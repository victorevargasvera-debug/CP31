using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000019 RID: 25
	internal class PasswordToTextConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000065FC File Offset: 0x000047FC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			string text;
			short num2;
			string text2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return text;
				case 1:
				{
					num2 = (short)1852178432;
					short num3 = num2;
					text2 = value.ToString();
					text = string.Empty;
					num2 = (short)451936260;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (value != null)
					{
						num2 = (short)1658060801;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 3:
				{
					if (text.Length >= text2.Length)
					{
						num2 = (short)1149632512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1465935550;
					short num4 = num2;
					num2 = (short)616654526;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_70;
					default:
						num2 = (short)1669529600;
						if (num2 != 0)
						{
						}
						text += global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("覢", a_);
						num2 = (short)1737097221;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					num2 = (short)1014824961;
					if (num2 != 0)
					{
					}
					goto IL_70;
				case 5:
					goto IL_70;
				}
				goto IL_31;
				IL_70:
				num2 = (short)1217134595;
				num = (int)((global::System.IntPtr)num2);
			}
			return text;
			IL_31:
			text2 = string.Empty;
			text = string.Empty;
			num2 = (short)218169346;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000067B0 File Offset: 0x000049B0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1321685256;
			short num2 = num;
			num = (short)899698952;
			switch (num2 == num)
			{
			}
			num = (short)930807808;
			short num3 = num;
			num = (short)1009713153;
			if (num != 0)
			{
			}
			num = (short)724107264;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
