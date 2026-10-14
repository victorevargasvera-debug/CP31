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
    public sealed class PhoneCallListCallListSection : FeatureSection
    {
        private AcpFieldX<string, string> uclPhone_PhoneNumber_A00033;
        private AcpListField uclPhone_ListinfoPhoneCategory_A00034;
        private AcpKeyField uclPhone_CombinedID_A00035;

        internal PhoneCallListCallListSection(FeatureNode parent);
        internal PhoneCallListCallListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public string UclPhone_PhoneNumber_A00033Value { get; set; }

        public string UclPhone_PhoneNumber_A00033_UIValue { get; set; }

        public AcpField<string> UclPhone_PhoneNumber_A00033Object { get; }

        public bool UclPhone_PhoneNumber_A00033_Applicable { get; set; }

        public bool UclPhone_PhoneNumber_A00033_Editable { get; set; }

        public bool UclPhone_PhoneNumber_A00033_Visible { get; set; }

        public bool UclPhone_PhoneNumber_A00033_Valid { get; set; }

        public bool UclPhone_PhoneNumber_A00033_HasDiffs { get; }

        public AcpListField UclPhone_ListinfoPhoneCategory_A00034Object { get; }

        public int UclPhone_ListinfoPhoneCategory_A00034Value { get; set; }

        public string UclPhone_ListinfoPhoneCategory_A00034_UIValue { get; set; }

        [Browsable(false)]
        public bool UclPhone_ListinfoPhoneCategory_A00034_Applicable { get; set; }

        [Browsable(false)]
        public bool UclPhone_ListinfoPhoneCategory_A00034_Editable { get; set; }

        [Browsable(false)]
        public bool UclPhone_ListinfoPhoneCategory_A00034_Visible { get; set; }

        [Browsable(false)]
        public bool UclPhone_ListinfoPhoneCategory_A00034_Valid { get; set; }

        public bool UclPhone_ListinfoPhoneCategory_A00034_HasDiffs { get; }

        public string UclPhone_CombinedID_A00035Value { get; set; }

        public AcpKeyField UclPhone_CombinedID_A00035Object { get; }

        internal string UclPhone_CombinedID_A00035_UILabel { get; }

        public bool UclPhone_CombinedID_A00035_Applicable { get; set; }

        public bool UclPhone_CombinedID_A00035_Editable { get; set; }

        public bool UclPhone_CombinedID_A00035_Visible { get; set; }

        internal bool UclPhone_CombinedID_A00035_HiddenStatic { get; set; }

        public bool UclPhone_CombinedID_A00035_Valid { get; set; }

        public bool UclPhone_CombinedID_A00035_HasDiffs { get; }

        public bool HasDiffs { get; }

        internal class UnpackAndpackPhoneNumber : IValueConverter
        {
            public UnpackAndpackPhoneNumber();
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
        }
    }
}

