using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000B3 RID: 179
	public static class CSVHeaderConverter
	{
		// Token: 0x06000A73 RID: 2675 RVA: 0x0007EFA4 File Offset: 0x0007D1A4
		public static global::System.Collections.Generic.IList<string> GetAllCSVHeaderList()
		{
			short num = (short)1931516913;
			short num2 = num;
			num = (short)389192689;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1688862720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)674234369;
			if (num != 0)
			{
			}
			num = (short)867172352;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVHeaderConverter.a.Keys.ToList<string>();
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0007F05C File Offset: 0x0007D25C
		public static global::System.Collections.Generic.IList<string> GetRequiredCSVHeaderList(global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier pac)
		{
			int a_ = 10;
			short num = (short)882937810;
			short num2 = num;
			num = (short)128618450;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1394868224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2017984513;
			if (num != 0)
			{
			}
			num = (short)189726720;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢힤캦좨잪\udaae\udcb0톲킴얶", a_)
			};
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0007F128 File Offset: 0x0007D328
		public static string ConvertHeaderToField(string header, global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier pac)
		{
			short num;
			if (global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVHeaderConverter.a.ContainsKey(header))
			{
				num = (short)1858594377;
				short num2 = num;
				num = (short)1558439497;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1676083200;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)135004160;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVHeaderConverter.a[header];
			}
			num = (short)1027997697;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0007F1F0 File Offset: 0x0007D3F0
		// Note: this type is marked as 'beforefieldinit'.
		static CSVHeaderConverter()
		{
			int a_ = 7;
			short num = (short)1377964380;
			short num2 = num;
			num = (short)905580892;
			switch (num2 == num)
			{
			default:
			{
				num = (short)926941184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1259536384;
			if (num != 0)
			{
			}
			num = (short)1611726849;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVHeaderConverter.a = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춝얟킡춣장쒧\ud9ab쎭튯ힱ욳", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춝얟킡춣장쒧\ud9ab쎭튯ힱ욳", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첝솟욡춣즥용얫쾭쎯", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첝솟욡춣즥용얫쾭쎯", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud99d튟춡톣횥쮩솫쮭", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud99d튟춡톣횥쮩솫쮭", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udd9d쾟쾡즣쎥욧\udea9\udfab", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udd9d쾟쾡즣쎥욧\udea9\udfab", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud89d쾟킡솣쾥쾧쒩ﺭ", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud89d쾟킡솣쾥쾧쒩ﺭ", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc9d첟힡솣튥잧얩\ud8ab욭荒춷\ud8b9쾻\uddbd늿ꯁꛃꏅ뫇菉鳋", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc9d첟힡솣튥잧얩\ud8ab욭荒춷\ud8b9쾻\uddbd늿ꯁꛃꏅ뫇菉鳋", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc9d첟힡솣튥잧얩\ud8ab욭荒\uddb7\udfb9캻邿", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc9d첟힡솣튥잧얩\ud8ab욭荒\uddb7\udfb9캻邿", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc9d첟힡솣튥잧얩\ud8ab욭삱\uddb3펵횷\udeb9킻잽躿ꏁ꧃ꏅ", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc9d첟힡솣튥잧얩\ud8ab욭삱\uddb3펵횷\udeb9킻잽躿ꏁ꧃ꏅ", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톝풟쎡횣", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톝풟쎡횣", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캝얟잡횣", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캝얟잡횣", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춝햟삡힣얥\udaa7쎩캫쮭슯ﮱ", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춝햟삡힣얥\udaa7쎩캫쮭슯ﮱ", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쮝펟잡횣즧잩즫", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쮝펟잡횣즧잩즫", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쮝펟잡횣잧충얫삭\udcb1\uddb3습ﺹ", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쮝펟잡횣잧충얫삭\udcb1\uddb3습ﺹ", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캝솟톡힣톥잧\ud8a9좫", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첝얟쎡삣즧\ud9a9\udfab\ud9ad\udfaf삱킳", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킝얟햡즥첧쾩\udcab슭얯햱ힵ쮷즹쮻톽늿ꛁ", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udd9d쾟욡솣횥쒧\udfa9쮫ﺭ톯솱잳솵ힷ좹\ud8bb", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캝솟톡힣톥잧\ud8a9좫ﺭ햯삱펵캷펹\udfbb\udbbd", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캝솟톡힣톥잧\ud8a9좫ﺭ햯삱펵캷펹\udfbb\udbbd", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캝솟톡힣톥잧\ud8a9좫ﺭ\udfaf\udeb1\uddb3햵솷", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캝솟톡힣톥잧\ud8a9좫ﺭ\udfaf\udeb1\uddb3햵솷", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("좝", a_),
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("좝", a_)
				}
			};
		}

		// Token: 0x04000182 RID: 386
		private static global::System.Collections.Generic.Dictionary<string, string> a;
	}
}
