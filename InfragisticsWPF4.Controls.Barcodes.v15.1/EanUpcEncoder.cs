using System;
using System.Text;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000024 RID: 36
	internal class EanUpcEncoder
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00010344 File Offset: 0x0000E544
		public static string EncodeGtin12ToUpcECode(string code)
		{
			if (string.IsNullOrEmpty(code) || code.Length != 12 || !code.StartsWith("0", global::System.StringComparison.CurrentCulture))
			{
				return string.Empty;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(code[0]);
			if (code[10] >= '5' && code.Substring(6, 4).Equals("0000") && code[5] != '0')
			{
				stringBuilder.Append(code.Substring(1, 5));
				stringBuilder.Append(code[10]);
			}
			if (code.Substring(5, 5).Equals("00000") && code[4] != '0')
			{
				stringBuilder.Append(code.Substring(1, 4));
				stringBuilder.Append(code[10]);
				stringBuilder.Append('4');
			}
			if (code.Substring(3, 5).Equals("00000") || code.Substring(3, 5).Equals("10000") || code.Substring(3, 5).Equals("20000"))
			{
				stringBuilder.Append(code.Substring(1, 2));
				stringBuilder.Append(code.Substring(8, 3));
				stringBuilder.Append(code[3]);
			}
			if (code[3] >= '3' && code.Substring(4, 5) == "00000")
			{
				stringBuilder.Append(code.Substring(1, 3));
				stringBuilder.Append(code.Substring(9, 2));
				stringBuilder.Append('3');
			}
			stringBuilder.Append(code[11]);
			return stringBuilder.ToString();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000104DE File Offset: 0x0000E6DE
		public static byte[] GetUpcBars(char input)
		{
			if (!char.IsDigit(input))
			{
				input = '0';
			}
			return global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcChars[input];
		}
	}
}
