using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000168 RID: 360
	public enum PermissionsPolicyFeature
	{
		// Token: 0x04000512 RID: 1298
		[global::System.Runtime.Serialization.EnumMember(Value = "accelerometer")]
		Accelerometer,
		// Token: 0x04000513 RID: 1299
		[global::System.Runtime.Serialization.EnumMember(Value = "ambient-light-sensor")]
		AmbientLightSensor,
		// Token: 0x04000514 RID: 1300
		[global::System.Runtime.Serialization.EnumMember(Value = "attribution-reporting")]
		AttributionReporting,
		// Token: 0x04000515 RID: 1301
		[global::System.Runtime.Serialization.EnumMember(Value = "autoplay")]
		Autoplay,
		// Token: 0x04000516 RID: 1302
		[global::System.Runtime.Serialization.EnumMember(Value = "bluetooth")]
		Bluetooth,
		// Token: 0x04000517 RID: 1303
		[global::System.Runtime.Serialization.EnumMember(Value = "browsing-topics")]
		BrowsingTopics,
		// Token: 0x04000518 RID: 1304
		[global::System.Runtime.Serialization.EnumMember(Value = "camera")]
		Camera,
		// Token: 0x04000519 RID: 1305
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-dpr")]
		ChDpr,
		// Token: 0x0400051A RID: 1306
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-device-memory")]
		ChDeviceMemory,
		// Token: 0x0400051B RID: 1307
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-downlink")]
		ChDownlink,
		// Token: 0x0400051C RID: 1308
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ect")]
		ChEct,
		// Token: 0x0400051D RID: 1309
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-prefers-color-scheme")]
		ChPrefersColorScheme,
		// Token: 0x0400051E RID: 1310
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-prefers-reduced-motion")]
		ChPrefersReducedMotion,
		// Token: 0x0400051F RID: 1311
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-rtt")]
		ChRtt,
		// Token: 0x04000520 RID: 1312
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-save-data")]
		ChSaveData,
		// Token: 0x04000521 RID: 1313
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ua")]
		ChUa,
		// Token: 0x04000522 RID: 1314
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ua-arch")]
		ChUaArch,
		// Token: 0x04000523 RID: 1315
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ua-bitness")]
		ChUaBitness,
		// Token: 0x04000524 RID: 1316
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ua-platform")]
		ChUaPlatform,
		// Token: 0x04000525 RID: 1317
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ua-model")]
		ChUaModel,
		// Token: 0x04000526 RID: 1318
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ua-mobile")]
		ChUaMobile,
		// Token: 0x04000527 RID: 1319
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ua-full")]
		ChUaFull,
		// Token: 0x04000528 RID: 1320
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ua-full-version")]
		ChUaFullVersion,
		// Token: 0x04000529 RID: 1321
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ua-full-version-list")]
		ChUaFullVersionList,
		// Token: 0x0400052A RID: 1322
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ua-platform-version")]
		ChUaPlatformVersion,
		// Token: 0x0400052B RID: 1323
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ua-reduced")]
		ChUaReduced,
		// Token: 0x0400052C RID: 1324
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-ua-wow64")]
		ChUaWow64,
		// Token: 0x0400052D RID: 1325
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-viewport-height")]
		ChViewportHeight,
		// Token: 0x0400052E RID: 1326
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-viewport-width")]
		ChViewportWidth,
		// Token: 0x0400052F RID: 1327
		[global::System.Runtime.Serialization.EnumMember(Value = "ch-width")]
		ChWidth,
		// Token: 0x04000530 RID: 1328
		[global::System.Runtime.Serialization.EnumMember(Value = "clipboard-read")]
		ClipboardRead,
		// Token: 0x04000531 RID: 1329
		[global::System.Runtime.Serialization.EnumMember(Value = "clipboard-write")]
		ClipboardWrite,
		// Token: 0x04000532 RID: 1330
		[global::System.Runtime.Serialization.EnumMember(Value = "compute-pressure")]
		ComputePressure,
		// Token: 0x04000533 RID: 1331
		[global::System.Runtime.Serialization.EnumMember(Value = "cross-origin-isolated")]
		CrossOriginIsolated,
		// Token: 0x04000534 RID: 1332
		[global::System.Runtime.Serialization.EnumMember(Value = "direct-sockets")]
		DirectSockets,
		// Token: 0x04000535 RID: 1333
		[global::System.Runtime.Serialization.EnumMember(Value = "display-capture")]
		DisplayCapture,
		// Token: 0x04000536 RID: 1334
		[global::System.Runtime.Serialization.EnumMember(Value = "document-domain")]
		DocumentDomain,
		// Token: 0x04000537 RID: 1335
		[global::System.Runtime.Serialization.EnumMember(Value = "encrypted-media")]
		EncryptedMedia,
		// Token: 0x04000538 RID: 1336
		[global::System.Runtime.Serialization.EnumMember(Value = "execution-while-out-of-viewport")]
		ExecutionWhileOutOfViewport,
		// Token: 0x04000539 RID: 1337
		[global::System.Runtime.Serialization.EnumMember(Value = "execution-while-not-rendered")]
		ExecutionWhileNotRendered,
		// Token: 0x0400053A RID: 1338
		[global::System.Runtime.Serialization.EnumMember(Value = "focus-without-user-activation")]
		FocusWithoutUserActivation,
		// Token: 0x0400053B RID: 1339
		[global::System.Runtime.Serialization.EnumMember(Value = "fullscreen")]
		Fullscreen,
		// Token: 0x0400053C RID: 1340
		[global::System.Runtime.Serialization.EnumMember(Value = "frobulate")]
		Frobulate,
		// Token: 0x0400053D RID: 1341
		[global::System.Runtime.Serialization.EnumMember(Value = "gamepad")]
		Gamepad,
		// Token: 0x0400053E RID: 1342
		[global::System.Runtime.Serialization.EnumMember(Value = "geolocation")]
		Geolocation,
		// Token: 0x0400053F RID: 1343
		[global::System.Runtime.Serialization.EnumMember(Value = "gyroscope")]
		Gyroscope,
		// Token: 0x04000540 RID: 1344
		[global::System.Runtime.Serialization.EnumMember(Value = "hid")]
		Hid,
		// Token: 0x04000541 RID: 1345
		[global::System.Runtime.Serialization.EnumMember(Value = "identity-credentials-get")]
		IdentityCredentialsGet,
		// Token: 0x04000542 RID: 1346
		[global::System.Runtime.Serialization.EnumMember(Value = "idle-detection")]
		IdleDetection,
		// Token: 0x04000543 RID: 1347
		[global::System.Runtime.Serialization.EnumMember(Value = "interest-cohort")]
		InterestCohort,
		// Token: 0x04000544 RID: 1348
		[global::System.Runtime.Serialization.EnumMember(Value = "join-ad-interest-group")]
		JoinAdInterestGroup,
		// Token: 0x04000545 RID: 1349
		[global::System.Runtime.Serialization.EnumMember(Value = "keyboard-map")]
		KeyboardMap,
		// Token: 0x04000546 RID: 1350
		[global::System.Runtime.Serialization.EnumMember(Value = "local-fonts")]
		LocalFonts,
		// Token: 0x04000547 RID: 1351
		[global::System.Runtime.Serialization.EnumMember(Value = "magnetometer")]
		Magnetometer,
		// Token: 0x04000548 RID: 1352
		[global::System.Runtime.Serialization.EnumMember(Value = "microphone")]
		Microphone,
		// Token: 0x04000549 RID: 1353
		[global::System.Runtime.Serialization.EnumMember(Value = "midi")]
		Midi,
		// Token: 0x0400054A RID: 1354
		[global::System.Runtime.Serialization.EnumMember(Value = "otp-credentials")]
		OtpCredentials,
		// Token: 0x0400054B RID: 1355
		[global::System.Runtime.Serialization.EnumMember(Value = "payment")]
		Payment,
		// Token: 0x0400054C RID: 1356
		[global::System.Runtime.Serialization.EnumMember(Value = "picture-in-picture")]
		PictureInPicture,
		// Token: 0x0400054D RID: 1357
		[global::System.Runtime.Serialization.EnumMember(Value = "private-aggregation")]
		PrivateAggregation,
		// Token: 0x0400054E RID: 1358
		[global::System.Runtime.Serialization.EnumMember(Value = "private-state-token-issuance")]
		PrivateStateTokenIssuance,
		// Token: 0x0400054F RID: 1359
		[global::System.Runtime.Serialization.EnumMember(Value = "private-state-token-redemption")]
		PrivateStateTokenRedemption,
		// Token: 0x04000550 RID: 1360
		[global::System.Runtime.Serialization.EnumMember(Value = "publickey-credentials-get")]
		PublickeyCredentialsGet,
		// Token: 0x04000551 RID: 1361
		[global::System.Runtime.Serialization.EnumMember(Value = "run-ad-auction")]
		RunAdAuction,
		// Token: 0x04000552 RID: 1362
		[global::System.Runtime.Serialization.EnumMember(Value = "screen-wake-lock")]
		ScreenWakeLock,
		// Token: 0x04000553 RID: 1363
		[global::System.Runtime.Serialization.EnumMember(Value = "serial")]
		Serial,
		// Token: 0x04000554 RID: 1364
		[global::System.Runtime.Serialization.EnumMember(Value = "shared-autofill")]
		SharedAutofill,
		// Token: 0x04000555 RID: 1365
		[global::System.Runtime.Serialization.EnumMember(Value = "shared-storage")]
		SharedStorage,
		// Token: 0x04000556 RID: 1366
		[global::System.Runtime.Serialization.EnumMember(Value = "shared-storage-select-url")]
		SharedStorageSelectUrl,
		// Token: 0x04000557 RID: 1367
		[global::System.Runtime.Serialization.EnumMember(Value = "smart-card")]
		SmartCard,
		// Token: 0x04000558 RID: 1368
		[global::System.Runtime.Serialization.EnumMember(Value = "storage-access")]
		StorageAccess,
		// Token: 0x04000559 RID: 1369
		[global::System.Runtime.Serialization.EnumMember(Value = "sync-xhr")]
		SyncXhr,
		// Token: 0x0400055A RID: 1370
		[global::System.Runtime.Serialization.EnumMember(Value = "unload")]
		Unload,
		// Token: 0x0400055B RID: 1371
		[global::System.Runtime.Serialization.EnumMember(Value = "usb")]
		Usb,
		// Token: 0x0400055C RID: 1372
		[global::System.Runtime.Serialization.EnumMember(Value = "vertical-scroll")]
		VerticalScroll,
		// Token: 0x0400055D RID: 1373
		[global::System.Runtime.Serialization.EnumMember(Value = "web-share")]
		WebShare,
		// Token: 0x0400055E RID: 1374
		[global::System.Runtime.Serialization.EnumMember(Value = "window-management")]
		WindowManagement,
		// Token: 0x0400055F RID: 1375
		[global::System.Runtime.Serialization.EnumMember(Value = "window-placement")]
		WindowPlacement,
		// Token: 0x04000560 RID: 1376
		[global::System.Runtime.Serialization.EnumMember(Value = "xr-spatial-tracking")]
		XrSpatialTracking
	}
}
