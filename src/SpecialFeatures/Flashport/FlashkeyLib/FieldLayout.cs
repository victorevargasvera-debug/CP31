namespace SpecialFeatures.Flashport.FlashkeyLib
{
    using System;

    internal sealed class FieldLayout
    {
        private FieldType a;
        private int b;
        private int c;
        private TypeCode d;
        private StringEncoding e;

        internal FieldLayout(FieldType name, int size, int offset, TypeCode typeCode);
        internal FieldLayout(FieldType name, int size, int offset, TypeCode typeCode, StringEncoding encoding);

        internal int Size { get; }

        internal int Offset { get; }

        internal FieldType Name { get; }

        internal TypeCode TCode { get; }

        internal StringEncoding Encoding { get; }
    }
}

