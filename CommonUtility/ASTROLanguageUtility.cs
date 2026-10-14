using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.Server.EntityModel;
using RFResourceRepository;

namespace CommonUtility
{
	// Token: 0x02000024 RID: 36
	public class ASTROLanguageUtility
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00014A5C File Offset: 0x00012C5C
		public static global::CommonUtility.ASTROLanguageUtility Instance
		{
			get
			{
				short num = (short)1054381613;
				short num2 = num;
				num = (short)1856673325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)368836608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1989804033;
				if (num != 0)
				{
				}
				num = (short)781451264;
				if (num != 0)
				{
				}
				return new global::CommonUtility.ASTROLanguageUtility();
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00014B0C File Offset: 0x00012D0C
		public static void FilterFakeLPForTemplateMode(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary> availableLpSummaryList)
		{
			short num = (short)2011168770;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary, bool> predicate;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					if ((predicate = global::CommonUtility.ASTROLanguageUtility.<>c.<>9__4_0) == null)
					{
						goto IL_168;
					}
					goto IL_1E7;
				case 1:
					IL_7B:
					num = (short)1885863941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
					goto IL_1E2;
				case 4:
					try
					{
						num = (short)117571585;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								switch (0)
								{
								case 0:
									goto IL_DF;
								}
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2047475716;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary item = enumerator.Current;
								availableLpSummaryList.Remove(item);
								num = (short)97255424;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_155;
							case 4:
								num = (short)1560674307;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_108:
							num = (short)1846607874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_DF:
							goto IL_108;
						}
						IL_155:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_168;
				case 5:
					if (availableLpSummaryList.Count == 0)
					{
						num = (short)1510473729;
						if (num != 0)
						{
						}
						num = (short)2129395715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1309343744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				if (availableLpSummaryList != null)
				{
					num = (short)1373306880;
					short num3 = num;
					num = (short)672333825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1E7:
				enumerator = availableLpSummaryList.Where(predicate).ToList<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary>().GetEnumerator();
				num = (short)659399877;
				short num4 = num;
				num = (short)1241818309;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_7B;
				default:
					num = (short)2032271360;
					if (num != 0)
					{
					}
					num = (short)1875640324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_168:
				predicate = (global::CommonUtility.ASTROLanguageUtility.<>c.<>9__4_0 = new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary, bool>(global::CommonUtility.ASTROLanguageUtility.<>c.<>9.a));
				goto IL_1E7;
			}
			return;
			IL_1E2:;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00014D88 File Offset: 0x00012F88
		public bool IsSupportedLanguagePack(string currentRadioFWVersion, string languagePackID)
		{
			int a_ = 19;
			short num = (short)714080268;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				short num3;
				switch (num2)
				{
				case 0:
					if (num3 < 7)
					{
						num = (short)794034189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					num = (short)1591869457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (currentRadioFWVersion.StartsWith(global::CommonUtility.VersionUtility.b("ك", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)13107211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					if (num3 < 8)
					{
						num = (short)1617756176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					return false;
				case 5:
					if (currentRadioFWVersion.StartsWith(global::CommonUtility.VersionUtility.b("ك", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)70385689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					if (num3 < 9)
					{
						num = (short)1985413139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 7:
					num = (short)110493701;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (currentRadioFWVersion.StartsWith(global::CommonUtility.VersionUtility.b("ᙃ", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)1446838292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_363;
				case 9:
					return false;
				case 10:
					if (num3 < 10)
					{
						num = (short)234422295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 11:
					goto IL_28E;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					continue;
				case 13:
					return false;
				case 14:
					IL_361:
					num = (short)1726808074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (!currentRadioFWVersion.StartsWith(global::CommonUtility.VersionUtility.b("C", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)964820999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43C;
				case 16:
					goto IL_363;
				case 17:
					if (currentRadioFWVersion.StartsWith(global::CommonUtility.VersionUtility.b("ᙃ", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)1218445326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3EF;
				case 18:
				{
					num = (short)2001600513;
					if (num != 0)
					{
					}
					num = (short)509411328;
					short num4 = num;
					if (!short.TryParse(currentRadioFWVersion.Substring(1, 2), out num3))
					{
						num = (short)2058420228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1567358998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					goto IL_4BC;
				case 20:
					num = (short)1553727491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (!currentRadioFWVersion.StartsWith(global::CommonUtility.VersionUtility.b("C", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)586416152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28E;
				case 22:
					if (languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_ARABIC.ToString())
					{
						num = (short)1953890305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1233059848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_3EF;
				case 24:
					num = (short)1133445122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_43C;
				}
				IL_95:
				if (languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_ENGLISH.ToString())
				{
					num = (short)601489417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num3 = 0;
				num = (short)1422524434;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_28E:
				num = (short)327876608;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_43C:
				num = (short)57043391;
				short num5 = num;
				num = (short)1232955839;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_361;
				default:
					num = (short)1516765184;
					if (num != 0)
					{
					}
					num = (short)131137542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_363:
				num = (short)1468465173;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3EF:
				num = (short)378994703;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_4BC:
			return false;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0001525C File Offset: 0x0001345C
		public string ConvertLPID2LanguageID(string lpID)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_E1;
			}
			int num;
			short num2;
			uint num3;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)2093350939;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (num3 != 1029486648U)
					{
						num2 = (short)574488611;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1672282155;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!(text == global::CommonUtility.VersionUtility.b("猱昳ᬵ礷根", a_)))
					{
						num2 = (short)1900347440;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_334;
				case 3:
					goto IL_67C;
				case 4:
					num2 = (short)947650607;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_3B7;
				case 6:
					if (num3 <= 2249852547U)
					{
						num2 = (short)1587740698;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1289879596;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1202126876;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)239468545;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_35C;
				case 10:
					num2 = (short)2131034134;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_643;
				case 12:
					num2 = (short)1932918830;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					num2 = (short)1311899653;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (num3 != 2333156380U)
					{
						num2 = (short)1724645376;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)461373471;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (!(text == global::CommonUtility.VersionUtility.b("眱朳ᬵ紷椹", a_)))
					{
						num2 = (short)921567262;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_220;
				case 16:
					num2 = (short)268763145;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (!(text == global::CommonUtility.VersionUtility.b("怱愳ᬵ樷漹", a_)))
					{
						num2 = (short)1996619813;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7A3;
				case 18:
					num2 = (short)829489175;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (num3 != 2249852547U)
					{
						num2 = (short)89784333;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1258029095;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (!(text == global::CommonUtility.VersionUtility.b("稱焳ᬵ焷瘹", a_)))
					{
						num2 = (short)1699348521;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28B;
				case 21:
				{
					num2 = (short)273612800;
					short num4 = num2;
					num2 = (short)752222227;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 22:
					if (num3 != 713441886U)
					{
						num2 = (short)1641545736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_70F;
				case 23:
					goto IL_65F;
				case 24:
					goto IL_837;
				case 25:
					if (num3 != 1213559016U)
					{
						num2 = (short)1082785813;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1808007183;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					num2 = (short)1994588189;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					if (num3 != 2783362300U)
					{
						num2 = (short)1162149924;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1161429012;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					goto IL_7CA;
				case 29:
					if (num3 <= 1029486648U)
					{
						num2 = (short)45350922;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)128188441;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					num2 = (short)671219736;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (!(text == global::CommonUtility.VersionUtility.b("琱昳ᬵ笷笹", a_)))
					{
						num2 = (short)1781661697;
						if (num2 != 0)
						{
						}
						num2 = (short)852885520;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_61A;
				case 32:
					num2 = (short)2119434254;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					goto IL_598;
				case 34:
					if (!(text == global::CommonUtility.VersionUtility.b("笱瀳ᬵ焷縹", a_)))
					{
						num2 = (short)1275854852;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_324;
				case 35:
					num2 = (short)1894711299;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					num2 = (short)219021323;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					num2 = (short)237764646;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 38:
					goto IL_286;
				case 39:
					if (!(text == global::CommonUtility.VersionUtility.b("栱簳ᬵ氷洹", a_)))
					{
						num2 = (short)1344536621;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7CF;
				case 40:
					goto IL_86F;
				case 41:
					num2 = (short)1519779873;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 42:
					if (num3 != 2897620426U)
					{
						num2 = (short)313720844;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1104281602;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					if (!(text == global::CommonUtility.VersionUtility.b("戱怳ᬵ样渹", a_)))
					{
						num2 = (short)675741703;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_462;
				case 44:
				{
					if (num3 > 2783362300U)
					{
						num2 = (short)485359658;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1667667560;
					short num5 = num2;
					num2 = (short)1035834984;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_70F;
					default:
						num2 = (short)1462566912;
						if (num2 != 0)
						{
						}
						num2 = (short)1166999584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 45:
					num2 = (short)1305149480;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
					if (num3 != 2929810234U)
					{
						num2 = (short)1028784146;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1554448418;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 47:
					goto IL_193;
				case 48:
					num2 = (short)1399783473;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 49:
					goto IL_853;
				}
				goto IL_E1;
				IL_70F:
				num2 = (short)1137377297;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_193:
			goto IL_874;
			IL_220:
			return global::CommonUtility.ASTROLanguageSelection.ID_SPANISH.ToString();
			IL_286:
			goto IL_874;
			IL_28B:
			return global::CommonUtility.ASTROLanguageSelection.ID_HEBREW.ToString();
			IL_324:
			return global::CommonUtility.ASTROLanguageSelection.ID_BAHASA.ToString();
			IL_334:
			return global::CommonUtility.ASTROLanguageSelection.ID_ARABIC.ToString();
			IL_35C:
			IL_3B7:
			goto IL_874;
			IL_462:
			return global::CommonUtility.ASTROLanguageSelection.ID_PORTUGUESE.ToString();
			IL_598:
			goto IL_874;
			IL_61A:
			return global::CommonUtility.ASTROLanguageSelection.ID_FRENCH.ToString();
			IL_643:
			IL_65F:
			IL_67C:
			goto IL_874;
			IL_7A3:
			return global::CommonUtility.ASTROLanguageSelection.ID_RUSSIAN.ToString();
			IL_7CA:
			goto IL_874;
			IL_7CF:
			return global::CommonUtility.ASTROLanguageSelection.ID_CHINESETRADITIONAL.ToString();
			IL_837:
			IL_853:
			IL_86F:
			IL_874:
			return global::CommonUtility.ASTROLanguageSelection.ID_ENGLISH.ToString();
			IL_E1:
			text = lpID.ToUpperInvariant();
			num3 = global::f.a(text);
			num2 = (short)967770118;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00015AEC File Offset: 0x00013CEC
		public string ConvertLanguageID2LPID(string languageID)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::CommonUtility.ASTROLanguageSelection astrolanguageSelection;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)392691713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_1FC;
				case 2:
					switch (astrolanguageSelection)
					{
					case global::CommonUtility.ASTROLanguageSelection.ID_FRENCH:
						goto IL_E0;
					case global::CommonUtility.ASTROLanguageSelection.ID_SPANISH:
						goto IL_C2;
					case global::CommonUtility.ASTROLanguageSelection.ID_PORTUGUESE:
						goto IL_167;
					case global::CommonUtility.ASTROLanguageSelection.ID_BAHASA:
						goto IL_1FE;
					case global::CommonUtility.ASTROLanguageSelection.ID_HEBREW:
						goto IL_158;
					case global::CommonUtility.ASTROLanguageSelection.ID_RUSSIAN:
						goto IL_B3;
					case global::CommonUtility.ASTROLanguageSelection.ID_CHINESETRADITIONAL:
						goto IL_1D5;
					case global::CommonUtility.ASTROLanguageSelection.ID_ARABIC:
						goto IL_13A;
					case global::CommonUtility.ASTROLanguageSelection.ID_ENGLISH_AU:
						goto IL_A4;
					case global::CommonUtility.ASTROLanguageSelection.ID_SPANISH_AR:
						goto IL_1C6;
					case global::CommonUtility.ASTROLanguageSelection.ID_SPANISH_CL:
						goto IL_D1;
					case global::CommonUtility.ASTROLanguageSelection.ID_SPANISH_CO:
						goto IL_149;
					default:
						num2 = (short)701169664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				goto IL_25;
			}
			IL_A4:
			return global::CommonUtility.VersionUtility.b("♂⭄橆⡈㹊", a_);
			IL_B3:
			return global::CommonUtility.VersionUtility.b("ㅂい橆㭈㹊", a_);
			IL_C2:
			return global::CommonUtility.VersionUtility.b("♂㙄橆ⱈ㡊", a_);
			IL_D1:
			return global::CommonUtility.VersionUtility.b("♂㙄橆⩈❊", a_);
			IL_E0:
			num2 = (short)383590857;
			short num3 = num2;
			num2 = (short)941236681;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1C6:
				return global::CommonUtility.VersionUtility.b("♂㙄橆⡈㥊", a_);
			default:
				num2 = (short)106299392;
				if (num2 != 0)
				{
				}
				return global::CommonUtility.VersionUtility.b("╂㝄橆⩈⩊", a_);
			}
			IL_13A:
			return global::CommonUtility.VersionUtility.b("≂㝄橆⡈㥊", a_);
			IL_149:
			return global::CommonUtility.VersionUtility.b("♂㙄橆⩈⑊", a_);
			IL_158:
			return global::CommonUtility.VersionUtility.b("⭂⁄橆⁈❊", a_);
			IL_167:
			num2 = (short)312541184;
			short num4 = num2;
			num2 = (short)1581449217;
			if (num2 != 0)
			{
			}
			return global::CommonUtility.VersionUtility.b("㍂ㅄ橆㥈㽊", a_);
			IL_1D5:
			return global::CommonUtility.VersionUtility.b("㥂ⵄ橆㵈㱊", a_);
			IL_1FC:
			return string.Empty;
			IL_1FE:
			return global::CommonUtility.VersionUtility.b("⩂⅄橆⁈⽊", a_);
			IL_25:
			astrolanguageSelection = (global::CommonUtility.ASTROLanguageSelection)global::System.Enum.Parse(typeof(global::CommonUtility.ASTROLanguageSelection), languageID);
			num2 = (short)947781634;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00015D0C File Offset: 0x00013F0C
		public bool IsFirmwareLPCompatible(string languagePackID, string firmwareVersion, bool isPortable)
		{
			short num = (short)283654949;
			short num2 = num;
			num = (short)233782053;
			switch (num2 == num)
			{
			}
			num = (short)138739713;
			if (num != 0)
			{
			}
			num = (short)538247168;
			if (num != 0)
			{
			}
			num = (short)921174016;
			short num3 = num;
			string empty = string.Empty;
			return this.IsFirmwareLPCompatible(languagePackID, firmwareVersion, isPortable, out empty);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00015DC4 File Offset: 0x00013FC4
		public bool IsFirmwareLPCompatible(string languagePackID, string firmwareVersion, bool isPortable, out string warningCode)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_21D;
			}
			int num;
			short num2;
			short num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (num2 < 4)
					{
						num3 = (short)104923207;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_A28;
				case 1:
					num3 = (short)794492998;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					num3 = (short)1014038535;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					if (firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("甶", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1521549355;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_A28;
				case 4:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_FRENCH.ToString()))
					{
						num3 = (short)1975713813;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_26B;
				case 5:
					if (!firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("猶", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1974403136;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_330;
				case 6:
					if (num2 == 6)
					{
						num3 = (short)1922302061;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 7:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_SPANISH.ToString()))
					{
						num3 = (short)696385660;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 8:
					if (firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("甶", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1901854843;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_C52;
				case 9:
					num3 = (short)443416662;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 10:
					num3 = (short)369492068;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 11:
					if (!firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("猶", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1053163551;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_110C;
				case 12:
					if (languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_HEBREW.ToString())
					{
						num3 = (short)615055480;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 13:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_HEBREW.ToString()))
					{
						num3 = (short)917307425;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_C03;
				case 14:
					num3 = (short)1627783172;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 15:
				{
					num3 = (short)1077140949;
					short num4 = num3;
					num3 = (short)2125127125;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1280;
					default:
						num3 = (short)302907392;
						if (num3 != 0)
						{
						}
						num3 = (short)399114264;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 16:
					num3 = (short)1005715553;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 17:
					if (num2 != 5)
					{
						num3 = (short)1545863223;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_4F8;
				case 18:
					goto IL_12A8;
				case 19:
					num3 = (short)99811429;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 20:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_FRENCH.ToString()))
					{
						num3 = (short)75104310;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_9EE;
				case 21:
					num3 = (short)1488322686;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 22:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_HEBREW.ToString()))
					{
						num3 = (short)1551958112;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_A79;
				case 23:
					goto IL_CED;
				case 24:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_HEBREW.ToString()))
					{
						num3 = (short)1507852336;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_26B;
				case 25:
					if (!isPortable)
					{
						num3 = (short)1526136888;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 26:
					if (firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("收", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)699465836;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1556;
				case 27:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_ENGLISH.ToString()))
					{
						num3 = (short)783220835;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_C03;
				case 28:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_HEBREW.ToString()))
					{
						num3 = (short)2068250653;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B7B;
				case 29:
					num3 = (short)1396572271;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 30:
					goto IL_801;
				case 31:
					num3 = (short)452788232;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 32:
					num3 = (short)790822934;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 33:
					num3 = (short)321388634;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 34:
					goto IL_9EE;
				case 35:
					if (firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("甶", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1230045312;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 36:
					goto IL_FA4;
				case 37:
					num3 = (short)1873150036;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 38:
					num3 = (short)1157038138;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 39:
					num3 = (short)1856241692;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 40:
					if (num2 != 7)
					{
						num3 = (short)2078539855;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_EA3;
				case 41:
					goto IL_999;
				case 42:
					if (firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("收", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)944898064;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_459;
				case 43:
					goto IL_8EA;
				case 44:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_SPANISH.ToString()))
					{
						num3 = (short)483459176;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_9EE;
				case 45:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_ENGLISH.ToString()))
					{
						num3 = (short)489226350;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_9EE;
				case 46:
					num3 = (short)1688600691;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 47:
					goto IL_B7B;
				case 48:
					num3 = (short)968949840;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 49:
					goto IL_4F8;
				case 50:
					num3 = (short)2138832953;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 51:
					if (languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_CHINESETRADITIONAL.ToString())
					{
						num3 = (short)2063532079;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1280;
				case 52:
					goto IL_AA6;
				case 53:
					num3 = (short)1148911714;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 54:
					num3 = (short)370868268;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 55:
					goto IL_714;
				case 56:
					num3 = (short)1994063884;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 57:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_PORTUGUESE.ToString()))
					{
						num3 = (short)582090767;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_26B;
				case 58:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_CHINESETRADITIONAL.ToString()))
					{
						num3 = (short)520028248;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_C03;
				case 59:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_ENGLISH.ToString()))
					{
						num3 = (short)756088878;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B7B;
				case 60:
					if (!isPortable)
					{
						num3 = (short)1882390538;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 61:
					goto IL_26B;
				case 62:
					warningCode = global::CommonUtility.VersionUtility.b("笶椸携漼帾╀⩂⩄ᡆⵈ≊㹌㽎㵐㉒ⱔࡖᕘ㩚㍜㡞ᑠɢɤɦ㙨╪ɬ᭮⹰⁲tݶॸᑺོ୾\uda84얆풊歷쪔ﾚ", a_);
					num3 = (short)308215881;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 63:
					num3 = (short)2013986881;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 64:
					num3 = (short)1531707427;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 65:
					if (num2 < 8)
					{
						num3 = (short)420478999;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return true;
				case 66:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_PORTUGUESE.ToString()))
					{
						num3 = (short)1445986393;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_C03;
				case 67:
					num3 = (short)1380712465;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 68:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_ENGLISH.ToString()))
					{
						num3 = (short)1495334926;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_26B;
				case 69:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_SPANISH.ToString()))
					{
						num3 = (short)1735590009;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B7B;
				case 70:
					if (num2 != 6)
					{
						num3 = (short)29032541;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_FA4;
				case 71:
					goto IL_923;
				case 72:
					goto IL_A79;
				case 73:
					goto IL_E01;
				case 74:
					if (num2 == 5)
					{
						num3 = (short)482476068;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_C52;
				case 75:
					if (num2 == 4)
					{
						num3 = (short)1570242609;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_12FB;
				case 76:
					if (!firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("猶", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1019019349;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_2F4;
				case 77:
					num3 = (short)870776835;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 78:
					num3 = (short)2046165075;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 79:
					goto IL_1556;
				case 80:
					if (languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_RUSSIAN.ToString())
					{
						num3 = (short)1360855101;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_A79;
				case 81:
					if (!isPortable)
					{
						num3 = (short)587399200;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_10D0;
				case 82:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_FRENCH.ToString()))
					{
						num3 = (short)709623886;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_C03;
				case 83:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_SPANISH.ToString()))
					{
						num3 = (short)1236009047;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_C03;
				case 84:
					if (languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_CHINESETRADITIONAL.ToString())
					{
						num3 = (short)1535377524;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 85:
					goto IL_564;
				case 86:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_FRENCH.ToString()))
					{
						num3 = (short)1567162370;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 87:
					num3 = (short)1786052674;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 88:
					return true;
				case 89:
					num3 = (short)1961426957;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 90:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_RUSSIAN.ToString()))
					{
						num3 = (short)1050804262;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_C03;
				case 91:
					if (firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("收", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)641466435;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_714;
				case 92:
					if (firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("收", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1657405441;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_2A4;
				case 93:
					goto IL_2A4;
				case 94:
					if (!isPortable)
					{
						num3 = (short)1305477157;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 95:
					num3 = (short)854982725;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 96:
					goto IL_10D0;
				case 97:
					if (num2 >= 5)
					{
						num3 = (short)1130758261;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_923;
				case 98:
					if (languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_HEBREW.ToString())
					{
						num3 = (short)413794338;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_970;
				case 99:
					num3 = (short)1810956370;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 100:
					if (languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_RUSSIAN.ToString())
					{
						num3 = (short)1491796040;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 101:
					if (firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("甶", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1206648884;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_12FB;
				case 102:
					if (firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("甶", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)965148799;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_801;
				case 103:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_ENGLISH.ToString()))
					{
						num3 = (short)931463177;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 104:
					num3 = (short)1044840566;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 105:
					if (firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("收", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1372586047;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_CED;
				case 106:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_PORTUGUESE.ToString()))
					{
						num3 = (short)1346175015;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B7B;
				case 107:
					num3 = (short)1551826995;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 108:
					num3 = (short)1226375208;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 109:
					goto IL_EA3;
				case 110:
					num3 = (short)1045037076;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 111:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_RUSSIAN.ToString()))
					{
						num3 = (short)1121517675;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B7B;
				case 112:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_PORTUGUESE.ToString()))
					{
						num3 = (short)421134398;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 113:
					if (!firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("猶", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1766916115;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_AA6;
				case 114:
					try
					{
						num2 = global::System.Convert.ToInt16(firmwareVersion.Substring(1, 2), 10);
						goto IL_99E;
					}
					catch
					{
						return false;
					}
					goto IL_564;
					IL_99E:
					num3 = (short)167837723;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 115:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_FRENCH.ToString()))
					{
						num3 = (short)1379336287;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B7B;
				case 116:
					goto IL_1280;
				case 117:
					goto IL_459;
				case 118:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_PORTUGUESE.ToString()))
					{
						num3 = (short)1175060533;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_9EE;
				case 119:
					goto IL_AA1;
				case 120:
					goto IL_970;
				case 121:
					num3 = (short)1921515626;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 122:
					if (!firmwareVersion.StartsWith(global::CommonUtility.VersionUtility.b("猶", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1678639181;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_8EA;
				case 123:
					goto IL_110C;
				case 124:
					num3 = (short)978911344;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 125:
					if (num2 < 7)
					{
						num3 = (short)2101346334;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return true;
				case 126:
					if (!(languagePackID == global::CommonUtility.ASTROLanguageSelection.ID_SPANISH.ToString()))
					{
						num3 = (short)1888813106;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_26B;
				case 127:
					goto IL_2F4;
				case 128:
					goto IL_330;
				}
				goto IL_21D;
				IL_26B:
				num3 = (short)1643184209;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_2A4:
				num3 = (short)1196228619;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_2F4:
				num3 = (short)871956605;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_330:
				num3 = (short)493355014;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_459:
				num3 = (short)1450508410;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_4F8:
				num3 = (short)1666187309;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_564:
				num3 = (short)1097793638;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_714:
				num3 = (short)1909981297;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_801:
				num3 = (short)1589116970;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_8EA:
				num3 = (short)2045575168;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_923:
				num3 = (short)1121189991;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_970:
				warningCode = global::CommonUtility.VersionUtility.b("笶椸携漼帾╀⩂⩄ᡆⵈ≊㹌㽎㵐㉒ⱔࡖᕘ㩚㍜㡞ᑠɢɤɦ㙨╪ɬ᭮⹰⁲tݶॸᑺོ୾\uda84얆풊歷쪔ﾚ", a_);
				num3 = (short)850657321;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_9EE:
				num3 = (short)463405081;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_A28:
				num3 = (short)1979580507;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_A79:
				warningCode = global::CommonUtility.VersionUtility.b("笶椸携漼帾╀⩂⩄ᡆⵈ≊㹌㽎㵐㉒ⱔࡖᕘ㩚㍜㡞ᑠɢɤɦ㙨╪ɬ᭮⹰⁲tݶॸᑺོ୾\uda84얆풊歷쪔ﾚ", a_);
				num3 = (short)1408434295;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_AA6:
				num3 = (short)1418395723;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_B7B:
				num3 = (short)1464008798;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_C03:
				num3 = (short)1551433833;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_C52:
				num3 = (short)2127822874;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_CED:
				num3 = (short)802226252;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_EA3:
				num3 = (short)1973157888;
				short num5 = num3;
				num3 = (short)513146939;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_FA4:
				num3 = (short)154206276;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_10D0:
				num3 = (short)758644796;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_110C:
				num3 = (short)614924362;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1280:
				warningCode = global::CommonUtility.VersionUtility.b("笶椸携漼帾╀⩂⩄ᡆⵈ≊㹌㽎㵐㉒ⱔࡖᕘ㩚㍜㡞ᑠɢɤɦ㙨╪ɬ᭮⹰⁲tݶॸᑺོ୾\uda84얆풊歷쪔ﾚ", a_);
				num3 = (short)1676673042;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_12FB:
				num3 = (short)1175519324;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1556:
				num3 = (short)1439825925;
				num = (int)((global::System.IntPtr)num3);
			}
			return false;
			IL_999:
			IL_AA1:
			return false;
			IL_E01:
			IL_12A8:
			return false;
			IL_21D:
			num2 = 0;
			warningCode = string.Empty;
			num3 = (short)1993801729;
			if (num3 != 0)
			{
			}
			num3 = (short)864551026;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00017388 File Offset: 0x00015588
		public bool IsFirmwareSupportCurrentLanguage(string hostVersion, string languageID)
		{
			int a_ = 17;
			short num = (short)1520566273;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				short num3;
				switch (num2)
				{
				case 0:
					if (num3 < 9)
					{
						num = (short)1383006215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_6B;
					}
					continue;
				case 2:
					goto IL_263;
				case 3:
					if (hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("၁", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)1197867018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_263;
				case 4:
					if (num3 < 10)
					{
						num = (short)642580482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15C;
				case 5:
					num = (short)417923085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return true;
				case 7:
					goto IL_101;
				case 8:
					if (languageID == global::CommonUtility.ASTROLanguageSelection.ID_ARABIC.ToString())
					{
						num = (short)76873739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 9:
					goto IL_CC;
				case 10:
					num = (short)967245828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)885194755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					try
					{
						num3 = global::System.Convert.ToInt16(hostVersion.Substring(1, 2), 10);
						goto IL_2DC;
					}
					catch
					{
						return false;
					}
					goto IL_15C;
				case 13:
					if (hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("A", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)137887753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 14:
					if (!hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("ف", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)950992901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC;
				}
				IL_6B:
				if (languageID == global::CommonUtility.ASTROLanguageSelection.ID_ENGLISH.ToString())
				{
					num = (short)630063104;
					short num4 = num;
					num = (short)1036517382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num3 = 0;
				num = (short)149422092;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CC:
				num = (short)1884225536;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_263:
				num = (short)1177354241;
				if (num != 0)
				{
				}
				num = (short)776470542;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2DC:
				num = (short)89128968;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15C:
				num = (short)1006386064;
				short num5 = num;
				num = (short)2060532624;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2DC;
				default:
					goto IL_192;
				}
			}
			return true;
			IL_101:
			return false;
			IL_192:
			num = (short)1133182976;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000176D0 File Offset: 0x000158D0
		public global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack CreateFakeLanguagePackage(string lpID)
		{
			int a_ = 16;
			short num = (short)1472987136;
			short num2 = num;
			num = (short)819538174;
			short num3 = num;
			num = (short)519252222;
			switch (num3 == num)
			{
			}
			num = (short)43581440;
			if (num != 0)
			{
			}
			num = (short)1941569537;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack
			{
				LpID = this.ConvertLanguageID2LPID(lpID),
				PackageLanguage = global::RFResourceRepository.ASTROResourceHelper.Instance().GetRFResourceValueByResourceID(this.ConvertLanguageID2LPID(lpID).Replace('-', '_'), null),
				Uuid = global::System.Guid.NewGuid(),
				PackageVersion = global::CommonUtility.VersionUtility.b("煀浂畄", a_)
			};
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000177D4 File Offset: 0x000159D4
		public bool ParseLanguageIDAndVersion(string source, out string packID, out string version)
		{
			int a_ = 10;
			short num = (short)918945792;
			short num2 = num;
			num = (short)471351152;
			short num3 = num;
			num = (short)327761776;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)198508544;
				if (num != 0)
				{
				}
				num = (short)867172353;
				if (num != 0)
				{
				}
				if (global::CommonUtility.VersionUtility.b("强尼䬾Ṁ", a_) == source.Substring(0, 4))
				{
					source = source.Substring(4);
					packID = source.Substring(0, source.IndexOf('_'));
					source = source.Substring(source.IndexOf('_') + 1);
					version = source.Substring(0, source.LastIndexOf('.'));
					return true;
				}
				break;
			}
			packID = string.Empty;
			version = string.Empty;
			return false;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000178F0 File Offset: 0x00015AF0
		public bool IsRadioUpgradeHostGreaterThan_7_12(string radioHostVer, string cvnHostVer)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_B4;
			}
			short num;
			int num3;
			short num4;
			short num5;
			for (;;)
			{
				IL_13:
				num = (short)92779479;
				short num2 = num;
				num = (short)1929950167;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1002110976;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (!radioHostVer.StartsWith(global::CommonUtility.VersionUtility.b("田", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)2074607624;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_313;
					case 1:
						goto IL_393;
					case 2:
						if (cvnHostVer.StartsWith(global::CommonUtility.VersionUtility.b("猰", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)1261633546;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						if (num4 >= 7)
						{
							num = (short)106233873;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						if (cvnHostVer.StartsWith(global::CommonUtility.VersionUtility.b("挰", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)1681850383;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_297;
					case 5:
						if (radioHostVer.StartsWith(global::CommonUtility.VersionUtility.b("挰", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)1160052747;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D4;
					case 6:
						goto IL_126;
					case 7:
						if (num4 < 8)
						{
							num = (short)99876876;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						num = (short)2129592336;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_313;
					case 10:
						num = (short)47906817;
						if (num != 0)
						{
						}
						goto IL_223;
					case 11:
						num = (short)770179090;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_297;
					case 13:
						goto IL_1D4;
					case 14:
						if (!cvnHostVer.StartsWith(global::CommonUtility.VersionUtility.b("田", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)1549664262;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_223;
					case 15:
						num = (short)633536519;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (radioHostVer.StartsWith(global::CommonUtility.VersionUtility.b("猰", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)1658257417;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
						return true;
					case 18:
						if (num5 < 8)
						{
							num = (short)1181286413;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_393;
					case 19:
						if (num5 >= 7)
						{
							num = (short)733020161;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_B4;
					IL_1D4:
					num = (short)848297984;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_223:
					num = (short)2056978435;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_297:
					num = (short)601554944;
					short num6 = num;
					num = (short)777715726;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_313:
					num = (short)900792339;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_393:
					num = (short)15990788;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_126:
				num = (short)1278214146;
				num3 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_B4:
			num5 = 0;
			num4 = 0;
			short.TryParse(radioHostVer.Substring(1, 2), out num5);
			short.TryParse(cvnHostVer.Substring(1, 2), out num4);
			num = (short)645595141;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00017CE0 File Offset: 0x00015EE0
		public bool IsRadioUpgradeCross7_12(string radioHostVer, string cvnHostVer)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			int num;
			short num2;
			short num4;
			short num5;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_2CB;
				case 1:
				{
					num2 = (short)1918959616;
					short num3 = num2;
					num2 = (short)1507262479;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (radioHostVer.StartsWith(global::CommonUtility.VersionUtility.b("紾", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)921632768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_39B;
				case 3:
					if (num4 < 8)
					{
						num2 = (short)378077198;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					if (num5 >= 7)
					{
						num2 = (short)1423835142;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
				{
					num2 = (short)468387785;
					short num6 = num2;
					num2 = (short)1916536777;
					switch ((num6 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_24D;
					default:
						num2 = (short)436535296;
						if (num2 != 0)
						{
						}
						if (num4 < 7)
						{
							num2 = (short)668794890;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				case 6:
					return true;
				case 7:
					if (cvnHostVer.StartsWith(global::CommonUtility.VersionUtility.b("派", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)1605894155;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_252;
				case 8:
					goto IL_1DA;
				case 9:
					num2 = (short)1461190658;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_39B;
				case 11:
					num2 = (short)371261458;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_252;
				case 13:
					if (radioHostVer.StartsWith(global::CommonUtility.VersionUtility.b("派", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)228065299;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18B;
				case 14:
					goto IL_24D;
				case 15:
					if (cvnHostVer.StartsWith(global::CommonUtility.VersionUtility.b("紾", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)1339424776;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 16:
					if (!radioHostVer.StartsWith(global::CommonUtility.VersionUtility.b("笾", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)410648585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CB;
				case 17:
					if (!cvnHostVer.StartsWith(global::CommonUtility.VersionUtility.b("笾", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)532938753;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1DA;
				case 18:
					if (num5 < 8)
					{
						num2 = (short)1827209228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 19:
					num2 = (short)2100494337;
					if (num2 != 0)
					{
					}
					num2 = (short)261029891;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_69;
				IL_18B:
				num2 = (short)1348993040;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_24D:
				goto IL_18B;
				IL_1DA:
				num2 = (short)237568004;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_252:
				num2 = (short)666828817;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2CB:
				num2 = (short)36765701;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_39B:
				num2 = (short)1414070279;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_69:
			num4 = 0;
			num5 = 0;
			short.TryParse(radioHostVer.Substring(1, 2), out num4);
			short.TryParse(cvnHostVer.Substring(1, 2), out num5);
			num2 = (short)1259536397;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000180D8 File Offset: 0x000162D8
		public string GetLanguageSettingInfoForRadio(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			string languageID;
			global::System.Guid? languagePackUuid;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1429138132;
					short num3 = num2;
					num2 = (short)1487530708;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)618332160;
						if (num2 != 0)
						{
						}
						languageID = global::CommonUtility.ASTROLanguageUtility.Instance.ConvertLPID2LanguageID(template.ASTROLanguagePack.LpID);
						num2 = (short)674299905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_10D;
				case 2:
				{
					languageID = global::CommonUtility.ASTROLanguageUtility.Instance.ConvertLPID2LanguageID((template.LanguageIndex != null) ? this.ConvertLanguageID2LPID(template.LanguageIndex.ToString()) : "");
					num2 = (short)1159790592;
					short num4 = num2;
					num2 = (short)324141059;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_1A0;
				case 4:
					if (languagePackUuid != null)
					{
						num2 = (short)1230307328;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)866516994;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_10D:
			num2 = (short)584253441;
			if (num2 != 0)
			{
			}
			IL_1A0:
			return global::Motorola.CommonCPS.Common.CommonUtility.ObjectSeralizeUtility.ObjectToJson<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>
			{
				new global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc
				{
					LanguageID = languageID
				}
			});
			IL_24:
			languageID = "";
			languagePackUuid = template.LanguagePackUuid;
			num2 = (short)1712193540;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400004F RID: 79
		public const string CONST_FAKELPPACKAGE_VER = "0.0";

		// Token: 0x04000050 RID: 80
		public const string CONST_LANGUAGEPACKAGESUPPORTED_FWVER = "R08.00.00";
	}
}
