using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using AcpCryptoLib;
using ConstraintHelper;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.FCCExceptionHandler
{
	// Token: 0x0200011A RID: 282
	public class FCCExceptionHandler
	{
		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00151640 File Offset: 0x0014F840
		public static global::SpecialFeatures.FCCExceptionHandler.FCCExceptionHandler Instance
		{
			get
			{
				short num = (short)843839893;
				short num2 = num;
				num = (short)2146433429;
				switch (num2 == num)
				{
				}
				num = (short)2092171265;
				if (num != 0)
				{
				}
				num = (short)1057357824;
				if (num != 0)
				{
				}
				num = (short)176291840;
				short num3 = num;
				return global::SpecialFeatures.FCCExceptionHandler.FCCExceptionHandler.a;
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x001516F0 File Offset: 0x0014F8F0
		private FCCExceptionHandler()
		{
			int a_ = 9;
			this.b = "";
			base..ctor();
			this.b = global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶍ憐ﺗﾙ낝쎟튡힣", a_));
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0015173C File Offset: 0x0014F93C
		public void InitExceptionList()
		{
			short num = (short)1471741953;
			if (num != 0)
			{
			}
			num = (short)1602561804;
			short num2 = num;
			num = (short)650127116;
			switch (num2 == num)
			{
			}
			num = (short)1878130688;
			if (num != 0)
			{
			}
			num = (short)1746272256;
			short num3 = num;
			global::System.Xml.XmlDocument a_ = this.a();
			global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.BaseSection>> a_2 = this.a(a_);
			this.a(a_2);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x001517F8 File Offset: 0x0014F9F8
		private global::System.Xml.XmlDocument a()
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::System.Xml.XmlDocument result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_103;
				case 1:
				{
					num2 = (short)554172417;
					if (num2 != 0)
					{
					}
					if (!global::System.IO.File.Exists(this.b))
					{
						goto IL_105;
					}
					num2 = (short)298584848;
					short num3 = num2;
					num2 = (short)130091792;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_103;
					default:
					{
						num2 = (short)2060517376;
						short num4 = num2;
						num2 = (short)1919025152;
						if (num2 != 0)
						{
						}
						num2 = (short)16842752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					return result;
				}
				goto IL_25;
				IL_103:
				result = new global::AcpCryptoLib.AcpXMLEncryptDecrypt().DecryptXMLFile(this.b);
				num2 = (short)1611923458;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_105:
			throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊캌첎놐킒杖練ﾘ煮뾞쪢즤슦覨슪\udeac辮\udcb0\udab2운쒶킸햺\udabc醾", a_));
			IL_25:
			result = new global::System.Xml.XmlDocument();
			num2 = (short)1482555393;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0015194C File Offset: 0x0014FB4C
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.BaseSection>> a(global::System.Xml.XmlDocument A_0)
		{
			int a_ = 17;
			short num = (short)2111307776;
			short num2 = num;
			num = (short)1584398336;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)682557441;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				for (;;)
				{
					IL_80:
					switch (num3)
					{
					case 0:
					{
						global::System.Xml.XmlNodeList xmlNodeList = A_0.SelectNodes(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓秊뎛\ud89d얟쎡킣펥\udaa7쾩", a_));
						if (xmlNodeList == null)
						{
							goto Block_4;
						}
						global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
						num = (short)1431109634;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)827195404;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::SpecialFeatures.FCCExceptionHandler.BaseSection baseSection;
								switch (num3)
								{
								case 0:
									try
									{
										num = (short)837025800;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
											{
												global::System.Collections.IEnumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1034682372;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator2.Current;
												num = (short)1553334279;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
											{
												num = (short)1827305590;
												short num4 = num;
												num = (short)1717205110;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_5EC;
												default:
													goto IL_767;
												}
												break;
											}
											case 3:
											{
												string text;
												if (!string.IsNullOrEmpty(text))
												{
													num = (short)2084110342;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
												num = (short)543424513;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
											{
												global::System.Xml.XmlNode xmlNode;
												string text = xmlNode.InnerText.Trim();
												num = (short)1851129859;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
											{
												string text;
												(baseSection as global::SpecialFeatures.FCCExceptionHandler.PointSection).AddPoint(text);
												num = (short)1120272386;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
											{
												global::System.Xml.XmlNode xmlNode;
												if (xmlNode is global::System.Xml.XmlElement)
												{
													num = (short)45875205;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 8:
												goto IL_5EC;
											}
											goto IL_621;
											IL_5EC:
											switch (0)
											{
											case 0:
												IL_621:
												goto IL_668;
											}
											continue;
											IL_668:
											num = (short)440008704;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_767:
										num = (short)1331167232;
										if (num != 0)
										{
										}
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_79E;
										}
										global::System.IDisposable disposable;
										for (;;)
										{
											IL_78B:
											switch (num3)
											{
											case 0:
												disposable.Dispose();
												num = (short)726269953;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_7F5;
											case 2:
												if (disposable != null)
												{
													num = (short)948305920;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_7F7;
											}
											goto IL_79E;
										}
										IL_7F5:
										IL_7F7:
										goto EndFinally_36;
										IL_79E:
										global::System.Collections.IEnumerator enumerator2;
										disposable = (enumerator2 as global::System.IDisposable);
										num = (short)261685250;
										num3 = (int)((global::System.IntPtr)num);
										goto IL_78B;
										EndFinally_36:;
									}
									goto IL_7F8;
								case 1:
								{
									global::SpecialFeatures.FCCExceptionHandler.SectionType sectionType;
									if (sectionType == global::SpecialFeatures.FCCExceptionHandler.SectionType.Point)
									{
										num = (short)451018762;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)893190155;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)931201032;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator.Current;
									num = (short)683212806;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_BC1;
								case 5:
								{
									baseSection = new global::SpecialFeatures.FCCExceptionHandler.RangeSection();
									string value;
									baseSection.BandType = value;
									global::System.Xml.XmlNode xmlNode2;
									global::System.Collections.IEnumerator enumerator2 = xmlNode2.ChildNodes.GetEnumerator();
									num = (short)1229324295;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::System.Xml.XmlNode xmlNode2;
									if (xmlNode2 is global::System.Xml.XmlElement)
									{
										num = (short)919076873;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									try
									{
										num = (short)1604321290;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
											{
												global::System.Collections.IEnumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1939079174;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Xml.XmlNode xmlNode3 = (global::System.Xml.XmlNode)enumerator2.Current;
												num = (short)1844314119;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												goto IL_B2B;
											case 3:
												num = (short)912195593;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												global::SpecialFeatures.FCCExceptionHandler.FreqRange freqRange;
												(baseSection as global::SpecialFeatures.FCCExceptionHandler.RangeSection).AddRange(freqRange);
												num = (short)1176305665;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												global::SpecialFeatures.FCCExceptionHandler.FreqRange freqRange = new global::SpecialFeatures.FCCExceptionHandler.FreqRange();
												global::System.Xml.XmlNode xmlNode3;
												freqRange.RangeStart = xmlNode3.Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓ﶙ鍊춝풟쎡횣튥", a_)].Value;
												freqRange.RangeEnd = xmlNode3.Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓ﶙ鍊\udb9d캟욡", a_)].Value;
												num = (short)2046951432;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												num = (short)1292369922;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
											{
												global::System.Xml.XmlNode xmlNode3;
												if (xmlNode3 is global::System.Xml.XmlElement)
												{
													num = (short)884539397;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 8:
											{
												global::SpecialFeatures.FCCExceptionHandler.FreqRange freqRange;
												if (!string.IsNullOrEmpty(freqRange.RangeStart))
												{
													num = (short)1672478723;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 9:
											{
												global::SpecialFeatures.FCCExceptionHandler.FreqRange freqRange;
												if (!string.IsNullOrEmpty(freqRange.RangeEnd))
												{
													num = (short)998375428;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 10:
												switch (0)
												{
												case 0:
													goto IL_982;
												}
												continue;
											}
											IL_A0F:
											num = (short)2115239936;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_982:
											goto IL_A0F;
										}
										IL_B2B:
										goto IL_7F8;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_B4D;
										}
										global::System.IDisposable disposable;
										for (;;)
										{
											IL_B3A:
											switch (num3)
											{
											case 0:
												if (disposable != null)
												{
													num = (short)60358657;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_BA8;
											case 1:
												disposable.Dispose();
												num = (short)1653080066;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_BA6;
											}
											goto IL_B4D;
										}
										IL_BA6:
										IL_BA8:
										goto EndFinally_35;
										IL_B4D:
										global::System.Collections.IEnumerator enumerator2;
										disposable = (enumerator2 as global::System.IDisposable);
										num = (short)2125791232;
										num3 = (int)((global::System.IntPtr)num);
										goto IL_B3A;
										EndFinally_35:;
									}
									goto IL_BA9;
								case 8:
									goto IL_BA9;
								case 9:
								{
									global::System.Xml.XmlNode xmlNode2;
									string value = xmlNode2.Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횓ﺙ좛킟잡", a_)].Value;
									string value2 = xmlNode2.Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튓ﶗ좛킟잡", a_)].Value;
									global::SpecialFeatures.FCCExceptionHandler.SectionType sectionType = (global::SpecialFeatures.FCCExceptionHandler.SectionType)global::System.Enum.Parse(typeof(global::SpecialFeatures.FCCExceptionHandler.SectionType), value2, true);
									baseSection = new global::SpecialFeatures.FCCExceptionHandler.BaseSection();
									num = (short)270336001;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									baseSection = new global::SpecialFeatures.FCCExceptionHandler.PointSection();
									string value;
									baseSection.BandType = value;
									global::System.Xml.XmlNode xmlNode2;
									global::System.Collections.IEnumerator enumerator2 = xmlNode2.ChildNodes.GetEnumerator();
									num = (short)628293632;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::SpecialFeatures.FCCExceptionHandler.SectionType sectionType;
									if (sectionType == global::SpecialFeatures.FCCExceptionHandler.SectionType.Range)
									{
										num = (short)531365893;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7F8;
								}
								case 12:
									switch (0)
									{
									case 0:
										goto IL_517;
									}
									continue;
								}
								goto IL_517;
								IL_7F8:
								global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.BaseSection> list;
								list.Add(baseSection);
								num = (short)654639106;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_81A:
								num = (short)2033516547;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_517:
								goto IL_81A;
								IL_BA9:
								num = (short)313393156;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_BC1:;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_BE0;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_BCD:
								switch (num3)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1726611457;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C3A;
								case 1:
									disposable.Dispose();
									num = (short)30277634;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_C38;
								}
								goto IL_BE0;
							}
							IL_C38:
							IL_C3A:
							goto EndFinally_37;
							IL_BE0:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1201012736;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_BCD;
							EndFinally_37:;
						}
						num = (short)120520704;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_C8C;
					case 3:
					{
						global::System.Xml.XmlNodeList xmlNodeList2 = A_0.SelectNodes(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓秊뎛춝얟송킣쾥잧쒩", a_));
						if (xmlNodeList2 == null)
						{
							goto Block_1;
						}
						global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.BaseSection> list = new global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.BaseSection>();
						global::System.Collections.IEnumerator enumerator = xmlNodeList2.GetEnumerator();
						num = (short)1537146881;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_97;
				}
				Block_1:
				IL_481:
				throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda93秊뢗즙鍊ﶝ풟쮡쮣좥袧쎩슫躭\uddb1\udab3킵톷\uddb9鲻\ud8bdꦿ껁ꇃ", a_));
				Block_4:
				throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda93秊뢗\udc99鍊ﾝ풟힡횣쎥袧쎩슫躭\uddb1\udab3킵톷\uddb9鲻\ud8bdꦿ껁ꇃ", a_));
				IL_C8C:
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.BaseSection>> dictionary;
				try
				{
					num = (short)714276871;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator2;
						global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.BaseSection> list2;
						string value3;
						global::System.Xml.XmlNode xmlNode5;
						switch (num3)
						{
						case 0:
							num = (short)63569926;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							try
							{
								num = (short)2032205830;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num = (short)1729429509;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::System.Xml.XmlNode xmlNode4;
										string listIncludeType = xmlNode4.Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93ﮗ瞧얟\udda3횥춧", a_)].Value.Trim();
										global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.BaseSection> list;
										list2.Add(list.Find(delegate(global::SpecialFeatures.FCCExceptionHandler.BaseSection x)
										{
											short num5 = (short)161850962;
											short num6 = num5;
											num5 = (short)2147329618;
											switch (num6 == num5)
											{
											}
											num5 = (short)470876160;
											if (num5 != 0)
											{
											}
											num5 = (short)173080576;
											short num7 = num5;
											num5 = (short)238354433;
											if (num5 != 0)
											{
											}
											return x.BandType == listIncludeType;
										}));
										num = (short)1016463361;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										global::System.Xml.XmlNode xmlNode4;
										if (xmlNode4 is global::System.Xml.XmlElement)
										{
											num = (short)1160970242;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)1018101760;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode4 = (global::System.Xml.XmlNode)enumerator2.Current;
										num = (short)408485891;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_26F;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_163;
										}
										continue;
									}
									IL_218:
									num = (short)1317076996;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_163:
									goto IL_218;
								}
								IL_26F:
								goto IL_33F;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_291;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_27E:
									switch (num3)
									{
									case 0:
										disposable.Dispose();
										num = (short)1029963777;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_2E9;
									case 2:
										if (disposable != null)
										{
											num = (short)1303052288;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2EB;
									}
									goto IL_291;
								}
								IL_2E9:
								IL_2EB:
								goto EndFinally_33;
								IL_291:
								disposable = (enumerator2 as global::System.IDisposable);
								num = (short)1345912834;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_27E;
								EndFinally_33:;
							}
							goto IL_2EC;
							IL_33F:
							dictionary.Add(value3, list2);
							num = (short)763822084;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2EC;
						case 3:
							if (xmlNode5 is global::System.Xml.XmlElement)
							{
								num = (short)1125515266;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 5:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)277217280;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							xmlNode5 = (global::System.Xml.XmlNode)enumerator.Current;
							num = (short)68681731;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_408;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_11A;
							}
							continue;
						}
						goto IL_11A;
						IL_2EC:
						value3 = xmlNode5.Attributes[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튓聯얟\udda3횥춧", a_)].Value;
						list2 = new global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.BaseSection>();
						enumerator2 = xmlNode5.ChildNodes.GetEnumerator();
						num = (short)1457848321;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_3B2:
						num = (short)1527775237;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_11A:
						goto IL_3B2;
					}
					IL_408:
					return dictionary;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_42A;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_417:
						switch (num3)
						{
						case 0:
							disposable.Dispose();
							num = (short)738328577;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_47E;
						case 2:
							if (disposable != null)
							{
								num = (short)859766784;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_480;
						}
						goto IL_42A;
					}
					IL_47E:
					IL_480:
					goto EndFinally_34;
					IL_42A:
					global::System.Collections.IEnumerator enumerator;
					disposable = (enumerator as global::System.IDisposable);
					num = (short)2066087938;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_417;
					EndFinally_34:;
				}
				goto IL_481;
				IL_97:
				dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.BaseSection>>();
				num = (short)1702625283;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_80;
			}
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0015267C File Offset: 0x0015087C
		private void a(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.BaseSection>> A_0)
		{
			int a_ = 16;
			global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.BaseSection>.Enumerator enumerator;
			global::System.Globalization.CultureInfo provider;
			global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.FreqRange>.Enumerator enumerator3;
			for (;;)
			{
				IL_09:
				short num = (short)1229258752;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					for (;;)
					{
						IL_31:
						num = (short)2084044800;
						short num3 = num;
						switch (num2)
						{
						case 0:
							goto IL_56C;
						case 1:
							goto IL_114;
						case 2:
						{
							num = (short)1278017537;
							if (num != 0)
							{
							}
							num = (short)1946745898;
							short num4 = num;
							num = (short)721943594;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)2082340864;
								if (num != 0)
								{
								}
								global::ConstraintHelper.UtilityMack.TrunkingExceptionRangeList = new global::System.Collections.Generic.List<global::ConstraintHelper.UtilityMack.FCCExceptionRange>();
								enumerator = A_0[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잒욠", a_)].GetEnumerator();
								num = (short)1949237249;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							try
							{
								num = (short)806486021;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_559;
									case 1:
									{
										global::SpecialFeatures.FCCExceptionHandler.BaseSection baseSection;
										global::System.Collections.Generic.List<string>.Enumerator enumerator2 = (baseSection as global::SpecialFeatures.FCCExceptionHandler.PointSection).PointsList.GetEnumerator();
										num = (short)609157123;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1962672132;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.FCCExceptionHandler.BaseSection baseSection = enumerator.Current;
										num = (short)781910025;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										try
										{
											num = (short)1811415041;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 1:
													switch (0)
													{
													case 0:
														goto IL_352;
													}
													continue;
												case 2:
													goto IL_3E5;
												case 3:
													num = (short)343670786;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 4:
												{
													global::System.Collections.Generic.List<string>.Enumerator enumerator2;
													if (!enumerator2.MoveNext())
													{
														num = (short)1166475267;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													string s = enumerator2.Current;
													global::ConstraintHelper.UtilityMack.ConventionalExceptionPointList.Add((int)(double.Parse(s, provider) * 1000000.0));
													num = (short)1880555520;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_354:
												num = (short)1469382660;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_352:
												goto IL_354;
											}
											IL_3E5:
											break;
										}
										finally
										{
											global::System.Collections.Generic.List<string>.Enumerator enumerator2;
											((global::System.IDisposable)enumerator2).Dispose();
										}
										goto IL_3F8;
									case 4:
										goto IL_541;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_22B;
										}
										continue;
									case 6:
									{
										global::SpecialFeatures.FCCExceptionHandler.BaseSection baseSection;
										enumerator3 = (baseSection as global::SpecialFeatures.FCCExceptionHandler.RangeSection).RangesList.GetEnumerator();
										num = (short)905314312;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										global::SpecialFeatures.FCCExceptionHandler.BaseSection baseSection;
										if (baseSection is global::SpecialFeatures.FCCExceptionHandler.RangeSection)
										{
											num = (short)1808793606;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
										try
										{
											num = (short)1874198529;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													num = (short)361562114;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_474;
													}
													continue;
												case 2:
													goto IL_52E;
												case 3:
												{
													if (!enumerator3.MoveNext())
													{
														num = (short)568131584;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::SpecialFeatures.FCCExceptionHandler.FreqRange freqRange = enumerator3.Current;
													global::ConstraintHelper.UtilityMack.ConventionalExceptionRangeList.Add(new global::ConstraintHelper.UtilityMack.FCCExceptionRange((int)(double.Parse(freqRange.RangeStart, provider) * 1000000.0), (int)(double.Parse(freqRange.RangeEnd, provider) * 1000000.0)));
													num = (short)1386741764;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_4D7:
												num = (short)253820931;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_474:
												goto IL_4D7;
											}
											IL_52E:
											break;
										}
										finally
										{
											((global::System.IDisposable)enumerator3).Dispose();
										}
										goto IL_541;
									case 9:
									{
										global::SpecialFeatures.FCCExceptionHandler.BaseSection baseSection;
										if (baseSection is global::SpecialFeatures.FCCExceptionHandler.PointSection)
										{
											num = (short)33292289;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3F8;
									}
									}
									IL_28D:
									num = (short)186515458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_22B:
									goto IL_28D;
									IL_3F8:
									num = (short)423165959;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_541:
									num = (short)1952841728;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_559:
								goto IL_119;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_56C;
						case 4:
							if (A_0.ContainsKey(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킒杖練ﺚ좠첢쮤욦얨", a_)))
							{
								num = (short)1098973184;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_119;
						case 5:
							if (A_0.ContainsKey(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잒욠", a_)))
							{
								num = (short)912785410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
						IL_119:
						num = (short)1203109893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_56C:
						global::ConstraintHelper.UtilityMack.ConventionalExceptionPointList = new global::System.Collections.Generic.List<int>();
						global::ConstraintHelper.UtilityMack.ConventionalExceptionRangeList = new global::System.Collections.Generic.List<global::ConstraintHelper.UtilityMack.FCCExceptionRange>();
						enumerator = A_0[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킒杖練ﺚ좠첢쮤욦얨", a_)].GetEnumerator();
						num = (short)914489347;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_79:
					provider = new global::System.Globalization.CultureInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮔ", a_));
					num = (short)449970180;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
			}
			IL_114:
			try
			{
				short num = (short)777912321;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_7BC;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5FB;
						}
						continue;
					case 2:
						goto IL_7D4;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)6750208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.FCCExceptionHandler.BaseSection baseSection2 = enumerator.Current;
						num = (short)215154694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						try
						{
							num = (short)1731854337;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1914568706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_6EF;
									}
									continue;
								case 2:
									goto IL_7A9;
								case 3:
								{
									if (!enumerator3.MoveNext())
									{
										num = (short)1085079552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.FCCExceptionHandler.FreqRange freqRange2 = enumerator3.Current;
									global::ConstraintHelper.UtilityMack.TrunkingExceptionRangeList.Add(new global::ConstraintHelper.UtilityMack.FCCExceptionRange((int)(double.Parse(freqRange2.RangeStart, provider) * 1000000.0), (int)(double.Parse(freqRange2.RangeEnd, provider) * 1000000.0)));
									num = (short)366477316;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_752:
								num = (short)1110573059;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6EF:
								goto IL_752;
							}
							IL_7A9:
							break;
						}
						finally
						{
							((global::System.IDisposable)enumerator3).Dispose();
						}
						goto IL_7BC;
					case 5:
					{
						global::SpecialFeatures.FCCExceptionHandler.BaseSection baseSection2;
						enumerator3 = (baseSection2 as global::SpecialFeatures.FCCExceptionHandler.RangeSection).RangesList.GetEnumerator();
						num = (short)1852506116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::SpecialFeatures.FCCExceptionHandler.BaseSection baseSection2;
						if (baseSection2 is global::SpecialFeatures.FCCExceptionHandler.RangeSection)
						{
							num = (short)324009989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_670:
					num = (short)1681129475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FB:
					goto IL_670;
					IL_7BC:
					num = (short)726597634;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7D4:;
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00152EEC File Offset: 0x001510EC
		// Note: this type is marked as 'beforefieldinit'.
		static FCCExceptionHandler()
		{
			short num = (short)175096971;
			short num2 = num;
			num = (short)1640285323;
			switch (num2 == num)
			{
			}
			num = (short)776994816;
			if (num != 0)
			{
			}
			num = (short)1890975744;
			short num3 = num;
			num = (short)1820262401;
			if (num != 0)
			{
			}
			global::SpecialFeatures.FCCExceptionHandler.FCCExceptionHandler.a = new global::SpecialFeatures.FCCExceptionHandler.FCCExceptionHandler();
		}

		// Token: 0x040007FD RID: 2045
		private static global::SpecialFeatures.FCCExceptionHandler.FCCExceptionHandler a;

		// Token: 0x040007FE RID: 2046
		private string b;
	}
}
