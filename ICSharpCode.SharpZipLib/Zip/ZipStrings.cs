using System;
using System.Text;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000032 RID: 50
	public static class ZipStrings
	{
		// Token: 0x0600020B RID: 523 RVA: 0x0000A8E0 File Offset: 0x00008AE0
		static ZipStrings()
		{
			try
			{
				int num = global::System.Text.Encoding.GetEncoding(0).CodePage;
				global::ICSharpCode.SharpZipLib.Zip.ZipStrings.SystemDefaultCodePage = ((num == 1 || num == 2 || num == 3 || num == 42) ? 437 : num);
			}
			catch
			{
				global::ICSharpCode.SharpZipLib.Zip.ZipStrings.SystemDefaultCodePage = 437;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0000A93C File Offset: 0x00008B3C
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0000A956 File Offset: 0x00008B56
		public static int CodePage
		{
			get
			{
				if (global::ICSharpCode.SharpZipLib.Zip.ZipStrings.codePage != -1)
				{
					return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.codePage;
				}
				return global::System.Text.Encoding.UTF8.CodePage;
			}
			set
			{
				if (value < 0 || value > 65535 || value == 1 || value == 2 || value == 3 || value == 42)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				global::ICSharpCode.SharpZipLib.Zip.ZipStrings.codePage = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000A986 File Offset: 0x00008B86
		public static int SystemDefaultCodePage { get; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000A98D File Offset: 0x00008B8D
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0000A9A0 File Offset: 0x00008BA0
		public static bool UseUnicode
		{
			get
			{
				return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.codePage == global::System.Text.Encoding.UTF8.CodePage;
			}
			set
			{
				if (value)
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipStrings.codePage = global::System.Text.Encoding.UTF8.CodePage;
					return;
				}
				global::ICSharpCode.SharpZipLib.Zip.ZipStrings.codePage = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.SystemDefaultCodePage;
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000A9BF File Offset: 0x00008BBF
		public static string ConvertToString(byte[] data, int count)
		{
			if (data != null)
			{
				return global::System.Text.Encoding.GetEncoding(global::ICSharpCode.SharpZipLib.Zip.ZipStrings.CodePage).GetString(data, 0, count);
			}
			return string.Empty;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000A9DC File Offset: 0x00008BDC
		public static string ConvertToString(byte[] data)
		{
			return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToString(data, data.Length);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000A9E7 File Offset: 0x00008BE7
		private static global::System.Text.Encoding EncodingFromFlag(int flags)
		{
			if ((flags & 2048) == 0)
			{
				return global::System.Text.Encoding.GetEncoding((global::ICSharpCode.SharpZipLib.Zip.ZipStrings.codePage == -1) ? global::ICSharpCode.SharpZipLib.Zip.ZipStrings.SystemDefaultCodePage : global::ICSharpCode.SharpZipLib.Zip.ZipStrings.codePage);
			}
			return global::System.Text.Encoding.UTF8;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000AA11 File Offset: 0x00008C11
		public static string ConvertToStringExt(int flags, byte[] data, int count)
		{
			if (data != null)
			{
				return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.EncodingFromFlag(flags).GetString(data, 0, count);
			}
			return string.Empty;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000AA2A File Offset: 0x00008C2A
		public static string ConvertToStringExt(int flags, byte[] data)
		{
			return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToStringExt(flags, data, data.Length);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000AA36 File Offset: 0x00008C36
		public static byte[] ConvertToArray(string str)
		{
			if (str != null)
			{
				return global::System.Text.Encoding.GetEncoding(global::ICSharpCode.SharpZipLib.Zip.ZipStrings.CodePage).GetBytes(str);
			}
			return global::ICSharpCode.SharpZipLib.Core.Empty.Array<byte>();
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000AA51 File Offset: 0x00008C51
		public static byte[] ConvertToArray(int flags, string str)
		{
			if (!string.IsNullOrEmpty(str))
			{
				return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.EncodingFromFlag(flags).GetBytes(str);
			}
			return global::ICSharpCode.SharpZipLib.Core.Empty.Array<byte>();
		}

		// Token: 0x0400010A RID: 266
		private static int codePage = -1;

		// Token: 0x0400010B RID: 267
		private const int AutomaticCodePage = -1;

		// Token: 0x0400010C RID: 268
		private const int FallbackCodePage = 437;
	}
}
