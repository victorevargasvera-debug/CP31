using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ConstraintHelper
{
	// Token: 0x020005FE RID: 1534
	public class LabelBindingConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600D10A RID: 53514 RVA: 0x00C3D900 File Offset: 0x00C3BB00
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)456916992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				bool flag;
				for (;;)
				{
					IL_27:
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_111;
					case 1:
					{
						object obj;
						if (!bool.Parse(obj.ToString()))
						{
							num = (short)648544259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8F;
					}
					case 2:
						if (values != null)
						{
							num = (short)205258760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24C;
					case 3:
						goto IL_ED;
					case 4:
					{
						object obj;
						if (obj != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1377828874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8F;
					}
					case 5:
					{
						num = (short)1329070080;
						short num3 = num;
						if (num4 >= values.Length)
						{
							num = (short)1179189257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj = values[num4];
						num = (short)1515520004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num = (short)623031491;
						short num5 = num;
						num = (short)733983939;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_ED;
						default:
							goto IL_234;
						}
						break;
					}
					case 7:
						goto IL_111;
					case 8:
						num4 = 0;
						num = (short)475201536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_173;
					case 10:
						num = (short)650575873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5A;
					IL_8F:
					num4++;
					num = (short)281149447;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_111:
					num = (short)929234949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ED:
					num = (short)1564672001;
					if (num != 0)
					{
					}
					flag = false;
					num = (short)1423441926;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_173:
				goto IL_24C;
				IL_234:
				num = (short)168361984;
				if (num != 0)
				{
				}
				IL_24C:
				return flag;
				IL_5A:
				flag = true;
				num = (short)2064580610;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600D10B RID: 53515 RVA: 0x00C3DB60 File Offset: 0x00C3BD60
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)155718460;
			short num2 = num;
			num = (short)615584572;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1169620992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1565917184;
			if (num != 0)
			{
			}
			num = (short)760741889;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
