using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000C RID: 12
	public sealed class Crc32 : global::System.Security.Cryptography.HashAlgorithm
	{
		// Token: 0x06000062 RID: 98 RVA: 0x0000C22C File Offset: 0x0000A42C
		public Crc32() : this(3988292384U, uint.MaxValue)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000C248 File Offset: 0x0000A448
		public Crc32(uint polynomial, uint seed)
		{
			this.c = global::Motorola.Common.Communication.Crc32.b(polynomial);
			this.d = seed;
			this.b = seed;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000C278 File Offset: 0x0000A478
		public override void Initialize()
		{
			short num = (short)407633920;
			short num2 = num;
			num = (short)1607474637;
			short num3 = num;
			num = (short)1962876365;
			switch (num3 == num)
			{
			}
			num = (short)1900806145;
			if (num != 0)
			{
			}
			num = (short)1837760512;
			if (num != 0)
			{
			}
			this.d = this.b;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000C330 File Offset: 0x0000A530
		protected override void HashCore(byte[] buffer, int start, int length)
		{
			short num = (short)1807417344;
			short num2 = num;
			num = (short)312767035;
			short num3 = num;
			num = (short)1071215163;
			switch (num3 == num)
			{
			}
			num = (short)185073665;
			if (num != 0)
			{
			}
			num = (short)1140260864;
			if (num != 0)
			{
			}
			this.d = global::Motorola.Common.Communication.Crc32.a(this.c, this.d, buffer, start, length);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		protected override byte[] HashFinal()
		{
			short num = (short)1900544000;
			short num2 = num;
			num = (short)427111533;
			short num3 = num;
			num = (short)2081436781;
			switch (num3 == num)
			{
			}
			num = (short)794492928;
			if (num != 0)
			{
			}
			num = (short)1083441153;
			if (num != 0)
			{
			}
			byte[] array = global::Motorola.Common.Communication.Crc32.a(~this.d);
			this.HashValue = array;
			return array;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		public override int HashSize
		{
			get
			{
				short num = (short)363790336;
				short num2 = num;
				num = (short)556269569;
				if (num != 0)
				{
				}
				num = (short)468690858;
				short num3 = num;
				num = (short)820094890;
				switch (num3 == num)
				{
				}
				num = (short)737345536;
				if (num != 0)
				{
				}
				return 32;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000C55C File Offset: 0x0000A75C
		public static uint Compute(byte[] buffer)
		{
			short num = (short)931790848;
			short num2 = num;
			num = (short)1140866735;
			short num3 = num;
			num = (short)1434730159;
			switch (num3 == num)
			{
			}
			num = (short)69009408;
			if (num != 0)
			{
			}
			num = (short)2065629185;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.Crc32.Compute(uint.MaxValue, buffer);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000C60C File Offset: 0x0000A80C
		public static uint Compute(uint seed, byte[] buffer)
		{
			short num = (short)1139867648;
			short num2 = num;
			num = (short)1029263599;
			short num3 = num;
			num = (short)710103279;
			switch (num3 == num)
			{
			}
			num = (short)680853505;
			if (num != 0)
			{
			}
			num = (short)992149504;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.Crc32.Compute(3988292384U, seed, buffer);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000C6C4 File Offset: 0x0000A8C4
		public static uint Compute(uint polynomial, uint seed, byte[] buffer)
		{
			short num = (short)1798176768;
			short num2 = num;
			num = (short)1217003521;
			if (num != 0)
			{
			}
			num = (short)1998842983;
			short num3 = num;
			num = (short)1625287783;
			switch (num3 == num)
			{
			}
			num = (short)80543744;
			if (num != 0)
			{
			}
			return ~global::Motorola.Common.Communication.Crc32.a(global::Motorola.Common.Communication.Crc32.b(polynomial), seed, buffer, 0, buffer.Length);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000C780 File Offset: 0x0000A980
		private static uint[] b(uint A_0)
		{
			short num = (short)839974912;
			switch (num)
			{
			default:
			{
				num = (short)1714356227;
				int num2 = (int)((global::System.IntPtr)num);
				uint[] array;
				for (;;)
				{
					int num3;
					int num5;
					switch (num2)
					{
					case 0:
						num = (short)1259208712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (num3 >= 8)
						{
							num = (short)708509706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)51314700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						global::Motorola.Common.Communication.Crc32.a = array;
						num = (short)37289989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_91;
						}
						continue;
					case 4:
					{
						num = (short)484154678;
						short num4 = num;
						num = (short)1902288182;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_330;
						}
						break;
					}
					case 5:
						goto IL_1F4;
					case 6:
						if (A_0 == 3988292384U)
						{
							num = (short)1776091138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					case 7:
						goto IL_263;
					case 8:
						if (global::Motorola.Common.Communication.Crc32.a != null)
						{
							num = (short)1055457284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_128;
					case 9:
						goto IL_2A0;
					case 10:
					{
						uint num6;
						array[num5] = num6;
						num5++;
						num = (short)979566599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_263;
					case 12:
					{
						uint num6;
						if ((num6 & 1U) == 1U)
						{
							num = (short)248512526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1601830912;
						short num7 = num;
						num6 >>= 1;
						num = (short)343670793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_2A0;
					case 14:
					{
						num = (short)369950721;
						if (num != 0)
						{
						}
						uint num6 = num6 >> 1 ^ A_0;
						num = (short)1358626829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_197;
					case 16:
					{
						if (num5 >= 256)
						{
							num = (short)40632338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num6 = (uint)num5;
						num3 = 0;
						num = (short)1514471441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_197;
					case 18:
						num = (short)1403846662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_91:
					if (A_0 == 3988292384U)
					{
						num = (short)1231093760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_128:
					array = new uint[256];
					num5 = 0;
					num = (short)1201078283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_197:
					num = (short)1090912257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_263:
					num = (short)271646736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A0:
					num3++;
					num = (short)161021967;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F4:
				return array;
				IL_330:
				num = (short)54591488;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.Crc32.a;
			}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000CB18 File Offset: 0x0000AD18
		private static uint a(uint[] A_0, uint A_1, global::System.Collections.Generic.IList<byte> A_2, int A_3, int A_4)
		{
			uint num4;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num2;
				short num3;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						goto IL_B2;
					case 1:
						goto IL_B2;
					case 2:
						if (num2 >= A_4 - A_3)
						{
							num3 = (short)1997471747;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num4 = (num4 >> 8 ^ A_0[(int)((uint)A_2[num2] ^ (num4 & 255U))]);
						num2++;
						num3 = (short)2074542081;
						if (num3 != 0)
						{
						}
						num3 = (short)1332215809;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 3:
						return num4;
					}
					break;
					IL_B2:
					num3 = (short)1353515010;
					num = (int)((global::System.IntPtr)num3);
				}
				IL_20:
				num4 = A_1;
				num2 = A_3;
				num3 = (short)1326842292;
				short num5 = num3;
				num3 = (short)131465652;
				switch ((num5 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num3 = (short)1250689024;
					short num6 = num3;
					num3 = (short)1416626176;
					if (num3 != 0)
					{
					}
					num3 = (short)113967104;
					int num = (int)((global::System.IntPtr)num3);
					goto IL_0A;
				}
				}
			}
			return num4;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000CC6C File Offset: 0x0000AE6C
		private static byte[] a(uint A_0)
		{
			short num = (short)1605566464;
			short num2 = num;
			num = (short)1373239836;
			short num3 = num;
			num = (short)242350620;
			switch (num3 == num)
			{
			}
			num = (short)939458561;
			if (num != 0)
			{
			}
			num = (short)340721664;
			if (num != 0)
			{
			}
			return global::System.BitConverter.GetBytes(A_0);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		internal static string c(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1659148415 + A_1) + (global::System.IntPtr)97 + (global::System.IntPtr)76 + (global::System.IntPtr)81 + (global::System.IntPtr)65 + (global::System.IntPtr)37);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
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
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x04000049 RID: 73
		public const uint DefaultPolynomial = 3988292384U;

		// Token: 0x0400004A RID: 74
		public const uint DefaultSeed = 4294967295U;

		// Token: 0x0400004B RID: 75
		private static uint[] a;

		// Token: 0x0400004C RID: 76
		private readonly uint b;

		// Token: 0x0400004D RID: 77
		private readonly uint[] c;

		// Token: 0x0400004E RID: 78
		private uint d;
	}
}
