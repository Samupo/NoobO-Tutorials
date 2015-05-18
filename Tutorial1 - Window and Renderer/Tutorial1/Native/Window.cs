using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.Native
{
    // S6.- Now that we have SDL coded, we will start coding the Window class.
    // We could have several windows laying around, but for this engine we
    // will stick to just one, which is referenced in the SDL class with an
    // static property.
    class Window
    {
        // Since SDL works internally with pointers we have to
        // store it's internal pointer to memory
        internal IntPtr Pointer { get; private set; }
        // Window flags for initializing a window
        private enum WindowFlags
        {
            SDL_WINDOW_FULLSCREEN = 0x00000001,
            SDL_WINDOW_OPENGL = 0x00000002,
            SDL_WINDOW_SHOWN = 0x00000004,
            SDL_WINDOW_HIDDEN = 0x00000008,
            SDL_WINDOW_BORDERLESS = 0x00000010,
            SDL_WINDOW_RESIZABLE = 0x00000020,
            SDL_WINDOW_MINIMIZED = 0x00000040,
            SDL_WINDOW_MAXIMIZED = 0x00000080,
            SDL_WINDOW_INPUT_GRABBED = 0x00000100,
            SDL_WINDOW_INPUT_FOCUS = 0x00000200,
            SDL_WINDOW_MOUSE_FOCUS = 0x00000400,
            SDL_WINDOW_FULLSCREEN_DESKTOP =
            (SDL_WINDOW_FULLSCREEN | 0x00001000),
            SDL_WINDOW_FOREIGN = 0x00000800,
            SDL_WINDOW_ALLOW_HIGHDPI = 0x00002000
        }

        // We don't want anyone to create windows outside our engine
        // So we make the constructor internal
        internal Window()
        {
            // We use SDL to create a Window, we have to specify the name here
            // We are also using OpenGL and establishing the window should be shown as it is created
            Pointer = SDL_CreateWindow("Tutorial1", 100, 100, 640, 480, (UInt32)(WindowFlags.SDL_WINDOW_OPENGL | WindowFlags.SDL_WINDOW_SHOWN));
        }

        #region NATIVE CODE
        // S7.- Now we add SDL code here, note that since the function needs a string
        // we have to cast from C#'s string to C's char* with Ethan Lee's marshaler
        [DllImport(SDL.NATIVELIB, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr SDL_CreateWindow([In()] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(LPUtf8StrMarshaler))] string title, int x, int y, int w, int h, UInt32 flags);
        #endregion
    }
}
