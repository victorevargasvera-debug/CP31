namespace SpecialFeatures.Clone_Configuration.Common
{
    using Motorola.CommonCPS.Server.EntityModel;
    using System;
    using System.Collections.Generic;

    public class CodeplugData
    {
        public string purchasedFlashcode;
        public string usedFlashcode;
        public string modelNumber;
        public List<AstroRecSetCountsItem> recSetCounts;
        public APXCodeplug _data;

        public CodeplugData();
    }
}

