namespace SpecialFeatures.SystemCertificates.List
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class SystemCertificateGeneralSection : FeatureSection
    {
        private AcpKeyField secSysCertGeneralKeyofSystemCertificates_A43633;
        private AcpStringField secSysCertGeneralCertificateFilename_A43634;
        private AcpVoiceFileField secSysCertGeneralCertificateFileData_A43635;

        internal SystemCertificateGeneralSection(FeatureNode parent);
        internal SystemCertificateGeneralSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public bool HasDiffs { get; }

        public string SecSysCertGeneralKeyofSystemCertificates_A43633Value { get; set; }

        public AcpKeyField SecSysCertGeneralKeyofSystemCertificates_A43633Object { get; }

        internal string SecSysCertGeneralKeyofSystemCertificates_A43633Name_UILabel { get; }

        public bool SecSysCertGeneralKeyofSystemCertificates_A43633_Applicable { get; set; }

        public bool SecSysCertGeneralKeyofSystemCertificates_A43633_Editable { get; set; }

        public bool SecSysCertGeneralKeyofSystemCertificates_A43633_Visible { get; set; }

        internal bool SecSysCertGeneralKeyofSystemCertificates_A43633_HiddenStatic { get; set; }

        public bool SecSysCertGeneralKeyofSystemCertificates_A43633_Valid { get; set; }

        public bool SecSysCertGeneralKeyofSystemCertificates_A43633_HasDiffs { get; }

        public string SecSysCertGeneralCertificateFilename_A43634Value { get; set; }

        public AcpStringField SecSysCertGeneralCertificateFilename_A43634Object { get; }

        internal string SecSysCertGeneralCertificateFilename_A43634_UILabel { get; }

        public bool SecSysCertGeneralCertificateFilename_A43634_Applicable { get; set; }

        public bool SecSysCertGeneralCertificateFilename_A43634_Editable { get; set; }

        public bool SecSysCertGeneralCertificateFilename_A43634_Visible { get; set; }

        public bool SecSysCertGeneralCertificateFilename_A43634_Valid { get; set; }

        internal bool SecSysCertGeneralCertificateFilename_A43634_HiddenStatic { get; set; }

        internal bool SecSysCertGeneralCertificateFilename_A43634_HiddenDynamic { get; set; }

        public bool SecSysCertGeneralCertificateFilename_A43634_HasDiffs { get; }

        public AcpVoiceFileStruct SecSysCertGeneralCertificateFileData_A43635Value { get; set; }

        public AcpVoiceFileField SecSysCertGeneralCertificateFileData_A43635 { get; }

        internal string SecSysCertGeneralCertificateFileData_A43635_UILabel { get; }

        public bool SecSysCertGeneralCertificateFileData_A43635_Applicable { get; set; }

        public bool SecSysCertGeneralCertificateFileData_A43635_Editable { get; set; }

        public bool SecSysCertGeneralCertificateFileData_A43635_Visible { get; set; }

        internal bool SecSysCertGeneralCertificateFileData_A43635_HiddenStatic { get; set; }

        public bool SecSysCertGeneralCertificateFileData_A43635_Valid { get; set; }

        public bool SecSysCertGeneralCertificateFileData_A43635_HasDiffs { get; }
    }
}

