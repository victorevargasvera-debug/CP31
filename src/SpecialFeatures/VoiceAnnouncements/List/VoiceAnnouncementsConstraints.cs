namespace SpecialFeatures.VoiceAnnouncements.List
{
    using AcpCommonLib;
    using AcpCommonLib.UndoRedo;
    using System;

    internal class VoiceAnnouncementsConstraints
    {
        public VoiceAnnouncementsConstraints();
        internal static void conSetVAFieldsValue(IAcpFeatureSection self, ContainerTask task);
        internal static bool conSetVoiceAnnouncementFileEditability(IAcpFeatureSection self);
        internal static bool conVoiceAnnouncementFileValidity(IAcpFeatureSection self);
    }
}

