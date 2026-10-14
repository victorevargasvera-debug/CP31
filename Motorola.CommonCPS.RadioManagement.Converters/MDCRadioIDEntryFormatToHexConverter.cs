using System;
using System.Globalization;
using System.Windows.Data;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000014 RID: 20
	public class MDCRadioIDEntryFormatToHexConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000047EC File Offset: 0x000029EC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 14;
			short num = (short)1322319872;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)597098496;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_1E;
				case 1:
				{
					num = (short)1344254285;
					short num4 = num;
					num = (short)441364813;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E;
					default:
						goto IL_15A;
					}
					break;
				}
				case 2:
					goto IL_A8;
				case 3:
					if (this.a(parameter))
					{
						num = (short)1963130881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_176;
				}
				goto IL_68;
				IL_1E:
				switch (0)
				{
				case 0:
					IL_68:
					if (value == null)
					{
						num = (short)1439367169;
						if (num != 0)
						{
						}
						num = (short)1740177410;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1846018051;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_A8:
			return null;
			IL_15A:
			num = (short)573308928;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("째菺蛼쿾簀", a_), global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.InvariantCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꇸ", a_), global::System.Globalization.CultureInfo.InvariantCulture));
			IL_176:
			return global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004980 File Offset: 0x00002B80
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1658925953;
			short num2 = num;
			num = (short)520041345;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1504837632;
				if (num != 0)
				{
				}
				if (value == null)
				{
					num = (short)487587841;
					if (num != 0)
					{
					}
					return null;
				}
				break;
			}
			num = (short)2006843392;
			short num3 = num;
			return global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004A40 File Offset: 0x00002C40
		private bool a(object A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
					if (dataRecord != null)
					{
						num2 = (short)330563585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 1:
					num2 = (short)178323460;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)2016346113;
					if (num2 != 0)
					{
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? subSystemType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
					flag = (subSystemType.GetValueOrDefault() == astroSystemSubType & subSystemType != null);
					goto IL_17D;
				}
				case 3:
					return true;
				case 4:
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
					global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem astroSystem = dataRecord.DataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem;
					if (astroSystem == null)
					{
						num2 = (short)451608581;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? subSystemType = astroSystem.SubSystemType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.MDC;
					num2 = (short)192282626;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					flag = false;
					goto IL_17D;
				}
				goto IL_28;
				IL_17D:
				if (!flag)
				{
					return false;
				}
				num2 = (short)1425408003;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_28:
			num2 = (short)730523580;
			short num3 = num2;
			num2 = (short)1052239804;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num2 = (short)591921152;
				if (num2 != 0)
				{
				}
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = A_0 as global::Infragistics.Windows.DataPresenter.DataRecord;
				break;
			}
			}
			num2 = (short)728104960;
			short num4 = num2;
			num2 = (short)1844969472;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
