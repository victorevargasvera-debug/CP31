namespace SpecialFeatures.PasswordResetFile
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class PasswordResetException : Exception
    {
        public PasswordResetException(string message);
        internal PasswordResetException(SerializationInfo info, StreamingContext context);
        internal PasswordResetException(string message, Exception innerException);
        internal PasswordResetException(string message, string details);
        internal PasswordResetException(string message, string details, Exception innerException);
    }
}

