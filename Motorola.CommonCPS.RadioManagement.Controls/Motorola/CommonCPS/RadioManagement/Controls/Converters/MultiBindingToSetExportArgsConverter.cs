using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using Controls.SetsImportExport;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls.Converters
{
	// Token: 0x02000134 RID: 308
	public class MultiBindingToSetExportArgsConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000970 RID: 2416 RVA: 0x0009C58C File Offset: 0x0009A78C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			short num = (short)1806761990;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.IEnumerable<string> enumerable;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
			global::System.Collections.Generic.IEnumerable<string> enumerable2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_262;
				case 1:
				{
					num = (short)1262878720;
					short num3 = num;
					num = (short)1072955394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (enumerable == null)
					{
						num = (short)776470535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_267;
				case 3:
					goto IL_179;
				case 4:
				{
					if (values.Length >= 3)
					{
						setCategory = (values[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
						enumerable2 = (values[2] as global::System.Collections.Generic.IEnumerable<string>);
						enumerable = (values[1] as global::System.Collections.Generic.IEnumerable<string>);
						num = (short)2017591304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)571149247;
					short num4 = num;
					num = (short)1986792383;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_179;
					default:
						num = (short)967442432;
						if (num != 0)
						{
						}
						num = (short)1490485248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (enumerable2 != null)
					{
						num = (short)517931009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_162;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 7:
					goto IL_162;
				case 8:
					if (setCategory != null)
					{
						num = (short)322764810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_162;
				case 9:
					num = (short)357433348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)611975169;
					if (num != 0)
					{
					}
					num = (short)283901957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_59:
				if (!values.Any(new global::System.Func<object, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.Converters.MultiBindingToSetExportArgsConverter.<>c.<>9.a)))
				{
					num = (short)357826569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1DD;
				IL_162:
				num = (short)1932460035;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_179:
			throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮝캟톡톣횥\ud8a7얩\udeab\udaad햯횱钳습솷쪹\ud9bb", a_));
			IL_1DD:
			return null;
			IL_262:
			goto IL_1DD;
			IL_267:
			return new global::Controls.SetsImportExport.SetExportArgs
			{
				SetCategory = setCategory,
				TranslatedColumnNamesList = enumerable2,
				OrderdColumnNamesList = enumerable
			};
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0009C81C File Offset: 0x0009AA1C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1691269831;
			short num2 = num;
			num = (short)2055125703;
			switch (num2 == num)
			{
			}
			num = (short)2055864321;
			if (num != 0)
			{
			}
			num = (short)784596992;
			short num3 = num;
			num = (short)601489408;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
