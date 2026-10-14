namespace SpecialFeatures.Comms
{
    using System;
    using System.Runtime.CompilerServices;

    public static class CloneParameters
    {
        [CompilerGenerated]
        private static COMMS_OP a;
        [CompilerGenerated]
        private static object b;
        [CompilerGenerated]
        private static bool c;

        public static COMMS_OP CloneWriteType { get; set; }

        public static object LastCloneOTAPUserState { get; set; }

        public static bool BlockNewSystemCheck { get; set; }
    }
}

