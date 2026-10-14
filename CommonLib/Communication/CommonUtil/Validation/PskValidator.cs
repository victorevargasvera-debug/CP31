using System;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.Communication.CommonUtil.Validation
{
	// Token: 0x0200009D RID: 157
	public static class PskValidator
	{
		// Token: 0x06000416 RID: 1046 RVA: 0x000432AC File Offset: 0x000414AC
		public static bool Valid(string input)
		{
			short num = (short)2092105729;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string text;
				switch (num2)
				{
				case 0:
					if (global::Motorola.Common.Communication.CommonUtil.Validation.PskValidator.a.IsMatch(input))
					{
						num = (short)1391329283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					text = string.Empty;
					goto IL_4B;
				case 3:
				{
					num = (short)1760761740;
					short num3 = num;
					num = (short)337581964;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_E5;
					}
					break;
				}
				}
				IL_35:
				if ((text = input) == null)
				{
					num = (short)1780482050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4B:
				input = text;
				num = (short)334626816;
				short num4 = num;
				num = (short)2096300032;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E5:
			num = (short)1435828225;
			if (num != 0)
			{
			}
			num = (short)1338769408;
			if (num != 0)
			{
			}
			return input.ToBch().Length == 16;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00043408 File Offset: 0x00041608
		// Note: this type is marked as 'beforefieldinit'.
		static PskValidator()
		{
			int a_ = 11;
			short num = (short)1298947365;
			short num2 = num;
			num = (short)163667237;
			switch (num2 == num)
			{
			}
			num = (short)990838784;
			short num3 = num;
			num = (short)1640562689;
			if (num != 0)
			{
			}
			num = (short)534904832;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.Validation.PskValidator.a = new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("儎䨐⌒㠔⸖堘㘚嬜䈞ਠܢ", a_));
		}

		// Token: 0x040004BC RID: 1212
		private static readonly global::System.Text.RegularExpressions.Regex a;
	}
}
