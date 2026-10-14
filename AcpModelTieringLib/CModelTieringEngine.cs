using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using AcpCommonLib;
using AcpCryptoLib;
using AcpUtility;

namespace AcpModelTieringLib
{
	// Token: 0x02000003 RID: 3
	public class CModelTieringEngine : global::AcpCommonLib.IAcpModelTieringEngine
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public string TieringFileVersion
		{
			get
			{
				short num = (short)240844801;
				if (num != 0)
				{
				}
				num = (short)995325810;
				short num2 = num;
				num = (short)1274181490;
				switch (num2 == num)
				{
				}
				num = (short)555352064;
				if (num != 0)
				{
				}
				num = (short)1327562752;
				short num3 = num;
				return this.f;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		public global::AcpModelTieringLib.CModelTieringData ModelTieringData
		{
			get
			{
				short num = (short)955394087;
				short num2 = num;
				num = (short)1814636583;
				switch (num2 == num)
				{
				}
				num = (short)1855193089;
				if (num != 0)
				{
				}
				num = (short)749404160;
				if (num != 0)
				{
				}
				num = (short)711589888;
				short num3 = num;
				return this.e;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000227C File Offset: 0x0000047C
		public global::System.Collections.Generic.List<string> TieredFields
		{
			get
			{
				short num = (short)1371681436;
				short num2 = num;
				num = (short)1647587996;
				switch (num2 == num)
				{
				}
				num = (short)1688010753;
				if (num != 0)
				{
				}
				num = (short)313524224;
				if (num != 0)
				{
				}
				num = (short)354811904;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002328 File Offset: 0x00000528
		public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string[]>> PCIFieldsAndUpdateCriteria
		{
			get
			{
				short num = (short)1595473921;
				if (num != 0)
				{
				}
				num = (short)742823848;
				short num2 = num;
				num = (short)1726191528;
				switch (num2 == num)
				{
				}
				num = (short)1588658176;
				if (num != 0)
				{
				}
				num = (short)529793024;
				short num3 = num;
				return this.g;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000023D4 File Offset: 0x000005D4
		public global::System.Collections.Generic.List<string> TieredRecordsets
		{
			get
			{
				short num = (short)1966473217;
				if (num != 0)
				{
				}
				num = (short)940540770;
				short num2 = num;
				num = (short)1162380130;
				switch (num2 == num)
				{
				}
				num = (short)285671424;
				if (num != 0)
				{
				}
				num = (short)1931870208;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002484 File Offset: 0x00000684
		static CModelTieringEngine()
		{
			short num = (short)914694202;
			short num2 = num;
			num = (short)1097343034;
			switch (num2 == num)
			{
			}
			num = (short)338493441;
			if (num != 0)
			{
			}
			num = (short)1244200960;
			if (num != 0)
			{
			}
			num = (short)1900871680;
			short num3 = num;
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002534 File Offset: 0x00000734
		public CModelTieringEngine(bool bolEncrypted, string strMTFFilePath, bool bolLoadTieringData, global::System.Collections.Generic.Dictionary<string, bool> dctAllOptions)
		{
			int a_ = 13;
			this.a = new global::System.Collections.Generic.List<string>();
			this.b = new global::System.Collections.Generic.List<string>();
			this.c = new global::System.Xml.XmlDocument();
			this.g = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string[]>>();
			base..ctor();
			try
			{
				if (strMTFFilePath.Trim().Length == 0)
				{
					throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("蚿듃Ʂ볇ꋉꟍꏏ뇓믕꣗껙ꗛﻝ죟胡裣蟥蛧臩엫십탯鏱髳훵鷷韹賻諽秿∁䤃刅万⨉簋漍搏稑㐓缕欗㨙爛焝吟ȡ䔣䨥䐧䔩嬫䬭启ᰱ", a_));
				}
				if (bolEncrypted)
				{
					global::AcpCryptoLib.AcpXMLEncryptDecrypt acpXMLEncryptDecrypt = new global::AcpCryptoLib.AcpXMLEncryptDecrypt();
					this.c = acpXMLEncryptDecrypt.DecryptXMLFile(strMTFFilePath);
				}
				else
				{
					this.c.Load(strMTFFilePath);
				}
				if (dctAllOptions == null)
				{
					throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("ﶻ튽겿跁듃닅ꇇꗉꋋ뷍믑ꟓ뛗꿙냛닝쳟싡藣웥蛧鿩胫苭탯돱飳髵럷諹裻韽濿氁眃★愇礉Ⰻ怍缏昑㐓眕琗瘙猛椝䔟䘡ਣ", a_));
				}
				this.d = dctAllOptions;
				this.f();
				if (bolLoadTieringData)
				{
					this.e();
					this.d();
					this.c();
					this.b();
					this.a();
					this.e = new global::AcpModelTieringLib.CModelTieringData(this.d, this.c);
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.Write(ex.Message);
				throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("킽ꆿꃁꣃꏅ뻉ꏋ돏ꃑ뇓럕곗뿙ﳛ뿝샟ꇡꧣ觥賧迩胫뫭駯韱蛳鿵雷鷹맻都柿欁樃挅⠇攉渋損甏焑怓Ⱅ㠗", a_) + ex.Message);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002674 File Offset: 0x00000874
		private void f()
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_77;
			}
			short num;
			int num3;
			global::System.Xml.XmlNodeList xmlNodeList;
			for (;;)
			{
				IL_13:
				num = (short)274589819;
				short num2 = num;
				num = (short)1534781563;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)293273600;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_30F;
					case 1:
					{
						if (xmlNodeList.Count == 0)
						{
							num = (short)1495269378;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1984495616;
						short num4 = num;
						num = (short)1484652547;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_CB;
					case 3:
						goto IL_2AB;
					case 4:
						goto IL_2CB;
					}
					goto IL_77;
				}
				IL_2AB:
				if (xmlNodeList.Count != 1)
				{
					num = (short)1766785028;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)8912896;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_CB:
			throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("\ud8b6\uddb8\udeba톼꓀ꫂ럄껆ꟈ곊诌ꛎ뷐뛒맖뛘뿚룜￞雠諢釤迦짨藪苬쿮鋰鯲鳴鯶鷸觺飼釾℀眂搄怆稈┊", a_));
			IL_243:
			throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("\ud8b6첸햺\ud9bc龾뗀곂꫄꓈꫊ꏌ뛎볒꟔럘듚﷜鋞軠蟢胤详짨뿪蓬諮菰髲鯴郶\ud9f8뷺铼鏾搀⌂圄栆昈缊ⴌ愎縐眒瀔搖㜘", a_));
			IL_2CB:
			num = (short)995098625;
			if (num != 0)
			{
			}
			goto IL_243;
			IL_30F:
			try
			{
				num = (short)2121465857;
				num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_200;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_10A;
						}
						continue;
					case 2:
						num = (short)608370691;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (xmlNodeList[0].Attributes[global::AcpModelTieringLib.ErrorException.b("쎴튶쮸좺풼킾꿀", a_)].Value.Trim().Length == 0)
						{
							num = (short)1985806340;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.f = xmlNodeList[0].Attributes[global::AcpModelTieringLib.ErrorException.b("쎴튶쮸좺풼킾꿀", a_)].Value.ToString();
						num = (short)704839680;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1B6;
					}
					IL_10A:
					if (xmlNodeList[0].Attributes[global::AcpModelTieringLib.ErrorException.b("쎴튶쮸좺풼킾꿀", a_)].Value == null)
					{
						break;
					}
					num = (short)1873346562;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_146:
				throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("\udab6즸쾺쒼龾럀ꛂ럄듆ꃈ꓊ꏌ뿐ꛒ룔뗖볘꧚﷜뻞闠韢韤軦诨黪駬諮\udff0", a_));
				IL_1B6:
				goto IL_146;
				IL_200:
				return;
			}
			catch (global::System.Exception ex)
			{
				if (ex.Message.Equals(global::AcpModelTieringLib.ErrorException.b("華햶편\udeba\udebc쮾뇂ꃄꇆ곈맊꣌ꇎ닐뛒맖뛘꿚﷜곞蓠韢엤鏦蛨쯪賬臮퇰髲鯴蓶跸髺鏼鳾搀⌂樄愆⤈樊挌⼎縐焒缔爖稘漚㌜", a_)))
				{
					throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("\ud8b6\uddb8\udeba톼ꣀꛂ럄껆ꟈ곊诌ꛎ뷐뛒ꏖ룘볚￞韠蛢韤铦胨蓪菬쿮郰蟲致藶郸駺裼课搀⌂欄栆紈⬊欌怎搐紒焔㤖", a_));
				}
				throw new global::System.Exception(ex.Message);
			}
			goto IL_243;
			IL_77:
			xmlNodeList = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("骴얶횸풺즼邾賀곂ꇄꋆꗈ鿊꓌꫎ꏐ뫒믔냖鿘닚뇜뫞", a_));
			num = (short)1380057089;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000029B4 File Offset: 0x00000BB4
		public void GetTieringData(string recordsetOrFieldName)
		{
			int a_ = 7;
			short num;
			try
			{
				num = (short)81906348;
				short num2 = num;
				num = (short)1655949996;
				switch (num2 == num)
				{
				}
				num = (short)358154241;
				if (num != 0)
				{
				}
				num = (short)949878784;
				if (num != 0)
				{
				}
				this.e.GetData(recordsetOrFieldName);
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.Write(recordsetOrFieldName + global::AcpModelTieringLib.ErrorException.b("貵颷", a_) + ex.Message);
				throw new global::System.Exception(recordsetOrFieldName + global::AcpModelTieringLib.ErrorException.b("貵颷", a_) + ex.Message);
			}
			num = (short)1629290496;
			short num3 = num;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002AC8 File Offset: 0x00000CC8
		private void e()
		{
			int a_ = 15;
			short num = (short)867172352;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1781727233;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						global::System.Xml.XmlNodeList xmlNodeList = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("醽늿귁ꯃ닅蟉ꏋ꫍뗏뻑胓뿕뷗꣙뗛냝蟟ꓡ跣諥跧엩뿫鯭胯英鯳蓵賷鿹飻뛽俿爁瀃漅朇搉缋ℍ䈏猑瀓缕眗尙紛猝䤟両崣थ朧娩堫䜭弯就䜳ᤵ眷䨹䠻圽⼿ⱁ", a_));
						if (xmlNodeList.Count == 0)
						{
							goto Block_4;
						}
						enumerator = xmlNodeList.GetEnumerator();
						num = (short)1197801475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					case 2:
						try
						{
							num = (short)1428946945;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_6EA;
								case 1:
								{
									num = (short)1399499101;
									short num3 = num;
									num = (short)1006348637;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_6D2;
									default:
										num = (short)255328256;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_477;
										}
										continue;
									}
									break;
								}
								case 2:
									try
									{
										num = (short)1524039684;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Xml.XmlNode xmlNode;
											switch (num2)
											{
											case 0:
												goto IL_63C;
											case 1:
												num = (short)1519779842;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("킽ꆿ꿁ꇃ", a_)].Value != null)
												{
													num = (short)1632698375;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_628;
											case 3:
												goto IL_654;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_4E6;
												}
												continue;
											case 5:
												if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("킽ꆿ꿁ꇃ", a_)].Value.Trim().Length == 0)
												{
													num = (short)1216479238;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												this.d.Add(xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("킽ꆿ꿁ꇃ", a_)].Value, false);
												num = (short)1531183104;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												goto IL_589;
											case 7:
												num = (short)564264965;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_4E6:
											if (!this.d.ContainsKey(xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("킽ꆿ꿁ꇃ", a_)].Value))
											{
												num = (short)1260978177;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_63C:
											num = (short)608239619;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_589:
										IL_628:
										throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("꾿ꛁꇃ꫅蓉맋ꏍ닏럑ꛓ뛗믙뇛믝샟菡郣鋥髧菩軫鯭蓯韱퓳鏵闷諹裻蟽⻿", a_));
										IL_654:;
									}
									catch (global::System.Exception ex)
									{
										if (ex.Message.Equals(global::AcpModelTieringLib.ErrorException.b("ꊿꣁꇃꗅ볇뻋ꯍ뛏럑ꛓ돕뛗맙맛ﻝ軟跡郣웥鯧迩飫컭蓯鷱퓳韵雷\udaf9闻都珿瘁攃栅欇漉Ⰻ愍瘏㈑甓砕㠗甙縛琝䔟䄡倣ࠥ", a_)))
										{
											throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("꾿ꛁꇃ꫅蛇뿉ꇋ곍뗏ꃑꋕ맗뷙ﻝ軟菡解菥죧诩飫髭苯鯱雳菵賷鿹\udcfb都濿瘁␃怅朇缉戋樍㸏", a_));
										}
										throw new global::System.Exception(ex.Message);
									}
									break;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)728498180;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
									num = (short)217710594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_6D2;
								}
								IL_694:
								num = (short)1287454723;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_477:
								goto IL_694;
								IL_6D2:
								num = (short)1653997568;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6EA:;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_709;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_6F6:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)2096234497;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_75E;
								case 1:
									disposable.Dispose();
									num = (short)1909981186;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_75C;
								}
								goto IL_709;
							}
							IL_75C:
							IL_75E:
							goto EndFinally_24;
							IL_709:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)125829120;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_6F6;
							EndFinally_24:;
						}
						num = (short)186449920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_7B8;
					}
					IL_5D:
					global::System.Xml.XmlNodeList xmlNodeList2 = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("醽늿귁ꯃ닅蟉ꏋ꫍뗏뻑胓뿕뷗꣙뗛냝蟟ꓡ跣諥跧엩뿫鯭胯英鯳蓵賷鿹飻뛽俿爁瀃漅朇搉缋ℍ䈏猑瀓缕眗尙紛猝䤟両崣थ攧䔩䠫䬭尯䄱ᬳ笵圷帹夻刽", a_));
					if (xmlNodeList2.Count == 0)
					{
						break;
					}
					enumerator = xmlNodeList2.GetEnumerator();
					num = (short)1421279234;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3BE:
				throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("꾿ꛁꇃ꫅믇ꋋꇍ듏럑ꇕ뇗껙듛ﻝ軟跡쓣ꯥ蟧軩觫苭탯蛱闳釵请퓹", a_));
				Block_4:
				throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("낿뛁귃꧅ꛇ막ꃍ뿏뛑뇓꿗동꣛뛝샟賡诣웥꟧髩飫蟭鿯鳱퓳苵駷鷹迻탽", a_));
				IL_7B8:
				num = (short)567083009;
				if (num != 0)
				{
				}
				num = (short)13762560;
				short num4 = num;
				try
				{
					num = (short)291831809;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_344;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_C0;
							}
							continue;
						case 2:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)471793667;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator.Current;
							num = (short)1239285764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)187105280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							try
							{
								num = (short)1749090308;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Xml.XmlNode xmlNode2;
									switch (num2)
									{
									case 0:
										goto IL_266;
									case 1:
										num = (short)1389428741;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										if (xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("킽ꆿ꿁ꇃ", a_)].Value.Trim().Length == 0)
										{
											num = (short)1041891335;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										this.d.Add(xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("킽ꆿ꿁ꇃ", a_)].Value, false);
										num = (short)914096128;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_27F;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_10C;
										}
										continue;
									case 5:
										if (xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("킽ꆿ꿁ꇃ", a_)].Value != null)
										{
											num = (short)971833350;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_252;
									case 6:
										num = (short)349306882;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_250;
									}
									IL_10C:
									if (!this.d.ContainsKey(xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("킽ꆿ꿁ꇃ", a_)].Value))
									{
										num = (short)1054801921;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_266:
									num = (short)1957363715;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_250:
								IL_252:
								throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("낿뛁귃꧅ꛇꋋ꿍뷏럑럕곗껙껛럝苟韡郣菥죧迩臫黭蓯诱\udaf3", a_));
								IL_27F:;
							}
							catch (global::System.Exception ex2)
							{
								if (ex2.Message.Equals(global::AcpModelTieringLib.ErrorException.b("ꊿꣁꇃꗅ볇뻋ꯍ뛏럑ꛓ돕뛗맙맛ﻝ軟跡郣웥鯧迩飫컭蓯鷱퓳韵雷\udaf9闻都珿瘁攃栅欇漉Ⰻ愍瘏㈑甓砕㠗甙縛琝䔟䄡倣ࠥ", a_)))
								{
									throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("낿뛁귃꧅ꛇ룋꿍럏ﻑ룕맗럙맛ﻝ臟雡郣铥臧裩駫髭闯틱髳駵賷\udaf9髻釽痿氁怃⠅", a_));
								}
								throw new global::System.Exception(ex2.Message);
							}
							break;
						}
						IL_2C2:
						num = (short)1097596930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C0:
						goto IL_2C2;
					}
					IL_344:
					return;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_366;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_353:
						switch (num2)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)2073690113;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3BD;
						case 1:
							disposable.Dispose();
							num = (short)91095042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_3BB;
						}
						goto IL_366;
					}
					IL_3BB:
					IL_3BD:
					goto EndFinally_23;
					IL_366:
					global::System.Collections.IEnumerator enumerator;
					disposable = (enumerator as global::System.IDisposable);
					num = (short)915668992;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_353;
					EndFinally_23:;
				}
				goto IL_3BE;
			}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000335C File Offset: 0x0000155C
		private void d()
		{
			int a_ = 19;
			short num = (short)1994522624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)2145058816;
				short num3 = num;
				global::System.Xml.XmlNodeList xmlNodeList = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("뛃꧅Ꟈ뻉菍뿏뛑뇓뫕賗동맛곝觟賡菣ꃥ臧蛩觫쇭ꋯ韱音駵諷黹迻鯽瓿焁⬃吅洇椉挋簍琏愑焓戕", a_));
				if (xmlNodeList.Count == 0)
				{
					throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("郁ꇃꗅꟇ룉꣋뷍뗏ꛑꟓ뛗뗙룛믝샟闡跣鋥胧쫩苫臭탯胱釳闵韷裹飻\udefd瓿持挃甅☇", a_));
				}
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
					try
					{
						num = (short)1885601796;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1462239233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
								num = (short)1377763330;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_2CF;
							case 2:
								try
								{
									num = (short)386269188;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Xml.XmlNode xmlNode;
										switch (num2)
										{
										case 0:
											if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("곁ꗃꯅ귇", a_)].Value.Trim().Length == 0)
											{
												num = (short)1044185089;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_245;
										case 1:
										{
											num = (short)1930394068;
											short num4 = num;
											num = (short)30570964;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_245;
											default:
												goto IL_21A;
											}
											break;
										}
										case 2:
											num = (short)1247870976;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											goto IL_28C;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_153;
											}
											continue;
										}
										IL_153:
										if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("곁ꗃꯅ귇", a_)].Value != null)
										{
											num = (short)1895038978;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_231;
										IL_245:
										this.a.Add(xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("곁ꗃꯅ귇", a_)].Value.ToString());
										num = (short)1792606211;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_21A:
									num = (short)439287808;
									if (num != 0)
									{
									}
									IL_231:
									throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("郁ꇃꗅꟇ룉꣋뷍뗏ꛑ룕맗럙맛ﻝ臟雡郣铥臧裩駫髭闯틱釳鯵裷軹藻탽", a_));
									IL_28C:
									break;
								}
								catch (global::System.Exception ex)
								{
									if (ex.Message.Equals(global::AcpModelTieringLib.ErrorException.b("跁ꛃ곅귇꧉룋ꋏ럑닓돕꫗뿙닛뷝藟싡諣觥鳧쫩鿫语蓯틱胳駵\ud8f7鯹鋻\udefd槿氁眃爅椇搉漋欍』紑爓㘕礗琙㰛焝䈟䠡䄣䔥尧Щ", a_)))
									{
										throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("郁ꇃꗅꟇ룉꣋뷍뗏ꛑꋕ맗뷙ﻝ軟菡解菥죧诩飫髭苯鯱雳菵賷鿹\udcfb都濿瘁␃怅朇缉戋樍㸏", a_));
									}
									throw new global::System.Exception(ex.Message);
								}
								goto IL_2CF;
							case 3:
								goto IL_2E8;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_B3;
								}
								continue;
							}
							IL_DC:
							num = (short)170000384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B3:
							goto IL_DC;
							IL_2CF:
							num = (short)2114125827;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2E8:
						break;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_30A;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_2F7:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)405798913;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_35E;
							case 2:
								if (disposable != null)
								{
									num = (short)921829376;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_388;
							}
							goto IL_30A;
						}
						IL_35E:
						num = (short)235208705;
						if (num != 0)
						{
						}
						IL_388:
						continue;
						IL_30A:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1900806146;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_2F7;
					}
				}
				return;
			}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003748 File Offset: 0x00001948
		private void c()
		{
			int a_ = 13;
			short num = (short)1423179776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Xml.XmlNodeList xmlNodeList = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("鎻첽꾿귁냃藇ꗉ꣋ꯍ볏蛑뷓돕꫗동닛망ꛟ诡裣菥쟧곩藫语鳯雱蟳\ud9f5뻷鏹駻鋽擿", a_));
				if (xmlNodeList.Count == 0)
				{
					throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("請ힽꖿ껁ꃃ뗅꓉ꏋ꫍뗏ꏓ뿕곗닙ﳛ냝迟싡苣迥跧蛩裫컭蓯鏱鏳藵훷", a_));
				}
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
					try
					{
						num = (short)413728772;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1102446593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
								num = (short)1201274882;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_2A7;
							case 2:
								try
								{
									num = (short)1634926596;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Xml.XmlNode xmlNode;
										switch (num2)
										{
										case 0:
											if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("튻\udfbd궿ꟁ", a_)].Value.Trim().Length == 0)
											{
												num = (short)288227329;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_21E;
										case 1:
										{
											num = (short)1141498030;
											short num3 = num;
											num = (short)845930670;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_21E;
											default:
												goto IL_1F3;
											}
											break;
										}
										case 2:
											num = (short)1081868288;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											goto IL_264;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_12A;
											}
											continue;
										}
										IL_12A:
										if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("튻\udfbd궿ꟁ", a_)].Value != null)
										{
											num = (short)1546846210;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_20A;
										IL_21E:
										this.b.Add(xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("튻\udfbd궿ꟁ", a_)].Value.ToString());
										num = (short)21692419;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_1F3:
									num = (short)1882718208;
									if (num != 0)
									{
									}
									IL_20A:
									throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("請ힽꖿ껁ꃃꛇꯉꇋꯍ돑ꃓꋕ꫗동뻛ꯝ铟蟡쓣菥藧髩飫韭\udeef", a_));
									IL_264:
									break;
								}
								catch (global::System.Exception ex)
								{
									if (ex.Message.Equals(global::AcpModelTieringLib.ErrorException.b("\udcbd꪿ꟁꟃ닅룉꧋꣍뗏ꃑ뇓룕믗뿙ﳛ냝迟雡쓣闥跧黩쳫髭鿯틱闳飵\ud8f7鏹鋻跽瓿持樃攅洇⨉挋栍』猑稓㘕眗砙瘛笝䌟嘡ਣ", a_)))
									{
										throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("請ힽꖿ껁ꃃ볇ꯉꯋ병뗓믕뷗龎뷛ꫝ铟郡跣蓥鷧黩觫컭黯鷱胳훵黷闹觻都擿Ⰱ", a_));
									}
									throw new global::System.Exception(ex.Message);
								}
								goto IL_2A7;
							case 3:
								goto IL_2BF;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_8A;
								}
								continue;
							}
							IL_B3:
							num = (short)1808203776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_8A:
							goto IL_B3;
							IL_2A7:
							num = (short)1206910979;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2BF:
						break;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_2E1;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_2CE:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)254017537;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_334;
							case 2:
								if (disposable != null)
								{
									num = (short)106299392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_336;
							}
							goto IL_2E1;
						}
						IL_334:
						IL_336:
						continue;
						IL_2E1:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)713555970;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_2CE;
					}
				}
				num = (short)386400256;
				short num4 = num;
				num = (short)2034368513;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003B30 File Offset: 0x00001D30
		private void b()
		{
			int a_ = 15;
			short num = (short)264372224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::System.Xml.XmlNodeList xmlNodeList;
				for (;;)
				{
					IL_30:
					global::System.Collections.IEnumerator enumerator3;
					switch (num2)
					{
					case 0:
					{
						num = (short)2007695360;
						short num3 = num;
						try
						{
							num = (short)908722180;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Xml.XmlNode xmlNode;
								switch (num2)
								{
								case 0:
									num = (short)2111307779;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_175;
										}
										string text2;
										for (;;)
										{
											IL_14E:
											switch (num2)
											{
											case 0:
											{
												global::System.Collections.IEnumerator enumerator = xmlNode.GetEnumerator();
												num = (short)1179516929;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												try
												{
													num = (short)1938030595;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
														{
															global::System.Xml.XmlNode xmlNode2;
															if (xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("킽ꆿ꿁ꇃ", a_)].Value != null)
															{
																num = (short)2064777221;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_282;
														}
														case 1:
														{
															global::System.Collections.IEnumerator enumerator;
															if (!enumerator.MoveNext())
															{
																num = (short)2097348614;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator.Current;
															global::System.Collections.Generic.List<string[]> list = new global::System.Collections.Generic.List<string[]>();
															num = (short)2030108672;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 2:
															num = (short)340918285;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 3:
															switch (0)
															{
															case 0:
																goto IL_27D;
															}
															continue;
														case 4:
															goto IL_A10;
														case 5:
															num = (short)274006027;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 6:
															goto IL_9F8;
														case 7:
														{
															global::System.Collections.Generic.List<string[]> list;
															string text;
															try
															{
																num = (short)1109327880;
																num2 = (int)((global::System.IntPtr)num);
																for (;;)
																{
																	switch (num2)
																	{
																	case 0:
																	{
																		global::System.Xml.XmlNode xmlNode3;
																		if (xmlNode3.Attributes[global::AcpModelTieringLib.ErrorException.b("톽낿뛁귃꧅ꛇ", a_)].Value == null)
																		{
																			num = (short)1077805073;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		string[] array;
																		array[0] = xmlNode3.Attributes[global::AcpModelTieringLib.ErrorException.b("톽낿뛁귃꧅ꛇ", a_)].Value.Trim();
																		num = (short)25296909;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	case 1:
																	{
																		global::System.Collections.IEnumerator enumerator2;
																		if (!enumerator2.MoveNext())
																		{
																			num = (short)581042183;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		global::System.Xml.XmlNode xmlNode3 = (global::System.Xml.XmlNode)enumerator2.Current;
																		string[] array = new string[3];
																		num = (short)961150976;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	case 2:
																		goto IL_97B;
																	case 3:
																		goto IL_8AC;
																	case 4:
																	{
																		global::System.Xml.XmlNode xmlNode3;
																		if (xmlNode3.Attributes[global::AcpModelTieringLib.ErrorException.b("좽ꆿ껁뇃ꏅ", a_)].Value.Trim().Length == 0)
																		{
																			num = (short)522256400;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		num = (short)581763086;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	case 5:
																	{
																		global::System.Xml.XmlNode xmlNode3;
																		if (xmlNode3.Attributes[global::AcpModelTieringLib.ErrorException.b("좽ꆿ껁뇃ꏅ", a_)].Value != null)
																		{
																			num = (short)425984015;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		goto IL_692;
																	}
																	case 6:
																	{
																		string[] array;
																		list.Add(array);
																		num = (short)1532559371;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	case 7:
																		num = (short)2006122498;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	case 8:
																		switch (0)
																		{
																		case 0:
																			goto IL_5B5;
																		}
																		continue;
																	case 9:
																		goto IL_722;
																	case 10:
																	{
																		string[] array;
																		if (array[0] != global::AcpModelTieringLib.ErrorException.b("覿郁觃釅觇飉觋重蛏韑蛓藕釗闙鋛", a_))
																		{
																			num = (short)978518022;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		break;
																	}
																	case 12:
																		goto IL_722;
																	case 13:
																	{
																		global::System.Xml.XmlNode xmlNode3;
																		if (xmlNode3.Attributes[global::AcpModelTieringLib.ErrorException.b("캽ꆿ냁ꗃꯅ귇뻉꧋볍", a_)].Value == null)
																		{
																			num = (short)1344602115;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		string[] array;
																		array[1] = xmlNode3.Attributes[global::AcpModelTieringLib.ErrorException.b("캽ꆿ냁ꗃꯅ귇뻉꧋볍", a_)].Value.Trim();
																		num = (short)317915141;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	case 14:
																	{
																		string[] array;
																		if (array[0] != global::AcpModelTieringLib.ErrorException.b("覿郁觃釅觇飉觋重蛏韑蛓藕釗闙鋛", a_))
																		{
																			num = (short)773128210;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		global::System.Xml.XmlNode xmlNode3;
																		text = xmlNode3.Attributes[global::AcpModelTieringLib.ErrorException.b("좽ꆿ껁뇃ꏅ", a_)].Value.Trim();
																		num = (short)1568800777;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	case 15:
																		num = (short)1524826116;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	case 16:
																		goto IL_7D4;
																	case 17:
																		goto IL_68D;
																	case 18:
																	{
																		global::System.Xml.XmlNode xmlNode3;
																		string[] array;
																		array[2] = xmlNode3.Attributes[global::AcpModelTieringLib.ErrorException.b("좽ꆿ껁뇃ꏅ", a_)].Value.Trim();
																		num = (short)447021068;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	}
																	goto IL_5B5;
																	IL_722:
																	num = (short)912326666;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																	IL_7D9:
																	num = (short)243073025;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																	IL_5B5:
																	goto IL_7D9;
																}
																IL_68D:
																throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("諾ꖿ꓁ꗃ독꓇뻉髋꿍볏ꟑ뇓맗껙꣛곝觟胡釣鋥跧쫩菫黭蓯鯱鯳飵\ud8f7黹鏻鯽珿∁樃椅簇⨉椋瘍礏愑怓㠕", a_));
																IL_692:
																throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("諾ꖿ꓁ꗃ독꓇뻉髋꿍볏ꟑ뇓맗껙꣛곝觟胡釣鋥跧쫩髫迭鳯蟱釳훵鷷韹賻諽秿Ⰱ", a_));
																IL_7D4:
																goto IL_692;
																IL_8AC:
																throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("諾ꖿ꓁ꗃ독꓇뻉髋꿍볏ꟑ뇓맗껙꣛곝觟胡釣鋥跧쫩鳫迭苯鏱駳鏵賷鿹軻\udefd擿洁愃甅⠇搉挋稍』眑氓缕欗渙㈛", a_));
																IL_97B:
																goto IL_296;
															}
															finally
															{
																switch (0)
																{
																case 0:
																	goto IL_99D;
																}
																global::System.IDisposable disposable;
																for (;;)
																{
																	IL_98A:
																	switch (num2)
																	{
																	case 0:
																		if (disposable != null)
																		{
																			num = (short)391905281;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		goto IL_9F7;
																	case 1:
																		disposable.Dispose();
																		num = (short)825294850;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	case 2:
																		goto IL_9F5;
																	}
																	goto IL_99D;
																}
																IL_9F5:
																IL_9F7:
																goto EndFinally_30;
																IL_99D:
																global::System.Collections.IEnumerator enumerator2;
																disposable = (enumerator2 as global::System.IDisposable);
																num = (short)1136721920;
																num2 = (int)((global::System.IntPtr)num);
																goto IL_98A;
																EndFinally_30:;
															}
															goto IL_9F8;
															IL_296:
															string[] item = new string[]
															{
																global::AcpModelTieringLib.ErrorException.b("覿郁觃釅觇飉觋重蛏韑蛓藕釗闙鋛", a_),
																text2,
																text
															};
															list.Add(item);
															global::System.Xml.XmlNode xmlNode2;
															string key = xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("킽ꆿ꿁ꇃ", a_)].Value.Trim();
															this.g.Add(key, list);
															num = (short)1535246345;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 8:
															goto IL_477;
														case 10:
														{
															global::System.Xml.XmlNode xmlNode2;
															if (xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("쮽ꦿ鷁꫃Ʂꗇ꿉", a_)].Value != null)
															{
																num = (short)350945282;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_52F;
														}
														case 11:
														{
															global::System.Xml.XmlNode xmlNode2;
															if (xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("킽ꆿ꿁ꇃ", a_)].Value.Trim().Length == 0)
															{
																num = (short)1372717064;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															num = (short)145555466;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 12:
															goto IL_36F;
														case 13:
														{
															global::System.Xml.XmlNode xmlNode2;
															if (xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("쮽ꦿ鷁꫃Ʂꗇ꿉", a_)].Value.Trim().Length == 0)
															{
																num = (short)629407756;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::System.Xml.XmlNode xmlNode4 = xmlNode2.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("諾ꖿ꓁ꗃ독꓇뻉髋꿍볏ꟑ뇓ꗕ", a_));
															string text = global::AcpModelTieringLib.ErrorException.b("쪽늿럁ꇃ", a_);
															global::System.Collections.IEnumerator enumerator2 = xmlNode4.GetEnumerator();
															num = (short)689831943;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														}
														IL_4EB:
														num = (short)1500250113;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_27D:
														goto IL_4EB;
														IL_9F8:
														num = (short)44826628;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_282:
													throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("ﾽ겿ꯁꗃ뗅꓉귋ꏍ뗏뗓ꋕ곗꣙뗛볝闟雡臣웥跧蟩鳫髭觯\udcf1", a_));
													IL_36F:
													goto IL_52F;
													IL_477:
													goto IL_282;
													IL_52F:
													throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("ﾽ겿ꯁꗃ뗅Ꟊ귋뻍돑ꃓꋕ꫗동뻛ꯝ铟蟡쓣菥藧髩飫韭\udeef", a_));
													IL_A10:
													goto IL_B7D;
												}
												finally
												{
													switch (0)
													{
													case 0:
														goto IL_A32;
													}
													global::System.IDisposable disposable;
													for (;;)
													{
														IL_A1F:
														switch (num2)
														{
														case 0:
															if (disposable != null)
															{
																num = (short)829489153;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_A8A;
														case 1:
															disposable.Dispose();
															num = (short)1985675266;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 2:
															goto IL_A88;
														}
														goto IL_A32;
													}
													IL_A88:
													IL_A8A:
													goto EndFinally_31;
													IL_A32:
													global::System.Collections.IEnumerator enumerator;
													disposable = (enumerator as global::System.IDisposable);
													num = (short)1140588544;
													num2 = (int)((global::System.IntPtr)num);
													goto IL_A1F;
													EndFinally_31:;
												}
												goto IL_A8B;
											case 2:
												if (xmlNode != null)
												{
													num = (short)726597632;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_B7D;
											case 3:
											{
												num = (short)1562301721;
												short num4 = num;
												num = (short)804312345;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													break;
												default:
													num = (short)1154613248;
													if (num != 0)
													{
													}
													if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("좽ꖿ냁럃꿅Ꟈ꓉", a_)].Value != null)
													{
														num = (short)1700265991;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_A8B;
												}
												break;
											}
											case 4:
												if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("좽ꖿ냁럃꿅Ꟈ꓉", a_)].Value.Trim().Length == 0)
												{
													num = (short)802422789;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												text2 = xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("좽ꖿ냁럃꿅Ꟈ꓉", a_)].Value.Trim();
												num = (short)2068119554;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												goto IL_AF9;
											case 6:
												goto IL_B95;
											case 7:
												num = (short)1618214916;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_175;
											IL_B7D:
											num = (short)1565065222;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_A8B:
										throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("ꦿ곁軅Ꟈ막룋蛏럑ꛓꗕ뇗뗙닛ﻝ軟跡郣웥軧藩駫胭铯틱鋳駵諷\udaf9賻鷽槿", a_));
										IL_AF9:
										goto IL_A8B;
										IL_B95:
										break;
										IL_175:
										text2 = string.Empty;
										num = (short)1832583171;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_14E;
									}
									catch (global::System.Exception ex)
									{
										throw ex;
									}
									goto IL_B9B;
								case 2:
									if (!enumerator3.MoveNext())
									{
										num = (short)519372800;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B9B;
								case 3:
									goto IL_BDD;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_103;
									}
									continue;
								}
								IL_108:
								num = (short)2095316994;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_103:
								goto IL_108;
								IL_B9B:
								xmlNode = (global::System.Xml.XmlNode)enumerator3.Current;
								num = (short)668139521;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_BDD:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_BFF;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_BEC:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1952251905;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C57;
								case 1:
									disposable.Dispose();
									num = (short)2125266946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_C55;
								}
								goto IL_BFF;
							}
							IL_C55:
							IL_C57:
							goto EndFinally_32;
							IL_BFF:
							disposable = (enumerator3 as global::System.IDisposable);
							num = (short)43581440;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_BEC;
							EndFinally_32:;
						}
						goto IL_C58;
					}
					case 1:
						if (xmlNodeList != null)
						{
							num = (short)1091502083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_C4;
					case 3:
						goto IL_C58;
					case 4:
						if (xmlNodeList.Count == 0)
						{
							num = (short)1199636482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)124846081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B;
					IL_C58:
					enumerator3 = xmlNodeList.GetEnumerator();
					num = (short)369295360;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C4:
				throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("莿证苃꿅귇ꛉ꣋뷍병믓닕뷗龎ꯛ럝铟諡쓣裥蟧쫩볫귭맯등鷳鏵铷黹\udcfb諽懿攁眃⠅", a_));
				IL_4B:
				num = (short)549060609;
				if (num != 0)
				{
				}
				xmlNodeList = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("醽늿귁ꯃ닅蟉ꏋ꫍뗏뻑胓뿕뷗꣙뗛냝蟟ꓡ跣諥跧엩볫귭맯등鷳鏵铷黹迻퇽䣿洁眃爅帇漉縋納礏紑稓䘕笗猙娛眝䔟両䀣唥ܧ朩䔫䀭砯崱䜳䈵渷弹主䴽⤿ⵁ⩃", a_));
				num = (short)660078596;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004898 File Offset: 0x00002A98
		private void a()
		{
			int a_ = 7;
			short num = (short)837943296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				global::System.Collections.Generic.Dictionary<string, string> dictionary;
				global::System.Collections.Generic.Dictionary<string, string> dictionary2;
				global::AcpModelTieringLib.ExpEvaluator expEvaluator;
				for (;;)
				{
					IL_30:
					num = (short)980484096;
					short num3 = num;
					global::System.Collections.IEnumerator enumerator;
					global::System.Xml.XmlNodeList xmlNodeList;
					switch (num2)
					{
					case 0:
					{
						try
						{
							num = (short)1660813314;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Xml.XmlNode xmlNode;
								switch (num2)
								{
								case 0:
									num = (short)1821507587;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)1884946432;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_84C;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_58C;
									}
									continue;
								case 3:
									goto IL_8CD;
								case 4:
									try
									{
										num = (short)1160511493;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("\udbb5\ud9b7쪹", a_)].Value != null)
												{
													num = (short)644677634;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_73E;
											case 1:
												goto IL_7BA;
											case 2:
												num = (short)715522051;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("\udbb5\ud9b7쪹", a_)].Value.Trim().Length == 0)
												{
													num = (short)92143620;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												dictionary.Add(xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("\ud8b5\ud9b7ힹ\ud9bb", a_)].Value.ToString(), xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("\udbb5\ud9b7쪹", a_)].Value.ToString());
												num = (short)1652883457;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												goto IL_6E6;
											case 5:
												switch (0)
												{
												case 0:
													goto IL_5DB;
												}
												continue;
											case 6:
												num = (short)1567096839;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("\ud8b5\ud9b7ힹ\ud9bb", a_)].Value.Trim().Length == 0)
												{
													num = (short)688979976;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1209204736;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
												goto IL_685;
											}
											IL_5DB:
											if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("\ud8b5\ud9b7ힹ\ud9bb", a_)].Value == null)
											{
												break;
											}
											num = (short)1491337222;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_614:
										throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("풷펹\uddbb춽곁ꗃꯅ귇귋뫍꓏ꃑ뷓듕귗껙맛ﻝ藟迡铣鋥釧쓩", a_));
										IL_685:
										goto IL_614;
										IL_6E6:
										IL_73E:
										throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("풷펹\uddbb춽꿁ꗃ뛅ꯉ룋뫍ꋏ믑뛓ꏕ곗뿙ﳛ믝跟鋡郣鿥웧", a_));
										IL_7BA:
										break;
									}
									catch (global::System.Exception ex)
									{
										if (!ex.Message.Equals(global::AcpModelTieringLib.ErrorException.b("例\udab7킹\ud9bb\uddbd뒿뛃ꏅ껇꿉뻋ꯍ뻏뇑뇓뛗뗙꣛ﻝ鏟蟡郣웥鳧藩쳫迭黯틱鷳飵请軹鷻都揿朁␃椅渇⨉洋怍』紑瘓簕紗礙栛〝", a_)))
										{
											num = (short)1564011477;
											short num4 = num;
											num = (short)354413525;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												num = (short)1385234432;
												if (num != 0)
												{
												}
												throw new global::System.Exception(ex.Message);
											}
										}
										throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("풷펹\uddbb춽뛁ꗃꇅꋋ꿍뷏럑맕꫗龎뇛뿝郟싡藣鋥鳧飩藫賭藯蛱釳훵雷闹裻\udefd替洁焃栅氇␉", a_));
									}
									goto IL_84C;
								}
								goto IL_58C;
								IL_84C:
								xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
								num = (short)1250099204;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_876:
								num = (short)356712449;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_58C:
								goto IL_876;
							}
							IL_8CD:;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_8EC;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_8D9:
								switch (num2)
								{
								case 0:
									goto IL_944;
								case 1:
									if (disposable != null)
									{
										num = (short)1718484994;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_946;
								case 2:
									disposable.Dispose();
									num = (short)1232535552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_8EC;
							}
							IL_944:
							IL_946:
							goto EndFinally_26;
							IL_8EC:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1241251841;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_8D9;
							EndFinally_26:;
						}
						dictionary2 = new global::System.Collections.Generic.Dictionary<string, string>(dictionary);
						global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator2 = dictionary.GetEnumerator();
						num = (short)1493172226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						xmlNodeList = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("馵쪷햹펻쪽迁ꯃꋅ귇ꛉ飋ꟍ뗏ꃑ뷓룕뿗鳙뗛닝藟췡ꗣ諥臧诩鿫ꏭ釯英\udbf3럵铷鏹鷻跽", a_));
						if (xmlNodeList.Count == 0)
						{
							goto Block_1;
						}
						goto IL_369;
					case 2:
					{
						global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator2;
						try
						{
							num = (short)858718210;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator3;
								global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair2;
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)629276675;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												if (!enumerator3.MoveNext())
												{
													num = (short)1093009409;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator3.Current;
												num = (short)1943404548;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												num = (short)1501429765;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_1E8;
												}
												continue;
											case 4:
											{
												global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
												if (keyValuePair2.Value.Contains(keyValuePair.Key))
												{
													num = (short)1371406342;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
												goto IL_2FC;
											case 6:
											{
												global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
												dictionary2[keyValuePair2.Key] = dictionary2[keyValuePair2.Key].Replace(keyValuePair.Key, global::AcpModelTieringLib.ErrorException.b("麵", a_) + keyValuePair.Value + global::AcpModelTieringLib.ErrorException.b("龵", a_));
												num = (short)1845297154;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_2A4:
											num = (short)1355481088;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1E8:
											goto IL_2A4;
										}
										IL_2FC:
										break;
									}
									finally
									{
										((global::System.IDisposable)enumerator3).Dispose();
									}
									goto IL_30F;
								case 1:
									num = (short)362479619;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_163;
									}
									continue;
								case 3:
									goto IL_356;
								case 4:
									if (!enumerator2.MoveNext())
									{
										num = (short)2001207297;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_30F;
								}
								IL_168:
								num = (short)838860804;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_163:
								goto IL_168;
								IL_30F:
								keyValuePair2 = enumerator2.Current;
								enumerator3 = dictionary.GetEnumerator();
								num = (short)575995904;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_356:
							goto IL_C5;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_369;
						IL_C5:
						((global::AcpModelTieringLib.ExpParser)expEvaluator._exp_parser).AllOptions = this.d;
						enumerator2 = dictionary2.GetEnumerator();
						num = (short)297336835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_FC;
					}
					goto IL_70;
					IL_369:
					enumerator = xmlNodeList.GetEnumerator();
					num = (short)402587648;
					num2 = (int)((global::System.IntPtr)num);
				}
				Block_1:
				goto IL_53E;
				IL_FC:
				num = (short)1479868417;
				if (num != 0)
				{
				}
				try
				{
					num = (short)276889604;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair3;
							this.d[keyValuePair3.Key.ToUpper()] = expEvaluator.a();
							num = (short)1321402370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair3;
							if (this.d.ContainsKey(keyValuePair3.Key.ToUpper()))
							{
								num = (short)281346049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.d.Add(keyValuePair3.Key.ToUpper(), expEvaluator.a());
							num = (short)1427177472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_3D2;
							}
							continue;
						case 5:
						{
							global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator2;
							if (!enumerator2.MoveNext())
							{
								num = (short)2028077063;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair3 = enumerator2.Current;
							expEvaluator.a(keyValuePair3.Value.Replace(global::AcpModelTieringLib.ErrorException.b("銵鲷", a_), global::AcpModelTieringLib.ErrorException.b("邵麷", a_)).ToUpper());
							num = (short)722731011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_52B;
						case 7:
							num = (short)946274310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_3D7:
						num = (short)1174929413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3D2:
						goto IL_3D7;
					}
					IL_52B:
					return;
				}
				finally
				{
					global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator2;
					((global::System.IDisposable)enumerator2).Dispose();
				}
				IL_53E:
				throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("ힷ骹ﶻ튽ꦿꏁ럃ꛇꗉ꣋ꯍꏏ닓맕귗듙룛", a_));
				IL_70:
				dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
				dictionary2 = new global::System.Collections.Generic.Dictionary<string, string>();
				expEvaluator = new global::AcpModelTieringLib.ExpEvaluator(new global::AcpModelTieringLib.ExpParser());
				num = (short)85131265;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00005298 File Offset: 0x00003498
		public bool IsModelNumberValid(string strModelNumber)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_CE;
				case 1:
					if (this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("邾돀곂꫄돆蛊ꋌꯎ듐뿒臔뻖볘꧚드뇞蛠ꗢ賤详賨쓪뻬髮臰菲髴藶跸黺駼럾一猂焄渆昈攊縌‎䌐爒焔縖瘘崚簜爞䠠伢尤ࠦ搨䐪䤬䨮崰䀲ᨴ稶嘸强堼匾ᩀ͂⭄♆⑈⹊灌桎", a_) + strModelNumber + global::AcpModelTieringLib.ErrorException.b("颾鳀", a_)).Count == 0)
					{
						num2 = (short)581238787;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = true;
					num2 = (short)1679818752;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)513802241;
					if (num2 != 0)
					{
					}
					result = false;
					num2 = (short)1677262848;
					short num3 = num2;
					num2 = (short)1397817346;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_29;
			}
			IL_CE:
			num2 = (short)1142287898;
			short num4 = num2;
			num2 = (short)2117922330;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_29:
				result = true;
				num2 = (short)347996161;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
				num2 = (short)949092352;
				if (num2 != 0)
				{
				}
				break;
			}
			return result;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00005408 File Offset: 0x00003608
		public string GetModelNumberType(string strModelNumber)
		{
			int a_ = 14;
			short num = (short)1590493184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::System.Xml.XmlNodeList xmlNodeList;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_455;
					case 1:
					{
						if (xmlNodeList.Count > 1)
						{
							num = (short)2099118080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
						num = (short)17956867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (xmlNodeList.Count == 0)
						{
							num = (short)1410859008;
							short num3 = num;
							num = (short)372375556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)380829697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_478;
					case 4:
						goto IL_108;
					}
					goto IL_4B;
				}
				IL_108:
				throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("謁\udabe뗀軂꫄ꏆ곈ꟊ菌뫎볐뇒냔ꗖ跘ꋚ규뫞쇠蟢賤菦짨藪苬鯮퇰闲鳴駶鷸\udbfa觼韾搀⌂眄戆砈縊栌簎攐瘒焔㜖琘琚礜稞䴠̢䬤刦䐨䤪䠬崮ἰ", a_));
				IL_3F3:
				throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("謁\udabe뗀軂꫄ꏆ곈ꟊ菌뫎볐뇒냔ꗖ跘ꋚ규뫞쇠藢諤鋦蟨迪췬苮黰臲郴ퟶ跸鏺鳼釾℀氂欄戆⤈戊挌簎攐爒笔琖簘㬚爜礞Ġ圢䴤䈦न太䠬帮䐰嘲䘴䌶尸强ᴼ刾⹀❂⁄⭆楈╊㡌≎㍐㙒❔祖", a_));
				IL_455:
				goto IL_3F3;
				IL_478:
				string result;
				try
				{
					num = (short)801832962;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						global::System.Xml.XmlNode xmlNode;
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1120665602;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_266;
									case 1:
										if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("즼욾뇀ꛂ", a_)].Value.Trim().Length == 0)
										{
											num = (short)1741619200;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										result = xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("즼욾뇀ꛂ", a_)].Value;
										num = (short)499056643;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1C1;
										}
										continue;
									case 3:
										goto IL_29F;
									case 4:
										num = (short)1156055041;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1C1:
									if (xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("즼욾뇀ꛂ", a_)].Value == null)
									{
										break;
									}
									num = (short)1215692804;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1F9:
								throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("謁\udabe뗀軂꫄ꏆ곈ꟊ菌뫎볐뇒냔ꗖ跘ꋚ규뫞\udbe0쏢꣤裦跨軪臬쿮뿰蛲飴闶鳸觺\uddfc课砀猂怄✆栈缊礌紎砐焒怔挖簘㬚欜縞䴠嘢䀤ܦ䀨堪ബ䄮䐰弲头᜶嘸䤺ᴼ娾ⱀ㍂ㅄ㹆杈", a_));
								IL_266:
								goto IL_1F9;
								IL_29F:
								break;
							}
							catch (global::System.Exception ex)
							{
								if (!ex.Message.Equals(global::AcpModelTieringLib.ErrorException.b("\uddbeꯀꛂꛄ돆맊꣌꧎듐ꇒ냔맖뫘뻚﷜뇞軠韢엤铦賨鿪췬鯮黰폲铴駶\ud9f8鋺鏼賾甀戂欄搆氈⬊戌椎ㄐ爒笔㜖瘘礚眜稞䈠圢ତ", a_)))
								{
									num = (short)581841463;
									short num4 = num;
									num = (short)1751396919;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)93126656;
										if (num != 0)
										{
										}
										throw new global::System.Exception(ex.Message);
									}
								}
								throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("謁\udabe뗀軂꫄ꏆ곈ꟊ菌뫎볐뇒냔ꗖ跘ꋚ규뫞\udbe0쏢꣤裦跨軪臬쿮鿰蛲飴闶鳸觺\uddfc裾栀眂洄✆搈戊縌簎砐紒爔㜖洘戚洜稞Ġ䈢儤匦嬨䈪伬娮䔰嘲᬴", a_));
							}
							goto IL_332;
						case 1:
							num = (short)716439555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_147;
							}
							continue;
						case 3:
							goto IL_375;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)25165825;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_332;
						}
						IL_14C:
						num = (short)804061188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_147:
						goto IL_14C;
						IL_332:
						xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
						num = (short)1867382784;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_375:
					return result;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_397;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_384:
						switch (num2)
						{
						case 0:
							goto IL_3F0;
						case 1:
							if (disposable != null)
							{
								num = (short)1438187522;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3F2;
						case 2:
							disposable.Dispose();
							num = (short)2112159744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_397;
					}
					IL_3F0:
					IL_3F2:
					goto EndFinally_11;
					IL_397:
					global::System.Collections.IEnumerator enumerator;
					disposable = (enumerator as global::System.IDisposable);
					num = (short)386203649;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_384;
					EndFinally_11:;
				}
				goto IL_3F3;
				IL_4B:
				num = (short)2111635457;
				if (num != 0)
				{
				}
				result = null;
				xmlNodeList = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("銼춾껀곂뇄蓈꓊꧌꫎뷐蟒볔닖ꯘ닚돜룞꟠諢觤苦웨룪飬鿮臰鳲蟴菶鳸鿺뗼냾焀眂氄栆月砊∌崎瀐眒簔砖弘稚瀜瘞䴠娢ਤ樦䘨伪䠬䌮䈰ᰲ破堶崸帺儼搾ŀⵂ⑄⩆ⱈ癊橌", a_) + strModelNumber + global::AcpModelTieringLib.ErrorException.b("骼", a_));
				num = (short)1871052802;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000058C8 File Offset: 0x00003AC8
		public bool IsOptionAvailableForModel(string strModelNumber, string strOptionName)
		{
			int a_ = 14;
			short num = (short)635109376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool flag = false;
				global::System.Xml.XmlNodeList xmlNodeList = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("銼춾껀곂뇄蓈꓊꧌꫎뷐蟒볔닖ꯘ닚돜룞꟠諢觤苦웨룪飬鿮臰鳲蟴菶鳸鿺뗼냾焀眂氄栆月砊∌崎瀐眒簔砖弘稚瀜瘞䴠娢", a_));
				if (xmlNodeList.Count == 0)
				{
					throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("튾뇀럂별髈뻊뷌뿎뻐ꇒꇔ닖뷘鏚鋜꿞闠諢諤触髨쯪맬軮雰\udff2헴髶郸裺軼雾漀搂┄唆栈漊搌怎圐爒研縖甘戚㴜欞䀠䐢嘤द", a_));
				}
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
					try
					{
						num = (short)112656390;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							bool flag2;
							global::System.Xml.XmlNode xmlNode2;
							switch (num2)
							{
							case 0:
								try
								{
									num = (short)1422786576;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_2F9;
										case 1:
										{
											global::System.Xml.XmlNode xmlNode;
											if (!xmlNode.Name.Equals(global::AcpModelTieringLib.ErrorException.b("쾾뗀ꫂ꫄꧆뫈", a_)))
											{
												num = (short)323551232;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 2:
											flag = false;
											num = (short)382337037;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											if (flag2)
											{
												num = (short)78512147;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 4:
										{
											global::System.Xml.XmlNodeList xmlNodeList2;
											if (xmlNodeList2.Count == 0)
											{
												num = (short)1352597521;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_247;
										}
										case 5:
											goto IL_3CF;
										case 6:
											goto IL_247;
										case 7:
										{
											global::System.Collections.IEnumerator enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)2147090446;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator2.Current;
											num = (short)1590427660;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 8:
											if (flag)
											{
												num = (short)1961951242;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 9:
											if (this.c.SelectNodes(string.Concat(new string[]
											{
												global::AcpModelTieringLib.ErrorException.b("銼춾껀곂뇄蓈꓊꧌꫎뷐蟒볔닖ꯘ닚돜룞꟠諢觤苦웨룪飬鿮臰鳲蟴菶鳸鿺뗼냾焀眂氄栆月砊∌崎瀐眒簔砖弘稚瀜瘞䴠娢縤朦䜨䨪䀬䨮రᐲ", a_),
												xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("펼\udebe곀ꛂ", a_)].Value.ToString(),
												global::AcpModelTieringLib.ErrorException.b("骼賂뗄돆ꃈ꓊ꏌ볎ﻐ鳒ꗔꏖ냘듚돜蓞ꇠ跢蓤諦賨훪쫬", a_),
												strOptionName,
												global::AcpModelTieringLib.ErrorException.b("骼", a_)
											})).Count == 0)
											{
												num = (short)1273626626;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											flag = true;
											num = (short)1240989701;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 10:
											num = (short)1792016395;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 11:
											goto IL_65A;
										case 12:
										{
											global::System.Xml.XmlNode xmlNode;
											if (xmlNode.Name.Equals(global::AcpModelTieringLib.ErrorException.b("킾ꗀꛂ꧄듆", a_)))
											{
												num = (short)616824847;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1378156545;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 13:
											goto IL_3CF;
										case 14:
											num = (short)614924306;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 15:
											try
											{
												num = (short)325058564;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														num = (short)1834680323;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 1:
														goto IL_59C;
													case 2:
														goto IL_4F9;
													case 3:
													{
														if (xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("펼\udebe곀ꛂ", a_)].Value.Trim().Length == 0)
														{
															num = (short)1952710658;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														global::System.Xml.XmlNodeList xmlNodeList2 = this.c.SelectNodes(string.Concat(new string[]
														{
															global::AcpModelTieringLib.ErrorException.b("銼춾껀곂뇄蓈꓊꧌꫎뷐蟒볔닖ꯘ닚돜룞꟠諢觤苦웨룪飬鿮臰鳲蟴菶鳸鿺뗼냾焀眂氄栆月砊∌崎瀐眒簔砖弘稚瀜瘞䴠娢縤朦䜨䨪䀬䨮రᐲ", a_),
															xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("펼\udebe곀ꛂ", a_)].Value.ToString(),
															global::AcpModelTieringLib.ErrorException.b("骼軂꫄ꏆ곈ꟊ뻌鳐볒뇔닖뗘胚鷜뇞胠転胤\udae6컨", a_),
															strModelNumber,
															global::AcpModelTieringLib.ErrorException.b("骼", a_)
														}));
														num = (short)627572737;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 4:
														switch (0)
														{
														case 0:
															goto IL_467;
														}
														continue;
													}
													IL_467:
													if (xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("펼\udebe곀ꛂ", a_)].Value == null)
													{
														break;
													}
													num = (short)749600768;
													num2 = (int)((global::System.IntPtr)num);
												}
												IL_4F9:
												throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("\udebeꗀꫂ꫄迈꫊ꃌꛎ뷐꫒맖뛘뿚룜￞雠諢釤迦짨諪菬쿮铰黲藴菶胸\udbfa鏼黾氀昂┄昆紈缊缌明猐昒愔爖㜘", a_));
												IL_59C:
												goto IL_209;
											}
											catch (global::System.Exception ex)
											{
												if (ex.Message.Equals(global::AcpModelTieringLib.ErrorException.b("\uddbeꯀꛂꛄ돆맊꣌꧎듐ꇒ냔맖뫘뻚﷜뇞軠韢엤铦賨鿪췬鯮黰폲铴駶\ud9f8鋺鏼賾甀戂欄搆氈⬊戌椎ㄐ爒笔㜖瘘礚眜稞䈠圢ତ", a_)))
												{
													throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("\udebeꗀꫂ꫄臆꣈ꛊ꓌ꏎ꣐뫔ꗖ律雚닜믞蓠迢엤鏦裨質쇬쿮鿰鋲飴鋶\ud9f8髺觼课猀樂朄爆紈渊ⴌ愎縐朒㔔焖瘘渚猜笞༠", a_));
												}
												throw new global::System.Exception(ex.Message);
											}
											break;
											IL_209:
											num = (short)146800644;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 16:
											switch (0)
											{
											case 0:
												goto IL_1A3;
											}
											continue;
										case 17:
											flag2 = false;
											num = (short)544735238;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 18:
											goto IL_678;
										case 19:
											num = (short)487784457;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1A3;
										IL_247:
										num = (short)1521942531;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_3CF:
										num = (short)592248840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_5E2:
										num = (short)1822621703;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_1A3:
										goto IL_5E2;
									}
									IL_2F9:
									throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("톾ꫀ귂꫄냆ꟈꏌꃎ뗐뛒맖룘뛚룜쇠鏢韤裦諨軪黬鳮飰鷲鋴ퟶ꯸髺駼雾渀⌂䌄昆搈戊愌瘎ㄐ紒稔猖簘栚✜㼞", a_) + xmlNode2.Name.ToString());
									IL_65A:
									IL_678:
									goto IL_B9;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_69A;
									}
									global::System.IDisposable disposable;
									for (;;)
									{
										IL_687:
										switch (num2)
										{
										case 0:
											goto IL_6F0;
										case 1:
											disposable.Dispose();
											num = (short)248381440;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											if (disposable != null)
											{
												num = (short)551288833;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_6F2;
										}
										goto IL_69A;
									}
									IL_6F0:
									IL_6F2:
									goto EndFinally_22;
									IL_69A:
									global::System.Collections.IEnumerator enumerator2;
									disposable = (enumerator2 as global::System.IDisposable);
									num = (short)1864433666;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_687;
									EndFinally_22:;
								}
								goto IL_6F3;
								IL_B9:
								num = (short)1759969281;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (flag)
								{
									num = (short)1076101127;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 2:
								num = (short)1773797384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_75F;
							case 4:
							{
								if (xmlNode2.ChildNodes.Count == 0)
								{
									num = (short)1999634437;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.IEnumerator enumerator2 = xmlNode2.ChildNodes.GetEnumerator();
								num = (short)279379968;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_742;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_A0;
								}
								continue;
							case 7:
								num = (short)30867459;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_7A9;
							case 9:
								if (!enumerator.MoveNext())
								{
									num = (short)108658690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6F3;
							}
							IL_ED:
							num = (short)2104295433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A0:
							goto IL_ED;
							IL_6F3:
							xmlNode2 = (global::System.Xml.XmlNode)enumerator.Current;
							flag2 = true;
							num = (short)2093416452;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_742:
						throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("튾뇀럂별鯈꫊꧌ꛎ뻐鏔뛖듘닚뇜ꛞ쇠跢諤菦賨엪", a_));
						IL_75F:
						IL_7A9:
						break;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_7CB;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_7B8:
							switch (num2)
							{
							case 0:
								goto IL_871;
							case 1:
								disposable.Dispose();
								num = (short)1860042752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_833;
							}
							goto IL_7CB;
						}
						IL_833:
						if (disposable != null)
						{
							goto IL_837;
						}
						IL_871:
						continue;
						IL_7CB:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1655583453;
						short num3 = num;
						num = (short)1947349725;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_837:
							num = (short)651821057;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_7B8;
						default:
							num = (short)1693253632;
							if (num != 0)
							{
							}
							num = (short)2024013826;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_7B8;
						}
					}
				}
				num = (short)410320897;
				if (num != 0)
				{
				}
				num = (short)890306560;
				short num4 = num;
				return flag;
			}
			}
		}

		// Token: 0x04000003 RID: 3
		private global::System.Collections.Generic.List<string> a;

		// Token: 0x04000004 RID: 4
		private global::System.Collections.Generic.List<string> b;

		// Token: 0x04000005 RID: 5
		private global::System.Xml.XmlDocument c;

		// Token: 0x04000006 RID: 6
		private global::System.Collections.Generic.Dictionary<string, bool> d;

		// Token: 0x04000007 RID: 7
		private global::AcpModelTieringLib.CModelTieringData e;

		// Token: 0x04000008 RID: 8
		private string f;

		// Token: 0x04000009 RID: 9
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string[]>> g;
	}
}
