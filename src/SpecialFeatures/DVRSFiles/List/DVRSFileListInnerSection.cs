namespace SpecialFeatures.DVRSFiles.List
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class DVRSFileListInnerSection : FeatureSection
    {
        private AcpStringField dvrsConfigDVRSFileData_A43734;

        public DVRSFileListInnerSection(FeatureNode parent);
        internal DVRSFileListInnerSection(SerializationInfo info, StreamingContext context);
        private IAcpRecordset a(int A_0);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public bool HasDiffs { get; }

        public string DVRSConfigDVRSFileData_A43734Value { get; set; }

        public AcpStringField DVRSConfigDVRSFileData_A43734 { get; }

        internal string DVRSConfigDVRSFileData_A43734_UILabel { get; }

        public bool DVRSConfigDVRSFileData_A43734_Applicable { get; set; }

        public bool DVRSConfigDVRSFileData_A43734_Editable { get; set; }

        public bool DVRSConfigDVRSFileData_A43734_Visible { get; set; }

        internal bool DVRSConfigDVRSFileData_A43734_HiddenStatic { get; set; }

        public bool DVRSConfigDVRSFileData_A43734_Valid { get; set; }

        public bool DVRSConfigDVRSFileData_A43734_HasDiffs { get; }
    }
}

