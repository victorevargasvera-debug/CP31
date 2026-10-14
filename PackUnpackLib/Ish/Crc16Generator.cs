using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000015 RID: 21
	public sealed class Crc16Generator : global::Motorola.Acp.PackUnpack.Ish.ICrcGenerator<short>, global::System.IDisposable
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x0000FF14 File Offset: 0x0000E114
		public Crc16Generator()
		{
			int a_ = 17;
			base..ctor();
			this.a = new global::Motorola.Acp.PackUnpack.CrcPolynomial(4129, 3, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("킧鶫颭邯馱钳캵讹躻麽볃飅ﷇ", a_));
			this.b = new ushort[]
			{
				0,
				4129,
				8258,
				12387,
				16516,
				20645,
				24774,
				28903,
				33032,
				37161,
				41290,
				45419,
				49548,
				53677,
				57806,
				61935,
				4657,
				528,
				12915,
				8786,
				21173,
				17044,
				29431,
				25302,
				37689,
				33560,
				45947,
				41818,
				54205,
				50076,
				62463,
				58334,
				9314,
				13379,
				1056,
				5121,
				25830,
				29895,
				17572,
				21637,
				42346,
				46411,
				34088,
				38153,
				58862,
				62927,
				50604,
				54669,
				13907,
				9842,
				5649,
				1584,
				30423,
				26358,
				22165,
				18100,
				46939,
				42874,
				38681,
				34616,
				63455,
				59390,
				55197,
				51132,
				18628,
				22757,
				26758,
				30887,
				2112,
				6241,
				10242,
				14371,
				51660,
				55789,
				59790,
				63919,
				35144,
				39273,
				43274,
				47403,
				23285,
				19156,
				31415,
				27286,
				6769,
				2640,
				14899,
				10770,
				56317,
				52188,
				64447,
				60318,
				39801,
				35672,
				47931,
				43802,
				27814,
				31879,
				19684,
				23749,
				11298,
				15363,
				3168,
				7233,
				60846,
				64911,
				52716,
				56781,
				44330,
				48395,
				36200,
				40265,
				32407,
				28342,
				24277,
				20212,
				15891,
				11826,
				7761,
				3696,
				65439,
				61374,
				57309,
				53244,
				48923,
				44858,
				40793,
				36728,
				37256,
				33193,
				45514,
				41451,
				53516,
				49453,
				61774,
				57711,
				4224,
				161,
				12482,
				8419,
				20484,
				16421,
				28742,
				24679,
				33721,
				37784,
				41979,
				46042,
				49981,
				54044,
				58239,
				62302,
				689,
				4752,
				8947,
				13010,
				16949,
				21012,
				25207,
				29270,
				46570,
				42443,
				38312,
				34185,
				62830,
				58703,
				54572,
				50445,
				13538,
				9411,
				5280,
				1153,
				29798,
				25671,
				21540,
				17413,
				42971,
				47098,
				34713,
				38840,
				59231,
				63358,
				50973,
				55100,
				9939,
				14066,
				1681,
				5808,
				26199,
				30326,
				17941,
				22068,
				55628,
				51565,
				63758,
				59695,
				39368,
				35305,
				47498,
				43435,
				22596,
				18533,
				30726,
				26663,
				6336,
				2273,
				14466,
				10403,
				52093,
				56156,
				60223,
				64286,
				35833,
				39896,
				43963,
				48026,
				19061,
				23124,
				27191,
				31254,
				2801,
				6864,
				10931,
				14994,
				64814,
				60687,
				56684,
				52557,
				48554,
				44427,
				40424,
				36297,
				31782,
				27655,
				23652,
				19525,
				15522,
				11395,
				7392,
				3265,
				61215,
				65342,
				53085,
				57212,
				44955,
				49082,
				36825,
				40952,
				28183,
				32310,
				20053,
				24180,
				11923,
				16050,
				3793,
				7920
			};
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000FF6C File Offset: 0x0000E16C
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1776542492;
				short num2 = num;
				num = (short)1940644636;
				switch (num2 == num)
				{
				}
				num = (short)1735720961;
				if (num != 0)
				{
				}
				num = (short)1760428032;
				if (num != 0)
				{
				}
				this.a(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)391512064;
			short num3 = num;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00010038 File Offset: 0x0000E238
		public global::Motorola.Acp.PackUnpack.CrcPolynomial Polynomial
		{
			get
			{
				short num = (short)1301465497;
				short num2 = num;
				num = (short)1150601625;
				switch (num2 == num)
				{
				}
				num = (short)496959489;
				if (num != 0)
				{
				}
				num = (short)1767833600;
				if (num != 0)
				{
				}
				num = (short)846528512;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000100E8 File Offset: 0x0000E2E8
		public short Compute(byte[] buffer, int index, int count)
		{
			int a_ = 3;
			short num = (short)393347073;
			int num2 = (int)((global::System.IntPtr)num);
			uint num5;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D1;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 2:
					goto IL_27E;
				case 3:
					goto IL_74;
				case 4:
					if (index < 0)
					{
						num = (short)85852169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1208483845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (count < 0)
					{
						num = (short)1177681922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)331022343;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)2016280577;
					if (num != 0)
					{
					}
					int num3;
					int num4;
					if (num3 >= num4)
					{
						num = (short)390856712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num5 = ((uint)this.b[(int)(checked((global::System.IntPtr)(unchecked((ulong)(num5 >> 8 ^ (uint)buffer[num3])) & 255UL)))] ^ num5 << 8);
					num3++;
					num = (short)713424906;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					if (count > buffer.Length - index)
					{
						goto IL_BA;
					}
					num5 = 0U;
					int num4 = index + count;
					int num3 = index;
					num = (short)782565387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_246;
				case 9:
					goto IL_157;
				case 10:
					goto IL_1E9;
				case 11:
					goto IL_1E9;
				}
				IL_5D:
				if (buffer == null)
				{
					num = (short)1198063619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)417134071;
				short num6 = num;
				num = (short)396031479;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)622002176;
					if (num != 0)
					{
					}
					num = (short)900136964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BA:
				num = (short)1969029120;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E9:
				num = (short)777453574;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_74:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욟잡횣", a_));
			IL_D1:
			num = (short)2125201408;
			short num7 = num;
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("蓮캟횡", a_));
			IL_157:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("瞧얟\udaa1", a_));
			IL_246:
			return (short)num5;
			IL_27E:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("蓮캟횡", a_));
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000103A0 File Offset: 0x0000E5A0
		public short Compute(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream stream)
		{
			int a_ = 10;
			short num = (short)1901395971;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_13F;
				case 1:
					goto IL_57;
				case 2:
					if (stream.Length == 0L)
					{
						num = (short)1824653312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_155;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				IL_3D:
				if (stream == null)
				{
					num = (short)859897857;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1930297346;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_57:
			num = (short)936509441;
			if (num != 0)
			{
			}
			num = (short)405740571;
			short num3 = num;
			num = (short)1026825243;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_155:
				byte[] buffer = stream.a();
				int index;
				int count;
				stream.a(out index, out count);
				return this.Compute(buffer, index, count);
			}
			default:
				num = (short)122355712;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("튠힢힤슦좨욪", a_));
			}
			IL_13F:
			num = (short)952827904;
			short num4 = num;
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("튠힢힤슦좨욪", a_));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0001051C File Offset: 0x0000E71C
		public short Compute(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream stream, int count)
		{
			int a_ = 18;
			short num = (short)1726152706;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (stream.Length != 0L)
					{
						num = (short)1893662724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2128940190;
					short num3 = num;
					num = (short)686951582;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)784269312;
						if (num != 0)
						{
						}
						num = (short)1290272771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_88;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 3:
					goto IL_1A7;
				case 4:
					if (count <= 0)
					{
						num = (short)1966080005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AC;
				case 5:
					goto IL_BD;
				}
				IL_45:
				if (stream == null)
				{
					num = (short)831848448;
					short num4 = num;
					num = (short)1708326913;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1300234240;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_88:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udaa8\udfaa\udfac쪮킰\udeb2", a_));
			IL_BD:
			num = (short)1790509057;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪨쒪\ud8ac솮얰", a_));
			IL_1A7:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udaa8\udfaa\udfac쪮킰\udeb2", a_));
			IL_1AC:
			short result = this.Compute(stream.a(), stream.b(), count);
			stream.b(count);
			return result;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000106F0 File Offset: 0x0000E8F0
		public short Compute(int count, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream stream)
		{
			int a_ = 9;
			short num = (short)76013976;
			short num2 = num;
			num = (short)2034557336;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)735379456;
				if (num != 0)
				{
				}
				if (stream == null)
				{
					num = (short)1449656321;
					if (num != 0)
					{
					}
					num = (short)1002504192;
					short num3 = num;
					throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펟횡횣쎥즧잩", a_));
				}
				break;
			}
			byte[] buffer = stream.a();
			int index;
			int num4;
			stream.a(out index, out num4);
			return this.Compute(buffer, index, count);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000107D8 File Offset: 0x0000E9D8
		void global::System.IDisposable.Dispose()
		{
			short num = (short)595126405;
			short num2 = num;
			num = (short)128772229;
			switch (num2 == num)
			{
			}
			num = (short)810549249;
			if (num != 0)
			{
			}
			num = (short)780664832;
			short num3 = num;
			num = (short)1123745792;
			if (num != 0)
			{
			}
			this.a(true);
			this.c = true;
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00010894 File Offset: 0x0000EA94
		private void a(bool A_0)
		{
			short num = (short)633077761;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_DB;
				case 1:
				{
					num = (short)611499077;
					short num3 = num;
					num = (short)1995553861;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9E;
					default:
						num = (short)427098112;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					}
					break;
				}
				case 2:
					goto IL_9E;
				}
				IL_7B:
				if (!this.c)
				{
					num = (short)818479106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_9E:
				num = (short)155123712;
				short num4 = num;
				num = (short)1294139392;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DB:
			num = (short)1480327169;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000037 RID: 55
		private global::Motorola.Acp.PackUnpack.CrcPolynomial a;

		// Token: 0x04000038 RID: 56
		private readonly ushort[] b;

		// Token: 0x04000039 RID: 57
		private bool c;
	}
}
