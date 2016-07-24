using System.Runtime.InteropServices;

namespace SharpGlfw
{
    public delegate void GlfwErrorCallback(GlfwError code, [MarshalAs(UnmanagedType.LPStr)] string desc);

    public delegate void GlfwWindowPosCallback(GlfwWindow wnd, int x, int y);

    public delegate void GlfwWindowSizeCallback(GlfwWindow wnd, int width, int height);

    public delegate void GlfwWindowCloseCallback(GlfwWindow wnd);

    public delegate void GlfwWindowRefreshCallback(GlfwWindow wnd);

    public delegate void GlfwWindowFocusCallback(GlfwWindow wnd, bool focus);

    public delegate void GlfwWindowIconifyCallback(GlfwWindow wnd, bool iconify);

    public delegate void GlfwFramebufferSizeCallback(GlfwWindow wnd, int width, int height);

    public delegate void GlfwMouseButtonCallback(GlfwWindow wnd, MouseButton btn, KeyAction action);

    public delegate void GlfwCursorPosCallback(GlfwWindow wnd, double x, double y);

    public delegate void GlfwCursorEnterCallback(GlfwWindow wnd, bool enter);

    public delegate void GlfwScrollCallback(GlfwWindow wnd, double xoffset, double yoffset);

    public delegate void GlfwKeyCallback(GlfwWindow wnd, Key key, int scanCode, KeyAction action, KeyModifiers modifiers);

    public delegate void GlfwCharCallback(GlfwWindow wnd, char ch);

    public delegate void GlfwCharModifiersCallback(GlfwWindow wnd, char ch, KeyModifiers modifiers);

    public delegate void GlfwDropCallback(
        GlfwWindow wnd, int numberFiles,
        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] filePaths);

    public delegate void GlfwMonitorCallback(GlfwMonitor mtor, ConnectionState @enum);

    public delegate void GlfwJoystickCallback(int joystickIndex, ConnectionState connectionState);



}
