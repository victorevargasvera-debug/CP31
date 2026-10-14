namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using SpecialFeatures.Ucl.Contact;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class DTMFCallHotListHotListSection : FeatureSection
    {
        private AcpRecRefField contactAlias;
        private AcpRecRefField callID;

        internal DTMFCallHotListHotListSection(FeatureNode parent);
        internal DTMFCallHotListHotListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public int ContactAlias { get; set; }

        public AcpRecRefField ContactAliasObject { get; set; }

        public string ContactAlias_UIValue { get; set; }

        public bool ContactAlias_Applicable { get; set; }

        public bool ContactAlias_Editable { get; set; }

        public bool ContactAlias_Visible { get; set; }

        public bool ContactAlias_Valid { get; set; }

        public int CallID { get; set; }

        public AcpRecRefField CallIDObject { get; set; }

        public string CallID_UIValue { get; set; }

        public bool CallID_Applicable { get; set; }

        public bool CallID_Editable { get; set; }

        public bool CallID_Visible { get; set; }

        public bool CallID_Valid { get; set; }

        public UclContact Contact { get; }
    }
}

