using System;
using System.Collections.ObjectModel;
using System.IO;
using AcpCryptoLib;
using AcpUtility;
using Motorola.CommonCPS.ResourceRepository;

namespace ASK.Core
{
	// Token: 0x02000021 RID: 33
	public class LegacySoftwareKey
	{
		// Token: 0x06000163 RID: 355 RVA: 0x00028A08 File Offset: 0x00026C08
		public int readASystemKey(string sFileName, global::System.Collections.ObjectModel.Collection<global::ASK.Core.StatusMsg> status)
		{
			short num = (short)1723203584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				global::ASK.Core.a a;
				byte[] array;
				bool a_2;
				bool flag;
				int num5;
				bool flag2;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)985987209;
							short num3 = num;
							num = (short)362412169;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)6291456;
								if (num != 0)
								{
								}
								global::System.IO.FileStream fileStream = new global::System.IO.FileStream(sFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
								try
								{
									switch (0)
									{
									case 0:
										goto IL_1F4;
									}
									global::AcpCryptoLib.AcpSmartNetAlgorithm a_;
									for (;;)
									{
										IL_185:
										switch (num2)
										{
										case 0:
											num = (short)1040318482;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
										{
											int num4 = (int)this.a(a_, fileStream, a, array, a_2);
											a_2 = false;
											if (num4 < 3)
											{
												num = (short)817168393;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											byte b = a.a;
											num = (short)729219085;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											if (flag)
											{
												num = (short)1092550667;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_223;
										case 3:
										{
											byte b;
											if (b != 3)
											{
												num = (short)1256194064;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num5 = this.a(array).a();
											num = (short)871759892;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
											status.Add(new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, global::Motorola.CommonCPS.ResourceRepository.Resources.Invalid_System_ID.AcpStringFormat(new object[]
											{
												sFileName
											}), 3758129165U));
											num = (short)454426646;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
											goto IL_223;
										case 6:
											if (num5 >= 1)
											{
												num = (short)276168704;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_223;
										case 7:
											num = (short)1684471823;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 8:
											if (status != null)
											{
												num = (short)903151620;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_55B;
										case 9:
											flag = false;
											num = (short)1486880791;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 10:
											goto IL_51E;
										case 11:
											num = (short)1108672518;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 12:
										{
											byte b;
											if (b != 255)
											{
												num = (short)1825832967;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											flag2 = true;
											num = (short)7471118;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 13:
										{
											byte b;
											if (b != 1)
											{
												num = (short)396427289;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_51E;
										}
										case 14:
											goto IL_51E;
										case 15:
											flag = false;
											flag2 = true;
											num = (short)1609629713;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 16:
											num = (short)1744175116;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 17:
											goto IL_51E;
										case 18:
											if (num5 > 65535)
											{
												num = (short)310312965;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_55B;
										case 19:
											goto IL_573;
										case 20:
											goto IL_51E;
										case 21:
											goto IL_4A4;
										case 22:
											goto IL_55B;
										case 23:
											goto IL_4A4;
										case 24:
											if (flag2)
											{
												num = (short)532676629;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1936064513;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 25:
											num = (short)241500163;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1F4;
										IL_223:
										num5 = 0;
										num = (short)1540620296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_4A4:
										fileStream.Close();
										num = (short)1261633538;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_51E:
										num = (short)325976088;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_55B:
										num = (short)968687635;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_573:
									break;
									IL_1F4:
									fileStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
									a_ = new global::AcpCryptoLib.AcpSmartNetAlgorithm();
									num = (short)971571210;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_185;
								}
								finally
								{
									num = (short)145162240;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_5A8;
											}
											continue;
										case 1:
											goto IL_5E1;
										case 2:
											((global::System.IDisposable)fileStream).Dispose();
											num = (short)1322057729;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_5A8:
										if (fileStream == null)
										{
											break;
										}
										num = (short)409403394;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_5E1:;
								}
								break;
							}
							}
							return num5;
						}
						catch (global::System.Exception ex)
						{
							num5 = 0;
							if (status != null)
							{
								status.Add(new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, global::Motorola.CommonCPS.ResourceRepository.Resources.Error_Reading_File.AcpStringFormat(new object[]
								{
									ex.Message
								}), 3758129165U));
							}
							return num5;
						}
						goto IL_61F;
					case 1:
						if (global::System.IO.File.Exists(sFileName))
						{
							num = (short)2005270528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)327548932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return num5;
					case 3:
					{
						num = (short)1604845568;
						short num6 = num;
						goto IL_61F;
					}
					case 4:
						if (status != null)
						{
							num = (short)411435011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num5;
					}
					goto IL_44;
					IL_61F:
					status.Add(new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, global::Motorola.CommonCPS.ResourceRepository.Resources.File_Not_Opened.AcpStringFormat(new object[]
					{
						sFileName
					}), 2684387337U));
					num = (short)1239547906;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num5;
				IL_44:
				num = (short)1805451265;
				if (num != 0)
				{
				}
				a = new global::ASK.Core.a();
				array = new byte[256];
				a_2 = true;
				flag2 = false;
				num5 = 0;
				flag = true;
				num = (short)62652417;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000290AC File Offset: 0x000272AC
		private ushort a(global::AcpCryptoLib.AcpSmartNetAlgorithm A_0, global::System.IO.FileStream A_1, global::ASK.Core.a A_2, byte[] A_3, bool A_4)
		{
			short num = (short)1233125376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E2;
				}
				ushort num3;
				ushort num4;
				byte b;
				ushort num5;
				int num6;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (num3 != 0)
						{
							num = (short)1022689318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_3[(int)num4] = 0;
						num = (short)2108227601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)493420551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						A_2.b = b;
						num5 += 1;
						num3 = 0;
						num = (short)706740254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (num4 >= 256)
						{
							num = (short)170590241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_3[(int)num4] = 0;
						num4 += 1;
						num = (short)1876819989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)137297921;
						if (num != 0)
						{
						}
						goto IL_2E0;
					case 5:
						goto IL_6F0;
					case 6:
					{
						if (num6 == -1)
						{
							num = (short)145883158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 = A_1.ReadByte();
						byte in_buf = (byte)num6;
						num3 = (ushort)A_0.DecryptChar(in_buf, out b, A_4);
						A_4 = false;
						num = (short)1335164952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						if (num6 == -1)
						{
							num = (short)684523549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 = A_1.ReadByte();
						byte in_buf = (byte)num6;
						num3 = (ushort)A_0.DecryptChar(in_buf, out b, A_4);
						num = (short)697368588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_2E0;
					case 9:
						if (num3 != 0)
						{
							num = (short)1596915748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_2.a = 0;
						num = (short)2008547359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (num3 != 0)
						{
							num = (short)344195107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_2.c = 0;
						num = (short)587530282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_266;
					case 12:
						goto IL_20B;
					case 13:
						if (num3 != 0)
						{
							num = (short)1770389506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_2.b = 0;
						num = (short)1160577058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_56D;
					case 15:
					{
						num = (short)1229717504;
						short num7 = num;
						if (num6 == -1)
						{
							num = (short)181010443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 = A_1.ReadByte();
						byte in_buf = (byte)num6;
						num3 = (ushort)A_0.DecryptChar(in_buf, out b, A_4);
						num = (short)992215072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (num3 == 0)
						{
							num = (short)1144258583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_266;
					case 17:
						goto IL_49C;
					case 18:
						goto IL_49C;
					case 19:
						goto IL_36D;
					case 20:
						if (num3 == 0)
						{
							num = (short)893190145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C0;
					case 21:
						goto IL_36D;
					case 22:
						goto IL_1D0;
					case 23:
						num = (short)2069037071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_6F0;
					case 25:
						num = (short)1164181543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_45F;
					case 27:
						goto IL_2A3;
					case 28:
					{
						num = (short)532173113;
						short num8 = num;
						num = (short)229921081;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6F0;
						default:
							num = (short)1445396480;
							if (num != 0)
							{
							}
							if (num4 >= (ushort)A_2.c)
							{
								num = (short)1079509033;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20B;
						}
						break;
					}
					case 29:
						goto IL_4C0;
					case 30:
						goto IL_532;
					case 31:
						goto IL_2A3;
					case 32:
						goto IL_532;
					case 33:
						return num5;
					case 34:
						goto IL_532;
					case 35:
						A_2.c = b;
						num5 += 1;
						num3 = 0;
						num = (short)768016398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						A_2.a = b;
						num5 += 1;
						num3 = 0;
						num = (short)787808300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (num3 == 0)
						{
							num = (short)792526873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45F;
					case 38:
						num3 = 0;
						A_3[(int)num4] = b;
						num5 += 1;
						num = (short)1949958162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						if (num6 == -1)
						{
							num = (short)1445920794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 = A_1.ReadByte();
						byte in_buf = (byte)num6;
						num3 = (ushort)A_0.DecryptChar(in_buf, out b, A_4);
						num = (short)1688993819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						num = (short)67829766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)1535180819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_56D;
					case 43:
						if (num3 == 0)
						{
							num = (short)1559035944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D0;
					case 44:
						goto IL_2A3;
					}
					goto IL_E2;
					IL_1D0:
					num = (short)1310982153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20B:
					num = (short)1982726164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_266:
					num = (short)674037770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A3:
					num = (short)1339359269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E0:
					num = (short)520618012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36D:
					num = (short)21954563;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45F:
					num = (short)35127309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49C:
					num4 += 1;
					num = (short)1052180488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C0:
					num = (short)1259536384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_532:
					num = (short)508755984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56D:
					num4 = 0;
					num = (short)815857668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F0:
					num = (short)3407915;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num5;
				IL_E2:
				num3 = 0;
				num5 = 0;
				num4 = 0;
				b = 0;
				num6 = 0;
				num = (short)1719730181;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0002986C File Offset: 0x00027A6C
		private global::ASK.Core.c a(byte[] A_0)
		{
			short num = (short)262153104;
			short num2 = num;
			num = (short)916136848;
			global::ASK.Core.c result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1382154240;
				if (num != 0)
				{
				}
				num = (short)1079050241;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				int num3;
				for (;;)
				{
					IL_7D:
					switch (num3)
					{
					case 0:
						num = (short)1586823171;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1128857600;
						short num4 = num;
						if (A_0 != null)
						{
							num = (short)2041708544;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 2:
						result = new global::ASK.Core.c((int)A_0[2] + ((int)A_0[1] << 8));
						num = (short)531824644;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (A_0.Length >= 3)
						{
							num = (short)1729560578;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						return result;
					}
					break;
				}
				IL_97:
				result = null;
				num = (short)943325185;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7D;
			}
			}
			return result;
		}

		// Token: 0x040000B6 RID: 182
		private const int a = 3;

		// Token: 0x040000B7 RID: 183
		private const int b = 256;

		// Token: 0x040000B8 RID: 184
		private const int c = 3;

		// Token: 0x040000B9 RID: 185
		private const int d = 2;

		// Token: 0x040000BA RID: 186
		private const int e = 8;

		// Token: 0x040000BB RID: 187
		private const byte f = 1;

		// Token: 0x040000BC RID: 188
		private const byte g = 3;

		// Token: 0x040000BD RID: 189
		private const byte h = 255;

		// Token: 0x040000BE RID: 190
		private const int i = 65535;

		// Token: 0x040000BF RID: 191
		private const int j = 1;
	}
}
