
namespace CSharpLibDev.WinAPI;

public static class Shell32
{
    [DllImport("shell32.dll", EntryPoint = "#62", CharSet = CharSet.Unicode, SetLastError = true)]
    [SuppressUnmanagedCodeSecurity]
    public static extern bool SHPickIconDialog(IntPtr hWnd, StringBuilder pszFilename, int cchFilenameMax, out int pnIconIndex);
}
