namespace SpecialFeatures.VoiceAnnouncements.List
{
    using AcpCommonLib;
    using AcpCommonLib.UndoRedo;
    using System;

    internal class TTSVoiceAnnouncementsConstraints
    {
        public TTSVoiceAnnouncementsConstraints();
        internal static void conSetTTSVAFieldsValue(IAcpFeatureSection self, ContainerTask task);
        internal static bool conSetTTSVoiceAnnouncementFileEditability(IAcpFeatureSection self);
        internal static bool conTTSVoiceAnnouncementFileValidity(IAcpFeatureSection self);
    }
}

