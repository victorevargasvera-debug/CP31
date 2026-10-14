using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200009C RID: 156
	public class EditCharacterConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x000187C4 File Offset: 0x000169C4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			string pattern;
			short num2;
			string a;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (new global::System.Text.RegularExpressions.Regex(pattern).IsMatch(value.ToString()))
					{
						num2 = (short)1399128068;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_34B;
				case 1:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꣪", a_)))
					{
						goto IL_15D;
					}
					num2 = (short)1748631565;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)457048076;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (value.ToString() != global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("", a_))
					{
						num2 = (short)2082471942;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20B;
				case 4:
					goto IL_1BD;
				case 5:
					num2 = (short)121044995;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_2A9;
				case 7:
					goto IL_179;
				case 8:
				{
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꫪ", a_)))
					{
						num2 = (short)2022440962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					pattern = global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뗪뛬\udfee\udcf0쫲듴\udaf6ꏸ髺탼藾崀瀂⼄⠆⨈␊⤌‎㜐㰒〔㠖㌘㐚㴜〞素ยਤదبЪȬ爮䨰̲ᤴԶस䘺᤼", a_);
					num2 = (short)1264761645;
					short num3 = num2;
					num2 = (short)1441577773;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15D;
					default:
						num2 = (short)689307648;
						if (num2 != 0)
						{
						}
						num2 = (short)1262878721;
						if (num2 != 0)
						{
						}
						num2 = (short)409600011;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					num2 = (short)1851326471;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_179;
				case 11:
					goto IL_179;
				case 12:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꧪ", a_)))
					{
						num2 = (short)13828110;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					pattern = text;
					num2 = (short)929955850;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
				{
					num2 = (short)1440808960;
					short num4 = num2;
					if (value != null)
					{
						num2 = (short)66584581;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20B;
				}
				case 14:
					num2 = (short)90570753;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_55;
				IL_15D:
				num2 = (short)1869545481;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_179:
				num2 = (short)1246101504;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1BD:
			return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("쇪", a_);
			IL_20B:
			return string.Empty;
			IL_2A9:
			return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("쇪", a_);
			IL_34B:
			return string.Empty;
			IL_55:
			pattern = string.Empty;
			text = global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뗪뛬\udfee\udcf0쫲듴\udaf6ꏸ髺탼藾崀瀂⼄␆☈⼊∌⸎㸐匒㨔眖㘘攚㈜㨞ภ索ਤĦبĪȬ̮Ḱᴲᨴശᘸ᰺ሼ̾湀終橄橆晈灊扌၎繐硒穔橖癘❚牜͞㵠䱢䩤䡦䙨ၪᙬ䁮౰๲婴彶典呺呼噾꺀벂ꪄꖆꚈ힊킌ꂎ춐좒몔쪖ꮚ놜꺞鞠\udea2膤", a_);
			a = parameter.ToString();
			num2 = (short)56950792;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00018B24 File Offset: 0x00016D24
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)388534219;
			short num2 = num;
			num = (short)778538955;
			switch (num2 == num)
			{
			}
			num = (short)512032769;
			if (num != 0)
			{
			}
			num = (short)43384832;
			if (num != 0)
			{
			}
			num = (short)1731788800;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
