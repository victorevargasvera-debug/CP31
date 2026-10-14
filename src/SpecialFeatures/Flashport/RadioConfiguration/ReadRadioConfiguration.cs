namespace SpecialFeatures.Flashport.RadioConfiguration
{
    using Motorola.Common.Communication.Pba;
    using SpecialFeatures.Comms;
    using System;

    public class ReadRadioConfiguration : IDisposable
    {
        private RadioConfigurationRecset a;
        private IDeviceProxy b;
        private const int c = 0x385;

        public ReadRadioConfiguration();
        private void a();
        private string a(byte[] A_0);
        private byte[] a(PbaObject A_0);
        private void a(bool A_0);
        private void b();
        public void Dispose();
        protected override void Finalize();
        public bool ReadRadio();

        public RadioConfigurationRecset RadioRecset { get; }
    }
}

