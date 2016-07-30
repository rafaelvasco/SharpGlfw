namespace SharpGlfw
{
    public static partial class Glfw
    {
        public static void CenterWindow(GlfwWindow window)
        {
            int windowW, windowH;

            GetWindowSize(window, out windowW, out windowH);

            GlfwVidMode mode = GetVideoMode(GetPrimaryMonitor());

            int desktopW = mode.Width;
            int desktopH = mode.Height;

            SetWindowPos(window, desktopW / 2 - windowW / 2, desktopH / 2 - windowH / 2);
        }

        public static GlfwWindow CreateWindow(int width, int height, string title)
        {
            return GlfwCore.glfwCreateWindow(width, height, title, GlfwMonitor.Null, GlfwWindow.Null);
        }

        public static GlfwWindow CreateWindow()
        {
            GlfwVidMode videoMode = GetVideoMode(GetPrimaryMonitor());

            WindowHint(WindowAttrib.Decorated, 0);
            WindowHint(WindowAttrib.Resizable, 0);

            return GlfwCore.glfwCreateWindow(videoMode.Width, videoMode.Height, string.Empty, GlfwMonitor.Null, GlfwWindow.Null);
        }
    }
}
