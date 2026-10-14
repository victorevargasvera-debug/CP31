namespace SpecialFeatures.VoiceAnnouncements.List
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class VoiceAnnouncementGeneralSection : FeatureSection
    {
        private AcpKeyField voiceFileName_A21220;
        private AcpField<uint> voiceAnnouncementFileHashcode_A24563;
        private AcpListField voiceAnnouncementEncodeType_A22264;
        private AcpVoiceFileField voiceFileDataInfo_A21213;

        internal VoiceAnnouncementGeneralSection(FeatureNode parent);
        internal VoiceAnnouncementGeneralSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public bool HasDiffs { get; }

        public string VoiceFileName_A21220Value { get; set; }

        public AcpKeyField VoiceFileName_A21220Object { get; }

        internal string VoiceFileName_A21220_UILabel { get; }

        public bool VoiceFileName_A21220_Applicable { get; set; }

        public bool VoiceFileName_A21220_Editable { get; set; }

        public bool VoiceFileName_A21220_Visible { get; set; }

        public bool VoiceFileName_A21220_Valid { get; set; }

        internal bool VoiceFileName_A21220_HiddenStatic { get; set; }

        internal bool VoiceFileName_A21220_HiddenDynamic { get; set; }

        public bool VoiceFileName_A21220_HasDiffs { get; }

        public uint VoiceAnnouncementFileHashcode_A24563Value { get; set; }

        public AcpField<uint> VoiceAnnouncementFileHashcode_A24563 { get; }

        public uint VoiceAnnouncementFileHashcode_A24563_UIValue { get; set; }

        public bool VoiceAnnouncementFileHashcode_A24563_Applicable { get; set; }

        public bool VoiceAnnouncementFileHashcode_A24563_Valid { get; set; }

        public bool VoiceAnnouncementFileHashcode_A24563_Visible { get; set; }

        public bool VoiceAnnouncementFileHashcode_A24563_Editable { get; set; }

        internal string VoiceAnnouncementFileHashcode_A24563_UILabel { get; }

        internal bool VoiceAnnouncementFileHashcode_A24563_HiddenStatic { get; set; }

        internal bool VoiceAnnouncementFileHashcode_A24563_HiddenDynamic { get; set; }

        internal bool VoiceAnnouncementFileHashcode_A24563_HasDiffs { get; }

        public int VoiceAnnouncementEncodeType_A22264Value { get; set; }

        public string VoiceAnnouncementEncodeType_A22264_UIValue { get; set; }

        public AcpListField VoiceAnnouncementEncodeType_A22264 { get; }

        public bool VoiceAnnouncementEncodeType_A22264_Applicable { get; set; }

        public bool VoiceAnnouncementEncodeType_A22264_Valid { get; set; }

        public bool VoiceAnnouncementEncodeType_A22264_Visible { get; set; }

        public bool VoiceAnnouncementEncodeType_A22264_Editable { get; set; }

        internal string VoiceAnnouncementEncodeType_A22264_UILabel { get; }

        internal bool VoiceAnnouncementEncodeType_A22264_HiddenStatic { get; set; }

        internal bool VoiceAnnouncementEncodeType_A22264_HiddenDynamic { get; set; }

        public AcpVoiceFileStruct VoiceFileDataInfo_A21213Value { get; set; }

        public AcpVoiceFileField VoiceFileDataInfo_A21213 { get; }

        internal string VoiceFileDataInfo_A21213_UILabel { get; }

        public bool VoiceFileDataInfo_A21213_Applicable { get; set; }

        public bool VoiceFileDataInfo_A21213_Editable { get; set; }

        public bool VoiceFileDataInfo_A21213_Visible { get; set; }

        internal bool VoiceFileDataInfo_A21213_HiddenStatic { get; set; }

        public bool VoiceFileDataInfo_A21213_Valid { get; set; }

        public bool VoiceFileDataInfo_A21213_HasDiffs { get; }
    }
}

