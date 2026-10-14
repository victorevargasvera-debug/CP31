using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace SpecialFeatures.CloneWizard
{
	// Token: 0x02000196 RID: 406
	public class SetCloneBtnLblConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06001370 RID: 4976 RVA: 0x001C2E9C File Offset: 0x001C109C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1075733466;
			short num2 = num;
			num = (short)837116890;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_91:
				if (!(value is bool?))
				{
					goto IL_FE;
				}
				num = (short)1791819779;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)199163904;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_75;
				}
				break;
			}
			bool? flag3;
			for (;;)
			{
				IL_53:
				switch (num3)
				{
				case 0:
				{
					bool? flag;
					bool flag2;
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num = (short)1845690370;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C2;
				}
				case 1:
					if (flag3 != null)
					{
						num = (short)1348599813;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BC;
				case 2:
					goto IL_F9;
				case 3:
					flag3 = (value as bool?);
					num = (short)1829044228;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_164;
				case 5:
				{
					bool? flag = flag3;
					bool flag2 = true;
					num = (short)1145372672;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_91;
				}
				goto IL_75;
			}
			IL_F9:
			goto IL_1BC;
			IL_164:
			num = (short)697368576;
			short num4 = num;
			num = (short)788070401;
			if (num != 0)
			{
			}
			goto IL_FE;
			IL_1BC:
			return global::CommonResources.AppResources.Save_As;
			IL_1C2:
			return global::CommonResources.AppResources.Clone_Id;
			IL_75:
			flag3 = new bool?(true);
			num = (short)904724486;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_53;
			IL_FE:
			num = (short)506593281;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_53;
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x001C3070 File Offset: 0x001C1270
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)588067833;
			short num2 = num;
			num = (short)490091513;
			switch (num2 == num)
			{
			default:
			{
				num = (short)580845568;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)863240193;
			if (num != 0)
			{
			}
			num = (short)219611136;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
