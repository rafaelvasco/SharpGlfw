namespace SharpGlfw
{
    public enum KeyModifiers
    {
        Shift = 1 << 0,
        Control = 1 << 1,
        Alt = 1 << 2,
        Super = 1 << 3
    }

    public enum KeyAction
    {
        Release = 0,
        Press,
        Repeat
    }

    public enum Key
    {
        /* Printable Keys */
        Unknown = -1,
        Space = 32,
        Apostrophe = 39,
        Comma = 44,
        Minus,
        Period,
        Slash,
        Zero,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Semicolon = 59,
        Equal = 61,
        A = 65,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
        J,
        K,
        L,
        M,
        N,
        O,
        P,
        Q,
        R,
        S,
        T,
        U,
        V,
        W,
        X,
        Y,
        Z,
        LeftBracket,
        Backslash,
        RightBracket,
        GraveAccent = 96,
        World1 = 161,
        World2,

        /* Funcion Keys */

        Escape = 256,
        Enter,
        Tab,
        Backspace,
        Insert,
        Delete,
        Right,
        Left,
        Down,
        Up,
        PageUp,
        PageDown,
        Home,
        End,
        CapsLock = 280,
        ScrollLock,
        NumLock,
        PrintScreen,
        Pause,
        F1 = 290,
        F2,
        F3,
        F4,
        F5,
        F6,
        F7,
        F8,
        F9,
        F10,
        F11,
        F12,
        F13,
        F14,
        F15,
        F16,
        F17,
        F18,
        F19,
        F20,
        F21,
        F22,
        F23,
        F24,
        F25,
        KP0 = 320,
        KP1,
        KP2,
        KP3,
        KP4,
        KP5,
        KP6,
        KP7,
        KP8,
        KP9,
        KP_Decimal,
        KP_Divide,
        KP_Multiply,
        Kp_Subtract,
        KP_Add,
        KP_Enter,
        KP_Equal,
        LeftShift = 340,
        LeftControl,
        LeftAlt,
        LeftSuper,
        RightShift,
        RightControl,
        RightAlt,
        RightSuper,
        Menu

    }

    public enum Modifier
    {
        Shift = 0x0001,
        Control = 0x0002,
        Alt = 0x0004,
        Super = 0x0008
    }

    public enum MouseButton
    {
        Button1 = 0,
        Button2,
        Button3,
        Button4,
        Button5,
        Button6,
        Button7,
        Button8,
        LeftButton = Button1,
        RightButton = Button2,
        MiddleButton = Button3
    }

    public enum Joystick
    {
        Joystick1 = 0,
        Joystick2,
        Joystick3,
        Joystick4,
        Joystick5,
        Joystick6,
        Joystick7,
        Joystick8,
        Joystick9,
        Joystick10,
        Joystick11,
        Joystick12,
        Joystick13,
        Joystick14,
        Joystick15,
        Joystick16
    }

    public enum GlfwError
    {
        NotInitialized = 0x00010001,
        NoCurrentContext = 0x00010002,
        InvalidEnum = 0x00010003,
        InvalidValue = 0x00010004,
        OutOfMemory = 0x00010005,
        ApiUnavailable = 0x00010006,
        VersionUnavailable = 0x00010007,
        PlatformError = 0x00010008,
        FormatUnavailable = 0x00010009,
        NoWindowContext = 0x0001000A
    }

    public enum WindowAttrib
    {
        Focused = 0x20001,
        Iconified,
        Resizable,
        Visible,
        Decorated,
        AutoIconify,
        Floating,
        Maximized
    }

    public enum WindowHint
    {
        RedBits = 0x00021001,
        GreenBits,
        BlueBits,
        AlphaBits,
        DepthBits,
        StencilBits,
        AccumRedBits,
        AccumGreenBits,
        AccumBlueBits,
        AccumAlphaBits,
        AuxBuffers,
        Stereo,
        Samples,
        SRGB_Capable,
        RefreshRate,
        ClientAPI = 0x00022001,
        ContextVersionMajor,
        ContextVersionMinor,
        ContextRevision,
        ContextRobustness,
        OpenGLForwardCompat,
        OpenGLDebugContext,
        OpenGLProfile,
        ContextReleaseBehavior,
        ContextNoError = 0x0002200A,
        ContextCreationAPI

    }

    public enum OpenGLAPI
    {
        NoAPI = 0,
        OpenGLAPI = 0x00030001,
        OpenGLESAPI = 0x00030002
    }

    public enum ContextRobustness
    {
        NoRobustness = 0,
        NoResetNotification = 0x00031001,
        LoseContextOnReset
    }

    public enum OpenGLProfile
    {
        Any = 0,
        Core = 0x00032001,
        Compatibility = 0x00032002

    }

    public enum InputMode
    {
        CursorEnabled = 0x00033001,
        StickyKeys = 0x00033002,
        StickyMouseButtons = 0x00033003
    }

    public enum CursorMode
    {
        CursorNormal = 0x00034001,
        CursorHidden,
        CursorDisabled
    }

    public enum CursorType
    {
        Arrow = 0x00036001,
        IBeam,
        Crosshair,
        Hand,
        HResize,
        VResize

    }

    public enum ConnectionState
    {
        Connected = 0x00040001,
        Disconnected
    }

    public enum ReleaseBehavior
    {
        Any = 0,
        Flush = 0x00035001,
        None
    }

    public enum ContextAPI
    {
        Native = 0x00036001,
        EGL
    }

   

}
