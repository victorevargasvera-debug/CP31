using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200007C RID: 124
	public class GridViewSourceConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000178 RID: 376 RVA: 0x00013DF4 File Offset: 0x00011FF4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)954073091;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)411439415;
					short num3 = num;
					num = (short)1655574839;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_BC;
					}
					break;
				}
				case 1:
					if (value is global::System.ComponentModel.ICollectionView)
					{
						num = (short)387252224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_127;
				case 2:
					goto IL_4D;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (value == null)
				{
					num = (short)1863647234;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1871511553;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_4D:
			return null;
			IL_BC:
			num = (short)2077556736;
			if (num != 0)
			{
			}
			num = (short)1622933505;
			if (num != 0)
			{
			}
			num = (short)1203437568;
			short num4 = num;
			return value;
			IL_127:
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(value);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00013F30 File Offset: 0x00012130
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 11;
			short num = (short)1065080734;
			short num2 = num;
			num = (short)968939422;
			switch (num2 == num)
			{
			}
			num = (short)1990262785;
			if (num != 0)
			{
			}
			num = (short)924254208;
			if (num != 0)
			{
			}
			num = (short)1069547520;
			short num3 = num;
			throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꗵ郷鯹郻鋽⃿氁欃爅⠇椉挋挍甏㈑怓礕㠗爙礛氝䔟", a_));
		}
	}
}
