using System;

namespace SharpGlfw
{
    /// <summary>
    /// C# Glfw3 Bindings
    /// 
    /// Version: 3.2
    ///
    /// </summary>
    /// 
    public static unsafe partial class Glfw
    {
#pragma warning disable 0414

        public static bool Init()
        {
            return GlfwCore.glfwInit() == 1;
        }

        public static void Terminate()
        {
            GlfwCore.glfwTerminate();
        }

        public static void GetVersion(out int major, out int minor, out int rev)
        {
            GlfwCore.glfwGetVersion(out major, out minor, out rev);
        }

        public static string GetVersionString()
        {
            return new string(GlfwCore.glfwGetVersionString());
        }

        private static GlfwErrorCallback errorCallback;

        public static GlfwErrorCallback SetErrorCallback(GlfwErrorCallback cbfun)
        {
            errorCallback = cbfun;
            return GlfwCore.glfwSetErrorCallback(cbfun);
        }

        public static GlfwMonitor[] GetMonitors()
        {
            int count;
            GlfwMonitor* array = GlfwCore.glfwGetMonitors(out count);
            GlfwMonitor[] result = new GlfwMonitor[count];
            for (int i = 0; i < count; ++i)
            {
                result[i] = array[i];
            }
            return result;
        }

        public static GlfwMonitor GetPrimaryMonitor()
        {
            return GlfwCore.glfwGetPrimaryMonitor();
        }

        public static void GetMonitorPos(GlfwMonitor monitor, out int xpos, out int ypos)
        {
            GlfwCore.glfwGetMonitorPos(monitor, out xpos, out ypos);
        }

        public static void GetMonitorPhysicalSize(GlfwMonitor monitor, out int width, out int height)
        {
            GlfwCore.glfwGetMonitorPhysicalSize(monitor, out width, out height);
        }

        public static string GetMonitorName(GlfwMonitor monitor)
        {
            return new string(GlfwCore.glfwGetMonitorName(monitor));
        }

        public static GlfwVidMode[] GetVideoModes(GlfwMonitor monitor)
        {
            int count;
            GlfwVidMode* array = GlfwCore.glfwGetVideoModes(monitor, out count);
            GlfwVidMode[] result = new GlfwVidMode[count];
            for (int i = 0; i < count; ++i)
            {
                result[i] = array[i];
            }
            return result;
        }

        public static GlfwVidMode GetVideoMode(GlfwMonitor monitor)
        {
            GlfwVidMode* vidMode = GlfwCore.glfwGetVideoMode(monitor);
            GlfwVidMode returnMode = new GlfwVidMode
            {
                RedBits = vidMode->RedBits,
                GreenBits = vidMode->GreenBits,
                BlueBits = vidMode->BlueBits,
                RefreshRate = vidMode->RefreshRate,
                Width = vidMode->Width,
                Height = vidMode->Height
            };
            return returnMode;
        }

        public static void SetGamma(GlfwMonitor monitor, float gamma)
        {
            GlfwCore.glfwSetGamma(monitor, gamma);
        }

        public static void GetGammaRamp(GlfwMonitor monitor, out GlfwGammaRamp ramp)
        {
            GlfwGammaRampInternal rampI;
            GlfwCore.glfwGetGammaRamp(monitor, out rampI);
            uint length = rampI.Length;
            ramp = new GlfwGammaRamp();
            ramp.Red = new uint[length];
            ramp.Green = new uint[length];
            ramp.Blue = new uint[length];
            for (int i = 0; i < ramp.Red.Length; ++i)
            {
                ramp.Red[i] = rampI.Red[i];
            }
            for (int i = 0; i < ramp.Green.Length; ++i)
            {
                ramp.Green[i] = rampI.Green[i];
            }
            for (int i = 0; i < ramp.Blue.Length; ++i)
            {
                ramp.Blue[i] = rampI.Blue[i];
            }
        }

        public static void SetGammaRamp(GlfwMonitor monitor, ref GlfwGammaRamp ramp)
        {
            ramp.Length = (uint) ramp.Red.Length;
            GlfwCore.glfwSetGammaRamp(monitor, ref ramp);
        }

        public static void DefaultWindowHints()
        {
            GlfwCore.glfwDefaultWindowHints();
        }

        public static void WindowHint(WindowHint target, int hint)
        {
            GlfwCore.glfwWindowHint((int) target, hint);
        }

        public static void WindowHint(WindowHint target, bool hint)
        {
            GlfwCore.glfwWindowHint((int) target, hint ? 1 : 0);
        }

        public static void WindowHint(WindowAttrib target, int hint)
        {
            GlfwCore.glfwWindowHint((int) target, hint);
        }

        public static void WindowHint(WindowAttrib target, bool hint)
        {
            GlfwCore.glfwWindowHint((int) target, hint ? 1 : 0);
        }

        public static GlfwWindow CreateWindow(int width, int height, string title, GlfwMonitor monitor, GlfwWindow share)
        {
            return GlfwCore.glfwCreateWindow(width, height, title, monitor, share);
        }

        public static void DestroyWindow(GlfwWindow window)
        {
            GlfwCore.glfwDestroyWindow(window);
        }

        public static bool WindowShouldClose(GlfwWindow window)
        {
            return GlfwCore.glfwWindowShouldClose(window) == 1;
        }

        public static void SetWindowShouldClose(GlfwWindow window, bool value)
        {
            GlfwCore.glfwSetWindowShouldClose(window, value ? 1 : 0);
        }

        public static void SetWindowTitle(GlfwWindow window, string title)
        {
            GlfwCore.glfwSetWindowTitle(window, title);
        }

        public static void SetWindowIcon(GlfwWindow window, int count, GlfwImage[] images)
        {
            GlfwCore.glfwSetWindowIcon(window, count, images);
        }

        public static void GetWindowPos(GlfwWindow window, out int xpos, out int ypos)
        {
            GlfwCore.glfwGetWindowPos(window, out xpos, out ypos);
        }

        public static void SetWindowPos(GlfwWindow window, int xpos, int ypos)
        {
            GlfwCore.glfwSetWindowPos(window, xpos, ypos);
        }

        public static void GetWindowSize(GlfwWindow window, out int width, out int height)
        {
            GlfwCore.glfwGetWindowSize(window, out width, out height);
        }

        public static void SetWindowSize(GlfwWindow window, int width, int height)
        {
            GlfwCore.glfwSetWindowSize(window, width, height);
        }

        public static void GetFramebufferSize(GlfwWindow window, out int width, out int height)
        {
            GlfwCore.glfwGetFramebufferSize(window, out width, out height);
        }

        public static void GetWindowFrameSize(GlfwWindow window, out int left, out int top, out int right,
            out int bottom)
        {
            GlfwCore.glfwGetWindowFrameSize(window, out left, out top, out right, out bottom);
        }


        public static void IconifyWindow(GlfwWindow window)
        {
            GlfwCore.glfwIconifyWindow(window);
        }

        public static void RestoreWindow(GlfwWindow window)
        {
            GlfwCore.glfwRestoreWindow(window);
        }

        public static void MaximizeWindow(GlfwWindow window)
        {
            GlfwCore.glfwMaximizeWindow(window);
        }

        public static void ShowWindow(GlfwWindow window)
        {
            GlfwCore.glfwShowWindow(window);
        }

        public static void HideWindow(GlfwWindow window)
        {
            GlfwCore.glfwHideWindow(window);
        }

        public static void FocusWindow(GlfwWindow window)
        {
            GlfwCore.glfwFocusWindow(window);
        }


        public static GlfwMonitor GetWindowMonitor(GlfwWindow window)
        {
            return GlfwCore.glfwGetWindowMonitor(window);
        }

        public static void SetWindowMonitor(GlfwWindow window, GlfwMonitor monitor, int xpos, int ypos, int width,
            int height, int refreshRate)
        {
            GlfwCore.glfwSetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);
        }

        public static int GetWindowAttrib(GlfwWindow window, WindowAttrib param)
        {
            return GlfwCore.glfwGetWindowAttrib(window, (int) param);
        }

        public static int GetWindowAttrib(GlfwWindow window, WindowHint param)
        {
            return GlfwCore.glfwGetWindowAttrib(window, (int) param);
        }

        public static void SetWindowUserPointer(GlfwWindow window, IntPtr pointer)
        {
            GlfwCore.glfwSetWindowUserPointer(window, pointer);
        }

        public static IntPtr GetWindowUserPointer(GlfwWindow window)
        {
            return GlfwCore.glfwGetWindowUserPointer(window);
        }

        private static GlfwWindowPosCallback windowPosFun;

        public static GlfwWindowPosCallback SetWindowPosCallback(GlfwWindow window, GlfwWindowPosCallback cbfun)
        {
            windowPosFun = cbfun;
            return GlfwCore.glfwSetWindowPosCallback(window, cbfun);
        }

        private static GlfwWindowSizeCallback windowSizeFun;

        public static GlfwWindowSizeCallback SetWindowSizeCallback(GlfwWindow window, GlfwWindowSizeCallback cbfun)
        {
            windowSizeFun = cbfun;
            return GlfwCore.glfwSetWindowSizeCallback(window, cbfun);
        }

        private static GlfwWindowCloseCallback windowCloseFun;

        public static GlfwWindowCloseCallback SetWindowCloseCallback(GlfwWindow window, GlfwWindowCloseCallback cbfun)
        {
            windowCloseFun = cbfun;
            return GlfwCore.glfwSetWindowCloseCallback(window, cbfun);
        }

        private static GlfwWindowRefreshCallback windowRefreshFun;

        public static GlfwWindowRefreshCallback SetWindowRefreshCallback(GlfwWindow window,
            GlfwWindowRefreshCallback cbfun)
        {
            windowRefreshFun = cbfun;
            return GlfwCore.glfwSetWindowRefreshCallback(window, cbfun);
        }

        private static GlfwWindowFocusCallback windowFocusFun;

        public static GlfwWindowFocusCallback SetWindowFocusCallback(GlfwWindow window, GlfwWindowFocusCallback cbfun)
        {
            windowFocusFun = cbfun;
            return GlfwCore.glfwSetWindowFocusCallback(window, cbfun);
        }

        private static GlfwWindowIconifyCallback windowIconifyFun;

        public static GlfwWindowIconifyCallback SetWindowIconifyCallback(GlfwWindow window,
            GlfwWindowIconifyCallback cbfun)
        {
            windowIconifyFun = cbfun;
            return GlfwCore.glfwSetWindowIconifyCallback(window, cbfun);
        }

        private static GlfwFramebufferSizeCallback frameBfSizeFun;

        public static GlfwFramebufferSizeCallback SetFramebufferSizeCallback(GlfwWindow window,
            GlfwFramebufferSizeCallback cbfun)
        {
            frameBfSizeFun = cbfun;
            return GlfwCore.glfwSetFramebufferSizeCallback(window, cbfun);
        }

        public static void PollEvents()
        {
            GlfwCore.glfwPollEvents();
        }

        public static void WaitEvents()
        {
            GlfwCore.glfwWaitEvents();
        }

        public static void WaitEventsTimeout(double timeout)
        {
            GlfwCore.glfwWaitEventsTimeout(timeout);
        }

        public static void PostEmptyEvent()
        {
            GlfwCore.glfwPostEmptyEvent();
        }


        public static int GetInputMode(GlfwWindow window, InputMode mode)
        {
            return GlfwCore.glfwGetInputMode(window, mode);
        }

        public static void SetInputMode(GlfwWindow window, InputMode mode, CursorMode value)
        {
            GlfwCore.glfwSetInputMode(window, mode, value);
        }

        public static string GetKeyName(int key, int scanCode)
        {
            return new string(GlfwCore.glfwGetKeyName(key, scanCode));
        }

        public static bool GetKey(GlfwWindow window, Key key)
        {
            return GlfwCore.glfwGetKey(window, key) != 0;
        }

        public static bool GetMouseButton(GlfwWindow window, MouseButton button)
        {
            return GlfwCore.glfwGetMouseButton(window, button) != 0;
        }

        public static void GetCursorPos(GlfwWindow window, out double xpos, out double ypos)
        {
            GlfwCore.glfwGetCursorPos(window, out xpos, out ypos);
        }

        public static void SetCursorPos(GlfwWindow window, double xpos, double ypos)
        {
            GlfwCore.glfwSetCursorPos(window, xpos, ypos);
        }

        public static GlfwCursor CreateCursor(GlfwImage image, int xhot, int yhot)
        {
            return GlfwCore.glfwCreateCursor(image, xhot, yhot);
        }

        public static GlfwCursor CreateStandardCursor(CursorType type)
        {
            return GlfwCore.glfwCreateStandardCursor(type);
        }

        public static void DestroyCursor(GlfwCursor cursor)
        {
            GlfwCore.glfwDestroyCursor(cursor);
        }

        public static void SetCursor(GlfwWindow window, GlfwCursor cursor)
        {
            GlfwCore.glfwSetCursor(window, cursor);
        }

        private static GlfwKeyCallback keyFun;

        public static GlfwKeyCallback SetKeyCallback(GlfwWindow window, GlfwKeyCallback cbfun)
        {
            keyFun = cbfun;
            return GlfwCore.glfwSetKeyCallback(window, cbfun);
        }

        private static GlfwCharCallback charFun;

        public static GlfwCharCallback SetCharCallback(GlfwWindow window, GlfwCharCallback cbfun)
        {
            charFun = cbfun;
            return GlfwCore.glfwSetCharCallback(window, cbfun);
        }

        private static GlfwCharModifiersCallback charModsFun;

        public static GlfwCharModifiersCallback SetCharModifiersCallback(GlfwWindow window,
            GlfwCharModifiersCallback cbfun)
        {
            charModsFun = cbfun;
            return GlfwCore.gflwSetCharModsCallback(window, cbfun);
        }


        private static GlfwMouseButtonCallback mouseButtonFun;

        public static GlfwMouseButtonCallback SetMouseButtonCallback(GlfwWindow window, GlfwMouseButtonCallback cbfun)
        {
            mouseButtonFun = cbfun;
            return GlfwCore.glfwSetMouseButtonCallback(window, cbfun);
        }

        private static GlfwCursorPosCallback cursorPosFun;

        public static GlfwCursorPosCallback SetCursorPosCallback(GlfwWindow window, GlfwCursorPosCallback cbfun)
        {
            cursorPosFun = cbfun;
            return GlfwCore.glfwSetCursorPosCallback(window, cbfun);
        }

        private static GlfwCursorEnterCallback cursorEnterFun;

        public static GlfwCursorEnterCallback SetCursorEnterCallback(GlfwWindow window, GlfwCursorEnterCallback cbfun)
        {
            cursorEnterFun = cbfun;
            return GlfwCore.glfwSetCursorEnterCallback(window, cbfun);
        }

        private static GlfwScrollCallback scrollFun;

        public static GlfwScrollCallback SetScrollCallback(GlfwWindow window, GlfwScrollCallback cbfun)
        {
            scrollFun = cbfun;
            return GlfwCore.glfwSetScrollCallback(window, cbfun);
        }

        private static GlfwDropCallback dropFun;

        public static GlfwDropCallback SetDropCallback(GlfwWindow window, GlfwDropCallback cbfun)
        {
            dropFun = cbfun;
            return GlfwCore.glfwSetDropCallback(window, cbfun);
        }

        public static bool JoystickPresent(Joystick joy)
        {
            return GlfwCore.glfwJoystickPresent(joy) == 1;
        }

        public static float[] GetJoystickAxes(Joystick joy)
        {
            int numaxes;
            float* axes = GlfwCore.glfwGetJoystickAxes(joy, out numaxes);
            float[] result = new float[numaxes];
            for (int i = 0; i < numaxes; ++i)
            {
                result[i] = axes[i];
            }
            return result;
        }

        public static byte[] GetJoystickButtons(Joystick joy)
        {
            int numbuttons;
            byte* buttons = GlfwCore.glfwGetJoystickButtons(joy, out numbuttons);
            byte[] result = new byte[numbuttons];
            for (int i = 0; i < numbuttons; ++i)
            {
                result[i] = buttons[i];
            }
            return result;
        }

        public static string GetJoystickName(Joystick joy)
        {
            return new string(GlfwCore.glfwGetJoystickName(joy));
        }

        private static GlfwJoystickCallback joyFun;

        public static GlfwJoystickCallback SetJoystickCallback(GlfwJoystickCallback cbfun)
        {
            joyFun = cbfun;
            return GlfwCore.glfwSetJoystickCallback(cbfun);
        }


        public static void SetClipboardString(GlfwWindow window, string @string)
        {
            GlfwCore.glfwSetClipboardString(window, @string);
        }

        public static string GetClipboardString(GlfwWindow window)
        {
            return new string(GlfwCore.glfwGetClipboardString(window));
        }

        public static double GetTime()
        {
            return GlfwCore.glfwGetTime();
        }

        public static void SetTime(double time)
        {
            GlfwCore.glfwSetTime(time);
        }

        public static ulong GetTimerValue()
        {
            return GlfwCore.glfwGetTimerValue();
        }

        public static ulong GetTimerFrequency()
        {
            return GlfwCore.glfwGetTimerFrequency();
        }


        public static void MakeContextCurrent(GlfwWindow window)
        {
            GlfwCore.glfwMakeContextCurrent(window);
        }

        public static GlfwWindow GetCurrentContext()
        {
            return GlfwCore.glfwGetCurrentContext();
        }

        public static void SwapBuffers(GlfwWindow window)
        {
            GlfwCore.glfwSwapBuffers(window);
        }

        public static void SwapInterval(int interval)
        {
            GlfwCore.glfwSwapInterval(interval);
        }

        public static bool ExtensionSupported(string extension)
        {
            return GlfwCore.glfwExtensionSupported(extension) == 1;
        }

        public static IntPtr GetProcAddress(string procname)
        {
            return GlfwCore.glfwGetProcAddress(procname);
        }

        //TODO: Put Vulkan Methods

#pragma warning restore 0414
    }
}
