namespace SpecialFeatures.SystemCertificates
{
    using Motorola.CommonCPS.Server.EntityModel;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class CACertificatesHelper
    {
        internal static string TempFolder;

        static CACertificatesHelper();
        public CACertificatesHelper();
        private static void a(string A_0);
        private static ASTROCACertificates a(string A_0, string A_1);
        public static ASTROCACertificates AnalysisCACertificatePackageInfo(string filePath);
        public static void AttachCACertificateReference(APXTemplate template);
        public static ASTROCACertificates[] GenerateNewCACertificatePackageData(Package[] serverCACertPackages, string outPutDir);
        public static List<string> GetCACertificateFileListFromCP();
        public static List<ASTROCACertificates> GetExistPackageData(Package[] serverCACertPackages);
        public static void UpdateCACertificateContent(List<ASTROCACertificates> templateCACertificateFiles, APXTemplate template);
        public static void UpdateCACertificateReference(APXTemplate template);
    }
}

