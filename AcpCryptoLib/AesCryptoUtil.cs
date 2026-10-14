using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using AcpUtility;

namespace AcpCryptoLib
{
	// Token: 0x02000017 RID: 23
	public class AesCryptoUtil
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00008814 File Offset: 0x00006A14
		static AesCryptoUtil()
		{
			short num = (short)1746264666;
			short num2 = num;
			num = (short)964485722;
			switch (num2 == num)
			{
			}
			num = (short)752222208;
			short num3 = num;
			num = (short)804978688;
			if (num != 0)
			{
			}
			num = (short)1305477121;
			if (num != 0)
			{
			}
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000088C4 File Offset: 0x00006AC4
		public void EncryptXMLDoc(global::System.Xml.XmlDocument doc, string outputFileName)
		{
			short num = (short)538247168;
			switch (num)
			{
			default:
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					doc.Save(memoryStream);
					memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
					byte[] array = new byte[memoryStream.Length];
					memoryStream.Read(array, 0, array.Length);
					global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = global::System.Security.Cryptography.Aes.Create();
					try
					{
						symmetricAlgorithm.Mode = global::System.Security.Cryptography.CipherMode.CBC;
						symmetricAlgorithm.Padding = global::System.Security.Cryptography.PaddingMode.PKCS7;
						symmetricAlgorithm.BlockSize = this.a;
						symmetricAlgorithm.KeySize = this.b;
						byte[] salt = this.a();
						global::System.Security.Cryptography.Rfc2898DeriveBytes rfc2898DeriveBytes = new global::System.Security.Cryptography.Rfc2898DeriveBytes(this.d, salt, this.c);
						try
						{
							symmetricAlgorithm.Key = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.KeySize / 8);
							symmetricAlgorithm.IV = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.BlockSize / 8);
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(outputFileName, global::System.IO.FileMode.Create);
							try
							{
								global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor();
								global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(fileStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Write);
								try
								{
									cryptoStream.Write(array, 0, array.Length);
									cryptoStream.FlushFinalBlock();
								}
								finally
								{
									num = (short)39649281;
									int num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_168;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_131;
											}
											continue;
										case 2:
											((global::System.IDisposable)cryptoStream).Dispose();
											num = (short)58654720;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_131:
										if (cryptoStream == null)
										{
											break;
										}
										num = (short)1045233666;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_168:;
								}
							}
							finally
							{
								num = (short)955514881;
								int num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1D6;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_19E;
										}
										continue;
									case 2:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)1816461312;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_19E:
									if (fileStream == null)
									{
										break;
									}
									num = (short)258277378;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1D6:;
							}
						}
						finally
						{
							num = (short)1002110977;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_242;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_20B;
									}
									continue;
								case 2:
									((global::System.IDisposable)rfc2898DeriveBytes).Dispose();
									num = (short)931528704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_20B:
								if (rfc2898DeriveBytes == null)
								{
									break;
								}
								num = (short)209780738;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_242:;
						}
					}
					finally
					{
						num = (short)91947009;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_301;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_277;
								}
								continue;
							case 2:
							{
								((global::System.IDisposable)symmetricAlgorithm).Dispose();
								num = (short)152610811;
								short num3 = num;
								num = (short)170960891;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_301;
								default:
									num = (short)1583939584;
									if (num != 0)
									{
									}
									num = (short)1734279168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_277:
							if (symmetricAlgorithm == null)
							{
								break;
							}
							num = (short)1703542786;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_301:;
					}
				}
				finally
				{
					num = (short)133169153;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_36F;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_336;
							}
							continue;
						case 2:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)858652672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_336:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)245956610;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_36F:;
				}
				num = (short)286982144;
				short num4 = num;
				num = (short)168493057;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00008D14 File Offset: 0x00006F14
		public global::System.Xml.XmlDocument DecryptXMLFile(string inputFileName)
		{
			short num = (short)1311637504;
			switch (num)
			{
			default:
			{
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = global::System.Security.Cryptography.Aes.Create();
				try
				{
					symmetricAlgorithm.Mode = global::System.Security.Cryptography.CipherMode.CBC;
					symmetricAlgorithm.Padding = global::System.Security.Cryptography.PaddingMode.PKCS7;
					symmetricAlgorithm.BlockSize = this.a;
					symmetricAlgorithm.KeySize = this.b;
					byte[] salt = this.a();
					global::System.Security.Cryptography.Rfc2898DeriveBytes rfc2898DeriveBytes = new global::System.Security.Cryptography.Rfc2898DeriveBytes(this.d, salt, this.c);
					try
					{
						symmetricAlgorithm.Key = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.KeySize / 8);
						symmetricAlgorithm.IV = rfc2898DeriveBytes.GetBytes(symmetricAlgorithm.BlockSize / 8);
						global::System.IO.FileStream fileStream = new global::System.IO.FileStream(inputFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
						try
						{
							num = (short)232980481;
							if (num != 0)
							{
							}
							global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor();
							global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(fileStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Read);
							try
							{
								xmlDocument.Load(cryptoStream);
							}
							finally
							{
								num = (short)1826619393;
								int num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_156;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_11D;
										}
										continue;
									case 2:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = (short)2112094208;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_11D:
									if (cryptoStream == null)
									{
										break;
									}
									num = (short)305397762;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_156:;
							}
						}
						finally
						{
							num = (short)1868234753;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_215;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_18C;
									}
									continue;
								case 2:
								{
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)943647307;
									short num3 = num;
									num = (short)1046538827;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_215;
									default:
										num = (short)1474953216;
										if (num != 0)
										{
										}
										num = (short)1967063040;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_18C:
								if (fileStream == null)
								{
									break;
								}
								num = (short)1751777282;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_215:;
						}
					}
					finally
					{
						num = (short)125763585;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_281;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_24C;
								}
								continue;
							case 2:
								((global::System.IDisposable)rfc2898DeriveBytes).Dispose();
								num = (short)1433993216;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_24C:
							if (rfc2898DeriveBytes == null)
							{
								break;
							}
							num = (short)1226702850;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_281:;
					}
				}
				finally
				{
					num = (short)575143937;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_2EC;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2B7;
							}
							continue;
						case 2:
							((global::System.IDisposable)symmetricAlgorithm).Dispose();
							num = (short)1767374848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2B7:
						if (symmetricAlgorithm == null)
						{
							break;
						}
						num = (short)1668939778;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2EC:;
				}
				num = (short)1027473408;
				short num4 = num;
				return xmlDocument;
			}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000090A0 File Offset: 0x000072A0
		private byte[] a()
		{
			int a_ = 10;
			short num = (short)811728896;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				byte[] array;
				int num5;
				byte[] bytes;
				int num7;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						return array;
					case 1:
					{
						num = (short)848691200;
						short num3 = num;
						num = (short)519075872;
						short num4 = num;
						num = (short)1280866336;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)818675712;
							if (num != 0)
							{
							}
							goto IL_BF;
						}
						break;
					}
					case 2:
						num = (short)171966465;
						if (num != 0)
						{
						}
						goto IL_BF;
					case 3:
					{
						if (num5 >= bytes.Length)
						{
							num = (short)848756736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6 = num5 % num7;
						array[num6] = (array[num6] + bytes[num5] & byte.MaxValue);
						num5++;
						num = (short)1154875393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_47;
					IL_BF:
					num = (short)1438515203;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_47:
				string str = global::AcpCryptoLib.XmlEncryptionUtil.b("㰈上伌䴎⌐‒吔␖㐘√⸜⼞戠ยᄤᜦᴨḪ,ᜮ琰瀲ܴᨶ簸࠺簼࠾獀療癄ц穈ൊौ硎", a_);
				bytes = global::System.Text.Encoding.UTF8.GetBytes(this.e + str);
				num7 = 64;
				array = new byte[num7];
				array.Initialize();
				num5 = 0;
				num = (short)36503554;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000925C File Offset: 0x0000745C
		public AesCryptoUtil()
		{
			int a_ = 2;
			this.a = 128;
			this.b = 256;
			this.c = 1000;
			this.d = global::AcpCryptoLib.XmlEncryptionUtil.b("稀㘂䀄㐆㬈㼊㠌䴎┐㸒✔␖堘ⴚ〜⬞ဠ昢ሤਦဨጪ欬ᰮᰰԲ眴ึ࠸稺༼࠾灀Ղ瑄畆ై㙊", a_);
			this.e = global::AcpCryptoLib.XmlEncryptionUtil.b("稀䄂䐄䈆伈䴊㸌㰎∐㸒嘔‖Ⱈ多〜⬞朠愢ᴤਦ栨ᬪᰬᜮᰰ焲琴̶紸稺礼稾獀牂籄Նൈ㙊", a_);
			base..ctor();
		}

		// Token: 0x0400002D RID: 45
		private int a;

		// Token: 0x0400002E RID: 46
		private int b;

		// Token: 0x0400002F RID: 47
		private int c;

		// Token: 0x04000030 RID: 48
		private string d;

		// Token: 0x04000031 RID: 49
		private string e;
	}
}
