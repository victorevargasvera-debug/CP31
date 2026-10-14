using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using AcpCryptoLib;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001F RID: 31
	internal class g
	{
		// Token: 0x060000FC RID: 252 RVA: 0x0001CD08 File Offset: 0x0001AF08
		public string j()
		{
			short num = (short)1800514502;
			short num2 = num;
			num = (short)1049930694;
			switch (num2 == num)
			{
			}
			num = (short)2045378561;
			if (num != 0)
			{
			}
			num = (short)1705705472;
			short num3 = num;
			num = (short)1070727168;
			if (num != 0)
			{
			}
			return this.c;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
		public g(string A_0, global::Motorola.Common.Communication.CommonUtil.ModelType A_1, string A_2)
		{
			int a_ = 0;
			this.a = string.Empty;
			this.c = global::System.IO.Path.GetTempPath();
			this.d = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.g.a>();
			this.f = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鳯鏱髳釵훷韹鋻飽", a_);
			this.g = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鳯鏱髳釵훷铹駻觽", a_);
			base..ctor();
			if (string.IsNullOrEmpty(A_2))
			{
				this.a = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뗯鳱鏳髵釷觹铻", a_);
				return;
			}
			global::System.Xml.XmlDocument a_2 = null;
			try
			{
				a_2 = new global::AcpCryptoLib.AcpXMLEncryptDecrypt().DecryptXMLFile(A_2);
				goto IL_73;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_InvalidData);
			}
			goto IL_136;
			IL_73:
			this.c = this.c + global::System.Guid.NewGuid().ToString().Replace(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("\uddef", a_), "") + global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("곯", a_);
			if (!global::System.IO.Directory.Exists(this.c))
			{
				global::System.IO.Directory.CreateDirectory(this.c);
			}
			this.h = this.c + global::System.IO.Path.GetFileName(A_2);
			if (!global::System.IO.File.Exists(this.h))
			{
				global::System.IO.File.Copy(A_2, this.h);
			}
			IL_136:
			this.j(a_2, A_1, A_0);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0001CF14 File Offset: 0x0001B114
		private string j(string A_0, string A_1)
		{
			int a_ = 10;
			short num;
			string result;
			try
			{
				num = (short)1747216899;
				short num2 = num;
				num = (short)1348299267;
				switch (num2 == num)
				{
				}
				num = (short)611319809;
				if (num != 0)
				{
				}
				num = (short)217186304;
				if (num != 0)
				{
				}
				string text = A_0 + global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("釹", a_);
				byte[] bytes = new global::System.Text.UTF8Encoding().GetBytes(A_1);
				this.j(bytes, text, true, global::System.IO.FileMode.Create);
				result = text;
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Write_LangManifestFile_Failed);
			}
			num = (short)1767899136;
			short num3 = num;
			return result;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001D014 File Offset: 0x0001B214
		private void j(byte[] A_0, string A_1, bool A_2, global::System.IO.FileMode A_3)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				global::System.IO.FileStream fileStream;
				switch (num)
				{
				case 0:
					try
					{
						global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(fileStream, global::System.Text.Encoding.UTF8);
						try
						{
							num2 = (short)1422458884;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_11B;
								case 1:
									num2 = (short)224854019;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 2:
									goto IL_13E;
								case 3:
									if (A_3 != global::System.IO.FileMode.Append)
									{
										num2 = (short)395051013;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_120;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_A8;
									}
									continue;
								case 5:
									binaryWriter.Write(new global::AcpCryptoLib.AcpEncryptDecrypt().Encrypt(A_0));
									num2 = (short)326303744;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								IL_A8:
								if (A_2)
								{
									num2 = (short)246218753;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								IL_120:
								binaryWriter.Write(A_0);
								num2 = (short)2037514242;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_11B:
							IL_13E:
							return;
						}
						finally
						{
							num2 = (short)1345847297;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_1A8;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_173;
									}
									continue;
								case 2:
									((global::System.IDisposable)binaryWriter).Dispose();
									num2 = (short)1515192320;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								IL_173:
								if (binaryWriter == null)
								{
									break;
								}
								num2 = (short)361365506;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_1A8:;
						}
					}
					finally
					{
						num2 = (short)264830977;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_27E;
							case 1:
							{
								num2 = (short)586814379;
								short num3 = num2;
								num2 = (short)1328485291;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_26A;
								default:
									num2 = (short)2126118912;
									if (num2 != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_225;
									}
									continue;
								}
								break;
							}
							case 2:
								num2 = (short)8912897;
								if (num2 != 0)
								{
								}
								((global::System.IDisposable)fileStream).Dispose();
								goto IL_26A;
							}
							IL_225:
							if (fileStream != null)
							{
								num2 = (short)2131296258;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
							IL_26A:
							num2 = (short)734789632;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_27E:;
					}
					goto IL_281;
				case 1:
					if (A_0 == null)
					{
						num2 = (short)390201346;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_281;
				case 2:
					goto IL_59;
				}
				goto IL_25;
				IL_281:
				fileStream = new global::System.IO.FileStream(A_1, A_3, global::System.IO.FileAccess.Write);
				num2 = (short)871825408;
				short num4 = num2;
				num2 = (short)2009989120;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_59:
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("賺迼雾甀昂䜄爆漈洊栌紎", a_));
			IL_25:
			new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			num2 = (short)386334721;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0001D33C File Offset: 0x0001B53C
		public string k()
		{
			short num = (short)569268365;
			short num2 = num;
			num = (short)889870477;
			switch (num2 == num)
			{
			}
			num = (short)749928448;
			if (num != 0)
			{
			}
			num = (short)1364983808;
			short num3 = num;
			num = (short)294256641;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0001D3EC File Offset: 0x0001B5EC
		public string l()
		{
			short num = (short)1610048364;
			short num2 = num;
			num = (short)1729520492;
			switch (num2 == num)
			{
			}
			num = (short)2034434048;
			if (num != 0)
			{
			}
			num = (short)1253244928;
			short num3 = num;
			num = (short)660275201;
			if (num != 0)
			{
			}
			return this.h;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0001D49C File Offset: 0x0001B69C
		public string m()
		{
			short num = (short)1537192894;
			short num2 = num;
			num = (short)2026222526;
			switch (num2 == num)
			{
			}
			num = (short)1372323840;
			if (num != 0)
			{
			}
			num = (short)343736320;
			short num3 = num;
			num = (short)1589248001;
			if (num != 0)
			{
			}
			return this.e;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0001D54C File Offset: 0x0001B74C
		public string n()
		{
			short num = (short)1663800000;
			short num2 = num;
			num = (short)1665372864;
			switch (num2 == num)
			{
			}
			num = (short)453378049;
			if (num != 0)
			{
			}
			num = (short)1022427136;
			short num3 = num;
			num = (short)1263206400;
			if (num != 0)
			{
			}
			return this.f;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001D5FC File Offset: 0x0001B7FC
		public string o()
		{
			short num = (short)275904122;
			short num2 = num;
			num = (short)321189498;
			switch (num2 == num)
			{
			}
			num = (short)932249601;
			if (num != 0)
			{
			}
			num = (short)1292828672;
			short num3 = num;
			num = (short)761135104;
			if (num != 0)
			{
			}
			return this.g;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0001D6AC File Offset: 0x0001B8AC
		public string p()
		{
			short num = (short)1806475805;
			short num2 = num;
			num = (short)1933943325;
			switch (num2 == num)
			{
			}
			num = (short)1687420929;
			if (num != 0)
			{
			}
			num = (short)1041432576;
			short num3 = num;
			num = (short)1374814208;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0001D760 File Offset: 0x0001B960
		public bool q()
		{
			short num = (short)1234104409;
			short num2 = num;
			num = (short)804450393;
			switch (num2 == num)
			{
			}
			num = (short)3342337;
			if (num != 0)
			{
			}
			num = (short)1137049600;
			short num3 = num;
			num = (short)1270218752;
			if (num != 0)
			{
			}
			return this.i;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0001D810 File Offset: 0x0001BA10
		private void j(global::System.Xml.XmlDocument A_0, global::Motorola.Common.Communication.CommonUtil.ModelType A_1, string A_2)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)695926784;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					global::System.Xml.XmlNode documentElement;
					global::System.Xml.XmlNode xmlNode3;
					for (;;)
					{
						IL_32:
						string str;
						string xpath;
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.List<string> list;
							if (list.Count == 0)
							{
								num = (short)1734869009;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.d = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.g.a>();
							string a_2 = string.Empty;
							string value = string.Empty;
							string text = string.Empty;
							int a_3 = 0;
							bool flag = false;
							this.i = false;
							global::System.Collections.IEnumerator enumerator = documentElement.SelectNodes(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("⿿ⴁ栃瘅椇椉朋ℍ琏猑怓眕㜗簙甛爝䔟", a_)).GetEnumerator();
							num = (short)1164378120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							str = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("淿洁昃漅搇漉", a_);
							num = (short)831127571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_6A8;
						case 3:
							if (A_1 == global::Motorola.Common.Communication.CommonUtil.ModelType.Mobile)
							{
								num = (short)1027801089;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							str = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("烿洁瘃爅椇栉怋欍", a_);
							num = (short)404291598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)60030983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::System.Collections.Generic.List<string> list;
							if (list.Count == 0)
							{
								num = (short)1396637707;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19C;
						}
						case 6:
							goto IL_225;
						case 7:
						{
							global::System.Collections.Generic.List<string> list;
							if (this.d.Count != list.Count)
							{
								num = (short)1600585734;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.e = this.j(this.c + this.f, string.Empty);
							num = (short)1704329225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							try
							{
								num = (short)1139081226;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1531445252;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Collections.Generic.List<string> list;
										string text;
										if (list.Contains(text))
										{
											num = (short)1191510023;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)27000838;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
										string text = ((global::System.Xml.XmlElement)xmlNode).GetAttribute(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("槿昁", a_));
										num = (short)1153630209;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										string value;
										if (value == string.Empty)
										{
											num = (short)99680261;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string a_2;
										int a_3;
										bool flag;
										global::Motorola.Common.Communication.g.a value2 = new global::Motorola.Common.Communication.g.a(a_2, a_3, flag);
										string text;
										this.d.Add(text, value2);
										num = (short)304283650;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_CFC;
									case 6:
										num = (short)1918959624;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										global::System.Xml.XmlNode xmlNode;
										global::System.Collections.IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
										num = (short)2116157449;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										goto IL_D1B;
									case 9:
										try
										{
											num = (short)722731018;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
												{
													global::System.Xml.XmlNode xmlNode2;
													string value = xmlNode2.InnerText;
													int a_3 = global::System.Convert.ToInt32(value);
													num = (short)1818886149;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 1:
													num = (short)2023424019;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
												{
													global::System.Xml.XmlNode xmlNode2;
													if (!string.IsNullOrEmpty(xmlNode2.InnerText))
													{
														num = (short)1408106508;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_909;
												}
												case 4:
													this.i = true;
													num = (short)2079719426;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 5:
													goto IL_8B5;
												case 6:
													num = (short)1367080963;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 7:
												{
													global::System.Collections.IEnumerator enumerator2;
													if (!enumerator2.MoveNext())
													{
														num = (short)1870200833;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator2.Current;
													num = (short)1265172491;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 8:
												{
													global::System.Xml.XmlNode xmlNode2;
													if (!string.IsNullOrEmpty(xmlNode2.InnerText))
													{
														num = (short)1151401998;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 9:
													goto IL_909;
												case 10:
													switch (0)
													{
													case 0:
														goto IL_7DF;
													}
													continue;
												case 11:
												{
													global::System.Xml.XmlNode xmlNode2;
													if (xmlNode2.Name == global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("替欁栃挅昇欉愋欍", a_))
													{
														num = (short)1791164422;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_909;
												}
												case 12:
												{
													global::System.Xml.XmlNode xmlNode2;
													string a_2 = xmlNode2.InnerText;
													num = (short)1886388233;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 13:
													num = (short)2124742664;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 14:
												{
													global::System.Xml.XmlNode xmlNode2;
													bool flag = global::System.Convert.ToBoolean(xmlNode2.InnerText);
													num = (short)496566289;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 15:
												{
													global::System.Xml.XmlNode xmlNode2;
													if (xmlNode2.Name == global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("珿欁縃挅", a_))
													{
														num = (short)550174740;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_8B5;
												}
												case 16:
												{
													global::System.Xml.XmlNode xmlNode2;
													if (xmlNode2.Name == global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("揿瀁洃爅愇椉洋戍䔏我瀓眕気缙", a_))
													{
														num = (short)1184432141;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 17:
												{
													bool flag;
													if (flag)
													{
														num = (short)74776580;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 18:
												{
													global::System.Xml.XmlNode xmlNode2;
													if (!string.IsNullOrEmpty(xmlNode2.InnerText))
													{
														num = (short)1038155776;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_8B5;
												}
												case 19:
													goto IL_ADC;
												case 20:
													num = (short)1931542546;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_7DF;
												IL_8B5:
												num = (short)959905808;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_909:
												num = (short)649003023;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_9C4:
												num = (short)1918435335;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_7DF:
												goto IL_9C4;
											}
											IL_ADC:
											goto IL_C76;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_AFE;
											}
											global::System.IDisposable disposable;
											for (;;)
											{
												IL_AEB:
												switch (num2)
												{
												case 0:
													goto IL_B54;
												case 1:
													if (disposable != null)
													{
														num = (short)815333378;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_B56;
												case 2:
													disposable.Dispose();
													num = (short)591265792;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_AFE;
											}
											IL_B54:
											IL_B56:
											goto EndFinally_47;
											IL_AFE:
											global::System.Collections.IEnumerator enumerator2;
											disposable = (enumerator2 as global::System.IDisposable);
											num = (short)892076033;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_AEB;
											EndFinally_47:;
										}
										goto IL_B57;
										IL_C76:
										num = (short)184877067;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										switch (0)
										{
										case 0:
											goto IL_75F;
										}
										continue;
									case 11:
									{
										string a_2;
										if (!(a_2 == string.Empty))
										{
											num = (short)2039873536;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_B57;
									}
									}
									IL_B62:
									num = (short)11665411;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_75F:
									goto IL_B62;
								}
								IL_B57:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
								IL_CFC:
								goto IL_B57;
								IL_D1B:
								goto IL_2EE;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_D3D;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_D2A:
									switch (num2)
									{
									case 0:
										goto IL_D95;
									case 1:
										if (disposable != null)
										{
											num = (short)657391618;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_D97;
									case 2:
										disposable.Dispose();
										num = (short)1589116928;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D3D;
								}
								IL_D95:
								IL_D97:
								goto EndFinally_48;
								IL_D3D:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1432616961;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_D2A;
								EndFinally_48:;
							}
							goto IL_D98;
							IL_2EE:
							num = (short)1921384470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_FC3;
						case 10:
							if (string.IsNullOrEmpty(xmlNode3.InnerText))
							{
								num = (short)1489895426;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.b = xmlNode3.InnerText;
							str = string.Empty;
							num = (short)763166723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							xpath = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("⿿ⴁ栃瘅椇椉朋ℍ紏猑稓缕縗缙漛樝༟", a_) + str + global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("⿿漁欃戅洇昉國不礏瘑⤓ㄕ尗缙稛缝唟両倣ĥ甧", a_);
							global::System.Xml.XmlNode xmlNode4 = documentElement.SelectSingleNode(xpath);
							num = (short)1295515668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
						{
							global::System.Xml.XmlNodeList xmlNodeList = documentElement.SelectNodes(xpath);
							string empty = string.Empty;
							global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
							if (xmlNodeList == null)
							{
								goto Block_8;
							}
							global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
							num = (short)506200077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							try
							{
								num = (short)1635909637;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_5ED;
									case 1:
									{
										global::System.Xml.XmlNode xmlNode5;
										global::System.Collections.IEnumerator enumerator2 = xmlNode5.ChildNodes.GetEnumerator();
										num = (short)436994051;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)957874180;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode5 = (global::System.Xml.XmlNode)enumerator.Current;
										num = (short)1104281606;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										try
										{
											num = (short)1590231043;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													num = (short)1933901825;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													goto IL_55C;
												case 3:
													switch (0)
													{
													case 0:
														goto IL_4D4;
													}
													continue;
												case 4:
												{
													global::System.Collections.IEnumerator enumerator2;
													if (!enumerator2.MoveNext())
													{
														num = (short)391774208;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::System.Xml.XmlNode xmlNode6 = (global::System.Xml.XmlNode)enumerator2.Current;
													global::System.Collections.Generic.List<string> list;
													list.Add(xmlNode6.InnerText);
													num = (short)335478786;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_509:
												num = (short)793509892;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_4D4:
												goto IL_509;
											}
											IL_55C:;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_57B;
											}
											global::System.IDisposable disposable;
											for (;;)
											{
												IL_568:
												switch (num2)
												{
												case 0:
													goto IL_5D1;
												case 1:
													if (disposable != null)
													{
														num = (short)796262402;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_5D3;
												case 2:
													disposable.Dispose();
													num = (short)2043019264;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_57B;
											}
											IL_5D1:
											IL_5D3:
											goto EndFinally_45;
											IL_57B:
											global::System.Collections.IEnumerator enumerator2;
											disposable = (enumerator2 as global::System.IDisposable);
											num = (short)232259585;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_568;
											EndFinally_45:;
										}
										goto IL_5D4;
									case 4:
										goto IL_5D4;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_37E;
										}
										continue;
									case 6:
									{
										global::System.Xml.XmlNode xmlNode5;
										if (((global::System.Xml.XmlElement)xmlNode5).GetAttribute(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("槿昁", a_)) == A_2)
										{
											num = (short)1780678657;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3CB;
									}
									}
									goto IL_37E;
									IL_3CB:
									num = (short)172163074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_37E:
									num = (short)755219421;
									short num3 = num;
									num = (short)737459165;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_5ED;
									default:
										num = (short)1610678272;
										if (num != 0)
										{
										}
										goto IL_3CB;
									}
									IL_5D4:
									num = (short)1809252352;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_5ED:
								goto IL_D98;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_60F;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_5FC:
									switch (num2)
									{
									case 0:
										goto IL_665;
									case 1:
										if (disposable != null)
										{
											num = (short)1506476034;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_667;
									case 2:
										disposable.Dispose();
										num = (short)794427392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_60F;
								}
								IL_665:
								IL_667:
								goto EndFinally_46;
								IL_60F:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1574043649;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_5FC;
								EndFinally_46:;
							}
							goto IL_668;
						case 14:
							goto IL_293;
						case 15:
							if (xmlNode3 != null)
							{
								num = (short)117833749;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F17;
						case 16:
							try
							{
								num = (short)1109196801;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)36241410;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_E14;
										}
										continue;
									case 2:
										goto IL_E9B;
									case 4:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1471217664;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode7 = (global::System.Xml.XmlNode)enumerator.Current;
										global::System.Collections.Generic.List<string> list;
										list.Add(xmlNode7.InnerText);
										num = (short)1977679875;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_E49:
									num = (short)819462148;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_E14:
									goto IL_E49;
								}
								IL_E9B:
								goto IL_19C;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_EBD;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_EAA:
									switch (num2)
									{
									case 0:
										goto IL_F14;
									case 1:
										if (disposable != null)
										{
											num = (short)28770306;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_F16;
									case 2:
										disposable.Dispose();
										num = (short)1464336384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_EBD;
								}
								IL_F14:
								IL_F16:
								goto EndFinally_44;
								IL_EBD:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1646329857;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_EAA;
								EndFinally_44:;
							}
							goto IL_F17;
						case 17:
							goto IL_1D9;
						case 18:
						{
							global::System.Xml.XmlNode xmlNode4;
							global::System.Collections.IEnumerator enumerator = xmlNode4.ChildNodes.GetEnumerator();
							num = (short)717160464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
							goto IL_293;
						case 20:
						{
							global::System.Xml.XmlNode xmlNode4;
							if (xmlNode4 != null)
							{
								num = (short)427753490;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19C;
						}
						case 21:
							goto IL_668;
						case 22:
							if (this.d.Count != 0)
							{
								num = (short)451018756;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_330;
						}
						goto IL_95;
						IL_19C:
						num = (short)1785856000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_293:
						xpath = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("⿿ⴁ栃瘅椇椉朋ℍ紏猑稓缕縗缙漛樝༟", a_) + str + global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("⿿漁欃戅洇昉", a_);
						num = (short)1950220300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_668:
						num = (short)1081278474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D98:
						num = (short)280100869;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1D9:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
					IL_225:
					goto IL_330;
					Block_8:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
					IL_330:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
					IL_6A8:
					IL_F17:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
					IL_FC3:
					break;
					IL_95:
					documentElement = A_0.DocumentElement;
					xmlNode3 = documentElement.SelectSingleNode(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("⿿ⴁ栃瘅椇椉朋ℍ礏瘑怓眕缗㔙甛稝", a_));
					num = (short)1826488335;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				}
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_InvalidData);
			}
			num = (short)1735327745;
			if (num != 0)
			{
			}
			num = (short)1524432896;
			short num4 = num;
		}

		// Token: 0x04000081 RID: 129
		private string a;

		// Token: 0x04000082 RID: 130
		private string b;

		// Token: 0x04000083 RID: 131
		private string c;

		// Token: 0x04000084 RID: 132
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.g.a> d;

		// Token: 0x04000085 RID: 133
		private string e;

		// Token: 0x04000086 RID: 134
		private string f;

		// Token: 0x04000087 RID: 135
		private string g;

		// Token: 0x04000088 RID: 136
		private string h;

		// Token: 0x04000089 RID: 137
		private bool i;

		// Token: 0x02000020 RID: 32
		public class a
		{
			// Token: 0x06000108 RID: 264 RVA: 0x0001E8D4 File Offset: 0x0001CAD4
			public a(string A_0, int A_1, bool A_2)
			{
				this.a = A_0;
				this.b = A_1;
				this.c = A_2;
			}

			// Token: 0x0400008A RID: 138
			public string a;

			// Token: 0x0400008B RID: 139
			public int b;

			// Token: 0x0400008C RID: 140
			private bool c;
		}
	}
}
