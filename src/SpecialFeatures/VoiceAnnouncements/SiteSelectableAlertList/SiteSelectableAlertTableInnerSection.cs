namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public class SiteSelectableAlertTableInnerSection : FeatureSection, ISerializable
    {
        private AcpKeyField sSAFrontDisplayAlertAlias_A41987;
        private AcpRecRefField sSAAlertFile_A41990;
        private AcpSimpleRangeField vASSAAlertPeriodSec_A41991;
        private AcpField<bool> vASSASubscriberEncodable_A41992;

        public SiteSelectableAlertTableInnerSection(FeatureNode parent);
        protected SiteSelectableAlertTableInnerSection(SerializationInfo info, StreamingContext context);
        private IAcpRecordset a(int A_0);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public bool HasDiffs { get; }

        public string SSAFrontDisplayAlertAlias_A41987Value { get; set; }

        public AcpKeyField SSAFrontDisplayAlertAlias_A41987 { get; }

        public string SSAFrontDisplayAlertAlias_A41987_UIValue { get; set; }

        public bool SSAFrontDisplayAlertAlias_A41987_Applicable { get; set; }

        public bool SSAFrontDisplayAlertAlias_A41987_Valid { get; set; }

        public bool SSAFrontDisplayAlertAlias_A41987_Visible { get; set; }

        public bool SSAFrontDisplayAlertAlias_A41987_Editable { get; set; }

        internal string SSAFrontDisplayAlertAlias_A41987_UILabel { get; }

        internal bool SSAFrontDisplayAlertAlias_A41987_HiddenStatic { get; set; }

        internal bool SSAFrontDisplayAlertAlias_A41987_HiddenDynamic { get; set; }

        public bool SSAFrontDisplayAlertAlias_A41987_HasDiffs { get; }

        public int SSAAlertFile_A41990Value { get; set; }

        public string SSAAlertFile_A41990_UIValue { get; set; }

        public AcpRecRefField SSAAlertFile_A41990 { get; }

        public bool SSAAlertFile_A41990_Applicable { get; set; }

        public bool SSAAlertFile_A41990_Valid { get; set; }

        public bool SSAAlertFile_A41990_Visible { get; set; }

        public bool SSAAlertFile_A41990_Editable { get; set; }

        internal string SSAAlertFile_A41990_UILabel { get; }

        internal bool SSAAlertFile_A41990_HiddenStatic { get; set; }

        internal bool SSAAlertFile_A41990_HiddenDynamic { get; set; }

        public bool SSAAlertFile_A41990_HasDiffs { get; }

        public int VASSAAlertPeriodSec_A41991Value { get; set; }

        public AcpSimpleRangeField VASSAAlertPeriodSec_A41991 { get; }

        public string VASSAAlertPeriodSec_A41991_UIValue { get; set; }

        internal int VASSAAlertPeriodSec_A41991Min { get; set; }

        internal int VASSAAlertPeriodSec_A41991Max { get; set; }

        internal int VASSAAlertPeriodSec_A41991Step { get; set; }

        public bool VASSAAlertPeriodSec_A41991_Applicable { get; set; }

        public bool VASSAAlertPeriodSec_A41991_Valid { get; set; }

        public bool VASSAAlertPeriodSec_A41991_Visible { get; set; }

        public bool VASSAAlertPeriodSec_A41991_Editable { get; set; }

        internal string VASSAAlertPeriodSec_A41991_UILabel { get; }

        internal bool VASSAAlertPeriodSec_A41991_HiddenStatic { get; set; }

        internal bool VASSAAlertPeriodSec_A41991_HiddenDynamic { get; set; }

        public bool VASSAAlertPeriodSec_A41991_HasDiffs { get; }

        public bool VASSASubscriberEncodable_A41992Value { get; set; }

        public AcpField<bool> VASSASubscriberEncodable_A41992 { get; }

        public bool VASSASubscriberEncodable_A41992_UIValue { get; set; }

        public bool VASSASubscriberEncodable_A41992_Applicable { get; set; }

        public bool VASSASubscriberEncodable_A41992_Valid { get; set; }

        public bool VASSASubscriberEncodable_A41992_Visible { get; set; }

        public bool VASSASubscriberEncodable_A41992_Editable { get; set; }

        internal string VASSASubscriberEncodable_A41992_UILabel { get; }

        internal bool VASSASubscriberEncodable_A41992_HiddenStatic { get; set; }

        internal bool VASSASubscriberEncodable_A41992_HiddenDynamic { get; set; }

        public bool VASSASubscriberEncodable_A41992_HasDiffs { get; }
    }
}

