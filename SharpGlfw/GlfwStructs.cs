using System;
using System.Runtime.InteropServices;

namespace SharpGlfw
{
    [StructLayout(LayoutKind.Explicit)]
    public struct GlfwMonitor
    {
        private GlfwMonitor(IntPtr ptr)
        {
            innerPtr = ptr;
        }

        [FieldOffsetAttribute(0)]
        private readonly IntPtr innerPtr;

        public static readonly GlfwMonitor Null = new GlfwMonitor(IntPtr.Zero);
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GlfwWindow
    {
        private GlfwWindow(IntPtr ptr)
        {
            innerPtr = ptr;
        }

        [FieldOffset(0)]
        private readonly IntPtr innerPtr;

        public static readonly GlfwWindow Null = new GlfwWindow(IntPtr.Zero);
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GlfwCursor
    {
        private GlfwCursor(IntPtr ptr)
        {
            innerPtr = ptr;
        }
        
        [FieldOffset(0)]
        private readonly IntPtr innerPtr;

        public static readonly GlfwCursor Null = new GlfwCursor(IntPtr.Zero);
    }

    [StructLayout(LayoutKind.Explicit, Size = sizeof(int) * 6)]
    public struct GlfwVidMode
    {
        [FieldOffset(sizeof(int) * 0)]
        public int Width;

        [FieldOffset(sizeof(int) * 1)]
        public int Height;

        [FieldOffset(sizeof(int) * 2)]
        public int RedBits;

        [FieldOffset(sizeof(int) * 3)]
        public int BlueBits;

        [FieldOffset(sizeof(int) * 4)]
        public int GreenBits;

        [FieldOffset(sizeof(int) * 5)]
        public int RefreshRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GlfwGammaRamp
    {
        [MarshalAs(UnmanagedType.LPArray)]
        public uint[] Red;

        [MarshalAs(UnmanagedType.LPArray)]
        public uint[] Green;

        [MarshalAs(UnmanagedType.LPArray)]
        public uint[] Blue;

        internal uint Length;
    }

    public struct GlfwImage
    {
        public int width;

        public int height;

        public byte[] pixels;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct GlfwGammaRampInternal
    {
        public uint* Red;
        public uint* Green;
        public uint* Blue;
        public uint Length;
    }




}
