namespace SpecialFeatures.Flashport.RadioConfiguration
{
    using SpecialFeatures.Flashport;
    using System;

    public sealed class General : FeatureSection
    {
        private Field a;
        private Field b;

        internal General(FeatureNode parent);
        private void a();
        public override void Init();

        public string RadioConfigCurrentModelNumberValue { get; set; }

        public Field RadioConfigCurrentModelNumber { get; }

        public bool RadioConfigCurrentModelNumber_Applicable { get; }

        public bool RadioConfigCurrentModelNumber_Valid { get; }

        public bool RadioConfigCurrentModelNumber_Visible { get; set; }

        public bool RadioConfigCurrentModelNumber_Editable { get; }

        public string RadioConfigCurrentModelNumber_UILabel { get; }

        public string RadioConfigCurrentFlashcodeValue { get; set; }

        public Field RadioConfigCurrentFlashcode { get; }

        public bool RadioConfigCurrentFlashcode_Applicable { get; }

        public bool RadioConfigCurrentFlashcode_Valid { get; }

        public bool RadioConfigCurrentFlashcode_Visible { get; set; }

        public bool RadioConfigCurrentFlashcode_Editable { get; }

        public string RadioConfigCurrentFlashcode_UILabel { get; }
    }
}

