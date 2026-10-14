namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.CommonUtil;
    using System;
    using System.Runtime.CompilerServices;

    public class ProxyParameter
    {
        [CompilerGenerated]
        private SpecialFeatures.Comms.RadioParams a;
        [CompilerGenerated]
        private Motorola.Common.Communication.CommonUtil.RadioOperation b;
        [CompilerGenerated]
        private Motorola.Common.Communication.CommonUtil.AstroDeviceInfo c;
        [CompilerGenerated]
        private string d;

        public ProxyParameter();

        public SpecialFeatures.Comms.RadioParams RadioParams { get; set; }

        public Motorola.Common.Communication.CommonUtil.RadioOperation RadioOperation { get; set; }

        public Motorola.Common.Communication.CommonUtil.AstroDeviceInfo AstroDeviceInfo { get; set; }

        public string DeviceFile { get; set; }
    }
}

