using System;
using System.Collections.ObjectModel;
using System.IO;
using AcpCommonResources;
using AcpCryptoLib;
using AcpUtility;

namespace AcpASKLib
{
	// Token: 0x0200002E RID: 46
	public class LegacySoftwareKey
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00026F88 File Offset: 0x00025188
		internal int a(string A_0, global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> A_1)
		{
			short num = (short)1878720512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				bool flag;
				bool flag2;
				byte[] array;
				int num4;
				global::AcpASKLib.a a;
				bool a_2;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)889686816;
							short num3 = num;
							num = (short)188910368;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)1408303104;
								if (num != 0)
								{
								}
								global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
								try
								{
									switch (0)
									{
									case 0:
										goto IL_1F7;
									}
									global::AcpCryptoLib.AcpSmartNetAlgorithm a_;
									for (;;)
									{
										IL_188:
										switch (num2)
										{
										case 0:
											if (A_1 != null)
											{
												num = (short)505872408;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_556;
										case 1:
											flag = false;
											flag2 = true;
											num = (short)2089222167;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											if (flag2)
											{
												num = (short)1470627861;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1672413199;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											num = (short)64487441;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											num = (short)1899233281;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
											if (flag)
											{
												num = (short)1305018375;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_226;
										case 6:
											goto IL_556;
										case 7:
											num = (short)1706754073;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 8:
											goto IL_51A;
										case 9:
											num = (short)1045364750;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 10:
											goto IL_49E;
										case 11:
											goto IL_56E;
										case 12:
										{
											byte b;
											if (b != 3)
											{
												num = (short)901382147;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num4 = this.a(array).a();
											num = (short)1811939336;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 13:
											goto IL_51A;
										case 14:
											if (num4 > 65535)
											{
												num = (short)2014969878;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_556;
										case 15:
										{
											int num5 = (int)this.a(a_, fileStream, a, array, a_2);
											a_2 = false;
											if (num5 < 3)
											{
												num = (short)863436816;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											byte b = a.a;
											num = (short)1596325906;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 16:
											flag = false;
											num = (short)1479344138;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 17:
										{
											byte b;
											if (b != 255)
											{
												num = (short)1574305796;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											flag2 = true;
											num = (short)893583379;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 18:
										{
											byte b;
											if (b != 1)
											{
												num = (short)623443988;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_51A;
										}
										case 19:
											goto IL_51A;
										case 20:
											num = (short)1908998156;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 21:
											goto IL_49E;
										case 22:
											goto IL_226;
										case 23:
											goto IL_51A;
										case 24:
											A_1.Add(new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, global::AcpCommonResources.AcpResources.Invalid_System_ID.AcpStringFormat(new object[]
											{
												A_0
											}), 3758129165U));
											num = (short)57147398;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 25:
											if (num4 >= 1)
											{
												num = (short)369885193;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_226;
										}
										goto IL_1F7;
										IL_226:
										num4 = 0;
										num = (short)631832576;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_49E:
										fileStream.Close();
										num = (short)2072969221;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_51A:
										num = (short)1564082178;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_556:
										num = (short)352911371;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_56E:
									break;
									IL_1F7:
									fileStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
									a_ = new global::AcpCryptoLib.AcpSmartNetAlgorithm();
									num = (short)657457165;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_188;
								}
								finally
								{
									num = (short)686882817;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_5D9;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_5A2;
											}
											continue;
										case 2:
											((global::System.IDisposable)fileStream).Dispose();
											num = (short)482410496;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_5A2:
										if (fileStream == null)
										{
											break;
										}
										num = (short)1926823938;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_5D9:;
								}
								break;
							}
							}
							return num4;
						}
						catch (global::System.Exception ex)
						{
							num4 = 0;
							if (A_1 != null)
							{
								A_1.Add(new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, global::AcpCommonResources.AcpResources.Error_Reading_File.AcpStringFormat(new object[]
								{
									ex.Message
								}), 3758129165U));
							}
							return num4;
						}
						goto IL_617;
					case 1:
					{
						num = (short)771555328;
						short num6 = num;
						num = (short)2021457921;
						if (num != 0)
						{
						}
						if (A_1 != null)
						{
							num = (short)639565828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num4;
					}
					case 2:
						return num4;
					case 3:
						if (global::System.IO.File.Exists(A_0))
						{
							num = (short)1001652224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)486146049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_617;
					}
					goto IL_43;
					IL_617:
					A_1.Add(new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, global::AcpCommonResources.AcpResources.File_Not_Opened.AcpStringFormat(new object[]
					{
						A_0
					}), 2684387337U));
					num = (short)731250690;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num4;
				IL_43:
				a = new global::AcpASKLib.a();
				array = new byte[256];
				a_2 = true;
				flag2 = false;
				num4 = 0;
				flag = true;
				num = (short)1992687619;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00027624 File Offset: 0x00025824
		private ushort a(global::AcpCryptoLib.AcpSmartNetAlgorithm A_0, global::System.IO.FileStream A_1, global::AcpASKLib.a A_2, byte[] A_3, bool A_4)
		{
			short num = (short)1659895808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E3;
				}
				int num3;
				byte b;
				ushort num4;
				ushort num5;
				ushort num6;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_268;
					case 1:
					{
						if (num3 == -1)
						{
							num = (short)1175978009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = A_1.ReadByte();
						byte in_buf = (byte)num3;
						num4 = (ushort)A_0.DecryptChar(in_buf, out b, A_4);
						A_4 = false;
						num = (short)1198653458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						A_2.a = b;
						num5 += 1;
						num4 = 0;
						num = (short)1157234722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (num3 == -1)
						{
							num = (short)1341915136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = A_1.ReadByte();
						byte in_buf = (byte)num3;
						num4 = (ushort)A_0.DecryptChar(in_buf, out b, A_4);
						num = (short)907345942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (num6 >= 256)
						{
							num = (short)2147090445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_3[(int)num6] = 0;
						num6 += 1;
						num = (short)736952356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_4BC;
					case 6:
						num = (short)1697775619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num4 = 0;
						A_3[(int)num6] = b;
						num5 += 1;
						num = (short)950534171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (num4 == 0)
						{
							num = (short)840892431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BC;
					case 9:
					{
						if (num4 != 0)
						{
							goto IL_45D;
						}
						num = (short)1016380448;
						short num7 = num;
						num = (short)1942273056;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5B1;
						default:
							num = (short)245104640;
							if (num != 0)
							{
							}
							num = (short)928251945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						if (num4 != 0)
						{
							num = (short)1938161699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_2.b = 0;
						num = (short)999620637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_328;
					case 12:
						goto IL_555;
					case 13:
						return num5;
					case 14:
						goto IL_20D;
					case 15:
						num = (short)236716048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						if (num3 == -1)
						{
							num = (short)403505157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = A_1.ReadByte();
						byte in_buf = (byte)num3;
						num4 = (ushort)A_0.DecryptChar(in_buf, out b, A_4);
						num = (short)517144590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (num6 >= (ushort)A_2.c)
						{
							num = (short)1278476318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20D;
					case 18:
						goto IL_6C1;
					case 19:
						goto IL_2A3;
					case 20:
					{
						if (num3 == -1)
						{
							num = (short)1488060437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = A_1.ReadByte();
						byte in_buf = (byte)num3;
						num4 = (ushort)A_0.DecryptChar(in_buf, out b, A_4);
						num = (short)1327956011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_45D;
					case 22:
						goto IL_555;
					case 23:
					{
						num = (short)1902247936;
						short num8 = num;
						if (num4 == 0)
						{
							num = (short)688062497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D0;
					}
					case 24:
						if (num4 != 0)
						{
							num = (short)390725660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_2.c = 0;
						num = (short)239009832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_1D0;
					case 26:
						goto IL_591;
					case 27:
						goto IL_499;
					case 28:
						A_2.c = b;
						num5 += 1;
						num4 = 0;
						num = (short)267517978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_555;
					case 30:
						num = (short)181731359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_36A;
					case 32:
						goto IL_6C1;
					case 33:
						num = (short)1732182017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_2A3;
					case 35:
						A_2.b = b;
						num5 += 1;
						num4 = 0;
						num = (short)1733296140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_36A;
					case 37:
						goto IL_328;
					case 38:
						goto IL_499;
					case 39:
						if (num4 != 0)
						{
							num = (short)111607815;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_3[(int)num6] = 0;
						num = (short)369229862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						goto IL_591;
					case 41:
						goto IL_5B1;
					case 42:
						if (num4 != 0)
						{
							num = (short)1810956290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_2.a = 0;
						num = (short)1012203539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_2A3;
					case 44:
						if (num4 == 0)
						{
							num = (short)787742726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_268;
					}
					goto IL_E3;
					IL_1D0:
					num = (short)1063977002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20D:
					num = (short)790102024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_268:
					num = (short)1356070936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A3:
					num = (short)467271689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_328:
					num = (short)609288209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36A:
					num = (short)281411588;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45D:
					num = (short)294125578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_499:
					num6 += 1;
					num = (short)1274740773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BC:
					num = (short)650903553;
					if (num != 0)
					{
					}
					num = (short)385417255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_555:
					num = (short)1076297772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_591:
					num6 = 0;
					num = (short)86507531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B1:
					num = (short)1282670612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C1:
					num = (short)1142489111;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num5;
				IL_E3:
				num4 = 0;
				num5 = 0;
				num6 = 0;
				b = 0;
				num3 = 0;
				num = (short)650838048;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00027DE0 File Offset: 0x00025FE0
		private global::AcpASKLib.c a(byte[] A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpASKLib.c result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					num2 = (short)759627779;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1510473728;
					short num3 = num2;
					result = new global::AcpASKLib.c((int)A_0[2] + ((int)A_0[1] << 8));
					num2 = (short)604307456;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					if (A_0.Length < 3)
					{
						return result;
					}
					num2 = (short)716150597;
					short num4 = num2;
					num2 = (short)958175045;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1662320640;
						if (num2 != 0)
						{
						}
						num2 = (short)1580662785;
						if (num2 != 0)
						{
						}
						num2 = (short)838205442;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (A_0 != null)
					{
						num2 = (short)1538523137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1636237316;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400019D RID: 413
		private const int a = 3;

		// Token: 0x0400019E RID: 414
		private const int b = 256;

		// Token: 0x0400019F RID: 415
		private const int c = 3;

		// Token: 0x040001A0 RID: 416
		private const int d = 2;

		// Token: 0x040001A1 RID: 417
		private const int e = 8;

		// Token: 0x040001A2 RID: 418
		private const byte f = 1;

		// Token: 0x040001A3 RID: 419
		private const byte g = 3;

		// Token: 0x040001A4 RID: 420
		private const byte h = 255;

		// Token: 0x040001A5 RID: 421
		private const int i = 65535;

		// Token: 0x040001A6 RID: 422
		private const int j = 1;
	}
}
