namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class SiteSelectableAlertTableInner : FeatureNode
    {
        public SiteSelectableAlertTableInner(Recordset parent);
        protected SiteSelectableAlertTableInner(SerializationInfo info, StreamingContext context);

        public SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerSection SiteSelectableAlertTableInnerSection { get; }
    }
}

