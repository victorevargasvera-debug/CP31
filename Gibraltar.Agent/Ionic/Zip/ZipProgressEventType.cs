using System;

namespace Ionic.Zip
{
	// Token: 0x0200044F RID: 1103
	internal enum ZipProgressEventType
	{
		// Token: 0x04001157 RID: 4439
		Adding_Started,
		// Token: 0x04001158 RID: 4440
		Adding_AfterAddEntry,
		// Token: 0x04001159 RID: 4441
		Adding_Completed,
		// Token: 0x0400115A RID: 4442
		Reading_Started,
		// Token: 0x0400115B RID: 4443
		Reading_BeforeReadEntry,
		// Token: 0x0400115C RID: 4444
		Reading_AfterReadEntry,
		// Token: 0x0400115D RID: 4445
		Reading_Completed,
		// Token: 0x0400115E RID: 4446
		Reading_ArchiveBytesRead,
		// Token: 0x0400115F RID: 4447
		Saving_Started,
		// Token: 0x04001160 RID: 4448
		Saving_BeforeWriteEntry,
		// Token: 0x04001161 RID: 4449
		Saving_AfterWriteEntry,
		// Token: 0x04001162 RID: 4450
		Saving_Completed,
		// Token: 0x04001163 RID: 4451
		Saving_AfterSaveTempArchive,
		// Token: 0x04001164 RID: 4452
		Saving_BeforeRenameTempArchive,
		// Token: 0x04001165 RID: 4453
		Saving_AfterRenameTempArchive,
		// Token: 0x04001166 RID: 4454
		Saving_AfterCompileSelfExtractor,
		// Token: 0x04001167 RID: 4455
		Saving_EntryBytesRead,
		// Token: 0x04001168 RID: 4456
		Extracting_BeforeExtractEntry,
		// Token: 0x04001169 RID: 4457
		Extracting_AfterExtractEntry,
		// Token: 0x0400116A RID: 4458
		Extracting_ExtractEntryWouldOverwrite,
		// Token: 0x0400116B RID: 4459
		Extracting_EntryBytesWritten,
		// Token: 0x0400116C RID: 4460
		Extracting_BeforeExtractAll,
		// Token: 0x0400116D RID: 4461
		Extracting_AfterExtractAll,
		// Token: 0x0400116E RID: 4462
		Error_Saving
	}
}
