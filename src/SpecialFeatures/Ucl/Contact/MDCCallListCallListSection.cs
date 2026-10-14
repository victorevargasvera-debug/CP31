namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Windows.Data;

    [Serializable]
    public sealed class MDCCallListCallListSection : FeatureSection
    {
        private AcpRecRefField uclMDCCnv_SystemAlias_A00028;
        private AcpPointerField<int> uclMDCCnv_SystemGroupNumber_A00029;
        private AcpCustomRangeField uclMDCCnv_PrimaryID_A00030;
        private AcpKeyField uclMDCCnv_CallID_A00031;
        private AcpRangeField<int, int> uclMDCCnv_CustomizedSysGrpNumber_A00032;

        internal MDCCallListCallListSection(FeatureNode parent);
        internal MDCCallListCallListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public void ResolveReferenceAfterUnpack();
        public override void SetConstraints();
        public override void SetupDependencies();

        public int UclMDCCnv_SystemAlias_A00028Value { get; set; }

        public AcpRecRefField UclMDCCnv_SystemAlias_A00028Object { get; }

        public string UclMDCCnv_SystemAlias_A00028_UIValue { get; set; }

        public bool UclMDCCnv_SystemAlias_A00028_Applicable { get; set; }

        public bool UclMDCCnv_SystemAlias_A00028_Editable { get; set; }

        public bool UclMDCCnv_SystemAlias_A00028_Visible { get; set; }

        public bool UclMDCCnv_SystemAlias_A00028_Valid { get; set; }

        public bool UclMDCCnv_SystemAlias_A00028_HasDiffs { get; }

        public int UclMDCCnv_SystemGroupNumber_A00029Value { get; }

        public AcpPointerField<int> UclMDCCnv_SystemGroupNumber_A00029Object { get; }

        public string UclMDCCnv_SystemGroupNumber_A00029_UIValue { get; set; }

        public bool UclMDCCnv_SystemGroupNumber_A00029_Applicable { get; set; }

        public bool UclMDCCnv_SystemGroupNumber_A00029_Editable { get; set; }

        public bool UclMDCCnv_SystemGroupNumber_A00029_Visible { get; set; }

        public bool UclMDCCnv_SystemGroupNumber_A00029_Valid { get; set; }

        public bool UclMDCCnv_SystemGroupNumber_A00029_HasDiffs { get; }

        public int UclMDCCnv_PrimaryID_A00030Value { get; set; }

        public AcpCustomRangeField UclMDCCnv_PrimaryID_A00030Object { get; }

        public string UclMDCCnv_PrimaryID_A00030_UIValue { get; set; }

        public bool UclMDCCnv_PrimaryID_A00030_Applicable { get; set; }

        public bool UclMDCCnv_PrimaryID_A00030_Editable { get; set; }

        public bool UclMDCCnv_PrimaryID_A00030_Visible { get; set; }

        internal bool UclMDCCnv_PrimaryID_A00030_HiddenStatic { get; set; }

        public bool UclMDCCnv_PrimaryID_A00030_Valid { get; set; }

        public bool UclMDCCnv_PrimaryID_A00030_HasDiffs { get; }

        public string UclMDCCnv_CallID_A00031Value { get; set; }

        public AcpKeyField UclMDCCnv_CallID_A00031Object { get; }

        public string UclMDCCnv_CallID_A00031_UILabel { get; }

        public bool UclMDCCnv_CallID_A00031_Applicable { get; set; }

        public bool UclMDCCnv_CallID_A00031_Editable { get; set; }

        public bool UclMDCCnv_CallID_A00031_Visible { get; set; }

        internal bool UclMDCCnv_CallID_A00031_HiddenStatic { get; set; }

        public bool UclMDCCnv_CallID_A00031_Valid { get; set; }

        public bool UclMDCCnv_CallID_A00031_HasDiffs { get; }

        public int UclMDCCnv_CustomizedSysGrpNumber_A00032Value { get; set; }

        public AcpRangeField<int, int> UclMDCCnv_CustomizedSysGrpNumber_A00032Object { get; }

        public int UclMDCCnv_CustomizedSysGrpNumber_A00032_UIValue { get; set; }

        internal int UclMDCCnv_CustomizedSysGrpNumber_A00032Min { get; set; }

        internal int UclMDCCnv_CustomizedSysGrpNumber_A00032Max { get; set; }

        internal int UclMDCCnv_CustomizedSysGrpNumber_A00032Step { get; set; }

        public bool UclMDCCnv_CustomizedSysGrpNumber_A00032_Applicable { get; set; }

        public bool UclMDCCnv_CustomizedSysGrpNumber_A00032_Valid { get; set; }

        public bool UclMDCCnv_CustomizedSysGrpNumber_A00032_Visible { get; set; }

        public bool UclMDCCnv_CustomizedSysGrpNumber_A00032_Editable { get; set; }

        internal string UclMDCCnv_CustomizedSysGrpNumber_A00032_UILabel { get; }

        internal bool UclMDCCnv_CustomizedSysGrpNumber_A00032_HiddenStatic { get; set; }

        internal bool UclMDCCnv_CustomizedSysGrpNumber_A00032_HiddenDynamic { get; set; }

        public bool UclMDCCnv_CustomizedSysGrpNumber_A00032_HasDiffs { get; }

        public bool HasDiffs { get; }

        internal class DecToHexConverter : IValueConverter
        {
            public DecToHexConverter();
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
        }
    }
}

