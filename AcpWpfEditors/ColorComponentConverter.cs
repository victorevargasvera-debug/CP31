using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000008 RID: 8
	[global::System.Windows.Data.ValueConversion(typeof(global::System.Windows.Media.Color), typeof(int), ParameterType = typeof(string))]
	public class ColorComponentConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00006C18 File Offset: 0x00004E18
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			string a;
			short num2;
			global::System.Windows.Media.Color color;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (a == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꋟ", a_))
					{
						num2 = (short)823984134;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_323;
				case 1:
					goto IL_D2;
				case 2:
					color = ((global::System.Windows.Media.Color?)value).Value;
					num2 = (short)856621069;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_11B;
				case 4:
					if (parameter != null)
					{
						num2 = (short)127991815;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_172;
				case 5:
				{
					if (!(value is global::System.Windows.Media.Color?))
					{
						color = (global::System.Windows.Media.Color)value;
						num2 = (short)2051211273;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)818710592;
					short num3 = num2;
					num2 = (short)812550208;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_190;
					default:
						num2 = (short)63635456;
						if (num2 != 0)
						{
						}
						num2 = (short)1369243650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					goto IL_170;
				case 7:
				{
					a = parameter.ToString().ToUpper();
					num2 = (short)764215296;
					short num4 = num2;
					num2 = (short)907083784;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					goto IL_172;
				case 9:
					goto IL_D7;
				case 10:
					if (value == null)
					{
						goto IL_190;
					}
					num2 = (short)193069061;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_1A7;
				case 12:
					if (a == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꟟", a_))
					{
						num2 = (short)1785462785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1893597184;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_D7;
				case 14:
					if (a == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꇟ", a_))
					{
						num2 = (short)1663041539;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1440219148;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_55;
				IL_D7:
				num2 = (short)128843790;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_172:
				num2 = (short)1019478026;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_190:
				num2 = (short)837943307;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D2:
			return color.G;
			IL_11B:
			return color.A;
			IL_170:
			num2 = (short)936312833;
			if (num2 != 0)
			{
			}
			return color.B;
			IL_1A7:
			return 0;
			IL_323:
			return color.R;
			IL_55:
			a = "";
			num2 = (short)1990000644;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006F54 File Offset: 0x00005154
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 18;
			short num = (short)75943081;
			short num2 = num;
			num = (short)1402129577;
			switch (num2 == num)
			{
			}
			num = (short)174850048;
			if (num != 0)
			{
			}
			num = (short)329580544;
			short num3 = num;
			num = (short)594542593;
			if (num != 0)
			{
			}
			return new global::System.NotSupportedException(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鳞軠跢鏤苦鯨鿪꿬軮鋰飲헴駶雸迺\uddfc賾琀猂甄栆笈缊栌欎ㄐ焒气㜖洘猚琜氞Ġ䀢䨤䤦弨个弬嬮吰䄲᬴", a_));
		}
	}
}
