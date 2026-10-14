namespace SpecialFeatures.Clone_Configuration.Common
{
    using Motorola.CommonCPS.Server.EntityModel;
    using System;

    public class CompatibilityChecks
    {
        private CodeplugData a;
        private CodeplugData b;
        private bool c;

        public CompatibilityChecks(APXTemplate srcData, APXCodeplug targetData, string targetModelNumber);
        internal CompatibilityChecks(string srcUsedFlashcode, string srcPurchasedFlashcode, string radioFlashcode, string srcModelNumber, string radioModelNumber);
        private void a(APXTemplate A_0, APXCodeplug A_1, string A_2);
        private void a(string A_0, string A_1, string A_2, string A_3, string A_4);
        public bool PerfomChecks(ref string stsErrorMsg);
    }
}

