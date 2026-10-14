using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using AcpUtility;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.CommonLib
{
	// Token: 0x02000015 RID: 21
	public class MetaDataEnDecryptHelper : global::System.IDisposable
	{
		// Token: 0x06000078 RID: 120 RVA: 0x0001106C File Offset: 0x0000F26C
		private MetaDataEnDecryptHelper()
		{
			this.b = global::System.Security.Cryptography.Aes.Create();
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0001108C File Offset: 0x0000F28C
		public static global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper Instance
		{
			get
			{
				short num = (short)1905587750;
				short num2 = num;
				num = (short)2075194918;
				switch (num2 == num)
				{
				}
				num = (short)1303838720;
				if (num != 0)
				{
				}
				num = (short)1505034241;
				if (num != 0)
				{
				}
				num = (short)2102132736;
				short num3 = num;
				global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper result;
				if ((result = global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.a) == null)
				{
					result = (global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.a = new global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper());
				}
				return result;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00011150 File Offset: 0x0000F350
		public void EncryptFileToFile(string filePath, string outputFileName, bool compress)
		{
			int a_ = 10;
			short num;
			try
			{
				num = (short)339345408;
				switch (num)
				{
				default:
				{
					num = (short)1160708096;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_79;
							}
							continue;
						case 1:
							goto IL_2C3;
						case 2:
							try
							{
								num = (short)699858945;
								if (num != 0)
								{
								}
								global::System.IO.FileStream fileStream;
								byte[] array;
								fileStream.Write(array, 0, array.Length);
								goto IL_36D;
							}
							finally
							{
								num = (short)1079320924;
								short num3 = num;
								num = (short)988684636;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)58916864;
									if (num != 0)
									{
									}
									num = (short)595066881;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.IO.FileStream fileStream;
										switch (num2)
										{
										case 0:
											goto IL_268;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_232;
											}
											continue;
										case 2:
											((global::System.IDisposable)fileStream).Dispose();
											num = (short)1133117440;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_232:
										if (fileStream == null)
										{
											break;
										}
										num = (short)181207042;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_268:
									break;
								}
							}
							goto IL_26B;
							IL_36D:
							num = (short)536346630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_178;
						case 4:
							num = (short)1524826113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							if (!global::System.IO.File.Exists(global::System.IO.Path.GetFullPath(filePath)))
							{
								num = (short)1104805892;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.b.Key = global::System.Convert.FromBase64String(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("對紏向唓䌕爗戙焛簝真刡栣栥䔧䄩崫笭支搱挳倵洷刹医漽焿ᝁ㝃≅祇ࡉ͋ṍ恏ࡑ⑓ᩕ๗㵙歛ଢ଼㍟㍡奣", a_));
							this.b.IV = global::System.Convert.FromBase64String(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("洍樏我Ⱃ崕丗渙䴛砝瘟眡ଣ䐥䈧ጩ渫䰭是瀱娳缵伷ܹĻ", a_));
							byte[] array = null;
							global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
							num = (short)110362631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_385;
						case 7:
						{
							byte[] array2;
							try
							{
								global::System.IO.FileStream fileStream2;
								array2 = new byte[fileStream2.Length];
								fileStream2.Read(array2, 0, array2.Length);
								goto IL_9E;
							}
							finally
							{
								num = (short)531234817;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IO.FileStream fileStream2;
									switch (num2)
									{
									case 0:
										goto IL_15D;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_127;
										}
										continue;
									case 2:
										((global::System.IDisposable)fileStream2).Dispose();
										num = (short)1440088064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_127:
									if (fileStream2 == null)
									{
										break;
									}
									num = (short)1791229954;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_15D:;
							}
							goto IL_160;
							IL_9E:
							byte[] array;
							global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.b(array2, ref array, compress, this.b.CreateEncryptor());
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(outputFileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
							num = (short)1112735746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_26B;
						case 9:
							if (string.IsNullOrEmpty(outputFileName))
							{
								num = (short)2064318474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1775304709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_160;
						}
						IL_79:
						if (!string.IsNullOrEmpty(filePath))
						{
							num = (short)645464072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_160:
						num = (short)78184451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_26B:
						num = (short)2051014665;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_178:
					IL_2C3:
					IL_385:
					break;
				}
				}
			}
			catch
			{
				throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䬍縏焑易漕栗渙甛焝丟ȡ䈣䜥䄧䘩䤫䨭ḯ", a_));
			}
			num = (short)1510735872;
			short num4 = num;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00011570 File Offset: 0x0000F770
		private static void b(byte[] A_0, ref byte[] A_1, bool A_2, global::System.Security.Cryptography.ICryptoTransform A_3)
		{
			short num = (short)1611792384;
			switch (num)
			{
			default:
			{
				num = (short)1639120901;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream2;
					switch (num2)
					{
					case 0:
					{
						num = (short)1195900928;
						short num3 = num;
						goto IL_320;
					}
					case 1:
						num = (short)1142882305;
						if (num != 0)
						{
						}
						try
						{
							global::System.IO.MemoryStream memoryStream;
							global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Compress, true);
							try
							{
								gzipStream.Write(A_0, 0, A_0.Length);
							}
							finally
							{
								num = (short)1184432129;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_153;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_11B;
										}
										continue;
									case 2:
										((global::System.IDisposable)gzipStream).Dispose();
										num = (short)1922039808;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_11B:
									if (gzipStream == null)
									{
										break;
									}
									num = (short)410189826;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_153:;
							}
							A_0 = memoryStream.ToArray();
							goto IL_AC;
						}
						finally
						{
							num = (short)961019905;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.IO.MemoryStream memoryStream;
								switch (num2)
								{
								case 0:
									goto IL_1CB;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_196;
									}
									continue;
								case 2:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)1863057408;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_196:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)1012334594;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1CB:;
						}
						return;
					case 2:
						if (A_2)
						{
							num = (short)2000748547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					case 3:
					{
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
						num = (short)1274806273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						try
						{
							num = (short)2019301151;
							short num4 = num;
							num = (short)682432287;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)997654528;
								if (num != 0)
								{
								}
								global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream2, A_3, global::System.Security.Cryptography.CryptoStreamMode.Write);
								try
								{
									cryptoStream.Write(A_0, 0, A_0.Length);
									cryptoStream.FlushFinalBlock();
								}
								finally
								{
									num = (short)235732993;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_2A2;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_26B;
											}
											continue;
										case 2:
											((global::System.IDisposable)cryptoStream).Dispose();
											num = (short)709099520;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_26B:
										if (cryptoStream == null)
										{
											break;
										}
										num = (short)59179010;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_2A2:;
								}
								break;
							}
							}
							A_1 = memoryStream2.ToArray();
							return;
						}
						finally
						{
							num = (short)758972417;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_31D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2E6;
									}
									continue;
								case 2:
									((global::System.IDisposable)memoryStream2).Dispose();
									num = (short)693239808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2E6:
								if (memoryStream2 == null)
								{
									break;
								}
								num = (short)1981874178;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_31D:;
						}
						goto IL_320;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 6:
						if (A_0.Length == 0)
						{
							num = (short)1266548743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)709296130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_355;
					}
					IL_64:
					if (A_0 != null)
					{
						num = (short)566362112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_AC:
					memoryStream2 = new global::System.IO.MemoryStream();
					num = (short)1474035716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_320:
					num = (short)101449734;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_355:
				return;
			}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00011994 File Offset: 0x0000FB94
		public global::System.IO.Stream DecryptStreamToStream(global::System.IO.Stream stream, bool decompress)
		{
			int a_ = 7;
			short num;
			global::System.IO.Stream result;
			try
			{
				for (;;)
				{
					IL_09:
					num = (short)1795293185;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_151;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_3D;
							}
							continue;
						case 2:
							result = null;
							num = (short)440336387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_6C;
						}
						IL_3D:
						if (stream == null)
						{
							num = (short)678100994;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)1967851041;
							short num3 = num;
							num = (short)354747937;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
							{
								num = (short)1773076480;
								if (num != 0)
								{
								}
								this.b.Key = global::System.Convert.FromBase64String(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("夊怌䤎倐䘒缔漖琘礚䨜漞洠洢䠤䰦堨縪砬礮昰唲怴弶嘸樺఼樾㉀❂瑄Նوᭊ経ᕎ⅐ὒ͔ざ湘๚๜๞屠", a_));
								this.b.IV = global::System.Convert.FromBase64String(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("栊県缎⤐堒䌔挖䠘級䬜䨞ภ䄢伤Ḧ欨䤪第洮弰稲䈴ਸ਼и", a_));
								byte[] buffer = null;
								byte[] array = new byte[stream.Length];
								stream.Read(array, 0, array.Length);
								stream.Seek(0L, global::System.IO.SeekOrigin.Begin);
								global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.a(array, ref buffer, decompress, this.b.CreateDecryptor());
								result = new global::System.IO.MemoryStream(buffer);
								num = (short)282001408;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							}
						}
					}
				}
				IL_6C:
				IL_151:;
			}
			catch
			{
				throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("伊栌氎挐樒攔挖瀘琚猜㼞䜠䈢䰤䬦䰨伪̬", a_));
			}
			num = (short)372768768;
			short num4 = num;
			num = (short)270139393;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00011B78 File Offset: 0x0000FD78
		public global::System.IO.Stream DecryptFileToStream(string filePath, bool decompress)
		{
			int a_ = 19;
			global::System.IO.Stream result;
			short num;
			try
			{
				global::System.IO.Stream stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				try
				{
					result = this.DecryptStreamToStream(stream, decompress);
				}
				finally
				{
					num = (short)1218763344;
					short num2 = num;
					num = (short)2143803984;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1868759040;
						if (num != 0)
						{
						}
						num = (short)209256449;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_D0;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_9C;
								}
								continue;
							case 2:
								((global::System.IDisposable)stream).Dispose();
								num = (short)215941120;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_9C:
							if (stream == null)
							{
								break;
							}
							num = (short)197722114;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_D0:
						break;
					}
					}
				}
			}
			catch (global::System.IO.IOException)
			{
				throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("堖椘縚猜㼞䜠䨢䤤䈦न䴪䰬䘮崰嘲儴ᤶ", a_));
			}
			catch
			{
				throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("化簘砚漜昞儠圢䰤䠦䜨ପ䬬丮堰弲倴匶᜸", a_));
			}
			num = (short)1701576704;
			short num4 = num;
			num = (short)1000472577;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00011CFC File Offset: 0x0000FEFC
		private static global::System.Text.Encoding a(byte[] A_0, ref byte[] A_1, bool A_2, global::System.Security.Cryptography.ICryptoTransform A_3)
		{
			short num = (short)78249984;
			short num2 = num;
			num = (short)1712914432;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B3;
				}
				byte[] array;
				global::System.Text.Encoding encoding;
				global::System.IO.MemoryStream memoryStream3;
				for (;;)
				{
					IL_50:
					byte b;
					switch (num3)
					{
					case 0:
						A_1 = new byte[array.Length];
						global::System.Array.Copy(array, 0, A_1, 0, array.Length);
						encoding = new global::System.Text.UTF8Encoding();
						global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.a(ref A_1, encoding);
						num = (short)608763921;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array);
						num = (short)200867851;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (array[1].Equals(187))
						{
							num = (short)1032192018;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return encoding;
					case 3:
						return encoding;
					case 4:
						A_1 = new byte[array.Length - 2];
						global::System.Array.Copy(array, 2, A_1, 0, array.Length - 2);
						encoding = new global::System.Text.UnicodeEncoding();
						global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.a(ref A_1, encoding);
						num = (short)67764229;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return encoding;
					case 6:
						A_1 = new byte[array.Length - 3];
						global::System.Array.Copy(array, 3, A_1, 0, array.Length - 3);
						encoding = new global::System.Text.UTF8Encoding();
						global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.a(ref A_1, encoding);
						num = (short)1811677187;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_50A;
					case 8:
						if (A_2)
						{
							num = (short)20054017;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_592;
					case 9:
						num = (short)872087567;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (b != 239)
						{
							num = (short)670892041;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)462225410;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						try
						{
							global::System.IO.MemoryStream memoryStream;
							global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Decompress, false);
							try
							{
								byte[] array2 = new byte[4096];
								global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream();
								try
								{
									num = (short)1892155395;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
										{
											int count;
											if ((count = gzipStream.Read(array2, 0, array2.Length)) <= 0)
											{
												num = (short)1566769154;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											memoryStream2.Write(array2, 0, count);
											num = (short)466419713;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											array = memoryStream2.ToArray();
											num = (short)1084620804;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											switch (0)
											{
											case 0:
												goto IL_2E6;
											}
											continue;
										case 4:
											goto IL_371;
										}
										IL_30D:
										num = (short)571211776;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_2E6:
										goto IL_30D;
									}
									IL_371:
									goto IL_592;
								}
								finally
								{
									num = (short)361955329;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											((global::System.IDisposable)memoryStream2).Dispose();
											num = (short)1189216258;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_3AA;
											}
											continue;
										case 2:
											goto IL_3E1;
										}
										IL_3AA:
										if (memoryStream2 == null)
										{
											break;
										}
										num = (short)296747008;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_3E1:;
								}
							}
							finally
							{
								num = (short)1370423297;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)gzipStream).Dispose();
										num = (short)82378754;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_417;
										}
										continue;
									case 2:
										goto IL_44F;
									}
									IL_417:
									if (gzipStream == null)
									{
										break;
									}
									num = (short)39387136;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_44F:;
							}
						}
						finally
						{
							num = (short)484380576;
							short num4 = num;
							num = (short)72290208;
							global::System.IO.MemoryStream memoryStream;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_4E8:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)19857408;
								num3 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)2078539776;
								if (num != 0)
								{
								}
								num = (short)1569390594;
								num3 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_507;
								case 1:
									goto IL_4E8;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4CF;
									}
									continue;
								}
								IL_4CF:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)1328218113;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_507:;
						}
						goto IL_50A;
					case 12:
						try
						{
							global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream3, A_3, global::System.Security.Cryptography.CryptoStreamMode.Read);
							try
							{
								array = cryptoStream.ReadRequestedBytes(A_0.Length);
							}
							finally
							{
								num = (short)947978242;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_65C;
									case 1:
										((global::System.IDisposable)cryptoStream).Dispose();
										num = (short)1687683072;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_626;
										}
										continue;
									}
									IL_626:
									if (cryptoStream == null)
									{
										break;
									}
									num = (short)902955009;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_65C:;
							}
						}
						finally
						{
							num = (short)2050228226;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_6C7;
								case 1:
									((global::System.IDisposable)memoryStream3).Dispose();
									num = (short)1038090240;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_691;
									}
									continue;
								}
								IL_691:
								if (memoryStream3 == null)
								{
									break;
								}
								num = (short)2060058625;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_6C7:;
						}
						num = (short)642646024;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)639369216;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return encoding;
					case 15:
						if (b != 254)
						{
							num = (short)881786899;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1169227797;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (b != 255)
						{
							num = (short)516227085;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)732758038;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						return encoding;
					case 18:
						num = (short)495845396;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1256456193;
						if (num != 0)
						{
						}
						num = (short)486473744;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (array[2].Equals(191))
						{
							num = (short)2102001670;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return encoding;
					case 21:
						if (array[1].Equals(255))
						{
							num = (short)1554382852;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return encoding;
					case 22:
						if (array[1].Equals(254))
						{
							num = (short)1019084807;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return encoding;
					}
					goto IL_B3;
					IL_50A:
					A_1 = new byte[array.Length - 2];
					global::System.Array.Copy(array, 2, A_1, 0, array.Length - 2);
					encoding = new global::System.Text.UnicodeEncoding();
					global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.a(ref A_1, encoding);
					num = (short)1977745422;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_592:
					b = array[0];
					num = (short)1634336778;
					num3 = (int)((global::System.IntPtr)num);
				}
				return encoding;
				IL_B3:
				encoding = null;
				array = new byte[A_0.Length];
				memoryStream3 = new global::System.IO.MemoryStream(A_0);
				num = (short)906756108;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0001258C File Offset: 0x0001078C
		private static void a(ref byte[] A_0, global::System.Text.Encoding A_1)
		{
			short num = (short)1237909996;
			short num2 = num;
			num = (short)848036332;
			switch (num2 == num)
			{
			}
			num = (short)1584988160;
			short num3 = num;
			num = (short)452067329;
			if (num != 0)
			{
			}
			num = (short)1642463232;
			if (num != 0)
			{
			}
			string text = A_1.GetString(A_0);
			text = text.TrimEnd(new char[1]);
			A_0 = A_1.GetBytes(text);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00012658 File Offset: 0x00010858
		public void Dispose()
		{
			short num = (short)386837423;
			short num2 = num;
			num = (short)1803201455;
			switch (num2 == num)
			{
			}
			num = (short)807469056;
			short num3 = num;
			num = (short)13893633;
			if (num != 0)
			{
			}
			num = (short)1883242496;
			if (num != 0)
			{
			}
			this.Dispose(true);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00012708 File Offset: 0x00010908
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1549139968;
			short num2 = num;
			num = (short)1785250750;
			short num3 = num;
			num = (short)2016003006;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E8:
				this.b.Dispose();
				num = (short)122224640;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)832241665;
				if (num != 0)
				{
				}
				num = (short)360644608;
				if (num != 0)
				{
				}
				num = (short)823394306;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					return;
				case 1:
					goto IL_E8;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_D1;
					}
					continue;
				}
				IL_D1:
				if (!disposing)
				{
					break;
				}
				num = (short)115736577;
				num4 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00012820 File Offset: 0x00010A20
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1859847442;
				short num2 = num;
				num = (short)720307474;
				switch (num2 == num)
				{
				}
				num = (short)988217344;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				num = (short)503316481;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)1961361408;
			short num3 = num;
		}

		// Token: 0x04000060 RID: 96
		private static global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper a;

		// Token: 0x04000061 RID: 97
		private readonly global::System.Security.Cryptography.SymmetricAlgorithm b;

		// Token: 0x04000062 RID: 98
		private const string c = "RmFAUjxmbWpLNmkqUUVWfUhoQ1Usd1BOP0ZpLVg7USQ";

		// Token: 0x04000063 RID: 99
		private const string d = "czp8KVtQfVU/bj9BbVBnIw";

		// Token: 0x04000064 RID: 100
		private const byte e = 239;

		// Token: 0x04000065 RID: 101
		private const byte f = 187;

		// Token: 0x04000066 RID: 102
		private const byte g = 191;

		// Token: 0x04000067 RID: 103
		private const byte h = 254;

		// Token: 0x04000068 RID: 104
		private const byte i = 255;

		// Token: 0x04000069 RID: 105
		private const byte j = 255;

		// Token: 0x0400006A RID: 106
		private const byte k = 254;

		// Token: 0x0400006B RID: 107
		private const int l = 3;

		// Token: 0x0400006C RID: 108
		private const int m = 2;

		// Token: 0x0400006D RID: 109
		private const int n = 1024;

		// Token: 0x0400006E RID: 110
		private const int o = 0;

		// Token: 0x0400006F RID: 111
		private const char p = '\0';
	}
}
