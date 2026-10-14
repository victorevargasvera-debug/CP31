using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using AcpUtility;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.CommonLib
{
	// Token: 0x0200000F RID: 15
	public class EnDecryptStreamHelper : global::System.IDisposable
	{
		// Token: 0x0600004C RID: 76 RVA: 0x0000C958 File Offset: 0x0000AB58
		private EnDecryptStreamHelper()
		{
			this.b = global::System.Security.Cryptography.Aes.Create();
			this.b.Padding = global::System.Security.Cryptography.PaddingMode.PKCS7;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000C984 File Offset: 0x0000AB84
		public static global::Motorola.Common.CommonLib.EnDecryptStreamHelper Instance
		{
			get
			{
				short num = (short)1581245378;
				short num2 = num;
				num = (short)228844482;
				switch (num2 == num)
				{
				}
				num = (short)1791033344;
				if (num != 0)
				{
				}
				num = (short)450363393;
				if (num != 0)
				{
				}
				num = (short)68157440;
				short num3 = num;
				global::Motorola.Common.CommonLib.EnDecryptStreamHelper result;
				if ((result = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.a) == null)
				{
					result = (global::Motorola.Common.CommonLib.EnDecryptStreamHelper.a = new global::Motorola.Common.CommonLib.EnDecryptStreamHelper());
				}
				return result;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000CA44 File Offset: 0x0000AC44
		public global::System.IO.Stream CreateEncryptStream(string id, global::System.IO.Stream nonEncryptStream)
		{
			short num = (short)128558649;
			short num2 = num;
			num = (short)1327736377;
			switch (num2 == num)
			{
			}
			num = (short)229900288;
			if (num != 0)
			{
			}
			num = (short)1025376257;
			if (num != 0)
			{
			}
			num = (short)807862272;
			short num3 = num;
			byte[] array = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.a(id);
			return new global::System.Security.Cryptography.CryptoStream(nonEncryptStream, this.b.CreateEncryptor(array, array), global::System.Security.Cryptography.CryptoStreamMode.Write);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000CB08 File Offset: 0x0000AD08
		private global::System.IO.Stream d(global::System.IO.Stream A_0)
		{
			int a_ = 4;
			short num = (short)264765441;
			if (num != 0)
			{
			}
			num = (short)547911794;
			short num2 = num;
			num = (short)1691777138;
			switch (num2 == num)
			{
			}
			num = (short)2093613056;
			if (num != 0)
			{
			}
			num = (short)272433152;
			short num3 = num;
			return this.CreateEncryptStream(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("猇䰉㰋㬍唏圑圓圕‗㜙⨛娝ᘟᬡणሥᠧᴩᔫ̭यر爳еᔷ഻༹࠽琿畁睃х็罉筋ཌྷ扏⽑", a_), A_0);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		public global::System.IO.Stream CreateDecryptStream(string id, global::System.IO.Stream encryptedStream)
		{
			short num = (short)1486406097;
			short num2 = num;
			num = (short)444711377;
			switch (num2 == num)
			{
			}
			num = (short)1936130049;
			if (num != 0)
			{
			}
			num = (short)1031536640;
			if (num != 0)
			{
			}
			num = (short)760283136;
			short num3 = num;
			byte[] array = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.a(id);
			return new global::System.Security.Cryptography.CryptoStream(encryptedStream, this.b.CreateDecryptor(array, array), global::System.Security.Cryptography.CryptoStreamMode.Read);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000CC94 File Offset: 0x0000AE94
		private global::System.IO.Stream c(global::System.IO.Stream A_0)
		{
			int a_ = 1;
			short num = (short)1950128133;
			short num2 = num;
			num = (short)2076481541;
			switch (num2 == num)
			{
			}
			num = (short)919470081;
			if (num != 0)
			{
			}
			num = (short)1191968768;
			if (num != 0)
			{
			}
			num = (short)1158479872;
			short num3 = num;
			return this.CreateDecryptStream(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("縄䄆㤈㸊䠌䨎刐划ⴔ㨖⼘弚⬜☞ఠᜢᔤဦဨتᐬᬮ眰Ĳᠴȶ࠸ഺ़࠾牀ł̈́牆繈੊罌㉎", a_), A_0);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000CD5C File Offset: 0x0000AF5C
		private static byte[] a(string A_0)
		{
			int a_ = 13;
			short num;
			byte[] array;
			for (;;)
			{
				IL_09:
				num = (short)2037252096;
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
					int num3;
					byte[] bytes;
					int num6;
					for (;;)
					{
						IL_30:
						switch (num2)
						{
						case 0:
							goto IL_8F;
						case 1:
							goto IL_C4;
						case 2:
							goto IL_8F;
						case 3:
						{
							if (num3 >= bytes.Length)
							{
								num = (short)1472135169;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1886304694;
							short num4 = num;
							num = (short)420329910;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
							{
								num = (short)788332545;
								if (num != 0)
								{
								}
								num = (short)1190395904;
								if (num != 0)
								{
								}
								int num5 = num3 % num6;
								array[num5] = (array[num5] + bytes[num3] & byte.MaxValue);
								num3++;
								num = (short)403505152;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_8F:
						num = (short)589496323;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_47:
					bytes = global::System.Text.Encoding.Unicode.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("樐嘒ⴔ⼖⸘⬚⨜娞ᜠยᘤሦᨨ洪,ᬮܰ甲شᨶĸ଺༼฾汀B煄牆灈籊硌癎扐ᕒᑔ捖慘♚灜", a_) + A_0);
					num6 = 16;
					array = new byte[num6];
					array.Initialize();
					num3 = 0;
					num = (short)1451622402;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			IL_C4:
			num = (short)1008664576;
			short num7 = num;
			return array;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000CF0C File Offset: 0x0000B10C
		private static bool b(global::System.IO.Stream A_0)
		{
			short num = (short)1198973014;
			short num2 = num;
			num = (short)1437327446;
			switch (num2 == num)
			{
			}
			num = (short)1747845121;
			if (num != 0)
			{
			}
			num = (short)282132480;
			if (num != 0)
			{
			}
			num = (short)865075200;
			short num3 = num;
			return A_0.ReadRequestedBytes(global::Motorola.Common.CommonLib.EnDecryptStreamHelper.g.Length).SequenceEqual(global::Motorola.Common.CommonLib.EnDecryptStreamHelper.g);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000CFCC File Offset: 0x0000B1CC
		private static global::System.IO.FileStream a(string A_0, global::System.IO.FileMode A_1, global::System.IO.FileAccess A_2, global::System.IO.FileShare A_3)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_65;
				case 1:
					if (num2 > 20)
					{
						num3 = (short)1870790660;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)621346818;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					try
					{
						return new global::System.IO.FileStream(A_0, A_1, A_2, A_3);
					}
					catch (global::System.IO.IOException ex)
					{
						if (num2 != 20)
						{
							if (ex.HResult == -2147024864)
							{
								num3 = (short)1463053529;
								short num4 = num3;
								num3 = (short)1181838553;
								switch ((num4 == num3) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num3 = (short)1224081408;
									if (num3 != 0)
									{
									}
									global::System.Threading.Thread.Sleep(num2 * num2 * 10);
									goto IL_162;
								}
							}
						}
						throw;
					}
					IL_162:
					num2++;
					num3 = (short)791805952;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					goto IL_65;
				case 4:
					goto IL_96;
				}
				goto IL_24;
				IL_65:
				num3 = (short)1343422465;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_96:
			num3 = (short)1116733440;
			short num5 = num3;
			return null;
			IL_24:
			num2 = 0;
			num3 = (short)1530658817;
			if (num3 != 0)
			{
			}
			num3 = (short)733872131;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000D16C File Offset: 0x0000B36C
		public global::System.IO.Stream CreateCryptoFlStream(string path, global::System.IO.FileAccess access)
		{
			int a_ = 17;
			short num = (short)596312067;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.IO.Stream stream;
			global::System.IO.FileStream fileStream;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_20B;
				case 1:
					num = (short)2037514248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (global::Motorola.Common.CommonLib.EnDecryptStreamHelper.b(stream))
					{
						num = (short)1610481668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_119;
				case 3:
					goto IL_1D;
				case 4:
					return stream;
				case 5:
					if (access != global::System.IO.FileAccess.Write)
					{
						num = (short)2054029313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD;
				case 6:
				{
					num = (short)1886833316;
					short num3 = num;
					num = (short)2118896292;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)338493440;
						if (num != 0)
						{
						}
						if (fileStream.Length < 80L)
						{
							num = (short)470745088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						stream = this.c(fileStream);
						num = (short)1697579010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					num = (short)611450885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_C8;
				}
				goto IL_51;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_51:
					if (access != global::System.IO.FileAccess.Read)
					{
						num = (short)383516679;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						fileStream = new global::System.IO.FileStream(path, global::System.IO.FileMode.Open, access, global::System.IO.FileShare.Read);
						num = (short)853540865;
						if (num != 0)
						{
						}
						num = (short)992608256;
						short num4 = num;
						num = (short)768409606;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			return stream;
			IL_C8:
			throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("儔砖簘栚猜㠞唠̢嘤刦夨嬪䈬崮䔰ጲ䄴弶尸ᬺ笼嘾ⵀ♂ф⑆⩈⹊㹌㱎煐╒㑔㭖ⱘ㹚獜", a_));
			IL_CD:
			global::System.IO.FileStream a_2 = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.a(path, global::System.IO.FileMode.Create, access, global::System.IO.FileShare.Read | global::System.IO.FileShare.Write | global::System.IO.FileShare.Delete);
			global::System.IO.Stream stream2 = this.d(a_2);
			global::Motorola.Common.CommonLib.EnDecryptStreamHelper.a(stream2);
			return stream2;
			IL_119:
			fileStream.Position = 0L;
			return fileStream;
			IL_20B:
			return null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000D39C File Offset: 0x0000B59C
		public global::System.IO.Stream CreateCryptoFlStream(global::System.IO.Stream content, bool decrypt = true)
		{
			switch (0)
			{
			case 0:
				goto IL_82;
			}
			short num;
			int num3;
			global::System.IO.Stream stream3;
			for (;;)
			{
				IL_0A:
				num = (short)869119221;
				short num2 = num;
				num = (short)428782837;
				global::System.IO.Stream stream;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)491388928;
					if (num != 0)
					{
					}
					global::System.IO.Stream stream2;
					switch (num3)
					{
					case 0:
						stream = this.c(content);
						num = (short)38862855;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1713504261;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						stream2 = stream;
						goto IL_18C;
					case 3:
						return stream3;
					case 4:
						num = (short)811859969;
						if (num != 0)
						{
						}
						if (decrypt)
						{
							num = (short)1676738568;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						stream3 = this.d(content);
						global::Motorola.Common.CommonLib.EnDecryptStreamHelper.a(stream3);
						num = (short)1734148099;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						stream2 = content;
						goto IL_18C;
					case 6:
						return stream3;
					case 7:
						goto IL_1E0;
					case 8:
						num = (short)1586888713;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (content.Length >= 80L)
						{
							num = (short)1816526848;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return stream3;
					}
					goto IL_82;
					IL_18C:
					stream3 = stream2;
					num = (short)1443627014;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_1E0:
				if (!global::Motorola.Common.CommonLib.EnDecryptStreamHelper.b(stream))
				{
					num = (short)2108293121;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)834797570;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return stream3;
			IL_82:
			num = (short)868286464;
			short num4 = num;
			stream3 = null;
			num = (short)1731133444;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000D5B0 File Offset: 0x0000B7B0
		private static void a(global::System.IO.Stream A_0)
		{
			short num = (short)1086652417;
			if (num != 0)
			{
			}
			num = (short)1029287438;
			short num2 = num;
			num = (short)1234021902;
			switch (num2 == num)
			{
			}
			num = (short)451936256;
			if (num != 0)
			{
			}
			num = (short)1638268928;
			short num3 = num;
			A_0.Write(global::Motorola.Common.CommonLib.EnDecryptStreamHelper.g, 0, global::Motorola.Common.CommonLib.EnDecryptStreamHelper.g.Length);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000D66C File Offset: 0x0000B86C
		public global::System.IO.Stream GetZippingAndEncryptingStream(global::System.IO.Stream outputStream)
		{
			short num = (short)1034033508;
			short num2 = num;
			num = (short)355932516;
			switch (num2 == num)
			{
			}
			num = (short)1075052544;
			if (num != 0)
			{
			}
			num = (short)1256456193;
			if (num != 0)
			{
			}
			num = (short)1617821696;
			short num3 = num;
			global::System.IO.Stream stream = this.d(outputStream);
			global::Motorola.Common.CommonLib.EnDecryptStreamHelper.a(stream);
			return new global::System.IO.Compression.DeflateStream(stream, global::System.IO.Compression.CompressionLevel.Fastest, false);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000D72C File Offset: 0x0000B92C
		public byte[] ZipAndEncryptByteArray(byte[] inputByteArray)
		{
			short num = (short)1257177088;
			switch (num)
			{
			default:
			{
				num = (short)1990393857;
				if (num != 0)
				{
				}
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				byte[] result;
				try
				{
					global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream(inputByteArray);
					try
					{
						global::System.IO.Stream zippingAndEncryptingStream = this.GetZippingAndEncryptingStream(memoryStream);
						try
						{
							memoryStream2.CopyTo(zippingAndEncryptingStream);
						}
						finally
						{
							num = (short)2043019265;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_D4;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_9F;
									}
									continue;
								case 2:
									((global::System.IDisposable)zippingAndEncryptingStream).Dispose();
									num = (short)978649088;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_9F:
								if (zippingAndEncryptingStream == null)
								{
									break;
								}
								num = (short)774438914;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D4:;
						}
					}
					finally
					{
						num = (short)67305473;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_140;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_10A;
								}
								continue;
							case 2:
								((global::System.IDisposable)memoryStream2).Dispose();
								num = (short)290586624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_10A:
							if (memoryStream2 == null)
							{
								break;
							}
							num = (short)1767243778;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_140:;
					}
					result = memoryStream.ToArray();
				}
				finally
				{
					num = (short)1104805889;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_206;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_181;
							}
							continue;
						case 2:
						{
							num = (short)1167697546;
							short num3 = num;
							num = (short)299017866;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_208;
							default:
								num = (short)2018115584;
								if (num != 0)
								{
								}
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)673054720;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_181:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)1763377154;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_206:
					IL_208:;
				}
				num = (short)598671360;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000D9BC File Offset: 0x0000BBBC
		public global::System.IO.Stream GetDecryptingAndUnzippingStream(global::System.IO.Stream inputStream)
		{
			short num = (short)1081999361;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.IO.Stream stream;
				bool flag;
				switch (num2)
				{
				case 0:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						global::System.IO.Stream result;
						for (;;)
						{
							IL_8E:
							switch (num2)
							{
							case 0:
								goto IL_126;
							case 1:
								goto IL_FE;
							case 2:
								if (!global::Motorola.Common.CommonLib.EnDecryptStreamHelper.b(stream))
								{
									num = (short)610664451;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								flag = false;
								result = new global::System.IO.Compression.DeflateStream(stream, global::System.IO.Compression.CompressionMode.Decompress, true);
								num = (short)1492647936;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								inputStream.Position = 0L;
								result = inputStream;
								num = (short)1620639745;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A4;
						}
						IL_FE:
						IL_126:
						return result;
						IL_A4:
						stream = this.c(inputStream);
						num = (short)869728258;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_8E;
					}
					finally
					{
						for (;;)
						{
							IL_12B:
							num = (short)328859651;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_242;
								case 1:
									num = (short)1862270980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)538328780;
									short num3 = num;
									num = (short)596786892;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_12B;
									default:
										num = (short)318832640;
										if (num != 0)
										{
										}
										num = (short)700121089;
										if (num != 0)
										{
										}
										stream.Dispose();
										num = (short)1836515328;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_163;
									}
									continue;
								case 4:
									if (stream != null)
									{
										num = (short)183500802;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_244;
								}
								IL_163:
								if (!flag)
								{
									goto IL_244;
								}
								num = (short)1685323777;
								num2 = (int)((global::System.IntPtr)num);
							}
						}
						IL_242:
						IL_244:;
					}
					goto IL_245;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					goto IL_54;
				}
				IL_31:
				if (inputStream.Length < 80L)
				{
					num = (short)593297410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_245:
				stream = null;
				flag = true;
				num = (short)1772027904;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_54:
			num = (short)520486912;
			short num4 = num;
			return inputStream;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000DC50 File Offset: 0x0000BE50
		public byte[] DecryptAndUnzipByteArray(byte[] inputByteArray)
		{
			short num = (short)1488715776;
			switch (num)
			{
			default:
			{
				num = (short)182517762;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream2;
					switch (num2)
					{
					case 0:
						try
						{
							global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(inputByteArray);
							try
							{
								switch (0)
								{
								case 0:
									goto IL_F6;
								}
								global::System.IO.Stream stream;
								byte[] result;
								for (;;)
								{
									IL_DB:
									global::System.IO.Compression.DeflateStream deflateStream;
									switch (num2)
									{
									case 0:
										goto IL_216;
									case 1:
										if (!global::Motorola.Common.CommonLib.EnDecryptStreamHelper.b(stream))
										{
											num = (short)1584594948;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1CD;
									case 2:
										try
										{
											deflateStream.CopyTo(memoryStream2);
											goto IL_1F6;
										}
										finally
										{
											num = (short)432865282;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_1CA;
												case 1:
													((global::System.IDisposable)deflateStream).Dispose();
													num = (short)2112749568;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_192;
													}
													continue;
												}
												IL_192:
												if (deflateStream == null)
												{
													break;
												}
												num = (short)926023681;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_1CA:;
										}
										goto IL_1CD;
										IL_1F6:
										result = memoryStream2.ToArray();
										num = (short)685375488;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_14D;
									case 4:
										result = inputByteArray;
										num = (short)148963331;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F6;
									IL_1CD:
									deflateStream = new global::System.IO.Compression.DeflateStream(stream, global::System.IO.Compression.CompressionMode.Decompress, true);
									num = (short)823066626;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_14D:
								IL_216:
								return result;
								IL_F6:
								stream = this.c(memoryStream);
								num = (short)1147142145;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_DB;
							}
							finally
							{
								num = (short)1352794114;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_283;
									case 1:
										((global::System.IDisposable)memoryStream).Dispose();
										num = (short)1792540672;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_24E;
										}
										continue;
									}
									IL_24E:
									if (memoryStream == null)
									{
										break;
									}
									num = (short)711786497;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_283:;
							}
						}
						finally
						{
							num = (short)232980482;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_33E;
								case 1:
									((global::System.IDisposable)memoryStream2).Dispose();
									goto IL_326;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2B8;
									}
									continue;
								}
								IL_2B8:
								num = (short)1497689164;
								short num3 = num;
								num = (short)1644489804;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_326:
									num = (short)1318060032;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)868220928;
									if (num != 0)
									{
									}
									if (memoryStream2 == null)
									{
										goto IL_340;
									}
									num = (short)944963585;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_33E:
							IL_340:;
						}
						goto IL_341;
					case 1:
						return inputByteArray;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_4F;
						}
						continue;
					}
					IL_4F:
					num = (short)270204929;
					if (num != 0)
					{
					}
					num = (short)1701773312;
					short num4 = num;
					if (inputByteArray.Length < 80)
					{
						num = (short)1776549889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_341:
					memoryStream2 = new global::System.IO.MemoryStream();
					num = (short)1283784704;
					num2 = (int)((global::System.IntPtr)num);
				}
				return inputByteArray;
			}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000E010 File Offset: 0x0000C210
		public byte[] GetBytesFromStream(global::System.IO.Stream sourceStream)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			short num;
			byte[] result;
			try
			{
				num = (short)3473409;
				if (num != 0)
				{
				}
				sourceStream.CopyTo(memoryStream);
				result = memoryStream.ToArray();
			}
			finally
			{
				num = (short)775159810;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_F5;
					case 1:
						((global::System.IDisposable)memoryStream).Dispose();
						goto IL_DD;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					}
					IL_72:
					num = (short)1090987357;
					short num3 = num;
					num = (short)119022941;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_DD:
						num = (short)2123038720;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)2064711680;
						if (num != 0)
						{
						}
						if (memoryStream == null)
						{
							goto IL_F7;
						}
						num = (short)360579073;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_F5:
				IL_F7:;
			}
			num = (short)143589376;
			short num4 = num;
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000E150 File Offset: 0x0000C350
		public bool IsEncryptedByMe(string filePath)
		{
			short num = (short)1763377152;
			switch (num)
			{
			default:
			{
				global::System.IO.Stream stream = global::System.IO.File.OpenRead(filePath);
				bool result;
				try
				{
					num = (short)1890779137;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1A2;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_62;
							}
							continue;
						case 2:
						{
							bool flag;
							try
							{
								global::System.IO.Stream stream2 = this.c(stream);
								flag = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.b(stream2);
							}
							finally
							{
								try
								{
									num = (short)94568448;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.IO.Stream stream2;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_133;
											}
											continue;
										case 1:
											goto IL_16D;
										case 2:
											goto IL_182;
										case 3:
											stream2.Dispose();
											num = (short)1543569409;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_133:
										if (stream2 != null)
										{
											num = (short)1735393283;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_16D:
										num = (short)524290;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_182:;
								}
								catch (global::System.Security.Cryptography.CryptographicException)
								{
								}
							}
							result = flag;
							num = (short)1883045888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_C2;
						case 4:
							result = false;
							num = (short)1403912195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_62:
						num = (short)13434881;
						if (num != 0)
						{
						}
						if (stream.Length < 80L)
						{
							num = (short)1907556356;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							bool flag = false;
							global::System.IO.Stream stream2 = null;
							num = (short)1469186050;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_C2:
					IL_1A2:;
				}
				finally
				{
					num = (short)270925826;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_25D;
						case 1:
							((global::System.IDisposable)stream).Dispose();
							goto IL_244;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1DA;
							}
							continue;
						}
						IL_1DA:
						num = (short)674893479;
						short num3 = num;
						num = (short)1551765159;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_244:
							num = (short)793968640;
							num2 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)721158144;
							if (num != 0)
							{
							}
							if (stream == null)
							{
								goto IL_25F;
							}
							num = (short)1163591681;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_25D:
					IL_25F:;
				}
				num = (short)894500864;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000E434 File Offset: 0x0000C634
		public void DecryptFileToFile(string sourcePath, string targetPath)
		{
			global::System.IO.Stream stream = this.CreateCryptoFlStream(sourcePath, global::System.IO.FileAccess.Read);
			short num;
			try
			{
				global::System.IO.FileStream fileStream = global::System.IO.File.Create(targetPath);
				try
				{
					stream.CopyTo(fileStream);
				}
				finally
				{
					num = (short)906035202;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_84;
						case 1:
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)1538129920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_50;
							}
							continue;
						}
						IL_50:
						if (fileStream == null)
						{
							break;
						}
						num = (short)1202585601;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_84:;
				}
			}
			finally
			{
				num = (short)1421017090;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_13C;
					case 1:
						((global::System.IDisposable)stream).Dispose();
						goto IL_123;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_B8;
						}
						continue;
					}
					IL_B8:
					num = (short)1059266215;
					short num3 = num;
					num = (short)1378426535;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_123:
						num = (short)553844736;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1582301184;
						if (num != 0)
						{
						}
						if (stream == null)
						{
							goto IL_13E;
						}
						num = (short)1191641089;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_13C:
				IL_13E:;
			}
			num = (short)171442177;
			if (num != 0)
			{
			}
			num = (short)1333592064;
			short num4 = num;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000E5F0 File Offset: 0x0000C7F0
		public void Dispose()
		{
			short num = (short)1645480937;
			short num2 = num;
			num = (short)1337658345;
			switch (num2 == num)
			{
			}
			num = (short)724172800;
			if (num != 0)
			{
			}
			num = (short)1610285057;
			if (num != 0)
			{
			}
			num = (short)2040987648;
			short num3 = num;
			this.Dispose(true);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1391589694;
			short num2 = num;
			num = (short)127269182;
			switch (num2 == num)
			{
			}
			num = (short)1854406657;
			if (num != 0)
			{
			}
			num = (short)143196160;
			if (num != 0)
			{
			}
			num = (short)727908352;
			short num3 = num;
			this.b.Dispose();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000E754 File Offset: 0x0000C954
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1622397857;
				short num2 = num;
				num = (short)2070139809;
				switch (num2 == num)
				{
				}
				num = (short)1512767488;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)1282473985;
			if (num != 0)
			{
			}
			num = (short)1465712640;
			short num3 = num;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000E820 File Offset: 0x0000CA20
		// Note: this type is marked as 'beforefieldinit'.
		static EnDecryptStreamHelper()
		{
			int a_ = 14;
			short num = (short)343717985;
			short num2 = num;
			num = (short)76527713;
			switch (num2 == num)
			{
			}
			num = (short)1035403265;
			if (num != 0)
			{
			}
			num = (short)1061486592;
			if (num != 0)
			{
			}
			num = (short)124846080;
			short num3 = num;
			global::Motorola.Common.CommonLib.EnDecryptStreamHelper.g = global::System.Text.Encoding.Unicode.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("椑刓␕娗⬙弛堝ᜟ搡णᜥ渧Ἡ渫̭Яȱȳ瀵ᔷ砹଻簽礿潁C畅็้筋硍扏慑敓晕浗潙⅛", a_));
		}

		// Token: 0x0400004D RID: 77
		private static global::Motorola.Common.CommonLib.EnDecryptStreamHelper a;

		// Token: 0x0400004E RID: 78
		private readonly global::System.Security.Cryptography.SymmetricAlgorithm b;

		// Token: 0x0400004F RID: 79
		private const string c = "{E88707E6-353F-46F3-8021-C4597593FA48}";

		// Token: 0x04000050 RID: 80
		private const int d = 128;

		// Token: 0x04000051 RID: 81
		private const string e = "{F05EECA8-6D69-4079-94F2-516473BF57A2}";

		// Token: 0x04000052 RID: 82
		private const string f = "{F2B1CF7F-1F5B-406F-B7B9-D3FD76231055}";

		// Token: 0x04000053 RID: 83
		private static readonly byte[] g;
	}
}
