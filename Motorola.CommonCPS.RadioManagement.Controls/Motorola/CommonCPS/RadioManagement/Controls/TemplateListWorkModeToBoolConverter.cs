using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000111 RID: 273
	public class TemplateListWorkModeToBoolConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060008A7 RID: 2215 RVA: 0x0008F650 File Offset: 0x0008D850
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)550830083;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1437925378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)644677632;
					short num3 = num;
					num = (short)1026883585;
					if (num != 0)
					{
					}
					num = (short)1877156008;
					short num4 = num;
					num = (short)213524648;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
						goto IL_EF;
					}
					break;
				}
				case 2:
					goto IL_11F;
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
				num = (short)1150484480;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35:
				if ((global::Motorola.CommonCPS.RadioManagement.Controls.TemplateListWorkMode)value != global::Motorola.CommonCPS.RadioManagement.Controls.TemplateListWorkMode.Editing)
				{
					goto IL_3D;
				}
				num = (short)2139488257;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EF:
			num = (short)452657152;
			if (num != 0)
			{
			}
			bool flag = false;
			goto IL_122;
			IL_11F:
			flag = true;
			IL_122:
			return flag;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0008F784 File Offset: 0x0008D984
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1252699373;
			short num2 = num;
			num = (short)69774573;
			switch (num2 == num)
			{
			}
			num = (short)2084372480;
			short num3 = num;
			num = (short)685965313;
			if (num != 0)
			{
			}
			num = (short)2002452480;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
