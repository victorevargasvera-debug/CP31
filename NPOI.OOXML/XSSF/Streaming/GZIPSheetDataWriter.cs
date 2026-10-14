using System;
using System.IO;
using ICSharpCode.SharpZipLib.GZip;
using NPOI.Util;
using NPOI.XSSF.Model;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000C3 RID: 195
	public class GZIPSheetDataWriter : global::NPOI.XSSF.Streaming.SheetDataWriter
	{
		// Token: 0x06000C19 RID: 3097 RVA: 0x0002C5C5 File Offset: 0x0002A7C5
		public GZIPSheetDataWriter()
		{
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0002C5CD File Offset: 0x0002A7CD
		public GZIPSheetDataWriter(global::NPOI.XSSF.Model.SharedStringsTable sharedStringsTable) : base(sharedStringsTable)
		{
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0002C5D6 File Offset: 0x0002A7D6
		public override global::System.IO.FileInfo CreateTempFile()
		{
			return global::NPOI.Util.TempFile.CreateTempFile("poi-sxssf-sheet-xml", ".gz");
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0002C5E7 File Offset: 0x0002A7E7
		protected override global::System.IO.Stream DecorateInputStream(global::System.IO.Stream fis)
		{
			return new global::ICSharpCode.SharpZipLib.GZip.GZipInputStream(fis);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0002C5EF File Offset: 0x0002A7EF
		protected override global::System.IO.Stream DecorateOutputStream(global::System.IO.Stream fos)
		{
			return new global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream(fos);
		}
	}
}
