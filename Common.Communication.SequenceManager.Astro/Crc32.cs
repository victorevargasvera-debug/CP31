using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Motorola.Common.Communication
{
	// Token: 0x02000014 RID: 20
	public sealed class Crc32 : global::System.Security.Cryptography.HashAlgorithm
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00019834 File Offset: 0x00017A34
		public Crc32() : this(3988292384U, uint.MaxValue)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00019850 File Offset: 0x00017A50
		public Crc32(uint polynomial, uint seed)
		{
			this.c = global::Motorola.Common.Communication.Crc32.b(polynomial);
			this.d = seed;
			this.b = seed;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00019880 File Offset: 0x00017A80
		public override void Initialize()
		{
			short num = (short)886323778;
			short num2 = num;
			num = (short)814234178;
			switch (num2 == num)
			{
			}
			num = (short)543424512;
			if (num != 0)
			{
			}
			num = (short)114163713;
			if (num != 0)
			{
			}
			num = (short)1802829824;
			short num3 = num;
			this.d = this.b;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00019934 File Offset: 0x00017B34
		protected override void HashCore(byte[] buffer, int start, int length)
		{
			short num = (short)1679095210;
			short num2 = num;
			num = (short)1175123370;
			switch (num2 == num)
			{
			}
			num = (short)502857728;
			if (num != 0)
			{
			}
			num = (short)2089811969;
			if (num != 0)
			{
			}
			num = (short)1561395200;
			short num3 = num;
			this.d = global::Motorola.Common.Communication.Crc32.a(this.c, this.d, buffer, start, length);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000199F8 File Offset: 0x00017BF8
		protected override byte[] HashFinal()
		{
			short num = (short)1203312389;
			short num2 = num;
			num = (short)2126649093;
			switch (num2 == num)
			{
			}
			num = (short)1677787136;
			if (num != 0)
			{
			}
			num = (short)516489217;
			if (num != 0)
			{
			}
			num = (short)135856128;
			short num3 = num;
			byte[] array = global::Motorola.Common.Communication.Crc32.a(~this.d);
			this.HashValue = array;
			return array;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00019AB8 File Offset: 0x00017CB8
		public override int HashSize
		{
			get
			{
				short num = (short)318428020;
				short num2 = num;
				num = (short)1269420916;
				switch (num2 == num)
				{
				}
				num = (short)1246625793;
				if (num != 0)
				{
				}
				num = (short)1822752768;
				if (num != 0)
				{
				}
				num = (short)144441344;
				short num3 = num;
				return 32;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00019B64 File Offset: 0x00017D64
		public static uint Compute(byte[] buffer)
		{
			short num = (short)350355457;
			if (num != 0)
			{
			}
			num = (short)595488121;
			short num2 = num;
			num = (short)1312779641;
			switch (num2 == num)
			{
			}
			num = (short)1422262272;
			if (num != 0)
			{
			}
			num = (short)1520435200;
			short num3 = num;
			return global::Motorola.Common.Communication.Crc32.Compute(uint.MaxValue, buffer);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00019C14 File Offset: 0x00017E14
		public static uint Compute(uint seed, byte[] buffer)
		{
			short num = (short)1184121644;
			short num2 = num;
			num = (short)386810668;
			switch (num2 == num)
			{
			}
			num = (short)628817921;
			if (num != 0)
			{
			}
			num = (short)571867136;
			if (num != 0)
			{
			}
			num = (short)2001010688;
			short num3 = num;
			return global::Motorola.Common.Communication.Crc32.Compute(3988292384U, seed, buffer);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00019CCC File Offset: 0x00017ECC
		public static uint Compute(uint polynomial, uint seed, byte[] buffer)
		{
			short num = (short)1983343927;
			short num2 = num;
			num = (short)673869111;
			switch (num2 == num)
			{
			}
			num = (short)925761536;
			if (num != 0)
			{
			}
			num = (short)570687489;
			if (num != 0)
			{
			}
			num = (short)746651648;
			short num3 = num;
			return ~global::Motorola.Common.Communication.Crc32.a(global::Motorola.Common.Communication.Crc32.b(polynomial), seed, buffer, 0, buffer.Length);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00019D84 File Offset: 0x00017F84
		private static uint[] b(uint A_0)
		{
			short num = (short)1966931968;
			switch (num)
			{
			default:
			{
				num = (short)755957774;
				int num2 = (int)((global::System.IntPtr)num);
				uint[] array;
				for (;;)
				{
					int num4;
					int num5;
					switch (num2)
					{
					case 0:
						goto IL_1EF;
					case 1:
					{
						uint num3 = num3 >> 1 ^ A_0;
						num = (short)1172635655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_192;
					case 3:
						if (A_0 == 3988292384U)
						{
							goto IL_172;
						}
						return array;
					case 4:
						goto IL_238;
					case 5:
						if (num4 >= 8)
						{
							num = (short)431423499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)449183756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						global::Motorola.Common.Communication.Crc32.a = array;
						num = (short)804782080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_2C0;
					case 8:
					{
						if (num5 >= 256)
						{
							num = (short)2024865810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num3 = (uint)num5;
						num4 = 0;
						num = (short)78577666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)399048705;
						if (num != 0)
						{
						}
						goto IL_2C0;
					case 10:
						if (global::Motorola.Common.Communication.Crc32.a != null)
						{
							num = (short)1396047887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_124;
					case 11:
					{
						uint num3;
						array[num5] = num3;
						num5++;
						num = (short)1415315460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						uint num3;
						if ((num3 & 1U) == 1U)
						{
							num = (short)1216544769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 >>= 1;
						num = (short)2086469641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_238;
					case 14:
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 15:
						goto IL_347;
					case 16:
						goto IL_192;
					case 17:
						num = (short)351076362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						num = (short)731054294;
						short num6 = num;
						num = (short)636027094;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_172;
						default:
							num = (short)1034878976;
							if (num != 0)
							{
							}
							num = (short)1692401667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_90:
					if (A_0 == 3988292384U)
					{
						num = (short)2054488081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_124:
					array = new uint[256];
					num5 = 0;
					num = (short)1740046349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_172:
					num = (short)1029308422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_192:
					num = (short)185335813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_238:
					num = (short)438697992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C0:
					num = (short)112263168;
					short num7 = num;
					num4++;
					num = (short)129040400;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1EF:
				return array;
				IL_347:
				return global::Motorola.Common.Communication.Crc32.a;
			}
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0001A120 File Offset: 0x00018320
		private static uint a(uint[] A_0, uint A_1, global::System.Collections.Generic.IList<byte> A_2, int A_3, int A_4)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			int num3;
			uint num4;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_B2;
				case 1:
					num2 = (short)946995201;
					if (num2 != 0)
					{
					}
					if (num3 >= A_4 - A_3)
					{
						goto IL_F8;
					}
					num4 = (num4 >> 8 ^ A_0[(int)((uint)A_2[num3] ^ (num4 & 255U))]);
					num3++;
					num2 = (short)1643184128;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_B2;
				case 3:
					return num4;
				}
				goto IL_20;
				IL_B2:
				num2 = (short)2044198913;
				num = (int)((global::System.IntPtr)num2);
			}
			return num4;
			IL_20:
			num2 = (short)1696071680;
			short num5 = num2;
			num4 = A_1;
			num3 = A_3;
			num2 = (short)1596184249;
			short num6 = num2;
			num2 = (short)965990073;
			switch ((num6 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F8:
				num2 = (short)1460666371;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1007616000;
				if (num2 != 0)
				{
				}
				num2 = (short)304349186;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0001A278 File Offset: 0x00018478
		private static byte[] a(uint A_0)
		{
			short num = (short)1247739401;
			short num2 = num;
			num = (short)1688403465;
			switch (num2 == num)
			{
			}
			num = (short)1708916737;
			if (num != 0)
			{
			}
			num = (short)2070151168;
			if (num != 0)
			{
			}
			num = (short)1809317888;
			short num3 = num;
			return global::System.BitConverter.GetBytes(A_0);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0001A328 File Offset: 0x00018528
		internal static string c(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1755740429 + A_1) + (global::System.IntPtr)31 + (global::System.IntPtr)69 + (global::System.IntPtr)41);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
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
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x04000090 RID: 144
		public const uint DefaultPolynomial = 3988292384U;

		// Token: 0x04000091 RID: 145
		public const uint DefaultSeed = 4294967295U;

		// Token: 0x04000092 RID: 146
		private static uint[] a;

		// Token: 0x04000093 RID: 147
		private readonly uint b;

		// Token: 0x04000094 RID: 148
		private readonly uint[] c;

		// Token: 0x04000095 RID: 149
		private uint d;
	}
}
