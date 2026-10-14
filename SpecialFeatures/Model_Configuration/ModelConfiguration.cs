using System;
using System.Collections.Generic;
using System.Reflection;
using AcpCommonLib;
using AcpModelTieringLib;
using AcpUtility;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.Model_Configuration
{
	// Token: 0x020000AC RID: 172
	public class ModelConfiguration
	{
		// Token: 0x06000B95 RID: 2965 RVA: 0x000DF7C0 File Offset: 0x000DD9C0
		static ModelConfiguration()
		{
			short num = (short)1820475233;
			short num2 = num;
			num = (short)991772513;
			switch (num2 == num)
			{
			default:
			{
				num = (short)726663168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)931397633;
			if (num != 0)
			{
			}
			num = (short)1789460480;
			if (num != 0)
			{
			}
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000DF870 File Offset: 0x000DDA70
		internal ModelConfiguration(string MyModelNumber, string strTieringFileSource)
		{
			this.c = int.MaxValue;
			this.d = int.MaxValue;
			this.e = 1;
			this.f = 1;
			this.a = null;
			this.h = new global::AcpModelTieringLib.CModelTiering(strTieringFileSource);
			this.b = MyModelNumber;
			this.i = true;
			this.g = new global::System.Collections.Generic.Dictionary<string, global::System.Type>();
			this.j = new global::System.Collections.Generic.Dictionary<string, bool>();
			this.a(ref this.j);
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x000DF8EC File Offset: 0x000DDAEC
		internal global::System.Collections.Generic.Dictionary<string, bool> AllEnabledOptList
		{
			get
			{
				short num = (short)787173122;
				short num2 = num;
				num = (short)1446268674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784741888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1854668800;
				if (num != 0)
				{
				}
				num = (short)20709377;
				if (num != 0)
				{
				}
				return this.j;
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x000DF99C File Offset: 0x000DDB9C
		private bool a(string A_0)
		{
			bool flag = false;
			this.c = int.MaxValue;
			this.d = int.MaxValue;
			this.e = 1;
			this.f = 1;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_94;
				}
				int num;
				global::System.Collections.Generic.Dictionary<string, bool>.Enumerator enumerator;
				for (;;)
				{
					IL_32:
					bool flag3;
					switch (num)
					{
					case 0:
						num2 = (short)1339490323;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (this.a(A_0, ""))
						{
							num2 = (short)1571225621;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1953824774;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						this.c = int.Parse(this.h.MaxNumOfRecords);
						num2 = (short)991363089;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						try
						{
							num2 = (short)1988689928;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								bool flag2;
								switch (num)
								{
								case 1:
									flag2 = this.h.GetFieldFromTieringFile(this.a);
									goto IL_37B;
								case 2:
									if (!flag)
									{
										num2 = (short)1526333440;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_43E;
								case 3:
								{
									global::System.Collections.Generic.KeyValuePair<string, bool> keyValuePair;
									if (this.a(A_0, keyValuePair.Key))
									{
										num2 = (short)1483407365;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									num2 = (short)1730215943;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								case 4:
									goto IL_455;
								case 5:
									num2 = (short)1430781953;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num2 = (short)679739401;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, bool> keyValuePair = enumerator.Current;
									num2 = (short)542834691;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								case 7:
									flag2 = false;
									goto IL_37B;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_335;
									}
									continue;
								case 9:
									goto IL_43E;
								}
								goto IL_335;
								IL_37B:
								flag = flag2;
								num2 = (short)579862530;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_404:
								num2 = (short)511049734;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_335:
								goto IL_404;
								IL_43E:
								num2 = (short)1130889220;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_455:;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						num2 = (short)1567358987;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						this.d = int.Parse(this.h.MaxpoolNumOfRecords);
						num2 = (short)2129657878;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (this.h.MaxpoolNumOfRecords != "")
						{
							num2 = (short)426704900;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_24A;
					case 6:
						flag3 = false;
						goto IL_2CC;
					case 7:
						this.f = int.Parse(this.h.DefaultNumOfRecords);
						num2 = (short)1053491215;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						num2 = (short)824442881;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						goto IL_180;
					case 10:
						flag3 = this.h.GetFieldFromTieringFile(this.a);
						goto IL_2CC;
					case 11:
						if (!flag)
						{
							num2 = (short)517013512;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_4BC;
					case 12:
						if (flag)
						{
							num2 = (short)1087635456;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_5A7;
					case 13:
						this.e = int.Parse(this.h.MinNumOfRecords);
						num2 = (short)538902537;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 14:
						goto IL_4BC;
					case 15:
						goto IL_5A7;
					case 16:
						if (this.h.MinNumOfRecords != "")
						{
							num2 = (short)325845005;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_180;
					case 17:
						goto IL_132;
					case 18:
						goto IL_5BE;
					case 19:
						if (this.h.MaxNumOfRecords != "")
						{
							num2 = (short)468058114;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_132;
					case 20:
						goto IL_198;
					case 21:
						num2 = (short)492306442;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 22:
					{
						num2 = (short)1316227602;
						short num3 = num2;
						num2 = (short)1044384274;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_198;
						default:
							num2 = (short)1621360640;
							if (num2 != 0)
							{
							}
							goto IL_24A;
						}
						break;
					}
					}
					goto IL_94;
					IL_132:
					num2 = (short)153681925;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_180:
					num2 = (short)1944059924;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_198:
					if (this.h.DefaultNumOfRecords != "")
					{
						num2 = (short)1061421063;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5A7;
					IL_24A:
					num2 = (short)636223504;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_2CC:
					flag = flag3;
					num2 = (short)1447821326;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_4BC:
					num2 = (short)956497932;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_5A7:
					num2 = (short)2090270738;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_5BE:
				goto IL_5C5;
				IL_94:
				enumerator = this.j.GetEnumerator();
				num2 = (short)1067646979;
				num = (int)((global::System.IntPtr)num2);
				goto IL_32;
			}
			catch (global::System.Exception)
			{
				flag = false;
			}
			IL_5C5:
			num2 = (short)1255669760;
			short num4 = num2;
			num2 = (short)1238827009;
			if (num2 != 0)
			{
			}
			return flag;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x000DFFF8 File Offset: 0x000DE1F8
		private bool a(string A_0, string A_1)
		{
			int a_ = 7;
			short num = (short)1198915585;
			if (num != 0)
			{
			}
			bool result = false;
			this.a = null;
			try
			{
				num = (short)261226498;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						result = true;
						num = (short)1752104965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_24D;
					case 2:
					{
						num = (short)1637985787;
						short num3 = num;
						num = (short)448638459;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)206831616;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_C9;
							}
							continue;
						}
						break;
					}
					case 3:
						goto IL_1FA;
					case 4:
						goto IL_1FA;
					case 5:
						goto IL_236;
					case 6:
						if (this.a != null)
						{
							num = (short)131137536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_236;
					case 7:
						this.a = string.Concat(new string[]
						{
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖉ솋랗힙瞧얟캡ﾣ욧쮩솫쮭趯閱", a_),
							this.b,
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("궉톋ꆍ횏鍊놝쮡솣쪥첧삭톯\udfb1톳讵龷", a_),
							A_0,
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("궉톋", a_)
						});
						num = (short)237895683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C9:
					if (A_1 == "")
					{
						num = (short)1886650375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a = string.Concat(new string[]
					{
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖉ솋랗힙瞧얟캡ﾣ욧쮩솫쮭趯閱", a_),
						this.b,
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("궉톋ꆍ횏鍊놝쮡솣쪥첧삭톯\udfb1톳讵龷", a_),
						A_0,
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("궉톋ꆍ\udf8fﾕ잛\ude9d캟쎡즣쎥閧趩", a_),
						A_1,
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("궉톋", a_)
					});
					num = (short)632684548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FA:
					num = (short)309067782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_236:
					num = (short)858390529;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_24D:;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			num = (short)300154880;
			short num4 = num;
			return result;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000E02A0 File Offset: 0x000DE4A0
		private void a(ref global::System.Collections.Generic.Dictionary<string, bool> A_0)
		{
			int a_ = 8;
			short num = (short)1303445504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)144506880;
				short num3 = num;
				bool flag = false;
				global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable = null;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					int num4;
					for (;;)
					{
						IL_5E:
						int num6;
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition;
							if (optionsByPosition != null)
							{
								num = (short)1306132491;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_265;
						}
						case 1:
							num4++;
							num = (short)1424621571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_25EA;
						case 3:
							goto IL_204;
						case 4:
							goto IL_1CB;
						case 5:
							try
							{
								num = (short)353501321;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::AcpCommonLib.IAcpField dbField;
									switch (num2)
									{
									case 0:
										num = (short)371720230;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										int fieldValue;
										if (fieldValue == 3)
										{
											num = (short)663879820;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 2:
									{
										int fieldValue;
										if (fieldValue == 8)
										{
											num = (short)566100077;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 3:
									{
										uint num5;
										if (num5 != 171604188U)
										{
											num = (short)370802695;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)475267285;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										int fieldValue;
										if (fieldValue == 8)
										{
											num = (short)738525391;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 5:
										num = (short)1761017955;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										goto IL_21D6;
									case 7:
										num = (short)1554448471;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										num = (short)382730243;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										global::SpecialFeatures.Flashport.FlashRadio.Option option;
										if (option.Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꖐꮒ겔ꖖ", a_))
										{
											num = (short)136446010;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 10:
									{
										uint num5;
										if (num5 != 2055636557U)
										{
											num = (short)610664650;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1792475156;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
										goto IL_21D6;
									case 12:
										num = (short)1933377637;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
									{
										uint num5;
										if (num5 != 1938193224U)
										{
											num = (short)1723858983;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1085931728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 14:
									{
										int fieldValue;
										if (fieldValue == 4)
										{
											num = (short)688914493;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 15:
										num = (short)1412956260;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 16:
										goto IL_21D6;
									case 17:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꖔ꾖", a_)))
										{
											num = (short)344850489;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1754988593;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 18:
									{
										int fieldValue;
										if (fieldValue == 5)
										{
											num = (short)584908959;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 19:
										goto IL_21D6;
									case 20:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꎖ", a_)))
										{
											num = (short)2059862166;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1398800544;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 21:
										goto IL_21D6;
									case 22:
										num = (short)1107886261;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 23:
									{
										int fieldValue;
										if (fieldValue == 6)
										{
											num = (short)1685979306;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 24:
										flag = true;
										num = (short)825950270;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 25:
										goto IL_21D6;
									case 26:
										goto IL_21D6;
									case 27:
										num = (short)1307902131;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 28:
										num = (short)1710096494;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 29:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꖔꆖ", a_)))
										{
											num = (short)1776025827;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1788084336;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 30:
										num = (short)1462632517;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 31:
										num = (short)1758855201;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 32:
										goto IL_245E;
									case 33:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꊐꎒꂔꆖ", a_)))
										{
											num = (short)1518469345;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)878903426;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 34:
										num = (short)307822728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 35:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꞖ", a_)))
										{
											num = (short)1332740123;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1286471903;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 36:
										num = (short)375783595;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 37:
										goto IL_21D6;
									case 38:
										goto IL_21D6;
									case 39:
										num = (short)866451532;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 40:
									{
										int fieldValue;
										if (fieldValue == 4)
										{
											num = (short)2112553058;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 41:
									{
										uint num5;
										if (num5 != 1770269939U)
										{
											num = (short)2147352606;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)38142048;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 42:
										flag = true;
										num = (short)673644717;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 43:
										num = (short)88867012;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 44:
										goto IL_21D6;
									case 45:
										goto IL_21D6;
									case 46:
									{
										string name;
										if (name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꆒꆔꎖ", a_))
										{
											num = (short)1213071392;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 47:
										goto IL_21D6;
									case 48:
									{
										int fieldValue;
										if (fieldValue == 4)
										{
											num = (short)1076297802;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 49:
									{
										int fieldValue;
										if (fieldValue == 2)
										{
											num = (short)252182655;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 50:
										num = (short)69533706;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 51:
										num = (short)116326406;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 52:
										flag = true;
										num = (short)310837367;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 53:
									{
										uint num5;
										if (num5 != 982331963U)
										{
											num = (short)526057523;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)422510740;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 54:
										num = (short)1887174867;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 55:
										num = (short)1547895016;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 56:
										goto IL_21D6;
									case 57:
										num = (short)1572977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 58:
										flashcodeTable.SetFieldValue(dbField, 3);
										num = (short)395182096;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 59:
									{
										int fieldValue;
										if (fieldValue == 1)
										{
											num = (short)1420034090;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 60:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꖔꂖ", a_)))
										{
											num = (short)2056388747;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)620822669;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 61:
										flag = true;
										num = (short)2130116814;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 62:
										goto IL_21D6;
									case 63:
										flag = true;
										num = (short)313655500;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 64:
										num = (short)535625774;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 65:
										num = (short)1451229360;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 66:
										goto IL_21D6;
									case 67:
										flag = true;
										num = (short)1597178085;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 68:
										goto IL_21D6;
									case 69:
									{
										uint num5;
										if (num5 != 1954970843U)
										{
											num = (short)548274188;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1974468692;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 70:
										goto IL_21D6;
									case 71:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꆒꆔꎖ", a_)))
										{
											num = (short)1570504790;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)664469705;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 72:
										num = (short)1282015431;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 73:
										num = (short)63570148;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 74:
										flag = true;
										num = (short)1813708968;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 75:
									{
										uint num5;
										if (num5 != 2071638597U)
										{
											num = (short)656867456;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)218235025;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 76:
										goto IL_21D6;
									case 77:
										num = (short)470286554;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 78:
										num = (short)1358233797;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 79:
									{
										string name2;
										if (!(name2 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a\ud890ﶒ햘漢ﾜ캠첢즤鮪馬鞮袰膲辶肸论趼觀駂髄蛆﷈ￊ﷎", a_)))
										{
											num = (short)2022244367;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)49807369;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 80:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꆒꞔꊖ", a_)))
										{
											num = (short)1935933660;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)368443495;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 81:
										goto IL_21D6;
									case 82:
										goto IL_21D6;
									case 83:
										goto IL_21D6;
									case 84:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꖖ", a_)))
										{
											num = (short)1848508530;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1077608452;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 85:
										num = (short)1132724318;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 86:
										num = (short)1086521577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 87:
									{
										uint num5;
										if (num5 != 793602653U)
										{
											num = (short)18350102;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1776418887;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 88:
									{
										uint num5;
										if (num5 != 1048750891U)
										{
											num = (short)1176895580;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)25165884;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 89:
										num = (short)251330639;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 90:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꆖ", a_)))
										{
											num = (short)581107784;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)755368040;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 91:
										goto IL_21D6;
									case 92:
										num = (short)986972205;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 93:
										if (flag)
										{
											num = (short)1497366744;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2485;
									case 94:
										goto IL_21D6;
									case 95:
									{
										uint num5;
										if (num5 != 2038858938U)
										{
											num = (short)1981677618;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)705954011;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 96:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꎔ꺖", a_)))
										{
											num = (short)1191510124;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1990066370;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 97:
										goto IL_21D6;
									case 98:
										flag = true;
										num = (short)1366884389;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 99:
										goto IL_21D6;
									case 100:
									{
										string name2;
										if (!(name2 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a\ud890ﶒ햘漢ﾜ캠첢즤\udba8슪사캮쎰쪲횶ힸ\udfba캼胀ﻆﳊ", a_)))
										{
											num = (short)2044526782;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.Flashport.FlashRadio.Option option;
										string name = option.Name;
										uint num5 = global::<PrivateImplementationDetails>.ComputeStringHash(name);
										num = (short)512098482;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 101:
										goto IL_21D6;
									case 102:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꖔ꺖", a_)))
										{
											num = (short)2137325645;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1107820545;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 103:
									{
										int fieldValue;
										if (fieldValue == 1)
										{
											num = (short)1126039615;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 104:
									{
										int fieldValue;
										if (fieldValue == 8)
										{
											num = (short)1936523395;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 105:
										num = (short)1579548767;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 106:
										num = (short)1919942790;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 107:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꎔ꺖", a_)))
										{
											num = (short)446365760;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_245E;
									}
									case 108:
										num = (short)752549909;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 109:
										flag = true;
										num = (short)1609171068;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 110:
										goto IL_21D6;
									case 111:
										goto IL_21D6;
									case 112:
									{
										int fieldValue;
										if (fieldValue == 2)
										{
											num = (short)1009713219;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 113:
										goto IL_21D6;
									case 114:
										num = (short)1322450969;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 115:
									{
										uint num5;
										if (num5 != 2022081319U)
										{
											num = (short)1357119593;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2004615350;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 116:
									{
										int fieldValue;
										if (fieldValue == 8)
										{
											num = (short)397344885;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 117:
										flag = true;
										num = (short)1852244094;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 118:
										num = (short)1317142648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 119:
										goto IL_21D6;
									case 120:
									{
										uint num5;
										if (num5 != 1032664820U)
										{
											num = (short)1513881817;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)506658906;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 121:
									{
										int fieldValue;
										if (fieldValue == 5)
										{
											num = (short)1411842183;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 122:
										num = (short)1427505362;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 123:
										goto IL_21D6;
									case 124:
										goto IL_21D6;
									case 125:
										num = (short)1526464594;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 126:
										goto IL_21D6;
									case 127:
										flag = true;
										num = (short)873660499;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 128:
										num = (short)1227620536;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 129:
										goto IL_21D6;
									case 130:
									{
										int fieldValue;
										if (fieldValue == 6)
										{
											num = (short)639762654;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 131:
										flag = true;
										num = (short)1224671251;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 132:
										num = (short)1485111407;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 133:
									{
										string name2;
										if (!(name2 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a\ud890ﶒ햘漢ﾜ캠첢즤첨좪슬솮햰튲잴캶﮸\udaba펼\udbbe닀鳂蓄靖", a_)))
										{
											num = (short)585957430;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.Flashport.FlashRadio.Option option;
										string name = option.Name;
										uint num5 = global::<PrivateImplementationDetails>.ComputeStringHash(name);
										num = (short)1769537725;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 134:
									{
										uint num5;
										if (num5 != 710700296U)
										{
											num = (short)394723484;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1532690512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 135:
										flag = true;
										num = (short)1533476875;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 136:
										goto IL_21D6;
									case 137:
										switch (0)
										{
										case 0:
											goto IL_654;
										}
										continue;
									case 138:
									{
										uint num5;
										if (num5 <= 1938193224U)
										{
											num = (short)377618475;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1575878771;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 139:
										num = (short)376504364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 140:
										flag = true;
										num = (short)1847132322;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 141:
									{
										int fieldValue;
										if (fieldValue == 3)
										{
											num = (short)1828192443;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 142:
										num = (short)146800815;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 143:
										goto IL_21D6;
									case 144:
										goto IL_255C;
									case 145:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꪒꎔ꺖", a_)))
										{
											num = (short)1138688193;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)781451287;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 146:
										flag = true;
										num = (short)1662058552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 147:
										goto IL_21D6;
									case 148:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔ꒖", a_)))
										{
											num = (short)39190613;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1498611752;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 149:
										num = (short)1353842776;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 150:
										num = (short)1703477439;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 151:
									{
										uint num5;
										if (num5 != 1971748462U)
										{
											num = (short)1379598409;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1781792932;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 152:
									{
										uint num5;
										if (num5 != 1031973272U)
										{
											num = (short)1303511189;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2116157469;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 153:
									{
										global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)601096380;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
										dbField = option.DbField;
										int fieldValue = flashcodeTable.GetFieldValue(dbField);
										string name2 = dbField.Name;
										num = (short)2115371193;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 154:
									{
										uint num5;
										if (num5 != 1015887201U)
										{
											num = (short)841810115;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2117599401;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 155:
										goto IL_21D6;
									case 156:
										num = (short)1198260277;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 157:
										num = (short)1471873175;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 158:
										goto IL_21D6;
									case 159:
										flag = true;
										num = (short)335806511;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 160:
									{
										int fieldValue;
										if (fieldValue == 2)
										{
											num = (short)1916665908;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 162:
										goto IL_21D6;
									case 163:
										flag = true;
										num = (short)197918849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 164:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꚖ", a_)))
										{
											num = (short)1674706978;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2123431950;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 165:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꎖ", a_)))
										{
											num = (short)598540480;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1482621049;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 166:
										goto IL_21D6;
									case 167:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꊖ", a_)))
										{
											num = (short)688783360;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1139343362;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 168:
										goto IL_21D6;
									case 169:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꚖ", a_)))
										{
											num = (short)692977806;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2071855304;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 170:
										flag = true;
										num = (short)1847132326;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 171:
									{
										uint num5;
										if (num5 <= 982331963U)
										{
											num = (short)1477443690;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)447348967;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 172:
										goto IL_21D6;
									case 173:
										goto IL_21D6;
									case 174:
										num = (short)1697054811;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 175:
										goto IL_21D6;
									case 176:
										goto IL_21D6;
									case 177:
										goto IL_2485;
									case 178:
									{
										uint num5;
										if (num5 <= 1048750891U)
										{
											num = (short)75825207;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)774373597;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 179:
										goto IL_21D6;
									case 180:
									{
										uint num5;
										if (num5 <= 1988526081U)
										{
											num = (short)2050621597;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1149960267;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 181:
									{
										uint num5;
										if (num5 != 965554344U)
										{
											num = (short)2046230653;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)431816902;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 182:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꆖ", a_)))
										{
											num = (short)128188421;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)848363636;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 183:
									{
										int fieldValue;
										if (fieldValue == 7)
										{
											num = (short)2053963922;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 184:
									{
										uint num5;
										if (num5 == 2379504813U)
										{
											num = (short)2046296095;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 185:
									{
										string name2;
										if (!(name2 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a\ud890ﶒ햘漢ﾜ캠첢즤鮪鶬骮螰課肶膸论趼觀駂髄蛆﷈流", a_)))
										{
											num = (short)115408985;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.Flashport.FlashRadio.Option option;
										string name = option.Name;
										num = (short)886964331;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 186:
										flag = true;
										num = (short)603521121;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 187:
										flag = true;
										num = (short)858194125;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 188:
										num = (short)585760912;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 189:
									{
										uint num5;
										if (num5 <= 1032664820U)
										{
											num = (short)192610340;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)581369994;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 190:
										num = (short)66650245;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 191:
										goto IL_21D6;
									case 192:
										num = (short)1637613798;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 193:
										num = (short)1860829398;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 194:
									{
										int fieldValue;
										if (fieldValue == 1)
										{
											num = (short)1292959968;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 195:
										num = (short)973734040;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 196:
									{
										uint num5;
										if (num5 != 1066220058U)
										{
											num = (short)1988952267;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1974272165;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 197:
									{
										uint num5;
										if (num5 != 1015195653U)
										{
											num = (short)1207173238;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)625541222;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 198:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꖖ", a_)))
										{
											num = (short)876609668;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)952238098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 199:
										goto IL_21D6;
									case 200:
									{
										int fieldValue;
										if (fieldValue == 4)
										{
											num = (short)1097007128;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 201:
									{
										int fieldValue;
										if (fieldValue == 1)
										{
											num = (short)1119944913;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 202:
										num = (short)1821966406;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 203:
										num = (short)678101005;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 204:
										goto IL_21D6;
									case 205:
										goto IL_21D6;
									case 206:
										goto IL_21D6;
									case 207:
										flag = true;
										num = (short)414384251;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 208:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔ꒖", a_)))
										{
											num = (short)1422590126;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1616773179;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 209:
										flag = true;
										num = (short)765132826;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 210:
									{
										uint num5;
										if (num5 != 1082997677U)
										{
											num = (short)1711866068;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)242417831;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 211:
										num = (short)217579735;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 212:
										num = (short)462094377;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 213:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꖐꮒꚔꖖ", a_)))
										{
											num = (short)281149666;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)45416631;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 214:
										goto IL_21D6;
									case 215:
									{
										int fieldValue;
										if (fieldValue == 1)
										{
											num = (short)1945174179;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 216:
									{
										global::SpecialFeatures.Flashport.FlashRadio.Option option;
										A_0.Add(option.Name, true);
										num = (short)1900282033;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 217:
										num = (short)1683226690;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 218:
										goto IL_21D6;
									case 219:
									{
										string name;
										if (!(name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꊖ", a_)))
										{
											num = (short)1459028033;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)581697584;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 220:
										num = (short)431554732;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 221:
									{
										uint num5;
										if (num5 <= 1954970843U)
										{
											num = (short)382795898;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1539571892;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 222:
										flag = true;
										num = (short)1668939857;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 223:
									{
										int fieldValue;
										if (fieldValue == 2)
										{
											num = (short)1253179578;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21D6;
									}
									case 224:
										flag = true;
										num = (short)617021598;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 225:
										num = (short)1287389331;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 226:
										num = (short)1997144219;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 227:
										num = (short)944308367;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 228:
									{
										uint num5;
										if (num5 != 1988526081U)
										{
											num = (short)605618204;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1753350179;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 229:
										goto IL_21D6;
									case 230:
										goto IL_21D6;
									case 231:
									{
										uint num5;
										if (num5 != 998418034U)
										{
											num = (short)397475918;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1571815441;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 232:
									{
										uint num5;
										if (num5 <= 965554344U)
										{
											num = (short)1059651592;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)616759450;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 233:
										goto IL_21D6;
									}
									IL_1C1D:
									num = (short)827785369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_654:
									goto IL_1C1D;
									IL_21D6:
									num = (short)1255604317;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_245E:
									flashcodeTable.SetFieldValue(dbField, 3);
									num = (short)1645346884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2485:
									flag = false;
									num = (short)653983905;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_255C:
								goto IL_265;
							}
							finally
							{
								num = (short)536543232;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_2594;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)63963138;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_25CE;
									}
									IL_2594:
									if (enumerator == null)
									{
										break;
									}
									num = (short)982188033;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_25CE:;
							}
							goto IL_25D1;
						case 6:
							goto IL_204;
						case 7:
							goto IL_1CB;
						case 8:
							if (num4 >= 25)
							{
								num = (short)1882849290;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num6 = 0;
							num = (short)910688263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (num6 < 8)
							{
								int position = num4 * 8 + num6 + 1;
								global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition = flashcodeTable.FLASHcode.GetOptionsByPosition(position);
								num = (short)1815097181;
								short num7 = num;
								num = (short)1700802397;
								switch ((num7 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1697513473;
									if (num != 0)
									{
									}
									num = (short)1384054784;
									if (num != 0)
									{
									}
									num = (short)380567552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							num = (short)2019360769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_25D1;
						case 11:
						{
							global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition;
							global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator = optionsByPosition.GetEnumerator();
							num = (short)805699589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_95;
						IL_1CB:
						num = (short)943063049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_204:
						num = (short)395247624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_265:
						num6++;
						num = (short)705953796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_25D1:
						num = (short)1508638722;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_25EA:
					return;
					IL_95:
					flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable();
					flashcodeTable.InitTable(true, this.b, false);
					num4 = 0;
					num = (short)1916076038;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_5E;
				}
				finally
				{
					num = (short)1229455360;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_261E;
							}
							continue;
						case 1:
							flashcodeTable.Dispose();
							flashcodeTable = null;
							num = (short)135266306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2655;
						}
						IL_261E:
						if (flashcodeTable == null)
						{
							break;
						}
						num = (short)985268225;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2655:;
				}
				return;
			}
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000E293C File Offset: 0x000E0B3C
		internal bool SetModelConfiguration(bool CplgOpenAndNew)
		{
			int a_ = 0;
			short num = (short)966131712;
			short num2 = num;
			num = (short)995413541;
			short num3 = num;
			num = (short)635489829;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)481558528;
				if (num != 0)
				{
				}
				num = (short)1160577025;
				if (num != 0)
				{
				}
				num = (short)2039742464;
				switch (num)
				{
				default:
				{
					this.i = true;
					bool flag = false;
					try
					{
						using (global::System.Collections.Generic.Dictionary<string, global::System.Type>.Enumerator enumerator = this.g.GetEnumerator())
						{
							num = (short)1914699776;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								bool flag2;
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_120;
									}
									continue;
								case 1:
									if (flag)
									{
										flag2 = this.i;
										goto IL_4B6;
									}
									goto IL_475;
								case 2:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_1AA;
										}
										object[] args;
										object[] args2;
										object[] args3;
										object[] args4;
										for (;;)
										{
											IL_16F:
											switch (num4)
											{
											case 0:
												goto IL_458;
											case 1:
												goto IL_257;
											case 2:
											{
												global::System.Collections.Generic.KeyValuePair<string, global::System.Type> keyValuePair;
												keyValuePair.Value.InvokeMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc82솄솒列\udc9e캠횢쮤펦", a_), global::System.Reflection.BindingFlags.SetField, null, null, args);
												num = (short)443940864;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
											{
												global::System.Collections.Generic.KeyValuePair<string, global::System.Type> keyValuePair;
												if (keyValuePair.Value.GetMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc82솄솒列\udc9e캠횢쮤펦", a_)).Length != 0)
												{
													num = (short)980877314;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_458;
											}
											case 4:
											{
												global::System.Collections.Generic.KeyValuePair<string, global::System.Type> keyValuePair;
												keyValuePair.Value.InvokeMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc82좄", a_), global::System.Reflection.BindingFlags.SetField, null, null, args2);
												num = (short)1896546311;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												global::System.Collections.Generic.KeyValuePair<string, global::System.Type> keyValuePair;
												if (keyValuePair.Value.GetMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc82좄", a_)).Length != 0)
												{
													num = (short)1345716228;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_381;
											}
											case 6:
											{
												global::System.Collections.Generic.KeyValuePair<string, global::System.Type> keyValuePair;
												keyValuePair.Value.InvokeMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc82좄", a_), global::System.Reflection.BindingFlags.SetField, null, null, args3);
												num = (short)1141112833;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
												goto IL_381;
											case 8:
												goto IL_32B;
											case 9:
												goto IL_470;
											case 10:
											{
												global::System.Collections.Generic.KeyValuePair<string, global::System.Type> keyValuePair;
												if (keyValuePair.Value.GetMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc82좄", a_)).Length != 0)
												{
													num = (short)1970208774;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_257;
											}
											case 11:
											{
												global::System.Collections.Generic.KeyValuePair<string, global::System.Type> keyValuePair;
												keyValuePair.Value.InvokeMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc82좄\udb8a﶐", a_), global::System.Reflection.BindingFlags.SetField, null, null, args4);
												num = (short)220856328;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 12:
											{
												global::System.Collections.Generic.KeyValuePair<string, global::System.Type> keyValuePair;
												if (keyValuePair.Value.GetMember(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc82좄\udb8a﶐", a_)).Length != 0)
												{
													num = (short)1870659595;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_32B;
											}
											}
											goto IL_1AA;
											IL_257:
											num = (short)1766916099;
											num4 = (int)((global::System.IntPtr)num);
											continue;
											IL_32B:
											num = (short)568131594;
											num4 = (int)((global::System.IntPtr)num);
											continue;
											IL_381:
											num = (short)2015887372;
											num4 = (int)((global::System.IntPtr)num);
											continue;
											IL_458:
											num = (short)1664352265;
											num4 = (int)((global::System.IntPtr)num);
										}
										IL_470:
										break;
										IL_1AA:
										args2 = new object[]
										{
											this.c
										};
										args4 = new object[]
										{
											this.d
										};
										args3 = new object[]
										{
											this.e
										};
										args = new object[]
										{
											this.f
										};
										num = (short)320536581;
										num4 = (int)((global::System.IntPtr)num);
										goto IL_16F;
									}
									catch (global::System.Exception)
									{
										break;
									}
									goto IL_475;
								case 3:
									num = (short)240451589;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)925302787;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, global::System.Type> keyValuePair = enumerator.Current;
									flag = this.a(keyValuePair.Key);
									num = (short)819855361;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_510;
								case 6:
									if (flag)
									{
										num = (short)516358146;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_478:
								num = (short)1157758980;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_120:
								goto IL_478;
								IL_4B6:
								this.i = flag2;
								num = (short)2071330822;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_475:
								flag2 = false;
								goto IL_4B6;
							}
							IL_510:;
						}
					}
					catch (global::System.Exception)
					{
						this.i = false;
					}
					break;
				}
				}
				break;
			}
			return this.i;
		}

		// Token: 0x04000527 RID: 1319
		private string a;

		// Token: 0x04000528 RID: 1320
		private string b;

		// Token: 0x04000529 RID: 1321
		private int c;

		// Token: 0x0400052A RID: 1322
		private int d;

		// Token: 0x0400052B RID: 1323
		private int e;

		// Token: 0x0400052C RID: 1324
		private int f;

		// Token: 0x0400052D RID: 1325
		private global::System.Collections.Generic.Dictionary<string, global::System.Type> g;

		// Token: 0x0400052E RID: 1326
		private global::AcpModelTieringLib.CModelTiering h;

		// Token: 0x0400052F RID: 1327
		private bool i;

		// Token: 0x04000530 RID: 1328
		private global::System.Collections.Generic.Dictionary<string, bool> j;

		// Token: 0x04000531 RID: 1329
		private const int k = 2147483647;

		// Token: 0x04000532 RID: 1330
		private const int l = 1;

		// Token: 0x04000533 RID: 1331
		private const int m = 1;
	}
}
