using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000035 RID: 53
	internal class ViewCacheFieldsToPrecentageConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000B31C File Offset: 0x0000951C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)38404096;
			switch (num)
			{
			default:
			{
				num = (short)1273626626;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				int value2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_8D;
					case 1:
					{
						string value;
						if (string.IsNullOrEmpty(value))
						{
							num = (short)1381367813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_245;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_6B;
						}
						continue;
					case 3:
						num = (short)605356040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (num3 == 0)
						{
							num = (short)1232928774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1056768007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1F5;
					case 6:
						goto IL_19A;
					case 7:
					{
						int num4;
						if (num4 != 1)
						{
							num = (short)880410627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92;
					}
					case 8:
					{
						int num4;
						if (num4 - 3 <= 3)
						{
							num = (short)120651785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)15073281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_F6;
					}
					IL_6B:
					if (values[0] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)964493312;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num3 = (int)values[0];
						value2 = (int)values[1];
						int num4 = (int)values[2];
						string value = values[3] as string;
						num = (short)393942047;
						short num5 = num;
						num = (short)2089423903;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_19F;
						default:
							num = (short)285802496;
							if (num != 0)
							{
							}
							num = (short)664535044;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
				IL_8D:
				return 0.0;
				IL_92:
				return (double)(value2 / num3 * 100m);
				IL_F6:
				goto IL_92;
				IL_19A:
				return 0.0;
				IL_19F:
				return 100.0;
				IL_1F5:
				goto IL_19F;
				IL_245:
				num = (short)309133312;
				short num6 = num;
				num = (short)761069569;
				if (num != 0)
				{
				}
				return (double)(value2 / num3 * 100m);
			}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000B5E8 File Offset: 0x000097E8
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)696783364;
			short num2 = num;
			num = (short)133304836;
			switch (num2 == num)
			{
			}
			num = (short)491126785;
			if (num != 0)
			{
			}
			num = (short)842989568;
			short num3 = num;
			num = (short)2051801088;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
