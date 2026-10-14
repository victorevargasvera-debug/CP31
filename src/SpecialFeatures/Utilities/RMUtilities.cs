namespace SpecialFeatures.Utilities
{
    using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
    using System;

    public static class RMUtilities
    {
        public static void PopulateAstroCpsASKProgrammingHistoryRecset(string astroSysKeyLogXml);
        public static void PopulateAstroCpsTrunkingGroupIDs(ref Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles RefDataProfile, string trunkingGroupIDXml);
        public static string PopulateAstroSysKeyLog();
        public static string PopulateTrunkingGroupIDs(Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles RefDataProfile);
    }
}

