using System;
using System.IO;
using System.Security.Cryptography;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000033 RID: 51
	public static class Encryption
	{
		// Token: 0x06000576 RID: 1398 RVA: 0x0003A174 File Offset: 0x00038374
		public static string AESEncrypt(string plainText, string keyPassword, byte[] keySalt)
		{
			short num = (short)1135738881;
			if (num != 0)
			{
			}
			num = (short)408748032;
			short num2 = num;
			num = (short)1906180096;
			switch (num)
			{
			default:
			{
				string result = null;
				global::System.Security.Cryptography.Rfc2898DeriveBytes rfc2898DeriveBytes = new global::System.Security.Cryptography.Rfc2898DeriveBytes(keyPassword, keySalt);
				try
				{
					global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = global::System.Security.Cryptography.Aes.Create();
					try
					{
						symmetricAlgorithm.Key = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.KeySize / 8);
						symmetricAlgorithm.IV = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.BlockSize / 8);
						global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor(symmetricAlgorithm.Key, symmetricAlgorithm.IV);
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
						try
						{
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
									num = (short)943259650;
									int num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											((global::System.IDisposable)streamWriter).Dispose();
											num = (short)406454273;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_157;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_120;
											}
											continue;
										}
										IL_120:
										if (streamWriter == null)
										{
											break;
										}
										num = (short)1985216512;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_157:;
								}
							}
							finally
							{
								num = (short)2130313218;
								int num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = (short)1162084353;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1C4;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_18D;
										}
										continue;
									}
									IL_18D:
									if (cryptoStream == null)
									{
										break;
									}
									num = (short)1107492864;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1C4:;
							}
							result = global::System.Convert.ToBase64String(memoryStream.ToArray());
						}
						finally
						{
							num = (short)220790786;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)1243348993;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_245;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_20D;
									}
									continue;
								}
								IL_20D:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)2116616192;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_245:;
						}
					}
					finally
					{
						num = (short)837746690;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								((global::System.IDisposable)symmetricAlgorithm).Dispose();
								num = (short)1097072641;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								num = (short)1557549273;
								short num4 = num;
								num = (short)1036800217;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_25D;
								default:
									goto IL_2E3;
								}
								break;
							}
							case 2:
								goto IL_25D;
							}
							goto IL_27A;
							IL_25D:
							switch (0)
							{
							case 0:
								IL_27A:
								if (symmetricAlgorithm == null)
								{
									goto IL_2FA;
								}
								num = (short)33488896;
								num3 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_2E3:
						num = (short)200409088;
						if (num != 0)
						{
						}
						IL_2FA:;
					}
				}
				finally
				{
					num = (short)318308354;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)rfc2898DeriveBytes).Dispose();
							num = (short)274792449;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_364;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_32E;
							}
							continue;
						}
						IL_32E:
						if (rfc2898DeriveBytes == null)
						{
							break;
						}
						num = (short)273219584;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_364:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0003A568 File Offset: 0x00038768
		public static string AESDecrypt(string encryptedText, string keyPassword, byte[] keySalt)
		{
			short num = (short)243466240;
			switch (num)
			{
			default:
			{
				num = (short)1041235968;
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
									num = (short)1376976898;
									int num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											((global::System.IDisposable)streamReader).Dispose();
											num = (short)805109761;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_134;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_FC;
											}
											continue;
										}
										IL_FC:
										if (streamReader == null)
										{
											break;
										}
										num = (short)193069056;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_134:;
								}
							}
							finally
							{
								num = (short)1565327362;
								int num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = (short)211091457;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1A2;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_169;
										}
										continue;
									}
									IL_169:
									if (cryptoStream == null)
									{
										break;
									}
									num = (short)1085865984;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1A2:;
							}
						}
						finally
						{
							num = (short)433520642;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)1039269889;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_212;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1D8;
									}
									continue;
								}
								IL_1D8:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)886439936;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_212:;
						}
					}
					finally
					{
						num = (short)1559625730;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								((global::System.IDisposable)symmetricAlgorithm).Dispose();
								num = (short)683278337;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								num = (short)2007415217;
								short num4 = num;
								num = (short)297318833;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_22A;
								default:
									goto IL_2B9;
								}
								break;
							}
							case 2:
								goto IL_22A;
							}
							goto IL_247;
							IL_22A:
							switch (0)
							{
							case 0:
								IL_247:
								if (symmetricAlgorithm == null)
								{
									goto IL_2D2;
								}
								num = (short)1981743104;
								num3 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_2B9:
						num = (short)1404764160;
						if (num != 0)
						{
						}
						IL_2D2:;
					}
				}
				finally
				{
					num = (short)1898905602;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)rfc2898DeriveBytes).Dispose();
							num = (short)1028259841;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_33D;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_306;
							}
							continue;
						}
						IL_306:
						if (rfc2898DeriveBytes == null)
						{
							break;
						}
						num = (short)714997760;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_33D:
					num = (short)1513422849;
					if (num != 0)
					{
					}
				}
				return result;
			}
			}
		}
	}
}
