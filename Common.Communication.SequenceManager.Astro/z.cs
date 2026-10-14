using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using AcpCryptoLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000017 RID: 23
	internal class z
	{
		// Token: 0x060000DD RID: 221 RVA: 0x0001B3F0 File Offset: 0x000195F0
		public string j()
		{
			short num = (short)1399151216;
			short num2 = num;
			num = (short)1240554096;
			switch (num2 == num)
			{
			}
			num = (short)147521536;
			if (num != 0)
			{
			}
			num = (short)687865856;
			short num3 = num;
			num = (short)167247873;
			if (num != 0)
			{
			}
			return this.c;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001B4A0 File Offset: 0x000196A0
		public z(string A_0, global::Motorola.Common.Communication.CommonUtil.ModelType A_1, string A_2)
		{
			int a_ = 7;
			this.a = string.Empty;
			this.c = global::System.IO.Path.GetTempPath();
			this.d = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.z.a>();
			this.f = global::Motorola.Common.Communication.Crc32.c("캡얣좥쾧蒩솫삭횯", a_);
			this.g = global::Motorola.Common.Communication.Crc32.c("캡얣좥쾧蒩슫쮭잯", a_);
			base..ctor();
			if (string.IsNullOrEmpty(A_2))
			{
				this.a = global::Motorola.Common.Communication.Crc32.c("쪣솥쒧쎩\udfab욭", a_);
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
			this.c = this.c + global::System.Guid.NewGuid().ToString().Replace(global::Motorola.Common.Communication.Crc32.c("辡", a_), "") + global::Motorola.Common.Communication.Crc32.c("ﺡ", a_);
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

		// Token: 0x060000DF RID: 223 RVA: 0x0001B5FC File Offset: 0x000197FC
		private string j(string A_0, string A_1)
		{
			int a_ = 17;
			short num;
			string result;
			try
			{
				num = (short)1847918593;
				if (num != 0)
				{
				}
				num = (short)2056235920;
				short num2 = num;
				num = (short)324053904;
				switch (num2 == num)
				{
				}
				num = (short)1195442176;
				if (num != 0)
				{
				}
				string text = A_0 + global::Motorola.Common.Communication.Crc32.c("잫", a_);
				byte[] bytes = new global::System.Text.UTF8Encoding().GetBytes(A_1);
				this.j(bytes, text, true, global::System.IO.FileMode.Create);
				result = text;
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Write_LangManifestFile_Failed);
			}
			num = (short)1421737984;
			short num3 = num;
			return result;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0001B6F8 File Offset: 0x000198F8
		private void j(byte[] A_0, string A_1, bool A_2, global::System.IO.FileMode A_3)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_76;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_13:
				num = (short)1096155137;
				if (num != 0)
				{
				}
				num = (short)249233408;
				short num2 = num;
				global::System.IO.FileStream fileStream;
				switch (num3)
				{
				case 0:
					try
					{
						global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(fileStream, global::System.Text.Encoding.UTF8);
						try
						{
							num = (short)1717239810;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_170;
								case 1:
									goto IL_194;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_FD;
									}
									continue;
								case 3:
									num = (short)557252612;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (A_3 != global::System.IO.FileMode.Append)
									{
										num = (short)1777008645;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_175;
								case 5:
									binaryWriter.Write(new global::AcpCryptoLib.AcpEncryptDecrypt().Encrypt(A_0));
									num = (short)360251392;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_FD:
								if (A_2)
								{
									num = (short)2141913091;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_175:
								binaryWriter.Write(A_0);
								num = (short)1452998657;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_170:
							IL_194:
							return;
						}
						finally
						{
							num = (short)1794899969;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_1FF;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1CA;
									}
									continue;
								case 2:
									((global::System.IDisposable)binaryWriter).Dispose();
									num = (short)521207808;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1CA:
								if (binaryWriter == null)
								{
									break;
								}
								num = (short)1712717826;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1FF:;
						}
					}
					finally
					{
						num = (short)1287127041;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_26C;
							case 1:
								IL_218:
								switch (0)
								{
								case 0:
									goto IL_234;
								}
								continue;
							case 2:
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)1489174528;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_234:
							if (fileStream != null)
							{
								num = (short)1862008834;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_26C:
							num = (short)1533176053;
							short num4 = num;
							num = (short)1198876917;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_218;
							default:
								goto IL_2A3;
							}
						}
						IL_2A3:
						num = (short)1193476096;
						if (num != 0)
						{
						}
					}
					goto IL_2BA;
				case 1:
					if (A_0 == null)
					{
						num = (short)1138622466;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BA;
				case 2:
					goto IL_AE;
				}
				goto IL_76;
				IL_2BA:
				fileStream = new global::System.IO.FileStream(A_1, A_3, global::System.IO.FileAccess.Write);
				num = (short)1820590080;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_AE:
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Crc32.c("힟킡춣튥춧\ud9ab좭횯ힱ욳", a_));
			IL_76:
			new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			num = (short)1056112641;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0001BA30 File Offset: 0x00019C30
		public string k()
		{
			short num = (short)1301222033;
			short num2 = num;
			num = (short)523637393;
			switch (num2 == num)
			{
			}
			num = (short)1570635777;
			if (num != 0)
			{
			}
			num = (short)628424704;
			short num3 = num;
			num = (short)1682112512;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0001BADC File Offset: 0x00019CDC
		public string l()
		{
			short num = (short)344585957;
			short num2 = num;
			num = (short)859698917;
			switch (num2 == num)
			{
			}
			num = (short)2066546689;
			if (num != 0)
			{
			}
			num = (short)1599078400;
			short num3 = num;
			num = (short)2113273856;
			if (num != 0)
			{
			}
			return this.h;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0001BB88 File Offset: 0x00019D88
		public string m()
		{
			short num = (short)710306194;
			short num2 = num;
			num = (short)952527250;
			switch (num2 == num)
			{
			}
			num = (short)1042743296;
			if (num != 0)
			{
			}
			num = (short)479133696;
			short num3 = num;
			num = (short)716898305;
			if (num != 0)
			{
			}
			return this.e;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0001BC38 File Offset: 0x00019E38
		public string n()
		{
			short num = (short)78941122;
			short num2 = num;
			num = (short)1313049538;
			switch (num2 == num)
			{
			}
			num = (short)281280512;
			if (num != 0)
			{
			}
			num = (short)2070347776;
			short num3 = num;
			num = (short)1706295297;
			if (num != 0)
			{
			}
			return this.f;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0001BCE8 File Offset: 0x00019EE8
		public string o()
		{
			short num = (short)2040445262;
			short num2 = num;
			num = (short)657570126;
			switch (num2 == num)
			{
			}
			num = (short)337903617;
			if (num != 0)
			{
			}
			num = (short)1575682048;
			short num3 = num;
			num = (short)1377435648;
			if (num != 0)
			{
			}
			return this.g;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0001BD98 File Offset: 0x00019F98
		public string p()
		{
			short num = (short)563978232;
			short num2 = num;
			num = (short)1031577592;
			switch (num2 == num)
			{
			}
			num = (short)1321664513;
			if (num != 0)
			{
			}
			num = (short)1926365184;
			short num3 = num;
			num = (short)893255680;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0001BE48 File Offset: 0x0001A048
		public bool q()
		{
			short num = (short)717820559;
			short num2 = num;
			num = (short)1673532047;
			switch (num2 == num)
			{
			}
			num = (short)348061696;
			if (num != 0)
			{
			}
			num = (short)2111438848;
			short num3 = num;
			num = (short)960495617;
			if (num != 0)
			{
			}
			return this.i;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		private void j(global::System.Xml.XmlDocument A_0, global::Motorola.Common.Communication.CommonUtil.ModelType A_1, string A_2)
		{
			int a_ = 4;
			short num;
			try
			{
				num = (short)1056047104;
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
					global::System.Xml.XmlNode documentElement;
					global::System.Xml.XmlNode xmlNode6;
					for (;;)
					{
						IL_31:
						string str;
						string xpath;
						switch (num2)
						{
						case 0:
							goto IL_623;
						case 1:
						{
							xpath = global::Motorola.Common.Communication.Crc32.c("낞躠쾢햤욦쪨삪芬슮킰\uddb2\udcb4톶\udcb8좺즼邾", a_) + str + global::Motorola.Common.Communication.Crc32.c("낞철첢솤슦얨욮햰躲銴\udcb8\uddba\udcbc쪾귀럂髆", a_);
							global::System.Xml.XmlNode xmlNode = documentElement.SelectSingleNode(xpath);
							num = (short)1436221461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							if (A_1 == global::Motorola.Common.Communication.CommonUtil.ModelType.Mobile)
							{
								num = (short)1632829446;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							str = global::Motorola.Common.Communication.Crc32.c("캠톢톤욦쮨잪좬", a_);
							num = (short)1442185231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							try
							{
								num = (short)1020133377;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_D02;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_71B;
										}
										continue;
									case 2:
									{
										string a_2;
										if (!(a_2 == string.Empty))
										{
											num = (short)1306066948;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_B5F;
									}
									case 3:
									{
										string value;
										if (value == string.Empty)
										{
											num = (short)86310912;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string a_2;
										int a_3;
										bool flag;
										global::Motorola.Common.Communication.z.a value2 = new global::Motorola.Common.Communication.z.a(a_2, a_3, flag);
										string text;
										this.d.Add(text, value2);
										num = (short)636813323;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										num = (short)245891075;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										global::System.Xml.XmlNode xmlNode2;
										global::System.Collections.IEnumerator enumerator = xmlNode2.ChildNodes.GetEnumerator();
										num = (short)818610186;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										num = (short)1798766599;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_D1F;
									case 8:
									{
										global::System.Collections.IEnumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1102446598;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator2.Current;
										string text = ((global::System.Xml.XmlElement)xmlNode2).GetAttribute(global::Motorola.Common.Communication.Crc32.c("얠", a_));
										num = (short)1872297993;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
									{
										string text;
										global::System.Collections.Generic.List<string> list;
										if (list.Contains(text))
										{
											num = (short)486932485;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
										try
										{
											num = (short)423755792;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													num = (short)1920139267;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
												{
													global::System.Xml.XmlNode xmlNode3;
													if (xmlNode3.Name == global::Motorola.Common.Communication.Crc32.c("좠\ud9a2삤", a_))
													{
														num = (short)1102905362;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_86F;
												}
												case 2:
												{
													global::System.Collections.IEnumerator enumerator;
													if (!enumerator.MoveNext())
													{
														num = (short)1920532494;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::System.Xml.XmlNode xmlNode3 = (global::System.Xml.XmlNode)enumerator.Current;
													num = (short)1279787027;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
												{
													global::System.Xml.XmlNode xmlNode3;
													if (!string.IsNullOrEmpty(xmlNode3.InnerText))
													{
														num = (short)1487536139;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_8C0;
												}
												case 4:
													goto IL_8C0;
												case 5:
													goto IL_86F;
												case 6:
													num = (short)1085014028;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 7:
												{
													global::System.Xml.XmlNode xmlNode3;
													bool flag = global::System.Convert.ToBoolean(xmlNode3.InnerText);
													num = (short)706215944;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 8:
												{
													bool flag;
													if (flag)
													{
														num = (short)959053833;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 9:
													this.i = true;
													num = (short)1118175242;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 11:
												{
													global::System.Xml.XmlNode xmlNode3;
													string a_2 = xmlNode3.InnerText;
													num = (short)1139474436;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 12:
												{
													num = (short)342983566;
													short num3 = num;
													num = (short)444302222;
													switch ((num3 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_AE3;
													default:
													{
														num = (short)1809121280;
														if (num != 0)
														{
														}
														global::System.Xml.XmlNode xmlNode3;
														if (!string.IsNullOrEmpty(xmlNode3.InnerText))
														{
															num = (short)1142685703;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														break;
													}
													}
													break;
												}
												case 13:
												{
													global::System.Xml.XmlNode xmlNode3;
													string value = xmlNode3.InnerText;
													int a_3 = global::System.Convert.ToInt32(value);
													num = (short)1656946693;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 14:
													num = (short)889651217;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 15:
												{
													global::System.Xml.XmlNode xmlNode3;
													if (xmlNode3.Name == global::Motorola.Common.Communication.Crc32.c("ﲞ펠쪢톤캦쪨쪪솬类솰ힲ풴쎶\udcb8", a_))
													{
														num = (short)2144862214;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 16:
													switch (0)
													{
													case 0:
														goto IL_79A;
													}
													continue;
												case 17:
													goto IL_AE3;
												case 18:
													num = (short)1832386580;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 19:
												{
													global::System.Xml.XmlNode xmlNode3;
													if (xmlNode3.Name == global::Motorola.Common.Communication.Crc32.c("咽좠쾢삤즦좨욪좬", a_))
													{
														num = (short)1096155136;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_8C0;
												}
												case 20:
												{
													global::System.Xml.XmlNode xmlNode3;
													if (!string.IsNullOrEmpty(xmlNode3.InnerText))
													{
														num = (short)1285947405;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_86F;
												}
												}
												goto IL_79A;
												IL_86F:
												num = (short)77463567;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_8C0:
												num = (short)1477246977;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_9CA:
												num = (short)1261043714;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_79A:
												goto IL_9CA;
											}
											IL_AE3:
											goto IL_C7D;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_B05;
											}
											global::System.IDisposable disposable;
											for (;;)
											{
												IL_AF2:
												switch (num2)
												{
												case 0:
													disposable.Dispose();
													num = (short)1899298818;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													if (disposable != null)
													{
														num = (short)1966538752;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_B5E;
												case 2:
													goto IL_B5C;
												}
												goto IL_B05;
											}
											IL_B5C:
											IL_B5E:
											goto EndFinally_47;
											IL_B05:
											global::System.Collections.IEnumerator enumerator;
											disposable = (enumerator as global::System.IDisposable);
											num = (short)2023751681;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_AF2;
											EndFinally_47:;
										}
										goto IL_B5F;
										IL_C7D:
										num = (short)1469579266;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_B6A:
									num = (short)1700659208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_71B:
									goto IL_B6A;
								}
								IL_B5F:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
								IL_D02:
								goto IL_B5F;
								IL_D1F:
								goto IL_2F3;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_D41;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_D2E:
									switch (num2)
									{
									case 0:
										disposable.Dispose();
										num = (short)963051522;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										if (disposable != null)
										{
											num = (short)1987248128;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_D9A;
									case 2:
										goto IL_D98;
									}
									goto IL_D41;
								}
								IL_D98:
								IL_D9A:
								goto EndFinally_48;
								IL_D41:
								global::System.Collections.IEnumerator enumerator2;
								disposable = (enumerator2 as global::System.IDisposable);
								num = (short)2062483457;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_D2E;
								EndFinally_48:;
							}
							goto IL_D9B;
							IL_2F3:
							num = (short)225968142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_299;
						case 5:
						{
							global::System.Collections.Generic.List<string> list;
							if (this.d.Count != list.Count)
							{
								num = (short)2008416267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.e = this.j(this.c + this.f, string.Empty);
							num = (short)2074083341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							str = global::Motorola.Common.Communication.Crc32.c("캠솢첤쮦첨", a_);
							num = (short)1761673220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							try
							{
								num = (short)163840003;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Xml.XmlNode xmlNode4;
										if (((global::System.Xml.XmlElement)xmlNode4).GetAttribute(global::Motorola.Common.Communication.Crc32.c("얠", a_)) == A_2)
										{
											num = (short)1077542914;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										goto IL_5A7;
									case 2:
									{
										global::System.Xml.XmlNode xmlNode4;
										global::System.Collections.IEnumerator enumerator = xmlNode4.ChildNodes.GetEnumerator();
										num = (short)616366086;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_384;
										}
										continue;
									case 4:
									{
										global::System.Collections.IEnumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)245563397;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode4 = (global::System.Xml.XmlNode)enumerator2.Current;
										num = (short)681705472;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_58E;
									case 6:
										try
										{
											num = (short)587988994;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													num = (short)2060648449;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													goto IL_513;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_48C;
													}
													continue;
												case 4:
												{
													global::System.Collections.IEnumerator enumerator;
													if (!enumerator.MoveNext())
													{
														num = (short)347078656;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::System.Xml.XmlNode xmlNode5 = (global::System.Xml.XmlNode)enumerator.Current;
													global::System.Collections.Generic.List<string> list;
													list.Add(xmlNode5.InnerText);
													num = (short)727252995;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_4C2:
												num = (short)1281818628;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_48C:
												goto IL_4C2;
											}
											IL_513:;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_532;
											}
											global::System.IDisposable disposable;
											for (;;)
											{
												IL_51F:
												switch (num2)
												{
												case 0:
													goto IL_58B;
												case 1:
													if (disposable != null)
													{
														num = (short)1769406466;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_58D;
												case 2:
													disposable.Dispose();
													num = (short)313982976;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_532;
											}
											IL_58B:
											IL_58D:
											goto EndFinally_45;
											IL_532:
											global::System.Collections.IEnumerator enumerator;
											disposable = (enumerator as global::System.IDisposable);
											num = (short)1912274945;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_51F;
											EndFinally_45:;
										}
										goto IL_58E;
									}
									IL_386:
									num = (short)1402929156;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_384:
									goto IL_386;
									IL_58E:
									num = (short)1934753793;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_5A7:
								goto IL_D9B;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_5C9;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_5B6:
									switch (num2)
									{
									case 0:
										goto IL_620;
									case 1:
										if (disposable != null)
										{
											num = (short)701628418;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_622;
									case 2:
										disposable.Dispose();
										num = (short)1266876416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5C9;
								}
								IL_620:
								IL_622:
								goto EndFinally_46;
								IL_5C9:
								global::System.Collections.IEnumerator enumerator2;
								disposable = (enumerator2 as global::System.IDisposable);
								num = (short)821428225;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_5B6;
								EndFinally_46:;
							}
							goto IL_623;
						case 8:
							if (xmlNode6 != null)
							{
								num = (short)517144576;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F20;
						case 9:
						{
							global::System.Xml.XmlNode xmlNode;
							global::System.Collections.IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
							num = (short)1162084371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_664;
						case 11:
							goto IL_22C;
						case 12:
						{
							global::System.Collections.Generic.List<string> list;
							if (list.Count == 0)
							{
								num = (short)1532755969;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A0;
						}
						case 13:
							goto IL_FCC;
						case 14:
							if (this.d.Count != 0)
							{
								num = (short)1173684240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_337;
						case 15:
							goto IL_299;
						case 16:
							num = (short)1811677189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							goto IL_1DF;
						case 18:
							if (string.IsNullOrEmpty(xmlNode6.InnerText))
							{
								num = (short)2013593610;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.b = xmlNode6.InnerText;
							str = string.Empty;
							num = (short)1868038146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							try
							{
								num = (short)1001783299;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1832124420;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Collections.IEnumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1843134464;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode7 = (global::System.Xml.XmlNode)enumerator2.Current;
										global::System.Collections.Generic.List<string> list;
										list.Add(xmlNode7.InnerText);
										num = (short)1973747714;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_E1A;
										}
										continue;
									case 4:
										goto IL_EA3;
									}
									IL_E50:
									num = (short)1106968577;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_E1A:
									goto IL_E50;
								}
								IL_EA3:
								goto IL_1A0;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_EC5;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_EB2:
									switch (num2)
									{
									case 0:
										disposable.Dispose();
										num = (short)144048130;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										if (disposable != null)
										{
											num = (short)1470300160;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_F1F;
									case 2:
										goto IL_F1D;
									}
									goto IL_EC5;
								}
								IL_F1D:
								IL_F1F:
								goto EndFinally_44;
								IL_EC5:
								global::System.Collections.IEnumerator enumerator2;
								disposable = (enumerator2 as global::System.IDisposable);
								num = (short)1224343553;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_EB2;
								EndFinally_44:;
							}
							goto IL_F20;
						case 20:
						{
							global::System.Collections.Generic.List<string> list;
							if (list.Count == 0)
							{
								num = (short)1231683601;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.d = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.z.a>();
							string a_2 = string.Empty;
							string value = string.Empty;
							string text = string.Empty;
							int a_3 = 0;
							bool flag = false;
							this.i = false;
							global::System.Collections.IEnumerator enumerator2 = documentElement.SelectNodes(global::Motorola.Common.Communication.Crc32.c("낞躠쾢햤욦쪨삪芬쮮킰잲풴颶\udfb8튺톼\udabe", a_)).GetEnumerator();
							num = (short)896401411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
						{
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode != null)
							{
								num = (short)612106249;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A0;
						}
						case 22:
						{
							global::System.Xml.XmlNodeList xmlNodeList = documentElement.SelectNodes(xpath);
							string empty = string.Empty;
							global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
							if (xmlNodeList == null)
							{
								goto Block_8;
							}
							global::System.Collections.IEnumerator enumerator2 = xmlNodeList.GetEnumerator();
							num = (short)1395326983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_94;
						IL_1A0:
						num = (short)2082078740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_299:
						xpath = global::Motorola.Common.Communication.Crc32.c("낞躠쾢햤욦쪨삪芬슮킰\uddb2\udcb4톶\udcb8좺즼邾", a_) + str + global::Motorola.Common.Communication.Crc32.c("낞철첢솤슦얨", a_);
						num = (short)1516699670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_623:
						num = (short)1596391442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D9B:
						num = (short)703528972;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1DF:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
					IL_22C:
					goto IL_337;
					Block_8:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
					IL_337:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
					IL_664:
					IL_F20:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
					IL_FCC:
					break;
					IL_94:
					documentElement = A_0.DocumentElement;
					xmlNode6 = documentElement.SelectSingleNode(global::Motorola.Common.Communication.Crc32.c("낞躠쾢햤욦쪨삪芬욮햰잲풴킶隸튺\ud9bc", a_));
					num = (short)2077556744;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_InvalidData);
			}
			num = (short)1983053824;
			short num4 = num;
			num = (short)774176769;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000099 RID: 153
		private string a;

		// Token: 0x0400009A RID: 154
		private string b;

		// Token: 0x0400009B RID: 155
		private string c;

		// Token: 0x0400009C RID: 156
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.z.a> d;

		// Token: 0x0400009D RID: 157
		private string e;

		// Token: 0x0400009E RID: 158
		private string f;

		// Token: 0x0400009F RID: 159
		private string g;

		// Token: 0x040000A0 RID: 160
		private string h;

		// Token: 0x040000A1 RID: 161
		private bool i;

		// Token: 0x02000018 RID: 24
		public class a
		{
			// Token: 0x060000E9 RID: 233 RVA: 0x0001CFC4 File Offset: 0x0001B1C4
			public a(string A_0, int A_1, bool A_2)
			{
				this.a = A_0;
				this.b = A_1;
				this.c = A_2;
			}

			// Token: 0x040000A2 RID: 162
			public string a;

			// Token: 0x040000A3 RID: 163
			public int b;

			// Token: 0x040000A4 RID: 164
			private bool c;
		}
	}
}
