namespace SpecialFeatures.ReadWriteTlsPsk
{
    using Motorola.Common.Communication.CommonUtil;
    using Motorola.Common.Communication.Service;
    using SpecialFeatures.ReadWritePassword;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class TlsPskHandler : IDisposable
    {
        private readonly ReadWritePasswordApp a;

        public TlsPskHandler(ReadWritePasswordApp readWritePasswordApp);
        private bool a(DeviceInfo A_0, IDeviceDiscovery A_1, out string A_2);
        public void Dispose();
        public void HandlePsk(IDeviceDiscovery deviceDiscovery, DeviceInfo deviceInfo, out string psk);

        [CompilerGenerated]
        private sealed class <>c__DisplayClass2_0
        {
            public PromptReadWritePassword promptPassword;
            public bool isPasswordRemembered;

            public <>c__DisplayClass2_0();
            internal bool <HandlePsk>b__0();
        }
    }
}

