namespace SpecialFeatures.Programming
{
    using System;
    using System.Threading;

    public sealed class DeviceOperationInProgressWindow : IDisposable
    {
        private DeviceOpStatusWindow a;
        private EventWaitHandle b;
        private bool c;
        private string d;

        public DeviceOperationInProgressWindow();
        private void a();
        private void a(bool A_0);
        public void CloseWindow();
        public void Dispose();
        public void ShowWindow(string message);
    }
}

