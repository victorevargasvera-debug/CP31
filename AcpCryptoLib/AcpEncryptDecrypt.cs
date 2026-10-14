using System;
using System.IO;
using System.Security.Cryptography;

namespace AcpCryptoLib
{
	// Token: 0x0200000E RID: 14
	public class AcpEncryptDecrypt : global::AcpCryptoLib.AcpCryptoBase, global::AcpCryptoLib.IAcpEncryptDecrypt
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00004CE0 File Offset: 0x00002EE0
		public byte[] Encrypt(byte[] plainData)
		{
			int a_ = 6;
			if (plainData == null)
			{
				short num;
				for (;;)
				{
					num = (short)1378768503;
					short num2 = num;
					num = (short)1187665527;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_48;
					}
				}
				IL_48:
				num = (short)1674641409;
				if (num != 0)
				{
				}
				num = (short)640811008;
				if (num != 0)
				{
				}
				num = (short)1214775296;
				short num3 = num;
				throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("䰄椆礈縊礌⼎甐爒愔瘖㤘爚渜㼞䀠̢䬤刦䔨䜪ബ崮吰唲倴䔶尸唺帼娾潀", a_));
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::AcpCryptoLib.AcpEncryptionHeader acpEncryptionHeader = new global::AcpCryptoLib.AcpEncryptionHeader();
			memoryStream.Write(acpEncryptionHeader.Data, 0, acpEncryptionHeader.Data.Length);
			global::System.Security.Cryptography.ICryptoTransform transform = ((global::System.Security.Cryptography.SymmetricAlgorithm)acpEncryptionHeader.Key).CreateEncryptor();
			global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Write);
			byte[] array = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(7, 128);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Write(plainData, 0, plainData.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return result;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004E28 File Offset: 0x00003028
		public byte[] Decrypt(byte[] encryptedData)
		{
			int a_ = 2;
			short num = (short)822870016;
			switch (num)
			{
			default:
			{
				num = (short)942604290;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte[] array;
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_75;
					case 1:
						num = (short)2015035393;
						if (num != 0)
						{
						}
						try
						{
							global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(encryptedData);
							try
							{
								global::System.Security.Cryptography.ICryptoTransform transform = ((global::System.Security.Cryptography.SymmetricAlgorithm)new global::AcpCryptoLib.AcpEncryptionHeader(base.ExtractHeader(memoryStream)).Key).CreateDecryptor();
								global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Read);
								try
								{
									global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream();
									try
									{
										cryptoStream.CopyTo(memoryStream2);
										memoryStream2.Seek(0L, global::System.IO.SeekOrigin.Begin);
										base.ExtractSalt(memoryStream2);
										num3 = memoryStream2.Read(array, 0, array.Length);
									}
									finally
									{
										num = (short)749862914;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												((global::System.IDisposable)memoryStream2).Dispose();
												num = (short)984023041;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_14D;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_114;
												}
												continue;
											}
											IL_114:
											if (memoryStream2 == null)
											{
												break;
											}
											num = (short)855375872;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_14D:;
									}
								}
								finally
								{
									num = (short)909967362;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										num = (short)1377710765;
										short num4 = num;
										num = (short)241382061;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_210;
										default:
											num = (short)222298112;
											if (num != 0)
											{
											}
											switch (num2)
											{
											case 0:
												((global::System.IDisposable)cryptoStream).Dispose();
												num = (short)446824449;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_20E;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_1D2;
												}
												continue;
											}
											IL_1D2:
											if (cryptoStream == null)
											{
												goto IL_210;
											}
											num = (short)359792640;
											num2 = (int)((global::System.IntPtr)num);
											break;
										}
									}
									IL_20E:
									IL_210:;
								}
							}
							finally
							{
								num = (short)198311938;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										((global::System.IDisposable)memoryStream).Dispose();
										num = (short)1596325889;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_27D;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_246;
										}
										continue;
									}
									IL_246:
									if (memoryStream == null)
									{
										break;
									}
									num = (short)1209663488;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_27D:;
							}
							byte[] array2 = new byte[num3];
							global::System.Array.Copy(array, 0, array2, 0, array2.Length);
							return array2;
						}
						catch (global::System.Exception ex)
						{
							throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䀀怂甄䈆月栊缌瘎愐朒儔爖稘椚搜漞唠ഢ愤䈦䨨太听弮䔰ጲᠴ᜶簸䌺帼娾ㅀ㝂ⱄ⡆❈煊浌", a_) + ex.Message);
						}
						goto IL_2BD;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					IL_59:
					if (encryptedData == null)
					{
						num = (short)1017249792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2BD:
					num3 = 0;
					array = new byte[encryptedData.Length];
					num = (short)1129578497;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_75:
				num = (short)1008926720;
				short num5 = num;
				throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("䠀洂甄爆紈⬊椌渎攐爒㔔縖樘㬚簜㼞传嘢䤤䬦न太䠬䤮吰䄲倴夶娸帺ጼ", a_));
			}
			}
		}
	}
}
