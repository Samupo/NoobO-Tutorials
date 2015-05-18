using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.Native
{
    // S8.- Now for the Renderer class. SDL has two ways of rendering 2D images to the screen: using
    // surfaces and using textures. Surfaces are software accelerated while textures are hardware
    // accelerated so we will be using textures because of that
    class Renderer
    {
        // As with the Window, we also need a pointer
        internal IntPtr Pointer { get; private set; }
        // This are the renderer initialization flags
        private enum RendererFlags
        {
            SDL_RENDERER_SOFTWARE = 0x00000001,
            SDL_RENDERER_ACCELERATED = 0x00000002,
            SDL_RENDERER_PRESENTVSYNC = 0x00000004,
            SDL_RENDERER_TARGETTEXTURE = 0x00000008
        }

        // We will make the constructor internal, no need to have several renderers
        internal Renderer(Window window)
        {
            // We create the renderer given the window pointer. We use -1 to make SDL do the work for us.
            // And we configure it to be hardware accelerated.
            Pointer = SDL_CreateRenderer(window.Pointer, -1, (UInt32)RendererFlags.SDL_RENDERER_ACCELERATED);
        }

        // Render function
        internal void Render()
        {
            // Render to screen this renderer
            SDL_RenderPresent(Pointer);
        }

        #region NATIVE CODE
        // This function makes a renderer draw its content to its assigned target (a Window by default)
        [DllImport(SDL.NATIVELIB, CallingConvention = CallingConvention.Cdecl)]
        private static extern void SDL_RenderPresent(IntPtr renderer);

        // Renderers can be created assigned to Windows
        [DllImport(SDL.NATIVELIB, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr SDL_CreateRenderer(IntPtr window, int index, UInt32 flags);
        #endregion
    }
}
