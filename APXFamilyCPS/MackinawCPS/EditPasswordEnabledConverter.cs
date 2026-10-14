using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.Server.EntityModel;

namespace MackinawCPS
{
	// Token: 0x02000015 RID: 21
	public class EditPasswordEnabledConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600004D RID: 77 RVA: 0x0000B514 File Offset: 0x00009714
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)841482247;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
				switch (num2)
				{
				case 0:
					goto IL_1FC;
				case 1:
				{
					if (apxradio == null)
					{
						goto IL_12D;
					}
					int? productFamily = apxradio.ProductFamily;
					num = (short)1187315715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_67;
				case 3:
				{
					int? productFamily;
					if (productFamily == null)
					{
						num = (short)968818688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					productFamily = apxradio.ProductFamily;
					global::Motorola.Common.Communication.CommonUtil.ProductFamily value2 = (global::Motorola.Common.Communication.CommonUtil.ProductFamily)productFamily.Value;
					num = (short)1128651822;
					short num3 = num;
					num = (short)1155390510;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12D;
					default:
						num = (short)812908544;
						if (num != 0)
						{
						}
						num = (short)122748933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					num = (short)332464134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					global::Motorola.Common.Communication.CommonUtil.ProductFamily value2;
					if (value2 != global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio)
					{
						num = (short)165871620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14A;
				}
				case 6:
				{
					global::Motorola.Common.Communication.CommonUtil.ProductFamily value2;
					if (value2 == global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio)
					{
						num = (short)244187145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_208;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 8:
					goto IL_145;
				case 9:
					goto IL_18F;
				}
				IL_4D:
				if (value == null)
				{
					num = (short)186253314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				apxradio = (value as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
				num = (short)1511260161;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_12D:
				num = (short)1558839304;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_67:
			return true;
			IL_145:
			return true;
			IL_14A:
			return false;
			IL_18F:
			num = (short)588840961;
			if (num != 0)
			{
			}
			goto IL_14A;
			IL_1FC:
			return true;
			IL_208:
			num = (short)743309312;
			short num4 = num;
			return true;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000B758 File Offset: 0x00009958
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)666501121;
			if (num != 0)
			{
			}
			num = (short)1978238555;
			short num2 = num;
			num = (short)267552347;
			switch (num2 == num)
			{
			}
			num = (short)1603796992;
			if (num != 0)
			{
			}
			num = (short)1130889216;
			short num3 = num;
			return null;
		}

		// Token: 0x04000029 RID: 41
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
