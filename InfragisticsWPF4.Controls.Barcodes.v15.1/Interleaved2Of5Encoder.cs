using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000029 RID: 41
	internal class Interleaved2Of5Encoder
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00012C90 File Offset: 0x00010E90
		public static char GenerateCheckDigit(string code)
		{
			int num = 3;
			int num2 = 0;
			for (int i = code.Length - 1; i >= 0; i--)
			{
				int num3 = (int)(code[i] - '0');
				num2 += num * num3;
				num ^= 2;
			}
			return (char)((10 - num2 % 10) % 10 + 48);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00012CD7 File Offset: 0x00010ED7
		public static string VerifyI25Code(string codeText)
		{
			if (codeText.Length % 2 != 0)
			{
				return "0" + codeText;
			}
			return codeText;
		}
	}
}
