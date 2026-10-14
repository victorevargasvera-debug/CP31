using System;
using System.IO;

namespace NLog.Internal
{
	// Token: 0x02000102 RID: 258
	internal abstract class FileCharacteristicsHelper
	{
		// Token: 0x06000CD2 RID: 3282 RVA: 0x0001F62C File Offset: 0x0001D82C
		public static global::NLog.Internal.FileCharacteristicsHelper CreateHelper(bool forcedManaged)
		{
			if (!forcedManaged && global::NLog.Internal.PlatformDetector.IsDesktopWin32 && !global::NLog.Internal.PlatformDetector.IsMono)
			{
				return new global::NLog.Internal.Win32FileCharacteristicsHelper();
			}
			return new global::NLog.Internal.PortableFileCharacteristicsHelper();
		}

		// Token: 0x06000CD3 RID: 3283
		public abstract global::NLog.Internal.FileCharacteristics GetFileCharacteristics(string fileName, global::System.IO.FileStream fileStream);

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0001F64C File Offset: 0x0001D84C
		public static global::System.DateTime? ValidateFileCreationTime<T>(T fileInfo, global::System.Func<T, global::System.DateTime?> primary, global::System.Func<T, global::System.DateTime?> fallback, global::System.Func<T, global::System.DateTime?> finalFallback = null)
		{
			global::System.DateTime? result = primary(fileInfo);
			if (result != null && result.Value.Year < 1980 && !global::NLog.Internal.PlatformDetector.IsDesktopWin32)
			{
				result = fallback(fileInfo);
				if (finalFallback != null && (result == null || result.Value.Year < 1980))
				{
					result = finalFallback(fileInfo);
				}
			}
			return result;
		}
	}
}
