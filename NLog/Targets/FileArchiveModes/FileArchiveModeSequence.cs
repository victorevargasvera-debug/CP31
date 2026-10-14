using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace NLog.Targets.FileArchiveModes
{
	// Token: 0x02000079 RID: 121
	internal sealed class FileArchiveModeSequence : global::NLog.Targets.FileArchiveModes.FileArchiveModeBase
	{
		// Token: 0x06000892 RID: 2194 RVA: 0x00016226 File Offset: 0x00014426
		public FileArchiveModeSequence(string archiveDateFormat)
		{
			this._archiveDateFormat = archiveDateFormat;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00016235 File Offset: 0x00014435
		public override bool AttemptCleanupOnInitializeFile(string archiveFilePath, int maxArchiveFiles)
		{
			return false;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00016238 File Offset: 0x00014438
		protected override global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileInfo(global::System.IO.FileInfo archiveFile, global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate fileTemplate)
		{
			string text = global::System.IO.Path.GetFileName(archiveFile.FullName) ?? "";
			int num = fileTemplate.Template.Length - fileTemplate.EndAt;
			string value = text.Substring(fileTemplate.BeginAt, text.Length - num - fileTemplate.BeginAt);
			int sequence;
			try
			{
				sequence = global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			catch (global::System.FormatException)
			{
				return null;
			}
			return new global::NLog.Targets.DateAndSequenceArchive(archiveFile.FullName, global::System.DateTime.MinValue, string.Empty, sequence);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000162C8 File Offset: 0x000144C8
		public override global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileName(string archiveFilePath, global::System.DateTime archiveDate, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles)
		{
			int num = 0;
			global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate fileNameTemplate = this.GenerateFileNameTemplate(archiveFilePath);
			foreach (global::NLog.Targets.DateAndSequenceArchive dateAndSequenceArchive in existingArchiveFiles)
			{
				num = global::System.Math.Max(num, dateAndSequenceArchive.Sequence + 1);
			}
			int totalWidth = fileNameTemplate.EndAt - fileNameTemplate.BeginAt - 2;
			string newValue = num.ToString().PadLeft(totalWidth, '0');
			archiveFilePath = global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(archiveFilePath), fileNameTemplate.ReplacePattern("*").Replace("*", newValue));
			return new global::NLog.Targets.DateAndSequenceArchive(archiveFilePath, archiveDate, this._archiveDateFormat, num);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0001637C File Offset: 0x0001457C
		public override global::System.Collections.Generic.IEnumerable<global::NLog.Targets.DateAndSequenceArchive> CheckArchiveCleanup(string archiveFilePath, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles, int maxArchiveFiles)
		{
			if (maxArchiveFiles <= 0 || existingArchiveFiles.Count == 0 || existingArchiveFiles.Count < maxArchiveFiles)
			{
				yield break;
			}
			int sequence = existingArchiveFiles[existingArchiveFiles.Count - 1].Sequence;
			int minNumberToKeep = sequence - maxArchiveFiles + 1;
			if (minNumberToKeep <= 0)
			{
				yield break;
			}
			foreach (global::NLog.Targets.DateAndSequenceArchive dateAndSequenceArchive in existingArchiveFiles)
			{
				if (dateAndSequenceArchive.Sequence < minNumberToKeep)
				{
					yield return dateAndSequenceArchive;
				}
			}
			global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive>.Enumerator enumerator = default(global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x040001FD RID: 509
		private readonly string _archiveDateFormat;
	}
}
