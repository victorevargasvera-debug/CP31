namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
    using SpecialFeatures.Flashport;
    using System;

    public sealed class General : FeatureSection
    {
        private Field a;
        private Field b;
        private Field c;
        private Field d;
        private Field e;
        private Field f;
        private Field g;

        internal General(FeatureNode parent);
        private void a();
        public override void Init();

        public string FkeyConfigFactoryOrderNumberValue { get; set; }

        public Field FkeyConfigFactoryOrderNumber { get; }

        public bool FkeyConfigFactoryOrderNumber_Applicable { get; }

        public bool FkeyConfigFactoryOrderNumber_Valid { get; }

        public bool FkeyConfigFactoryOrderNumber_Visible { get; set; }

        public bool FkeyConfigFactoryOrderNumber_Editable { get; }

        public string FkeyConfigFactoryOrderNumber_UILabel { get; }

        public string FkeyConfigCurrentModelNumberValue { get; set; }

        public Field FkeyConfigCurrentModelNumber { get; }

        public bool FkeyConfigCurrentModelNumber_Applicable { get; }

        public bool FkeyConfigCurrentModelNumber_Valid { get; }

        public bool FkeyConfigCurrentModelNumber_Visible { get; set; }

        public bool FkeyConfigCurrentModelNumber_Editable { get; }

        public string FkeyConfigCurrentModelNumber_UILabel { get; }

        public string FkeyConfigNewModelNumberValue { get; set; }

        public Field FkeyConfigNewModelNumber { get; }

        public bool FkeyConfigNewModelNumber_Applicable { get; }

        public bool FkeyConfigNewModelNumber_Valid { get; }

        public bool FkeyConfigNewModelNumber_Visible { get; set; }

        public bool FkeyConfigNewModelNumber_Editable { get; }

        public string FkeyConfigNewModelNumber_UILabel { get; }

        public string FkeyConfigCurrentFlashcodeValue { get; set; }

        public Field FkeyConfigCurrentFlashcode { get; }

        public bool FkeyConfigCurrentFlashcode_Applicable { get; }

        public bool FkeyConfigCurrentFlashcode_Valid { get; }

        public bool FkeyConfigCurrentFlashcode_Visible { get; set; }

        public bool FkeyConfigCurrentFlashcode_Editable { get; }

        public string FkeyConfigCurrentFlashcode_UILabel { get; }

        public string FkeyConfigNewFlashcodeValue { get; set; }

        public Field FkeyConfigNewFlashcode { get; }

        public bool FkeyConfigNewFlashcode_Applicable { get; }

        public bool FkeyConfigNewFlashcode_Valid { get; }

        public bool FkeyConfigNewFlashcode_Visible { get; set; }

        public bool FkeyConfigNewFlashcode_Editable { get; }

        public string FkeyConfigNewFlashcode_UILabel { get; }

        public string FkeyConfigUpgradesPurchasedValue { get; set; }

        public Field FkeyConfigUpgradesPurchased { get; }

        public bool FkeyConfigUpgradesPurchased_Applicable { get; }

        public bool FkeyConfigUpgradesPurchased_Valid { get; }

        public bool FkeyConfigUpgradesPurchased_Visible { get; set; }

        public bool FkeyConfigUpgradesPurchased_Editable { get; }

        public string FkeyConfigUpgradesPurchased_UILabel { get; }

        public string FkeyConfigUpgradesRemainingValue { get; set; }

        public Field FkeyConfigUpgradesRemaining { get; }

        public bool FkeyConfigUpgradesRemaining_Applicable { get; }

        public bool FkeyConfigUpgradesRemaining_Valid { get; }

        public bool FkeyConfigUpgradesRemaining_Visible { get; set; }

        public bool FkeyConfigUpgradesRemaining_Editable { get; }

        public string FkeyConfigUpgradesRemaining_UILabel { get; }
    }
}

