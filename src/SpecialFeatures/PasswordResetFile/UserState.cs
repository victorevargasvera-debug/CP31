namespace SpecialFeatures.PasswordResetFile
{
    using System;

    public enum UserState
    {
        ConnectStart,
        ConnectError,
        ConnectDone,
        ReadRadInfoStart,
        ReadRadInfoError,
        ReadRadInfoDone,
        ResetFileValidationStart,
        ResetFileValidationDone,
        ResetFileValidationError,
        ResetPasswordStart,
        ResetPasswordDone,
        ResetPasswordError,
        None
    }
}

