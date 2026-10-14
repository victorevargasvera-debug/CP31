namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    [Serializable]
    public class QCIICallList : FeatureNode, IAcpFeatureNodeCallList
    {
        [CompilerGenerated]
        private int <HotlistParentRecsetId>k__BackingField;
        [CompilerGenerated]
        private int <HotlistParentSectionId>k__BackingField;
        [CompilerGenerated]
        private int <HotlistRecsetId>k__BackingField;
        [CompilerGenerated]
        private int <HotlistSectionId>k__BackingField;
        [CompilerGenerated]
        private int <CalllistContactAliasSectionId>k__BackingField;
        [CompilerGenerated]
        private string <CalllistContactAlias>k__BackingField;
        [CompilerGenerated]
        private string <HotlistContactAlias>k__BackingField;
        [CompilerGenerated]
        private string <HotlistContactCallId>k__BackingField;

        private QCIICallList();
        internal QCIICallList(Recordset parent);
        protected QCIICallList(SerializationInfo info, StreamingContext context);
        public override void GetObjectData(SerializationInfo info, StreamingContext context);

        public override string ReferenceKey { get; }

        internal QCIICallListCallListSection CallListQCII { get; }

        public int HotlistParentRecsetId { get; set; }

        public int HotlistParentSectionId { get; set; }

        public int HotlistRecsetId { get; set; }

        public int HotlistSectionId { get; set; }

        public int CalllistContactAliasSectionId { get; set; }

        public string CalllistContactAlias { get; set; }

        public string HotlistContactAlias { get; set; }

        public string HotlistContactCallId { get; set; }
    }
}

