using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000030 RID: 48
	public class CSVProvider : global::Motorola.CommonCPS.RadioManagement.SharedServices.ICSVProvider
	{
		// Token: 0x06000548 RID: 1352 RVA: 0x00034DBC File Offset: 0x00032FBC
		public static global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVProvider GetProvider(string csvFilePath)
		{
			short num = (short)973209600;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 1:
					goto IL_101;
				case 2:
					num = (short)188022788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_C2;
				case 4:
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVProvider.a != csvFilePath)
					{
						num = (short)994902017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12D;
				}
				IL_38:
				num = (short)1678535092;
				short num3 = num;
				num = (short)314730932;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_101:
					num = (short)908525569;
					if (num != 0)
					{
					}
					break;
				default:
					num = (short)1686568960;
					if (num != 0)
					{
					}
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVProvider.g != null)
					{
						num = (short)247791618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVProvider.g = new global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVProvider(csvFilePath);
				num = (short)1639776259;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C2:
			IL_12D:
			num = (short)101253120;
			short num4 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVProvider.g;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00034F28 File Offset: 0x00033128
		private CSVProvider(string csvFilePath)
		{
			global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVProvider.a = csvFilePath;
			if (!new global::System.IO.FileInfo(csvFilePath).Exists)
			{
				throw new global::System.IO.FileNotFoundException(csvFilePath);
			}
			this.b();
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00034F68 File Offset: 0x00033168
		private void b()
		{
			int a_ = 9;
			short num;
			try
			{
				num = (short)327541472;
				short num2 = num;
				num = (short)97116896;
				string text;
				string text2;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)183959552;
					if (num != 0)
					{
					}
					num = (short)1497169920;
					switch (num)
					{
					default:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting> enumerable = global::System.Configuration.ConfigurationManager.GetSection(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햟톡솣풥ﮧ쾩\ud8ab\udaad\ud9af\udcb1펳억鞷惡펻킽뎿귁ꣃꏅ觇ꛉꗋ꿍ꏏ럑ꟓ髕뇗꧙꣛距藟雡郣迥蛧跩鿫", a_)) as global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting>;
						text = string.Empty;
						text2 = string.Empty;
						this.d = new global::System.Collections.Generic.Dictionary<string, string>();
						this.e = new global::System.Collections.Generic.Dictionary<string, char>();
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting> enumerator = enumerable.GetEnumerator();
						try
						{
							num = (short)1665007621;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_3DE;
								case 1:
								{
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting consoleAliasesListSetting;
									text2 = consoleAliasesListSetting.value;
									num = (short)1447755789;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting consoleAliasesListSetting;
									text = consoleAliasesListSetting.value;
									num = (short)941490190;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)937295887;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting consoleAliasesListSetting = enumerator.Current;
									num = (short)1806303248;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_120;
									}
									continue;
								case 6:
								{
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting consoleAliasesListSetting;
									if (consoleAliasesListSetting.key == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횟쎡좣펥춧", a_))
									{
										num = (short)1613365250;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_31B;
								}
								case 7:
								{
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting consoleAliasesListSetting;
									this.e.Add(consoleAliasesListSetting.key, global::System.Convert.ToChar(consoleAliasesListSetting.value, global::System.Globalization.CultureInfo.InvariantCulture));
									num = (short)520028172;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)34603019;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting consoleAliasesListSetting;
									if (consoleAliasesListSetting.type == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욟쮡좣튥춧\ud8a9", a_))
									{
										num = (short)729939978;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2042232849;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting consoleAliasesListSetting;
									this.d.Add(consoleAliasesListSetting.key, consoleAliasesListSetting.value);
									num = (short)232914947;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting consoleAliasesListSetting;
									if (consoleAliasesListSetting.key == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쮟잡\udda3", a_))
									{
										num = (short)1767047169;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1919811590;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									num = (short)1191772160;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting consoleAliasesListSetting;
									if (consoleAliasesListSetting.type == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쮟잡\udda3킥즧용\ud9ab쮭", a_))
									{
										num = (short)691798024;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_31B;
								}
								case 17:
								{
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting consoleAliasesListSetting;
									if (consoleAliasesListSetting.type == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쒟잡좣쾥얧쎩\ud8ab쮭슯", a_))
									{
										num = (short)1463943175;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_20B:
								num = (short)612171780;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_120:
								goto IL_20B;
								IL_31B:
								num = (short)1227030537;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_3DE:;
						}
						finally
						{
							num = (short)528941056;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_412;
									}
									continue;
								case 1:
									goto IL_449;
								case 2:
									enumerator.Dispose();
									num = (short)224985089;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_412:
								if (enumerator == null)
								{
									break;
								}
								num = (short)466550786;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_449:;
						}
						break;
					}
					}
					break;
				}
				this.b = text.Split(new string[]
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc9f\udea1", a_)
				}, global::System.StringSplitOptions.RemoveEmptyEntries);
				this.c = text2.Split(new string[]
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc9f\udea1", a_)
				}, global::System.StringSplitOptions.RemoveEmptyEntries);
				this.a();
			}
			catch (global::System.Exception)
			{
			}
			num = (short)2026373120;
			short num4 = num;
			num = (short)249167873;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0003549C File Offset: 0x0003369C
		public global::System.Collections.Generic.IDictionary<string, string> getUnitIdAndSortedAliasDict()
		{
			short num = (short)1997668352;
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
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_133;
					case 1:
					{
						global::System.Collections.Generic.IDictionary<string, string> unitIdAndAliasDict;
						if (unitIdAndAliasDict.Count == 0)
						{
							num = (short)1867513858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)602734595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return dictionary;
					case 3:
					{
						global::System.Collections.Generic.IDictionary<string, string> unitIdAndAliasDict;
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator = unitIdAndAliasDict.OrderBy(delegate(global::System.Collections.Generic.KeyValuePair<string, string> di)
						{
							short num5 = (short)1721756129;
							short num6 = num5;
							num5 = (short)757131745;
							switch (num6 == num5)
							{
							}
							num5 = (short)1951531008;
							if (num5 != 0)
							{
							}
							num5 = (short)1543766017;
							if (num5 != 0)
							{
							}
							num5 = (short)719519744;
							short num7 = num5;
							return di.Key;
						}).GetEnumerator();
						num = (short)686817280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_3E;
				}
				return dictionary;
				IL_3E:
				num = (short)1636231152;
				short num3 = num;
				num = (short)1823598576;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_133:
					num = (short)1505099777;
					if (num != 0)
					{
					}
					try
					{
						num = (short)66256896;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_198;
								}
								continue;
							case 1:
								goto IL_20F;
							case 3:
							{
								global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)536150020;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<string, string> item = enumerator.Current;
								dictionary.Add(item);
								num = (short)557449218;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)731906049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1BF:
							num = (short)158072835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_198:
							goto IL_1BF;
						}
						IL_20F:;
					}
					finally
					{
						num = (short)361693184;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_243;
								}
								continue;
							case 1:
								goto IL_27B;
							case 2:
								enumerator.Dispose();
								num = (short)1890451457;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_243:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1164378114;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_27B:;
					}
					num = (short)244449280;
					short num4 = num;
					return dictionary;
				}
				default:
				{
					num = (short)1072496640;
					if (num != 0)
					{
					}
					dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
					global::System.Collections.Generic.IDictionary<string, string> unitIdAndAliasDict = this.getUnitIdAndAliasDict();
					num = (short)70189057;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
				break;
			}
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00035760 File Offset: 0x00033960
		public global::System.Collections.Generic.IDictionary<string, string> getUnitIdAndAliasDict()
		{
			short num = (short)1249576935;
			short num2 = num;
			num = (short)927205351;
			global::System.Collections.Generic.IDictionary<string, string> result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1665400833;
				if (num != 0)
				{
				}
				num = (short)738459648;
				if (num != 0)
				{
				}
				num = (short)586743808;
				short num3 = num;
				global::System.Data.DataTable dataTable = this.b(global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVProvider.a, true);
				try
				{
					result = this.b(dataTable);
				}
				finally
				{
					num = (short)1234042880;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_E5;
							}
							continue;
						case 1:
							goto IL_119;
						case 2:
							((global::System.IDisposable)dataTable).Dispose();
							num = (short)541392897;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E5:
						if (dataTable == null)
						{
							break;
						}
						num = (short)875560962;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_119:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0003589C File Offset: 0x00033A9C
		public global::System.Collections.Specialized.NameValueCollection getUnitIdAndAliasList()
		{
			short num = (short)898826241;
			if (num != 0)
			{
			}
			num = (short)1613000287;
			short num2 = num;
			num = (short)592146015;
			global::System.Collections.Specialized.NameValueCollection result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1272643584;
				if (num != 0)
				{
				}
				num = (short)55902208;
				short num3 = num;
				global::System.Data.DataTable dataTable = this.b(global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVProvider.a, true);
				try
				{
					result = this.a(dataTable);
				}
				finally
				{
					num = (short)1099628544;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_E8;
							}
							continue;
						case 1:
							goto IL_11C;
						case 2:
							((global::System.IDisposable)dataTable).Dispose();
							num = (short)1683226625;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E8:
						if (dataTable == null)
						{
							break;
						}
						num = (short)206962690;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_11C:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000359DC File Offset: 0x00033BDC
		private global::System.Data.DataColumn a(global::System.Data.DataTable A_0, string[] A_1)
		{
			short num = (short)1806106624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				global::System.Data.DataColumn dataColumn;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (A_0 != null)
						{
							num = (short)517210114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dataColumn;
					case 1:
						try
						{
							num = (short)1864695816;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::System.Data.DataColumn dataColumn2;
									dataColumn = dataColumn2;
									num = (short)84213760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1697316868;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (dataColumn == null)
									{
										num = (short)1825243146;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_265;
								case 5:
									goto IL_D3;
								case 7:
								{
									int num3;
									if (num3 >= A_1.Length)
									{
										num = (short)1483145222;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = A_1[num3];
									num = (short)184811532;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_CE;
									}
									continue;
								case 9:
									goto IL_D3;
								case 10:
								{
									int num3 = 0;
									num = (short)321781765;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1915682818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Data.DataColumn dataColumn2 = (global::System.Data.DataColumn)enumerator.Current;
									num = (short)670236675;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									global::System.Data.DataColumn dataColumn2;
									string text;
									if (dataColumn2.ColumnName.Trim().ToUpperInvariant() == text.ToUpperInvariant())
									{
										num = (short)1054670849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num3;
									num3++;
									num = (short)675545097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_CE;
								IL_D3:
								num = (short)1052639239;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_171:
								num = (short)472121355;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CE:
								goto IL_171;
							}
							IL_265:
							return dataColumn;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_287;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_274:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)2027618306;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DE;
								case 1:
									goto IL_2DC;
								case 2:
									disposable.Dispose();
									num = (short)1541144577;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_287;
							}
							IL_2DC:
							IL_2DE:
							goto EndFinally_9;
							IL_287:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)812449792;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_274;
							EndFinally_9:;
						}
						goto IL_2DF;
					case 2:
						goto IL_2DF;
					}
					goto IL_3B;
					IL_2DF:
					num = (short)1968161271;
					short num4 = num;
					num = (short)653509111;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)757923841;
						if (num != 0)
						{
						}
						num = (short)1618935808;
						if (num != 0)
						{
						}
						global::System.Collections.IEnumerator enumerator = A_0.Columns.GetEnumerator();
						break;
					}
					}
					num = (short)1672609792;
					short num5 = num;
					num = (short)1853489153;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dataColumn;
				IL_3B:
				dataColumn = null;
				num = (short)470745088;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00035DAC File Offset: 0x00033FAC
		private global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> a(global::System.Data.DataTable A_0, global::System.Collections.Generic.IDictionary<string, string> A_1)
		{
			short num = (short)1193082880;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)618463232;
				short num3 = num;
				global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.DataColumn, string>();
				global::System.Collections.IEnumerator enumerator = A_0.Columns.GetEnumerator();
				try
				{
					num = (short)34406404;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_29D;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1892286466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Data.DataColumn dataColumn = (global::System.Data.DataColumn)enumerator.Current;
							global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator2 = A_1.GetEnumerator();
							num = (short)1455620099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_285;
						case 3:
							try
							{
								num = (short)1580400646;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Data.DataColumn dataColumn;
										global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
										dictionary.Add(dataColumn, keyValuePair.Value);
										num = (short)1753415684;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)821100546;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_214;
									case 3:
									{
										global::System.Data.DataColumn dataColumn;
										global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
										if (dataColumn.ColumnName.Trim() == keyValuePair.Key)
										{
											num = (short)133890048;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
										goto IL_19D;
									case 5:
									{
										global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)277020673;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator2.Current;
										num = (short)1064763395;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_13C;
										}
										continue;
									}
									IL_13E:
									num = (short)1608646661;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_13C:
									goto IL_13E;
								}
								IL_19D:
								IL_214:
								break;
							}
							finally
							{
								num = (short)1884356610;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> enumerator2;
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)1660092417;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_282;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_24B;
										}
										continue;
									}
									IL_24B:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1912340480;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_282:;
							}
							goto IL_285;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_95;
							}
							continue;
						}
						IL_C2:
						num = (short)1798045697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_95:
						goto IL_C2;
						IL_285:
						num = (short)51707904;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_29D:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_2BF;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_2AC:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)1518534657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_38E;
						case 2:
						{
							num = (short)581602227;
							short num4 = num;
							num = (short)276466611;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)1963524097;
								if (num != 0)
								{
								}
								num = (short)654835712;
								if (num != 0)
								{
								}
								if (disposable != null)
								{
									num = (short)1653538816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_390;
							}
							break;
						}
						}
						goto IL_2BF;
					}
					IL_38E:
					IL_390:
					goto EndFinally_11;
					IL_2BF:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)497680386;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_2AC;
					EndFinally_11:;
				}
				return dictionary;
			}
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00036180 File Offset: 0x00034380
		private void a(ref string A_0, ref string A_1, global::System.Data.DataRow A_2, global::System.Data.DataColumn A_3, global::System.Data.DataColumn A_4, global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> A_5)
		{
			short num = (short)1977942027;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::System.Data.DataColumn, string>> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_2AF;
				case 1:
					num = (short)1300955143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					num = (short)1156579336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (A_4 != null)
					{
						num = (short)1784152065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					num = (short)465174532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)2037252105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (A_5 != null)
					{
						num = (short)481165315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_30D;
				case 8:
					if (A_5.Count > 0)
					{
						num = (short)339607552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_30D;
				case 9:
					if (A_3 != null)
					{
						num = (short)1177223173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					try
					{
						num = (short)660471814;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							num = (short)1231064892;
							short num3 = num;
							num = (short)159682364;
							global::System.Collections.Generic.KeyValuePair<global::System.Data.DataColumn, string> keyValuePair;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1606942720;
								if (num != 0)
								{
								}
								switch (num2)
								{
								case 0:
									goto IL_1FC;
								case 1:
									A_0 = A_2[A_3].ToString();
									A_1 = A_2[A_4].ToString();
									num = (short)1200947200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_219;
								case 3:
									num = (short)659619842;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)989528067;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									keyValuePair = enumerator.Current;
									num = (short)120979461;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_148;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_127;
									}
									continue;
								}
								IL_127:
								goto IL_18B;
							}
							IL_148:
							if (A_2[keyValuePair.Key].ToString().ToUpperInvariant() == keyValuePair.Value.ToUpperInvariant())
							{
								num = (short)1982595073;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_18B:
							num = (short)1683488772;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1FC:
						IL_219:
						return;
					}
					finally
					{
						num = (short)1196883970;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1085210625;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_283;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_24F;
								}
								continue;
							}
							IL_24F:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1633222656;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_283:
						num = (short)253886465;
						if (num != 0)
						{
						}
					}
					goto IL_2AF;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				}
				IL_55:
				if (A_2 != null)
				{
					num = (short)579403776;
					short num4 = num;
					num = (short)678952966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2AF:
				enumerator = A_5.GetEnumerator();
				num = (short)1533214730;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30D:
				A_0 = A_2[A_3].ToString();
				A_1 = A_2[A_4].ToString();
				num = (short)48234498;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000365A8 File Offset: 0x000347A8
		private global::System.Collections.Generic.IDictionary<string, string> b(global::System.Data.DataTable A_0, global::System.Data.DataColumn A_1, global::System.Data.DataColumn A_2, global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> A_3)
		{
			short num = (short)302710784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1010565121;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_71;
				}
				global::System.Collections.Generic.Dictionary<string, string> dictionary;
				for (;;)
				{
					IL_4E:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						if (A_2 != null)
						{
							num = (short)1466302466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					case 1:
						try
						{
							num = (short)697696266;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string empty;
								string empty2;
								global::System.Data.DataRow dataRow;
								switch (num2)
								{
								case 0:
									if (empty != string.Empty)
									{
										num = (short)2078933000;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									if (empty2 != string.Empty)
									{
										num = (short)442826758;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									num = (short)1263730693;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (!dictionary.ContainsKey(dataRow[A_1].ToString()))
									{
										num = (short)2131820551;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									goto IL_2E7;
								case 6:
									dictionary.Add(empty, empty2);
									num = (short)2059599873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_237;
								case 8:
								{
									num = (short)167679943;
									short num3 = num;
									num = (short)1442617287;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_237;
									default:
										num = (short)1357381632;
										if (num != 0)
										{
										}
										num = (short)1341390850;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									if (!enumerator.MoveNext())
									{
										num = (short)968818691;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									dataRow = (global::System.Data.DataRow)enumerator.Current;
									num = (short)1507524612;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_12C;
									}
									continue;
								}
								IL_14E:
								num = (short)1140064265;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12C:
								goto IL_14E;
								IL_237:
								empty = string.Empty;
								empty2 = string.Empty;
								this.a(ref empty, ref empty2, dataRow, A_1, A_2, A_3);
								num = (short)533397504;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E7:
							return dictionary;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_309;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2F6:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)198180865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_362;
								case 2:
									if (disposable != null)
									{
										num = (short)980811776;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_364;
								}
								goto IL_309;
							}
							IL_362:
							IL_364:
							goto EndFinally_11;
							IL_309:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1322909698;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2F6;
							EndFinally_11:;
						}
						goto IL_365;
					case 2:
						goto IL_365;
					case 3:
						num = (short)1619525632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (A_1 != null)
						{
							num = (short)1762131971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					case 5:
						num = (short)1984954372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (A_0 != null)
						{
							num = (short)1141702661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					}
					goto IL_71;
					IL_365:
					enumerator = A_0.Rows.GetEnumerator();
					num = (short)546242561;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dictionary;
				IL_71:
				num = (short)263454720;
				short num4 = num;
				dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
				num = (short)1634598918;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4E;
			}
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000369D8 File Offset: 0x00034BD8
		private global::System.Collections.Specialized.NameValueCollection a(global::System.Data.DataTable A_0, global::System.Data.DataColumn A_1, global::System.Data.DataColumn A_2, global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> A_3)
		{
			short num = (short)1761017856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				global::System.Collections.Specialized.NameValueCollection nameValueCollection;
				for (;;)
				{
					IL_27:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						if (A_2 != null)
						{
							num = (short)1710948354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return nameValueCollection;
					case 1:
						try
						{
							num = (short)637206536;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)569835523;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_286;
								case 2:
								{
									string empty;
									if (empty != string.Empty)
									{
										num = (short)676593665;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_198;
								}
								case 3:
									goto IL_2A5;
								case 4:
									goto IL_198;
								case 5:
								{
									string empty;
									string empty2;
									nameValueCollection.Add(empty, empty2);
									num = (short)412483588;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									string empty2;
									if (empty2 != string.Empty)
									{
										num = (short)751435781;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_198;
								}
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)427294720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Data.DataRow a_ = (global::System.Data.DataRow)enumerator.Current;
									string empty = string.Empty;
									string empty2 = string.Empty;
									this.a(ref empty, ref empty2, a_, A_1, A_2, A_3);
									num = (short)398327810;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_126;
									}
									continue;
								}
								goto IL_126;
								IL_198:
								num = (short)115343367;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_126:
								num = (short)1661188362;
								short num3 = num;
								num = (short)199670026;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_286:
									num = (short)1548812294;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)1123155968;
									if (num != 0)
									{
									}
									goto IL_198;
								}
							}
							IL_2A5:
							return nameValueCollection;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2C7;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2B4:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1785135105;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_31C;
								case 2:
									if (disposable != null)
									{
										num = (short)1729232896;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_31E;
								}
								goto IL_2C7;
							}
							IL_31C:
							IL_31E:
							goto EndFinally_10;
							IL_2C7:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)2082078722;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2B4;
							EndFinally_10:;
						}
						goto IL_31F;
					case 2:
						goto IL_31F;
					case 3:
						num = (short)772079616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (A_1 != null)
						{
							num = (short)528547843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return nameValueCollection;
					case 5:
						num = (short)908984324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (A_0 != null)
						{
							num = (short)646578181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return nameValueCollection;
					}
					goto IL_4A;
					IL_31F:
					enumerator = A_0.Rows.GetEnumerator();
					num = (short)458031105;
					num2 = (int)((global::System.IntPtr)num);
				}
				return nameValueCollection;
				IL_4A:
				num = (short)472842241;
				if (num != 0)
				{
				}
				num = (short)1320550400;
				short num4 = num;
				nameValueCollection = new global::System.Collections.Specialized.NameValueCollection();
				num = (short)1134886918;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00036DBC File Offset: 0x00034FBC
		private global::System.Collections.Generic.IDictionary<string, string> b(global::System.Data.DataTable A_0)
		{
			short num = (short)521305977;
			short num2 = num;
			num = (short)1785167737;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1084162048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)448856065;
			if (num != 0)
			{
			}
			num = (short)1236860928;
			if (num != 0)
			{
			}
			global::System.Data.DataColumn a_ = this.a(A_0, this.c);
			global::System.Data.DataColumn a_2 = this.a(A_0, this.b);
			global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> a_3 = this.a(A_0, this.d);
			return this.b(A_0, a_, a_2, a_3);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00036E98 File Offset: 0x00035098
		private global::System.Collections.Specialized.NameValueCollection a(global::System.Data.DataTable A_0)
		{
			short num = (short)1521482620;
			short num2 = num;
			num = (short)1846016892;
			switch (num2 == num)
			{
			default:
			{
				num = (short)454033408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1838809088;
			if (num != 0)
			{
			}
			num = (short)321847297;
			if (num != 0)
			{
			}
			global::System.Data.DataColumn a_ = this.a(A_0, this.c);
			global::System.Data.DataColumn a_2 = this.a(A_0, this.b);
			global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> a_3 = this.a(A_0, this.d);
			return this.a(A_0, a_, a_2, a_3);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00036F78 File Offset: 0x00035178
		private string g(string csvFilePath)
		{
			short num = (short)894510882;
			short num2 = num;
			num = (short)1762666274;
			string result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)1334968320;
				short num3 = num;
				break;
			}
			}
			num = (short)765657088;
			if (num != 0)
			{
			}
			num = (short)148963329;
			if (num != 0)
			{
			}
			result = string.Empty;
			global::System.IO.FileStream fileStream = new global::System.IO.FileStream(csvFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.ReadWrite);
			try
			{
				result = new global::System.IO.StreamReader(fileStream, global::System.Text.Encoding.Default).ReadToEnd();
			}
			finally
			{
				num = (short)1381629952;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_EE;
						}
						continue;
					case 1:
						((global::System.IDisposable)fileStream).Dispose();
						num = (short)1231159298;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_121;
					}
					IL_EE:
					if (fileStream == null)
					{
						break;
					}
					num = (short)33619969;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_121:;
			}
			return result;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000370BC File Offset: 0x000352BC
		private global::System.Data.DataTable b(string csvFilePath, bool isFirstRowHeader)
		{
			short num = (short)1136294022;
			short num2 = num;
			num = (short)1347254406;
			global::System.Data.DataTable result;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AE:
				if (!global::System.IO.File.Exists(csvFilePath))
				{
					return result;
				}
				num = (short)1866924032;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1935671296;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				break;
			}
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
				{
					string text = this.g(csvFilePath);
					num = (short)1180041216;
					short num4 = num;
					num = (short)722468865;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					string text;
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)675545092;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				case 2:
					goto IL_AE;
				case 3:
					goto IL_F0;
				case 4:
				{
					string text;
					result = this.a(text, isFirstRowHeader);
					num = (short)1654718467;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_6F;
			}
			IL_F0:
			return result;
			IL_6F:
			num = (short)250937345;
			if (num != 0)
			{
			}
			result = null;
			num = (short)1515323394;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0003722C File Offset: 0x0003542C
		public bool isCsvValid()
		{
			short num = (short)1033334495;
			short num2 = num;
			num = (short)1696427743;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1819738112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)725155841;
			if (num != 0)
			{
			}
			num = (short)255524864;
			if (num != 0)
			{
			}
			return this.f(global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVProvider.a);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000372E4 File Offset: 0x000354E4
		private bool f(string csvFilePath)
		{
			short num = (short)1627521025;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)851443712;
						short num3 = num;
						num = (short)991363075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					num = (short)1560543233;
					if (num != 0)
					{
					}
					text = this.g(csvFilePath);
					num = (short)37879808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)443936721;
					short num4 = num;
					num = (short)142733265;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_12C;
					}
					break;
				}
				}
				IL_35:
				if (!global::System.IO.File.Exists(csvFilePath))
				{
					return false;
				}
				num = (short)1870790658;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12C:
			num = (short)999096320;
			if (num != 0)
			{
			}
			return this.d(text);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0003743C File Offset: 0x0003563C
		private void b(ref global::System.Data.DataTable A_0, string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			int num2;
			string[] array;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_178;
				case 2:
					goto IL_178;
				case 3:
				{
					if (num2 >= array.Length)
					{
						num3 = (short)1808465920;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)298582016;
					short num4 = num3;
					num3 = (short)374734853;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 4:
				{
					num3 = (short)1941924761;
					short num5 = num3;
					num3 = (short)673475481;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_111;
					default:
						num3 = (short)368312320;
						if (num3 != 0)
						{
						}
						A_0.Columns.Add(array[num2]);
						num3 = (short)399179782;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 5:
					num3 = (short)824442881;
					if (num3 != 0)
					{
					}
					if (!A_0.Columns.Contains(array[num2]))
					{
						goto IL_111;
					}
					goto IL_51;
				case 6:
					goto IL_51;
				}
				goto IL_2C;
				IL_51:
				num2++;
				num3 = (short)1770061825;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_111:
				num3 = (short)1160773636;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_178:
				num3 = (short)1691418627;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_2C:
			array = null;
			array = this.c(A_1);
			num2 = 0;
			num3 = (short)153092098;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000375FC File Offset: 0x000357FC
		private global::System.Data.DataRow a(ref global::System.Data.DataTable A_0, string A_1)
		{
			short num = (short)1242890240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)607059969;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				string[] array;
				for (;;)
				{
					IL_4F:
					switch (num2)
					{
					case 0:
						goto IL_1C4;
					case 1:
						if (A_0.Columns.Count < array.Length)
						{
							num = (short)1000210437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C9;
					case 2:
					{
						int num3;
						int num4;
						if (num3 >= num4)
						{
							num = (short)45744132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_0.Columns.Add();
						num3++;
						num = (short)823978437;
						short num5 = num;
						num = (short)479783365;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C4;
						default:
							num = (short)1820459008;
							if (num != 0)
							{
							}
							num = (short)578945027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_BC;
					case 4:
						goto IL_11B;
					case 5:
					{
						int num4 = array.Length - A_0.Columns.Count;
						int num3 = 0;
						num = (short)213975040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6E;
					IL_BC:
					num = (short)1679228928;
					short num6 = num;
					num = (short)348979202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C4:
					goto IL_BC;
				}
				IL_11B:
				IL_1C9:
				global::System.Data.DataRowCollection rows = A_0.Rows;
				object[] values = array;
				return rows.Add(values);
				IL_6E:
				array = null;
				array = this.c(A_1);
				num = (short)947126273;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000377E4 File Offset: 0x000359E4
		private string[] e(string csv)
		{
			int a_ = 5;
			short num = (short)591331328;
			short num2 = num;
			num = (short)1379074049;
			if (num != 0)
			{
			}
			num = (short)831590702;
			short num3 = num;
			num = (short)2058883374;
			switch (num3 == num)
			{
			}
			num = (short)1749090304;
			if (num != 0)
			{
			}
			return csv.Split(new string[]
			{
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("醛钝", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("際", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("醛", a_)
			}, global::System.StringSplitOptions.RemoveEmptyEntries);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000378D8 File Offset: 0x00035AD8
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1306:SetLocaleForDataTypes")]
		private bool d(string csv)
		{
			short num = (short)625999872;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8A;
				}
				global::System.Data.DataTable dataTable;
				for (;;)
				{
					IL_27:
					int num3;
					switch (num2)
					{
					case 0:
					{
						string[] array;
						this.b(ref dataTable, array[0]);
						array[0] = null;
						global::System.Data.DataColumn dataColumn = this.a(dataTable, this.c);
						global::System.Data.DataColumn dataColumn2 = this.a(dataTable, this.b);
						num = (short)133496850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1685258251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_21C;
					case 3:
					{
						dataTable = new global::System.Data.DataTable();
						string[] array = this.e(csv);
						num = (short)2007957505;
						if (num != 0)
						{
						}
						num = (short)125632532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1647116309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_358;
					case 6:
						if (dataTable != null)
						{
							num = (short)2025390089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
					{
						string empty;
						if (empty != string.Empty)
						{
							num = (short)523108368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29A;
					}
					case 8:
						goto IL_2DE;
					case 9:
						dataTable.Dispose();
						num = (short)925499400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						string empty2;
						if (empty2 != string.Empty)
						{
							num = (short)1804599315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29A;
					}
					case 11:
					{
						string[] array;
						if (array.Length != 0)
						{
							num = (short)1983250432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35D;
					}
					case 12:
					{
						string[] array;
						if (num3 >= array.Length)
						{
							num = (short)126222358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1662124046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (!string.IsNullOrEmpty(csv))
						{
							num = (short)1571028995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 14:
					{
						string[] array;
						if (array[num3] != null)
						{
							num = (short)874381327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29A;
					}
					case 15:
					{
						string[] array;
						global::System.Data.DataRow a_ = this.a(ref dataTable, array[num3]);
						string empty = string.Empty;
						string empty2 = string.Empty;
						global::System.Data.DataColumn dataColumn;
						global::System.Data.DataColumn dataColumn2;
						global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> a_2;
						this.a(ref empty, ref empty2, a_, dataColumn, dataColumn2, a_2);
						num = (short)1142173612;
						short num4 = num;
						num = (short)1545023404;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_358;
						default:
							num = (short)152109056;
							if (num != 0)
							{
							}
							num = (short)1006239751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
					{
						num = (short)2027028480;
						short num5 = num;
						num = (short)1248460810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_21C;
					case 18:
					{
						global::System.Data.DataColumn dataColumn;
						if (dataColumn != null)
						{
							num = (short)516751364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 19:
						return true;
					case 20:
					{
						string[] array;
						if (array != null)
						{
							num = (short)88145921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35D;
					}
					case 21:
					{
						global::System.Data.DataColumn dataColumn2;
						if (dataColumn2 == null)
						{
							num = (short)1471021061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IDictionary<global::System.Data.DataColumn, string> a_2 = this.a(dataTable, this.d);
						num3 = 0;
						num = (short)1189543938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_35D;
					}
					goto IL_8A;
					IL_21C:
					num = (short)1915355148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29A:
					num3++;
					num = (short)1071972369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35D:
					num = (short)1804140550;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2DE:
				return false;
				IL_358:
				return false;
				IL_8A:
				dataTable = null;
				num = (short)1113784333;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00037D68 File Offset: 0x00035F68
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1306:SetLocaleForDataTypes")]
		private global::System.Data.DataTable a(string csv, bool isFirstRowHeader)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			global::System.Data.DataTable result;
			for (;;)
			{
				IL_0A:
				string[] array;
				int num3;
				switch (num)
				{
				case 0:
					num2 = (short)2021261314;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					this.b(ref result, array[0]);
					array[0] = null;
					num2 = (short)1819803661;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_112;
				case 3:
					result = new global::System.Data.DataTable();
					array = this.e(csv);
					num2 = (short)2087125000;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_24C;
				case 5:
					if (isFirstRowHeader)
					{
						num2 = (short)2066284545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DB;
				case 6:
					if (!string.IsNullOrEmpty(csv))
					{
						num2 = (short)361562115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 7:
					num2 = (short)767492097;
					if (num2 != 0)
					{
					}
					this.a(ref result, array[num3]);
					num2 = (short)1869938699;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					num2 = (short)25808307;
					short num4 = num2;
					num2 = (short)967101875;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_112;
					default:
					{
						num2 = (short)861863936;
						if (num2 != 0)
						{
						}
						num2 = (short)224067584;
						short num5 = num2;
						if (array != null)
						{
							num2 = (short)434700288;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 9:
					if (num3 >= array.Length)
					{
						num2 = (short)369033228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1267204110;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_24C;
				case 11:
					goto IL_135;
				case 12:
					return result;
				case 13:
					goto IL_DB;
				case 14:
					if (array[num3] != null)
					{
						num2 = (short)212336647;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_135;
				case 15:
					num2 = (short)1277755397;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_50;
				IL_DB:
				num3 = 0;
				num2 = (short)907935748;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_112:
				if (array.Length != 0)
				{
					num2 = (short)327417871;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				break;
				IL_135:
				num3++;
				num2 = (short)512622602;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_24C:
				num2 = (short)771031049;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_50:
			result = null;
			num2 = (short)1053884422;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0003805C File Offset: 0x0003625C
		private void a()
		{
			int a_ = 0;
			short num = (short)1221984257;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_53;
			}
			for (;;)
			{
				IL_39:
				int num2;
				switch (num2)
				{
				case 0:
					if (this.e.Count > 0)
					{
						num = (short)949026820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18C;
				case 1:
					goto IL_187;
				case 2:
					if (this.e.ContainsKey(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﲘﶚﲜ춠힢", a_)))
					{
						num = (short)2132082689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18C;
				case 3:
					goto IL_10F;
				case 4:
					num = (short)1486028802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_53;
			}
			IL_10F:
			num = (short)1958739968;
			short num3 = num;
			goto IL_18C;
			IL_187:
			goto IL_DE;
			IL_18C:
			char c;
			this.f = c;
			return;
			IL_53:
			c = ',';
			num = (short)207389330;
			short num4 = num;
			num = (short)1783071378;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_DE:
				c = this.e[global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﲘﶚﲜ춠힢", a_)];
				num = (short)1959395331;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_39;
			}
			default:
			{
				num = (short)1550319616;
				if (num != 0)
				{
				}
				num = (short)2039414784;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_39;
			}
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000381FC File Offset: 0x000363FC
		private string[] c(string csv)
		{
			short num = (short)12648448;
			short num2 = num;
			num = (short)1951989761;
			if (num != 0)
			{
			}
			num = (short)1824154679;
			short num3 = num;
			num = (short)1837458487;
			switch (num3 == num)
			{
			}
			num = (short)436338688;
			if (num != 0)
			{
			}
			return this.a(csv, this.f);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000382B0 File Offset: 0x000364B0
		private string[] a(string A_0, char A_1)
		{
			short num = (short)33554432;
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
					int num5;
					int num6;
					switch (num2)
					{
					case 0:
						num = (short)1200750613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int num3 = 0;
						int num4 = 0;
						string text = string.Empty;
						num5 = 0;
						num = (short)2137325601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1963917348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71B;
					}
					case 3:
						if (A_0[num5] == '"')
						{
							num = (short)503840803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)802029576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)285868055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1752301570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_5A0;
					case 7:
						goto IL_6D6;
					case 8:
						goto IL_4AC;
					case 9:
					{
						string text2;
						if (num6 == text2.Length - 1)
						{
							num = (short)1728708633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2;
					}
					case 10:
						if (num5 == A_0.Length - 1)
						{
							num = (short)1034813467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_608;
					case 11:
					{
						int num4;
						num4++;
						num = (short)2114781191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_3F4;
					case 13:
					{
						int num3;
						string text2;
						list.Add(this.a(this.b(text2.Substring(num3, num6 - num3))));
						num3 = num6 + 1;
						num = (short)1542717466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_2F5;
					case 15:
						goto IL_608;
					case 16:
					{
						string text2;
						if (text2[num6] == '"')
						{
							num = (short)309919755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1157038111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						int num3;
						string text2;
						list.Add(this.a(this.b(text2.Substring(num3, num6 - num3 + 1))));
						num3 = num6 + 1;
						num = (short)1535574050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_2F5;
					case 19:
						goto IL_451;
					case 20:
						if (num5 >= A_0.Length)
						{
							num = (short)869269509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1402601475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						int num4;
						if (num4 % 2 == 0)
						{
							num = (short)922025997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D6;
					}
					case 22:
					{
						string text2;
						if (num6 >= text2.Length)
						{
							num = (short)2047606822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1653145616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						int num4;
						if (num4 % 2 == 0)
						{
							num = (short)634781728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_451;
					}
					case 24:
					{
						int num3;
						if (num3 < A_0.Length)
						{
							num = (short)32374821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_608;
					}
					case 25:
						num = (short)2098987038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						num = (short)2029034042;
						short num7 = num;
						num = (short)1267309114;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4AC;
						default:
							num = (short)1067581440;
							if (num != 0)
							{
							}
							goto IL_6D6;
						}
						break;
					}
					case 27:
						num = (short)1178599448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_451;
					case 29:
						if (!string.IsNullOrEmpty(A_0))
						{
							num = (short)1955397633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71B;
					case 30:
					{
						int num3;
						string text2;
						if (num3 < text2.Length)
						{
							num = (short)2049245201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2;
					}
					case 31:
					{
						string text2;
						if (text2[num6] == A_1)
						{
							num = (short)1097662464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D6;
					}
					case 32:
					{
						num = (short)1117388801;
						if (num != 0)
						{
						}
						int num3;
						list2.Add(this.a(A_0.Substring(num3, num5 - num3)));
						num3 = num5 + 1;
						num = (short)2011824156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						goto IL_5A0;
					case 34:
						goto IL_3A2;
					case 35:
					{
						int num4;
						num4++;
						num = (short)1960116243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
					{
						int num3 = 0;
						int num4 = 0;
						string text;
						string text2 = this.b(text);
						num6 = 0;
						num = (short)319488014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
					{
						int num3;
						string text = A_0.Substring(num3, num5 - num3 + 1);
						num = (short)574619663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
					{
						string[] array = list.ToArray();
						global::System.Array.Reverse(array);
						list2.AddRange(array);
						num = (short)1919680524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_CA;
					IL_2F5:
					num = (short)129630230;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A2:
					num6++;
					num = (short)1142947858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_451:
					num = (short)98369546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AC:
					if (A_0[num5] == A_1)
					{
						num = (short)1272774660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_451;
					IL_5A0:
					num = (short)339673088;
					short num8 = num;
					num = (short)1414856724;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_608:
					num5++;
					num = (short)842727430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D6:
					num = (short)1501298697;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3F4:
				IL_71B:
				return list2.ToArray();
				IL_CA:
				list2 = new global::System.Collections.Generic.List<string>();
				list = new global::System.Collections.Generic.List<string>();
				num = (short)427163677;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000389E0 File Offset: 0x00036BE0
		private string b(string str)
		{
			short num = (short)675151872;
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
						goto IL_60;
					case 1:
						goto IL_60;
					case 2:
					{
						num = (short)440197681;
						short num3 = num;
						num = (short)129032753;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)533004288;
							if (num != 0)
							{
							}
							if (num4 >= str.Length)
							{
								num = (short)1779695619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = str[num4].ToString() + text;
							num4++;
							break;
						}
						num = (short)1847459840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_10A;
					}
					goto IL_3F;
					IL_60:
					num = (short)446496769;
					if (num != 0)
					{
					}
					num = (short)991494146;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10A:
				num = (short)92798976;
				short num5 = num;
				return text;
				IL_3F:
				text = string.Empty;
				num4 = 0;
				num = (short)434700289;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00038B5C File Offset: 0x00036D5C
		private string a(string csvValue)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			string text;
			global::System.Text.RegularExpressions.Match match;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return text;
				case 1:
					return text;
				case 2:
					text = match.Result(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("莦튨骪킬", a_)).Replace(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("薦讨", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("薦", a_));
					num2 = (short)1141637121;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!string.IsNullOrEmpty(csvValue))
					{
						num2 = (short)1209860100;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 4:
					goto IL_106;
				case 5:
					if (match.Success)
					{
						num2 = (short)1452343298;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = text.Replace(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("薦讨", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("薦", a_));
					num2 = (short)535625728;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_31;
			}
			IL_106:
			match = global::System.Text.RegularExpressions.Regex.Match(csvValue, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("簾讨莪莬薮躰骲鞴鎶", a_));
			goto IL_1AE;
			IL_31:
			text = csvValue;
			num2 = (short)345047041;
			if (num2 != 0)
			{
			}
			num2 = (short)249506612;
			short num3 = num2;
			num2 = (short)1851796276;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1AE:
				num2 = (short)1492058117;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			case 1:
				break;
			default:
			{
				num2 = (short)671350784;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)860880896;
			if (num2 != 0)
			{
			}
			num2 = (short)1820065795;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00038D58 File Offset: 0x00036F58
		public static global::System.Collections.Generic.IList<string> ParseTrunkSystemInfo(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary> tempResult, ref string systemId, ref string homeWacnId, ref global::System.Collections.Generic.IList<string> result)
		{
			int a_ = 17;
			short num = (short)1981612032;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IList<string> list = new global::System.Collections.Generic.List<string>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary> enumerator = tempResult.GetEnumerator();
				try
				{
					num = (short)437256194;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_3D5;
						case 1:
							num = (short)295370752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2C2;
							}
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1512570881;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary apxsystemInfoSummary = enumerator.Current;
							list.Add(string.Concat(new string[]
							{
								apxsystemInfoSummary.SystemSubType.ToString(),
								global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("薧", a_),
								apxsystemInfoSummary.SystemName,
								global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("薧", a_),
								apxsystemInfoSummary.SystemId.ToString(),
								global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("薧", a_),
								apxsystemInfoSummary.HomeWacnId.ToString()
							}));
							num = (short)1682440196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_2C7:
						num = (short)1186267139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C2:
						goto IL_2C7;
					}
					IL_3D5:
					goto IL_278;
				}
				finally
				{
					num = (short)1709560633;
					short num3 = num;
					num = (short)599380793;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)574947328;
						if (num != 0)
						{
						}
						num = (short)855375873;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)370802690;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_459;
								}
								continue;
							case 2:
								goto IL_48E;
							}
							IL_459:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1916338176;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
					}
					IL_48E:;
				}
				goto IL_491;
				for (;;)
				{
					IL_278:
					int num4 = 0;
					global::System.Collections.Generic.IEnumerator<string> enumerator2 = list.GetEnumerator();
					try
					{
						num = (short)1628504064;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_86;
								}
								continue;
							case 1:
								goto IL_8B;
							case 2:
								if (num4 == 0)
								{
									num = (short)1677918212;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_8B;
							case 3:
							{
								string text;
								result.Add(text.Split(new char[]
								{
									'-'
								})[1]);
								num = (short)1773207554;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								string text;
								systemId = text.Split(new char[]
								{
									'-'
								})[2];
								homeWacnId = text.Split(new char[]
								{
									'-'
								})[3];
								num = (short)2036465665;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_206;
							case 6:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)1721696264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string text = enumerator2.Current;
								num = (short)1935015945;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								num = (short)520814597;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
							{
								string text;
								if (text.Split(new char[]
								{
									'-'
								})[0] == 4.ToString(global::System.Globalization.CultureInfo.InvariantCulture))
								{
									num = (short)198639619;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							goto IL_86;
							IL_8B:
							num4++;
							num = (short)1773535239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A7:
							num = (short)1082654726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_86:
							goto IL_A7;
						}
						IL_206:
						break;
					}
					finally
					{
						num = (short)1628962817;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator2.Dispose();
								num = (short)777650178;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_23D;
								}
								continue;
							case 2:
								goto IL_275;
							}
							IL_23D:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)1887567872;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_275:;
					}
				}
				IL_491:
				num = (short)1786576897;
				if (num != 0)
				{
				}
				num = (short)455475200;
				short num5 = num;
				result.Add(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("钧\ud9ab\uddad쒯\uddb1\ud9b3\udfb5슷\udfb9\ud8bb肽", a_));
				return list;
			}
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00039290 File Offset: 0x00037490
		// Note: this type is marked as 'beforefieldinit'.
		static CSVProvider()
		{
			short num = (short)36178886;
			short num2 = num;
			num = (short)1128074182;
			switch (num2 == num)
			{
			}
			num = (short)1427374080;
			if (num != 0)
			{
			}
			num = (short)1316945921;
			if (num != 0)
			{
			}
			num = (short)1698234368;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVProvider.a = string.Empty;
		}

		// Token: 0x04000043 RID: 67
		private static string a;

		// Token: 0x04000044 RID: 68
		private string[] b;

		// Token: 0x04000045 RID: 69
		private string[] c;

		// Token: 0x04000046 RID: 70
		private global::System.Collections.Generic.IDictionary<string, string> d;

		// Token: 0x04000047 RID: 71
		private global::System.Collections.Generic.IDictionary<string, char> e;

		// Token: 0x04000048 RID: 72
		private char f = ',';

		// Token: 0x04000049 RID: 73
		private static global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVProvider g;
	}
}
