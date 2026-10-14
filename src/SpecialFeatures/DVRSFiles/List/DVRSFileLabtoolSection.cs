namespace SpecialFeatures.DVRSFiles.List
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class DVRSFileLabtoolSection : FeatureSection
    {
        private SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset innerRecset;
        private AcpKeyField dvrsConfigDVRSFileName_A43736;

        public DVRSFileLabtoolSection(FeatureNode parent);
        internal DVRSFileLabtoolSection(SerializationInfo info, StreamingContext context);
        private IAcpRecordset a(int A_0);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset DVRSFileListInnerRecset { get; }

        public bool HasDiffs { get; }

        public string DVRSConfigDVRSFileName_A43736Value { get; set; }

        public AcpKeyField DVRSConfigDVRSFileName_A43736Object { get; }

        internal string DVRSConfigDVRSFileName_A43736_UILabel { get; }

        public bool DVRSConfigDVRSFileName_A43736_Applicable { get; set; }

        public bool DVRSConfigDVRSFileName_A43736_Editable { get; set; }

        public bool DVRSConfigDVRSFileName_A43736_Visible { get; set; }

        public bool DVRSConfigDVRSFileName_A43736_Valid { get; set; }

        internal bool DVRSConfigDVRSFileName_A43736_HiddenStatic { get; set; }

        internal bool DVRSConfigDVRSFileName_A43736_HiddenDynamic { get; set; }

        public bool DVRSConfigDVRSFileName_A43736_HasDiffs { get; }
    }
}

