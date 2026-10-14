using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using Motorola.Security.SamlCommonUtility.DMHttpClients;

namespace Motorola.Security.SamlCommonUtility
{
	// Token: 0x02000014 RID: 20
	public static class GZipUtilty
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00005A40 File Offset: 0x00003C40
		public static string Compress(string strToCompress)
		{
			int a_ = 5;
			short num;
			if (!string.IsNullOrWhiteSpace(strToCompress))
			{
				num = (short)1901875920;
				short num2 = num;
				num = (short)1144804048;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)997064704;
					if (num != 0)
					{
					}
					return global::System.Convert.ToBase64String(global::Motorola.Security.SamlCommonUtility.GZipUtilty.Compress(global::System.Text.Encoding.UTF8.GetBytes(strToCompress)));
				}
			}
			num = (short)1325662208;
			short num3 = num;
			num = (short)2133458945;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\uddad쒯삱\ud9b5﮷햹톻캽늿ꟁ럃뗅", a_));
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005B28 File Offset: 0x00003D28
		public static string Decompress(string base64EncodedStrToDecompress)
		{
			int a_ = 17;
			short num;
			if (!string.IsNullOrWhiteSpace(base64EncodedStrToDecompress))
			{
				num = (short)421064429;
				short num2 = num;
				num = (short)1315892973;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2127626240;
					if (num != 0)
					{
					}
					byte[] bytes = global::Motorola.Security.SamlCommonUtility.GZipUtilty.Decompress(global::System.Convert.FromBase64String(base64EncodedStrToDecompress));
					return global::System.Text.Encoding.UTF8.GetString(bytes);
				}
				}
			}
			num = (short)1389363201;
			if (num != 0)
			{
			}
			num = (short)1790771200;
			short num3 = num;
			throw new global::System.ArgumentNullException(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\ud8b9\uddbb춽ꖿ菅ꛇ꧉ꏋ꫍뗏뛑蟓ꋕ꫗軙돛髝藟臡诣该飧飩觫鷭華", a_));
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005C10 File Offset: 0x00003E10
		public static byte[] Compress(byte[] bytesToCompress)
		{
			int a_ = 3;
			short num = (short)596246531;
			int num2 = (int)((global::System.IntPtr)num);
			byte[] result;
			for (;;)
			{
				global::System.IO.MemoryStream memoryStream;
				switch (num2)
				{
				case 0:
					goto IL_222;
				case 1:
					try
					{
						global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Compress);
						try
						{
							gzipStream.Write(bytesToCompress, 0, bytesToCompress.Length);
						}
						finally
						{
							num = (short)811991041;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)gzipStream).Dispose();
									num = (short)1559756802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A8;
									}
									continue;
								case 2:
									goto IL_DE;
								}
								IL_A8:
								if (gzipStream == null)
								{
									break;
								}
								num = (short)2028797952;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_DE:;
						}
						result = memoryStream.ToArray();
						goto IL_238;
					}
					finally
					{
						num = (short)34799617;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)1319829506;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_11D;
								}
								continue;
							case 2:
							{
								num = (short)192301565;
								short num3 = num;
								num = (short)1990806013;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_189;
								}
								break;
							}
							}
							IL_11D:
							if (memoryStream == null)
							{
								goto IL_1A2;
							}
							num = (short)230948864;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_189:
						num = (short)201195520;
						if (num != 0)
						{
						}
						IL_1A2:;
					}
					goto IL_1A3;
				case 2:
					num = (short)1795555329;
					if (num != 0)
					{
					}
					num = (short)114688004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 4:
					if (bytesToCompress.Length == 0)
					{
						num = (short)951713792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A3;
				}
				IL_42:
				if (bytesToCompress != null)
				{
					num = (short)223150082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1A3:
				result = null;
				memoryStream = new global::System.IO.MemoryStream();
				num = (short)1544945665;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_222:
			throw new global::System.ArgumentNullException(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("캫힭쒯ힱ잳ힷ惡펻펽낿냁ꇃ뗅믇", a_));
			IL_238:
			num = (short)1367015424;
			short num4 = num;
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005E9C File Offset: 0x0000409C
		public static byte[] Decompress(byte[] bytesToDecompress)
		{
			int a_ = 15;
			short num = (short)301072384;
			short num2 = num;
			num = (short)947060736;
			int num3 = (int)num;
			switch (num3)
			{
			default:
				num = (short)1700790276;
				num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream2;
					switch (num3)
					{
					case 0:
						num = (short)1173094403;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_39C;
					case 2:
						try
						{
							global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(bytesToDecompress, 0, bytesToDecompress.Length);
							goto IL_DE;
							try
							{
								for (;;)
								{
									IL_DE:
									int num4 = 0;
									int num5 = 1024;
									byte[] buffer = new byte[num5];
									global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Decompress);
									goto IL_FB;
									try
									{
										for (;;)
										{
											IL_FB:
											switch (0)
											{
											case 0:
												goto IL_11C;
											}
											int num6;
											for (;;)
											{
												IL_105:
												switch (num3)
												{
												case 0:
													goto IL_19E;
												case 1:
													num = (short)1683161090;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													goto IL_171;
												case 3:
													if (num6 == 0)
													{
														num = (short)160169985;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													memoryStream2.Write(buffer, 0, num6);
													num4 += num6;
													num = (short)57999360;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_11C;
											}
											IL_19E:
											continue;
											IL_11C:
											num6 = gzipStream.Read(buffer, 0, num5);
											num = (short)1715208195;
											num3 = (int)((global::System.IntPtr)num);
											goto IL_105;
										}
										IL_171:;
									}
									finally
									{
										num = (short)1229127682;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
												goto IL_210;
											case 1:
												((global::System.IDisposable)gzipStream).Dispose();
												num = (short)733872128;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_1D6;
												}
												continue;
											}
											IL_1D6:
											if (gzipStream == null)
											{
												break;
											}
											num = (short)773652481;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_210:;
									}
									num = (short)991540271;
									short num7 = num;
									num = (short)1118352431;
									switch ((num7 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_248;
									}
								}
								IL_248:
								num = (short)1398210560;
								if (num != 0)
								{
								}
								return memoryStream2.ToArray();
							}
							finally
							{
								num = (short)2057764866;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_2D5;
									case 1:
										((global::System.IDisposable)memoryStream).Dispose();
										num = (short)360775680;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_29D;
										}
										continue;
									}
									IL_29D:
									if (memoryStream == null)
									{
										break;
									}
									num = (short)2110849025;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_2D5:;
							}
						}
						finally
						{
							num = (short)980090882;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_33F;
								case 1:
									((global::System.IDisposable)memoryStream2).Dispose();
									num = (short)1402994688;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_30A;
									}
									continue;
								}
								IL_30A:
								if (memoryStream2 == null)
								{
									break;
								}
								num = (short)1142882305;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_33F:;
						}
						goto IL_342;
					case 3:
						if (bytesToDecompress.Length == 0)
						{
							num = (short)265486337;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_342;
					case 4:
						num = (short)815071233;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B1;
						}
						continue;
					}
					IL_B1:
					if (bytesToDecompress != null)
					{
						num = (short)93847552;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_342:
					memoryStream2 = new global::System.IO.MemoryStream();
					num = (short)2078408706;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_39C:
				throw new global::System.ArgumentNullException(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\udab7쎹좻\udbbd뎿雁ꯃ苅귇꧉ꏋꏍꃏꃑ뇓ꗕꯗ", a_));
			}
		}
	}
}
