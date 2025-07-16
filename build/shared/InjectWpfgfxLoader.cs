using System;
using System.IO;
using System.Runtime.InteropServices;

static class WpfgfxLoader
{
    [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Unicode)]
    private static extern IntPtr LoadLibrary(string lpFileName);

    static WpfgfxLoader()
    {
        string exeDir = AppDomain.CurrentDomain.BaseDirectory;
        string dllPath = Path.Combine(exeDir, "wpfgfx_cor3.dll");
        if (File.Exists(dllPath))
        {
            LoadLibrary(dllPath);
        }
    }

    // Force static constructor to run
    public static void EnsureLoaded() { }
}
