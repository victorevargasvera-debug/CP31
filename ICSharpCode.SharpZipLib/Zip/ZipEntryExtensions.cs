using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000013 RID: 19
	public static class ZipEntryExtensions
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00003DF8 File Offset: 0x00001FF8
		public static bool HasFlag(this global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, global::ICSharpCode.SharpZipLib.Zip.GeneralBitFlags flag)
		{
			return (entry.Flags & (int)flag) != 0;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003E05 File Offset: 0x00002005
		public static void SetFlag(this global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, global::ICSharpCode.SharpZipLib.Zip.GeneralBitFlags flag, bool enabled = true)
		{
			entry.Flags = (enabled ? (entry.Flags | (int)flag) : (entry.Flags & (int)(~(int)flag)));
		}
	}
}
