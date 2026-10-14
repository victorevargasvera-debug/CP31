namespace SpecialFeatures.RadioLanguagePack
{
    using System;

    public class BinarySeralizeDeserialize
    {
        public BinarySeralizeDeserialize();
        internal static T Deserialize<T>(byte[] array);
        internal static byte[] Serialize(object instance);
    }
}

