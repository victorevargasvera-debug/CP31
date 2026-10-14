namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class SiteSelectableAlertListRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;
        public int _DynMax;
        public static int _Min;

        static SiteSelectableAlertListRecset();
        public SiteSelectableAlertListRecset();
        protected SiteSelectableAlertListRecset(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();
        internal void SetValues();

        public override int MaxPool { get; }

        public override int Max { get; set; }

        public bool HasDiffs { get; }

        public override int Min { get; }
    }
}

