namespace SpecialFeatures.VoiceAnnouncements.Wide
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class VoiceAnnouncementWideRecSet : Recordset
    {
        public VoiceAnnouncementWideRecSet();
        internal VoiceAnnouncementWideRecSet(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();
        internal void SetValues();
    }
}

