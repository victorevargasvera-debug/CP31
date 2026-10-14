namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Windows.Data;

    [Serializable]
    public sealed class AstroCallListCallListSection : FeatureSection
    {
        private AcpRecRefField uclAstroCnv_SystemAlias_A00022;
        private AcpPointerField<int> uclAstroCnv_SystemGroupNumber_A00023;
        private AcpCustomRangeField uclAstroCnv_IndividualID_A00024;
        private AcpListField uclAstroCnv_ListinfoCallType_A00025;
        private AcpKeyField uclAstroCnv_CallID_A00026;
        private AcpRangeField<int, int> uclAstroCnv_CustomizedSysGrpNumber_A00027;

        internal AstroCallListCallListSection(FeatureNode parent);
        internal AstroCallListCallListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public void ResolveReferenceAfterUnpack();
        public override void SetConstraints();
        public override void SetupDependencies();

        public int UclAstroCnv_SystemAlias_A00022Value { get; set; }

        public AcpRecRefField UclAstroCnv_SystemAlias_A00022Object { get; }

        public string UclAstroCnv_SystemAlias_A00022_UIValue { get; set; }

        public bool UclAstroCnv_SystemAlias_A00022_Applicable { get; set; }

        public bool UclAstroCnv_SystemAlias_A00022_Editable { get; set; }

        public bool UclAstroCnv_SystemAlias_A00022_Visible { get; set; }

        public bool UclAstroCnv_SystemAlias_A00022_Valid { get; set; }

        public bool UclAstroCnv_SystemAlias_A00022_HasDiffs { get; }

        public int UclAstroCnv_SystemGroupNumber_A00023Value { get; }

        public AcpPointerField<int> UclAstroCnv_SystemGroupNumber_A00023Object { get; }

        public string UclAstroCnv_SystemGroupNumber_A00023_UIValue { get; set; }

        public bool UclAstroCnv_SystemGroupNumber_A00023_Applicable { get; set; }

        public bool UclAstroCnv_SystemGroupNumber_A00023_Editable { get; set; }

        public bool UclAstroCnv_SystemGroupNumber_A00023_Visible { get; set; }

        public bool UclAstroCnv_SystemGroupNumber_A00023_Valid { get; set; }

        public bool UclAstroCnv_SystemGroupNumber_A00023_HasDiffs { get; }

        public int UclAstroCnv_IndividualID_A00024Value { get; set; }

        public AcpCustomRangeField UclAstroCnv_IndividualID_A00024Object { get; }

        public string UclAstroCnv_IndividualID_A00024_UIValue { get; set; }

        public bool UclAstroCnv_IndividualID_A00024_Applicable { get; set; }

        public bool UclAstroCnv_IndividualID_A00024_Editable { get; set; }

        public bool UclAstroCnv_IndividualID_A00024_Visible { get; set; }

        internal bool UclAstroCnv_IndividualID_A00024_HiddenStatic { get; set; }

        public bool UclAstroCnv_IndividualID_A00024_Valid { get; set; }

        public bool UclAstroCnv_IndividualID_A00024_HasDiffs { get; }

        public AcpListField UclAstroCnv_ListinfoCallType_A00025Object { get; }

        public int UclAstroCnv_ListinfoCallType_A00025Value { get; set; }

        public string UclAstroCnv_ListinfoCallType_A00025_UIValue { get; set; }

        [Browsable(false)]
        public bool UclAstroCnv_ListinfoCallType_A00025_Applicable { get; set; }

        [Browsable(false)]
        public bool UclAstroCnv_ListinfoCallType_A00025_Editable { get; set; }

        [Browsable(false)]
        public bool UclAstroCnv_ListinfoCallType_A00025_Visible { get; set; }

        [Browsable(false)]
        public bool UclAstroCnv_ListinfoCallType_A00025_Valid { get; set; }

        public bool UclAstroCnv_ListinfoCallType_A00025_HasDiffs { get; }

        public string UclAstroCnv_CallID_A00026Value { get; set; }

        public AcpKeyField UclAstroCnv_CallID_A00026Object { get; }

        public string UclAstroCnv_CallID_A00026_UILabel { get; }

        public bool UclAstroCnv_CallID_A00026_Applicable { get; set; }

        public bool UclAstroCnv_CallID_A00026_Editable { get; set; }

        public bool UclAstroCnv_CallID_A00026_Visible { get; set; }

        internal bool UclAstroCnv_CallID_A00026_HiddenStatic { get; set; }

        public bool UclAstroCnv_CallID_A00026_Valid { get; set; }

        public bool UclAstroCnv_CallID_A00026_HasDiffs { get; }

        public int UclAstroCnv_CustomizedSysGrpNumber_A00027Value { get; set; }

        public AcpRangeField<int, int> UclAstroCnv_CustomizedSysGrpNumber_A00027Object { get; }

        public int UclAstroCnv_CustomizedSysGrpNumber_A00027_UIValue { get; set; }

        internal int UclAstroCnv_CustomizedSysGrpNumber_A00027Min { get; set; }

        internal int UclAstroCnv_CustomizedSysGrpNumber_A00027Max { get; set; }

        internal int UclAstroCnv_CustomizedSysGrpNumber_A00027Step { get; set; }

        public bool UclAstroCnv_CustomizedSysGrpNumber_A00027_Applicable { get; set; }

        public bool UclAstroCnv_CustomizedSysGrpNumber_A00027_Valid { get; set; }

        public bool UclAstroCnv_CustomizedSysGrpNumber_A00027_Visible { get; set; }

        public bool UclAstroCnv_CustomizedSysGrpNumber_A00027_Editable { get; set; }

        internal string UclAstroCnv_CustomizedSysGrpNumber_A00027_UILabel { get; }

        internal bool UclAstroCnv_CustomizedSysGrpNumber_A00027_HiddenStatic { get; set; }

        internal bool UclAstroCnv_CustomizedSysGrpNumber_A00027_HiddenDynamic { get; set; }

        public bool UclAstroCnv_CustomizedSysGrpNumber_A00027_HasDiffs { get; }

        public bool HasDiffs { get; }

        internal class UnassignedConverter : IValueConverter
        {
            public UnassignedConverter();
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
        }
    }
}

