namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class SiteSelectableAlertList : FeatureNode
    {
        public SiteSelectableAlertList(Recordset parent);
        protected SiteSelectableAlertList(SerializationInfo info, StreamingContext context);
        public static IAcpFeatureNode GetSiteSelectableAlertList();

        public SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertList41985 SiteSelectableAlertList41985 { get; }
    }
}

