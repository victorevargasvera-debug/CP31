using System;
using System.Text;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000023 RID: 35
	public class Code39Encoder
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00010278 File Offset: 0x0000E478
		public static string ConvertCode39ExCode(string code)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < code.Length; i++)
			{
				char c = "%U$A$B$C$D$E$F$G$H$I$J$K$L$M$N$O$P$Q$R$S$T$U$V$W$X$Y$Z%A%B%C%D%E  /A/B/C/D/E/F/G/H/I/J/K/L - ./O 0 1 2 3 4 5 6 7 8 9/Z%F%G%H%I%J%V A B C D E F G H I J K L M N O P Q R S T U V W X Y Z%K%L%M%N%O%W+A+B+C+D+E+F+G+H+I+J+K+L+M+N+O+P+Q+R+S+T+U+V+W+X+Y+Z%P%Q%R%S%T"[(int)(code[i] * '\u0002')];
				char value = "%U$A$B$C$D$E$F$G$H$I$J$K$L$M$N$O$P$Q$R$S$T$U$V$W$X$Y$Z%A%B%C%D%E  /A/B/C/D/E/F/G/H/I/J/K/L - ./O 0 1 2 3 4 5 6 7 8 9/Z%F%G%H%I%J%V A B C D E F G H I J K L M N O P Q R S T U V W X Y Z%K%L%M%N%O%W+A+B+C+D+E+F+G+H+I+J+K+L+M+N+O+P+Q+R+S+T+U+V+W+X+Y+Z%P%Q%R%S%T"[(int)(code[i] * '\u0002' + '\u0001')];
				if (c != ' ')
				{
					stringBuilder.Append(c);
				}
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000102E4 File Offset: 0x0000E4E4
		public static string GenerateCheckDigit(string code)
		{
			int num = 0;
			for (int i = 0; i < code.Length; i++)
			{
				int num2 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%".IndexOf(code[i]);
				if (num2 < 0)
				{
					return string.Empty;
				}
				num += num2;
			}
			return "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%"[num % 43].ToString();
		}
	}
}
