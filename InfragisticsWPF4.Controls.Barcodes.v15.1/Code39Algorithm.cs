using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000007 RID: 7
	internal class Code39Algorithm : global::Infragistics.Controls.Barcodes.BarcodeAlgorithm
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000040CC File Offset: 0x000022CC
		static Code39Algorithm()
		{
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['0'] = new byte[]
			{
				1,
				1,
				1,
				3,
				3,
				1,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['1'] = new byte[]
			{
				3,
				1,
				1,
				3,
				1,
				1,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['2'] = new byte[]
			{
				1,
				1,
				3,
				3,
				1,
				1,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['3'] = new byte[]
			{
				3,
				1,
				3,
				3,
				1,
				1,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['4'] = new byte[]
			{
				1,
				1,
				1,
				3,
				3,
				1,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['5'] = new byte[]
			{
				3,
				1,
				1,
				3,
				3,
				1,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['6'] = new byte[]
			{
				1,
				1,
				3,
				3,
				3,
				1,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['7'] = new byte[]
			{
				1,
				1,
				1,
				3,
				1,
				1,
				3,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['8'] = new byte[]
			{
				3,
				1,
				1,
				3,
				1,
				1,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['9'] = new byte[]
			{
				1,
				1,
				3,
				3,
				1,
				1,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['A'] = new byte[]
			{
				3,
				1,
				1,
				1,
				1,
				3,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['B'] = new byte[]
			{
				1,
				1,
				3,
				1,
				1,
				3,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['C'] = new byte[]
			{
				3,
				1,
				3,
				1,
				1,
				3,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['D'] = new byte[]
			{
				1,
				1,
				1,
				1,
				3,
				3,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['E'] = new byte[]
			{
				3,
				1,
				1,
				1,
				3,
				3,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['F'] = new byte[]
			{
				1,
				1,
				3,
				1,
				3,
				3,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['G'] = new byte[]
			{
				1,
				1,
				1,
				1,
				1,
				3,
				3,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['H'] = new byte[]
			{
				3,
				1,
				1,
				1,
				1,
				3,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['I'] = new byte[]
			{
				1,
				1,
				3,
				1,
				1,
				3,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['J'] = new byte[]
			{
				1,
				1,
				1,
				1,
				3,
				3,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['K'] = new byte[]
			{
				3,
				1,
				1,
				1,
				1,
				1,
				1,
				3,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['L'] = new byte[]
			{
				1,
				1,
				3,
				1,
				1,
				1,
				1,
				3,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['M'] = new byte[]
			{
				3,
				1,
				3,
				1,
				1,
				1,
				1,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['N'] = new byte[]
			{
				1,
				1,
				1,
				1,
				3,
				1,
				1,
				3,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['O'] = new byte[]
			{
				3,
				1,
				1,
				1,
				3,
				1,
				1,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['P'] = new byte[]
			{
				1,
				1,
				3,
				1,
				3,
				1,
				1,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['Q'] = new byte[]
			{
				1,
				1,
				1,
				1,
				1,
				1,
				3,
				3,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['R'] = new byte[]
			{
				3,
				1,
				1,
				1,
				1,
				1,
				3,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['S'] = new byte[]
			{
				1,
				1,
				3,
				1,
				1,
				1,
				3,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['T'] = new byte[]
			{
				1,
				1,
				1,
				1,
				3,
				1,
				3,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['U'] = new byte[]
			{
				3,
				3,
				1,
				1,
				1,
				1,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['V'] = new byte[]
			{
				1,
				3,
				3,
				1,
				1,
				1,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['W'] = new byte[]
			{
				3,
				3,
				3,
				1,
				1,
				1,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['X'] = new byte[]
			{
				1,
				3,
				1,
				1,
				3,
				1,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['Y'] = new byte[]
			{
				3,
				3,
				1,
				1,
				3,
				1,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['Z'] = new byte[]
			{
				1,
				3,
				3,
				1,
				3,
				1,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['-'] = new byte[]
			{
				1,
				3,
				1,
				1,
				1,
				1,
				3,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['.'] = new byte[]
			{
				3,
				3,
				1,
				1,
				1,
				1,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars[' '] = new byte[]
			{
				1,
				3,
				3,
				1,
				1,
				1,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['$'] = new byte[]
			{
				1,
				3,
				1,
				3,
				1,
				3,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['/'] = new byte[]
			{
				1,
				3,
				1,
				3,
				1,
				1,
				1,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['+'] = new byte[]
			{
				1,
				3,
				1,
				1,
				1,
				3,
				1,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['%'] = new byte[]
			{
				1,
				1,
				1,
				3,
				1,
				3,
				1,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['*'] = new byte[]
			{
				1,
				3,
				1,
				1,
				3,
				1,
				3,
				1,
				1
			};
		}

		// Token: 0x0400001C RID: 28
		public const string ValidCode39Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%";

		// Token: 0x0400001D RID: 29
		public const string ValidCode39CharsExtended = "%U$A$B$C$D$E$F$G$H$I$J$K$L$M$N$O$P$Q$R$S$T$U$V$W$X$Y$Z%A%B%C%D%E  /A/B/C/D/E/F/G/H/I/J/K/L - ./O 0 1 2 3 4 5 6 7 8 9/Z%F%G%H%I%J%V A B C D E F G H I J K L M N O P Q R S T U V W X Y Z%K%L%M%N%O%W+A+B+C+D+E+F+G+H+I+J+K+L+M+N+O+P+Q+R+S+T+U+V+W+X+Y+Z%P%Q%R%S%T";

		// Token: 0x0400001E RID: 30
		private const int WideToNarrowRatio = 3;

		// Token: 0x0400001F RID: 31
		internal const int NarrowBar = 1;

		// Token: 0x04000020 RID: 32
		internal const int WideBar = 3;

		// Token: 0x04000021 RID: 33
		public static readonly global::System.Collections.Generic.Dictionary<char, byte[]> Code39Chars = new global::System.Collections.Generic.Dictionary<char, byte[]>();
	}
}
