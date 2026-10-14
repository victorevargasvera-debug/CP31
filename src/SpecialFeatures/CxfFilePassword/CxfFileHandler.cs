namespace SpecialFeatures.CxfFilePassword
{
    using CodeplugExchangeLibrary;
    using SpecialFeatures.CxfFilePassword.Models;
    using SpecialFeatures.CxfFilePassword.View;
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    public static class CxfFileHandler
    {
        public static SecureString currentlyOpenedCxfFilePass;
        private static SecureString a;

        private static bool a(CxfFileInitializePasswordPromptResult A_0);
        private static void a(CxfFilePasswordPromptResult A_0);
        private static CxfFileInitializePasswordPromptResult a(bool A_0);
        private static bool a(SecureString A_0);
        private static CxfFilePasswordPromptResult a(string A_0);
        public static SecureString InitializePassword(bool isCxfEditingMode);
        public static bool OpenCodeplugFile(byte[] codeplugBytes);
        public static CodeplugExchangeFile OpenFileAndValidatePassword(string filePath);
        public static bool SaveCodeplugFile(string filePath, SecureString filePassword, string modelNumber, string codeplugVersion);

        [CompilerGenerated]
        private sealed class <>c__DisplayClass6_0
        {
            public CxfFilePasswordPrompt prompt;

            public <>c__DisplayClass6_0();
            internal void <ShowPasswordPopup>b__0(object _, EventArgs _);
            internal void <ShowPasswordPopup>b__1();
        }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass7_0
        {
            public CxfFileInitializePasswordPrompt prompt;

            public <>c__DisplayClass7_0();
            internal void <ShowInitializePasswordPopup>b__0(object _, EventArgs _);
            internal void <ShowInitializePasswordPopup>b__1();
        }
    }
}

