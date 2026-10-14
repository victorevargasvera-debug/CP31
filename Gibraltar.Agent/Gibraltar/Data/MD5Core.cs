using System;
using System.Text;

namespace Gibraltar.Data
{
	// Token: 0x020000E1 RID: 225
	internal static class MD5Core
	{
		// Token: 0x0600095B RID: 2395 RVA: 0x00015D24 File Offset: 0x00013F24
		public static byte[] GetHash(string input, global::System.Text.Encoding encoding)
		{
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input", "Unable to calculate hash over null input data");
			}
			if (encoding == null)
			{
				throw new global::System.ArgumentNullException("encoding", "Unable to calculate hash over a string without a default encoding. Consider using the GetHash(string) overload to use UTF8 Encoding");
			}
			return global::Gibraltar.Data.MD5Core.GetHash(encoding.GetBytes(input));
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00015D60 File Offset: 0x00013F60
		public static byte[] GetHash(string input)
		{
			return global::Gibraltar.Data.MD5Core.GetHash(input, new global::System.Text.UTF8Encoding());
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00015D70 File Offset: 0x00013F70
		public static string GetHashString(byte[] input)
		{
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input", "Unable to calculate hash over null input data");
			}
			return global::System.BitConverter.ToString(global::Gibraltar.Data.MD5Core.GetHash(input)).Replace("-", "");
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00015DA4 File Offset: 0x00013FA4
		public static string GetHashString(string input, global::System.Text.Encoding encoding)
		{
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input", "Unable to calculate hash over null input data");
			}
			if (encoding == null)
			{
				throw new global::System.ArgumentNullException("encoding", "Unable to calculate hash over a string without a default encoding. Consider using the GetHashString(string) overload to use UTF8 Encoding");
			}
			return global::Gibraltar.Data.MD5Core.GetHashString(encoding.GetBytes(input));
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00015DE0 File Offset: 0x00013FE0
		public static string GetHashString(string input)
		{
			return global::Gibraltar.Data.MD5Core.GetHashString(input, new global::System.Text.UTF8Encoding());
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00015DF0 File Offset: 0x00013FF0
		public static byte[] GetHash(byte[] input)
		{
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input", "Unable to calculate hash over null input data");
			}
			global::Gibraltar.Data.MD5Core.ABCDStruct abcd = default(global::Gibraltar.Data.MD5Core.ABCDStruct);
			abcd.A = 1732584193U;
			abcd.B = 4023233417U;
			abcd.C = 2562383102U;
			abcd.D = 271733878U;
			int i;
			for (i = 0; i <= input.Length - 64; i += 64)
			{
				global::Gibraltar.Data.MD5Core.GetHashBlock(input, ref abcd, i);
			}
			return global::Gibraltar.Data.MD5Core.GetHashFinalBlock(input, i, input.Length - i, abcd, (long)input.Length * 8L);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00015E84 File Offset: 0x00014084
		private static byte[] GetHashFinalBlock(byte[] input, int ibStart, int cbSize, global::Gibraltar.Data.MD5Core.ABCDStruct ABCD, long len)
		{
			byte[] array = new byte[64];
			byte[] bytes = global::System.BitConverter.GetBytes(len);
			global::System.Array.Copy(input, ibStart, array, 0, cbSize);
			array[cbSize] = 128;
			if (cbSize <= 56)
			{
				global::System.Array.Copy(bytes, 0, array, 56, 8);
				global::Gibraltar.Data.MD5Core.GetHashBlock(array, ref ABCD, 0);
			}
			else
			{
				global::Gibraltar.Data.MD5Core.GetHashBlock(array, ref ABCD, 0);
				array = new byte[64];
				global::System.Array.Copy(bytes, 0, array, 56, 8);
				global::Gibraltar.Data.MD5Core.GetHashBlock(array, ref ABCD, 0);
			}
			byte[] array2 = new byte[16];
			global::System.Array.Copy(global::System.BitConverter.GetBytes(ABCD.A), 0, array2, 0, 4);
			global::System.Array.Copy(global::System.BitConverter.GetBytes(ABCD.B), 0, array2, 4, 4);
			global::System.Array.Copy(global::System.BitConverter.GetBytes(ABCD.C), 0, array2, 8, 4);
			global::System.Array.Copy(global::System.BitConverter.GetBytes(ABCD.D), 0, array2, 12, 4);
			return array2;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00015F58 File Offset: 0x00014158
		private static void GetHashBlock(byte[] input, ref global::Gibraltar.Data.MD5Core.ABCDStruct ABCDValue, int ibStart)
		{
			uint[] array = global::Gibraltar.Data.MD5Core.Converter(input, ibStart);
			uint num = ABCDValue.A;
			uint num2 = ABCDValue.B;
			uint num3 = ABCDValue.C;
			uint num4 = ABCDValue.D;
			num = global::Gibraltar.Data.MD5Core.r1(num, num2, num3, num4, array[0], 7, 3614090360U);
			num4 = global::Gibraltar.Data.MD5Core.r1(num4, num, num2, num3, array[1], 12, 3905402710U);
			num3 = global::Gibraltar.Data.MD5Core.r1(num3, num4, num, num2, array[2], 17, 606105819U);
			num2 = global::Gibraltar.Data.MD5Core.r1(num2, num3, num4, num, array[3], 22, 3250441966U);
			num = global::Gibraltar.Data.MD5Core.r1(num, num2, num3, num4, array[4], 7, 4118548399U);
			num4 = global::Gibraltar.Data.MD5Core.r1(num4, num, num2, num3, array[5], 12, 1200080426U);
			num3 = global::Gibraltar.Data.MD5Core.r1(num3, num4, num, num2, array[6], 17, 2821735955U);
			num2 = global::Gibraltar.Data.MD5Core.r1(num2, num3, num4, num, array[7], 22, 4249261313U);
			num = global::Gibraltar.Data.MD5Core.r1(num, num2, num3, num4, array[8], 7, 1770035416U);
			num4 = global::Gibraltar.Data.MD5Core.r1(num4, num, num2, num3, array[9], 12, 2336552879U);
			num3 = global::Gibraltar.Data.MD5Core.r1(num3, num4, num, num2, array[10], 17, 4294925233U);
			num2 = global::Gibraltar.Data.MD5Core.r1(num2, num3, num4, num, array[11], 22, 2304563134U);
			num = global::Gibraltar.Data.MD5Core.r1(num, num2, num3, num4, array[12], 7, 1804603682U);
			num4 = global::Gibraltar.Data.MD5Core.r1(num4, num, num2, num3, array[13], 12, 4254626195U);
			num3 = global::Gibraltar.Data.MD5Core.r1(num3, num4, num, num2, array[14], 17, 2792965006U);
			num2 = global::Gibraltar.Data.MD5Core.r1(num2, num3, num4, num, array[15], 22, 1236535329U);
			num = global::Gibraltar.Data.MD5Core.r2(num, num2, num3, num4, array[1], 5, 4129170786U);
			num4 = global::Gibraltar.Data.MD5Core.r2(num4, num, num2, num3, array[6], 9, 3225465664U);
			num3 = global::Gibraltar.Data.MD5Core.r2(num3, num4, num, num2, array[11], 14, 643717713U);
			num2 = global::Gibraltar.Data.MD5Core.r2(num2, num3, num4, num, array[0], 20, 3921069994U);
			num = global::Gibraltar.Data.MD5Core.r2(num, num2, num3, num4, array[5], 5, 3593408605U);
			num4 = global::Gibraltar.Data.MD5Core.r2(num4, num, num2, num3, array[10], 9, 38016083U);
			num3 = global::Gibraltar.Data.MD5Core.r2(num3, num4, num, num2, array[15], 14, 3634488961U);
			num2 = global::Gibraltar.Data.MD5Core.r2(num2, num3, num4, num, array[4], 20, 3889429448U);
			num = global::Gibraltar.Data.MD5Core.r2(num, num2, num3, num4, array[9], 5, 568446438U);
			num4 = global::Gibraltar.Data.MD5Core.r2(num4, num, num2, num3, array[14], 9, 3275163606U);
			num3 = global::Gibraltar.Data.MD5Core.r2(num3, num4, num, num2, array[3], 14, 4107603335U);
			num2 = global::Gibraltar.Data.MD5Core.r2(num2, num3, num4, num, array[8], 20, 1163531501U);
			num = global::Gibraltar.Data.MD5Core.r2(num, num2, num3, num4, array[13], 5, 2850285829U);
			num4 = global::Gibraltar.Data.MD5Core.r2(num4, num, num2, num3, array[2], 9, 4243563512U);
			num3 = global::Gibraltar.Data.MD5Core.r2(num3, num4, num, num2, array[7], 14, 1735328473U);
			num2 = global::Gibraltar.Data.MD5Core.r2(num2, num3, num4, num, array[12], 20, 2368359562U);
			num = global::Gibraltar.Data.MD5Core.r3(num, num2, num3, num4, array[5], 4, 4294588738U);
			num4 = global::Gibraltar.Data.MD5Core.r3(num4, num, num2, num3, array[8], 11, 2272392833U);
			num3 = global::Gibraltar.Data.MD5Core.r3(num3, num4, num, num2, array[11], 16, 1839030562U);
			num2 = global::Gibraltar.Data.MD5Core.r3(num2, num3, num4, num, array[14], 23, 4259657740U);
			num = global::Gibraltar.Data.MD5Core.r3(num, num2, num3, num4, array[1], 4, 2763975236U);
			num4 = global::Gibraltar.Data.MD5Core.r3(num4, num, num2, num3, array[4], 11, 1272893353U);
			num3 = global::Gibraltar.Data.MD5Core.r3(num3, num4, num, num2, array[7], 16, 4139469664U);
			num2 = global::Gibraltar.Data.MD5Core.r3(num2, num3, num4, num, array[10], 23, 3200236656U);
			num = global::Gibraltar.Data.MD5Core.r3(num, num2, num3, num4, array[13], 4, 681279174U);
			num4 = global::Gibraltar.Data.MD5Core.r3(num4, num, num2, num3, array[0], 11, 3936430074U);
			num3 = global::Gibraltar.Data.MD5Core.r3(num3, num4, num, num2, array[3], 16, 3572445317U);
			num2 = global::Gibraltar.Data.MD5Core.r3(num2, num3, num4, num, array[6], 23, 76029189U);
			num = global::Gibraltar.Data.MD5Core.r3(num, num2, num3, num4, array[9], 4, 3654602809U);
			num4 = global::Gibraltar.Data.MD5Core.r3(num4, num, num2, num3, array[12], 11, 3873151461U);
			num3 = global::Gibraltar.Data.MD5Core.r3(num3, num4, num, num2, array[15], 16, 530742520U);
			num2 = global::Gibraltar.Data.MD5Core.r3(num2, num3, num4, num, array[2], 23, 3299628645U);
			num = global::Gibraltar.Data.MD5Core.r4(num, num2, num3, num4, array[0], 6, 4096336452U);
			num4 = global::Gibraltar.Data.MD5Core.r4(num4, num, num2, num3, array[7], 10, 1126891415U);
			num3 = global::Gibraltar.Data.MD5Core.r4(num3, num4, num, num2, array[14], 15, 2878612391U);
			num2 = global::Gibraltar.Data.MD5Core.r4(num2, num3, num4, num, array[5], 21, 4237533241U);
			num = global::Gibraltar.Data.MD5Core.r4(num, num2, num3, num4, array[12], 6, 1700485571U);
			num4 = global::Gibraltar.Data.MD5Core.r4(num4, num, num2, num3, array[3], 10, 2399980690U);
			num3 = global::Gibraltar.Data.MD5Core.r4(num3, num4, num, num2, array[10], 15, 4293915773U);
			num2 = global::Gibraltar.Data.MD5Core.r4(num2, num3, num4, num, array[1], 21, 2240044497U);
			num = global::Gibraltar.Data.MD5Core.r4(num, num2, num3, num4, array[8], 6, 1873313359U);
			num4 = global::Gibraltar.Data.MD5Core.r4(num4, num, num2, num3, array[15], 10, 4264355552U);
			num3 = global::Gibraltar.Data.MD5Core.r4(num3, num4, num, num2, array[6], 15, 2734768916U);
			num2 = global::Gibraltar.Data.MD5Core.r4(num2, num3, num4, num, array[13], 21, 1309151649U);
			num = global::Gibraltar.Data.MD5Core.r4(num, num2, num3, num4, array[4], 6, 4149444226U);
			num4 = global::Gibraltar.Data.MD5Core.r4(num4, num, num2, num3, array[11], 10, 3174756917U);
			num3 = global::Gibraltar.Data.MD5Core.r4(num3, num4, num, num2, array[2], 15, 718787259U);
			num2 = global::Gibraltar.Data.MD5Core.r4(num2, num3, num4, num, array[9], 21, 3951481745U);
			ABCDValue.A = num + ABCDValue.A;
			ABCDValue.B = num2 + ABCDValue.B;
			ABCDValue.C = num3 + ABCDValue.C;
			ABCDValue.D = num4 + ABCDValue.D;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00016524 File Offset: 0x00014724
		private static uint r1(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return b + global::Gibraltar.Data.MD5Core.LSR(a + ((b & c) | ((b ^ uint.MaxValue) & d)) + x + t, s);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00016540 File Offset: 0x00014740
		private static uint r2(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return b + global::Gibraltar.Data.MD5Core.LSR(a + ((b & d) | (c & (d ^ uint.MaxValue))) + x + t, s);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0001655C File Offset: 0x0001475C
		private static uint r3(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return b + global::Gibraltar.Data.MD5Core.LSR(a + (b ^ c ^ d) + x + t, s);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00016574 File Offset: 0x00014774
		private static uint r4(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return b + global::Gibraltar.Data.MD5Core.LSR(a + (c ^ (b | (d ^ uint.MaxValue))) + x + t, s);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00016590 File Offset: 0x00014790
		private static uint LSR(uint i, int s)
		{
			return i << s | i >> 32 - s;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000165A4 File Offset: 0x000147A4
		private static uint[] Converter(byte[] input, int ibStart)
		{
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input", "Unable convert null array to array of uInts");
			}
			uint[] array = new uint[16];
			for (int i = 0; i < 16; i++)
			{
				array[i] = (uint)input[ibStart + i * 4];
				array[i] += (uint)((uint)input[ibStart + i * 4 + 1] << 8);
				array[i] += (uint)((uint)input[ibStart + i * 4 + 2] << 16);
				array[i] += (uint)((uint)input[ibStart + i * 4 + 3] << 24);
			}
			return array;
		}

		// Token: 0x02000494 RID: 1172
		private struct ABCDStruct
		{
			// Token: 0x0400136C RID: 4972
			public uint A;

			// Token: 0x0400136D RID: 4973
			public uint B;

			// Token: 0x0400136E RID: 4974
			public uint C;

			// Token: 0x0400136F RID: 4975
			public uint D;
		}
	}
}
