using System;

namespace Ionic.Zip
{
	// Token: 0x02000034 RID: 52
	public enum ZipProgressEventType
	{
		// Token: 0x040001D2 RID: 466
		Adding_Started,
		// Token: 0x040001D3 RID: 467
		Adding_AfterAddEntry,
		// Token: 0x040001D4 RID: 468
		Adding_Completed,
		// Token: 0x040001D5 RID: 469
		Reading_Started,
		// Token: 0x040001D6 RID: 470
		Reading_BeforeReadEntry,
		// Token: 0x040001D7 RID: 471
		Reading_AfterReadEntry,
		// Token: 0x040001D8 RID: 472
		Reading_Completed,
		// Token: 0x040001D9 RID: 473
		Reading_ArchiveBytesRead,
		// Token: 0x040001DA RID: 474
		Saving_Started,
		// Token: 0x040001DB RID: 475
		Saving_BeforeWriteEntry,
		// Token: 0x040001DC RID: 476
		Saving_AfterWriteEntry,
		// Token: 0x040001DD RID: 477
		Saving_Completed,
		// Token: 0x040001DE RID: 478
		Saving_AfterSaveTempArchive,
		// Token: 0x040001DF RID: 479
		Saving_BeforeRenameTempArchive,
		// Token: 0x040001E0 RID: 480
		Saving_AfterRenameTempArchive,
		// Token: 0x040001E1 RID: 481
		Saving_AfterCompileSelfExtractor,
		// Token: 0x040001E2 RID: 482
		Saving_EntryBytesRead,
		// Token: 0x040001E3 RID: 483
		Extracting_BeforeExtractEntry,
		// Token: 0x040001E4 RID: 484
		Extracting_AfterExtractEntry,
		// Token: 0x040001E5 RID: 485
		Extracting_ExtractEntryWouldOverwrite,
		// Token: 0x040001E6 RID: 486
		Extracting_EntryBytesWritten,
		// Token: 0x040001E7 RID: 487
		Extracting_BeforeExtractAll,
		// Token: 0x040001E8 RID: 488
		Extracting_AfterExtractAll,
		// Token: 0x040001E9 RID: 489
		Error_Saving
	}
}
