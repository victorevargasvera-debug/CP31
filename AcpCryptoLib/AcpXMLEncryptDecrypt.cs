using System;
using System.IO;
using System.Security.Cryptography;
using System.Xml;

namespace AcpCryptoLib
{
	// Token: 0x02000015 RID: 21
	public class AcpXMLEncryptDecrypt : global::AcpCryptoLib.AcpCryptoBase, global::AcpCryptoLib.IAcpXMLEncryptDecrypt
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00007F60 File Offset: 0x00006160
		public void EncryptXMLFile(string inputFileName, string outputFileName)
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)165675008;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					global::System.IO.FileStream fileStream;
					for (;;)
					{
						IL_32:
						switch (num2)
						{
						case 0:
							IL_13C:
							goto IL_13E;
						case 1:
							if (this.a(fileStream))
							{
								num = (short)504430594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_13E;
						case 2:
						{
							fileStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
							byte[] array = new byte[fileStream.Length];
							fileStream.Read(array, 0, array.Length);
							global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(outputFileName, global::System.IO.FileMode.Create);
							global::AcpCryptoLib.AcpCryptoHeader acpCryptoHeader = new global::AcpCryptoLib.AcpCryptoHeader();
							fileStream2.Write(acpCryptoHeader.Data, 0, acpCryptoHeader.Data.Length);
							global::System.Security.Cryptography.ICryptoTransform transform = ((global::System.Security.Cryptography.SymmetricAlgorithm)acpCryptoHeader.Key).CreateEncryptor();
							global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(fileStream2, transform, global::System.Security.Cryptography.CryptoStreamMode.Write);
							byte[] array2 = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(7, 128);
							cryptoStream.Write(array2, 0, array2.Length);
							cryptoStream.Write(array, 0, array.Length);
							cryptoStream.FlushFinalBlock();
							fileStream.Close();
							cryptoStream.Close();
							fileStream2.Close();
							num = (short)1710620672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_1A0;
						}
						goto IL_49;
						IL_13E:
						num = (short)1542657276;
						short num3 = num;
						num = (short)2125534460;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13C;
						default:
							num = (short)400228352;
							if (num != 0)
							{
							}
							num = (short)1902706691;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_1A0:
					break;
					IL_49:
					fileStream = new global::System.IO.FileStream(inputFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					num = (short)428212225;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("儏焑搓丕唗嘙夛瀝䌟倡崣嘥尧温䤫䴭䈯䬱䐳䈵ᘷ缹刻崽㈿㭁㑃㉅၇݉Kࡍ㥏㹑ㅓ癕畗穙ᥛ♝͟ݡᑣብŧթɫ呭偯", a_) + ex.Message);
			}
			num = (short)650969089;
			if (num != 0)
			{
			}
			num = (short)1731985408;
			short num4 = num;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000081A0 File Offset: 0x000063A0
		public void EncryptXMLDoc(global::System.Xml.XmlDocument doc, string outputFileName)
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)260702209;
				if (num != 0)
				{
				}
				num = (short)1947922884;
				short num2 = num;
				num = (short)175370692;
				switch (num2 == num)
				{
				}
				num = (short)1756889088;
				if (num != 0)
				{
				}
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				doc.Save(memoryStream);
				memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
				byte[] array = new byte[memoryStream.Length];
				memoryStream.Read(array, 0, array.Length);
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(outputFileName, global::System.IO.FileMode.Create);
				global::AcpCryptoLib.AcpCryptoHeader acpCryptoHeader = new global::AcpCryptoLib.AcpCryptoHeader();
				fileStream.Write(acpCryptoHeader.Data, 0, acpCryptoHeader.Data.Length);
				global::System.Security.Cryptography.ICryptoTransform transform = ((global::System.Security.Cryptography.SymmetricAlgorithm)acpCryptoHeader.Key).CreateEncryptor();
				global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(fileStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Write);
				byte[] array2 = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(7, 128);
				cryptoStream.Write(array2, 0, array2.Length);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				memoryStream.Close();
				cryptoStream.Close();
				fileStream.Close();
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("儏焑搓丕唗嘙夛瀝䌟倡崣嘥尧温䤫䴭䈯䬱䐳䈵ᘷ缹刻崽㈿㭁㑃㉅ే╉⽋湍絏牑ᅓ⹕㭗㽙ⱛ⩝य़ൡ੣履䡧", a_) + ex.Message);
			}
			num = (short)86310912;
			short num3 = num;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00008338 File Offset: 0x00006538
		public global::System.Xml.XmlDocument DecryptXMLFile(string inputFileName)
		{
			int a_ = 6;
			global::System.Xml.XmlDocument result;
			short num;
			try
			{
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(inputFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				try
				{
					result = this.DecryptXMLFile(fileStream);
				}
				finally
				{
					num = (short)1803223041;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_D7;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_51;
							}
							continue;
						case 2:
						{
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)831489017;
							short num3 = num;
							num = (short)269124601;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_D7;
							default:
								num = (short)18677760;
								if (num != 0)
								{
								}
								num = (short)227082240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_51:
						if (fileStream == null)
						{
							break;
						}
						num = (short)115408898;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_D7:;
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䐄搆礈匊䀌䌎吐紒瘔攖怘欚検嬞䐠䀢圤带夨弪̬欮吰倲䜴丶䤸伺攼爾ീՂⱄ⭆ⱈ歊恌潎ᑐ⭒㙔㉖⥘⽚㑜ぞའ奢䕤", a_) + ex.Message);
			}
			num = (short)977272833;
			if (num != 0)
			{
			}
			num = (short)932708352;
			short num4 = num;
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000084B0 File Offset: 0x000066B0
		public global::System.Xml.XmlDocument DecryptXMLFile(global::System.IO.Stream inputStream)
		{
			int a_ = 19;
			short num;
			global::System.Xml.XmlDocument result;
			try
			{
				num = (short)728039424;
				switch (num)
				{
				default:
				{
					num = (short)2047082497;
					if (num != 0)
					{
					}
					global::System.Security.Cryptography.ICryptoTransform transform = ((global::System.Security.Cryptography.SymmetricAlgorithm)new global::AcpCryptoLib.AcpCryptoHeader(base.ExtractHeader(inputStream)).Key).CreateDecryptor();
					global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(inputStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Read);
					try
					{
						base.ExtractSalt(cryptoStream);
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(cryptoStream);
						result = xmlDocument;
					}
					finally
					{
						num = (short)1423835137;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_147;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_C1;
								}
								continue;
							case 2:
							{
								((global::System.IDisposable)cryptoStream).Dispose();
								num = (short)1089491105;
								short num3 = num;
								num = (short)1783386273;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_147;
								default:
									num = (short)297664512;
									if (num != 0)
									{
									}
									num = (short)471334912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_C1:
							if (cryptoStream == null)
							{
								break;
							}
							num = (short)1064763394;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_147:;
					}
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("匑眓昕䀗圙倛嬝丟䄡嘣弥堧帩栫䬭匯䀱䴳䘵䰷ᐹ砻嬽⌿ぁ㵃㙅㱇቉ŋɍᙏ㭑㡓㍕硗睙籛᭝ᡟšţᙥᱧͩͫm䩯剱", a_) + ex.Message);
			}
			num = (short)963117056;
			short num4 = num;
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00008688 File Offset: 0x00006888
		private bool a(global::System.IO.Stream A_0)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)497025025;
					if (num2 != 0)
					{
					}
					num2 = (short)1545085641;
					short num3 = num2;
					num2 = (short)57811657;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_144;
					default:
						num2 = (short)510001152;
						if (num2 != 0)
						{
						}
						try
						{
							new global::System.Xml.XmlDocument().Load(A_0);
							return result;
						}
						catch (global::System.Exception ex)
						{
							result = false;
							throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䬁樃瀅椇昉攋樍』䨑夓娕㠗䤙栛氝䔟䌡䤣ᰥࠧ", a_) + ex.Message);
						}
						goto IL_B4;
					}
					break;
				}
				case 1:
					if (A_0 == null)
					{
						num2 = (short)1466761218;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B4;
				case 2:
					goto IL_7D;
				}
				goto IL_25;
				IL_B4:
				num2 = (short)1216348160;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_7D:
			IL_144:
			result = false;
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("儁瀃琅洇欉愋⸍砏猑朓㘕礗㨙爛欝䰟両У吥䴧䰩䤫尭唯就圳匵ᘷ", a_));
			IL_25:
			num2 = (short)1065549824;
			short num4 = num2;
			result = true;
			num2 = (short)740884481;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
