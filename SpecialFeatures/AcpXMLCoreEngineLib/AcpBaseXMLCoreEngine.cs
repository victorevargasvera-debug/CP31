using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml;
using AcpCommonLib;
using Common;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.AcpXMLCoreEngineLib;

namespace SpecialFeatures.ACPXMLCoreEngineLib
{
	// Token: 0x02000232 RID: 562
	public abstract class AcpBaseXMLCoreEngine
	{
		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x0026ACF0 File Offset: 0x00268EF0
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x0026ADA4 File Offset: 0x00268FA4
		protected global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports acpr
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)917489599;
				short num2 = num;
				num = (short)293455807;
				switch (num2 == num)
				{
				}
				num = (short)2124546048;
				short num3 = num;
				num = (short)2104164353;
				if (num != 0)
				{
				}
				num = (short)131072000;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)969736193;
				if (num != 0)
				{
				}
				num = (short)1692296010;
				short num2 = num;
				num = (short)797074250;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1594884096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)760741888;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0026AE58 File Offset: 0x00269058
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x0026AF0C File Offset: 0x0026910C
		protected string cul
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)369198236;
				short num2 = num;
				num = (short)1268614300;
				switch (num2 == num)
				{
				}
				num = (short)1629618176;
				short num3 = num;
				num = (short)182517761;
				if (num != 0)
				{
				}
				num = (short)880738304;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)944046081;
				if (num != 0)
				{
				}
				num = (short)607859760;
				short num2 = num;
				num = (short)63124528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1387003904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2128936960;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x0026AFC0 File Offset: 0x002691C0
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x0026B074 File Offset: 0x00269274
		protected global::System.Globalization.CultureInfo ci
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)939250827;
				short num2 = num;
				num = (short)1795019915;
				switch (num2 == num)
				{
				}
				num = (short)2026307584;
				short num3 = num;
				num = (short)1086455808;
				if (num != 0)
				{
				}
				num = (short)1755709441;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1312378573;
				short num2 = num;
				num = (short)1548046029;
				switch (num2 == num)
				{
				}
				num = (short)381091840;
				short num3 = num;
				num = (short)1174142977;
				if (num != 0)
				{
				}
				num = (short)942931968;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x0026B124 File Offset: 0x00269324
		// (set) Token: 0x06001C65 RID: 7269 RVA: 0x0026B1D4 File Offset: 0x002693D4
		protected bool isRTL
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2056072859;
				short num2 = num;
				num = (short)635842203;
				switch (num2 == num)
				{
				}
				num = (short)1624440832;
				short num3 = num;
				num = (short)1005453313;
				if (num != 0)
				{
				}
				num = (short)279773184;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1809645568;
				short num2 = num;
				num = (short)1734344493;
				short num3 = num;
				num = (short)1700331309;
				switch (num3 == num)
				{
				}
				num = (short)807600128;
				if (num != 0)
				{
				}
				num = (short)1600323585;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0026B284 File Offset: 0x00269484
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x0026B334 File Offset: 0x00269534
		protected string indexSeparator
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)174325760;
				short num2 = num;
				num = (short)111477684;
				short num3 = num;
				num = (short)1528693684;
				switch (num3 == num)
				{
				}
				num = (short)1669660672;
				if (num != 0)
				{
				}
				num = (short)1559822337;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1655504896;
				short num2 = num;
				num = (short)1768224009;
				short num3 = num;
				num = (short)1823733001;
				switch (num3 == num)
				{
				}
				num = (short)1621622785;
				if (num != 0)
				{
				}
				num = (short)1724973056;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x0026B3E4 File Offset: 0x002695E4
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x0026B494 File Offset: 0x00269694
		protected global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet rptRec
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)492306432;
				short num2 = num;
				num = (short)2087419628;
				short num3 = num;
				num = (short)517963500;
				switch (num3 == num)
				{
				}
				num = (short)371130369;
				if (num != 0)
				{
				}
				num = (short)730464256;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1371865088;
				short num2 = num;
				num = (short)1580072961;
				if (num != 0)
				{
				}
				num = (short)1171697858;
				short num3 = num;
				num = (short)1870966978;
				switch (num3 == num)
				{
				}
				num = (short)2038431744;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x0026B548 File Offset: 0x00269748
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x0026B5F8 File Offset: 0x002697F8
		protected global::SpecialFeatures.AcpXMLCoreEngineLib._Value rptValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1020657664;
				short num2 = num;
				num = (short)1339507356;
				short num3 = num;
				num = (short)1018118812;
				switch (num3 == num)
				{
				}
				num = (short)144637953;
				if (num != 0)
				{
				}
				num = (short)959840256;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1987575808;
				short num2 = num;
				num = (short)73561069;
				short num3 = num;
				num = (short)1730376685;
				switch (num3 == num)
				{
				}
				num = (short)926351360;
				if (num != 0)
				{
				}
				num = (short)1524891649;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0026B6A8 File Offset: 0x002698A8
		public AcpBaseXMLCoreEngine()
		{
			int a_ = 14;
			base..ctor();
			this.XMLRptDataObj = new global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData();
			this.rptTable = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
			this.acpr = new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
			this.cul = global::AcpCommonLib.AppInfoManager.ReportsLangSelection;
			this.ci = new global::System.Globalization.CultureInfo(this.cul);
			this.isRTL = this.ci.TextInfo.IsRightToLeft;
			this.indexSeparator = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붐", a_);
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			this.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
			this.rptValue = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
		}

		// Token: 0x06001C6D RID: 7277
		public abstract void BuildDataTables(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData XMLRptDataObj);

		// Token: 0x06001C6E RID: 7278 RVA: 0x0026B74C File Offset: 0x0026994C
		public void BuildXMLfile(string XMLFileName, ref int inError)
		{
			int a_ = 8;
			short num = (short)12845056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_94;
				}
				string radInfoGeneralModelNumber_A8539_UIValue;
				global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData xmldata;
				global::System.Globalization.CultureInfo culture;
				for (;;)
				{
					IL_31:
					global::System.Xml.XmlTextWriter xmlTextWriter;
					string str;
					switch (num2)
					{
					case 0:
						if (radInfoGeneralModelNumber_A8539_UIValue.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊뒌붎", a_)))
						{
							num = (short)848429063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F70;
					case 1:
					{
						num = (short)1640366080;
						short num3 = num;
						try
						{
							xmlTextWriter = new global::System.Xml.XmlTextWriter(XMLFileName, null);
							xmlTextWriter.Formatting = global::System.Xml.Formatting.Indented;
							xmlTextWriter.Indentation = 3;
							xmlTextWriter.WriteStartDocument();
							xmlTextWriter.WriteStartElement(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊ﮎ", a_));
							xmlTextWriter.WriteAttributeString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8a잒ﲔﺚ", a_), xmldata.PageTitle);
							using (global::System.Collections.Generic.List<global::SpecialFeatures.AcpXMLCoreEngineLib._table>.Enumerator enumerator = xmldata.tables.GetEnumerator())
							{
								num = (short)928579584;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator2;
									global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_47C;
										}
										continue;
									case 1:
										xmlTextWriter.WriteStartElement(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8a﶐", a_));
										xmlTextWriter.WriteAttributeString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8a﶐\udb94ﺚ", a_), "");
										num = (short)1583415301;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										try
										{
											num = (short)98500608;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_4C8;
													}
													continue;
												case 1:
												{
													string text;
													if (text == null)
													{
														num = (short)1739522053;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													xmlTextWriter.WriteElementString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좊얐朗ﮖﲘ", a_), text);
													num = (short)1209401348;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
													goto IL_5BE;
												case 5:
													xmlTextWriter.WriteElementString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좊얐朗ﮖﲘ", a_), "");
													num = (short)208666626;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 6:
													num = (short)1000013827;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 7:
												{
													if (!enumerator2.MoveNext())
													{
														num = (short)1334771718;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													string text = enumerator2.Current;
													num = (short)498139137;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_537:
												num = (short)509411335;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_4C8:
												goto IL_537;
											}
											IL_5BE:
											goto IL_D11;
										}
										finally
										{
											((global::System.IDisposable)enumerator2).Dispose();
										}
										goto IL_5D1;
										IL_D11:
										xmlTextWriter.WriteEndElement();
										global::System.Collections.Generic.List<global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet>.Enumerator enumerator3 = table.RecSet.GetEnumerator();
										num = (short)1572405256;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_5D1;
									case 5:
										goto IL_5D1;
									case 6:
										goto IL_DE6;
									case 7:
										num = (short)299499526;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										try
										{
											num = (short)901185537;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
												global::System.Collections.Generic.List<global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields>.Enumerator enumerator5;
												switch (num2)
												{
												case 0:
													goto IL_C46;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_66E;
													}
													continue;
												case 2:
													goto IL_76C;
												case 4:
													goto IL_C01;
												case 5:
													if (recSet.RecTitle == null)
													{
														num = (short)698155015;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													xmlTextWriter.WriteAttributeString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a얐朗ﮖﲘ", a_), recSet.RecTitle);
													num = (short)496631814;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 6:
													goto IL_76C;
												case 7:
													xmlTextWriter.WriteAttributeString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a얐朗ﮖﲘ", a_), "");
													num = (short)1606483970;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 8:
												{
													global::System.Collections.Generic.List<global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet>.Enumerator enumerator3;
													if (!enumerator3.MoveNext())
													{
														num = (short)1433993227;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													recSet = enumerator3.Current;
													xmlTextWriter.WriteStartElement(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a슐", a_));
													num = (short)463077381;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 9:
													try
													{
														num = (short)1848836096;
														num2 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															global::System.Collections.Generic.List<global::SpecialFeatures.AcpXMLCoreEngineLib._Value>.Enumerator enumerator4;
															global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
															switch (num2)
															{
															case 0:
																switch (0)
																{
																case 0:
																	goto IL_833;
																}
																continue;
															case 2:
																try
																{
																	num = (short)75235328;
																	num2 = (int)((global::System.IntPtr)num);
																	for (;;)
																	{
																		switch (num2)
																		{
																		case 0:
																			switch (0)
																			{
																			case 0:
																				goto IL_8A4;
																			}
																			continue;
																		case 1:
																			xmlTextWriter.WriteElementString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8a", a_), "");
																			num = (short)1291321348;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		case 2:
																		{
																			global::SpecialFeatures.AcpXMLCoreEngineLib._Value value;
																			if (value.FieldValue == null)
																			{
																				num = (short)102957057;
																				num2 = (int)((global::System.IntPtr)num);
																				continue;
																			}
																			xmlTextWriter.WriteElementString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8a", a_), global::SpecialFeatures.AcpXMLCoreEngineLib.AcpXMLCoreEngLib.convertToArabicFormat(value.FieldValue));
																			num = (short)723976198;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		case 3:
																			goto IL_9FE;
																		case 5:
																		{
																			if (enumerator4.MoveNext())
																			{
																				global::SpecialFeatures.AcpXMLCoreEngineLib._Value value = enumerator4.Current;
																				num = (short)1223426050;
																				num2 = (int)((global::System.IntPtr)num);
																				continue;
																			}
																			num = (short)1209024146;
																			short num4 = num;
																			num = (short)741031570;
																			switch ((num4 == num) ? 1 : 0)
																			{
																			case 0:
																			case 2:
																				break;
																			default:
																				num = (short)538902528;
																				if (num != 0)
																				{
																				}
																				num = (short)1824456711;
																				num2 = (int)((global::System.IntPtr)num);
																				continue;
																			}
																			break;
																		}
																		case 7:
																			num = (short)394133507;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		IL_8EA:
																		num = (short)478019589;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																		IL_8A4:
																		goto IL_8EA;
																	}
																	IL_9FE:
																	goto IL_838;
																}
																finally
																{
																	((global::System.IDisposable)enumerator4).Dispose();
																}
																break;
																IL_838:
																xmlTextWriter.WriteEndElement();
																xmlTextWriter.WriteEndElement();
																num = (short)4390913;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 3:
																if (!enumerator5.MoveNext())
																{
																	num = (short)1263468548;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																uifields = enumerator5.Current;
																xmlTextWriter.WriteStartElement(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊﶐", a_));
																num = (short)1800404999;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 4:
																num = (short)1381892102;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 5:
																goto IL_B13;
															case 6:
																goto IL_B86;
															case 7:
																if (uifields.UIFieldDes == null)
																{
																	num = (short)258605065;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																xmlTextWriter.WriteAttributeString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊﶐톔", a_), uifields.UIFieldDes);
																num = (short)11206661;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 8:
																goto IL_B13;
															case 9:
																xmlTextWriter.WriteAttributeString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊﶐톔", a_), "");
																num = (short)763166728;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_A11:
															num = (short)2048786435;
															num2 = (int)((global::System.IntPtr)num);
															continue;
															IL_833:
															goto IL_A11;
															IL_B13:
															xmlTextWriter.WriteElementString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얊", a_), uifields.UIFieldName);
															xmlTextWriter.WriteStartElement(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8a", a_));
															enumerator4 = uifields.values.GetEnumerator();
															num = (short)20774914;
															num2 = (int)((global::System.IntPtr)num);
														}
														IL_B86:
														goto IL_673;
													}
													finally
													{
														((global::System.IDisposable)enumerator5).Dispose();
													}
													goto IL_B99;
													IL_673:
													xmlTextWriter.WriteEndElement();
													num = (short)223739907;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 10:
													goto IL_B99;
												case 11:
													num = (short)1681260544;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 12:
													goto IL_C01;
												case 13:
													if (recSet.RecNo == null)
													{
														num = (short)88801290;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													xmlTextWriter.WriteAttributeString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a\udf90ﲒ", a_), recSet.RecNo);
													num = (short)1784152068;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_72A:
												num = (short)1173356552;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_66E:
												goto IL_72A;
												IL_76C:
												num = (short)886243341;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_B99:
												xmlTextWriter.WriteAttributeString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98a\udf90ﲒ", a_), "");
												num = (short)278855692;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_C01:
												enumerator5 = recSet.UIFields.GetEnumerator();
												num = (short)327548937;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_C46:
											goto IL_CF1;
										}
										finally
										{
											global::System.Collections.Generic.List<global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet>.Enumerator enumerator3;
											((global::System.IDisposable)enumerator3).Dispose();
										}
										goto IL_C59;
										IL_CF1:
										xmlTextWriter.WriteEndElement();
										num = (short)1193213955;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										if (!enumerator.MoveNext())
										{
											num = (short)1470300167;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										table = enumerator.Current;
										num = (short)1717436426;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										if (table.TableTitle == null)
										{
											num = (short)1805713409;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_C59;
									}
									goto IL_47C;
									IL_5D1:
									xmlTextWriter.WriteStartElement(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8a﶐\udd94ﾚ", a_));
									enumerator2 = table.ColTitle.GetEnumerator();
									num = (short)853409794;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_C59:
									xmlTextWriter.WriteStartElement(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8a﶐", a_));
									xmlTextWriter.WriteAttributeString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8a﶐\udb94ﺚ", a_), table.TableTitle);
									num = (short)1550188548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_D8D:
									num = (short)1026490377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_47C:
									goto IL_D8D;
								}
								IL_DE6:;
							}
							xmlTextWriter.WriteEndElement();
							return;
						}
						catch (global::System.Exception ex)
						{
							global::System.Windows.MessageBox.Show(ex.Message);
							inError = 1;
							return;
						}
						finally
						{
							num = (short)1614741504;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_E47;
									}
									continue;
								case 1:
									goto IL_E7E;
								case 2:
									xmlTextWriter.Close();
									num = (short)143196161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E47:
								if (xmlTextWriter == null)
								{
									break;
								}
								num = (short)1051000834;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E7E:;
						}
						goto IL_E81;
					}
					case 2:
						if (radInfoGeneralModelNumber_A8539_UIValue.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잊", a_)))
						{
							num = (short)359464963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A1;
					case 3:
						xmldata.PageTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪊\udd8c힎놐킒杖練爵햠힢삤螦", a_) + global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98aﲒ쪔\ude96ﶘ", a_), culture);
						num = (short)1719140370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_251;
					case 5:
						num = (short)437518344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_FBF;
					case 7:
						num = (short)1127022612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (radInfoGeneralModelNumber_A8539_UIValue.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("벊첌솎", a_)))
						{
							num = (short)765657104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E81;
					case 9:
						num = (short)1361379329;
						if (num != 0)
						{
						}
						str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8a햌ꊎ", a_);
						num = (short)477954061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_1037;
					case 11:
						if (radInfoGeneralModelNumber_A8539_UIValue.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊뒌벎", a_)))
						{
							num = (short)1198784521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_251;
					case 12:
						goto IL_F70;
					case 13:
						if (global::Common.Product.IsVertex())
						{
							num = (short)995688465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1037;
					case 14:
						if (!radInfoGeneralModelNumber_A8539_UIValue.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붊첌솎", a_)))
						{
							num = (short)1435107333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_181;
					case 15:
						if (radInfoGeneralModelNumber_A8539_UIValue.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊벌몎쒐킒펔꺖즘첚ꮜ\ude9e", a_)))
						{
							num = (short)1826488341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FBF;
					case 16:
						goto IL_181;
					case 17:
						str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8aﶎ랖쪘ﲜ얠슢힤쎦蒨", a_);
						num = (short)2035875850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_2A1;
					case 19:
						goto IL_251;
					case 20:
						if (!global::ConstraintHelper.UtilityMack.IsAPX1000i)
						{
							num = (short)424804374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F70;
					case 21:
						xmldata.PageTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪊\udd8c힎놐\udd92ꚔꞖ릘", a_) + global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98aﲒ쪔\ude96ﶘ", a_), culture);
						num = (short)1762066438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						xmldata.PageTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪊\udd8c힎놐ꪒꖔꞖ릘", a_) + global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98aﲒ쪔\ude96ﶘ", a_), culture);
						num = (short)1468530700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_94;
					IL_181:
					xmldata.PageTitle = str + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8a뒌뮎ꢐ뎒", a_) + global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98aﲒ쪔\ude96ﶘ", a_), culture);
					num = (short)1106771972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_251:
					this.BuildDataTables(ref xmldata);
					xmlTextWriter = null;
					num = (short)1155465217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A1:
					num = (short)1343684608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E81:
					xmldata.PageTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8a햌꾎", a_) + global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98aﲒ쪔\ude96ﶘ", a_), culture);
					num = (short)1336147987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F70:
					num = (short)1173356559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FBF:
					num = (short)1291911179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1037:
					num = (short)1142358030;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_94:
				culture = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				xmldata = new global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData();
				xmldata.PageTitle = string.Concat(new string[]
				{
					global::ConstraintHelper.UtilityMack.ProductModelId.Substring(0, 3),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꮊ", a_),
					global::ConstraintHelper.UtilityMack.ProductModelId.Substring(3),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꮊ", a_),
					global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98aﲒ쪔\ude96ﶘ", a_), culture)
				});
				radInfoGeneralModelNumber_A8539_UIValue = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539_UIValue;
				num = (short)1274609666;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x04000DFD RID: 3581
		protected global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData XMLRptDataObj;

		// Token: 0x04000DFE RID: 3582
		protected global::SpecialFeatures.AcpXMLCoreEngineLib._table rptTable;

		// Token: 0x04000DFF RID: 3583
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports a;

		// Token: 0x04000E00 RID: 3584
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x04000E01 RID: 3585
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Globalization.CultureInfo c;

		// Token: 0x04000E02 RID: 3586
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d;

		// Token: 0x04000E03 RID: 3587
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;

		// Token: 0x04000E04 RID: 3588
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet f;

		// Token: 0x04000E05 RID: 3589
		protected global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields rptFields;

		// Token: 0x04000E06 RID: 3590
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SpecialFeatures.AcpXMLCoreEngineLib._Value g;
	}
}
