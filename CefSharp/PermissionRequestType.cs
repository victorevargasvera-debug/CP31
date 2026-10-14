using System;

namespace CefSharp
{
	// Token: 0x0200003D RID: 61
	[global::System.Flags]
	public enum PermissionRequestType : uint
	{
		// Token: 0x040001F7 RID: 503
		None = 0U,
		// Token: 0x040001F8 RID: 504
		AccessibilityEvents = 1U,
		// Token: 0x040001F9 RID: 505
		ArSession = 2U,
		// Token: 0x040001FA RID: 506
		CameraPanTiltZoom = 4U,
		// Token: 0x040001FB RID: 507
		CameraStream = 8U,
		// Token: 0x040001FC RID: 508
		Clipboard = 16U,
		// Token: 0x040001FD RID: 509
		DiskQuota = 32U,
		// Token: 0x040001FE RID: 510
		LocalFonts = 64U,
		// Token: 0x040001FF RID: 511
		Geolocation = 128U,
		// Token: 0x04000200 RID: 512
		IdleDetection = 256U,
		// Token: 0x04000201 RID: 513
		MicStream = 512U,
		// Token: 0x04000202 RID: 514
		MidiSysex = 1024U,
		// Token: 0x04000203 RID: 515
		MultipleDownloads = 2048U,
		// Token: 0x04000204 RID: 516
		Notifications = 4096U,
		// Token: 0x04000205 RID: 517
		ProtectedMediaIdentifier = 8192U,
		// Token: 0x04000206 RID: 518
		RegisterProtocolHandler = 16384U,
		// Token: 0x04000207 RID: 519
		SecurityAttestation = 32768U,
		// Token: 0x04000208 RID: 520
		StorageAccess = 65536U,
		// Token: 0x04000209 RID: 521
		U2FApiRequest = 131072U,
		// Token: 0x0400020A RID: 522
		VrSession = 262144U,
		// Token: 0x0400020B RID: 523
		WindowPlacement = 524288U
	}
}
