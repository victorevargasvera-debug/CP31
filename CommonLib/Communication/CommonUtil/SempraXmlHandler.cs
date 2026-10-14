using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using Motorola.Common.Communication.CommonUtil.Extensions;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004C RID: 76
	public sealed class SempraXmlHandler
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000217F8 File Offset: 0x0001F9F8
		public static global::Motorola.Common.Communication.CommonUtil.SempraXmlHandler Instance
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1315569665;
				if (num != 0)
				{
				}
				num = (short)427731418;
				short num2 = num;
				num = (short)155036122;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1639841792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)831193088;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommonUtil.SempraXmlHandler.p;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000218A8 File Offset: 0x0001FAA8
		static SempraXmlHandler()
		{
			short num = (short)206150738;
			short num2 = num;
			num = (short)1207344210;
			switch (num2 == num)
			{
			}
			num = (short)1341259776;
			short num3 = num;
			num = (short)1762721793;
			if (num != 0)
			{
			}
			num = (short)1819672576;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.SempraXmlHandler.p = new global::Motorola.Common.Communication.CommonUtil.SempraXmlHandler();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00021960 File Offset: 0x0001FB60
		private SempraXmlHandler()
		{
			int a_ = 18;
			this.m = new global::System.Xml.XmlDocument();
			this.n = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.ApplicationData) + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䨕唗甙栛焝刟䴡䠣䜥琧弩弫䬭䈯洱倳圵䰷嬹ሻ刽ⴿ㩁", a_);
			base..ctor();
			if (!global::System.IO.File.Exists(this.n))
			{
				this.m.AppendChild(this.m.CreateNode(global::System.Xml.XmlNodeType.Element, global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("搕礗縙甛焝匟", a_), ""));
				this.a();
				return;
			}
			this.b();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000219F0 File Offset: 0x0001FBF0
		private void a(out byte[] A_0)
		{
			short num;
			try
			{
				num = (short)2075685195;
				short num2 = num;
				num = (short)537817419;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1430388736;
					if (num != 0)
					{
					}
					global::System.IO.FileStream fileStream = new global::System.IO.FileStream(this.n, global::System.IO.FileMode.Open);
					try
					{
						A_0 = new byte[fileStream.Length];
						fileStream.Read(A_0, 0, (int)fileStream.Length);
					}
					finally
					{
						num = (short)199032832;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_AE;
								}
								continue;
							case 1:
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)2062417922;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_E4;
							}
							IL_AE:
							if (fileStream == null)
							{
								break;
							}
							num = (short)96403457;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_E4:;
					}
					break;
				}
				}
			}
			catch (global::System.IO.FileNotFoundException)
			{
				throw new global::Motorola.Common.CustomException.Cps2Exception(global::Motorola.Common.CustomException.CommonErrorCode.FILE_DOES_NOT_EXSIST, null, null);
			}
			catch (global::System.IO.IOException)
			{
				throw new global::Motorola.Common.CustomException.Cps2Exception(global::Motorola.Common.CustomException.Cps2ErrorCodes.CPS2_File_Access_Failure, null, null);
			}
			num = (short)1737555968;
			short num4 = num;
			num = (short)62849025;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00021B7C File Offset: 0x0001FD7C
		private void a(out byte[] A_0, byte[] A_1)
		{
			int a_ = 6;
			short num = (short)1190330369;
			if (num != 0)
			{
			}
			num = (short)1811939328;
			short num2 = num;
			num = (short)1018115892;
			short num3 = num;
			num = (short)202651444;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1248198656;
				if (num != 0)
				{
				}
				string @string = global::System.Text.Encoding.UTF8.GetString(A_1);
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.LoadXml(@string);
				byte[] a_2 = global::System.Convert.FromBase64String(xmlDocument.GetElementsByTagName(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("堉䴋䨍夏崑", a_))[0].InnerText);
				A_0 = null;
				try
				{
					global::b.a(a_2, ref A_0, false, global::b.a.b);
				}
				catch
				{
					throw new global::Motorola.Common.CustomException.Cps2Exception(global::Motorola.Common.CustomException.Cps2ErrorCodes.CPS2_Decryption_Failed, null, null);
				}
				break;
			}
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00021C9C File Offset: 0x0001FE9C
		private string a(byte[] A_0)
		{
			short num;
			for (;;)
			{
				string @string = global::System.Text.Encoding.UTF8.GetString(A_0);
				if (global::b.a(global::b.b.a, ref @string) != global::b.c.c)
				{
					num = (short)1548091314;
					short num2 = num;
					num = (short)1501233074;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_79;
					}
					break;
				}
				return @string;
			}
			num = (short)1614807040;
			short num3 = num;
			IL_79:
			num = (short)135069697;
			if (num != 0)
			{
			}
			num = (short)1157693440;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.Cps2Exception(global::Motorola.Common.CustomException.Cps2ErrorCodes.CPS2_Verification_Failed, null, null);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00021D70 File Offset: 0x0001FF70
		private void b()
		{
			short num = (short)1712618474;
			short num2 = num;
			num = (short)901413866;
			switch (num2 == num)
			{
			}
			num = (short)820314112;
			short num3 = num;
			num = (short)1776746497;
			if (num != 0)
			{
			}
			num = (short)1731461120;
			if (num != 0)
			{
			}
			byte[] a_;
			this.a(out a_);
			byte[] a_2;
			this.a(out a_2, a_);
			string xml = this.a(a_2);
			this.m.LoadXml(xml);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00021E3C File Offset: 0x0002003C
		private void a(string A_0, out byte[] A_1)
		{
			int a_ = 9;
			short num;
			try
			{
				num = (short)1159896631;
				short num2 = num;
				num = (short)1428856375;
				switch (num2 == num)
				{
				}
				num = (short)658309120;
				if (num != 0)
				{
				}
				global::b.a(global::System.Environment.CurrentDirectory + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("儌紎琐怒稔或欘砚砜氞素", a_), global::b.b.a, ref A_0);
				byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(A_0);
				A_1 = null;
				global::b.b(bytes, ref A_1, false, global::b.a.b);
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.Cps2Exception(global::Motorola.Common.CustomException.Cps2ErrorCodes.CPS2_Encryption_Failed, null, null);
			}
			num = (short)1123352576;
			short num3 = num;
			num = (short)1751515137;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00021F44 File Offset: 0x00020144
		private void a(global::System.Xml.XmlDocument A_0, byte[] A_1)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			string value;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					for (;;)
					{
						A_0.DocumentElement.SetAttribute(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("伋䄍䀏䬑䘓引弗则䠛", a_), value);
						global::System.Xml.XmlElement xmlElement = A_0.CreateElement(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("帋伍吏嬑嬓", a_));
						xmlElement.SetAttribute(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䤋䀍匏崑倓引嘗崙", a_), global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("下漍挏眑∓∕", a_));
						xmlElement.InnerText = global::System.Convert.ToBase64String(A_1);
						num2 = (short)99583573;
						short num3 = num2;
						num2 = (short)1584760405;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_17E;
						}
					}
					IL_17E:
					num2 = (short)1718550528;
					if (num2 != 0)
					{
					}
					num2 = (short)1164705794;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)102105089;
					if (num2 != 0)
					{
					}
					if (A_0.DocumentElement != null)
					{
						num2 = (short)84934656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					global::System.Xml.XmlElement documentElement = A_0.DocumentElement;
					if (documentElement == null)
					{
						return;
					}
					global::System.Xml.XmlElement xmlElement;
					documentElement.AppendChild(xmlElement);
					num2 = (short)572653571;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					return;
				}
				goto IL_29;
			}
			return;
			IL_29:
			A_0.AppendChild(A_0.CreateElement(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䴋對匏娑崓䀕崗", a_)));
			value = string.Format(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("伋愍怏欑易缕缗爙栛㸝ࠟ䄡ണإ匧ᨩᘫ圭䤯䬱䴳䬵ᠷ眹医䨽⼿ぁ⭃⩅⥇橉Ὃ⅍㱏❑⁓㽕㝗㑙⽛牝䁟⭡੣ե䙧䩩⵫ɭᱯ剱♳ήίቹࡻൽꁿ킁懲벑", a_), global::System.DateTime.Now);
			num2 = (short)112001024;
			short num4 = num2;
			num2 = (short)1297612801;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0002212C File Offset: 0x0002032C
		private void a()
		{
			short num = (short)1391329280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				byte[] bytes;
				for (;;)
				{
					IL_27:
					global::System.IO.FileStream fileStream;
					switch (num2)
					{
					case 0:
						num = (short)313065473;
						if (num != 0)
						{
						}
						global::System.IO.Directory.CreateDirectory(global::System.IO.Path.GetDirectoryName(this.n));
						num = (short)1185415171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!global::System.IO.Directory.Exists(global::System.IO.Path.GetDirectoryName(this.n)))
						{
							num = (short)912850944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A;
					case 2:
					{
						num = (short)1944533821;
						short num3 = num;
						num = (short)616053565;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15A;
						default:
							num = (short)1966014464;
							if (num != 0)
							{
							}
							try
							{
								fileStream.Write(bytes, 0, bytes.Length);
								goto IL_1FF;
							}
							finally
							{
								num = (short)1056964608;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_121;
										}
										continue;
									case 1:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)1435435010;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_157;
									}
									IL_121:
									if (fileStream == null)
									{
										break;
									}
									num = (short)1742864385;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_157:;
							}
							goto IL_15A;
						}
						break;
					}
					case 3:
						goto IL_15A;
					}
					goto IL_3E;
					IL_15A:
					fileStream = new global::System.IO.FileStream(this.n, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
					num = (short)1564606466;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1FF:
				num = (short)662241280;
				short num4 = num;
				return;
				IL_3E:
				byte[] a_;
				this.a(this.m.OuterXml, out a_);
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				this.a(xmlDocument, a_);
				bytes = global::System.Text.Encoding.UTF8.GetBytes(xmlDocument.OuterXml);
				num = (short)902037505;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00022374 File Offset: 0x00020574
		public void AddToXml(string keyId, string key, string guid)
		{
			int a_ = 1;
			short num = (short)1731198976;
			switch (num)
			{
			default:
			{
				num = (short)152567813;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Xml.XmlNode xmlNode2;
				for (;;)
				{
					global::System.Xml.XmlAttribute xmlAttribute;
					switch (num2)
					{
					case 0:
					{
						global::System.Xml.XmlNode xmlNode = this.m.SelectSingleNode(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⨄⠆笈樊椌明縐怒", a_));
						xmlNode2 = this.m.CreateNode(global::System.Xml.XmlNodeType.Element, global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("渄戆瀈", a_), null);
						if (xmlNode == null)
						{
							num = (short)808124417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						xmlNode.AppendChild(xmlNode2);
						num = (short)2065825793;
						if (num != 0)
						{
						}
						num = (short)1382612992;
						short num3 = num;
						num = (short)1147273220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_153;
					case 2:
					{
						num = (short)640215178;
						short num4 = num;
						num = (short)1394600074;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_153;
						default:
							goto IL_C1;
						}
						break;
					}
					case 3:
						goto IL_21F;
					case 4:
						goto IL_221;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_6E;
						}
						continue;
					case 6:
						if (xmlNode2.Attributes != null)
						{
							num = (short)1117716487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_281;
					case 7:
					{
						xmlNode2.Attributes.SetNamedItem(xmlAttribute);
						global::System.Xml.XmlAttribute xmlAttribute2 = this.m.CreateAttribute(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("戄爆怈漊", a_));
						xmlAttribute2.Value = guid;
						xmlNode2.Attributes.SetNamedItem(xmlAttribute2);
						num = (short)2048983043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_6E:
					if (this.IsIdExist(keyId))
					{
						num = (short)1612840962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)813367296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_221:
					xmlAttribute = this.m.CreateAttribute(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("氄挆", a_));
					xmlAttribute.Value = keyId;
					num = (short)1974534150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_153:
					goto IL_221;
				}
				IL_C1:
				num = (short)2046230528;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.Cps2Exception(global::Motorola.Common.CustomException.Cps2ErrorCodes.CPS2_Multiple_Keys_Failed, null, null);
				IL_21F:
				IL_281:
				global::System.Xml.XmlText newChild = this.m.CreateTextNode(key);
				xmlNode2.AppendChild(newChild);
				this.a();
				return;
			}
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00022620 File Offset: 0x00020820
		public void UpdateKeyById(string keyId, string newKey)
		{
			int a_ = 9;
			short num = (short)1680801792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)215351296;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				global::System.Xml.XmlNodeList xmlNodeList;
				for (;;)
				{
					IL_5A:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1492647937;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)660799495;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
									num = (short)46202882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_132;
									}
									continue;
								case 2:
								{
									global::System.Xml.XmlNode xmlNode;
									if (xmlNode.Attributes != null)
									{
										num = (short)1658978312;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::System.Xml.XmlNode xmlNode;
									xmlNode.InnerXml = newKey;
									this.a();
									num = (short)209846276;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_1DB;
								case 5:
								{
									global::System.Xml.XmlNode xmlNode;
									if (!(keyId != xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("搌欎", a_)].Value))
									{
										num = (short)966262787;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_256;
								case 7:
									num = (short)1697841158;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)703987717;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_177:
								num = (short)1081606144;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_132:
								goto IL_177;
							}
							IL_1DB:
							IL_256:
							return;
						}
						finally
						{
							for (;;)
							{
								IL_25B:
								switch (0)
								{
								case 0:
									goto IL_278;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_265:
									switch (num2)
									{
									case 0:
										goto IL_319;
									case 1:
									{
										disposable.Dispose();
										num = (short)103476881;
										short num4 = num;
										num = (short)1352330897;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_25B;
										default:
											num = (short)478478336;
											if (num != 0)
											{
											}
											num = (short)1181614080;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										if (disposable != null)
										{
											num = (short)914751489;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_31B;
									}
									break;
								}
								IL_278:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)2131034114;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_265;
							}
							IL_319:
							IL_31B:;
						}
						goto IL_31C;
					case 1:
						return;
					case 2:
						if (xmlNodeList == null)
						{
							num = (short)1670250497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31C;
					}
					goto IL_6D;
					IL_31C:
					enumerator = xmlNodeList.GetEnumerator();
					num = (short)413859840;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6D:
				xmlNodeList = this.m.SelectNodes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("∌‎挐爒焔縖瘘栚㈜琞䐠娢", a_));
				num = (short)225771521;
				if (num != 0)
				{
				}
				num = (short)2055929858;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0002298C File Offset: 0x00020B8C
		public global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey UpdateKey(string keyGuid, string valueToChange, string fieldToChange)
		{
			int a_ = 18;
			short num;
			for (;;)
			{
				num = (short)1646329856;
				short num2 = num;
				if (fieldToChange == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀕礗瘙椛笝", a_))
				{
					goto IL_C9;
				}
				num = (short)138240974;
				short num3 = num;
				num = (short)1211130830;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_83;
				}
			}
			IL_83:
			num = (short)581828608;
			if (num != 0)
			{
			}
			num = (short)1773142017;
			if (num != 0)
			{
			}
			return this.UpdateKeyAlias(keyGuid, valueToChange);
			IL_C9:
			return this.UpdateKeyByGuid(keyGuid, valueToChange);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00022A6C File Offset: 0x00020C6C
		public global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey UpdateKeyByGuid(string keyGuid, string newKey)
		{
			int a_ = 12;
			short num = (short)1935671296;
			short num2 = num;
			num = (short)667090944;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_94;
				}
				global::System.Xml.XmlNodeList xmlNodeList;
				for (;;)
				{
					IL_5A:
					num = (short)821559297;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_395;
					case 1:
					{
						if (xmlNodeList == null)
						{
							num = (short)1309736962;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
						num = (short)2062876672;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_E2;
					}
					goto IL_94;
				}
				IL_E2:
				IL_36A:
				return new global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey();
				IL_395:
				try
				{
					num = (short)1998061569;
					num3 = (int)((global::System.IntPtr)num);
					global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey result;
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_1A0;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_131;
							}
							continue;
						case 2:
							goto IL_2A3;
						case 3:
							num = (short)1997668357;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes != null)
							{
								num = (short)1299841027;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							global::System.Xml.XmlNode xmlNode;
							if (!(keyGuid != xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("眏朑紓爕", a_)].Value))
							{
								num = (short)1492844552;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)511442946;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1166082054;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
							num = (short)1901592580;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::System.Xml.XmlNode xmlNode;
							xmlNode.InnerXml = newKey;
							global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey localPreSharedKey = new global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey(xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("眏朑紓爕", a_)].Value, xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("礏瘑", a_)].Value, xmlNode.InnerXml);
							this.a();
							result = localPreSharedKey;
							num = (short)808386560;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_1A5:
						num = (short)589955079;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_131:
						goto IL_1A5;
					}
					IL_1A0:
					return result;
					IL_2A3:
					goto IL_370;
				}
				finally
				{
					for (;;)
					{
						switch (0)
						{
						case 0:
							goto IL_2C5;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_2B2:
							switch (num3)
							{
							case 0:
								goto IL_31E;
							case 1:
								if (disposable != null)
								{
									num = (short)57344002;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_369;
							case 2:
								disposable.Dispose();
								num = (short)790953984;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C5;
						}
						IL_31E:
						num = (short)585501454;
						short num4 = num;
						num = (short)453708558;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_352;
						}
						IL_2C5:
						global::System.Collections.IEnumerator enumerator;
						disposable = (enumerator as global::System.IDisposable);
						num = (short)8781825;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_2B2;
					}
					IL_352:
					num = (short)140771328;
					if (num != 0)
					{
					}
					IL_369:;
				}
				goto IL_36A;
				IL_370:
				return new global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey();
				IL_94:
				xmlNodeList = this.m.SelectNodes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㼏㴑易眕簗猙猛洝༟䤡䄣弥", a_));
				num = (short)2105409537;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00022E30 File Offset: 0x00021030
		public global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey UpdateKeyAlias(string oldKeyGuid, string newKey)
		{
			int a_ = 0;
			short num = (short)1404829696;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey result;
				global::System.Xml.XmlNodeList xmlNodeList;
				for (;;)
				{
					IL_32:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)320667649;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Xml.XmlNode xmlNode;
								switch (num2)
								{
								case 0:
									goto IL_15F;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_115;
									}
									continue;
								case 2:
									goto IL_2FF;
								case 3:
									if (xmlNode.Attributes != null)
									{
										num = (short)841154569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_15F;
								case 4:
									num = (short)1994588162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (!(oldKeyGuid != xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("挃猅愇渉", a_)].Value))
									{
										num = (short)1306853376;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									if (xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("洃戅", a_)].Value == newKey)
									{
										num = (short)183042058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)543227910;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (!enumerator.MoveNext())
									{
										num = (short)2035744772;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
									num = (short)1939603459;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)2055208967;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_286;
								}
								goto IL_115;
								IL_15F:
								xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("洃戅", a_)].Value = newKey;
								result = new global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey(xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("挃猅愇渉", a_)].Value, xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("洃戅", a_)].Value, xmlNode.InnerXml);
								num = (short)1357643781;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E1:
								num = (short)1288306696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_115:
								goto IL_1E1;
							}
							IL_286:
							throw new global::Motorola.Common.CustomException.Cps2Exception(global::Motorola.Common.CustomException.Cps2ErrorCodes.CPS2_Multiple_Keys_Failed, null, null);
							IL_2FF:
							goto IL_41A;
						}
						finally
						{
							for (;;)
							{
								switch (0)
								{
								case 0:
									goto IL_321;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_30E:
									switch (num2)
									{
									case 0:
										goto IL_37A;
									case 1:
										if (disposable != null)
										{
											num = (short)109772802;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3C6;
									case 2:
										disposable.Dispose();
										num = (short)1348796416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_321;
								}
								IL_37A:
								num = (short)1459461454;
								short num3 = num;
								num = (short)852860238;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									goto IL_3AF;
								}
								IL_321:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)387121153;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_30E;
							}
							IL_3AF:
							num = (short)761856000;
							if (num != 0)
							{
							}
							IL_3C6:;
						}
						goto IL_3C7;
					case 1:
						if (xmlNodeList == null)
						{
							num = (short)127664130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C7;
					case 2:
						goto IL_96;
					}
					goto IL_45;
					IL_3C7:
					enumerator = xmlNodeList.GetEnumerator();
					num = (short)875888641;
					if (num != 0)
					{
					}
					num = (short)1286995968;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_96:
				num = (short)454164480;
				short num4 = num;
				return new global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey();
				IL_41A:
				this.a();
				return result;
				IL_45:
				xmlNodeList = this.m.SelectNodes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⬃⤅稇欉栋服缏愑㬓紕紗挙", a_));
				result = new global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey();
				num = (short)1577975809;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0002327C File Offset: 0x0002147C
		public bool IsIdExist(string keyId)
		{
			int a_ = 11;
			short num = (short)478347264;
			short num2 = num;
			num = (short)649789440;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				global::System.Xml.XmlNodeList xmlNodeList;
				for (;;)
				{
					IL_5B:
					switch (num3)
					{
					case 0:
						goto IL_370;
					case 1:
					{
						if (xmlNodeList == null)
						{
							num = (short)1729822722;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
						num = (short)1779695616;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return false;
					}
					goto IL_6E;
				}
				return false;
				IL_370:
				try
				{
					num = (short)890175489;
					num3 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						bool flag;
						switch (num3)
						{
						case 0:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)150208518;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
							num = (short)227344386;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_137;
							}
							continue;
						case 2:
						{
							global::System.Xml.XmlNode xmlNode;
							global::System.Xml.XmlAttributeCollection attributes = xmlNode.Attributes;
							if (attributes == null)
							{
								num = (short)575602696;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = (attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("明甐", a_)] != null);
							goto IL_197;
						}
						case 3:
							goto IL_285;
						case 4:
							result = true;
							num = (short)858390537;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::System.Xml.XmlNode xmlNode;
							if (keyId == xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("明甐", a_)].Value)
							{
								num = (short)1564475396;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)155779075;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)921436165;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							flag = (null != null);
							goto IL_197;
						case 9:
							goto IL_20C;
						}
						goto IL_137;
						IL_197:
						if (flag)
						{
							num = (short)848822279;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1B3:
						num = (short)1227751424;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_137:
						goto IL_1B3;
					}
					IL_20C:
					return result;
					IL_285:
					return false;
				}
				finally
				{
					for (;;)
					{
						switch (0)
						{
						case 0:
							goto IL_2A7;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_294:
							switch (num3)
							{
							case 0:
								goto IL_2FF;
							case 1:
								if (disposable != null)
								{
									num = (short)546570242;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_34C;
							case 2:
								disposable.Dispose();
								num = (short)72810496;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A7;
						}
						IL_2FF:
						num = (short)1475480592;
						short num4 = num;
						num = (short)291834896;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_335;
						}
						IL_2A7:
						global::System.Collections.IEnumerator enumerator;
						disposable = (enumerator as global::System.IDisposable);
						num = (short)172883969;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_294;
					}
					IL_335:
					num = (short)1059651584;
					if (num != 0)
					{
					}
					IL_34C:;
				}
				return false;
				IL_6E:
				num = (short)1150353409;
				if (num != 0)
				{
				}
				xmlNodeList = this.m.SelectNodes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("‎㸐愒琔猖瀘琚渜〞䨠䘢尤", a_));
				num = (short)1595277313;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5B;
			}
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0002361C File Offset: 0x0002181C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey> GetKeys()
		{
			int a_ = 6;
			short num = (short)2007498752;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey> list;
				global::System.Xml.XmlNodeList xmlNodeList;
				for (;;)
				{
					IL_32:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1254948865;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								bool flag;
								switch (num2)
								{
								case 0:
								{
									global::System.Xml.XmlNode xmlNode;
									global::System.Xml.XmlAttributeCollection attributes = xmlNode.Attributes;
									if (attributes == null)
									{
										num = (short)96731143;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = (attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("按栋", a_)] != null);
									goto IL_19A;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_13B;
									}
									continue;
								case 2:
									goto IL_2EE;
								case 3:
									num = (short)1347485698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1439694851;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
									num = (short)1276379136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Xml.XmlNode xmlNode;
									global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey item = new global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey
									{
										Id = xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("按栋", a_)].Value,
										Guid = ((xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("洉礋服琏", a_)] == null) ? this.a(xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("按栋", a_)].Value) : xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("洉礋服琏", a_)].Value),
										Key = xmlNode.InnerXml
									};
									list.Add(item);
									num = (short)1313800200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)52559877;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									flag = (null != null);
									goto IL_19A;
								}
								goto IL_13B;
								IL_19A:
								if (flag)
								{
									num = (short)1902575622;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_295:
								num = (short)1498087428;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13B:
								goto IL_295;
							}
							IL_2EE:
							return list;
						}
						finally
						{
							for (;;)
							{
								switch (0)
								{
								case 0:
									goto IL_310;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_2FD:
									switch (num2)
									{
									case 0:
										goto IL_36B;
									case 1:
										if (disposable != null)
										{
											num = (short)573440002;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3B6;
									case 2:
										disposable.Dispose();
										num = (short)1652359168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_310;
								}
								IL_36B:
								num = (short)1442854469;
								short num3 = num;
								num = (short)1593325125;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									goto IL_39F;
								}
								IL_310:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1022296065;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_2FD;
							}
							IL_39F:
							num = (short)843251712;
							if (num != 0)
							{
							}
							IL_3B6:;
						}
						goto IL_3B7;
					case 1:
						if (xmlNodeList == null)
						{
							num = (short)315949058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B7;
					case 2:
						goto IL_C3;
					}
					goto IL_45;
					IL_3B7:
					enumerator = xmlNodeList.GetEnumerator();
					num = (short)315817984;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C3:
				num = (short)848953345;
				if (num != 0)
				{
				}
				return list;
				IL_45:
				num = (short)698482688;
				short num4 = num;
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.LocalPreSharedKey>();
				xmlNodeList = this.m.SelectNodes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("┉⌋簍焏瘑紓礕欗㔙眛笝够", a_));
				num = (short)773390337;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00023A24 File Offset: 0x00021C24
		private string a(string A_0)
		{
			int a_ = 10;
			short num = (short)338952192;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						global::System.Xml.XmlNodeList xmlNodeList;
						if (xmlNodeList == null)
						{
							num = (short)120193026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
						num = (short)849018881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_36C;
					case 2:
						goto IL_11D;
					}
					goto IL_44;
				}
				IL_11D:
				goto IL_340;
				IL_36C:
				num = (short)509739008;
				short num3 = num;
				try
				{
					num = (short)1702363137;
					num2 = (int)((global::System.IntPtr)num);
					string result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)449839107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_16D;
							}
							continue;
						case 2:
							goto IL_1C0;
						case 3:
							goto IL_2C9;
						case 4:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1078132736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
							num = (short)928710662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1630208008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes != null)
							{
								num = (short)1617428485;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
						{
							global::System.Xml.XmlAttribute xmlAttribute = this.m.CreateAttribute(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("植攏笑瀓", a_));
							string text;
							xmlAttribute.Value = text;
							global::System.Xml.XmlNode xmlNode;
							xmlNode.Attributes.SetNamedItem(xmlAttribute);
							this.a();
							result = text;
							num = (short)1409351682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::System.Xml.XmlNode xmlNode;
							if (!(A_0 != xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("服琏", a_)].Value))
							{
								num = (short)823328775;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_1C5:
						num = (short)180944900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_16D:
						goto IL_1C5;
					}
					IL_1C0:
					return result;
					IL_2C9:
					goto IL_346;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_2E8;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_2D5:
						switch (num2)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)961740802;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_33F;
						case 1:
							goto IL_33D;
						case 2:
							disposable.Dispose();
							num = (short)345964545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E8;
					}
					IL_33D:
					IL_33F:
					goto EndFinally_8;
					IL_2E8:
					global::System.Collections.IEnumerator enumerator;
					disposable = (enumerator as global::System.IDisposable);
					num = (short)2037186560;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_2D5;
					EndFinally_8:;
				}
				goto IL_340;
				IL_346:
				return string.Empty;
				IL_44:
				num = (short)160214866;
				short num4 = num;
				num = (short)1803071314;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_340:
					return string.Empty;
				default:
				{
					num = (short)2100887552;
					if (num != 0)
					{
					}
					string text = global::System.Guid.NewGuid().ToString();
					global::System.Xml.XmlNodeList xmlNodeList = this.m.SelectNodes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("ℍ㼏怑甓爕焗甙漛ㄝ䬟䜡崣", a_));
					num = (short)1446838273;
					if (num != 0)
					{
					}
					num = (short)1908801536;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
				break;
			}
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00023DEC File Offset: 0x00021FEC
		public bool DeleteKey(string keyGuid)
		{
			int a_ = 11;
			short num = (short)584122368;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						global::System.Xml.XmlNodeList xmlNodeList;
						if (xmlNodeList == null)
						{
							num = (short)1822162946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
						num = (short)283770881;
						if (num != 0)
						{
						}
						num = (short)1176305665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_3A1;
					case 2:
						goto IL_E1;
					}
					goto IL_43;
				}
				IL_E1:
				return false;
				IL_3A1:
				num = (short)245825536;
				short num3 = num;
				try
				{
					num = (short)2139422724;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_261;
						case 1:
							goto IL_2DE;
						case 2:
							num = (short)780533767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes != null)
							{
								num = (short)1229586434;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_13C;
							}
							continue;
						case 5:
							num = (short)1117061121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)2144731147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::System.Xml.XmlNode xmlNode;
							global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes[global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("栎搐稒焔", a_)];
							if (!(keyGuid != ((xmlAttribute != null) ? xmlAttribute.Value : null)))
							{
								num = (short)172163078;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							goto IL_282;
						case 9:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1809383429;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
							num = (short)972423171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_261;
						case 11:
						{
							global::System.Xml.XmlNode xmlNode2 = this.m.SelectSingleNode(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("‎㸐愒琔猖瀘琚渜", a_));
							if (xmlNode2 == null)
							{
								num = (short)347209728;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlNode xmlNode;
							xmlNode2.RemoveChild(xmlNode);
							num = (short)687800330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_13C;
						IL_261:
						this.a();
						result = true;
						num = (short)1573912584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_287:
						num = (short)1835204617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_13C:
						goto IL_287;
					}
					IL_282:
					return result;
					IL_2DE:
					return false;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_2FD;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_2EA:
						switch (num2)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)196608002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_356;
						case 1:
							goto IL_354;
						case 2:
							disposable.Dispose();
							num = (short)1090256897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FD;
					}
					IL_354:
					IL_356:
					goto EndFinally_10;
					IL_2FD:
					global::System.Collections.IEnumerator enumerator;
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1302659072;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_2EA;
					EndFinally_10:;
				}
				return false;
				IL_43:
				num = (short)324016969;
				short num4 = num;
				num = (short)355670857;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
				{
					num = (short)888078336;
					if (num != 0)
					{
					}
					global::System.Xml.XmlNodeList xmlNodeList = this.m.SelectNodes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("‎㸐愒琔猖瀘琚渜〞䨠䘢尤", a_));
					num = (short)1554317312;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
				break;
			}
			}
		}

		// Token: 0x040001CE RID: 462
		private const string a = "id";

		// Token: 0x040001CF RID: 463
		private const string b = "guid";

		// Token: 0x040001D0 RID: 464
		private const string c = "radios";

		// Token: 0x040001D1 RID: 465
		private const string d = "Value";

		// Token: 0x040001D2 RID: 466
		private const string e = "RADIO";

		// Token: 0x040001D3 RID: 467
		private const string f = "ARCHIVE";

		// Token: 0x040001D4 RID: 468
		private const string g = "COPYRIGHT";

		// Token: 0x040001D5 RID: 469
		private const string h = "ENCODING";

		// Token: 0x040001D6 RID: 470
		private const string i = "Base64";

		// Token: 0x040001D7 RID: 471
		private const string j = "key";

		// Token: 0x040001D8 RID: 472
		private const string k = "//radios";

		// Token: 0x040001D9 RID: 473
		private const string l = "//radios/key";

		// Token: 0x040001DA RID: 474
		private readonly global::System.Xml.XmlDocument m;

		// Token: 0x040001DB RID: 475
		private readonly string n;

		// Token: 0x040001DC RID: 476
		private const string o = "Copyright (c) {0:yyyy} Motorola Solutions, Inc. All Rights Reserved.";

		// Token: 0x040001DD RID: 477
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static readonly global::Motorola.Common.Communication.CommonUtil.SempraXmlHandler p;
	}
}
