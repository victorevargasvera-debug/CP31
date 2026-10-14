namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UpgradeRadioException : Exception, ISerializable
    {
        public UpgradeRadioException(string message);
        internal UpgradeRadioException(SerializationInfo info, StreamingContext context);
        internal UpgradeRadioException(string message, Exception innerException);
        internal UpgradeRadioException(string message, string details);
        internal UpgradeRadioException(string message, string details, Exception innerException);

        internal string Details { get; }
    }
}

