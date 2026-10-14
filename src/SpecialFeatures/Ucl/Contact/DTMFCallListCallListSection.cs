namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class DTMFCallListCallListSection : FeatureSection
    {
        private AcpField<string> systemGroupNumber;
        private AcpField<string> primaryID;
        private AcpKeyField combinedID;
        private AcpField<bool> isHotListItem;

        internal DTMFCallListCallListSection(FeatureNode parent);
        internal DTMFCallListCallListSection(SerializationInfo info, StreamingContext context);
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

        public string PrimaryID { get; set; }

        public AcpField<string> PrimaryIDObject { get; }

        public bool PrimaryID_Applicable { get; set; }

        public bool PrimaryID_Editable { get; set; }

        public bool PrimaryID_Visible { get; set; }

        public bool PrimaryID_Valid { get; set; }

        public string CombinedID { get; set; }

        public AcpKeyField CombinedIDObject { get; }

        internal string CombinedID_UILabel { get; }

        public bool CombinedID_Applicable { get; set; }

        public bool CombinedID_Editable { get; set; }

        public bool CombinedID_Visible { get; set; }

        internal bool CombinedID_HiddenStatic { get; set; }

        public bool CombinedID_Valid { get; set; }

        public AcpField<bool> IsHotListItemObject { get; }

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

