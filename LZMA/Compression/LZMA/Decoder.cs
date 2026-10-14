using System;
using System.IO;
using SevenZip.Compression.LZ;
using SevenZip.Compression.RangeCoder;

namespace SevenZip.Compression.LZMA
{
	// Token: 0x02000019 RID: 25
	public class Decoder : global::SevenZip.ICoder, global::SevenZip.ISetDecoderProperties
	{
		// Token: 0x06000077 RID: 119 RVA: 0x0000A530 File Offset: 0x00008730
		public Decoder()
		{
			this.o = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.i[num] = new global::SevenZip.Compression.RangeCoder.f(6);
				num++;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000A620 File Offset: 0x00008820
		private void a(uint A_0)
		{
			short num = (short)55574528;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					goto IL_EE;
				case 2:
				{
					this.o = A_0;
					this.p = global::System.Math.Max(this.o, 1U);
					uint windowSize = global::System.Math.Max(this.p, 4096U);
					this.a.Create(windowSize);
					num = (short)2066743297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_32:
				num = (short)248105548;
				short num3 = num;
				num = (short)238733900;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1714683904;
					if (num != 0)
					{
					}
					if (this.o == A_0)
					{
						goto IL_117;
					}
					num = (short)50462722;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_EE:
			num = (short)1503199233;
			if (num != 0)
			{
			}
			IL_117:
			num = (short)1908408320;
			short num4 = num;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000A770 File Offset: 0x00008970
		private void a(int A_0, int A_1)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)911998976;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 1:
						goto IL_126;
					case 2:
						if (A_1 > 8)
						{
							num = (short)686620673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12E;
					case 3:
						goto IL_C4;
					}
					IL_34:
					if (A_0 > 8)
					{
						num = (short)1875378176;
						short num3 = num;
						num = (short)1365528051;
						short num4 = num;
						num = (short)997871091;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)2044854272;
							if (num != 0)
							{
							}
							num = (short)1907425283;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						num = (short)828768258;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
			IL_C4:
			num = (short)740294657;
			if (num != 0)
			{
			}
			throw new global::SevenZip.InvalidParamException();
			IL_126:
			throw new global::SevenZip.InvalidParamException();
			IL_12E:
			this.n.a(A_0, A_1);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000A8B8 File Offset: 0x00008AB8
		private void a(int pb)
		{
			short num = (short)455042915;
			short num2 = num;
			num = (short)627795811;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A7;
			case 1:
				break;
			default:
			{
				num = (short)1960574976;
				short num3 = num;
				break;
			}
			}
			num = (short)193855488;
			if (num != 0)
			{
			}
			if (pb > 4)
			{
				num = (short)218234881;
				if (num != 0)
				{
				}
				throw new global::SevenZip.InvalidParamException();
			}
			IL_A7:
			uint num4 = 1U << pb;
			this.l.a(num4);
			this.m.a(num4);
			this.q = num4 - 1U;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000A994 File Offset: 0x00008B94
		private void a(global::System.IO.Stream A_0, global::System.IO.Stream A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			uint num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.d[(int)num2].a();
					this.e[(int)num2].a();
					this.f[(int)num2].a();
					this.g[(int)num2].a();
					num2 += 1U;
					num3 = (short)1826881540;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					goto IL_2B3;
				case 2:
					num3 = (short)462094337;
					if (num3 != 0)
					{
					}
					goto IL_277;
				case 3:
					goto IL_C9;
				case 4:
					goto IL_277;
				case 5:
					goto IL_213;
				case 6:
					goto IL_2B3;
				case 7:
					if (num2 >= 114U)
					{
						num3 = (short)735117325;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					this.j[(int)num2].a();
					num2 += 1U;
					num3 = (short)935591941;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 8:
				{
					num3 = (short)641462225;
					short num4 = num3;
					num3 = (short)740945873;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C9;
					default:
						num3 = (short)1864826880;
						if (num3 != 0)
						{
						}
						num2 = 0U;
						num3 = (short)697565199;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 9:
					goto IL_B1;
				case 10:
				{
					if (num2 >= 12U)
					{
						num3 = (short)325124107;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					uint num5 = 0U;
					num3 = (short)1676148742;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 11:
					this.n.a();
					num2 = 0U;
					num3 = (short)48693257;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 12:
				{
					uint num5;
					if (num5 > this.q)
					{
						num3 = (short)2145976320;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					uint num6 = (num2 << 4) + num5;
					this.c[(int)num6].a();
					this.h[(int)num6].a();
					num5 += 1U;
					num3 = (short)352976897;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 13:
					goto IL_272;
				case 14:
					goto IL_B1;
				case 15:
					goto IL_213;
				}
				goto IL_50;
				IL_B1:
				num3 = (short)1489633283;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_C9:
				if (num2 >= 4U)
				{
					num3 = (short)2113339400;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				this.i[(int)num2].a();
				num2 += 1U;
				num3 = (short)1663696910;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_213:
				num3 = (short)131399680;
				short num7 = num3;
				num3 = (short)743571463;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_277:
				num3 = (short)1766326282;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_2B3:
				num3 = (short)186974220;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_272:
			this.l.a();
			this.m.a();
			this.k.a();
			return;
			IL_50:
			this.b.a(A_0);
			this.a.Init(A_1, this.r);
			num2 = 0U;
			num3 = (short)1872756738;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000AD48 File Offset: 0x00008F48
		public void Code(global::System.IO.Stream inStream, global::System.IO.Stream outStream, long inSize, long outSize, global::SevenZip.ICodeProgress progress)
		{
			short num = (short)1604059136;
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
				global::SevenZip.Compression.LZMA.a.a a;
				uint num4;
				uint num3;
				uint num5;
				uint num6;
				ulong num11;
				for (;;)
				{
					IL_27:
					uint num8;
					uint num7;
					uint num10;
					byte b;
					switch (num2)
					{
					case 0:
					{
						if (this.d[(int)a.a].a(this.b) == 1U)
						{
							num = (short)993787908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = num4;
						num4 = num5;
						num5 = num6;
						num7 = 2U + this.l.a(this.b, num8);
						a.d();
						uint num9 = this.i[(int)global::SevenZip.Compression.LZMA.a.a(num7)].a(this.b);
						num = (short)965345293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_3F6;
					case 2:
						num10 = num5;
						num = (short)1830551594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.c[(int)((a.a << 4) + num8)].a(this.b) == 0U)
						{
							num = (short)544538660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)726138880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)303169559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1F5;
					case 6:
						goto IL_431;
					case 7:
						goto IL_913;
					case 8:
						goto IL_3B9;
					case 9:
					{
						if (!a.g())
						{
							num = (short)231669787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte @byte;
						b = this.n.a(this.b, (uint)num11, @byte);
						num = (short)639827984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_4E3;
					case 11:
						num = (short)50790401;
						if (num != 0)
						{
						}
						num = (short)629669920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (num6 >= this.p)
						{
							num = (short)1353580552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.CopyBlock(num6, num7);
						num11 += (ulong)num7;
						num = (short)550895644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						uint num9;
						if (num9 >= 4U)
						{
							num = (short)81264677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 = num9;
						num = (short)1029832709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						uint num9;
						if (num9 < 14U)
						{
							num = (short)2112552984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num12;
						num6 += this.b.a(num12 - 4) << 4;
						num6 += this.k.b(this.b);
						num = (short)81264674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if ((ulong)num6 < (ulong)this.a.TrainSize + num11)
						{
							num = (short)802750495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B9;
					case 16:
						goto IL_380;
					case 17:
						if (num11 < (ulong)outSize)
						{
							num = (short)516751389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F6;
					case 18:
						if (this.f[(int)a.a].a(this.b) == 0U)
						{
							num = (short)27787266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)334233640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						a.f();
						this.a.PutByte(this.a.GetByte(num6));
						num11 += 1UL;
						num = (short)359858177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_8F6;
					case 21:
						goto IL_1F5;
					case 22:
						if (num6 != 4294967295U)
						{
							num = (short)1166213150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_996;
					case 23:
						if (this.e[(int)a.a].a(this.b) == 0U)
						{
							num = (short)1932001291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1894187026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						uint num9;
						int num12;
						num6 += global::SevenZip.Compression.RangeCoder.f.a(this.j, num6 - num9 - 1U, this.b, num12);
						num = (short)1368588331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_380;
					case 26:
					{
						if (num11 >= (ulong)outSize)
						{
							num = (short)557711366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num8 = ((uint)num11 & this.q);
						num = (short)1315700736;
						short num13 = num;
						num = (short)1563099139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						byte @byte;
						b = this.n.a(this.b, (uint)num11, @byte, this.a.GetByte(num6));
						num = (short)750649369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
					{
						num = (short)1305435556;
						short num14 = num;
						num = (short)778722724;
						switch ((num14 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_913;
						default:
							num = (short)1098448896;
							if (num != 0)
							{
							}
							goto IL_3F6;
						}
						break;
					}
					case 29:
						num = (short)158335020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_3F1;
					case 31:
						num = (short)1755316236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (this.h[(int)((a.a << 4) + num8)].a(this.b) == 0U)
						{
							num = (short)825032723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BA;
					case 33:
						goto IL_3F6;
					case 34:
						goto IL_1F5;
					case 35:
						goto IL_3F6;
					case 36:
					{
						byte @byte = this.a.GetByte(0U);
						num = (short)1722613769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
					{
						uint num9;
						int num12 = (int)((num9 >> 1) - 1U);
						num6 = (2U | (num9 & 1U)) << num12;
						num = (short)569507854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						goto IL_19F;
					case 39:
						goto IL_19F;
					case 40:
						if (this.g[(int)a.a].a(this.b) == 0U)
						{
							num = (short)1165492265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num10 = num3;
						num3 = num4;
						num = (short)618922022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num10 = num4;
						num = (short)1526333479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_8F6;
					case 43:
						goto IL_1F5;
					case 44:
					{
						if (this.c[(int)((int)a.a << 4)].a(this.b) != 0U)
						{
							num = (short)1519648778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a.c();
						byte b2 = this.n.a(this.b, 0U, 0);
						this.a.PutByte(b2);
						num11 += 1UL;
						num = (short)97452067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_E2;
					IL_19F:
					num4 = num5;
					num = (short)524308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F5:
					num = (short)235339791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_380:
					this.a.PutByte(b);
					a.c();
					num11 += 1UL;
					num = (short)677511201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B9:
					num = (short)1885077526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F6:
					num = (short)434765850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6BA:
					num7 = this.m.a(this.b, num8) + 2U;
					a.e();
					num = (short)1097596949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_913:
					goto IL_6BA;
					IL_8F6:
					num5 = num6;
					num6 = num10;
					num = (short)1136394247;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3F1:
				throw new global::SevenZip.DataErrorException();
				IL_431:
				goto IL_996;
				IL_4E3:
				throw new global::SevenZip.DataErrorException();
				IL_996:
				this.a.Flush();
				this.a.ReleaseStream();
				this.b.a();
				return;
				IL_E2:
				this.a(inStream, outStream);
				a = default(global::SevenZip.Compression.LZMA.a.a);
				a.b();
				num6 = 0U;
				num5 = 0U;
				num4 = 0U;
				num3 = 0U;
				num11 = 0UL;
				num = (short)818216977;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000B70C File Offset: 0x0000990C
		public void SetDecoderProperties(byte[] properties)
		{
			short num = (short)1934884864;
			switch (num)
			{
			default:
			{
				num = (short)1306329089;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				uint num4;
				int a_;
				int a_2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_85;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_65;
						}
						continue;
					case 2:
						goto IL_13D;
					case 3:
						goto IL_13D;
					case 4:
					{
						if (num3 > 4)
						{
							num = (short)544145414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = 0U;
						int num5 = 0;
						num = (short)1525350403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_176;
					case 6:
						goto IL_1EF;
					case 7:
					{
						int num5;
						if (num5 >= 4)
						{
							num = (short)683343877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 += (uint)((uint)properties[1 + num5] << num5 * 8);
						num5++;
						num = (short)2054425511;
						short num6 = num;
						num = (short)373623719;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_217;
						default:
						{
							num = (short)2057437184;
							if (num != 0)
							{
							}
							num = (short)390266880;
							short num7 = num;
							num = (short)1860960258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_65:
					if (properties.Length < 5)
					{
						num = (short)1424490496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)846659585;
					if (num != 0)
					{
					}
					a_ = (int)(properties[0] % 9);
					byte b = properties[0] / 9;
					a_2 = (int)(b % 5);
					num3 = (int)(b / 5);
					num = (short)297533444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13D:
					num = (short)1324089351;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_85:
				throw new global::SevenZip.InvalidParamException();
				IL_176:
				goto IL_217;
				IL_1EF:
				throw new global::SevenZip.InvalidParamException();
				IL_217:
				this.a(num4);
				this.a(a_2, a_);
				this.a(num3);
				return;
			}
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000B948 File Offset: 0x00009B48
		public bool Train(global::System.IO.Stream stream)
		{
			short num = (short)538443776;
			short num2 = num;
			num = (short)393319419;
			short num3 = num;
			num = (short)67081211;
			switch (num3 == num)
			{
			}
			num = (short)634060800;
			if (num != 0)
			{
			}
			num = (short)1742995457;
			if (num != 0)
			{
			}
			this.r = true;
			return this.a.Train(stream);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000BA04 File Offset: 0x00009C04
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1399814003 + A_1) + (global::System.IntPtr)53 + (global::System.IntPtr)8 + (global::System.IntPtr)16 + (global::System.IntPtr)88);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}

		// Token: 0x04000070 RID: 112
		private global::SevenZip.Compression.LZ.OutWindow a = new global::SevenZip.Compression.LZ.OutWindow();

		// Token: 0x04000071 RID: 113
		private global::SevenZip.Compression.RangeCoder.b b = new global::SevenZip.Compression.RangeCoder.b();

		// Token: 0x04000072 RID: 114
		private global::SevenZip.Compression.RangeCoder.d[] c = new global::SevenZip.Compression.RangeCoder.d[192];

		// Token: 0x04000073 RID: 115
		private global::SevenZip.Compression.RangeCoder.d[] d = new global::SevenZip.Compression.RangeCoder.d[12];

		// Token: 0x04000074 RID: 116
		private global::SevenZip.Compression.RangeCoder.d[] e = new global::SevenZip.Compression.RangeCoder.d[12];

		// Token: 0x04000075 RID: 117
		private global::SevenZip.Compression.RangeCoder.d[] f = new global::SevenZip.Compression.RangeCoder.d[12];

		// Token: 0x04000076 RID: 118
		private global::SevenZip.Compression.RangeCoder.d[] g = new global::SevenZip.Compression.RangeCoder.d[12];

		// Token: 0x04000077 RID: 119
		private global::SevenZip.Compression.RangeCoder.d[] h = new global::SevenZip.Compression.RangeCoder.d[192];

		// Token: 0x04000078 RID: 120
		private global::SevenZip.Compression.RangeCoder.f[] i = new global::SevenZip.Compression.RangeCoder.f[4];

		// Token: 0x04000079 RID: 121
		private global::SevenZip.Compression.RangeCoder.d[] j = new global::SevenZip.Compression.RangeCoder.d[114];

		// Token: 0x0400007A RID: 122
		private global::SevenZip.Compression.RangeCoder.f k = new global::SevenZip.Compression.RangeCoder.f(4);

		// Token: 0x0400007B RID: 123
		private global::SevenZip.Compression.LZMA.Decoder.a l = new global::SevenZip.Compression.LZMA.Decoder.a();

		// Token: 0x0400007C RID: 124
		private global::SevenZip.Compression.LZMA.Decoder.a m = new global::SevenZip.Compression.LZMA.Decoder.a();

		// Token: 0x0400007D RID: 125
		private global::SevenZip.Compression.LZMA.Decoder.b n = new global::SevenZip.Compression.LZMA.Decoder.b();

		// Token: 0x0400007E RID: 126
		private uint o;

		// Token: 0x0400007F RID: 127
		private uint p;

		// Token: 0x04000080 RID: 128
		private uint q;

		// Token: 0x04000081 RID: 129
		private bool r;

		// Token: 0x0200001A RID: 26
		private class a
		{
			// Token: 0x06000080 RID: 128 RVA: 0x0000BA88 File Offset: 0x00009C88
			public void a(uint A_0)
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_20;
					}
					int num;
					uint num5;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
						{
							num2 = (short)1213333504;
							short num3 = num2;
							num2 = (short)1706515256;
							short num4 = num2;
							num2 = (short)1649498936;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)2046885888;
								if (num2 != 0)
								{
								}
								goto IL_B5;
							}
							break;
						}
						case 1:
							goto IL_B5;
						case 2:
							goto IL_E8;
						case 3:
							if (num5 >= A_0)
							{
								num2 = (short)987103234;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							this.c[(int)num5] = new global::SevenZip.Compression.RangeCoder.f(3);
							this.d[(int)num5] = new global::SevenZip.Compression.RangeCoder.f(3);
							num5 += 1U;
							num2 = (short)649986049;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
						IL_B5:
						num2 = (short)1290403843;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_20:
					num5 = this.f;
					num2 = (short)1165688832;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_E8:
				num2 = (short)1600389121;
				if (num2 != 0)
				{
				}
				this.f = A_0;
			}

			// Token: 0x06000081 RID: 129 RVA: 0x0000BBF4 File Offset: 0x00009DF4
			public void a()
			{
				for (;;)
				{
					IL_00:
					short num = (short)916258817;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					int num2;
					uint num4;
					for (;;)
					{
						IL_32:
						switch (num2)
						{
						case 0:
						{
							num = (short)760460303;
							short num3 = num;
							num = (short)815510543;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1216086016;
								if (num != 0)
								{
								}
								goto IL_E0;
							}
							break;
						}
						case 1:
							goto IL_E0;
						case 2:
							goto IL_119;
						case 3:
							if (num4 >= this.f)
							{
								num = (short)303104002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.c[(int)num4].a();
							this.d[(int)num4].a();
							num4 += 1U;
							num = (short)1818558465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_E0:
						num = (short)1680932867;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_48:
					this.a.a();
					num4 = 0U;
					num = (short)1425080320;
					short num5 = num;
					num = (short)1731657728;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				IL_119:
				this.b.a();
				this.e.a();
			}

			// Token: 0x06000082 RID: 130 RVA: 0x0000BD74 File Offset: 0x00009F74
			public uint a(global::SevenZip.Compression.RangeCoder.b A_0, uint A_1)
			{
				short num = (short)834404352;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 1:
						goto IL_5F;
					case 2:
					{
						if (this.b.a(A_0) == 0U)
						{
							num = (short)2009726980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num3;
						num3 += 8U;
						num3 += this.e.a(A_0);
						num = (short)4456451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_141;
					case 4:
					{
						num = (short)97124352;
						short num4 = num;
						uint num3;
						num3 += this.d[(int)A_1].a(A_0);
						num = (short)659750917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_BA;
					}
					IL_3C:
					if (this.a.a(A_0) == 0U)
					{
						num = (short)1910767617;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						uint num3 = 8U;
						num = (short)1983315970;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_5F:
				return this.c[(int)A_1].a(A_0);
				IL_BA:
				IL_141:
				num = (short)1885853197;
				short num5 = num;
				num = (short)1731515917;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5F;
				default:
				{
					num = (short)1754726400;
					if (num != 0)
					{
					}
					num = (short)1195245569;
					if (num != 0)
					{
					}
					uint num3;
					return num3;
				}
				}
			}

			// Token: 0x04000082 RID: 130
			private global::SevenZip.Compression.RangeCoder.d a;

			// Token: 0x04000083 RID: 131
			private global::SevenZip.Compression.RangeCoder.d b;

			// Token: 0x04000084 RID: 132
			private global::SevenZip.Compression.RangeCoder.f[] c = new global::SevenZip.Compression.RangeCoder.f[16];

			// Token: 0x04000085 RID: 133
			private global::SevenZip.Compression.RangeCoder.f[] d = new global::SevenZip.Compression.RangeCoder.f[16];

			// Token: 0x04000086 RID: 134
			private global::SevenZip.Compression.RangeCoder.f e = new global::SevenZip.Compression.RangeCoder.f(8);

			// Token: 0x04000087 RID: 135
			private uint f;
		}

		// Token: 0x0200001B RID: 27
		private class b
		{
			// Token: 0x06000084 RID: 132 RVA: 0x0000BF74 File Offset: 0x0000A174
			public void a(int A_0, int A_1)
			{
				short num = (short)321060866;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					uint num5;
					uint num6;
					switch (num2)
					{
					case 0:
					{
						if (this.b != A_1)
						{
							goto IL_1ED;
						}
						num = (short)1974075392;
						short num3 = num;
						num = (short)149758843;
						short num4 = num;
						num = (short)1703879547;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)964689920;
							if (num != 0)
							{
							}
							num = (short)1987706889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_14E;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_4D;
						}
						continue;
					case 3:
						num = (short)553910272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_14E;
					case 5:
						if (this.c == A_0)
						{
							num = (short)1091698696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1ED;
					case 6:
						goto IL_183;
					case 7:
						if (num5 >= num6)
						{
							num = (short)2117533702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a[(int)num5].a();
						num5 += 1U;
						num = (short)1778319361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						return;
					case 9:
						num = (short)1178337285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4D:
					if (this.a != null)
					{
						num = (short)2034237443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1ED;
					IL_14E:
					num = (short)1580335111;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1ED:
					this.c = A_0;
					this.d = (1U << A_0) - 1U;
					this.b = A_1;
					num6 = 1U << this.b + this.c;
					this.a = new global::SevenZip.Compression.LZMA.Decoder.b.a[num6];
					num5 = 0U;
					num = (short)476512260;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_183:
				num = (short)270794753;
				if (num != 0)
				{
				}
			}

			// Token: 0x06000085 RID: 133 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
			public void a()
			{
				short num = (short)154317437;
				short num2 = num;
				num = (short)27374205;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_93;
				case 1:
					goto IL_5D;
				default:
				{
					num = (short)564592640;
					short num3 = num;
					goto IL_5D;
				}
				}
				int num4;
				uint num5;
				uint num6;
				for (;;)
				{
					IL_7D:
					switch (num4)
					{
					case 0:
						goto IL_E6;
					case 1:
						return;
					case 2:
						if (num5 >= num6)
						{
							num = (short)1252917249;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a[(int)num5].b();
						num5 += 1U;
						num = (short)284360707;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_E6;
					}
					goto IL_93;
					IL_E6:
					num = (short)1119944706;
					num4 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_5D:
				num = (short)204406784;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				goto IL_7D;
				IL_93:
				num = (short)1514340353;
				if (num != 0)
				{
				}
				num6 = 1U << this.b + this.c;
				num5 = 0U;
				num = (short)22806528;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7D;
			}

			// Token: 0x06000086 RID: 134 RVA: 0x0000C320 File Offset: 0x0000A520
			private uint a(uint A_0, byte A_1)
			{
				short num = (short)170000385;
				if (num != 0)
				{
				}
				num = (short)271712256;
				short num2 = num;
				num = (short)388946889;
				short num3 = num;
				num = (short)1951783881;
				switch (num3 == num)
				{
				}
				num = (short)75759616;
				if (num != 0)
				{
				}
				return ((A_0 & this.d) << this.b) + (uint)(A_1 >> 8 - this.b);
			}

			// Token: 0x06000087 RID: 135 RVA: 0x0000C3EC File Offset: 0x0000A5EC
			public byte a(global::SevenZip.Compression.RangeCoder.b A_0, uint A_1, byte A_2)
			{
				short num = (short)1099333699;
				short num2 = num;
				num = (short)518553667;
				switch (num2 == num)
				{
				default:
				{
					num = (short)307429376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1226899456;
				if (num != 0)
				{
				}
				num = (short)1611464705;
				if (num != 0)
				{
				}
				return this.a[(int)this.a(A_1, A_2)].a(A_0);
			}

			// Token: 0x06000088 RID: 136 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
			public byte a(global::SevenZip.Compression.RangeCoder.b A_0, uint A_1, byte A_2, byte A_3)
			{
				short num = (short)526403779;
				short num2 = num;
				num = (short)2143242435;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1251475456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)743243776;
				if (num != 0)
				{
				}
				num = (short)1864564737;
				if (num != 0)
				{
				}
				return this.a[(int)this.a(A_1, A_2)].a(A_0, A_3);
			}

			// Token: 0x04000088 RID: 136
			private global::SevenZip.Compression.LZMA.Decoder.b.a[] a;

			// Token: 0x04000089 RID: 137
			private int b;

			// Token: 0x0400008A RID: 138
			private int c;

			// Token: 0x0400008B RID: 139
			private uint d;

			// Token: 0x0200001C RID: 28
			private struct a
			{
				// Token: 0x0600008A RID: 138 RVA: 0x0000C58C File Offset: 0x0000A78C
				public void a()
				{
					short num = (short)676995373;
					short num2 = num;
					num = (short)2067013933;
					switch (num2 == num)
					{
					default:
					{
						num = (short)1289945088;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)1149829121;
					if (num != 0)
					{
					}
					num = (short)1766457344;
					if (num != 0)
					{
					}
					this.a = new global::SevenZip.Compression.RangeCoder.d[768];
				}

				// Token: 0x0600008B RID: 139 RVA: 0x0000C648 File Offset: 0x0000A848
				public void b()
				{
					short num = (short)505014878;
					short num2 = num;
					num = (short)1710680670;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_95;
					case 1:
						goto IL_5F;
					default:
					{
						num = (short)62455808;
						short num3 = num;
						goto IL_5F;
					}
					}
					int num4;
					int num5;
					for (;;)
					{
						IL_7F:
						switch (num4)
						{
						case 0:
							goto IL_AD;
						case 1:
							return;
						case 2:
							if (num5 >= 768)
							{
								num = (short)92602369;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.a[num5].a();
							num5++;
							num = (short)379256835;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_AD;
						}
						goto IL_95;
						IL_AD:
						num = (short)1285619713;
						if (num != 0)
						{
						}
						num = (short)1025179650;
						num4 = (int)((global::System.IntPtr)num);
					}
					return;
					IL_5F:
					num = (short)721616896;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					goto IL_7F;
					IL_95:
					num5 = 0;
					num = (short)2107703296;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_7F;
				}

				// Token: 0x0600008C RID: 140 RVA: 0x0000C794 File Offset: 0x0000A994
				public byte a(global::SevenZip.Compression.RangeCoder.b A_0)
				{
					short num = (short)1347026944;
					short num2 = num;
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					int num3;
					uint num5;
					for (;;)
					{
						IL_33:
						switch (num3)
						{
						case 0:
						{
							num = (short)631359847;
							short num4 = num;
							num = (short)1595787623;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_11E;
							default:
								num = (short)1064173568;
								if (num != 0)
								{
								}
								goto IL_CF;
							}
							break;
						}
						case 1:
							if (num5 >= 256U)
							{
								num = (short)1787101186;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CF;
						case 2:
							goto IL_11C;
						}
						goto IL_45;
						IL_CF:
						num5 = (num5 << 1 | this.a[(int)num5].a(A_0));
						num = (short)1352335361;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_11C:
					IL_11E:
					return (byte)num5;
					IL_45:
					num5 = 1U;
					num = (short)887291905;
					if (num != 0)
					{
					}
					num = (short)454950912;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_33;
				}

				// Token: 0x0600008D RID: 141 RVA: 0x0000C8C4 File Offset: 0x0000AAC4
				public byte a(global::SevenZip.Compression.RangeCoder.b A_0, byte A_1)
				{
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					int num;
					short num4;
					uint num6;
					for (;;)
					{
						IL_0A:
						uint num2;
						uint num3;
						switch (num)
						{
						case 0:
						{
							if (num2 != num3)
							{
								num4 = (short)1247019012;
								num = (int)((global::System.IntPtr)num4);
								continue;
							}
							num4 = (short)1408237568;
							short num5 = num4;
							num4 = (short)453312520;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						case 1:
							goto IL_1D9;
						case 2:
							goto IL_117;
						case 3:
							num4 = (short)1329397765;
							num = (int)((global::System.IntPtr)num4);
							continue;
						case 4:
							num4 = (short)83427335;
							num = (int)((global::System.IntPtr)num4);
							continue;
						case 5:
							goto IL_B6;
						case 6:
							num4 = (short)1010696193;
							if (num4 != 0)
							{
							}
							goto IL_1F4;
						case 7:
							goto IL_1F4;
						case 8:
							if (num6 >= 256U)
							{
								num4 = (short)777060353;
								num = (int)((global::System.IntPtr)num4);
								continue;
							}
							goto IL_117;
						case 9:
							if (num6 >= 256U)
							{
								num4 = (short)2023096323;
								num = (int)((global::System.IntPtr)num4);
								continue;
							}
							num6 = (num6 << 1 | this.a[(int)num6].a(A_0));
							num4 = (short)1316028422;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						goto IL_38;
						IL_117:
						num2 = (uint)(A_1 >> 7 & 1);
						A_1 = (byte)(A_1 << 1);
						num3 = this.a[(int)((1U + num2 << 8) + num6)].a(A_0);
						num6 = (num6 << 1 | num3);
						num4 = (short)1959067648;
						num = (int)((global::System.IntPtr)num4);
						continue;
						IL_1F4:
						num4 = (short)768409609;
						num = (int)((global::System.IntPtr)num4);
					}
					IL_B6:
					IL_1D9:
					return (byte)num6;
					IL_38:
					num4 = (short)595849404;
					short num7 = num4;
					num4 = (short)1006694588;
					switch ((num7 == num4) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num4 = (short)905641984;
						if (num4 != 0)
						{
						}
						num6 = 1U;
						break;
					}
					num4 = (short)1109655554;
					num = (int)((global::System.IntPtr)num4);
					goto IL_0A;
				}

				// Token: 0x0400008C RID: 140
				private global::SevenZip.Compression.RangeCoder.d[] a;
			}
		}
	}
}
