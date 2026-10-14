using System;
using System.Collections.Generic;

namespace NLog.Targets
{
	// Token: 0x0200003B RID: 59
	internal interface IFileArchiveMode
	{
		// Token: 0x0600060D RID: 1549
		bool AttemptCleanupOnInitializeFile(string archiveFilePath, int maxArchiveFiles);

		// Token: 0x0600060E RID: 1550
		string GenerateFileNameMask(string archiveFilePath);

		// Token: 0x0600060F RID: 1551
		global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> GetExistingArchiveFiles(string archiveFilePath);

		// Token: 0x06000610 RID: 1552
		global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileName(string archiveFilePath, global::System.DateTime archiveDate, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles);

		// Token: 0x06000611 RID: 1553
		global::System.Collections.Generic.IEnumerable<global::NLog.Targets.DateAndSequenceArchive> CheckArchiveCleanup(string archiveFilePath, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles, int maxArchiveFiles);
	}
}
