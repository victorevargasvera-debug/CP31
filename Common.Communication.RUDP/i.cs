using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.RUDP.Helper;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000010 RID: 16
	internal class i : global::Motorola.Common.Communication.RUDP.Helper.c
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000ED0C File Offset: 0x0000CF0C
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000EDB8 File Offset: 0x0000CFB8
		private int a
		{
			get
			{
				short num = (short)455241499;
				short num2 = num;
				num = (short)1327984411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)534708224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1009188865;
				if (num != 0)
				{
				}
				num = (short)934608896;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)2143251826;
				short num2 = num;
				num = (short)2017815922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)236519424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1969881089;
				if (num != 0)
				{
				}
				num = (short)199950336;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000EE68 File Offset: 0x0000D068
		public i(bool A_0)
		{
			this.e.ao(global::Motorola.Common.Communication.RUDP.g.c);
			this.m = A_0;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		public override object[] d()
		{
			short num = (short)783155200;
			int num2 = (int)((global::System.IntPtr)num);
			object[] result;
			for (;;)
			{
				num = (short)1087323747;
				short num3 = num;
				num = (short)460996195;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
				{
					num = (short)341704704;
					short num4 = num;
					num = (short)887357440;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					case 1:
						num = (short)1912799233;
						if (num != 0)
						{
						}
						result = new object[]
						{
							this.b,
							this.c
						};
						num = (short)1770389506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						return result;
					}
					IL_A7:
					if (this.c != null)
					{
						num = (short)1118240769;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						result = new object[]
						{
							this.b
						};
						num = (short)1643839491;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			return result;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000F020 File Offset: 0x0000D220
		public override void e(object[] A_0)
		{
			short num;
			int num3;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1374586029;
					short num2 = num;
					num = (short)796886189;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9F;
					default:
						num = (short)537198592;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (A_0.Length == 2)
							{
								num = (short)1911619586;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							return;
						case 2:
							this.c = (global::Motorola.Common.Communication.RUDP.l)A_0[1];
							num = (short)1417216001;
							if (num != 0)
							{
							}
							num = (short)1563492353;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67;
					}
				}
				return;
			}
			IL_67:
			num = (short)958726144;
			short num4 = num;
			this.b = (global::Motorola.Common.Communication.RUDP.j)A_0[0];
			IL_9F:
			num = (short)1585119232;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000F154 File Offset: 0x0000D354
		public override int f(byte[] A_0, int A_1, int A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1BE;
				case 1:
					if (this.c != null)
					{
						num2 = (short)38273033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return num3;
				case 2:
					this.m = true;
					num2 = (short)1976565761;
					if (num2 != 0)
					{
					}
					num2 = (short)1355284480;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)2099707904;
					short num4 = num2;
					this.m = false;
					num2 = (short)1019346950;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_1BE;
				case 5:
					if (this.b.au())
					{
						num2 = (short)1963655170;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1990918152;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_1BE;
				case 7:
					return num3;
				case 8:
					if (this.b.av())
					{
						num2 = (short)1717567498;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8F;
				case 9:
					goto IL_1F8;
				case 10:
				{
					num2 = (short)1409249379;
					short num5 = num2;
					num2 = (short)1682272355;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F8;
					default:
						num2 = (short)1110835200;
						if (num2 != 0)
						{
						}
						num2 = (short)772014091;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					if (A_2 > (int)global::Motorola.Common.Communication.RUDP.c.b)
					{
						num2 = (short)189661187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8F;
				}
				goto IL_40;
				IL_8F:
				this.bb();
				num2 = (short)1382350852;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1BE:
				num2 = (short)2105278465;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F8:
				num3 += this.c.f(A_0, A_1 + num3, A_2 - num3);
				num2 = (short)2139947015;
				num = (int)((global::System.IntPtr)num2);
			}
			return num3;
			IL_40:
			num3 = this.b.f(A_0, A_1, A_2);
			num2 = (short)658178053;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000F3E8 File Offset: 0x0000D5E8
		public global::Motorola.Common.Communication.RUDP.f b
		{
			get
			{
				int num;
				short num2;
				global::Motorola.Common.Communication.RUDP.f result;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							if (!this.i.aw())
							{
								num2 = (short)1277493258;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						case 1:
							num2 = (short)79101952;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							if (this.i.av())
							{
								num2 = (short)1281556504;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							result = global::Motorola.Common.Communication.RUDP.f.b;
							num2 = (short)129695785;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							goto IL_585;
						case 4:
							return result;
						case 5:
							if (this.i.av())
							{
								num2 = (short)938410003;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							result = global::Motorola.Common.Communication.RUDP.f.f;
							num2 = (short)97124360;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 6:
							if (!this.i.au())
							{
								num2 = (short)1785790495;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						case 7:
							num2 = (short)358678550;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 8:
							goto IL_46F;
						case 9:
							if (this.i.ay())
							{
								num2 = (short)1531314180;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1609367557;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 10:
							num2 = (short)951189544;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 11:
							goto IL_723;
						case 12:
							num2 = (short)1784152087;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 13:
							result = global::Motorola.Common.Communication.RUDP.f.i;
							num2 = (short)1288634407;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 14:
							if (this.i.ay())
							{
								num2 = (short)1017970717;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_2A3;
						case 15:
							if (!this.i.av())
							{
								num2 = (short)805240879;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1799553061;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 16:
							goto IL_3AA;
						case 17:
							num2 = (short)1872232490;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 18:
							result = global::Motorola.Common.Communication.RUDP.f.e;
							num2 = (short)195952660;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 19:
							result = global::Motorola.Common.Communication.RUDP.f.g;
							num2 = (short)1591672857;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 20:
							goto IL_215;
						case 21:
							num2 = (short)1560608777;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 22:
							if (this.i.ay())
							{
								num2 = (short)1649672195;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1323040770;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 23:
							if (!this.i.au())
							{
								num2 = (short)1372520449;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						case 24:
							result = global::Motorola.Common.Communication.RUDP.f.c;
							num2 = (short)1524826128;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 25:
							goto IL_44F;
						case 26:
							num2 = (short)1274675214;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 27:
							goto IL_301;
						case 28:
							if (this.i.au())
							{
								num2 = (short)985923601;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1568931874;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 29:
							return result;
						case 30:
							goto IL_130;
						case 31:
							num2 = (short)816250926;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 32:
							if (this.i.ax())
							{
								num2 = (short)2121924620;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)364576783;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 33:
							if (!this.i.ax())
							{
								num2 = (short)948830215;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						case 34:
							if (this.i.aw())
							{
								num2 = (short)679542822;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)349831200;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 35:
							num2 = (short)1787035681;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 36:
							if (this.f == (ushort)global::Motorola.Common.Communication.RUDP.c.b)
							{
								num2 = (short)72941586;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)592379948;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 37:
							if (this.f == (ushort)global::Motorola.Common.Communication.RUDP.c.b)
							{
								num2 = (short)1633615898;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_2A3;
						case 38:
							num2 = (short)21430278;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 39:
							goto IL_1F6;
						case 40:
						{
							if (this.i.ay())
							{
								num2 = (short)729284619;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1660685496;
							short num3 = num2;
							num2 = (short)614796472;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_D2;
							default:
								num2 = (short)208797696;
								if (num2 != 0)
								{
								}
								num2 = (short)50987051;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 41:
							goto IL_191;
						case 42:
							if (!this.i.aw())
							{
								num2 = (short)2070151203;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						case 43:
							if (this.i.av())
							{
								num2 = (short)1961164813;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							result = global::Motorola.Common.Communication.RUDP.f.h;
							num2 = (short)308412446;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 44:
							num2 = (short)522649601;
							if (num2 != 0)
							{
							}
							if (this.f > (ushort)global::Motorola.Common.Communication.RUDP.c.b)
							{
								num2 = (short)1003028525;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						case 45:
							result = global::Motorola.Common.Communication.RUDP.f.d;
							num2 = (short)133759003;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 46:
							if (!this.i.ax())
							{
								num2 = (short)1696006165;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						case 47:
							return result;
						}
						goto IL_D0;
						IL_2A3:
						num2 = (short)1592721444;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_130:
					IL_191:
					return result;
					IL_1F6:
					IL_215:
					IL_301:
					IL_3AA:
					IL_44F:
					IL_46F:
					return result;
					IL_585:
					return result;
					IL_723:
					num2 = (short)916324352;
					short num4 = num2;
					return result;
				}
				}
				IL_D0:
				result = global::Motorola.Common.Communication.RUDP.f.a;
				IL_D2:
				num2 = (short)747175964;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000FBB4 File Offset: 0x0000DDB4
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000FC64 File Offset: 0x0000DE64
		public global::Motorola.Common.Communication.RUDP.q c
		{
			private get
			{
				short num = (short)1147863040;
				short num2 = num;
				num = (short)283105620;
				short num3 = num;
				num = (short)659806548;
				switch (num3 == num)
				{
				}
				num = (short)1099366400;
				if (num != 0)
				{
				}
				num = (short)1339949057;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)38076416;
				short num2 = num;
				num = (short)2115423093;
				short num3 = num;
				num = (short)176671605;
				switch (num3 == num)
				{
				}
				num = (short)888537089;
				if (num != 0)
				{
				}
				num = (short)2021261312;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000FD14 File Offset: 0x0000DF14
		public void av()
		{
			int a_ = 11;
			short num = (short)1033530077;
			short num2 = num;
			num = (short)504392413;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)943980545;
				if (num != 0)
				{
				}
				num = (short)1866924032;
				if (num != 0)
				{
				}
				num = (short)1886257152;
				short num3 = num;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("缮倰倲帴制䴸ᬺļ䐾煀祂㵄㩆睈歊㥌㵎ぐ㵒♔㩖じ⡚⹜㙞๠ൢ䕤ŦࡨɪŬ੮ᕰ嵲啴", a_), new object[]
				{
					this.i.az()
				});
				this.s = true;
				if (this.g == null)
				{
					this.o.Set();
					return;
				}
				break;
			}
			}
			this.g.e(true);
			this.g.j();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000FE2C File Offset: 0x0000E02C
		public void aw()
		{
			int a_ = 9;
			short num = (short)1998215562;
			short num2 = num;
			num = (short)428956042;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)293273600;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("紬丮到堲倴䌶ᤸܺ䘼༾筀㭂㡄祆楈㽊㽌⹎㽐⁒㡔㹖⩘⡚㑜ぞའ䍢٤ࡦѨ᭪Ŭ੮հᙲᅴ奶奸", a_), new object[]
				{
					this.i.az()
				});
				if (this.g == null)
				{
					num = (short)10485761;
					if (num != 0)
					{
					}
					this.o.Set();
					return;
				}
				num = (short)1279787008;
				short num3 = num;
				break;
			}
			}
			this.g.k();
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000FF34 File Offset: 0x0000E134
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
		public new byte[] e
		{
			get
			{
				short num = (short)1956735417;
				short num2 = num;
				num = (short)711551417;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1750007809;
					if (num != 0)
					{
					}
					num = (short)1697579008;
					if (num != 0)
					{
					}
					num = (short)41746432;
					short num3 = num;
					if (!this.h)
					{
						return (this.c as global::Motorola.Common.Communication.RUDP.p).ar();
					}
					break;
				}
				}
				return null;
			}
			private set
			{
				short num = (short)1556545536;
				short num2 = num;
				num = (short)735117312;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 1:
						num = (short)1049886721;
						if (num != 0)
						{
						}
						goto IL_A2;
					case 2:
					{
						num = (short)1583550111;
						short num4 = num;
						num = (short)1835142815;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A2;
						default:
							goto IL_101;
						}
						break;
					}
					}
					IL_5A:
					if (!this.h)
					{
						num = (short)443678721;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_A2:
					(this.c as global::Motorola.Common.Communication.RUDP.p).ao(value);
					num = (short)1592852482;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_101:
				num = (short)1315635200;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00010120 File Offset: 0x0000E320
		public new ushort f
		{
			get
			{
				short num;
				int num3;
				int num4;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						num = (short)1773789562;
						short num2 = num;
						num = (short)1222697338;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_95;
						default:
							num = (short)1866596352;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								if (this.c != null)
								{
									num = (short)780926977;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F5;
							case 1:
								num4 += (int)this.j.g();
								num = (short)513933314;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_F3;
							}
							goto IL_66;
						}
					}
					IL_F3:
					IL_F5:
					num = (short)1939537921;
					if (num != 0)
					{
					}
					return (ushort)num4;
				}
				IL_66:
				num = (short)530120704;
				short num5 = num;
				num4 = (int)global::Motorola.Common.Communication.RUDP.c.b;
				IL_95:
				num = (short)750977024;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0001024C File Offset: 0x0000E44C
		public bool g
		{
			get
			{
				short num = (short)1501954048;
				short num2 = num;
				num = (short)1433577495;
				short num3 = num;
				num = (short)650815511;
				switch (num3 == num)
				{
				}
				num = (short)1713569793;
				if (num != 0)
				{
				}
				num = (short)1886781440;
				if (num != 0)
				{
				}
				return !this.i.ay();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00010304 File Offset: 0x0000E504
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000103B4 File Offset: 0x0000E5B4
		public bool h
		{
			get
			{
				short num = (short)1345978368;
				short num2 = num;
				num = (short)1987313665;
				if (num != 0)
				{
				}
				num = (short)373301189;
				short num3 = num;
				num = (short)202645445;
				switch (num3 == num)
				{
				}
				num = (short)2114322432;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)1217724416;
				short num2 = num;
				num = (short)446493723;
				short num3 = num;
				num = (short)1041495067;
				switch (num3 == num)
				{
				}
				num = (short)452853761;
				if (num != 0)
				{
				}
				num = (short)541327360;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00010464 File Offset: 0x0000E664
		public global::Motorola.Common.Communication.RUDP.j i
		{
			get
			{
				short num = (short)356646912;
				short num2 = num;
				num = (short)1749180059;
				short num3 = num;
				num = (short)1134517915;
				switch (num3 == num)
				{
				}
				num = (short)1776877568;
				if (num != 0)
				{
				}
				num = (short)506462209;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00010514 File Offset: 0x0000E714
		private global::Motorola.Common.Communication.RUDP.l j
		{
			get
			{
				short num = (short)1512767488;
				short num2 = num;
				num = (short)210896061;
				short num3 = num;
				num = (short)1281426621;
				switch (num3 == num)
				{
				}
				num = (short)1854013440;
				if (num != 0)
				{
				}
				num = (short)1401815041;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000105C4 File Offset: 0x0000E7C4
		public global::Motorola.Common.Communication.RUDP.m k
		{
			get
			{
				short num = (short)718733312;
				short num2 = num;
				num = (short)28597831;
				short num3 = num;
				num = (short)1184587335;
				switch (num3 == num)
				{
				}
				num = (short)937951233;
				if (num != 0)
				{
				}
				num = (short)1858600960;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00010670 File Offset: 0x0000E870
		public global::Motorola.Common.Communication.RUDP.p l
		{
			get
			{
				short num = (short)99287040;
				short num2 = num;
				num = (short)642644419;
				short num3 = num;
				num = (short)1553332675;
				switch (num3 == num)
				{
				}
				num = (short)1619329024;
				if (num != 0)
				{
				}
				num = (short)1612316673;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00010720 File Offset: 0x0000E920
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000107D4 File Offset: 0x0000E9D4
		public bool m
		{
			private get
			{
				short num = (short)2015428608;
				short num2 = num;
				num = (short)1371144193;
				if (num != 0)
				{
				}
				num = (short)742527622;
				short num3 = num;
				num = (short)124785286;
				switch (num3 == num)
				{
				}
				num = (short)346161152;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)1544118912;
				short num2 = num;
				num = (short)1303798400;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)253886464;
					if (num != 0)
					{
					}
					num = (short)764739585;
					if (num != 0)
					{
					}
					num = (short)1404370944;
					short num3 = num;
					this.h = value;
					if (!this.h)
					{
						this.c = this.f;
						return;
					}
					break;
				}
				}
				this.c = this.e;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000108A4 File Offset: 0x0000EAA4
		public bool n
		{
			get
			{
				short num = (short)1988820992;
				short num2 = num;
				num = (short)1525940225;
				if (num != 0)
				{
				}
				num = (short)225970765;
				short num3 = num;
				num = (short)1184893517;
				switch (num3 == num)
				{
				}
				num = (short)2100559872;
				if (num != 0)
				{
				}
				return this.i.av();
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00010958 File Offset: 0x0000EB58
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00010A08 File Offset: 0x0000EC08
		public long o
		{
			get
			{
				short num = (short)1286209536;
				short num2 = num;
				num = (short)1826488321;
				if (num != 0)
				{
				}
				num = (short)591150084;
				short num3 = num;
				num = (short)662846468;
				switch (num3 == num)
				{
				}
				num = (short)954728448;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				short num = (short)1131085824;
				short num2 = num;
				num = (short)508821181;
				short num3 = num;
				num = (short)379190973;
				switch (num3 == num)
				{
				}
				num = (short)871628801;
				if (num != 0)
				{
				}
				num = (short)1931804672;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00010AB8 File Offset: 0x0000ECB8
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00010B68 File Offset: 0x0000ED68
		public long p
		{
			get
			{
				short num = (short)95813632;
				short num2 = num;
				num = (short)1524760577;
				if (num != 0)
				{
				}
				num = (short)1137168805;
				short num3 = num;
				num = (short)1575997861;
				switch (num3 == num)
				{
				}
				num = (short)1361641472;
				if (num != 0)
				{
				}
				return this.l;
			}
			set
			{
				short num = (short)869793792;
				short num2 = num;
				num = (short)438829698;
				short num3 = num;
				num = (short)2058093186;
				switch (num3 == num)
				{
				}
				num = (short)1550057473;
				if (num != 0)
				{
				}
				num = (short)1825243136;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00010C18 File Offset: 0x0000EE18
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		public new int q
		{
			get
			{
				short num = (short)1418854400;
				short num2 = num;
				num = (short)846534348;
				short num3 = num;
				num = (short)900667084;
				switch (num3 == num)
				{
				}
				num = (short)1491075073;
				if (num != 0)
				{
				}
				num = (short)1903820800;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1612513280;
				short num2 = num;
				num = (short)1006470803;
				short num3 = num;
				num = (short)614958739;
				switch (num3 == num)
				{
				}
				num = (short)1510014977;
				if (num != 0)
				{
				}
				num = (short)1379860480;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00010D78 File Offset: 0x0000EF78
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00010E24 File Offset: 0x0000F024
		public long r
		{
			get
			{
				short num = (short)1794179072;
				short num2 = num;
				num = (short)871735759;
				short num3 = num;
				num = (short)316318159;
				switch (num3 == num)
				{
				}
				num = (short)335151105;
				if (num != 0)
				{
				}
				num = (short)115736576;
				if (num != 0)
				{
				}
				return this.m;
			}
			set
			{
				short num = (short)290979840;
				short num2 = num;
				num = (short)794824260;
				short num3 = num;
				num = (short)641207876;
				switch (num3 == num)
				{
				}
				num = (short)1668546561;
				if (num != 0)
				{
				}
				num = (short)829685760;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00010F84 File Offset: 0x0000F184
		public bool s
		{
			get
			{
				short num = (short)862781440;
				short num2 = num;
				num = (short)190850170;
				short num3 = num;
				num = (short)1718035578;
				switch (num3 == num)
				{
				}
				num = (short)1574961153;
				if (num != 0)
				{
				}
				num = (short)1711079424;
				if (num != 0)
				{
				}
				return this.n;
			}
			set
			{
				short num = (short)1007812608;
				short num2 = num;
				num = (short)1725129890;
				short num3 = num;
				num = (short)1894671522;
				switch (num3 == num)
				{
				}
				num = (short)1513553920;
				if (num != 0)
				{
				}
				num = (short)609026049;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00011034 File Offset: 0x0000F234
		public void ba()
		{
			short num = (short)471269376;
			short num2 = num;
			num = (short)29567937;
			short num3 = num;
			num = (short)1620061121;
			switch (num3 == num)
			{
			}
			num = (short)284033024;
			if (num != 0)
			{
			}
			num = (short)1848508417;
			if (num != 0)
			{
			}
			this.o.WaitOne();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000110E8 File Offset: 0x0000F2E8
		public void bb()
		{
			short num = (short)1500839936;
			short num2 = num;
			num = (short)1788291512;
			short num3 = num;
			num = (short)623454648;
			switch (num3 == num)
			{
			}
			num = (short)522846209;
			if (num != 0)
			{
			}
			num = (short)1675034624;
			if (num != 0)
			{
			}
			this.c = null;
		}

		// Token: 0x04000084 RID: 132
		private int a;

		// Token: 0x04000085 RID: 133
		private global::Motorola.Common.Communication.RUDP.j b = new global::Motorola.Common.Communication.RUDP.j();

		// Token: 0x04000086 RID: 134
		private global::Motorola.Common.Communication.RUDP.l c;

		// Token: 0x04000087 RID: 135
		private new global::Motorola.Common.Communication.RUDP.m e = new global::Motorola.Common.Communication.RUDP.m();

		// Token: 0x04000088 RID: 136
		private new global::Motorola.Common.Communication.RUDP.p f = new global::Motorola.Common.Communication.RUDP.p();

		// Token: 0x04000089 RID: 137
		private global::Motorola.Common.Communication.RUDP.q g;

		// Token: 0x0400008A RID: 138
		private bool h = true;

		// Token: 0x0400008B RID: 139
		private bool i;

		// Token: 0x0400008C RID: 140
		private int j;

		// Token: 0x0400008D RID: 141
		private long k;

		// Token: 0x0400008E RID: 142
		private long l;

		// Token: 0x0400008F RID: 143
		private long m;

		// Token: 0x04000090 RID: 144
		private bool n;

		// Token: 0x04000091 RID: 145
		private global::System.Threading.ManualResetEvent o = new global::System.Threading.ManualResetEvent(false);
	}
}
