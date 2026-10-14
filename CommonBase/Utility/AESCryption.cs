using System;
using System.IO;
using System.Security.Cryptography;

namespace CommonBase.Utility
{
	// Token: 0x02000004 RID: 4
	public static class AESCryption
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00003C20 File Offset: 0x00001E20
		public static string AESEncrypt(string plainText, string keyPassword, byte[] keySalt)
		{
			short num = (short)2113994752;
			short num2 = num;
			num = (short)498401280;
			switch (num)
			{
			default:
			{
				string result = null;
				global::System.Security.Cryptography.Rfc2898DeriveBytes rfc2898DeriveBytes = new global::System.Security.Cryptography.Rfc2898DeriveBytes(keyPassword, keySalt);
				try
				{
					num = (short)1183645697;
					if (num != 0)
					{
					}
					global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = global::System.Security.Cryptography.Aes.Create();
					try
					{
						symmetricAlgorithm.Key = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.KeySize / 8);
						symmetricAlgorithm.IV = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.BlockSize / 8);
						global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor(symmetricAlgorithm.Key, symmetricAlgorithm.IV);
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
						try
						{
							num = (short)2130637731;
							short num3 = num;
							num = (short)180548515;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)1867186176;
								if (num != 0)
								{
								}
								global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Write);
								try
								{
									global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(cryptoStream);
									try
									{
										streamWriter.Write(plainText);
									}
									finally
									{
										num = (short)1129119744;
										int num4 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num4)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_16B;
												}
												continue;
											case 1:
												((global::System.IDisposable)streamWriter).Dispose();
												num = (short)1594490882;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_1A4;
											}
											IL_16B:
											if (streamWriter == null)
											{
												break;
											}
											num = (short)1782448129;
											num4 = (int)((global::System.IntPtr)num);
										}
										IL_1A4:;
									}
								}
								finally
								{
									num = (short)1880162304;
									int num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_1D9;
											}
											continue;
										case 1:
											((global::System.IDisposable)cryptoStream).Dispose();
											num = (short)264568834;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_210;
										}
										IL_1D9:
										if (cryptoStream == null)
										{
											break;
										}
										num = (short)1263730689;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_210:;
								}
								break;
							}
							}
							result = global::System.Convert.ToBase64String(memoryStream.ToArray());
						}
						finally
						{
							num = (short)1685454848;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_258;
									}
									continue;
								case 1:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)314179586;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_28F;
								}
								IL_258:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)185794561;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_28F:;
						}
					}
					finally
					{
						num = (short)504627200;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2C5;
								}
								continue;
							case 1:
								((global::System.IDisposable)symmetricAlgorithm).Dispose();
								num = (short)344129538;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_2FB;
							}
							IL_2C5:
							if (symmetricAlgorithm == null)
							{
								break;
							}
							num = (short)840957953;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_2FB:;
					}
				}
				finally
				{
					num = (short)1035141120;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_330;
							}
							continue;
						case 1:
							((global::System.IDisposable)rfc2898DeriveBytes).Dispose();
							num = (short)109314050;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_365;
						}
						IL_330:
						if (rfc2898DeriveBytes == null)
						{
							break;
						}
						num = (short)1210843137;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_365:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00004014 File Offset: 0x00002214
		public static string AESDecrypt(string encryptedText, string keyPassword, byte[] keySalt)
		{
			short num = (short)1244332032;
			switch (num)
			{
			default:
			{
				num = (short)1508048897;
				if (num != 0)
				{
				}
				num = (short)1328349184;
				short num2 = num;
				global::System.Security.Cryptography.Rfc2898DeriveBytes rfc2898DeriveBytes = new global::System.Security.Cryptography.Rfc2898DeriveBytes(keyPassword, keySalt);
				string result;
				try
				{
					global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = global::System.Security.Cryptography.Aes.Create();
					try
					{
						symmetricAlgorithm.Key = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.KeySize / 8);
						symmetricAlgorithm.IV = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.BlockSize / 8);
						global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(symmetricAlgorithm.Key, symmetricAlgorithm.IV);
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Convert.FromBase64String(encryptedText));
						try
						{
							global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Read);
							try
							{
								global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(cryptoStream);
								try
								{
									result = streamReader.ReadToEnd();
								}
								finally
								{
									num = (short)845348866;
									int num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											((global::System.IDisposable)streamReader).Dispose();
											num = (short)1442447361;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_15A;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_123;
											}
											continue;
										}
										IL_123:
										if (streamReader == null)
										{
											break;
										}
										num = (short)2047344640;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_15A:;
								}
							}
							finally
							{
								num = (short)1404502018;
								int num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = (short)1682440193;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1CA;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_190;
										}
										continue;
									}
									IL_190:
									if (cryptoStream == null)
									{
										break;
									}
									num = (short)209321984;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1CA:;
							}
						}
						finally
						{
							num = (short)867303426;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									num = (short)804685269;
									short num4 = num;
									num = (short)1070171605;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1245184000;
										if (num != 0)
										{
										}
										break;
									}
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)1763442689;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_288;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_200;
									}
									continue;
								}
								IL_200:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)246939648;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_288:;
						}
					}
					finally
					{
						num = (short)489684994;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								((global::System.IDisposable)symmetricAlgorithm).Dispose();
								num = (short)271056897;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_2F3;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_2BD;
								}
								continue;
							}
							IL_2BD:
							if (symmetricAlgorithm == null)
							{
								break;
							}
							num = (short)1701576704;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_2F3:;
					}
				}
				finally
				{
					num = (short)824180738;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)rfc2898DeriveBytes).Dispose();
							num = (short)356515841;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_35F;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_329;
							}
							continue;
						}
						IL_329:
						if (rfc2898DeriveBytes == null)
						{
							break;
						}
						num = (short)554041344;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_35F:;
				}
				return result;
			}
			}
		}
	}
}
