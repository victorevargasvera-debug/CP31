using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000024 RID: 36
	public interface IDynamicDataSource
	{
		// Token: 0x06000181 RID: 385
		global::System.IO.Stream GetSource(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, string name);
	}
}
