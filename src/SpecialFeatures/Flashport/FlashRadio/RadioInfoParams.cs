namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;

    public class RadioInfoParams
    {
        private string a;
        private string b;
        private string c;

        internal RadioInfoParams(string model, string serial, string fcode);

        internal string ModelNumber { get; private set; }

        internal string SerialNumber { get; private set; }

        internal string Flashcode { get; private set; }
    }
}

