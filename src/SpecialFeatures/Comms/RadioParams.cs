namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.CommonUtil;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    [DataContract]
    public class RadioParams
    {
        [DataMember]
        private string m_SerialNumber;
        [DataMember]
        private byte[] m_ESerialNumber;
        [DataMember]
        private string m_ModelNumber;
        [DataMember]
        private Guid m_Uuid;
        [DataMember]
        private string m_RadioBBFVersion;
        [DataMember]
        private string m_HostVersion;
        [DataMember]
        private string m_DspVersion;
        [DataMember]
        private string m_CodeplugVersion;
        [DataMember]
        private string m_PsdtVersion;
        [DataMember]
        private string m_BootAppVersion;
        [DataMember]
        private string m_TuneVersion;
        [DataMember]
        private string m_FlashCode;
        [DataMember]
        private string m_OptBrdName;
        [DataMember]
        private string m_OptBrdHwType;
        [DataMember]
        private string m_OptBrdHwHostVersion;
        [DataMember]
        private string m_LTEOptBrdHwHostVersion;
        [DataMember]
        private string m_OptBrdFlashImageVersion;
        [DataMember]
        private string m_OptBrdFlashImageType;
        [DataMember]
        private bool m_OptBrdHwNotPresentFlag;
        [DataMember]
        private string m_ConBrdHwType;
        [DataMember]
        private string m_ConBrdHwHostVersion;
        private string a;
        private string b;
        private string c;
        [CompilerGenerated]
        private ProductFamily d;
        [CompilerGenerated]
        private Motorola.Common.Communication.CommonUtil.ConnectionInfo e;
        [CompilerGenerated]
        private string f;
        [CompilerGenerated]
        private Motorola.Common.Communication.CommonUtil.RadioState g;
        [CompilerGenerated]
        private Motorola.Common.Communication.CommonUtil.RadioStorage h;

        public RadioParams();
        public override string ToString();

        public string SerialNumber { get; set; }

        public byte[] ESerialNumber { get; set; }

        public string ModelNumber { get; set; }

        public Guid Uuid { get; set; }

        public string HostVersion { get; set; }

        public string RadioBBFSuiteVersion { get; set; }

        public string DspVersion { get; set; }

        public string PsdtVersion { get; set; }

        public string BootAppVersion { get; set; }

        public string TuneVersion { get; set; }

        public string CodeplugVersion { get; set; }

        public string FlashCode { get; set; }

        public string OptBoardName { get; set; }

        public string OptBrdHardwareType { get; set; }

        public string OptBrdHwHostVersion { get; set; }

        public string LTEOptBrdHwHostVersion { get; set; }

        public string OptBrdFlashImageVersion { get; set; }

        public string OptBrdFlashImageType { get; set; }

        public bool OptBrdHwNotPresentFlag { get; set; }

        public string ConBrdHardwareType { get; set; }

        public string ConBrdHwHostVersion { get; set; }

        public string MaceFlashVersion { get; set; }

        internal string MaceHardwareType { get; set; }

        internal string MaceHardwareVersion { get; set; }

        public ProductFamily Family { get; set; }

        public Motorola.Common.Communication.CommonUtil.ConnectionInfo ConnectionInfo { get; set; }

        public string RadioID { get; set; }

        public Motorola.Common.Communication.CommonUtil.RadioState RadioState { get; set; }

        public Motorola.Common.Communication.CommonUtil.RadioStorage RadioStorage { get; set; }
    }
}

