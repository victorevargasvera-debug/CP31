using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Ionic.Crc
{
	// Token: 0x02000029 RID: 41
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDispatch)]
	public class CRC32
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000C620 File Offset: 0x0000A820
		public long TotalBytesRead
		{
			get
			{
				return this._TotalBytesRead;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000C628 File Offset: 0x0000A828
		public int Crc32Result
		{
			get
			{
				return (int)(~(int)this._register);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000C631 File Offset: 0x0000A831
		public int GetCrc32(global::System.IO.Stream input)
		{
			return this.GetCrc32AndCopy(input, null);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000C63C File Offset: 0x0000A83C
		public int GetCrc32AndCopy(global::System.IO.Stream input, global::System.IO.Stream output)
		{
			if (input == null)
			{
				throw new global::System.Exception("The input stream must not be null.");
			}
			byte[] array = new byte[8192];
			int count = 8192;
			this._TotalBytesRead = 0L;
			int i = input.Read(array, 0, count);
			if (output != null)
			{
				output.Write(array, 0, i);
			}
			this._TotalBytesRead += (long)i;
			while (i > 0)
			{
				this.SlurpBlock(array, 0, i);
				i = input.Read(array, 0, count);
				if (output != null)
				{
					output.Write(array, 0, i);
				}
				this._TotalBytesRead += (long)i;
			}
			return (int)(~(int)this._register);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
		public int ComputeCrc32(int W, byte B)
		{
			return this._InternalComputeCrc32((uint)W, B);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000C6DA File Offset: 0x0000A8DA
		internal int _InternalComputeCrc32(uint W, byte B)
		{
			return (int)(this.crc32Table[(int)((W ^ (uint)B) & 255U)] ^ W >> 8);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		public void SlurpBlock(byte[] block, int offset, int count)
		{
			if (block == null)
			{
				throw new global::System.Exception("The data buffer must not be null.");
			}
			for (int i = 0; i < count; i++)
			{
				int num = offset + i;
				byte b = block[num];
				if (this.reverseBits)
				{
					uint num2 = this._register >> 24 ^ (uint)b;
					this._register = (this._register << 8 ^ this.crc32Table[(int)num2]);
				}
				else
				{
					uint num3 = (this._register & 255U) ^ (uint)b;
					this._register = (this._register >> 8 ^ this.crc32Table[(int)num3]);
				}
			}
			this._TotalBytesRead += (long)count;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000C784 File Offset: 0x0000A984
		public void UpdateCRC(byte b)
		{
			if (this.reverseBits)
			{
				uint num = this._register >> 24 ^ (uint)b;
				this._register = (this._register << 8 ^ this.crc32Table[(int)num]);
				return;
			}
			uint num2 = (this._register & 255U) ^ (uint)b;
			this._register = (this._register >> 8 ^ this.crc32Table[(int)num2]);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
		public void UpdateCRC(byte b, int n)
		{
			while (n-- > 0)
			{
				if (this.reverseBits)
				{
					uint num = this._register >> 24 ^ (uint)b;
					this._register = (this._register << 8 ^ this.crc32Table[(int)((num >= 0U) ? num : (num + 256U))]);
				}
				else
				{
					uint num2 = (this._register & 255U) ^ (uint)b;
					this._register = (this._register >> 8 ^ this.crc32Table[(int)((num2 >= 0U) ? num2 : (num2 + 256U))]);
				}
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000C86C File Offset: 0x0000AA6C
		private static uint ReverseBits(uint data)
		{
			uint num = (data & 1431655765U) << 1 | (data >> 1 & 1431655765U);
			num = ((num & 858993459U) << 2 | (num >> 2 & 858993459U));
			num = ((num & 252645135U) << 4 | (num >> 4 & 252645135U));
			return num << 24 | (num & 65280U) << 8 | (num >> 8 & 65280U) | num >> 24;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000C8D8 File Offset: 0x0000AAD8
		private static byte ReverseBits(byte data)
		{
			int num = (int)data * 131586;
			uint num2 = 17055760U;
			uint num3 = (uint)(num & (int)num2);
			uint num4 = (uint)(num << 2 & (int)((int)num2 << 1));
			return (byte)(16781313U * (num3 + num4) >> 24);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000C90C File Offset: 0x0000AB0C
		private void GenerateLookupTable()
		{
			this.crc32Table = new uint[256];
			byte b = 0;
			do
			{
				uint num = (uint)b;
				for (byte b2 = 8; b2 > 0; b2 -= 1)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ this.dwPolynomial);
					}
					else
					{
						num >>= 1;
					}
				}
				if (this.reverseBits)
				{
					this.crc32Table[(int)global::Ionic.Crc.CRC32.ReverseBits(b)] = global::Ionic.Crc.CRC32.ReverseBits(num);
				}
				else
				{
					this.crc32Table[(int)b] = num;
				}
				b += 1;
			}
			while (b != 0);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000C980 File Offset: 0x0000AB80
		private uint gf2_matrix_times(uint[] matrix, uint vec)
		{
			uint num = 0U;
			int num2 = 0;
			while (vec != 0U)
			{
				if ((vec & 1U) == 1U)
				{
					num ^= matrix[num2];
				}
				vec >>= 1;
				num2++;
			}
			return num;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000C9AC File Offset: 0x0000ABAC
		private void gf2_matrix_square(uint[] square, uint[] mat)
		{
			for (int i = 0; i < 32; i++)
			{
				square[i] = this.gf2_matrix_times(mat, mat[i]);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		public void Combine(int crc, int length)
		{
			uint[] array = new uint[32];
			uint[] array2 = new uint[32];
			if (length == 0)
			{
				return;
			}
			uint num = ~this._register;
			array2[0] = this.dwPolynomial;
			uint num2 = 1U;
			for (int i = 1; i < 32; i++)
			{
				array2[i] = num2;
				num2 <<= 1;
			}
			this.gf2_matrix_square(array, array2);
			this.gf2_matrix_square(array2, array);
			uint num3 = (uint)length;
			do
			{
				this.gf2_matrix_square(array, array2);
				if ((num3 & 1U) == 1U)
				{
					num = this.gf2_matrix_times(array, num);
				}
				num3 >>= 1;
				if (num3 == 0U)
				{
					break;
				}
				this.gf2_matrix_square(array2, array);
				if ((num3 & 1U) == 1U)
				{
					num = this.gf2_matrix_times(array2, num);
				}
				num3 >>= 1;
			}
			while (num3 != 0U);
			num ^= (uint)crc;
			this._register = ~num;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000CA8B File Offset: 0x0000AC8B
		public CRC32() : this(false)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000CA94 File Offset: 0x0000AC94
		public CRC32(bool reverseBits) : this(-306674912, reverseBits)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000CAA2 File Offset: 0x0000ACA2
		public CRC32(int polynomial, bool reverseBits)
		{
			this.reverseBits = reverseBits;
			this.dwPolynomial = (uint)polynomial;
			this.GenerateLookupTable();
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000CAC5 File Offset: 0x0000ACC5
		public void Reset()
		{
			this._register = uint.MaxValue;
		}

		// Token: 0x0400016C RID: 364
		private uint dwPolynomial;

		// Token: 0x0400016D RID: 365
		private long _TotalBytesRead;

		// Token: 0x0400016E RID: 366
		private bool reverseBits;

		// Token: 0x0400016F RID: 367
		private uint[] crc32Table;

		// Token: 0x04000170 RID: 368
		private const int BUFFER_SIZE = 8192;

		// Token: 0x04000171 RID: 369
		private uint _register = uint.MaxValue;
	}
}
