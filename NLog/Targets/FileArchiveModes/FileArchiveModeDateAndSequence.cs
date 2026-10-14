using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using NLog.Common;

namespace NLog.Targets.FileArchiveModes
{
	// Token: 0x02000074 RID: 116
	internal sealed class FileArchiveModeDateAndSequence : global::NLog.Targets.FileArchiveModes.FileArchiveModeBase
	{
		// Token: 0x06000874 RID: 2164 RVA: 0x0001584E File Offset: 0x00013A4E
		public FileArchiveModeDateAndSequence(string archiveDateFormat)
		{
			this._archiveDateFormat = archiveDateFormat;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0001585D File Offset: 0x00013A5D
		public override bool AttemptCleanupOnInitializeFile(string archiveFilePath, int maxArchiveFiles)
		{
			return false;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00015860 File Offset: 0x00013A60
		protected override global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileInfo(global::System.IO.FileInfo archiveFile, global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate fileTemplate)
		{
			global::System.DateTime date;
			int sequence;
			if (!global::NLog.Targets.FileArchiveModes.FileArchiveModeDateAndSequence.TryParseDateAndSequence(global::System.IO.Path.GetFileName(archiveFile.FullName) ?? string.Empty, this._archiveDateFormat, fileTemplate, out date, out sequence))
			{
				return null;
			}
			return new global::NLog.Targets.DateAndSequenceArchive(archiveFile.FullName, date, this._archiveDateFormat, sequence);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000158A8 File Offset: 0x00013AA8
		public override global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileName(string archiveFilePath, global::System.DateTime archiveDate, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles)
		{
			int num = 0;
			global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate fileNameTemplate = this.GenerateFileNameTemplate(archiveFilePath);
			foreach (global::NLog.Targets.DateAndSequenceArchive dateAndSequenceArchive in existingArchiveFiles)
			{
				if (dateAndSequenceArchive.HasSameFormattedDate(archiveDate))
				{
					num = global::System.Math.Max(num, dateAndSequenceArchive.Sequence + 1);
				}
			}
			int totalWidth = fileNameTemplate.EndAt - fileNameTemplate.BeginAt - 2;
			string arg = num.ToString().PadLeft(totalWidth, '0');
			string path = fileNameTemplate.ReplacePattern("*").Replace("*", string.Format("{0}.{1}", archiveDate.ToString(this._archiveDateFormat), arg));
			archiveFilePath = global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(archiveFilePath), path);
			return new global::NLog.Targets.DateAndSequenceArchive(archiveFilePath, archiveDate, this._archiveDateFormat, num);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00015984 File Offset: 0x00013B84
		private static bool TryParseDateAndSequence(string archiveFileNameWithoutPath, string dateFormat, global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate fileTemplate, out global::System.DateTime date, out int sequence)
		{
			int num = fileTemplate.Template.Length - fileTemplate.EndAt;
			int beginAt = fileTemplate.BeginAt;
			int num2 = archiveFileNameWithoutPath.Length - num - beginAt;
			if (num2 < 0)
			{
				date = default(global::System.DateTime);
				sequence = 0;
				return false;
			}
			string text = archiveFileNameWithoutPath.Substring(beginAt, num2);
			int startIndex = text.LastIndexOf('.') + 1;
			string text2 = text.Substring(startIndex);
			if (!int.TryParse(text2, global::System.Globalization.NumberStyles.None, global::System.Globalization.CultureInfo.CurrentCulture, out sequence))
			{
				date = default(global::System.DateTime);
				return false;
			}
			int num3 = text.Length - text2.Length - 1;
			if (num3 < 0)
			{
				date = default(global::System.DateTime);
				return false;
			}
			string text3 = text.Substring(0, num3);
			if (!global::System.DateTime.TryParseExact(text3, dateFormat, global::System.Globalization.CultureInfo.CurrentCulture, global::System.Globalization.DateTimeStyles.None, out date))
			{
				return false;
			}
			global::NLog.Common.InternalLogger.Trace<string, string>("FileTarget: parsed date '{0}' from file-template '{1}'", text3, (fileTemplate != null) ? fileTemplate.Template : null);
			return true;
		}

		// Token: 0x040001F8 RID: 504
		private readonly string _archiveDateFormat;
	}
}
