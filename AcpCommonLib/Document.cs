using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using AcpCommonLib.Exceptions;
using AcpCommonLib.FieldsReport;
using AcpCommonLib.UndoRedo;
using AcpCryptoLib;

namespace AcpCommonLib
{
	// Token: 0x02000018 RID: 24
	public class Document
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00009F3C File Offset: 0x0000813C
		private bool CanImport
		{
			get
			{
				int a_ = 11;
				short num = (short)560005127;
				int num2 = (int)((global::System.IntPtr)num);
				string text;
				for (;;)
				{
					global::System.Xml.XmlElement xmlElement;
					switch (num2)
					{
					case 0:
						global::AcpCommonLib.Document.h = global::System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
						num = (short)650772483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						text = xmlElement.InnerText;
						num = (short)1346015964;
						short num3 = num;
						num = (short)1040683740;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)2108293120;
							if (num != 0)
							{
							}
							num = (short)1723531264;
							short num4 = num;
							num = (short)2100559874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						num = (short)986841089;
						if (num != 0)
						{
						}
						goto IL_72;
					case 3:
						goto IL_190;
					case 4:
						if (global::AcpCommonLib.Document.h == null)
						{
							num = (short)1223098368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_208;
					case 5:
						if (xmlElement != null)
						{
							num = (short)1600782337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72;
					case 6:
						return false;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_4D;
						}
						continue;
					}
					IL_4D:
					if (this.c == null)
					{
						num = (short)783417350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = global::AcpCommonLib.Exceptions.AcpSecurityException.b("飼釾", a_);
					xmlElement = this.c[global::AcpCommonLib.Exceptions.AcpSecurityException.b("黼諾爀眂樄樆嘈紊搌樎昐䰒焔砖稘", a_)][global::AcpCommonLib.Exceptions.AcpSecurityException.b("뇼黾漀搂瀄昆済渊", a_)];
					num = (short)1574699013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_72:
					num = (short)36372484;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_190:
				IL_208:
				return text == global::AcpCommonLib.Document.h;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000A15C File Offset: 0x0000835C
		private global::System.Xml.XmlDocument a(global::AcpCommonLib.XmlFileType A_0)
		{
			int a_ = 16;
			short num = (short)1102053376;
			short num2 = num;
			num = (short)966231402;
			short num3 = num;
			num = (short)1375634794;
			switch (num3 == num)
			{
			}
			num = (short)1736769537;
			if (num != 0)
			{
			}
			num = (short)116785152;
			if (num != 0)
			{
			}
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration(global::AcpCommonLib.Exceptions.AcpSecurityException.b("㌁⨃㘅", a_), global::AcpCommonLib.Exceptions.AcpSecurityException.b("圁倃䀅┇㈉", a_), null));
			global::System.Xml.XmlElement xmlElement = xmlDocument.CreateElement(global::AcpCommonLib.Exceptions.AcpSecurityException.b("愁焃甅簇攉愋儍昏笑焓愕䜗縙猛紝", a_));
			xmlDocument.AppendChild(xmlElement);
			global::System.Xml.XmlElement xmlElement2 = xmlDocument.CreateElement(global::AcpCommonLib.Exceptions.AcpSecurityException.b("吁愃琅笇按挋怍", a_));
			xmlElement2.InnerText = global::AcpCommonLib.Exceptions.AcpSecurityException.b("、", a_);
			xmlElement.AppendChild(xmlElement2);
			global::System.Xml.XmlElement xmlElement3 = xmlDocument.CreateElement(global::AcpCommonLib.Exceptions.AcpSecurityException.b("丁攃栅漇缉洋植甏", a_));
			xmlElement3.InnerText = global::System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
			xmlElement.AppendChild(xmlElement3);
			global::System.Xml.XmlElement xmlElement4 = xmlDocument.CreateElement(global::AcpCommonLib.Exceptions.AcpSecurityException.b("倁欃椅簇", a_));
			xmlElement.AppendChild(xmlElement4);
			this.a(xmlElement4, A_0);
			return xmlDocument;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000A2DC File Offset: 0x000084DC
		private void a(global::AcpCommonLib.IAcpRecordset A_0)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1993015297;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
					switch (num2)
					{
					case 0:
						goto IL_7B;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 2:
					{
						num = (short)2087212942;
						short num3 = num;
						num = (short)332879758;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)424476672;
							if (num != 0)
							{
							}
							try
							{
								num = (short)1600454657;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_15F;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_EB;
										}
										continue;
									case 2:
										this.a(acpFeatureSection.EmbeddedRecset);
										num = (short)278331392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_2BC;
									case 4:
										try
										{
											num = (short)1161297920;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_1E2;
													}
													continue;
												case 1:
													num = (short)1883701252;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													if (!enumerator.MoveNext())
													{
														num = (short)1123155969;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													enumerator.Current.CustomViewVisibility = false;
													num = (short)278331394;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 4:
													goto IL_250;
												}
												IL_1E4:
												num = (short)131465219;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_1E2:
												goto IL_1E4;
											}
											IL_250:
											break;
										}
										finally
										{
											num = (short)1625161729;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													enumerator.Dispose();
													num = (short)1199177730;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_285;
													}
													continue;
												case 2:
													goto IL_2B9;
												}
												IL_285:
												if (enumerator == null)
												{
													break;
												}
												num = (short)1678442496;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_2B9:;
										}
										goto IL_2BC;
									case 5:
										if (!enumerator2.MoveNext())
										{
											num = (short)966721539;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFeatureSection = enumerator2.Current;
										num = (short)1526267910;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										if (acpFeatureSection.HasEmbeddedRecset)
										{
											num = (short)1483866114;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_15F;
									case 7:
										goto IL_2D3;
									}
									IL_126:
									num = (short)692912133;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_EB:
									goto IL_126;
									IL_15F:
									enumerator = acpFeatureSection.FieldsCollection.GetEnumerator();
									num = (short)2097610756;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2BC:
									num = (short)816316423;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2D3:
								return;
							}
							finally
							{
								num = (short)778174465;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)363200514;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_309;
										}
										continue;
									case 2:
										goto IL_33D;
									}
									IL_309:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)534052864;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_33D:;
							}
							goto IL_340;
						}
						break;
					}
					}
					IL_32:
					if (A_0.Count == 0)
					{
						num = (short)665714688;
						short num4 = num;
						num = (short)602734592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_340:
					enumerator2 = A_0[0].FeatureSectionsCollection.GetEnumerator();
					num = (short)1814757378;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7B:
			num = (short)1379008513;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000A6DC File Offset: 0x000088DC
		private bool a(global::System.Xml.XmlDocument A_0, global::AcpCommonLib.XmlFileType A_1, bool A_2)
		{
			int a_ = 14;
			short num = (short)1662517248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_86;
				}
				bool flag;
				for (;;)
				{
					IL_31:
					num = (short)1787822081;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (!this.CanImport)
						{
							num = (short)1139015683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F1;
					case 1:
					{
						global::System.Xml.XmlNode xmlNode = A_0.ChildNodes[1];
						num = (short)1538654210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Xml.XmlNode xmlNode;
						if (xmlNode.Name.Equals(global::AcpCommonLib.Exceptions.AcpSecurityException.b("揿省眃爅朇有匋砍礏眑挓䤕簗甙缛", a_)))
						{
							num = (short)2031026185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)15204357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						global::AcpCommonLib.AppInfoManager.IsCustomViewLanguageMismatch = true;
						flag = false;
						num = (short)1787822087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							num = (short)1386348547;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpRecordset feature;
								global::System.Xml.XmlNode xmlNode2;
								switch (num2)
								{
								case 0:
									if (feature != null)
									{
										num = (short)713359366;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)704643077;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									xmlNode2 = (global::System.Xml.XmlNode)enumerator.Current;
									int id = 0;
									global::System.Xml.XmlAttribute xmlAttribute = xmlNode2.Attributes[global::AcpCommonLib.Exceptions.AcpSecurityException.b("䧿昁", a_)];
									num = (short)595591176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_11C;
									}
									continue;
								case 4:
									goto IL_275;
								case 5:
									num = (short)1311440900;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_1EB;
								case 7:
								{
									int id;
									try
									{
										global::System.Xml.XmlAttribute xmlAttribute;
										id = int.Parse(xmlAttribute.Value, global::System.Globalization.CultureInfo.InvariantCulture);
										goto IL_219;
									}
									catch (global::System.ArgumentNullException)
									{
										return false;
									}
									catch (global::System.FormatException)
									{
										return false;
									}
									catch (global::System.OverflowException)
									{
										return false;
									}
									goto IL_1EB;
									IL_219:
									feature = this.GetFeature(id);
									num = (short)213123072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::System.Xml.XmlAttribute xmlAttribute;
									if (xmlAttribute != null)
									{
										num = (short)1629552647;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_11E:
								num = (short)604045314;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11C:
								goto IL_11E;
								IL_1EB:
								feature.ReadFromXml(xmlNode2, null, A_1, A_2, null, null);
								num = (short)299302913;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_275:
							return flag;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_297;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_284:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)125763586;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2F0;
								case 1:
									goto IL_2EE;
								case 2:
									disposable.Dispose();
									num = (short)656670721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_297;
							}
							IL_2EE:
							IL_2F0:
							goto EndFinally_19;
							IL_297:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1566769152;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_284;
							EndFinally_19:;
						}
						goto IL_2F1;
					case 5:
						return flag;
					case 6:
					{
						try
						{
							num = (short)1759510529;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)2143624966;
								short num3 = num;
								num = (short)575348486;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1797783552;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										num = (short)1357053954;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_4DF;
										}
										continue;
									case 2:
										goto IL_55F;
									case 3:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1196687360;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpRecordset a_2 = enumerator2.Current;
										this.a(a_2);
										num = (short)17891332;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_4DF:
									break;
								}
								num = (short)1538326531;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_55F:
							goto IL_37F;
						}
						finally
						{
							num = (short)1514209280;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_597;
									}
									continue;
								case 1:
									goto IL_5CF;
								case 2:
									enumerator2.Dispose();
									num = (short)627703809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_597:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1302790146;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5CF:;
						}
						return flag;
						IL_37F:
						global::System.Xml.XmlNode lastChild;
						global::System.Collections.IEnumerator enumerator = lastChild.ChildNodes.GetEnumerator();
						num = (short)1106640900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_2F1;
					case 8:
						if (flag)
						{
							num = (short)824180737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 9:
					{
						global::System.Xml.XmlNode xmlNode;
						global::System.Xml.XmlNode lastChild = xmlNode.LastChild;
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2 = global::AcpCommonLib.FeatureManager.Features.GetEnumerator();
						num = (short)245039110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_86;
					IL_2F1:
					num = (short)186384384;
					short num4 = num;
					num = (short)1931870216;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_86:
				flag = true;
				this.c = A_0;
				global::AcpCommonLib.AppInfoManager.IsCustomViewLanguageMismatch = false;
				num = (short)1994326016;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000AD38 File Offset: 0x00008F38
		private void a(global::System.Xml.XmlElement A_0, global::AcpCommonLib.XmlFileType A_1)
		{
			short num;
			using (global::System.Collections.Generic.SortedDictionary<int, global::AcpCommonLib.IAcpRecordset>.ValueCollection.Enumerator enumerator = this.b.Values.GetEnumerator())
			{
				num = (short)601620483;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						acpRecordset.AddToXml(A_0, A_1);
						num = (short)208207873;
						if (num != 0)
						{
						}
						num = (short)581697542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						if (acpRecordset.HasVisibleObjects)
						{
							num = (short)555483136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						if (!acpRecordset.HiddenStatic)
						{
							num = (short)1068302341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					case 4:
						goto IL_1BD;
					case 5:
						num = (short)247791617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)1104554065;
						short num3 = num;
						num = (short)499394641;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1675493376;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					case 7:
						num = (short)1842937860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1955725319;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
						num = (short)1126105090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_99:
					num = (short)1927151624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D:
					goto IL_99;
				}
				IL_1BD:;
			}
			num = (short)688455680;
			short num4 = num;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000AF5C File Offset: 0x0000915C
		private global::AcpCommonLib.IAcpField a(string A_0, bool A_1, string A_2)
		{
			global::AcpCommonLib.IAcpField acpField = null;
			global::System.Collections.Generic.SortedDictionary<int, global::AcpCommonLib.IAcpRecordset>.ValueCollection.Enumerator enumerator = this.b.Values.GetEnumerator();
			short num;
			try
			{
				num = (short)146735104;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_65;
						}
						continue;
					case 1:
					{
						num = (short)299207497;
						short num3 = num;
						num = (short)719620937;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CC;
						default:
							num = (short)1385234432;
							if (num != 0)
							{
							}
							num = (short)1528299523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						if (acpField != null)
						{
							num = (short)1007157249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 3:
						goto IL_168;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)66650122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
						goto IL_CC;
					}
					case 5:
						goto IL_16D;
					case 6:
					{
						if (A_1)
						{
							num = (short)573898761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						acpField = acpRecordset.FieldFromFavoritePath(A_0, A_2);
						num = (short)705036296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_1E1;
					case 8:
						goto IL_16D;
					case 9:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						acpField = acpRecordset.FieldFromPath(A_0, A_2);
						num = (short)510918661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)183042055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8A:
					num = (short)493223940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65:
					goto IL_8A;
					IL_CC:
					num = (short)1000538118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16D:
					num = (short)1791033346;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_168:
				IL_1E1:;
			}
			finally
			{
				num = (short)457441281;
				if (num != 0)
				{
				}
				((global::System.IDisposable)enumerator).Dispose();
			}
			num = (short)1751908352;
			short num4 = num;
			return acpField;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000B1C8 File Offset: 0x000093C8
		protected internal void AddFeature(global::AcpCommonLib.IAcpRecordset recset)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
				int num3;
				switch (num)
				{
				case 0:
					if (recset.HasEmbeddedRecset)
					{
						num2 = (short)1242300420;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C6;
				case 1:
					goto IL_91;
				case 2:
					goto IL_17A;
				case 3:
					try
					{
						num2 = (short)268042241;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								switch (0)
								{
								case 0:
									goto IL_27E;
								}
								continue;
							case 2:
								num2 = (short)541523972;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
							{
								global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
								if (acpFeatureSection.HasEmbeddedRecset)
								{
									num2 = (short)427425798;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 4:
								goto IL_32C;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)1867513858;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator.Current;
								num2 = (short)1811087363;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 6:
							{
								global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
								acpFeatureSection.EmbeddedRecset.ContainerDoc = this;
								num2 = (short)346750976;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							IL_2B9:
							num2 = (short)1000931333;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_27E:
							goto IL_2B9;
						}
						IL_32C:
						goto IL_B8;
					}
					finally
					{
						num2 = (short)1490026496;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_363;
								}
								continue;
							case 1:
								goto IL_39A;
							case 2:
								enumerator.Dispose();
								num2 = (short)1073348609;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_363:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)17170434;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_39A:;
					}
					return;
					IL_B8:
					num3++;
					num2 = (short)579600392;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num3 = 0;
					num2 = (short)1870200837;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_79;
				case 6:
				{
					this.b.Add(recset.DataTransferOrder, recset);
					num2 = (short)1219197227;
					short num4 = num2;
					num2 = (short)710637867;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						num2 = (short)1014562816;
						if (num2 != 0)
						{
						}
						num2 = (short)1275330562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					if (recset.DataTransferOrder > 0)
					{
						num2 = (short)127991809;
						if (num2 != 0)
						{
						}
						num2 = (short)614268934;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					goto IL_79;
				case 9:
					goto IL_1C6;
				}
				goto IL_38;
				IL_79:
				num2 = (short)1036845057;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_91:
				if (num3 >= recset.Count)
				{
					num2 = (short)1960902665;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				enumerator = recset[num3].FeatureSectionsCollection.GetEnumerator();
				num2 = (short)50266115;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C6:
				this.a[recset.RecsetId] = recset;
				num2 = (short)832897031;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_17A:
			num2 = (short)2103181312;
			short num5 = num2;
			return;
			IL_38:
			recset.ContainerDoc = this;
			num2 = (short)1731526656;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000B584 File Offset: 0x00009784
		public Document()
		{
			this.a = new global::System.Collections.Generic.Dictionary<int, global::AcpCommonLib.IAcpRecordset>();
			this.b = new global::System.Collections.Generic.SortedDictionary<int, global::AcpCommonLib.IAcpRecordset>();
			global::AcpCommonLib.FeatureManager.ActiveDocument = this;
			global::AcpCommonLib.AppInfoManager.InvalidFieldsReport = new global::AcpCommonLib.FieldsReport.FieldsReportManager();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000B5C8 File Offset: 0x000097C8
		public Document(bool background, global::AcpCommonLib.DocumentType type)
		{
			this.a = new global::System.Collections.Generic.Dictionary<int, global::AcpCommonLib.IAcpRecordset>();
			this.b = new global::System.Collections.Generic.SortedDictionary<int, global::AcpCommonLib.IAcpRecordset>();
			this.Background = background;
			this.DocType = type;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000B60C File Offset: 0x0000980C
		public bool ExportToXml(string path, global::AcpCommonLib.XmlFileType fileType)
		{
			int a_ = 11;
			short num = (short)827719680;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 1:
				{
					num = (short)1706777347;
					short num3 = num;
					num = (short)1917344515;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
					{
						num = (short)1110835201;
						if (num != 0)
						{
						}
						num = (short)115539968;
						if (num != 0)
						{
						}
						if (fileType == global::AcpCommonLib.XmlFileType.CustomView)
						{
							num = (short)1390477315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Xml.XmlTextWriter xmlTextWriter = new global::System.Xml.XmlTextWriter(path, null);
						xmlTextWriter.Formatting = global::System.Xml.Formatting.Indented;
						global::System.Xml.XmlDocument xmlDocument;
						xmlDocument.WriteContentTo(xmlTextWriter);
						xmlTextWriter.Flush();
						num = (short)2008875012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					return false;
				case 3:
				{
					global::System.Xml.XmlDocument xmlDocument;
					new global::AcpCryptoLib.AcpXMLEncryptDecrypt().EncryptXMLDoc(xmlDocument, path);
					num = (short)1351286789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return true;
				case 5:
					return true;
				}
				IL_45:
				num = (short)1748697088;
				short num4 = num;
				if (!path.EndsWith(global::AcpCommonLib.Exceptions.AcpSecurityException.b("폼蟾氀漂", a_), global::System.StringComparison.Ordinal))
				{
					num = (short)932577282;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Xml.XmlDocument xmlDocument = this.a(fileType);
					num = (short)1505296385;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000B7CC File Offset: 0x000099CC
		public bool ImportFromXml(string path, global::AcpCommonLib.XmlFileType fileType)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::System.Xml.XmlDocument xmlDocument;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (fileType == global::AcpCommonLib.XmlFileType.CustomView)
					{
						num2 = (short)865927170;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1331830807;
					short num3 = num2;
					num2 = (short)2111709207;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num2 = (short)600244224;
						if (num2 != 0)
						{
						}
						xmlDocument = this.GetXmlDocument(path);
						num2 = (short)2061893635;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return false;
				case 2:
					xmlDocument = new global::AcpCryptoLib.AcpXMLEncryptDecrypt().DecryptXMLFile(path);
					num2 = (short)1320550404;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_B3;
				case 4:
					goto IL_B3;
				case 5:
					if (xmlDocument == null)
					{
						num2 = (short)184156161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_189;
				}
				goto IL_28;
				IL_B3:
				num2 = (short)2046296069;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_189:
			return this.a(xmlDocument, fileType, false);
			IL_28:
			num2 = (short)1619132417;
			if (num2 != 0)
			{
			}
			num2 = (short)70189056;
			short num4 = num2;
			xmlDocument = null;
			num2 = (short)495517696;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000B96C File Offset: 0x00009B6C
		public global::System.Xml.XmlDocument GetXmlDocument(string path)
		{
			int a_ = 2;
			short num = (short)1035382885;
			short num2 = num;
			num = (short)1603514469;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BE;
			case 1:
				break;
			default:
			{
				num = (short)766181376;
				short num3 = num;
				break;
			}
			}
			num = (short)1711144960;
			if (num != 0)
			{
			}
			num = (short)790364161;
			if (num != 0)
			{
			}
			if (path.EndsWith(global::AcpCommonLib.Exceptions.AcpSecurityException.b("\udaf3軵闷雹", a_), global::System.StringComparison.Ordinal))
			{
				global::System.Xml.XmlTextReader reader = new global::System.Xml.XmlTextReader(path);
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.Load(reader);
				return xmlDocument;
			}
			IL_BE:
			return null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000BA4C File Offset: 0x00009C4C
		public void Clear()
		{
			short num = (short)765657088;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<int, global::AcpCommonLib.IAcpRecordset>.ValueCollection.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					num = (short)890372097;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 1:
					try
					{
						num = (short)102629377;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_96;
							case 2:
								num = (short)674365444;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								global::AcpCommonLib.IAcpRecordset acpRecordset;
								if (acpRecordset != null)
								{
									num = (short)733937670;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								goto IL_1C2;
							case 5:
							{
								if (enumerator.MoveNext())
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
									num = (short)830341123;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)490235675;
								short num3 = num;
								num = (short)89483035;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_96;
								default:
									num = (short)914030592;
									if (num != 0)
									{
									}
									num = (short)887816194;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
							{
								global::AcpCommonLib.IAcpRecordset acpRecordset;
								acpRecordset.Clear();
								acpRecordset.ContainerDoc = null;
								num = (short)919797760;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_C2;
							IL_96:
							switch (0)
							{
							case 0:
								IL_C2:
								goto IL_FE;
							}
							continue;
							IL_FE:
							num = (short)181338117;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1C2:
						goto IL_263;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1D5;
				case 2:
					goto IL_1D5;
				case 3:
				{
					num = (short)1894711296;
					short num4 = num;
					global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
					global::AcpCommonLib.UndoRedo.UndoManager.Reset();
					global::AcpCommonLib.ConstraintManager.Suspend();
					this.g.Clear();
					num = (short)1449459714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_5C:
				if (this.IsMainDocument)
				{
					num = (short)1147207683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1D5:
				enumerator = this.a.Values.GetEnumerator();
				num = (short)2086076417;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_263:
			this.a.Clear();
			this.b.Clear();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000BCF0 File Offset: 0x00009EF0
		public void ClearHasDiffs()
		{
			short num = (short)1180237824;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = this.Features.GetEnumerator();
			goto IL_38;
			try
			{
				for (;;)
				{
					IL_38:
					num = (short)88211459;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_135;
						case 2:
							if (!enumerator.MoveNext())
							{
								num = (short)1547567108;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.ClearHasDiffs();
							num = (short)902234113;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_71;
							}
							continue;
						case 4:
							num = (short)1663238144;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_96:
						num = (short)2070116595;
						short num4 = num;
						num = (short)149059827;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_38;
						default:
							num = (short)802881536;
							if (num != 0)
							{
							}
							num = (short)1670971394;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_71:
						goto IL_96;
					}
				}
				IL_135:;
			}
			finally
			{
				num = (short)134545409;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1759313922;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)538247169;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_191;
						}
						continue;
					case 2:
						goto IL_1C5;
					}
					IL_191:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1804533760;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1C5:;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
		public global::AcpCommonLib.IAcpRecordset GetFeature(int id)
		{
			short num;
			if (!this.a.ContainsKey(id))
			{
				num = (short)1218914352;
				short num2 = num;
				num = (short)982132784;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)818544640;
					if (num != 0)
					{
					}
					return null;
				}
			}
			num = (short)1771241473;
			if (num != 0)
			{
			}
			num = (short)1871577088;
			short num3 = num;
			return this.a[id];
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000BFB0 File Offset: 0x0000A1B0
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> Search(string token)
		{
			short num = (short)1088226974;
			short num2 = num;
			num = (short)359794334;
			switch (num2 == num)
			{
			}
			num = (short)1237385217;
			if (num != 0)
			{
			}
			num = (short)1404502016;
			if (num != 0)
			{
			}
			num = (short)1144127488;
			short num3 = num;
			global::AcpCommonLib.Document.a a = new global::AcpCommonLib.Document.a(-2);
			a.d = this;
			a.f = token;
			return a;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000C070 File Offset: 0x0000A270
		public global::AcpCommonLib.IAcpField FieldFromPath(string path, string delimiter)
		{
			short num = (short)1704772647;
			short num2 = num;
			num = (short)1878443047;
			switch (num2 == num)
			{
			}
			num = (short)1192624129;
			if (num != 0)
			{
			}
			num = (short)77987840;
			if (num != 0)
			{
			}
			num = (short)303759360;
			short num3 = num;
			return this.a(path, true, delimiter);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000C124 File Offset: 0x0000A324
		public global::AcpCommonLib.IAcpField FieldFromFavoritePath(string path, string delimiter)
		{
			short num = (short)1201199615;
			short num2 = num;
			num = (short)993909247;
			switch (num2 == num)
			{
			}
			num = (short)1468465153;
			if (num != 0)
			{
			}
			num = (short)1892417536;
			if (num != 0)
			{
			}
			num = (short)2116550656;
			short num3 = num;
			return this.a(path, false, delimiter);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		public void SetModificationLogPath(string path, bool append)
		{
			short num = (short)1409653311;
			short num2 = num;
			num = (short)1232378431;
			switch (num2 == num)
			{
			}
			num = (short)1345650689;
			if (num != 0)
			{
			}
			num = (short)1828323328;
			if (num != 0)
			{
			}
			num = (short)1367670784;
			short num3 = num;
			global::System.IO.Path.GetDirectoryName(path);
			this.d = path;
			this.e = append;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000C290 File Offset: 0x0000A490
		public void WriteModificationLog()
		{
			int a_ = 4;
			short num = (short)2128412672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				global::System.IO.StreamWriter streamWriter;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_3E2;
					case 1:
						goto IL_376;
					case 2:
						if (this.g.Count > 0)
						{
							num = (short)1276968964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (this.ModificationLogEnabled)
						{
							num = (short)724434945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.g.Clear();
						num = (short)1533149184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							num = (short)1089994752;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text;
								global::System.Collections.Generic.List<string>.Enumerator enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_F2;
									}
									continue;
								case 1:
									goto IL_2A3;
								case 2:
									text = this.docFileName;
									goto IL_1FF;
								case 3:
									try
									{
										num = (short)572588035;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_1EC;
											case 1:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)1265303554;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												string value = enumerator.Current;
												streamWriter.WriteLine(value);
												num = (short)568000516;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												num = (short)1496580096;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_175;
												}
												continue;
											}
											IL_177:
											num = (short)1739849729;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_175:
											goto IL_177;
										}
										IL_1EC:
										goto IL_28A;
									}
									finally
									{
										((global::System.IDisposable)enumerator).Dispose();
									}
									goto IL_1FF;
									IL_28A:
									num = (short)1341980673;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)2087911426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									text = global::AcpCommonLib.Exceptions.AcpSecurityException.b("鯵韷黹闻飽槿愁攃爅愇攉戋戍缏甑", a_);
									goto IL_1FF;
								}
								IL_F2:
								if (!string.IsNullOrEmpty(this.docFileName))
								{
									num = (short)956497924;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)520224773;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FF:
								string str = text;
								streamWriter = new global::System.IO.StreamWriter(this.d + str + global::AcpCommonLib.Exceptions.AcpSecurityException.b("\ud8f5铷闹鯻", a_), this.e, global::System.Text.Encoding.Unicode);
								streamWriter.AutoFlush = true;
								enumerator = this.g.GetEnumerator();
								num = (short)1012531203;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2A3:
							return;
						}
						catch (global::System.IO.IOException)
						{
							return;
						}
						catch
						{
							return;
						}
						finally
						{
							num = (short)869177571;
							short num3 = num;
							num = (short)1327012067;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_332:
								if (streamWriter == null)
								{
									goto IL_36A;
								}
								num = (short)1009188864;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)595984384;
								if (num != 0)
								{
								}
								num = (short)1847787521;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									streamWriter.Close();
									num = (short)328335362;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_332;
									}
									continue;
								case 2:
									goto IL_368;
								}
								goto IL_332;
							}
							IL_368:
							IL_36A:
							this.g.Clear();
						}
						goto IL_376;
					}
					goto IL_4C;
					IL_376:
					num = (short)1579810818;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3E2:
				num = (short)1158348801;
				if (num != 0)
				{
				}
				return;
				IL_4C:
				streamWriter = null;
				num = (short)173670400;
				short num4 = num;
				num = (short)1659371523;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000C70C File Offset: 0x0000A90C
		public void AddToModificationLog(string line)
		{
			short num;
			if (!string.IsNullOrEmpty(line))
			{
				num = (short)239927179;
				short num2 = num;
				num = (short)96534411;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1787625473;
					if (num != 0)
					{
					}
					num = (short)1711865856;
					if (num != 0)
					{
					}
					this.g.Add(line);
					return;
				}
			}
			num = (short)921763840;
			short num3 = num;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000C7D0 File Offset: 0x0000A9D0
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpRecordset> Features
		{
			get
			{
				short num = (short)521076737;
				if (num != 0)
				{
				}
				num = (short)1279579662;
				short num2 = num;
				num = (short)634836494;
				switch (num2 == num)
				{
				}
				num = (short)917176320;
				if (num != 0)
				{
				}
				num = (short)465305600;
				short num3 = num;
				global::AcpCommonLib.Document.b b = new global::AcpCommonLib.Document.b(-2);
				b.d = this;
				return b;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000C888 File Offset: 0x0000AA88
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000C93C File Offset: 0x0000AB3C
		public bool ModificationLogEnabled
		{
			get
			{
				short num = (short)1345934719;
				short num2 = num;
				num = (short)1339053439;
				switch (num2 == num)
				{
				}
				num = (short)1672740865;
				if (num != 0)
				{
				}
				num = (short)1521156096;
				if (num != 0)
				{
				}
				num = (short)587464704;
				short num3 = num;
				return this.f;
			}
			set
			{
				short num = (short)1697400153;
				short num2 = num;
				num = (short)669795673;
				switch (num2 == num)
				{
				}
				num = (short)1932328961;
				if (num != 0)
				{
				}
				num = (short)372047872;
				if (num != 0)
				{
				}
				num = (short)227147776;
				short num3 = num;
				this.f = false;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000C9EC File Offset: 0x0000ABEC
		public bool IsMainDocument
		{
			get
			{
				short num = (short)1014637639;
				short num2 = num;
				num = (short)1993417799;
				switch (num2 == num)
				{
				}
				num = (short)338624512;
				if (num != 0)
				{
				}
				num = (short)1891893249;
				if (num != 0)
				{
				}
				num = (short)1733492736;
				short num3 = num;
				return !this.Background;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000CB50 File Offset: 0x0000AD50
		public bool IsDirty
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1447856198;
				short num2 = num;
				num = (short)2080606278;
				switch (num2 == num)
				{
				}
				num = (short)2104885248;
				if (num != 0)
				{
				}
				num = (short)1747189761;
				if (num != 0)
				{
				}
				num = (short)158990336;
				short num3 = num;
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected internal set
			{
				short num = (short)1232992379;
				short num2 = num;
				num = (short)855898235;
				switch (num2 == num)
				{
				}
				num = (short)550305792;
				if (num != 0)
				{
				}
				num = (short)915668993;
				if (num != 0)
				{
				}
				num = (short)1213202432;
				short num3 = num;
				this.i = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000CC00 File Offset: 0x0000AE00
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000CCAC File Offset: 0x0000AEAC
		public bool IsOpen
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)31719425;
				if (num != 0)
				{
				}
				num = (short)781723236;
				short num2 = num;
				num = (short)1006184036;
				switch (num2 == num)
				{
				}
				num = (short)1891237888;
				if (num != 0)
				{
				}
				num = (short)999489536;
				short num3 = num;
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected internal set
			{
				short num = (short)560310626;
				short num2 = num;
				num = (short)753903970;
				switch (num2 == num)
				{
				}
				num = (short)248905729;
				if (num != 0)
				{
				}
				num = (short)1788870656;
				if (num != 0)
				{
				}
				num = (short)186056704;
				short num3 = num;
				this.j = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000CD5C File Offset: 0x0000AF5C
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000CE0C File Offset: 0x0000B00C
		private protected bool Background
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected get
			{
				short num = (short)1147420944;
				short num2 = num;
				num = (short)417808656;
				switch (num2 == num)
				{
				}
				num = (short)1671561216;
				if (num != 0)
				{
				}
				num = (short)1395064833;
				if (num != 0)
				{
				}
				num = (short)363134976;
				short num3 = num;
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)987286707;
				short num2 = num;
				num = (short)610913459;
				switch (num2 == num)
				{
				}
				num = (short)44105728;
				if (num != 0)
				{
				}
				num = (short)1772027905;
				if (num != 0)
				{
				}
				num = (short)1439236096;
				short num3 = num;
				this.k = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000CF70 File Offset: 0x0000B170
		public global::AcpCommonLib.DocumentType DocType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)917705880;
				short num2 = num;
				num = (short)24450200;
				switch (num2 == num)
				{
				}
				num = (short)1951203329;
				if (num != 0)
				{
				}
				num = (short)112459776;
				if (num != 0)
				{
				}
				num = (short)1669464064;
				short num3 = num;
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)229836078;
				short num2 = num;
				num = (short)466355502;
				switch (num2 == num)
				{
				}
				num = (short)1068892161;
				if (num != 0)
				{
				}
				num = (short)709099520;
				if (num != 0)
				{
				}
				num = (short)1195966464;
				short num3 = num;
				this.l = value;
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000D020 File Offset: 0x0000B220
		public void Init()
		{
			short num;
			using (global::System.Collections.Generic.SortedDictionary<int, global::AcpCommonLib.IAcpRecordset>.ValueCollection.Enumerator enumerator = this.b.Values.GetEnumerator())
			{
				num = (short)376897539;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_215;
					case 1:
					{
						global::System.Collections.Generic.SortedDictionary<int, global::AcpCommonLib.IAcpRecordset>.ValueCollection.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)760086530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.Initialize();
						num = (short)1188298756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1012858880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_1A3;
						}
						continue;
					}
					IL_1A5:
					num = (short)160694273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A3:
					goto IL_1A5;
				}
				IL_215:
				goto IL_12F;
			}
			goto IL_228;
			for (;;)
			{
				IL_12F:
				num = (short)230096897;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.SortedDictionary<int, global::AcpCommonLib.IAcpRecordset>.ValueCollection.Enumerator enumerator = this.b.Values.GetEnumerator();
				goto IL_16;
				try
				{
					for (;;)
					{
						IL_16:
						num = (short)1993932803;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_11C;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1360855042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
								acpRecordset.RepairRecRefs();
								acpRecordset.ContainerDoc = this;
								num = (short)1734934532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								num = (short)2022527030;
								short num3 = num;
								num = (short)1170690102;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_16;
								default:
									num = (short)519634944;
									if (num != 0)
									{
									}
									num = (short)1082064896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_4F;
								}
								continue;
							}
							IL_51:
							num = (short)742195201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_4F:
							goto IL_51;
						}
					}
					IL_11C:
					break;
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
			}
			IL_228:
			num = (short)355401728;
			short num4 = num;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000D2B4 File Offset: 0x0000B4B4
		// Note: this type is marked as 'beforefieldinit'.
		static Document()
		{
			int a_ = 7;
			short num = (short)1221271300;
			short num2 = num;
			num = (short)850272004;
			switch (num2 == num)
			{
			}
			num = (short)442499073;
			if (num != 0)
			{
			}
			num = (short)1217265664;
			if (num != 0)
			{
			}
			num = (short)668532736;
			short num3 = num;
			global::AcpCommonLib.Document.CodePlugVersionNumber = string.Empty;
			global::AcpCommonLib.Document.h = null;
			global::AcpCommonLib.Document.SearchMode = global::AcpCommonLib.SearchMode.UINamesAndUIValues;
			global::AcpCommonLib.Document.SuppressExceptions = new global::System.Diagnostics.BooleanSwitch(global::AcpCommonLib.Exceptions.AcpSecurityException.b("꫸軺跼迾猀昂瘄理䨈搊挌簎攐愒琔縖眘漚堜洞匠䰢圤否", a_), global::AcpCommonLib.Exceptions.AcpSecurityException.b("꫸軺跼迾猀昂瘄理氈砊ⴌ氎挐爒昔编簘栚㴜簞䀠嘢嘤䈦䴨ପ伬嘮ᄰ倲娴夶䨸伺似帾⡀ⵂㅄ㑆", a_));
		}

		// Token: 0x04000064 RID: 100
		private global::System.Collections.Generic.Dictionary<int, global::AcpCommonLib.IAcpRecordset> a;

		// Token: 0x04000065 RID: 101
		private global::System.Collections.Generic.SortedDictionary<int, global::AcpCommonLib.IAcpRecordset> b;

		// Token: 0x04000066 RID: 102
		private global::System.Xml.XmlDocument c;

		// Token: 0x04000067 RID: 103
		private string d;

		// Token: 0x04000068 RID: 104
		private bool e;

		// Token: 0x04000069 RID: 105
		public string docFileName;

		// Token: 0x0400006A RID: 106
		public string docFilePath;

		// Token: 0x0400006B RID: 107
		private bool f;

		// Token: 0x0400006C RID: 108
		private global::System.Collections.Generic.List<string> g = new global::System.Collections.Generic.List<string>();

		// Token: 0x0400006D RID: 109
		public static string CodePlugVersionNumber;

		// Token: 0x0400006E RID: 110
		private static string h;

		// Token: 0x0400006F RID: 111
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool i;

		// Token: 0x04000070 RID: 112
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool j;

		// Token: 0x04000071 RID: 113
		public static global::AcpCommonLib.SearchMode SearchMode;

		// Token: 0x04000072 RID: 114
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;

		// Token: 0x04000073 RID: 115
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.DocumentType l;

		// Token: 0x04000074 RID: 116
		public static global::System.Diagnostics.BooleanSwitch SuppressExceptions;
	}
}
