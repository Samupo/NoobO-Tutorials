using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.Native
{
    // S0.- Create class SDL. We will be creating it abstract to avoid several instances of SDL running at the
    // same time.
    abstract class SDL
    {
        // S1.- We create references to the libraries we will be using. Note that all required dlls have to be
        // in the same folder as the executable so copy them to bin\Debug and/or bin\Release.
        internal const string NATIVELIB = "SDL2.dll";
        internal const string IMGLIB = "SDL2_image.dll";
        internal const string TTFLIB = "SDL2_ttf.dll";
        internal const string MIXLIB = "SDL2_mixer.dll";

        internal enum Initializers
        {
            SDL_INIT_TIMER = 0x00000001,
            SDL_INIT_AUDIO = 0x00000010,
            SDL_INIT_VIDEO = 0x00000020,
            SDL_INIT_JOYSTICK = 0x00000200,
            SDL_INIT_HAPTIC = 0x00001000,
            SDL_INIT_GAMECONTROLLER = 0x00002000,
            SDL_INIT_NOPARACHUTE = 0x00100000,
            SDL_INIT_EVERYTHING = SDL_INIT_TIMER | SDL_INIT_AUDIO | SDL_INIT_VIDEO | SDL_INIT_JOYSTICK | SDL_INIT_HAPTIC | SDL_INIT_GAMECONTROLLER
        }

        internal enum ImageMode
        {
            IMG_INIT_JPG = 0x00000001,
            IMG_INIT_PNG = 0x00000002,
            IMG_INIT_TIF = 0x00000004,
            IMG_INIT_WEBP = 0x00000008
        }

        public static Window Window { get; private set; }
        public static Renderer Renderer { get; private set; }

        // S5.- Now we create the SDL initializer method, from which we will establish a Window
        // and a Renderer (we will create those classes later).
        public static void Initialize()
        {
            // SDL initialization
            if (SDL_Init((UInt32)Initializers.SDL_INIT_EVERYTHING) == 0)
            {
                // IMG initialization, we will use this to load images other than BMPs
                if (IMG_Init((UInt32)(ImageMode.IMG_INIT_PNG | ImageMode.IMG_INIT_JPG)) == (UInt32)(ImageMode.IMG_INIT_PNG | ImageMode.IMG_INIT_JPG))
                {
                    // If all is correct we create a Window
                    Window = new Window();
                    // and a renderer attached to that window
                    Renderer = new Renderer(Window);

                    // DEBUG CODE
                    Texture texture = new Texture("data/img.png");
                    // END DEBUG CODE

                    // This is the main game loop
                    while (true)
                    {
                        // We create a reference to an event that we will be overriding
                        // with data each frame
                        SDL_Event eventData;
                        // Get all the events to parse them (which we will cover in
                        // a later tutorial)
                        while (SDL_PollEvent(out eventData) != 0)
                        {
                            // Parse events
                        }

                        // DEBUG CODE
                        Rect srcRect = new Rect(0, 0, 800, 600);
                        Rect dstRect = new Rect(0, 0, 640, 480);
                        texture.Draw(srcRect, dstRect);
                        // END DEBUG CODE

                        // Render the scene using the Renderer
                        Renderer.Render();

                        // Wait some time, just because we don't want our CPU
                        // to work more than it should
                        SDL_Delay(100);
                    }
                }
                else
                {
                    // IMG error
                    Console.WriteLine("Error while loading image module.");
                }
            }
            else
            {
                // In case of getting an error we write it
                Console.WriteLine(SDL_GetError());
            }
        }

        // S3.- Now let's create a region to insert our native code. We will need to use Ethan Lee's
        // LPUtf8StrMarshaler class, so go get it and thank him for his work.
        #region NATIVE CODE
        // S4.- Now we will be importing the SDL functionality, for that we can use SDL's wiki page
        // and adapt it as follows:

        // We need to specify in the DllImport attribute the dll we are accessing and the calling
        // convention (which will be Cdecl for SDL)
        // Whenever we encounter an enum we will be using an UInt32 instead, which functions in a
        // similar way internally
        [DllImport(IMGLIB, CallingConvention = CallingConvention.Cdecl)]
        private static extern int IMG_Init(UInt32 flags);

        [DllImport(NATIVELIB, CallingConvention = CallingConvention.Cdecl)]
        private static extern int SDL_Init(UInt32 flags);

        [DllImport(NATIVELIB, CallingConvention = CallingConvention.Cdecl)]
        // If we need to return a string we will have to add this line to cast from C's char* to C#'s string
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(LPUtf8StrMarshaler), MarshalCookie = LPUtf8StrMarshaler.LeaveAllocated)]
        private static extern string SDL_GetError();

        // For events we will be using again some Ethan Lee's code, in this case the struct SDL_Event but we
        // will make all public data internal to avoid showing back-end code to the people using our engine
        [DllImport(SDL.NATIVELIB, CallingConvention = CallingConvention.Cdecl)]
        private static extern int SDL_PollEvent(out SDL_Event _event);

        [DllImport(NATIVELIB, CallingConvention = CallingConvention.Cdecl)]
        private static extern void SDL_Delay(UInt32 ms);
        #endregion
    }
}
