using System;
using System.Collections.Generic;
using System.IO;
using NLog.Common;

namespace NLog.Targets.FileArchiveModes
{
	// Token: 0x02000078 RID: 120
	internal sealed class FileArchiveModeRolling : global::NLog.Targets.IFileArchiveMode
	{
		// Token: 0x0600088B RID: 2187 RVA: 0x000160CF File Offset: 0x000142CF
		public bool AttemptCleanupOnInitializeFile(string archiveFilePath, int maxArchiveFiles)
		{
			return false;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x000160D2 File Offset: 0x000142D2
		public string GenerateFileNameMask(string archiveFilePath)
		{
			return new global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate(global::System.IO.Path.GetFileName(archiveFilePath)).ReplacePattern("*");
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x000160EC File Offset: 0x000142EC
		public global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> GetExistingArchiveFiles(string archiveFilePath)
		{
			global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> list = new global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive>();
			for (int i = 0; i < 2147483647; i++)
			{
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(global::NLog.Targets.FileArchiveModes.FileArchiveModeRolling.ReplaceNumberPattern(archiveFilePath, i));
				if (!fileInfo.Exists)
				{
					break;
				}
				list.Add(new global::NLog.Targets.DateAndSequenceArchive(fileInfo.FullName, global::System.DateTime.MinValue, string.Empty, i));
			}
			return list;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00016144 File Offset: 0x00014344
		private static string ReplaceNumberPattern(string pattern, int value)
		{
			int num = pattern.IndexOf("{#", global::System.StringComparison.Ordinal);
			int num2 = pattern.IndexOf("#}", global::System.StringComparison.Ordinal) + 2;
			int totalWidth = num2 - num - 2;
			return pattern.Substring(0, num) + global::System.Convert.ToString(value, 10).PadLeft(totalWidth, '0') + pattern.Substring(num2);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00016198 File Offset: 0x00014398
		public global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileName(string archiveFilePath, global::System.DateTime archiveDate, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles)
		{
			if (existingArchiveFiles.Count > 0)
			{
				int value = existingArchiveFiles[existingArchiveFiles.Count - 1].Sequence + 1;
				string fileName = global::NLog.Targets.FileArchiveModes.FileArchiveModeRolling.ReplaceNumberPattern(archiveFilePath, value);
				existingArchiveFiles.Add(new global::NLog.Targets.DateAndSequenceArchive(fileName, global::System.DateTime.MinValue, string.Empty, int.MaxValue));
			}
			return new global::NLog.Targets.DateAndSequenceArchive(global::System.IO.Path.GetFullPath(global::NLog.Targets.FileArchiveModes.FileArchiveModeRolling.ReplaceNumberPattern(archiveFilePath, 0)), global::System.DateTime.MinValue, string.Empty, int.MinValue);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00016207 File Offset: 0x00014407
		public global::System.Collections.Generic.IEnumerable<global::NLog.Targets.DateAndSequenceArchive> CheckArchiveCleanup(string archiveFilePath, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles, int maxArchiveFiles)
		{
			if (existingArchiveFiles.Count <= 1)
			{
				yield break;
			}
			existingArchiveFiles.Sort((global::NLog.Targets.DateAndSequenceArchive x, global::NLog.Targets.DateAndSequenceArchive y) => x.Sequence.CompareTo(y.Sequence));
			if (maxArchiveFiles > 0 && existingArchiveFiles.Count > maxArchiveFiles)
			{
				int num;
				for (int i = 0; i < existingArchiveFiles.Count; i = num + 1)
				{
					if (existingArchiveFiles[i].Sequence != -2147483648 && existingArchiveFiles[i].Sequence != 2147483647 && i + 1 > maxArchiveFiles)
					{
						yield return existingArchiveFiles[i];
					}
					num = i;
				}
			}
			if (existingArchiveFiles.Count > 1 && existingArchiveFiles[0].Sequence == -2147483648)
			{
				string text = string.Empty;
				int num2 = existingArchiveFiles.Count - 1;
				if (maxArchiveFiles > 0 && num2 > maxArchiveFiles)
				{
					num2 = maxArchiveFiles;
				}
				for (int j = num2; j >= 1; j--)
				{
					string fileName = existingArchiveFiles[j].FileName;
					if (!string.IsNullOrEmpty(text))
					{
						global::NLog.Common.InternalLogger.Info<string, string>("Roll archive {0} to {1}", fileName, text);
						global::System.IO.File.Move(fileName, text);
					}
					text = fileName;
				}
			}
			yield break;
		}
	}
}
