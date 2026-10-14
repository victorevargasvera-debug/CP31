namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class QCIICallListCallListSection : FeatureSection
    {
        private AcpField<string> systemGroupNumber;
        private AcpField<string> callFormat;
        private AcpField<string> toneAFreq;
        private AcpField<string> toneBFreq;
        private AcpKeyField combinedID;
        private AcpField<bool> isHotListItem;

        internal QCIICallListCallListSection(FeatureNode parent);
        internal QCIICallListCallListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public string SystemGroupNumber { get; set; }

        public AcpField<string> SystemGroupNumberObject { get; }

        public bool SystemGroupNumber_Applicable { get; set; }

        public bool SystemGroupNumber_Editable { get; set; }

        public bool SystemGroupNumber_Visible { get; set; }

        public bool SystemGroupNumber_Valid { get; set; }

        public string CallFormat { get; set; }

        public AcpField<string> CallFormatObject { get; }

        public bool CallFormat_Applicable { get; set; }

        public bool CallFormat_Editable { get; set; }

        public bool CallFormat_Visible { get; set; }

        public bool CallFormat_Valid { get; set; }

        public string ToneAFreq { get; set; }

        public AcpField<string> ToneAFreqObject { get; }

        public bool ToneAFreq_Applicable { get; set; }

        public bool ToneAFreq_Editable { get; set; }

        public bool ToneAFreq_Visible { get; set; }

        public bool ToneAFreq_Valid { get; set; }

        public string ToneBFreq { get; set; }

        public AcpField<string> ToneBFreqObject { get; }

        public bool ToneBFreq_Applicable { get; set; }

        public bool ToneBFreq_Editable { get; set; }

        public bool ToneBFreq_Visible { get; set; }

        public bool ToneBFreq_Valid { get; set; }

        public string CombinedID { get; set; }

        public AcpKeyField CombinedIDObject { get; }

        public string CombinedID_UILabel { get; }

        public bool CombinedID_Applicable { get; set; }

        public bool CombinedID_Editable { get; set; }

        public bool CombinedID_Visible { get; set; }

        internal bool CombinedID_HiddenStatic { get; set; }

        public bool CombinedID_Valid { get; set; }

        public bool IsHotListItem { get; set; }

        [Browsable(false)]
        public bool IsHotListItem_Applicable { get; set; }

        [Browsable(false)]
        public bool IsHotListItem_Editable { get; set; }

        [Browsable(false)]
        public bool IsHotListItem_Visible { get; set; }

        [Browsable(false)]
        public bool IsHotListItem_Valid { get; set; }
    }
}

