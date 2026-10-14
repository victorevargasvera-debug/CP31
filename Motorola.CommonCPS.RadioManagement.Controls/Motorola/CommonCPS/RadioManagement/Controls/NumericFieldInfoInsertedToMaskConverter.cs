using System;
using System.Globalization;
using System.Windows.Data;
using Infragistics.Controls.Editors;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000E3 RID: 227
	public class NumericFieldInfoInsertedToMaskConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000640 RID: 1600 RVA: 0x00063F34 File Offset: 0x00062134
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 15;
			int num;
			short num2;
			string text;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1878786049;
						if (num2 != 0)
						{
						}
						if (text == null)
						{
							num2 = (short)1511325698;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericInput rmnumericInput = (global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericInput)values[0];
						rmnumericInput.ValueConstraint = new global::Infragistics.Controls.Editors.ValueConstraint();
						rmnumericInput.ValueConstraint.MinInclusive = double.MinValue;
						num2 = (short)2110193667;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						return text;
					case 2:
					{
						num2 = (short)1103953920;
						short num3 = num2;
						text = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udca6잨\udeaa사춮풰솲좴", a_);
						num2 = (short)2048262145;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
						goto IL_D0;
					}
					goto IL_29;
				}
				IL_D0:
				num2 = (short)1363512180;
				short num4 = num2;
				num2 = (short)410553204;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_32;
				default:
					num2 = (short)1014824960;
					if (num2 != 0)
					{
					}
					break;
				}
				return text;
			}
			}
			IL_29:
			text = (values[1] as string);
			IL_32:
			num2 = (short)1971585024;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000640B0 File Offset: 0x000622B0
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)673260248;
			short num2 = num;
			num = (short)1917854424;
			switch (num2 == num)
			{
			}
			num = (short)328663040;
			if (num != 0)
			{
			}
			num = (short)1158938624;
			short num3 = num;
			num = (short)1791492097;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
