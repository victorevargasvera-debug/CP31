using System;
using System.IO;

namespace NLog.Internal
{
	// Token: 0x02000130 RID: 304
	internal class Win32FileCharacteristicsHelper : global::NLog.Internal.FileCharacteristicsHelper
	{
		// Token: 0x06000DE5 RID: 3557 RVA: 0x0002345C File Offset: 0x0002165C
		public override global::NLog.Internal.FileCharacteristics GetFileCharacteristics(string fileName, global::System.IO.FileStream fileStream)
		{
			global::NLog.Internal.Win32FileNativeMethods.BY_HANDLE_FILE_INFORMATION by_HANDLE_FILE_INFORMATION;
			if (fileStream != null && global::NLog.Internal.Win32FileNativeMethods.GetFileInformationByHandle(fileStream.SafeFileHandle.DangerousGetHandle(), out by_HANDLE_FILE_INFORMATION))
			{
				return new global::NLog.Internal.FileCharacteristics(global::System.DateTime.FromFileTimeUtc(by_HANDLE_FILE_INFORMATION.ftCreationTime), global::System.DateTime.FromFileTimeUtc(by_HANDLE_FILE_INFORMATION.ftLastWriteTime), (long)((ulong)by_HANDLE_FILE_INFORMATION.nFileSizeLow + ((ulong)by_HANDLE_FILE_INFORMATION.nFileSizeHigh << 32)));
			}
			return null;
		}
	}
}
