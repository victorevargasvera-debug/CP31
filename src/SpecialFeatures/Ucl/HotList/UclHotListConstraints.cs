namespace SpecialFeatures.Ucl.HotList
{
    using AcpCommonLib;
    using System;

    internal class UclHotListConstraints
    {
        public UclHotListConstraints();
        internal static bool ConAstro25ContactAliasIsNotUnassigned(IAcpFeatureSection self);
        internal static bool conAstro25HotListCallIDIsValid(IAcpFeatureSection self, int index);
        internal static bool ConAstroContactAliasIsNotUnassigned(IAcpFeatureSection self);
        internal static bool conAstroHotListCallIDIsValid(IAcpFeatureSection self, int index);
        internal static bool ConMDCContactAliasIsNotUnassigned(IAcpFeatureSection self);
        internal static bool conMDCHotListCallIDIsValid(IAcpFeatureSection self, int index);
        internal static bool ConPhoneContactAliasIsNotUnassigned(IAcpFeatureSection self);
        internal static bool conPhoneHotListCallIDIsValid(IAcpFeatureSection self, int index);
        internal static bool ConTrkT2ContactAliasIsNotUnassigned(IAcpFeatureSection self);
        internal static bool conTrkT2HotListCallIDIsValid(IAcpFeatureSection self, int index);
    }
}

