namespace SpecialFeatures.Comms
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct RadioIdInfo
    {
        private Dictionary<string, int[]> a;
        private Dictionary<string, int[]> b;
        private Dictionary<string, int> c;
        private DataProfIP[] d;
        private string[] e;
        private string f;
        private string g;
        private byte[] h;
        private bool i;
        private string j;
        private bool k;
        [CompilerGenerated]
        private string l;
        public Dictionary<string, int[]> CnvSysIds { get; set; }
        public Dictionary<string, int[]> TrkSysIds { get; set; }
        public Dictionary<string, int> AstroOtarRadioIds { get; set; }
        public DataProfIP[] DataProfIps { get; set; }
        public string[] SoftIds { get; set; }
        public string RadioAlias { get; set; }
        public string BluetoothFriendlyName { get; set; }
        public byte[] ESerialNumber { get; set; }
        public bool IsEncryptedPwd { get; set; }
        public string EncryptedPwd { get; set; }
        public bool IsManagedUpgrade { get; set; }
        public string SerialNumber { [IsReadOnly] get; set; }
    }
}

