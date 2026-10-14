namespace SpecialFeatures.Flashport.FlashkeyLib
{
    using System;
    using System.Collections.Generic;

    internal sealed class FlashkeyLayout
    {
        private Dictionary<FieldType, FieldLayout> a;
        private bool b;
        private int c;
        private int d;
        private int e;
        private int f;

        public FlashkeyLayout();
        private byte a(byte[] A_0);
        private object a(FieldLayout A_0, byte[] A_1);
        private void a(FieldLayout A_0, ref byte[] A_1, object A_2);
        internal byte[] GetAllData(byte[] data, byte[] keyData);
        internal byte[] GetDecryptedData(byte[] fkeyData);
        internal byte[] GetEncryptedData(byte[] fkeyData);
        internal object GetFieldValue(FieldType fieldType, byte[] data);
        internal bool InitLayout(byte[] fkeyData);
        internal void SetFieldValue(FieldType fieldType, ref byte[] data, object value);

        internal bool ValidLayout { get; }

        internal int KeyDecDataSize { get; }
    }
}

