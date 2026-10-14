namespace SpecialFeatures.VoiceAnnouncements
{
    using ACPVoiceAnnouncementLib;
    using Motorola.CommonCPS.Server.EntityModel;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class VAHelper
    {
        public const string EXTENTIONWAV = ".wav";
        public const string EXTENTIONMVA = ".mva";
        internal static string TempFolder;

        static VAHelper();
        public VAHelper();
        private static string a(ACPInflateDeflateCodes A_0);
        private static void a(string A_0);
        private static ASTROVoiceAnnouncement a(string A_0, string A_1);
        public static ASTROVoiceAnnouncement AnaysisVAPackageInfo(string filePath);
        public static void AttachVoiceAnnouncemnetReference(APXTemplate template);
        private static string[] b(string A_0);
        private static string c(string A_0);
        public static ASTROVoiceAnnouncement[] GenerateNewVAPackageData(Package[] serverVAPackages, string outPutDir);
        public static List<ASTROVoiceAnnouncement> GetExistPackageData(Package[] serverVAPackages);
        public static List<string> GetVAFileListFromCP();
        public static void UpdateVAContent(List<ASTROVoiceAnnouncement> templateVoiceFiles, APXTemplate template);
        public static void UpdateVoiceAnnouncemnetReference(APXTemplate template);
    }
}

