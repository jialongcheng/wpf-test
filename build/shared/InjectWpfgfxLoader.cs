using System;
using System.IO;
using System.Runtime.InteropServices;

public static class WpfgfxLoader
{
    [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Unicode)]
    private static extern IntPtr LoadLibrary(string lpFileName);

    public static void Load()
    {
        string exeDir = AppDomain.CurrentDomain.BaseDirectory;
        string dllPath = Path.Combine(exeDir, "wpfgfx_cor3.dll");
        if (File.Exists(dllPath))
        {
            LoadLibrary(dllPath);
        }
    }
}
