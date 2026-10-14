using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using AcpASKLib.Properties;
using AcpCommonResources;
using AcpCryptoLib;

namespace AcpASKLib
{
	// Token: 0x02000025 RID: 37
	public static class FeatureSchemaManager
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00011E68 File Offset: 0x00010068
		static FeatureSchemaManager()
		{
			short num = (short)1121320960;
			short num2 = num;
			num = (short)937219965;
			short num3 = num;
			num = (short)1409079165;
			switch (num3 == num)
			{
			}
			num = (short)629342209;
			if (num != 0)
			{
			}
			num = (short)1699020800;
			if (num != 0)
			{
			}
			global::AcpASKLib.FeatureSchemaManager.a = null;
			global::AcpASKLib.FeatureSchemaManager.b = new global::System.Type[9];
			global::AcpASKLib.FeatureSchemaManager.c = null;
			global::AcpASKLib.FeatureSchemaManager.b[0] = typeof(global::AcpASKLib.FeatureCategory);
			global::AcpASKLib.FeatureSchemaManager.b[1] = typeof(global::AcpASKLib.AccessNode);
			global::AcpASKLib.FeatureSchemaManager.b[2] = typeof(global::AcpASKLib.AccessSection);
			global::AcpASKLib.FeatureSchemaManager.b[3] = typeof(global::AcpASKLib.AccessField);
			global::AcpASKLib.FeatureSchemaManager.b[4] = typeof(global::AcpASKLib.AccessOperation);
			global::AcpASKLib.FeatureSchemaManager.b[5] = typeof(global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessNode>);
			global::AcpASKLib.FeatureSchemaManager.b[6] = typeof(global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessSection>);
			global::AcpASKLib.FeatureSchemaManager.b[7] = typeof(global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessField>);
			global::AcpASKLib.FeatureSchemaManager.b[8] = typeof(global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessOperation>);
			global::AcpASKLib.FeatureSchemaManager.c();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00011FC8 File Offset: 0x000101C8
		internal static void c()
		{
			short num = (short)1827864576;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)709427200;
				short num3 = num;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				case 1:
					num = (short)671023105;
					if (num != 0)
					{
					}
					goto IL_BB;
				case 2:
					global::AcpASKLib.FeatureSchemaManager.b();
					num = (short)295632897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5B:
				if (global::AcpASKLib.FeatureSchemaManager.a == null)
				{
					num = (short)1740570626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BB:
				num = (short)199418224;
				short num4 = num;
				num = (short)2030231920;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5B;
				default:
					goto IL_F1;
				}
			}
			IL_F1:
			num = (short)1807024128;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000120DC File Offset: 0x000102DC
		private static void b()
		{
			short num = (short)337117184;
			short num2 = num;
			num = (short)2089484289;
			if (num != 0)
			{
			}
			global::System.Windows.MessageBoxOptions options = global::System.Windows.MessageBoxOptions.None;
			try
			{
				num = (short)1123287040;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1514683987;
					short num4 = num;
					num = (short)2103590483;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1464074240;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_14D;
							}
							continue;
						case 1:
							options = (global::System.Windows.MessageBoxOptions.RightAlign | global::System.Windows.MessageBoxOptions.RtlReading);
							num = (short)703332354;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1B7;
						case 3:
							goto IL_1D0;
						case 4:
							goto IL_1B9;
						}
						IL_14D:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1527250945;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						options = global::System.Windows.MessageBoxOptions.None;
						num = (short)1595146244;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1B9:
					num = (short)1886453763;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B7:
					goto IL_1B9;
				}
				IL_1D0:
				goto IL_C6;
			}
			catch
			{
				goto IL_C6;
			}
			return;
			for (;;)
			{
				IL_C6:
				try
				{
					global::System.Xml.XmlNodeReader xmlReader = new global::System.Xml.XmlNodeReader(new global::AcpCryptoLib.AcpXMLEncryptDecrypt().DecryptXMLFile(new global::System.IO.MemoryStream(global::AcpASKLib.Properties.Resources.askalm2p)).DocumentElement);
					global::AcpASKLib.FeatureSchemaManager.a = (global::System.Collections.ArrayList)new global::System.Xml.Serialization.XmlSerializer(typeof(global::System.Collections.ArrayList), global::AcpASKLib.FeatureSchemaManager.b).Deserialize(xmlReader);
					global::AcpASKLib.FeatureSchemaManager.a();
					break;
				}
				catch (global::System.Exception)
				{
					global::System.Windows.MessageBox.Show(global::AcpCommonResources.AcpResources.Critical_File_Missing, global::AcpCommonResources.AcpResources.Warning_Id, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Hand, global::System.Windows.MessageBoxResult.OK, options);
					global::System.Environment.Exit(3073);
					break;
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000122F8 File Offset: 0x000104F8
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000123A4 File Offset: 0x000105A4
		public static global::System.Collections.ArrayList FeatureCategories
		{
			get
			{
				short num = (short)657260544;
				short num2 = num;
				num = (short)149433521;
				short num3 = num;
				num = (short)1606560945;
				switch (num3 == num)
				{
				}
				num = (short)1844707329;
				if (num != 0)
				{
				}
				num = (short)784400384;
				if (num != 0)
				{
				}
				return global::AcpASKLib.FeatureSchemaManager.a;
			}
			set
			{
				short num = (short)1529085952;
				short num2 = num;
				num = (short)1624246750;
				short num3 = num;
				num = (short)1814563294;
				switch (num3 == num)
				{
				}
				num = (short)1979580417;
				if (num != 0)
				{
				}
				num = (short)122880000;
				if (num != 0)
				{
				}
				global::AcpASKLib.FeatureSchemaManager.a = value;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00012454 File Offset: 0x00010654
		internal static global::AcpASKLib.AccessElement a(global::AcpASKLib.AccessElementIDType A_0)
		{
			short num;
			int num3;
			global::AcpASKLib.AccessElement result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)54297115;
					short num2 = num;
					num = (short)647266843;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69;
					default:
						num = (short)438501376;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (global::AcpASKLib.FeatureSchemaManager.c.ContainsKey(A_0))
							{
								num = (short)916193282;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 1:
							return result;
						case 2:
						{
							num = (short)406585345;
							if (num != 0)
							{
							}
							result = global::AcpASKLib.FeatureSchemaManager.c[A_0];
							num = (short)1653604352;
							short num4 = num;
							num = (short)1365114881;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_67;
					}
				}
				return result;
			}
			IL_67:
			result = null;
			IL_69:
			num = (short)990838784;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00012580 File Offset: 0x00010780
		private static void a()
		{
			short num = (short)1715404800;
			short num2 = num;
			num = (short)1950482432;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				global::AcpASKLib.FeatureSchemaManager.c = new global::System.Collections.Generic.Dictionary<global::AcpASKLib.AccessElementIDType, global::AcpASKLib.AccessElement>();
				global::System.Collections.IEnumerator enumerator = global::AcpASKLib.FeatureSchemaManager.FeatureCategories.GetEnumerator();
				try
				{
					num = (short)602537987;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::AcpASKLib.FeatureCategory featureCategory;
							if (featureCategory.RadioType == global::AcpASKLib.FeatureCategoryRadioType.APXRadios)
							{
								num = (short)1352531975;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_912;
						case 2:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator4;
							try
							{
								num = (short)195166208;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_573;
										}
										continue;
									case 1:
										try
										{
											num = (short)1789132800;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
												global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator3;
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_5DD;
													}
													continue;
												case 1:
													try
													{
														num = (short)329842688;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																switch (0)
																{
																case 0:
																	goto IL_61D;
																}
																continue;
															case 2:
																num = (short)1327431683;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 3:
																goto IL_6A6;
															case 4:
															{
																if (!enumerator2.MoveNext())
																{
																	num = (short)1482817538;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpASKLib.AccessElement accessElement = enumerator2.Current;
																global::AcpASKLib.FeatureSchemaManager.c.Add(accessElement.ElemID, accessElement);
																num = (short)49807361;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															}
															IL_653:
															num = (short)390332420;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_61D:
															goto IL_653;
														}
														IL_6A6:
														break;
													}
													finally
													{
														num = (short)469041152;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																switch (0)
																{
																case 0:
																	goto IL_6DE;
																}
																continue;
															case 1:
																goto IL_716;
															case 2:
																enumerator2.Dispose();
																num = (short)301137921;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_6DE:
															if (enumerator2 == null)
															{
																break;
															}
															num = (short)1803485186;
															num3 = (int)((global::System.IntPtr)num);
														}
														IL_716:;
													}
													goto IL_719;
												case 2:
													num = (short)1754071043;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													goto IL_79D;
												case 4:
													if (!enumerator3.MoveNext())
													{
														num = (short)289079298;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_719;
												}
												goto IL_5DD;
												IL_719:
												enumerator2 = enumerator3.Current.Items.GetEnumerator();
												num = (short)1404108801;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_74A:
												num = (short)1070399492;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_5DD:
												goto IL_74A;
											}
											IL_79D:;
										}
										finally
										{
											num = (short)1849032704;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator3;
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_7D2;
													}
													continue;
												case 1:
													goto IL_808;
												case 2:
													enumerator3.Dispose();
													num = (short)852819969;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_7D2:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)1535180802;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_808:;
										}
										break;
									case 2:
										num = (short)425197571;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_862;
									case 4:
									{
										if (!enumerator4.MoveNext())
										{
											num = (short)7602178;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator3 = enumerator4.Current.Sections.GetEnumerator();
										num = (short)966590465;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_80B:
									num = (short)229441540;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_573:
									goto IL_80B;
								}
								IL_862:;
							}
							finally
							{
								num = (short)87293952;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_898;
										}
										continue;
									case 1:
										goto IL_8CE;
									case 2:
										enumerator4.Dispose();
										num = (short)332922881;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_898:
									if (enumerator4 == null)
									{
										break;
									}
									num = (short)443678722;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_8CE:;
							}
							global::AcpASKLib.FeatureCategory featureCategory;
							enumerator4 = featureCategory.Functions.GetEnumerator();
							num = (short)914423812;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_A3;
							}
							continue;
						case 4:
							try
							{
								num = (short)974323712;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator3;
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator4;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_152;
										}
										continue;
									case 1:
										if (!enumerator4.MoveNext())
										{
											num = (short)1841692676;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_445;
									case 2:
										try
										{
											num = (short)1014628352;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_1CB;
													}
													continue;
												case 1:
													try
													{
														num = (short)703725568;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																switch (0)
																{
																case 0:
																	goto IL_233;
																}
																continue;
															case 2:
																num = (short)338231299;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 3:
																goto IL_2BA;
															case 4:
															{
																global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
																if (!enumerator2.MoveNext())
																{
																	num = (short)2084110338;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::AcpASKLib.AccessElement accessElement2 = enumerator2.Current;
																global::AcpASKLib.FeatureSchemaManager.c.Add(accessElement2.ElemID, accessElement2);
																num = (short)936509441;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															}
															IL_268:
															num = (short)1108148228;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_233:
															goto IL_268;
														}
														IL_2BA:;
													}
													finally
													{
														num = (short)763232256;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															IL_2DE:
															global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2;
															switch (num3)
															{
															case 0:
																switch (0)
																{
																case 0:
																	goto IL_2F1;
																}
																continue;
															case 1:
																goto IL_379;
															case 2:
																enumerator2.Dispose();
																num = (short)1810890753;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_2F1:
															while (enumerator2 != null)
															{
																num = (short)740150995;
																short num4 = num;
																num = (short)2053295827;
																switch ((num4 == num) ? 1 : 0)
																{
																case 0:
																case 2:
																	break;
																default:
																	num = (short)2009726976;
																	if (num != 0)
																	{
																	}
																	num = (short)865468418;
																	num3 = (int)((global::System.IntPtr)num);
																	goto IL_2DE;
																}
															}
															break;
														}
														IL_379:;
													}
													break;
												case 2:
													num = (short)1312751619;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													goto IL_3D5;
												case 4:
												{
													if (!enumerator3.MoveNext())
													{
														num = (short)1617756162;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator2 = enumerator3.Current.Items.GetEnumerator();
													num = (short)876150785;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_37C:
												num = (short)1687617540;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_1CB:
												goto IL_37C;
											}
											IL_3D5:
											break;
										}
										finally
										{
											num = (short)2036924416;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_40C;
													}
													continue;
												case 1:
													goto IL_442;
												case 2:
													enumerator3.Dispose();
													num = (short)130088961;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_40C:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)292225026;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_442:;
										}
										goto IL_445;
									case 3:
										goto IL_48D;
									case 4:
										num = (short)80150531;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_154:
									num = (short)578748417;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_152:
									goto IL_154;
									IL_445:
									enumerator3 = enumerator4.Current.Sections.GetEnumerator();
									num = (short)703987714;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_48D:;
							}
							finally
							{
								num = (short)1841561600;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator4;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_4C1;
										}
										continue;
									case 1:
										goto IL_4F6;
									case 2:
										enumerator4.Dispose();
										num = (short)1517813761;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_4C1:
									if (enumerator4 == null)
									{
										break;
									}
									num = (short)2097545218;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_4F6:;
							}
							break;
						case 5:
							num = (short)1145241601;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1331429381;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.FeatureCategory featureCategory = (global::AcpASKLib.FeatureCategory)enumerator.Current;
							num = (short)1719795712;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::AcpASKLib.FeatureCategory featureCategory;
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessNode> enumerator4 = featureCategory.Features.GetEnumerator();
							num = (short)1069219842;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_4F9:
						num = (short)532283398;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A3:
						goto IL_4F9;
					}
					IL_912:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_95B;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_921:
						num = (short)1540358145;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)794558466;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9B5;
						case 1:
							goto IL_9B3;
						case 2:
							disposable.Dispose();
							num = (short)313720833;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_95B;
					}
					IL_9B3:
					IL_9B5:
					goto EndFinally_36;
					IL_95B:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)868483072;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_921;
					EndFinally_36:;
				}
				return;
			}
			}
		}

		// Token: 0x0400016E RID: 366
		private static global::System.Collections.ArrayList a;

		// Token: 0x0400016F RID: 367
		private static global::System.Type[] b;

		// Token: 0x04000170 RID: 368
		private static global::System.Collections.Generic.Dictionary<global::AcpASKLib.AccessElementIDType, global::AcpASKLib.AccessElement> c;
	}
}
