using System;

namespace Motorola.CommonCPS.RadioManagement.Global
{
	// Token: 0x0200000C RID: 12
	public static class Constants
	{
		// Token: 0x0400001E RID: 30
		public const string REG_USERPIN = "^[0-9A-Za-z\\s*/#/$/&/%/*/ /\\-/+///]{0,20}$";

		// Token: 0x0400001F RID: 31
		public const string XPBAFILE_SUFFIX = ".xpba";

		// Token: 0x04000020 RID: 32
		public const string PCR_ARCHIVEFile_SUFFIX = ".ctb";

		// Token: 0x04000021 RID: 33
		public const string EXTENDED_ARCHIVEFile_SUFFIX = ".ctb2";

		// Token: 0x04000022 RID: 34
		public const string ASTRO_ARCHIVEFile_SUFFIX = ".mc";

		// Token: 0x04000023 RID: 35
		public const string MigrateFolderName_PBA = "PBARepository";

		// Token: 0x04000024 RID: 36
		public const string MigrateFolderName_ARCHIVE = "ArchiveRepository";

		// Token: 0x04000025 RID: 37
		public const string OpenArchiveIdentifier = "ConfigCPSGuid=";

		// Token: 0x04000026 RID: 38
		public const int MAX_RECENT_OPEN_FILE_NUMBER = 10;

		// Token: 0x04000027 RID: 39
		public const int TRYTIMES_PER_BAR = 50;

		// Token: 0x04000028 RID: 40
		public const int NAV_PATH_MAX_LENGTH = 20;

		// Token: 0x0200000D RID: 13
		public enum RadioUpdateStatus
		{
			// Token: 0x0400002A RID: 42
			None,
			// Token: 0x0400002B RID: 43
			UpdatingFirmware,
			// Token: 0x0400002C RID: 44
			UpdatingCodeplug,
			// Token: 0x0400002D RID: 45
			UpdatingSecure,
			// Token: 0x0400002E RID: 46
			UpdatingFont,
			// Token: 0x0400002F RID: 47
			UpdatingControlHead,
			// Token: 0x04000030 RID: 48
			NoReponse = 99
		}
	}
}
