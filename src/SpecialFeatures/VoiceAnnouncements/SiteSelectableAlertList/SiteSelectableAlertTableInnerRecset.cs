namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class SiteSelectableAlertTableInnerRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;
        public int _DynMax;
        public static int _Min;
        public static int _DefaultRecordCount;

        static SiteSelectableAlertTableInnerRecset();
        public SiteSelectableAlertTableInnerRecset();
        protected SiteSelectableAlertTableInnerRecset(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();
        internal void SetValues();

        public override int MaxPool { get; }

        public override int Max { get; set; }

        public override int Min { get; }

        public override int DefaultRecordCount { get; set; }

        public bool HasDiffs { get; }
    }
}

