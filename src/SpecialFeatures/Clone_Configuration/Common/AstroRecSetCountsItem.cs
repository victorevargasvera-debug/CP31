namespace SpecialFeatures.Clone_Configuration.Common
{
    using System;

    public class AstroRecSetCountsItem
    {
        public int _count;
        public int _maxPool;
        public int _counterToMaxPool;
        public int _recSetInstanceNo;
        public string _recSetName;

        public AstroRecSetCountsItem(string recsetName, int instance, int count, int maxpool, int countToMaxPool);
    }
}

