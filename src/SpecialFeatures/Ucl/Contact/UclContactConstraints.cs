namespace SpecialFeatures.Ucl.Contact
{
    using AcpCommonLib;
    using System;

    internal class UclContactConstraints
    {
        public UclContactConstraints();
        internal static bool conIsAstroCallTypeValid(IAcpFeatureSection self, int index);
        internal static bool conIsAstroIndividualIdValid(IAcpFeatureSection self);
        internal static bool conIsAstroSystemAliasValid(IAcpFeatureSection self, int index);
        internal static bool conIsCustomizedAstro25System(IAcpFeatureSection self);
        internal static bool conIsCustomizedAstroSystem(IAcpFeatureSection self);
        internal static bool conIsCustomizedMDCSystem(IAcpFeatureSection self);
        internal static bool conIsCustomizedT2System(IAcpFeatureSection self);
        internal static bool conIsMDCSystemAliasValid(IAcpFeatureSection self, int index);
        internal static bool conIsNotCustomizedAstro25System(IAcpFeatureSection self);
        internal static bool conIsNotCustomizedAstroSystem(IAcpFeatureSection self);
        internal static bool conIsNotCustomizedMDCSystem(IAcpFeatureSection self);
        internal static bool conIsNotCustomizedT2System(IAcpFeatureSection self);
        internal static bool conIsPhoneCategoryTypeValid(IAcpFeatureSection self, int index);
        internal static bool conIsPhoneNumberValid(IAcpFeatureSection self);
        internal static bool conIsPrimaryIdValid(IAcpFeatureSection self);
        internal static bool conIsT2IndividualIdValid(IAcpFeatureSection self);
        internal static bool conIsTrkIndividualIdValid(IAcpFeatureSection self);
        internal static bool conIsTrkType2SystemAliasValid(IAcpFeatureSection self, int index);
        internal static bool conSetAstroSysGroupNumber(IAcpFeatureSection self);
        internal static bool conSetMDCSysGroupNumber(IAcpFeatureSection self);
        internal static bool conSetTrkSystemIDs(IAcpFeatureSection self);
        internal static bool conSetType2SystemID(IAcpFeatureSection self);
        internal static bool conTrk25SystemAliasIsValid(IAcpFeatureSection self, int index);
        internal static bool conUCLContactsValidity(IAcpFeatureSection self);
    }
}

