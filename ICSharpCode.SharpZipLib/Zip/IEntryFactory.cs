using System;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000009 RID: 9
	public interface IEntryFactory
	{
		// Token: 0x06000049 RID: 73
		global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName);

		// Token: 0x0600004A RID: 74
		global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName, bool useFileSystem);

		// Token: 0x0600004B RID: 75
		global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName, string entryName, bool useFileSystem);

		// Token: 0x0600004C RID: 76
		global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeDirectoryEntry(string directoryName);

		// Token: 0x0600004D RID: 77
		global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeDirectoryEntry(string directoryName, bool useFileSystem);

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004E RID: 78
		// (set) Token: 0x0600004F RID: 79
		global::ICSharpCode.SharpZipLib.Core.INameTransform NameTransform { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000050 RID: 80
		global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting Setting { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000051 RID: 81
		global::System.DateTime FixedDateTime { get; }
	}
}
