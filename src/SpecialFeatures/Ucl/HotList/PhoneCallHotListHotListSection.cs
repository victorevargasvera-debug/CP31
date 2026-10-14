namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using SpecialFeatures.Ucl.Contact;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class PhoneCallHotListHotListSection : FeatureSection
    {
        private AcpRecRefField uclPhoneHotList_ContactAlias_A00049;
        private AcpRecRefField uclPhoneHotList_CallID_A00050;

        internal PhoneCallHotListHotListSection(FeatureNode parent);
        internal PhoneCallHotListHotListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public int UclPhoneHotList_ContactAlias_A00049Value { get; set; }

        public AcpRecRefField UclPhoneHotList_ContactAlias_A00049Object { get; set; }

        public string UclPhoneHotList_ContactAlias_A00049_UIValue { get; set; }

        public bool UclPhoneHotList_ContactAlias_A00049_Applicable { get; set; }

        public bool UclPhoneHotList_ContactAlias_A00049_Editable { get; set; }

        public bool UclPhoneHotList_ContactAlias_A00049_Visible { get; set; }

        public bool UclPhoneHotList_ContactAlias_A00049_Valid { get; set; }

        public bool UclPhoneHotList_ContactAlias_A00049_HasDiffs { get; }

        public int UclPhoneHotList_CallID_A00050Value { get; set; }

        public AcpRecRefField UclPhoneHotList_CallID_A00050Object { get; set; }

        public string UclPhoneHotList_CallID_A00050_UIValue { get; set; }

        public bool UclPhoneHotList_CallID_A00050_Applicable { get; set; }

        public bool UclPhoneHotList_CallID_A00050_Editable { get; set; }

        public bool UclPhoneHotList_CallID_A00050_Visible { get; set; }

        public bool UclPhoneHotList_CallID_A00050_Valid { get; set; }

        public bool UclPhoneHotList_CallID_A00050_HasDiffs { get; }

        public UclContact Contact { get; }

        public bool HasDiffs { get; }
    }
}

