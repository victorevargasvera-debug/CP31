namespace SpecialFeatures.DVRSFiles
{
    using Motorola.CommonCPS.Server.EntityModel;
    using SpecialFeatures.DVRSFiles.List;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class DVRSFilesHelper
    {
        internal static string TempFolder;
        public const string EXTENSIONDCD = ".dcd";

        static DVRSFilesHelper();
        public DVRSFilesHelper();
        private static void a();
        private static void a(string A_0);
        private static void a(byte[] A_0, DVRSFileListInnerRecset A_1);
        private static bool a(DVRSFileListRecSet A_0, string A_1);
        private static void a(string A_0, byte[] A_1, ASTRODVRSFiles A_2);
        private static ASTRODVRSFiles a(string A_0, ASTRODVRSFiles A_1, bool A_2);
        private static ASTRODVRSFiles a(string A_0, bool A_1, string A_2);
        public static ASTRODVRSFiles AnalysisDVRSFilePackageInfo(string filePath);
        public static void ApplyDVRSFileDataFromTemplate(APXTemplate currentTpl);
        public static void ApplyDVRSFileDataFromTemplateUsingCruncherData(APXTemplate currentTpl, CruncherData cruncherData);
        public static void AttachDVRSFileReference(APXTemplate template);
        private static byte[] b(string A_0);
        public static ASTRODVRSFiles[] GenerateNewDVRSFilePackageData(Package[] serverDVRSPackages, string outPutDir);
        public static List<string> GetDVRSFileListFromCP();
        public static List<ASTRODVRSFiles> GetExistingPackageData(Package[] serverDVRSFilesPackages);
        public static void populateDvrsFileDbRecords(DVRSFileLabtoolSection labTool, string dvrsFilePath);
        public static void PopulateDvrsFileDbRecordsFromCruncherData(DVRSFileLabtoolSection labTool, KeyValuePair<Package, byte[]> dvrsFileContent);
        public static void UpdateDVRSFileReference(APXTemplate template);
        public static void UpdateDVRSFilesContent(List<ASTRODVRSFiles> templateDVRSFiles, APXTemplate template);

        [CompilerGenerated]
        private sealed class <>c__DisplayClass14_0
        {
            public Guid? packageUUID;

            public <>c__DisplayClass14_0();
            internal bool <ApplyDVRSFileDataFromTemplateUsingCruncherData>b__0(KeyValuePair<Package, byte[]> f);
        }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass6_0
        {
            public string hex;

            public <>c__DisplayClass6_0();
            internal byte <GenerateNewDVRSFilePackageData>b__0(int x);
        }
    }
}

