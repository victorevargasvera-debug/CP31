using System;
using NLog.Common;

namespace NLog.Targets.FileArchiveModes
{
	// Token: 0x02000077 RID: 119
	internal static class FileArchiveModeFactory
	{
		// Token: 0x06000887 RID: 2183 RVA: 0x00016004 File Offset: 0x00014204
		public static global::NLog.Targets.IFileArchiveMode CreateArchiveStyle(string archiveFilePath, global::NLog.Targets.ArchiveNumberingMode archiveNumbering, string dateFormat, bool customArchiveFileName, int maxArchiveFiles)
		{
			if (global::NLog.Targets.FileArchiveModes.FileArchiveModeFactory.ContainsFileNamePattern(archiveFilePath))
			{
				global::NLog.Targets.IFileArchiveMode fileArchiveMode = global::NLog.Targets.FileArchiveModes.FileArchiveModeFactory.CreateStrictFileArchiveMode(archiveNumbering, dateFormat, maxArchiveFiles);
				if (fileArchiveMode != null)
				{
					return fileArchiveMode;
				}
			}
			if (archiveNumbering != global::NLog.Targets.ArchiveNumberingMode.Sequence)
			{
				if (!customArchiveFileName)
				{
					global::NLog.Targets.IFileArchiveMode fileArchiveMode2 = global::NLog.Targets.FileArchiveModes.FileArchiveModeFactory.CreateStrictFileArchiveMode(archiveNumbering, dateFormat, maxArchiveFiles);
					if (fileArchiveMode2 != null)
					{
						return new global::NLog.Targets.FileArchiveModes.FileArchiveModeDynamicTemplate(fileArchiveMode2);
					}
				}
				else
				{
					global::NLog.Common.InternalLogger.Info<string>("FileTarget: Pattern {{#}} is missing in ArchiveFileName `{0}` (Fallback to dynamic wildcard)", archiveFilePath);
				}
			}
			return new global::NLog.Targets.FileArchiveModes.FileArchiveModeDynamicSequence(archiveNumbering, dateFormat, customArchiveFileName);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00016055 File Offset: 0x00014255
		private static global::NLog.Targets.IFileArchiveMode CreateStrictFileArchiveMode(global::NLog.Targets.ArchiveNumberingMode archiveNumbering, string dateFormat, int maxArchiveFiles)
		{
			switch (archiveNumbering)
			{
			case global::NLog.Targets.ArchiveNumberingMode.Sequence:
				return new global::NLog.Targets.FileArchiveModes.FileArchiveModeSequence(dateFormat);
			case global::NLog.Targets.ArchiveNumberingMode.Rolling:
				return new global::NLog.Targets.FileArchiveModes.FileArchiveModeRolling();
			case global::NLog.Targets.ArchiveNumberingMode.Date:
				return new global::NLog.Targets.FileArchiveModes.FileArchiveModeDate(dateFormat, global::NLog.Targets.FileArchiveModes.FileArchiveModeFactory.ShouldDeleteOldArchives(maxArchiveFiles));
			case global::NLog.Targets.ArchiveNumberingMode.DateAndSequence:
				return new global::NLog.Targets.FileArchiveModes.FileArchiveModeDateAndSequence(dateFormat);
			default:
				return null;
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00016094 File Offset: 0x00014294
		public static bool ContainsFileNamePattern(string fileName)
		{
			int num = fileName.IndexOf("{#", global::System.StringComparison.Ordinal);
			int num2 = fileName.IndexOf("#}", global::System.StringComparison.Ordinal);
			return num != -1 && num2 != -1 && num < num2;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000160C9 File Offset: 0x000142C9
		public static bool ShouldDeleteOldArchives(int maxArchiveFiles)
		{
			return maxArchiveFiles > 0;
		}
	}
}
