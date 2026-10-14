namespace SpecialFeatures.Ucl.UclWide
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Windows.Data;

    [Serializable]
    public sealed class UclWideSectionGeneral : FeatureSection
    {
        private AcpField<bool> uclWideGen_UCLEdit_A00001;
        private AcpField<bool> uclWideGen_HotListEdit_A00002;
        private AcpField<bool> uclWideGen_PhoneNumEdit_A00004;
        private AcpField<bool> uclWideGen_RadioIdEdit_A00003;
        private AcpSparseLOVField uclWideGen_ContactDataOrder_A00005;

        internal UclWideSectionGeneral(FeatureNode parent);
        internal UclWideSectionGeneral(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public bool UclWideGen_UCLEdit_A00001Value { get; set; }

        public AcpField<bool> UclWideGen_UCLEdit_A00001Object { get; }

        public string UclWideGen_UCLEdit_A00001_UILabel { get; }

        public bool UclWideGen_UCLEdit_A00001_Applicable { get; set; }

        public bool UclWideGen_UCLEdit_A00001_Editable { get; set; }

        public bool UclWideGen_UCLEdit_A00001_Visible { get; set; }

        internal bool UclWideGen_UCLEdit_A00001_HiddenStatic { get; set; }

        public bool UclWideGen_UCLEdit_A00001_Valid { get; set; }

        public bool UclWideGen_UCLEdit_A00001_HasDiffs { get; }

        public bool UclWideGen_HotListEdit_A00002Value { get; set; }

        public AcpField<bool> UclWideGen_HotListEdit_A00002Object { get; }

        public string UclWideGen_HotListEdit_A00002_UILabel { get; }

        public bool UclWideGen_HotListEdit_A00002_Applicable { get; set; }

        public bool UclWideGen_HotListEdit_A00002_Editable { get; set; }

        public bool UclWideGen_HotListEdit_A00002_Visible { get; set; }

        internal bool UclWideGen_HotListEdit_A00002_HiddenStatic { get; set; }

        public bool UclWideGen_HotListEdit_A00002_Valid { get; set; }

        public bool UclWideGen_HotListEdit_A00002_HasDiffs { get; }

        public bool UclWideGen_PhoneNumEdit_A00004Value { get; set; }

        public AcpField<bool> UclWideGen_PhoneNumEdit_A00004Object { get; }

        public string UclWideGen_PhoneNumEdit_A00004_UILabel { get; }

        public bool UclWideGen_PhoneNumEdit_A00004_Applicable { get; set; }

        public bool UclWideGen_PhoneNumEdit_A00004_Editable { get; set; }

        public bool UclWideGen_PhoneNumEdit_A00004_Visible { get; set; }

        internal bool UclWideGen_PhoneNumEdit_A00004_HiddenStatic { get; set; }

        public bool UclWideGen_PhoneNumEdit_A00004_Valid { get; set; }

        public bool UclWideGen_PhoneNumEdit_A00004_HasDiffs { get; }

        public bool UclWideGen_RadioIdEdit_A00003Value { get; set; }

        public AcpField<bool> UclWideGen_RadioIdEdit_A00003Object { get; }

        public string UclWideGen_RadioIdEdit_A00003_UILabel { get; }

        public bool UclWideGen_RadioIdEdit_A00003_Applicable { get; set; }

        public bool UclWideGen_RadioIdEdit_A00003_Editable { get; set; }

        public bool UclWideGen_RadioIdEdit_A00003_Visible { get; set; }

        internal bool UclWideGen_RadioIdEdit_A00003_HiddenStatic { get; set; }

        public bool UclWideGen_RadioIdEdit_A00003_Valid { get; set; }

        public bool UclWideGen_RadioIdEdit_A00003_HasDiffs { get; }

        public int UclWideGen_ContactDataOrder_A00005Value { get; set; }

        public AcpSparseLOVField UclWideGen_ContactDataOrder_A00005Object { get; }

        public string UclWideGen_ContactDataOrder_A00005_UIValue { get; set; }

        public string UclWideGen_ContactDataOrder_A00005_UILabel { get; }

        public bool UclWideGen_ContactDataOrder_A00005_Applicable { get; set; }

        public bool UclWideGen_ContactDataOrder_A00005_Editable { get; set; }

        public bool UclWideGen_ContactDataOrder_A00005_Visible { get; set; }

        internal bool UclWideGen_ContactDataOrder_A00005_HiddenStatic { get; set; }

        public bool UclWideGen_ContactDataOrder_A00005_Valid { get; set; }

        public bool UclWideGen_ContactDataOrder_A00005_HasDiffs { get; }

        public bool HasDiffs { get; }

        internal class CallTypeLOVConverter : IValueConverter
        {
            public CallTypeLOVConverter();
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
        }
    }
}

