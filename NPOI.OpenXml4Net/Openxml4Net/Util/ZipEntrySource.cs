using System;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace NPOI.OpenXml4Net.Util
{
	// Token: 0x02000009 RID: 9
	public interface ZipEntrySource
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000031 RID: 49
		global::System.Collections.IEnumerator Entries { get; }

		// Token: 0x06000032 RID: 50
		global::System.IO.Stream GetInputStream(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry);

		// Token: 0x06000033 RID: 51
		void Close();

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000034 RID: 52
		bool IsClosed { get; }
	}
}
