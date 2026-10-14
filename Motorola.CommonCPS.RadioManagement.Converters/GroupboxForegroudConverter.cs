using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000010 RID: 16
	public class GroupboxForegroudConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000040CC File Offset: 0x000022CC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2028470273;
			if (num != 0)
			{
			}
			num = (short)2061697024;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_3D;
				case 1:
				{
					num = (short)1119097671;
					short num3 = num;
					num = (short)121180999;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
						goto IL_10E;
					}
					break;
				}
				case 2:
					goto IL_9E;
				case 3:
					if (!(bool)value)
					{
						num = (short)893124609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12F;
				}
				goto IL_87;
				IL_3D:
				num = (short)1127088128;
				short num4 = num;
				switch (0)
				{
				case 0:
					IL_87:
					if (value == null)
					{
						num = (short)732299266;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)235077635;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_9E:
			return global::System.Windows.Media.Brushes.Black;
			IL_10E:
			num = (short)1356005376;
			if (num != 0)
			{
			}
			return global::System.Windows.Media.Brushes.Gray;
			IL_12F:
			return global::System.Windows.Media.Brushes.Black;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004210 File Offset: 0x00002410
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1218510848;
			short num2 = num;
			num = (short)1383596033;
			if (num != 0)
			{
			}
			num = (short)1286515583;
			short num3 = num;
			num = (short)1088203647;
			switch (num3 == num)
			{
			}
			num = (short)2013855744;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
