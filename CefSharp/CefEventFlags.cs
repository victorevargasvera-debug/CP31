using System;

namespace CefSharp
{
	// Token: 0x02000025 RID: 37
	[global::System.Flags]
	public enum CefEventFlags : uint
	{
		// Token: 0x04000139 RID: 313
		None = 0U,
		// Token: 0x0400013A RID: 314
		CapsLockOn = 1U,
		// Token: 0x0400013B RID: 315
		ShiftDown = 2U,
		// Token: 0x0400013C RID: 316
		ControlDown = 4U,
		// Token: 0x0400013D RID: 317
		AltDown = 8U,
		// Token: 0x0400013E RID: 318
		LeftMouseButton = 16U,
		// Token: 0x0400013F RID: 319
		MiddleMouseButton = 32U,
		// Token: 0x04000140 RID: 320
		RightMouseButton = 64U,
		// Token: 0x04000141 RID: 321
		CommandDown = 128U,
		// Token: 0x04000142 RID: 322
		NumLockOn = 256U,
		// Token: 0x04000143 RID: 323
		IsKeyPad = 512U,
		// Token: 0x04000144 RID: 324
		IsLeft = 1024U,
		// Token: 0x04000145 RID: 325
		IsRight = 2048U,
		// Token: 0x04000146 RID: 326
		AltGrDown = 4096U,
		// Token: 0x04000147 RID: 327
		IsRepeat = 8192U
	}
}
