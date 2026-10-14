namespace SpecialFeatures.ReadWritePassword
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Windows;

    public class ReadWritePasswordApp : IDisposable
    {
        private static ReadWritePasswordApp a;
        private readonly ReadWriteUtil b;
        private bool c;
        private bool d;
        private SecureString e;
        [CompilerGenerated]
        private bool f;
        [CompilerGenerated]
        private bool g;

        private ReadWritePasswordApp();
        private bool a(string A_0, string A_1, ReadWritePasswordApp.ValidType A_2);
        private bool b(string A_0, string A_1, ReadWritePasswordApp.ValidType A_2);
        public void ClearCachedPasswordValidation();
        public void Dispose();
        public static ReadWritePasswordApp GetInstance();
        internal PromptReadWritePassword ShowPopup(string radioIdentifier, string dialogMessage);
        public void ShowReadWritePasswordWindow();
        public bool ValidateOKToArchiveFile(string codeplugPassword);
        public bool ValidateOKToReadWrite(Window win, string codeplugPassword, string serialNumber, ReadWritePasswordApp.ValidType validType);
        public bool ValidateOKToUserPassword(string userPassword, string codeplugPassword, string serialNumber);

        public bool IsPasswordStoredForCurrentSession { get; set; }

        public string ReadWritePassword { get; set; }

        internal bool IsPasswordValidatedForCurrentInteraction { get; set; }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass25_0
        {
            public PromptReadWritePassword promptPassword;
            public string radioIdentifier;
            public string dialogMessage;

            public <>c__DisplayClass25_0();
            internal void <ShowPopup>b__0();
        }

        private delegate bool ValidateOKDelegate(string codeplugPassword, string serialNumber, ReadWritePasswordApp.ValidType validType);

        public enum ValidType
        {
            Read,
            Write,
            File
        }
    }
}

