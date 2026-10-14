using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.UCL.CallListUpdate
{
	// Token: 0x02000222 RID: 546
	internal class CSVProvider : global::SpecialFeatures.UCL.CallListUpdate.ICSVProvider
	{
		// Token: 0x06001BC8 RID: 7112 RVA: 0x0023C514 File Offset: 0x0023A714
		public static global::SpecialFeatures.UCL.CallListUpdate.CSVProvider GetProvider(string csvFilePath)
		{
			short num = (short)2093154305;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::SpecialFeatures.UCL.CallListUpdate.CSVProvider.a != csvFilePath)
					{
						num = (short)1685258241;
						if (num != 0)
						{
						}
						num = (short)1645281282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_157;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					goto IL_81;
				case 3:
					num = (short)587595776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1816858148;
					short num3 = num;
					num = (short)223153700;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_D9;
					}
					break;
				}
				}
				IL_39:
				num = (short)1573912576;
				short num4 = num;
				if (global::SpecialFeatures.UCL.CallListUpdate.CSVProvider.g != null)
				{
					num = (short)189202435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_81:
				global::SpecialFeatures.UCL.CallListUpdate.CSVProvider.g = new global::SpecialFeatures.UCL.CallListUpdate.CSVProvider(csvFilePath);
				num = (short)1286668292;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D9:
			num = (short)159645696;
			if (num != 0)
			{
			}
			IL_157:
			return global::SpecialFeatures.UCL.CallListUpdate.CSVProvider.g;
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00003EB6 File Offset: 0x000020B6
		private CSVProvider(string A_0)
		{
			global::SpecialFeatures.UCL.CallListUpdate.CSVProvider.a = A_0;
			if (!new global::System.IO.FileInfo(A_0).Exists)
			{
				throw new global::System.IO.FileNotFoundException(A_0);
			}
			this.b();
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0023C680 File Offset: 0x0023A880
		private void b()
		{
			int a_ = 2;
			short num = (short)1156907008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				string text;
				global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting> enumerator;
				string text2;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (this.c != null)
						{
							num = (short)1804009478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_649;
					case 1:
					{
						num = (short)881131520;
						short num3 = num;
						try
						{
							num = (short)754122758;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting consoleAliasesListSetting;
									if (consoleAliasesListSetting.type == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶊ", a_))
									{
										num = (short)446038030;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_418;
								}
								case 2:
								{
									global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting consoleAliasesListSetting;
									text = consoleAliasesListSetting.value;
									num = (short)1047986176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2025324557;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting consoleAliasesListSetting = enumerator.Current;
									num = (short)1398079489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting consoleAliasesListSetting;
									this.d.Add(consoleAliasesListSetting.key, consoleAliasesListSetting.value);
									num = (short)885719044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_298;
									}
									continue;
								case 7:
								{
									global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting consoleAliasesListSetting;
									if (consoleAliasesListSetting.key == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_))
									{
										num = (short)1007091729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2023358479;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting consoleAliasesListSetting;
									if (consoleAliasesListSetting.type == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_))
									{
										num = (short)1912274955;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting consoleAliasesListSetting;
									if (consoleAliasesListSetting.type == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾊﶎ", a_))
									{
										num = (short)1687420933;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1775173640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting consoleAliasesListSetting;
									this.e.Add(consoleAliasesListSetting.key, global::System.Convert.ToChar(consoleAliasesListSetting.value));
									num = (short)1389559818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									goto IL_59A;
								case 13:
									num = (short)635502604;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									num = (short)239861767;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting consoleAliasesListSetting;
									if (consoleAliasesListSetting.key == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺊ", a_))
									{
										num = (short)1805058050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_418;
								}
								case 16:
								{
									num = (short)1333260745;
									short num4 = num;
									num = (short)1679618505;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_59A;
									default:
										num = (short)1240465408;
										if (num != 0)
										{
										}
										break;
									}
									break;
								}
								case 17:
								{
									global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting consoleAliasesListSetting;
									text2 = consoleAliasesListSetting.value;
									num = (short)353435664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_29D:
								num = (short)2070020099;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_298:
								goto IL_29D;
								IL_418:
								num = (short)1363017737;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_59A:
							goto IL_696;
						}
						finally
						{
							num = (short)386465793;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2005139458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5D1;
									}
									continue;
								case 2:
									goto IL_606;
								}
								IL_5D1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1744371712;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_606:;
						}
						goto IL_609;
						IL_696:
						num = (short)1535967236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)649330700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_694;
					case 4:
						if (!(text == string.Empty))
						{
							num = (short)515178503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D8;
					case 5:
						goto IL_224;
					case 6:
						num = (short)1819082760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)121896970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1003683841;
						if (num != 0)
						{
						}
						if (this.b.Length != 0)
						{
							num = (short)1327890434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_649;
					case 9:
						if (this.b != null)
						{
							num = (short)1409220619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_649;
					case 10:
						if (text2 == string.Empty)
						{
							num = (short)1609170947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b = text.Split(new string[]
						{
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("濾ﮆ", a_)
						}, global::System.StringSplitOptions.RemoveEmptyEntries);
						this.c = text2.Split(new string[]
						{
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("濾ﮆ", a_)
						}, global::System.StringSplitOptions.RemoveEmptyEntries);
						num = (short)976289801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_609;
					case 12:
						if (this.c.Length == 0)
						{
							num = (short)678297605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E3;
					}
					goto IL_6C;
					IL_609:
					num = (short)1023082496;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_224:
				IL_649:
				throw new global::System.Exception(global::CommonResources.AppResources.ConsoleAliasesListSetting_Missing);
				IL_694:
				IL_6D8:
				throw new global::System.Exception(global::CommonResources.AppResources.ConsoleAliasesListSetting_Missing);
				IL_6E3:
				this.a();
				return;
				IL_6C:
				global::System.Collections.Generic.IEnumerable<global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting> enumerable = global::System.Configuration.ConfigurationManager.GetSection(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("力\ude8cﲔ練ﺘ늜\udc9e캠춢횤좦얨캪쎮\ud8b0튲운튶쪸풼첾뗀郂ꃄ돆뷈ꋊꏌ꣎ꋐ", a_)) as global::System.Collections.Generic.IList<global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting>;
				text = string.Empty;
				text2 = string.Empty;
				this.d = new global::System.Collections.Generic.Dictionary<string, string>();
				this.e = new global::System.Collections.Generic.Dictionary<string, char>();
				enumerator = enumerable.GetEnumerator();
				num = (short)1577320449;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0023CD94 File Offset: 0x0023AF94
		public global::System.Collections.Generic.IDictionary<string, string> getUnitIdAndSortedAliasDict()
		{
			short num = (short)1360134144;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				global::System.Collections.Generic.IDictionary<string, string> dictionary;
				global::System.Collections.Generic.IDictionary<string, string> unitIdAndAliasDict;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						return dictionary;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator = unitIdAndAliasDict.OrderBy(delegate(global::System.Collections.Generic.KeyValuePair<string, string> di)
						{
							short num5 = (short)274263847;
							short num6 = num5;
							num5 = (short)1211756327;
							switch (num6 == num5)
							{
							default:
							{
								num5 = (short)617414656;
								short num7 = num5;
								break;
							}
							case true:
								break;
							}
							num5 = (short)1695612928;
							if (num5 != 0)
							{
							}
							num5 = (short)1946091521;
							if (num5 != 0)
							{
							}
							return di.Key;
						}).GetEnumerator();
						num = (short)377618435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)727187456;
						short num3 = num;
						if (unitIdAndAliasDict.Count == 0)
						{
							num = (short)301727745;
							if (num != 0)
							{
							}
							num = (short)1210187776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1601175553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_138;
					}
					goto IL_3E;
				}
				return dictionary;
				IL_138:
				try
				{
					num = (short)1441333251;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator;
							if (!enumerator.MoveNext())
							{
								goto IL_1BC;
							}
							global::System.Collections.Generic.KeyValuePair<string, string> item = enumerator.Current;
							dictionary.Add(item);
							num = (short)910950401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)802422788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_176;
							}
							continue;
						case 4:
						{
							num = (short)386141889;
							short num4 = num;
							num = (short)2028998337;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1BC;
							default:
								goto IL_222;
							}
							break;
						}
						}
						IL_19E:
						num = (short)1906573312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_176:
						goto IL_19E;
						IL_1BC:
						num = (short)1310130178;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_222:
					num = (short)424345600;
					if (num != 0)
					{
					}
				}
				finally
				{
					num = (short)1959723009;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator;
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1093402626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_26E;
							}
							continue;
						case 2:
							goto IL_2A7;
						}
						IL_26E:
						if (enumerator == null)
						{
							break;
						}
						num = (short)187826176;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2A7:;
				}
				return dictionary;
				IL_3E:
				dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
				unitIdAndAliasDict = this.getUnitIdAndAliasDict();
				num = (short)2029322242;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0023D068 File Offset: 0x0023B268
		public global::System.Collections.Generic.IDictionary<string, string> getUnitIdAndAliasDict()
		{
			short num = (short)1882768719;
			short num2 = num;
			num = (short)1346946383;
			switch (num2 == num)
			{
			}
			num = (short)868220928;
			short num3 = num;
			num = (short)139853824;
			if (num != 0)
			{
			}
			num = (short)1731264513;
			if (num != 0)
			{
			}
			global::System.Data.DataTable a_ = this.b(global::SpecialFeatures.UCL.CallListUpdate.CSVProvider.a, true);
			return this.b(a_);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0023D12C File Offset: 0x0023B32C
		public global::System.Collections.Specialized.NameValueCollection getUnitIdAndAliasList()
		{
			short num = (short)258321851;
			short num2 = num;
			num = (short)1979428283;
			switch (num2 == num)
			{
			}
			num = (short)855965696;
			short num3 = num;
			num = (short)378077185;
			if (num != 0)
			{
			}
			num = (short)364118016;
			if (num != 0)
			{
			}
			global::System.Data.DataTable a_ = this.b(global::SpecialFeatures.UCL.CallListUpdate.CSVProvider.a, true);
			return this.a(a_);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0023D1EC File Offset: 0x0023B3EC
		private global::System.Data.DataColumn a(global::System.Data.DataTable A_0, string[] A_1)
		{
			short num = (short)742588416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::System.Data.DataColumn dataColumn;
				for (;;)
				{
					IL_27:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_334;
					case 1:
						if (A_0 != null)
						{
							num = (short)243204096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_385;
					case 2:
						try
						{
							num = (short)1246101515;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2B6;
								case 1:
								{
									global::System.Data.DataColumn dataColumn2;
									dataColumn = dataColumn2;
									num = (short)1447886858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2124021769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Data.DataColumn dataColumn2 = (global::System.Data.DataColumn)enumerator.Current;
									num = (short)352976904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Data.DataColumn dataColumn2;
									string text;
									if (dataColumn2.ColumnName.Trim().ToUpper() == text.ToUpper())
									{
										num = (short)1895038977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num3;
									num3++;
									num = (short)1386479623;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_25C;
								case 5:
								{
									int num3;
									if (num3 >= A_1.Length)
									{
										num = (short)1085014022;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = A_1[num3];
									num = (short)1414332419;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_D2;
								case 8:
									if (dataColumn == null)
									{
										num = (short)986710020;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 9:
									num = (short)1042808832;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_CD;
									}
									continue;
								case 12:
									goto IL_D2;
								}
								goto IL_CD;
								IL_D2:
								num = (short)638135478;
								short num4 = num;
								num = (short)744434870;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
								{
									IL_25C:
									int num3 = 0;
									num = (short)184483852;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								default:
									num = (short)139264000;
									if (num != 0)
									{
									}
									num = (short)180092933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1C2:
								num = (short)2030829570;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CD:
								goto IL_1C2;
							}
							IL_2B6:
							goto IL_385;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2D8;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2C5:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1041956866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)976879616;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_333;
								case 2:
									goto IL_331;
								}
								goto IL_2D8;
							}
							IL_331:
							IL_333:
							goto EndFinally_9;
							IL_2D8:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)2030043137;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2C5;
							EndFinally_9:;
						}
						goto IL_334;
					}
					goto IL_3A;
					IL_334:
					num = (short)2033778689;
					if (num != 0)
					{
					}
					enumerator = A_0.Columns.GetEnumerator();
					num = (short)268632066;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_385:
				num = (short)557842432;
				short num5 = num;
				return dataColumn;
				IL_3A:
				dataColumn = null;
				num = (short)1828782081;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0023D5C4 File Offset: 0x0023B7C4
		private global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> a(global::System.Data.DataTable A_0, global::System.Collections.Generic.IDictionary<string, string> A_1)
		{
			short num;
			global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> dictionary;
			for (;;)
			{
				num = (short)1458110464;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.DataColumn, string>();
					global::System.Collections.IEnumerator enumerator = A_0.Columns.GetEnumerator();
					try
					{
						num = (short)1230045187;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1505558530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Data.DataColumn dataColumn = (global::System.Data.DataColumn)enumerator.Current;
								global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator2 = A_1.GetEnumerator();
								num = (short)989790209;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								try
								{
									num = (short)1107820546;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_1EA;
										case 1:
										{
											global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)1809645573;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator2.Current;
											num = (short)576389126;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											switch (0)
											{
											case 0:
												goto IL_113;
											}
											continue;
										case 3:
											goto IL_170;
										case 4:
										{
											global::System.Data.DataColumn dataColumn;
											global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
											dictionary.Add(dataColumn, keyValuePair.Value);
											num = (short)1007616003;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 5:
											num = (short)786825216;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
										{
											global::System.Data.DataColumn dataColumn;
											global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
											if (dataColumn.ColumnName.Trim() == keyValuePair.Key)
											{
												num = (short)668008452;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										IL_115:
										num = (short)577699841;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_113:
										goto IL_115;
									}
									IL_170:
									IL_1EA:
									break;
								}
								finally
								{
									num = (short)94961665;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator2;
										switch (num2)
										{
										case 0:
											goto IL_258;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_221;
											}
											continue;
										case 2:
											enumerator2.Dispose();
											num = (short)1166934016;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_221:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)896925698;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_258:;
								}
								goto IL_25B;
							case 2:
								goto IL_25B;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_6D;
								}
								continue;
							case 4:
								goto IL_273;
							}
							IL_99:
							num = (short)675217408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_6D:
							goto IL_99;
							IL_25B:
							num = (short)1451687940;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_273:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_292;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_27F:
							switch (num2)
							{
							case 0:
								goto IL_2E9;
							case 1:
								if (disposable != null)
								{
									num = (short)974782466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2EB;
							case 2:
								disposable.Dispose();
								num = (short)1797324800;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_292;
						}
						IL_2E9:
						IL_2EB:
						goto EndFinally_10;
						IL_292:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)518520833;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_27F;
						EndFinally_10:;
					}
					num = (short)1496898342;
					short num3 = num;
					num = (short)468376358;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_321;
					}
					break;
				}
				}
			}
			IL_321:
			num = (short)1871708161;
			if (num != 0)
			{
			}
			num = (short)2009006080;
			if (num != 0)
			{
			}
			num = (short)756744192;
			short num4 = num;
			return dictionary;
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0023D98C File Offset: 0x0023BB8C
		private void a(ref string A_0, ref string A_1, global::System.Data.DataRow A_2, global::System.Data.DataColumn A_3, global::System.Data.DataColumn A_4, global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> A_5)
		{
			short num = (short)364642309;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::System.Data.DataColumn, string>> enumerator;
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)1887698946;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_19E;
							case 1:
							{
								global::System.Collections.Generic.KeyValuePair<global::System.Data.DataColumn, string> keyValuePair;
								if (A_2[keyValuePair.Key].ToString().ToUpper() == keyValuePair.Value.ToUpper())
								{
									num = (short)1979318277;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_B4;
								}
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)917504006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::System.Data.DataColumn, string> keyValuePair = enumerator.Current;
								num = (short)536608769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_182;
							case 5:
								A_0 = A_2[A_3].ToString();
								A_1 = A_2[A_4].ToString();
								num = (short)1588396036;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								num = (short)77922304;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_113:
							num = (short)1138950147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B4:
							goto IL_113;
						}
						IL_182:
						IL_19E:
						return;
					}
					finally
					{
						num = (short)2020147201;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_259;
							case 1:
								goto IL_1B8;
							case 2:
							{
								enumerator.Dispose();
								num = (short)97582135;
								short num3 = num;
								num = (short)2020277303;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1B8;
								default:
									num = (short)767033344;
									if (num != 0)
									{
									}
									num = (short)585760768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							goto IL_1D4;
							IL_1B8:
							switch (0)
							{
							case 0:
								IL_1D4:
								if (enumerator == null)
								{
									goto IL_25B;
								}
								num = (short)2120744962;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_259:
						IL_25B:;
					}
					goto IL_25C;
				case 1:
					num = (short)2011234305;
					if (num != 0)
					{
					}
					num = (short)849739784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (A_3 != null)
					{
						num = (short)1127219211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)681574409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)806092800;
					short num4 = num;
					if (A_4 != null)
					{
						num = (short)1470824451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 6:
					goto IL_25C;
				case 7:
					num = (short)1975779330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (A_5.Count > 0)
					{
						num = (short)1726611462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E3;
				case 9:
					if (A_5 != null)
					{
						num = (short)1816788993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E3;
				case 10:
					return;
				case 11:
					num = (short)1889337348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_54:
				if (A_2 != null)
				{
					num = (short)1293287431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_25C:
				enumerator = A_5.GetEnumerator();
				num = (short)225968128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E3:
				A_0 = A_2[A_3].ToString();
				A_1 = A_2[A_4].ToString();
				num = (short)1114767370;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0023DDB0 File Offset: 0x0023BFB0
		private global::System.Collections.Generic.IDictionary<string, string> b(global::System.Data.DataTable A_0, global::System.Data.DataColumn A_1, global::System.Data.DataColumn A_2, global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> A_3)
		{
			short num = (short)1475149824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				global::System.Collections.IEnumerator enumerator;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1863647238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						enumerator = A_0.Rows.GetEnumerator();
						num = (short)1686896642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_AD;
					case 3:
						if (A_0 != null)
						{
							num = (short)1424097280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112;
					case 4:
						num = (short)921829381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (A_2 != null)
						{
							num = (short)465108993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112;
					case 6:
						num = (short)1027735553;
						if (num != 0)
						{
						}
						if (A_1 != null)
						{
							num = (short)164888580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112;
					case 7:
						goto IL_13C;
					}
					goto IL_4E;
					IL_112:
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, global::CommonResources.AppResources.Invalid_CSV_File);
					num = (short)1546911751;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AD:
				global::System.Collections.Generic.Dictionary<string, string> dictionary;
				try
				{
					num = (short)2096365572;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							string empty = string.Empty;
							string empty2 = string.Empty;
							global::System.Data.DataRow dataRow;
							this.a(ref empty, ref empty2, dataRow, A_1, A_2, A_3);
							num = (short)656015365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::System.Data.DataRow dataRow;
							if (!dictionary.ContainsKey(dataRow[A_1].ToString()))
							{
								num = (short)604831744;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							num = (short)1533345799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							string empty2;
							if (empty2 != string.Empty)
							{
								num = (short)1433272329;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_1FA;
							}
							continue;
						case 5:
						{
							string empty;
							if (empty != string.Empty)
							{
								num = (short)424607752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)51642370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Data.DataRow dataRow = (global::System.Data.DataRow)enumerator.Current;
							num = (short)1559101441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_36B;
						case 8:
							num = (short)1775042563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							string empty;
							string empty2;
							dictionary.Add(empty, empty2);
							num = (short)1637679114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_1FC:
						num = (short)975372294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1FA:
						goto IL_1FC;
					}
					IL_36B:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_38D;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_37A:
						switch (num2)
						{
						case 0:
							goto IL_435;
						case 1:
							if (disposable != null)
							{
								goto IL_3B2;
							}
							goto IL_437;
						case 2:
						{
							num = (short)603847868;
							short num3 = num;
							num = (short)858717372;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3B2;
							default:
								num = (short)570949632;
								if (num != 0)
								{
								}
								disposable.Dispose();
								num = (short)523763712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_38D;
						IL_3B2:
						num = (short)1789001730;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_435:
					IL_437:
					goto EndFinally_10;
					IL_38D:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)310575105;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_37A;
					EndFinally_10:;
				}
				return dictionary;
				IL_13C:
				num = (short)211156992;
				short num4 = num;
				return dictionary;
				IL_4E:
				dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
				num = (short)490143747;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0023E214 File Offset: 0x0023C414
		private global::System.Collections.Specialized.NameValueCollection a(global::System.Data.DataTable A_0, global::System.Data.DataColumn A_1, global::System.Data.DataColumn A_2, global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> A_3)
		{
			short num = (short)1149435904;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				global::System.Collections.IEnumerator enumerator;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1329594369;
						if (num != 0)
						{
						}
						num = (short)1221328902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						enumerator = A_0.Rows.GetEnumerator();
						num = (short)2139357186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_AC;
					case 3:
						if (A_0 != null)
						{
							num = (short)1698824192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_110;
					case 4:
						num = (short)267386885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (A_2 != null)
						{
							num = (short)1649016833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_110;
					case 6:
						if (A_1 != null)
						{
							num = (short)234815492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_110;
					case 7:
						goto IL_138;
					}
					goto IL_4E;
					IL_110:
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, global::CommonResources.AppResources.Invalid_CSV_File);
					num = (short)1545076743;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AC:
				global::System.Collections.Specialized.NameValueCollection nameValueCollection;
				try
				{
					num = (short)1113128964;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)582615045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1038286848;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Data.DataRow a_ = (global::System.Data.DataRow)enumerator.Current;
							string empty = string.Empty;
							string empty2 = string.Empty;
							this.a(ref empty, ref empty2, a_, A_1, A_2, A_3);
							num = (short)139329544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							string empty;
							string empty2;
							nameValueCollection.Add(empty, empty2);
							num = (short)961806342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)1946157063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_1EB;
							}
							continue;
						case 5:
							goto IL_311;
						case 7:
						{
							string empty2;
							if (empty2 != string.Empty)
							{
								num = (short)572194818;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							string empty;
							if (empty != string.Empty)
							{
								num = (short)1916665859;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_1ED:
						num = (short)604372993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1EB:
						goto IL_1ED;
					}
					IL_311:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_333;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_320:
						switch (num2)
						{
						case 0:
							goto IL_3D8;
						case 1:
							if (disposable != null)
							{
								goto IL_358;
							}
							goto IL_3DA;
						case 2:
						{
							num = (short)1356370309;
							short num3 = num;
							num = (short)1238929797;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_358;
							default:
								num = (short)1531707392;
								if (num != 0)
								{
								}
								disposable.Dispose();
								num = (short)2056978432;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_333;
						IL_358:
						num = (short)2141454338;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3D8:
					IL_3DA:
					goto EndFinally_9;
					IL_333:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)476905473;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_320;
					EndFinally_9:;
				}
				return nameValueCollection;
				IL_138:
				num = (short)1513619456;
				short num4 = num;
				return nameValueCollection;
				IL_4E:
				nameValueCollection = new global::System.Collections.Specialized.NameValueCollection();
				num = (short)206831619;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0023E61C File Offset: 0x0023C81C
		private global::System.Collections.Generic.IDictionary<string, string> b(global::System.Data.DataTable A_0)
		{
			short num = (short)262340608;
			short num2 = num;
			num = (short)1858855816;
			short num3 = num;
			num = (short)1552016264;
			switch (num3 == num)
			{
			}
			num = (short)1919352832;
			if (num != 0)
			{
			}
			num = (short)1319305217;
			if (num != 0)
			{
			}
			global::System.Data.DataColumn a_ = this.a(A_0, this.c);
			global::System.Data.DataColumn a_2 = this.a(A_0, this.b);
			global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> a_3 = this.a(A_0, this.d);
			return this.b(A_0, a_, a_2, a_3);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0023E6FC File Offset: 0x0023C8FC
		private global::System.Collections.Specialized.NameValueCollection a(global::System.Data.DataTable A_0)
		{
			short num = (short)469172224;
			short num2 = num;
			num = (short)659196500;
			short num3 = num;
			num = (short)1418037844;
			switch (num3 == num)
			{
			}
			num = (short)1018757121;
			if (num != 0)
			{
			}
			num = (short)1887109120;
			if (num != 0)
			{
			}
			global::System.Data.DataColumn a_ = this.a(A_0, this.c);
			global::System.Data.DataColumn a_2 = this.a(A_0, this.b);
			global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> a_3 = this.a(A_0, this.d);
			return this.a(A_0, a_, a_2, a_3);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0023E7DC File Offset: 0x0023C9DC
		private string g(string A_0)
		{
			short num = (short)2122973184;
			short num2 = num;
			num = (short)1184906277;
			short num3 = num;
			num = (short)1354906661;
			switch (num3 == num)
			{
			}
			num = (short)1841627137;
			if (num != 0)
			{
			}
			num = (short)973012992;
			if (num != 0)
			{
			}
			string empty = string.Empty;
			return new global::System.IO.StreamReader(new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.ReadWrite), global::System.Text.Encoding.Default).ReadToEnd();
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0023E8A4 File Offset: 0x0023CAA4
		private global::System.Data.DataTable b(string A_0, bool A_1)
		{
			int num;
			global::System.Data.DataTable result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (!global::System.IO.File.Exists(A_0))
						{
							return result;
						}
						num2 = (short)928105980;
						short num3 = num2;
						num2 = (short)256296444;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
							num2 = (short)53936129;
							if (num2 != 0)
							{
							}
							num2 = (short)529006592;
							if (num2 != 0)
							{
							}
							num2 = (short)468254723;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						return result;
					case 2:
					{
						num2 = (short)850001920;
						short num4 = num2;
						string text;
						result = this.a(text, A_1);
						num2 = (short)751632385;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
					{
						string text = this.g(A_0);
						num2 = (short)373817348;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num2 = (short)300285954;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					goto IL_24;
				}
				return result;
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)603848704;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0023EA14 File Offset: 0x0023CC14
		public bool isCsvValid()
		{
			short num = (short)1697775616;
			short num2 = num;
			num = (short)1040239424;
			short num3 = num;
			num = (short)1102564160;
			switch (num3 == num)
			{
			}
			num = (short)410386433;
			if (num != 0)
			{
			}
			num = (short)708640768;
			if (num != 0)
			{
			}
			return this.f(global::SpecialFeatures.UCL.CallListUpdate.CSVProvider.a);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0023EAC8 File Offset: 0x0023CCC8
		private bool f(string A_0)
		{
			short num = (short)1466499072;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				case 1:
				{
					num = (short)292880385;
					if (num != 0)
					{
					}
					num = (short)173356372;
					short num3 = num;
					num = (short)217724244;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_88;
					default:
						goto IL_125;
					}
					break;
				}
				case 2:
					goto IL_88;
				case 3:
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)1494155265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_36:
				if (global::System.IO.File.Exists(A_0))
				{
					num = (short)46923776;
					short num4 = num;
					num = (short)226295810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_88:
				text = this.g(A_0);
				num = (short)1766064131;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_125:
			num = (short)33095680;
			if (num != 0)
			{
			}
			return this.d(text);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0023EC18 File Offset: 0x0023CE18
		private void b(ref global::System.Data.DataTable A_0, string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_52;
			}
			short num;
			int num2;
			string[] array;
			int num4;
			for (;;)
			{
				IL_0A:
				num = (short)1004929025;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)832556420;
					short num3 = num;
					num = (short)888393092;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_73;
					default:
						goto IL_198;
					}
					break;
				}
				case 1:
					goto IL_102;
				case 2:
					goto IL_73;
				case 3:
					if (!A_0.Columns.Contains(array[num4]))
					{
						num = (short)2136473606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78;
				case 4:
					if (num4 >= array.Length)
					{
						num = (short)1202061312;
						short num5 = num;
						num = (short)568262656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)892207107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_78;
				case 6:
					A_0.Columns.Add(array[num4]);
					num = (short)2146107397;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_52;
				IL_78:
				num4++;
				num = (short)2092957697;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_102:
				num = (short)2015690756;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_73:
				goto IL_102;
			}
			IL_198:
			num = (short)667090944;
			if (num != 0)
			{
			}
			return;
			IL_52:
			array = null;
			array = this.c(A_1);
			num4 = 0;
			num = (short)1787953154;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0023EDD8 File Offset: 0x0023CFD8
		private global::System.Data.DataRow a(ref global::System.Data.DataTable A_0, string A_1)
		{
			short num = (short)484507648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				string[] array;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						num = (short)58566191;
						short num3 = num;
						num = (short)2038212143;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_169;
						default:
						{
							num = (short)358678528;
							if (num != 0)
							{
							}
							int num4 = array.Length - A_0.Columns.Count;
							int num5 = 0;
							num = (short)1159856130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
					{
						num = (short)1945042945;
						if (num != 0)
						{
						}
						num = (short)1231683584;
						short num6 = num;
						if (A_0.Columns.Count < array.Length)
						{
							num = (short)157810688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C7;
					}
					case 2:
						goto IL_132;
					case 3:
						goto IL_132;
					case 4:
					{
						int num4;
						int num5;
						if (num5 >= num4)
						{
							num = (short)109969413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_0.Columns.Add();
						num5++;
						num = (short)1397948419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_169;
					}
					goto IL_48;
					IL_132:
					num = (short)501022724;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_169:
				IL_1C7:
				global::System.Data.DataRowCollection rows = A_0.Rows;
				object[] values = array;
				return rows.Add(values);
				IL_48:
				array = null;
				array = this.c(A_1);
				num = (short)9109505;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0023EFBC File Offset: 0x0023D1BC
		private string[] e(string A_0)
		{
			int a_ = 19;
			short num = (short)406388736;
			short num2 = num;
			num = (short)1924440420;
			short num3 = num;
			num = (short)457285988;
			switch (num3 == num)
			{
			}
			num = (short)20840448;
			if (num != 0)
			{
			}
			num = (short)1257570305;
			if (num != 0)
			{
			}
			return A_0.Split(new string[]
			{
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("鮕銗", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("鲕", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("鮕", a_)
			}, global::System.StringSplitOptions.RemoveEmptyEntries);
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0023F0B0 File Offset: 0x0023D2B0
		private bool d(string A_0)
		{
			short num = (short)1353580544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7E;
				}
				global::System.Data.DataTable a_2;
				for (;;)
				{
					IL_27:
					int num3;
					string[] array;
					switch (num2)
					{
					case 0:
					{
						global::System.Data.DataColumn dataColumn;
						if (dataColumn == null)
						{
							num = (short)1010892811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> a_ = this.a(a_2, this.d);
						num3 = 0;
						num = (short)308084748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (array[num3] != null)
						{
							num = (short)199557127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_201;
					case 2:
					{
						num = (short)966983680;
						short num4 = num;
						this.b(ref a_2, array[0]);
						array[0] = null;
						global::System.Data.DataColumn dataColumn2 = this.a(a_2, this.c);
						global::System.Data.DataColumn dataColumn = this.a(a_2, this.b);
						num = (short)1665466373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_35D;
					case 4:
						if (!string.IsNullOrEmpty(A_0))
						{
							num = (short)910295053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
					{
						global::System.Data.DataColumn dataColumn2;
						if (dataColumn2 != null)
						{
							num = (short)1518665737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 6:
						if (num3 >= array.Length)
						{
							num = (short)641859587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1303642113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.Data.DataRow a_3 = this.a(ref a_2, array[num3]);
						string empty = string.Empty;
						string empty2 = string.Empty;
						global::System.Data.DataColumn dataColumn;
						global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> a_;
						global::System.Data.DataColumn dataColumn2;
						this.a(ref empty, ref empty2, a_3, dataColumn2, dataColumn, a_);
						num = (short)1179385870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (array != null)
						{
							num = (short)1818624016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						num = (short)2024865792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return true;
					case 11:
						goto IL_416;
					case 12:
						goto IL_320;
					case 13:
						num = (short)396820481;
						if (num != 0)
						{
						}
						a_2 = new global::System.Data.DataTable();
						array = this.e(A_0);
						num = (short)1418526728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						string empty;
						if (empty != string.Empty)
						{
							num = (short)228130835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_201;
					}
					case 15:
					{
						string empty2;
						if (empty2 != string.Empty)
						{
							num = (short)1526595594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_201;
					}
					case 16:
					{
						num = (short)551697477;
						short num5 = num;
						num = (short)230767685;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_289;
						default:
							num = (short)90308608;
							if (num != 0)
							{
							}
							num = (short)238354449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 17:
						goto IL_289;
					case 18:
						goto IL_320;
					case 19:
						num = (short)850984975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E;
					IL_201:
					num3++;
					num = (short)907280402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_289:
					if (array.Length != 0)
					{
						num = (short)1334968322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
					IL_320:
					num = (short)353304582;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_35D:
				return false;
				IL_416:
				return false;
				IL_7E:
				a_2 = null;
				num = (short)1217593348;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0023F4DC File Offset: 0x0023D6DC
		private global::System.Data.DataTable a(string A_0, bool A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num3;
			global::System.Data.DataTable result;
			for (;;)
			{
				IL_0A:
				int num2;
				switch (num)
				{
				case 0:
				{
					string[] array;
					if (num2 >= array.Length)
					{
						num3 = (short)633274379;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1607729155;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 1:
				{
					string[] array;
					this.b(ref result, array[0]);
					array[0] = null;
					num3 = (short)66977796;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
					goto IL_250;
				case 3:
				{
					string[] array;
					if (array[num2] != null)
					{
						num3 = (short)433127437;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1AA;
				}
				case 4:
					goto IL_DD;
				case 5:
				{
					num3 = (short)973014892;
					short num4 = num3;
					num3 = (short)1434060652;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AE;
					default:
						num3 = (short)826474496;
						if (num3 != 0)
						{
						}
						goto IL_250;
					}
					break;
				}
				case 6:
				{
					result = new global::System.Data.DataTable();
					string[] array = this.e(A_0);
					num3 = (short)771227656;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 7:
				{
					num3 = (short)707919872;
					short num5 = num3;
					num3 = (short)396034057;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 8:
				{
					string[] array;
					if (array != null)
					{
						num3 = (short)1489109002;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return result;
				}
				case 9:
					if (A_1)
					{
						num3 = (short)6684673;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_DD;
				case 10:
					num3 = (short)1883570188;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 11:
					return result;
				case 12:
				{
					string[] array;
					if (array.Length != 0)
					{
						num3 = (short)1041891335;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return result;
				}
				case 13:
				{
					string[] array;
					this.a(ref result, array[num2]);
					num3 = (short)49741825;
					if (num3 != 0)
					{
					}
					num3 = (short)631177230;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 14:
					goto IL_1AA;
				case 15:
					if (!string.IsNullOrEmpty(A_0))
					{
						num3 = (short)1981153286;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return result;
				}
				goto IL_50;
				IL_DD:
				num2 = 0;
				num3 = (short)1464336389;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1AE:
				num3 = (short)1885995010;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1AA:
				num2++;
				goto IL_1AE;
				IL_250:
				num3 = (short)1820917760;
				num = (int)((global::System.IntPtr)num3);
			}
			return result;
			IL_50:
			result = null;
			num3 = (short)1261305871;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0023F7D4 File Offset: 0x0023D9D4
		private void a()
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			char c;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)12648449;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.e.ContainsKey(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)))
					{
						goto IL_F9;
					}
					goto IL_112;
				case 2:
					goto IL_112;
				case 3:
					c = this.e[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)];
					num2 = (short)1665204226;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (this.e.Count > 0)
					{
						num2 = (short)1577582592;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_112;
				}
				goto IL_2D;
				IL_F9:
				num2 = (short)510459907;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_112:
				num2 = (short)1249837056;
				short num3 = num2;
				num2 = (short)1219805648;
				short num4 = num2;
				num2 = (short)657441232;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F9;
				default:
					goto IL_170;
				}
			}
			IL_170:
			num2 = (short)188153856;
			if (num2 != 0)
			{
			}
			this.f = c;
			return;
			IL_2D:
			num2 = (short)1406337025;
			if (num2 != 0)
			{
			}
			c = ',';
			num2 = (short)1391460356;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0023F970 File Offset: 0x0023DB70
		private string[] c(string A_0)
		{
			short num = (short)1344191848;
			short num2 = num;
			num = (short)1038007656;
			switch (num2 == num)
			{
			default:
			{
				num = (short)747634688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)629604353;
			if (num != 0)
			{
			}
			num = (short)1053229056;
			if (num != 0)
			{
			}
			return this.a(A_0, this.f);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0023FA24 File Offset: 0x0023DC24
		private string[] a(string A_0, char A_1)
		{
			short num = (short)119275520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CA;
				}
				global::System.Collections.Generic.List<string> list;
				global::System.Collections.Generic.List<string> list2;
				for (;;)
				{
					IL_27:
					int num3;
					int num6;
					switch (num2)
					{
					case 0:
						goto IL_6D0;
					case 1:
						goto IL_605;
					case 2:
						goto IL_429;
					case 3:
					{
						string text;
						if (num3 == text.Length - 1)
						{
							num = (short)1334247436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_379;
					}
					case 4:
					{
						int num4;
						if (num4 < A_0.Length)
						{
							num = (short)258670608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_605;
					}
					case 5:
					{
						int num4 = 0;
						int num5 = 0;
						string text2;
						string text = this.b(text2);
						num3 = 0;
						num = (short)793772067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (num6 == A_0.Length - 1)
						{
							num = (short)572653595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_605;
					case 7:
					{
						int num5;
						num5++;
						num = (short)1621688344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						string text;
						if (num3 >= text.Length)
						{
							num = (short)273743906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1749942290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						if (A_0[num6] != A_1)
						{
							goto IL_429;
						}
						num = (short)639322385;
						short num7 = num;
						num = (short)1600342289;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_670;
						default:
							num = (short)381747200;
							if (num != 0)
							{
							}
							num = (short)1626669086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						if (num6 >= A_0.Length)
						{
							num = (short)241500177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2115305503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_6D0;
					case 12:
						num = (short)1414332449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_3CC;
					case 14:
						goto IL_5C6;
					case 15:
					{
						int num4 = 0;
						int num5 = 0;
						string text2 = string.Empty;
						num6 = 0;
						num = (short)938213402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						int num4;
						string text2 = A_0.Substring(num4, num6 - num4 + 1);
						num = (short)423297025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						num = (short)1560281107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						string text;
						if (text[num3] == '"')
						{
							num = (short)1562837029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)687800356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						string text2;
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)911081477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_716;
					}
					case 20:
					{
						string text;
						int num4;
						list.Add(this.a(this.b(text.Substring(num4, num3 - num4 + 1))));
						num4 = num3 + 1;
						num = (short)446496800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						int num4;
						list2.Add(this.a(A_0.Substring(num4, num6 - num4)));
						num4 = num6 + 1;
						num = (short)594608130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						string text;
						int num4;
						list.Add(this.a(this.b(text.Substring(num4, num3 - num4))));
						num4 = num3 + 1;
						num = (short)1927610368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						int num5;
						if (num5 % 2 == 0)
						{
							num = (short)1137639424;
							short num8 = num;
							num = (short)1445330966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D0;
					}
					case 24:
						goto IL_429;
					case 25:
						num = (short)734789655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_5C6;
					case 27:
						num = (short)145162244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_2CB;
					case 29:
					{
						int num5;
						if (num5 % 2 == 0)
						{
							num = (short)1280376853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_429;
					}
					case 30:
						num = (short)1506279453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (A_0[num6] == '"')
						{
							goto IL_670;
						}
						num = (short)711852041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_379;
					case 33:
					{
						string text;
						int num4;
						if (num4 < text.Length)
						{
							num = (short)39125012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_379;
					}
					case 34:
					{
						string[] array = list.ToArray();
						global::System.Array.Reverse(array);
						list2.AddRange(array);
						num = (short)339738637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						goto IL_2CB;
					case 36:
					{
						string text;
						if (text[num3] == A_1)
						{
							num = (short)2070609945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D0;
					}
					case 37:
					{
						num = (short)183369729;
						if (num != 0)
						{
						}
						int num5;
						num5++;
						num = (short)46989323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						if (!string.IsNullOrEmpty(A_0))
						{
							num = (short)218300431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_716;
					}
					goto IL_CA;
					IL_2CB:
					num = (short)196616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_379:
					num3++;
					num = (short)1760165916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_429:
					num = (short)1641021446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C6:
					num = (short)829554698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_605:
					num6++;
					num = (short)1812660238;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_670:
					num = (short)1366032391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D0:
					num = (short)1129512963;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3CC:
				IL_716:
				return list2.ToArray();
				IL_CA:
				list2 = new global::System.Collections.Generic.List<string>();
				list = new global::System.Collections.Generic.List<string>();
				num = (short)1702297638;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00240150 File Offset: 0x0023E350
		private string b(string A_0)
		{
			short num = (short)62324736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				int num4;
				string text;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						num = (short)1221118974;
						short num3 = num;
						num = (short)665439230;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_106;
						default:
							goto IL_155;
						}
						break;
					}
					case 1:
						if (num4 >= A_0.Length)
						{
							num = (short)1827864576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = A_0[num4].ToString() + text;
						num4++;
						goto IL_106;
					case 2:
						goto IL_B0;
					case 3:
					{
						num = (short)1221918720;
						short num5 = num;
						goto IL_B0;
					}
					}
					goto IL_3F;
					IL_B0:
					num = (short)572325889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_106:
					num = (short)353632258;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_155:
				num = (short)1129119744;
				if (num != 0)
				{
				}
				return text;
				IL_3F:
				num = (short)2105344001;
				if (num != 0)
				{
				}
				text = string.Empty;
				num4 = 0;
				num = (short)667418627;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x002402CC File Offset: 0x0023E4CC
		private string a(string A_0)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return text;
				case 1:
				{
					num2 = (short)275833736;
					short num3 = num2;
					num2 = (short)243262344;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10A;
					default:
					{
						num2 = (short)552075265;
						if (num2 != 0)
						{
						}
						num2 = (short)1383137280;
						if (num2 != 0)
						{
						}
						global::System.Text.RegularExpressions.Match match;
						if (match.Success)
						{
							num2 = (short)625803268;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						text = text.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆂꞄ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆂ", a_));
						num2 = (short)1233584131;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
				{
					global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(A_0, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd82Ꞅ꾆ꞈꆊ늌Ꚏ뎐랒", a_));
					num2 = (short)294846465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_A7;
				case 4:
				{
					global::System.Text.RegularExpressions.Match match;
					text = match.Result(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("Ꞃﺄ뚆", a_)).Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆂꞄ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆂ", a_));
					goto IL_10A;
				}
				case 5:
					if (!string.IsNullOrEmpty(A_0))
					{
						num2 = (short)522911746;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				}
				goto IL_31;
				IL_10A:
				num2 = (short)193724416;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A7:
			num2 = (short)2073821184;
			short num4 = num2;
			return text;
			IL_31:
			text = A_0;
			num2 = (short)2142568453;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x002404C4 File Offset: 0x0023E6C4
		// Note: this type is marked as 'beforefieldinit'.
		static CSVProvider()
		{
			short num = (short)2146119980;
			short num2 = num;
			num = (short)2088710444;
			switch (num2 == num)
			{
			default:
			{
				num = (short)679739392;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1177419776;
			if (num != 0)
			{
			}
			num = (short)405471233;
			if (num != 0)
			{
			}
			global::SpecialFeatures.UCL.CallListUpdate.CSVProvider.a = string.Empty;
			global::SpecialFeatures.UCL.CallListUpdate.CSVProvider.g = null;
		}

		// Token: 0x04000DAF RID: 3503
		private static string a;

		// Token: 0x04000DB0 RID: 3504
		private string[] b;

		// Token: 0x04000DB1 RID: 3505
		private string[] c;

		// Token: 0x04000DB2 RID: 3506
		private global::System.Collections.Generic.IDictionary<string, string> d;

		// Token: 0x04000DB3 RID: 3507
		private global::System.Collections.Generic.IDictionary<string, char> e;

		// Token: 0x04000DB4 RID: 3508
		private char f = ',';

		// Token: 0x04000DB5 RID: 3509
		private static global::SpecialFeatures.UCL.CallListUpdate.CSVProvider g;
	}
}
