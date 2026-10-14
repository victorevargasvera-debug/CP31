using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000026 RID: 38
	public class DynamicDiskDataSource : global::ICSharpCode.SharpZipLib.Zip.IDynamicDataSource
	{
		// Token: 0x06000184 RID: 388 RVA: 0x00007FC8 File Offset: 0x000061C8
		public global::System.IO.Stream GetSource(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, string name)
		{
			global::System.IO.Stream result = null;
			if (name != null)
			{
				result = global::System.IO.File.Open(name, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
			}
			return result;
		}
	}
}
