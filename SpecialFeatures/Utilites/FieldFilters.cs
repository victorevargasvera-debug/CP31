using System;
using System.Linq;
using AcpCommonLib;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Utilites
{
	// Token: 0x02000044 RID: 68
	public class FieldFilters
	{
		// Token: 0x06000777 RID: 1911 RVA: 0x0006E130 File Offset: 0x0006C330
		public static bool FilterSpecialFieldInReport(global::AcpCommonLib.IAcpField fld)
		{
			short num = (short)2005598215;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2115174401;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_11A;
				case 1:
					num = (short)1117716482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppView != global::AcpCommonLib.DifferentiatedUserViewType.Labtool)
					{
						num = (short)972488708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					if (fld.Name != null)
					{
						num = (short)27197441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					num = (short)948240384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return true;
				case 6:
					num = (short)1071185923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				}
				IL_6C:
				if (fld == null)
				{
					return false;
				}
				num = (short)1335820288;
				short num3 = num;
				num = (short)1112549804;
				short num4 = num;
				num = (short)1975658924;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1316028416;
					if (num != 0)
					{
					}
					num = (short)717291526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_11A:
				if (!global::SpecialFeatures.Utilites.FieldFilters.a.Contains(fld.Name))
				{
					return false;
				}
				num = (short)276496389;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0006E300 File Offset: 0x0006C500
		// Note: this type is marked as 'beforefieldinit'.
		static FieldFilters()
		{
			int a_ = 17;
			short num = (short)1676481158;
			short num2 = num;
			num = (short)1929712262;
			switch (num2 == num)
			{
			}
			num = (short)613023745;
			if (num != 0)
			{
			}
			num = (short)211943424;
			short num3 = num;
			num = (short)2018115584;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Utilites.FieldFilters.a = new string[]
			{
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓ﲗ쪙욟좣쎥\udaa7\udea9솭\udeafힱ잳\uddb7춹쮽뒿ꟁ郃꧅ꛇ꿉뿋臍ꃏ럑ꛓ럕곗동돛냝뿟ꏡ탣퓥\ud9e7\udee9헫", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓ﲗ쪙욟좣쎥\udaa7\udea9솭\udeafힱ잳﮵춷캹\ud9bb꾿곁ꇃ뗅蟇뫉꧋볍뇏ꛑ뷓맕뛗藙鷛헟퓡훣", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킓ﮙ쮛쒟잡\udab1톳햵펷\ud8b9\uddbb\uddbdꮿ雁귃ꯅ귇闉跋鬒", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킓ﮙ첛쾟쒡슫쾭튯\udeb1톳튵﮹袻貽", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힓쪙鍊춡쪣킥춧쒩\ud8ab잭\udfaf\udcb1햳\udab5﮷특\uddbb킽꺿ꟁꣃ觅룇뻉ꗋꇍ뻏ꇑ臓ꗕ뷗꣙进믝賟蟡蟣鋥觧裩胫语ꃯ뻱맳꛵듷ꗹ뷻쟽㛿㈁㈃", a_)
			};
		}

		// Token: 0x040002ED RID: 749
		private static string[] a;
	}
}
