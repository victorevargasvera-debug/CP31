using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000013 RID: 19
	internal class Interleaved2Of5Algorithm : global::Infragistics.Controls.Barcodes.BarcodeAlgorithm
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000075E8 File Offset: 0x000057E8
		static Interleaved2Of5Algorithm()
		{
			global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars = new global::System.Collections.Generic.Dictionary<int, byte[]>();
			global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars[0] = new byte[]
			{
				1,
				1,
				2,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars[1] = new byte[]
			{
				2,
				1,
				1,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars[2] = new byte[]
			{
				1,
				2,
				1,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars[3] = new byte[]
			{
				2,
				2,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars[4] = new byte[]
			{
				1,
				1,
				2,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars[5] = new byte[]
			{
				2,
				1,
				2,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars[6] = new byte[]
			{
				1,
				2,
				2,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars[7] = new byte[]
			{
				1,
				1,
				1,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars[8] = new byte[]
			{
				2,
				1,
				1,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars[9] = new byte[]
			{
				1,
				2,
				1,
				2,
				1
			};
		}

		// Token: 0x04000067 RID: 103
		public const string ValidI25Chars = "0123456789";

		// Token: 0x04000068 RID: 104
		public const int CharLength = 7;

		// Token: 0x04000069 RID: 105
		public static readonly global::System.Collections.Generic.Dictionary<int, byte[]> I25Chars;

		// Token: 0x0400006A RID: 106
		public static readonly byte[] StartPattern = new byte[]
		{
			1,
			1,
			1,
			1
		};

		// Token: 0x0400006B RID: 107
		public static readonly byte[] StopPattern = new byte[]
		{
			2,
			1,
			1
		};
	}
}
