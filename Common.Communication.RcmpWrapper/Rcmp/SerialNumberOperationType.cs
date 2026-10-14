using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000048 RID: 72
	public enum SerialNumberOperationType : byte
	{
		// Token: 0x04000153 RID: 339
		ReadRadioSerialNumber,
		// Token: 0x04000154 RID: 340
		WriteRadioSerialNumber,
		// Token: 0x04000155 RID: 341
		ReadESN,
		// Token: 0x04000156 RID: 342
		WriteESN,
		// Token: 0x04000157 RID: 343
		ReadMACAddress,
		// Token: 0x04000158 RID: 344
		WriteMACAddress,
		// Token: 0x04000159 RID: 345
		ReadProductSerialNumber,
		// Token: 0x0400015A RID: 346
		WriteProductSerialNumber,
		// Token: 0x0400015B RID: 347
		ReadOptionBoardSerialNumber,
		// Token: 0x0400015C RID: 348
		WriteOptionBoardSerialNumber,
		// Token: 0x0400015D RID: 349
		ReadWiFiMACAddress,
		// Token: 0x0400015E RID: 350
		WriteWiFiMACAddress
	}
}
