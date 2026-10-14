namespace SpecialFeatures.Model_Configuration
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class ErrorException : Exception
    {
        internal string _message;
        internal long _messageId;

        internal ErrorException(long MessageId);
        internal ErrorException(string Message);
        internal ErrorException(long MessageId, string Message);
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}

