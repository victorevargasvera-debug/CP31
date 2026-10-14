namespace SpecialFeatures.RadioLanguagePack
{
    using AcpBusinessLayer;
    using Motorola.Common.Communication.Pba;
    using Motorola.CommonCPS.Server.EntityModel;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public static class LanguagePackHelper
    {
        private const string a = "RadioLanguagePacks";
        public static readonly string LanguagePackFolderPath;
        public const string LanguagePackExtension = ".lpk";
        public const string LanguagePackSearchPattern = "*.lpk";
        [CompilerGenerated]
        private static int b;
        private static string c;
        [CompilerGenerated]
        private static string d;
        private static Dictionary<int, ASTROLanguagePack> e;

        static LanguagePackHelper();
        private static List<ASTROLanguagePack> a();
        private static string a(int A_0);
        private static string a(string A_0);
        public static void AttachLanguagePackagesReference(APXTemplate template);
        private static int b(string A_0);
        public static void BindingLanguageSections();
        internal static LanguagePackData BuildWriteLanguageData(string softWareVersion, bool isFlashPort);
        public static string GetAstroLanugagePackID(int languageIndex);
        internal static int GetCodeplugLanguageIndex();
        public static bool IsFirmwareLPCompatible(string hostVersion, int cpLanguageIndex);
        public static bool IsFirmwareLPCompatible(string hostVersion, ref string stat, int codeplugLanguageIndx, bool IsPortable);
        public static bool IsNeedBindingServerLanguagePack(string firmwareVersion);
        public static bool IsRadioUpgradeHostGreaterThan_7_12(string radioHostVer, string cvnHostVer);
        internal static bool IsRadioUpgradeHostLessThan_7_12(string radioHostVer, string cvnHostVer);
        public static ASTROLanguagePack ParseLanguagePackage(string packagePath);
        public static void UpdateLanguageRefence(APXTemplate template);

        public static int UpgradRadioLangSetting { get; set; }

        public static string warningOTAPMessage { get; set; }

        internal static Dictionary<int, ASTROLanguagePack> LanguageMappingTable { get; }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass17_0
        {
            public object strLanguage;

            public <>c__DisplayClass17_0();
            internal bool <BindingLanguageSections>b__0(ListItem p);
        }
    }
}

