namespace SpecialFeatures.Security
{
    using System;

    public class TrkSysBandPlan
    {
        private int a;
        private int b;
        private bool c;

        public TrkSysBandPlan(int sysType, int sysId, bool shuffledBandPlan);

        internal int SystemType { get; }

        internal int SystemId { get; }

        internal bool ShuffledBandPlan { get; }
    }
}

