namespace SpecialFeatures.Flashport.FlashRadio
{
    using Motorola.CommonCPS.RadioManagement.SharedServices;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class FlashCodeplug
    {
        [CompilerGenerated]
        private HOptionAdvancedKeyIDS a;

        public FlashCodeplug();
        private OwnerSystemData a();
        public void postCodeplugInitialization();
        internal void ResolveUCLReferenceAfterUnpack();
        public void SetPostFlashCodeplugFields(string ibtnSerialNumber);
        internal void UpdateFlashcode(string currFlashcode, ref string newFlashcode, string strOpt, bool bAdd);
        public bool UpgradeCodeplug(string modelNumber, string flashcode, bool IsModelNumberUpgrade, bool updateASK, OwnerSystemData ownerSystemData);

        public HOptionAdvancedKeyIDS keyIDS { get; private set; }

        public delegate OwnerSystemData MainUIDisplayOwnerSysID();
    }
}

