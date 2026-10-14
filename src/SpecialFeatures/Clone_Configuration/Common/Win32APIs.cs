namespace SpecialFeatures.Clone_Configuration.Common
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;

    public static class Win32APIs
    {
        private const uint a = 0;
        private const uint b = 1;
        private const uint c = 0;
        private const uint d = 0xf060;

        public static void EnableCloseMenuItem(IntPtr hwnd, bool bEnable);

        [SuppressUnmanagedCodeSecurity]
        internal static class SafeNativeMethods
        {
            [DllImport("user32.dll")]
            internal static extern bool EnableMenuItem(IntPtr hMenuItem, uint uItemID, uint uEnable);
            [DllImport("user32.dll")]
            internal static extern IntPtr GetSystemMenu(IntPtr hwnd, bool bRevert);
        }
    }
}

