using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000008 RID: 8
	internal class EanUpcAlgorithm : global::Infragistics.Controls.Barcodes.BarcodeAlgorithm
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00004718 File Offset: 0x00002918
		static EanUpcAlgorithm()
		{
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcChars['0'] = new byte[]
			{
				3,
				2,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcChars['1'] = new byte[]
			{
				2,
				2,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcChars['2'] = new byte[]
			{
				2,
				1,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcChars['3'] = new byte[]
			{
				1,
				4,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcChars['4'] = new byte[]
			{
				1,
				1,
				3,
				2
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcChars['5'] = new byte[]
			{
				1,
				2,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcChars['6'] = new byte[]
			{
				1,
				1,
				1,
				4
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcChars['7'] = new byte[]
			{
				1,
				3,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcChars['8'] = new byte[]
			{
				1,
				2,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcChars['9'] = new byte[]
			{
				3,
				1,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.Parity13 = new global::System.Collections.Generic.Dictionary<char, byte[]>();
			global::System.Collections.Generic.Dictionary<char, byte[]> parity = global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.Parity13;
			char key = '0';
			byte[] value = new byte[6];
			parity[key] = value;
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.Parity13['1'] = new byte[]
			{
				0,
				0,
				1,
				0,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.Parity13['2'] = new byte[]
			{
				0,
				0,
				1,
				1,
				0,
				1
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.Parity13['3'] = new byte[]
			{
				0,
				0,
				1,
				1,
				1,
				0
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.Parity13['4'] = new byte[]
			{
				0,
				1,
				0,
				0,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.Parity13['5'] = new byte[]
			{
				0,
				1,
				1,
				0,
				0,
				1
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.Parity13['6'] = new byte[]
			{
				0,
				1,
				1,
				1,
				0,
				0
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.Parity13['7'] = new byte[]
			{
				0,
				1,
				0,
				1,
				0,
				1
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.Parity13['8'] = new byte[]
			{
				0,
				1,
				0,
				1,
				1,
				0
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.Parity13['9'] = new byte[]
			{
				0,
				1,
				1,
				0,
				1,
				0
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ParityE = new global::System.Collections.Generic.Dictionary<char, byte[]>();
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ParityE['0'] = new byte[]
			{
				1,
				1,
				1,
				0,
				0,
				0
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ParityE['1'] = new byte[]
			{
				1,
				1,
				0,
				1,
				0,
				0
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ParityE['2'] = new byte[]
			{
				1,
				1,
				0,
				0,
				1,
				0
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ParityE['3'] = new byte[]
			{
				1,
				1,
				0,
				0,
				0,
				1
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ParityE['4'] = new byte[]
			{
				1,
				0,
				1,
				1,
				0,
				0
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ParityE['5'] = new byte[]
			{
				1,
				0,
				0,
				1,
				1,
				0
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ParityE['6'] = new byte[]
			{
				1,
				0,
				0,
				0,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ParityE['7'] = new byte[]
			{
				1,
				0,
				1,
				0,
				1,
				0
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ParityE['8'] = new byte[]
			{
				1,
				0,
				1,
				0,
				0,
				1
			};
			global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ParityE['9'] = new byte[]
			{
				1,
				0,
				0,
				1,
				0,
				1
			};
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004AE4 File Offset: 0x00002CE4
		public static string ConvertUpcEToUpcA(string upcE)
		{
			if (string.IsNullOrEmpty(upcE) || upcE.Length != 7)
			{
				return string.Empty;
			}
			upcE = upcE.Substring(1);
			string str;
			string str2;
			if (upcE[5] == '0' || upcE[5] == '1' || upcE[5] == '2')
			{
				str = string.Concat(new object[]
				{
					upcE[0].ToString(),
					upcE[1],
					upcE[5],
					"00"
				});
				str2 = string.Concat(new object[]
				{
					"00",
					upcE[2],
					upcE[3],
					upcE[4]
				});
			}
			else if (upcE[5] == '3')
			{
				str = string.Concat(new object[]
				{
					upcE[0].ToString(),
					upcE[1],
					upcE[2],
					"00"
				});
				str2 = "000" + upcE[3] + upcE[4];
			}
			else if (upcE[5] == '4')
			{
				str = string.Concat(new object[]
				{
					upcE[0].ToString(),
					upcE[1],
					upcE[2],
					upcE[3],
					"0"
				});
				str2 = "0000" + upcE[4];
			}
			else
			{
				str = string.Concat(new object[]
				{
					upcE[0].ToString(),
					upcE[1],
					upcE[2],
					upcE[3],
					upcE[4]
				});
				str2 = "0000" + upcE[5];
			}
			return "0" + str + str2;
		}

		// Token: 0x04000022 RID: 34
		public const byte Odd = 0;

		// Token: 0x04000023 RID: 35
		public const byte Even = 1;

		// Token: 0x04000024 RID: 36
		public const string ValidUpcEanChars = "0123456789";

		// Token: 0x04000025 RID: 37
		public static byte[] FinderPattern = new byte[]
		{
			1,
			1,
			1
		};

		// Token: 0x04000026 RID: 38
		public static byte[] MiddlePattern = new byte[]
		{
			1,
			1,
			1,
			1,
			1
		};

		// Token: 0x04000027 RID: 39
		public static byte[] UpcEStopPattern = new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			1
		};

		// Token: 0x04000028 RID: 40
		public static readonly global::System.Collections.Generic.Dictionary<char, byte[]> UpcChars = new global::System.Collections.Generic.Dictionary<char, byte[]>();

		// Token: 0x04000029 RID: 41
		public static readonly global::System.Collections.Generic.Dictionary<char, byte[]> Parity13;

		// Token: 0x0400002A RID: 42
		public static readonly global::System.Collections.Generic.Dictionary<char, byte[]> ParityE;
	}
}
