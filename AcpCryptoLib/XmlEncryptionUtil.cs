using System;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace AcpCryptoLib
{
	// Token: 0x0200001D RID: 29
	public class XmlEncryptionUtil
	{
		// Token: 0x06000076 RID: 118 RVA: 0x0000C310 File Offset: 0x0000A510
		public static void EncryptXmlDoc(global::System.Xml.XmlDocument doc, string rsaXmlKey)
		{
			int a_ = 3;
			short num = (short)1068433408;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 1:
					goto IL_54;
				case 2:
				{
					if (!string.IsNullOrEmpty(rsaXmlKey))
					{
						goto IL_130;
					}
					num = (short)962723841;
					if (num != 0)
					{
					}
					num = (short)209760213;
					short num3 = num;
					num = (short)695578581;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_117;
					default:
						num = (short)1198063616;
						if (num != 0)
						{
						}
						num = (short)641335299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_117;
				}
				IL_3D:
				if (doc == null)
				{
					num = (short)2112028673;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1896022018;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_54:
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("昁欃攅", a_));
			IL_117:
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("瀁眃朅倇有怋䔍甏欑", a_));
			IL_130:
			num = (short)1979580416;
			short num4 = num;
			string name = doc.DocumentElement.Name;
			global::AcpCryptoLib.XmlEncryptionUtil.EncryptXmlDoc(doc, name, rsaXmlKey);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000C48C File Offset: 0x0000A68C
		public static void EncryptXmlDoc(global::System.Xml.XmlDocument doc, string xmlElementToEncrypt, string rsaXmlKey)
		{
			int a_ = 4;
			short num = (short)2066939905;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)795607040;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)53215233;
					if (num != 0)
					{
					}
					if (string.IsNullOrEmpty(xmlElementToEncrypt))
					{
						num = (short)1022689282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C6;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				case 2:
				{
					num = (short)1929643171;
					short num4 = num;
					num = (short)1045628067;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_23B;
					}
					break;
				}
				case 3:
					goto IL_89;
				case 4:
					try
					{
						global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
						rsacryptoServiceProvider.FromXmlString(rsaXmlKey);
						global::AcpCryptoLib.XmlEncryptionUtil.a(doc, xmlElementToEncrypt, rsacryptoServiceProvider, global::AcpCryptoLib.XmlEncryptionUtil.b("焂瘄昆䈈渊琌", a_));
						return;
					}
					finally
					{
						num = (short)919601152;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_190;
								}
								continue;
							case 1:
								((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
								num = (short)1857355778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1C3;
							}
							IL_190:
							if (rsacryptoServiceProvider == null)
							{
								break;
							}
							num = (short)2067988481;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1C3:;
					}
					goto IL_1C6;
				case 5:
				{
					if (string.IsNullOrEmpty(rsaXmlKey))
					{
						num = (short)1328152582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider();
					num = (short)1967456260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_202;
				}
				IL_71:
				if (doc == null)
				{
					num = (short)1194524675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1453588480;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C6:
				num = (short)1313275909;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_89:
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("朂樄搆", a_));
			IL_202:
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("焂瘄昆儈昊愌䐎琐樒", a_));
			IL_23B:
			num = (short)915668992;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("笂栄欆䰈朊栌戎琐紒愔䌖瘘帚猜簞匠娢唤匦", a_));
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000C710 File Offset: 0x0000A910
		public static void DecryptXmlDoc(global::System.Xml.XmlDocument doc, string keyContainerName)
		{
			int a_ = 6;
			short num = (short)69596594;
			short num2 = num;
			num = (short)1863775666;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_23C:
				num = (short)1530265600;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1009778688;
				if (num != 0)
				{
				}
				num = (short)1783693313;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)1274806273;
					if (num != 0)
					{
					}
					if (string.IsNullOrEmpty(keyContainerName))
					{
						num = (short)1239613443;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					string name = doc.DocumentElement.Name;
					global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider(new global::System.Security.Cryptography.CspParameters
					{
						KeyContainerName = keyContainerName
					});
					num = (short)1752367108;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_8C;
					}
					continue;
				case 2:
					goto IL_CF;
				case 3:
					goto IL_299;
				case 4:
					goto IL_2D4;
				}
				IL_8C:
				num = (short)783613952;
				short num4 = num;
				if (doc != null)
				{
					goto IL_23C;
				}
				num = (short)2046427138;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_CF:
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("愄栆樈", a_));
			IL_214:
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("渄戆瀈䠊戌愎攐爒簔礖簘椚匜縞䰠䘢", a_));
			IL_299:
			goto IL_214;
			IL_2D4:
			try
			{
				switch (0)
				{
				case 0:
					goto IL_F8;
				}
				global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
				global::System.Security.Cryptography.CspKeyContainerInfo cspKeyContainerInfo;
				for (;;)
				{
					IL_DE:
					switch (num3)
					{
					case 0:
						goto IL_159;
					case 1:
						if (cspKeyContainerInfo != null)
						{
							num = (short)1349451778;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_198;
					case 2:
						num = (short)90243075;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!cspKeyContainerInfo.Exportable)
						{
							num = (short)1131675652;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_198;
					case 4:
						global::AcpCryptoLib.XmlEncryptionUtil.a(doc, rsacryptoServiceProvider, global::AcpCryptoLib.XmlEncryptionUtil.b("眄理栈䀊栌瘎", a_));
						num = (short)273743872;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F8;
				}
				IL_159:
				return;
				IL_198:
				throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䰄䤆弈䨊䄌䘎唐䰒帔刖䀘䐚东娞甠", a_));
				IL_F8:
				cspKeyContainerInfo = rsacryptoServiceProvider.CspKeyContainerInfo;
				num = (short)1843855361;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_DE;
			}
			finally
			{
				num = (short)1098448896;
				num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider;
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_1DD;
						}
						continue;
					case 1:
						((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
						num = (short)1521549314;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_211;
					}
					IL_1DD:
					if (rsacryptoServiceProvider == null)
					{
						break;
					}
					num = (short)148111361;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_211:;
			}
			goto IL_214;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000CA08 File Offset: 0x0000AC08
		private static void a(global::System.Xml.XmlDocument A_0, string A_1, global::System.Security.Cryptography.RSA A_2, string A_3)
		{
			int a_ = 5;
			short num = (short)452919296;
			switch (num)
			{
			default:
			{
				num = (short)2099707907;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_8D;
					case 1:
						goto IL_19C;
					case 2:
						if (string.IsNullOrEmpty(A_1))
						{
							num = (short)382992385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)663486465;
						if (num != 0)
						{
						}
						num = (short)1653342215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					case 4:
					{
						num = (short)1446499230;
						short num3 = num;
						num = (short)871093150;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_434;
						default:
							goto IL_146;
						}
						break;
					}
					case 5:
						goto IL_A9;
					case 6:
						if (string.IsNullOrEmpty(A_3))
						{
							num = (short)791478276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)139591685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_434;
					case 8:
						goto IL_453;
					}
					IL_71:
					if (A_0 == null)
					{
						num = (short)1773338624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1521942530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_434:
					if (A_2 == null)
					{
						num = (short)375390216;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1991311360;
						short num4 = num;
						num = (short)382664710;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_8D:
				goto IL_3CD;
				IL_A9:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_1C2;
					}
					global::System.Xml.XmlElement xmlElement;
					for (;;)
					{
						IL_1AB:
						global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm;
						switch (num2)
						{
						case 0:
							if (xmlElement != null)
							{
								num = (short)839516161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20B;
						case 1:
							goto IL_369;
						case 2:
							try
							{
								symmetricAlgorithm.KeySize = 256;
								byte[] cipherValue = new global::System.Security.Cryptography.Xml.EncryptedXml().EncryptData(xmlElement, symmetricAlgorithm, false);
								global::System.Security.Cryptography.Xml.EncryptedData encryptedData = new global::System.Security.Cryptography.Xml.EncryptedData();
								encryptedData.Type = global::AcpCryptoLib.XmlEncryptionUtil.b("氃爅簇稉㘋ℍ㼏攑挓愕㘗洙⼛〝伟倡䌣थᨧᨩᰫἭἯȱ3ᤵ䀷圹倻嬽⸿⅁权ͅ⑇⽉⅋⭍㹏♑", a_);
								encryptedData.EncryptionMethod = new global::System.Security.Cryptography.Xml.EncryptionMethod(global::AcpCryptoLib.XmlEncryptionUtil.b("氃爅簇稉㘋ℍ㼏攑挓愕㘗洙⼛〝伟倡䌣थᨧᨩᰫἭἯȱ3ᤵ䀷圹倻嬽⸿⅁权❅ⵇ㥉繋筍晏网㝓㑕㭗", a_));
								global::System.Security.Cryptography.Xml.EncryptedKey encryptedKey = new global::System.Security.Cryptography.Xml.EncryptedKey();
								byte[] cipherValue2 = global::System.Security.Cryptography.Xml.EncryptedXml.EncryptKey(symmetricAlgorithm.Key, A_2, false);
								encryptedKey.CipherData = new global::System.Security.Cryptography.Xml.CipherData(cipherValue2);
								encryptedKey.EncryptionMethod = new global::System.Security.Cryptography.Xml.EncryptionMethod(global::AcpCryptoLib.XmlEncryptionUtil.b("氃爅簇稉㘋ℍ㼏攑挓愕㘗洙⼛〝伟倡䌣थᨧᨩᰫἭἯȱ3ᤵ䀷圹倻嬽⸿⅁权㑅㭇⭉態罍ཏ村", a_));
								encryptedData.KeyInfo = new global::System.Security.Cryptography.Xml.KeyInfo();
								global::System.Security.Cryptography.Xml.KeyInfoName keyInfoName = new global::System.Security.Cryptography.Xml.KeyInfoName();
								keyInfoName.Value = A_3;
								encryptedKey.KeyInfo.AddClause(keyInfoName);
								encryptedData.KeyInfo.AddClause(new global::System.Security.Cryptography.Xml.KeyInfoEncryptedKey(encryptedKey));
								encryptedData.CipherData.CipherValue = cipherValue;
								global::System.Security.Cryptography.Xml.EncryptedXml.ReplaceElement(xmlElement, encryptedData, false);
								goto IL_38C;
							}
							finally
							{
								num = (short)763297792;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_330;
										}
										continue;
									case 1:
										((global::System.IDisposable)symmetricAlgorithm).Dispose();
										num = (short)1416101890;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_366;
									}
									IL_330:
									if (symmetricAlgorithm == null)
									{
										break;
									}
									num = (short)1762131969;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_366:;
							}
							goto IL_369;
							IL_38C:
							num = (short)731643907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_3A6;
						}
						goto IL_1C2;
						IL_369:
						symmetricAlgorithm = global::System.Security.Cryptography.Aes.Create();
						num = (short)264437762;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_20B:
					throw new global::System.Xml.XmlException(global::AcpCryptoLib.XmlEncryptionUtil.b("倃清洇⨉缋縍甏焑紓瀕焗缙砛㸝䔟両䄣䬥䴧䐩堫อ䜯匱䜳ᘵ嘷唹䠻ḽ☿ⵁㅃ⡅ⱇ", a_));
					IL_3A6:
					return;
					IL_1C2:
					xmlElement = (A_0.GetElementsByTagName(A_1)[0] as global::System.Xml.XmlElement);
					num = (short)599654400;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_1AB;
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䄃琅稇攉縋⸍甏簑眓搕愗標栛眝丟䔡У別䀧伩ఫ瘭崯帱瀳夵嬷伹儻嬽⸿㙁摃歅桇", a_) + ex.Message);
				}
				goto IL_3CD;
				IL_146:
				num = (short)2025783296;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("伃挅焇䐉洋挍甏", a_));
				IL_19C:
				throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("簃欅搇伉怋欍紏眑稓戕䰗甙夛瀝䌟倡崣嘥尧", a_));
				IL_3CD:
				throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("怃椅欇", a_));
				IL_453:
				throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("瘃甅椇䬉怋植缏怑紓戕瀗眙", a_));
			}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000CEC8 File Offset: 0x0000B0C8
		private static void a(global::System.Xml.XmlDocument A_0, global::System.Security.Cryptography.RSA A_1, string A_2)
		{
			int a_ = 0;
			short num = (short)1290207233;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1889009664;
				short num3 = num;
				switch (num2)
				{
				case 0:
					if (A_1 == null)
					{
						num = (short)1646526466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_166;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_73;
					}
					continue;
				case 2:
				{
					num = (short)200774276;
					short num4 = num;
					num = (short)1439666820;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1DA;
					}
					break;
				}
				case 3:
					goto IL_8A;
				case 4:
					try
					{
						global::System.Security.Cryptography.Xml.EncryptedXml encryptedXml = new global::System.Security.Cryptography.Xml.EncryptedXml(A_0);
						encryptedXml.AddKeyNameMapping(A_2, A_1);
						encryptedXml.DecryptDocument();
						return;
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("뫾猀焂樄甆⤈漊栌氎挐樒攔挖瀘甚稜㼞唠䬢䀤ܦ焨䘪䄬欮帰倲䀴娶尸唺䤼Ἶ汀捂", a_) + ex.Message);
					}
					goto IL_166;
				case 5:
					if (string.IsNullOrEmpty(A_2))
					{
						num = (short)154337286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)950665220;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1A0;
				}
				IL_73:
				if (A_0 == null)
				{
					num = (short)726859779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1668808705;
				if (num != 0)
				{
				}
				num = (short)1027932160;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_166:
				num = (short)1220673541;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8A:
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("鯾渀怂", a_));
			IL_1A0:
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("듾搀稂䬄昆搈渊", a_));
			IL_1DA:
			num = (short)247726080;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("뻾洀搂", a_));
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000D0FC File Offset: 0x0000B2FC
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(372090710 + A_1) + (global::System.IntPtr)43 + (global::System.IntPtr)29 + (global::System.IntPtr)55 + (global::System.IntPtr)41);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}
	}
}
