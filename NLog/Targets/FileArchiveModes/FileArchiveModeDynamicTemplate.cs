using System;
using System.Collections.Generic;
using System.IO;

namespace NLog.Targets.FileArchiveModes
{
	// Token: 0x02000076 RID: 118
	internal sealed class FileArchiveModeDynamicTemplate : global::NLog.Targets.IFileArchiveMode
	{
		// Token: 0x06000880 RID: 2176 RVA: 0x00015F70 File Offset: 0x00014170
		private static string CreateDynamicTemplate(string archiveFilePath)
		{
			string extension = global::System.IO.Path.GetExtension(archiveFilePath);
			return global::System.IO.Path.ChangeExtension(archiveFilePath, ".{#}" + extension);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00015F95 File Offset: 0x00014195
		public FileArchiveModeDynamicTemplate(global::NLog.Targets.IFileArchiveMode archiveHelper)
		{
			this._archiveHelper = archiveHelper;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00015FA4 File Offset: 0x000141A4
		public bool AttemptCleanupOnInitializeFile(string archiveFilePath, int maxArchiveFiles)
		{
			return this._archiveHelper.AttemptCleanupOnInitializeFile(archiveFilePath, maxArchiveFiles);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00015FB3 File Offset: 0x000141B3
		public global::System.Collections.Generic.IEnumerable<global::NLog.Targets.DateAndSequenceArchive> CheckArchiveCleanup(string archiveFilePath, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles, int maxArchiveFiles)
		{
			return this._archiveHelper.CheckArchiveCleanup(global::NLog.Targets.FileArchiveModes.FileArchiveModeDynamicTemplate.CreateDynamicTemplate(archiveFilePath), existingArchiveFiles, maxArchiveFiles);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00015FC8 File Offset: 0x000141C8
		public global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileName(string archiveFilePath, global::System.DateTime archiveDate, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles)
		{
			return this._archiveHelper.GenerateArchiveFileName(global::NLog.Targets.FileArchiveModes.FileArchiveModeDynamicTemplate.CreateDynamicTemplate(archiveFilePath), archiveDate, existingArchiveFiles);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00015FDD File Offset: 0x000141DD
		public string GenerateFileNameMask(string archiveFilePath)
		{
			return this._archiveHelper.GenerateFileNameMask(global::NLog.Targets.FileArchiveModes.FileArchiveModeDynamicTemplate.CreateDynamicTemplate(archiveFilePath));
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00015FF0 File Offset: 0x000141F0
		public global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> GetExistingArchiveFiles(string archiveFilePath)
		{
			return this._archiveHelper.GetExistingArchiveFiles(global::NLog.Targets.FileArchiveModes.FileArchiveModeDynamicTemplate.CreateDynamicTemplate(archiveFilePath));
		}

		// Token: 0x040001FC RID: 508
		private readonly global::NLog.Targets.IFileArchiveMode _archiveHelper;
	}
}
