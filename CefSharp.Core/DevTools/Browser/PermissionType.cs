using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x02000331 RID: 817
	public enum PermissionType
	{
		// Token: 0x04000CC6 RID: 3270
		[global::System.Runtime.Serialization.EnumMember(Value = "accessibilityEvents")]
		AccessibilityEvents,
		// Token: 0x04000CC7 RID: 3271
		[global::System.Runtime.Serialization.EnumMember(Value = "audioCapture")]
		AudioCapture,
		// Token: 0x04000CC8 RID: 3272
		[global::System.Runtime.Serialization.EnumMember(Value = "backgroundSync")]
		BackgroundSync,
		// Token: 0x04000CC9 RID: 3273
		[global::System.Runtime.Serialization.EnumMember(Value = "backgroundFetch")]
		BackgroundFetch,
		// Token: 0x04000CCA RID: 3274
		[global::System.Runtime.Serialization.EnumMember(Value = "clipboardReadWrite")]
		ClipboardReadWrite,
		// Token: 0x04000CCB RID: 3275
		[global::System.Runtime.Serialization.EnumMember(Value = "clipboardSanitizedWrite")]
		ClipboardSanitizedWrite,
		// Token: 0x04000CCC RID: 3276
		[global::System.Runtime.Serialization.EnumMember(Value = "displayCapture")]
		DisplayCapture,
		// Token: 0x04000CCD RID: 3277
		[global::System.Runtime.Serialization.EnumMember(Value = "durableStorage")]
		DurableStorage,
		// Token: 0x04000CCE RID: 3278
		[global::System.Runtime.Serialization.EnumMember(Value = "flash")]
		Flash,
		// Token: 0x04000CCF RID: 3279
		[global::System.Runtime.Serialization.EnumMember(Value = "geolocation")]
		Geolocation,
		// Token: 0x04000CD0 RID: 3280
		[global::System.Runtime.Serialization.EnumMember(Value = "idleDetection")]
		IdleDetection,
		// Token: 0x04000CD1 RID: 3281
		[global::System.Runtime.Serialization.EnumMember(Value = "localFonts")]
		LocalFonts,
		// Token: 0x04000CD2 RID: 3282
		[global::System.Runtime.Serialization.EnumMember(Value = "midi")]
		Midi,
		// Token: 0x04000CD3 RID: 3283
		[global::System.Runtime.Serialization.EnumMember(Value = "midiSysex")]
		MidiSysex,
		// Token: 0x04000CD4 RID: 3284
		[global::System.Runtime.Serialization.EnumMember(Value = "nfc")]
		Nfc,
		// Token: 0x04000CD5 RID: 3285
		[global::System.Runtime.Serialization.EnumMember(Value = "notifications")]
		Notifications,
		// Token: 0x04000CD6 RID: 3286
		[global::System.Runtime.Serialization.EnumMember(Value = "paymentHandler")]
		PaymentHandler,
		// Token: 0x04000CD7 RID: 3287
		[global::System.Runtime.Serialization.EnumMember(Value = "periodicBackgroundSync")]
		PeriodicBackgroundSync,
		// Token: 0x04000CD8 RID: 3288
		[global::System.Runtime.Serialization.EnumMember(Value = "protectedMediaIdentifier")]
		ProtectedMediaIdentifier,
		// Token: 0x04000CD9 RID: 3289
		[global::System.Runtime.Serialization.EnumMember(Value = "sensors")]
		Sensors,
		// Token: 0x04000CDA RID: 3290
		[global::System.Runtime.Serialization.EnumMember(Value = "storageAccess")]
		StorageAccess,
		// Token: 0x04000CDB RID: 3291
		[global::System.Runtime.Serialization.EnumMember(Value = "topLevelStorageAccess")]
		TopLevelStorageAccess,
		// Token: 0x04000CDC RID: 3292
		[global::System.Runtime.Serialization.EnumMember(Value = "videoCapture")]
		VideoCapture,
		// Token: 0x04000CDD RID: 3293
		[global::System.Runtime.Serialization.EnumMember(Value = "videoCapturePanTiltZoom")]
		VideoCapturePanTiltZoom,
		// Token: 0x04000CDE RID: 3294
		[global::System.Runtime.Serialization.EnumMember(Value = "wakeLockScreen")]
		WakeLockScreen,
		// Token: 0x04000CDF RID: 3295
		[global::System.Runtime.Serialization.EnumMember(Value = "wakeLockSystem")]
		WakeLockSystem,
		// Token: 0x04000CE0 RID: 3296
		[global::System.Runtime.Serialization.EnumMember(Value = "windowManagement")]
		WindowManagement
	}
}
