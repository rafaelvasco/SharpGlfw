using System;

namespace SharpGlfw.Test
{
    class Program
    {
        

        static void Main()
        {

            if (!Glfw.Init())
            {
                Glfw.Terminate();
                throw new Exception("GLFW Failed to Initialize");
            }

            Glfw.WindowHint(WindowAttrib.Resizable, false);

            var window = Glfw.CreateWindow(1024, 768, "Test");

            if (window.Equals(GlfwWindow.Null))
            {
                Glfw.Terminate();
                throw new Exception("GLFW failed to create window");
            }

            Glfw.CenterWindow(window);

            Glfw.MakeContextCurrent(window);

            Glfw.SwapInterval(1);

            while (!Glfw.WindowShouldClose(window))
            {
                

                Glfw.PollEvents();

                if (Glfw.GetKey(window, Key.Escape))
                {
                    Glfw.SetWindowShouldClose(window, true);
                }

                Glfw.SwapBuffers(window);
            }

            Glfw.DestroyWindow(window);
            Glfw.Terminate();
        }
    }
}
