namespace SpecialFeatures.PasswordResetFile
{
    using System;
    using System.Runtime.CompilerServices;

    public class ProgressUserState
    {
        [CompilerGenerated]
        private readonly string a;
        [CompilerGenerated]
        private readonly UserState b;
        [CompilerGenerated]
        private readonly UserState c;

        public ProgressUserState(UserState currUS, UserState newUS, string msg);

        internal string UserText { get; }

        internal UserState CurrentUserState { get; }

        internal UserState NewUserState { get; }
    }
}

