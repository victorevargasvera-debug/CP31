using System;
using System.IO;

namespace NLog.Internal
{
	// Token: 0x02000116 RID: 278
	internal class PortableFileCharacteristicsHelper : global::NLog.Internal.FileCharacteristicsHelper
	{
		// Token: 0x06000D41 RID: 3393 RVA: 0x00020C30 File Offset: 0x0001EE30
		public override global::NLog.Internal.FileCharacteristics GetFileCharacteristics(string fileName, global::System.IO.FileStream fileStream)
		{
			if (!string.IsNullOrEmpty(fileName))
			{
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(fileName);
				if (fileInfo.Exists)
				{
					return new global::NLog.Internal.FileCharacteristics(fileInfo.GetCreationTimeUtc(), fileInfo.GetLastWriteTimeUtc(), fileInfo.Length);
				}
			}
			return null;
		}
	}
}
