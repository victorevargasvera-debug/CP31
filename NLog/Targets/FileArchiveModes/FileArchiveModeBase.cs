using System;
using System.Collections.Generic;
using System.IO;

namespace NLog.Targets.FileArchiveModes
{
	// Token: 0x02000072 RID: 114
	internal abstract class FileArchiveModeBase : global::NLog.Targets.IFileArchiveMode
	{
		// Token: 0x06000866 RID: 2150 RVA: 0x0001555C File Offset: 0x0001375C
		public virtual bool AttemptCleanupOnInitializeFile(string archiveFilePath, int maxArchiveFiles)
		{
			int lastArchiveFileCount = this._lastArchiveFileCount;
			this._lastArchiveFileCount = lastArchiveFileCount + 1;
			return lastArchiveFileCount > maxArchiveFiles;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00015580 File Offset: 0x00013780
		public string GenerateFileNameMask(string archiveFilePath)
		{
			int lastArchiveFileCount = this._lastArchiveFileCount;
			string result = this.GenerateFileNameMask(archiveFilePath, this.GenerateFileNameTemplate(archiveFilePath));
			this._lastArchiveFileCount = lastArchiveFileCount;
			return result;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000155AC File Offset: 0x000137AC
		public virtual global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> GetExistingArchiveFiles(string archiveFilePath)
		{
			this._lastArchiveFileCount = 65534;
			string directoryName = global::System.IO.Path.GetDirectoryName(archiveFilePath);
			global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate fileTemplate = this.GenerateFileNameTemplate(archiveFilePath);
			string text = this.GenerateFileNameMask(archiveFilePath, fileTemplate);
			global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> list = new global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive>();
			if (string.IsNullOrEmpty(text))
			{
				return list;
			}
			global::System.IO.DirectoryInfo directoryInfo = new global::System.IO.DirectoryInfo(directoryName);
			if (!directoryInfo.Exists)
			{
				return list;
			}
			foreach (global::System.IO.FileInfo archiveFile in directoryInfo.GetFiles(text))
			{
				global::NLog.Targets.DateAndSequenceArchive dateAndSequenceArchive = this.GenerateArchiveFileInfo(archiveFile, fileTemplate);
				if (dateAndSequenceArchive != null)
				{
					list.Add(dateAndSequenceArchive);
				}
			}
			if (list.Count > 1)
			{
				list.Sort(new global::System.Comparison<global::NLog.Targets.DateAndSequenceArchive>(global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileSortOrderComparison));
			}
			this._lastArchiveFileCount = list.Count;
			return list;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00015664 File Offset: 0x00013864
		private static int FileSortOrderComparison(global::NLog.Targets.DateAndSequenceArchive x, global::NLog.Targets.DateAndSequenceArchive y)
		{
			if (x.Date != y.Date && !x.HasSameFormattedDate(y.Date))
			{
				return x.Date.CompareTo(y.Date);
			}
			if (x.Sequence.CompareTo(y.Sequence) != 0)
			{
				return x.Sequence.CompareTo(y.Sequence);
			}
			return string.CompareOrdinal(x.FileName, y.FileName);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000156E3 File Offset: 0x000138E3
		protected virtual global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate GenerateFileNameTemplate(string archiveFilePath)
		{
			this._lastArchiveFileCount++;
			return new global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate(global::System.IO.Path.GetFileName(archiveFilePath));
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000156FE File Offset: 0x000138FE
		protected virtual string GenerateFileNameMask(string archiveFilePath, global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate fileTemplate)
		{
			if (fileTemplate != null)
			{
				return fileTemplate.ReplacePattern("*");
			}
			return string.Empty;
		}

		// Token: 0x0600086C RID: 2156
		protected abstract global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileInfo(global::System.IO.FileInfo archiveFile, global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate fileTemplate);

		// Token: 0x0600086D RID: 2157
		public abstract global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileName(string archiveFilePath, global::System.DateTime archiveDate, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles);

		// Token: 0x0600086E RID: 2158 RVA: 0x00015714 File Offset: 0x00013914
		public virtual global::System.Collections.Generic.IEnumerable<global::NLog.Targets.DateAndSequenceArchive> CheckArchiveCleanup(string archiveFilePath, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles, int maxArchiveFiles)
		{
			if (maxArchiveFiles <= 0)
			{
				yield break;
			}
			this._lastArchiveFileCount = existingArchiveFiles.Count;
			if (existingArchiveFiles.Count == 0 || existingArchiveFiles.Count < maxArchiveFiles)
			{
				yield break;
			}
			int num;
			for (int i = 0; i < existingArchiveFiles.Count - maxArchiveFiles; i = num + 1)
			{
				if (this._lastArchiveFileCount > 0)
				{
					this._lastArchiveFileCount--;
				}
				yield return existingArchiveFiles[i];
				num = i;
			}
			yield break;
		}

		// Token: 0x040001F5 RID: 501
		private int _lastArchiveFileCount = 65534;

		// Token: 0x020001EE RID: 494
		internal sealed class FileNameTemplate
		{
			// Token: 0x17000368 RID: 872
			// (get) Token: 0x06001269 RID: 4713 RVA: 0x00030158 File Offset: 0x0002E358
			// (set) Token: 0x0600126A RID: 4714 RVA: 0x00030160 File Offset: 0x0002E360
			public string Template { get; private set; }

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x0600126B RID: 4715 RVA: 0x00030169 File Offset: 0x0002E369
			// (set) Token: 0x0600126C RID: 4716 RVA: 0x00030171 File Offset: 0x0002E371
			public int BeginAt { get; private set; }

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x0600126D RID: 4717 RVA: 0x0003017A File Offset: 0x0002E37A
			// (set) Token: 0x0600126E RID: 4718 RVA: 0x00030182 File Offset: 0x0002E382
			public int EndAt { get; private set; }

			// Token: 0x1700036B RID: 875
			// (get) Token: 0x0600126F RID: 4719 RVA: 0x0003018B File Offset: 0x0002E38B
			private bool FoundPattern
			{
				get
				{
					return this.BeginAt != -1 && this.EndAt != -1;
				}
			}

			// Token: 0x06001270 RID: 4720 RVA: 0x000301A4 File Offset: 0x0002E3A4
			public FileNameTemplate(string template)
			{
				this.Template = template;
				this.BeginAt = template.IndexOf("{#", global::System.StringComparison.Ordinal);
				if (this.BeginAt != -1)
				{
					this.EndAt = template.IndexOf("#}", global::System.StringComparison.Ordinal) + "#}".Length;
				}
			}

			// Token: 0x06001271 RID: 4721 RVA: 0x000301F8 File Offset: 0x0002E3F8
			public string ReplacePattern(string replacementValue)
			{
				if (this.FoundPattern && !string.IsNullOrEmpty(replacementValue))
				{
					return this.Template.Substring(0, this.BeginAt) + replacementValue + this.Template.Substring(this.EndAt);
				}
				return this.Template;
			}

			// Token: 0x0400057E RID: 1406
			public const string PatternStartCharacters = "{#";

			// Token: 0x0400057F RID: 1407
			public const string PatternEndCharacters = "#}";
		}
	}
}
