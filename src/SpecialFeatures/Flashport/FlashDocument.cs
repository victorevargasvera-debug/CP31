namespace SpecialFeatures.Flashport
{
    using System;
    using System.Collections.Generic;

    public class FlashDocument
    {
        private Dictionary<int, Recordset> a;

        public FlashDocument();
        protected internal void AddFeature(Recordset recset);
        public void Clear();
        internal Recordset GetFeature(int id);
    }
}

