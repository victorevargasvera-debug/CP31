namespace SpecialFeatures.Clone_Configuration.Common
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    internal class ClearAndRestorePassword
    {
        private readonly Queue<string> a;
        private readonly Recordset b;
        private readonly string c;

        public ClearAndRestorePassword(Recordset recordSet, string fieldName);
        [CompilerGenerated]
        private bool a(IAcpField A_0);
        [CompilerGenerated]
        private bool b(IAcpField A_0);
        public void ClearFieldsAndRemember(Func<string, string> encryptionMethodAction);
        public void RestorePasswordsAndForgot(Func<string, string> encryptionMethodAction, int trimPassword);
    }
}

