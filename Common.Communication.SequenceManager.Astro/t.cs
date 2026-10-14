using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using AcpCryptoLib;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	internal sealed class t
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		public t(global::Motorola.Common.Communication.Pba.LanguagePackData A_0)
		{
			this.b = A_0;
			this.a = null;
			this.c = null;
			this.b();
			this.a();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000F1F0 File Offset: 0x0000D3F0
		public t()
		{
			this.b = null;
			this.a = null;
			this.c = null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000F218 File Offset: 0x0000D418
		private void b()
		{
			short num = (short)1821704192;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 1:
					if (this.b.LanguagePacks.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, bool>(global::Motorola.Common.Communication.t.<>c.<>9.a)))
					{
						num = (short)812187651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_306;
				case 2:
					try
					{
						num = (short)49348610;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
								if (!string.IsNullOrEmpty(astroFilePackInfo.encFileName))
								{
									num = (short)2128936961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_16A;
							}
							case 1:
								num = (short)326434820;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_108;
							case 3:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
								if (astroFilePackInfo != null)
								{
									num = (short)2075852801;
									if (num != 0)
									{
									}
									num = (short)1211170824;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_16A;
							}
							case 4:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
								if (global::System.IO.File.Exists(astroFilePackInfo.encFileName))
								{
									num = (short)867565574;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_16A;
							}
							case 5:
								goto IL_2F8;
							case 6:
							{
								num = (short)1201180753;
								short num3 = num;
								num = (short)2125893713;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_108;
								default:
								{
									num = (short)2025193472;
									if (num != 0)
									{
									}
									global::AcpCryptoLib.AcpXMLEncryptDecrypt acpXMLEncryptDecrypt = new global::AcpCryptoLib.AcpXMLEncryptDecrypt();
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
									this.a = acpXMLEncryptDecrypt.DecryptXMLFile(astroFilePackInfo.encFileName);
									num = (short)1101725703;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 7:
								num = (short)1071906821;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								num = (short)1428815872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_13C;
							IL_108:
							switch (0)
							{
							case 0:
							{
								IL_13C:
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.b.LanguagePacks.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(global::Motorola.Common.Communication.t.<>c.<>9.b));
								num = (short)21757955;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							}
						}
						IL_16A:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
						IL_2F8:
						return;
					}
					catch
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
					}
					goto IL_306;
				case 3:
					goto IL_87;
				case 4:
					goto IL_CA;
				case 5:
					num = (short)1391263745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				if (this.b != null)
				{
					num = (short)402063365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_87:
				num = (short)932315136;
				short num4 = num;
				num = (short)1645805572;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_306:
				this.a = null;
				num = (short)1449721858;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CA:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000F588 File Offset: 0x0000D788
		private void a()
		{
			short num = (short)820969472;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1916862465;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 1:
					if (this.b.LanguagePacks.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, bool>(global::Motorola.Common.Communication.t.<>c.<>9.c)))
					{
						num = (short)370475011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FC;
				case 2:
					try
					{
						num = (short)850657282;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
								if (!string.IsNullOrEmpty(astroFilePackInfo.encFileName))
								{
									num = (short)1690238977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_191;
							}
							case 1:
								num = (short)659423236;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_12F;
							case 3:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
								if (astroFilePackInfo != null)
								{
									num = (short)766377992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_191;
							}
							case 4:
							{
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
								if (global::System.IO.File.Exists(astroFilePackInfo.encFileName))
								{
									num = (short)681312262;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_191;
							}
							case 5:
								goto IL_2EE;
							case 6:
							{
								num = (short)1256759463;
								short num3 = num;
								num = (short)1350344871;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_12F;
								default:
								{
									num = (short)1082195968;
									if (num != 0)
									{
									}
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
									this.a(out this.c, astroFilePackInfo.encFileName, true);
									num = (short)1330970631;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 7:
								num = (short)1966800901;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								num = (short)1348599808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_163;
							IL_12F:
							switch (0)
							{
							case 0:
							{
								IL_163:
								global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.b.LanguagePacks.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(global::Motorola.Common.Communication.t.<>c.<>9.d));
								num = (short)1948712963;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							}
						}
						IL_191:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
						IL_2EE:
						return;
					}
					catch
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
					}
					goto IL_2FC;
				case 3:
					goto IL_B0;
				case 4:
					goto IL_F0;
				case 5:
					num = (short)1771175937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_63:
				if (this.b != null)
				{
					num = (short)977993733;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B0:
				num = (short)49610752;
				short num4 = num;
				num = (short)1658847236;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2FC:
				this.c = null;
				num = (short)25231362;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F0:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000F8F0 File Offset: 0x0000DAF0
		public byte[] a(global::Motorola.Common.Communication.Pba.AstroFilePackInfo A_0)
		{
			short num = (short)2123759618;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				byte[] result;
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)2053898240;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_DD;
								}
								continue;
							case 1:
							{
								num = (short)1465066831;
								short num3 = num;
								num = (short)1042490703;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1B1;
								default:
									num = (short)1534459904;
									if (num != 0)
									{
									}
									if (global::System.IO.File.Exists(A_0.encFileName))
									{
										num = (short)350224388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1B1;
								}
								break;
							}
							case 2:
								goto IL_1C9;
							case 3:
								goto IL_1B1;
							case 4:
								this.a(out result, A_0.encFileName, true);
								num = (short)1819344899;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								num = (short)1835270145;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_DD:
							if (!string.IsNullOrEmpty(A_0.encFileName))
							{
								num = (short)1048581;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1B1:
							num = (short)310444034;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1C9:
						return result;
					}
					catch
					{
						return null;
					}
					goto IL_1D0;
				case 1:
					goto IL_74;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				num = (short)2115829761;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					num = (short)1006174209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1D0:
				result = null;
				num = (short)1812398080;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_74:
			num = (short)948764672;
			short num4 = num;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000FB10 File Offset: 0x0000DD10
		public byte[] b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo A_0)
		{
			int a_ = 0;
			short num = (short)1883504640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1842385066;
				short num3 = num;
				num = (short)1104449706;
				byte[] array;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2015166464;
					if (num != 0)
					{
					}
					num = (short)72876032;
					short num4 = num;
					num = (short)279838721;
					if (num != 0)
					{
					}
					num = (short)446038017;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (this.a != null)
							{
								num = (short)1729298437;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_512;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_107;
							}
							continue;
						case 2:
							goto IL_58E;
						case 3:
							goto IL_5AB;
						case 4:
							if (this.c == null)
							{
								num = (short)452132866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array = null;
							num = (short)841875459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)31719428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)888799232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_107:
						if (A_0 == null)
						{
							break;
						}
						num = (short)1925382150;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_512:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
					IL_58E:
					goto IL_512;
					IL_5AB:
					try
					{
						num = (short)604766210;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Xml.XmlNode xmlNode;
							switch (num2)
							{
							case 0:
								if (xmlNode != null)
								{
									num = (short)630587393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4EC;
							case 1:
							{
								global::System.Collections.IEnumerator enumerator = xmlNode.ChildNodes.GetEnumerator();
								num = (short)198115334;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_172;
								}
								continue;
							case 3:
								goto IL_417;
							case 4:
								array = new byte[this.c.Length];
								this.c.CopyTo(array, 0);
								num = (short)1965490184;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_505;
							case 6:
								try
								{
									num = (short)1270546436;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::System.Xml.XmlNode xmlNode2;
											if (xmlNode2.Name.Equals(global::Motorola.Common.Communication.Crc32.c("ﲜ춠첢쒤쎦", a_)))
											{
												num = (short)519766025;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 1:
										{
											global::System.Xml.XmlNode xmlNode2;
											if (xmlNode2.Name.Equals(global::Motorola.Common.Communication.Crc32.c("ﶚ쒠춢쒤쪦첨", a_)))
											{
												num = (short)2085814277;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_2D1;
										}
										case 2:
											goto IL_384;
										case 3:
											goto IL_2D1;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_224;
											}
											continue;
										case 5:
											num = (short)174522378;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
										{
											global::System.Collections.IEnumerator enumerator;
											if (!enumerator.MoveNext())
											{
												num = (short)218890242;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator.Current;
											num = (short)2020212737;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 7:
											goto IL_39D;
										case 9:
										{
											global::System.Xml.XmlNode xmlNode2;
											array = global::System.Convert.FromBase64String(xmlNode2.InnerText);
											num = (short)1345323016;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 10:
										{
											global::System.Xml.XmlNode xmlNode2;
											if (xmlNode2.InnerText.Equals(global::System.IO.Path.GetFileName(A_0.sourceFilePath)))
											{
												num = (short)1872363523;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_384;
										}
										}
										goto IL_224;
										IL_2D1:
										num = (short)1446445056;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_345:
										num = (short)548405254;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_224:
										goto IL_345;
										IL_384:
										num = (short)968097799;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_39D:
									goto IL_4EC;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_3BF;
									}
									global::System.IDisposable disposable;
									for (;;)
									{
										IL_3AC:
										switch (num2)
										{
										case 0:
											goto IL_414;
										case 1:
											disposable.Dispose();
											num = (short)1219690496;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											if (disposable != null)
											{
												num = (short)475267073;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_416;
										}
										goto IL_3BF;
									}
									IL_414:
									IL_416:
									goto EndFinally_16;
									IL_3BF:
									global::System.Collections.IEnumerator enumerator;
									disposable = (enumerator as global::System.IDisposable);
									num = (short)1085210626;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_3AC;
									EndFinally_16:;
								}
								goto IL_417;
							case 7:
								if (A_0.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
								{
									num = (short)1925120004;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4EC;
							case 8:
								goto IL_4EC;
							}
							IL_172:
							if (A_0.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.LanguagePack)
							{
								num = (short)639500291;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)277348359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_417:
							xmlNode = this.a.SelectSingleNode(global::Motorola.Common.Communication.Crc32.c("뒚늜토슢욤첦蚨쾪첬\udbae킰鲲펴\udeb6햸\udebaﾾꣀꟂ", a_) + A_0.sourceFileId + global::Motorola.Common.Communication.Crc32.c("벚삜", a_));
							num = (short)1186660352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_4EC:
							num = (short)678166533;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_505:
						break;
					}
					catch
					{
						array = null;
						break;
					}
					goto IL_512;
				}
				}
				return array;
			}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00010104 File Offset: 0x0000E304
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
					try
					{
						global::Motorola.Common.Communication.t.a(out A_0, fileStream, A_2);
						return;
					}
					finally
					{
						num2 = (short)573112322;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								num2 = (short)1431875040;
								short num3 = num2;
								num2 = (short)164277728;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_172;
								default:
									num2 = (short)12255232;
									if (num2 != 0)
									{
									}
									((global::System.IDisposable)fileStream).Dispose();
									num2 = (short)1735262209;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 1:
								goto IL_172;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_EE;
								}
								continue;
							}
							IL_EE:
							if (fileStream == null)
							{
								break;
							}
							num2 = (short)1127677952;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_172:;
					}
					goto IL_175;
				case 1:
					num2 = (short)890044418;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (global::System.IO.File.Exists(A_1))
					{
						num2 = (short)1005191171;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_175;
				case 4:
					if (!string.IsNullOrEmpty(A_1))
					{
						num2 = (short)742129664;
						short num4 = num2;
						num2 = (short)2106982401;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_24;
				IL_175:
				fileStream = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				num2 = (short)233373696;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			A_0 = null;
			num2 = (short)493486081;
			if (num2 != 0)
			{
			}
			num2 = (short)1203568644;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000102F8 File Offset: 0x0000E4F8
		private static void a(out byte[] A_0, global::System.IO.FileStream A_1, bool A_2)
		{
			short num = (short)1443495937;
			if (num != 0)
			{
			}
			num = (short)1606025216;
			short num2 = num;
			num = (short)576258048;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				long num4 = A_1.Length - A_1.Position;
				global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(A_1, global::System.Text.Encoding.UTF8);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_AC;
					}
					byte[] array;
					for (;;)
					{
						IL_95:
						switch (num3)
						{
						case 0:
						{
							global::AcpCryptoLib.AcpEncryptDecrypt acpEncryptDecrypt = new global::AcpCryptoLib.AcpEncryptDecrypt();
							A_0 = acpEncryptDecrypt.Decrypt(array);
							num = (short)2096948083;
							short num5 = num;
							num = (short)1159455603;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_166;
							default:
								num = (short)1825243136;
								if (num != 0)
								{
								}
								num = (short)1095827457;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_166;
						case 2:
							goto IL_187;
						case 3:
							if (A_2)
							{
								num = (short)437583872;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_0 = array;
							num = (short)369885186;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					}
					IL_166:
					IL_187:
					return;
					IL_AC:
					array = new byte[num4];
					binaryReader.Read(array, 0, (int)num4);
					num = (short)1176698883;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_95;
				}
				finally
				{
					num = (short)193855490;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)binaryReader).Dispose();
							num = (short)1460797441;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1F4;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1BB;
							}
							continue;
						}
						IL_1BB:
						if (binaryReader == null)
						{
							break;
						}
						num = (short)1510342656;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1F4:;
				}
				return;
			}
			}
		}

		// Token: 0x04000058 RID: 88
		private global::System.Xml.XmlDocument a;

		// Token: 0x04000059 RID: 89
		private global::Motorola.Common.Communication.Pba.LanguagePackData b;

		// Token: 0x0400005A RID: 90
		private byte[] c;
	}
}
