namespace SpecialFeatures.PasswordResetFile
{
    using SpecialFeatures.Comms;
    using SpecialFeatures.Flashport.FlashRadio;
    using SpecialFeatures.ReadWritePassword;
    using System;
    using System.ComponentModel;

    internal class SendPasswordResetFileExecutor
    {
        private readonly BackgroundWorker a;
        private readonly ReadWritePasswordApp b;

        public SendPasswordResetFileExecutor(BackgroundWorker backgroundWorker, ReadWritePasswordApp readWritePasswordApp);
        private static IDeviceProxy a();
        private static RadioParams a(IDeviceProxy A_0);
        private static void a(RadioParams A_0);
        private static bool a(string A_0);
        private static bool a(IDeviceProxy A_0, byte[] A_1);
        private void a(int A_0, RadioInfoParams A_1);
        private static byte[] a(string A_0, RadioParams A_1);
        private void a(int A_0, UserState A_1, UserState A_2, string A_3);
        public void SendPasswordResetFile(string passwordResetFilePath);
    }
}

