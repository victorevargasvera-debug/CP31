using System;

namespace Ionic.Zip
{
	// Token: 0x02000472 RID: 1138
	internal class SelfExtractorSaveOptions
	{
		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x060031F3 RID: 12787 RVA: 0x000B7384 File Offset: 0x000B5584
		// (set) Token: 0x060031F4 RID: 12788 RVA: 0x000B738C File Offset: 0x000B558C
		public global::Ionic.Zip.SelfExtractorFlavor Flavor { get; set; }

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x000B7398 File Offset: 0x000B5598
		// (set) Token: 0x060031F6 RID: 12790 RVA: 0x000B73A0 File Offset: 0x000B55A0
		public string PostExtractCommandLine { get; set; }

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x060031F7 RID: 12791 RVA: 0x000B73AC File Offset: 0x000B55AC
		// (set) Token: 0x060031F8 RID: 12792 RVA: 0x000B73B4 File Offset: 0x000B55B4
		public string DefaultExtractDirectory { get; set; }

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x060031F9 RID: 12793 RVA: 0x000B73C0 File Offset: 0x000B55C0
		// (set) Token: 0x060031FA RID: 12794 RVA: 0x000B73C8 File Offset: 0x000B55C8
		public string IconFile { get; set; }

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x060031FB RID: 12795 RVA: 0x000B73D4 File Offset: 0x000B55D4
		// (set) Token: 0x060031FC RID: 12796 RVA: 0x000B73DC File Offset: 0x000B55DC
		public bool Quiet { get; set; }

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x060031FD RID: 12797 RVA: 0x000B73E8 File Offset: 0x000B55E8
		// (set) Token: 0x060031FE RID: 12798 RVA: 0x000B73F0 File Offset: 0x000B55F0
		public global::Ionic.Zip.ExtractExistingFileAction ExtractExistingFile { get; set; }

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x060031FF RID: 12799 RVA: 0x000B73FC File Offset: 0x000B55FC
		// (set) Token: 0x06003200 RID: 12800 RVA: 0x000B7404 File Offset: 0x000B5604
		public bool RemoveUnpackedFilesAfterExecute { get; set; }

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x000B7410 File Offset: 0x000B5610
		// (set) Token: 0x06003202 RID: 12802 RVA: 0x000B7418 File Offset: 0x000B5618
		public global::System.Version FileVersion { get; set; }

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06003203 RID: 12803 RVA: 0x000B7424 File Offset: 0x000B5624
		// (set) Token: 0x06003204 RID: 12804 RVA: 0x000B742C File Offset: 0x000B562C
		public string ProductVersion { get; set; }

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06003205 RID: 12805 RVA: 0x000B7438 File Offset: 0x000B5638
		// (set) Token: 0x06003206 RID: 12806 RVA: 0x000B7440 File Offset: 0x000B5640
		public string Copyright { get; set; }

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06003207 RID: 12807 RVA: 0x000B744C File Offset: 0x000B564C
		// (set) Token: 0x06003208 RID: 12808 RVA: 0x000B7454 File Offset: 0x000B5654
		public string Description { get; set; }

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06003209 RID: 12809 RVA: 0x000B7460 File Offset: 0x000B5660
		// (set) Token: 0x0600320A RID: 12810 RVA: 0x000B7468 File Offset: 0x000B5668
		public string ProductName { get; set; }

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x0600320B RID: 12811 RVA: 0x000B7474 File Offset: 0x000B5674
		// (set) Token: 0x0600320C RID: 12812 RVA: 0x000B747C File Offset: 0x000B567C
		public string SfxExeWindowTitle { get; set; }

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x0600320D RID: 12813 RVA: 0x000B7488 File Offset: 0x000B5688
		// (set) Token: 0x0600320E RID: 12814 RVA: 0x000B7490 File Offset: 0x000B5690
		public string AdditionalCompilerSwitches { get; set; }
	}
}
