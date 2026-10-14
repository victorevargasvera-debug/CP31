using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CompressionWrapper;
using Motorola.Common.CustomException;
using SevenZip;
using SevenZip.Compression.LZMA;

namespace Motorola.Common.Communication.CommonFile
{
	// Token: 0x0200000D RID: 13
	internal class d
	{
		// Token: 0x0600001B RID: 27 RVA: 0x0000351C File Offset: 0x0000171C
		private uint a()
		{
			short num = (short)2001600513;
			if (num != 0)
			{
			}
			num = (short)1457205960;
			short num2 = num;
			num = (short)1798910664;
			switch (num2 == num)
			{
			}
			num = (short)85524480;
			if (num != 0)
			{
			}
			num = (short)769851392;
			short num3 = num;
			return this.e;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000035CC File Offset: 0x000017CC
		private void a(uint A_0)
		{
			short num = (short)36379003;
			short num2 = num;
			num = (short)723655035;
			switch (num2 == num)
			{
			}
			num = (short)1960181761;
			if (num != 0)
			{
			}
			num = (short)1997799424;
			if (num != 0)
			{
			}
			num = (short)1765212160;
			short num3 = num;
			this.e = A_0;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000367C File Offset: 0x0000187C
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonFile.c> b(byte[] A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			long num4;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonFile.c> list;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_69;
				case 1:
				{
					num2 = (short)1731849531;
					short num3 = num2;
					num2 = (short)147189051;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1EB;
					case 1:
						goto IL_FE;
					}
					goto Block_2;
				}
				case 2:
					goto IL_69;
				case 3:
				{
					if (num4 >= (long)(A_0.Length - 4))
					{
						num2 = (short)2141978625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.Common.Communication.CommonFile.c c = new global::Motorola.Common.Communication.CommonFile.c();
					checked
					{
						c.f(A_0[(int)((global::System.IntPtr)num4)]);
						c.g(A_0[(int)((global::System.IntPtr)(unchecked(num4 + 1L)))]);
						c.f(global::System.BitConverter.ToInt32(new byte[]
						{
							A_0[(int)((global::System.IntPtr)(unchecked(num4 + 2L)))],
							A_0[(int)((global::System.IntPtr)(unchecked(num4 + 3L)))],
							A_0[(int)((global::System.IntPtr)(unchecked(num4 + 4L)))],
							A_0[(int)((global::System.IntPtr)(unchecked(num4 + 5L)))]
						}, 0));
						c.g(global::System.BitConverter.ToInt32(new byte[]
						{
							A_0[(int)((global::System.IntPtr)(unchecked(num4 + 6L)))],
							A_0[(int)((global::System.IntPtr)(unchecked(num4 + 7L)))],
							A_0[(int)((global::System.IntPtr)(unchecked(num4 + 8L)))],
							A_0[(int)((global::System.IntPtr)(unchecked(num4 + 9L)))]
						}, 0));
						c.f(new byte[c.h()]);
					}
					global::System.Array.Copy(A_0, num4 + 10L, c.j(), 0L, (long)c.h());
					list.Add(c);
					num4 = num4 + 10L + (long)c.h();
					goto IL_1EB;
				}
				}
				goto IL_20;
				IL_69:
				num2 = (short)1933246467;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1EB:
				num2 = (short)2119696384;
				num = (int)((global::System.IntPtr)num2);
			}
			Block_2:
			num2 = (short)519110656;
			short num5 = num2;
			IL_FE:
			num2 = (short)1925906432;
			if (num2 != 0)
			{
			}
			return list;
			IL_20:
			num2 = (short)1794244609;
			if (num2 != 0)
			{
			}
			list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonFile.c>();
			num4 = 0L;
			num2 = (short)1855324162;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000038A8 File Offset: 0x00001AA8
		public static byte[] a(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonFile.c> A_0)
		{
			short num = (short)995098624;
			switch (num)
			{
			default:
			{
				num = (short)2100363264;
				short num2 = num;
				global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonFile.c>.Enumerator enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)187105289;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.Communication.CommonFile.c c;
						byte[] array;
						global::SevenZip.Compression.LZMA.Decoder decoder;
						global::System.IO.MemoryStream memoryStream2;
						byte[] array3;
						byte[] collection;
						switch (num3)
						{
						case 0:
							goto IL_12A;
						case 1:
						{
							uint num4 = 0U;
							global::Motorola.Common.Communication.CompressionWrapper.FastLZWrapper.DataDecompress(c.j(), array, ref num4);
							num = (short)299958288;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							byte b;
							if (b == 2)
							{
								num = (short)846200833;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1236795405;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_52F;
						case 4:
							try
							{
								global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(c.i());
								try
								{
									decoder.Train(memoryStream2);
									memoryStream2.Position = 13L;
									decoder.Code(memoryStream2, memoryStream, (long)c.j().Length, (long)c.i(), null);
									array = memoryStream.ToArray();
									goto IL_259;
								}
								finally
								{
									num = (short)541786114;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											((global::System.IDisposable)memoryStream).Dispose();
											num = (short)506658817;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_335;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_2FD;
											}
											continue;
										}
										IL_2FD:
										if (memoryStream == null)
										{
											break;
										}
										num = (short)390397952;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_335:;
								}
							}
							finally
							{
								num = (short)770244610;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									num = (short)870182728;
									short num5 = num;
									num = (short)416477000;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3F2;
									default:
										num = (short)1363935232;
										if (num != 0)
										{
										}
										switch (num3)
										{
										case 0:
											((global::System.IDisposable)memoryStream2).Dispose();
											num = (short)1422393345;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_3F2;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_3B7;
											}
											continue;
										}
										IL_3B7:
										if (memoryStream2 == null)
										{
											goto IL_3F4;
										}
										num = (short)1429864448;
										num3 = (int)((global::System.IntPtr)num);
										break;
									}
								}
								IL_3F2:
								IL_3F4:;
							}
							goto IL_3F5;
						case 5:
							goto IL_1DE;
						case 6:
						{
							byte[] array2 = new byte[5];
							array2[0] = 93;
							array2[2] = 64;
							array3 = array2;
							num = (short)1606352901;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_3F5;
						case 8:
						{
							byte b2;
							if (b2 == 0)
							{
								num = (short)959315974;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1DE;
						}
						case 9:
							switch (0)
							{
							case 0:
								goto IL_C4;
							}
							continue;
						case 10:
						{
							byte b2;
							if (b2 == 2)
							{
								num = (short)2106523662;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12A;
						}
						case 12:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)895025169;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							c = enumerator.Current;
							collection = c.j();
							byte b = c.g() / 16;
							byte b2 = c.g() & 15;
							array = new byte[c.i()];
							num = (short)131923970;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							byte b;
							if (b == 1)
							{
								num = (short)407568391;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_259;
						}
						case 14:
						{
							byte[] array4 = new byte[5];
							array4[0] = 93;
							array4[3] = 4;
							array3 = array4;
							num = (short)848101376;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							goto IL_128;
						case 16:
						{
							uint num4;
							if ((ulong)num4 != (ulong)((long)c.i()))
							{
								num = (short)72286223;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_259;
						}
						case 17:
							num = (short)1781596163;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4;
						IL_12A:
						decoder.SetDecoderProperties(array3);
						global::System.Collections.Generic.List<byte> list2 = new global::System.Collections.Generic.List<byte>();
						list2.AddRange(array3);
						list2.AddRange(global::System.BitConverter.GetBytes(c.i()));
						list2.AddRange(new byte[4]);
						list2.AddRange(c.j());
						memoryStream2 = new global::System.IO.MemoryStream(list2.ToArray());
						num = (short)1980235780;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_19C:
						num = (short)1921253388;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C4:
						goto IL_19C;
						IL_1DE:
						num = (short)197656586;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_259:
						collection = array;
						list.AddRange(collection);
						num = (short)482803723;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_3F5:
						decoder = new global::SevenZip.Compression.LZMA.Decoder();
						byte[] array5 = new byte[5];
						array5[0] = 93;
						array5[3] = 1;
						array3 = array5;
						num = (short)1149960200;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_128:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_Compression_FASTLZ_Decompress_Failed);
					IL_52F:;
				}
				finally
				{
					num = (short)98041857;
					if (num != 0)
					{
					}
					((global::System.IDisposable)enumerator).Dispose();
				}
				return list.ToArray();
			}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003E70 File Offset: 0x00002070
		public static byte[] a(byte[] A_0)
		{
			short num = (short)780533760;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1932328960;
				short num3 = num;
				global::SevenZip.Compression.LZMA.Encoder encoder = new global::SevenZip.Compression.LZMA.Encoder();
				byte[] array = null;
				global::System.IO.Stream stream = new global::System.IO.MemoryStream(A_0);
				try
				{
					global::System.IO.Stream stream2 = new global::System.IO.MemoryStream();
					try
					{
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						for (;;)
						{
							IL_6B:
							switch (num2)
							{
							case 0:
							{
								int num4;
								if (num4 >= 8)
								{
									num = (short)406192132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								stream2.WriteByte((byte)(stream.Length >> 8 * num4));
								num4++;
								num = (short)71434241;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_13D;
							case 2:
								goto IL_104;
							case 3:
								goto IL_1D2;
							case 4:
							{
								long outSize = 0L;
								encoder.Code(stream, stream2, stream.Length, outSize, null);
								stream2.Position = 13L;
								array = new byte[stream2.Length - 13L];
								stream2.Read(array, 0, array.Length);
								num = (short)806944771;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_86;
						}
						IL_104:
						goto IL_13F;
						IL_1D2:
						goto IL_2B3;
						IL_86:
						num = (short)50063470;
						short num5 = num;
						num = (short)1106831470;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_13D:
							break;
						default:
						{
							num = (short)830537728;
							if (num != 0)
							{
							}
							encoder.SetCoderProperties(global::Motorola.Common.Communication.CommonFile.d.c, global::Motorola.Common.Communication.CommonFile.d.d);
							encoder.WriteCoderProperties(stream2);
							int num4 = 0;
							num = (short)1286537218;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_6B;
						}
						}
						IL_13F:
						num = (short)861405184;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_6B;
					}
					finally
					{
						num = (short)248250368;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_20A;
								}
								continue;
							case 1:
								goto IL_243;
							case 2:
								((global::System.IDisposable)stream2).Dispose();
								num = (short)1075445761;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_20A:
							if (stream2 == null)
							{
								break;
							}
							num = (short)404619266;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_243:;
					}
				}
				finally
				{
					num = (short)1062535168;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_279;
							}
							continue;
						case 1:
							goto IL_2B0;
						case 2:
							((global::System.IDisposable)stream).Dispose();
							num = (short)531234817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_279:
						if (stream == null)
						{
							break;
						}
						num = (short)1042284546;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2B0:;
				}
				IL_2B3:
				num = (short)1860370433;
				if (num != 0)
				{
				}
				byte[] array2 = new byte[10];
				array2[0] = 16;
				array2[1] = 17;
				byte[] bytes = global::System.BitConverter.GetBytes(array.Length);
				global::System.Array.Copy(bytes, 0, array2, 2, bytes.Length);
				byte[] bytes2 = global::System.BitConverter.GetBytes(A_0.Length);
				global::System.Array.Copy(bytes2, 0, array2, 6, bytes2.Length);
				global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
				list.AddRange(array2);
				list.AddRange(array);
				byte[] bytes3 = global::System.BitConverter.GetBytes((int)global::Motorola.Common.Communication.CommonFile.CheckSumCrc32.GetCrc32CheckSum(list.ToArray()));
				list.AddRange(bytes3);
				return list.ToArray();
			}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004200 File Offset: 0x00002400
		// Note: this type is marked as 'beforefieldinit'.
		static d()
		{
			int a_ = 2;
			short num = (short)1035515024;
			short num2 = num;
			num = (short)526300304;
			switch (num2 == num)
			{
			}
			num = (short)61931520;
			short num3 = num;
			num = (short)1801715712;
			if (num != 0)
			{
			}
			num = (short)1059586049;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonFile.d.a = 65536;
			global::Motorola.Common.Communication.CommonFile.d.b = false;
			global::SevenZip.CoderPropID[] array = new global::SevenZip.CoderPropID[8];
			global::System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array, fieldof(global::c.b).FieldHandle);
			global::Motorola.Common.Communication.CommonFile.d.c = array;
			global::Motorola.Common.Communication.CommonFile.d.d = new object[]
			{
				global::Motorola.Common.Communication.CommonFile.d.a,
				2,
				3,
				0,
				1,
				32,
				global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.e("朄猆㴈", a_),
				global::Motorola.Common.Communication.CommonFile.d.b
			};
		}

		// Token: 0x04000022 RID: 34
		private static int a;

		// Token: 0x04000023 RID: 35
		private static bool b;

		// Token: 0x04000024 RID: 36
		private static global::SevenZip.CoderPropID[] c;

		// Token: 0x04000025 RID: 37
		private static object[] d;

		// Token: 0x04000026 RID: 38
		private uint e;

		// Token: 0x0200000E RID: 14
		private static class a
		{
			// Token: 0x04000027 RID: 39
			public const byte a = 16;

			// Token: 0x04000028 RID: 40
			public const int b = 10;

			// Token: 0x04000029 RID: 41
			public const int c = 2;

			// Token: 0x0400002A RID: 42
			public const int d = 6;
		}

		// Token: 0x0200000F RID: 15
		private enum b : byte
		{
			// Token: 0x0400002C RID: 44
			a,
			// Token: 0x0400002D RID: 45
			b,
			// Token: 0x0400002E RID: 46
			c
		}

		// Token: 0x02000010 RID: 16
		private enum c : byte
		{
			// Token: 0x04000030 RID: 48
			a,
			// Token: 0x04000031 RID: 49
			b,
			// Token: 0x04000032 RID: 50
			c
		}
	}
}
