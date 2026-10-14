using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.ActivityBuilderLib
{
	// Token: 0x02000025 RID: 37
	public class ScxmlParser
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x0000BE48 File Offset: 0x0000A048
		public string GetWidgetTypeStrByWidgetType(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType type)
		{
			int a_ = 4;
			short num = (short)1468137472;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)637730817;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 1:
					goto IL_1D8;
				case 2:
					num = (short)72482817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_63:
				switch (type)
				{
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyStatus:
					goto IL_10D;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wQuery:
					goto IL_1A3;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyIncident:
					goto IL_158;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wStatusMonitor:
					goto IL_167;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wRadio:
					goto IL_13A;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wSearch:
					goto IL_194;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingSimple:
					goto IL_212;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingAdv:
					goto IL_1B2;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingSimple:
					goto IL_11C;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingAdv:
					goto IL_176;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarSimple:
					goto IL_185;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarAdv:
					goto IL_149;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyApps:
					goto IL_221;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMapNoType:
					goto IL_203;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCoreApp:
					goto IL_12B;
				default:
				{
					num = (short)692680959;
					short num3 = num;
					num = (short)2030860543;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_176;
					default:
						num = (short)1809645568;
						if (num != 0)
						{
						}
						num = (short)755564546;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_10D:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("삒", a_);
			IL_11C:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("\ude92漢煮쾠쒢薤삨욪\uddac쎮풰", a_);
			IL_12B:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("킒杖ﲘ뮚\udc9c토", a_);
			IL_13A:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("솒", a_);
			IL_149:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("킒ﮖﲘ列ﺞ펠莢쎦\udfa8쪪쎬첮풰ힲ", a_);
			IL_158:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("\ude92랖킘ﺜ얠욢쮤펦", a_);
			IL_167:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("삒뾞첢쮤캦\udda8쒪\udfac", a_);
			IL_176:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("\ude92漢煮쾠쒢薤춨\uddaa첬솮튰횲톴", a_);
			IL_185:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("킒ﮖﲘ列ﺞ펠莢캦쒨\udbaa솬쪮", a_);
			IL_194:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("삒", a_);
			IL_1A3:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("슒", a_);
			IL_1B2:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("\ude92릘\uda9a列삠춢욤슦춨", a_);
			IL_1D8:
			num = (short)1517355008;
			short num4 = num;
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮔﲖ", a_);
			IL_203:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("\ude92릘좚토쾢삤", a_);
			IL_212:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("\ude92릘좚토쾢삤", a_);
			IL_221:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("\ude92랖\ud898", a_);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000C094 File Offset: 0x0000A294
		public string[] GetHomeLayoutAndActivities(string filepath)
		{
			int a_ = 3;
			short num = (short)1934819328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1468858368;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				global::System.Xml.Linq.XDocument xdocument;
				int num5;
				int num6;
				int[] array2;
				global::System.Xml.Linq.XNamespace ns;
				for (;;)
				{
					IL_5A:
					global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)583008257;
						if (num != 0)
						{
						}
						if (xdocument != null)
						{
							num = (short)1450704898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_643;
					case 1:
						try
						{
							num = (short)926285826;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Xml.Linq.XElement xelement;
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)227475465;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									xelement = enumerator.Current;
									bool flag = false;
									bool flag2 = false;
									int[] array = new int[2];
									global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2 = xelement.Elements().GetEnumerator();
									num = (short)1349648391;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_233;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1B8;
									}
									continue;
								case 3:
									goto IL_58F;
								case 4:
									goto IL_54F;
								case 5:
								{
									bool flag2;
									if (flag2)
									{
										num = (short)1340801034;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									try
									{
										num = (short)763822087;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											num = (short)968396276;
											short num4 = num;
											num = (short)2021166580;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												num = (short)2003042304;
												if (num != 0)
												{
												}
												switch (num2)
												{
												case 0:
												{
													global::System.Xml.Linq.XElement xelement2;
													if (string.Equals(xelement2.Name.LocalName, global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("즟춡쪣", a_)))
													{
														num = (short)700645381;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 1:
												{
													global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
													if (!enumerator2.MoveNext())
													{
														num = (short)1267400713;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::System.Xml.Linq.XElement xelement2 = enumerator2.Current;
													num = (short)1010761736;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 2:
												{
													bool flag = true;
													num = (short)720502790;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 4:
													goto IL_4DB;
												case 5:
												{
													bool flag = false;
													bool flag2 = true;
													num = (short)1859452931;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 6:
													goto IL_389;
												case 7:
													goto IL_300;
												case 8:
												{
													global::System.Xml.Linq.XElement xelement2;
													if (!string.Equals(xelement2.Name.LocalName, global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﾙ", a_), global::System.StringComparison.Ordinal))
													{
														num = (short)1374486530;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_389;
												}
												case 9:
													num = (short)2020016132;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_384;
												IL_389:
												num = (short)1384972288;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_300:
											switch (0)
											{
											case 0:
												IL_384:
												goto IL_485;
											}
											continue;
											IL_485:
											num = (short)2086862849;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_4DB:
										goto IL_2AE;
									}
									finally
									{
										num = (short)160694273;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)428605442;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_514;
												}
												continue;
											case 2:
												goto IL_54C;
											}
											IL_514:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1365114880;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_54C:;
									}
									goto IL_54F;
									IL_2AE:
									num = (short)1170604040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									bool flag;
									if (flag)
									{
										num = (short)873332740;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_233;
								}
								case 9:
									num = (short)1432289283;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									int[] array = this.GetPanelAndWidgetCounts(xelement);
									num5 += array[0];
									num6 += array[1];
									num = (short)596836358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_1B8;
								IL_233:
								num = (short)1776615429;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_26D:
								num = (short)172359680;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B8:
								goto IL_26D;
								IL_54F:
								array2 = this.GetPanelAndWidgetCounts(xelement);
								num = (short)514195457;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_58F:
							goto IL_643;
						}
						finally
						{
							num = (short)928251905;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1673068546;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5C7;
									}
									continue;
								case 2:
									goto IL_600;
								}
								IL_5C7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)684195840;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_600:;
						}
						goto IL_603;
					case 2:
						goto IL_603;
					}
					goto IL_6D;
					IL_603:
					enumerator = xdocument.Descendants(ns + global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﾙ", a_)).GetEnumerator();
					num = (short)802816001;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_643:
				int[] array3;
				array3[0] = num5;
				array3[1] = num6;
				string[] array4;
				array4[0] = string.Concat(new string[]
				{
					array2[0].ToString(global::System.Globalization.CultureInfo.CurrentCulture),
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("늑", a_),
					global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Panels,
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("뺑뒓", a_),
					array2[1].ToString(global::System.Globalization.CultureInfo.CurrentCulture),
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("늑", a_),
					global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Widgets
				});
				array4[1] = string.Concat(new string[]
				{
					array3[0].ToString(global::System.Globalization.CultureInfo.CurrentCulture),
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("늑", a_),
					global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Panels,
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("뺑뒓", a_),
					array3[1].ToString(global::System.Globalization.CultureInfo.CurrentCulture),
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("늑", a_),
					global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Widgets
				});
				return array4;
				IL_6D:
				array4 = new string[]
				{
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ꊑ뒓", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Panels + global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("뺑뒓ꚕ뢗", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Widgets,
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ꊑ뒓", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Panels + global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("뺑뒓ꚕ뢗", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Widgets
				};
				array2 = new int[2];
				array3 = new int[2];
				xdocument = global::System.Xml.Linq.XDocument.Load(filepath);
				ns = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("晴ꂙ뎛놝힟햡펣袥\udfa7馩芫솭슯햱鮳蒵袷誹覻醽뗅ꯇ닉ꇋꋍ", a_);
				num5 = 0;
				num6 = 0;
				num = (short)1445199872;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000C818 File Offset: 0x0000AA18
		public int[] GetPanelAndWidgetCounts(global::System.Xml.Linq.XElement state)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int[] array;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_211;
				case 1:
					array[0] = state.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("쎟킡솣쎥욧", a_)).Count<global::System.Xml.Linq.XElement>();
					num2 = (short)1846673411;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					array[1] = state.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﾝ킟튡펣쾥첧충즫\udaad", a_)).Count<global::System.Xml.Linq.XElement>();
					num2 = (short)430309381;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_239;
				case 4:
					if (state.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("솟튡펣쾥첧충즫\udaad", a_)) != null)
					{
						num2 = (short)1914044423;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return array;
				case 5:
					goto IL_10D;
				case 6:
					if (state.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("쎟킡솣쎥욧", a_)) != null)
					{
						num2 = (short)1921515521;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_239;
				case 7:
					array[1] = array[1] + state.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("솟튡펣쾥첧충즫\udaad", a_)).Count<global::System.Xml.Linq.XElement>();
					num2 = (short)340918272;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (state.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﾝ킟튡펣쾥첧충즫\udaad", a_)) != null)
					{
						num2 = (short)1277558786;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10D;
				}
				goto IL_3D;
				IL_10D:
				num2 = (short)948830212;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_239:
				num2 = (short)2087387144;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_211:
			num2 = (short)1048707073;
			if (num2 != 0)
			{
			}
			return array;
			IL_3D:
			num2 = (short)749233413;
			short num3 = num2;
			num2 = (short)334521605;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_13;
			default:
			{
				num2 = (short)154206208;
				short num4 = num2;
				num2 = (short)770375680;
				if (num2 != 0)
				{
				}
				array = new int[2];
				num2 = (short)1210580998;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		public global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivitySet ParseActivitySetFile(string filepath)
		{
			int a_ = 13;
			short num = (short)483393536;
			short num2 = num;
			num = (short)1117257729;
			if (num != 0)
			{
			}
			num = (short)2057568256;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivitySet activitySet = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivitySet();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_9E;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
					global::System.Xml.Linq.XDocument xdocument;
					global::System.Xml.Linq.XNamespace ns;
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HomeLayout homeLayout;
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activities activities;
					for (;;)
					{
						IL_8B:
						switch (num3)
						{
						case 0:
							goto IL_266;
						case 1:
							try
							{
								num = (short)1476329474;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num = (short)379060228;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_160;
										}
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1830420480;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.Linq.XElement xelement = enumerator.Current;
										activitySet.Eventsets = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Eventset
										{
											Contents = xelement.Value
										};
										num = (short)604831745;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_1F5;
									}
									IL_162:
									num = (short)192610307;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_160:
									goto IL_162;
								}
								IL_1F5:
								goto IL_11B6;
							}
							finally
							{
								num = (short)1541406721;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										enumerator.Dispose();
										num = (short)742064130;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_22C;
										}
										continue;
									case 2:
										goto IL_263;
									}
									IL_22C:
									if (enumerator == null)
									{
										break;
									}
									num = (short)2058616832;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_263:;
							}
							goto Block_3;
						case 2:
							goto IL_120E;
						}
						goto IL_9E;
						IL_11B6:
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2 = xdocument.Descendants(ns + global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("솟횡솣", a_)).GetEnumerator();
						num = (short)2096693248;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						Block_3:
						try
						{
							IL_266:
							num = (short)2097020944;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator3;
								int num4;
								global::System.Xml.Linq.XElement xelement2;
								string description;
								bool flag;
								bool flag2;
								global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator5;
								switch (num3)
								{
								case 1:
									try
									{
										num = (short)1566048263;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel hlpanel;
											switch (num3)
											{
											case 0:
												goto IL_457;
											case 1:
												num = (short)2143289349;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
											{
												if (!enumerator3.MoveNext())
												{
													num = (short)2126839814;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Xml.Linq.XElement parentNode = enumerator3.Current;
												hlpanel = this.getHLPanel(parentNode, num4);
												num = (short)2111307779;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												if (hlpanel != null)
												{
													num = (short)1938227201;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 4:
												goto IL_4C3;
											case 5:
												if (num4 == 0)
												{
													num = (short)1973288968;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_457;
											case 6:
												num = (short)1174536196;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												switch (0)
												{
												case 0:
													goto IL_36D;
												}
												continue;
											case 8:
												hlpanel.Selected = true;
												num = (short)772145152;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_3C7:
											num = (short)1501822978;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_36D:
											goto IL_3C7;
											IL_457:
											hlpanel.Name = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Panel_Space + (num4 + 1).ToString(global::System.Globalization.CultureInfo.CurrentCulture);
											homeLayout.LstHLPanel.Add(hlpanel);
											num4++;
											num = (short)1889796105;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_4C3:
										goto IL_9A7;
									}
									finally
									{
										num = (short)1916534785;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
												enumerator3.Dispose();
												num = (short)564199426;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_4FA;
												}
												continue;
											case 2:
												goto IL_533;
											}
											IL_4FA:
											if (enumerator3 == null)
											{
												break;
											}
											num = (short)1499594752;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_533:;
									}
									goto IL_536;
									IL_9A7:
									activitySet.HomeLayout = homeLayout;
									num = (short)1635778563;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_112A;
								case 3:
									goto IL_9C8;
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition>();
									global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XNode> enumerator4 = xelement2.DescendantNodes().GetEnumerator();
									num = (short)1720057865;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									description = ((global::System.Xml.Linq.XComment)xelement2.PreviousNode).Value;
									num = (short)608370703;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (xelement2.PreviousNode.NodeType == global::System.Xml.XmlNodeType.Comment)
									{
										num = (short)1568997381;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5FE;
								case 7:
									try
									{
										num = (short)79495177;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
												num = (short)1646002186;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_C62;
											case 2:
												activities.Initial = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityBuilderLibCommonService.GetEventTriggerUIstring(xelement2.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("즟횡춣장쒧", a_)).Value);
												num = (short)1930493953;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												num = (short)469630987;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												goto IL_C0E;
											case 6:
												goto IL_DF3;
											case 7:
												goto IL_C62;
											case 8:
												activities.Name = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("瀞쎟힡힣쎥첧\ud8ab솭삯", a_);
												num = (short)268369924;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
												switch (0)
												{
												case 0:
													goto IL_A8F;
												}
												continue;
											case 10:
											{
												global::System.Xml.Linq.XElement xelement3;
												if (xelement3.Parent.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("瞧", a_)).Value != global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﺛﾝ펟잡", a_))
												{
													num = (short)200540175;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_C62;
											}
											case 11:
												goto IL_EA3;
											case 12:
												if (xelement2.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("즟횡춣장쒧", a_)) != null)
												{
													num = (short)834666498;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_C62;
											case 13:
											{
												global::System.Xml.Linq.XElement xelement3;
												if (xelement3.Parent != null)
												{
													num = (short)934084626;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_C62;
											}
											case 14:
											{
												global::System.Xml.Linq.XElement xelement3;
												if (string.Equals(xelement3.Name.LocalName, global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("솟첡힣쾥\udca7쎩쎫삭", a_), global::System.StringComparison.Ordinal))
												{
													num = (short)355729427;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 15:
												flag = false;
												num = (short)2091778055;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 16:
												activities.Name = xelement2.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("瞧", a_)).Value;
												num = (short)1594294278;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 17:
												if (string.IsNullOrEmpty(activities.Name))
												{
													num = (short)2125856776;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_C0E;
											case 18:
												num = (short)479985686;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 19:
												flag = false;
												flag2 = true;
												num = (short)1329004549;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 20:
											{
												if (!enumerator5.MoveNext())
												{
													num = (short)1948188675;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Xml.Linq.XElement xelement3 = enumerator5.Current;
												num = (short)857538583;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 21:
												if (xelement2.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("瞧", a_)) != null)
												{
													num = (short)1611923472;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_DF3;
											case 22:
											{
												global::System.Xml.Linq.XElement xelement3;
												if (xelement3.Parent.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("瞧", a_)) != null)
												{
													num = (short)2097348608;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_C62;
											}
											case 23:
											{
												global::System.Xml.Linq.XElement xelement3;
												if (xelement3.Name.LocalName != global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("솟횡솣", a_))
												{
													num = (short)1929183256;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)9699349;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 24:
												flag = true;
												num = (short)1735262221;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_A8F;
											IL_C0E:
											num = (short)1945042956;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_C62:
											num = (short)1706688526;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_CBA:
											num = (short)467992596;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_A8F:
											goto IL_CBA;
											IL_DF3:
											num = (short)704249873;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_EA3:
										goto IL_5B6;
									}
									finally
									{
										num = (short)1859584002;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
												enumerator5.Dispose();
												num = (short)986054657;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_F14;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_EDA;
												}
												continue;
											}
											IL_EDA:
											if (enumerator5 == null)
											{
												break;
											}
											num = (short)2083913728;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_F14:;
									}
									goto IL_F17;
									IL_5B6:
									description = "";
									num = (short)1847132174;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_8BD;
								case 9:
								{
									try
									{
										num = (short)1547042823;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 1:
											{
												global::System.Xml.Linq.XNode xnode;
												if (xnode.NodeType == global::System.Xml.XmlNodeType.Element)
												{
													num = (short)1291386885;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 2:
											{
												global::System.Xml.Linq.XNode xnode;
												global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition transition = this.getTransition(xelement2, xnode as global::System.Xml.Linq.XElement);
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition> list;
												list.Add(transition);
												num = (short)1958871040;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												num = (short)1091895302;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												global::System.Xml.Linq.XNode xnode;
												if (string.Equals((xnode as global::System.Xml.Linq.XElement).Name.LocalName, global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("솟첡힣쾥\udca7쎩쎫삭", a_)))
												{
													num = (short)730726402;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
												num = (short)372178948;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												goto IL_10B8;
											case 7:
												switch (0)
												{
												case 0:
													goto IL_F89;
												}
												continue;
											case 8:
											{
												global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XNode> enumerator4;
												if (!enumerator4.MoveNext())
												{
													num = (short)2031812611;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Xml.Linq.XNode xnode = enumerator4.Current;
												num = (short)333840385;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_F8B:
											num = (short)1643118600;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_F89:
											goto IL_F8B;
										}
										IL_10B8:
										goto IL_969;
									}
									finally
									{
										num = (short)1927413762;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XNode> enumerator4;
											switch (num3)
											{
											case 0:
												enumerator4.Dispose();
												num = (short)449576961;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_1127;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_10F0;
												}
												continue;
											}
											IL_10F0:
											if (enumerator4 == null)
											{
												break;
											}
											num = (short)1828782080;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_1127:;
									}
									goto IL_112A;
									IL_969:
									global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator6 = xelement2.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﶝ튟잡솣좥", a_)).GetEnumerator();
									num = (short)21299212;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (!enumerator2.MoveNext())
									{
										num = (short)742850562;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_536;
								case 11:
									goto IL_1143;
								case 12:
									try
									{
										num = (short)2044657672;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity;
											switch (num3)
											{
											case 0:
												num = (short)1175584775;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												num = (short)1122304005;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												activity.Name = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityBuilderLibCommonService.GetEventTriggerUIstring(xelement2.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("瞧", a_)).Value);
												num = (short)570949638;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator6;
												if (!enumerator6.MoveNext())
												{
													num = (short)1255276544;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Xml.Linq.XElement parentNode2 = enumerator6.Current;
												activity = this.getActivity(xelement2, parentNode2);
												num = (short)783522133;
												short num5 = num;
												num = (short)1019386197;
												switch ((num5 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_652;
												default:
													num = (short)417136640;
													if (num != 0)
													{
													}
													num = (short)2122907657;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
												if (xelement2.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("瞧", a_)) != null)
												{
													num = (short)36896771;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_7FE;
											case 6:
												goto IL_7FE;
											case 7:
												goto IL_84B;
											case 8:
												goto IL_652;
											case 9:
												if (activity != null)
												{
													num = (short)771751938;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											goto IL_68B;
											IL_652:
											switch (0)
											{
											case 0:
												IL_68B:
												goto IL_779;
											}
											continue;
											IL_779:
											num = (short)1836515332;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_7FE:
											global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition> list;
											activity.Transitions = list;
											activities.LstActivity.Add(activity);
											num = (short)2089811969;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_84B:
										goto IL_F17;
									}
									finally
									{
										num = (short)666238978;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator6;
											switch (num3)
											{
											case 0:
												enumerator6.Dispose();
												num = (short)90636289;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_8BA;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_882;
												}
												continue;
											}
											IL_882:
											if (enumerator6 == null)
											{
												break;
											}
											num = (short)1147011072;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_8BA:;
									}
									goto IL_8BD;
								case 13:
									if (flag)
									{
										num = (short)23789576;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9C8;
								case 14:
									if (xelement2.PreviousNode != null)
									{
										num = (short)42205201;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5FE;
								case 15:
									goto IL_5FE;
								case 16:
									switch (0)
									{
									case 0:
										goto IL_2DA;
									}
									continue;
								case 17:
									num = (short)23265286;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									if (flag2)
									{
										num = (short)1943011332;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_2DF:
								num = (short)986906634;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_2DA:
								goto IL_2DF;
								IL_536:
								xelement2 = enumerator2.Current;
								flag = false;
								flag2 = false;
								enumerator5 = xelement2.Elements().GetEnumerator();
								num = (short)368902151;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_5FE:
								num = (short)1314390029;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_8BD:
								homeLayout.Description = description;
								num4 = 0;
								enumerator3 = xelement2.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﶝ튟잡솣좥", a_)).GetEnumerator();
								num = (short)1540620289;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_9C8:
								num = (short)242221074;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_F17:
								activitySet.Activities = activities;
								num = (short)799932416;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_112A:
								num = (short)1952317451;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1143:
							goto IL_11F4;
						}
						finally
						{
							num = (short)1214709762;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)1309474817;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_11B3;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_117B;
									}
									continue;
								}
								IL_117B:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)963706880;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_11B3:;
						}
						goto IL_11B6;
						IL_11F4:
						num = (short)753008642;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_120E:
					return activitySet;
					IL_9E:
					xdocument = global::System.Xml.Linq.XDocument.Load(filepath);
					ns = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("풟튡麣覥螧\udda9\udbab\ud9ad麯얱螳颵ힷ좹\udbbb醽韛﯋ꏏ뇑곓믕듗", a_);
					homeLayout = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HomeLayout();
					activities = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activities();
					homeLayout.LstHLPanel = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel>();
					activities.LstActivity = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity>();
					activitySet.HomeLayout = homeLayout;
					activitySet.Activities = activities;
					enumerator = xdocument.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("鍊얟첡킣향춧\udea9", a_)).GetEnumerator();
					num = (short)708116481;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_8B;
				}
				catch (global::System.Exception)
				{
				}
				return activitySet;
			}
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000DD80 File Offset: 0x0000BF80
		private global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel getHLPanel(global::System.Xml.Linq.XElement parentNode, int pagenum)
		{
			int a_ = 0;
			short num = (short)1193934848;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5D;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase> list;
				string description;
				global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel hlpanel;
				for (;;)
				{
					IL_32:
					global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
					global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
					switch (num2)
					{
					case 0:
						if (parentNode.PreviousNode.NodeType == global::System.Xml.XmlNodeType.Comment)
						{
							num = (short)1478557704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_402;
					case 1:
					{
						if (parentNode.PreviousNode == null)
						{
							goto IL_402;
						}
						num = (short)467368094;
						short num3 = num;
						num = (short)1063614622;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_545;
						default:
							num = (short)186646528;
							if (num != 0)
							{
							}
							num = (short)204079106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_6FE;
					case 3:
						goto IL_28C;
					case 4:
						try
						{
							num = (short)1036058624;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_15A;
									}
									continue;
								case 1:
									num = (short)1763180550;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1555824641;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.Linq.XElement mapwidget = enumerator.Current;
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget mapWidget = this.getMapWidget(mapwidget);
									num = (short)1630273539;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget mapWidget;
									if (mapWidget != null)
									{
										num = (short)1458307077;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget mapWidget;
									list.Add(mapWidget);
									num = (short)190119940;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_219;
								}
								IL_1C2:
								num = (short)374800386;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_15A:
								goto IL_1C2;
							}
							IL_219:
							goto IL_474;
						}
						finally
						{
							num = (short)460128257;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1597177858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_250;
									}
									continue;
								case 2:
									goto IL_289;
								}
								IL_250:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2082930688;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_289:;
						}
						goto Block_3;
						IL_474:
						num = (short)717815815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						try
						{
							num = (short)1793130496;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5A7;
									}
									continue;
								case 1:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget appWidget;
									list.Add(appWidget);
									num = (short)1942749187;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget appWidget;
									if (appWidget != null)
									{
										num = (short)465960961;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)1417609217;
									if (num != 0)
									{
									}
									num = (short)2138177542;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1951924228;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.Linq.XElement appwidget = enumerator2.Current;
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget appWidget = this.getAppWidget(appwidget);
									num = (short)1517617154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_68E;
								}
								IL_5C8:
								num = (short)410386437;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5A7:
								goto IL_5C8;
							}
							IL_68E:
							goto IL_525;
						}
						finally
						{
							num = (short)1401552897;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)920649730;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_6C6;
									}
									continue;
								case 2:
									goto IL_6FB;
								}
								IL_6C6:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1784414208;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6FB:;
						}
						goto IL_6FE;
						IL_525:
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator3 = parentNode.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﺔﺖﮞ욠욢톤", a_)).GetEnumerator();
						goto IL_545;
					}
					case 6:
						goto IL_402;
					case 7:
						goto IL_48E;
					case 8:
						description = ((global::System.Xml.Linq.XComment)parentNode.PreviousNode).Value;
						num = (short)1865744390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D;
					IL_402:
					hlpanel.Description = description;
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase>();
					enumerator2 = parentNode.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﺖﶘﲚ", a_)).GetEnumerator();
					num = (short)1242169344;
					short num4 = num;
					num = (short)1285750789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_28C:
						num = (short)1040187392;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2CE;
								}
								continue;
							case 1:
							{
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget webKitWidget;
								list.Add(webKitWidget);
								num = (short)1325137924;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget webKitWidget;
								if (webKitWidget != null)
								{
									num = (short)275709953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator3;
								if (!enumerator3.MoveNext())
								{
									num = (short)1474101253;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Xml.Linq.XElement webkitwidget = enumerator3.Current;
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget webKitWidget = this.getWebKitWidget(webkitwidget);
								num = (short)1104478210;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								num = (short)44564486;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_38C;
							}
							IL_2D0:
							num = (short)705036291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2CE:
							goto IL_2D0;
						}
						IL_38C:
						goto IL_4CB;
					}
					finally
					{
						num = (short)474087425;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator3;
							switch (num2)
							{
							case 0:
								enumerator3.Dispose();
								num = (short)2018770946;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_3C5;
								}
								continue;
							case 2:
								goto IL_3FF;
							}
							IL_3C5:
							if (enumerator3 == null)
							{
								break;
							}
							num = (short)1698824192;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3FF:;
					}
					goto IL_402;
					IL_4CB:
					enumerator = parentNode.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﺖﶘﲚ", a_)).GetEnumerator();
					num = (short)1563754500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_545:
					num = (short)119341059;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6FE:
					num = (short)652804096;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_48E:
				hlpanel.Widgets = list.OrderBy(delegate(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase a)
				{
					short num5 = (short)1418395648;
					short num6 = num5;
					num5 = (short)1249729100;
					short num7 = num5;
					num5 = (short)880892492;
					switch (num7 == num5)
					{
					}
					num5 = (short)39387137;
					if (num5 != 0)
					{
					}
					num5 = (short)1718353920;
					if (num5 != 0)
					{
					}
					return a.Y;
				}).ToList<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase>();
				return hlpanel;
				IL_5D:
				hlpanel = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel();
				hlpanel.height = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("릎", a_);
				hlpanel.pagenum = pagenum.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
				description = "";
				num = (short)1154154497;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000E530 File Offset: 0x0000C730
		private global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity getActivity(global::System.Xml.Linq.XElement stateRoot, global::System.Xml.Linq.XElement parentNode)
		{
			int a_ = 15;
			short num = (short)1960050688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_98;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase> list;
				global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity activity;
				for (;;)
				{
					IL_31:
					string description;
					global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator3;
					switch (num2)
					{
					case 0:
						goto IL_4FB;
					case 1:
						goto IL_72E;
					case 2:
						goto IL_80B;
					case 3:
						description = ((global::System.Xml.Linq.XComment)parentNode.PreviousNode).Value;
						num = (short)867368964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_267;
					case 5:
					{
						try
						{
							num = (short)404750336;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_136;
									}
									continue;
								case 1:
									goto IL_1F3;
								case 3:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget webKitWidget;
									if (webKitWidget != null)
									{
										num = (short)1077542916;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget webKitWidget;
									list.Add(webKitWidget);
									num = (short)412418050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)968622086;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.Linq.XElement webkitwidget = enumerator.Current;
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget webKitWidget = this.getWebKitWidget(webkitwidget);
									num = (short)565903363;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1891434497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_138:
								num = (short)822018053;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_136:
								goto IL_138;
							}
							IL_1F3:
							goto IL_782;
						}
						finally
						{
							num = (short)1421803521;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_264;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_22A;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1361969152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_22A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)107675650;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_264:;
						}
						goto IL_267;
						IL_782:
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2 = parentNode.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("솟튡펣쾥첧충즫\udaad", a_)).GetEnumerator();
						num = (short)916979719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_A01;
					case 7:
					{
						num = (short)302895324;
						short num3 = num;
						num = (short)1597886684;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_80B;
						default:
							num = (short)1231421440;
							if (num != 0)
							{
							}
							try
							{
								num = (short)160759808;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_336;
										}
										continue;
									case 1:
										goto IL_3F0;
									case 3:
									{
										global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1181679620;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.Linq.XElement mapwidget = enumerator2.Current;
										global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget mapWidget = this.getMapWidget(mapwidget);
										num = (short)1766588421;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										num = (short)965214209;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget mapWidget;
										if (mapWidget != null)
										{
											num = (short)873463814;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
									{
										global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget mapWidget;
										list.Add(mapWidget);
										num = (short)1393426434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_37B:
									num = (short)1308950531;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_336:
									goto IL_37B;
								}
								IL_3F0:
								goto IL_4E3;
							}
							finally
							{
								num = (short)1477181441;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
									switch (num2)
									{
									case 0:
										goto IL_45F;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_428;
										}
										continue;
									case 2:
										enumerator2.Dispose();
										num = (short)915865600;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_428:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1855586306;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_45F:;
							}
							goto IL_462;
							IL_4E3:
							num = (short)1299972096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						goto IL_565;
					case 9:
						num = (short)2009202689;
						if (num != 0)
						{
						}
						activity.screen_locked = parentNode.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("쾟송쾣쎥첧", a_)).Value;
						num = (short)133955585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (parentNode.PreviousNode.NodeType == global::System.Xml.XmlNodeType.Comment)
						{
							num = (short)699662339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_267;
					case 11:
						if (stateRoot.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("쒟", a_)) != null)
						{
							num = (short)886767628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A01;
					case 12:
						activity.state_id = stateRoot.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("쒟", a_)).Value;
						activity._Event = this.getAcitvityPanelEventByStateId(activity.state_id);
						activity.Target = activity.state_id;
						num = (short)1908604934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_462;
					case 14:
					{
						try
						{
							num = (short)1425604608;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_8D7;
									}
									continue;
								case 1:
									goto IL_991;
								case 2:
									num = (short)815464449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget appWidget;
									list.Add(appWidget);
									num = (short)623575045;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator3.MoveNext())
									{
										num = (short)768737282;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.Linq.XElement appwidget = enumerator3.Current;
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget appWidget = this.getAppWidget(appwidget);
									num = (short)1088356358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget appWidget;
									if (appWidget != null)
									{
										num = (short)1912471555;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_93E:
								num = (short)957743108;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8D7:
								goto IL_93E;
							}
							IL_991:
							goto IL_4A5;
						}
						finally
						{
							num = (short)2145714177;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_9FE;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_9C9;
									}
									continue;
								case 2:
									enumerator3.Dispose();
									num = (short)194183168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_9C9:
								if (enumerator3 == null)
								{
									break;
								}
								num = (short)431095810;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_9FE:;
						}
						goto IL_A01;
						IL_4A5:
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator = parentNode.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("얟삡쾣쾥\udca7\udda9얫쪭힯ힱ삳", a_)).GetEnumerator();
						num = (short)232128517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (parentNode.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("튟쮡쮣풥솧\udea9햫", a_)) != null)
						{
							num = (short)1449459732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80B;
					case 16:
						if (parentNode.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("쾟송톣향춧캩", a_)) != null)
						{
							num = (short)820379661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69D;
					case 17:
						if (parentNode.PreviousNode != null)
						{
							num = (short)185532437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_267;
					case 18:
						activity.screen_show = parentNode.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("좟춡펣", a_)).Value;
						num = (short)1523712008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (parentNode.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("좟춡펣", a_)) != null)
						{
							num = (short)1723203602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_565;
					case 20:
						activity.screen_priority = parentNode.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("튟쮡쮣풥솧\udea9햫", a_)).Value;
						num = (short)233832450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)1837826058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_69D;
					case 23:
						if (parentNode.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("쾟송쾣쎥첧", a_)) != null)
						{
							num = (short)1734082569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72E;
					}
					goto IL_98;
					IL_267:
					activity.Description = description;
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase>();
					enumerator3 = parentNode.Descendants(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﾝ킟튡펣쾥첧충즫\udaad", a_)).GetEnumerator();
					num = (short)833814542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_462:
					activity.screen_focused = parentNode.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("쾟송톣향춧캩", a_)).Value;
					num = (short)566165526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_565:
					num = (short)7012375;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69D:
					num = (short)1330577427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_72E:
					num = (short)1966095;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_80B:
					description = "";
					num = (short)1537015825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A01:
					num = (short)273219600;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4FB:
				num = (short)923009024;
				short num4 = num;
				activity.Widgets = list.OrderBy(delegate(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase a)
				{
					short num5 = (short)920387584;
					short num6 = num5;
					num5 = (short)367329281;
					if (num5 != 0)
					{
					}
					num5 = (short)2109898935;
					short num7 = num5;
					num5 = (short)1508409527;
					switch (num7 == num5)
					{
					}
					num5 = (short)1042677760;
					if (num5 != 0)
					{
					}
					return a.Y;
				}).ToList<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase>();
				return activity;
				IL_98:
				activity = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity();
				num = (short)99549195;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000EFF0 File Offset: 0x0000D1F0
		private global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition getTransition(global::System.Xml.Linq.XElement state, global::System.Xml.Linq.XElement sigeltransition)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition transition;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					transition._Event = sigeltransition.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)).Value;
					num2 = (short)1802567685;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)340459520;
					short num3 = num2;
					transition.Target = sigeltransition.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﺘﺚ", a_)).Value;
					num2 = (short)280166402;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_168;
				case 3:
					if (sigeltransition.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)) != null)
					{
						num2 = (short)1968046080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return transition;
				case 4:
					num2 = (short)1170866177;
					if (num2 != 0)
					{
					}
					if (sigeltransition.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﺘﺚ", a_)) != null)
					{
						goto IL_DF;
					}
					goto IL_168;
				case 5:
					return transition;
				}
				goto IL_31;
				IL_168:
				num2 = (short)1250623491;
				num = (int)((global::System.IntPtr)num2);
			}
			return transition;
			IL_31:
			num2 = (short)1802942230;
			short num4 = num2;
			num2 = (short)1581758230;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_DF:
				num2 = (short)2122973185;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)975044608;
				if (num2 != 0)
				{
				}
				transition = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Transition();
				num2 = (short)345178116;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase> getWidgetList(global::System.Xml.Linq.XElement parentNode)
		{
			short num = (short)1780504714;
			short num2 = num;
			num = (short)1166432394;
			switch (num2 == num)
			{
			}
			num = (short)1018232832;
			if (num != 0)
			{
			}
			num = (short)93192192;
			short num3 = num;
			num = (short)960626689;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase>();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000F2A8 File Offset: 0x0000D4A8
		private global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget getAppWidget(global::System.Xml.Linq.XElement appwidget)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget appWidget;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_413;
				case 1:
				{
					num2 = (short)623968256;
					short num3 = num2;
					appWidget.SpanY = this.StringConvertToInt(appwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("킟쎡쪣ﾥ", a_)).Value);
					num2 = (short)1181810688;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_300;
				case 3:
					goto IL_27D;
				case 4:
					if (appWidget.WidgetItemType == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.unknown)
					{
						num2 = (short)1568735251;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return appWidget;
				case 5:
					appWidget.ClassName = appwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﶝ첟쎡힣향쮩솫쮭", a_)).Value;
					num2 = (short)1778581513;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (appwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)) != null)
					{
						num2 = (short)685178894;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E8;
				case 7:
					if (appwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("솟송쾣장쾧쾩쾭\uddafힱ", a_)) != null)
					{
						num2 = (short)244711432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_265;
				case 8:
					num2 = (short)1024851969;
					if (num2 != 0)
					{
					}
					appWidget.PackageName = appwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("솟송쾣장쾧쾩쾭\uddafힱ", a_)).Value;
					num2 = (short)296353804;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_37A;
				case 10:
					if (appwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)) != null)
					{
						num2 = (short)1369964562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C3;
				case 11:
					if (appwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("킟쎡쪣ﾥ", a_)) != null)
					{
						num2 = (short)2083913729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_413;
				case 12:
					goto IL_265;
				case 13:
					appWidget.SpanX = this.StringConvertToInt(appwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("킟쎡쪣ﺥ", a_)).Value);
					num2 = (short)1655177218;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					appWidget.X = this.StringConvertToInt(appwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)).Value);
					num2 = (short)1436483599;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_E8;
				case 16:
					if (appwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("킟쎡쪣ﺥ", a_)) != null)
					{
						num2 = (short)704839693;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_300;
				case 17:
					goto IL_1C3;
				case 18:
					appWidget.Y = this.StringConvertToInt(appwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)).Value);
					num2 = (short)489029649;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
				{
					num2 = (short)353373398;
					short num4 = num2;
					num2 = (short)1102908630;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_27D;
					default:
						goto IL_24A;
					}
					break;
				}
				}
				goto IL_69;
				IL_E8:
				num2 = (short)763756554;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C3:
				appWidget.WidgetItemType = this.GetWidgetItemTypeByClassName(appWidget.ClassName, appWidget.SpanY);
				num2 = (short)173801476;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_265:
				num2 = (short)1885995011;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_27D:
				if (appwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﶝ첟쎡힣향쮩솫쮭", a_)) != null)
				{
					num2 = (short)16515077;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_37A;
				IL_300:
				num2 = (short)981336075;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_37A:
				num2 = (short)331677712;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_413:
				num2 = (short)496173062;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_24A:
			num2 = (short)1059127296;
			if (num2 != 0)
			{
			}
			return null;
			IL_69:
			appWidget = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget();
			num2 = (short)1792606215;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
		private global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget getWebKitWidget(global::System.Xml.Linq.XElement webkitwidget)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_7D;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget webKitWidget;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (webkitwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("얜", a_)) != null)
					{
						num2 = (short)513409037;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_141;
				case 1:
					goto IL_22C;
				case 2:
					if (webkitwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)) != null)
					{
						num2 = (short)103809032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_372;
				case 3:
					if (webKitWidget.SpanY == 1)
					{
						num2 = (short)275775488;
						short num3 = num2;
						num2 = (short)2055077895;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)12058625;
					if (num2 != 0)
					{
					}
					webKitWidget.WidgetItemType = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingSimple;
					num2 = (short)476839956;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_332;
				case 5:
					if (webKitWidget.WidgetItemType == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.unknown)
					{
						num2 = (short)1502216202;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_518;
				case 6:
					goto IL_372;
				case 7:
					webKitWidget.WidgetItemType = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingSimple;
					num2 = (short)1884487681;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					webKitWidget.X = this.StringConvertToInt(webkitwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)).Value);
					num2 = (short)891224070;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_22C;
				case 10:
					goto IL_36D;
				case 11:
					webKitWidget.WidgetItemType = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingAdv;
					num2 = (short)1025245193;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (webkitwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)) != null)
					{
						num2 = (short)1590820886;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D9;
				case 13:
					webKitWidget.SpanX = this.StringConvertToInt(webkitwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("얜", a_)).Value);
					num2 = (short)1992687635;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (webKitWidget.SpanY <= 6)
					{
						num2 = (short)956694539;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_282;
				case 15:
					num2 = (short)337969166;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (webkitwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)) != null)
					{
						num2 = (short)983236632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_332;
				case 17:
					webKitWidget.SpanY = this.StringConvertToInt(webkitwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("쒜", a_)).Value);
					num2 = (short)1875640343;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					goto IL_1D9;
				case 19:
					goto IL_141;
				case 20:
					goto IL_22C;
				case 21:
					if (webkitwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("쒜", a_)) != null)
					{
						num2 = (short)182779921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22C;
				case 22:
					webKitWidget.Url = webkitwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)).Value;
					num2 = (short)1797718034;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					if (webKitWidget.SpanY > 2)
					{
						num2 = (short)1569521679;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_282;
				case 24:
					webKitWidget.Y = this.StringConvertToInt(webkitwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)).Value);
					num2 = (short)1056243716;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_7D;
				IL_141:
				num2 = (short)2022178837;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1D9:
				num2 = (short)1450967040;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_22C:
				num2 = (short)492699650;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_282:
				num2 = (short)1309540355;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_332:
				num2 = (short)1266483205;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_372:
				num2 = (short)1863516176;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_36D:
			return null;
			IL_518:
			num2 = (short)55816722;
			short num4 = num2;
			num2 = (short)338997778;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_36D;
			default:
				num2 = (short)1559166976;
				if (num2 != 0)
				{
				}
				return webKitWidget;
			}
			IL_7D:
			webKitWidget = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WebKitWidget();
			num2 = (short)1344995340;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000FD18 File Offset: 0x0000DF18
		private global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget getMapWidget(global::System.Xml.Linq.XElement mapwidget)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget mapWidget;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_292;
				case 1:
					if (mapwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮙ욝", a_)) != null)
					{
						num2 = (short)1418526722;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_32B;
				case 2:
					num2 = (short)360251393;
					if (num2 != 0)
					{
					}
					mapWidget.SpanX = this.StringConvertToInt(mapwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮙ욝", a_)).Value);
					num2 = (short)1781137414;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)309101605;
					short num3 = num2;
					num2 = (short)1629127717;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E5;
					default:
						num2 = (short)131006464;
						if (num2 != 0)
						{
						}
						mapWidget.Y = this.StringConvertToInt(mapwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)).Value);
						num2 = (short)1952907271;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
				{
					num2 = (short)1767374848;
					short num4 = num2;
					mapWidget.MapType = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ScxmlParser.GetMapTypeByString(mapwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("鍊", a_)).Value);
					num2 = (short)1078853640;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					mapWidget.SpanY = this.StringConvertToInt(mapwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮙ잝", a_)).Value);
					num2 = (short)1325727744;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_3E5;
				case 7:
					goto IL_326;
				case 8:
					goto IL_138;
				case 9:
					if (mapwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)) != null)
					{
						num2 = (short)1007484931;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3EA;
				case 10:
					if (mapwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)) != null)
					{
						num2 = (short)765591566;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_189;
				case 11:
					goto IL_189;
				case 12:
					if (mapwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("鍊", a_)) != null)
					{
						num2 = (short)80805892;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_138;
				case 13:
					if (mapwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮙ잝", a_)) != null)
					{
						num2 = (short)326828037;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_292;
				case 14:
					mapWidget.X = this.StringConvertToInt(mapwidget.Attribute(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("", a_)).Value);
					num2 = (short)1458503691;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_55;
				IL_138:
				num2 = (short)184549377;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_189:
				num2 = (short)1992359945;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_292:
				num2 = (short)1422983178;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_32B:
				num2 = (short)1897463821;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3E5:
				goto IL_32B;
			}
			IL_326:
			IL_3EA:
			mapWidget.WidgetItemType = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingAdv;
			return mapWidget;
			IL_55:
			mapWidget = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget();
			num2 = (short)1532559372;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00010118 File Offset: 0x0000E318
		private static global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType GetMapTypeByString(string typeString)
		{
			int a_ = 15;
			short num = (short)54984714;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)144703490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)974323712;
					short num3 = num;
					num = (short)173801484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.Unconfigured;
				case 3:
					if (!(typeString == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("펝솟튡쾥춧\udda9", a_)))
					{
						num = (short)1462435841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.MapView;
				case 4:
					if (!(typeString == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("솟튡튣쾥춧\udda9", a_)))
					{
						num = (short)26279943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.MapView;
				case 5:
				{
					num = (short)777794083;
					short num4 = num;
					num = (short)1478308387;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_78;
					default:
						num = (short)1691222016;
						if (num != 0)
						{
						}
						num = (short)2058878982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					if (!(typeString == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("힝캟송춣슥춧쒩\ud8ab\udfaf톱햳습톷햹튻", a_)))
					{
						num = (short)186974216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.IncidentLocation;
				case 7:
					num = (short)1275527171;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)1496776705;
					if (num != 0)
					{
					}
					num = (short)94961668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (!(typeString == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("펝\ud99f쮣얥즧\udea9얫솭\udeaf", a_)))
					{
						num = (short)52035584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.MyLocation;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 11:
					num = (short)1686765577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (!(typeString == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("\ud99f캡쮣얥즧\udea9얫솭\udeaf", a_)))
					{
						num = (short)1722548235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.MyLocation;
				}
				goto IL_62;
				IL_78:
				num = (short)638517253;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_62:
				if (!(typeString == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("캟송춣슥춧쒩\ud8ab슭\udfaf톱햳습톷햹튻", a_)))
				{
					goto IL_78;
				}
				break;
			}
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.IncidentLocation;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000103F4 File Offset: 0x0000E5F4
		private string getAcitvityPanelEventByStateId(string state_id)
		{
			short num = (short)1139590074;
			short num2 = num;
			num = (short)312591290;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1274544129;
				if (num != 0)
				{
				}
				num = (short)63504384;
				short num3 = num;
				num = (short)1139474432;
				if (num != 0)
				{
				}
				string @event;
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.TransitionSetting>.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant.WD.transitionlist.GetEnumerator())
				{
					num = (short)1145765892;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.TransitionSetting transitionSetting;
							if (transitionSetting.Target == state_id)
							{
								num = (short)828112902;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1855586306;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.TransitionSetting transitionSetting = enumerator.Current;
							num = (short)635109376;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)575537155;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_1A7;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_F3;
							}
							continue;
						case 5:
							goto IL_18D;
						case 6:
						{
							global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.TransitionSetting transitionSetting;
							@event = transitionSetting._Event;
							num = (short)67960837;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_F5:
						num = (short)1599733761;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_F3:
						goto IL_F5;
					}
					IL_18D:
					return @event;
					IL_1A7:
					break;
				}
				return @event;
			}
			}
			return "";
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000105CC File Offset: 0x0000E7CC
		private global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType GetWidgetItemTypeByClassName(string className, int YSpan)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_191;
			}
			int num;
			short num2;
			uint num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧\ud9a9쎫슭얯욱\uddb3\ud9b5횷즹銻펽ꢿ뫁ꯅ뇇ꯉ볋뻍ꏏﳑꏓ뿕볗뷙맛ꫝ컟ꇡ诣铥跧ꯩ鳫黭華ꗱ鷳鋵鿷鿹裻껽狿洁爃漅氇漉縋", a_)))
					{
						num2 = (short)729677848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3AE;
				case 1:
					num2 = (short)822804536;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1167065181;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧\ud9a9쎫슭얯욱\uddb3\ud9b5횷즹銻펽ꢿ뫁ꗅ꧇ꛉ꧋ꃍ듏돑ꛓꇕ뇗뻙믛믝铟쳡韣迥藧髩胫语꟯鯱郳釵鷷軹틻뷽懿渁愃栅氇欉縋复礏瘑猓猕気䨙減焝嘟䬡䀣䌥娧", a_)))
					{
						num2 = (short)1077870650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarSimple;
				case 4:
					num2 = (short)1287323657;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_B12;
				case 6:
					num2 = (short)2074542125;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)74448923;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1317077044;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					if (num3 == 2862887314U)
					{
						num2 = (short)2054291485;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)15833914;
					short num4 = num2;
					num2 = (short)1684314938;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CDD;
					default:
						num2 = (short)1158807552;
						if (num2 != 0)
						{
						}
						num2 = (short)301531220;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 10:
					goto IL_717;
				case 11:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧\ud9a9쎫슭얯욱\uddb3\ud9b5횷즹銻펽ꢿ뫁ꗅ꧇ꛉ꧋ꃍ듏돑ꛓꇕ뇗뻙믛믝铟쳡꟣蟥蓧迩苫諭釯胱룳鿵请軹꯻韽擿攁愃爅堇砉挋砍礏瘑焓搕", a_)))
					{
						num2 = (short)455868418;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarAdv;
				case 12:
					num2 = (short)813170757;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					num2 = (short)787218442;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_80F;
				case 15:
					num2 = (short)1205862473;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					num2 = (short)979173453;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (num3 <= 2962534187U)
					{
						num2 = (short)704839684;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)306905107;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧蒩\udcab龭\ud8af\udab1쎳\udfb5\udcb7\uddb9\ud9bb쪽뎿듃듅Ꟈ볉ꗋ꫍뗏ꃑ䀘鿕뛗맙뗛뫝藟賡郣ꯥ蟧蓩藫髭鿯胱ꓳ蓵韷賹闻髽旿瀁", a_)))
					{
						num2 = (short)1077936198;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wStatusMonitor;
				case 19:
					if (num3 != 3320919761U)
					{
						num2 = (short)361103413;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1670971410;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧\ud9a9쎫슭얯욱\uddb3\ud9b5횷즹銻펽ꖿ뇁럃Ʂ꿇ꏉꋋ꧍ﻏꗑ뷓닕뿗뿙꣛돟诡解雥蓧迩ꇫ语華臱闳釵釷铹鯻ꧽ槿昁挃挅簇娉縋愍昏笑瀓猕樗", a_)))
					{
						num2 = (short)600965167;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingSimple;
				case 21:
					if (num3 != 507125655U)
					{
						num2 = (short)95551562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)130547723;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (num3 != 3990210273U)
					{
						num2 = (short)147849224;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)337117256;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					if (num3 <= 3975413496U)
					{
						num2 = (short)716505170;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)864157718;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					num2 = (short)2038038590;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧\ud9a9쎫슭얯욱\uddb3\ud9b5횷즹銻펽ꆿ닁듃꿅ꛇ귉ꟍ뿏ﳑꏓ뿕볗뷙맛ꫝ컟꿡藣雥飧菩苫觭꟯鯱郳釵鷷軹곻賽濿琁洃戅洇砉", a_)))
					{
						num2 = (short)309002255;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingSimple;
				case 26:
					if (num3 <= 532790571U)
					{
						num2 = (short)848232528;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1991442480;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					goto IL_6BB;
				case 28:
					if (num3 != 532790571U)
					{
						num2 = (short)1462173755;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)668073987;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧\ud9a9쎫슭얯욱\uddb3\ud9b5횷즹銻펽ꢿ뫁ꯅ뇇막룋꿍꓏ꟑꟓꇕ뇗뻙믛믝铟쳡ꧣ鿥믧黩跫髭藯臱ꏳ鿵鳷鷹駻諽", a_)))
					{
						num2 = (short)1716060251;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyStatus;
				case 30:
					goto IL_D7B;
				case 31:
					goto IL_D10;
				case 32:
					if (num3 != 2061147780U)
					{
						num2 = (short)42467418;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)602734612;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					num2 = (short)2043215910;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					num2 = (short)1919221846;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					if (num3 <= 3919165290U)
					{
						num2 = (short)1522597928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)942669847;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					goto IL_E2D;
				case 37:
					num2 = (short)1898971141;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 38:
					goto IL_799;
				case 39:
					goto IL_DB8;
				case 40:
					num2 = (short)65077265;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗躟킡횣얥蚧ﺫ펱\ud8b3\uddb5ﾷ좹펻쮽낿蛁귃뗅룇ꛉ귋럍蟏믑냓뇕뷗껙賛곝迟铡跣若跧飩", a_)))
					{
						num2 = (short)1335296001;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wRadio;
				case 42:
					if (num3 != 3975413496U)
					{
						num2 = (short)1493106732;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1524826201;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					goto IL_AD9;
				case 44:
					num2 = (short)130416676;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 45:
					goto IL_DD4;
				case 46:
					goto IL_7F3;
				case 47:
					num2 = (short)541982734;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 48:
					if (num3 != 832374227U)
					{
						num2 = (short)344850487;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)982909013;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 49:
					num2 = (short)1210449921;
					if (num2 != 0)
					{
					}
					num2 = (short)1194262582;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 50:
					if (num3 != 2962534187U)
					{
						num2 = (short)2059927635;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)150732841;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 51:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧\ud9a9쎫슭얯욱\uddb3\ud9b5횷즹銻펽ꢿ뫁ꯅ귇막뿋꿍럏믑뫓뇕귙뗛뫝蟟蟡郣죥믧菩臫黭鳯韱맳鏵请觹鷻駽槿氁挃儅愇渉欋欍搏䈑易礕渗猙砛笝刟", a_)))
					{
						num2 = (short)492568610;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingSimple;
				case 52:
					if (num3 != 4261842917U)
					{
						num2 = (short)1520959545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)113836108;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 53:
					num2 = (short)594542658;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 54:
					if (num3 != 190334312U)
					{
						num2 = (short)758120509;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2040201216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 55:
					num2 = (short)869728288;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 56:
					goto IL_D98;
				case 57:
					num2 = (short)1191903262;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 58:
					num2 = (short)1377108043;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 59:
					num2 = (short)34078788;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 60:
					if (num3 != 354959009U)
					{
						num2 = (short)665124870;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)978321495;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 61:
					num2 = (short)85917756;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 62:
					goto IL_540;
				case 63:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧蒩\udcab龭\ud8af\udab1쎳\udfb5\udcb7\uddb9\ud9bb쪽뎿듃듅Ꟈ볉ꗋ꫍뗏ꃑ䀘蟕귗뿙껛꟝냟郡诣郥臧軩觫鳭", a_)))
					{
						num2 = (short)1604059224;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wQuery;
				case 64:
					goto IL_3A7;
				case 65:
					num2 = (short)1274347562;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 66:
					if (num3 != 3919165290U)
					{
						num2 = (short)790036487;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)167837721;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 67:
					num2 = (short)652279879;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 68:
					goto IL_31C;
				case 69:
					goto IL_BBE;
				case 70:
					num2 = (short)1539768366;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 71:
					if (num3 != 40489557U)
					{
						num2 = (short)1977090097;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)875167807;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 72:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧\ud9a9쎫슭얯욱\uddb3\ud9b5횷즹銻펽ꢿ뫁뗅귇ꯉ뻋귍룏ﳑꏓ뿕볗뷙맛ꫝ컟뇡臣蟥髧觩蓫맭駯雱鏳鏵賷꫹軻釽盿欁怃挅稇", a_)))
					{
						num2 = (short)2088894477;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wSearch;
				case 73:
					goto IL_660;
				case 74:
					num2 = (short)956891164;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 75:
					goto IL_5C5;
				case 76:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧蒩\udcab龭\ud8af\udab1쎳\udfb5\udcb7\uddb9\ud9bb쪽뎿듃듅Ꟈ볉ꗋ꫍뗏ꃑ䀘鯕ꇗ鏙닛뷝觟蛡臣裥鳧뫩黫臭蛯鯱郳鏵諷", a_)))
					{
						num2 = (short)1635188748;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyIncident;
				case 77:
					if (num3 <= 354959009U)
					{
						num2 = (short)1119617091;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2096562202;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 78:
					if (num3 != 3958494475U)
					{
						num2 = (short)101449793;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)958398515;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 79:
					goto IL_389;
				case 80:
					num2 = (short)259325973;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 81:
					if (num3 <= 2061147780U)
					{
						num2 = (short)1437663248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1083441187;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 82:
					num2 = (short)163250254;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 83:
					num2 = (short)1764425792;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 84:
					num2 = (short)320929842;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 85:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧\ud9a9쎫슭얯욱\uddb3\ud9b5횷즹銻펽ꢿ뫁ꯅ귇막뿋꿍럏믑뫓뇕귙뗛뫝蟟蟡郣죥ꧧ軩髫迭黯釱釳鋵뗷鿹迻跽懿攁洃栅漇崉攋樍眏眑怓䘕樗甙樛眝䐟䜡嘣", a_)))
					{
						num2 = (short)987562021;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingAdv;
				case 86:
					goto IL_5A8;
				case 87:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧\ud9a9쎫슭얯욱\uddb3\ud9b5횷즹銻펽ꢿ뫁ꯅ뇇ꯉ볋뻍ꏏﳑꏓ뿕볗뷙맛ꫝ컟꿡鷣꟥飧髩鿫맭駯雱鏳鏵賷꫹軻釽盿欁怃挅稇", a_)))
					{
						goto IL_CDD;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyApps;
				case 88:
					num2 = (short)746192927;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 89:
					if (!(className == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮓﮕ뚗쾟킡쮣쪥즧\ud9a9쎫슭얯욱\uddb3\ud9b5횷즹銻펽ꖿ뇁럃Ʂ꿇ꏉꋋ꧍ﻏꗑ뷓닕뿗뿙꣛ꇟ蛡鋣蟥蛧觩觫諭뷯韱蟳藵駷鷹闻都柿唁洃戅漇漉砋帍戏紑戓缕簗缙減", a_)))
					{
						num2 = (short)319881249;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingAdv;
				case 90:
					num2 = (short)1601175595;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 91:
					num2 = (short)621150287;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 92:
					num2 = (short)307626023;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 93:
					goto IL_AF5;
				}
				goto IL_191;
				IL_CDD:
				num2 = (short)1520173148;
				num = (int)((global::System.IntPtr)num2);
			}
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingSimple;
			IL_31C:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.unknown;
			IL_389:
			IL_3A7:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.unknown;
			IL_3AE:
			num2 = (short)689373184;
			short num5 = num2;
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCoreApp;
			IL_540:
			IL_5A8:
			IL_5C5:
			IL_660:
			IL_6BB:
			IL_717:
			IL_799:
			IL_7F3:
			IL_80F:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.unknown;
			IL_AD9:
			IL_AF5:
			IL_B12:
			IL_BBE:
			IL_D10:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.unknown;
			IL_D7B:
			IL_D98:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.unknown;
			IL_DB8:
			IL_DD4:
			IL_E2D:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.unknown;
			IL_191:
			num3 = global::<PrivateImplementationDetails>.ComputeStringHash(className);
			num2 = (short)1021116497;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0001145C File Offset: 0x0000F65C
		public string GetPackageNameByWidgetItemTypeAndSize(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType itemType, int XSpan, int YSpan)
		{
			int a_ = 7;
			short num = (short)35258368;
			short num2 = num;
			num = (short)154337281;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)571959088;
					short num4 = num;
					num = (short)1771333424;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_153;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 2:
					num = (short)617349120;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_62:
				num = (short)1881735169;
				if (num != 0)
				{
				}
				switch (itemType)
				{
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyStatus:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wSearch:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarSimple:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarAdv:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyApps:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCoreApp:
					goto IL_F7;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wQuery:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyIncident:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wStatusMonitor:
					goto IL_188;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wRadio:
					goto IL_E8;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingSimple:
					goto IL_16A;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingAdv:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMapNoType:
					goto IL_197;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingSimple:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingAdv:
					goto IL_179;
				default:
					num = (short)538050562;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E8:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("늛쾟횡쮣풥잧용춫\uddad\udfaf\udeb1솳습톷햹튻춽냁ꗃꋅꇇꗉ뿋ꯍꋏꓑ뷓뗕뷗꧙", a_);
			IL_F7:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("늛쾟횡쮣풥잧용춫\uddad\udfaf\udeb1솳습톷햹튻춽꿁곃뻅", a_);
			IL_153:
			num = (short)1506410496;
			if (num != 0)
			{
			}
			goto IL_197;
			IL_16A:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("늛쾟횡쮣풥잧용춫\uddad\udfaf\udeb1솳습톷햹튻춽꿁ꗃ뛅룇ꏉꋋ꧍", a_);
			IL_179:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("늛쾟횡쮣풥잧용춫\uddad\udfaf\udeb1솳습톷햹튻춽꿁ꇃ뗅믇ꯉꯋꟍ뻏뗑", a_);
			IL_188:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("늛쾟횡쮣풥잧용춫肭삯莱\udcb3\udeb5", a_);
			IL_197:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("늛쾟횡쮣풥잧용춫\uddad\udfaf\udeb1솳습톷햹튻춽꿁곃뻅", a_);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00011610 File Offset: 0x0000F810
		public string GetClassNameByWidgetItemTypeAndSize(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType itemType, int XSpan, int YSpan)
		{
			int a_ = 6;
			short num;
			for (;;)
			{
				num = (short)2123497473;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1FE;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3B;
						}
						continue;
					case 2:
						num = (short)808910848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3B:
					switch (itemType)
					{
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyStatus:
						goto IL_200;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wQuery:
						goto IL_1C8;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyIncident:
						goto IL_98;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wStatusMonitor:
						goto IL_133;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wRadio:
						goto IL_ED;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wSearch:
						goto IL_160;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingSimple:
						goto IL_142;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingAdv:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMapNoType:
						goto IL_20F;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingSimple:
						goto IL_FC;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingAdv:
						goto IL_B6;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarSimple:
						goto IL_A7;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarAdv:
						goto IL_151;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyApps:
						goto IL_1D7;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCoreApp:
						goto IL_1B9;
					default:
						num = (short)1005060098;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_160:
				num = (short)234385407;
				short num3 = num;
				num = (short)1213034495;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_194;
				}
			}
			IL_98:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚햠첢힤좦얨쪪莬\udfae肰\udbb2\uddb4삶킸\udfba\udabc\udabe뗀냂럆믈꓊믌ꛎ뗐뛒꟔淪铘ꋚ铜뇞苠諢臤苦蟨鿪뷬鷮黰藲鳴鏶鳸觺", a_);
			IL_A7:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚햠첢힤좦얨쪪\udeac삮\uddb0욲솴\udeb6횸햺캼醾곀ꯂ뷄꫈꫊ꇌ꫎뿐럒듔ꗖ께닚맜룞蓠韢쯤铦胨蛪鷬菮铰ꓲ鳴鏶黸黺觼퇾䈀戂椄戆月漊氌紎䘐稒焔瀖簘漚䴜洞丠唢䰤䌦䰨太", a_);
			IL_B6:
			num = (short)1567227905;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚햠첢힤좦얨쪪\udeac삮\uddb0욲솴\udeb6횸햺캼醾곀ꛂ뛄듆꣈곊꓌ꇎ뛐﷒ꋔ뻖뷘볚룜ꯞ쿠ꋢ臤釦裨藪軬諮闰뻲郴蓶諸髺髼雾漀搂刄渆洈氊栌笎䄐愒稔愖瀘缚砜洞", a_);
			IL_ED:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚좠趢힤햦쪨薪ﾬﶮ풴\udbb6트ﲺ쾼킾듀돂臄껆뫈믊ꇌ껎꣐蓒볔돖뻘뻚꧜连鏠賢鏤軦跨軪鿬", a_);
			IL_FC:
			num = (short)199491584;
			short num4 = num;
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚햠첢힤좦얨쪪\udeac삮\uddb0욲솴\udeb6횸햺캼醾곀ꛂ뛄듆꣈곊꓌ꇎ뛐﷒ꋔ뻖뷘볚룜ꯞ쿠냢賤諦駨蟪裬ꋮ铰胲蛴零黸鋺鏼飾嘀樂愄怆氈缊崌紎縐攒簔猖簘椚", a_);
			IL_133:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚햠첢힤좦얨쪪莬\udfae肰\udbb2\uddb4삶킸\udfba\udabc\udabe뗀냂럆믈꓊믌ꛎ뗐뛒꟔淪郘뗚뻜뛞藠蛢诤鏦ꓨ蓪菬蛮藰鳲蟴ꟶ诸铺诼雾攀昂眄", a_);
			IL_142:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚햠첢힤좦얨쪪\udeac삮\uddb0욲솴\udeb6횸햺캼醾곀ꋂ뗄럆ꃈꗊ꫌룐볒ﯔꃖ냘뿚뫜뫞闠췢꣤蛦駨鯪蓬臮雰ꓲ鳴鏶黸黺觼꿾猀氂猄渆洈渊缌", a_);
			IL_151:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚햠첢힤좦얨쪪\udeac삮\uddb0욲솴\udeb6횸햺캼醾곀ꯂ뷄꫈꫊ꇌ꫎뿐럒듔ꗖ께닚맜룞蓠韢쯤ꓦ裨蟪裬臮闰鋲蟴믶郸裺觼ꣾ栀朂戄戆紈嬊缌怎朐稒焔爖欘", a_);
			IL_194:
			num = (short)1738473472;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚햠첢힤좦얨쪪\udeac삮\uddb0욲솴\udeb6횸햺캼醾곀ꯂ뷄뫈껊곌뷎닐믒ﯔꃖ냘뿚뫜뫞闠췢뛤苦裨駪軬蟮꛰髲釴郶鳸迺근跾渀甂氄挆氈礊", a_);
			IL_1B9:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚햠첢힤좦얨쪪\udeac삮\uddb0욲솴\udeb6횸햺캼醾곀ꯂ뷄꓈닊곌뿎ꇐꃒﯔꃖ냘뿚뫜뫞闠췢ꛤ裦鯨軪곬鿮臰胲ꋴ黶鷸鳺飼课儀焂樄焆怈漊栌紎", a_);
			IL_1C8:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚햠첢힤좦얨쪪莬\udfae肰\udbb2\uddb4삶킸\udfba\udabc\udabe뗀냂럆믈꓊믌ꛎ뗐뛒꟔淪裘껚룜귞飠돢韤裦鿨苪觬諮菰", a_);
			IL_1D7:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚햠첢힤좦얨쪪\udeac삮\uddb0욲솴\udeb6횸햺캼醾곀ꯂ뷄꓈닊곌뿎ꇐꃒﯔꃖ냘뿚뫜뫞闠췢꣤黦꣨鯪鷬鳮꛰髲釴郶鳸迺근跾渀甂氄挆氈礊", a_);
			IL_1FE:
			goto IL_20F;
			IL_200:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("떚햠첢힤좦얨쪪\udeac삮\uddb0욲솴\udeb6횸햺캼醾곀ꯂ뷄꓈닊뻌믎냐꟒ꃔꓖ께닚맜룞蓠韢쯤ꫦ部룪駬軮藰蛲蛴ꃶ郸鿺髼髾甀", a_);
			IL_20F:
			return string.Empty;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00011834 File Offset: 0x0000FA34
		public string GetMapTypeByMapItemType(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType mapItemType)
		{
			int a_ = 13;
			for (;;)
			{
				IL_09:
				short num = (short)17563648;
				short num2 = num;
				num = (short)1823473665;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)265191497;
					short num4 = num;
					num = (short)108036169;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_09;
					default:
						num = (short)1472462848;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_134;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_AC;
							}
							continue;
						case 2:
							num = (short)965869569;
							if (num != 0)
							{
							}
							num = (short)1123221504;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_AC:
						switch (mapItemType)
						{
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.MapView:
							goto IL_D9;
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.MyLocation:
							goto IL_E8;
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.IncidentLocation:
							goto IL_136;
						default:
							num = (short)1903624194;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
				}
			}
			IL_D9:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("톛ﾝ킟춣쎥\udfa7", a_);
			IL_E8:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("톛춡잣장\udca7쎩쎫삭", a_);
			IL_134:
			return string.Empty;
			IL_136:
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("햛쎟쮡삣쎥욧\udea9솭펯펱삳\udfb5ힷ풹", a_);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0001198C File Offset: 0x0000FB8C
		private int StringConvertToInt(string str)
		{
			short num = (short)255393792;
			short num2 = num;
			num = (short)1224142667;
			short num3 = num;
			num = (short)748154699;
			int result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)242352129;
				if (num != 0)
				{
				}
				num = (short)1621884928;
				if (num != 0)
				{
				}
				result = 0;
				try
				{
					result = global::System.Convert.ToInt32(str, global::System.Globalization.CultureInfo.CurrentCulture);
				}
				catch (global::System.Exception)
				{
				}
				break;
			}
			return result;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00011A5C File Offset: 0x0000FC5C
		public void FileSignature(string filePath, string signaturePath, string cerfilePath)
		{
			int a_ = 5;
			short num = (short)467206144;
			short num2 = num;
			num = (short)969570507;
			short num3 = num;
			num = (short)24934603;
			switch (num3 == num)
			{
			}
			num = (short)995885056;
			if (num != 0)
			{
			}
			num = (short)2072444929;
			if (num != 0)
			{
			}
			byte[] input = global::System.IO.File.ReadAllBytes(filePath);
			string privateKey = global::System.IO.File.ReadAllText(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮝ\ud99f財풣쎥얧", a_));
			byte[] bytes = input.Sign(privateKey, global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("煉秊첟쎡", a_));
			global::System.IO.File.WriteAllBytes(signaturePath, bytes);
		}
	}
}
