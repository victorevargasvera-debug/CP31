using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200003F RID: 63
	public enum RadioStatusCondition : byte
	{
		// Token: 0x04000117 RID: 279
		Squelch,
		// Token: 0x04000118 RID: 280
		SynthesizerLockDetect,
		// Token: 0x04000119 RID: 281
		RSSI,
		// Token: 0x0400011A RID: 282
		BatteryValue,
		// Token: 0x0400011B RID: 283
		LowBattery,
		// Token: 0x0400011C RID: 284
		PowerUpStatus,
		// Token: 0x0400011D RID: 285
		AbacusTuningStatus,
		// Token: 0x0400011E RID: 286
		ModelNumber,
		// Token: 0x0400011F RID: 287
		SerialNumber,
		// Token: 0x04000120 RID: 288
		ReadESN,
		// Token: 0x04000121 RID: 289
		IFInputSignalStrength,
		// Token: 0x04000122 RID: 290
		ReadProductSerialNumber,
		// Token: 0x04000123 RID: 291
		FrequencyOffset,
		// Token: 0x04000124 RID: 292
		CurrentSignallingMode,
		// Token: 0x04000125 RID: 293
		RadioID,
		// Token: 0x04000126 RID: 294
		RadioAlias,
		// Token: 0x04000127 RID: 295
		GenericOptionBoardAvailable,
		// Token: 0x04000128 RID: 296
		BanditWirelineBoardAvailable,
		// Token: 0x04000129 RID: 297
		AlternativeImageStatusOfBanditControllerFPGA,
		// Token: 0x0400012A RID: 298
		AlternativeImageStatusOfBanditWirelineFPGA,
		// Token: 0x0400012B RID: 299
		NeptuneFeatureStatus,
		// Token: 0x0400012C RID: 300
		MeterStatusOfBanditFPGA,
		// Token: 0x0400012D RID: 301
		Select5RadioID,
		// Token: 0x0400012E RID: 302
		PrivacyType,
		// Token: 0x0400012F RID: 303
		BluetoothAddress,
		// Token: 0x04000130 RID: 304
		SidebandSuppression,
		// Token: 0x04000131 RID: 305
		RadioUpdateStatus = 45,
		// Token: 0x04000132 RID: 306
		PhysicalSerialNumber = 75,
		// Token: 0x04000133 RID: 307
		DefaultGatewayNetworkAttachment = 78,
		// Token: 0x04000134 RID: 308
		SMADate = 80,
		// Token: 0x04000135 RID: 309
		WarrantyDate
	}
}
