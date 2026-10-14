using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000110 RID: 272
	internal class ConfigurationListWorkModeToBoolConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060008A4 RID: 2212 RVA: 0x0008F458 File Offset: 0x0008D658
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1246822403;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)451084290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1732968448;
					short num3 = num;
					num = (short)364418669;
					short num4 = num;
					num = (short)463050349;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
						goto IL_CA;
					}
					break;
				}
				case 2:
					goto IL_123;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				goto IL_35;
				IL_3D:
				num = (short)1215430656;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35:
				if ((global::Motorola.CommonCPS.RadioManagement.Controls.ConfigurationListWorkMode)value != global::Motorola.CommonCPS.RadioManagement.Controls.ConfigurationListWorkMode.Editing)
				{
					goto IL_3D;
				}
				num = (short)2068316161;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CA:
			num = (short)2115960833;
			if (num != 0)
			{
			}
			num = (short)1065615360;
			if (num != 0)
			{
			}
			bool flag = false;
			goto IL_126;
			IL_123:
			flag = true;
			IL_126:
			return flag;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0008F590 File Offset: 0x0008D790
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)408702666;
			short num2 = num;
			num = (short)2017742538;
			switch (num2 == num)
			{
			}
			num = (short)1002373120;
			short num3 = num;
			num = (short)1654128640;
			if (num != 0)
			{
			}
			num = (short)658767873;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
