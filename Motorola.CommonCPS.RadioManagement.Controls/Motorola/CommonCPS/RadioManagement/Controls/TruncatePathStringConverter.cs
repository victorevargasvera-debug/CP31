using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000AD RID: 173
	public class TruncatePathStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000464 RID: 1124 RVA: 0x00047F98 File Offset: 0x00046198
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 2;
			short num = (short)562102272;
			switch (num)
			{
			default:
			{
				num = (short)966459397;
				int num2 = (int)((global::System.IntPtr)num);
				string text;
				int num3;
				for (;;)
				{
					string text2;
					string text3;
					switch (num2)
					{
					case 0:
						if (text.Contains(text2))
						{
							num = (short)572391430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1562771473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_196;
					case 2:
						goto IL_2FC;
					case 3:
						num3 = 20;
						num = (short)1946877953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_ED;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					case 6:
						text = text.Substring(text2.Length, text.Length - text2.Length);
						num = (short)917372932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)583729168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = string.Empty;
						num = (short)789512194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1800536077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_F2;
					case 10:
						num = (short)499384321;
						if (num != 0)
						{
						}
						if (text3 != null)
						{
							num = (short)239599616;
							short num4 = num;
							num = (short)1438253070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F2;
					case 11:
						goto IL_196;
					case 12:
						goto IL_39A;
					case 13:
					{
						int num5;
						if (num5 > 4)
						{
							num = (short)775684111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F2;
					}
					case 14:
						num = (short)36241426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						int num5;
						num3 = num5;
						num = (short)1274281993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						num = (short)782848843;
						short num6 = num;
						num = (short)1549620043;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27C;
						default:
							num = (short)1543569408;
							if (num != 0)
							{
							}
							num = (short)1728380928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 17:
						if (text.Length > num3)
						{
							num = (short)818151436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 18:
					{
						int num5;
						if (int.TryParse(text3, out num5))
						{
							num = (short)1541799944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F2;
					}
					}
					IL_9A:
					if (parameter == null)
					{
						num = (short)1644167171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = global::System.Convert.ToInt32(parameter);
					goto IL_27C;
					IL_F2:
					text = (value as string);
					text2 = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\uda99쎛캝蒟킡膣쎥캧覩얫킭좯", a_);
					num = (short)384172039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_196:
					text3 = global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좙톛킝솟풡춣솥즧\udea9쎫\udcad펱삳\udeb5ﲷ펹쾻튽ꆿ믁韃닅뫇ꏉꋋ꧍鷏돑곓髕뷗듙꣛뛝", a_)];
					num = (short)556400650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27C:
					num = (short)1618149387;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_ED:
				IL_2FC:
				return text;
				IL_39A:
				int num7 = num3 - 1;
				int num8 = num7 / 2;
				return text.Substring(0, num8) + global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("벹", a_) + text.Substring(text.Length - (num7 - num8));
			}
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000483AC File Offset: 0x000465AC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1258901952;
			short num2 = num;
			num = (short)978670016;
			switch (num2 == num)
			{
			}
			num = (short)475725824;
			short num3 = num;
			num = (short)1103167489;
			if (num != 0)
			{
			}
			num = (short)1537671168;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
