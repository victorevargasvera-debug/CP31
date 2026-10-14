using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using AcpBusinessLayer;
using AcpCommonLib;
using Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.RadioProfiles;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Ucl.Contact;
using SpecialFeatures.VoiceAnnouncements.List;

namespace SpecialFeatures.Clone_Configuration.Common
{
	// Token: 0x02000184 RID: 388
	public static class AstroRecSetCounts
	{
		// Token: 0x060012F2 RID: 4850 RVA: 0x001B5A60 File Offset: 0x001B3C60
		public static global::System.Xml.XmlDocument GetXmlDocument(string xmlData)
		{
			global::System.Xml.XmlDocument xmlDocument = null;
			goto IL_04;
			short num;
			try
			{
				for (;;)
				{
					IL_04:
					global::System.IO.StringReader stringReader = new global::System.IO.StringReader(xmlData);
					try
					{
						global::System.Xml.XmlTextReader reader = new global::System.Xml.XmlTextReader(stringReader);
						xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(reader);
					}
					finally
					{
						num = (short)385286146;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)stringReader).Dispose();
								num = (short)423231489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_87;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_54;
								}
								continue;
							}
							IL_54:
							if (stringReader == null)
							{
								break;
							}
							num = (short)1475543040;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_87:;
					}
					num = (short)775650703;
					short num3 = num;
					num = (short)806124943;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_C0;
					}
				}
				IL_C0:
				num = (short)1332609024;
				if (num != 0)
				{
				}
			}
			catch
			{
				xmlDocument = null;
			}
			num = (short)1908736000;
			short num4 = num;
			num = (short)1953300481;
			if (num != 0)
			{
			}
			return xmlDocument;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x001B5BBC File Offset: 0x001B3DBC
		public static global::System.Collections.Generic.List<global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem> LoadRecSetItemsFromXml(string xmlData)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::System.Collections.Generic.List<global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem> result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::System.Xml.XmlDocument xmlDocument;
					if (xmlDocument != null)
					{
						num2 = (short)1831731202;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 1:
					return result;
				case 2:
				{
					num2 = (short)1202323457;
					if (num2 != 0)
					{
					}
					global::System.Xml.XmlDocument xmlDocument;
					result = global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCounts.LoadRecSetItemsFromXml(xmlDocument);
					num2 = (short)1792606209;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					global::System.Xml.XmlDocument xmlDocument = global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCounts.GetXmlDocument(xmlData);
					num2 = (short)1575747584;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (!string.IsNullOrEmpty(xmlData))
					{
						num2 = (short)202113027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1203016869;
			short num3 = num2;
			num2 = (short)502240421;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num2 = (short)728367104;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)392888320;
			if (num2 != 0)
			{
			}
			num2 = (short)355139588;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x001B5D28 File Offset: 0x001B3F28
		public static global::System.Collections.Generic.List<global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem> LoadRecSetItemsFromXml(global::System.Xml.XmlDocument doc)
		{
			int a_ = 18;
			short num = (short)1660747777;
			if (num != 0)
			{
			}
			num = (short)401997824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)443219968;
				short num3 = num;
				int count = 0;
				int maxpool = 0;
				int countToMaxPool = 0;
				int instance = 0;
				global::System.Collections.Generic.List<global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem> list = null;
				try
				{
					num = (short)2034761731;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)679870468;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.IEnumerator enumerator;
									string recsetName;
									global::System.Collections.IEnumerator enumerator2;
									switch (num2)
									{
									case 0:
										try
										{
											num = (short)1012137986;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 1:
													goto IL_350;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_1E2;
													}
													continue;
												case 3:
													goto IL_350;
												case 4:
													num = (short)95223815;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 5:
												{
													global::System.Xml.XmlAttribute xmlAttribute;
													if (xmlAttribute != null)
													{
														num = (short)1804009480;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													countToMaxPool = 0;
													num = (short)1383989249;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 6:
													if (!enumerator.MoveNext())
													{
														num = (short)230162436;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)2124480521;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 7:
													goto IL_3D8;
												case 8:
												{
													global::System.Xml.XmlAttribute xmlAttribute;
													countToMaxPool = int.Parse(xmlAttribute.Value, global::System.Globalization.CultureInfo.InvariantCulture);
													num = (short)193200131;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 9:
												{
													global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
													global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc94", a_)];
													if (xmlAttribute != null)
													{
														instance = int.Parse(xmlAttribute.Value, global::System.Globalization.CultureInfo.InvariantCulture);
													}
													else
													{
														instance = 0;
													}
													xmlAttribute = xmlNode.Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횔", a_)];
													if (xmlAttribute != null)
													{
														count = int.Parse(xmlAttribute.Value, global::System.Globalization.CultureInfo.InvariantCulture);
													}
													else
													{
														count = 0;
													}
													xmlAttribute = xmlNode.Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud894쮚춠", a_)];
													if (xmlAttribute != null)
													{
														maxpool = int.Parse(xmlAttribute.Value, global::System.Globalization.CultureInfo.InvariantCulture);
													}
													else
													{
														maxpool = 0;
													}
													xmlAttribute = xmlNode.Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횔爵펠쪤좨펪ﶬ삮\udeb0\udfb2", a_)];
													num = (short)395444229;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												goto IL_1E2;
												IL_350:
												global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem item = new global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem(recsetName, instance, count, maxpool, countToMaxPool);
												list.Add(item);
												num = (short)530186240;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_382:
												num = (short)400883718;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_1E2:
												goto IL_382;
											}
											IL_3D8:
											break;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_3FA;
											}
											global::System.IDisposable disposable;
											for (;;)
											{
												IL_3E7:
												switch (num2)
												{
												case 0:
												{
													num = (short)625177828;
													short num4 = num;
													num = (short)1538684132;
													switch ((num4 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														break;
													default:
														num = (short)407568384;
														if (num != 0)
														{
														}
														break;
													}
													disposable.Dispose();
													num = (short)957480961;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 1:
													goto IL_49F;
												case 2:
													if (disposable != null)
													{
														num = (short)1223491584;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_4A1;
												}
												goto IL_3FA;
											}
											IL_49F:
											IL_4A1:
											goto EndFinally_16;
											IL_3FA:
											disposable = (enumerator as global::System.IDisposable);
											num = (short)80674818;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_3E7;
											EndFinally_16:;
										}
										goto IL_4A2;
									case 1:
										num = (short)1399586818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_515;
									case 3:
										if (!enumerator2.MoveNext())
										{
											num = (short)2073952257;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_4A2;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_153;
										}
										continue;
									}
									IL_158:
									num = (short)771751939;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_153:
									goto IL_158;
									IL_4A2:
									global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator2.Current;
									recsetName = xmlNode2.Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮔﺚ", a_)].Value.Trim();
									enumerator = xmlNode2.ChildNodes.GetEnumerator();
									num = (short)838860800;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_515:;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_534;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_521:
									switch (num2)
									{
									case 0:
										disposable.Dispose();
										num = (short)82247681;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_589;
									case 2:
										if (disposable != null)
										{
											num = (short)1806368768;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_58B;
									}
									goto IL_534;
								}
								IL_589:
								IL_58B:
								goto EndFinally_17;
								IL_534:
								global::System.Collections.IEnumerator enumerator2;
								disposable = (enumerator2 as global::System.IDisposable);
								num = (short)67371010;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_521;
								EndFinally_17:;
							}
							goto IL_58C;
						case 1:
							goto IL_5A5;
						case 2:
						{
							list = new global::System.Collections.Generic.List<global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem>();
							global::System.Collections.IEnumerator enumerator2 = doc.ChildNodes[1].LastChild.ChildNodes.GetEnumerator();
							num = (short)925564928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_BD;
							}
							continue;
						}
						IL_BD:
						if (doc != null)
						{
							num = (short)800718850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_58C:
						num = (short)1668349953;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5A5:;
				}
				catch (global::System.Exception)
				{
					list.Clear();
					list = null;
				}
				return list;
			}
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x001B6338 File Offset: 0x001B4538
		public static global::System.Xml.XmlDocument LoadRecSetItemsToXmlDoc(global::System.Collections.Generic.List<global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem> recSetItems)
		{
			int a_ = 11;
			short num = (short)1474756608;
			switch (num)
			{
			default:
			{
				global::System.Xml.XmlDocument xmlDocument = null;
				try
				{
					num = (short)52428802;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						int num3;
						global::System.Xml.XmlElement xmlElement3;
						global::System.Collections.Generic.List<global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem>.Enumerator enumerator;
						int num4;
						global::System.Xml.XmlElement xmlElement5;
						global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem item;
						switch (num2)
						{
						case 0:
							if (num3 >= recSetItems.Count)
							{
								num = (short)1795293190;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_514;
						case 1:
						{
							xmlDocument = new global::System.Xml.XmlDocument();
							xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾍뺏ꊑ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8d쒏풑릓꺕", a_), null));
							global::System.Xml.XmlElement xmlElement = xmlDocument.CreateElement(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾍秊쪗ﾙﾛ얟횡즥\udda7쒩\ud8ab\uddad", a_));
							xmlDocument.AppendChild(xmlElement);
							global::System.Xml.XmlElement xmlElement2 = xmlDocument.CreateElement(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88dﾕ", a_));
							xmlElement2.InnerText = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾍", a_);
							xmlElement.AppendChild(xmlElement2);
							xmlElement3 = xmlDocument.CreateElement(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8dﾏ﶑", a_));
							xmlElement.AppendChild(xmlElement3);
							num3 = 0;
							num = (short)1747124229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_78;
							}
							continue;
						case 3:
							if (recSetItems.Count > 0)
							{
								num = (short)1562968065;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5AA;
						case 4:
							try
							{
								num = (short)66977798;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem astroRecSetCountsItem;
										if (astroRecSetCountsItem._counterToMaxPool != 0)
										{
											num = (short)1732706314;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_26B;
									}
									case 1:
										goto IL_501;
									case 2:
										goto IL_321;
									case 3:
										goto IL_26B;
									case 4:
										goto IL_466;
									case 5:
									{
										global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem astroRecSetCountsItem;
										if (astroRecSetCountsItem._count != 0)
										{
											num = (short)508100615;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_321;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_266;
										}
										continue;
									case 7:
									{
										IL_3E0:
										global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem astroRecSetCountsItem;
										global::System.Xml.XmlElement xmlElement4;
										xmlElement4.SetAttribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춍ﾏ望", a_), astroRecSetCountsItem._count.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
										num = (short)1661140994;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem astroRecSetCountsItem;
										global::System.Xml.XmlElement xmlElement4;
										xmlElement4.SetAttribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎍쒓秊", a_), astroRecSetCountsItem._maxPool.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
										num = (short)1523384324;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										num = (short)766377985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
									{
										global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem astroRecSetCountsItem;
										global::System.Xml.XmlElement xmlElement4;
										xmlElement4.SetAttribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춍ﾏ望ﶗ좛쎡\udca3잧얩삫", a_), astroRecSetCountsItem._counterToMaxPool.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
										num = (short)2089222147;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1367539721;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem astroRecSetCountsItem = enumerator.Current;
										global::System.Xml.XmlElement xmlElement4 = xmlDocument.CreateElement(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삍ﾏ", a_));
										xmlElement4.SetAttribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잍", a_), num4.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
										num = (short)638582789;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
									{
										global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem astroRecSetCountsItem;
										if (astroRecSetCountsItem._maxPool != 0)
										{
											num = (short)920584200;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_466;
									}
									}
									goto IL_266;
									IL_26B:
									num = (short)671032626;
									short num5 = num;
									num = (short)1566516530;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3E0;
									default:
									{
										num = (short)1743585280;
										if (num != 0)
										{
										}
										global::System.Xml.XmlElement xmlElement4;
										xmlElement5.AppendChild(xmlElement4);
										num4++;
										num = (short)1770127373;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_2E0:
									num = (short)772538379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_266:
									goto IL_2E0;
									IL_321:
									num = (short)1592393740;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_466:
									num = (short)1355939840;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_501:
								goto IL_154;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_514;
							IL_154:
							recSetItems.RemoveAll(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
							{
								short num7 = (short)1778320022;
								short num8 = num7;
								num7 = (short)1616642710;
								switch (num8 == num7)
								{
								}
								num7 = (short)2126643201;
								if (num7 != 0)
								{
								}
								num7 = (short)2101477376;
								short num9 = num7;
								num7 = (short)113836032;
								if (num7 != 0)
								{
								}
								return x._recSetName == item._recSetName;
							});
							num = (short)817168392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_1C5;
						case 6:
							goto IL_5AA;
						case 7:
							goto IL_5C3;
						case 8:
							goto IL_1C5;
						case 9:
							num = (short)866975747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_78:
						if (recSetItems != null)
						{
							num = (short)729350153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AA;
						IL_1C5:
						num = (short)896139264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_514:
						item = recSetItems[num3];
						xmlElement5 = xmlDocument.CreateElement(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8d", a_));
						xmlElement5.SetAttribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾑ", a_), item._recSetName.Trim());
						xmlElement3.AppendChild(xmlElement5);
						global::System.Collections.Generic.List<global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem> list = recSetItems.FindAll(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
						{
							short num7 = (short)1967982193;
							short num8 = num7;
							num7 = (short)1618151025;
							switch (num8 == num7)
							{
							}
							num7 = (short)1291452417;
							if (num7 != 0)
							{
							}
							num7 = (short)1329987584;
							short num9 = num7;
							num7 = (short)1067188224;
							if (num7 != 0)
							{
							}
							return x._recSetName == item._recSetName;
						});
						num4 = 0;
						enumerator = list.GetEnumerator();
						num = (short)455016452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5AA:
						num = (short)1613234183;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5C3:;
				}
				catch (global::System.Exception)
				{
					xmlDocument = null;
				}
				num = (short)1932984321;
				if (num != 0)
				{
				}
				num = (short)1370554368;
				short num6 = num;
				return xmlDocument;
			}
			}
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x001B6998 File Offset: 0x001B4B98
		public static string PopulateAstroRecSetCounts()
		{
			int a_ = 5;
			short num = (short)1686896640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C7;
				}
				global::System.Collections.Generic.List<global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem> list;
				string result;
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
				for (;;)
				{
					IL_30:
					global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
					global::System.Xml.XmlDocument xmlDocument;
					global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset;
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset;
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset;
					switch (num2)
					{
					case 0:
						list.Add(new global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즇\ud989\ud88b\udc8d\udf8f욑歹ﶙ햟튡쾥\udba7\udea9ﺫ쮭펯솱톳습", a_), 0, astrotalkgroupListRecset.Count, 0, 0));
						num = (short)1153171476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_534;
					case 2:
						goto IL_5BD;
					case 3:
						list.Add(new global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮇ﲑﾕﶛ\udba1힣튥춧잩ﺫ쮭펯솱톳습", a_), 0, conventionalSystemRecset.Count, 0, 0));
						num = (short)1253244930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (xmlDocument != null)
						{
							num = (short)1407254550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
						if (conventionalSystemRecset != null)
						{
							num = (short)882835459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5BD;
					case 6:
						goto IL_7A8;
					case 7:
						return result;
					case 8:
						goto IL_2F3;
					case 9:
						num = (short)1583022081;
						if (num != 0)
						{
						}
						goto IL_64A;
					case 10:
						list.Add(new global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87춍ﾏﲑﮗ캛ﮝ쎟톡솣튥", a_), 0, uclContactRecset.Count, 0, 0));
						num = (short)545587201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (voiceAnnouncementListRecSet != null)
						{
							num = (short)899285015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F3;
					case 12:
						try
						{
							num = (short)455278595;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)764411905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_234;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_17E;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)854392832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset secureHardwareEncryptionKeyReferencesListInnerRecset = ((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current).SecureHardwareEncryptionKeyReferencesList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset;
									int num3;
									list.Add(new global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb87ﮍ\udc93ﺙﾝ튟잡좥쮧\ud8a9햫\udead쒯\udbb1\udbb3\ud8b5\udfb9얻ꖿ꓁ꇃ듅귇꓉꿋ꯍꏏ黑뷓ꗕ곗鏙닛냝藟郡뛣菥诧駩觫髭", a_), num3++, secureHardwareEncryptionKeyReferencesListInnerRecset.Count, 0, 0));
									num = (short)794296322;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1DD:
								num = (short)1209008132;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_17E:
								goto IL_1DD;
							}
							IL_234:
							goto IL_8DC;
						}
						finally
						{
							num = (short)438566913;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_2F0;
								case 1:
								{
									num = (short)258619131;
									short num4 = num;
									num = (short)1980970747;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2DA;
									default:
										num = (short)676265984;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_2B7;
										}
										continue;
									}
									break;
								}
								case 2:
									enumerator.Dispose();
									goto IL_2DA;
								}
								IL_2B7:
								if (enumerator != null)
								{
									num = (short)1165754370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
								IL_2DA:
								num = (short)1479016448;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F0:;
						}
						goto IL_2F3;
					case 13:
						goto IL_46D;
					case 14:
						list.Add(new global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮇ﺏ힕劣캟쾡솣좥\udca7얫\uddad쒯ﮱ\udab3\ud8b5\uddb7좹\udbbdꎿ뇁ꇃ닅", a_), 0, 0, channelAssignmentListInnerRecset.MaxPool, channelAssignmentListInnerRecset.CounterToMaxPool));
						num = (short)264241165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_697;
					case 16:
						if (radioProfilesRecset != null)
						{
							num = (short)220004352;
							short num5 = num;
							num = (short)934674466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_890;
					case 17:
						list.Add(new global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc87曆ﮏﮑ望쮗얟쾡쎥쮧\ud9a9즫\udaad", a_), 0, trunkingSystemRecset.Count, 0, 0));
						num = (short)2013528073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (secureKMFProfileRecset != null)
						{
							num = (short)632225819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8DC;
					case 19:
						list.Add(new global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튇펏晴ﾙ\udf9d펟톡춣솥욧잩즫삭쒯톳햵쮷\udfb9좻", a_), 0, zoneChannelAssignmentRecset.Count, 0, 0));
						num = (short)70057999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_842;
					case 21:
						if (zoneChannelAssignmentRecset != null)
						{
							num = (short)1104740371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_697;
					case 22:
						result = xmlDocument.InnerXml;
						num = (short)1921187847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						list.Add(new global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude87펑望ﶝ얟쾡솣좥\udca7얫\uddad쒯톳햵\udfb9좻", a_), 0, voiceAnnouncementListRecSet.Count, 0, 0));
						num = (short)2049114120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (uclContactRecset != null)
						{
							num = (short)743243786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					case 25:
						if (trunkingPersonalityRecset != null)
						{
							num = (short)1344536602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A8;
					case 26:
						list.Add(new global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc87曆ﮏﮑ望좗ﾙ쾟첡얣쪥솧\udea9햫ﲭ햯톱잳펵첷", a_), 0, trunkingPersonalityRecset.Count, 0, 0));
						num = (short)975634438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						int num3 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)668860428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						if (encryptionKeyListInnerRecset != null)
						{
							num = (short)852688925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F5;
					case 29:
						list.Add(new global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춇ﲍﾕ힛ﮝ\ud99f춣향\udca7슫삭햯삱펵\udbb7즹\ud9bb쪽", a_), 0, encryptionKeyListInnerRecset.Count, 0, 0));
						num = (short)544538655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (astrotalkgroupListRecset != null)
						{
							num = (short)1084620800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_842;
					case 31:
						goto IL_7F5;
					case 32:
						if (trunkingSystemRecset != null)
						{
							num = (short)1154613265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64A;
					case 33:
						if (channelAssignmentListInnerRecset != null)
						{
							num = (short)1796472846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46D;
					case 34:
						list.Add(new global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda87ﾏ슑秊ﺗﮝ펟솣얥\udba7쾩\ud8ab", a_), 0, radioProfilesRecset.Count, 0, 0));
						num = (short)1341128739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_890;
					}
					goto IL_C7;
					IL_2F3:
					encryptionKeyListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2021) as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset)[0][10040].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset);
					num = (short)1375797276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46D:
					xmlDocument = global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCounts.LoadRecSetItemsToXmlDoc(list);
					num = (short)1641021444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_534:
					channelAssignmentListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051)[0][10114].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset);
					num = (short)670040097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5BD:
					trunkingPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset);
					num = (short)1437663257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64A:
					astrotalkgroupListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2062) as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset);
					num = (short)384958494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_697:
					trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
					num = (short)389414944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A8:
					voiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2300) as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet);
					num = (short)326041611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F5:
					secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
					num = (short)1780285458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_842:
					conventionalSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset);
					num = (short)1042153477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_890:
					zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
					num = (short)1257504789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8DC:
					uclContactRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2200) as global::SpecialFeatures.Ucl.Contact.UclContactRecset);
					num = (short)1176829976;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_C7:
				result = null;
				list = new global::System.Collections.Generic.List<global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem>();
				radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
				num = (short)1640497168;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
