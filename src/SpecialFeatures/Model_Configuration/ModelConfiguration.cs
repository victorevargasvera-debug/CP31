namespace SpecialFeatures.Model_Configuration
{
    using AcpModelTieringLib;
    using System;
    using System.Collections.Generic;

    public class ModelConfiguration
    {
        private string a;
        private string b;
        private int c;
        private int d;
        private int e;
        private int f;
        private Dictionary<string, Type> g;
        private CModelTiering h;
        private bool i;
        private Dictionary<string, bool> j;
        private const int k = 0x7fffffff;
        private const int l = 1;
        private const int m = 1;

        static ModelConfiguration();
        internal ModelConfiguration(string MyModelNumber, string strTieringFileSource);
        private bool a(string A_0);
        private void a(ref Dictionary<string, bool> A_0);
        private bool a(string A_0, string A_1);
        internal bool SetModelConfiguration(bool CplgOpenAndNew);

        internal Dictionary<string, bool> AllEnabledOptList { get; }
    }
}

