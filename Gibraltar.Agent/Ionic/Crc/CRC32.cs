using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Ionic.Crc
{
	// Token: 0x02000424 RID: 1060
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDispatch)]
	internal class CRC32
	{
		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x0009B1BC File Offset: 0x000993BC
		public long TotalBytesRead
		{
			get
			{
				return this._TotalBytesRead;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002DE3 RID: 11747 RVA: 0x0009B1C4 File Offset: 0x000993C4
		public int Crc32Result
		{
			get
			{
				return (int)(~(int)this._register);
			}
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x0009B1D0 File Offset: 0x000993D0
		public int GetCrc32(global::System.IO.Stream input)
		{
			return this.GetCrc32AndCopy(input, null);
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x0009B1DC File Offset: 0x000993DC
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

		// Token: 0x06002DE6 RID: 11750 RVA: 0x0009B280 File Offset: 0x00099480
		public int ComputeCrc32(int W, byte B)
		{
			return this._InternalComputeCrc32((uint)W, B);
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x0009B28C File Offset: 0x0009948C
		internal int _InternalComputeCrc32(uint W, byte B)
		{
			return (int)(this.crc32Table[(int)((W ^ (uint)B) & 255U)] ^ W >> 8);
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x0009B2A4 File Offset: 0x000994A4
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

		// Token: 0x06002DE9 RID: 11753 RVA: 0x0009B348 File Offset: 0x00099548
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

		// Token: 0x06002DEA RID: 11754 RVA: 0x0009B3B0 File Offset: 0x000995B0
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

		// Token: 0x06002DEB RID: 11755 RVA: 0x0009B454 File Offset: 0x00099654
		private static uint ReverseBits(uint data)
		{
			uint num = (data & 1431655765U) << 1 | (data >> 1 & 1431655765U);
			num = ((num & 858993459U) << 2 | (num >> 2 & 858993459U));
			num = ((num & 252645135U) << 4 | (num >> 4 & 252645135U));
			return num << 24 | (num & 65280U) << 8 | (num >> 8 & 65280U) | num >> 24;
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x0009B4C4 File Offset: 0x000996C4
		private static byte ReverseBits(byte data)
		{
			int num = (int)data * 131586;
			uint num2 = 17055760U;
			uint num3 = (uint)(num & (int)num2);
			uint num4 = (uint)(num << 2 & (int)((int)num2 << 1));
			return (byte)(16781313U * (num3 + num4) >> 24);
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x0009B4FC File Offset: 0x000996FC
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

		// Token: 0x06002DEE RID: 11758 RVA: 0x0009B584 File Offset: 0x00099784
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

		// Token: 0x06002DEF RID: 11759 RVA: 0x0009B5BC File Offset: 0x000997BC
		private void gf2_matrix_square(uint[] square, uint[] mat)
		{
			for (int i = 0; i < 32; i++)
			{
				square[i] = this.gf2_matrix_times(mat, mat[i]);
			}
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x0009B5EC File Offset: 0x000997EC
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

		// Token: 0x06002DF1 RID: 11761 RVA: 0x0009B6B8 File Offset: 0x000998B8
		public CRC32() : this(false)
		{
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x0009B6C4 File Offset: 0x000998C4
		public CRC32(bool reverseBits) : this(-306674912, reverseBits)
		{
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x0009B6D4 File Offset: 0x000998D4
		public CRC32(int polynomial, bool reverseBits)
		{
			this.reverseBits = reverseBits;
			this.dwPolynomial = (uint)polynomial;
			this.GenerateLookupTable();
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x0009B6F8 File Offset: 0x000998F8
		public void Reset()
		{
			this._register = uint.MaxValue;
		}

		// Token: 0x04000F8F RID: 3983
		private uint dwPolynomial;

		// Token: 0x04000F90 RID: 3984
		private long _TotalBytesRead;

		// Token: 0x04000F91 RID: 3985
		private bool reverseBits;

		// Token: 0x04000F92 RID: 3986
		private uint[] crc32Table;

		// Token: 0x04000F93 RID: 3987
		private const int BUFFER_SIZE = 8192;

		// Token: 0x04000F94 RID: 3988
		private uint _register = uint.MaxValue;
	}
}
