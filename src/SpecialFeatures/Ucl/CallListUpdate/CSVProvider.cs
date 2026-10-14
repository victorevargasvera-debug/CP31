namespace SpecialFeatures.UCL.CallListUpdate
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Data;
    using System.Runtime.CompilerServices;

    internal class CSVProvider : ICSVProvider
    {
        private static string a;
        private string[] b;
        private string[] c;
        private IDictionary<string, string> d;
        private IDictionary<string, char> e;
        private char f;
        private static CSVProvider g;

        static CSVProvider();
        private CSVProvider(string A_0);
        private void a();
        private NameValueCollection a(DataTable A_0);
        private string a(string A_0);
        private IDictionary<DataColumn, string> a(DataTable A_0, IDictionary<string, string> A_1);
        private DataColumn a(DataTable A_0, string[] A_1);
        private DataTable a(string A_0, bool A_1);
        private string[] a(string A_0, char A_1);
        private DataRow a(ref DataTable A_0, string A_1);
        private NameValueCollection a(DataTable A_0, DataColumn A_1, DataColumn A_2, IDictionary<DataColumn, string> A_3);
        private void a(ref string A_0, ref string A_1, DataRow A_2, DataColumn A_3, DataColumn A_4, IDictionary<DataColumn, string> A_5);
        private void b();
        private IDictionary<string, string> b(DataTable A_0);
        private string b(string A_0);
        private DataTable b(string A_0, bool A_1);
        private void b(ref DataTable A_0, string A_1);
        private IDictionary<string, string> b(DataTable A_0, DataColumn A_1, DataColumn A_2, IDictionary<DataColumn, string> A_3);
        private string[] c(string A_0);
        private bool d(string A_0);
        private string[] e(string A_0);
        private bool f(string A_0);
        private string g(string A_0);
        public static CSVProvider GetProvider(string csvFilePath);
        public IDictionary<string, string> getUnitIdAndAliasDict();
        public NameValueCollection getUnitIdAndAliasList();
        public IDictionary<string, string> getUnitIdAndSortedAliasDict();
        public bool isCsvValid();

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly CSVProvider.<>c <>9;
            public static Func<KeyValuePair<string, string>, string> <>9__10_0;

            static <>c();
            public <>c();
            internal string <getUnitIdAndSortedAliasDict>b__10_0(KeyValuePair<string, string> di);
        }
    }
}

