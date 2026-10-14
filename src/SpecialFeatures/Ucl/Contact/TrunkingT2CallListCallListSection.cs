namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Windows.Data;

    [Serializable]
    public sealed class TrunkingT2CallListCallListSection : FeatureSection
    {
        private AcpRecRefField uclT2Trk_SystemAlias_A00017;
        private AcpPointerField<int> uclT2Trk_SystemID_A00018;
        private AcpCustomRangeField uclT2Trk_IndividualID_A00019;
        private AcpKeyField uclT2Trk_CombinedID_A00020;
        private AcpRangeField<int, int> uclT2Trk_CustomizedSystemID_A00021;

        internal TrunkingT2CallListCallListSection(FeatureNode parent);
        internal TrunkingT2CallListCallListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public void ResolveReferenceAfterUnpack();
        public override void SetConstraints();
        public override void SetupDependencies();

        public bool HasDiffs { get; }

        public int UclT2Trk_SystemAlias_A00017Value { get; set; }

        public AcpRecRefField UclT2Trk_SystemAlias_A00017Object { get; }

        public string UclT2Trk_SystemAlias_A00017_UIValue { get; set; }

        public bool UclT2Trk_SystemAlias_A00017_Applicable { get; set; }

        public bool UclT2Trk_SystemAlias_A00017_Editable { get; set; }

        public bool UclT2Trk_SystemAlias_A00017_Visible { get; set; }

        public bool UclT2Trk_SystemAlias_A00017_Valid { get; set; }

        public bool UclT2Trk_SystemAlias_A00017_HasDiffs { get; }

        public int UclT2Trk_SystemID_A00018Value { get; }

        public AcpPointerField<int> UclT2Trk_SystemID_A00018Object { get; }

        public string UclT2Trk_SystemID_A00018_UIValue { get; set; }

        public bool UclT2Trk_SystemID_A00018_Applicable { get; set; }

        public bool UclT2Trk_SystemID_A00018_Editable { get; set; }

        public bool UclT2Trk_SystemID_A00018_Visible { get; set; }

        public bool UclT2Trk_SystemID_A00018_Valid { get; set; }

        public bool UclT2Trk_SystemID_A00018_HasDiffs { get; }

        public int UclT2Trk_IndividualID_A00019Value { get; set; }

        public AcpCustomRangeField UclT2Trk_IndividualID_A00019Object { get; }

        public string UclT2Trk_IndividualID_A00019_UIValue { get; set; }

        public bool UclT2Trk_IndividualID_A00019_Applicable { get; set; }

        public bool UclT2Trk_IndividualID_A00019_Editable { get; set; }

        public bool UclT2Trk_IndividualID_A00019_Visible { get; set; }

        public bool UclT2Trk_IndividualID_A00019_Valid { get; set; }

        internal bool UclT2Trk_IndividualID_A00019_HiddenStatic { get; set; }

        public bool UclT2Trk_IndividualID_A00019_HasDiffs { get; }

        public string UclT2Trk_CombinedID_A00020Value { get; set; }

        public AcpKeyField UclT2Trk_CombinedID_A00020Object { get; }

        internal string UclT2Trk_CombinedID_A00020_UILabel { get; }

        public bool UclT2Trk_CombinedID_A00020_Applicable { get; set; }

        public bool UclT2Trk_CombinedID_A00020_Editable { get; set; }

        public bool UclT2Trk_CombinedID_A00020_Visible { get; set; }

        internal bool UclT2Trk_CombinedID_A00020_HiddenStatic { get; set; }

        public bool UclT2Trk_CombinedID_A00020_Valid { get; set; }

        public bool UclT2Trk_CombinedID_A00020_HasDiffs { get; }

        public int UclT2Trk_CustomizedSystemID_A00021Value { get; set; }

        public AcpRangeField<int, int> UclT2Trk_CustomizedSystemID_A00021Object { get; }

        public int UclT2Trk_CustomizedSystemID_A00021_UIValue { get; set; }

        internal int UclT2Trk_CustomizedSystemID_A00021Min { get; set; }

        internal int UclT2Trk_CustomizedSystemID_A00021Max { get; set; }

        internal int UclT2Trk_CustomizedSystemID_A00021Step { get; set; }

        public bool UclT2Trk_CustomizedSystemID_A00021_Applicable { get; set; }

        public bool UclT2Trk_CustomizedSystemID_A00021_Valid { get; set; }

        public bool UclT2Trk_CustomizedSystemID_A00021_Visible { get; set; }

        public bool UclT2Trk_CustomizedSystemID_A00021_Editable { get; set; }

        internal string UclT2Trk_CustomizedSystemID_A00021_UILabel { get; }

        internal bool UclT2Trk_CustomizedSystemID_A00021_HiddenStatic { get; set; }

        internal bool UclT2Trk_CustomizedSystemID_A00021_HiddenDynamic { get; set; }

        public bool UclT2Trk_CustomizedSystemID_A00021_HasDiffs { get; }

        internal class UnassignedConverter : IValueConverter
        {
            public UnassignedConverter();
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
        }
    }
}

