namespace SpecialFeatures.CxfFilePassword.Models
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    internal class CxfFileInitializePasswordPromptResult : CxfFilePasswordPromptResult
    {
        [CompilerGenerated]
        private SecureString a;

        public CxfFileInitializePasswordPromptResult();

        internal SecureString ConfirmedProvidedPassword { get; set; }
    }
}

