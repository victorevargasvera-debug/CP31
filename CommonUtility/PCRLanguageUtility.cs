using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace CommonUtility
{
	// Token: 0x02000048 RID: 72
	public class PCRLanguageUtility
	{
		// Token: 0x06000185 RID: 389 RVA: 0x0002B6C4 File Offset: 0x000298C4
		public static void FilterFakeLPForTemplateMode(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary> availableLpSummaryList)
		{
			short num = (short)89980931;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary>.Enumerator enumerator;
				global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary, bool> predicate;
				switch (num2)
				{
				case 0:
				{
					num = (short)1979138436;
					short num3 = num;
					num = (short)1120944516;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1CA;
					default:
						num = (short)93126656;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1014759426;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_154;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)659095556;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary item = enumerator.Current;
									availableLpSummaryList.Remove(item);
									num = (short)36962307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E0;
									}
									continue;
								case 4:
									num = (short)1009975296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_108:
								num = (short)1601306625;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E0:
								goto IL_108;
							}
							IL_154:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_167;
					}
					break;
				}
				case 1:
					goto IL_1E3;
				case 2:
					num = (short)1411842053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)20774912;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				}
				case 4:
					if ((predicate = global::CommonUtility.PCRLanguageUtility.<>c.<>9__2_0) == null)
					{
						goto IL_167;
					}
					goto IL_1E8;
				case 5:
					num = (short)290848769;
					if (num != 0)
					{
					}
					if (availableLpSummaryList.Count == 0)
					{
						goto IL_1CA;
					}
					num = (short)2143879172;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_65:
				if (availableLpSummaryList != null)
				{
					num = (short)989134850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1CA:
				num = (short)2082078721;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E8:
				enumerator = availableLpSummaryList.Where(predicate).ToList<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary>().GetEnumerator();
				num = (short)1396703232;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_167:
				predicate = (global::CommonUtility.PCRLanguageUtility.<>c.<>9__2_0 = new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary, bool>(global::CommonUtility.PCRLanguageUtility.<>c.<>9.a));
				goto IL_1E8;
			}
			return;
			IL_1E3:;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0002B940 File Offset: 0x00029B40
		public static string ToUnifyConfigID(string packageId)
		{
			global::CommonUtility.PCRLanguageUtility.a a;
			global::System.Tuple<string, string, global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily> tuple;
			short num;
			for (;;)
			{
				a = new global::CommonUtility.PCRLanguageUtility.a();
				a.a = packageId;
				a.a = a.a.Replace('_', '-');
				tuple = global::CommonUtility.PCRLanguageUtility.a.FirstOrDefault(new global::System.Func<global::System.Tuple<string, string, global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily>, bool>(a.b));
				if (tuple != null)
				{
					break;
				}
				num = (short)1839726593;
				if (num != 0)
				{
				}
				num = (short)2053055411;
				short num2 = num;
				num = (short)1493640115;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A2;
				}
			}
			return tuple.Item2;
			IL_A2:
			num = (short)1819213824;
			if (num != 0)
			{
			}
			num = (short)715259904;
			short num3 = num;
			return a.a;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0002BA38 File Offset: 0x00029C38
		public static string ToLanguagePackID(string configID, int? languagePackFamily)
		{
			global::CommonUtility.PCRLanguageUtility.b b;
			global::System.Tuple<string, string, global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily> tuple;
			short num;
			for (;;)
			{
				b = new global::CommonUtility.PCRLanguageUtility.b();
				b.a = configID;
				b.b = languagePackFamily;
				b.a = b.a.Replace('_', '-');
				tuple = global::CommonUtility.PCRLanguageUtility.a.FirstOrDefault(new global::System.Func<global::System.Tuple<string, string, global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily>, bool>(b.c));
				if (tuple != null)
				{
					break;
				}
				num = (short)1998632584;
				short num2 = num;
				num = (short)422033032;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A9;
				}
			}
			num = (short)460914689;
			if (num != 0)
			{
			}
			return tuple.Item1;
			IL_A9:
			num = (short)880148480;
			if (num != 0)
			{
			}
			num = (short)131923968;
			short num3 = num;
			return b.a;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0002BB34 File Offset: 0x00029D34
		public static string ToResourceID(string packID)
		{
			short num = (short)916410832;
			short num2 = num;
			num = (short)511398352;
			switch (num2 == num)
			{
			}
			num = (short)334561281;
			if (num != 0)
			{
			}
			num = (short)1868496896;
			if (num != 0)
			{
			}
			num = (short)1074003968;
			short num3 = num;
			return packID.Replace('-', '_');
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0002BBE4 File Offset: 0x00029DE4
		public static string GetLanguageSettingInfoForRadio(global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate template)
		{
			short num = (short)2021982208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_40;
				}
				string result;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc> list;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_206;
					case 1:
						if (template.PCRLanguagePacks.Any<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack>())
						{
							num = (short)1567031298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						goto IL_1BC;
					case 3:
						try
						{
							num = (short)1868103680;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)32834974;
								short num3 = num;
								num = (short)1287194014;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1031340032;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_111;
										}
										continue;
									case 2:
										goto IL_1AC;
									case 3:
										num = (short)2103181314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)305266691;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack pcrlanguagePack = enumerator.Current;
										list.Add(new global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc
										{
											LanguageID = global::CommonUtility.PCRLanguageUtility.ToLanguagePackID(pcrlanguagePack.PackageID, pcrlanguagePack.LanguagePackFamily)
										});
										num = (short)147193857;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								IL_157:
								num = (short)2096103428;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_111:
								goto IL_157;
							}
							IL_1AC:
							goto IL_1E7;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1BC;
						IL_1E7:
						result = global::Motorola.CommonCPS.Common.CommonUtility.ObjectSeralizeUtility.ObjectToJson<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>>(list);
						num = (short)959643648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_40;
					IL_1BC:
					enumerator = template.PCRLanguagePacks.GetEnumerator();
					num = (short)876544003;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_206:
				num = (short)660144129;
				if (num != 0)
				{
				}
				num = (short)25231360;
				short num4 = num;
				return result;
				IL_40:
				result = "";
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>();
				num = (short)1772945409;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0002BE7C File Offset: 0x0002A07C
		// Note: this type is marked as 'beforefieldinit'.
		static PCRLanguageUtility()
		{
			int a_ = 16;
			short num = (short)1510866944;
			short num2 = num;
			num = (short)1087504385;
			if (num != 0)
			{
			}
			num = (short)751745095;
			short num3 = num;
			num = (short)731232327;
			switch (num3 == num)
			{
			}
			num = (short)1438908416;
			if (num != 0)
			{
			}
			global::CommonUtility.PCRLanguageUtility.a = new global::System.Collections.Generic.List<global::System.Tuple<string, string, global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily>>
			{
				new global::System.Tuple<string, string, global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily>(global::CommonUtility.VersionUtility.b("⭀≂桄ⵆ㥈", a_), global::CommonUtility.VersionUtility.b("⭀㍂桄ⵆ㥈", a_), global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily.Trbo)
			};
		}

		// Token: 0x04000102 RID: 258
		public const string CONST_FAKELPPACKAGE_VER = "0.0";

		// Token: 0x04000103 RID: 259
		private static global::System.Collections.Generic.List<global::System.Tuple<string, string, global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily>> a;

		// Token: 0x0200004A RID: 74
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000190 RID: 400 RVA: 0x0002C10C File Offset: 0x0002A30C
			internal bool b(global::System.Tuple<string, string, global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily> A_0)
			{
				short num = (short)1102512128;
				short num2 = num;
				num = (short)742326273;
				if (num != 0)
				{
				}
				num = (short)155615692;
				short num3 = num;
				num = (short)1271562700;
				switch (num3 == num)
				{
				}
				num = (short)603717632;
				if (num != 0)
				{
				}
				return A_0.Item1 == this.a;
			}

			// Token: 0x04000106 RID: 262
			public string a;
		}

		// Token: 0x0200004B RID: 75
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06000192 RID: 402 RVA: 0x0002C1DC File Offset: 0x0002A3DC
			internal bool c(global::System.Tuple<string, string, global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily> A_0)
			{
				short num = (short)1738342400;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1236366902;
						short num3 = num;
						num = (short)174487094;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1138425856;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_80;
							}
							continue;
						}
						break;
					}
					case 1:
						goto IL_125;
					case 2:
						if (this.b != null)
						{
							num = (short)356515841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						num = (short)1374552066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_80:
					num = (short)1232076801;
					if (num != 0)
					{
					}
					if (!(A_0.Item2 == this.a))
					{
						return false;
					}
					num = (short)949616643;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_125:
				num = (short)92667904;
				short num4 = num;
				return A_0.Item3 == (global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily)this.b.Value;
			}

			// Token: 0x04000107 RID: 263
			public string a;

			// Token: 0x04000108 RID: 264
			public int? b;
		}
	}
}
