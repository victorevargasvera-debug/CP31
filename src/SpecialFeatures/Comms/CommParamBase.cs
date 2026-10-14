namespace SpecialFeatures.Comms
{
    using System;
    using System.Runtime.CompilerServices;

    public class CommParamBase
    {
        [CompilerGenerated]
        private int a;
        [CompilerGenerated]
        private int b;

        public CommParamBase();

        internal int CommReceiveTimeout { get; set; }

        internal int CommSendTimeout { get; set; }
    }
}

