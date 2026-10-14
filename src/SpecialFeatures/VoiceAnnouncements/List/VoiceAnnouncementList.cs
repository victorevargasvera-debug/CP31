namespace SpecialFeatures.VoiceAnnouncements.List
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class VoiceAnnouncementList : FeatureNode
    {
        internal VoiceAnnouncementList(Recordset parent);
        protected VoiceAnnouncementList(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetVoiceAnnouncement();

        public VoiceAnnouncementGeneralSection General { get; }
    }
}

