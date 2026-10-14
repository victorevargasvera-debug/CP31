using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using AcpCryptoLib;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000015 RID: 21
	internal sealed class d
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00016460 File Offset: 0x00014660
		public d(global::Motorola.Common.Communication.Pba.LanguagePackData A_0)
		{
			this.b = A_0;
			this.a = null;
			this.c = null;
			this.b();
			this.a();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00016494 File Offset: 0x00014694
		public d()
		{
			this.b = null;
			this.a = null;
			this.c = null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000164BC File Offset: 0x000146BC
		private void b()
		{
			short num = (short)563609600;
			short num2 = num;
			num = (short)1858207749;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_DA;
				case 1:
					num = (short)1799225345;
					if (num != 0)
					{
					}
					if (this.b.LanguagePacks.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, bool>(global::Motorola.Common.Communication.d.<>c.<>9.a)))
					{
						num = (short)58195968;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_303;
				case 2:
					num = (short)187957249;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_F2;
				case 4:
					try
					{
						num = (short)1293811720;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
							switch (num3)
							{
							case 0:
								num = (short)1624244226;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::AcpCryptoLib.AcpXMLEncryptDecrypt acpXMLEncryptDecrypt = new global::AcpCryptoLib.AcpXMLEncryptDecrypt();
								this.a = acpXMLEncryptDecrypt.DecryptXMLFile(astroFilePackInfo.encFileName);
								goto IL_284;
							}
							case 2:
								if (global::System.IO.File.Exists(astroFilePackInfo.encFileName))
								{
									num = (short)1553006593;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_195;
							case 3:
								if (astroFilePackInfo != null)
								{
									num = (short)35717125;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_195;
							case 4:
								if (!string.IsNullOrEmpty(astroFilePackInfo.encFileName))
								{
									num = (short)1481834496;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_195;
							case 5:
								num = (short)1399521284;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								num = (short)1476132871;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_2F5;
							case 8:
								switch (0)
								{
								case 0:
									goto IL_167;
								}
								continue;
							}
							IL_167:
							astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.b.LanguagePacks.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(global::Motorola.Common.Communication.d.<>c.<>9.b));
							num = (short)667016274;
							short num4 = num;
							num = (short)1329388626;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_284:
								num = (short)1196228614;
								num3 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1515716608;
								if (num != 0)
								{
								}
								num = (short)112984067;
								num3 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_195:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
						IL_2F5:
						return;
					}
					catch
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
					}
					goto IL_303;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				}
				IL_66:
				if (this.b != null)
				{
					num = (short)73400322;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_DA:
				num = (short)1789526019;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_303:
				this.a = null;
				num = (short)1615069188;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F2:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00016828 File Offset: 0x00014A28
		private void a()
		{
			short num = (short)1296826368;
			short num2 = num;
			num = (short)607322117;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)1558511617;
					if (num != 0)
					{
					}
					goto IL_AF;
				case 1:
					if (this.b.LanguagePacks.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, bool>(global::Motorola.Common.Communication.d.<>c.<>9.c)))
					{
						num = (short)728039424;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F7;
				case 2:
					num = (short)267911169;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_C4;
				case 4:
					try
					{
						num = (short)1314258952;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
							switch (num3)
							{
							case 0:
								num = (short)277807106;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								this.a(out this.c, astroFilePackInfo.encFileName, true);
								goto IL_276;
							case 2:
								if (global::System.IO.File.Exists(astroFilePackInfo.encFileName))
								{
									num = (short)2060779521;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_18B;
							case 3:
								if (astroFilePackInfo != null)
								{
									num = (short)418643973;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_18B;
							case 4:
								if (!string.IsNullOrEmpty(astroFilePackInfo.encFileName))
								{
									num = (short)68616192;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_18B;
							case 5:
								num = (short)1182203908;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								num = (short)1493434375;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_2E9;
							case 8:
								switch (0)
								{
								case 0:
									goto IL_15D;
								}
								continue;
							}
							IL_15D:
							astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.b.LanguagePacks.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(global::Motorola.Common.Communication.d.<>c.<>9.d));
							num = (short)1833296415;
							short num4 = num;
							num = (short)398254623;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_276:
								num = (short)738852870;
								num3 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)2092761088;
								if (num != 0)
								{
								}
								num = (short)709296131;
								num3 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_18B:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
						IL_2E9:
						return;
					}
					catch
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
					}
					goto IL_2F7;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				}
				IL_64:
				if (this.b != null)
				{
					num = (short)1953693698;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AF:
				num = (short)382795779;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F7:
				this.c = null;
				num = (short)933822468;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_C4:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00016B88 File Offset: 0x00014D88
		public byte[] a(global::Motorola.Common.Communication.Pba.AstroFilePackInfo A_0)
		{
			short num = (short)516554754;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				byte[] result;
				switch (num2)
				{
				case 0:
					goto IL_9E;
				case 1:
					try
					{
						num = (short)168951813;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_162;
							case 1:
								if (global::System.IO.File.Exists(A_0.encFileName))
								{
									num = (short)55771139;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_164;
							case 2:
								num = (short)322437121;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								this.a(out result, A_0.encFileName, true);
								num = (short)50069504;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								num = (short)1716675484;
								short num3 = num;
								num = (short)161244060;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_162;
								default:
									goto IL_1B2;
								}
								break;
							}
							case 5:
								switch (0)
								{
								case 0:
									goto IL_DF;
								}
								continue;
							}
							IL_DF:
							if (!string.IsNullOrEmpty(A_0.encFileName))
							{
								num = (short)704577538;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_164:
							num = (short)1039204356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_162:
							goto IL_164;
						}
						IL_1B2:
						num = (short)676462592;
						if (num != 0)
						{
						}
						return result;
					}
					catch
					{
						return null;
					}
					goto IL_1CF;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)845873153;
				if (num != 0)
				{
				}
				num = (short)1703084032;
				short num4 = num;
				if (A_0 == null)
				{
					num = (short)1512898560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1CF:
				result = null;
				num = (short)1516044289;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9E:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00016DA8 File Offset: 0x00014FA8
		public byte[] b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo A_0)
		{
			int a_ = 4;
			short num = (short)1017053184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1298792454;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1341390848;
						short num3 = num;
						num = (short)1808203780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_593;
					case 2:
						if (this.a != null)
						{
							num = (short)2145320960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4ED;
					case 3:
						num = (short)781123586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (this.c == null)
						{
							num = (short)221708289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array = null;
						num = (short)1681457157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_5B2;
					case 6:
						num = (short)255262721;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_92;
						}
						continue;
					}
					IL_92:
					if (A_0 == null)
					{
						break;
					}
					num = (short)314507267;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4ED:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_593:
				goto IL_4ED;
				IL_5B2:
				try
				{
					num = (short)155582472;
					num2 = (int)((global::System.IntPtr)num);
					byte[] array;
					for (;;)
					{
						global::System.Xml.XmlNode xmlNode;
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.IEnumerator enumerator = xmlNode.ChildNodes.GetEnumerator();
							num = (short)234291201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							try
							{
								num = (short)1539112970;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Xml.XmlNode xmlNode2;
										if (xmlNode2.Name.Equals(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鋳鿵铷鿹鋻鿽淿朁", a_)))
										{
											num = (short)1761280007;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2AB;
									}
									case 1:
									{
										global::System.Xml.XmlNode xmlNode2;
										if (xmlNode2.InnerText.Equals(global::System.IO.Path.GetFileName(A_0.sourceFilePath)))
										{
											num = (short)1581645830;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_35C;
									}
									case 2:
									{
										global::System.Xml.XmlNode xmlNode2;
										if (xmlNode2.Name.Equals(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("蓳韵臷雹鏻鿽擿", a_)))
										{
											num = (short)885850116;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										goto IL_35C;
									case 4:
									{
										global::System.Xml.XmlNode xmlNode2;
										array = global::System.Convert.FromBase64String(xmlNode2.InnerText);
										goto IL_304;
									}
									case 5:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1107230723;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator.Current;
										num = (short)1632589523;
										short num4 = num;
										num = (short)1823168211;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_304;
										default:
											num = (short)688717824;
											if (num != 0)
											{
											}
											num = (short)1259274240;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										goto IL_2AB;
									case 7:
										num = (short)1545666561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										goto IL_376;
									case 10:
										switch (0)
										{
										case 0:
											goto IL_1B2;
										}
										continue;
									}
									goto IL_1B2;
									IL_2AB:
									num = (short)408289282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_304:
									num = (short)1113653256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_31F:
									num = (short)583335941;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1B2:
									goto IL_31F;
									IL_35C:
									num = (short)1183514633;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_376:
								goto IL_4C8;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_398;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_385:
									switch (num2)
									{
									case 0:
										disposable.Dispose();
										num = (short)155451393;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_3EE;
									case 2:
										if (disposable != null)
										{
											num = (short)1411907584;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3F0;
									}
									goto IL_398;
								}
								IL_3EE:
								IL_3F0:
								goto EndFinally_16;
								IL_398:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)506724354;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_385;
								EndFinally_16:;
							}
							goto IL_3F1;
						case 2:
							array = new byte[this.c.Length];
							this.c.CopyTo(array, 0);
							num = (short)1508114437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_3F1;
						case 4:
							if (xmlNode != null)
							{
								num = (short)199229440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4C8;
						case 5:
							goto IL_4C8;
						case 6:
							if (A_0.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
							{
								num = (short)611057666;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4C8;
						case 7:
							goto IL_4E0;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_FD;
							}
							continue;
						}
						IL_FD:
						if (A_0.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.LanguagePack)
						{
							num = (short)1977942019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)507248646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3F1:
						xmlNode = this.a.SelectSingleNode(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("\udbf3\ud9f5铷諹鷻鷽毿ⴁ怃朅簇欉⌋栍礏縑焓䴕堗猙砛⌝ܟ", a_) + A_0.sourceFileId + global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("폳꯵", a_));
						num = (short)286982148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4C8:
						num = (short)772407303;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4E0:
					return array;
				}
				catch
				{
					return null;
				}
				goto IL_4ED;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000173A4 File Offset: 0x000155A4
		private void a(out byte[] A_0, string A_1, bool A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.IO.FileStream fileStream;
				switch (num)
				{
				case 0:
					goto IL_17C;
				case 1:
					num2 = (short)113573891;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!string.IsNullOrEmpty(A_1))
					{
						num2 = (short)1736507393;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (global::System.IO.File.Exists(A_1))
					{
						num2 = (short)1825636352;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					try
					{
						global::Motorola.Common.Communication.d.a(out A_0, fileStream, A_2);
						return;
					}
					finally
					{
						num2 = (short)1992687616;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							num2 = (short)1222462231;
							short num3 = num2;
							num2 = (short)547900183;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_17B;
							default:
								num2 = (short)324337664;
								if (num2 != 0)
								{
								}
								switch (num)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_142;
									}
									continue;
								case 1:
									goto IL_179;
								case 2:
									((global::System.IDisposable)fileStream).Dispose();
									num2 = (short)613285889;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								IL_142:
								if (fileStream == null)
								{
									goto IL_17B;
								}
								num2 = (short)1930297346;
								num = (int)((global::System.IntPtr)num2);
								break;
							}
						}
						IL_179:
						IL_17B:;
					}
					goto IL_17C;
				}
				goto IL_24;
				IL_17C:
				fileStream = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				num2 = (short)1282473988;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			num2 = (short)936312832;
			short num4 = num2;
			A_0 = null;
			num2 = (short)1622933505;
			if (num2 != 0)
			{
			}
			num2 = (short)801701890;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0001759C File Offset: 0x0001579C
		private static void a(out byte[] A_0, global::System.IO.FileStream A_1, bool A_2)
		{
			short num = (short)674006200;
			short num2 = num;
			num = (short)2042528952;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)435814400;
				short num3 = num;
				break;
			}
			}
			num = (short)67764225;
			if (num != 0)
			{
			}
			num = (short)819593216;
			if (num != 0)
			{
			}
			num = (short)1820327936;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				long num5 = A_1.Length - A_1.Position;
				global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(A_1, global::System.Text.Encoding.UTF8);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_F4;
					}
					byte[] array;
					for (;;)
					{
						IL_DD:
						switch (num4)
						{
						case 0:
							goto IL_17D;
						case 1:
							if (A_2)
							{
								num = (short)717160451;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_0 = array;
							num = (short)1135214592;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_15C;
						case 3:
						{
							global::AcpCryptoLib.AcpEncryptDecrypt acpEncryptDecrypt = new global::AcpCryptoLib.AcpEncryptDecrypt();
							A_0 = acpEncryptDecrypt.Decrypt(array);
							num = (short)784203778;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_F4;
					}
					IL_15C:
					IL_17D:
					break;
					IL_F4:
					array = new byte[num5];
					binaryReader.Read(array, 0, (int)num5);
					num = (short)1866924033;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_DD;
				}
				finally
				{
					num = (short)437256192;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1B1;
							}
							continue;
						case 1:
							goto IL_1E8;
						case 2:
							((global::System.IDisposable)binaryReader).Dispose();
							num = (short)1691090945;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1B1:
						if (binaryReader == null)
						{
							break;
						}
						num = (short)439156738;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1E8:;
				}
				break;
			}
			}
		}

		// Token: 0x04000034 RID: 52
		private global::System.Xml.XmlDocument a;

		// Token: 0x04000035 RID: 53
		private global::Motorola.Common.Communication.Pba.LanguagePackData b;

		// Token: 0x04000036 RID: 54
		private byte[] c;
	}
}
