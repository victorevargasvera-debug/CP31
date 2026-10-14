namespace SpecialFeatures.Flashport
{
    using Encaten;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public sealed class FlashportUpgradeFile
    {
        private IEncateWrapper a;
        private string b;
        private const string c = "1B7097E8-D9E3-11d5-A3BE-0060B0FB015A";
        private bool d;
        private string e;
        private const string f = "fileItem";
        private const string g = "fileName";
        private const string h = "filePackageDestinationInfo";
        private const string i = "fileVersion";
        private const string j = "fileData";
        private const string k = "@BBFhdr@";
        private const string l = "@BBFimg@";
        private const int m = 0x40;
        private const int n = 0x200;
        private const int o = 0x100;
        private const int p = 0x18;

        public FlashportUpgradeFile();
        public FlashportUpgradeFile(string path);
        internal bool CheckFileContentsValid();
        internal bool CheckFileDestinatioInfoValid(string modelNumber);
        internal bool CheckFileDestinatioInfoValidForBBF(string modelNumber);
        public bool ComponentPresent(string componentName);
        public bool ExtractDataToFile(string componentName, string filePath);
        public Dictionary<string, byte[]> GetAllSectionsData();
        public byte[] GetBBFFileData();
        public string GetBBFSuiteVersion();
        public void GetComponentData(string componentName, out string data);
        internal string getCurrentFileData(string ComponentName);
        internal string getCurrentFileVersion(string ComponentName);
        public string GetFileComponentVersion(string componentName, bool noPeriods);
        internal string getFilePackageDestinationInfo();
        public string GetFileTargetModelNumber();
        public string GetFileTargetModelNumberForBBF();
        public int GetImageSectionsCount();
        public Dictionary<string, byte[]> GetTargetSectionsData(string imageSectionName);
        public int GetValidationBlockOffset();
        public bool OpenUpgradeFile();
        internal int selectCurrentFile(string ComponentName);
        public string ValidateImageSectionName(string imageName);
        public bool verifyBBFMagicNumber();
        public bool verifyChecksum();

        public string UpgradeFilePath { get; set; }
    }
}

