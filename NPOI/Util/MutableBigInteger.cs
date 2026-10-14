using System;

namespace NPOI.Util
{
	// Token: 0x0200025F RID: 607
	internal class MutableBigInteger
	{
		// Token: 0x06000F83 RID: 3971 RVA: 0x0002F023 File Offset: 0x0002D223
		public MutableBigInteger()
		{
			this._value = new int[1];
			this.intLen = 0;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0002F03E File Offset: 0x0002D23E
		public MutableBigInteger(int val)
		{
			this._value = new int[1];
			this.intLen = 1;
			this._value[0] = val;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0002F062 File Offset: 0x0002D262
		public MutableBigInteger(int[] val)
		{
			this._value = val;
			this.intLen = val.Length;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0002F07C File Offset: 0x0002D27C
		public static int[] ArraysCopyOf(int[] original, int newLength)
		{
			int[] array = new int[newLength];
			global::System.Array.Copy(original, 0, array, 0, global::System.Math.Min(original.Length, newLength));
			return array;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0002F0A4 File Offset: 0x0002D2A4
		public static long[] ArraysCopyOf(long[] original, int newLength)
		{
			long[] array = new long[newLength];
			global::System.Array.Copy(original, 0, array, 0, global::System.Math.Min(original.Length, newLength));
			return array;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0002F0CC File Offset: 0x0002D2CC
		public static int[] ArraysCopyOfRange(int[] original, int from, int to)
		{
			int num = to - from;
			if (num < 0)
			{
				throw new global::System.ArgumentException(from.ToString() + " > " + to.ToString());
			}
			int[] array = new int[num];
			global::System.Array.Copy(original, from, array, 0, global::System.Math.Min(original.Length - from, num));
			return array;
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0002F11C File Offset: 0x0002D31C
		public static long[] ArraysCopyOfRange(long[] original, int from, int to)
		{
			int num = to - from;
			if (num < 0)
			{
				throw new global::System.ArgumentException(from.ToString() + " > " + to.ToString());
			}
			long[] array = new long[num];
			global::System.Array.Copy(original, from, array, 0, global::System.Math.Min(original.Length - from, num));
			return array;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0002F16B File Offset: 0x0002D36B
		private MutableBigInteger(global::NPOI.Util.BigInteger b)
		{
			this.intLen = b.mag.Length;
			this._value = global::NPOI.Util.MutableBigInteger.ArraysCopyOf(b.mag, this.intLen);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0002F198 File Offset: 0x0002D398
		private MutableBigInteger(global::NPOI.Util.MutableBigInteger val)
		{
			this.intLen = val.intLen;
			this._value = global::NPOI.Util.MutableBigInteger.ArraysCopyOfRange(val._value, val.offset, val.offset + this.intLen);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0002F1D0 File Offset: 0x0002D3D0
		private int[] getMagnitudeArray()
		{
			if (this.offset > 0 || this._value.Length != this.intLen)
			{
				return global::NPOI.Util.MutableBigInteger.ArraysCopyOfRange(this._value, this.offset, this.offset + this.intLen);
			}
			return this._value;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0002F210 File Offset: 0x0002D410
		private long toLong()
		{
			if (this.intLen == 0)
			{
				return 0L;
			}
			long num = (long)this._value[this.offset] & (long)((ulong)-1);
			if (this.intLen != 2)
			{
				return num;
			}
			return num << 32 | ((long)this._value[this.offset + 1] & (long)((ulong)-1));
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0002F25D File Offset: 0x0002D45D
		public global::NPOI.Util.BigInteger toBigInteger(int sign)
		{
			if (this.intLen == 0 || sign == 0)
			{
				return global::NPOI.Util.BigInteger.ZERO;
			}
			return new global::NPOI.Util.BigInteger(this.getMagnitudeArray(), sign);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0002F27C File Offset: 0x0002D47C
		private void clear()
		{
			this.offset = (this.intLen = 0);
			int i = 0;
			int num = this._value.Length;
			while (i < num)
			{
				this._value[i] = 0;
				i++;
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0002F2B8 File Offset: 0x0002D4B8
		private void reset()
		{
			this.offset = (this.intLen = 0);
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0002F2D8 File Offset: 0x0002D4D8
		private int compare(global::NPOI.Util.MutableBigInteger b)
		{
			int num = b.intLen;
			if (this.intLen < num)
			{
				return -1;
			}
			if (this.intLen > num)
			{
				return 1;
			}
			int[] value = b._value;
			int i = this.offset;
			int num2 = b.offset;
			while (i < this.intLen + this.offset)
			{
				int num3 = (int)((long)this._value[i] + (long)((ulong)int.MinValue));
				int num4 = (int)((long)value[num2] + (long)((ulong)int.MinValue));
				if (num3 < num4)
				{
					return -1;
				}
				if (num3 > num4)
				{
					return 1;
				}
				i++;
				num2++;
			}
			return 0;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0002F364 File Offset: 0x0002D564
		private int compareHalf(global::NPOI.Util.MutableBigInteger b)
		{
			int num = b.intLen;
			int num2 = this.intLen;
			if (num2 <= 0)
			{
				if (num > 0)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (num2 > num)
				{
					return 1;
				}
				if (num2 < num - 1)
				{
					return -1;
				}
				int[] value = b._value;
				int num3 = 0;
				int num4 = 0;
				if (num2 != num)
				{
					if (value[num3] != 1)
					{
						return -1;
					}
					num3++;
					num4 = int.MinValue;
				}
				int[] value2 = this._value;
				int i = this.offset;
				int num5 = num3;
				while (i < num2 + this.offset)
				{
					int num6 = value[num5++];
					long num7 = (long)(global::NPOI.Util.Operator.UnsignedRightShift(num6, 1) + num4) & (long)((ulong)-1);
					long num8 = (long)value2[i++] & (long)((ulong)-1);
					if (num8 != num7)
					{
						if (num8 >= num7)
						{
							return 1;
						}
						return -1;
					}
					else
					{
						num4 = (num6 & 1) << 31;
					}
				}
				if (num4 != 0)
				{
					return -1;
				}
				return 0;
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0002F42C File Offset: 0x0002D62C
		private int getLowestSetBit()
		{
			if (this.intLen == 0)
			{
				return -1;
			}
			int num = this.intLen - 1;
			while (num > 0 && this._value[num + this.offset] == 0)
			{
				num--;
			}
			int num2 = this._value[num + this.offset];
			if (num2 == 0)
			{
				return -1;
			}
			return (this.intLen - 1 - num << 5) + global::NPOI.Util.BigInteger.NumberOfTrailingZeros(num2);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0002F48F File Offset: 0x0002D68F
		private int getInt(int index)
		{
			return this._value[this.offset + index];
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0002F4A0 File Offset: 0x0002D6A0
		private long getLong(int index)
		{
			return (long)this._value[this.offset + index] & (long)((ulong)-1);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0002F4B8 File Offset: 0x0002D6B8
		private void normalize()
		{
			if (this.intLen == 0)
			{
				this.offset = 0;
				return;
			}
			int num = this.offset;
			if (this._value[num] != 0)
			{
				return;
			}
			int num2 = num + this.intLen;
			do
			{
				num++;
			}
			while (num < num2 && this._value[num] == 0);
			int num3 = num - this.offset;
			this.intLen -= num3;
			this.offset = ((this.intLen == 0) ? 0 : (this.offset + num3));
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0002F532 File Offset: 0x0002D732
		private void ensureCapacity(int len)
		{
			if (this._value.Length < len)
			{
				this._value = new int[len];
				this.offset = 0;
				this.intLen = len;
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0002F55C File Offset: 0x0002D75C
		private int[] toIntArray()
		{
			int[] array = new int[this.intLen];
			for (int i = 0; i < this.intLen; i++)
			{
				array[i] = this._value[this.offset + i];
			}
			return array;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0002F599 File Offset: 0x0002D799
		private void setInt(int index, int val)
		{
			this._value[this.offset + index] = val;
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0002F5AB File Offset: 0x0002D7AB
		private void setValue(int[] val, int length)
		{
			this._value = val;
			this.intLen = length;
			this.offset = 0;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x0002F5C4 File Offset: 0x0002D7C4
		private void copyValue(global::NPOI.Util.MutableBigInteger src)
		{
			int num = src.intLen;
			if (this._value.Length < num)
			{
				this._value = new int[num];
			}
			global::System.Array.Copy(src._value, src.offset, this._value, 0, num);
			this.intLen = num;
			this.offset = 0;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0002F618 File Offset: 0x0002D818
		private void copyValue(int[] val)
		{
			int num = val.Length;
			if (this._value.Length < num)
			{
				this._value = new int[num];
			}
			global::System.Array.Copy(val, 0, this._value, 0, num);
			this.intLen = num;
			this.offset = 0;
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0002F65D File Offset: 0x0002D85D
		private bool isOne()
		{
			return this.intLen == 1 && this._value[this.offset] == 1;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0002F67A File Offset: 0x0002D87A
		private bool isZero()
		{
			return this.intLen == 0;
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0002F685 File Offset: 0x0002D885
		private bool isEven()
		{
			return this.intLen == 0 || (this._value[this.offset + this.intLen - 1] & 1) == 0;
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0002F6AC File Offset: 0x0002D8AC
		private bool isOdd()
		{
			return !this.isZero() && (this._value[this.offset + this.intLen - 1] & 1) == 1;
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0002F6D3 File Offset: 0x0002D8D3
		private bool isNormal()
		{
			return this.intLen + this.offset <= this._value.Length && (this.intLen == 0 || this._value[this.offset] != 0);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0002F708 File Offset: 0x0002D908
		public string toString()
		{
			return this.toBigInteger(1).ToString();
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0002F718 File Offset: 0x0002D918
		private void rightShift(int n)
		{
			if (this.intLen == 0)
			{
				return;
			}
			int num = global::NPOI.Util.Operator.UnsignedRightShift(n, 5);
			int num2 = n & 31;
			this.intLen -= num;
			if (num2 == 0)
			{
				return;
			}
			int num3 = global::NPOI.Util.BigInteger.BitLengthForInt(this._value[this.offset]);
			if (num2 >= num3)
			{
				this.primitiveLeftShift(32 - num2);
				this.intLen--;
				return;
			}
			this.primitiveRightShift(num2);
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0002F784 File Offset: 0x0002D984
		private void leftShift(int n)
		{
			if (this.intLen == 0)
			{
				return;
			}
			int num = global::NPOI.Util.Operator.UnsignedRightShift(n, 5);
			int num2 = n & 31;
			int num3 = global::NPOI.Util.BigInteger.BitLengthForInt(this._value[this.offset]);
			if (n <= 32 - num3)
			{
				this.primitiveLeftShift(num2);
				return;
			}
			int num4 = this.intLen + num + 1;
			if (num2 <= 32 - num3)
			{
				num4--;
			}
			if (this._value.Length < num4)
			{
				int[] array = new int[num4];
				for (int i = 0; i < this.intLen; i++)
				{
					array[i] = this._value[this.offset + i];
				}
				this.setValue(array, num4);
			}
			else if (this._value.Length - this.offset >= num4)
			{
				for (int j = 0; j < num4 - this.intLen; j++)
				{
					this._value[this.offset + this.intLen + j] = 0;
				}
			}
			else
			{
				for (int k = 0; k < this.intLen; k++)
				{
					this._value[k] = this._value[this.offset + k];
				}
				for (int l = this.intLen; l < num4; l++)
				{
					this._value[l] = 0;
				}
				this.offset = 0;
			}
			this.intLen = num4;
			if (num2 == 0)
			{
				return;
			}
			if (num2 <= 32 - num3)
			{
				this.primitiveLeftShift(num2);
				return;
			}
			this.primitiveRightShift(32 - num2);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0002F8E8 File Offset: 0x0002DAE8
		private int divadd(int[] a, int[] result, int offset)
		{
			long num = 0L;
			for (int i = a.Length - 1; i >= 0; i--)
			{
				long num2 = ((long)a[i] & (long)((ulong)-1)) + ((long)result[i + offset] & (long)((ulong)-1)) + num;
				result[i + offset] = (int)num2;
				num = global::NPOI.Util.Operator.UnsignedRightShift(num2, 32);
			}
			return (int)num;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0002F930 File Offset: 0x0002DB30
		private int mulsub(int[] q, int[] a, int x, int len, int offset)
		{
			long num = (long)x & (long)((ulong)-1);
			long num2 = 0L;
			offset += len;
			for (int i = len - 1; i >= 0; i--)
			{
				long num3 = ((long)a[i] & (long)((ulong)-1)) * num + num2;
				long num4 = (long)q[offset] - num3;
				q[offset--] = (int)num4;
				num2 = global::NPOI.Util.Operator.UnsignedRightShift(num3, 32) + (((num4 & (long)((ulong)-1)) > ((long)(~(long)((int)num3)) & (long)((ulong)-1))) ? 1L : 0L);
			}
			return (int)num2;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0002F99C File Offset: 0x0002DB9C
		private void primitiveRightShift(int n)
		{
			int[] value = this._value;
			int num = 32 - n;
			int i = this.offset + this.intLen - 1;
			int num2 = value[i];
			while (i > this.offset)
			{
				int operand = num2;
				num2 = value[i - 1];
				value[i] = (num2 << num | global::NPOI.Util.Operator.UnsignedRightShift(operand, n));
				i--;
			}
			value[this.offset] = global::NPOI.Util.Operator.UnsignedRightShift(value[this.offset], n);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0002FA0C File Offset: 0x0002DC0C
		private void primitiveLeftShift(int n)
		{
			int[] value = this._value;
			int val = 32 - n;
			int i = this.offset;
			int num = value[i];
			int num2 = i + this.intLen - 1;
			while (i < num2)
			{
				int num3 = num;
				num = value[i + 1];
				value[i] = (num3 << n | global::NPOI.Util.Operator.UnsignedRightShift(num, val));
				i++;
			}
			value[this.offset + this.intLen - 1] <<= n;
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0002FA80 File Offset: 0x0002DC80
		private void add(global::NPOI.Util.MutableBigInteger addend)
		{
			int i = this.intLen;
			int j = addend.intLen;
			int num = (this.intLen > addend.intLen) ? this.intLen : addend.intLen;
			int[] array = (this._value.Length < num) ? new int[num] : this._value;
			int num2 = array.Length - 1;
			long num3 = 0L;
			while (i > 0)
			{
				if (j <= 0)
				{
					break;
				}
				i--;
				j--;
				long num4 = ((long)this._value[i + this.offset] & (long)((ulong)-1)) + ((long)addend._value[j + addend.offset] & (long)((ulong)-1)) + num3;
				array[num2--] = (int)num4;
				num3 = global::NPOI.Util.Operator.UnsignedRightShift(num4, 32);
			}
			while (i > 0)
			{
				i--;
				if (num3 == 0L && array == this._value && num2 == i + this.offset)
				{
					return;
				}
				long num4 = ((long)this._value[i + this.offset] & (long)((ulong)-1)) + num3;
				array[num2--] = (int)num4;
				num3 = global::NPOI.Util.Operator.UnsignedRightShift(num4, 32);
			}
			while (j > 0)
			{
				j--;
				long num4 = ((long)addend._value[j + addend.offset] & (long)((ulong)-1)) + num3;
				array[num2--] = (int)num4;
				num3 = global::NPOI.Util.Operator.UnsignedRightShift(num4, 32);
			}
			if (num3 > 0L)
			{
				num++;
				if (array.Length < num)
				{
					int[] array2 = new int[num];
					global::System.Array.Copy(array, 0, array2, 1, array.Length);
					array2[0] = 1;
					array = array2;
				}
				else
				{
					array[num2--] = 1;
				}
			}
			this._value = array;
			this.intLen = num;
			this.offset = array.Length - num;
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x0002FC10 File Offset: 0x0002DE10
		private int subtract(global::NPOI.Util.MutableBigInteger b)
		{
			global::NPOI.Util.MutableBigInteger mutableBigInteger = this;
			int[] array = this._value;
			int num = mutableBigInteger.compare(b);
			if (num == 0)
			{
				this.reset();
				return 0;
			}
			if (num < 0)
			{
				global::NPOI.Util.MutableBigInteger mutableBigInteger2 = mutableBigInteger;
				mutableBigInteger = b;
				b = mutableBigInteger2;
			}
			int num2 = mutableBigInteger.intLen;
			if (array.Length < num2)
			{
				array = new int[num2];
			}
			long num3 = 0L;
			int i = mutableBigInteger.intLen;
			int j = b.intLen;
			int num4 = array.Length - 1;
			while (j > 0)
			{
				i--;
				j--;
				num3 = ((long)mutableBigInteger._value[i + mutableBigInteger.offset] & (long)((ulong)-1)) - ((long)b._value[j + b.offset] & (long)((ulong)-1)) - (long)((int)(-(int)(num3 >> 32)));
				array[num4--] = (int)num3;
			}
			while (i > 0)
			{
				i--;
				num3 = ((long)mutableBigInteger._value[i + mutableBigInteger.offset] & (long)((ulong)-1)) - (long)((int)(-(int)(num3 >> 32)));
				array[num4--] = (int)num3;
			}
			this._value = array;
			this.intLen = num2;
			this.offset = this._value.Length - num2;
			this.normalize();
			return num;
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x0002FD24 File Offset: 0x0002DF24
		private int difference(global::NPOI.Util.MutableBigInteger b)
		{
			global::NPOI.Util.MutableBigInteger mutableBigInteger = this;
			int num = mutableBigInteger.compare(b);
			if (num == 0)
			{
				return 0;
			}
			if (num < 0)
			{
				global::NPOI.Util.MutableBigInteger mutableBigInteger2 = mutableBigInteger;
				mutableBigInteger = b;
				b = mutableBigInteger2;
			}
			long num2 = 0L;
			int i = mutableBigInteger.intLen;
			int j = b.intLen;
			while (j > 0)
			{
				i--;
				j--;
				num2 = ((long)mutableBigInteger._value[mutableBigInteger.offset + i] & (long)((ulong)-1)) - ((long)b._value[b.offset + j] & (long)((ulong)-1)) - (long)((int)(-(int)(num2 >> 32)));
				mutableBigInteger._value[mutableBigInteger.offset + i] = (int)num2;
			}
			while (i > 0)
			{
				i--;
				num2 = ((long)mutableBigInteger._value[mutableBigInteger.offset + i] & (long)((ulong)-1)) - (long)((int)(-(int)(num2 >> 32)));
				mutableBigInteger._value[mutableBigInteger.offset + i] = (int)num2;
			}
			mutableBigInteger.normalize();
			return num;
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0002FDEC File Offset: 0x0002DFEC
		private void multiply(global::NPOI.Util.MutableBigInteger y, global::NPOI.Util.MutableBigInteger z)
		{
			int num = this.intLen;
			int num2 = y.intLen;
			int num3 = num + num2;
			if (z._value.Length < num3)
			{
				z._value = new int[num3];
			}
			z.offset = 0;
			z.intLen = num3;
			long num4 = 0L;
			int i = num2 - 1;
			int num5 = num2 + num - 1;
			while (i >= 0)
			{
				long num6 = ((long)y._value[i + y.offset] & (long)((ulong)-1)) * ((long)this._value[num - 1 + this.offset] & (long)((ulong)-1)) + num4;
				z._value[num5] = (int)num6;
				num4 = global::NPOI.Util.Operator.UnsignedRightShift(num6, 32);
				i--;
				num5--;
			}
			z._value[num - 1] = (int)num4;
			for (int j = num - 2; j >= 0; j--)
			{
				num4 = 0L;
				int k = num2 - 1;
				int num7 = num2 + j;
				while (k >= 0)
				{
					long num8 = ((long)y._value[k + y.offset] & (long)((ulong)-1)) * ((long)this._value[j + this.offset] & (long)((ulong)-1)) + ((long)z._value[num7] & (long)((ulong)-1)) + num4;
					z._value[num7] = (int)num8;
					num4 = global::NPOI.Util.Operator.UnsignedRightShift(num8, 32);
					k--;
					num7--;
				}
				z._value[j] = (int)num4;
			}
			z.normalize();
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0002FF40 File Offset: 0x0002E140
		public void mul(int y, global::NPOI.Util.MutableBigInteger z)
		{
			if (y == 1)
			{
				z.copyValue(this);
				return;
			}
			if (y == 0)
			{
				z.clear();
				return;
			}
			long num = (long)y & (long)((ulong)-1);
			int[] array = (z._value.Length < this.intLen + 1) ? new int[this.intLen + 1] : z._value;
			long num2 = 0L;
			for (int i = this.intLen - 1; i >= 0; i--)
			{
				long num3 = num * ((long)this._value[i + this.offset] & (long)((ulong)-1)) + num2;
				array[i + 1] = (int)num3;
				num2 = global::NPOI.Util.Operator.UnsignedRightShift(num3, 32);
			}
			if (num2 == 0L)
			{
				z.offset = 1;
				z.intLen = this.intLen;
			}
			else
			{
				z.offset = 0;
				z.intLen = this.intLen + 1;
				array[0] = (int)num2;
			}
			z._value = array;
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x0003000C File Offset: 0x0002E20C
		public int divideOneWord(int divisor, global::NPOI.Util.MutableBigInteger quotient)
		{
			long num = (long)divisor & (long)((ulong)-1);
			if (this.intLen == 1)
			{
				long num2 = (long)this._value[this.offset] & (long)((ulong)-1);
				int num3 = (int)(num2 / num);
				int result = (int)(num2 - (long)num3 * num);
				quotient._value[0] = num3;
				quotient.intLen = ((num3 == 0) ? 0 : 1);
				quotient.offset = 0;
				return result;
			}
			if (quotient._value.Length < this.intLen)
			{
				quotient._value = new int[this.intLen];
			}
			quotient.offset = 0;
			quotient.intLen = this.intLen;
			int num4 = global::NPOI.Util.BigInteger.NumberOfLeadingZeros(divisor);
			int num5 = this._value[this.offset];
			long num6 = (long)num5 & (long)((ulong)-1);
			if (num6 < num)
			{
				quotient._value[0] = 0;
			}
			else
			{
				quotient._value[0] = (int)(num6 / num);
				num5 = (int)(num6 - (long)quotient._value[0] * num);
				num6 = ((long)num5 & (long)((ulong)-1));
			}
			int num7 = this.intLen;
			int[] array = new int[2];
			while (--num7 > 0)
			{
				long num8 = num6 << 32 | ((long)this._value[this.offset + this.intLen - num7] & (long)((ulong)-1));
				if (num8 >= 0L)
				{
					array[0] = (int)(num8 / num);
					array[1] = (int)(num8 - (long)array[0] * num);
				}
				else
				{
					this.divWord(array, num8, divisor);
				}
				quotient._value[this.intLen - num7] = array[0];
				num5 = array[1];
				num6 = ((long)num5 & (long)((ulong)-1));
			}
			quotient.normalize();
			if (num4 > 0)
			{
				return num5 % divisor;
			}
			return num5;
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0003017C File Offset: 0x0002E37C
		public global::NPOI.Util.MutableBigInteger divide(global::NPOI.Util.MutableBigInteger b, global::NPOI.Util.MutableBigInteger quotient)
		{
			if (b.intLen == 0)
			{
				throw new global::System.ArithmeticException("BigInteger divide by zero");
			}
			if (this.intLen == 0)
			{
				quotient.intLen = quotient.offset;
				return new global::NPOI.Util.MutableBigInteger();
			}
			int num = this.compare(b);
			if (num < 0)
			{
				quotient.intLen = (quotient.offset = 0);
				return new global::NPOI.Util.MutableBigInteger(this);
			}
			if (num == 0)
			{
				quotient._value[0] = (quotient.intLen = 1);
				quotient.offset = 0;
				return new global::NPOI.Util.MutableBigInteger();
			}
			quotient.clear();
			if (b.intLen != 1)
			{
				int[] divisor = global::NPOI.Util.MutableBigInteger.ArraysCopyOfRange(b._value, b.offset, b.offset + b.intLen);
				return this.divideMagnitude(divisor, quotient);
			}
			int num2 = this.divideOneWord(b._value[b.offset], quotient);
			if (num2 == 0)
			{
				return new global::NPOI.Util.MutableBigInteger();
			}
			return new global::NPOI.Util.MutableBigInteger(num2);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00030258 File Offset: 0x0002E458
		public long divide(long v, global::NPOI.Util.MutableBigInteger quotient)
		{
			if (v == 0L)
			{
				throw new global::System.ArithmeticException("BigInteger divide by zero");
			}
			if (this.intLen == 0)
			{
				quotient.intLen = (quotient.offset = 0);
				return 0L;
			}
			if (v < 0L)
			{
				v = -v;
			}
			int num = (int)global::NPOI.Util.Operator.UnsignedRightShift(v, 32);
			quotient.clear();
			if (num == 0)
			{
				return (long)this.divideOneWord((int)v, quotient) & (long)((ulong)-1);
			}
			int[] divisor = new int[]
			{
				num,
				(int)(v & (long)((ulong)-1))
			};
			return this.divideMagnitude(divisor, quotient).toLong();
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x000302D8 File Offset: 0x0002E4D8
		private global::NPOI.Util.MutableBigInteger divideMagnitude(int[] divisor, global::NPOI.Util.MutableBigInteger quotient)
		{
			global::NPOI.Util.MutableBigInteger mutableBigInteger = new global::NPOI.Util.MutableBigInteger(new int[this.intLen + 1]);
			global::System.Array.Copy(this._value, this.offset, mutableBigInteger._value, 1, this.intLen);
			mutableBigInteger.intLen = this.intLen;
			mutableBigInteger.offset = 1;
			int num = mutableBigInteger.intLen;
			int num2 = divisor.Length;
			int num3 = num - num2 + 1;
			if (quotient._value.Length < num3)
			{
				quotient._value = new int[num3];
				quotient.offset = 0;
			}
			quotient.intLen = num3;
			int[] value = quotient._value;
			int num4 = global::NPOI.Util.BigInteger.NumberOfLeadingZeros(divisor[0]);
			if (num4 > 0)
			{
				global::NPOI.Util.BigInteger.PrimitiveLeftShift(divisor, num2, num4);
				mutableBigInteger.leftShift(num4);
			}
			if (mutableBigInteger.intLen == num)
			{
				mutableBigInteger.offset = 0;
				mutableBigInteger._value[0] = 0;
				mutableBigInteger.intLen++;
			}
			int num5 = divisor[0];
			long num6 = (long)num5 & (long)((ulong)-1);
			int num7 = divisor[1];
			int[] array = new int[2];
			for (int i = 0; i < num3; i++)
			{
				bool flag = false;
				int num8 = mutableBigInteger._value[i + mutableBigInteger.offset];
				int num9 = (int)((long)num8 + (long)((ulong)int.MinValue));
				int num10 = mutableBigInteger._value[i + 1 + mutableBigInteger.offset];
				int num11;
				int num12;
				if (num8 == num5)
				{
					num11 = -1;
					num12 = num8 + num10;
					flag = ((long)num12 + (long)((ulong)int.MinValue) < (long)num9);
				}
				else
				{
					long num13 = (long)num8 << 32 | ((long)num10 & (long)((ulong)-1));
					if (num13 >= 0L)
					{
						num11 = (int)(num13 / num6);
						num12 = (int)(num13 - (long)num11 * num6);
					}
					else
					{
						this.divWord(array, num13, num5);
						num11 = array[0];
						num12 = array[1];
					}
				}
				if (num11 != 0)
				{
					if (!flag)
					{
						long num14 = (long)mutableBigInteger._value[i + 2 + mutableBigInteger.offset] & (long)((ulong)-1);
						long two = ((long)num12 & (long)((ulong)-1)) << 32 | num14;
						long num15 = ((long)num7 & (long)((ulong)-1)) * ((long)num11 & (long)((ulong)-1));
						if (this.unsignedLongCompare(num15, two))
						{
							num11--;
							num12 = (int)(((long)num12 & (long)((ulong)-1)) + num6);
							if (((long)num12 & (long)((ulong)-1)) >= num6)
							{
								num15 -= ((long)num7 & (long)((ulong)-1));
								two = (((long)num12 & (long)((ulong)-1)) << 32 | num14);
								if (this.unsignedLongCompare(num15, two))
								{
									num11--;
								}
							}
						}
					}
					mutableBigInteger._value[i + mutableBigInteger.offset] = 0;
					if ((int)((long)this.mulsub(mutableBigInteger._value, divisor, num11, num2, i + mutableBigInteger.offset) + (long)((ulong)-2147483648)) > num9)
					{
						this.divadd(divisor, mutableBigInteger._value, i + 1 + mutableBigInteger.offset);
						num11--;
					}
					value[i] = num11;
				}
			}
			if (num4 > 0)
			{
				mutableBigInteger.rightShift(num4);
			}
			quotient.normalize();
			mutableBigInteger.normalize();
			return mutableBigInteger;
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0003058D File Offset: 0x0002E78D
		private bool unsignedLongCompare(long one, long two)
		{
			return one + long.MinValue > two + long.MinValue;
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x000305A8 File Offset: 0x0002E7A8
		private void divWord(int[] result, long n, int d)
		{
			long num = (long)d & (long)((ulong)-1);
			if (num == 1L)
			{
				result[0] = (int)n;
				result[1] = 0;
				return;
			}
			long num2 = global::NPOI.Util.Operator.UnsignedRightShift(n, 1) / global::NPOI.Util.Operator.UnsignedRightShift(num, 1);
			long num3 = n - num2 * num;
			while (num3 < 0L)
			{
				num3 += num;
				num2 -= 1L;
			}
			while (num3 >= num)
			{
				num3 -= num;
				num2 += 1L;
			}
			result[0] = (int)num2;
			result[1] = (int)num3;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0003060C File Offset: 0x0002E80C
		private global::NPOI.Util.MutableBigInteger hybridGCD(global::NPOI.Util.MutableBigInteger b)
		{
			global::NPOI.Util.MutableBigInteger mutableBigInteger = this;
			global::NPOI.Util.MutableBigInteger quotient = new global::NPOI.Util.MutableBigInteger();
			while (b.intLen != 0)
			{
				if (global::System.Math.Abs(mutableBigInteger.intLen - b.intLen) < 2)
				{
					return mutableBigInteger.binaryGCD(b);
				}
				global::NPOI.Util.MutableBigInteger mutableBigInteger2 = mutableBigInteger.divide(b, quotient);
				mutableBigInteger = b;
				b = mutableBigInteger2;
			}
			return mutableBigInteger;
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00030658 File Offset: 0x0002E858
		private global::NPOI.Util.MutableBigInteger binaryGCD(global::NPOI.Util.MutableBigInteger v)
		{
			global::NPOI.Util.MutableBigInteger mutableBigInteger = this;
			global::NPOI.Util.MutableBigInteger mutableBigInteger2 = new global::NPOI.Util.MutableBigInteger();
			int lowestSetBit = mutableBigInteger.getLowestSetBit();
			int lowestSetBit2 = v.getLowestSetBit();
			int num = (lowestSetBit < lowestSetBit2) ? lowestSetBit : lowestSetBit2;
			if (num != 0)
			{
				mutableBigInteger.rightShift(num);
				v.rightShift(num);
			}
			bool flag = num == lowestSetBit;
			global::NPOI.Util.MutableBigInteger mutableBigInteger3 = flag ? v : mutableBigInteger;
			int num2 = flag ? -1 : 1;
			int lowestSetBit3;
			while ((lowestSetBit3 = mutableBigInteger3.getLowestSetBit()) >= 0)
			{
				mutableBigInteger3.rightShift(lowestSetBit3);
				if (num2 > 0)
				{
					mutableBigInteger = mutableBigInteger3;
				}
				else
				{
					v = mutableBigInteger3;
				}
				if (mutableBigInteger.intLen < 2 && v.intLen < 2)
				{
					int num3 = mutableBigInteger._value[mutableBigInteger.offset];
					int b = v._value[v.offset];
					num3 = global::NPOI.Util.MutableBigInteger.binaryGcd(num3, b);
					mutableBigInteger2._value[0] = num3;
					mutableBigInteger2.intLen = 1;
					mutableBigInteger2.offset = 0;
					if (num > 0)
					{
						mutableBigInteger2.leftShift(num);
					}
					return mutableBigInteger2;
				}
				if ((num2 = mutableBigInteger.difference(v)) == 0)
				{
					break;
				}
				mutableBigInteger3 = ((num2 >= 0) ? mutableBigInteger : v);
			}
			if (num > 0)
			{
				mutableBigInteger.leftShift(num);
			}
			return mutableBigInteger;
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00030764 File Offset: 0x0002E964
		private static int binaryGcd(int a, int b)
		{
			if (b == 0)
			{
				return a;
			}
			if (a == 0)
			{
				return b;
			}
			int num = global::NPOI.Util.BigInteger.NumberOfTrailingZeros(a);
			int num2 = global::NPOI.Util.BigInteger.NumberOfTrailingZeros(b);
			a = global::NPOI.Util.Operator.UnsignedRightShift(a, num);
			b = global::NPOI.Util.Operator.UnsignedRightShift(b, num2);
			int num3 = (num < num2) ? num : num2;
			while (a != b)
			{
				if ((long)a + (long)((ulong)-2147483648) > (long)b + (long)((ulong)-2147483648))
				{
					a -= b;
					a = global::NPOI.Util.Operator.UnsignedRightShift(a, global::NPOI.Util.BigInteger.NumberOfTrailingZeros(a));
				}
				else
				{
					b -= a;
					b = global::NPOI.Util.Operator.UnsignedRightShift(b, global::NPOI.Util.BigInteger.NumberOfTrailingZeros(b));
				}
			}
			return a << num3;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x000307EC File Offset: 0x0002E9EC
		private global::NPOI.Util.MutableBigInteger mutableModInverse(global::NPOI.Util.MutableBigInteger p)
		{
			if (p.isOdd())
			{
				return this.modInverse(p);
			}
			if (this.isEven())
			{
				throw new global::System.ArithmeticException("BigInteger not invertible.");
			}
			int lowestSetBit = p.getLowestSetBit();
			global::NPOI.Util.MutableBigInteger mutableBigInteger = new global::NPOI.Util.MutableBigInteger(p);
			mutableBigInteger.rightShift(lowestSetBit);
			if (mutableBigInteger.isOne())
			{
				return this.modInverseMP2(lowestSetBit);
			}
			global::NPOI.Util.MutableBigInteger mutableBigInteger2 = this.modInverse(mutableBigInteger);
			global::NPOI.Util.MutableBigInteger mutableBigInteger3 = this.modInverseMP2(lowestSetBit);
			global::NPOI.Util.MutableBigInteger y = global::NPOI.Util.MutableBigInteger.modInverseBP2(mutableBigInteger, lowestSetBit);
			global::NPOI.Util.MutableBigInteger y2 = mutableBigInteger.modInverseMP2(lowestSetBit);
			global::NPOI.Util.MutableBigInteger mutableBigInteger4 = new global::NPOI.Util.MutableBigInteger();
			global::NPOI.Util.MutableBigInteger mutableBigInteger5 = new global::NPOI.Util.MutableBigInteger();
			global::NPOI.Util.MutableBigInteger mutableBigInteger6 = new global::NPOI.Util.MutableBigInteger();
			mutableBigInteger2.leftShift(lowestSetBit);
			mutableBigInteger2.multiply(y, mutableBigInteger6);
			mutableBigInteger3.multiply(mutableBigInteger, mutableBigInteger4);
			mutableBigInteger4.multiply(y2, mutableBigInteger5);
			mutableBigInteger6.add(mutableBigInteger5);
			return mutableBigInteger6.divide(p, mutableBigInteger4);
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x000308AC File Offset: 0x0002EAAC
		private global::NPOI.Util.MutableBigInteger modInverseMP2(int k)
		{
			if (this.isEven())
			{
				throw new global::System.ArithmeticException("Non-invertible. (GCD != 1)");
			}
			if (k > 64)
			{
				return this.euclidModInverse(k);
			}
			int num = global::NPOI.Util.MutableBigInteger.inverseMod32(this._value[this.offset + this.intLen - 1]);
			if (k < 33)
			{
				num = ((k == 32) ? num : (num & (1 << k) - 1));
				return new global::NPOI.Util.MutableBigInteger(num);
			}
			long num2 = (long)this._value[this.offset + this.intLen - 1] & (long)((ulong)-1);
			if (this.intLen > 1)
			{
				num2 |= (long)this._value[this.offset + this.intLen - 2] << 32;
			}
			long num3 = (long)num & (long)((ulong)-1);
			num3 *= 2L - num2 * num3;
			num3 = ((k == 64) ? num3 : (num3 & (1L << k) - 1L));
			global::NPOI.Util.MutableBigInteger mutableBigInteger = new global::NPOI.Util.MutableBigInteger(new int[2]);
			mutableBigInteger._value[0] = (int)global::NPOI.Util.Operator.UnsignedRightShift(num3, 32);
			mutableBigInteger._value[1] = (int)num3;
			mutableBigInteger.intLen = 2;
			mutableBigInteger.normalize();
			return mutableBigInteger;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x000309AC File Offset: 0x0002EBAC
		private static int inverseMod32(int val)
		{
			int num = val * (2 - val * val);
			num *= 2 - val * num;
			num *= 2 - val * num;
			return num * (2 - val * num);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000309DC File Offset: 0x0002EBDC
		private static global::NPOI.Util.MutableBigInteger modInverseBP2(global::NPOI.Util.MutableBigInteger mod, int k)
		{
			return global::NPOI.Util.MutableBigInteger.fixup(new global::NPOI.Util.MutableBigInteger(1), new global::NPOI.Util.MutableBigInteger(mod), k);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x000309F0 File Offset: 0x0002EBF0
		private global::NPOI.Util.MutableBigInteger modInverse(global::NPOI.Util.MutableBigInteger mod)
		{
			throw new global::System.NotImplementedException("This method uses SignedMutableBigInteger class.");
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000309FC File Offset: 0x0002EBFC
		private static global::NPOI.Util.MutableBigInteger fixup(global::NPOI.Util.MutableBigInteger c, global::NPOI.Util.MutableBigInteger p, int k)
		{
			global::NPOI.Util.MutableBigInteger mutableBigInteger = new global::NPOI.Util.MutableBigInteger();
			int num = -global::NPOI.Util.MutableBigInteger.inverseMod32(p._value[p.offset + p.intLen - 1]);
			int i = 0;
			int num2 = k >> 5;
			while (i < num2)
			{
				int y = num * c._value[c.offset + c.intLen - 1];
				p.mul(y, mutableBigInteger);
				c.add(mutableBigInteger);
				c.intLen--;
				i++;
			}
			int num3 = k & 31;
			if (num3 != 0)
			{
				int num4 = num * c._value[c.offset + c.intLen - 1];
				num4 &= (1 << num3) - 1;
				p.mul(num4, mutableBigInteger);
				c.add(mutableBigInteger);
				c.rightShift(num3);
			}
			while (c.compare(p) >= 0)
			{
				c.subtract(p);
			}
			return c;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00030AD4 File Offset: 0x0002ECD4
		private global::NPOI.Util.MutableBigInteger euclidModInverse(int k)
		{
			global::NPOI.Util.MutableBigInteger mutableBigInteger = new global::NPOI.Util.MutableBigInteger(1);
			mutableBigInteger.leftShift(k);
			global::NPOI.Util.MutableBigInteger mutableBigInteger2 = new global::NPOI.Util.MutableBigInteger(mutableBigInteger);
			global::NPOI.Util.MutableBigInteger mutableBigInteger3 = new global::NPOI.Util.MutableBigInteger(this);
			global::NPOI.Util.MutableBigInteger mutableBigInteger4 = new global::NPOI.Util.MutableBigInteger();
			mutableBigInteger = mutableBigInteger.divide(mutableBigInteger3, mutableBigInteger4);
			global::NPOI.Util.MutableBigInteger mutableBigInteger5 = new global::NPOI.Util.MutableBigInteger(mutableBigInteger4);
			global::NPOI.Util.MutableBigInteger mutableBigInteger6 = new global::NPOI.Util.MutableBigInteger(1);
			global::NPOI.Util.MutableBigInteger mutableBigInteger7 = new global::NPOI.Util.MutableBigInteger();
			while (!mutableBigInteger.isOne())
			{
				global::NPOI.Util.MutableBigInteger mutableBigInteger8 = mutableBigInteger3.divide(mutableBigInteger, mutableBigInteger4);
				if (mutableBigInteger8.intLen == 0)
				{
					throw new global::System.ArithmeticException("BigInteger not invertible.");
				}
				global::NPOI.Util.MutableBigInteger mutableBigInteger9 = mutableBigInteger8;
				mutableBigInteger3 = mutableBigInteger9;
				if (mutableBigInteger4.intLen == 1)
				{
					mutableBigInteger5.mul(mutableBigInteger4._value[mutableBigInteger4.offset], mutableBigInteger7);
				}
				else
				{
					mutableBigInteger4.multiply(mutableBigInteger5, mutableBigInteger7);
				}
				mutableBigInteger9 = mutableBigInteger4;
				mutableBigInteger4 = mutableBigInteger7;
				mutableBigInteger7 = mutableBigInteger9;
				mutableBigInteger6.add(mutableBigInteger4);
				if (mutableBigInteger3.isOne())
				{
					return mutableBigInteger6;
				}
				global::NPOI.Util.MutableBigInteger mutableBigInteger10 = mutableBigInteger.divide(mutableBigInteger3, mutableBigInteger4);
				if (mutableBigInteger10.intLen == 0)
				{
					throw new global::System.ArithmeticException("BigInteger not invertible.");
				}
				mutableBigInteger = mutableBigInteger10;
				if (mutableBigInteger4.intLen == 1)
				{
					mutableBigInteger6.mul(mutableBigInteger4._value[mutableBigInteger4.offset], mutableBigInteger7);
				}
				else
				{
					mutableBigInteger4.multiply(mutableBigInteger6, mutableBigInteger7);
				}
				mutableBigInteger9 = mutableBigInteger4;
				mutableBigInteger4 = mutableBigInteger7;
				mutableBigInteger7 = mutableBigInteger9;
				mutableBigInteger5.add(mutableBigInteger4);
			}
			mutableBigInteger2.subtract(mutableBigInteger5);
			return mutableBigInteger2;
		}

		// Token: 0x040006DC RID: 1756
		private int[] _value;

		// Token: 0x040006DD RID: 1757
		private int intLen;

		// Token: 0x040006DE RID: 1758
		private int offset;

		// Token: 0x040006DF RID: 1759
		private static readonly global::NPOI.Util.MutableBigInteger One = new global::NPOI.Util.MutableBigInteger(1);

		// Token: 0x040006E0 RID: 1760
		private const long LONG_MASK = 4294967295L;

		// Token: 0x040006E1 RID: 1761
		private const long INFLATED = -9223372036854775808L;
	}
}
