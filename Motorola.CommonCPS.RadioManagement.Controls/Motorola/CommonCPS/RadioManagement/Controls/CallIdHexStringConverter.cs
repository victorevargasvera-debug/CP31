using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000011 RID: 17
	public class CallIdHexStringConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00004084 File Offset: 0x00002284
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 9;
			short num = (short)1883570180;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						bool flag;
						object result;
						for (;;)
						{
							IL_73:
							switch (num2)
							{
							case 0:
								goto IL_C0;
							case 1:
								goto IL_170;
							case 2:
							{
								num = (short)1857872662;
								short num3 = num;
								num = (short)393470742;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_C0;
								default:
									goto IL_139;
								}
								break;
							}
							case 3:
								if (flag)
								{
									num = (short)770703360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = values[0];
								num = (short)1783758849;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_89;
							IL_C0:
							result = global::System.Convert.ToInt64(values[0], global::System.Globalization.CultureInfo.CurrentCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("裂", a_), global::System.Globalization.CultureInfo.CurrentCulture);
							num = (short)879886338;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_139:
						num = (short)1729560576;
						if (num != 0)
						{
						}
						IL_170:
						return result;
						IL_89:
						flag = (bool)values[1];
						num = (short)935788547;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_73;
					}
					catch (global::System.FormatException)
					{
						return values[0];
					}
					goto IL_17F;
				case 1:
					num = (short)1090519043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1FC;
				case 3:
					if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)269090818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17F;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				}
				IL_42:
				if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
				{
					num = (short)2103902209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_17F:
				num = (short)1817313281;
				if (num != 0)
				{
				}
				num = (short)1178468352;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1FC:
			num = (short)356909056;
			short num4 = num;
			return string.Empty;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000042DC File Offset: 0x000024DC
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1202885805;
			short num2 = num;
			num = (short)1249088685;
			switch (num2 == num)
			{
			}
			num = (short)929890304;
			short num3 = num;
			num = (short)538902529;
			if (num != 0)
			{
			}
			num = (short)777977856;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
