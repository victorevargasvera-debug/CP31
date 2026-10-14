using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using AcpCryptoLib;
using ASK.Interface;
using Motorola.CommonCPS.ResourceRepository;

namespace ASK.Core
{
	// Token: 0x02000017 RID: 23
	public static class FeatureSchemaManager
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00012CD8 File Offset: 0x00010ED8
		static FeatureSchemaManager()
		{
			short num = (short)154075137;
			if (num != 0)
			{
			}
			num = (short)2121515081;
			short num2 = num;
			num = (short)1749270601;
			switch (num2 == num)
			{
			default:
			{
				num = (short)299565056;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)967901184;
			if (num != 0)
			{
			}
			global::ASK.Core.FeatureSchemaManager.a = null;
			global::ASK.Core.FeatureSchemaManager.b = new global::System.Type[9];
			global::ASK.Core.FeatureSchemaManager.c = null;
			global::ASK.Core.FeatureSchemaManager.b[0] = typeof(global::ASK.Core.FeatureCategory);
			global::ASK.Core.FeatureSchemaManager.b[1] = typeof(global::ASK.Core.AccessNode);
			global::ASK.Core.FeatureSchemaManager.b[2] = typeof(global::ASK.Core.AccessSection);
			global::ASK.Core.FeatureSchemaManager.b[3] = typeof(global::ASK.Core.AccessField);
			global::ASK.Core.FeatureSchemaManager.b[4] = typeof(global::ASK.Core.AccessOperation);
			global::ASK.Core.FeatureSchemaManager.b[5] = typeof(global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessNode>);
			global::ASK.Core.FeatureSchemaManager.b[6] = typeof(global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessSection>);
			global::ASK.Core.FeatureSchemaManager.b[7] = typeof(global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessField>);
			global::ASK.Core.FeatureSchemaManager.b[8] = typeof(global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessOperation>);
			global::ASK.Core.FeatureSchemaManager.c();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00012E34 File Offset: 0x00011034
		internal static void c()
		{
			short num = (short)654114817;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EF;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
					return;
				}
				IL_32:
				num = (short)1567959967;
				short num3 = num;
				num = (short)494218143;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_EF:
					global::ASK.Core.FeatureSchemaManager.b();
					num = (short)1784676354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					break;
				default:
				{
					num = (short)579862528;
					short num4 = num;
					break;
				}
				}
				num = (short)1871970304;
				if (num != 0)
				{
				}
				num = (short)1404633089;
				if (num != 0)
				{
				}
				if (global::ASK.Core.FeatureSchemaManager.a != null)
				{
					break;
				}
				num = (short)801243136;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00012F50 File Offset: 0x00011150
		private static void b()
		{
			int a_ = 0;
			for (;;)
			{
				IL_09:
				global::System.Windows.MessageBoxOptions options = global::System.Windows.MessageBoxOptions.None;
				try
				{
					short num = (short)1132920835;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1D1;
						case 1:
							goto IL_1E9;
						case 2:
							options = (global::System.Windows.MessageBoxOptions.RightAlign | global::System.Windows.MessageBoxOptions.RtlReading);
							num = (short)1491599364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_16F;
							}
							continue;
						case 4:
							goto IL_1D1;
						}
						IL_16F:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)105644034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						options = global::System.Windows.MessageBoxOptions.None;
						num = (short)1407909888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D1:
						num = (short)999424001;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1E9:
					goto IL_97;
				}
				catch
				{
					goto IL_97;
				}
				break;
				for (;;)
				{
					IL_97:
					short num = (short)935854080;
					short num3 = num;
					num = (short)1269399444;
					short num4 = num;
					num = (short)437354388;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_09;
					default:
						num = (short)1678639104;
						if (num != 0)
						{
						}
						num = (short)32505857;
						if (num != 0)
						{
						}
						try
						{
							string inputFileName = global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, global::ASK.Core.StatusMsg.b("崻䴽⬿⍁⡃⭅穇㩉手ⵍ⁏⅑", a_));
							global::System.Xml.XmlNodeReader xmlReader = new global::System.Xml.XmlNodeReader(new global::AcpCryptoLib.AcpXMLEncryptDecrypt().DecryptXMLFile(inputFileName).DocumentElement);
							global::ASK.Core.FeatureSchemaManager.a = (global::System.Collections.ArrayList)new global::System.Xml.Serialization.XmlSerializer(typeof(global::System.Collections.ArrayList), global::ASK.Core.FeatureSchemaManager.b).Deserialize(xmlReader);
							global::ASK.Core.FeatureSchemaManager.a();
							return;
						}
						catch (global::System.Exception)
						{
							global::System.Windows.MessageBox.Show(global::Motorola.CommonCPS.ResourceRepository.Resources.Critical_File_Missing, global::Motorola.CommonCPS.ResourceRepository.Resources.Warning_Id, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Hand, global::System.Windows.MessageBoxResult.OK, options);
							global::System.Environment.Exit(3073);
							return;
						}
						break;
					}
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00013170 File Offset: 0x00011370
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0001321C File Offset: 0x0001141C
		public static global::System.Collections.ArrayList FeatureCategories
		{
			get
			{
				short num = (short)239609790;
				short num2 = num;
				num = (short)1689855934;
				switch (num2 == num)
				{
				}
				num = (short)301858816;
				short num3 = num;
				num = (short)453640192;
				if (num != 0)
				{
				}
				num = (short)910557185;
				if (num != 0)
				{
				}
				return global::ASK.Core.FeatureSchemaManager.a;
			}
			set
			{
				short num = (short)1918477564;
				short num2 = num;
				num = (short)235578620;
				switch (num2 == num)
				{
				}
				num = (short)607977472;
				short num3 = num;
				num = (short)1375141888;
				if (num != 0)
				{
				}
				num = (short)950730753;
				if (num != 0)
				{
				}
				global::ASK.Core.FeatureSchemaManager.a = value;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000132C8 File Offset: 0x000114C8
		public static global::ASK.Core.AccessElement GetAccessElement(global::ASK.Interface.AccessElementIDType id)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::ASK.Core.AccessElement result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2126381056;
					short num3 = num2;
					num2 = (short)1493851171;
					short num4 = num2;
					num2 = (short)1245928483;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
						num2 = (short)1741619200;
						if (num2 != 0)
						{
						}
						result = global::ASK.Core.FeatureSchemaManager.c[id];
						num2 = (short)1233321986;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_5A;
				case 2:
					return result;
				}
				goto IL_1C;
				IL_5A:
				if (!global::ASK.Core.FeatureSchemaManager.c.ContainsKey(id))
				{
					break;
				}
				num2 = (short)2033057792;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_1C:
			num2 = (short)473432065;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)71696385;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000133F4 File Offset: 0x000115F4
		private static void a()
		{
			short num = (short)2004353024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)239534081;
				if (num != 0)
				{
				}
				global::ASK.Core.FeatureSchemaManager.c = new global::System.Collections.Generic.Dictionary<global::ASK.Interface.AccessElementIDType, global::ASK.Core.AccessElement>();
				global::System.Collections.IEnumerator enumerator = global::ASK.Core.FeatureSchemaManager.FeatureCategories.GetEnumerator();
				try
				{
					num = (short)1724252165;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1880555527;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASK.Core.FeatureCategory featureCategory = (global::ASK.Core.FeatureCategory)enumerator.Current;
							num = (short)2144272387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							try
							{
								num = (short)1580924930;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator2;
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator3;
									switch (num2)
									{
									case 0:
										goto IL_42F;
									case 1:
										num = (short)2005139456;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_14F;
										}
										continue;
									case 3:
										if (!enumerator2.MoveNext())
										{
											num = (short)1147600897;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3E8;
									case 4:
										try
										{
											num = (short)1623851010;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_379;
												case 1:
												{
													if (!enumerator3.MoveNext())
													{
														num = (short)1462239236;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator4 = enumerator3.Current.Items.GetEnumerator();
													num = (short)681115651;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 2:
													switch (0)
													{
													case 0:
														goto IL_1C7;
													}
													continue;
												case 3:
													try
													{
														num = (short)1247346690;
														num2 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
																goto IL_2B5;
															case 1:
															{
																global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator4;
																if (!enumerator4.MoveNext())
																{
																	num = (short)1983971332;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::ASK.Core.AccessElement accessElement = enumerator4.Current;
																global::ASK.Core.FeatureSchemaManager.c.Add(accessElement.ElemID, accessElement);
																num = (short)73400323;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 2:
																switch (0)
																{
																case 0:
																	goto IL_230;
																}
																continue;
															case 4:
																num = (short)1910767616;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_265:
															num = (short)421396481;
															num2 = (int)((global::System.IntPtr)num);
															continue;
															IL_230:
															goto IL_265;
														}
														IL_2B5:;
													}
													finally
													{
														num = (short)1376780289;
														num2 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator4;
															switch (num2)
															{
															case 0:
																goto IL_321;
															case 1:
																switch (0)
																{
																case 0:
																	goto IL_2E9;
																}
																continue;
															case 2:
																enumerator4.Dispose();
																num = (short)695795712;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_2E9:
															if (enumerator4 == null)
															{
																break;
															}
															num = (short)1943863298;
															num2 = (int)((global::System.IntPtr)num);
														}
														IL_321:;
													}
													break;
												case 4:
													num = (short)213123072;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_324:
												num = (short)98435073;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_1C7:
												goto IL_324;
											}
											IL_379:
											break;
										}
										finally
										{
											num = (short)1413611521;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_3E5;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_3B0;
													}
													continue;
												case 2:
													enumerator3.Dispose();
													num = (short)1050542080;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_3B0:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)2003566594;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_3E5:;
										}
										goto IL_3E8;
									}
									IL_151:
									num = (short)990642179;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_14F:
									goto IL_151;
									IL_3E8:
									enumerator3 = enumerator2.Current.Sections.GetEnumerator();
									num = (short)1491730436;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_42F:;
							}
							finally
							{
								num = (short)199753729;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator2;
									switch (num2)
									{
									case 0:
										goto IL_49A;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_464;
										}
										continue;
									case 2:
										enumerator2.Dispose();
										num = (short)16646144;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_464:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)2106130434;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_49A:;
							}
							break;
						case 2:
							goto IL_903;
						case 3:
						{
							global::ASK.Core.FeatureCategory featureCategory;
							if (featureCategory.RadioType == global::ASK.Interface.FeatureCategoryRadioType.APXRadios)
							{
								num = (short)1852047366;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator2;
							try
							{
								num = (short)396754946;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_850;
									case 1:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)1833893892;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator3 = enumerator2.Current.Sections.GetEnumerator();
										num = (short)1310523395;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_518;
										}
										continue;
									case 3:
										try
										{
											num = (short)344391682;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator3;
												global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator4;
												switch (num2)
												{
												case 0:
													goto IL_78D;
												case 1:
													if (!enumerator3.MoveNext())
													{
														num = (short)1368850436;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_70A;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_582;
													}
													continue;
												case 3:
													try
													{
														num = (short)275972098;
														num2 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
																goto IL_649;
															case 1:
															{
																if (!enumerator4.MoveNext())
																{
																	num = (short)879099908;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::ASK.Core.AccessElement accessElement2 = enumerator4.Current;
																global::ASK.Core.FeatureSchemaManager.c.Add(accessElement2.ElemID, accessElement2);
																num = (short)458883075;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 2:
																switch (0)
																{
																case 0:
																	goto IL_5C2;
																}
																continue;
															case 4:
																num = (short)1352663040;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_5F8:
															num = (short)815398913;
															num2 = (int)((global::System.IntPtr)num);
															continue;
															IL_5C2:
															goto IL_5F8;
														}
														IL_649:
														break;
													}
													finally
													{
														num = (short)1787887617;
														num2 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num2)
															{
															case 0:
																goto IL_707;
															case 1:
																switch (0)
																{
																case 0:
																	goto IL_681;
																}
																continue;
															case 2:
															{
																num = (short)1092120955;
																short num3 = num;
																num = (short)1804562811;
																switch ((num3 == num) ? 1 : 0)
																{
																case 0:
																case 2:
																	break;
																default:
																	num = (short)887357440;
																	if (num != 0)
																	{
																	}
																	enumerator4.Dispose();
																	num = (short)1751842816;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															}
															IL_681:
															if (enumerator4 == null)
															{
																break;
															}
															num = (short)75366402;
															num2 = (int)((global::System.IntPtr)num);
														}
														IL_707:;
													}
													goto IL_70A;
												case 4:
													num = (short)1546452992;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_582;
												IL_70A:
												enumerator4 = enumerator3.Current.Items.GetEnumerator();
												num = (short)1989672963;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_73A:
												num = (short)1240465409;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_582:
												goto IL_73A;
											}
											IL_78D:;
										}
										finally
										{
											num = (short)1898905601;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator3;
												switch (num2)
												{
												case 0:
													goto IL_7F8;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_7C1;
													}
													continue;
												case 2:
													enumerator3.Dispose();
													num = (short)417857536;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_7C1:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)86507522;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_7F8:;
										}
										break;
									case 4:
										num = (short)652935168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_7FB:
									num = (short)2023030785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_518:
									goto IL_7FB;
								}
								IL_850:;
							}
							finally
							{
								num = (short)623509505;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_8BC;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_886;
										}
										continue;
									case 2:
										enumerator2.Dispose();
										num = (short)1935802368;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_886:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1038417922;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_8BC:;
							}
							global::ASK.Core.FeatureCategory featureCategory;
							enumerator2 = featureCategory.Functions.GetEnumerator();
							num = (short)313262081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_A1;
							}
							continue;
						case 6:
						{
							global::ASK.Core.FeatureCategory featureCategory;
							global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessNode> enumerator2 = featureCategory.Features.GetEnumerator();
							num = (short)1878654980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							num = (short)810221570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_49D:
						num = (short)316604416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A1:
						goto IL_49D;
					}
					IL_903:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_922;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_90F:
						switch (num2)
						{
						case 0:
							goto IL_979;
						case 1:
							if (disposable != null)
							{
								num = (short)2011430914;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_97B;
						case 2:
							disposable.Dispose();
							num = (short)471007232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_922;
					}
					IL_979:
					IL_97B:
					goto EndFinally_36;
					IL_922:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1652621313;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_90F;
					EndFinally_36:;
				}
				num = (short)1836711936;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x04000060 RID: 96
		private static global::System.Collections.ArrayList a;

		// Token: 0x04000061 RID: 97
		private static global::System.Type[] b;

		// Token: 0x04000062 RID: 98
		private static global::System.Collections.Generic.Dictionary<global::ASK.Interface.AccessElementIDType, global::ASK.Core.AccessElement> c;
	}
}
