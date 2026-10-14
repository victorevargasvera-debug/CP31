using System;
using System.IO;
using SevenZip.Compression.LZ;
using SevenZip.Compression.RangeCoder;

namespace SevenZip.Compression.LZMA
{
	// Token: 0x0200001D RID: 29
	public class Encoder : global::SevenZip.ICoder, global::SevenZip.ISetCoderProperties, global::SevenZip.IWriteCoderProperties
	{
		// Token: 0x0600008E RID: 142 RVA: 0x0000CB08 File Offset: 0x0000AD08
		static Encoder()
		{
			int a_ = 2;
			short num = (short)1618870272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				byte b;
				int num6;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
							goto IL_E4;
						case 1:
							b += 1;
							num = (short)1060634628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							uint num3;
							uint num4;
							if (num3 >= num4)
							{
								num = (short)1843986433;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2135490561;
							if (num != 0)
							{
							}
							num = (short)1328895847;
							short num5 = num;
							num = (short)122771303;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_A8;
							default:
								num = (short)1778319360;
								if (num != 0)
								{
								}
								global::SevenZip.Compression.LZMA.Encoder.b[num6] = b;
								num3 += 1U;
								num6++;
								num = (short)1133117440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_147;
						case 4:
							goto IL_147;
						case 5:
						{
							if (b >= 22)
							{
								num = (short)1738211335;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							uint num4 = 1U << (b >> 1) - 1;
							uint num3 = 0U;
							num = (short)1673330694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_E4;
						case 7:
							goto IL_17D;
						}
						goto IL_58;
						IL_E4:
						num = (short)1932460034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_147:
						num = (short)1436549125;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_17D:
					num = (short)131792896;
					short num7 = num;
					return;
				}
				}
				IL_58:
				global::SevenZip.Compression.LZMA.Encoder.b = new byte[2048];
				global::SevenZip.Compression.LZMA.Encoder.a4 = new string[]
				{
					global::SevenZip.Compression.LZMA.Decoder.b("多䤜ⴞ", a_),
					global::SevenZip.Compression.LZMA.Decoder.b("多䤜⬞", a_)
				};
				num6 = 2;
				global::SevenZip.Compression.LZMA.Encoder.b[0] = 0;
				global::SevenZip.Compression.LZMA.Encoder.b[1] = 1;
				b = 2;
				IL_A8:
				num = (short)738787331;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000CD5C File Offset: 0x0000AF5C
		private static uint e(uint A_0)
		{
			short num = (short)1020348178;
			short num2 = num;
			num = (short)1235240722;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)525664256;
				short num3 = num;
				goto IL_5E;
			}
			}
			int num4;
			for (;;)
			{
				IL_93:
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				case 1:
					if (A_0 < 2097152U)
					{
						num = (short)238813187;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13D;
				case 2:
					goto IL_EE;
				case 3:
					goto IL_133;
				}
				IL_A9:
				if (A_0 < 2048U)
				{
					num = (short)2058813441;
					if (num != 0)
					{
					}
					num = (short)1910177794;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1965621249;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
			IL_EE:
			return (uint)global::SevenZip.Compression.LZMA.Encoder.b[(int)A_0];
			IL_133:
			return (uint)(global::SevenZip.Compression.LZMA.Encoder.b[(int)(A_0 >> 10)] + 20);
			IL_13D:
			return (uint)(global::SevenZip.Compression.LZMA.Encoder.b[(int)(A_0 >> 20)] + 40);
			IL_5E:
			num = (short)1604190208;
			if (num != 0)
			{
			}
			num = (short)887488512;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_93;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000CEB4 File Offset: 0x0000B0B4
		private static uint d(uint A_0)
		{
			short num = (short)962626244;
			short num2 = num;
			num = (short)1526366916;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			case 1:
				goto IL_60;
			default:
			{
				num = (short)1715077120;
				short num3 = num;
				goto IL_60;
			}
			}
			int num4;
			for (;;)
			{
				IL_94:
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_AA;
					}
					continue;
				case 1:
					if (A_0 < 134217728U)
					{
						num = (short)1435041795;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13F;
				case 2:
					goto IL_C7;
				case 3:
					goto IL_108;
				}
				IL_AA:
				if (A_0 < 131072U)
				{
					num = (short)186777602;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)2078539777;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
			IL_C7:
			return (uint)(global::SevenZip.Compression.LZMA.Encoder.b[(int)(A_0 >> 6)] + 12);
			IL_108:
			num = (short)1344798721;
			if (num != 0)
			{
			}
			return (uint)(global::SevenZip.Compression.LZMA.Encoder.b[(int)(A_0 >> 16)] + 32);
			IL_13F:
			return (uint)(global::SevenZip.Compression.LZMA.Encoder.b[(int)(A_0 >> 26)] + 52);
			IL_60:
			num = (short)1591017472;
			if (num != 0)
			{
			}
			num = (short)46071808;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_94;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000D010 File Offset: 0x0000B210
		private void h()
		{
			short num = (short)92504212;
			short num2 = num;
			num = (short)541229204;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_93;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)880279552;
				short num3 = num;
				goto IL_5E;
			}
			}
			int num4;
			uint num5;
			for (;;)
			{
				IL_7D:
				switch (num4)
				{
				case 0:
					goto IL_BE;
				case 1:
					return;
				case 2:
					num = (short)1441398785;
					if (num != 0)
					{
					}
					if (num5 >= 4U)
					{
						num = (short)1741160449;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.e[(int)num5] = 0U;
					num5 += 1U;
					num = (short)1850081283;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_BE;
				}
				goto IL_93;
				IL_BE:
				num = (short)1458896898;
				num4 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_5E:
			num = (short)1252065280;
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
			this.c.b();
			this.d = 0;
			num5 = 0U;
			num = (short)2081357824;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7D;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000D164 File Offset: 0x0000B364
		private void g()
		{
			short num = (short)1207369730;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int type;
				global::SevenZip.Compression.LZ.BinTree binTree;
				switch (num2)
				{
				case 0:
					goto IL_D5;
				case 1:
				{
					num = (short)1242232208;
					short num3 = num;
					num = (short)254801296;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_228;
					default:
						num = (short)552796160;
						if (num != 0)
						{
						}
						type = 2;
						num = (short)1788149767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 3:
					goto IL_228;
				case 4:
					goto IL_1D5;
				case 5:
					binTree = new global::SevenZip.Compression.LZ.BinTree();
					type = 4;
					num = (short)2145255432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (this.ar == this.z)
					{
						num = (short)999030784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22D;
				case 7:
					goto IL_D7;
				case 8:
					if (this.av == global::SevenZip.Compression.LZMA.Encoder.a.a)
					{
						num = (short)740884481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D7;
				case 9:
					if (this.ap == this.aq)
					{
						num = (short)1543438339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22D;
				}
				IL_4C:
				if (this.k == null)
				{
					num = (short)439549953;
					if (num != 0)
					{
					}
					num = (short)472121349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1D5;
				IL_D7:
				binTree.SetType(type);
				this.k = binTree;
				num = (short)60096516;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D5:
				this.x.a(this.an, this.ao);
				num = (short)808517641;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_228:
				num = (short)957808646;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D5:
			num = (short)173604864;
			short num4 = num;
			return;
			IL_22D:
			this.k.Create(this.ap, 4096U, this.z, 274U);
			this.aq = this.ap;
			this.ar = this.z;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000D3D8 File Offset: 0x0000B5D8
		public Encoder()
		{
			int num = 0;
			while ((long)num < 4096L)
			{
				this.j[num] = new global::SevenZip.Compression.LZMA.Encoder.e();
				num++;
			}
			int num2 = 0;
			while ((long)num2 < 4L)
			{
				this.s[num2] = new global::SevenZip.Compression.RangeCoder.e(6);
				num2++;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000D5AC File Offset: 0x0000B7AC
		private void a(bool A_0)
		{
			short num = (short)804666707;
			short num2 = num;
			num = (short)323108179;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1679163392;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1601765376;
			if (num != 0)
			{
			}
			num = (short)2136932353;
			if (num != 0)
			{
			}
			this.aw = A_0;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000D65C File Offset: 0x0000B85C
		private void f()
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
				uint num5;
				switch (num)
				{
				case 0:
					goto IL_275;
				case 1:
					if (num2 >= 114U)
					{
						num3 = (short)279969806;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					this.t[(int)num2].b();
					num2 += 1U;
					num3 = (short)264765442;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					goto IL_239;
				case 3:
				{
					num3 = (short)1357528461;
					short num4 = num3;
					num3 = (short)1399209357;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_28C;
					default:
						num3 = (short)185991168;
						if (num3 != 0)
						{
						}
						goto IL_239;
					}
					break;
				}
				case 4:
					goto IL_AB;
				case 5:
					goto IL_AB;
				case 6:
					goto IL_2B1;
				case 7:
					if (num2 >= 4U)
					{
						num3 = (short)865599499;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					this.s[(int)num2].a();
					num2 += 1U;
					num3 = (short)614400004;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 8:
					this.x.a();
					num2 = 0U;
					num3 = (short)1541996549;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					this.n[(int)num2].b();
					this.o[(int)num2].b();
					this.p[(int)num2].b();
					this.q[(int)num2].b();
					num2 += 1U;
					num3 = (short)729350157;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 10:
					goto IL_28C;
				case 11:
					num3 = (short)725745665;
					if (num3 != 0)
					{
					}
					num2 = 0U;
					num3 = (short)2086141955;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 12:
					goto IL_2B1;
				case 13:
					goto IL_275;
				case 14:
					goto IL_270;
				case 15:
				{
					if (num5 > this.am)
					{
						num3 = (short)269156361;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					uint num6 = (num2 << 4) + num5;
					this.m[(int)num6].b();
					this.r[(int)num6].b();
					num5 += 1U;
					num3 = (short)1582563340;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				}
				goto IL_50;
				IL_AB:
				num3 = (short)1035862023;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_28C:
				if (num2 >= 12U)
				{
					num3 = (short)1267204104;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				num5 = 0U;
				num3 = (short)928382982;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_239:
				num3 = (short)1187250177;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_275:
				num3 = (short)190513162;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_2B1:
				num3 = (short)1361575951;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_270:
			this.v.d(1U << this.al);
			this.w.d(1U << this.al);
			this.u.a();
			this.af = false;
			this.ad = 0U;
			this.ae = 0U;
			this.ac = 0U;
			return;
			IL_50:
			num3 = (short)1168637952;
			short num7 = num3;
			this.h();
			this.l.b();
			num2 = 0U;
			num3 = (short)1179648000;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000DA40 File Offset: 0x0000BC40
		private void a(out uint A_0, out uint A_1)
		{
			short num = (short)1061503077;
			short num2 = num;
			num = (short)1116618853;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_134:
				num = (short)285409283;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1056964608;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				break;
			}
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					A_0 = this.y[(int)(A_1 - 2U)];
					num = (short)2046296066;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (A_1 > 0U)
					{
						num = (short)100466688;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19B;
				case 2:
					if (A_0 == this.z)
					{
						num = (short)1786183684;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19B;
				case 3:
					goto IL_14C;
				case 4:
					goto IL_196;
				}
				goto IL_6F;
			}
			IL_14C:
			goto IL_19B;
			IL_196:
			num = (short)1066205184;
			short num4 = num;
			num = (short)1919811585;
			if (num != 0)
			{
			}
			A_0 += this.k.GetMatchLen((int)(A_0 - 1U), this.y[(int)(A_1 - 1U)], 273U - A_0);
			goto IL_134;
			IL_19B:
			this.ac += 1U;
			return;
			IL_6F:
			A_0 = 0U;
			A_1 = this.k.GetMatches(this.y);
			num = (short)157024257;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
		private void c(uint A_0)
		{
			short num = (short)1117650944;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)794427393;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 1:
					goto IL_EA;
				case 2:
					return;
				}
				IL_58:
				num = (short)1223767838;
				short num3 = num;
				num = (short)1037973278;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_EA:
					this.k.Skip(A_0);
					this.ac += A_0;
					num = (short)2015166466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					break;
				default:
				{
					num = (short)899809280;
					short num4 = num;
					break;
				}
				}
				num = (short)1918238720;
				if (num != 0)
				{
				}
				if (A_0 <= 0U)
				{
					break;
				}
				num = (short)1235156993;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000DD24 File Offset: 0x0000BF24
		private uint a(global::SevenZip.Compression.LZMA.a.a A_0, uint A_1)
		{
			short num = (short)2123952762;
			short num2 = num;
			num = (short)1306980986;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1718616064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)181338113;
			if (num != 0)
			{
			}
			num = (short)243007488;
			if (num != 0)
			{
			}
			return this.o[(int)A_0.a].c() + this.r[(int)((A_0.a << 4) + A_1)].c();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000DE00 File Offset: 0x0000C000
		private uint a(uint A_0, global::SevenZip.Compression.LZMA.a.a A_1, uint A_2)
		{
			short num = (short)1341194244;
			int num2 = (int)((global::System.IntPtr)num);
			uint num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num3 += this.p[(int)A_1.a].c();
					num = (short)1782251525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_19F;
				case 2:
					goto IL_1ED;
				case 3:
					if (A_0 == 1U)
					{
						num = (short)588251136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 += this.p[(int)A_1.a].d();
					num3 += this.q[(int)A_1.a].b(A_0 - 2U);
					num = (short)2092892162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 5:
				{
					num = (short)933036033;
					if (num != 0)
					{
					}
					num = (short)1194215525;
					short num4 = num;
					num = (short)492718181;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11C;
					default:
						goto IL_EA;
					}
					break;
				}
				case 6:
					num3 = this.o[(int)A_1.a].c();
					num3 += this.r[(int)((A_1.a << 4) + A_2)].d();
					num = (short)429522945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_41:
				if (A_0 == 0U)
				{
					num = (short)990904326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num3 = this.o[(int)A_1.a].d();
				IL_11C:
				num = (short)1243086851;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EA:
			num = (short)1346371584;
			if (num != 0)
			{
			}
			IL_19F:
			IL_1ED:
			num = (short)609026048;
			short num5 = num;
			return num3;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000E028 File Offset: 0x0000C228
		private uint a(uint A_0, uint A_1, global::SevenZip.Compression.LZMA.a.a A_2, uint A_3)
		{
			short num = (short)1428934943;
			short num2 = num;
			num = (short)643485983;
			switch (num2 == num)
			{
			}
			num = (short)2015887360;
			short num3 = num;
			num = (short)1185021953;
			if (num != 0)
			{
			}
			num = (short)1910177792;
			if (num != 0)
			{
			}
			return this.w.a(A_1 - 2U, A_3) + this.a(A_0, A_2, A_3);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		private uint a(uint A_0, uint A_1, uint A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			uint num5;
			uint num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_102;
				case 1:
					goto IL_154;
				case 2:
				{
					num2 = (short)117775926;
					short num3 = num2;
					num2 = (short)132193846;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)170655744;
						if (num2 != 0)
						{
						}
						num4 = this.ah[(int)(num5 * 128U + A_0)];
						break;
					}
					num2 = (short)2013331456;
					short num6 = num2;
					num2 = (short)1771700225;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (A_0 < 128U)
					{
						num2 = (short)2055471106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num4 = this.ag[(int)((num5 << 6) + global::SevenZip.Compression.LZMA.Encoder.d(A_0))] + this.ai[(int)(A_0 & 15U)];
					num2 = (short)212008960;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_102:
			IL_154:
			return num4 + this.v.a(A_1 - 2U, A_2);
			IL_20:
			num2 = (short)1263927297;
			if (num2 != 0)
			{
			}
			num5 = global::SevenZip.Compression.LZMA.a.a(A_1);
			num2 = (short)1272053763;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000E25C File Offset: 0x0000C45C
		private uint a(out uint A_0, uint A_1)
		{
			short num = (short)1917583360;
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
				uint num3;
				uint num8;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						this.j[(int)num3].m();
						this.j[(int)num3].g = num3 - 1U;
						goto IL_15D;
					case 1:
					{
						num = (short)1886819042;
						short num4 = num;
						num = (short)1111790306;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15D;
						default:
							num = (short)354353152;
							if (num != 0)
							{
							}
							if (this.j[(int)A_1].b)
							{
								num = (short)1903362048;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_236;
						}
						break;
					}
					case 2:
						if (A_1 <= 0U)
						{
							num = (short)393019395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A6;
					case 3:
						goto IL_2AF;
					case 4:
					{
						this.j[(int)(num3 - 1U)].b = false;
						this.j[(int)(num3 - 1U)].g = this.j[(int)A_1].d;
						this.j[(int)(num3 - 1U)].h = this.j[(int)A_1].e;
						num = (short)117047296;
						short num5 = num;
						num = (short)171311111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)379191297;
						if (num != 0)
						{
						}
						goto IL_1A6;
					case 6:
						if (this.j[(int)A_1].c)
						{
							num = (short)1510211588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_236;
					case 7:
						goto IL_236;
					}
					goto IL_4E;
					IL_15D:
					num = (short)418381830;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A6:
					num = (short)1570373633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_236:
					uint num6 = num3;
					uint num7 = num8;
					num8 = this.j[(int)num6].h;
					num3 = this.j[(int)num6].g;
					this.j[(int)num6].h = num7;
					this.j[(int)num6].g = A_1;
					A_1 = num6;
					num = (short)307363842;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2AF:
				A_0 = this.j[0].h;
				this.ae = this.j[0].g;
				return this.ae;
				IL_4E:
				this.ad = A_1;
				num3 = this.j[(int)A_1].g;
				num8 = this.j[(int)A_1].h;
				num = (short)2136539141;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000E544 File Offset: 0x0000C744
		private uint a(uint A_0, out uint A_1)
		{
			short num = (short)1909129216;
			switch (num)
			{
			default:
			{
				num = (short)346882257;
				int num2 = (int)((global::System.IntPtr)num);
				uint num8;
				uint num15;
				uint num21;
				uint num22;
				uint num24;
				for (;;)
				{
					uint num3;
					uint num5;
					uint num6;
					global::SevenZip.Compression.LZMA.a.a a;
					byte indexByte;
					byte indexByte2;
					uint num9;
					uint num11;
					uint num12;
					global::SevenZip.Compression.LZMA.Encoder.e e2;
					uint num13;
					uint num14;
					uint num16;
					uint num17;
					uint num23;
					uint num26;
					uint num27;
					uint num28;
					uint num30;
					uint num35;
					global::SevenZip.Compression.LZMA.Encoder.e e5;
					uint num36;
					uint num37;
					uint num38;
					global::SevenZip.Compression.LZMA.Encoder.e e6;
					uint num40;
					uint num41;
					uint num43;
					global::SevenZip.Compression.LZMA.Encoder.e e7;
					uint num46;
					uint num51;
					uint num52;
					uint num54;
					switch (num2)
					{
					case 0:
						goto IL_C17;
					case 1:
						goto IL_130A;
					case 2:
						num = (short)1638137985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_20EE;
					case 4:
						if (num3 > 273U)
						{
							num = (short)1572864138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2021;
					case 5:
						goto IL_20B0;
					case 6:
					{
						uint num4;
						if (num4 < num5)
						{
							num = (short)753533012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B6;
					}
					case 7:
						goto IL_90B;
					case 8:
						if (num6 < 4U)
						{
							num = (short)1951465517;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a.d();
						num = (short)698810468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						uint num7 = this.j[(int)num8].f;
						indexByte = this.k.GetIndexByte(-1);
						indexByte2 = this.k.GetIndexByte((int)(0U - this.ay[0] - 1U - 1U));
						num9 = (A_0 & this.am);
						uint num10 = num7 + this.m[(int)((a.a << 4) + num9)].c() + this.x.a(A_0, this.k.GetIndexByte(-2)).a(!a.g(), indexByte2, indexByte);
						global::SevenZip.Compression.LZMA.Encoder.e e = this.j[(int)(num8 + 1U)];
						bool flag = false;
						if (num10 < e.f)
						{
							e.f = num10;
							e.g = num8;
							e.m();
							flag = true;
						}
						num11 = num7 + this.m[(int)((a.a << 4) + num9)].d();
						num12 = num11 + this.n[(int)a.a].d();
						num = (short)1651703935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						e2.f = num13;
						e2.g = 0U;
						e2.h = num14;
						e2.b = false;
						num = (short)1145044997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (num15 >= this.z)
						{
							num = (short)176160945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_0 += 1U;
						num16 = this.j[(int)num8].g;
						num = (short)1153826967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_3B5;
					case 13:
						num = (short)1618870334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (num17 < 2U)
						{
							num = (short)336920752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B08;
					case 15:
					{
						global::SevenZip.Compression.LZMA.a.a a2 = a;
						a2.c();
						uint num18 = A_0 + 1U & this.am;
						uint num10;
						uint num19 = num10 + this.m[(int)((a2.a << 4) + num18)].d() + this.n[(int)a2.a].d();
						uint matchLen;
						uint num20 = num8 + 1U + matchLen;
						num = (short)1585840267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num = (short)1762787426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (this.j[(int)num8].o())
						{
							num = (short)299630668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a.c();
						num = (short)373489714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						uint matchLen2;
						if (matchLen2 >= 2U)
						{
							num = (short)1104150656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240E;
					}
					case 19:
						goto IL_F63;
					case 20:
						if (num16 == num8 - 1U)
						{
							num = (short)1339031727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2145058869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (num21 < this.az[(int)num22])
						{
							num = (short)1107623949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1520894017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_2A53;
					case 23:
						goto IL_2B18;
					case 24:
						goto IL_15E9;
					case 25:
						if (num23 != num24)
						{
							num = (short)176160791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C17;
					case 26:
						goto IL_1AE3;
					case 27:
					{
						global::SevenZip.Compression.LZMA.Encoder.e e3;
						uint num25;
						e3.f = num25;
						e3.g = num8 + 1U;
						e3.h = 0U;
						e3.b = true;
						e3.c = false;
						num = (short)1251279013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						goto IL_21B6;
					case 29:
						goto IL_187A;
					case 30:
						goto IL_1B5A;
					case 31:
						if (num26 < num5)
						{
							num = (short)566689830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240E;
					case 32:
						if (num26 == this.y[(int)num23])
						{
							num = (short)1035468966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B18;
					case 33:
						num = (short)869728438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_164D;
					case 35:
						goto IL_5BF;
					case 36:
						if (this.az[(int)num22] < 2U)
						{
							num = (short)1476198491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B6;
					case 37:
						a.e();
						num = (short)1514995738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						uint limit = global::System.Math.Min(num5 - 1U - num26, this.z);
						uint matchLen2 = this.k.GetMatchLen((int)num26, num27, limit);
						num = (short)962527250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						goto IL_823;
					case 40:
						num = (short)1464991848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_823;
					case 42:
						goto IL_214D;
					case 43:
						goto IL_1C8D;
					case 44:
						if (num14 >= 4U)
						{
							num = (short)1105985673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ay[(int)num14] = this.e[(int)num14];
						this.az[(int)num14] = this.k.GetMatchLen(-1, this.ay[(int)num14], 273U);
						num = (short)765591669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						a.e();
						num = (short)85065921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (this.j[(int)num8].c)
						{
							num = (short)1379926149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a = this.j[(int)num16].a;
						num = (short)570032210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_E59;
					case 48:
						if (num21 >= this.z)
						{
							num = (short)949616842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						indexByte = this.k.GetIndexByte(-1);
						indexByte2 = this.k.GetIndexByte((int)(0U - this.e[0] - 1U - 1U));
						num = (short)670433348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num28 = this.az[0] + 1U;
						goto IL_27CC;
					case 50:
						goto IL_5BF;
					case 51:
						goto IL_C56;
					case 52:
					{
						uint num29;
						this.j[1].f = num29;
						this.j[1].n();
						num = (short)734724231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						if (this.j[(int)num8].b)
						{
							num = (short)52494338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA4;
					case 54:
						goto IL_2810;
					case 55:
						num26 = num30;
						num = (short)1591541790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						goto IL_2A9A;
					case 57:
						goto IL_5BF;
					case 58:
					{
						uint num32;
						uint matchLen3;
						global::SevenZip.Compression.LZMA.a.a a3;
						uint num33;
						uint num31 = num32 + this.a(0U, matchLen3, a3, num33);
						uint num34;
						global::SevenZip.Compression.LZMA.Encoder.e e4 = this.j[(int)(num8 + num34)];
						num = (short)1734279362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
					{
						uint matchLen;
						if (matchLen >= 2U)
						{
							num = (short)196214799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_223E;
					}
					case 60:
						num23 = 0U;
						num = (short)1093206058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						goto IL_2044;
					case 62:
						num35 = this.az[(int)num22];
						goto IL_1C51;
					case 63:
						this.ay[0] = e5.i;
						this.ay[1] = e5.j;
						this.ay[2] = e5.k;
						this.ay[3] = e5.l;
						num = (short)27590777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						if (this.j[(int)num8].e < 4U)
						{
							num = (short)303890469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a.d();
						num = (short)646709325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						num35 = num21;
						goto IL_1C51;
					case 66:
					{
						global::SevenZip.Compression.LZMA.Encoder.e e;
						if (e.h != 0U)
						{
							num = (short)1430257832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29CF;
					}
					case 67:
						num = (short)997589188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						if (num21 < 2U)
						{
							num = (short)1077084176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B6;
					case 69:
						goto IL_198A;
					case 70:
						goto IL_187A;
					case 71:
						if (num6 == 2U)
						{
							num = (short)411369657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ay[0] = e5.l;
						this.ay[1] = e5.i;
						this.ay[2] = e5.j;
						this.ay[3] = e5.k;
						num = (short)686620707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						goto IL_1702;
					case 73:
						goto IL_5BF;
					case 74:
						goto IL_1B5A;
					case 75:
						num36 = num11 + this.n[(int)a.a].c();
						num = (short)396951576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						a.f();
						num = (short)154927177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						goto IL_1AE3;
					case 78:
						goto IL_2454;
					case 79:
						if (this.az[(int)num22] >= this.z)
						{
							num = (short)249102491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1390018608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						if (num37 < 2U)
						{
							num = (short)910426155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.j[1].g = 0U;
						this.j[0].i = this.ay[0];
						this.j[0].j = this.ay[1];
						this.j[0].k = this.ay[2];
						this.j[0].l = this.ay[3];
						num17 = num37;
						num = (short)1117978795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						goto IL_240E;
					case 82:
						goto IL_1AE3;
					case 83:
						if (num15 > num3)
						{
							num = (short)1141112976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1702;
					case 84:
					{
						uint num4;
						uint limit2 = global::System.Math.Min(num5 - 1U - num4, this.z);
						uint matchLen3 = this.k.GetMatchLen((int)num4, this.ay[(int)num38], limit2);
						num = (short)750125255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
						num36 = num11 + this.n[(int)this.c.a].c();
						num = (short)1932263511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
					{
						uint num29;
						if (num29 < this.j[1].f)
						{
							num = (short)1286340660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E9F;
					}
					case 87:
					{
						num = (short)1076232192;
						short num39 = num;
						if (this.az[0] < 2U)
						{
							num = (short)759955489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)897581105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 88:
					{
						uint num4;
						num30 = num4 + 1U;
						num = (short)1492254809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 89:
						goto IL_1F70;
					case 90:
						if (num15 <= this.y[(int)num24])
						{
							num = (short)1861156986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num24 += 2U;
						num = (short)1622737054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						goto IL_27A6;
					case 92:
						e6.f = num40;
						e6.g = 0U;
						e6.h = num41 + 4U;
						e6.b = false;
						num = (short)1618083887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
					{
						uint num4;
						uint num42 = num4;
						num = (short)197460092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 94:
						goto IL_23C6;
					case 95:
					{
						if (num38 >= 4U)
						{
							num = (short)1893400743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num4 = this.k.GetMatchLen(-1, this.ay[(int)num38], num3);
						num = (short)185860291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 96:
						if (num43 < e7.f)
						{
							num = (short)657064039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23C6;
					case 97:
						goto IL_2021;
					case 98:
						if (indexByte != indexByte2)
						{
							num = (short)365494479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B6;
					case 99:
						num = (short)506986621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						goto IL_164D;
					case 101:
						if (num30 <= this.y[(int)num23])
						{
							num = (short)649068599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num23 += 2U;
						num = (short)261685353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
					{
						uint num4;
						uint num44 = num12 + this.a(num38, num4, a, num9);
						global::SevenZip.Compression.LZMA.Encoder.e e8 = this.j[(int)(num8 + num4)];
						num = (short)559874221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 103:
						e7.f = num43;
						e7.g = num8;
						e7.h = num27 + 4U;
						e7.b = false;
						num = (short)2035155038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
						if (num6 == 0U)
						{
							num = (short)493355071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)511705291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						goto IL_214D;
					case 106:
					{
						num = (short)1640281360;
						short num45 = num;
						num = (short)587445520;
						switch ((num45 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_20EE;
						default:
							num = (short)842072064;
							if (num != 0)
							{
							}
							this.ay[0] = e5.j;
							this.ay[1] = e5.i;
							this.ay[2] = e5.k;
							this.ay[3] = e5.l;
							num = (short)570753081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 107:
						if (num15 >= num30)
						{
							num = (short)2038956107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C17;
					case 108:
						goto IL_90B;
					case 109:
						if (num13 < e2.f)
						{
							num = (short)952565770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20B0;
					case 110:
						goto IL_22E6;
					case 111:
						e7.f = num43;
						e7.g = num8 + num26 + 1U;
						e7.h = 0U;
						e7.b = true;
						e7.c = true;
						e7.d = num8;
						e7.e = num27 + 4U;
						num = (short)363593809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 112:
					{
						uint num44;
						global::SevenZip.Compression.LZMA.Encoder.e e8;
						e8.f = num44;
						e8.g = num8;
						e8.h = num38;
						e8.b = false;
						num = (short)229572800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 113:
						num = (short)121700467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						this.a(out num21, out num24);
						num = (short)61931521;
						if (num != 0)
						{
						}
						num = (short)447283308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						if (indexByte2 != indexByte)
						{
							num = (short)1572012216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_223E;
					case 116:
						num16 -= 1U;
						num = (short)1681326126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 117:
						if (this.az[(int)num14] > this.az[(int)num22])
						{
							num = (short)1318781082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1283;
					case 118:
					{
						global::SevenZip.Compression.LZMA.Encoder.e e;
						e.f = num46;
						e.g = num8;
						e.n();
						bool flag = true;
						num = (short)1254490254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 119:
						if (num17 <= num21)
						{
							num = (short)361824386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28DC;
					case 120:
						num3 = this.z;
						num = (short)1334706232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						goto IL_5BF;
					case 122:
						this.y[(int)num24] = num15;
						num24 += 2U;
						num = (short)1661993032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
					{
						global::SevenZip.Compression.LZMA.a.a a2;
						uint num18;
						uint num19;
						uint matchLen;
						uint num25 = num19 + this.a(0U, matchLen, a2, num18);
						uint num20;
						global::SevenZip.Compression.LZMA.Encoder.e e3 = this.j[(int)num20];
						num = (short)1169817750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 124:
						goto IL_1839;
					case 125:
					{
						global::SevenZip.Compression.LZMA.Encoder.e e;
						if (e.g < num8)
						{
							num = (short)1958412431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18B7;
					}
					case 126:
						goto IL_EE4;
					case 127:
						if (indexByte2 == indexByte)
						{
							num = (short)1273430115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29CF;
					case 128:
					{
						global::SevenZip.Compression.LZMA.a.a a4 = a;
						a4.d();
						uint num47 = A_0 + num26 & this.am;
						uint num48 = num43 + this.m[(int)((a4.a << 4) + num47)].c() + this.x.a(A_0 + num26, this.k.GetIndexByte((int)(num26 - 1U - 1U))).a(true, this.k.GetIndexByte((int)(num26 - (num27 + 1U) - 1U)), this.k.GetIndexByte((int)(num26 - 1U)));
						a4.c();
						num47 = (A_0 + num26 + 1U & this.am);
						uint num49 = num48 + this.m[(int)((a4.a << 4) + num47)].d() + this.n[(int)a4.a].d();
						uint matchLen2;
						uint num50 = num26 + 1U + matchLen2;
						num = (short)25755717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 129:
						if (this.j[(int)num8].c)
						{
							num = (short)1556611228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA4;
					case 130:
						num51 = 0U;
						num = (short)254279881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 131:
					{
						uint num31;
						global::SevenZip.Compression.LZMA.Encoder.e e4;
						e4.f = num31;
						uint num4;
						e4.g = num8 + num4 + 1U;
						e4.h = 0U;
						e4.b = true;
						e4.c = true;
						e4.d = num8;
						e4.e = num38;
						num = (short)1206911004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 132:
						goto IL_198A;
					case 133:
						a = this.j[(int)this.j[(int)num8].d].a;
						num = (short)1988821056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						if (num3 >= 2U)
						{
							num = (short)548405315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C17;
					case 135:
						goto IL_E9F;
					case 136:
					{
						uint num4;
						if (num37 >= num8 + num4)
						{
							num = (short)2137718886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.j[(int)(num37 += 1U)].f = 268435455U;
						num = (short)268042426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 137:
						num = (short)188940367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 138:
						num3 = 273U;
						num = (short)1672020065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 139:
						goto IL_EE4;
					case 140:
						goto IL_130A;
					case 141:
						if (num51 != num24)
						{
							num = (short)2143092814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28DC;
					case 142:
						goto IL_29CF;
					case 143:
						num = (short)1332412482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 144:
						num15 = num3;
						num24 = 0U;
						num = (short)1865285742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 145:
						if (num40 < e6.f)
						{
							num = (short)776208476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E59;
					case 146:
					{
						uint num4;
						if ((num4 -= 1U) < 2U)
						{
							num = (short)338428095;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1839;
					}
					case 147:
						if (num37 >= num8 + num15)
						{
							num = (short)2010447932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.j[(int)(num37 += 1U)].f = 268435455U;
						num = (short)1174274217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 148:
						if (indexByte2 == indexByte)
						{
							num = (short)219807907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E9F;
					case 149:
						if (num14 >= 4U)
						{
							num = (short)1112473685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num52 = this.az[(int)num14];
						num = (short)594018468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 150:
					{
						global::SevenZip.Compression.LZMA.Encoder.e e3;
						uint num25;
						if (num25 < e3.f)
						{
							num = (short)1348796443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_223E;
					}
					case 151:
						if (this.j[(int)num8].b)
						{
							num = (short)378077300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a = this.j[(int)num16].a;
						num = (short)2071134387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 152:
						if (num38 == 0U)
						{
							num = (short)532283480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F70;
					case 153:
						goto IL_952;
					case 154:
						num22 = num14;
						num = (short)1683488973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 155:
						goto IL_5BA;
					case 156:
						num16 = this.j[(int)num8].d;
						num6 = this.j[(int)num8].e;
						a.e();
						num = (short)955318306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 157:
					{
						uint matchLen2;
						global::SevenZip.Compression.LZMA.a.a a4;
						uint num47;
						uint num49;
						num43 = num49 + this.a(0U, matchLen2, a4, num47);
						uint num50;
						e7 = this.j[(int)(num8 + num50)];
						num = (short)1037697232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 158:
						goto IL_22E6;
					case 159:
					{
						global::SevenZip.Compression.LZMA.a.a a3 = a;
						a3.e();
						uint num4;
						uint num33 = A_0 + num4 & this.am;
						uint num53 = num12 + this.a(num38, num4, a, num9) + this.m[(int)((a3.a << 4) + num33)].c() + this.x.a(A_0 + num4, this.k.GetIndexByte((int)(num4 - 1U - 1U))).a(true, this.k.GetIndexByte((int)(num4 - 1U - (this.ay[(int)num38] + 1U))), this.k.GetIndexByte((int)(num4 - 1U)));
						a3.c();
						num33 = (A_0 + num4 + 1U & this.am);
						uint num32 = num53 + this.m[(int)((a3.a << 4) + num33)].d() + this.n[(int)a3.a].d();
						uint matchLen3;
						uint num34 = num4 + 1U + matchLen3;
						num = (short)127533097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 160:
					{
						global::SevenZip.Compression.LZMA.Encoder.e e;
						if (num46 <= e.f)
						{
							num = (short)1309081718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29CF;
					}
					case 161:
						num54 = num12 + this.a(num14, this.c, num9);
						num = (short)1523187766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 162:
						if (num8 == num37)
						{
							num = (short)376766515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(out num15, out num24);
						num = (short)1667432459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 163:
					{
						uint num29 = num12 + this.a(this.c, num9);
						num = (short)743309398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 164:
						if (num52 >= 2U)
						{
							num = (short)2134769825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A80;
					case 165:
						goto IL_223E;
					case 166:
						num = (short)1324679199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 167:
						num = (short)796524627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 168:
						goto IL_18B7;
					case 169:
						goto IL_15E9;
					case 170:
						if (num3 < 2U)
						{
							num = (short)1900347545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1653342212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 171:
						goto IL_1B08;
					case 172:
						if ((num52 -= 1U) < 2U)
						{
							num = (short)1331757059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2810;
					case 173:
					{
						uint num44;
						global::SevenZip.Compression.LZMA.Encoder.e e8;
						if (num44 < e8.f)
						{
							num = (short)1872035952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_232B;
					}
					case 174:
					{
						uint num20;
						if (num37 >= num20)
						{
							num = (short)660799611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.j[(int)(num37 += 1U)].f = 268435455U;
						num = (short)1085997182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 175:
						num = (short)1128071185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 176:
						num14 = 0U;
						num = (short)615448646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 177:
						goto IL_906;
					case 178:
						goto IL_5BF;
					case 179:
						goto IL_F63;
					case 180:
						if (num17 == this.y[(int)num51])
						{
							num = (short)101908661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2454;
					case 181:
						num51 += 2U;
						num = (short)1082851469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 182:
						num28 = 2U;
						goto IL_27CC;
					case 183:
						goto IL_1C13;
					case 184:
					{
						uint limit3 = global::System.Math.Min(num5 - 1U, this.z);
						uint matchLen = this.k.GetMatchLen(0, this.ay[0], limit3);
						num = (short)1046806587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 185:
						this.ay[0] = e5.k;
						this.ay[1] = e5.i;
						this.ay[2] = e5.j;
						this.ay[3] = e5.l;
						num = (short)918356146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 186:
						goto IL_1839;
					case 187:
					{
						uint num50;
						if (num37 >= num8 + num50)
						{
							num = (short)334495901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.j[(int)(num37 += 1U)].f = 268435455U;
						num = (short)1390280836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 188:
						if (num6 < 4U)
						{
							num = (short)1837826088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ay[0] = num6 - 4U;
						this.ay[1] = e5.i;
						this.ay[2] = e5.j;
						this.ay[3] = e5.k;
						num = (short)691994828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 189:
						if (num17 <= this.y[(int)num51])
						{
							num = (short)1464926398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num51 += 2U;
						num = (short)193921046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 190:
						goto IL_2044;
					case 191:
					{
						uint num42;
						uint num4 = num42;
						num = (short)320012440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 192:
						goto IL_232B;
					case 193:
						goto IL_164D;
					case 194:
					{
						uint num31;
						global::SevenZip.Compression.LZMA.Encoder.e e4;
						if (num31 < e4.f)
						{
							num = (short)771424387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B6;
					}
					case 195:
					{
						uint num4;
						if (num4 >= 2U)
						{
							num = (short)2130903133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B6;
					}
					case 196:
						if (num3 > this.z)
						{
							num = (short)1224933496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A9A;
					case 197:
						goto IL_1C13;
					case 198:
					{
						uint num34;
						if (num37 >= num8 + num34)
						{
							num = (short)414122042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.j[(int)(num37 += 1U)].f = 268435455U;
						num = (short)113836071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 199:
					{
						uint matchLen3;
						if (matchLen3 >= 2U)
						{
							num = (short)823722143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B6;
					}
					case 200:
						if (!this.af)
						{
							num = (short)346488946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num21 = this.aa;
						num24 = this.ab;
						this.af = false;
						num = (short)688193543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 201:
						goto IL_2A53;
					case 202:
						goto IL_25BF;
					case 203:
						if (num6 == 1U)
						{
							num = (short)1384841322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1073086535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 204:
						goto IL_5BF;
					case 205:
						goto IL_1283;
					case 206:
					{
						bool flag;
						if (!flag)
						{
							num = (short)801505393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_223E;
					}
					case 207:
						num = (short)49348644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 208:
						if (num43 < e7.f)
						{
							num = (short)897187951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240E;
					case 209:
						switch (0)
						{
						case 0:
							goto IL_38C;
						}
						continue;
					}
					IL_38C:
					if (this.ad != this.ae)
					{
						num = (short)1565327372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.ae = (this.ad = 0U);
					num = (short)1268187336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5BF:
					this.j[(int)num8].a = a;
					this.j[(int)num8].i = this.ay[0];
					this.j[(int)num8].j = this.ay[1];
					this.j[(int)num8].k = this.ay[2];
					this.j[(int)num8].l = this.ay[3];
					num = (short)877002761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_823:
					num = (short)22675654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_90B:
					num3 = this.k.GetNumAvailableBytes() + 1U;
					num = (short)763756714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9B6:
					this.j[0].a = this.c;
					num9 = (A_0 & this.am);
					this.j[1].f = this.m[(int)((this.c.a << 4) + num9)].c() + this.x.a(A_0, this.d).a(!this.c.g(), indexByte2, indexByte);
					this.j[1].m();
					num11 = this.m[(int)((this.c.a << 4) + num9)].d();
					num12 = num11 + this.n[(int)this.c.a].d();
					num = (short)133890196;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C17:
					num8 += 1U;
					num = (short)1460076706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E59:
					num = (short)962855092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E9F:
					num = (short)208404501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EE4:
					num = (short)1153826990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F63:
					num = (short)1793851412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FA4:
					num6 = this.j[(int)num8].h;
					num = (short)1673986056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1283:
					num14 += 1U;
					num = (short)364970167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_130A:
					num = (short)174129247;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E9:
					num = (short)1404240019;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_164D:
					e5 = this.j[(int)num16];
					num = (short)1016987836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1702:
					num = (short)1155989611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1839:
					num = (short)1509163144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_187A:
					num = (short)1487929493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18B7:
					num46 = num12 + this.a(a, num9);
					num = (short)154992800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_198A:
					num = (short)696975547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A80:
					num14 += 1U;
					num = (short)1295450141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20EE:
					goto IL_1A80;
					IL_1AE3:
					a.c();
					num = (short)965410835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B08:
					this.j[(int)num17--].f = 268435455U;
					num = (short)1179648014;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B5A:
					num27 = this.y[(int)(num23 + 1U)];
					num43 = num36 + this.a(num27, num26, num9);
					e7 = this.j[(int)(num8 + num26)];
					num = (short)1581645920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C13:
					num = (short)1480392748;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C51:
					num37 = num35;
					num = (short)1914044496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F70:
					num = (short)2061107206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2021:
					num22 = 0U;
					num14 = 0U;
					num = (short)863633605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2044:
					num41 = this.y[(int)(num51 + 1U)];
					num40 = num36 + this.a(num41, num17, num9);
					e6 = this.j[(int)num17];
					num = (short)1802502289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20B0:
					num = (short)96403628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_214D:
					num = (short)851050597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21B6:
					num38 += 1U;
					num = (short)1631453324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_223E:
					num30 = 2U;
					num38 = 0U;
					num = (short)2034106369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22E6:
					num = (short)11075674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_232B:
					num = (short)1861353618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23C6:
					num = (short)58851360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_240E:
					num23 += 2U;
					num = (short)2088173593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2454:
					num17 += 1U;
					num = (short)1762656317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27CC:
					num17 = num28;
					num = (short)1965686903;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2810:
					num13 = num54 + this.w.a(num52 - 2U, num9);
					e2 = this.j[(int)num52];
					num = (short)416743533;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28DC:
					num8 = 0U;
					num = (short)1438515200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29CF:
					num5 = this.k.GetNumAvailableBytes() + 1U;
					num5 = global::System.Math.Min(4095U - num8, num5);
					num3 = num5;
					num = (short)412352646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A53:
					num = (short)1344143549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A9A:
					num = (short)690553038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B18:
					num26 += 1U;
					num = (short)149618762;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3B5:
				uint result = this.j[(int)this.ae].g - this.ae;
				A_1 = this.j[(int)this.ae].h;
				this.ae = this.j[(int)this.ae].g;
				return result;
				IL_5BA:
				A_1 = num22;
				uint num55 = this.az[(int)num22];
				this.c(num55 - 1U);
				return num55;
				IL_906:
				this.ab = num24;
				this.aa = num15;
				this.af = true;
				return this.a(out A_1, num8);
				IL_952:
				A_1 = uint.MaxValue;
				return 1U;
				IL_C56:
				return this.a(out A_1, num8);
				IL_1C8D:
				A_1 = this.j[1].h;
				return 1U;
				IL_25BF:
				A_1 = this.y[(int)(num24 - 1U)] + 4U;
				this.c(num21 - 1U);
				return num21;
				IL_27A6:
				A_1 = uint.MaxValue;
				return 1U;
			}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00011090 File Offset: 0x0000F290
		private bool a(uint A_0, uint A_1)
		{
			if (A_0 < 33554432U)
			{
				short num = (short)2119355073;
				short num2 = num;
				num = (short)621923009;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)76808193;
					if (num != 0)
					{
					}
					num = (short)13238272;
					if (num != 0)
					{
					}
					num = (short)667025408;
					short num3 = num;
					break;
				}
				}
				return A_1 >= A_0 << 7;
			}
			return false;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00011150 File Offset: 0x0000F350
		private void b(uint A_0)
		{
			if (!this.aw)
			{
				short num = (short)1418709685;
				short num2 = num;
				num = (short)17091253;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1187708929;
					if (num != 0)
					{
					}
					num = (short)328400896;
					if (num != 0)
					{
					}
					num = (short)1000865792;
					short num3 = num;
					break;
				}
				}
				return;
			}
			this.m[(int)((this.c.a << 4) + A_0)].a(this.l, 1U);
			this.n[(int)this.c.a].a(this.l, 0U);
			this.c.d();
			uint num4 = 2U;
			this.v.a(this.l, num4 - 2U, A_0);
			uint a_ = 63U;
			uint num5 = global::SevenZip.Compression.LZMA.a.a(num4);
			this.s[(int)num5].a(this.l, a_);
			int num6 = 30;
			uint num7 = (1U << num6) - 1U;
			this.l.a(num7 >> 4, num6 - 4);
			this.u.b(this.l, num7 & 15U);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000112C8 File Offset: 0x0000F4C8
		private void a(uint A_0)
		{
			short num = (short)1264780918;
			short num2 = num;
			num = (short)983500406;
			switch (num2 == num)
			{
			}
			num = (short)717094912;
			if (num != 0)
			{
			}
			num = (short)322830336;
			short num3 = num;
			num = (short)1946746881;
			if (num != 0)
			{
			}
			this.e();
			this.b(A_0 & this.am);
			this.l.e();
			this.l.f();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0001139C File Offset: 0x0000F59C
		public void CodeOneBlock(out long inSize, out long outSize, out bool finished)
		{
			short num = (short)122552320;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_146;
				}
				for (;;)
				{
					IL_27:
					uint num3;
					byte indexByte;
					uint num8;
					uint num10;
					uint num12;
					uint num14;
					uint num18;
					uint num20;
					switch (num2)
					{
					case 0:
						goto IL_C7D;
					case 1:
					{
						this.m[(int)num3].a(this.l, 0U);
						indexByte = this.k.GetIndexByte((int)(0U - this.ac));
						global::SevenZip.Compression.LZMA.Encoder.b.a a = this.x.a((uint)this.@as, this.d);
						num = (short)540409869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1CE;
					case 3:
						if (this.@as == 0L)
						{
							num = (short)1346502712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_77C;
					case 4:
					{
						uint num4;
						if (num4 >= 4U)
						{
							num = (short)235864069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C58;
					}
					case 5:
					{
						uint num4;
						int num5 = (int)((num4 >> 1) - 1U);
						uint num6 = (2U | (num4 & 1U)) << num5;
						uint num7 = num8 - num6;
						num = (short)1601044502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_74A;
					case 7:
						return;
					case 8:
						goto IL_77C;
					case 9:
						this.c.f();
						num = (short)1663959072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_C53;
					case 11:
						goto IL_C7D;
					case 12:
						if (this.au != null)
						{
							num = (short)1129775149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1A;
					case 13:
					{
						if (!this.c.g())
						{
							num = (short)175571013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SevenZip.Compression.LZMA.Encoder.b.a a;
						a.a(this.l, indexByte);
						num = (short)812515334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_A28;
					case 15:
						goto IL_E47;
					case 16:
						num = (short)1194786868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (num8 == 1U)
						{
							num = (short)1179582508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.p[(int)this.c.a].a(this.l, 1U);
						this.q[(int)this.c.a].a(this.l, num8 - 2U);
						num = (short)418250801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						if (this.at)
						{
							num = (short)14286855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.at = true;
						long num9 = this.@as;
						num = (short)1881931779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						this.e[0] = num10;
						num = (short)523698210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						uint num11 = num8;
						num = (short)986775610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						this.r[(int)num3].a(this.l, 0U);
						num = (short)843972619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						uint num4;
						if (num4 < 14U)
						{
							num = (short)2075328567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5;
						uint num7;
						this.l.a(num7 >> 4, num5 - 4);
						this.u.b(this.l, num7 & 15U);
						this.aj += 1U;
						num = (short)1724055595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_A28;
					case 24:
						if (num12 == 1U)
						{
							num = (short)1213792320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F9;
					case 25:
						goto IL_287;
					case 26:
						goto IL_7BD;
					case 27:
						if (this.k.GetNumAvailableBytes() == 0U)
						{
							num = (short)1637613594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_216;
					case 28:
						this.o[(int)this.c.a].a(this.l, 0U);
						num = (short)152830013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						if (num8 == 0U)
						{
							num = (short)1583087644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)566296576;
						short num13 = num;
						this.o[(int)this.c.a].a(this.l, 1U);
						num = (short)1102643217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						if (this.aj >= 16U)
						{
							num = (short)1556938790;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B57;
					case 31:
						goto IL_B1A;
					case 32:
						goto IL_1CE;
					case 33:
						goto IL_74A;
					case 34:
						goto IL_287;
					case 35:
						if (num12 == 1U)
						{
							num = (short)1822425097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.w.a(this.l, num12 - 2U, num14);
						this.c.e();
						num = (short)944898050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (num8 != 0U)
						{
							num = (short)1878589460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_287;
					case 37:
						goto IL_C58;
					case 38:
						this.a();
						num = (short)1806303289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_BAC;
					case 40:
						if (num8 == 4294967295U)
						{
							num = (short)753139713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F9;
					case 41:
						this.k.Skip(this.a5);
						num = (short)1613430815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
					{
						long num9;
						if (this.@as - num9 >= 4096L)
						{
							num = (short)1771634742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_216;
					}
					case 43:
						goto IL_C58;
					case 44:
						this.p[(int)this.c.a].a(this.l, 0U);
						goto IL_A89;
					case 45:
						this.k.SetStream(this.au);
						this.k.Init();
						this.ax = true;
						this.au = null;
						num = (short)1934360629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
					{
						if (this.k.GetNumAvailableBytes() == 0U)
						{
							num = (short)492044298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num15;
						uint num16;
						this.a(out num15, out num16);
						uint num17 = (uint)this.@as & this.am;
						this.m[(int)((this.c.a << 4) + num17)].a(this.l, 0U);
						this.c.c();
						byte indexByte2 = this.k.GetIndexByte((int)(0U - this.ac));
						this.x.a((uint)this.@as, this.d).a(this.l, indexByte2);
						this.d = indexByte2;
						this.ac -= 1U;
						this.@as += 1L;
						num = (short)181993480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						goto IL_32C;
					case 48:
						if (num18 < 1U)
						{
							num = (short)1656422460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e[(int)num18] = this.e[(int)(num18 - 1U)];
						num18 -= 1U;
						num = (short)774635534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						num = (short)1214456523;
						short num19 = num;
						num = (short)903488203;
						switch ((num19 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A89;
						default:
							num = (short)1255538688;
							if (num != 0)
							{
							}
							goto IL_C7D;
						}
						break;
					}
					case 50:
						if (this.ac == 0U)
						{
							num = (short)1496645648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_216;
					case 51:
						goto IL_709;
					case 52:
						if (this.a3 >= 128U)
						{
							num = (short)1351745603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					case 53:
						num = (short)1408237569;
						if (num != 0)
						{
						}
						if (this.a5 > 0U)
						{
							num = (short)655884329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1A;
					case 54:
						goto IL_D8E;
					case 55:
					{
						uint num4;
						int num5;
						uint num6;
						uint num7;
						global::SevenZip.Compression.RangeCoder.e.a(this.t, num6 - num4 - 1U, this.l, num5, num7);
						num = (short)1086849061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						num = (short)1802436654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_B57;
					case 58:
						goto IL_709;
					case 59:
					{
						uint num11;
						if (num11 < 1U)
						{
							num = (short)1934819347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e[(int)num11] = this.e[(int)(num11 - 1U)];
						num11 -= 1U;
						num = (short)1408630835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						this.e[0] = num20;
						this.a3 += 1U;
						num = (short)871628825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						if (num12 == 1U)
						{
							num = (short)1777795093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.r[(int)num3].a(this.l, 1U);
						num = (short)2036269056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						goto IL_C7D;
					case 63:
						this.n[(int)this.c.a].a(this.l, 1U);
						num = (short)990904349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						num = (short)58589224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_E47;
					case 66:
					{
						if (num8 < 4U)
						{
							num = (short)371785791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.n[(int)this.c.a].a(this.l, 0U);
						this.c.d();
						this.v.a(this.l, num12 - 2U, num14);
						num8 -= 4U;
						uint num4 = global::SevenZip.Compression.LZMA.Encoder.e(num8);
						uint num21 = global::SevenZip.Compression.LZMA.a.a(num12);
						this.s[(int)num21].a(this.l, num4);
						num = (short)1389821956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 67:
						this.b();
						num = (short)492961839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						if (this.k.GetNumAvailableBytes() == 0U)
						{
							num = (short)559611943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)475463722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
					{
						byte indexByte3 = this.k.GetIndexByte((int)(0U - this.e[0] - 1U - this.ac));
						global::SevenZip.Compression.LZMA.Encoder.b.a a;
						a.a(this.l, indexByte3, indexByte);
						num = (short)978649121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_146;
					IL_1CE:
					num10 = this.e[(int)num8];
					num = (short)1235091492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_216:
					num12 = this.a((uint)this.@as, out num8);
					num14 = ((uint)this.@as & this.am);
					num3 = (this.c.a << 4) + num14;
					num = (short)97452056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_287:
					this.d = this.k.GetIndexByte((int)(num12 - 1U - this.ac));
					num = (short)122093633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32C:
					num = (short)1704263710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_709:
					num = (short)679149627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74A:
					this.d = indexByte;
					this.c.c();
					num = (short)1731264527;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_77C:
					num = (short)1679753243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F9:
					this.m[(int)num3].a(this.l, 1U);
					num = (short)1789067330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A28:
					num = (short)456196144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A89:
					num = (short)582352958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B1A:
					num = (short)1322123282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B57:
					inSize = this.@as;
					outSize = this.l.i();
					num = (short)472907844;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C58:
					num20 = num8;
					num18 = 3U;
					num = (short)734330903;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C7D:
					num = (short)1221525539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E47:
					this.ac -= num12;
					this.@as += (long)((ulong)num12);
					num = (short)226558002;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7BD:
				this.a((uint)this.@as);
				return;
				IL_BAC:
				this.a((uint)this.@as);
				return;
				IL_C53:
				this.a((uint)this.@as);
				return;
				IL_D8E:
				this.at = false;
				finished = false;
				return;
				IL_146:
				inSize = 0L;
				outSize = 0L;
				finished = true;
				num = (short)1888944140;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00012334 File Offset: 0x00010534
		private void e()
		{
			short num = (short)105906176;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1107427328;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_15;
				case 1:
					return;
				case 2:
					if (this.ax)
					{
						num = (short)700055556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)1536622594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.k.ReleaseStream();
					this.ax = false;
					num = (short)1825701889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_62;
				IL_15:
				switch (0)
				{
				case 0:
				{
					IL_62:
					if (this.k == null)
					{
						return;
					}
					num = (short)623747178;
					short num4 = num;
					num = (short)1642963050;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)1715798016;
						if (num != 0)
						{
						}
						num = (short)2010906625;
						if (num != 0)
						{
						}
						num = (short)1200553987;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000124A0 File Offset: 0x000106A0
		private void a(global::System.IO.Stream A_0)
		{
			short num = (short)1393885184;
			short num2 = num;
			num = (short)1741524676;
			short num3 = num;
			num = (short)385912516;
			switch (num3 == num)
			{
			}
			num = (short)652214273;
			if (num != 0)
			{
			}
			num = (short)924188672;
			if (num != 0)
			{
			}
			this.l.a(A_0);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00012554 File Offset: 0x00010754
		private void d()
		{
			short num = (short)1042808832;
			short num2 = num;
			num = (short)418145398;
			short num3 = num;
			num = (short)581919862;
			switch (num3 == num)
			{
			}
			num = (short)27721729;
			if (num != 0)
			{
			}
			num = (short)970391552;
			if (num != 0)
			{
			}
			this.l.a();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00012608 File Offset: 0x00010808
		private void c()
		{
			short num = (short)1762852864;
			short num2 = num;
			num = (short)711983105;
			if (num != 0)
			{
			}
			num = (short)2115977309;
			short num3 = num;
			num = (short)612319325;
			switch (num3 == num)
			{
			}
			num = (short)82444288;
			if (num != 0)
			{
			}
			this.e();
			this.d();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000126BC File Offset: 0x000108BC
		private void a(global::System.IO.Stream A_0, global::System.IO.Stream A_1, long A_2, long A_3)
		{
			short num = (short)1653800960;
			short num2 = num;
			num = (short)2010574368;
			short num3 = num;
			num = (short)1829695008;
			switch (num3 == num)
			{
			}
			num = (short)1702363137;
			if (num != 0)
			{
			}
			num = (short)1831010304;
			if (num != 0)
			{
			}
			this.au = A_0;
			this.at = false;
			this.g();
			this.a(A_1);
			this.f();
			this.b();
			this.a();
			this.v.b(this.z + 1U - 2U);
			this.v.c(1U << this.al);
			this.w.b(this.z + 1U - 2U);
			this.w.c(1U << this.al);
			this.@as = 0L;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000127F0 File Offset: 0x000109F0
		public void Code(global::System.IO.Stream inStream, global::System.IO.Stream outStream, long inSize, long outSize, global::SevenZip.ICodeProgress progress)
		{
			short num = (short)1411863164;
			short num2 = num;
			num = (short)1488736892;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1196687361;
				if (num != 0)
				{
				}
				num = (short)776863744;
				short num3 = num;
				num = (short)85655552;
				if (num != 0)
				{
				}
				this.ax = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_D2;
					}
					int num4;
					for (;;)
					{
						IL_B0:
						bool flag;
						long inSize2;
						long outSize2;
						switch (num4)
						{
						case 0:
							if (flag)
							{
								num = (short)695926789;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)522846211;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							progress.SetProgress(inSize2, outSize2);
							num = (short)1695023110;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_F3;
						case 3:
							if (progress != null)
							{
								num = (short)330170369;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F3;
						case 4:
							goto IL_179;
						case 5:
							num = (short)1970929668;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_F3;
						}
						goto IL_D2;
						IL_F3:
						this.CodeOneBlock(out inSize2, out outSize2, out flag);
						num = (short)277413888;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_179:
					break;
					IL_D2:
					this.a(inStream, outStream, inSize, outSize);
					num = (short)66977794;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_B0;
				}
				finally
				{
					this.c();
				}
				break;
			}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000129B8 File Offset: 0x00010BB8
		public void WriteCoderProperties(global::System.IO.Stream outStream)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_12C;
				case 1:
				{
					num2 = (short)1297154048;
					short num3 = num2;
					goto IL_FA;
				}
				case 2:
					if (num4 >= 4)
					{
						num2 = (short)221511680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.a1[1 + num4] = (byte)(this.ap >> 8 * num4 & 255U);
					num4++;
					num2 = (short)1403912195;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_FA;
				}
				goto IL_20;
				IL_FA:
				num2 = (short)630390786;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_12C:
			goto IL_169;
			IL_20:
			num2 = (short)801177601;
			if (num2 != 0)
			{
			}
			this.a1[0] = (byte)((this.al * 5 + this.an) * 9 + this.ao);
			num4 = 0;
			num2 = (short)1159956954;
			short num5 = num2;
			num2 = (short)1830259162;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_169:
				outStream.Write(this.a1, 0, 5);
				return;
			default:
			{
				num2 = (short)1488257024;
				if (num2 != 0)
				{
				}
				num2 = (short)841547777;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00012B3C File Offset: 0x00010D3C
		private void b()
		{
			short num = (short)524943360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				uint num5;
				for (;;)
				{
					IL_28:
					uint num12;
					global::SevenZip.Compression.RangeCoder.e e;
					uint num13;
					switch (num2)
					{
					case 0:
					{
						num = (short)539048411;
						short num3 = num;
						num = (short)51984859;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_39C;
						default:
							goto IL_369;
						}
						break;
					}
					case 1:
					{
						num = (short)1582235648;
						short num4 = num;
						if (num5 >= 128U)
						{
							num = (short)1774387205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num6 = global::SevenZip.Compression.LZMA.Encoder.e(num5);
						int num7 = (int)((num6 >> 1) - 1U);
						uint num8 = (2U | (num6 & 1U)) << num7;
						this.a2[(int)num5] = global::SevenZip.Compression.RangeCoder.e.a(this.t, num8 - num6 - 1U, num7, num5 - num8);
						num5 += 1U;
						num = (short)251199498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1506607125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_483;
					case 4:
						goto IL_384;
					case 5:
					{
						uint num9 = 0U;
						num = (short)1966145556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						uint num9;
						uint num10 = num9 * 128U;
						uint num11 = 0U;
						num = (short)464125965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_187;
					case 8:
					{
						uint num11;
						if (num11 >= 128U)
						{
							num = (short)1655898131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num10;
						this.ah[(int)(num10 + num11)] = this.ag[(int)(num12 + global::SevenZip.Compression.LZMA.Encoder.e(num11))] + this.a2[(int)num11];
						num11 += 1U;
						num = (short)486211593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_145;
					case 10:
						num = (short)1151270913;
						if (num != 0)
						{
						}
						goto IL_187;
					case 11:
						goto IL_39C;
					case 12:
					{
						uint num9;
						if (num9 >= 4U)
						{
							num = (short)1493106688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						e = this.s[(int)num9];
						num12 = num9 << 6;
						num13 = 0U;
						num = (short)878051332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_AB;
					case 14:
						goto IL_AB;
					case 15:
						goto IL_483;
					case 16:
						num13 = 14U;
						num = (short)238354447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_384;
					case 18:
					{
						uint num11;
						if (num11 >= 4U)
						{
							num = (short)826605570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num10;
						this.ah[(int)(num10 + num11)] = this.ag[(int)(num12 + num11)];
						num11 += 1U;
						num = (short)1956904974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						uint num9;
						num9 += 1U;
						num = (short)1483014166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_2FA;
					case 21:
						goto IL_145;
					case 22:
						goto IL_2FA;
					case 23:
						if (num13 >= this.ak)
						{
							num = (short)1332936710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ag[(int)(num12 + num13)] += (num13 >> 1) - 1U - 4U << 6;
						num13 += 1U;
						num = (short)1620180995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F;
					IL_AB:
					num = (short)1171259410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_145:
					num = (short)112263176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_187:
					num = (short)189857793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39C:
					if (num13 >= this.ak)
					{
						num = (short)514588688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.ag[(int)(num12 + num13)] = e.a(num13);
					num13 += 1U;
					num = (short)1771896849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FA:
					num = (short)1160577036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_384:
					num = (short)1306591243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_483:
					num = (short)1979383831;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_369:
				num = (short)1874591744;
				if (num != 0)
				{
				}
				this.a3 = 0U;
				return;
				IL_8F:
				num5 = 4U;
				num = (short)1322254343;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00013054 File Offset: 0x00011254
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			uint num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)355194365;
					short num3 = num2;
					num2 = (short)816961021;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1238761473;
						if (num2 != 0)
						{
						}
						num2 = (short)317259776;
						if (num2 != 0)
						{
						}
						goto IL_A9;
					}
					break;
				}
				case 1:
				{
					num2 = (short)1621426176;
					short num4 = num2;
					if (num5 >= 16U)
					{
						num2 = (short)1954545667;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.ai[(int)num5] = this.u.b(num5);
					num5 += 1U;
					num2 = (short)1504837634;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_A9;
				case 3:
					goto IL_106;
				}
				goto IL_20;
				IL_A9:
				num2 = (short)535691265;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_106:
			this.aj = 0U;
			return;
			IL_20:
			num5 = 0U;
			num2 = (short)1541537792;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000131A4 File Offset: 0x000113A4
		private static int a(string s)
		{
			short num = (short)439484416;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_78;
			}
			int num3;
			int num4;
			for (;;)
			{
				IL_32:
				num = (short)1682898945;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					goto IL_144;
				case 1:
					if (s == global::SevenZip.Compression.LZMA.Encoder.a4[num4])
					{
						goto IL_127;
					}
					num4++;
					num = (short)1547894784;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_144;
				case 3:
				{
					num = (short)671020096;
					short num5 = num;
					num = (short)659682368;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_127;
					default:
						goto IL_E6;
					}
					break;
				}
				case 4:
					return -1;
				case 5:
					if (num4 >= global::SevenZip.Compression.LZMA.Encoder.a4.Length)
					{
						num = (short)1206648836;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1122893825;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_78;
				IL_127:
				num = (short)600506371;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_144:
				num = (short)2020081669;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_E6:
			num = (short)1085341696;
			if (num != 0)
			{
			}
			return num4;
			IL_78:
			num4 = 0;
			num = (short)2039939074;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00013334 File Offset: 0x00011534
		public void SetCoderProperties(global::SevenZip.CoderPropID[] propIDs, object[] properties)
		{
			short num = (short)1908670464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_11F;
				}
				uint num3;
				for (;;)
				{
					IL_28:
					int num6;
					switch (num2)
					{
					case 0:
						goto IL_5DB;
					case 1:
					{
						if ((ulong)num3 >= (ulong)((long)properties.Length))
						{
							num = (short)575930415;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj = properties[(int)num3];
						global::SevenZip.CoderPropID coderPropID = propIDs[(int)num3];
						num = (short)1026949163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_8AA;
					case 3:
						goto IL_A2C;
					case 4:
						goto IL_96D;
					case 5:
					{
						object obj;
						if (!(obj is int))
						{
							num = (short)770375706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = (int)obj;
						num = (short)1858207774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						int num5;
						if ((long)num5 > (long)(1UL << (num6 & 31)))
						{
							num = (short)1811283996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_96D;
					}
					case 7:
						goto IL_318;
					case 8:
						goto IL_644;
					case 9:
					{
						object obj;
						if (!(obj is int))
						{
							num = (short)1514078208;
							short num7 = num;
							num = (short)1275723778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num8 = (int)obj;
						num = (short)843579436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						int num9;
						if (num9 >= 0)
						{
							num = (short)1107427353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99C;
					}
					case 11:
						num = (short)761004064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						int num9;
						if ((long)num9 > 4L)
						{
							num = (short)2056257558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.al = num9;
						this.am = (1U << this.al) - 1U;
						num = (short)708706344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_A2C;
					case 14:
						goto IL_72B;
					case 15:
					{
						object obj;
						if (!(obj is int))
						{
							num = (short)1909260288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = (int)obj;
						num = (short)1184366630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						object obj;
						if (!(obj is bool))
						{
							goto IL_4BC;
						}
						this.a((bool)obj);
						num = (short)1361641531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_517;
					case 18:
						goto IL_318;
					case 19:
					{
						int num8;
						if ((long)num8 > 273L)
						{
							num = (short)1554579497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.z = (uint)num8;
						num = (short)262864903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						object obj;
						if (!(obj is int))
						{
							num = (short)1972043821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num9 = (int)obj;
						num = (short)857276426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						num = (short)1603469326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_2E9;
					case 23:
					{
						int num10;
						if (num10 >= 0)
						{
							num = (short)2057502731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E8;
					}
					case 24:
						num = (short)1549991984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)1405878284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_A2A;
					case 27:
						if ((long)num6 >= 30L)
						{
							num = (short)570884100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1895432198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num6++;
						num = (short)2106327043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						int num5;
						if ((long)num5 > 1073741824L)
						{
							num = (short)95027237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ap = (uint)num5;
						num6 = 0;
						num = (short)1225195533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						int num4;
						if (num4 >= 0)
						{
							num = (short)545587254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_996;
					}
					case 31:
						goto IL_9A2;
					case 32:
					{
						int num10;
						if ((long)num10 > 8L)
						{
							num = (short)792133682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ao = num10;
						num = (short)739508275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						this.aq = uint.MaxValue;
						this.k = null;
						num = (short)1991114770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						object obj;
						if (!(obj is string))
						{
							num = (short)916193288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SevenZip.Compression.LZMA.Encoder.a a = this.av;
						int num11 = global::SevenZip.Compression.LZMA.Encoder.a(((string)obj).ToUpperInvariant());
						num = (short)1485307959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						goto IL_179;
					case 36:
					{
						int num4;
						if ((long)num4 > 4L)
						{
							num = (short)548405283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.an = num4;
						num = (short)2104557617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						goto IL_561;
					case 38:
					{
						int num5;
						if ((long)num5 >= 1L)
						{
							num = (short)1017905210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51C;
					}
					case 39:
						if (this.k != null)
						{
							num = (short)267517976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_318;
					case 40:
						goto IL_318;
					case 41:
						goto IL_93C;
					case 42:
						goto IL_4D6;
					case 43:
					{
						global::SevenZip.CoderPropID coderPropID;
						switch (coderPropID)
						{
						case global::SevenZip.CoderPropID.DictionarySize:
							num = (short)1618477071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SevenZip.CoderPropID.UsedMemorySize:
						case global::SevenZip.CoderPropID.Order:
						case global::SevenZip.CoderPropID.BlockSize:
						case global::SevenZip.CoderPropID.MatchFinderCycles:
						case global::SevenZip.CoderPropID.NumPasses:
						case global::SevenZip.CoderPropID.NumThreads:
							goto IL_8AF;
						case global::SevenZip.CoderPropID.PosStateBits:
							num = (short)709230612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SevenZip.CoderPropID.LitContextBits:
							num = (short)959643701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SevenZip.CoderPropID.LitPosBits:
							num = (short)1695285253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SevenZip.CoderPropID.NumFastBytes:
							num = (short)585236489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SevenZip.CoderPropID.MatchFinder:
							num = (short)859373602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SevenZip.CoderPropID.Algorithm:
							goto IL_318;
						case global::SevenZip.CoderPropID.EndMarker:
							num = (short)912719888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1736048661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 44:
					{
						int num8;
						if (num8 >= 5)
						{
							num = (short)2096693294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25B;
					}
					case 45:
						goto IL_76C;
					case 46:
						num = (short)1874722835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						return;
					case 48:
					{
						global::SevenZip.Compression.LZMA.Encoder.a a;
						if (a != this.av)
						{
							num = (short)295632929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_318;
					}
					case 49:
						goto IL_318;
					case 50:
						goto IL_256;
					case 51:
						goto IL_318;
					case 52:
						goto IL_9A2;
					case 53:
					{
						object obj;
						if (!(obj is int))
						{
							num = (short)482934801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num10 = (int)obj;
						num = (short)378929175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
						num = (short)2095775780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
					{
						int num11;
						if (num11 < 0)
						{
							num = (short)773849144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.av = (global::SevenZip.Compression.LZMA.Encoder.a)num11;
						num = (short)744357927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						goto IL_217;
					case 57:
						goto IL_318;
					case 58:
						num = (short)715194397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						goto IL_318;
					}
					goto IL_11F;
					IL_318:
					num = (short)1784591218;
					short num12 = num;
					num = (short)1461498738;
					switch ((num12 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_4BC:
						num = (short)1707016234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)2037579776;
						if (num != 0)
						{
						}
						num3 += 1U;
						num = (short)398393396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_96D:
					this.ak = (uint)(num6 * 2);
					num = (short)1812332601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A2:
					num = (short)2030960641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A2C:
					num = (short)1662910491;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_179:
				goto IL_996;
				IL_217:
				throw new global::SevenZip.InvalidParamException();
				IL_256:
				goto IL_9E8;
				IL_25B:
				throw new global::SevenZip.InvalidParamException();
				IL_2E9:
				goto IL_99C;
				IL_4D6:
				throw new global::SevenZip.InvalidParamException();
				IL_517:
				throw new global::SevenZip.InvalidParamException();
				IL_51C:
				throw new global::SevenZip.InvalidParamException();
				IL_561:
				goto IL_51C;
				IL_5DB:
				num = (short)1223229441;
				if (num != 0)
				{
				}
				throw new global::SevenZip.InvalidParamException();
				IL_644:
				throw new global::SevenZip.InvalidParamException();
				IL_72B:
				goto IL_8AF;
				IL_76C:
				throw new global::SevenZip.InvalidParamException();
				IL_8AA:
				throw new global::SevenZip.InvalidParamException();
				IL_8AF:
				throw new global::SevenZip.InvalidParamException();
				IL_93C:
				goto IL_25B;
				IL_996:
				throw new global::SevenZip.InvalidParamException();
				IL_99C:
				throw new global::SevenZip.InvalidParamException();
				IL_9E8:
				throw new global::SevenZip.InvalidParamException();
				IL_A2A:
				throw new global::SevenZip.InvalidParamException();
				IL_11F:
				num3 = 0U;
				num = (short)1905655839;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00013DB0 File Offset: 0x00011FB0
		public void SetTrainSize(uint trainSize)
		{
			short num = (short)948252280;
			short num2 = num;
			num = (short)669134456;
			switch (num2 == num)
			{
			}
			num = (short)1862402049;
			if (num != 0)
			{
			}
			num = (short)53149696;
			short num3 = num;
			num = (short)151781376;
			if (num != 0)
			{
			}
			this.a5 = trainSize;
		}

		// Token: 0x0400008D RID: 141
		private const uint a = 268435455U;

		// Token: 0x0400008E RID: 142
		private static byte[] b;

		// Token: 0x0400008F RID: 143
		private global::SevenZip.Compression.LZMA.a.a c;

		// Token: 0x04000090 RID: 144
		private byte d;

		// Token: 0x04000091 RID: 145
		private uint[] e = new uint[4];

		// Token: 0x04000092 RID: 146
		private const int f = 22;

		// Token: 0x04000093 RID: 147
		private const uint g = 32U;

		// Token: 0x04000094 RID: 148
		private const uint h = 16U;

		// Token: 0x04000095 RID: 149
		private const uint i = 4096U;

		// Token: 0x04000096 RID: 150
		private global::SevenZip.Compression.LZMA.Encoder.e[] j = new global::SevenZip.Compression.LZMA.Encoder.e[4096];

		// Token: 0x04000097 RID: 151
		private global::SevenZip.Compression.LZ.b k;

		// Token: 0x04000098 RID: 152
		private global::SevenZip.Compression.RangeCoder.a l = new global::SevenZip.Compression.RangeCoder.a();

		// Token: 0x04000099 RID: 153
		private global::SevenZip.Compression.RangeCoder.c[] m = new global::SevenZip.Compression.RangeCoder.c[192];

		// Token: 0x0400009A RID: 154
		private global::SevenZip.Compression.RangeCoder.c[] n = new global::SevenZip.Compression.RangeCoder.c[12];

		// Token: 0x0400009B RID: 155
		private global::SevenZip.Compression.RangeCoder.c[] o = new global::SevenZip.Compression.RangeCoder.c[12];

		// Token: 0x0400009C RID: 156
		private global::SevenZip.Compression.RangeCoder.c[] p = new global::SevenZip.Compression.RangeCoder.c[12];

		// Token: 0x0400009D RID: 157
		private global::SevenZip.Compression.RangeCoder.c[] q = new global::SevenZip.Compression.RangeCoder.c[12];

		// Token: 0x0400009E RID: 158
		private global::SevenZip.Compression.RangeCoder.c[] r = new global::SevenZip.Compression.RangeCoder.c[192];

		// Token: 0x0400009F RID: 159
		private global::SevenZip.Compression.RangeCoder.e[] s = new global::SevenZip.Compression.RangeCoder.e[4];

		// Token: 0x040000A0 RID: 160
		private global::SevenZip.Compression.RangeCoder.c[] t = new global::SevenZip.Compression.RangeCoder.c[114];

		// Token: 0x040000A1 RID: 161
		private global::SevenZip.Compression.RangeCoder.e u = new global::SevenZip.Compression.RangeCoder.e(4);

		// Token: 0x040000A2 RID: 162
		private global::SevenZip.Compression.LZMA.Encoder.d v = new global::SevenZip.Compression.LZMA.Encoder.d();

		// Token: 0x040000A3 RID: 163
		private global::SevenZip.Compression.LZMA.Encoder.d w = new global::SevenZip.Compression.LZMA.Encoder.d();

		// Token: 0x040000A4 RID: 164
		private global::SevenZip.Compression.LZMA.Encoder.b x = new global::SevenZip.Compression.LZMA.Encoder.b();

		// Token: 0x040000A5 RID: 165
		private uint[] y = new uint[548];

		// Token: 0x040000A6 RID: 166
		private uint z = 32U;

		// Token: 0x040000A7 RID: 167
		private uint aa;

		// Token: 0x040000A8 RID: 168
		private uint ab;

		// Token: 0x040000A9 RID: 169
		private uint ac;

		// Token: 0x040000AA RID: 170
		private uint ad;

		// Token: 0x040000AB RID: 171
		private uint ae;

		// Token: 0x040000AC RID: 172
		private bool af;

		// Token: 0x040000AD RID: 173
		private uint[] ag = new uint[256];

		// Token: 0x040000AE RID: 174
		private uint[] ah = new uint[512];

		// Token: 0x040000AF RID: 175
		private uint[] ai = new uint[16];

		// Token: 0x040000B0 RID: 176
		private uint aj;

		// Token: 0x040000B1 RID: 177
		private uint ak = 44U;

		// Token: 0x040000B2 RID: 178
		private int al = 2;

		// Token: 0x040000B3 RID: 179
		private uint am = 3U;

		// Token: 0x040000B4 RID: 180
		private int an;

		// Token: 0x040000B5 RID: 181
		private int ao = 3;

		// Token: 0x040000B6 RID: 182
		private uint ap = 4194304U;

		// Token: 0x040000B7 RID: 183
		private uint aq = uint.MaxValue;

		// Token: 0x040000B8 RID: 184
		private uint ar = uint.MaxValue;

		// Token: 0x040000B9 RID: 185
		private long @as;

		// Token: 0x040000BA RID: 186
		private bool at;

		// Token: 0x040000BB RID: 187
		private global::System.IO.Stream au;

		// Token: 0x040000BC RID: 188
		private global::SevenZip.Compression.LZMA.Encoder.a av = global::SevenZip.Compression.LZMA.Encoder.a.b;

		// Token: 0x040000BD RID: 189
		private bool aw;

		// Token: 0x040000BE RID: 190
		private bool ax;

		// Token: 0x040000BF RID: 191
		private uint[] ay = new uint[4];

		// Token: 0x040000C0 RID: 192
		private uint[] az = new uint[4];

		// Token: 0x040000C1 RID: 193
		private const int a0 = 5;

		// Token: 0x040000C2 RID: 194
		private byte[] a1 = new byte[5];

		// Token: 0x040000C3 RID: 195
		private uint[] a2 = new uint[128];

		// Token: 0x040000C4 RID: 196
		private uint a3;

		// Token: 0x040000C5 RID: 197
		private static string[] a4;

		// Token: 0x040000C6 RID: 198
		private uint a5;

		// Token: 0x0200001E RID: 30
		private enum a
		{
			// Token: 0x040000C8 RID: 200
			a,
			// Token: 0x040000C9 RID: 201
			b
		}

		// Token: 0x0200001F RID: 31
		private class b
		{
			// Token: 0x060000AE RID: 174 RVA: 0x00013E60 File Offset: 0x00012060
			public void a(int A_0, int A_1)
			{
				short num = (short)1045954569;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					uint num3;
					uint num4;
					switch (num2)
					{
					case 0:
						if (num3 >= num4)
						{
							num = (short)2064646145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a[(int)num3].a();
						num3 += 1U;
						num = (short)571277315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						return;
					case 3:
						goto IL_12C;
					case 4:
						if (this.c == A_0)
						{
							num = (short)775553026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EF;
					case 5:
						num = (short)1194786822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)1881276417;
						if (num != 0)
						{
						}
						num = (short)890699776;
						short num5 = num;
						if (this.b == A_1)
						{
							num = (short)2138308616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EF;
					}
					case 7:
						goto IL_12C;
					case 8:
					{
						num = (short)1038947239;
						short num6 = num;
						num = (short)1824330663;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1441529856;
							if (num != 0)
							{
							}
							num = (short)1405419524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						switch (0)
						{
						case 0:
							goto IL_4C;
						}
						continue;
					}
					IL_4C:
					if (this.a != null)
					{
						num = (short)1858994181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EF;
					IL_12C:
					num = (short)360316928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EF:
					this.c = A_0;
					this.d = (1U << A_0) - 1U;
					this.b = A_1;
					num4 = 1U << this.b + this.c;
					this.a = new global::SevenZip.Compression.LZMA.Encoder.b.a[num4];
					num3 = 0U;
					num = (short)844365831;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x060000AF RID: 175 RVA: 0x000140B8 File Offset: 0x000122B8
			public void a()
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				uint num4;
				uint num5;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1711368241;
						short num3 = num2;
						num2 = (short)543778865;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11D;
						default:
							goto IL_B2;
						}
						break;
					}
					case 1:
						goto IL_11D;
					case 2:
						if (num4 >= num5)
						{
							num2 = (short)997195776;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.a[(int)num4].b();
						num4 += 1U;
						num2 = (short)997523457;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_4D;
					}
					goto IL_20;
					IL_4D:
					num2 = (short)609943554;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_11D:
					num2 = (short)824377344;
					short num6 = num2;
					goto IL_4D;
				}
				IL_B2:
				num2 = (short)1633484801;
				if (num2 != 0)
				{
				}
				num2 = (short)641990656;
				if (num2 != 0)
				{
				}
				return;
				IL_20:
				num5 = 1U << this.b + this.c;
				num4 = 0U;
				num2 = (short)1062404099;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x060000B0 RID: 176 RVA: 0x00014210 File Offset: 0x00012410
			public global::SevenZip.Compression.LZMA.Encoder.b.a a(uint A_0, byte A_1)
			{
				short num = (short)620649876;
				short num2 = num;
				num = (short)1042832788;
				switch (num2 == num)
				{
				}
				num = (short)778043393;
				if (num != 0)
				{
				}
				num = (short)1112735744;
				short num3 = num;
				num = (short)15597568;
				if (num != 0)
				{
				}
				return this.a[(int)(((A_0 & this.d) << this.b) + (uint)(A_1 >> 8 - this.b))];
			}

			// Token: 0x040000CA RID: 202
			private global::SevenZip.Compression.LZMA.Encoder.b.a[] a;

			// Token: 0x040000CB RID: 203
			private int b;

			// Token: 0x040000CC RID: 204
			private int c;

			// Token: 0x040000CD RID: 205
			private uint d;

			// Token: 0x02000020 RID: 32
			public struct a
			{
				// Token: 0x060000B2 RID: 178 RVA: 0x000142F8 File Offset: 0x000124F8
				public void a()
				{
					short num = (short)2080243713;
					if (num != 0)
					{
					}
					num = (short)1203077120;
					short num2 = num;
					num = (short)1924235264;
					switch (num2 == num)
					{
					}
					num = (short)1065943040;
					short num3 = num;
					num = (short)1549402112;
					if (num != 0)
					{
					}
					this.a = new global::SevenZip.Compression.RangeCoder.c[768];
				}

				// Token: 0x060000B3 RID: 179 RVA: 0x000143B0 File Offset: 0x000125B0
				public void b()
				{
					short num = (short)800915457;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					int num2;
					int num4;
					for (;;)
					{
						IL_32:
						switch (num2)
						{
						case 0:
						{
							num = (short)1003174408;
							short num3 = num;
							num = (short)956185096;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_10A;
							default:
								goto IL_C6;
							}
							break;
						}
						case 1:
							goto IL_10A;
						case 2:
							if (num4 >= 768)
							{
								num = (short)1109524480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.a[num4].b();
							num4++;
							num = (short)848035841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_60;
						}
						goto IL_48;
						IL_60:
						num = (short)1869348866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_10A:
						num = (short)321585152;
						short num5 = num;
						goto IL_60;
					}
					IL_C6:
					num = (short)545783808;
					if (num != 0)
					{
					}
					return;
					IL_48:
					num4 = 0;
					num = (short)865861635;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}

				// Token: 0x060000B4 RID: 180 RVA: 0x000144F8 File Offset: 0x000126F8
				public void a(global::SevenZip.Compression.RangeCoder.a A_0, byte A_1)
				{
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					short num;
					int num2;
					int num4;
					uint num6;
					for (;;)
					{
						IL_0A:
						num = (short)1846214657;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
						{
							num = (short)1072383880;
							short num3 = num;
							num = (short)1042040712;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_11E;
							default:
								goto IL_C9;
							}
							break;
						}
						case 1:
							goto IL_11E;
						case 2:
						{
							if (num4 < 0)
							{
								num = (short)1663827968;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							uint num5 = (uint)(A_1 >> num4 & 1);
							this.a[(int)num6].a(A_0, num5);
							num6 = (num6 << 1 | num5);
							num4--;
							num = (short)246808577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_63;
						}
						goto IL_49;
						IL_63:
						num = (short)369491970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_11E:
						num = (short)1951727616;
						short num7 = num;
						goto IL_63;
					}
					IL_C9:
					num = (short)2068381696;
					if (num != 0)
					{
					}
					return;
					IL_49:
					num6 = 1U;
					num4 = 7;
					num = (short)323026947;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}

				// Token: 0x060000B5 RID: 181 RVA: 0x00014650 File Offset: 0x00012850
				public void a(global::SevenZip.Compression.RangeCoder.a A_0, byte A_1, byte A_2)
				{
					short num = (short)1464598528;
					int num2 = (int)num;
					switch (num2)
					{
					default:
					{
						switch (0)
						{
						case 0:
							goto IL_4B;
						}
						int num5;
						uint num8;
						bool flag;
						for (;;)
						{
							IL_28:
							uint num6;
							uint num7;
							switch (num2)
							{
							case 0:
								goto IL_11C;
							case 1:
							{
								num = (short)2059599872;
								short num3 = num;
								num = (short)548523359;
								short num4 = num;
								num = (short)1435815263;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_11C;
								default:
									num = (short)204931072;
									if (num != 0)
									{
									}
									if (num5 < 0)
									{
										num = (short)1790771204;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num6 = (uint)(A_2 >> num5 & 1);
									num7 = num8;
									num = (short)872284165;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								uint num9 = (uint)(A_1 >> num5 & 1);
								num7 += 1U + num9 << 8;
								flag = (num9 == num6);
								num = (short)1372651523;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_6C;
							case 4:
								goto IL_1C9;
							case 5:
								if (flag)
								{
									num = (short)1546321922;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6C;
							case 6:
								goto IL_11C;
							}
							goto IL_4B;
							IL_6C:
							this.a[(int)num7].a(A_0, num6);
							num8 = (num8 << 1 | num6);
							num5--;
							num = (short)460062720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_11C:
							num = (short)1476132865;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1C9:
						num = (short)271319041;
						if (num != 0)
						{
						}
						return;
						IL_4B:
						num8 = 1U;
						flag = true;
						num5 = 7;
						num = (short)1520238598;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_28;
					}
					}
				}

				// Token: 0x060000B6 RID: 182 RVA: 0x00014850 File Offset: 0x00012A50
				public uint a(bool A_0, byte A_1, byte A_2)
				{
					short num = (short)1905131520;
					int num2 = (int)num;
					switch (num2)
					{
					default:
					{
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						uint num3;
						int num4;
						uint num6;
						for (;;)
						{
							IL_27:
							uint num9;
							uint num10;
							switch (num2)
							{
							case 0:
								return num3;
							case 1:
								goto IL_BC;
							case 2:
								if (num4 < 0)
								{
									num = (short)541851654;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_11A;
							case 3:
								if (A_0)
								{
									num = (short)1930952716;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1D7;
							case 4:
								num = (short)662437889;
								if (num != 0)
								{
								}
								goto IL_BC;
							case 5:
							{
								if (num4 < 0)
								{
									num = (short)1234239488;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								uint num5 = (uint)(A_2 >> num4 & 1);
								num3 += this.a[(int)num6].b(num5);
								num6 = (num6 << 1 | num5);
								num4--;
								num = (short)1955332103;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								num = (short)1759248384;
								short num7 = num;
								num = (short)1641152520;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								goto IL_1D7;
							case 8:
								goto IL_1D7;
							case 9:
							{
								num = (short)1978888658;
								short num8 = num;
								num = (short)1276015058;
								switch ((num8 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_11A;
								default:
									num = (short)1243611136;
									if (num != 0)
									{
									}
									if (num9 != num10)
									{
										num = (short)617086987;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num4--;
									num = (short)852885505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
								goto IL_1D7;
							case 11:
								num4--;
								num = (short)1627127818;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								num = (short)1235025924;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_62;
							IL_BC:
							num = (short)264962050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_11A:
							num9 = (uint)(A_1 >> num4 & 1);
							num10 = (uint)(A_2 >> num4 & 1);
							num3 += this.a[(int)((1U + num9 << 8) + num6)].b(num10);
							num6 = (num6 << 1 | num10);
							num = (short)622723081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1D7:
							num = (short)1543438341;
							num2 = (int)((global::System.IntPtr)num);
						}
						return num3;
						IL_62:
						num3 = 0U;
						num6 = 1U;
						num4 = 7;
						num = (short)1365377027;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_27;
					}
					}
				}

				// Token: 0x040000CE RID: 206
				private global::SevenZip.Compression.RangeCoder.c[] a;
			}
		}

		// Token: 0x02000021 RID: 33
		private class c
		{
			// Token: 0x060000B7 RID: 183 RVA: 0x00014B40 File Offset: 0x00012D40
			public c()
			{
				for (uint num = 0U; num < 16U; num += 1U)
				{
					this.c[(int)num] = new global::SevenZip.Compression.RangeCoder.e(3);
					this.d[(int)num] = new global::SevenZip.Compression.RangeCoder.e(3);
				}
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00014BB0 File Offset: 0x00012DB0
			public void d(uint A_0)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				uint num4;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1842197117;
						short num3 = num2;
						num2 = (short)648000125;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_131;
						default:
							goto IL_DB;
						}
						break;
					}
					case 1:
						goto IL_131;
					case 2:
						if (num4 >= A_0)
						{
							num2 = (short)2096693248;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.c[(int)num4].a();
						this.d[(int)num4].a();
						num4 += 1U;
						num2 = (short)1107623937;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num2 = (short)703660033;
						if (num2 != 0)
						{
						}
						goto IL_76;
					}
					goto IL_20;
					IL_76:
					num2 = (short)506068994;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_131:
					num2 = (short)1452867584;
					short num5 = num2;
					goto IL_76;
				}
				IL_DB:
				num2 = (short)770899968;
				if (num2 != 0)
				{
				}
				this.e.a();
				return;
				IL_20:
				this.a.b();
				this.b.b();
				num4 = 0U;
				num2 = (short)240910339;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x00014D28 File Offset: 0x00012F28
			public void b(global::SevenZip.Compression.RangeCoder.a A_0, uint A_1, uint A_2)
			{
				short num = (short)309526531;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						for (;;)
						{
							num = (short)1456799745;
							if (num != 0)
							{
							}
							if (A_1 >= 8U)
							{
								goto IL_177;
							}
							num = (short)223748119;
							short num3 = num;
							num = (short)456663063;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_FC;
							}
						}
						IL_FC:
						num = (short)1422000128;
						short num4 = num;
						num = (short)1680539648;
						if (num != 0)
						{
						}
						num = (short)1871183873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_151;
					case 2:
						goto IL_4E;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_35;
						}
						continue;
					}
					IL_35:
					if (A_1 < 8U)
					{
						num = (short)341049346;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						A_1 -= 8U;
						this.a.a(A_0, 1U);
						num = (short)518127616;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_4E:
				this.a.a(A_0, 0U);
				this.c[(int)A_2].a(A_0, A_1);
				return;
				IL_151:
				this.b.a(A_0, 0U);
				this.d[(int)A_2].a(A_0, A_1);
				return;
				IL_177:
				this.b.a(A_0, 1U);
				this.e.a(A_0, A_1 - 8U);
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00014EC8 File Offset: 0x000130C8
			public void a(uint A_0, uint A_1, uint[] A_2, uint A_3)
			{
				short num = (short)212467712;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					uint num3;
					uint num4;
					uint num5;
					uint num8;
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							return;
						case 1:
							if (num3 >= 8U)
							{
								num = (short)2064121869;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)193724421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_24E;
						case 3:
							goto IL_C2;
						case 4:
							goto IL_24E;
						case 5:
							if (num3 >= A_1)
							{
								num = (short)1230503943;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_2[(int)(A_3 + num3)] = num4 + this.c[(int)A_0].a(num3);
							num3 += 1U;
							num = (short)1580400651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_343;
						case 7:
							return;
						case 8:
							num = (short)1318846466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (num3 >= A_1)
							{
								num = (short)1574436874;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_2[(int)(A_3 + num3)] = num5 + this.d[(int)A_0].a(num3 - 8U);
							num3 += 1U;
							num = (short)1481441283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							return;
						case 11:
						{
							num = (short)1265093442;
							short num6 = num;
							num = (short)2010237762;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								return;
							case 1:
								break;
							default:
							{
								num = (short)1522991104;
								short num7 = num;
								break;
							}
							}
							num = (short)1297285120;
							if (num != 0)
							{
							}
							goto IL_343;
						}
						case 12:
							if (num3 >= A_1)
							{
								num = (short)666632192;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_2[(int)(A_3 + num3)] = num8 + this.e.a(num3 - 8U - 8U);
							num3 += 1U;
							num = (short)1765146628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							num = (short)531431438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_C2;
						case 15:
							if (num3 >= 16U)
							{
								num = (short)1629159432;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1548812297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F;
						IL_C2:
						num = (short)541065217;
						if (num != 0)
						{
						}
						num = (short)1530593295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_24E:
						num = (short)1781727244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_343:
						num = (short)1583022081;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
					IL_6F:
					num4 = this.a.c();
					uint num9 = this.a.d();
					num5 = num9 + this.b.c();
					num8 = num9 + this.b.d();
					num3 = 0U;
					num3 = 0U;
					num = (short)17694726;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}

			// Token: 0x040000CF RID: 207
			private global::SevenZip.Compression.RangeCoder.c a;

			// Token: 0x040000D0 RID: 208
			private global::SevenZip.Compression.RangeCoder.c b;

			// Token: 0x040000D1 RID: 209
			private global::SevenZip.Compression.RangeCoder.e[] c = new global::SevenZip.Compression.RangeCoder.e[16];

			// Token: 0x040000D2 RID: 210
			private global::SevenZip.Compression.RangeCoder.e[] d = new global::SevenZip.Compression.RangeCoder.e[16];

			// Token: 0x040000D3 RID: 211
			private global::SevenZip.Compression.RangeCoder.e e = new global::SevenZip.Compression.RangeCoder.e(8);
		}

		// Token: 0x02000022 RID: 34
		private class d : global::SevenZip.Compression.LZMA.Encoder.c
		{
			// Token: 0x060000BB RID: 187 RVA: 0x00015258 File Offset: 0x00013458
			public void b(uint A_0)
			{
				short num = (short)1004035293;
				short num2 = num;
				num = (short)602430685;
				switch (num2 == num)
				{
				}
				num = (short)689373185;
				if (num != 0)
				{
				}
				num = (short)1289748480;
				short num3 = num;
				num = (short)1576927232;
				if (num != 0)
				{
				}
				this.b = A_0;
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00015308 File Offset: 0x00013508
			public uint a(uint A_0, uint A_1)
			{
				short num = (short)1887436801;
				if (num != 0)
				{
				}
				num = (short)140273853;
				short num2 = num;
				num = (short)869558461;
				switch (num2 == num)
				{
				}
				num = (short)1553006592;
				short num3 = num;
				num = (short)2107441152;
				if (num != 0)
				{
				}
				return this.a[(int)(A_1 * 272U + A_0)];
			}

			// Token: 0x060000BD RID: 189 RVA: 0x000153C4 File Offset: 0x000135C4
			private void a(uint A_0)
			{
				short num = (short)199257002;
				short num2 = num;
				num = (short)825125802;
				switch (num2 == num)
				{
				}
				num = (short)981598209;
				if (num != 0)
				{
				}
				num = (short)247922688;
				short num3 = num;
				num = (short)966131712;
				if (num != 0)
				{
				}
				base.a(A_0, this.b, this.a, A_0 * 272U);
				this.c[(int)A_0] = this.b;
			}

			// Token: 0x060000BE RID: 190 RVA: 0x00015494 File Offset: 0x00013694
			public void c(uint A_0)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				uint num4;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)998376686;
						short num3 = num2;
						num2 = (short)1409811694;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FE;
						default:
							goto IL_9D;
						}
						break;
					}
					case 1:
						goto IL_FE;
					case 2:
						if (num4 >= A_0)
						{
							num2 = (short)1661665280;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.a(num4);
						num4 += 1U;
						num2 = (short)2004156417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_38;
					}
					goto IL_20;
					IL_38:
					num2 = (short)945553410;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_FE:
					num2 = (short)1169817600;
					short num5 = num2;
					goto IL_38;
				}
				IL_9D:
				num2 = (short)525205505;
				if (num2 != 0)
				{
				}
				num2 = (short)2138963968;
				if (num2 != 0)
				{
				}
				return;
				IL_20:
				num4 = 0U;
				num2 = (short)1435500547;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x060000BF RID: 191 RVA: 0x000155D0 File Offset: 0x000137D0
			public void a(global::SevenZip.Compression.RangeCoder.a A_0, uint A_1, uint A_2)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				uint num5;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						for (;;)
						{
							num2 = (short)901711172;
							short num3 = num2;
							num2 = (short)1609368900;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_A0;
							}
						}
						IL_A0:
						num2 = (short)1978925057;
						if (num2 != 0)
						{
						}
						num2 = (short)1709309952;
						if (num2 != 0)
						{
						}
						num2 = (short)1999175680;
						short num4 = num2;
						this.a(A_2);
						num2 = (short)129433600;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						if (num5 == 0U)
						{
							num2 = (short)1428946945;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				base.b(A_0, A_1, A_2);
				uint[] array = this.c;
				num5 = array[(int)A_2] - 1U;
				array[(int)A_2] = num5;
				num2 = (short)829947906;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x040000D4 RID: 212
			private new uint[] a = new uint[4352];

			// Token: 0x040000D5 RID: 213
			private new uint b;

			// Token: 0x040000D6 RID: 214
			private uint[] c = new uint[16];
		}

		// Token: 0x02000023 RID: 35
		private class e
		{
			// Token: 0x060000C1 RID: 193 RVA: 0x00015738 File Offset: 0x00013938
			public void m()
			{
				short num = (short)1843273626;
				short num2 = num;
				num = (short)1932861338;
				switch (num2 == num)
				{
				}
				num = (short)191299585;
				if (num != 0)
				{
				}
				num = (short)1563557888;
				short num3 = num;
				num = (short)976289792;
				if (num != 0)
				{
				}
				this.h = uint.MaxValue;
				this.b = false;
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x000157F0 File Offset: 0x000139F0
			public void n()
			{
				short num = (short)1674061497;
				short num2 = num;
				num = (short)244524729;
				switch (num2 == num)
				{
				}
				num = (short)1540292609;
				if (num != 0)
				{
				}
				num = (short)20054016;
				short num3 = num;
				num = (short)66191360;
				if (num != 0)
				{
				}
				this.h = 0U;
				this.b = false;
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x000158A8 File Offset: 0x00013AA8
			public bool o()
			{
				short num = (short)65910145;
				short num2 = num;
				num = (short)230602113;
				switch (num2 == num)
				{
				}
				num = (short)1615396865;
				if (num != 0)
				{
				}
				num = (short)800587776;
				short num3 = num;
				num = (short)1677721600;
				if (num != 0)
				{
				}
				return this.h == 0U;
			}

			// Token: 0x040000D7 RID: 215
			public global::SevenZip.Compression.LZMA.a.a a;

			// Token: 0x040000D8 RID: 216
			public bool b;

			// Token: 0x040000D9 RID: 217
			public bool c;

			// Token: 0x040000DA RID: 218
			public uint d;

			// Token: 0x040000DB RID: 219
			public uint e;

			// Token: 0x040000DC RID: 220
			public uint f;

			// Token: 0x040000DD RID: 221
			public uint g;

			// Token: 0x040000DE RID: 222
			public uint h;

			// Token: 0x040000DF RID: 223
			public uint i;

			// Token: 0x040000E0 RID: 224
			public uint j;

			// Token: 0x040000E1 RID: 225
			public uint k;

			// Token: 0x040000E2 RID: 226
			public uint l;
		}
	}
}
