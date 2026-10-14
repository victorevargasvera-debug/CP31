using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000060 RID: 96
	public class MNISRegionToNAConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000123 RID: 291 RVA: 0x0000FE60 File Offset: 0x0000E060
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 18;
			short num = (short)294912000;
			switch (num)
			{
			default:
			{
				num = (short)1031274502;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2;
						if (!(productFamily.GetValueOrDefault() == productFamily2 & productFamily != null))
						{
							num = (short)2072379401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A8;
					}
					case 1:
						goto IL_1E4;
					case 2:
						goto IL_247;
					case 3:
					{
						num = (short)563329596;
						short num3 = num;
						num = (short)1162000956;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1DE;
						default:
							num = (short)2022047744;
							if (num != 0)
							{
							}
							goto IL_A8;
						}
						break;
					}
					case 4:
						if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)137822216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E4;
					case 5:
						if (flag)
						{
							num = (short)1553268738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FC;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 7:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily = productFamily3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2 = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS;
						num = (short)163315712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily3 = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily?)values[1];
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily = productFamily3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2 = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller;
						num = (short)1733558284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily = productFamily3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2 = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC;
						num = (short)1632501771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_A3;
					case 11:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2;
						if (productFamily.GetValueOrDefault() == productFamily2 & productFamily != null)
						{
							num = (short)1109458947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E4;
					}
					case 12:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2;
						if (!(productFamily.GetValueOrDefault() == productFamily2 & productFamily != null))
						{
							num = (short)45547527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A8;
					}
					}
					IL_81:
					if (values[0] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)981139466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = false;
					num = (short)881459201;
					if (num != 0)
					{
					}
					num = (short)1571225604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A8:
					flag = true;
					num = (short)1357643777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E4:
					num = (short)620232704;
					short num4 = num;
					num = (short)1091567621;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A3:
				IL_1DE:
				return string.Empty;
				IL_247:
				return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("돼탾䀀", a_);
				IL_2FC:
				return ((global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName)values[0]).ToResourceString();
			}
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00010178 File Offset: 0x0000E378
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)971898881;
			if (num != 0)
			{
			}
			num = (short)361761952;
			short num2 = num;
			num = (short)629148832;
			switch (num2 == num)
			{
			}
			num = (short)673185792;
			short num3 = num;
			num = (short)2095644672;
			if (num != 0)
			{
			}
			return new object[]
			{
				value
			};
		}
	}
}
