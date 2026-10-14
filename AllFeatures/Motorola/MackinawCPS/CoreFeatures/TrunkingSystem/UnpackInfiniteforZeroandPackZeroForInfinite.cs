using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000072 RID: 114
	public sealed class UnpackInfiniteforZeroandPackZeroForInfinite : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000C73 RID: 3187 RVA: 0x000CEB6C File Offset: 0x000CCD6C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			string result;
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_ED;
				case 1:
					result = global::CommonResources.AcgResources.ID_INFINITE;
					num2 = (short)405798914;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)1013645312;
					short num3 = num2;
					if (num4 == 0)
					{
						num2 = (short)1630928897;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CD;
				}
				}
				goto IL_20;
			}
			IL_ED:
			num2 = (short)1051721729;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			num4 = (int)value;
			num2 = (short)444142548;
			short num5 = num2;
			num2 = (short)1260065748;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_CD:
				result = num4.ToString();
				num2 = (short)1392115712;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1951334400;
				if (num2 != 0)
				{
				}
				num2 = (short)50593795;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000CECB0 File Offset: 0x000CCEB0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num2;
			short num3;
			string text;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_121;
				case 1:
					num2 = 0;
					num3 = (short)513277954;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					goto IL_13E;
				case 3:
					if (text.CompareTo(global::CommonResources.AcgResources.ID_INFINITE) == 0)
					{
						num3 = (short)1873739777;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_103;
				}
				goto IL_20;
			}
			IL_121:
			IL_13E:
			return num2;
			IL_20:
			text = (string)value;
			num3 = (short)1710489601;
			if (num3 != 0)
			{
			}
			num3 = (short)977341479;
			short num4 = num3;
			num3 = (short)1002441767;
			switch ((num4 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_103:
				num2 = int.Parse(text);
				num3 = (short)877461504;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			default:
			{
				num3 = (short)1924595712;
				if (num3 != 0)
				{
				}
				num3 = (short)858521600;
				short num5 = num3;
				num3 = (short)634519555;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			}
		}
	}
}
