using System;

namespace SpecialFeatures.PasswordResetFile
{
	// Token: 0x020000AB RID: 171
	public enum UserState
	{
		// Token: 0x0400051A RID: 1306
		ConnectStart,
		// Token: 0x0400051B RID: 1307
		ConnectError,
		// Token: 0x0400051C RID: 1308
		ConnectDone,
		// Token: 0x0400051D RID: 1309
		ReadRadInfoStart,
		// Token: 0x0400051E RID: 1310
		ReadRadInfoError,
		// Token: 0x0400051F RID: 1311
		ReadRadInfoDone,
		// Token: 0x04000520 RID: 1312
		ResetFileValidationStart,
		// Token: 0x04000521 RID: 1313
		ResetFileValidationDone,
		// Token: 0x04000522 RID: 1314
		ResetFileValidationError,
		// Token: 0x04000523 RID: 1315
		ResetPasswordStart,
		// Token: 0x04000524 RID: 1316
		ResetPasswordDone,
		// Token: 0x04000525 RID: 1317
		ResetPasswordError,
		// Token: 0x04000526 RID: 1318
		None
	}
}
