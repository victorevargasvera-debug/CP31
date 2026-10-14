namespace SpecialFeatures.FileOperations
{
    using System;
    using System.Runtime.CompilerServices;

    public class FileOperationReturnEventArgs
    {
        [CompilerGenerated]
        private readonly DialogResult a;
        [CompilerGenerated]
        private readonly object b;

        internal FileOperationReturnEventArgs(DialogResult result, object data);

        internal DialogResult Result { get; }

        internal object Data { get; }
    }
}

