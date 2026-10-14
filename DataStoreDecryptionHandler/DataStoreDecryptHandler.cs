using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO.Pem;

namespace SSLAdminTool
{
	// Token: 0x02000003 RID: 3
	public sealed class DataStoreDecryptHandler : global::SSLAdminTool.IDataStoreDecryptHandler
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public DataStoreDecryptHandler(int dhCertainty = 112, int dhLength = 2048)
		{
			int a_ = 13;
			this.w = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData) + global::SSLAdminTool.RawData.b("裓鯕럗껙돛곝迟軡藣뫥ꧧ룩뿫ꫭ釯蛱闳럵鳷韹闻都峿䘁攃爅椇⨉缋稍缏怑焓䨕夗䠙伛娝䄟嘡䔣ࠥ倧䜩䀫", a_);
			this.x = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData) + global::SSLAdminTool.RawData.b("裓鯕럗껙돛곝迟軡藣뫥ꧧ룩뿫ꫭ釯蛱闳럵鳷韹闻都峿企欃爅朇砉挋戍焏㈑倓猕縗笙椛爝吟ȡ朣䌥娧帩䔫䠭夯儱唳䈵崷昹堻嘽〿⍁㙃❅╇摉㱋⭍㵏", a_);
			base..ctor();
			this.y = dhLength;
			this.z = dhCertainty;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002188 File Offset: 0x00000388
		public bool XStoreAvailable
		{
			get
			{
				short num = (short)1752170496;
				short num2 = num;
				num = (short)615304176;
				short num3 = num;
				num = (short)186043376;
				switch (num3 == num)
				{
				}
				num = (short)1142882305;
				if (num != 0)
				{
				}
				num = (short)1967718400;
				if (num != 0)
				{
				}
				return global::System.IO.File.Exists(this.w);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000223C File Offset: 0x0000043C
		public bool IsXStoreValid()
		{
			short num = (short)1649811179;
			short num2 = num;
			num = (short)1273044715;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1675296769;
				if (num != 0)
				{
				}
				num = (short)961740800;
				short num3 = num;
				num = (short)1815281664;
				if (num != 0)
				{
				}
				result = true;
				try
				{
					this.XStoreRead();
				}
				catch
				{
					result = false;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002308 File Offset: 0x00000508
		public global::System.Collections.Generic.List<global::SSLAdminTool.PNServer> XStoreRead()
		{
			int a_ = 17;
			short num = (short)1482162176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				global::System.Xml.Linq.XDocument xdocument;
				string text2;
				global::System.Collections.Generic.List<global::SSLAdminTool.PNServer> list;
				bool flag;
				global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
				for (;;)
				{
					IL_32:
					string text;
					switch (num2)
					{
					case 0:
					{
						num = (short)1403060224;
						short num3 = num;
						if (!xdocument.ToString().Contains(global::SSLAdminTool.RawData.b("賙맛곝鏟诡诣裥훧", a_)))
						{
							num = (short)57278474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)647430145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Xml.Linq.XElement xelement = xdocument.Element(global::SSLAdminTool.RawData.b("軗뿙껛귝觟跡諣", a_));
						if (xelement == null)
						{
							num = (short)398721028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = xelement.Value;
						goto IL_2FE;
					}
					case 2:
						goto IL_24B;
					case 3:
						goto IL_159;
					case 4:
						text = null;
						goto IL_2FE;
					case 5:
						xdocument.Element(global::SSLAdminTool.RawData.b("軗뿙껛귝觟跡諣", a_)).Value = text2;
						num = (short)1879638028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (xdocument != null)
						{
							num = (short)1513488391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 7:
						num = (short)1816395784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!xdocument.ToString().Contains(global::SSLAdminTool.RawData.b("裙맛뷝迟郡胣닥釧髩觫탭", a_)))
						{
							num = (short)1409482761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_159;
					case 9:
						flag = true;
						num = (short)272629761;
						if (num != 0)
						{
						}
						num = (short)1298792451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						xdocument.Root.Add(new global::System.Xml.Linq.XElement(global::SSLAdminTool.RawData.b("軗뿙껛귝觟跡諣", a_), text2));
						num = (short)2044657675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_20C;
					case 12:
						goto IL_20C;
					}
					goto IL_6D;
					IL_159:
					num = (short)419954688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20C:
					enumerator = xdocument.Elements(global::SSLAdminTool.RawData.b("诗뿙껛꣝藟郡韣", a_)).Elements<global::System.Xml.Linq.XElement>().GetEnumerator();
					num = (short)635174914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FE:
					if (!(text != text2))
					{
						goto IL_20C;
					}
					num = (short)1198063621;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_24B:
				try
				{
					num = (short)967114769;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::SSLAdminTool.PNServer pnserver2;
						string text3;
						ushort portNum;
						switch (num2)
						{
						case 0:
							if (flag)
							{
								num = (short)2079457283;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2049835012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::SSLAdminTool.PNServer pnserver = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement2 = xelement3.Element(global::SSLAdminTool.RawData.b("釗韙诛鏝闟軡郣迥꿧飩菫鯭胯ꋱ鯳蓵賷", a_));
							pnserver.IMWMGMPort = ((xelement2 != null) ? xelement2.Value : null);
							num = (short)1058930720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::SSLAdminTool.PNServer pnserver3 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement4 = xelement3.Element(global::SSLAdminTool.RawData.b("釗韙诛針ꇟ韡郣軥ꯧ蛩藫语黯蛱뷳답", a_));
							pnserver3.IMWOAuthCID = ((xelement4 != null) ? xelement4.Value : null);
							num = (short)1042022409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							pnserver2.RecType = global::SSLAdminTool.RecordType.UNS;
							num = (short)1019543566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::SSLAdminTool.PNServer pnserver4 = pnserver2;
							global::System.Type typeFromHandle = typeof(global::SSLAdminTool.RecordType);
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement5 = xelement3.Element(global::SSLAdminTool.RawData.b("諗뿙뿛뇝鋟蛡냣鿥飧迩", a_));
							pnserver4.RecType = (global::SSLAdminTool.RecordType)global::System.Enum.Parse(typeFromHandle, (xelement5 != null) ? xelement5.Value : null);
							num = (short)1618214937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::SSLAdminTool.PNServer pnserver5 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement6 = xelement3.Element(global::SSLAdminTool.RawData.b("釗韙诛針ꇟ韡郣軥ꃧ藩鿫髭黯鏱駳鏵", a_));
							pnserver5.IMWOAuthHostname = ((xelement6 != null) ? xelement6.Value : null);
							num = (short)398327837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							text3 = null;
							goto IL_664;
						case 7:
						{
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement7 = xelement3.Element(global::SSLAdminTool.RawData.b("裗뗙껛ꫝ껟韡解蓥跧飩", a_));
							if (xelement7 == null)
							{
								num = (short)2001338374;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text3 = xelement7.Value;
							goto IL_664;
						}
						case 8:
							pnserver2 = new global::SSLAdminTool.PNServer();
							num = (short)1093468188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							global::SSLAdminTool.PNServer pnserver6 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement8 = xelement3.Element(global::SSLAdminTool.RawData.b("釗韙诛針ꇟ韡郣軥ꯧ蛩藫语黯蛱ꟳ鏵鯷裹駻諽", a_));
							pnserver6.IMWOAuthCSec = ((xelement8 != null) ? xelement8.Value : null);
							num = (short)508624906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_B94;
						case 11:
							num = (short)145227797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							global::SSLAdminTool.PNServer pnserver7 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement9 = xelement3.Element(global::SSLAdminTool.RawData.b("鯗뗙닛냝듟鯡铣菥믧迩迫鯭苯韱", a_));
							pnserver7.SecureConn = bool.Parse((xelement9 != null) ? xelement9.Value : null);
							portNum = 0;
							num = (short)2023424007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							global::System.Xml.Linq.XElement xelement3;
							if (!xelement3.ToString().Contains(global::SSLAdminTool.RawData.b("賙맛곝鏟诡诣裥훧", a_)))
							{
								num = (short)109248520;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 14:
							goto IL_B94;
						case 15:
						{
							global::SSLAdminTool.PNServer pnserver8 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement10 = xelement3.Element(global::SSLAdminTool.RawData.b("鯗동곛뛝藟郡럣鏥臧黩觫", a_));
							pnserver8.CipherSuite = ((xelement10 != null) ? xelement10.Value : null);
							num = (short)1356857367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
						{
							global::SSLAdminTool.PNServer pnserver9 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement11 = xelement3.Element(global::SSLAdminTool.RawData.b("诗뿙껛꣝藟郡귣뛥", a_));
							pnserver9.PNServerIP = global::System.Net.IPAddress.Parse((xelement11 != null) ? xelement11.Value : null);
							num = (short)317980702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							switch (0)
							{
							case 0:
								goto IL_3D4;
							}
							continue;
						case 18:
						{
							global::SSLAdminTool.PNServer pnserver10 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement12 = xelement3.Element(global::SSLAdminTool.RawData.b("郗뗙꿛ꫝ軟菡解菥", a_));
							pnserver10.Hostname = ((xelement12 != null) ? xelement12.Value : null);
							num = (short)153944095;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
						{
							global::SSLAdminTool.PNServer pnserver11 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement13 = xelement3.Element(global::SSLAdminTool.RawData.b("釗韙诛雝迟釡郣裥觧蟩觫", a_));
							pnserver11.IMWHostname = ((xelement13 != null) ? xelement13.Value : null);
							num = (short)1848508421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
						{
							global::SSLAdminTool.PNServer pnserver12 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement14 = xelement3.Element(global::SSLAdminTool.RawData.b("鯗뛙뗛믝軟雡꟣菥髧黩뻫迭蟯뛱闳苵駷", a_));
							pnserver12.ClientCert = ((xelement14 != null) ? xelement14.Value : null);
							pnserver2.PNSIp1 = pnserver2.PNServerIP.GetAddressBytes().ElementAt(0).ToString();
							pnserver2.PNSIp2 = pnserver2.PNServerIP.GetAddressBytes().ElementAt(1).ToString();
							pnserver2.PNSIp3 = pnserver2.PNServerIP.GetAddressBytes().ElementAt(2).ToString();
							pnserver2.PNSIp4 = pnserver2.PNServerIP.GetAddressBytes().ElementAt(3).ToString();
							num = (short)599982080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							goto IL_C5B;
						case 22:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)170917899;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.Linq.XElement xelement3 = enumerator.Current;
							num = (short)1833238541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
						{
							global::SSLAdminTool.PNServer pnserver13 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement15 = xelement3.Element(global::SSLAdminTool.RawData.b("鯗뗙닛냝듟鯡铣菥뷧껩볫", a_));
							pnserver13.UDPConn = bool.Parse((xelement15 != null) ? xelement15.Value : null);
							num = (short)1477115916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
						{
							global::SSLAdminTool.PNServer pnserver14 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement16 = xelement3.Element(global::SSLAdminTool.RawData.b("釗韙诛雝迟釡郣裥觧蟩觫", a_));
							string str = (xelement16 != null) ? xelement16.Value : null;
							string str2 = global::SSLAdminTool.RawData.b("龎", a_);
							global::System.Xml.Linq.XElement xelement17 = xelement3.Element(global::SSLAdminTool.RawData.b("釗韙诛針ꇟ韡郣軥ꃧ藩鿫髭黯鏱駳鏵", a_));
							pnserver14.Hostname = str + str2 + ((xelement17 != null) ? xelement17.Value : null);
							num = (short)984678419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							if (pnserver2.RecType == global::SSLAdminTool.RecordType.IMW)
							{
								num = (short)1025376289;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1202782226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
						{
							num = (short)860909798;
							short num4 = num;
							num = (short)638939366;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_B94;
							default:
								num = (short)712966144;
								if (num != 0)
								{
								}
								break;
							}
							break;
						}
						case 27:
						{
							global::SSLAdminTool.PNServer pnserver15 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement18 = xelement3.Element(global::SSLAdminTool.RawData.b("鯗鯙鿛믝鋟雡뛣蟥鿧껩跫髭釯", a_));
							pnserver15.CACert = ((xelement18 != null) ? xelement18.Value : null);
							num = (short)1378418708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 28:
						{
							global::SSLAdminTool.PNServer pnserver16 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement19 = xelement3.Element(global::SSLAdminTool.RawData.b("诗뿙껛꣝藟郡ꫣ蟥藧迩", a_));
							pnserver16.PNSName = ((xelement19 != null) ? xelement19.Value : null);
							num = (short)1961492496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 29:
						{
							global::SSLAdminTool.PNServer pnserver17 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement20 = xelement3.Element(global::SSLAdminTool.RawData.b("釗韙诛軝迟郡郣", a_));
							pnserver17.IMWPort = ((xelement20 != null) ? xelement20.Value : null);
							num = (short)252575745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
						{
							global::SSLAdminTool.PNServer pnserver18 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement21 = xelement3.Element(global::SSLAdminTool.RawData.b("裗믙꿛귝韟跡難뛥胧飩跫鷭闯", a_));
							pnserver18.PassWordPhrase = ((xelement21 != null) ? xelement21.Value : null);
							num = (short)279773199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 31:
							goto IL_B94;
						case 32:
						{
							global::SSLAdminTool.PNServer pnserver19 = pnserver2;
							global::System.Xml.Linq.XElement xelement3;
							global::System.Xml.Linq.XElement xelement22 = xelement3.Element(global::SSLAdminTool.RawData.b("釗韙诛針ꇟ韡郣軥룧藩黫髭", a_));
							pnserver19.IMWOAuthPort = ((xelement22 != null) ? xelement22.Value : null);
							num = (short)1911160834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 33:
							num = (short)1143144472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D4;
						IL_664:
						ushort.TryParse(text3, out portNum);
						pnserver2.PortNum = portNum;
						num = (short)856752155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B94:
						list.Add(pnserver2);
						num = (short)500826138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C02:
						num = (short)1425997846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3D4:
						goto IL_C02;
					}
					IL_C5B:;
				}
				finally
				{
					num = (short)579141633;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1078722562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_C90;
							}
							continue;
						case 2:
							goto IL_CC7;
						}
						IL_C90:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1349910528;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_CC7:;
				}
				return list;
				IL_6D:
				list = new global::System.Collections.Generic.List<global::SSLAdminTool.PNServer>();
				xdocument = this.dataStoreDecryption();
				flag = false;
				text2 = global::System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
				num = (short)768212998;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002FFC File Offset: 0x000011FC
		public string PatDataStoreRead()
		{
			short num = (short)1294090951;
			short num2 = num;
			num = (short)1978483399;
			switch (num2 == num)
			{
			}
			num = (short)1464532992;
			if (num != 0)
			{
			}
			num = (short)590217217;
			if (num != 0)
			{
			}
			num = (short)2022899712;
			short num3 = num;
			byte[] bytes = this.a();
			return global::System.Text.Encoding.ASCII.GetString(bytes);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000030BC File Offset: 0x000012BC
		public global::System.Xml.Linq.XDocument dataStoreDecryption()
		{
			short num = (short)756218224;
			short num2 = num;
			num = (short)1496250736;
			global::System.Xml.Linq.XDocument result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)801701888;
				if (num != 0)
				{
				}
				num = (short)385089537;
				if (num != 0)
				{
				}
				result = new global::System.Xml.Linq.XDocument();
				try
				{
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(this.a());
					result = global::System.Xml.Linq.XDocument.Load(global::System.Xml.XmlReader.Create(memoryStream), global::System.Xml.Linq.LoadOptions.None);
					memoryStream.Close();
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				break;
			}
			num = (short)72286208;
			short num3 = num;
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000031A0 File Offset: 0x000013A0
		private byte[] a()
		{
			int a_ = 5;
			short num = (short)1119596271;
			short num2 = num;
			num = (short)1128574703;
			byte[] result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1514602497;
				if (num != 0)
				{
				}
				num = (short)1772617728;
				if (num != 0)
				{
				}
				result = null;
				try
				{
					global::System.IO.FileStream fileStream = new global::System.IO.FileStream(this.w, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					byte[] array = new byte[fileStream.Length];
					fileStream.Read(array, 0, (int)fileStream.Length);
					fileStream.Close();
					result = global::System.Security.Cryptography.ProtectedData.Unprotect(array, global::System.Text.Encoding.UTF8.GetBytes(global::SSLAdminTool.RawData.b("鿋ꯍꋏꓑ뇓ꓕꯗ諙돛곝铟곡釣该諧迩黫", a_)), global::System.Security.Cryptography.DataProtectionScope.LocalMachine);
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				break;
			}
			num = (short)2089156608;
			short num3 = num;
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000032C0 File Offset: 0x000014C0
		public global::SSLAdminTool.RawData GetRawCertData(string SerName)
		{
			int a_ = 6;
			short num = (short)90308608;
			short num2 = num;
			global::SSLAdminTool.RawData rawData = new global::SSLAdminTool.RawData();
			global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator = this.dataStoreDecryption().Elements(global::SSLAdminTool.RawData.b("黌꫎ꏐꗒ냔ꗖ꫘", a_)).Elements<global::System.Xml.Linq.XElement>().GetEnumerator();
			try
			{
				num = (short)1843331082;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num3)
					{
					case 0:
						num = (short)1932525569;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_339;
					case 2:
					{
						global::SSLAdminTool.RawData rawData2 = rawData;
						global::System.Xml.Linq.XElement xelement2;
						global::System.Xml.Linq.XElement xelement = xelement2.Element(global::SSLAdminTool.RawData.b("黌꫎ꏐꗒ냔ꗖ韘뫚냜뫞", a_));
						rawData2.mServerName = ((xelement != null) ? xelement.Value : null);
						num = (short)1489436683;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						text = null;
						goto IL_163;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)614465536;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Xml.Linq.XElement xelement2 = enumerator.Current;
						num = (short)1913585669;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Xml.Linq.XElement xelement2;
						global::System.Xml.Linq.XElement xelement3 = xelement2.Element(global::SSLAdminTool.RawData.b("黌꫎ꏐꗒ냔ꗖ韘뫚냜뫞", a_));
						if (xelement3 != null)
						{
							text = xelement3.Value;
							goto IL_163;
						}
						num = (short)1008232377;
						short num4 = num;
						num = (short)825649081;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)445448192;
							if (num != 0)
							{
							}
							num = (short)2146172931;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						num = (short)1774125064;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::SSLAdminTool.RawData rawData3 = rawData;
						global::System.Xml.Linq.XElement xelement2;
						global::System.Xml.Linq.XElement xelement4 = xelement2.Element(global::SSLAdminTool.RawData.b("軌ꏎ룐뛒믔ꏖ高뻚꿜ꯞ돠苢鋤ꏦ裨鿪賬", a_));
						rawData3.mRawCliCert = ((xelement4 != null) ? xelement4.Value : null);
						num = (short)1927872513;
						if (num != 0)
						{
						}
						num = (short)841941001;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::SSLAdminTool.RawData rawData4 = rawData;
						global::System.Xml.Linq.XElement xelement2;
						global::System.Xml.Linq.XElement xelement5 = xelement2.Element(global::SSLAdminTool.RawData.b("軌軎鋐뛒꟔ꏖ诘뫚ꫜ鯞胠韢蓤", a_));
						rawData4.mRawCACert = ((xelement5 != null) ? xelement5.Value : null);
						num = (short)995819527;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::SSLAdminTool.RawData rawData5 = rawData;
						global::System.Xml.Linq.XElement xelement2;
						global::System.Xml.Linq.XElement xelement6 = xelement2.Element(global::SSLAdminTool.RawData.b("鷌껎ꋐꃒꋔ룖ꯘ诚뗜귞胠郢胤", a_));
						rawData5.mPassPhrase = ((xelement6 != null) ? xelement6.Value : null);
						num = (short)293208066;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						switch (0)
						{
						case 0:
							goto IL_B6;
						}
						continue;
					}
					goto IL_B6;
					IL_163:
					if (text == SerName)
					{
						num = (short)856358918;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2E6:
					num = (short)1088552964;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_B6:
					goto IL_2E6;
				}
				IL_339:;
			}
			finally
			{
				num = (short)613285889;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)951123970;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_36B;
						}
						continue;
					case 2:
						goto IL_39E;
					}
					IL_36B:
					if (enumerator == null)
					{
						break;
					}
					num = (short)2005336064;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_39E:;
			}
			return rawData;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000368C File Offset: 0x0000188C
		public void dhUpdateEventThread()
		{
			int a_ = 17;
			short num = (short)1687289856;
			switch (num)
			{
			default:
			{
				num = (short)619839489;
				if (num != 0)
				{
				}
				global::Org.BouncyCastle.Crypto.Generators.DHParametersGenerator dhparametersGenerator = new global::Org.BouncyCastle.Crypto.Generators.DHParametersGenerator();
				dhparametersGenerator.Init(this.y, this.z, new global::Org.BouncyCastle.Security.SecureRandom());
				global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhparameters = new global::Org.BouncyCastle.Crypto.Parameters.DHParameters(dhparametersGenerator.GenerateParameters().P, global::Org.BouncyCastle.Math.BigInteger.ValueOf(5L));
				byte[] derEncoded = new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1EncodableVector
				{
					new global::Org.BouncyCastle.Asn1.DerInteger(dhparameters.P),
					new global::Org.BouncyCastle.Asn1.DerInteger(dhparameters.G)
				}).GetDerEncoded();
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(this.x);
				fileInfo.IsReadOnly = false;
				fileInfo.CreationTime = global::System.DateTime.Now;
				global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(this.x);
				try
				{
					global::Org.BouncyCastle.Utilities.IO.Pem.PemWriter pemWriter = new global::Org.BouncyCastle.Utilities.IO.Pem.PemWriter(streamWriter);
					global::Org.BouncyCastle.Utilities.IO.Pem.PemObject objGen = new global::Org.BouncyCastle.Utilities.IO.Pem.PemObject(global::SSLAdminTool.RawData.b("鳗鋙ﳛ軝ꇟ냡ꗣꯥ귧뻩ꧫ볭ꏯ", a_), derEncoded);
					pemWriter.WriteObject(objGen);
				}
				finally
				{
					num = (short)478281730;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_170;
						case 1:
							((global::System.IDisposable)streamWriter).Dispose();
							num = (short)1025966080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_136;
							}
							continue;
						}
						IL_136:
						if (streamWriter != null)
						{
							num = (short)987299841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_170:
						num = (short)1109179629;
						short num3 = num;
						num = (short)2125315309;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_136;
						default:
							goto IL_1A4;
						}
					}
					IL_1A4:
					num = (short)52428800;
					if (num != 0)
					{
					}
				}
				num = (short)2076508160;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000388C File Offset: 0x00001A8C
		public bool isDHkeyExpired()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			bool result;
			global::System.IO.FileInfo fileInfo;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2137915392;
					short num3 = num2;
					num2 = (short)380043686;
					short num4 = num2;
					num2 = (short)117834150;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)934281216;
						if (num2 != 0)
						{
						}
						result = true;
						break;
					}
					num2 = (short)410255363;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					global::System.DateTime.Today - fileInfo.CreationTime;
					global::System.TimeSpan timeSpan = global::System.DateTime.Today - fileInfo.CreationTime;
					num2 = (short)1987313666;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)1652031489;
					if (num2 != 0)
					{
					}
					global::System.TimeSpan timeSpan;
					if (timeSpan.Days > 30)
					{
						num2 = (short)1966080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 3:
					return result;
				case 4:
					if (global::System.IO.File.Exists(fileInfo.FullName))
					{
						num2 = (short)158597121;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = false;
			fileInfo = new global::System.IO.FileInfo(this.x);
			num2 = (short)444203012;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000003 RID: 3
		private const string a = "Servers";

		// Token: 0x04000004 RID: 4
		private const string b = "Server";

		// Token: 0x04000005 RID: 5
		private const string c = "ServerIP";

		// Token: 0x04000006 RID: 6
		private const string d = "ServerName";

		// Token: 0x04000007 RID: 7
		private const string e = "CACertRawData";

		// Token: 0x04000008 RID: 8
		private const string f = "ClientCertRawData";

		// Token: 0x04000009 RID: 9
		private const string g = "PassworPhrase";

		// Token: 0x0400000A RID: 10
		private const string h = "CipherSuite";

		// Token: 0x0400000B RID: 11
		private const string i = "ConnTypeUDP";

		// Token: 0x0400000C RID: 12
		private const string j = "ConnectionTypeReliable";

		// Token: 0x0400000D RID: 13
		private const string k = "ConnTypeSecure";

		// Token: 0x0400000E RID: 14
		private const string l = "PortNumber";

		// Token: 0x0400000F RID: 15
		private const string m = "RecordType";

		// Token: 0x04000010 RID: 16
		private const string n = "Version";

		// Token: 0x04000011 RID: 17
		private const string o = "Hostname";

		// Token: 0x04000012 RID: 18
		private const string p = "IMWHostname";

		// Token: 0x04000013 RID: 19
		private const string q = "IMWPort";

		// Token: 0x04000014 RID: 20
		private const string r = "IMWMultiGroupPort";

		// Token: 0x04000015 RID: 21
		private const string s = "IMWOAuthHostname";

		// Token: 0x04000016 RID: 22
		private const string t = "IMWOAuthPort";

		// Token: 0x04000017 RID: 23
		private const string u = "IMWOAuthClientID";

		// Token: 0x04000018 RID: 24
		private const string v = "IMWOAuthClientSecret";

		// Token: 0x04000019 RID: 25
		private string w;

		// Token: 0x0400001A RID: 26
		private string x;

		// Token: 0x0400001B RID: 27
		private readonly int y;

		// Token: 0x0400001C RID: 28
		private readonly int z;
	}
}
