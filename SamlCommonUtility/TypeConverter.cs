using System;
using Motorola.Security.SamlCommonUtility.DMHttpClients;

namespace Motorola.Security.SamlCommonUtility
{
	// Token: 0x02000010 RID: 16
	public static class TypeConverter
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00003FE0 File Offset: 0x000021E0
		public static string GetServerScopeFromServiceTypeName(string name)
		{
			int a_ = 2;
			short num = (short)35192833;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)702770229;
					short num3 = num;
					num = (short)2037410869;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_236;
					default:
						goto IL_E6;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 2:
					goto IL_236;
				case 3:
					goto IL_20B;
				case 4:
					if (name.Contains(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("슬춮횲잴솶\udcb8즺", a_)))
					{
						num = (short)470614019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2095120392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1B2;
				case 6:
					if (name.Contains(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("寧ﲮ풰솲쎴튶쮸", a_)))
					{
						num = (short)927465481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1483735042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_268;
				case 8:
					if (name.Contains(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("寧ﮮ풰삲솴\udcb8즺쮼횾ꋀꛂ", a_)))
					{
						num = (short)1875902469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A5;
				case 9:
					goto IL_166;
				}
				IL_55:
				if (name.Contains(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("寧\ud8b0삲횴\ud8b6쾸\udeba쾼욾鋀ꛂ럄뇆곈맊", a_)))
				{
					num = (short)479723520;
					short num4 = num;
					num = (short)952238080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1055260678;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_236:
				if (name.Contains(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첬\udbae킰킴얶쾸\udeba쾼", a_)))
				{
					num = (short)247988231;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)576126980;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_E6:
			num = (short)588775424;
			if (num != 0)
			{
			}
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\ud9aa사閮麰鲲톴\udeb6쪸\ud8ba튼즾꓀뇂별뷈닊뷌꫎ﻐ臒飔鏖냘꣚뻜냞韠蛢韤黦뫨軪鿬駮铰臲", a_);
			IL_166:
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\ud9aa사閮麰鲲톴\udeb6쪸\ud8ba튼즾꓀뇂별뷈닊뷌꫎ﻐ臒飔蓖볘꧚ꯜ뫞鏠", a_);
			IL_1B2:
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\ud9aa사閮麰鲲톴\udeb6쪸\ud8ba튼즾꓀뇂별뷈닊뷌꫎ﻐ臒飔菖볘꣚꧜賞蓠釢鏤軦諨軪", a_);
			IL_20B:
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\ud9aa사閮麰鲲톴\udeb6쪸\ud8ba튼즾꓀뇂별뷈닊뷌꫎ﻐ臒飔鷖뛘맚軜뫞鏠闢胤闦", a_);
			IL_268:
			num = (short)1533739009;
			if (num != 0)
			{
			}
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\ud9aa사閮麰鲲톴\udeb6쪸\ud8ba튼즾꓀뇂별뷈닊뷌꫎ﻐ臒飔鏖룘꿚볜賞蓠釢鏤苦鯨", a_);
			IL_2A5:
			return null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004294 File Offset: 0x00002494
		public static string GetServiceTypeFromServerScope(string scope)
		{
			int a_ = 9;
			short num = (short)683737089;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)936359163;
					short num3 = num;
					num = (short)343192827;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_261;
					default:
						goto IL_E4;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 2:
					goto IL_261;
				case 3:
					goto IL_235;
				case 4:
					if (scope == global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("삱\ud9b3貵鞷閹\ud8bbힽ뎿ꇁꯃ냅귇룉뗋꓏ꯑꓓ돕裙釛髝臟雡藣뗥跧飩髫语苯", a_))
					{
						num = (short)2004221955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)764542984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1DC;
				case 6:
					if (scope == global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("삱\ud9b3貵鞷閹\ud8bbힽ뎿ꇁꯃ냅귇룉뗋꓏ꯑꓓ돕裙釛距藟郡鋣菥髧", a_))
					{
						num = (short)1079967753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1591148546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_292;
				case 8:
					if (scope == global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("삱\ud9b3貵鞷閹\ud8bbힽ뎿ꇁꯃ냅귇룉뗋꓏ꯑꓓ돕裙釛諝藟釡郣뗥跧飩髫蟭鏯韱", a_))
					{
						num = (short)380108805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A6;
				case 9:
					goto IL_18D;
				}
				IL_55:
				if (scope == global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("삱\ud9b3貵鞷閹\ud8bbힽ뎿ꇁꯃ냅귇룉뗋꓏ꯑꓓ돕裙釛髝觟釡蟣觥黧迩黫韭ꏯ韱蛳胵鷷裹", a_))
				{
					num = (short)840499200;
					short num4 = num;
					num = (short)92536832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1615069185;
				if (num != 0)
				{
				}
				num = (short)1973944326;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_261:
				if (scope == global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("삱\ud9b3貵鞷閹\ud8bbힽ뎿ꇁꯃ냅귇룉뗋꓏ꯑꓓ돕裙釛铝迟胡럣菥髧鳩觫鳭", a_))
				{
					num = (short)131923975;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)199163908;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_E4:
			num = (short)282525696;
			if (num != 0)
			{
			}
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("靈톷즹\udfbb톽뚿ꟁ뛃뿅鯇꿉뻋룍뗏ꃑ", a_);
			IL_18D:
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("靈\uddb7좹쪻\udbbd늿", a_);
			IL_1DC:
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("靈\uddb7즹좻ꖿ냁닃꿅ꯇ꿉", a_);
			IL_235:
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("햳습\ud9b7\ud9bb첽뚿ꟁ뛃", a_);
			IL_292:
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\udbb3풵\udfb9캻좽ꖿ냁", a_);
			IL_2A6:
			return null;
		}
	}
}
