namespace SpecialFeatures.Flashport.FlashRadio
{
    using AcpASKLib;
    using System;

    public class OwnerSystemData
    {
        private int a;
        private KeyType b;

        public OwnerSystemData(int ownerID, KeyType ownerType);

        internal int OwnerSystemID { get; }

        internal KeyType OwnerSystemType { get; }
    }
}

