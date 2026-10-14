namespace SpecialFeatures.VoiceAnnouncements.List
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class TTSVoiceAnnouncementList : FeatureNode
    {
        internal TTSVoiceAnnouncementList(Recordset parent);
        protected TTSVoiceAnnouncementList(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetTTSVoiceAnnouncement();

        public TTSVoiceAnnouncementGeneralSection General { get; }
    }
}

