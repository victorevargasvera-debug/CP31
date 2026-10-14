using System;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000015 RID: 21
	[global::System.Flags]
	public enum ChangeIndicator
	{
		// Token: 0x040000AA RID: 170
		CP = 1,
		// Token: 0x040000AB RID: 171
		FW = 2,
		// Token: 0x040000AC RID: 172
		VA = 4,
		// Token: 0x040000AD RID: 173
		LP = 8,
		// Token: 0x040000AE RID: 174
		Apx_FlashCode = 16,
		// Token: 0x040000AF RID: 175
		Matrix_CFS = 32,
		// Token: 0x040000B0 RID: 176
		MisMatch = 64,
		// Token: 0x040000B1 RID: 177
		GeneralPackage = 128,
		// Token: 0x040000B2 RID: 178
		PBB_Apps = 256,
		// Token: 0x040000B3 RID: 179
		PBB_CFS = 512,
		// Token: 0x040000B4 RID: 180
		TTS = 1024,
		// Token: 0x040000B5 RID: 181
		PBB_HomeSet = 2048,
		// Token: 0x040000B6 RID: 182
		PBB_Certificate = 4096
	}
}
