using System;

namespace CefSharp
{
	// Token: 0x02000038 RID: 56
	[global::System.Flags]
	public enum MediaAccessPermissionType : uint
	{
		// Token: 0x040001DE RID: 478
		None = 0U,
		// Token: 0x040001DF RID: 479
		AudioCapture = 1U,
		// Token: 0x040001E0 RID: 480
		VideoCapture = 2U,
		// Token: 0x040001E1 RID: 481
		DesktopAudioCapture = 4U,
		// Token: 0x040001E2 RID: 482
		DesktopVideoCapture = 8U
	}
}
