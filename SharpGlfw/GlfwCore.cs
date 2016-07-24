using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SharpGlfw
{
    static unsafe class GlfwCore
    {
        private const string GLFW_DLL = "glfw3.dll";

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwInit();

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwTerminate();

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetVersion(out int major, out int minor, out int rev);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern sbyte* glfwGetVersionString();

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwErrorCallback glfwSetErrorCallback(GlfwErrorCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwMonitor* glfwGetMonitors(out int count);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwMonitor glfwGetPrimaryMonitor();

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetMonitorPos(GlfwMonitor monitor, out int xpos, out int ypos);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetMonitorPhysicalSize(GlfwMonitor monitor, out int width, out int height);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern sbyte* glfwGetMonitorName(GlfwMonitor monitor);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwMonitorCallback glfwSetMonitorCallback(GlfwWindow window, GlfwMonitorCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwVidMode* glfwGetVideoModes(GlfwMonitor monitor, out int count);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwVidMode* glfwGetVideoMode(GlfwMonitor monitor);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetGamma(GlfwMonitor monitor, float gamma);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetGammaRamp(GlfwMonitor monitor, out GlfwGammaRampInternal ramp);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetGammaRamp(GlfwMonitor monitor, ref GlfwGammaRamp ramp);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwDefaultWindowHints();

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwWindowHint(int target, int hint);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwWindow glfwCreateWindow(int width, int height,
            [MarshalAs(UnmanagedType.LPStr)] string title, GlfwMonitor monitor, GlfwWindow share);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwDestroyWindow(GlfwWindow window);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwWindowShouldClose(GlfwWindow window);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowShouldClose(GlfwWindow window, int value);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowTitle(GlfwWindow window, [MarshalAs(UnmanagedType.LPStr)] string title);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowIcon(GlfwWindow window, int count, GlfwImage[] images);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetWindowPos(GlfwWindow window, out int xpos, out int ypos);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowPos(GlfwWindow window, int xpos, int ypos);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetWindowSize(GlfwWindow window, out int width, out int height);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowSizeLimits(GlfwWindow window, int minWidth, int minHeight, int maxWidth,
            int maxHeight);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowAspectRatio(GlfwWindow window, int numerator, int denominator);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowSize(GlfwWindow window, int width, int height);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetFramebufferSize(GlfwWindow window, out int width, out int height);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetWindowFrameSize(GlfwWindow window, out int left, out int top, out int right,
            out int bottom);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwIconifyWindow(GlfwWindow window);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwRestoreWindow(GlfwWindow window);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwMaximizeWindow(GlfwWindow window);


        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwShowWindow(GlfwWindow window);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwHideWindow(GlfwWindow window);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwFocusWindow(GlfwWindow window);


        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwMonitor glfwGetWindowMonitor(GlfwWindow window);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowMonitor(GlfwWindow window, GlfwMonitor monitor, int xpos, int ypos,
            int width, int height, int refreshRate);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwGetWindowAttrib(GlfwWindow window, int param);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetWindowUserPointer(GlfwWindow window, IntPtr pointer);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern IntPtr glfwGetWindowUserPointer(GlfwWindow window);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwWindowPosCallback glfwSetWindowPosCallback(GlfwWindow window,
            GlfwWindowPosCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwWindowSizeCallback glfwSetWindowSizeCallback(GlfwWindow window,
            GlfwWindowSizeCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwWindowCloseCallback glfwSetWindowCloseCallback(GlfwWindow window,
            GlfwWindowCloseCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwWindowRefreshCallback glfwSetWindowRefreshCallback(GlfwWindow window,
            GlfwWindowRefreshCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwWindowFocusCallback glfwSetWindowFocusCallback(GlfwWindow window,
            GlfwWindowFocusCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwWindowIconifyCallback glfwSetWindowIconifyCallback(GlfwWindow window,
            GlfwWindowIconifyCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwFramebufferSizeCallback glfwSetFramebufferSizeCallback(GlfwWindow window,
            GlfwFramebufferSizeCallback cbfun);


        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwPollEvents();

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwWaitEvents();

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwWaitEventsTimeout(double timeout);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwPostEmptyEvent();


        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwGetInputMode(GlfwWindow window, InputMode mode);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetInputMode(GlfwWindow window, InputMode mode, CursorMode value);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern sbyte* glfwGetKeyName(int key, int scanCode);


        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwGetKey(GlfwWindow window, Key key);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwGetMouseButton(GlfwWindow window, MouseButton button);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwGetCursorPos(GlfwWindow window, out double xpos, out double ypos);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetCursorPos(GlfwWindow window, double xpos, double ypos);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwCursor glfwCreateCursor(GlfwImage image, int xhot, int yhot);


        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwCursor glfwCreateStandardCursor(CursorType shape);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwDestroyCursor(GlfwCursor cursor);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetCursor(GlfwWindow window, GlfwCursor cursor);


        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwKeyCallback glfwSetKeyCallback(GlfwWindow window, GlfwKeyCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwCharCallback glfwSetCharCallback(GlfwWindow window, GlfwCharCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwCharModifiersCallback gflwSetCharModsCallback(GlfwWindow window,
            GlfwCharModifiersCallback cbfun);


        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwMouseButtonCallback glfwSetMouseButtonCallback(GlfwWindow window,
            GlfwMouseButtonCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwCursorPosCallback glfwSetCursorPosCallback(GlfwWindow window,
            GlfwCursorPosCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwCursorEnterCallback glfwSetCursorEnterCallback(GlfwWindow window,
            GlfwCursorEnterCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwScrollCallback glfwSetScrollCallback(GlfwWindow window, GlfwScrollCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwDropCallback glfwSetDropCallback(GlfwWindow window, GlfwDropCallback cbfun);


        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwJoystickPresent(Joystick joy);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern float* glfwGetJoystickAxes(Joystick joy, out int numaxes);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern byte* glfwGetJoystickButtons(Joystick joy, out int numbuttons);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern sbyte* glfwGetJoystickName(Joystick joy);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwJoystickCallback glfwSetJoystickCallback(GlfwJoystickCallback cbfun);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetClipboardString(GlfwWindow window,
            [MarshalAs(UnmanagedType.LPStr)] string @string);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern sbyte* glfwGetClipboardString(GlfwWindow window);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern double glfwGetTime();

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSetTime(double time);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern ulong glfwGetTimerValue();

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern ulong glfwGetTimerFrequency();

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwMakeContextCurrent(GlfwWindow window);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern GlfwWindow glfwGetCurrentContext();

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSwapBuffers(GlfwWindow window);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern void glfwSwapInterval(int interval);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern int glfwExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);

        [DllImport(GLFW_DLL), SuppressUnmanagedCodeSecurity]
        internal static extern IntPtr glfwGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);

        //TODO: Bind Vulkan Methods
    }
}