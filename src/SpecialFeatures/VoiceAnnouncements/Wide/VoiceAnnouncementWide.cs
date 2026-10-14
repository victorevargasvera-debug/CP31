namespace SpecialFeatures.VoiceAnnouncements.Wide
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class VoiceAnnouncementWide : FeatureNode
    {
        internal VoiceAnnouncementWide(Recordset parent);
        protected VoiceAnnouncementWide(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetVoiceAnnouncement();

        public SpecialFeatures.VoiceAnnouncements.Wide.General General { get; }
    }
}

