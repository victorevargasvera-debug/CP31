using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000025 RID: 37
	public class StaticDiskDataSource : global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00007FA8 File Offset: 0x000061A8
		public StaticDiskDataSource(string fileName)
		{
			this.fileName_ = fileName;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00007FB7 File Offset: 0x000061B7
		public global::System.IO.Stream GetSource()
		{
			return global::System.IO.File.Open(this.fileName_, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
		}

		// Token: 0x040000E3 RID: 227
		private readonly string fileName_;
	}
}
