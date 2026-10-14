using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace NLog.Targets.FileArchiveModes
{
	// Token: 0x02000073 RID: 115
	internal sealed class FileArchiveModeDate : global::NLog.Targets.FileArchiveModes.FileArchiveModeBase
	{
		// Token: 0x06000870 RID: 2160 RVA: 0x00015745 File Offset: 0x00013945
		public FileArchiveModeDate(string archiveDateFormat, bool archiveCleanupEnabled)
		{
			this._archiveDateFormat = archiveDateFormat;
			this._archiveCleanupEnabled = archiveCleanupEnabled;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0001575B File Offset: 0x0001395B
		public override global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> GetExistingArchiveFiles(string archiveFilePath)
		{
			if (this._archiveCleanupEnabled)
			{
				return base.GetExistingArchiveFiles(archiveFilePath);
			}
			return new global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive>();
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00015774 File Offset: 0x00013974
		protected override global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileInfo(global::System.IO.FileInfo archiveFile, global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate fileTemplate)
		{
			string text = global::System.IO.Path.GetFileName(archiveFile.FullName) ?? "";
			int num = fileTemplate.ReplacePattern("*").LastIndexOf('*');
			global::System.DateTime date;
			if (num + this._archiveDateFormat.Length <= text.Length && global::System.DateTime.TryParseExact(text.Substring(num, this._archiveDateFormat.Length), this._archiveDateFormat, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.None, out date))
			{
				return new global::NLog.Targets.DateAndSequenceArchive(archiveFile.FullName, date, this._archiveDateFormat, -1);
			}
			return null;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000157FC File Offset: 0x000139FC
		public override global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileName(string archiveFilePath, global::System.DateTime archiveDate, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles)
		{
			global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate fileNameTemplate = this.GenerateFileNameTemplate(archiveFilePath);
			archiveFilePath = global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(archiveFilePath), fileNameTemplate.ReplacePattern("*").Replace("*", archiveDate.ToString(this._archiveDateFormat)));
			return new global::NLog.Targets.DateAndSequenceArchive(archiveFilePath, archiveDate, this._archiveDateFormat, 0);
		}

		// Token: 0x040001F6 RID: 502
		private readonly string _archiveDateFormat;

		// Token: 0x040001F7 RID: 503
		private readonly bool _archiveCleanupEnabled;
	}
}
