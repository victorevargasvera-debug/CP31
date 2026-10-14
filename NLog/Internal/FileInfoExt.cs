using System;
using System.IO;

namespace NLog.Internal
{
	// Token: 0x02000103 RID: 259
	internal static class FileInfoExt
	{
		// Token: 0x06000CD6 RID: 3286 RVA: 0x0001F6C2 File Offset: 0x0001D8C2
		public static global::System.DateTime GetLastWriteTimeUtc(this global::System.IO.FileInfo fileInfo)
		{
			return fileInfo.LastWriteTimeUtc;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0001F6CA File Offset: 0x0001D8CA
		public static global::System.DateTime GetCreationTimeUtc(this global::System.IO.FileInfo fileInfo)
		{
			return fileInfo.CreationTimeUtc;
		}
	}
}
