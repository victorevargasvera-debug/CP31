using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000023 RID: 35
	public enum UpdateControlAction : byte
	{
		// Token: 0x0400009D RID: 157
		None,
		// Token: 0x0400009E RID: 158
		RadioFirmwareActive,
		// Token: 0x0400009F RID: 159
		RadioCodeplugActive,
		// Token: 0x040000A0 RID: 160
		RadioUpdateFirmware,
		// Token: 0x040000A1 RID: 161
		RadioUpdateCodeplug,
		// Token: 0x040000A2 RID: 162
		RadioValidateFirmware,
		// Token: 0x040000A3 RID: 163
		RadioValidateCodeplug,
		// Token: 0x040000A4 RID: 164
		RadioDefaultAddrMode,
		// Token: 0x040000A5 RID: 165
		RadioAbsAddrMode,
		// Token: 0x040000A6 RID: 166
		StopBGEraser,
		// Token: 0x040000A7 RID: 167
		UpdateStatus,
		// Token: 0x040000A8 RID: 168
		SetDecomp,
		// Token: 0x040000A9 RID: 169
		SetChecksum,
		// Token: 0x040000AA RID: 170
		CHBootAppUpdate,
		// Token: 0x040000AB RID: 171
		OBBootAppUpdate,
		// Token: 0x040000AC RID: 172
		COBootAppUpdate,
		// Token: 0x040000AD RID: 173
		CommitUpdate,
		// Token: 0x040000AE RID: 174
		OverwriteActivePartition = 18,
		// Token: 0x040000AF RID: 175
		GetDownloadProgress = 20,
		// Token: 0x040000B0 RID: 176
		SetDownloadTGVersion,
		// Token: 0x040000B1 RID: 177
		PasswordReset = 25
	}
}
