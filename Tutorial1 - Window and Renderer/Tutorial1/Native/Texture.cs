using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.Native
{
    // Texture flip
    [Flags]
    public enum Flip
    {
        /// <summary>
        /// Not flipped
        /// </summary>
        NONE = 0x00000000,
        /// <summary>
        /// Flipped horizontally
        /// </summary>
        HORIZONTAL = 0x00000001,
        /// <summary>
        /// Flipped vertically
        /// </summary>
        VERTICAL = 0x00000002
    }

    // S10.- What are going to draw? Textures! So let's create a class for them too.
    class Texture
    {
        // For every SDL "class" we have to store it's pointer
        internal IntPtr Pointer { get; private set; }

        // We will be creating textures from files. Note: in SDL you should use / instead of \
        public Texture(string file)
        {
            // We first load the image, which will give us a surface
            IntPtr surfacePointer = IMG_Load(file);
            // We create the texture from that surface
            Pointer = SDL_CreateTextureFromSurface(SDL.Renderer.Pointer, surfacePointer);
            // And we free the memory that surface was using since we don't need it anymore
            SDL_FreeSurface(surfacePointer);
        }

        // We have to free memory manually so a nice (not the best) way to do this is using
        // the destructor. When the texture is no longer referenced we will destroy it (which
        // conviniently frees the memory)
        ~Texture()
        {
            // Destruction :D
            SDL_DestroyTexutre(Pointer);
        }

        // We will be using several functions to draw our textures. This is just a basic one,
        // we will cover more in later tutorials
        public void Draw(Rect srcRect, Rect dstRect)
        {
            // We use IntPtr.Zero which acts as a NULL to make the rotation center of the texture
            // correspond to the center of the texture
            SDL_RenderCopyEx(SDL.Renderer.Pointer, Pointer, ref srcRect, ref dstRect, 0, IntPtr.Zero, (UInt32)Flip.NONE);
        }

        #region NATIVE CODE
        // We can implement this function in several ways, which we might cover later if needed
        [DllImport(SDL.NATIVELIB, CallingConvention = CallingConvention.Cdecl)]
        private static extern int SDL_RenderCopyEx(IntPtr renderer, IntPtr texture, ref Rect srcrect, ref Rect dstrect, double angle, IntPtr center, UInt32 flip);

        // Load images as surfaces
        [DllImport(SDL.IMGLIB, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr IMG_Load([In()] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(LPUtf8StrMarshaler))] string file);

        // Free surfaces
        [DllImport(SDL.NATIVELIB, CallingConvention = CallingConvention.Cdecl)]
        private static extern void SDL_FreeSurface(IntPtr surface);

        // Destroy textures
        [DllImport(SDL.NATIVELIB, CallingConvention = CallingConvention.Cdecl)]
        private static extern void SDL_DestroyTexutre(IntPtr surface);

        // Create textures from surfaces
        [DllImport(SDL.NATIVELIB, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr SDL_CreateTextureFromSurface(IntPtr renderer, IntPtr surface);
        #endregion
    }
}
