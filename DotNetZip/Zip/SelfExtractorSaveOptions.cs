using System;

namespace Ionic.Zip
{
	// Token: 0x0200002C RID: 44
	public class SelfExtractorSaveOptions
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000CCCD File Offset: 0x0000AECD
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0000CCD5 File Offset: 0x0000AED5
		public global::Ionic.Zip.SelfExtractorFlavor Flavor { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000CCDE File Offset: 0x0000AEDE
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0000CCE6 File Offset: 0x0000AEE6
		public string PostExtractCommandLine { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0000CCEF File Offset: 0x0000AEEF
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0000CCF7 File Offset: 0x0000AEF7
		public string DefaultExtractDirectory { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000CD00 File Offset: 0x0000AF00
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0000CD08 File Offset: 0x0000AF08
		public string IconFile { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000CD11 File Offset: 0x0000AF11
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0000CD19 File Offset: 0x0000AF19
		public bool Quiet { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000CD22 File Offset: 0x0000AF22
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0000CD2A File Offset: 0x0000AF2A
		public global::Ionic.Zip.ExtractExistingFileAction ExtractExistingFile { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000CD33 File Offset: 0x0000AF33
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0000CD3B File Offset: 0x0000AF3B
		public bool RemoveUnpackedFilesAfterExecute { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000CD44 File Offset: 0x0000AF44
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		public global::System.Version FileVersion { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0000CD55 File Offset: 0x0000AF55
		// (set) Token: 0x06000187 RID: 391 RVA: 0x0000CD5D File Offset: 0x0000AF5D
		public string ProductVersion { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000CD66 File Offset: 0x0000AF66
		// (set) Token: 0x06000189 RID: 393 RVA: 0x0000CD6E File Offset: 0x0000AF6E
		public string Copyright { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000CD77 File Offset: 0x0000AF77
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0000CD7F File Offset: 0x0000AF7F
		public string Description { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000CD88 File Offset: 0x0000AF88
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0000CD90 File Offset: 0x0000AF90
		public string ProductName { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000CD99 File Offset: 0x0000AF99
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0000CDA1 File Offset: 0x0000AFA1
		public string SfxExeWindowTitle { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000CDAA File Offset: 0x0000AFAA
		// (set) Token: 0x06000191 RID: 401 RVA: 0x0000CDB2 File Offset: 0x0000AFB2
		public string AdditionalCompilerSwitches { get; set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000CDBB File Offset: 0x0000AFBB
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0000CDC3 File Offset: 0x0000AFC3
		public string CompilerVersion { get; set; }
	}
}
