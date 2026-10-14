namespace SpecialFeatures.FCCExceptionHandler
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Xml;

    public class FCCExceptionHandler
    {
        private static SpecialFeatures.FCCExceptionHandler.FCCExceptionHandler a;
        private string b;

        static FCCExceptionHandler();
        private FCCExceptionHandler();
        private XmlDocument a();
        private void a(Dictionary<string, List<BaseSection>> A_0);
        private Dictionary<string, List<BaseSection>> a(XmlDocument A_0);
        public void InitExceptionList();

        public static SpecialFeatures.FCCExceptionHandler.FCCExceptionHandler Instance { get; }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass7_0
        {
            public string listIncludeType;

            public <>c__DisplayClass7_0();
            internal bool <LoadConfigFile>b__0(BaseSection x);
        }
    }
}

