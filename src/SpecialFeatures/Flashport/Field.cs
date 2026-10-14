namespace SpecialFeatures.Flashport
{
    using System;

    public class Field
    {
        private string a;
        private string b;
        private bool c;

        internal Field(string name, bool visible);

        internal string Value { get; set; }

        internal string UIName { get; set; }

        internal bool Visible { get; set; }
    }
}

