using System;
using System.IO;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200000B RID: 11
	public class ByteBufferStream : global::System.IO.Stream
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00005000 File Offset: 0x00003200
		public ByteBufferStream() : this(0)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005014 File Offset: 0x00003214
		internal ByteBufferStream(int A_0)
		{
			int a_ = 9;
			base..ctor();
			if (A_0 < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쎟쎡풣장쮧쎩\ud8ab힭", a_));
			}
			this.a = new byte[A_0];
			this.b = A_0;
			this.c = true;
			this.i = true;
			this.d = true;
			this.g = 0;
			this.e = true;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005080 File Offset: 0x00003280
		public ByteBufferStream(byte[] buffer) : this(buffer, true)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005098 File Offset: 0x00003298
		internal ByteBufferStream(byte[] A_0, bool A_1)
		{
			int a_ = 7;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﲝ햟쒡슣쎥\udaa7", a_));
			}
			this.a = A_0;
			this.f = A_0.Length;
			this.b = A_0.Length;
			this.c = false;
			this.i = A_1;
			this.d = false;
			this.g = 0;
			this.e = true;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000510C File Offset: 0x0000330C
		internal ByteBufferStream(byte[] A_0, int A_1, int A_2) : this(A_0, A_1, A_2, true, false)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005124 File Offset: 0x00003324
		internal ByteBufferStream(byte[] A_0, int A_1, int A_2, bool A_3) : this(A_0, A_1, A_2, A_3, false)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005140 File Offset: 0x00003340
		internal ByteBufferStream(byte[] A_0, int A_1, int A_2, bool A_3, bool A_4)
		{
			int a_ = 10;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쎠횢쎤솦첨\ud9aa", a_));
			}
			if (A_1 < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좠춢솤슦톨", a_));
			}
			if (A_2 < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슠첢키즦\udda8", a_));
			}
			if (A_0.Length - A_1 < A_2)
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춢펤욦얨슪즬辮ﺰ햲펴쒶\udcb8쾺鶼꓀귂ꋄ꿆뷈", a_));
			}
			this.a = A_0;
			this.h = A_1;
			this.g = A_1;
			this.f = (this.b = A_1 + A_2);
			this.i = A_3;
			this.d = A_4;
			this.c = false;
			this.e = true;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005210 File Offset: 0x00003410
		protected override void Dispose(bool disposing)
		{
			short num;
			try
			{
				num = (short)537853953;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_10B;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_35;
						}
						continue;
					case 2:
						goto IL_F4;
					case 3:
					{
						num = (short)962786285;
						short num3 = num;
						num = (short)474149869;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1167327232;
							if (num != 0)
							{
							}
							this.e = false;
							this.i = false;
							this.c = false;
							break;
						}
						num = (short)924778497;
						if (num != 0)
						{
						}
						num = (short)1073610754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_35:
					if (disposing)
					{
						num = (short)874119171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_F4:
					num = (short)1266286592;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10B:;
			}
			finally
			{
				base.Dispose(disposing);
			}
			num = (short)1181679616;
			short num4 = num;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005378 File Offset: 0x00003578
		private bool a(int A_0)
		{
			int a_ = 7;
			short num = (short)1041956871;
			int num2 = (int)((global::System.IntPtr)num);
			int num4;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
				{
					num = (short)584192096;
					short num3 = num;
					num = (short)907415648;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A9;
					default:
						num = (short)1100677120;
						if (num != 0)
						{
						}
						num4 = this.b * 2;
						num = (short)1616773128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					if (A_0 <= this.b)
					{
						num = (short)466944000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num4 = A_0;
					num = (short)756875265;
					if (num != 0)
					{
					}
					num = (short)1143209988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1BF;
				case 4:
					if (num4 < 256)
					{
						num = (short)496828425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BF;
				case 5:
					goto IL_72;
				case 6:
					if (num4 < this.b * 2)
					{
						num = (short)1680408577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_200;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 8:
					goto IL_1A9;
				case 9:
					num4 = 256;
					num = (short)1863254019;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_55:
				if (A_0 < 0)
				{
					num = (short)1885995013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1379205122;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BF:
				num = (short)853868550;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_72:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춝풟킡솣장얧誩솭\udfaf銱\ud9b5횷\uddb9", a_));
			IL_1A9:
			IL_200:
			num = (short)678559744;
			short num5 = num;
			this.Capacity = num4;
			return true;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000055B8 File Offset: 0x000037B8
		public override void Flush()
		{
			short num = (short)1699994823;
			short num2 = num;
			num = (short)144235719;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2016411648;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1832845313;
			if (num != 0)
			{
			}
			num = (short)1936261120;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005664 File Offset: 0x00003864
		public virtual byte[] GetBuffer()
		{
			int a_ = 11;
			while (this.d)
			{
				short num = (short)1264840891;
				short num2 = num;
				num = (short)463728827;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1686831105;
					if (num != 0)
					{
					}
					num = (short)1801519104;
					if (num != 0)
					{
					}
					num = (short)1747582976;
					short num3 = num;
					return this.a;
				}
				}
			}
			throw new global::System.UnauthorizedAccessException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪣장\udda7\udea9쒫솭슯\udbb1캳펵\udcb7骹\uddbb\uddbdꎿꟁ럃뗅뻉ꏋꏏꛑꛓ럕뗗龎뻛ꯝ蛟蓡臣铥", a_));
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000573C File Offset: 0x0000393C
		internal int b(int A_0)
		{
			int a_ = 3;
			short num = (short)1670971397;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			for (;;)
			{
				num = (short)998572033;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num3 = A_0;
					num = (short)1186594816;
					short num4 = num;
					num = (short)1823080451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_DD;
				case 2:
					if (num3 < 0)
					{
						num = (short)293732359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D4;
				case 3:
					goto IL_DF;
				case 4:
					if (num3 > A_0)
					{
						num = (short)356909056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DF;
				case 5:
				{
					num = (short)1364069533;
					short num5 = num;
					num = (short)1674513565;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_189;
					default:
						num = (short)369360896;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_BE;
						}
						continue;
					}
					break;
				}
				case 6:
					goto IL_189;
				case 7:
					num3 = 0;
					num = (short)618987526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BE:
				if (!this.e)
				{
					num = (short)817233921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num3 = this.f - this.h;
				num = (short)661323780;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DF:
				num = (short)1560215554;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DD:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즙얟쎡즣蚥솧\ud9a9貫춭\udcaf\uddb1잳펵\udcb7", a_));
			IL_189:
			IL_1D4:
			this.h += num3;
			return num3;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000592C File Offset: 0x00003B2C
		internal byte[] a()
		{
			short num = (short)1018480244;
			short num2 = num;
			num = (short)2130101876;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1076428800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)979435520;
			if (num != 0)
			{
			}
			num = (short)1352597505;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000059E0 File Offset: 0x00003BE0
		internal void a(out int A_0)
		{
			int a_ = 18;
			while (this.e)
			{
				short num = (short)1928549313;
				short num2 = num;
				num = (short)9851841;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1380515841;
					if (num != 0)
					{
					}
					num = (short)1822097408;
					if (num != 0)
					{
					}
					num = (short)1053097984;
					short num3 = num;
					A_0 = this.g;
					return;
				}
				}
			}
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("直\udfaa\udfac쪮킰\udeb2閴\udeb6쪸鮺\udebc펾껀냂ꃄꏆ", a_));
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005ABC File Offset: 0x00003CBC
		internal void a(out int A_0, out int A_1)
		{
			int a_ = 16;
			while (this.e)
			{
				short num = (short)890438399;
				short num2 = num;
				num = (short)1078657791;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1657470977;
					if (num != 0)
					{
					}
					num = (short)1953169408;
					if (num != 0)
					{
					}
					num = (short)99876864;
					short num3 = num;
					A_0 = this.g;
					A_1 = this.f;
					return;
				}
				}
			}
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udda8\ud9aa좬캮\udcb0鎲\udcb4쒶馸\ud8ba톼킾닀ꛂꇄ", a_));
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005B9C File Offset: 0x00003D9C
		internal int b()
		{
			int a_ = 12;
			while (this.e)
			{
				short num = (short)616700395;
				short num2 = num;
				num = (short)252713451;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1211760641;
					if (num != 0)
					{
					}
					num = (short)134807552;
					if (num != 0)
					{
					}
					num = (short)1212481536;
					short num3 = num;
					return this.h;
				}
				}
			}
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("톤햦첨쪪사辮\ud8b0삲閴풶햸풺캼\udabeꗀ", a_));
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005C74 File Offset: 0x00003E74
		internal int c()
		{
			int a_ = 15;
			short num = (short)896663553;
			int num2 = (int)((global::System.IntPtr)num);
			int num4;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)443257773;
					short num3 = num;
					num = (short)843355053;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_12A;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					if (num4 > this.f)
					{
						num = (short)1747386368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_181;
				case 3:
					goto IL_5A;
				}
				IL_3D:
				if (!this.e)
				{
					num = (short)583270403;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num4 = (this.h += 4);
					num = (short)1801846785;
					if (num != 0)
					{
					}
					num = (short)928776194;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5A:
			num = (short)2049638400;
			short num5 = num;
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udca7\ud8a9즫쾭\uddaf銱\uddb3억颷\ud9b9킻톽뎿ꟁꃃ", a_));
			IL_12A:
			num = (short)1669005312;
			if (num != 0)
			{
			}
			this.h = this.f;
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욧캩貫솭횯銱잳습쪷\udfb9\uddbb펽뗁ꗃ뗅룉꧋꿍돏뫑뇓닕", a_));
			IL_181:
			return (int)this.a[num4 - 4] | (int)this.a[num4 - 3] << 8 | (int)this.a[num4 - 2] << 16 | (int)this.a[num4 - 1] << 24;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005E38 File Offset: 0x00004038
		internal uint d()
		{
			int a_ = 17;
			short num = (short)984219649;
			int num2 = (int)((global::System.IntPtr)num);
			int num4;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1904626573;
					short num3 = num;
					num = (short)1666206605;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_117;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					if (num4 > this.f)
					{
						num = (short)1961361409;
						if (num != 0)
						{
						}
						num = (short)2064318464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_170;
				case 3:
					goto IL_59;
				}
				IL_3D:
				if (!this.e)
				{
					num = (short)701825027;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num4 = (this.h += 4);
					num = (short)726007810;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_59:
			num = (short)1564606464;
			short num5 = num;
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮧ\udea9\udeab쮭톯\udfb1钳\udfb5쮷骹\udfbb튽꾿뇁ꇃꋅ", a_));
			IL_117:
			num = (short)1915486208;
			if (num != 0)
			{
			}
			this.h = this.f;
			return 0U;
			IL_170:
			return (uint)((int)this.a[num4 - 4] | (int)this.a[num4 - 3] << 8 | (int)this.a[num4 - 2] << 16 | (int)this.a[num4 - 1] << 24);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005FE8 File Offset: 0x000041E8
		internal int e()
		{
			int a_ = 15;
			short num = (short)511967233;
			int num2 = (int)((global::System.IntPtr)num);
			int num4;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1593059086;
					short num3 = num;
					num = (short)1342580494;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_12F;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 2:
					if (num4 > this.f)
					{
						num = (short)835911680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_185;
				case 3:
					goto IL_5C;
				}
				IL_3E:
				if (!this.e)
				{
					num = (short)552009731;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num4 = (this.h += 2);
					num = (short)1727463426;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5C:
			num = (short)346226689;
			if (num != 0)
			{
			}
			num = (short)1815609344;
			short num5 = num;
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udca7\ud8a9즫쾭\uddaf銱\uddb3억颷\ud9b9킻톽뎿ꟁꃃ", a_));
			IL_12F:
			num = (short)1311637504;
			if (num != 0)
			{
			}
			this.h = this.f;
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욧캩貫솭횯銱잳습쪷\udfb9\uddbb펽뗁ꗃ뗅룉꧋꿍돏뫑뇓닕", a_));
			IL_185:
			return (int)this.a[num4 - 2] << 16 | (int)this.a[num4 - 1] << 24;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006198 File Offset: 0x00004398
		internal ushort f()
		{
			int a_ = 4;
			short num = (short)1955856385;
			int num2 = (int)((global::System.IntPtr)num);
			int num4;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)258697055;
					short num3 = num;
					num = (short)1374906207;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_FE;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					if (num4 > this.f)
					{
						num = (short)576258048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17B;
				case 3:
					goto IL_59;
				}
				IL_3D:
				if (!this.e)
				{
					num = (short)489422851;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num4 = (this.h += 2);
					num = (short)333316098;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_59:
			num = (short)464846848;
			short num5 = num;
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좚쒠슢좤螦삨\ud8aa趬첮\uddb0\udcb2운튶\uddb8", a_));
			IL_FE:
			num = (short)2013790208;
			if (num != 0)
			{
			}
			num = (short)782303233;
			if (num != 0)
			{
			}
			this.h = this.f;
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ude9aﮞ膠첢쎤螦\udaa8\udfaa\udfac쪮킰\udeb2閴삶\ud8b8좺鶼춾꓀ꋂꛄ꿆곈꿊", a_));
			IL_17B:
			return (ushort)((int)this.a[num4 - 2] << 16 | (int)this.a[num4 - 1] << 24);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000633C File Offset: 0x0000453C
		public override int Read(byte[] buffer, int offset, int count)
		{
			int a_ = 10;
			short num = (short)715718675;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_AB;
				case 1:
					if (buffer == null)
					{
						num = (short)201195529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)870055939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_205;
				case 3:
					if (offset < 0)
					{
						num = (short)1108475910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2031681543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_39D;
				case 5:
					num = (short)139132940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_13E;
				case 7:
					if (count < 0)
					{
						num = (short)211484680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)225443861;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_2D3;
				case 9:
					goto IL_35D;
				case 10:
					if (num3 <= 0)
					{
						num = (short)1859977232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1968046100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					int num4 = num3;
					num = (short)17629197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					goto IL_1A1;
				case 13:
					goto IL_205;
				case 14:
				{
					int num4;
					if (--num4 < 0)
					{
						num = (short)1222705157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					buffer[offset + num4] = this.a[this.h + num4];
					num = (short)1962541058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
					num3 = count;
					num = (short)904200210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_3F7;
				case 17:
					goto IL_270;
				case 18:
					goto IL_3C0;
				case 19:
					switch (0)
					{
					case 0:
						goto IL_89;
					}
					continue;
				case 20:
					if (num3 <= 8)
					{
						num = (short)498008075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Buffer.BlockCopy(this.a, this.h, buffer, offset, num3);
					num = (short)1972502545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (buffer.Length - offset < count)
					{
						num = (short)1047920644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = this.f - this.h;
					num = (short)366215190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (num3 > count)
					{
						num = (short)1021247503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C0;
				}
				IL_89:
				if (!this.e)
				{
					num = (short)853475328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1338572800;
				short num5 = num;
				num = (short)171966465;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_205:
				num = (short)293797902;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C0:
				num = (short)2023555082;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AB:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("힢힤슦좨욪趬욮슰鎲횴\udbb6횸좺\ud8bc\udbbe", a_));
			IL_13E:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캠얢쎤풦첨\udfaa", a_));
			IL_1A1:
			IL_270:
			goto IL_45B;
			IL_2D3:
			num = (short)436404225;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슠첢키즦\udda8", a_));
			IL_35D:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쎠횢쎤솦첨\ud9aa", a_));
			IL_39D:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춢펤욦얨슪즬辮\udeb0햲펴쒶\udcb8쾺鶼펾꓀귂ꋄ돆ꇈ", a_));
			IL_3F7:
			num = (short)1074280800;
			short num6 = num;
			num = (short)2013215072;
			switch ((num6 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)633798656;
				if (num != 0)
				{
				}
				break;
			}
			return 0;
			IL_45B:
			this.h += num3;
			return num3;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000067B4 File Offset: 0x000049B4
		public override int ReadByte()
		{
			int a_ = 3;
			short num = (short)255197185;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1542237311;
				short num3 = num;
				num = (short)1504291967;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)901840896;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_117;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					case 2:
						if (this.h >= this.f)
						{
							num = (short)1489371136;
							short num4 = num;
							num = (short)267386880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_156;
					case 3:
						goto IL_A6;
					}
					IL_89:
					if (!this.e)
					{
						num = (short)969605123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				num = (short)1036320770;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A6:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즙얟쎡즣蚥솧\ud9a9貫춭\udcaf\uddb1잳펵\udcb7", a_));
			IL_117:
			num = (short)1823604737;
			if (num != 0)
			{
			}
			return -1;
			IL_156:
			byte[] array = this.a;
			int num5 = this.h;
			this.h = num5 + 1;
			return array[num5];
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006930 File Offset: 0x00004B30
		public override long Seek(long offset, global::System.IO.SeekOrigin loc)
		{
			int a_ = 17;
			short num = (short)1229193228;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)817656089;
				short num3 = num;
				num = (short)1352954137;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_286;
				default:
					num = (short)873725952;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_2CD;
					case 1:
						switch (loc)
						{
						case global::System.IO.SeekOrigin.Begin:
							num = (short)1161756678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::System.IO.SeekOrigin.Current:
							num = (short)1219231749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::System.IO.SeekOrigin.End:
							num = (short)2065891335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)2104033290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 2:
						goto IL_336;
					case 3:
						goto IL_150;
					case 4:
						goto IL_361;
					case 5:
						if (offset + (long)this.h < (long)this.g)
						{
							num = (short)1654390787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.h += (int)offset;
						num = (short)276430859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (offset < 0L)
						{
							num = (short)802684930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.h = this.g + (int)offset;
						num = (short)1958412292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if ((long)this.f + offset < (long)this.g)
						{
							num = (short)1980497920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.h = this.f + (int)offset;
						num = (short)208273416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_286;
					case 9:
						if (offset > 2147483647L)
						{
							num = (short)1647509519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1304690689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)734986254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_10A;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_BA;
						}
						continue;
					case 13:
						goto IL_DD;
					case 14:
						goto IL_2EA;
					case 15:
						goto IL_1DC;
					}
					IL_BA:
					if (!this.e)
					{
						num = (short)674562061;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)917700617;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_DD:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮧ\udea9\udeab쮭톯\udfb1钳\udfb5쮷骹\udfbb튽꾿뇁ꇃꋅ", a_));
			IL_10A:
			goto IL_38D;
			IL_150:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮧ쾩즫얭邯킱톳킵ힷ좹\ud9bb麽ꊿꟁꏃ꿅ꛇ", a_));
			IL_1DC:
			num = (short)781058049;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("잧첩쪫\uddad햯욱", a_));
			IL_286:
			goto IL_38D;
			IL_2CD:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮧ쾩즫얭邯킱톳킵ힷ좹\ud9bb麽ꊿꟁꏃ꿅ꛇ", a_));
			IL_2EA:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒧얩쾫", a_));
			IL_336:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮧ쾩즫얭邯킱톳킵ힷ좹\ud9bb麽ꊿꟁꏃ꿅ꛇ", a_));
			IL_361:
			num = (short)2005598208;
			short num4 = num;
			IL_38D:
			return (long)this.h;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006CD4 File Offset: 0x00004ED4
		public override void SetLength(long value)
		{
			int a_ = 1;
			short num = (short)703463430;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					if (value > 2147483647L - (long)this.g)
					{
						num = (short)1810432007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = this.g + (int)value;
					num = (short)930545665;
					if (num != 0)
					{
					}
					num = (short)1796603919;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1F8;
				case 2:
					num = (short)1906180101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_8C;
				case 4:
					global::System.Array.Clear(this.a, this.f, num3 - this.f);
					goto IL_1BE;
				case 5:
					if (num3 > this.f)
					{
						num = (short)685572100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14C;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 7:
					goto IL_23E;
				case 8:
					if (this.h > num3)
					{
						num = (short)459341838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					if (value >= 0L)
					{
						num = (short)444727307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CF;
				case 10:
					goto IL_14C;
				case 11:
					num = (short)1793589248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					num = (short)1102943513;
					short num4 = num;
					num = (short)1470403865;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1BE;
					default:
						goto IL_278;
					}
					break;
				}
				case 13:
					if (value > 2147483647L)
					{
						num = (short)1152843788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1711013897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					this.h = num3;
					num = (short)545849345;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (!this.a(num3))
					{
						num = (short)955973634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14C;
				}
				IL_6D:
				if (!this.i)
				{
					num = (short)2131623939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1793130509;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14C:
				this.f = num3;
				num = (short)497287176;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BE:
				num = (short)1363869706;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8C:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾗얟芡쪣즥\udca7誩\udfab\udbad삯슱\udbb3쒵첷\udfb9\ud8bb", a_));
			IL_CF:
			num = (short)120127488;
			short num5 = num;
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮙ얟", a_));
			IL_1F8:
			return;
			IL_23E:
			goto IL_CF;
			IL_278:
			num = (short)417595392;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮙ얟", a_));
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00007030 File Offset: 0x00005230
		public virtual byte[] ToArray()
		{
			short num = (short)1387424206;
			short num2 = num;
			num = (short)662727118;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1793654784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)580452353;
			if (num != 0)
			{
			}
			num = (short)1179779072;
			if (num != 0)
			{
			}
			byte[] array = new byte[this.f - this.g];
			global::System.Buffer.BlockCopy(this.a, this.g, array, 0, this.f - this.g);
			return array;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000710C File Offset: 0x0000530C
		public override void Write(byte[] buffer, int offset, int count)
		{
			int a_ = 15;
			short num = (short)463142921;
			int num2 = (int)((global::System.IntPtr)num);
			int num4;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_594;
				case 1:
					if (offset < 0)
					{
						num = (short)2120613890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)428736529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1085001837;
					short num3 = num;
					num = (short)837144685;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_594;
					default:
						goto IL_2C4;
					}
					break;
				}
				case 3:
					goto IL_52B;
				case 4:
					if (this.a(num4))
					{
						num = (short)634257440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				case 5:
					num = (short)634322948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_43B;
				case 7:
					num = (short)100401174;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (buffer.Length - offset < count)
					{
						num = (short)2089877535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num4 = this.h + count;
					num = (short)105316367;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_B2;
					}
					continue;
				case 10:
					goto IL_49B;
				case 11:
					if (count <= 8)
					{
						num = (short)638713882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Buffer.BlockCopy(buffer, offset, this.a, this.h, count);
					num = (short)198836242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_569;
				case 13:
					if (num4 > this.b)
					{
						num = (short)363528197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				case 14:
				{
					int num5;
					if (--num5 < 0)
					{
						num = (short)481820679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a[this.h + num5] = buffer[offset + num5];
					num = (short)555548701;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
					if (num4 < 0)
					{
						num = (short)1684733962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2008547344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (num4 > this.f)
					{
						num = (short)1635975196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3FF;
				case 17:
					if (count < 0)
					{
						num = (short)1872691203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)497090568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_349;
				case 19:
					if (!this.i)
					{
						num = (short)1152319500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)364183577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
				{
					bool flag;
					if (flag)
					{
						num = (short)823328798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43B;
				}
				case 21:
					goto IL_1F6;
				case 22:
					goto IL_249;
				case 23:
					goto IL_FF;
				case 24:
					goto IL_3E9;
				case 25:
					if (buffer == null)
					{
						num = (short)583729176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1152319489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
				{
					int num5 = count;
					num = (short)1176698880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 27:
					goto IL_3FF;
				case 28:
				{
					bool flag = this.h > this.f;
					num = (short)1074200589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 29:
					goto IL_594;
				case 30:
					global::System.Array.Clear(this.a, this.f, num4 - this.f);
					num = (short)2131230726;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					goto IL_387;
				case 32:
				{
					bool flag = false;
					num = (short)1982464021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_B2:
				num = (short)1395458048;
				short num6 = num;
				if (!this.e)
				{
					num = (short)2073952279;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)919666707;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F6:
				num = (short)1678835732;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3FF:
				num = (short)1397555211;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_43B:
				this.f = num4;
				num = (short)1690239003;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_594:
				num = (short)1915027470;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FF:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udca7\ud8a9즫쾭\uddaf銱\uddb3억颷\ud9b9킻톽뎿ꟁꃃ", a_));
			IL_249:
			goto IL_605;
			IL_2C4:
			num = (short)2024341504;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즥캧첩\udfab쮭쒯", a_));
			IL_349:
			goto IL_605;
			IL_387:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욧\udca9춫슭\ud9af횱钳\ud9b5\udeb7\udcb9쾻\udbbd뒿ꣃꏅꛇ귉룋ꛍ", a_));
			IL_3E9:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒥\udda7첩쪫쮭슯", a_));
			IL_49B:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udca7\ud8a9즫쾭\uddaf銱삳\ud9b5ힷ骹킻톽꺿ꗁ", a_));
			IL_52B:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얥잧\udfa9슫\udaad", a_));
			IL_569:
			num = (short)1898840065;
			if (num != 0)
			{
			}
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udaa7쎩\ud8ab쮭邯\udcb1\udbb3습颷즹즻캽낿귁뛃닅귇껉", a_));
			IL_605:
			this.h = num4;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00007728 File Offset: 0x00005928
		public override void WriteByte(byte value)
		{
			int a_ = 6;
			short num = (short)736886789;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					num = (short)1556086785;
					if (num != 0)
					{
					}
					goto IL_246;
				case 1:
					goto IL_265;
				case 2:
					goto IL_89;
				case 3:
				{
					num3 = this.h + 1;
					bool flag = this.h > this.f;
					num = (short)1823801353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					bool flag;
					if (flag)
					{
						num = (short)2129854476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_246;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					continue;
				case 6:
					goto IL_8E;
				case 7:
					num = (short)123142154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (!this.i)
					{
						num = (short)259915776;
						short num4 = num;
						num = (short)227868685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1818624014;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (num3 >= this.b)
					{
						num = (short)1544552455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8E;
				case 10:
					if (this.a(num3))
					{
						num = (short)1404502027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8E;
				case 11:
				{
					bool flag = false;
					num = (short)510853126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
				{
					num = (short)1682696589;
					short num5 = num;
					num = (short)1422190989;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_24D;
					default:
						num = (short)1110507520;
						if (num != 0)
						{
						}
						global::System.Array.Clear(this.a, this.f, this.h - this.f);
						num = (short)1275854848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					goto IL_1B0;
				case 14:
					if (this.h >= this.f)
					{
						num = (short)1451819011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_317;
				}
				IL_69:
				if (!this.e)
				{
					num = (short)1766195202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1190133768;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8E:
				num = (short)637796356;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_24D:
				num = (short)334430209;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_246:
				this.f = num3;
				goto IL_24D;
			}
			IL_89:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캜펠욢쒤쪦覨슪\udeac辮튰\udfb2\udab4쒶\udcb8\udfba", a_));
			IL_1B0:
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪜좠힢삤螦잨쒪\ud9ac辮슰욲어잶횸즺즼\udabeꗀ", a_));
			IL_265:
			IL_317:
			byte[] array = this.a;
			int num6 = this.h;
			this.h = num6 + 1;
			array[num6] = value;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00007A68 File Offset: 0x00005C68
		public virtual void WriteTo(global::System.IO.Stream stream)
		{
			int a_ = 7;
			short num = (short)644481025;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1704787968;
					short num3 = num;
					if (stream == null)
					{
						num = (short)1900347395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15C;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3F;
					}
					continue;
				case 2:
					goto IL_5D;
				case 3:
					goto IL_143;
				}
				IL_3F:
				if (!this.e)
				{
					num = (short)479592450;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1117435846;
					short num4 = num;
					num = (short)543733702;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)508887040;
						if (num != 0)
						{
						}
						num = (short)2059599872;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_5D:
			num = (short)1957625857;
			if (num != 0)
			{
			}
			throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춝풟킡솣장얧誩얫\uddad邯톱\ud8b3\ud9b5쮷\udfb9\ud8bb", a_));
			IL_143:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풟킡솣장얧", a_));
			IL_15C:
			stream.Write(this.a, this.g, this.f - this.g);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00007BF0 File Offset: 0x00005DF0
		public override bool CanRead
		{
			get
			{
				short num = (short)943849381;
				short num2 = num;
				num = (short)267321253;
				switch (num2 == num)
				{
				default:
				{
					num = (short)306184192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1158021121;
				if (num != 0)
				{
				}
				num = (short)1022164992;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00007C9C File Offset: 0x00005E9C
		public override bool CanSeek
		{
			get
			{
				short num = (short)738392486;
				short num2 = num;
				num = (short)1400502694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1235091456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)163708929;
				if (num != 0)
				{
				}
				num = (short)109838336;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00007D4C File Offset: 0x00005F4C
		public override bool CanWrite
		{
			get
			{
				short num = (short)447461491;
				short num2 = num;
				num = (short)523221107;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1156055040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1652293632;
				if (num != 0)
				{
				}
				num = (short)1657602049;
				if (num != 0)
				{
				}
				return this.i;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00007DFC File Offset: 0x00005FFC
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00007EDC File Offset: 0x000060DC
		public virtual int Capacity
		{
			get
			{
				int a_ = 5;
				short num;
				for (;;)
				{
					num = (short)175702016;
					short num2 = num;
					if (this.e)
					{
						goto IL_C4;
					}
					num = (short)1558839297;
					if (num != 0)
					{
					}
					num = (short)1410269249;
					short num3 = num;
					num = (short)181993537;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9B;
					}
				}
				IL_9B:
				num = (short)2007891968;
				if (num != 0)
				{
				}
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾛튟잡얣쮥袧쎩\udfab躭펯\udeb1\udbb3억\uddb7\udeb9", a_));
				IL_C4:
				return this.b - this.g;
			}
			set
			{
				int a_ = 11;
				short num = (short)2127757318;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte[] dst;
					switch (num2)
					{
					case 0:
						if (this.f > 0)
						{
							num = (short)1652228103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F6;
					case 1:
						num = (short)789708812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1945894913;
						if (num != 0)
						{
						}
						if (value < this.f)
						{
							num = (short)1767374857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)261619716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_8E;
					case 4:
						if (value > 0)
						{
							num = (short)1141964813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a = null;
						num = (short)1621819406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_2F6;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 7:
						global::System.Buffer.BlockCopy(this.a, 0, dst, 0, this.f);
						num = (short)275447813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_136;
					case 9:
						goto IL_2E0;
					case 10:
						if (value != this.b)
						{
							num = (short)27525121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						goto IL_25A;
					case 12:
						if (!this.c)
						{
							num = (short)2003763208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1674838018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						dst = new byte[value];
						num = (short)916127744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)940089604;
						short num3 = num;
						num = (short)983081220;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2E2;
						default:
							num = (short)296222720;
							if (num != 0)
							{
							}
							goto IL_25A;
						}
						break;
					}
					case 15:
						goto IL_279;
					}
					IL_6D:
					if (!this.e)
					{
						num = (short)1074528259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1912340480;
					short num4 = num;
					num = (short)108593162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25A:
					this.b = value;
					num = (short)691798031;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F6:
					this.a = dst;
					num = (short)1951137803;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_8E:
				goto IL_2E2;
				IL_136:
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솣쮥잧\ud8a9햫躭쎯욱욳펵\ud9b7ힹ鲻킽꾿뛁ꏅ냇뫉귋ꃍ듏돑뛓뫕뷗", a_));
				IL_279:
				return;
				IL_2E0:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풡얣쪥\udda7쾩", a_));
				IL_2E2:
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("킣풥춧쮩솫躭\ud9af솱钳햵풷햹쾻\udbbd꒿", a_));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000822C File Offset: 0x0000642C
		public override long Length
		{
			get
			{
				int a_ = 10;
				short num;
				for (;;)
				{
					num = (short)1394802688;
					short num2 = num;
					if (this.e)
					{
						goto IL_C6;
					}
					num = (short)2093547521;
					if (num != 0)
					{
					}
					num = (short)315132364;
					short num3 = num;
					num = (short)1711573452;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9C;
					}
				}
				IL_9C:
				num = (short)1921122304;
				if (num != 0)
				{
				}
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("힢힤슦좨욪趬욮슰鎲횴\udbb6횸좺\ud8bc\udbbe", a_));
				IL_C6:
				return (long)(this.f - this.g);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00008310 File Offset: 0x00006510
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000083F4 File Offset: 0x000065F4
		public override long Position
		{
			get
			{
				int a_ = 10;
				short num;
				for (;;)
				{
					num = (short)809697280;
					short num2 = num;
					if (this.e)
					{
						goto IL_C6;
					}
					num = (short)1155139544;
					short num3 = num;
					num = (short)1870071768;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_76;
					}
				}
				IL_76:
				num = (short)545587201;
				if (num != 0)
				{
				}
				num = (short)102170624;
				if (num != 0)
				{
				}
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("힢힤슦좨욪趬욮슰鎲횴\udbb6횸좺\ud8bc\udbbe", a_));
				IL_C6:
				return (long)(this.h - this.g);
			}
			set
			{
				int a_ = 17;
				short num = (short)331677697;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1AF;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 2:
						goto IL_9D;
					case 3:
					{
						num = (short)1757879758;
						short num3 = num;
						num = (short)1020337614;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_197;
						default:
							goto IL_EA;
						}
						break;
					}
					case 4:
						if (value > 2147483647L)
						{
							num = (short)981991426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4;
					case 5:
						if (value < 0L)
						{
							goto IL_197;
						}
						num = (short)1116471300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_45:
					if (!this.e)
					{
						num = (short)838467587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1568735232;
					short num4 = num;
					num = (short)835846145;
					if (num != 0)
					{
					}
					num = (short)292749317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_197:
					num = (short)1506279424;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9D:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udea7쮩삫\udbad햯", a_));
				IL_EA:
				num = (short)1477312512;
				if (num != 0)
				{
				}
				throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮧ\udea9\udeab쮭톯\udfb1钳\udfb5쮷骹\udfbb튽꾿뇁ꇃꋅ", a_));
				IL_1AF:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udea7쮩삫\udbad햯", a_));
				IL_1B4:
				this.h = this.g + (int)value;
			}
		}

		// Token: 0x04000010 RID: 16
		private byte[] a;

		// Token: 0x04000011 RID: 17
		private int b;

		// Token: 0x04000012 RID: 18
		private bool c;

		// Token: 0x04000013 RID: 19
		private bool d;

		// Token: 0x04000014 RID: 20
		private bool e;

		// Token: 0x04000015 RID: 21
		private int f;

		// Token: 0x04000016 RID: 22
		private int g;

		// Token: 0x04000017 RID: 23
		private int h;

		// Token: 0x04000018 RID: 24
		private bool i;

		// Token: 0x04000019 RID: 25
		private const long j = 2147483647L;
	}
}
