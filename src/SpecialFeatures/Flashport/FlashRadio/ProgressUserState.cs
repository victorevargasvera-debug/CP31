namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;

    public class ProgressUserState
    {
        private string a;
        private UserState b;
        private UserState c;

        public ProgressUserState(UserState currUS, UserState newUS, string msg);

        internal string UserText { get; private set; }

        internal UserState CurrentUserState { get; private set; }

        internal UserState NewUserState { get; private set; }
    }
}

