using System;
using System.Globalization;
using System.Text;

namespace NPOI.Util
{
	// Token: 0x0200025E RID: 606
	public class BigInteger : global::System.IComparable<global::NPOI.Util.BigInteger>
	{
		// Token: 0x06000F3D RID: 3901 RVA: 0x0002D340 File Offset: 0x0002B540
		static BigInteger()
		{
			global::NPOI.Util.BigInteger.Init();
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0002D684 File Offset: 0x0002B884
		private static void Init()
		{
			if (global::NPOI.Util.BigInteger.zeros[63] == null)
			{
				for (int i = 1; i <= 16; i++)
				{
					int[] magnitude = new int[]
					{
						i
					};
					global::NPOI.Util.BigInteger.posConst[i] = new global::NPOI.Util.BigInteger(magnitude, 1);
					global::NPOI.Util.BigInteger.negConst[i] = new global::NPOI.Util.BigInteger(magnitude, -1);
				}
				global::NPOI.Util.BigInteger.zeros[63] = "000000000000000000000000000000000000000000000000000000000000000";
				for (int j = 0; j < 63; j++)
				{
					global::NPOI.Util.BigInteger.zeros[j] = global::NPOI.Util.BigInteger.zeros[63].Substring(0, j);
				}
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0002D6FF File Offset: 0x0002B8FF
		public BigInteger(int[] magnitude, int signum)
		{
			this._signum = ((magnitude.Length == 0) ? 0 : signum);
			this.mag = magnitude;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0002D71C File Offset: 0x0002B91C
		public BigInteger(byte[] val)
		{
			if (val.Length == 0)
			{
				throw new global::System.ArgumentException("Zero length BigInteger");
			}
			if ((sbyte)val[0] < 0)
			{
				this.mag = global::NPOI.Util.BigInteger.makePositive(val);
				this._signum = -1;
				return;
			}
			this.mag = global::NPOI.Util.BigInteger.stripLeadingZeroBytes(val);
			this._signum = ((this.mag.Length == 0) ? 0 : 1);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x0002D778 File Offset: 0x0002B978
		public BigInteger(int[] val)
		{
			if (val.Length == 0)
			{
				throw new global::System.ArgumentException("Zero length BigInteger");
			}
			if (val[0] < 0)
			{
				this.mag = global::NPOI.Util.BigInteger.makePositive(val);
				this._signum = -1;
				return;
			}
			this.mag = global::NPOI.Util.BigInteger.TrustedStripLeadingZeroInts(val);
			this._signum = ((this.mag.Length == 0) ? 0 : 1);
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0002D7D4 File Offset: 0x0002B9D4
		public BigInteger(long val)
		{
			if (val < 0L)
			{
				val = -val;
				this._signum = -1;
			}
			else
			{
				this._signum = 1;
			}
			int num = (int)global::NPOI.Util.Operator.UnsignedRightShift(val, 32);
			if (num == 0)
			{
				this.mag = new int[1];
				this.mag[0] = (int)val;
				return;
			}
			this.mag = new int[2];
			this.mag[0] = num;
			this.mag[1] = (int)val;
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0002D843 File Offset: 0x0002BA43
		public BigInteger(string val) : this(val, 10)
		{
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0002D850 File Offset: 0x0002BA50
		public BigInteger(string val, int radix)
		{
			int i = 0;
			int length = val.Length;
			if (radix < 2 || radix > 36)
			{
				throw new global::System.FormatException("Radix out of range");
			}
			if (length == 0)
			{
				throw new global::System.FormatException("Zero length BigInteger");
			}
			int signum = 1;
			int num = val.LastIndexOf('-');
			int num2 = val.LastIndexOf('+');
			if (num + num2 > -1)
			{
				throw new global::System.FormatException("Illegal embedded sign character");
			}
			if (num == 0 || num2 == 0)
			{
				i = 1;
				if (length == 1)
				{
					throw new global::System.FormatException("Zero length BigInteger");
				}
			}
			if (num == 0)
			{
				signum = -1;
			}
			while (i < length && val[i] == '0')
			{
				i++;
			}
			if (i == length)
			{
				this._signum = 0;
				this.mag = global::NPOI.Util.BigInteger.ZERO.mag;
				return;
			}
			int num3 = length - i;
			this._signum = signum;
			int num4 = global::NPOI.Util.Operator.UnsignedRightShift((int)(global::NPOI.Util.Operator.UnsignedRightShift((long)num3 * global::NPOI.Util.BigInteger.bitsPerDigit[radix], 10) + 1L) + 31, 5);
			int[] array = new int[num4];
			int num5 = num3 % global::NPOI.Util.BigInteger.digitsPerInt[radix];
			if (num5 == 0)
			{
				num5 = global::NPOI.Util.BigInteger.digitsPerInt[radix];
			}
			string s = val.Substring(i, i += num5);
			array[num4 - 1] = int.Parse(s, global::System.Globalization.CultureInfo.InvariantCulture);
			if (array[num4 - 1] < 0)
			{
				throw new global::System.FormatException("Illegal digit");
			}
			int y = global::NPOI.Util.BigInteger.intRadix[radix];
			while (i < length)
			{
				s = val.Substring(i, i += global::NPOI.Util.BigInteger.digitsPerInt[radix]);
				int num6 = int.Parse(s, global::System.Globalization.CultureInfo.InvariantCulture);
				if (num6 < 0)
				{
					throw new global::System.FormatException("Illegal digit");
				}
				global::NPOI.Util.BigInteger.DestructiveMulAdd(array, y, num6);
			}
			this.mag = global::NPOI.Util.BigInteger.TrustedStripLeadingZeroInts(array);
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0002D9E0 File Offset: 0x0002BBE0
		private static int[] TrustedStripLeadingZeroInts(int[] val)
		{
			int num = val.Length;
			int num2 = 0;
			while (num2 < num && val[num2] == 0)
			{
				num2++;
			}
			if (num2 != 0)
			{
				return global::NPOI.Util.Arrays.CopyOfRange(val, num2, num);
			}
			return val;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0002DA10 File Offset: 0x0002BC10
		private static void DestructiveMulAdd(int[] x, int y, int z)
		{
			long num = (long)y & (long)((ulong)-1);
			long num2 = (long)z & (long)((ulong)-1);
			int num3 = x.Length;
			long num4 = 0L;
			for (int i = num3 - 1; i >= 0; i--)
			{
				long num5 = num * ((long)x[i] & (long)((ulong)-1)) + num4;
				x[i] = (int)num5;
				num4 = global::NPOI.Util.Operator.UnsignedRightShift(num5, 32);
			}
			long num6 = ((long)x[num3 - 1] & (long)((ulong)-1)) + num2;
			x[num3 - 1] = (int)num6;
			num4 = global::NPOI.Util.Operator.UnsignedRightShift(num6, 32);
			for (int j = num3 - 2; j >= 0; j--)
			{
				num6 = ((long)x[j] & (long)((ulong)-1)) + num4;
				x[j] = (int)num6;
				num4 = global::NPOI.Util.Operator.UnsignedRightShift(num6, 32);
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0002DAB8 File Offset: 0x0002BCB8
		public string ToString(int radix)
		{
			if (this._signum == 0)
			{
				return "0";
			}
			if (radix < 2 || radix > 36)
			{
				radix = 10;
			}
			if (radix != 10)
			{
				throw new global::System.ArgumentException("Only support 10 radix rendering");
			}
			string[] array = new string[(4 * this.mag.Length + 6) / 7];
			global::NPOI.Util.BigInteger bigInteger = this.Abs();
			int num = 0;
			while (bigInteger._signum != 0)
			{
				global::NPOI.Util.BigInteger bigInteger2 = global::NPOI.Util.BigInteger.longRadix[radix];
				global::NPOI.Util.MutableBigInteger mutableBigInteger = new global::NPOI.Util.MutableBigInteger();
				global::NPOI.Util.MutableBigInteger mutableBigInteger2 = new global::NPOI.Util.MutableBigInteger(bigInteger.mag);
				global::NPOI.Util.MutableBigInteger b = new global::NPOI.Util.MutableBigInteger(bigInteger2.mag);
				global::NPOI.Util.MutableBigInteger mutableBigInteger3 = mutableBigInteger2.divide(b, mutableBigInteger);
				global::NPOI.Util.BigInteger bigInteger3 = mutableBigInteger.toBigInteger(bigInteger._signum * bigInteger2._signum);
				global::NPOI.Util.BigInteger bigInteger4 = mutableBigInteger3.toBigInteger(bigInteger._signum * bigInteger2._signum);
				array[num++] = bigInteger4.LongValue().ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				bigInteger = bigInteger3;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(num * global::NPOI.Util.BigInteger.digitsPerLong[radix] + 1);
			if (this._signum < 0)
			{
				stringBuilder.Append('-');
			}
			stringBuilder.Append(array[num - 1]);
			for (int i = num - 2; i >= 0; i--)
			{
				int num2 = global::NPOI.Util.BigInteger.digitsPerLong[radix] - array[i].Length;
				if (num2 != 0)
				{
					stringBuilder.Append(global::NPOI.Util.BigInteger.zeros[num2]);
				}
				stringBuilder.Append(array[i]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0002DC0F File Offset: 0x0002BE0F
		public static global::NPOI.Util.BigInteger ValueOf(long val)
		{
			global::NPOI.Util.BigInteger.Init();
			if (val == 0L)
			{
				return global::NPOI.Util.BigInteger.ZERO;
			}
			if (val > 0L && val <= 16L)
			{
				return global::NPOI.Util.BigInteger.posConst[(int)val];
			}
			if (val < 0L && val >= -16L)
			{
				return global::NPOI.Util.BigInteger.negConst[(int)(-(int)val)];
			}
			return new global::NPOI.Util.BigInteger(val);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0002DC4E File Offset: 0x0002BE4E
		private static global::NPOI.Util.BigInteger ValueOf(int[] val)
		{
			if (val[0] <= 0)
			{
				return new global::NPOI.Util.BigInteger(val);
			}
			return new global::NPOI.Util.BigInteger(val, 1);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0002DC64 File Offset: 0x0002BE64
		public static int BitLengthForInt(int n)
		{
			return 32 - global::NPOI.Util.BigInteger.NumberOfLeadingZeros(n);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0002DC70 File Offset: 0x0002BE70
		public int BitLength()
		{
			int num = this.bitLength - 1;
			if (num == -1)
			{
				int num2 = this.mag.Length;
				if (num2 == 0)
				{
					num = 0;
				}
				else
				{
					int num3 = (num2 - 1 << 5) + global::NPOI.Util.BigInteger.BitLengthForInt(this.mag[0]);
					if (this._signum < 0)
					{
						bool flag = global::NPOI.Util.BigInteger.BitCountForInt(this.mag[0]) == 1;
						int num4 = 1;
						while (num4 < num2 && flag)
						{
							flag = (this.mag[num4] == 0);
							num4++;
						}
						num = (flag ? (num3 - 1) : num3);
					}
					else
					{
						num = num3;
					}
				}
				this.bitLength = num + 1;
			}
			return num;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0002DD04 File Offset: 0x0002BF04
		public int BitCount()
		{
			int num = this.bitCount - 1;
			if (num == -1)
			{
				num = 0;
				for (int i = 0; i < this.mag.Length; i++)
				{
					num += global::NPOI.Util.BigInteger.BitCountForInt(this.mag[i]);
				}
				if (this._signum < 0)
				{
					int num2 = 0;
					int num3 = this.mag.Length - 1;
					while (this.mag[num3] == 0)
					{
						num2 += 32;
						num3--;
					}
					num2 += global::NPOI.Util.BigInteger.NumberOfTrailingZeros(this.mag[num3]);
					num += num2 - 1;
				}
				this.bitCount = num + 1;
			}
			return num;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0002DD8E File Offset: 0x0002BF8E
		public global::NPOI.Util.BigInteger Abs()
		{
			if (this._signum < 0)
			{
				return this.Negate();
			}
			return this;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0002DDA1 File Offset: 0x0002BFA1
		public global::NPOI.Util.BigInteger Negate()
		{
			return new global::NPOI.Util.BigInteger(this.mag, -this._signum);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0002DDB8 File Offset: 0x0002BFB8
		public global::NPOI.Util.BigInteger Pow(int exponent)
		{
			if (exponent < 0)
			{
				throw new global::System.ArithmeticException("Negative exponent");
			}
			if (this._signum != 0)
			{
				int signum = (this._signum < 0 && (exponent & 1) == 1) ? -1 : 1;
				int[] array = this.mag;
				int[] array2 = new int[]
				{
					1
				};
				while (exponent != 0)
				{
					if ((exponent & 1) == 1)
					{
						array2 = this.MultiplyToLen(array2, array2.Length, array, array.Length, null);
						array2 = global::NPOI.Util.BigInteger.TrustedStripLeadingZeroInts(array2);
					}
					exponent = global::NPOI.Util.Operator.UnsignedRightShift(exponent, 1);
					if (exponent != 0)
					{
						array = global::NPOI.Util.BigInteger.squareToLen(array, array.Length, null);
						array = global::NPOI.Util.BigInteger.TrustedStripLeadingZeroInts(array);
					}
				}
				return new global::NPOI.Util.BigInteger(array2, signum);
			}
			if (exponent != 0)
			{
				return this;
			}
			return global::NPOI.Util.BigInteger.One;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0002DE54 File Offset: 0x0002C054
		private int[] MultiplyToLen(int[] x, int xlen, int[] y, int ylen, int[] z)
		{
			int num = xlen - 1;
			int num2 = ylen - 1;
			if (z == null || z.Length < xlen + ylen)
			{
				z = new int[xlen + ylen];
			}
			long num3 = 0L;
			int i = num2;
			int num4 = num2 + 1 + num;
			while (i >= 0)
			{
				long num5 = ((long)y[i] & (long)((ulong)-1)) * ((long)x[num] & (long)((ulong)-1)) + num3;
				z[num4] = (int)num5;
				num3 = global::NPOI.Util.Operator.UnsignedRightShift(num5, 32);
				i--;
				num4--;
			}
			z[num] = (int)num3;
			for (int j = num - 1; j >= 0; j--)
			{
				num3 = 0L;
				int k = num2;
				int num6 = num2 + 1 + j;
				while (k >= 0)
				{
					long num7 = ((long)y[k] & (long)((ulong)-1)) * ((long)x[j] & (long)((ulong)-1)) + ((long)z[num6] & (long)((ulong)-1)) + num3;
					z[num6] = (int)num7;
					num3 = global::NPOI.Util.Operator.UnsignedRightShift(num7, 32);
					k--;
					num6--;
				}
				z[j] = (int)num3;
			}
			return z;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0002DF38 File Offset: 0x0002C138
		private static int mulAdd(int[] output, int[] input, int offset, int len, int k)
		{
			long num = (long)k & (long)((ulong)-1);
			long num2 = 0L;
			offset = output.Length - offset - 1;
			for (int i = len - 1; i >= 0; i--)
			{
				long num3 = ((long)input[i] & (long)((ulong)-1)) * num + ((long)output[offset] & (long)((ulong)-1)) + num2;
				output[offset--] = (int)num3;
				num2 = global::NPOI.Util.Operator.UnsignedRightShift(num3, 32);
			}
			return (int)num2;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0002DF90 File Offset: 0x0002C190
		private static int[] squareToLen(int[] x, int len, int[] z)
		{
			int num = len << 1;
			if (z == null || z.Length < num)
			{
				z = new int[num];
			}
			int num2 = 0;
			int i = 0;
			int num3 = 0;
			while (i < len)
			{
				long num4 = (long)x[i] & (long)((ulong)-1);
				long num5 = num4 * num4;
				z[num3++] = (num2 << 31 | (int)global::NPOI.Util.Operator.UnsignedRightShift(num5, 33));
				z[num3++] = (int)global::NPOI.Util.Operator.UnsignedRightShift(num5, 1);
				num2 = (int)num5;
				i++;
			}
			int j = len;
			int num6 = 1;
			while (j > 0)
			{
				int num7 = x[j - 1];
				num7 = global::NPOI.Util.BigInteger.mulAdd(z, x, num6, j - 1, num7);
				global::NPOI.Util.BigInteger.addOne(z, num6 - 1, j, num7);
				j--;
				num6 += 2;
			}
			global::NPOI.Util.BigInteger.PrimitiveLeftShift(z, num, 1);
			z[num - 1] |= (x[len - 1] & 1);
			return z;
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0002E058 File Offset: 0x0002C258
		public static void PrimitiveLeftShift(int[] a, int len, int n)
		{
			if (len == 0 || n == 0)
			{
				return;
			}
			int val = 32 - n;
			int i = 0;
			int num = a[i];
			int num2 = i + len - 1;
			while (i < num2)
			{
				int num3 = num;
				num = a[i + 1];
				a[i] = (num3 << n | global::NPOI.Util.Operator.UnsignedRightShift(num, val));
				i++;
			}
			a[len - 1] <<= n;
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0002E0B4 File Offset: 0x0002C2B4
		private static int addOne(int[] a, int offset, int mlen, int carry)
		{
			offset = a.Length - 1 - mlen - offset;
			long num = ((long)a[offset] & (long)((ulong)-1)) + ((long)carry & (long)((ulong)-1));
			a[offset] = (int)num;
			if (num >> 32 == 0L)
			{
				return 0;
			}
			while (--mlen >= 0)
			{
				if (--offset < 0)
				{
					return 1;
				}
				a[offset]++;
				if (a[offset] != 0)
				{
					return 0;
				}
			}
			return 1;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0002E10F File Offset: 0x0002C30F
		public int Signum()
		{
			return this._signum;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0002E118 File Offset: 0x0002C318
		public byte[] ToByteArray()
		{
			int num = this.BitLength() / 8 + 1;
			byte[] array = new byte[num];
			int i = num - 1;
			int num2 = 4;
			int num3 = 0;
			int num4 = 0;
			while (i >= 0)
			{
				if (num2 == 4)
				{
					num3 = this.GetInt(num4++);
					num2 = 1;
				}
				else
				{
					num3 = global::NPOI.Util.Operator.UnsignedRightShift(num3, 8);
					num2++;
				}
				array[i] = (byte)num3;
				i--;
			}
			return array;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0002E172 File Offset: 0x0002C372
		private int intLength()
		{
			return global::NPOI.Util.Operator.UnsignedRightShift(this.BitLength(), 5) + 1;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0002E182 File Offset: 0x0002C382
		private int signBit()
		{
			if (this._signum >= 0)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0002E190 File Offset: 0x0002C390
		private int signInt()
		{
			if (this._signum >= 0)
			{
				return 0;
			}
			return -1;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0002E1A0 File Offset: 0x0002C3A0
		private int GetInt(int n)
		{
			if (n < 0)
			{
				return 0;
			}
			if (n >= this.mag.Length)
			{
				return this.signInt();
			}
			int num = this.mag[this.mag.Length - n - 1];
			if (this._signum >= 0)
			{
				return num;
			}
			if (n > this.FirstNonzeroIntNum())
			{
				return ~num;
			}
			return -num;
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0002E1F4 File Offset: 0x0002C3F4
		private int FirstNonzeroIntNum()
		{
			int num = this.firstNonzeroIntNum - 2;
			if (num == -2)
			{
				int num2 = this.mag.Length;
				int num3 = num2 - 1;
				while (num3 >= 0 && this.mag[num3] == 0)
				{
					num3--;
				}
				num = num2 - num3 - 1;
				this.firstNonzeroIntNum = num + 2;
			}
			return num;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x0002E244 File Offset: 0x0002C444
		private static int[] stripLeadingZeroBytes(byte[] a)
		{
			int num = a.Length;
			int num2 = 0;
			while (num2 < num && a[num2] == 0)
			{
				num2++;
			}
			int num3 = global::NPOI.Util.Operator.UnsignedRightShift(num - num2 + 3, 2);
			int[] array = new int[num3];
			int num4 = num - 1;
			for (int i = num3 - 1; i >= 0; i--)
			{
				array[i] = (int)(a[num4--] & byte.MaxValue);
				int val = num4 - num2 + 1;
				int num5 = global::System.Math.Min(3, val);
				for (int j = 8; j <= num5 << 3; j += 8)
				{
					array[i] |= (int)(a[num4--] & byte.MaxValue) << j;
				}
			}
			return array;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0002E2E4 File Offset: 0x0002C4E4
		private static int[] makePositive(byte[] a)
		{
			int num = a.Length;
			int num2 = 0;
			while (num2 < num && (sbyte)a[num2] == -1)
			{
				num2++;
			}
			int num3 = num2;
			while (num3 < num && a[num3] == 0)
			{
				num3++;
			}
			int num4 = (num3 == num) ? 1 : 0;
			int num5 = (num - num2 + num4 + 3) / 4;
			int[] array = new int[num5];
			int num6 = num - 1;
			for (int i = num5 - 1; i >= 0; i--)
			{
				array[i] = (int)(a[num6--] & byte.MaxValue);
				int num7 = global::System.Math.Min(3, num6 - num2 + 1);
				if (num7 < 0)
				{
					num7 = 0;
				}
				for (int j = 8; j <= 8 * num7; j += 8)
				{
					array[i] |= (int)(a[num6--] & byte.MaxValue) << j;
				}
				int num8 = global::NPOI.Util.Operator.UnsignedRightShift(-1, 8 * (3 - num7));
				array[i] = (~array[i] & num8);
			}
			for (int k = array.Length - 1; k >= 0; k--)
			{
				array[k] = (int)(((long)array[k] & (long)((ulong)-1)) + 1L);
				if (array[k] != 0)
				{
					break;
				}
			}
			return array;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0002E3FC File Offset: 0x0002C5FC
		private static int[] makePositive(int[] a)
		{
			int num = 0;
			while (num < a.Length && a[num] == -1)
			{
				num++;
			}
			int num2 = num;
			while (num2 < a.Length && a[num2] == 0)
			{
				num2++;
			}
			int num3 = (num2 == a.Length) ? 1 : 0;
			int[] array = new int[a.Length - num + num3];
			for (int i = num; i < a.Length; i++)
			{
				array[i - num + num3] = ~a[i];
			}
			int num4 = array.Length - 1;
			for (;;)
			{
				int[] array2 = array;
				int num5 = num4;
				int num6 = array2[num5] + 1;
				array2[num5] = num6;
				if (num6 != 0)
				{
					break;
				}
				num4--;
			}
			return array;
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0002E48C File Offset: 0x0002C68C
		public static int NumberOfLeadingZeros(int i)
		{
			if (i == 0)
			{
				return 32;
			}
			int num = 1;
			if (global::NPOI.Util.Operator.UnsignedRightShift(i, 16) == 0)
			{
				num += 16;
				i <<= 16;
			}
			if (global::NPOI.Util.Operator.UnsignedRightShift(i, 24) == 0)
			{
				num += 8;
				i <<= 8;
			}
			if (global::NPOI.Util.Operator.UnsignedRightShift(i, 28) == 0)
			{
				num += 4;
				i <<= 4;
			}
			if (global::NPOI.Util.Operator.UnsignedRightShift(i, 30) == 0)
			{
				num += 2;
				i <<= 2;
			}
			return num - global::NPOI.Util.Operator.UnsignedRightShift(i, 31);
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0002E4FC File Offset: 0x0002C6FC
		public static int NumberOfTrailingZeros(int i)
		{
			if (i == 0)
			{
				return 32;
			}
			int num = 31;
			int num2 = i << 16;
			if (num2 != 0)
			{
				num -= 16;
				i = num2;
			}
			num2 = i << 8;
			if (num2 != 0)
			{
				num -= 8;
				i = num2;
			}
			num2 = i << 4;
			if (num2 != 0)
			{
				num -= 4;
				i = num2;
			}
			num2 = i << 2;
			if (num2 != 0)
			{
				num -= 2;
				i = num2;
			}
			return num - global::NPOI.Util.Operator.UnsignedRightShift(i << 1, 31);
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0002E558 File Offset: 0x0002C758
		public static int BitCountForInt(int i)
		{
			uint num = (uint)(i - (int)((uint)i >> 1 & 1431655765U));
			num = (num & 858993459U) + (num >> 2 & 858993459U);
			num = (num + (num >> 4) & 252645135U);
			num += num >> 8;
			num += num >> 16;
			return (int)(num & 63U);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0002E5A4 File Offset: 0x0002C7A4
		public int CompareTo(global::NPOI.Util.BigInteger val)
		{
			if (this._signum == val._signum)
			{
				int signum = this._signum;
				if (signum == -1)
				{
					return val.compareMagnitude(this);
				}
				if (signum == 1)
				{
					return this.compareMagnitude(val);
				}
				return 0;
			}
			else
			{
				if (this._signum <= val._signum)
				{
					return -1;
				}
				return 1;
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
		private int compareMagnitude(global::NPOI.Util.BigInteger val)
		{
			int[] array = this.mag;
			int num = array.Length;
			int[] array2 = val.mag;
			int num2 = array2.Length;
			if (num < num2)
			{
				return -1;
			}
			if (num > num2)
			{
				return 1;
			}
			int i = 0;
			while (i < num)
			{
				int num3 = array[i];
				int num4 = array2[i];
				if (num3 != num4)
				{
					if (((long)num3 & (long)((ulong)-1)) >= ((long)num4 & (long)((ulong)-1)))
					{
						return 1;
					}
					return -1;
				}
				else
				{
					i++;
				}
			}
			return 0;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0002E658 File Offset: 0x0002C858
		public override bool Equals(object x)
		{
			if (x == this)
			{
				return true;
			}
			if (!(x is global::NPOI.Util.BigInteger) || x == null)
			{
				return false;
			}
			global::NPOI.Util.BigInteger bigInteger = (global::NPOI.Util.BigInteger)x;
			if (bigInteger._signum != this._signum)
			{
				return false;
			}
			int[] array = this.mag;
			int num = array.Length;
			int[] array2 = bigInteger.mag;
			if (num != array2.Length)
			{
				return false;
			}
			for (int i = 0; i < num; i++)
			{
				if (array2[i] != array[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0002E6C6 File Offset: 0x0002C8C6
		public global::NPOI.Util.BigInteger Min(global::NPOI.Util.BigInteger val)
		{
			if (this.CompareTo(val) >= 0)
			{
				return val;
			}
			return this;
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0002E6D5 File Offset: 0x0002C8D5
		public global::NPOI.Util.BigInteger Max(global::NPOI.Util.BigInteger val)
		{
			if (this.CompareTo(val) <= 0)
			{
				return val;
			}
			return this;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0002E6E4 File Offset: 0x0002C8E4
		public override int GetHashCode()
		{
			int num = 0;
			for (int i = 0; i < this.mag.Length; i++)
			{
				num = (int)((long)(31 * num) + ((long)this.mag[i] & (long)((ulong)-1)));
			}
			return num * this._signum;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x0002E722 File Offset: 0x0002C922
		public int IntValue()
		{
			return this.GetInt(0);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0002E72C File Offset: 0x0002C92C
		public global::NPOI.Util.BigInteger ShiftLeft(int n)
		{
			if (this._signum == 0)
			{
				return global::NPOI.Util.BigInteger.ZERO;
			}
			if (n == 0)
			{
				return this;
			}
			if (n >= 0)
			{
				int num = global::NPOI.Util.Operator.UnsignedRightShift(n, 5);
				int num2 = n & 31;
				int num3 = this.mag.Length;
				int[] array;
				if (num2 == 0)
				{
					array = new int[num3 + num];
					for (int i = 0; i < num3; i++)
					{
						array[i] = this.mag[i];
					}
				}
				else
				{
					int num4 = 0;
					int val = 32 - num2;
					int num5 = global::NPOI.Util.Operator.UnsignedRightShift(this.mag[0], val);
					if (num5 != 0)
					{
						array = new int[num3 + num + 1];
						array[num4++] = num5;
					}
					else
					{
						array = new int[num3 + num];
					}
					int j = 0;
					while (j < num3 - 1)
					{
						array[num4++] = (this.mag[j++] << (num2 & 31) | global::NPOI.Util.Operator.UnsignedRightShift(this.mag[j], val));
					}
					array[num4] = this.mag[j] << num2;
				}
				return new global::NPOI.Util.BigInteger(array, this._signum);
			}
			if (n == -2147483648)
			{
				throw new global::System.ArithmeticException("Shift distance of Integer.Min_VALUE not supported.");
			}
			return this.ShiftRight(-n);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x0002E848 File Offset: 0x0002CA48
		public long LongValue()
		{
			long num = 0L;
			for (int i = 1; i >= 0; i--)
			{
				num = (num << 32) + ((long)this.GetInt(i) & (long)((ulong)-1));
			}
			return num;
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0002E878 File Offset: 0x0002CA78
		public global::NPOI.Util.BigInteger ShiftRight(int n)
		{
			if (n == 0)
			{
				return this;
			}
			if (n < 0)
			{
				if (n == -2147483648)
				{
					throw new global::System.ArithmeticException("Shift distance of Integer.Min_VALUE not supported.");
				}
				return this.ShiftLeft(-n);
			}
			else
			{
				int num = global::NPOI.Util.Operator.UnsignedRightShift(n, 5);
				int num2 = n & 31;
				int num3 = this.mag.Length;
				if (num < num3)
				{
					int[] array;
					if (num2 == 0)
					{
						int num4 = num3 - num;
						array = new int[num4];
						for (int i = 0; i < num4; i++)
						{
							array[i] = this.mag[i];
						}
					}
					else
					{
						int num5 = 0;
						int num6 = global::NPOI.Util.Operator.UnsignedRightShift(this.mag[0], num2);
						if (num6 != 0)
						{
							array = new int[num3 - num];
							array[num5++] = num6;
						}
						else
						{
							array = new int[num3 - num - 1];
						}
						int num7 = 32 - num2;
						int j = 0;
						while (j < num3 - num - 1)
						{
							array[num5++] = (this.mag[j++] << (num7 & 31) | global::NPOI.Util.Operator.UnsignedRightShift(this.mag[j], num2));
						}
					}
					if (this._signum < 0)
					{
						bool flag = false;
						int num8 = num3 - 1;
						int num9 = num3 - num;
						while (num8 >= num9 && !flag)
						{
							flag = (this.mag[num8] != 0);
							num8--;
						}
						if (!flag && num2 != 0)
						{
							flag = (this.mag[num3 - num - 1] << 32 - num2 != 0);
						}
						if (flag)
						{
							array = this.Increment(array);
						}
					}
					return new global::NPOI.Util.BigInteger(array, this._signum);
				}
				if (this._signum < 0)
				{
					return global::NPOI.Util.BigInteger.negConst[1];
				}
				return global::NPOI.Util.BigInteger.ZERO;
			}
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0002E9F4 File Offset: 0x0002CBF4
		private int[] Increment(int[] val)
		{
			int num = 0;
			int num2 = val.Length - 1;
			while (num2 >= 0 && num == 0)
			{
				num = ++val[num2];
				num2--;
			}
			if (num == 0)
			{
				val = new int[val.Length + 1];
				val[0] = 1;
			}
			return val;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0002EA3C File Offset: 0x0002CC3C
		public global::NPOI.Util.BigInteger and(global::NPOI.Util.BigInteger val)
		{
			int[] array = new int[global::System.Math.Max(this.intLength(), val.intLength())];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (this.GetInt(array.Length - i - 1) & val.GetInt(array.Length - i - 1));
			}
			return global::NPOI.Util.BigInteger.ValueOf(array);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0002EA94 File Offset: 0x0002CC94
		public global::NPOI.Util.BigInteger Not()
		{
			int[] array = new int[this.intLength()];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = ~this.GetInt(array.Length - i - 1);
			}
			return global::NPOI.Util.BigInteger.ValueOf(array);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0002EAD4 File Offset: 0x0002CCD4
		public global::NPOI.Util.BigInteger Or(global::NPOI.Util.BigInteger val)
		{
			int[] array = new int[global::System.Math.Max(this.intLength(), val.intLength())];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (this.GetInt(array.Length - i - 1) | val.GetInt(array.Length - i - 1));
			}
			return global::NPOI.Util.BigInteger.ValueOf(array);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0002EB2C File Offset: 0x0002CD2C
		private global::NPOI.Util.BigInteger Multiply(long v)
		{
			if (v == 0L || this._signum == 0)
			{
				return global::NPOI.Util.BigInteger.ZERO;
			}
			if (v == -9223372036854775808L)
			{
				return this.Multiply(global::NPOI.Util.BigInteger.ValueOf(v));
			}
			int signum = (v > 0L) ? this._signum : (-this._signum);
			if (v < 0L)
			{
				v = -v;
			}
			long num = global::NPOI.Util.Operator.UnsignedRightShift(v, 32);
			long num2 = v & (long)((ulong)-1);
			int num3 = this.mag.Length;
			int[] array = this.mag;
			int[] array2 = (num == 0L) ? new int[num3 + 1] : new int[num3 + 2];
			long num4 = 0L;
			int num5 = array2.Length - 1;
			for (int i = num3 - 1; i >= 0; i--)
			{
				long num6 = ((long)array[i] & (long)((ulong)-1)) * num2 + num4;
				array2[num5--] = (int)num6;
				num4 = global::NPOI.Util.Operator.UnsignedRightShift(num6, 32);
			}
			array2[num5] = (int)num4;
			if (num != 0L)
			{
				num4 = 0L;
				num5 = array2.Length - 2;
				for (int j = num3 - 1; j >= 0; j--)
				{
					long num7 = ((long)array[j] & (long)((ulong)-1)) * num + ((long)array2[num5] & (long)((ulong)-1)) + num4;
					array2[num5--] = (int)num7;
					num4 = global::NPOI.Util.Operator.UnsignedRightShift(num7, 32);
				}
				array2[0] = (int)num4;
			}
			if (num4 == 0L)
			{
				array2 = global::NPOI.Util.Arrays.CopyOfRange(array2, 1, array2.Length);
			}
			return new global::NPOI.Util.BigInteger(array2, signum);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0002EC7C File Offset: 0x0002CE7C
		public global::NPOI.Util.BigInteger Multiply(global::NPOI.Util.BigInteger val)
		{
			if (val._signum == 0 || this._signum == 0)
			{
				return global::NPOI.Util.BigInteger.ZERO;
			}
			return new global::NPOI.Util.BigInteger(global::NPOI.Util.BigInteger.TrustedStripLeadingZeroInts(this.MultiplyToLen(this.mag, this.mag.Length, val.mag, val.mag.Length, null)), (this._signum == val._signum) ? 1 : -1);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0002ECE0 File Offset: 0x0002CEE0
		public global::NPOI.Util.BigInteger Add(global::NPOI.Util.BigInteger val)
		{
			if (val._signum == 0)
			{
				return this;
			}
			if (this._signum == 0)
			{
				return val;
			}
			if (val._signum == this._signum)
			{
				return new global::NPOI.Util.BigInteger(global::NPOI.Util.BigInteger.add(this.mag, val.mag), this._signum);
			}
			int num = this.compareMagnitude(val);
			if (num == 0)
			{
				return global::NPOI.Util.BigInteger.ZERO;
			}
			return new global::NPOI.Util.BigInteger(global::NPOI.Util.BigInteger.TrustedStripLeadingZeroInts((num > 0) ? global::NPOI.Util.BigInteger.Subtract(this.mag, val.mag) : global::NPOI.Util.BigInteger.Subtract(val.mag, this.mag)), (num == this._signum) ? 1 : -1);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0002ED7C File Offset: 0x0002CF7C
		private static int[] add(int[] x, int[] y)
		{
			if (x.Length < y.Length)
			{
				int[] array = x;
				x = y;
				y = array;
			}
			int i = x.Length;
			int j = y.Length;
			int[] array2 = new int[i];
			long num = 0L;
			while (j > 0)
			{
				num = ((long)x[--i] & (long)((ulong)-1)) + ((long)y[--j] & (long)((ulong)-1)) + global::NPOI.Util.Operator.UnsignedRightShift(num, 32);
				array2[i] = (int)num;
			}
			bool flag = global::NPOI.Util.Operator.UnsignedRightShift(num, 32) != 0L;
			while (i > 0 && flag)
			{
				flag = ((array2[--i] = x[i] + 1) == 0);
			}
			while (i > 0)
			{
				array2[--i] = x[i];
			}
			if (flag)
			{
				int[] array3 = new int[array2.Length + 1];
				global::System.Array.Copy(array2, 0, array3, 1, array2.Length);
				array3[0] = 1;
				return array3;
			}
			return array2;
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0002EE3C File Offset: 0x0002D03C
		public global::NPOI.Util.BigInteger Subtract(global::NPOI.Util.BigInteger val)
		{
			if (val._signum == 0)
			{
				return this;
			}
			if (this._signum == 0)
			{
				return val.Negate();
			}
			if (val._signum != this._signum)
			{
				return new global::NPOI.Util.BigInteger(global::NPOI.Util.BigInteger.add(this.mag, val.mag), this._signum);
			}
			int num = this.compareMagnitude(val);
			if (num == 0)
			{
				return global::NPOI.Util.BigInteger.ZERO;
			}
			return new global::NPOI.Util.BigInteger(global::NPOI.Util.BigInteger.TrustedStripLeadingZeroInts((num > 0) ? global::NPOI.Util.BigInteger.Subtract(this.mag, val.mag) : global::NPOI.Util.BigInteger.Subtract(val.mag, this.mag)), (num == this._signum) ? 1 : -1);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0002EEE0 File Offset: 0x0002D0E0
		private static int[] Subtract(int[] big, int[] little)
		{
			int i = big.Length;
			int[] array = new int[i];
			int j = little.Length;
			long num = 0L;
			while (j > 0)
			{
				num = ((long)big[--i] & (long)((ulong)-1)) - ((long)little[--j] & (long)((ulong)-1)) + (num >> 32);
				array[i] = (int)num;
			}
			bool flag = num >> 32 != 0L;
			while (i > 0 && flag)
			{
				flag = ((array[--i] = big[i] - 1) == -1);
			}
			while (i > 0)
			{
				array[--i] = big[i];
			}
			return array;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0002EF64 File Offset: 0x0002D164
		public global::NPOI.Util.BigInteger Divide(global::NPOI.Util.BigInteger val)
		{
			global::NPOI.Util.MutableBigInteger mutableBigInteger = new global::NPOI.Util.MutableBigInteger();
			global::NPOI.Util.MutableBigInteger mutableBigInteger2 = new global::NPOI.Util.MutableBigInteger(this.mag);
			global::NPOI.Util.MutableBigInteger b = new global::NPOI.Util.MutableBigInteger(val.mag);
			mutableBigInteger2.divide(b, mutableBigInteger);
			return mutableBigInteger.toBigInteger((this._signum == val._signum) ? 1 : -1);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0002EFAE File Offset: 0x0002D1AE
		public static global::NPOI.Util.BigInteger operator >>(global::NPOI.Util.BigInteger bi1, int shiftVal)
		{
			return bi1.ShiftRight(shiftVal);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0002EFB7 File Offset: 0x0002D1B7
		public static global::NPOI.Util.BigInteger operator <<(global::NPOI.Util.BigInteger bi1, int shiftVal)
		{
			return bi1.ShiftLeft(shiftVal);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0002EFC0 File Offset: 0x0002D1C0
		public static global::NPOI.Util.BigInteger operator &(global::NPOI.Util.BigInteger bi1, global::NPOI.Util.BigInteger bi2)
		{
			return bi1.and(bi2);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0002EFC9 File Offset: 0x0002D1C9
		public static global::NPOI.Util.BigInteger operator |(global::NPOI.Util.BigInteger bi1, global::NPOI.Util.BigInteger bi2)
		{
			return bi1.Or(bi2);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0002EFD2 File Offset: 0x0002D1D2
		public static global::NPOI.Util.BigInteger operator *(global::NPOI.Util.BigInteger bi1, global::NPOI.Util.BigInteger bi2)
		{
			return bi1.Multiply(bi2);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0002EFDB File Offset: 0x0002D1DB
		public static global::NPOI.Util.BigInteger operator +(global::NPOI.Util.BigInteger bi1, global::NPOI.Util.BigInteger bi2)
		{
			return bi1.Add(bi2);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0002EFE4 File Offset: 0x0002D1E4
		public static global::NPOI.Util.BigInteger operator -(global::NPOI.Util.BigInteger bi1, global::NPOI.Util.BigInteger bi2)
		{
			return bi1.Subtract(bi2);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0002EFED File Offset: 0x0002D1ED
		public static bool operator <(global::NPOI.Util.BigInteger bi1, global::NPOI.Util.BigInteger bi2)
		{
			return bi1.CompareTo(bi2) < 0;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0002EFF9 File Offset: 0x0002D1F9
		public static bool operator >(global::NPOI.Util.BigInteger bi1, global::NPOI.Util.BigInteger bi2)
		{
			return bi1.CompareTo(bi2) > 0;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0002F005 File Offset: 0x0002D205
		public static global::NPOI.Util.BigInteger operator /(global::NPOI.Util.BigInteger bi1, global::NPOI.Util.BigInteger bi2)
		{
			return bi1.Divide(bi2);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x0002F00E File Offset: 0x0002D20E
		public static bool operator ==(global::NPOI.Util.BigInteger bi1, global::NPOI.Util.BigInteger bi2)
		{
			return bi1.Equals(bi2);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0002F017 File Offset: 0x0002D217
		public static bool operator !=(global::NPOI.Util.BigInteger bi1, global::NPOI.Util.BigInteger bi2)
		{
			return !(bi1 == bi2);
		}

		// Token: 0x040006C6 RID: 1734
		private int _signum;

		// Token: 0x040006C7 RID: 1735
		internal int[] mag;

		// Token: 0x040006C8 RID: 1736
		private int bitCount;

		// Token: 0x040006C9 RID: 1737
		private int bitLength;

		// Token: 0x040006CA RID: 1738
		private int firstNonzeroIntNum;

		// Token: 0x040006CB RID: 1739
		public const long LONG_MASK = 4294967295L;

		// Token: 0x040006CC RID: 1740
		public const long INFLATED = -9223372036854775808L;

		// Token: 0x040006CD RID: 1741
		public const int Min_RADIX = 2;

		// Token: 0x040006CE RID: 1742
		public const int Max_RADIX = 36;

		// Token: 0x040006CF RID: 1743
		private static global::NPOI.Util.BigInteger[] posConst = new global::NPOI.Util.BigInteger[17];

		// Token: 0x040006D0 RID: 1744
		private static global::NPOI.Util.BigInteger[] negConst = new global::NPOI.Util.BigInteger[17];

		// Token: 0x040006D1 RID: 1745
		private static readonly string[] zeros = new string[64];

		// Token: 0x040006D2 RID: 1746
		public static readonly global::NPOI.Util.BigInteger ZERO = new global::NPOI.Util.BigInteger(new int[0], 0);

		// Token: 0x040006D3 RID: 1747
		public static readonly global::NPOI.Util.BigInteger One = global::NPOI.Util.BigInteger.ValueOf(1L);

		// Token: 0x040006D4 RID: 1748
		private static readonly global::NPOI.Util.BigInteger Two = global::NPOI.Util.BigInteger.ValueOf(2L);

		// Token: 0x040006D5 RID: 1749
		public static readonly global::NPOI.Util.BigInteger TEN = global::NPOI.Util.BigInteger.ValueOf(10L);

		// Token: 0x040006D6 RID: 1750
		private const int Max_CONSTANT = 16;

		// Token: 0x040006D7 RID: 1751
		private static readonly int[] digitsPerLong = new int[]
		{
			0,
			0,
			62,
			39,
			31,
			27,
			24,
			22,
			20,
			19,
			18,
			18,
			17,
			17,
			16,
			16,
			15,
			15,
			15,
			14,
			14,
			14,
			14,
			13,
			13,
			13,
			13,
			13,
			13,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12
		};

		// Token: 0x040006D8 RID: 1752
		private static readonly global::NPOI.Util.BigInteger[] longRadix = new global::NPOI.Util.BigInteger[]
		{
			null,
			null,
			global::NPOI.Util.BigInteger.ValueOf(4611686018427387904L),
			global::NPOI.Util.BigInteger.ValueOf(4052555153018976267L),
			global::NPOI.Util.BigInteger.ValueOf(4611686018427387904L),
			global::NPOI.Util.BigInteger.ValueOf(7450580596923828125L),
			global::NPOI.Util.BigInteger.ValueOf(4738381338321616896L),
			global::NPOI.Util.BigInteger.ValueOf(3909821048582988049L),
			global::NPOI.Util.BigInteger.ValueOf(1152921504606846976L),
			global::NPOI.Util.BigInteger.ValueOf(1350851717672992089L),
			global::NPOI.Util.BigInteger.ValueOf(1000000000000000000L),
			global::NPOI.Util.BigInteger.ValueOf(5559917313492231481L),
			global::NPOI.Util.BigInteger.ValueOf(2218611106740436992L),
			global::NPOI.Util.BigInteger.ValueOf(8650415919381337933L),
			global::NPOI.Util.BigInteger.ValueOf(2177953337809371136L),
			global::NPOI.Util.BigInteger.ValueOf(6568408355712890625L),
			global::NPOI.Util.BigInteger.ValueOf(1152921504606846976L),
			global::NPOI.Util.BigInteger.ValueOf(2862423051509815793L),
			global::NPOI.Util.BigInteger.ValueOf(6746640616477458432L),
			global::NPOI.Util.BigInteger.ValueOf(799006685782884121L),
			global::NPOI.Util.BigInteger.ValueOf(1638400000000000000L),
			global::NPOI.Util.BigInteger.ValueOf(3243919932521508681L),
			global::NPOI.Util.BigInteger.ValueOf(6221821273427820544L),
			global::NPOI.Util.BigInteger.ValueOf(504036361936467383L),
			global::NPOI.Util.BigInteger.ValueOf(876488338465357824L),
			global::NPOI.Util.BigInteger.ValueOf(1490116119384765625L),
			global::NPOI.Util.BigInteger.ValueOf(2481152873203736576L),
			global::NPOI.Util.BigInteger.ValueOf(4052555153018976267L),
			global::NPOI.Util.BigInteger.ValueOf(6502111422497947648L),
			global::NPOI.Util.BigInteger.ValueOf(353814783205469041L),
			global::NPOI.Util.BigInteger.ValueOf(531441000000000000L),
			global::NPOI.Util.BigInteger.ValueOf(787662783788549761L),
			global::NPOI.Util.BigInteger.ValueOf(1152921504606846976L),
			global::NPOI.Util.BigInteger.ValueOf(1667889514952984961L),
			global::NPOI.Util.BigInteger.ValueOf(2386420683693101056L),
			global::NPOI.Util.BigInteger.ValueOf(3379220508056640625L),
			global::NPOI.Util.BigInteger.ValueOf(4738381338321616896L)
		};

		// Token: 0x040006D9 RID: 1753
		private static readonly long[] bitsPerDigit = new long[]
		{
			0L,
			0L,
			1024L,
			1624L,
			2048L,
			2378L,
			2648L,
			2875L,
			3072L,
			3247L,
			3402L,
			3543L,
			3672L,
			3790L,
			3899L,
			4001L,
			4096L,
			4186L,
			4271L,
			4350L,
			4426L,
			4498L,
			4567L,
			4633L,
			4696L,
			4756L,
			4814L,
			4870L,
			4923L,
			4975L,
			5025L,
			5074L,
			5120L,
			5166L,
			5210L,
			5253L,
			5295L
		};

		// Token: 0x040006DA RID: 1754
		private static readonly int[] digitsPerInt = new int[]
		{
			0,
			0,
			30,
			19,
			15,
			13,
			11,
			11,
			10,
			9,
			9,
			8,
			8,
			8,
			8,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			6,
			6,
			6,
			6,
			6,
			6,
			6,
			6,
			6,
			6,
			6,
			6,
			6,
			6,
			5
		};

		// Token: 0x040006DB RID: 1755
		private static readonly int[] intRadix = new int[]
		{
			0,
			0,
			1073741824,
			1162261467,
			1073741824,
			1220703125,
			362797056,
			1977326743,
			1073741824,
			387420489,
			1000000000,
			214358881,
			429981696,
			815730721,
			1475789056,
			170859375,
			268435456,
			410338673,
			612220032,
			893871739,
			1280000000,
			1801088541,
			113379904,
			148035889,
			191102976,
			244140625,
			308915776,
			387420489,
			481890304,
			594823321,
			729000000,
			887503681,
			1073741824,
			1291467969,
			1544804416,
			1838265625,
			60466176
		};
	}
}
