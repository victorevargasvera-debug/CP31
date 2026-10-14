using System;
using System.IO;
using System.Reflection;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x02000020 RID: 32
	public class WaveFile
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000994C File Offset: 0x00007B4C
		internal void a(string A_0)
		{
			int a_ = 2;
			short num = (short)1167458305;
			if (num != 0)
			{
			}
			num = (short)2112815104;
			short num2 = num;
			global::ACPVoiceAnnouncementLib.WaveFileReader waveFileReader = null;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_DF;
				}
				int num3;
				for (;;)
				{
					IL_69:
					switch (num3)
					{
					case 0:
						goto IL_565;
					case 1:
					{
						string text;
						if (text == global::ACPVoiceAnnouncementLib.WaveFileReader.f("唲場䌶ᤸ", a_))
						{
							num = (short)1927282698;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)142213144;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (this.format.dwSamplesPerSec != 8000U)
						{
							num = (short)922157078;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1064370189;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1973249566;
						short num4 = num;
						num = (short)446719518;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_369;
						default:
							num = (short)1377435648;
							if (num != 0)
							{
							}
							this.c(waveFileReader);
							num = (short)1241055246;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_242;
					case 5:
						goto IL_565;
					case 6:
						goto IL_565;
					case 7:
						num = (short)1898184704;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_57E;
					case 9:
						goto IL_220;
					case 10:
						this.b(waveFileReader);
						num = (short)2051538969;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.format.wFormatTag != 1)
						{
							num = (short)694943759;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)396034071;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1035993093;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (this.format.wChannels != 1)
						{
							num = (short)971571209;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1094385675;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (waveFileReader.a() + (long)((ulong)this.fact.dwChunkSize) == (long)((ulong)this.maindata.dwFileLength))
						{
							num = (short)476315666;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_242;
					case 15:
						goto IL_2CE;
					case 16:
						this.a(waveFileReader, false);
						num = (short)568786970;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						string text;
						if (text == global::ACPVoiceAnnouncementLib.WaveFileReader.f("圲吴䌶堸", a_))
						{
							num = (short)1398669328;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						waveFileReader.c();
						num = (short)1124401156;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)1724055573;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_4C8;
					case 20:
						goto IL_242;
					case 21:
						goto IL_565;
					case 22:
						goto IL_369;
					case 23:
						if (waveFileReader.a() + (long)((ulong)this.format.dwChunkSize) == (long)((ulong)this.maindata.dwFileLength))
						{
							num = (short)770179084;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_242;
					case 24:
					{
						string text;
						if (text == global::ACPVoiceAnnouncementLib.WaveFileReader.f("唲吴吶䴸", a_))
						{
							num = (short)1159069699;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1175912465;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (this.format.dwBitsPerSample != 16U)
						{
							num = (short)1954349075;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1443495938;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (waveFileReader.a() + (long)((ulong)this.data.dwChunkSize) == (long)((ulong)this.maindata.dwFileLength))
						{
							num = (short)2139422727;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_242;
					case 27:
					{
						if (waveFileReader.a() >= (long)((ulong)this.maindata.dwFileLength))
						{
							num = (short)552534022;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = waveFileReader.b();
						num = (short)1074462721;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_DF;
					IL_242:
					num = (short)1826881563;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_565:
					num = (short)1053753352;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_220:
				throw new global::ACPVoiceAnnouncementLib.WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes.WRONG_NUMBER_OF_CHANNELS);
				IL_2CE:
				throw new global::ACPVoiceAnnouncementLib.WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes.WRONG_DATA_FORMAT);
				IL_369:
				throw new global::ACPVoiceAnnouncementLib.WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes.WRONG_SAMPLE_RATE);
				IL_4C8:
				throw new global::ACPVoiceAnnouncementLib.WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes.WRONG_BITS_PER_SAMPLE);
				IL_57E:
				return;
				IL_DF:
				waveFileReader = new global::ACPVoiceAnnouncementLib.WaveFileReader(A_0);
				this.a(waveFileReader);
				this.maindata.FileName = A_0;
				num = (short)1938227220;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_69;
			}
			catch (global::ACPVoiceAnnouncementLib.WaveFileException a_2)
			{
				global::ACPVoiceAnnouncementLib.WaveFile.a(a_2);
				throw;
			}
			catch (global::System.Exception a_3)
			{
				global::ACPVoiceAnnouncementLib.WaveFile.a(a_3);
				throw;
			}
			finally
			{
				num = (short)413335554;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						waveFileReader.Dispose();
						num = (short)579534849;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_5F5;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5C0;
						}
						continue;
					}
					IL_5C0:
					if (waveFileReader == null)
					{
						break;
					}
					num = (short)669319168;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_5F5:
				waveFileReader = null;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00009FA0 File Offset: 0x000081A0
		internal bool a(byte[] A_0, int A_1, string A_2)
		{
			int a_ = 6;
			short num = (short)778895360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				bool result;
				global::ACPVoiceAnnouncementLib.b b;
				long num5;
				for (;;)
				{
					IL_30:
					num = (short)1668612097;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_2ED;
					case 1:
						return result;
					case 2:
						if (b != null)
						{
							num = (short)151715840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_F7;
							}
							for (;;)
							{
								IL_D8:
								switch (num2)
								{
								case 0:
								{
									num = (short)3945254;
									short num3 = num;
									num = (short)2025665318;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2E0;
									default:
										num = (short)1760428032;
										if (num != 0)
										{
										}
										goto IL_1D9;
									}
									break;
								}
								case 1:
								{
									long num4 = num5 / 2L;
									num = (short)564199424;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									if (num5 > 0L)
									{
										num = (short)778829829;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1D9;
								case 3:
									goto IL_2E0;
								case 4:
									if ((num5 & 1L) == 0L)
									{
										num = (short)2127953921;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1D9;
								case 5:
									num = (short)1454112772;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F7;
								IL_1D9:
								b.a(global::ACPVoiceAnnouncementLib.WaveFileReader.f("收瀸紺笼", a_));
								long num6 = b.a();
								b.a(0U);
								b.a(global::ACPVoiceAnnouncementLib.WaveFileReader.f("怶砸洺砼", a_));
								b.a(global::ACPVoiceAnnouncementLib.WaveFileReader.f("儶吸伺ᴼ", a_));
								b.a();
								b.a(16U);
								b.a(1);
								b.a(1);
								b.a(8000U);
								b.a(16000U);
								b.a(2);
								b.a(16);
								b.b();
								b.a(global::ACPVoiceAnnouncementLib.WaveFileReader.f("匶堸伺尼", a_));
								b.a((uint)num5);
								b.a(A_0, 0, (int)num5);
								b.b();
								long num7 = b.a() - (num6 + 4L);
								b.a(num6);
								b.a((uint)num7);
								num = (short)1176698883;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E0:
							goto IL_94;
							IL_F7:
							b = new global::ACPVoiceAnnouncementLib.b(A_2);
							num5 = (long)A_1;
							num = (short)1740242946;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_D8;
						}
						catch
						{
							result = false;
							goto IL_94;
						}
						goto IL_2ED;
						IL_94:
						num = (short)1396113410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6E;
					IL_2ED:
					num = (short)1249640448;
					short num8 = num;
					b.Dispose();
					num = (short)907739137;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_6E:
				result = true;
				num5 = 0L;
				b = null;
				num = (short)986185731;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000A304 File Offset: 0x00008504
		internal bool a(string A_0, string A_1)
		{
			int a_ = 6;
			short num = (short)818020352;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				int num4;
				int num5;
				int num6;
				long num7;
				byte[] array;
				global::ACPVoiceAnnouncementLib.b b;
				long num9;
				global::System.IO.FileStream fileStream;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_391;
					case 1:
					{
						num = (short)402335766;
						short num3 = num;
						num = (short)60827670;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3CA;
						default:
							num = (short)1572208641;
							if (num != 0)
							{
							}
							num = (short)1996357632;
							if (num != 0)
							{
							}
							if (num4 == num5)
							{
								num = (short)827981838;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14D;
						}
						break;
					}
					case 2:
						goto IL_525;
					case 3:
						goto IL_189;
					case 4:
						goto IL_3CA;
					case 5:
						if ((long)num6 >= num7)
						{
							num = (short)1548288006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = (int)num7 - num6;
						num = (short)369754119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_14D;
					case 7:
						if (num5 > array.Length)
						{
							num = (short)1340932105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_467;
					case 8:
					{
						if ((long)num6 != num7)
						{
							num = (short)2139881495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b.b();
						long num8 = b.a() - (num9 + 4L);
						b.a(num9);
						b.a((uint)num8);
						num = (short)1398800404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						num = (short)100466688;
						short num10 = num;
						num5 = array.Length;
						num = (short)1630994444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						long num11 = num7 / 2L;
						num = (short)764346371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)1606680589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_467;
					case 13:
						if ((num7 & 1L) == 0L)
						{
							num = (short)1149435914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_189;
					case 14:
						b.a(array, 0, num4);
						num6 += num4;
						num = (short)1578041366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (num7 > 0L)
						{
							num = (short)1993277451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_189;
					case 16:
						return true;
					case 17:
						fileStream.Close();
						fileStream = null;
						num = (short)656932864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (fileStream != null)
						{
							num = (short)1020723217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_391;
					case 19:
						if (b != null)
						{
							num = (short)2006843396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 20:
						goto IL_3CF;
					case 21:
						goto IL_3CF;
					case 22:
						goto IL_525;
					case 23:
						num6 = 0;
						num = (short)1010368533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97;
					IL_14D:
					num = (short)1585905672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_189:
					b.a(global::ACPVoiceAnnouncementLib.WaveFileReader.f("收瀸紺笼", a_));
					num9 = b.a();
					b.a(0U);
					b.a(global::ACPVoiceAnnouncementLib.WaveFileReader.f("怶砸洺砼", a_));
					b.a(global::ACPVoiceAnnouncementLib.WaveFileReader.f("儶吸伺ᴼ", a_));
					b.a();
					b.a(16U);
					b.a(1);
					b.a(1);
					b.a(8000U);
					b.a(16000U);
					b.a(2);
					b.a(16);
					b.b();
					b.a(global::ACPVoiceAnnouncementLib.WaveFileReader.f("匶堸伺尼", a_));
					b.a((uint)num7);
					num6 = 0;
					num = (short)1447952386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_391:
					num = (short)216793107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CA:
					b.Dispose();
					num = (short)777650192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CF:
					num = (short)280494098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_467:
					num4 = fileStream.Read(array, 0, num5);
					num = (short)1238302721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_525:
					num = (short)442105861;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_97:
				num7 = 0L;
				num9 = 0L;
				num5 = 0;
				num4 = 0;
				num6 = 0;
				array = new byte[1024];
				fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open);
				b = new global::ACPVoiceAnnouncementLib.b(A_1);
				num7 = fileStream.Length;
				num = (short)1644757007;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000A878 File Offset: 0x00008A78
		internal int a(global::System.IO.Stream A_0)
		{
			short num = (short)1678901248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				int num3;
				int num4;
				int num5;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (this.data.pcmData != null)
						{
							num = (short)915865603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C6;
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_103;
							}
							global::ACPVoiceAnnouncementLib.WaveFileReader waveFileReader;
							for (;;)
							{
								IL_C4:
								byte[] array;
								switch (num2)
								{
								case 0:
									if (num3 > 1024)
									{
										num = (short)1595670530;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_22C;
								case 1:
									A_0.Write(array, 0, num4);
									num5 += num4;
									num = (short)1189347331;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num3 = array.Length;
									num = (short)1461714955;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_162;
								case 4:
									goto IL_2FE;
								case 5:
									goto IL_162;
								case 6:
									goto IL_1E5;
								case 7:
									if (num4 == num3)
									{
										num = (short)61931521;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1E5;
								case 8:
									num5 = 0;
									num = (short)1990524940;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if ((long)num5 != (long)((ulong)this.data.dwChunkSize))
									{
										num = (short)1442447368;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									A_0.Flush();
									num = (short)133365770;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_2E4;
								case 11:
									goto IL_22C;
								case 12:
									goto IL_2E4;
								case 13:
									if ((long)num5 >= (long)((ulong)this.data.dwChunkSize))
									{
										num = (short)495714310;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num3 = (int)(this.data.dwChunkSize - (uint)num5);
									num = (short)2132541440;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_103;
								IL_162:
								num = (short)555417613;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E5:
								num = (short)2027290633;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_22C:
								num4 = waveFileReader.a(array, 0, num3);
								num = (short)1356333063;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2E4:
								num = (short)1971126276;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2FE:
							return num5;
							IL_103:
							waveFileReader = new global::ACPVoiceAnnouncementLib.WaveFileReader(this.maindata.FileName);
							waveFileReader.a(this.data.lFilePosition);
							num5 = 0;
							num = (short)1536229381;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_C4;
						}
						catch
						{
							return 0;
						}
						finally
						{
							num = (short)1923481601;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)200200787;
								short num6 = num;
								num = (short)531026515;
								global::ACPVoiceAnnouncementLib.WaveFileReader waveFileReader;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1635254272;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_3C3;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_38A;
										}
										continue;
									case 2:
										goto IL_3A5;
									}
									IL_38A:
									if (waveFileReader != null)
									{
										num = (short)465240066;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3C5;
								}
								IL_3A5:
								waveFileReader.Dispose();
								num = (short)1781399552;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3C3:
							IL_3C5:;
						}
						goto IL_3C6;
					case 2:
						return num5;
					case 3:
						A_0.Write(this.data.pcmData, 0, this.data.pcmData.Length);
						num5 = this.data.pcmData.Length;
						num = (short)1549008898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)201850880;
						short num7 = num;
						if (this.data != null)
						{
							num = (short)1052639239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num5;
					}
					case 5:
						if (this.data.lFilePosition != 0L)
						{
							num = (short)1572143110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num5;
					case 6:
					{
						global::ACPVoiceAnnouncementLib.WaveFileReader waveFileReader = null;
						byte[] array = new byte[1024];
						num = (short)157614081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1884749825;
						if (num != 0)
						{
						}
						num = (short)815464448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4E;
					IL_3C6:
					num = (short)1526398981;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num5;
				IL_4E:
				num3 = 0;
				num4 = 0;
				num5 = 0;
				num = (short)618070020;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000ADAC File Offset: 0x00008FAC
		internal byte[] a()
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			byte[] array;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1029174708;
					short num3 = num2;
					num2 = (short)1552807348;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)460914689;
						if (num2 != 0)
						{
						}
						num2 = (short)1982332928;
						if (num2 != 0)
						{
						}
						num2 = (short)1954152448;
						short num4 = num2;
						num2 = (short)823197703;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					return array;
				case 2:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						global::ACPVoiceAnnouncementLib.WaveFileReader waveFileReader;
						for (;;)
						{
							IL_75:
							switch (num)
							{
							case 0:
								goto IL_148;
							case 1:
								array = new byte[this.data.dwChunkSize];
								waveFileReader.a(this.data.lFilePosition);
								waveFileReader.a(array, 0, (int)this.data.dwChunkSize);
								num2 = (short)536150019;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (this.data.dwChunkSize <= 192000U)
								{
									num2 = (short)1595801601;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_D9;
							case 3:
								num2 = (short)495058944;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_8B;
						}
						IL_D9:
						throw new global::ACPVoiceAnnouncementLib.WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes.CHUNK_DATA_TOO_LARGE);
						IL_148:
						return array;
						IL_8B:
						waveFileReader = new global::ACPVoiceAnnouncementLib.WaveFileReader(this.maindata.FileName);
						num2 = (short)1821442050;
						num = (int)((global::System.IntPtr)num2);
						goto IL_75;
					}
					catch (global::ACPVoiceAnnouncementLib.WaveFileException a_)
					{
						global::ACPVoiceAnnouncementLib.WaveFile.a(a_);
						throw;
					}
					catch (global::System.Exception a_2)
					{
						global::ACPVoiceAnnouncementLib.WaveFile.a(a_2);
						throw;
					}
					finally
					{
						num2 = (short)1263861760;
						num = (int)((global::System.IntPtr)num2);
						global::ACPVoiceAnnouncementLib.WaveFileReader waveFileReader;
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_18C;
								}
								continue;
							case 1:
								waveFileReader.Dispose();
								num2 = (short)2072248322;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_1BF;
							}
							IL_18C:
							if (waveFileReader == null)
							{
								break;
							}
							num2 = (short)1850212353;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1BF:
						waveFileReader = null;
					}
					goto IL_1C4;
				case 3:
					array = this.data.pcmData;
					num2 = (short)2096955393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (this.data.lFilePosition != 0L)
					{
						num2 = (short)236257285;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return array;
				case 5:
				{
					global::ACPVoiceAnnouncementLib.WaveFileReader waveFileReader = null;
					num2 = (short)1338048514;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (this.data != null)
					{
						num2 = (short)632029184;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return array;
				case 7:
					if (this.data.pcmData != null)
					{
						num2 = (short)1866596355;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C4;
				}
				goto IL_30;
				IL_1C4:
				num2 = (short)1115160580;
				num = (int)((global::System.IntPtr)num2);
			}
			return array;
			IL_30:
			array = null;
			num2 = (short)1297940486;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000B114 File Offset: 0x00009314
		internal void a(global::ACPVoiceAnnouncementLib.WaveFileReader A_0)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (!(this.maindata.sRiffType != global::ACPVoiceAnnouncementLib.WaveFileReader.f("ᕁՃ၅േ", a_)))
					{
						return;
					}
					num2 = (short)960470396;
					short num3 = num2;
					num2 = (short)1839832444;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_51;
					default:
					{
						num2 = (short)1823997953;
						if (num2 != 0)
						{
						}
						num2 = (short)1881538560;
						short num4 = num2;
						num2 = (short)1144061952;
						if (num2 != 0)
						{
						}
						num2 = (short)1197604866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					try
					{
						this.maindata.sGroupID = new string(A_0.a(4));
						this.maindata.dwFileLength = A_0.d() + 8U;
						this.maindata.sRiffType = new string(A_0.a(4));
						goto IL_141;
					}
					catch
					{
						throw new global::ACPVoiceAnnouncementLib.WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes.UNKNOWN_FILE_FORMAT);
					}
					goto IL_1E2;
					IL_141:
					num2 = (short)757202947;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_13C;
				case 3:
					if (!(this.maindata.sGroupID != global::ACPVoiceAnnouncementLib.WaveFileReader.f("၁ൃE็", a_)))
					{
						num2 = (short)879099908;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E2;
				case 4:
					goto IL_51;
				}
				goto IL_2D;
				IL_51:
				num2 = (short)1327824896;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_13C:
			IL_1E2:
			throw new global::ACPVoiceAnnouncementLib.WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes.UNKNOWN_FILE_FORMAT);
			IL_2D:
			this.maindata = new global::ACPVoiceAnnouncementLib.riffChunk();
			num2 = (short)1599602689;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000B31C File Offset: 0x0000951C
		internal void b(global::ACPVoiceAnnouncementLib.WaveFileReader A_0)
		{
			int a_ = 7;
			short num = (short)1030786022;
			short num2 = num;
			num = (short)1274842086;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2088566785;
				if (num != 0)
				{
				}
				num = (short)1868759040;
				if (num != 0)
				{
				}
				this.format = new global::ACPVoiceAnnouncementLib.fmtChunk();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_A8;
					}
					int num3;
					long num4;
					for (;;)
					{
						IL_92:
						switch (num3)
						{
						case 0:
							A_0.a(num4 + (long)((ulong)this.format.dwChunkSize));
							num = (short)320929795;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1CB;
						case 2:
							if (A_0.a() - num4 != (long)((ulong)this.format.dwChunkSize))
							{
								num = (short)173998080;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B3;
						case 3:
							goto IL_1B3;
						}
						goto IL_A8;
						IL_1B3:
						num = (short)1701052417;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1CB:
					break;
					IL_A8:
					this.format.sChunkID = global::ACPVoiceAnnouncementLib.WaveFileReader.f("帷圹䠻ḽ", a_);
					this.format.dwChunkSize = A_0.d();
					num4 = A_0.a();
					this.format.wFormatTag = A_0.e();
					this.format.wChannels = A_0.e();
					this.format.dwSamplesPerSec = A_0.d();
					this.format.dwAvgBytesPerSec = A_0.d();
					this.format.wBlockAlign = A_0.e();
					this.format.dwBitsPerSample = (uint)A_0.e();
					num = (short)415432706;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_92;
				}
				catch
				{
					throw new global::ACPVoiceAnnouncementLib.WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes.MALFORMED_WAV_FILE);
				}
				break;
			}
			num = (short)2048131072;
			short num5 = num;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000B548 File Offset: 0x00009748
		internal void c(global::ACPVoiceAnnouncementLib.WaveFileReader A_0)
		{
			int a_ = 13;
			short num = (short)1092785940;
			short num2 = num;
			num = (short)1998690068;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1757020160;
				short num3 = num;
				num = (short)428343296;
				if (num != 0)
				{
				}
				this.fact = new global::ACPVoiceAnnouncementLib.factChunk();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					int num4;
					long num5;
					for (;;)
					{
						IL_93:
						switch (num4)
						{
						case 0:
							A_0.a(num5 + (long)((ulong)this.format.dwChunkSize));
							num = (short)181927939;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_19D;
						case 2:
							if (A_0.a() - num5 != (long)((ulong)this.fact.dwChunkSize))
							{
								num = (short)831127552;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_186;
						case 3:
							num = (short)503709697;
							if (num != 0)
							{
							}
							goto IL_186;
						}
						goto IL_A9;
						IL_186:
						num = (short)645988353;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_19D:
					break;
					IL_A9:
					this.fact.sChunkID = global::ACPVoiceAnnouncementLib.WaveFileReader.f("堽ℿ⅁ぃ", a_);
					this.fact.dwChunkSize = A_0.d();
					num5 = A_0.a();
					this.fact.dwNumSamples = A_0.d();
					num = (short)1331953666;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_93;
				}
				catch
				{
					throw new global::ACPVoiceAnnouncementLib.WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes.MALFORMED_WAV_FILE);
				}
				break;
			}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000B718 File Offset: 0x00009918
		internal void a(global::ACPVoiceAnnouncementLib.WaveFileReader A_0, bool A_1)
		{
			int a_ = 7;
			short num = (short)1682309122;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1407188992;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_A3;
				case 1:
					this.data = new global::ACPVoiceAnnouncementLib.dataChunk();
					num = (short)2059796480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				}
				IL_63:
				if (this.format == null)
				{
					goto IL_CB;
				}
				num = (short)2101411841;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A3:
			num = (short)351862785;
			if (num != 0)
			{
			}
			try
			{
				switch (0)
				{
				case 0:
					goto IL_122;
				}
				long num5;
				for (;;)
				{
					IL_DC:
					switch (num2)
					{
					case 0:
						if (this.data.pcmData != null)
						{
							num = (short)294649866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_453;
					case 1:
						if (this.fact != null)
						{
							num = (short)2021851150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.data.dwNumSamples = this.data.dwChunkSize / (this.format.dwBitsPerSample / 8U * (uint)this.format.wChannels);
						num = (short)593231879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						this.data.pcmData = new byte[this.data.dwChunkSize];
						num = (short)332464128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_453;
					case 4:
						goto IL_493;
					case 5:
						if (this.data.dwChunkSize <= 192000U)
						{
							num = (short)1404764162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44C;
					case 6:
						goto IL_4AC;
					case 7:
						goto IL_2D3;
					case 8:
						goto IL_2D3;
					case 9:
						num = (short)1518600197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)786028870;
						short num4 = num;
						num = (short)1620695366;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2D3;
						default:
							num = (short)150536192;
							if (num != 0)
							{
							}
							A_0.a(this.data.pcmData, 0, (int)this.data.dwChunkSize);
							num = (short)1424031747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						goto IL_453;
					case 12:
						A_0.a(num5 + (long)((ulong)this.format.dwChunkSize));
						num = (short)1095761924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (A_0.a() - num5 != (long)((ulong)this.format.dwChunkSize))
						{
							num = (short)387579916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_493;
					case 14:
						this.data.dwNumSamples = this.fact.dwNumSamples;
						num = (short)2045247496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (A_1)
						{
							num = (short)1728380937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.data.pcmData = null;
						num = (short)1678704651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_122;
					IL_2D3:
					this.data.dwMinLength = this.data.dwChunkSize / this.format.dwAvgBytesPerSec / 60U;
					this.data.dSecLength = this.data.dwChunkSize / this.format.dwAvgBytesPerSec - this.data.dwMinLength * 60.0;
					num = (short)656277517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_453:
					num = (short)153616385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_493:
					num = (short)1570242566;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_44C:
				throw new global::ACPVoiceAnnouncementLib.WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes.CHUNK_DATA_TOO_LARGE);
				IL_4AC:
				return;
				IL_122:
				this.data.sChunkID = global::ACPVoiceAnnouncementLib.WaveFileReader.f("尷嬹䠻弽", a_);
				this.data.dwChunkSize = A_0.d();
				this.data.lFilePosition = A_0.a();
				num5 = A_0.a();
				num = (short)1177419791;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_DC;
			}
			catch (global::ACPVoiceAnnouncementLib.WaveFileException a_2)
			{
				global::ACPVoiceAnnouncementLib.WaveFile.a(a_2);
				throw;
			}
			catch
			{
				throw new global::ACPVoiceAnnouncementLib.WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes.MALFORMED_WAV_FILE);
			}
			return;
			IL_CB:
			throw new global::ACPVoiceAnnouncementLib.WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes.MALFORMED_WAV_FILE);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000BC18 File Offset: 0x00009E18
		private static void a(global::System.Exception A_0)
		{
			int a_ = 17;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_29;
				}
				for (;;)
				{
					IL_13:
					int num;
					switch (num)
					{
					case 0:
						goto IL_12C;
					case 1:
						goto IL_F0;
					case 2:
						goto IL_114;
					case 3:
					{
						global::System.Reflection.MethodInfo method;
						if (method != null)
						{
							num2 = (short)900333569;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_114;
					}
					}
					goto IL_29;
					IL_114:
					num2 = (short)1335033856;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_12C:
				goto IL_131;
				IL_29:
				num2 = (short)1013953914;
				short num3 = num2;
				num2 = (short)964474234;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_F0:
					global::System.Reflection.MethodInfo method;
					method.Invoke(A_0, null);
					num2 = (short)360644610;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				default:
				{
					num2 = (short)1956642816;
					if (num2 != 0)
					{
					}
					num2 = (short)502267905;
					if (num2 != 0)
					{
					}
					global::System.Reflection.MethodInfo method = typeof(global::System.Exception).GetMethod(global::ACPVoiceAnnouncementLib.WaveFileReader.f("ୁ⩃㉅ⵇ㡉≋⽍㱏ɑ♓㍕⭗㽙⹛⡝՟ㅡၣݥ୧ũ㡫ᱭᅯᅱᅳ", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
					num2 = (short)480837635;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				}
			}
			catch
			{
			}
			IL_131:
			num2 = (short)560988160;
			short num4 = num2;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000BD9C File Offset: 0x00009F9C
		public void Dispose()
		{
			short num = (short)1976464372;
			short num2 = num;
			num = (short)1135309812;
			switch (num2 == num)
			{
			}
			num = (short)1985282048;
			if (num != 0)
			{
			}
			num = (short)1310982145;
			if (num != 0)
			{
			}
			num = (short)912195584;
			short num3 = num;
		}

		// Token: 0x04000088 RID: 136
		public global::ACPVoiceAnnouncementLib.riffChunk maindata;

		// Token: 0x04000089 RID: 137
		public global::ACPVoiceAnnouncementLib.fmtChunk format;

		// Token: 0x0400008A RID: 138
		public global::ACPVoiceAnnouncementLib.factChunk fact;

		// Token: 0x0400008B RID: 139
		public global::ACPVoiceAnnouncementLib.dataChunk data;

		// Token: 0x0400008C RID: 140
		private const int a = 192000;
	}
}
