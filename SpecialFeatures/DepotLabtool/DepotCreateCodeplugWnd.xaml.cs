using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Xml;
using AcpCryptoLib;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.Model_Configuration;

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x02000134 RID: 308
	public partial class DepotCreateCodeplugWnd : Window
	{
		// Token: 0x0600102C RID: 4140 RVA: 0x00167F8C File Offset: 0x0016618C
		public DepotCreateCodeplugWnd()
		{
			this.InitializeComponent();
			this.DepotOptions = new List<string>();
			this.cmbRadio.SelectionChanged += new SelectionChangedEventHandler(this.SelectModel);
			this.cmbModelNum.SelectionChanged += this.cmbModelNum_SelectionChanged;
			this.cmbRadio.SelectedIndex = 0;
			this.cmbRegion.SelectedIndex = 0;
			this.e();
			this.SelectModel(this.cmbRadio, null);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00168034 File Offset: 0x00166234
		private void e()
		{
			int a_ = 5;
			short num;
			try
			{
				num = (short)1700069376;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					ModelTiering modelTiering;
					for (;;)
					{
						IL_32:
						Dictionary<string, string> dictionary;
						Dictionary<string, string> dictionary2;
						IEnumerator enumerator;
						switch (num2)
						{
						case 0:
							goto IL_12DE;
						case 1:
							try
							{
								num = (short)1034092545;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										string text;
										if (text == RptMgrErrorHandler.b("즇\uda89풋뢍ꖏꊑ꒓", a_))
										{
											num = (short)1365639171;
											num2 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_179;
										}
										continue;
									case 2:
									{
										string text;
										if (text == RptMgrErrorHandler.b("즇\uda89풋뢍ꂏꊑ꒓", a_))
										{
											num = (short)1830682630;
											num2 = (int)((IntPtr)num);
											continue;
										}
										num = (short)1088487424;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 3:
									{
										int key;
										dictionary = new Dictionary<string, string>(this.j[key]);
										num = (short)516751364;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 5:
										num = (short)771162120;
										num2 = (int)((IntPtr)num);
										continue;
									case 6:
									{
										int key;
										dictionary2 = new Dictionary<string, string>(this.j[key]);
										num = (short)302120967;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 8:
										goto IL_306;
									case 9:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1716584453;
											num2 = (int)((IntPtr)num);
											continue;
										}
										ComboBoxItem comboBoxItem = (ComboBoxItem)enumerator.Current;
										string text = comboBoxItem.Content.ToString().ToUpper().Trim();
										int key = this.cmbRadio.Items.IndexOf(comboBoxItem);
										num = (short)1348337666;
										num2 = (int)((IntPtr)num);
										continue;
									}
									}
									IL_17B:
									num = (short)1921908745;
									num2 = (int)((IntPtr)num);
									continue;
									IL_179:
									goto IL_17B;
								}
								IL_306:
								goto IL_B5;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_376;
								}
								IDisposable disposable;
								for (;;)
								{
									IL_315:
									num = (short)953382921;
									short num3 = num;
									num = (short)126056457;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)519110656;
										if (num != 0)
										{
										}
										switch (num2)
										{
										case 0:
											disposable.Dispose();
											num = (short)309723137;
											num2 = (int)((IntPtr)num);
											continue;
										case 1:
											goto IL_3D9;
										case 2:
											goto IL_399;
										}
										goto IL_376;
									}
									IL_399:
									if (disposable == null)
									{
										break;
									}
									num = (short)1839267840;
									num2 = (int)((IntPtr)num);
								}
								IL_3D9:
								goto EndFinally_54;
								IL_376:
								disposable = (enumerator as IDisposable);
								num = (short)931266562;
								num2 = (int)((IntPtr)num);
								goto IL_315;
								EndFinally_54:;
							}
							goto Block_5;
							IL_B5:
							this.a(dictionary2, RptMgrErrorHandler.b("펇쮉펍쮏슑쮕쎗슙쎝ﲟ톡辣邥颧骩鲫", a_), RptMgrErrorHandler.b("즇\uda89풋꺍ꖏꊑ꒓ꚕ", a_));
							this.a(dictionary, RptMgrErrorHandler.b("펇쮉펍쮏슑쮕쎗슙쎝ﲟ톡辣邥鶧骩鲫", a_), RptMgrErrorHandler.b("즇\uda89풋꺍ꖏꞑ꒓ꚕ", a_));
							enumerator = ((IEnumerable)this.cmbRadio.Items).GetEnumerator();
							num = (short)519503875;
							num2 = (int)((IntPtr)num);
							continue;
						case 2:
							goto IL_3DC;
						case 3:
							goto IL_FF6;
						case 4:
							goto IL_1396;
						case 5:
							if (File.Exists(this.d))
							{
								num = (short)787349504;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_137D;
						}
						goto IL_51;
						IL_12DE:
						new XmlDocument();
						XmlNodeList xmlNodeList = new AcpXMLEncryptDecrypt().DecryptXMLFile(modelTiering.MTFPath).SelectNodes(RptMgrErrorHandler.b("ꞇ붑\ud993秊ﲗﾙ쪝즟잡횣쾥욧충잭\udcafힱ鮳춷쪹첻톽늿뛁ꇃꋅ胇藉볋뫍맏뷑뫓ꗕ", a_));
						this.j = new Dictionary<int, Dictionary<string, string>>();
						enumerator = ((IEnumerable)this.cmbRadio.Items).GetEnumerator();
						num = (short)202047490;
						num2 = (int)((IntPtr)num);
						continue;
						Block_6:
						try
						{
							IL_FF6:
							num = (short)1154023429;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)522584068;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									num = (short)522846219;
									num2 = (int)((IntPtr)num);
									continue;
								case 4:
								{
									int key2;
									if (!this.j.ContainsKey(key2))
									{
										num = (short)1399259146;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1055;
									}
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1113391112;
										num2 = (int)((IntPtr)num);
										continue;
									}
									ComboBoxItem comboBoxItem2 = (ComboBoxItem)enumerator.Current;
									string text2 = comboBoxItem2.Content.ToString().ToUpper().Trim();
									int key2 = this.cmbRadio.Items.IndexOf(comboBoxItem2);
									num = (short)1837629453;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 7:
								{
									int key2;
									this.j.Add(key2, dictionary2);
									num = (short)88866818;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1210515465;
									num2 = (int)((IntPtr)num);
									continue;
								case 9:
									goto IL_1263;
								case 10:
								{
									int key2;
									this.j.Add(key2, dictionary);
									num = (short)880345091;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 11:
								{
									int key2;
									if (!this.j.ContainsKey(key2))
									{
										num = (short)511442951;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
								{
									string text2;
									if (text2 == RptMgrErrorHandler.b("즇\uda89풋뮍ꖏꊑ꒓", a_))
									{
										num = (short)547684352;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
								{
									string text2;
									if (text2 == RptMgrErrorHandler.b("즇\uda89풋뮍ꂏꊑ꒓", a_))
									{
										num = (short)1436942337;
										num2 = (int)((IntPtr)num);
										continue;
									}
									num = (short)689373196;
									num2 = (int)((IntPtr)num);
									continue;
								}
								}
								IL_10BE:
								num = (short)1991311366;
								num2 = (int)((IntPtr)num);
								continue;
								IL_1055:
								goto IL_10BE;
							}
							IL_1263:
							goto IL_137D;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1285;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_1272:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1817772034;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_12DD;
								case 1:
									goto IL_12DB;
								case 2:
									disposable.Dispose();
									num = (short)180027393;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_1285;
							}
							IL_12DB:
							IL_12DD:
							goto EndFinally_53;
							IL_1285:
							disposable = (enumerator as IDisposable);
							num = (short)2143354880;
							num2 = (int)((IntPtr)num);
							goto IL_1272;
							EndFinally_53:;
						}
						goto IL_12DE;
						Block_5:
						try
						{
							IL_3DC:
							num = (short)808845318;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								IEnumerator enumerator2;
								Dictionary<string, string> dictionary3;
								int key3;
								ComboBoxItem comboBoxItem3;
								switch (num2)
								{
								case 0:
									goto IL_F78;
								case 1:
									try
									{
										num = (short)1235288068;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											IEnumerator enumerator4;
											switch (num2)
											{
											case 0:
												num = (short)1180631043;
												num2 = (int)((IntPtr)num);
												continue;
											case 1:
												if (!enumerator2.MoveNext())
												{
													num = (short)918355968;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_E29;
											case 2:
												try
												{
													num = (short)1889140738;
													num2 = (int)((IntPtr)num);
													for (;;)
													{
														IEnumerator enumerator3;
														XmlNode xmlNode2;
														switch (num2)
														{
														case 0:
															try
															{
																num = (short)140247053;
																num2 = (int)((IntPtr)num);
																for (;;)
																{
																	switch (num2)
																	{
																	case 0:
																	{
																		string value;
																		if (!(value == RptMgrErrorHandler.b("憎꺍ꞏꊑ꒓ꚕ", a_)))
																		{
																			num = (short)834338837;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_B11;
																	}
																	case 1:
																		num = (short)930676736;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 2:
																		if (dictionary3 != null)
																		{
																			num = (short)1732313098;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		break;
																	case 4:
																	{
																		string value;
																		if (value == RptMgrErrorHandler.b("憎꺍꒏ꊑ꒓ꚕ", a_))
																		{
																			num = (short)2078408713;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		XmlNode xmlNode;
																		dictionary3.Add(xmlNode.Attributes[RptMgrErrorHandler.b("", a_)].Value, xmlNode.Attributes[RptMgrErrorHandler.b("ﾋﮑ", a_)].Value + RptMgrErrorHandler.b("ꢇ꞉겋", a_) + xmlNode.Attributes[RptMgrErrorHandler.b("", a_)].Value);
																		num = (short)2072510467;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	case 5:
																		num = (short)595525634;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 6:
																		num = (short)1167982607;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 7:
																	{
																		XmlNode xmlNode;
																		if (xmlNode is XmlElement)
																		{
																			num = (short)1067450373;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		break;
																	}
																	case 8:
																	{
																		XmlNode xmlNode;
																		dictionary3.Add(xmlNode.Attributes[RptMgrErrorHandler.b("", a_)].Value, xmlNode.Attributes[RptMgrErrorHandler.b("ﾋﮑ", a_)].Value + RptMgrErrorHandler.b("ꢇ꞉겋", a_) + xmlNode.Attributes[RptMgrErrorHandler.b("", a_)].Value);
																		num = (short)508690449;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	case 9:
																		goto IL_B11;
																	case 10:
																		num = (short)1872232459;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 11:
																	{
																		XmlNode xmlNode;
																		if (!dictionary3.ContainsKey(xmlNode.Attributes[RptMgrErrorHandler.b("", a_)].Value))
																		{
																			num = (short)612368390;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		break;
																	}
																	case 12:
																	{
																		if (!enumerator3.MoveNext())
																		{
																			num = (short)1766195218;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		XmlNode xmlNode = (XmlNode)enumerator3.Current;
																		num = (short)694878215;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	case 13:
																		switch (0)
																		{
																		case 0:
																			goto IL_7D5;
																		}
																		continue;
																	case 14:
																		num = (short)1833107475;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 15:
																	{
																		string value;
																		XmlNode xmlNode;
																		if (xmlNode.Attributes[RptMgrErrorHandler.b("ﾋﮑ", a_)].Value.ToLower().Contains(value))
																		{
																			num = (short)430833665;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		break;
																	}
																	case 16:
																		goto IL_C2F;
																	case 18:
																		num = (short)905969680;
																		num2 = (int)((IntPtr)num);
																		continue;
																	case 19:
																	{
																		XmlNode xmlNode;
																		if (!xmlNode.Attributes[RptMgrErrorHandler.b("ﾋﮑ", a_)].Value.ToLower().Contains(RptMgrErrorHandler.b("벇몉벋뺍晴", a_)))
																		{
																			num = (short)1228210184;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		break;
																	}
																	case 20:
																	{
																		XmlNode xmlNode;
																		if (!xmlNode.Attributes[RptMgrErrorHandler.b("ﾋﮑ", a_)].Value.ToLower().Contains(RptMgrErrorHandler.b("뾇몉벋뺍", a_)))
																		{
																			num = (short)858783758;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		break;
																	}
																	case 21:
																		num = (short)1964638212;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	IL_864:
																	num = (short)1694171148;
																	num2 = (int)((IntPtr)num);
																	continue;
																	IL_7D5:
																	goto IL_864;
																	IL_B11:
																	num = (short)388694036;
																	num2 = (int)((IntPtr)num);
																}
																IL_C2F:
																break;
															}
															finally
															{
																switch (0)
																{
																case 0:
																	goto IL_C51;
																}
																IDisposable disposable;
																for (;;)
																{
																	IL_C3E:
																	switch (num2)
																	{
																	case 0:
																		if (disposable != null)
																		{
																			num = (short)131530754;
																			num2 = (int)((IntPtr)num);
																			continue;
																		}
																		goto IL_CAC;
																	case 1:
																		goto IL_CAA;
																	case 2:
																		disposable.Dispose();
																		num = (short)301203457;
																		num2 = (int)((IntPtr)num);
																		continue;
																	}
																	goto IL_C51;
																}
																IL_CAA:
																IL_CAC:
																goto EndFinally_49;
																IL_C51:
																disposable = (enumerator3 as IDisposable);
																num = (short)836960256;
																num2 = (int)((IntPtr)num);
																goto IL_C3E;
																EndFinally_49:;
															}
															goto IL_CAD;
														case 1:
															goto IL_CAD;
														case 2:
															switch (0)
															{
															case 0:
																goto IL_706;
															}
															continue;
														case 3:
														{
															string value;
															if (xmlNode2.Attributes[RptMgrErrorHandler.b("", a_)].Value.ToLower().Contains(value))
															{
																num = (short)1107951617;
																num2 = (int)((IntPtr)num);
																continue;
															}
															break;
														}
														case 4:
															num = (short)146210819;
															num2 = (int)((IntPtr)num);
															continue;
														case 5:
															num = (short)1668874247;
															num2 = (int)((IntPtr)num);
															continue;
														case 6:
															if (!enumerator4.MoveNext())
															{
																num = (short)1490747397;
																num2 = (int)((IntPtr)num);
																continue;
															}
															xmlNode2 = (XmlNode)enumerator4.Current;
															num = (short)1917124616;
															num2 = (int)((IntPtr)num);
															continue;
														case 7:
															goto IL_DAC;
														case 8:
															if (xmlNode2 is XmlElement)
															{
																num = (short)285409284;
																num2 = (int)((IntPtr)num);
																continue;
															}
															break;
														}
														goto IL_706;
														IL_CAD:
														enumerator3 = xmlNode2.SelectSingleNode(RptMgrErrorHandler.b("얇ﲏ", a_)).ChildNodes.GetEnumerator();
														num = (short)1030488064;
														num2 = (int)((IntPtr)num);
														continue;
														IL_CED:
														num = (short)1322057734;
														num2 = (int)((IntPtr)num);
														continue;
														IL_706:
														goto IL_CED;
													}
													IL_DAC:
													break;
												}
												finally
												{
													switch (0)
													{
													case 0:
														goto IL_DCE;
													}
													IDisposable disposable;
													for (;;)
													{
														IL_DBB:
														switch (num2)
														{
														case 0:
															if (disposable != null)
															{
																num = (short)210829314;
																num2 = (int)((IntPtr)num);
																continue;
															}
															goto IL_E28;
														case 1:
															goto IL_E26;
														case 2:
															disposable.Dispose();
															num = (short)1113718785;
															num2 = (int)((IntPtr)num);
															continue;
														}
														goto IL_DCE;
													}
													IL_E26:
													IL_E28:
													goto EndFinally_50;
													IL_DCE:
													disposable = (enumerator4 as IDisposable);
													num = (short)1929314304;
													num2 = (int)((IntPtr)num);
													goto IL_DBB;
													EndFinally_50:;
												}
												goto IL_E29;
											case 3:
												goto IL_EB5;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_6B6;
												}
												continue;
											}
											goto IL_6B6;
											IL_E29:
											enumerator4 = ((XmlNode)enumerator2.Current).ChildNodes.GetEnumerator();
											num = (short)1693712386;
											num2 = (int)((IntPtr)num);
											continue;
											IL_E5E:
											num = (short)932380673;
											num2 = (int)((IntPtr)num);
											continue;
											IL_6B6:
											goto IL_E5E;
										}
										IL_EB5:
										goto IL_53D;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_ED7;
										}
										IDisposable disposable;
										for (;;)
										{
											IL_EC4:
											switch (num2)
											{
											case 0:
												if (disposable != null)
												{
													num = (short)2032140290;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_F32;
											case 1:
												goto IL_F30;
											case 2:
												disposable.Dispose();
												num = (short)920125441;
												num2 = (int)((IntPtr)num);
												continue;
											}
											goto IL_ED7;
										}
										IL_F30:
										IL_F32:
										goto EndFinally_51;
										IL_ED7:
										disposable = (enumerator2 as IDisposable);
										num = (short)441909248;
										num2 = (int)((IntPtr)num);
										goto IL_EC4;
										EndFinally_51:;
									}
									goto IL_F33;
									IL_53D:
									num = (short)1679818756;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
								{
									string text3;
									if (!(text3 == RptMgrErrorHandler.b("즇\uda89풋뮍ꂏꊑ꒓", a_)))
									{
										num = (short)1079115779;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1270284302;
									num2 = (int)((IntPtr)num);
									continue;
								case 4:
									if (!this.j.ContainsKey(key3))
									{
										num = (short)1053294604;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								case 5:
									if (!(comboBoxItem3.Content as string).ToLower().StartsWith(RptMgrErrorHandler.b("ﺇ", a_)))
									{
										num = (short)740884490;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_581;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_43E;
									}
									continue;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1709309961;
										num2 = (int)((IntPtr)num);
										continue;
									}
									comboBoxItem3 = (ComboBoxItem)enumerator.Current;
									string text3 = comboBoxItem3.Content.ToString().ToUpper().Trim();
									num = (short)1275461634;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 9:
									num = (short)858718208;
									num2 = (int)((IntPtr)num);
									continue;
								case 10:
								{
									string value = (comboBoxItem3.Content as string).Insert(3, RptMgrErrorHandler.b("ꢇ", a_)).ToLower();
									num = (short)1751515147;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 11:
									goto IL_581;
								case 12:
									goto IL_F33;
								case 13:
								{
									string value = RptMgrErrorHandler.b("ﺇꆋﺍꦏꚑ궓", a_);
									num = (short)396361733;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 14:
								{
									string text3;
									if (!(text3 == RptMgrErrorHandler.b("즇\uda89풋뮍ꖏꊑ꒓", a_)))
									{
										num = (short)248184845;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_4FB:
								num = (short)814350343;
								num2 = (int)((IntPtr)num);
								continue;
								IL_43E:
								goto IL_4FB;
								IL_581:
								key3 = this.cmbRadio.Items.IndexOf(comboBoxItem3);
								dictionary3 = new Dictionary<string, string>();
								enumerator2 = xmlNodeList.GetEnumerator();
								num = (short)609812481;
								num2 = (int)((IntPtr)num);
								continue;
								IL_F33:
								this.j.Add(key3, dictionary3);
								num = (short)694288392;
								num2 = (int)((IntPtr)num);
							}
							IL_F78:
							goto IL_1342;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_F9A;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_F87:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1863057410;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_FF5;
								case 1:
									goto IL_FF3;
								case 2:
									disposable.Dispose();
									num = (short)1955201025;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_F9A;
							}
							IL_FF3:
							IL_FF5:
							goto EndFinally_52;
							IL_F9A:
							disposable = (enumerator as IDisposable);
							num = (short)1797521408;
							num2 = (int)((IntPtr)num);
							goto IL_F87;
							EndFinally_52:;
						}
						goto Block_6;
						IL_1342:
						dictionary2 = new Dictionary<string, string>();
						dictionary = new Dictionary<string, string>();
						enumerator = ((IEnumerable)this.cmbRadio.Items).GetEnumerator();
						num = (short)538378241;
						num2 = (int)((IntPtr)num);
						continue;
						IL_137D:
						num = (short)518455300;
						num2 = (int)((IntPtr)num);
					}
					IL_1396:
					break;
					IL_51:
					modelTiering = new ModelTiering(RptMgrErrorHandler.b("삇뎉뮋\uda8d힏횑궓욕쾗ꮙ\udd9b킝", a_), ModelTiering.ActionTypes.NONE, ModelTiering.TargetTypes.NONE, false);
					this.d = modelTiering.MTFPath;
					num = (short)1375928325;
					num2 = (int)((IntPtr)num);
					goto IL_32;
				}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			num = (short)1763442688;
			short num4 = num;
			num = (short)251265025;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x001694E4 File Offset: 0x001676E4
		private void a(Dictionary<string, string> A_0, string A_1, string A_2)
		{
			short num = (short)1057161216;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				List<string>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
				{
					num = (short)571336480;
					short num3 = num;
					num = (short)1614079776;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AA;
					default:
						num = (short)318308352;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					num = (short)1287782401;
					if (num != 0)
					{
					}
					try
					{
						num = (short)1138425856;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_FB;
								}
								continue;
							case 2:
								num = (short)738263044;
								num2 = (int)((IntPtr)num);
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1953759234;
									num2 = (int)((IntPtr)num);
									continue;
								}
								string key = enumerator.Current;
								A_0[key] = Regex.Replace(A_0[key], A_1, A_2);
								num = (short)843448321;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 4:
								goto IL_17C;
							}
							IL_130:
							num = (short)540803075;
							num2 = (int)((IntPtr)num);
							continue;
							IL_FB:
							goto IL_130;
						}
						IL_17C:
						return;
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					goto IL_18C;
				}
				goto IL_7B;
				IL_AA:
				num = (short)1848573953;
				num2 = (int)((IntPtr)num);
				continue;
				IL_7B:
				num = (short)2079850496;
				short num4 = num;
				if (A_0 == null)
				{
					goto IL_AA;
				}
				IL_18C:
				enumerator = new List<string>(A_0.Keys).GetEnumerator();
				num = (short)1924792322;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x001696E4 File Offset: 0x001678E4
		public string ModelNum
		{
			get
			{
				int a_ = 11;
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				short num;
				int num2;
				for (;;)
				{
					IL_13:
					num = (short)1092222977;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						string text;
						if (!(text == RptMgrErrorHandler.b("쾍삏쪑ꆓꚕꢗꪙ", a_)))
						{
							num = (short)312147970;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_106;
					}
					case 1:
					{
						string text;
						if (text == RptMgrErrorHandler.b("쾍삏쪑ꆓꎕꢗꪙ", a_))
						{
							num = (short)1277689859;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_197;
					}
					case 2:
						num = (short)935395329;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						goto IL_169;
					}
					goto IL_4F;
				}
				IL_106:
				return this.cmbModelNum.Text + RptMgrErrorHandler.b("잍", a_);
				IL_169:
				num = (short)261226496;
				short num3 = num;
				goto IL_106;
				IL_197:
				return this.cmbModelNum.Text;
				IL_4F:
				num = (short)445395503;
				short num4 = num;
				num = (short)1338257967;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1624637440;
					if (num != 0)
					{
					}
					string text = ((ComboBoxItem)this.cmbRadio.SelectedItem).Content.ToString().ToUpper().Trim();
					break;
				}
				}
				num = (short)1777664000;
				num2 = (int)((IntPtr)num);
				goto IL_13;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x00169894 File Offset: 0x00167A94
		public string SerNum
		{
			get
			{
				short num = (short)1699545088;
				short num2 = num;
				num = (short)692451484;
				short num3 = num;
				num = (short)651753628;
				switch (num3 == num)
				{
				}
				num = (short)1046740993;
				if (num != 0)
				{
				}
				num = (short)1899167744;
				if (num != 0)
				{
				}
				return this.txtSerNum.Text;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00169948 File Offset: 0x00167B48
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x00169A64 File Offset: 0x00167C64
		public string FlashCode
		{
			get
			{
				int a_ = 10;
				short num = (short)1182072832;
				short num2 = num;
				num = (short)1746495150;
				short num3 = num;
				num = (short)626681518;
				switch (num3 == num)
				{
				}
				num = (short)1249181696;
				if (num != 0)
				{
				}
				num = (short)1023475713;
				if (num != 0)
				{
				}
				return string.Concat(new string[]
				{
					this.txtFlashCode1.Text,
					RptMgrErrorHandler.b("ꂌ", a_),
					this.txtFlashCode2.Text,
					RptMgrErrorHandler.b("ꂌ", a_),
					this.txtFlashCodeCheckSum.Text,
					RptMgrErrorHandler.b("ꂌ뾎ꆐꎒꖔꞖꦘ뚚궜꾞醠鎢閤鞦", a_)
				});
			}
			set
			{
				short num = (short)879755264;
				short num2 = num;
				num = (short)1004705573;
				short num3 = num;
				num = (short)71997221;
				switch (num3 == num)
				{
				}
				num = (short)802684929;
				if (num != 0)
				{
				}
				num = (short)624492544;
				if (num != 0)
				{
				}
				string[] array = value.Trim().Split(new char[]
				{
					'-'
				});
				this.txtFlashCode1.Text = array[0];
				this.txtFlashCode2.Text = array[1];
				this.txtFlashCodeCheckSum.Text = array[2];
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00169B50 File Offset: 0x00167D50
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x00169C00 File Offset: 0x00167E00
		public List<string> DepotOptions
		{
			[CompilerGenerated]
			get
			{
				short num = (short)1292369920;
				short num2 = num;
				num = (short)827737823;
				short num3 = num;
				num = (short)334317279;
				switch (num3 == num)
				{
				}
				num = (short)1214513152;
				if (num != 0)
				{
				}
				num = (short)1199374337;
				if (num != 0)
				{
				}
				return this.l;
			}
			[CompilerGenerated]
			internal set
			{
				short num = (short)1693450240;
				short num2 = num;
				num = (short)1803989279;
				short num3 = num;
				num = (short)27767071;
				switch (num3 == num)
				{
				}
				num = (short)1043922945;
				if (num != 0)
				{
				}
				num = (short)2062286848;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00169CB0 File Offset: 0x00167EB0
		private void txtFlashCode_TextChanged(object A_0, TextChangedEventArgs A_1)
		{
			short num = (short)1421803521;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)824311810;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 2:
					if (this.txtFlashCode2 != null)
					{
						num = (short)2056323075;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)1782448133;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					goto IL_D1;
				case 5:
				{
					if (this.txtFlashCodeCheckSum == null)
					{
						num = (short)198443015;
						num2 = (int)((IntPtr)num);
						continue;
					}
					byte b = FlashcodeValidator.CalculateFlashCodeCheckDigit(this.txtFlashCode1.Text + this.txtFlashCode2.Text);
					num = (short)832241673;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 6:
				{
					num = (short)1240793088;
					short num3 = num;
					byte b;
					this.txtFlashCodeCheckSum.Text = b.ToString();
					this.a = FlashcodeValidator.Validate(this.FlashCode);
					goto IL_B9;
				}
				case 7:
					goto IL_183;
				case 8:
					goto IL_146;
				case 9:
				{
					num = (short)596740519;
					short num4 = num;
					num = (short)453675431;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B9;
					default:
					{
						num = (short)1977876480;
						if (num != 0)
						{
						}
						num = (short)1069154305;
						if (num != 0)
						{
						}
						byte b;
						if (b != 255)
						{
							num = (short)455344134;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.txtFlashCodeCheckSum.Text = ' '.ToString();
						this.a = false;
						num = (short)234094600;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_4C:
				if (this.txtFlashCode1 != null)
				{
					num = (short)530055168;
					num2 = (int)((IntPtr)num);
					continue;
				}
				return;
				IL_B9:
				num = (short)69140484;
				num2 = (int)((IntPtr)num);
			}
			IL_D1:
			IL_146:
			goto IL_25A;
			IL_183:
			return;
			IL_25A:
			this.d();
			this.b();
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00169F24 File Offset: 0x00168124
		private void d()
		{
			int a_ = 19;
			short num = (short)552730624;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)2123357010;
				short num3 = num;
				num = (short)1241701202;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)631570432;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_9B;
						}
						continue;
					case 1:
						goto IL_10C;
					case 2:
						num = (short)1515847687;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
					{
						byte b;
						if ((b & 8) != 0)
						{
							num = (short)2081292289;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1A8;
					}
					case 4:
					{
						byte b = (byte)FlashcodeMapping.GetFlashcodeIntValue(this.txtFlashCode2.Text[5]);
						goto IL_1EE;
					}
					case 5:
						num = (short)1861419011;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
						return;
					case 7:
						if (this.txtFlashCode2.Text.Length == 6)
						{
							num = (short)1231421444;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 8:
						if (((ComboBoxItem)this.cmbRadio.SelectedItem).Content.ToString().ToUpper().Trim().Equals(RptMgrErrorHandler.b("힕좗슙ꪛ꺝邟銡", a_)))
						{
							num = (short)938541061;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1A8;
					}
					IL_9B:
					if (this.txtFlashCode2 != null)
					{
						num = (short)1952579586;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
					IL_1A8:
					this.cbAPX6000P25.IsChecked = new bool?(false);
					num = (short)1568145414;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_1EE:
				num = (short)1017577480;
				num2 = (int)((IntPtr)num);
			}
			IL_10C:
			num = (short)221184001;
			if (num != 0)
			{
			}
			num = (short)42270720;
			short num4 = num;
			this.cbAPX6000P25.IsChecked = new bool?(true);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0016A190 File Offset: 0x00168390
		private void txtSerNum_TextChanged(object A_0, TextChangedEventArgs A_1)
		{
			short num = (short)987889664;
			short num2 = num;
			num = (short)456654643;
			short num3 = num;
			num = (short)943193907;
			switch (num3 == num)
			{
			}
			num = (short)1585119233;
			if (num != 0)
			{
			}
			num = (short)333643776;
			if (num != 0)
			{
			}
			string s = this.txtSerNum.Text.ToString().Trim();
			string serialNumber = Convert.ToBase64String(Encoding.ASCII.GetBytes(s));
			this.b = SerialNumberValidator.ValidateSerialNumber(serialNumber);
			this.b();
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0016A270 File Offset: 0x00168470
		private void c()
		{
			short num = (short)345636864;
			short num2 = num;
			num = (short)1136767741;
			short num3 = num;
			num = (short)825799421;
			switch (num3 == num)
			{
			}
			num = (short)313982976;
			if (num != 0)
			{
			}
			num = (short)1687617537;
			if (num != 0)
			{
			}
			string radioType = ((ComboBoxItem)this.cmbRadio.SelectedItem).Content.ToString().ToUpper().Trim();
			this.k.AddPCIOptionsForCreate(radioType);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0016A34C File Offset: 0x0016854C
		private void btnOK_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_95;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				bool? isChecked;
				bool flag;
				switch (num)
				{
				case 0:
					this.a(RptMgrErrorHandler.b("\uda91ꆓꎕꮗ", a_));
					num2 = (short)546635797;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
					if (this.cbULP.IsVisible)
					{
						num2 = (short)102825991;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_524;
				case 2:
					num2 = (short)626458654;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						num2 = (short)1141964817;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_22E;
				case 4:
				{
					num2 = (short)1763311616;
					short num3 = num2;
					this.a(RptMgrErrorHandler.b("\uda91ꖓꆕ", a_));
					num2 = (short)315883542;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_16B;
				case 6:
				{
					if (!this.cbMariTimeRadio.IsVisible)
					{
						goto IL_12C;
					}
					num2 = (short)1341664083;
					short num4 = num2;
					num2 = (short)988097363;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16B;
					default:
						num2 = (short)727252992;
						if (num2 != 0)
						{
						}
						num2 = (short)1092550676;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					isChecked = this.cbULP.IsChecked;
					flag = true;
					num2 = (short)2104295432;
					num = (int)((IntPtr)num2);
					continue;
				case 8:
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						num2 = (short)273874944;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_524;
				case 9:
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						num2 = (short)707461147;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_170;
				case 10:
					if (this.cmbRegion.SelectedIndex == 1)
					{
						num2 = (short)683474946;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_36D;
				case 11:
					this.a(RptMgrErrorHandler.b("쎑햓ꚕꮗꪙꦛꮝ", a_));
					num2 = (short)1010302999;
					num = (int)((IntPtr)num2);
					continue;
				case 12:
					goto IL_170;
				case 13:
					goto IL_12C;
				case 14:
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						num2 = (short)401866780;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_654;
				case 15:
					this.a(RptMgrErrorHandler.b("햑햓ꚕꦗꪙ꾛궝", a_));
					num2 = (short)1265762317;
					num = (int)((IntPtr)num2);
					continue;
				case 16:
					if (this.cbDualKnobs.IsVisible)
					{
						num2 = (short)443416581;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_22E;
				case 17:
					this.a(RptMgrErrorHandler.b("쎑햓ꚕ겗ꊙꪛꮝ", a_));
					num2 = (short)1844051994;
					num = (int)((IntPtr)num2);
					continue;
				case 18:
					if (this.cmbRegion.SelectedIndex == 2)
					{
						num2 = (short)294912004;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)898695178;
					num = (int)((IntPtr)num2);
					continue;
				case 19:
					if (this.cbDisableEnc.IsVisible)
					{
						num2 = (short)1182400536;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_654;
				case 20:
					isChecked = this.cbMariTimeRadio.IsChecked;
					flag = true;
					num2 = (short)363003933;
					num = (int)((IntPtr)num2);
					continue;
				case 21:
					goto IL_524;
				case 22:
					goto IL_36D;
				case 23:
					goto IL_36D;
				case 24:
					isChecked = this.cbDisableEnc.IsChecked;
					flag = true;
					num2 = (short)1589575694;
					num = (int)((IntPtr)num2);
					continue;
				case 25:
					goto IL_40C;
				case 26:
					goto IL_22E;
				case 27:
					this.a(RptMgrErrorHandler.b("쎑햓ꚕꮗ궙겛꾝", a_));
					num2 = (short)1996423180;
					num = (int)((IntPtr)num2);
					continue;
				case 28:
					this.a(RptMgrErrorHandler.b("쎑햓ꚕ궗궙ꦛ꾝", a_));
					num2 = (short)628424729;
					num = (int)((IntPtr)num2);
					continue;
				case 29:
					if (isChecked.GetValueOrDefault() == flag & isChecked != null)
					{
						num2 = (short)2113470479;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_12C;
				case 30:
					if (((ComboBoxItem)this.cmbRegion.ItemContainerGenerator.ContainerFromIndex(1)).Foreground == Brushes.Black)
					{
						num2 = (short)585302027;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_36D;
				}
				goto IL_95;
				IL_12C:
				num2 = (short)31916048;
				num = (int)((IntPtr)num2);
				continue;
				IL_16B:
				isChecked = this.cbDualKnobs.IsChecked;
				flag = true;
				num2 = (short)1819738115;
				num = (int)((IntPtr)num2);
				continue;
				IL_170:
				num2 = (short)239599622;
				num = (int)((IntPtr)num2);
				continue;
				IL_22E:
				num2 = (short)194248723;
				num = (int)((IntPtr)num2);
				continue;
				IL_36D:
				num2 = (short)779485185;
				num = (int)((IntPtr)num2);
				continue;
				IL_524:
				num2 = (short)1379794945;
				if (num2 != 0)
				{
				}
				isChecked = this.cbAPX6000P25.IsChecked;
				flag = true;
				num2 = (short)1455423497;
				num = (int)((IntPtr)num2);
			}
			IL_40C:
			IL_654:
			base.DialogResult = new bool?(true);
			return;
			IL_95:
			this.DepotOptions.Clear();
			this.c = true;
			this.c();
			this.DepotOptions = this.k.PCIOptionList;
			num2 = (short)1327628306;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0016A9BC File Offset: 0x00168BBC
		private void a(string A_0)
		{
			short num = (short)126418945;
			if (num != 0)
			{
			}
			num = (short)944808988;
			short num2 = num;
			num = (short)1284678684;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_94:
				num = (short)70975488;
				num3 = (int)((IntPtr)num);
				break;
			default:
				num = (short)7471104;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					if (!this.DepotOptions.Contains(A_0))
					{
						num = (short)1442381825;
						num3 = (int)((IntPtr)num);
						continue;
					}
					goto IL_F1;
				case 1:
					this.DepotOptions.Add(A_0);
					num = (short)643366914;
					num3 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_EF;
				}
				goto IL_8C;
			}
			IL_EF:
			IL_F1:
			num = (short)781254656;
			short num4 = num;
			return;
			IL_8C:
			A_0 = A_0.Trim();
			goto IL_94;
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0016AAE4 File Offset: 0x00168CE4
		private void SelectModel(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 8;
			short num;
			try
			{
				num = (short)1298857984;
				switch (num)
				{
				default:
				{
					num = (short)1293484035;
					int num2 = (int)((IntPtr)num);
					for (;;)
					{
						int selectedIndex;
						switch (num2)
						{
						case 0:
							if (this.j != null)
							{
								num = (short)2016673796;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_BC;
						case 1:
							goto IL_45A;
						case 2:
						{
							num = (short)144347894;
							short num3 = num;
							num = (short)1525191414;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_43B;
							default:
								num = (short)1108279296;
								if (num != 0)
								{
								}
								goto IL_266;
							}
							break;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_8C;
							}
							continue;
						case 4:
							num = (short)326828044;
							num2 = (int)((IntPtr)num);
							continue;
						case 5:
							this.cmbModelNum.Items.Clear();
							num = (short)1820590082;
							num2 = (int)((IntPtr)num);
							continue;
						case 6:
						{
							Dictionary<string, string> dictionary = this.j[selectedIndex];
							num = (short)1944059919;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 7:
							goto IL_47E;
						case 8:
							if (this.cmbModelNum != null)
							{
								num = (short)920715273;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_45A;
						case 9:
							num = (short)1565917197;
							num2 = (int)((IntPtr)num);
							continue;
						case 10:
						{
							Dictionary<string, string> dictionary;
							Dictionary<string, string>.KeyCollection.Enumerator enumerator = dictionary.Keys.GetEnumerator();
							goto IL_43B;
						}
						case 11:
							this.cmbModelNum.SelectedIndex = 0;
							num = (short)2067726337;
							num2 = (int)((IntPtr)num);
							continue;
						case 12:
							if (this.j.ContainsKey(selectedIndex))
							{
								num = (short)1764032518;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_BC;
						case 13:
							if (this.cmbModelNum.Items.Count > 0)
							{
								num = (short)341901323;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_45A;
						case 14:
							try
							{
								num = (short)783941632;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_141;
										}
										continue;
									case 1:
										goto IL_253;
									case 2:
									{
										Dictionary<string, string>.KeyCollection.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)667811844;
											num2 = (int)((IntPtr)num);
											continue;
										}
										string text = enumerator.Current;
										ComboBoxItem comboBoxItem = new ComboBoxItem();
										comboBoxItem.Content = text;
										Dictionary<string, string> dictionary;
										new ToolTip().Content = dictionary[text];
										comboBoxItem.ToolTip = dictionary[text];
										num = (short)1691090947;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 3:
									{
										string text;
										if (Array.IndexOf<string>(new string[]
										{
											RptMgrErrorHandler.b("쎊떌뮎욐킒톔꺖즘첚ꢜ\ude9e", a_)
										}, text) <= -1)
										{
											num = (short)127270918;
											num2 = (int)((IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
										num = (short)1626341377;
										num2 = (int)((IntPtr)num);
										continue;
									case 6:
									{
										ComboBoxItem comboBoxItem;
										this.cmbModelNum.Items.Add(comboBoxItem);
										num = (short)978845701;
										num2 = (int)((IntPtr)num);
										continue;
									}
									}
									IL_143:
									num = (short)1226768386;
									num2 = (int)((IntPtr)num);
									continue;
									IL_141:
									goto IL_143;
								}
								IL_253:
								goto IL_BC;
							}
							finally
							{
								Dictionary<string, string>.KeyCollection.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							goto IL_266;
						case 15:
						{
							Dictionary<string, string> dictionary;
							if (dictionary != null)
							{
								num = (short)1263206410;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_BC;
						}
						}
						IL_8C:
						if (this.cmbModelNum.Items.Count > 0)
						{
							num = (short)313327621;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_266;
						IL_BC:
						num = (short)1125580808;
						num2 = (int)((IntPtr)num);
						continue;
						IL_266:
						selectedIndex = ((ComboBox)A_0).SelectedIndex;
						num = (short)686948352;
						num2 = (int)((IntPtr)num);
						continue;
						IL_43B:
						num = (short)451084302;
						num2 = (int)((IntPtr)num);
						continue;
						IL_45A:
						this.d();
						this.b();
						num = (short)1239613447;
						num2 = (int)((IntPtr)num);
					}
					IL_47E:
					break;
				}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			num = (short)1024327680;
			short num4 = num;
			num = (short)1199243265;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0016B004 File Offset: 0x00169204
		private void cmbModelNum_SelectionChanged(object A_0, SelectionChangedEventArgs A_1)
		{
			short num = (short)2020540416;
			short num2 = num;
			num = (short)987204828;
			short num3 = num;
			num = (short)442469596;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)50200576;
				if (num != 0)
				{
				}
				if (this.cmbModelNum.SelectedIndex <= -1)
				{
					return;
				}
				break;
			}
			try
			{
				num = (short)2083651585;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_D5;
				}
				int num4;
				int selectedIndex;
				ComboBoxItem comboBoxItem;
				for (;;)
				{
					IL_B7:
					switch (num4)
					{
					case 0:
						if (this.j != null)
						{
							num = (short)1502412803;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1C4;
					case 1:
					{
						ToolTip toolTip = new ToolTip();
						toolTip.Content = this.j[selectedIndex][comboBoxItem.Content as string];
						this.cmbModelNum.ToolTip = toolTip;
						num = (short)1324089349;
						num4 = (int)((IntPtr)num);
						continue;
					}
					case 2:
						if (this.j.ContainsKey(selectedIndex))
						{
							num = (short)346947585;
							num4 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1C4;
					case 3:
						num = (short)1409613826;
						num4 = (int)((IntPtr)num);
						continue;
					case 4:
						goto IL_1DB;
					case 5:
						goto IL_1C4;
					}
					goto IL_D5;
					IL_1C4:
					num = (short)1957429252;
					num4 = (int)((IntPtr)num);
				}
				IL_1DB:
				return;
				IL_D5:
				comboBoxItem = (this.cmbModelNum.Items[this.cmbModelNum.SelectedIndex] as ComboBoxItem);
				selectedIndex = this.cmbRadio.SelectedIndex;
				num = (short)138739712;
				num4 = (int)((IntPtr)num);
				goto IL_B7;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0016B218 File Offset: 0x00169418
		private void b()
		{
			short num = (short)1905786883;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				Brush brush;
				Brush brush2;
				switch (num2)
				{
				case 0:
					goto IL_173;
				case 1:
					num = (short)1387855887;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					if (this.cmbRegion != null)
					{
						num = (short)1527513089;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2F8;
				case 3:
				{
					num = (short)521229103;
					short num3 = num;
					num = (short)1993102127;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_173;
					default:
						num = (short)341835776;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B2;
						}
						continue;
					}
					break;
				}
				case 4:
					num = (short)773652493;
					num2 = (int)((IntPtr)num);
					continue;
				case 5:
					num = (short)1468203016;
					num2 = (int)((IntPtr)num);
					continue;
				case 6:
					this.c = false;
					num = (short)1138491406;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					goto IL_310;
				case 8:
					brush = Brushes.Red;
					goto IL_15B;
				case 9:
				{
					num = (short)1476263937;
					if (num != 0)
					{
					}
					num = (short)618528768;
					short num4 = num;
					brush = this.NormalBorder;
					goto IL_15B;
				}
				case 10:
					num = (short)1516896268;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					brush2 = this.NormalBorder;
					goto IL_1D2;
				case 12:
					if (((ComboBoxItem)this.cmbRegion.SelectedItem).Foreground == Brushes.Red)
					{
						num = (short)238419974;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2F8;
				case 13:
					brush2 = Brushes.Red;
					goto IL_1D2;
				case 14:
					goto IL_2F8;
				case 15:
					if (this.cmbRegion.SelectedIndex == 1)
					{
						num = (short)1475608586;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2F8;
				}
				IL_B2:
				if (!this.a)
				{
					num = (short)213057541;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)262864905;
				num2 = (int)((IntPtr)num);
				continue;
				IL_15B:
				Brush borderBrush = brush;
				num = (short)543555584;
				num2 = (int)((IntPtr)num);
				continue;
				IL_173:
				if (!this.b)
				{
					num = (short)1611202564;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)270925835;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1D2:
				Brush borderBrush2 = brush2;
				this.txtFlashCode1.BorderBrush = borderBrush;
				this.txtFlashCode2.BorderBrush = borderBrush;
				this.txtFlashCodeCheckSum.BorderBrush = borderBrush;
				this.txtSerNum.BorderBrush = borderBrush2;
				this.c = true;
				num = (short)1165361154;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2F8:
				num = (short)170917895;
				num2 = (int)((IntPtr)num);
			}
			IL_310:
			this.btnOK.IsEnabled = (this.a && this.b && this.c);
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x0016B560 File Offset: 0x00169760
		private Brush NormalBorder
		{
			get
			{
				short num = (short)261357568;
				short num2 = num;
				num = (short)986366496;
				short num3 = num;
				num = (short)1164821024;
				switch (num3 == num)
				{
				}
				num = (short)1578237953;
				if (num != 0)
				{
				}
				num = (short)86310912;
				if (num != 0)
				{
				}
				return this.cmbRadio.BorderBrush;
			}
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0016B614 File Offset: 0x00169814
		private void btnCancel_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1138163712;
			short num2 = num;
			num = (short)1532213399;
			short num3 = num;
			num = (short)1420933271;
			switch (num3 == num)
			{
			}
			num = (short)963510272;
			if (num != 0)
			{
			}
			num = (short)299237377;
			if (num != 0)
			{
			}
			base.Close();
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0016B6C0 File Offset: 0x001698C0
		private void cmbRegion_SelectionChanged(object A_0, SelectionChangedEventArgs A_1)
		{
			short num = (short)409468928;
			short num2 = num;
			num = (short)56444524;
			short num3 = num;
			num = (short)388515436;
			switch (num3 == num)
			{
			}
			num = (short)1510080512;
			if (num != 0)
			{
			}
			num = (short)1061879809;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x0400084B RID: 2123
		private bool a = true;

		// Token: 0x0400084C RID: 2124
		private bool b = true;

		// Token: 0x0400084D RID: 2125
		private bool c = true;

		// Token: 0x0400084E RID: 2126
		private string d = "";

		// Token: 0x0400084F RID: 2127
		private const string e = "APX5000";

		// Token: 0x04000850 RID: 2128
		private const string f = "APX5500";

		// Token: 0x04000851 RID: 2129
		private const string g = "APX6000";

		// Token: 0x04000852 RID: 2130
		private const string h = "APX6500";

		// Token: 0x04000853 RID: 2131
		private const string i = "I";

		// Token: 0x04000854 RID: 2132
		private Dictionary<int, Dictionary<string, string>> j;

		// Token: 0x04000855 RID: 2133
		private PCIHandler k = new PCIHandler();

		// Token: 0x04000856 RID: 2134
		[CompilerGenerated]
		private List<string> l;
	}
}
