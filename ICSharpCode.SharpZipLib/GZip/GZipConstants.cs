using System;
using System.Text;

namespace ICSharpCode.SharpZipLib.GZip
{
	// Token: 0x02000050 RID: 80
	public sealed class GZipConstants
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0001229C File Offset: 0x0001049C
		public static global::System.Text.Encoding Encoding
		{
			get
			{
				global::System.Text.Encoding result;
				try
				{
					result = global::System.Text.Encoding.GetEncoding(1252);
				}
				catch
				{
					result = global::System.Text.Encoding.ASCII;
				}
				return result;
			}
		}

		// Token: 0x04000262 RID: 610
		public const byte ID1 = 31;

		// Token: 0x04000263 RID: 611
		public const byte ID2 = 139;

		// Token: 0x04000264 RID: 612
		public const byte CompressionMethodDeflate = 8;
	}
}
