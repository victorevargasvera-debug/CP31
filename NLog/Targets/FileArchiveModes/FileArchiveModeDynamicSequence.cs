using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using NLog.Common;
using NLog.Internal;

namespace NLog.Targets.FileArchiveModes
{
	// Token: 0x02000075 RID: 117
	internal sealed class FileArchiveModeDynamicSequence : global::NLog.Targets.FileArchiveModes.FileArchiveModeBase
	{
		// Token: 0x06000879 RID: 2169 RVA: 0x00015A57 File Offset: 0x00013C57
		public FileArchiveModeDynamicSequence(global::NLog.Targets.ArchiveNumberingMode archiveNumbering, string archiveDateFormat, bool customArchiveFileName)
		{
			this._archiveNumbering = archiveNumbering;
			this._archiveDateFormat = archiveDateFormat;
			this._customArchiveFileName = customArchiveFileName;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00015A74 File Offset: 0x00013C74
		private static bool RemoveNonLetters(string fileName, int startPosition, global::System.Text.StringBuilder sb, out int digitsRemoved)
		{
			digitsRemoved = 0;
			sb.ClearBuilder();
			for (int i = 0; i < startPosition; i++)
			{
				sb.Append(fileName[i]);
			}
			bool? flag = null;
			for (int j = startPosition; j < fileName.Length; j++)
			{
				char c = fileName[j];
				if (char.IsDigit(c))
				{
					if (flag == null)
					{
						flag = new bool?(true);
						digitsRemoved = 1;
						sb.Append('{');
						sb.Append('#');
						sb.Append('}');
					}
					else if (!flag.Value)
					{
						sb.Append(c);
					}
					else
					{
						digitsRemoved++;
					}
				}
				else if (!char.IsLetter(c))
				{
					if (flag == null || !flag.Value)
					{
						sb.Append(c);
					}
				}
				else
				{
					if (flag != null)
					{
						flag = new bool?(false);
					}
					sb.Append(c);
				}
			}
			return flag != null;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00015B64 File Offset: 0x00013D64
		protected override global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate GenerateFileNameTemplate(string archiveFilePath)
		{
			string fileNameWithoutExtension = global::System.IO.Path.GetFileNameWithoutExtension(archiveFilePath);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int startPosition = 0;
			int num = int.MaxValue;
			int num2 = 0;
			int num3;
			while (num2 < fileNameWithoutExtension.Length && (global::NLog.Targets.FileArchiveModes.FileArchiveModeDynamicSequence.RemoveNonLetters(fileNameWithoutExtension, num2, stringBuilder, out num3) || num2 != 0))
			{
				if (num3 > 1 && stringBuilder.Length < num)
				{
					startPosition = num2;
					num = stringBuilder.Length;
				}
				num2++;
			}
			global::NLog.Targets.FileArchiveModes.FileArchiveModeDynamicSequence.RemoveNonLetters(fileNameWithoutExtension, startPosition, stringBuilder, out num3);
			if (num3 <= 1)
			{
				stringBuilder.ClearBuilder();
				stringBuilder.Append(fileNameWithoutExtension);
			}
			global::NLog.Targets.ArchiveNumberingMode archiveNumbering = this._archiveNumbering;
			if ((archiveNumbering <= global::NLog.Targets.ArchiveNumberingMode.Rolling || archiveNumbering == global::NLog.Targets.ArchiveNumberingMode.DateAndSequence) && stringBuilder.Length > 3 && stringBuilder[stringBuilder.Length - 3] != '{' && stringBuilder[stringBuilder.Length - 2] != '#' && stringBuilder[stringBuilder.Length - 1] != '}')
			{
				if (num3 <= 1)
				{
					stringBuilder.Append("{");
					stringBuilder.Append("#");
					stringBuilder.Append("}");
				}
				else
				{
					stringBuilder.Append('*');
				}
			}
			stringBuilder.Append(global::System.IO.Path.GetExtension(archiveFilePath));
			return base.GenerateFileNameTemplate(stringBuilder.ToString());
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00015C80 File Offset: 0x00013E80
		protected override global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileInfo(global::System.IO.FileInfo archiveFile, global::NLog.Targets.FileArchiveModes.FileArchiveModeBase.FileNameTemplate fileTemplate)
		{
			if (fileTemplate != null && fileTemplate.EndAt > 0)
			{
				string name = archiveFile.Name;
				int i = 0;
				int j = 0;
				while (j < name.Length)
				{
					char c = name[j];
					if (i >= fileTemplate.Template.Length)
					{
						if (char.IsLetter(c))
						{
							return null;
						}
						break;
					}
					else
					{
						char c2;
						if (i >= fileTemplate.EndAt || j < fileTemplate.BeginAt)
						{
							c2 = fileTemplate.Template[i];
							i++;
							goto IL_AB;
						}
						if (char.IsLetter(c))
						{
							i = fileTemplate.EndAt;
							while (i < fileTemplate.Template.Length)
							{
								c2 = fileTemplate.Template[i];
								i++;
								if (char.IsLetter(c2))
								{
									goto IL_AB;
								}
							}
							return null;
						}
						IL_D2:
						j++;
						continue;
						IL_AB:
						if (c == c2 || char.ToLowerInvariant(c) == char.ToLowerInvariant(c2))
						{
							goto IL_D2;
						}
						if (c2 != '*' || char.IsLetter(c))
						{
							return null;
						}
						break;
					}
				}
			}
			int num = global::NLog.Targets.FileArchiveModes.FileArchiveModeDynamicSequence.ExtractArchiveNumberFromFileName(archiveFile.FullName);
			global::NLog.Common.InternalLogger.Trace<int, string>("FileTarget: extracted sequenceNumber: {0} from file '{1}'", num, archiveFile.FullName);
			global::System.DateTime value = global::NLog.Internal.FileCharacteristicsHelper.ValidateFileCreationTime<global::System.IO.FileInfo>(archiveFile, (global::System.IO.FileInfo f) => new global::System.DateTime?(f.GetCreationTimeUtc()), (global::System.IO.FileInfo f) => new global::System.DateTime?(f.GetLastWriteTimeUtc()), null).Value;
			return new global::NLog.Targets.DateAndSequenceArchive(archiveFile.FullName, value, string.Empty, (num > 0) ? num : 0);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00015DF8 File Offset: 0x00013FF8
		private static int ExtractArchiveNumberFromFileName(string archiveFileName)
		{
			archiveFileName = global::System.IO.Path.GetFileName(archiveFileName);
			int num = archiveFileName.LastIndexOf('.');
			if (num == -1)
			{
				return 0;
			}
			int num2 = archiveFileName.LastIndexOf('.', num - 1);
			int result;
			if (!int.TryParse((num2 == -1) ? archiveFileName.Substring(num + 1) : archiveFileName.Substring(num2 + 1, num - num2 - 1), out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00015E54 File Offset: 0x00014054
		public override global::NLog.Targets.DateAndSequenceArchive GenerateArchiveFileName(string archiveFilePath, global::System.DateTime archiveDate, global::System.Collections.Generic.List<global::NLog.Targets.DateAndSequenceArchive> existingArchiveFiles)
		{
			int num = this.GetStartSequenceNo() - 1;
			string fileName = global::System.IO.Path.GetFileName(archiveFilePath);
			foreach (global::NLog.Targets.DateAndSequenceArchive dateAndSequenceArchive in existingArchiveFiles)
			{
				string text = global::System.IO.Path.GetFileName(dateAndSequenceArchive.FileName);
				if (string.Equals(text, fileName, global::System.StringComparison.OrdinalIgnoreCase))
				{
					num = global::System.Math.Max(num, dateAndSequenceArchive.Sequence + this.GetStartSequenceNo());
				}
				else
				{
					string extension = global::System.IO.Path.GetExtension(text);
					text = global::System.IO.Path.GetFileNameWithoutExtension(global::System.IO.Path.GetFileNameWithoutExtension(text)) + extension;
					if (string.Equals(text, fileName, global::System.StringComparison.OrdinalIgnoreCase))
					{
						num = global::System.Math.Max(num, dateAndSequenceArchive.Sequence + 1);
					}
				}
			}
			archiveFilePath = global::System.IO.Path.GetFullPath(archiveFilePath);
			if (num >= this.GetStartSequenceNo())
			{
				archiveFilePath = global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(archiveFilePath), global::System.IO.Path.GetFileNameWithoutExtension(fileName) + "." + num.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + global::System.IO.Path.GetExtension(fileName));
			}
			return new global::NLog.Targets.DateAndSequenceArchive(archiveFilePath, archiveDate, this._archiveDateFormat, num);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00015F60 File Offset: 0x00014160
		private int GetStartSequenceNo()
		{
			if (!this._customArchiveFileName)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x040001F9 RID: 505
		private readonly global::NLog.Targets.ArchiveNumberingMode _archiveNumbering;

		// Token: 0x040001FA RID: 506
		private readonly string _archiveDateFormat;

		// Token: 0x040001FB RID: 507
		private readonly bool _customArchiveFileName;
	}
}
