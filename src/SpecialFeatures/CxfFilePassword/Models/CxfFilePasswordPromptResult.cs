namespace SpecialFeatures.CxfFilePassword.Models
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    internal class CxfFilePasswordPromptResult
    {
        [CompilerGenerated]
        private SecureString a;
        [CompilerGenerated]
        private bool b;
        [CompilerGenerated]
        private bool c;

        public CxfFilePasswordPromptResult();

        internal SecureString ProvidedPassword { get; set; }

        internal bool Cancelled { get; set; }

        internal bool RememberCxfFilePassword { get; set; }
    }
}

