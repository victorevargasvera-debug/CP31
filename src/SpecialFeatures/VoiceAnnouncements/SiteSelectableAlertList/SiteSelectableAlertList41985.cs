namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public class SiteSelectableAlertList41985 : FeatureSection, ISerializable
    {
        private SiteSelectableAlertTableInnerRecset innerRecset;
        private AcpKeyField siteSelectableAlertListAlias_A41993;
        private AcpListField siteSelectableAlertListConfigurationType_A42058;

        public SiteSelectableAlertList41985(FeatureNode parent);
        protected SiteSelectableAlertList41985(SerializationInfo info, StreamingContext context);
        private IAcpRecordset a(int A_0);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public bool HasDiffs { get; }

        public string SiteSelectableAlertListAlias_A41993Value { get; set; }

        public string SiteSelectableAlertListAlias_A41993_UIValue { get; set; }

        public AcpKeyField SiteSelectableAlertListAlias_A41993 { get; }

        public bool SiteSelectableAlertListAlias_A41993_Applicable { get; set; }

        public bool SiteSelectableAlertListAlias_A41993_Valid { get; set; }

        public bool SiteSelectableAlertListAlias_A41993_Visible { get; set; }

        public bool SiteSelectableAlertListAlias_A41993_Editable { get; set; }

        internal string SiteSelectableAlertListAlias_A41993_UILabel { get; }

        internal bool SiteSelectableAlertListAlias_A41993_HiddenStatic { get; set; }

        internal bool SiteSelectableAlertListAlias_A41993_HiddenDynamic { get; set; }

        public bool SiteSelectableAlertListAlias_A41993_HasDiffs { get; }

        public int SiteSelectableAlertListConfigurationType_A42058Value { get; set; }

        public string SiteSelectableAlertListConfigurationType_A42058_UIValue { get; set; }

        public AcpListField SiteSelectableAlertListConfigurationType_A42058 { get; }

        public bool SiteSelectableAlertListConfigurationType_A42058_Applicable { get; set; }

        public bool SiteSelectableAlertListConfigurationType_A42058_Valid { get; set; }

        public bool SiteSelectableAlertListConfigurationType_A42058_Visible { get; set; }

        public bool SiteSelectableAlertListConfigurationType_A42058_Editable { get; set; }

        internal string SiteSelectableAlertListConfigurationType_A42058_UILabel { get; }

        internal bool SiteSelectableAlertListConfigurationType_A42058_HiddenStatic { get; set; }

        internal bool SiteSelectableAlertListConfigurationType_A42058_HiddenDynamic { get; set; }

        public bool SiteSelectableAlertListConfigurationType_A42058_HasDiffs { get; }
    }
}

