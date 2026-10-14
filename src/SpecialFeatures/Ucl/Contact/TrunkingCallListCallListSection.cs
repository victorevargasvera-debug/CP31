namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Windows.Data;

    [Serializable]
    public sealed class TrunkingCallListCallListSection : FeatureSection
    {
        private AcpRecRefField uclAstro25Trk_SystemAlias_A00010;
        private AcpPointerField<int> uclAstro25Trk_HomeSystemID_A00012;
        private AcpPointerField<int> uclAstro25Trk_WACNID_A00011;
        private AcpCustomRangeField uclAstro25Trk_IndividualID_A00013;
        private AcpKeyField uclAstro25Trk_CombinedID_A00014;
        private AcpRangeField<int, int> uclAstro25Trk_CustomizedWACNID_A00015;
        private AcpRangeField<int, int> uclAstro25Trk_CustomizedHomeSystemID_A00016;
        private AcpField<bool> isHotListItem;

        internal TrunkingCallListCallListSection(FeatureNode parent);
        internal TrunkingCallListCallListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public void ResolveReferenceAfterUnpack();
        public override void SetConstraints();
        public override void SetupDependencies();

        public bool HasDiffs { get; }

        public int UclAstro25Trk_SystemAlias_A00010Value { get; set; }

        public AcpRecRefField UclAstro25Trk_SystemAlias_A00010Object { get; set; }

        public string UclAstro25Trk_SystemAlias_A00010_UIValue { get; set; }

        public bool UclAstro25Trk_SystemAlias_A00010_Applicable { get; set; }

        public bool UclAstro25Trk_SystemAlias_A00010_Editable { get; set; }

        public bool UclAstro25Trk_SystemAlias_A00010_Visible { get; set; }

        public bool UclAstro25Trk_SystemAlias_A00010_Valid { get; set; }

        public bool UclAstro25Trk_SystemAlias_A00010_HasDiffs { get; }

        public int UclAstro25Trk_HomeSystemID_A00012Value { get; }

        public AcpPointerField<int> UclAstro25Trk_HomeSystemID_A00012Object { get; }

        public string UclAstro25Trk_HomeSystemID_A00012_UIValue { get; set; }

        public bool UclAstro25Trk_HomeSystemID_A00012_Applicable { get; set; }

        public bool UclAstro25Trk_HomeSystemID_A00012_Editable { get; set; }

        public bool UclAstro25Trk_HomeSystemID_A00012_Visible { get; set; }

        public bool UclAstro25Trk_HomeSystemID_A00012_Valid { get; set; }

        public bool UclAstro25Trk_HomeSystemID_A00012_HasDiffs { get; }

        public int UclAstro25Trk_WACNID_A00011Value { get; }

        public AcpPointerField<int> UclAstro25Trk_WACNID_A00011Object { get; }

        public string UclAstro25Trk_WACNID_A00011_UIValue { get; set; }

        public bool UclAstro25Trk_WACNID_A00011_Applicable { get; set; }

        public bool UclAstro25Trk_WACNID_A00011_Editable { get; set; }

        public bool UclAstro25Trk_WACNID_A00011_Visible { get; set; }

        public bool UclAstro25Trk_WACNID_A00011_Valid { get; set; }

        internal bool UclAstro25Trk_WACNID_A00011_HasDiffs { get; }

        public int UclAstro25Trk_IndividualID_A00013Value { get; set; }

        public AcpCustomRangeField UclAstro25Trk_IndividualID_A00013Object { get; }

        public string UclAstro25Trk_IndividualID_A00013_UIValue { get; set; }

        public bool UclAstro25Trk_IndividualID_A00013_Applicable { get; set; }

        public bool UclAstro25Trk_IndividualID_A00013_Editable { get; set; }

        public bool UclAstro25Trk_IndividualID_A00013_Visible { get; set; }

        public bool UclAstro25Trk_IndividualID_A00013_Valid { get; set; }

        internal bool UclAstro25Trk_IndividualID_A00013_HiddenStatic { get; set; }

        public bool UclAstro25Trk_IndividualID_A00013_HasDiffs { get; }

        public string UclAstro25Trk_CombinedID_A00014Value { get; set; }

        public AcpKeyField UclAstro25Trk_CombinedID_A00014Object { get; }

        public string UclAstro25Trk_CombinedID_A00014_UILabel { get; }

        public bool UclAstro25Trk_CombinedID_A00014_Applicable { get; set; }

        public bool UclAstro25Trk_CombinedID_A00014_Editable { get; set; }

        public bool UclAstro25Trk_CombinedID_A00014_Visible { get; set; }

        internal bool UclAstro25Trk_CombinedID_A00014_HiddenStatic { get; set; }

        public bool UclAstro25Trk_CombinedID_A00014_Valid { get; set; }

        public bool UclAstro25Trk_CombinedID_A00014_HasDiffs { get; }

        public int UclAstro25Trk_CustomizedWACNID_A00015Value { get; set; }

        public AcpRangeField<int, int> UclAstro25Trk_CustomizedWACNID_A00015Object { get; }

        public int UclAstro25Trk_CustomizedWACNID_A00015_UIValue { get; set; }

        public string UclAstro25Trk_CustomizedWACNID_A00015_HexUIValue { get; set; }

        internal int UclAstro25Trk_CustomizedWACNID_A00015Min { get; set; }

        internal int UclAstro25Trk_CustomizedWACNID_A00015Max { get; set; }

        internal int UclAstro25Trk_CustomizedWACNID_A00015Step { get; set; }

        public bool UclAstro25Trk_CustomizedWACNID_A00015_Applicable { get; set; }

        public bool UclAstro25Trk_CustomizedWACNID_A00015_Valid { get; set; }

        public bool UclAstro25Trk_CustomizedWACNID_A00015_Visible { get; set; }

        public bool UclAstro25Trk_CustomizedWACNID_A00015_Editable { get; set; }

        internal string UclAstro25Trk_CustomizedWACNID_A00015_UILabel { get; }

        internal bool UclAstro25Trk_CustomizedWACNID_A00015_HiddenStatic { get; set; }

        internal bool UclAstro25Trk_CustomizedWACNID_A00015_HiddenDynamic { get; set; }

        public bool UclAstro25Trk_CustomizedWACNID_A00015_HasDiffs { get; }

        public int UclAstro25Trk_CustomizedHomeSystemID_A00016Value { get; set; }

        public AcpRangeField<int, int> UclAstro25Trk_CustomizedHomeSystemID_A00016Object { get; }

        public int UclAstro25Trk_CustomizedHomeSystemID_A00016_UIValue { get; set; }

        public string UclAstro25Trk_CustomizedHomeSystemID_A00016_HexUIValue { get; set; }

        internal int UclAstro25Trk_CustomizedHomeSystemID_A00016Min { get; set; }

        internal int UclAstro25Trk_CustomizedHomeSystemID_A00016Max { get; set; }

        internal int UclAstro25Trk_CustomizedHomeSystemID_A00016Step { get; set; }

        public bool UclAstro25Trk_CustomizedHomeSystemID_A00016_Applicable { get; set; }

        public bool UclAstro25Trk_CustomizedHomeSystemID_A00016_Valid { get; set; }

        public bool UclAstro25Trk_CustomizedHomeSystemID_A00016_Visible { get; set; }

        public bool UclAstro25Trk_CustomizedHomeSystemID_A00016_Editable { get; set; }

        internal string UclAstro25Trk_CustomizedHomeSystemID_A00016_UILabel { get; }

        internal bool UclAstro25Trk_CustomizedHomeSystemID_A00016_HiddenStatic { get; set; }

        internal bool UclAstro25Trk_CustomizedHomeSystemID_A00016_HiddenDynamic { get; set; }

        public bool UclAstro25Trk_CustomizedHomeSystemID_A00016_HasDiffs { get; }

        public bool IsHotListItem { get; set; }

        [Browsable(false)]
        public bool IsHotListItem_Applicable { get; set; }

        [Browsable(false)]
        public bool IsHotListItem_Editable { get; set; }

        [Browsable(false)]
        public bool IsHotListItem_Visible { get; set; }

        [Browsable(false)]
        public bool IsHotListItem_Valid { get; set; }

        public Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem TrkSysGeneralSystemType_A9252 { get; }

        internal class UnassignedConverter : IValueConverter
        {
            public UnassignedConverter();
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
        }
    }
}

