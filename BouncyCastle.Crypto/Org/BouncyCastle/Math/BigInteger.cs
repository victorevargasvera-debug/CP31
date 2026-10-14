using System;
using System.Collections;
using System.Globalization;
using System.Text;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math
{
	// Token: 0x020001EC RID: 492
	[global::System.Serializable]
	public class BigInteger
	{
		// Token: 0x06001206 RID: 4614 RVA: 0x0004F588 File Offset: 0x0004D788
		static BigInteger()
		{
			global::Org.BouncyCastle.Math.BigInteger.Zero = new global::Org.BouncyCastle.Math.BigInteger(0, global::Org.BouncyCastle.Math.BigInteger.ZeroMagnitude, false);
			global::Org.BouncyCastle.Math.BigInteger.Zero.nBits = 0;
			global::Org.BouncyCastle.Math.BigInteger.Zero.nBitLength = 0;
			global::Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS[0] = global::Org.BouncyCastle.Math.BigInteger.Zero;
			uint i = 1U;
			while ((ulong)i < (ulong)((long)global::Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS.Length))
			{
				global::Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS[(int)i] = global::Org.BouncyCastle.Math.BigInteger.CreateUValueOf((ulong)i);
				i += 1U;
			}
			global::Org.BouncyCastle.Math.BigInteger.One = global::Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS[1];
			global::Org.BouncyCastle.Math.BigInteger.Two = global::Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS[2];
			global::Org.BouncyCastle.Math.BigInteger.Three = global::Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS[3];
			global::Org.BouncyCastle.Math.BigInteger.Four = global::Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS[4];
			global::Org.BouncyCastle.Math.BigInteger.Ten = global::Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS[10];
			global::Org.BouncyCastle.Math.BigInteger.radix2 = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
			global::Org.BouncyCastle.Math.BigInteger.radix2E = global::Org.BouncyCastle.Math.BigInteger.radix2.Pow(1);
			global::Org.BouncyCastle.Math.BigInteger.radix8 = global::Org.BouncyCastle.Math.BigInteger.ValueOf(8L);
			global::Org.BouncyCastle.Math.BigInteger.radix8E = global::Org.BouncyCastle.Math.BigInteger.radix8.Pow(1);
			global::Org.BouncyCastle.Math.BigInteger.radix10 = global::Org.BouncyCastle.Math.BigInteger.ValueOf(10L);
			global::Org.BouncyCastle.Math.BigInteger.radix10E = global::Org.BouncyCastle.Math.BigInteger.radix10.Pow(19);
			global::Org.BouncyCastle.Math.BigInteger.radix16 = global::Org.BouncyCastle.Math.BigInteger.ValueOf(16L);
			global::Org.BouncyCastle.Math.BigInteger.radix16E = global::Org.BouncyCastle.Math.BigInteger.radix16.Pow(16);
			global::Org.BouncyCastle.Math.BigInteger.primeProducts = new int[global::Org.BouncyCastle.Math.BigInteger.primeLists.Length];
			for (int j = 0; j < global::Org.BouncyCastle.Math.BigInteger.primeLists.Length; j++)
			{
				int[] primeList = global::Org.BouncyCastle.Math.BigInteger.primeLists[j];
				int product = primeList[0];
				for (int k = 1; k < primeList.Length; k++)
				{
					product *= primeList[k];
				}
				global::Org.BouncyCastle.Math.BigInteger.primeProducts[j] = product;
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0004FC8A File Offset: 0x0004DE8A
		private static int GetByteLength(int nBits)
		{
			return (nBits + 8 - 1) / 8;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0004FC93 File Offset: 0x0004DE93
		public static global::Org.BouncyCastle.Math.BigInteger Arbitrary(int sizeInBits)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(sizeInBits, global::Org.BouncyCastle.Math.BigInteger.RandomSource);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0004FCA0 File Offset: 0x0004DEA0
		private BigInteger(int signum, int[] mag, bool checkMag)
		{
			if (!checkMag)
			{
				this.sign = signum;
				this.magnitude = mag;
				return;
			}
			int i = 0;
			while (i < mag.Length && mag[i] == 0)
			{
				i++;
			}
			if (i == mag.Length)
			{
				this.sign = 0;
				this.magnitude = global::Org.BouncyCastle.Math.BigInteger.ZeroMagnitude;
				return;
			}
			this.sign = signum;
			if (i == 0)
			{
				this.magnitude = mag;
				return;
			}
			this.magnitude = new int[mag.Length - i];
			global::System.Array.Copy(mag, i, this.magnitude, 0, this.magnitude.Length);
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0004FD37 File Offset: 0x0004DF37
		public BigInteger(string value) : this(value, 10)
		{
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0004FD44 File Offset: 0x0004DF44
		public BigInteger(string str, int radix)
		{
			if (str.Length == 0)
			{
				throw new global::System.FormatException("Zero length BigInteger");
			}
			global::System.Globalization.NumberStyles style;
			int chunk;
			if (radix <= 8)
			{
				if (radix == 2)
				{
					style = global::System.Globalization.NumberStyles.Integer;
					chunk = 1;
					global::Org.BouncyCastle.Math.BigInteger r = global::Org.BouncyCastle.Math.BigInteger.radix2;
					global::Org.BouncyCastle.Math.BigInteger rE = global::Org.BouncyCastle.Math.BigInteger.radix2E;
					goto IL_9A;
				}
				if (radix == 8)
				{
					style = global::System.Globalization.NumberStyles.Integer;
					chunk = 1;
					global::Org.BouncyCastle.Math.BigInteger r = global::Org.BouncyCastle.Math.BigInteger.radix8;
					global::Org.BouncyCastle.Math.BigInteger rE = global::Org.BouncyCastle.Math.BigInteger.radix8E;
					goto IL_9A;
				}
			}
			else
			{
				if (radix == 10)
				{
					style = global::System.Globalization.NumberStyles.Integer;
					chunk = 19;
					global::Org.BouncyCastle.Math.BigInteger r = global::Org.BouncyCastle.Math.BigInteger.radix10;
					global::Org.BouncyCastle.Math.BigInteger rE = global::Org.BouncyCastle.Math.BigInteger.radix10E;
					goto IL_9A;
				}
				if (radix == 16)
				{
					style = global::System.Globalization.NumberStyles.AllowHexSpecifier;
					chunk = 16;
					global::Org.BouncyCastle.Math.BigInteger r = global::Org.BouncyCastle.Math.BigInteger.radix16;
					global::Org.BouncyCastle.Math.BigInteger rE = global::Org.BouncyCastle.Math.BigInteger.radix16E;
					goto IL_9A;
				}
			}
			throw new global::System.FormatException("Only bases 2, 8, 10, or 16 allowed");
			IL_9A:
			int index = 0;
			this.sign = 1;
			if (str[0] == '-')
			{
				if (str.Length == 1)
				{
					throw new global::System.FormatException("Zero length BigInteger");
				}
				this.sign = -1;
				index = 1;
			}
			while (index < str.Length && int.Parse(str[index].ToString(), style) == 0)
			{
				index++;
			}
			if (index >= str.Length)
			{
				this.sign = 0;
				this.magnitude = global::Org.BouncyCastle.Math.BigInteger.ZeroMagnitude;
				return;
			}
			global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Math.BigInteger.Zero;
			int next = index + chunk;
			if (next <= str.Length)
			{
				string s;
				for (;;)
				{
					s = str.Substring(index, chunk);
					ulong i = ulong.Parse(s, style);
					global::Org.BouncyCastle.Math.BigInteger bi = global::Org.BouncyCastle.Math.BigInteger.CreateUValueOf(i);
					if (radix != 2)
					{
						if (radix != 8)
						{
							if (radix != 16)
							{
								global::Org.BouncyCastle.Math.BigInteger rE;
								b = b.Multiply(rE);
							}
							else
							{
								b = b.ShiftLeft(64);
							}
						}
						else
						{
							if (i >= 8UL)
							{
								goto Block_15;
							}
							b = b.ShiftLeft(3);
						}
					}
					else
					{
						if (i >= 2UL)
						{
							break;
						}
						b = b.ShiftLeft(1);
					}
					b = b.Add(bi);
					index = next;
					next += chunk;
					if (next > str.Length)
					{
						goto IL_1DD;
					}
				}
				throw new global::System.FormatException("Bad character in radix 2 string: " + s);
				Block_15:
				throw new global::System.FormatException("Bad character in radix 8 string: " + s);
			}
			IL_1DD:
			if (index < str.Length)
			{
				string s2 = str.Substring(index);
				global::Org.BouncyCastle.Math.BigInteger bi2 = global::Org.BouncyCastle.Math.BigInteger.CreateUValueOf(ulong.Parse(s2, style));
				if (b.sign > 0)
				{
					if (radix != 2 && radix != 8)
					{
						if (radix == 16)
						{
							b = b.ShiftLeft(s2.Length << 2);
						}
						else
						{
							global::Org.BouncyCastle.Math.BigInteger r;
							b = b.Multiply(r.Pow(s2.Length));
						}
					}
					b = b.Add(bi2);
				}
				else
				{
					b = bi2;
				}
			}
			this.magnitude = b.magnitude;
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0004FFB0 File Offset: 0x0004E1B0
		public BigInteger(byte[] bytes) : this(bytes, 0, bytes.Length)
		{
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0004FFC0 File Offset: 0x0004E1C0
		public BigInteger(byte[] bytes, int offset, int length)
		{
			if (length == 0)
			{
				throw new global::System.FormatException("Zero length BigInteger");
			}
			if ((sbyte)bytes[offset] >= 0)
			{
				this.magnitude = global::Org.BouncyCastle.Math.BigInteger.MakeMagnitude(bytes, offset, length);
				this.sign = ((this.magnitude.Length != 0) ? 1 : 0);
				return;
			}
			this.sign = -1;
			int end = offset + length;
			int iBval = offset;
			while (iBval < end && (sbyte)bytes[iBval] == -1)
			{
				iBval++;
			}
			if (iBval >= end)
			{
				this.magnitude = global::Org.BouncyCastle.Math.BigInteger.One.magnitude;
				return;
			}
			int numBytes = end - iBval;
			byte[] inverse = new byte[numBytes];
			int index = 0;
			while (index < numBytes)
			{
				inverse[index++] = ~bytes[iBval++];
			}
			while (inverse[--index] == 255)
			{
				inverse[index] = 0;
			}
			byte[] array = inverse;
			int num = index;
			array[num] += 1;
			this.magnitude = global::Org.BouncyCastle.Math.BigInteger.MakeMagnitude(inverse, 0, inverse.Length);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x000500AC File Offset: 0x0004E2AC
		private static int[] MakeMagnitude(byte[] bytes, int offset, int length)
		{
			int end = offset + length;
			int firstSignificant = offset;
			while (firstSignificant < end && bytes[firstSignificant] == 0)
			{
				firstSignificant++;
			}
			if (firstSignificant >= end)
			{
				return global::Org.BouncyCastle.Math.BigInteger.ZeroMagnitude;
			}
			int nInts = (end - firstSignificant + 3) / 4;
			int bCount = (end - firstSignificant) % 4;
			if (bCount == 0)
			{
				bCount = 4;
			}
			if (nInts < 1)
			{
				return global::Org.BouncyCastle.Math.BigInteger.ZeroMagnitude;
			}
			int[] mag = new int[nInts];
			int v = 0;
			int magnitudeIndex = 0;
			for (int i = firstSignificant; i < end; i++)
			{
				v <<= 8;
				v |= (int)(bytes[i] & byte.MaxValue);
				bCount--;
				if (bCount <= 0)
				{
					mag[magnitudeIndex] = v;
					magnitudeIndex++;
					bCount = 4;
					v = 0;
				}
			}
			if (magnitudeIndex < mag.Length)
			{
				mag[magnitudeIndex] = v;
			}
			return mag;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00050153 File Offset: 0x0004E353
		public BigInteger(int sign, byte[] bytes) : this(sign, bytes, 0, bytes.Length)
		{
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00050164 File Offset: 0x0004E364
		public BigInteger(int sign, byte[] bytes, int offset, int length)
		{
			if (sign < -1 || sign > 1)
			{
				throw new global::System.FormatException("Invalid sign value");
			}
			if (sign == 0)
			{
				this.sign = 0;
				this.magnitude = global::Org.BouncyCastle.Math.BigInteger.ZeroMagnitude;
				return;
			}
			this.magnitude = global::Org.BouncyCastle.Math.BigInteger.MakeMagnitude(bytes, offset, length);
			this.sign = ((this.magnitude.Length < 1) ? 0 : sign);
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x000501D4 File Offset: 0x0004E3D4
		public BigInteger(int sizeInBits, global::System.Random random)
		{
			if (sizeInBits < 0)
			{
				throw new global::System.ArgumentException("sizeInBits must be non-negative");
			}
			this.nBits = -1;
			this.nBitLength = -1;
			if (sizeInBits == 0)
			{
				this.sign = 0;
				this.magnitude = global::Org.BouncyCastle.Math.BigInteger.ZeroMagnitude;
				return;
			}
			int nBytes = global::Org.BouncyCastle.Math.BigInteger.GetByteLength(sizeInBits);
			byte[] b = new byte[nBytes];
			random.NextBytes(b);
			int xBits = 8 * nBytes - sizeInBits;
			byte[] array = b;
			int num = 0;
			array[num] &= (byte)(255U >> xBits);
			this.magnitude = global::Org.BouncyCastle.Math.BigInteger.MakeMagnitude(b, 0, b.Length);
			this.sign = ((this.magnitude.Length < 1) ? 0 : 1);
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00050280 File Offset: 0x0004E480
		public BigInteger(int bitLength, int certainty, global::System.Random random)
		{
			if (bitLength < 2)
			{
				throw new global::System.ArithmeticException("bitLength < 2");
			}
			this.sign = 1;
			this.nBitLength = bitLength;
			if (bitLength == 2)
			{
				this.magnitude = ((random.Next(2) == 0) ? global::Org.BouncyCastle.Math.BigInteger.Two.magnitude : global::Org.BouncyCastle.Math.BigInteger.Three.magnitude);
				return;
			}
			int nBytes = global::Org.BouncyCastle.Math.BigInteger.GetByteLength(bitLength);
			byte[] b = new byte[nBytes];
			int xBits = 8 * nBytes - bitLength;
			byte mask = (byte)(255U >> xBits);
			byte lead = (byte)(1 << 7 - xBits);
			for (;;)
			{
				random.NextBytes(b);
				byte[] array = b;
				int num = 0;
				array[num] &= mask;
				byte[] array2 = b;
				int num2 = 0;
				array2[num2] |= lead;
				byte[] array3 = b;
				int num3 = nBytes - 1;
				array3[num3] |= 1;
				this.magnitude = global::Org.BouncyCastle.Math.BigInteger.MakeMagnitude(b, 0, b.Length);
				this.nBits = -1;
				this.mQuote = 0;
				if (certainty < 1 || this.CheckProbablePrime(certainty, random, true))
				{
					return;
				}
				for (int i = 1; i < this.magnitude.Length - 1; i++)
				{
					this.magnitude[i] ^= random.Next();
					if (this.CheckProbablePrime(certainty, random, true))
					{
						return;
					}
				}
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x000503B2 File Offset: 0x0004E5B2
		public global::Org.BouncyCastle.Math.BigInteger Abs()
		{
			if (this.sign < 0)
			{
				return this.Negate();
			}
			return this;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x000503C8 File Offset: 0x0004E5C8
		private static int[] AddMagnitudes(int[] a, int[] b)
		{
			int tI = a.Length - 1;
			int vI = b.Length - 1;
			long i = 0L;
			while (vI >= 0)
			{
				i += (long)((ulong)a[tI] + (ulong)b[vI--]);
				a[tI--] = (int)i;
				i = (long)((ulong)i >> 32);
			}
			if (i != 0L)
			{
				while (tI >= 0)
				{
					int num = tI--;
					int num2 = a[num] + 1;
					a[num] = num2;
					if (num2 != 0)
					{
						break;
					}
				}
			}
			return a;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00050428 File Offset: 0x0004E628
		public global::Org.BouncyCastle.Math.BigInteger Add(global::Org.BouncyCastle.Math.BigInteger value)
		{
			if (this.sign == 0)
			{
				return value;
			}
			if (this.sign == value.sign)
			{
				return this.AddToMagnitude(value.magnitude);
			}
			if (value.sign == 0)
			{
				return this;
			}
			if (value.sign < 0)
			{
				return this.Subtract(value.Negate());
			}
			return value.Subtract(this.Negate());
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00050488 File Offset: 0x0004E688
		private global::Org.BouncyCastle.Math.BigInteger AddToMagnitude(int[] magToAdd)
		{
			int[] big;
			int[] small;
			if (this.magnitude.Length < magToAdd.Length)
			{
				big = magToAdd;
				small = this.magnitude;
			}
			else
			{
				big = this.magnitude;
				small = magToAdd;
			}
			uint limit = uint.MaxValue;
			if (big.Length == small.Length)
			{
				limit -= (uint)small[0];
			}
			bool possibleOverflow = big[0] >= (int)limit;
			int[] bigCopy;
			if (possibleOverflow)
			{
				bigCopy = new int[big.Length + 1];
				big.CopyTo(bigCopy, 1);
			}
			else
			{
				bigCopy = (int[])big.Clone();
			}
			bigCopy = global::Org.BouncyCastle.Math.BigInteger.AddMagnitudes(bigCopy, small);
			return new global::Org.BouncyCastle.Math.BigInteger(this.sign, bigCopy, possibleOverflow);
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00050510 File Offset: 0x0004E710
		public global::Org.BouncyCastle.Math.BigInteger And(global::Org.BouncyCastle.Math.BigInteger value)
		{
			if (this.sign == 0 || value.sign == 0)
			{
				return global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			int[] aMag = (this.sign > 0) ? this.magnitude : this.Add(global::Org.BouncyCastle.Math.BigInteger.One).magnitude;
			int[] bMag = (value.sign > 0) ? value.magnitude : value.Add(global::Org.BouncyCastle.Math.BigInteger.One).magnitude;
			bool resultNeg = this.sign < 0 && value.sign < 0;
			int[] resultMag = new int[global::System.Math.Max(aMag.Length, bMag.Length)];
			int aStart = resultMag.Length - aMag.Length;
			int bStart = resultMag.Length - bMag.Length;
			for (int i = 0; i < resultMag.Length; i++)
			{
				int aWord = (i >= aStart) ? aMag[i - aStart] : 0;
				int bWord = (i >= bStart) ? bMag[i - bStart] : 0;
				if (this.sign < 0)
				{
					aWord = ~aWord;
				}
				if (value.sign < 0)
				{
					bWord = ~bWord;
				}
				resultMag[i] = (aWord & bWord);
				if (resultNeg)
				{
					resultMag[i] = ~resultMag[i];
				}
			}
			global::Org.BouncyCastle.Math.BigInteger result = new global::Org.BouncyCastle.Math.BigInteger(1, resultMag, true);
			if (resultNeg)
			{
				result = result.Not();
			}
			return result;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0005062F File Offset: 0x0004E82F
		public global::Org.BouncyCastle.Math.BigInteger AndNot(global::Org.BouncyCastle.Math.BigInteger val)
		{
			return this.And(val.Not());
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x00050640 File Offset: 0x0004E840
		public int BitCount
		{
			get
			{
				if (this.nBits == -1)
				{
					if (this.sign < 0)
					{
						this.nBits = this.Not().BitCount;
					}
					else
					{
						int sum = 0;
						for (int i = 0; i < this.magnitude.Length; i++)
						{
							sum += global::Org.BouncyCastle.Math.BigInteger.BitCnt(this.magnitude[i]);
						}
						this.nBits = sum;
					}
				}
				return this.nBits;
			}
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x000506A4 File Offset: 0x0004E8A4
		public static int BitCnt(int i)
		{
			uint u = (uint)(i - (int)((uint)i >> 1 & 1431655765U));
			u = (u & 858993459U) + (u >> 2 & 858993459U);
			u = (u + (u >> 4) & 252645135U);
			u += u >> 8;
			u += u >> 16;
			return (int)(u & 63U);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000506F0 File Offset: 0x0004E8F0
		private static int CalcBitLength(int sign, int indx, int[] mag)
		{
			while (indx < mag.Length)
			{
				if (mag[indx] != 0)
				{
					int bitLength = 32 * (mag.Length - indx - 1);
					int firstMag = mag[indx];
					bitLength += global::Org.BouncyCastle.Math.BigInteger.BitLen(firstMag);
					if (sign < 0 && (firstMag & -firstMag) == firstMag)
					{
						while (++indx < mag.Length)
						{
							if (mag[indx] != 0)
							{
								return bitLength;
							}
						}
						bitLength--;
					}
					return bitLength;
				}
				indx++;
			}
			return 0;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x0005074B File Offset: 0x0004E94B
		public int BitLength
		{
			get
			{
				if (this.nBitLength == -1)
				{
					this.nBitLength = ((this.sign == 0) ? 0 : global::Org.BouncyCastle.Math.BigInteger.CalcBitLength(this.sign, 0, this.magnitude));
				}
				return this.nBitLength;
			}
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00050780 File Offset: 0x0004E980
		internal static int BitLen(int w)
		{
			uint t = (uint)w >> 24;
			if (t != 0U)
			{
				return (int)(24 + global::Org.BouncyCastle.Math.BigInteger.BitLengthTable[(int)t]);
			}
			t = (uint)w >> 16;
			if (t != 0U)
			{
				return (int)(16 + global::Org.BouncyCastle.Math.BigInteger.BitLengthTable[(int)t]);
			}
			t = (uint)w >> 8;
			if (t != 0U)
			{
				return (int)(8 + global::Org.BouncyCastle.Math.BigInteger.BitLengthTable[(int)t]);
			}
			return (int)global::Org.BouncyCastle.Math.BigInteger.BitLengthTable[w];
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x000507CD File Offset: 0x0004E9CD
		private bool QuickPow2Check()
		{
			return this.sign > 0 && this.nBits == 1;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x000507E3 File Offset: 0x0004E9E3
		public int CompareTo(object obj)
		{
			return this.CompareTo((global::Org.BouncyCastle.Math.BigInteger)obj);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000507F1 File Offset: 0x0004E9F1
		private static int CompareTo(int xIndx, int[] x, int yIndx, int[] y)
		{
			while (xIndx != x.Length)
			{
				if (x[xIndx] != 0)
				{
					break;
				}
				xIndx++;
			}
			while (yIndx != y.Length && y[yIndx] == 0)
			{
				yIndx++;
			}
			return global::Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xIndx, x, yIndx, y);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00050820 File Offset: 0x0004EA20
		private static int CompareNoLeadingZeroes(int xIndx, int[] x, int yIndx, int[] y)
		{
			int diff = x.Length - y.Length - (xIndx - yIndx);
			if (diff == 0)
			{
				while (xIndx < x.Length)
				{
					uint v = (uint)x[xIndx++];
					uint v2 = (uint)y[yIndx++];
					if (v != v2)
					{
						if (v >= v2)
						{
							return 1;
						}
						return -1;
					}
				}
				return 0;
			}
			if (diff >= 0)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x0005086C File Offset: 0x0004EA6C
		public int CompareTo(global::Org.BouncyCastle.Math.BigInteger value)
		{
			if (this.sign < value.sign)
			{
				return -1;
			}
			if (this.sign > value.sign)
			{
				return 1;
			}
			if (this.sign != 0)
			{
				return this.sign * global::Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(0, this.magnitude, 0, value.magnitude);
			}
			return 0;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x000508C0 File Offset: 0x0004EAC0
		private int[] Divide(int[] x, int[] y)
		{
			int xStart = 0;
			while (xStart < x.Length && x[xStart] == 0)
			{
				xStart++;
			}
			int yStart = 0;
			while (yStart < y.Length && y[yStart] == 0)
			{
				yStart++;
			}
			int xyCmp = global::Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xStart, x, yStart, y);
			int[] count;
			if (xyCmp > 0)
			{
				int yBitLength = global::Org.BouncyCastle.Math.BigInteger.CalcBitLength(1, yStart, y);
				int xBitLength = global::Org.BouncyCastle.Math.BigInteger.CalcBitLength(1, xStart, x);
				int shift = xBitLength - yBitLength;
				int iCountStart = 0;
				int cStart = 0;
				int cBitLength = yBitLength;
				int[] iCount;
				int[] c;
				if (shift > 0)
				{
					iCount = new int[(shift >> 5) + 1];
					iCount[0] = 1 << shift % 32;
					c = global::Org.BouncyCastle.Math.BigInteger.ShiftLeft(y, shift);
					cBitLength += shift;
				}
				else
				{
					iCount = new int[]
					{
						1
					};
					int len = y.Length - yStart;
					c = new int[len];
					global::System.Array.Copy(y, yStart, c, 0, len);
				}
				count = new int[iCount.Length];
				for (;;)
				{
					if (cBitLength < xBitLength || global::Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xStart, x, cStart, c) >= 0)
					{
						global::Org.BouncyCastle.Math.BigInteger.Subtract(xStart, x, cStart, c);
						global::Org.BouncyCastle.Math.BigInteger.AddMagnitudes(count, iCount);
						while (x[xStart] == 0)
						{
							if (++xStart == x.Length)
							{
								return count;
							}
						}
						xBitLength = 32 * (x.Length - xStart - 1) + global::Org.BouncyCastle.Math.BigInteger.BitLen(x[xStart]);
						if (xBitLength <= yBitLength)
						{
							if (xBitLength < yBitLength)
							{
								return count;
							}
							xyCmp = global::Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xStart, x, yStart, y);
							if (xyCmp <= 0)
							{
								goto IL_1B9;
							}
						}
					}
					shift = cBitLength - xBitLength;
					if (shift == 1)
					{
						uint num = (uint)c[cStart] >> 1;
						uint firstX = (uint)x[xStart];
						if (num > firstX)
						{
							shift++;
						}
					}
					if (shift < 2)
					{
						global::Org.BouncyCastle.Math.BigInteger.ShiftRightOneInPlace(cStart, c);
						cBitLength--;
						global::Org.BouncyCastle.Math.BigInteger.ShiftRightOneInPlace(iCountStart, iCount);
					}
					else
					{
						global::Org.BouncyCastle.Math.BigInteger.ShiftRightInPlace(cStart, c, shift);
						cBitLength -= shift;
						global::Org.BouncyCastle.Math.BigInteger.ShiftRightInPlace(iCountStart, iCount, shift);
					}
					while (c[cStart] == 0)
					{
						cStart++;
					}
					while (iCount[iCountStart] == 0)
					{
						iCountStart++;
					}
				}
				return count;
			}
			count = new int[1];
			IL_1B9:
			if (xyCmp == 0)
			{
				global::Org.BouncyCastle.Math.BigInteger.AddMagnitudes(count, global::Org.BouncyCastle.Math.BigInteger.One.magnitude);
				global::System.Array.Clear(x, xStart, x.Length - xStart);
			}
			return count;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00050AA8 File Offset: 0x0004ECA8
		public global::Org.BouncyCastle.Math.BigInteger Divide(global::Org.BouncyCastle.Math.BigInteger val)
		{
			if (val.sign == 0)
			{
				throw new global::System.ArithmeticException("Division by zero error");
			}
			if (this.sign == 0)
			{
				return global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			if (!val.QuickPow2Check())
			{
				int[] mag = (int[])this.magnitude.Clone();
				return new global::Org.BouncyCastle.Math.BigInteger(this.sign * val.sign, this.Divide(mag, val.magnitude), true);
			}
			global::Org.BouncyCastle.Math.BigInteger result = this.Abs().ShiftRight(val.Abs().BitLength - 1);
			if (val.sign != this.sign)
			{
				return result.Negate();
			}
			return result;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00050B40 File Offset: 0x0004ED40
		public global::Org.BouncyCastle.Math.BigInteger[] DivideAndRemainder(global::Org.BouncyCastle.Math.BigInteger val)
		{
			if (val.sign == 0)
			{
				throw new global::System.ArithmeticException("Division by zero error");
			}
			global::Org.BouncyCastle.Math.BigInteger[] biggies = new global::Org.BouncyCastle.Math.BigInteger[2];
			if (this.sign == 0)
			{
				biggies[0] = global::Org.BouncyCastle.Math.BigInteger.Zero;
				biggies[1] = global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			else if (val.QuickPow2Check())
			{
				int e = val.Abs().BitLength - 1;
				global::Org.BouncyCastle.Math.BigInteger quotient = this.Abs().ShiftRight(e);
				int[] remainder = this.LastNBits(e);
				biggies[0] = ((val.sign == this.sign) ? quotient : quotient.Negate());
				biggies[1] = new global::Org.BouncyCastle.Math.BigInteger(this.sign, remainder, true);
			}
			else
			{
				int[] remainder2 = (int[])this.magnitude.Clone();
				int[] quotient2 = this.Divide(remainder2, val.magnitude);
				biggies[0] = new global::Org.BouncyCastle.Math.BigInteger(this.sign * val.sign, quotient2, true);
				biggies[1] = new global::Org.BouncyCastle.Math.BigInteger(this.sign, remainder2, true);
			}
			return biggies;
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00050C28 File Offset: 0x0004EE28
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Math.BigInteger biggie = obj as global::Org.BouncyCastle.Math.BigInteger;
			return biggie != null && this.sign == biggie.sign && this.IsEqualMagnitude(biggie);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00050C60 File Offset: 0x0004EE60
		private bool IsEqualMagnitude(global::Org.BouncyCastle.Math.BigInteger x)
		{
			int[] array = x.magnitude;
			if (this.magnitude.Length != x.magnitude.Length)
			{
				return false;
			}
			for (int i = 0; i < this.magnitude.Length; i++)
			{
				if (this.magnitude[i] != x.magnitude[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00050CB0 File Offset: 0x0004EEB0
		public global::Org.BouncyCastle.Math.BigInteger Gcd(global::Org.BouncyCastle.Math.BigInteger value)
		{
			if (value.sign == 0)
			{
				return this.Abs();
			}
			if (this.sign == 0)
			{
				return value.Abs();
			}
			global::Org.BouncyCastle.Math.BigInteger u = this;
			global::Org.BouncyCastle.Math.BigInteger v = value;
			while (v.sign != 0)
			{
				global::Org.BouncyCastle.Math.BigInteger bigInteger = u.Mod(v);
				u = v;
				v = bigInteger;
			}
			return u;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00050CF4 File Offset: 0x0004EEF4
		public override int GetHashCode()
		{
			int hc = this.magnitude.Length;
			if (this.magnitude.Length != 0)
			{
				hc ^= this.magnitude[0];
				if (this.magnitude.Length > 1)
				{
					hc ^= this.magnitude[this.magnitude.Length - 1];
				}
			}
			if (this.sign >= 0)
			{
				return hc;
			}
			return ~hc;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00050D4C File Offset: 0x0004EF4C
		private global::Org.BouncyCastle.Math.BigInteger Inc()
		{
			if (this.sign == 0)
			{
				return global::Org.BouncyCastle.Math.BigInteger.One;
			}
			if (this.sign < 0)
			{
				return new global::Org.BouncyCastle.Math.BigInteger(-1, global::Org.BouncyCastle.Math.BigInteger.doSubBigLil(this.magnitude, global::Org.BouncyCastle.Math.BigInteger.One.magnitude), true);
			}
			return this.AddToMagnitude(global::Org.BouncyCastle.Math.BigInteger.One.magnitude);
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x00050DA0 File Offset: 0x0004EFA0
		public int IntValue
		{
			get
			{
				if (this.sign == 0)
				{
					return 0;
				}
				int i = this.magnitude.Length;
				int v = this.magnitude[i - 1];
				if (this.sign >= 0)
				{
					return v;
				}
				return -v;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00050DD8 File Offset: 0x0004EFD8
		public int IntValueExact
		{
			get
			{
				if (this.BitLength > 31)
				{
					throw new global::System.ArithmeticException("BigInteger out of int range");
				}
				return this.IntValue;
			}
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00050DF5 File Offset: 0x0004EFF5
		public bool IsProbablePrime(int certainty)
		{
			return this.IsProbablePrime(certainty, false);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00050E00 File Offset: 0x0004F000
		internal bool IsProbablePrime(int certainty, bool randomlySelected)
		{
			if (certainty <= 0)
			{
				return true;
			}
			global::Org.BouncyCastle.Math.BigInteger i = this.Abs();
			if (!i.TestBit(0))
			{
				return i.Equals(global::Org.BouncyCastle.Math.BigInteger.Two);
			}
			return !i.Equals(global::Org.BouncyCastle.Math.BigInteger.One) && i.CheckProbablePrime(certainty, global::Org.BouncyCastle.Math.BigInteger.RandomSource, randomlySelected);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00050E4C File Offset: 0x0004F04C
		private bool CheckProbablePrime(int certainty, global::System.Random random, bool randomlySelected)
		{
			int numLists = global::System.Math.Min(this.BitLength - 1, global::Org.BouncyCastle.Math.BigInteger.primeLists.Length);
			for (int i = 0; i < numLists; i++)
			{
				int test = this.Remainder(global::Org.BouncyCastle.Math.BigInteger.primeProducts[i]);
				foreach (int prime in global::Org.BouncyCastle.Math.BigInteger.primeLists[i])
				{
					if (test % prime == 0)
					{
						return this.BitLength < 16 && this.IntValue == prime;
					}
				}
			}
			return this.RabinMillerTest(certainty, random, randomlySelected);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00050ECE File Offset: 0x0004F0CE
		public bool RabinMillerTest(int certainty, global::System.Random random)
		{
			return this.RabinMillerTest(certainty, random, false);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00050EDC File Offset: 0x0004F0DC
		internal bool RabinMillerTest(int certainty, global::System.Random random, bool randomlySelected)
		{
			int bits = this.BitLength;
			int iterations = (certainty - 1) / 2 + 1;
			if (randomlySelected)
			{
				int itersFor100Cert = (bits >= 1024) ? 4 : ((bits >= 512) ? 8 : ((bits >= 256) ? 16 : 50));
				if (certainty < 100)
				{
					iterations = global::System.Math.Min(itersFor100Cert, iterations);
				}
				else
				{
					iterations -= 50;
					iterations += itersFor100Cert;
				}
			}
			int s = this.GetLowestSetBitMaskFirst(-2);
			global::Org.BouncyCastle.Math.BigInteger r = this.ShiftRight(s);
			global::Org.BouncyCastle.Math.BigInteger montRadix = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(32 * this.magnitude.Length).Remainder(this);
			global::Org.BouncyCastle.Math.BigInteger minusMontRadix = this.Subtract(montRadix);
			for (;;)
			{
				global::Org.BouncyCastle.Math.BigInteger a = new global::Org.BouncyCastle.Math.BigInteger(this.BitLength, random);
				if (a.sign != 0 && a.CompareTo(this) < 0 && !a.IsEqualMagnitude(montRadix) && !a.IsEqualMagnitude(minusMontRadix))
				{
					global::Org.BouncyCastle.Math.BigInteger y = global::Org.BouncyCastle.Math.BigInteger.ModPowMonty(a, r, this, false);
					if (!y.Equals(montRadix))
					{
						int i = 0;
						while (!y.Equals(minusMontRadix))
						{
							if (++i == s)
							{
								return false;
							}
							y = global::Org.BouncyCastle.Math.BigInteger.ModPowMonty(y, global::Org.BouncyCastle.Math.BigInteger.Two, this, false);
							if (y.Equals(montRadix))
							{
								return false;
							}
						}
					}
					if (--iterations <= 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x0005100C File Offset: 0x0004F20C
		public long LongValue
		{
			get
			{
				if (this.sign == 0)
				{
					return 0L;
				}
				int i = this.magnitude.Length;
				long v = (long)this.magnitude[i - 1] & (long)((ulong)-1);
				if (i > 1)
				{
					v |= ((long)this.magnitude[i - 2] & (long)((ulong)-1)) << 32;
				}
				if (this.sign >= 0)
				{
					return v;
				}
				return -v;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00051061 File Offset: 0x0004F261
		public long LongValueExact
		{
			get
			{
				if (this.BitLength > 63)
				{
					throw new global::System.ArithmeticException("BigInteger out of long range");
				}
				return this.LongValue;
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0005107E File Offset: 0x0004F27E
		public global::Org.BouncyCastle.Math.BigInteger Max(global::Org.BouncyCastle.Math.BigInteger value)
		{
			if (this.CompareTo(value) <= 0)
			{
				return value;
			}
			return this;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0005108D File Offset: 0x0004F28D
		public global::Org.BouncyCastle.Math.BigInteger Min(global::Org.BouncyCastle.Math.BigInteger value)
		{
			if (this.CompareTo(value) >= 0)
			{
				return value;
			}
			return this;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0005109C File Offset: 0x0004F29C
		public global::Org.BouncyCastle.Math.BigInteger Mod(global::Org.BouncyCastle.Math.BigInteger m)
		{
			if (m.sign < 1)
			{
				throw new global::System.ArithmeticException("Modulus must be positive");
			}
			global::Org.BouncyCastle.Math.BigInteger biggie = this.Remainder(m);
			if (biggie.sign < 0)
			{
				return biggie.Add(m);
			}
			return biggie;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000510D8 File Offset: 0x0004F2D8
		public global::Org.BouncyCastle.Math.BigInteger ModInverse(global::Org.BouncyCastle.Math.BigInteger m)
		{
			if (m.sign < 1)
			{
				throw new global::System.ArithmeticException("Modulus must be positive");
			}
			if (m.QuickPow2Check())
			{
				return this.ModInversePow2(m);
			}
			global::Org.BouncyCastle.Math.BigInteger x;
			if (!global::Org.BouncyCastle.Math.BigInteger.ExtEuclid(this.Remainder(m), m, out x).Equals(global::Org.BouncyCastle.Math.BigInteger.One))
			{
				throw new global::System.ArithmeticException("Numbers not relatively prime.");
			}
			if (x.sign < 0)
			{
				x = x.Add(m);
			}
			return x;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00051144 File Offset: 0x0004F344
		private global::Org.BouncyCastle.Math.BigInteger ModInversePow2(global::Org.BouncyCastle.Math.BigInteger m)
		{
			if (!this.TestBit(0))
			{
				throw new global::System.ArithmeticException("Numbers not relatively prime.");
			}
			int pow = m.BitLength - 1;
			long inv64 = global::Org.BouncyCastle.Math.BigInteger.ModInverse64(this.LongValue);
			if (pow < 64)
			{
				inv64 &= (1L << pow) - 1L;
			}
			global::Org.BouncyCastle.Math.BigInteger x = global::Org.BouncyCastle.Math.BigInteger.ValueOf(inv64);
			if (pow > 64)
			{
				global::Org.BouncyCastle.Math.BigInteger d = this.Remainder(m);
				int bitsCorrect = 64;
				do
				{
					global::Org.BouncyCastle.Math.BigInteger t = x.Multiply(d).Remainder(m);
					x = x.Multiply(global::Org.BouncyCastle.Math.BigInteger.Two.Subtract(t)).Remainder(m);
					bitsCorrect <<= 1;
				}
				while (bitsCorrect < pow);
			}
			if (x.sign < 0)
			{
				x = x.Add(m);
			}
			return x;
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000511EC File Offset: 0x0004F3EC
		private static int ModInverse32(int d)
		{
			int x = d + ((d + 1 & 4) << 1);
			x *= 2 - d * x;
			x *= 2 - d * x;
			return x * (2 - d * x);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0005121C File Offset: 0x0004F41C
		private static long ModInverse64(long d)
		{
			long x = d + ((d + 1L & 4L) << 1);
			x *= 2L - d * x;
			x *= 2L - d * x;
			x *= 2L - d * x;
			return x * (2L - d * x);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0005125C File Offset: 0x0004F45C
		private static global::Org.BouncyCastle.Math.BigInteger ExtEuclid(global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b, out global::Org.BouncyCastle.Math.BigInteger u1Out)
		{
			global::Org.BouncyCastle.Math.BigInteger u = global::Org.BouncyCastle.Math.BigInteger.One;
			global::Org.BouncyCastle.Math.BigInteger v = global::Org.BouncyCastle.Math.BigInteger.Zero;
			global::Org.BouncyCastle.Math.BigInteger u2 = a;
			global::Org.BouncyCastle.Math.BigInteger v2 = b;
			if (v2.sign > 0)
			{
				for (;;)
				{
					global::Org.BouncyCastle.Math.BigInteger[] q = u2.DivideAndRemainder(v2);
					u2 = v2;
					v2 = q[1];
					global::Org.BouncyCastle.Math.BigInteger oldU = u;
					u = v;
					if (v2.sign <= 0)
					{
						break;
					}
					v = oldU.Subtract(v.Multiply(q[0]));
				}
			}
			u1Out = u;
			return u2;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000512B8 File Offset: 0x0004F4B8
		private static void ZeroOut(int[] x)
		{
			global::System.Array.Clear(x, 0, x.Length);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000512C4 File Offset: 0x0004F4C4
		public global::Org.BouncyCastle.Math.BigInteger ModPow(global::Org.BouncyCastle.Math.BigInteger e, global::Org.BouncyCastle.Math.BigInteger m)
		{
			if (m.sign < 1)
			{
				throw new global::System.ArithmeticException("Modulus must be positive");
			}
			if (m.Equals(global::Org.BouncyCastle.Math.BigInteger.One))
			{
				return global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			if (e.sign == 0)
			{
				return global::Org.BouncyCastle.Math.BigInteger.One;
			}
			if (this.sign == 0)
			{
				return global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			bool flag = e.sign < 0;
			if (flag)
			{
				e = e.Negate();
			}
			global::Org.BouncyCastle.Math.BigInteger result = this.Mod(m);
			if (!e.Equals(global::Org.BouncyCastle.Math.BigInteger.One))
			{
				if ((m.magnitude[m.magnitude.Length - 1] & 1) == 0)
				{
					result = global::Org.BouncyCastle.Math.BigInteger.ModPowBarrett(result, e, m);
				}
				else
				{
					result = global::Org.BouncyCastle.Math.BigInteger.ModPowMonty(result, e, m, true);
				}
			}
			if (flag)
			{
				result = result.ModInverse(m);
			}
			return result;
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00051374 File Offset: 0x0004F574
		private static global::Org.BouncyCastle.Math.BigInteger ModPowBarrett(global::Org.BouncyCastle.Math.BigInteger b, global::Org.BouncyCastle.Math.BigInteger e, global::Org.BouncyCastle.Math.BigInteger m)
		{
			int i = m.magnitude.Length;
			global::Org.BouncyCastle.Math.BigInteger mr = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(i + 1 << 5);
			global::Org.BouncyCastle.Math.BigInteger yu = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(i << 6).Divide(m);
			int extraBits = 0;
			int expLength = e.BitLength;
			while (expLength > global::Org.BouncyCastle.Math.BigInteger.ExpWindowThresholds[extraBits])
			{
				extraBits++;
			}
			int numPowers = 1 << extraBits;
			global::Org.BouncyCastle.Math.BigInteger[] oddPowers = new global::Org.BouncyCastle.Math.BigInteger[numPowers];
			oddPowers[0] = b;
			global::Org.BouncyCastle.Math.BigInteger b2 = global::Org.BouncyCastle.Math.BigInteger.ReduceBarrett(b.Square(), m, mr, yu);
			for (int j = 1; j < numPowers; j++)
			{
				oddPowers[j] = global::Org.BouncyCastle.Math.BigInteger.ReduceBarrett(oddPowers[j - 1].Multiply(b2), m, mr, yu);
			}
			int[] windowList = global::Org.BouncyCastle.Math.BigInteger.GetWindowList(e.magnitude, extraBits);
			int window = windowList[0];
			int mult = window & 255;
			int lastZeroes = window >> 8;
			global::Org.BouncyCastle.Math.BigInteger y;
			if (mult == 1)
			{
				y = b2;
				lastZeroes--;
			}
			else
			{
				y = oddPowers[mult >> 1];
			}
			int windowPos = 1;
			while ((window = windowList[windowPos++]) != -1)
			{
				mult = (window & 255);
				int bits = lastZeroes + (int)global::Org.BouncyCastle.Math.BigInteger.BitLengthTable[mult];
				for (int k = 0; k < bits; k++)
				{
					y = global::Org.BouncyCastle.Math.BigInteger.ReduceBarrett(y.Square(), m, mr, yu);
				}
				y = global::Org.BouncyCastle.Math.BigInteger.ReduceBarrett(y.Multiply(oddPowers[mult >> 1]), m, mr, yu);
				lastZeroes = window >> 8;
			}
			for (int l = 0; l < lastZeroes; l++)
			{
				y = global::Org.BouncyCastle.Math.BigInteger.ReduceBarrett(y.Square(), m, mr, yu);
			}
			return y;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000514EC File Offset: 0x0004F6EC
		private static global::Org.BouncyCastle.Math.BigInteger ReduceBarrett(global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Math.BigInteger m, global::Org.BouncyCastle.Math.BigInteger mr, global::Org.BouncyCastle.Math.BigInteger yu)
		{
			int xLen = x.BitLength;
			int mLen = m.BitLength;
			if (xLen < mLen)
			{
				return x;
			}
			if (xLen - mLen > 1)
			{
				int i = m.magnitude.Length;
				global::Org.BouncyCastle.Math.BigInteger bigInteger = x.DivideWords(i - 1).Multiply(yu).DivideWords(i + 1);
				global::Org.BouncyCastle.Math.BigInteger r = x.RemainderWords(i + 1);
				global::Org.BouncyCastle.Math.BigInteger r2 = bigInteger.Multiply(m).RemainderWords(i + 1);
				x = r.Subtract(r2);
				if (x.sign < 0)
				{
					x = x.Add(mr);
				}
			}
			while (x.CompareTo(m) >= 0)
			{
				x = x.Subtract(m);
			}
			return x;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00051580 File Offset: 0x0004F780
		private static global::Org.BouncyCastle.Math.BigInteger ModPowMonty(global::Org.BouncyCastle.Math.BigInteger b, global::Org.BouncyCastle.Math.BigInteger e, global::Org.BouncyCastle.Math.BigInteger m, bool convert)
		{
			int i = m.magnitude.Length;
			int powR = 32 * i;
			bool smallMontyModulus = m.BitLength + 2 <= powR;
			uint mDash = (uint)m.GetMQuote();
			if (convert)
			{
				b = b.ShiftLeft(powR).Remainder(m);
			}
			int[] yAccum = new int[i + 1];
			int[] zVal = b.magnitude;
			if (zVal.Length < i)
			{
				int[] tmp = new int[i];
				zVal.CopyTo(tmp, i - zVal.Length);
				zVal = tmp;
			}
			int extraBits = 0;
			if (e.magnitude.Length > 1 || e.BitCount > 2)
			{
				int expLength = e.BitLength;
				while (expLength > global::Org.BouncyCastle.Math.BigInteger.ExpWindowThresholds[extraBits])
				{
					extraBits++;
				}
			}
			int numPowers = 1 << extraBits;
			int[][] oddPowers = new int[numPowers][];
			oddPowers[0] = zVal;
			int[] zSquared = global::Org.BouncyCastle.Utilities.Arrays.Clone(zVal);
			global::Org.BouncyCastle.Math.BigInteger.SquareMonty(yAccum, zSquared, m.magnitude, mDash, smallMontyModulus);
			for (int j = 1; j < numPowers; j++)
			{
				oddPowers[j] = global::Org.BouncyCastle.Utilities.Arrays.Clone(oddPowers[j - 1]);
				global::Org.BouncyCastle.Math.BigInteger.MultiplyMonty(yAccum, oddPowers[j], zSquared, m.magnitude, mDash, smallMontyModulus);
			}
			int[] windowList = global::Org.BouncyCastle.Math.BigInteger.GetWindowList(e.magnitude, extraBits);
			int window = windowList[0];
			int mult = window & 255;
			int lastZeroes = window >> 8;
			int[] yVal;
			if (mult == 1)
			{
				yVal = zSquared;
				lastZeroes--;
			}
			else
			{
				yVal = global::Org.BouncyCastle.Utilities.Arrays.Clone(oddPowers[mult >> 1]);
			}
			int windowPos = 1;
			while ((window = windowList[windowPos++]) != -1)
			{
				mult = (window & 255);
				int bits = lastZeroes + (int)global::Org.BouncyCastle.Math.BigInteger.BitLengthTable[mult];
				for (int k = 0; k < bits; k++)
				{
					global::Org.BouncyCastle.Math.BigInteger.SquareMonty(yAccum, yVal, m.magnitude, mDash, smallMontyModulus);
				}
				global::Org.BouncyCastle.Math.BigInteger.MultiplyMonty(yAccum, yVal, oddPowers[mult >> 1], m.magnitude, mDash, smallMontyModulus);
				lastZeroes = window >> 8;
			}
			for (int l = 0; l < lastZeroes; l++)
			{
				global::Org.BouncyCastle.Math.BigInteger.SquareMonty(yAccum, yVal, m.magnitude, mDash, smallMontyModulus);
			}
			if (convert)
			{
				global::Org.BouncyCastle.Math.BigInteger.MontgomeryReduce(yVal, m.magnitude, mDash);
			}
			else if (smallMontyModulus && global::Org.BouncyCastle.Math.BigInteger.CompareTo(0, yVal, 0, m.magnitude) >= 0)
			{
				global::Org.BouncyCastle.Math.BigInteger.Subtract(0, yVal, 0, m.magnitude);
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, yVal, true);
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x000517A8 File Offset: 0x0004F9A8
		private static int[] GetWindowList(int[] mag, int extraBits)
		{
			int v = mag[0];
			int leadingBits = global::Org.BouncyCastle.Math.BigInteger.BitLen(v);
			int[] result = new int[((mag.Length - 1 << 5) + leadingBits) / (1 + extraBits) + 2];
			int resultPos = 0;
			int bitPos = 33 - leadingBits;
			v <<= bitPos;
			int mult = 1;
			int multLimit = 1 << extraBits;
			int zeroes = 0;
			int i = 0;
			for (;;)
			{
				if (bitPos >= 32)
				{
					if (++i == mag.Length)
					{
						break;
					}
					v = mag[i];
					bitPos = 0;
				}
				else
				{
					if (mult < multLimit)
					{
						mult = (mult << 1 | (int)((uint)v >> 31));
					}
					else if (v < 0)
					{
						result[resultPos++] = global::Org.BouncyCastle.Math.BigInteger.CreateWindowEntry(mult, zeroes);
						mult = 1;
						zeroes = 0;
					}
					else
					{
						zeroes++;
					}
					v <<= 1;
					bitPos++;
				}
			}
			result[resultPos++] = global::Org.BouncyCastle.Math.BigInteger.CreateWindowEntry(mult, zeroes);
			result[resultPos] = -1;
			return result;
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0005186A File Offset: 0x0004FA6A
		private static int CreateWindowEntry(int mult, int zeroes)
		{
			while ((mult & 1) == 0)
			{
				mult >>= 1;
				zeroes++;
			}
			return mult | zeroes << 8;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00051884 File Offset: 0x0004FA84
		private static int[] Square(int[] w, int[] x)
		{
			int wBase = w.Length - 1;
			ulong c;
			for (int i = x.Length - 1; i > 0; i--)
			{
				ulong v = (ulong)x[i];
				c = v * v + (ulong)w[wBase];
				w[wBase] = (int)c;
				c >>= 32;
				for (int j = i - 1; j >= 0; j--)
				{
					ulong prod = v * (ulong)x[j];
					c += ((ulong)w[--wBase] & (ulong)-1) + (ulong)((ulong)((uint)prod) << 1);
					w[wBase] = (int)c;
					c = (c >> 32) + (prod >> 31);
				}
				c += (ulong)w[--wBase];
				w[wBase] = (int)c;
				if (--wBase >= 0)
				{
					w[wBase] = (int)(c >> 32);
				}
				wBase += i;
			}
			c = (ulong)x[0];
			c = c * c + (ulong)w[wBase];
			w[wBase] = (int)c;
			if (--wBase >= 0)
			{
				w[wBase] += (int)(c >> 32);
			}
			return w;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00051958 File Offset: 0x0004FB58
		private static int[] Multiply(int[] x, int[] y, int[] z)
		{
			int i = z.Length;
			if (i < 1)
			{
				return x;
			}
			int xBase = x.Length - y.Length;
			do
			{
				long a = (long)z[--i] & (long)((ulong)-1);
				long val = 0L;
				if (a != 0L)
				{
					for (int j = y.Length - 1; j >= 0; j--)
					{
						val += a * ((long)y[j] & (long)((ulong)-1)) + ((long)x[xBase + j] & (long)((ulong)-1));
						x[xBase + j] = (int)val;
						val = (long)((ulong)val >> 32);
					}
				}
				xBase--;
				if (xBase >= 0)
				{
					x[xBase] = (int)val;
				}
			}
			while (i > 0);
			return x;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x000519D4 File Offset: 0x0004FBD4
		private int GetMQuote()
		{
			if (this.mQuote != 0)
			{
				return this.mQuote;
			}
			int d = -this.magnitude[this.magnitude.Length - 1];
			return this.mQuote = global::Org.BouncyCastle.Math.BigInteger.ModInverse32(d);
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00051A14 File Offset: 0x0004FC14
		private static void MontgomeryReduce(int[] x, int[] m, uint mDash)
		{
			int i = m.Length;
			for (int j = i - 1; j >= 0; j--)
			{
				uint x2 = (uint)x[i - 1];
				ulong t = (ulong)(x2 * mDash);
				ulong carry = t * (ulong)m[i - 1] + (ulong)x2;
				carry >>= 32;
				for (int k = i - 2; k >= 0; k--)
				{
					carry += t * (ulong)m[k] + (ulong)x[k];
					x[k + 1] = (int)carry;
					carry >>= 32;
				}
				x[0] = (int)carry;
			}
			if (global::Org.BouncyCastle.Math.BigInteger.CompareTo(0, x, 0, m) >= 0)
			{
				global::Org.BouncyCastle.Math.BigInteger.Subtract(0, x, 0, m);
			}
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00051AA4 File Offset: 0x0004FCA4
		private static void MultiplyMonty(int[] a, int[] x, int[] y, int[] m, uint mDash, bool smallMontyModulus)
		{
			int i = m.Length;
			if (i == 1)
			{
				x[0] = (int)global::Org.BouncyCastle.Math.BigInteger.MultiplyMontyNIsOne((uint)x[0], (uint)y[0], (uint)m[0], mDash);
				return;
			}
			uint y2 = (uint)y[i - 1];
			ulong xi = (ulong)x[i - 1];
			ulong carry = xi * (ulong)y2;
			ulong t = (ulong)((uint)carry * mDash);
			ulong prod2 = t * (ulong)m[i - 1];
			carry += (ulong)((uint)prod2);
			carry = (carry >> 32) + (prod2 >> 32);
			for (int j = i - 2; j >= 0; j--)
			{
				ulong prod3 = xi * (ulong)y[j];
				prod2 = t * (ulong)m[j];
				carry += (prod3 & (ulong)-1) + (ulong)((uint)prod2);
				a[j + 2] = (int)carry;
				carry = (carry >> 32) + (prod3 >> 32) + (prod2 >> 32);
			}
			a[1] = (int)carry;
			int aMax = (int)(carry >> 32);
			for (int k = i - 2; k >= 0; k--)
			{
				uint a2 = (uint)a[i];
				ulong xi2 = (ulong)x[k];
				ulong prod4 = xi2 * (ulong)y2;
				ulong carry2 = (prod4 & (ulong)-1) + (ulong)a2;
				ulong t2 = (ulong)((uint)carry2 * mDash);
				ulong prod5 = t2 * (ulong)m[i - 1];
				carry2 += (ulong)((uint)prod5);
				carry2 = (carry2 >> 32) + (prod4 >> 32) + (prod5 >> 32);
				for (int l = i - 2; l >= 0; l--)
				{
					prod4 = xi2 * (ulong)y[l];
					prod5 = t2 * (ulong)m[l];
					carry2 += (prod4 & (ulong)-1) + (ulong)((uint)prod5) + (ulong)a[l + 1];
					a[l + 2] = (int)carry2;
					carry2 = (carry2 >> 32) + (prod4 >> 32) + (prod5 >> 32);
				}
				carry2 += (ulong)aMax;
				a[1] = (int)carry2;
				aMax = (int)(carry2 >> 32);
			}
			a[0] = aMax;
			if (!smallMontyModulus && global::Org.BouncyCastle.Math.BigInteger.CompareTo(0, a, 0, m) >= 0)
			{
				global::Org.BouncyCastle.Math.BigInteger.Subtract(0, a, 0, m);
			}
			global::System.Array.Copy(a, 1, x, 0, i);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00051C64 File Offset: 0x0004FE64
		private static void SquareMonty(int[] a, int[] x, int[] m, uint mDash, bool smallMontyModulus)
		{
			int i = m.Length;
			if (i == 1)
			{
				uint xVal = (uint)x[0];
				x[0] = (int)global::Org.BouncyCastle.Math.BigInteger.MultiplyMontyNIsOne(xVal, xVal, (uint)m[0], mDash);
				return;
			}
			ulong x2 = (ulong)x[i - 1];
			ulong carry = x2 * x2;
			ulong t = (ulong)((uint)carry * mDash);
			ulong prod2 = t * (ulong)m[i - 1];
			carry += (ulong)((uint)prod2);
			carry = (carry >> 32) + (prod2 >> 32);
			for (int j = i - 2; j >= 0; j--)
			{
				ulong prod3 = x2 * (ulong)x[j];
				prod2 = t * (ulong)m[j];
				carry += (prod2 & (ulong)-1) + (ulong)((ulong)((uint)prod3) << 1);
				a[j + 2] = (int)carry;
				carry = (carry >> 32) + (prod3 >> 31) + (prod2 >> 32);
			}
			a[1] = (int)carry;
			int aMax = (int)(carry >> 32);
			for (int k = i - 2; k >= 0; k--)
			{
				uint a2 = (uint)a[i];
				ulong t2 = (ulong)(a2 * mDash);
				ulong carry2 = t2 * (ulong)m[i - 1] + (ulong)a2;
				carry2 >>= 32;
				for (int l = i - 2; l > k; l--)
				{
					carry2 += t2 * (ulong)m[l] + (ulong)a[l + 1];
					a[l + 2] = (int)carry2;
					carry2 >>= 32;
				}
				ulong xi = (ulong)x[k];
				ulong prod4 = xi * xi;
				ulong prod5 = t2 * (ulong)m[k];
				carry2 += (prod4 & (ulong)-1) + (ulong)((uint)prod5) + (ulong)a[k + 1];
				a[k + 2] = (int)carry2;
				carry2 = (carry2 >> 32) + (prod4 >> 32) + (prod5 >> 32);
				for (int n = k - 1; n >= 0; n--)
				{
					ulong prod6 = xi * (ulong)x[n];
					ulong prod7 = t2 * (ulong)m[n];
					carry2 += (prod7 & (ulong)-1) + (ulong)((ulong)((uint)prod6) << 1) + (ulong)a[n + 1];
					a[n + 2] = (int)carry2;
					carry2 = (carry2 >> 32) + (prod6 >> 31) + (prod7 >> 32);
				}
				carry2 += (ulong)aMax;
				a[1] = (int)carry2;
				aMax = (int)(carry2 >> 32);
			}
			a[0] = aMax;
			if (!smallMontyModulus && global::Org.BouncyCastle.Math.BigInteger.CompareTo(0, a, 0, m) >= 0)
			{
				global::Org.BouncyCastle.Math.BigInteger.Subtract(0, a, 0, m);
			}
			global::System.Array.Copy(a, 1, x, 0, i);
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00051E78 File Offset: 0x00050078
		private static uint MultiplyMontyNIsOne(uint x, uint y, uint m, uint mDash)
		{
			ulong carry = (ulong)x * (ulong)y;
			uint t = (uint)carry * mDash;
			ulong um = (ulong)m;
			ulong prod2 = um * (ulong)t;
			carry += (ulong)((uint)prod2);
			carry = (carry >> 32) + (prod2 >> 32);
			if (carry > um)
			{
				carry -= um;
			}
			return (uint)carry;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00051EB4 File Offset: 0x000500B4
		public global::Org.BouncyCastle.Math.BigInteger Multiply(global::Org.BouncyCastle.Math.BigInteger val)
		{
			if (val == this)
			{
				return this.Square();
			}
			if ((this.sign & val.sign) == 0)
			{
				return global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			if (val.QuickPow2Check())
			{
				global::Org.BouncyCastle.Math.BigInteger result = this.ShiftLeft(val.Abs().BitLength - 1);
				if (val.sign <= 0)
				{
					return result.Negate();
				}
				return result;
			}
			else
			{
				if (!this.QuickPow2Check())
				{
					int[] res = new int[this.magnitude.Length + val.magnitude.Length];
					global::Org.BouncyCastle.Math.BigInteger.Multiply(res, this.magnitude, val.magnitude);
					return new global::Org.BouncyCastle.Math.BigInteger(this.sign ^ val.sign ^ 1, res, true);
				}
				global::Org.BouncyCastle.Math.BigInteger result2 = val.ShiftLeft(this.Abs().BitLength - 1);
				if (this.sign <= 0)
				{
					return result2.Negate();
				}
				return result2;
			}
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00051F80 File Offset: 0x00050180
		public global::Org.BouncyCastle.Math.BigInteger Square()
		{
			if (this.sign == 0)
			{
				return global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			if (this.QuickPow2Check())
			{
				return this.ShiftLeft(this.Abs().BitLength - 1);
			}
			int resLength = this.magnitude.Length << 1;
			if ((uint)this.magnitude[0] >> 16 == 0U)
			{
				resLength--;
			}
			int[] res = new int[resLength];
			global::Org.BouncyCastle.Math.BigInteger.Square(res, this.magnitude);
			return new global::Org.BouncyCastle.Math.BigInteger(1, res, false);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00051FEF File Offset: 0x000501EF
		public global::Org.BouncyCastle.Math.BigInteger Negate()
		{
			if (this.sign == 0)
			{
				return this;
			}
			return new global::Org.BouncyCastle.Math.BigInteger(-this.sign, this.magnitude, false);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00052010 File Offset: 0x00050210
		public global::Org.BouncyCastle.Math.BigInteger NextProbablePrime()
		{
			if (this.sign < 0)
			{
				throw new global::System.ArithmeticException("Cannot be called on value < 0");
			}
			if (this.CompareTo(global::Org.BouncyCastle.Math.BigInteger.Two) < 0)
			{
				return global::Org.BouncyCastle.Math.BigInteger.Two;
			}
			global::Org.BouncyCastle.Math.BigInteger i = this.Inc().SetBit(0);
			while (!i.CheckProbablePrime(100, global::Org.BouncyCastle.Math.BigInteger.RandomSource, false))
			{
				i = i.Add(global::Org.BouncyCastle.Math.BigInteger.Two);
			}
			return i;
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00052071 File Offset: 0x00050271
		public global::Org.BouncyCastle.Math.BigInteger Not()
		{
			return this.Inc().Negate();
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00052080 File Offset: 0x00050280
		public global::Org.BouncyCastle.Math.BigInteger Pow(int exp)
		{
			if (exp <= 0)
			{
				if (exp < 0)
				{
					throw new global::System.ArithmeticException("Negative exponent");
				}
				return global::Org.BouncyCastle.Math.BigInteger.One;
			}
			else
			{
				if (this.sign == 0)
				{
					return this;
				}
				if (!this.QuickPow2Check())
				{
					global::Org.BouncyCastle.Math.BigInteger y = global::Org.BouncyCastle.Math.BigInteger.One;
					global::Org.BouncyCastle.Math.BigInteger z = this;
					for (;;)
					{
						if ((exp & 1) == 1)
						{
							y = y.Multiply(z);
						}
						exp >>= 1;
						if (exp == 0)
						{
							break;
						}
						z = z.Multiply(z);
					}
					return y;
				}
				long powOf2 = (long)exp * (long)(this.BitLength - 1);
				if (powOf2 > 2147483647L)
				{
					throw new global::System.ArithmeticException("Result too large");
				}
				return global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft((int)powOf2);
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0005210F File Offset: 0x0005030F
		public static global::Org.BouncyCastle.Math.BigInteger ProbablePrime(int bitLength, global::System.Random random)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(bitLength, 100, random);
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0005211C File Offset: 0x0005031C
		private int Remainder(int m)
		{
			long acc = 0L;
			for (int pos = 0; pos < this.magnitude.Length; pos++)
			{
				long posVal = (long)((ulong)this.magnitude[pos]);
				acc = (acc << 32 | posVal) % (long)m;
			}
			return (int)acc;
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00052158 File Offset: 0x00050358
		private static int[] Remainder(int[] x, int[] y)
		{
			int xStart = 0;
			while (xStart < x.Length && x[xStart] == 0)
			{
				xStart++;
			}
			int yStart = 0;
			while (yStart < y.Length && y[yStart] == 0)
			{
				yStart++;
			}
			int xyCmp = global::Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xStart, x, yStart, y);
			if (xyCmp > 0)
			{
				int yBitLength = global::Org.BouncyCastle.Math.BigInteger.CalcBitLength(1, yStart, y);
				int xBitLength = global::Org.BouncyCastle.Math.BigInteger.CalcBitLength(1, xStart, x);
				int shift = xBitLength - yBitLength;
				int cStart = 0;
				int cBitLength = yBitLength;
				int[] c;
				if (shift > 0)
				{
					c = global::Org.BouncyCastle.Math.BigInteger.ShiftLeft(y, shift);
					cBitLength += shift;
				}
				else
				{
					int len = y.Length - yStart;
					c = new int[len];
					global::System.Array.Copy(y, yStart, c, 0, len);
				}
				for (;;)
				{
					if (cBitLength < xBitLength || global::Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xStart, x, cStart, c) >= 0)
					{
						global::Org.BouncyCastle.Math.BigInteger.Subtract(xStart, x, cStart, c);
						while (x[xStart] == 0)
						{
							if (++xStart == x.Length)
							{
								return x;
							}
						}
						xBitLength = 32 * (x.Length - xStart - 1) + global::Org.BouncyCastle.Math.BigInteger.BitLen(x[xStart]);
						if (xBitLength <= yBitLength)
						{
							if (xBitLength < yBitLength)
							{
								return x;
							}
							xyCmp = global::Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xStart, x, yStart, y);
							if (xyCmp <= 0)
							{
								goto IL_14A;
							}
						}
					}
					shift = cBitLength - xBitLength;
					if (shift == 1)
					{
						uint num = (uint)c[cStart] >> 1;
						uint firstX = (uint)x[xStart];
						if (num > firstX)
						{
							shift++;
						}
					}
					if (shift < 2)
					{
						global::Org.BouncyCastle.Math.BigInteger.ShiftRightOneInPlace(cStart, c);
						cBitLength--;
					}
					else
					{
						global::Org.BouncyCastle.Math.BigInteger.ShiftRightInPlace(cStart, c, shift);
						cBitLength -= shift;
					}
					while (c[cStart] == 0)
					{
						cStart++;
					}
				}
				return x;
			}
			IL_14A:
			if (xyCmp == 0)
			{
				global::System.Array.Clear(x, xStart, x.Length - xStart);
			}
			return x;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x000522C0 File Offset: 0x000504C0
		public global::Org.BouncyCastle.Math.BigInteger Remainder(global::Org.BouncyCastle.Math.BigInteger n)
		{
			if (n.sign == 0)
			{
				throw new global::System.ArithmeticException("Division by zero error");
			}
			if (this.sign == 0)
			{
				return global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			if (n.magnitude.Length == 1)
			{
				int val = n.magnitude[0];
				if (val > 0)
				{
					if (val == 1)
					{
						return global::Org.BouncyCastle.Math.BigInteger.Zero;
					}
					int rem = this.Remainder(val);
					if (rem != 0)
					{
						return new global::Org.BouncyCastle.Math.BigInteger(this.sign, new int[]
						{
							rem
						}, false);
					}
					return global::Org.BouncyCastle.Math.BigInteger.Zero;
				}
			}
			if (global::Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(0, this.magnitude, 0, n.magnitude) < 0)
			{
				return this;
			}
			int[] result;
			if (n.QuickPow2Check())
			{
				result = this.LastNBits(n.Abs().BitLength - 1);
			}
			else
			{
				result = (int[])this.magnitude.Clone();
				result = global::Org.BouncyCastle.Math.BigInteger.Remainder(result, n.magnitude);
			}
			return new global::Org.BouncyCastle.Math.BigInteger(this.sign, result, true);
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x0005239C File Offset: 0x0005059C
		private int[] LastNBits(int n)
		{
			if (n < 1)
			{
				return global::Org.BouncyCastle.Math.BigInteger.ZeroMagnitude;
			}
			int numWords = (n + 32 - 1) / 32;
			numWords = global::System.Math.Min(numWords, this.magnitude.Length);
			int[] result = new int[numWords];
			global::System.Array.Copy(this.magnitude, this.magnitude.Length - numWords, result, 0, numWords);
			int excessBits = (numWords << 5) - n;
			if (excessBits > 0)
			{
				result[0] &= (int)(uint.MaxValue >> excessBits);
			}
			return result;
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00052408 File Offset: 0x00050608
		private global::Org.BouncyCastle.Math.BigInteger DivideWords(int w)
		{
			int i = this.magnitude.Length;
			if (w >= i)
			{
				return global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			int[] mag = new int[i - w];
			global::System.Array.Copy(this.magnitude, 0, mag, 0, i - w);
			return new global::Org.BouncyCastle.Math.BigInteger(this.sign, mag, false);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00052450 File Offset: 0x00050650
		private global::Org.BouncyCastle.Math.BigInteger RemainderWords(int w)
		{
			int i = this.magnitude.Length;
			if (w >= i)
			{
				return this;
			}
			int[] mag = new int[w];
			global::System.Array.Copy(this.magnitude, i - w, mag, 0, w);
			return new global::Org.BouncyCastle.Math.BigInteger(this.sign, mag, false);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00052494 File Offset: 0x00050694
		private static int[] ShiftLeft(int[] mag, int n)
		{
			int nInts = (int)((uint)n >> 5);
			int nBits = n & 31;
			int magLen = mag.Length;
			int[] newMag;
			if (nBits == 0)
			{
				newMag = new int[magLen + nInts];
				mag.CopyTo(newMag, 0);
			}
			else
			{
				int i = 0;
				int nBits2 = 32 - nBits;
				int highBits = (int)((uint)mag[0] >> nBits2);
				if (highBits != 0)
				{
					newMag = new int[magLen + nInts + 1];
					newMag[i++] = highBits;
				}
				else
				{
					newMag = new int[magLen + nInts];
				}
				int j = mag[0];
				for (int k = 0; k < magLen - 1; k++)
				{
					int next = mag[k + 1];
					newMag[i++] = (j << nBits | (int)((uint)next >> nBits2));
					j = next;
				}
				newMag[i] = mag[magLen - 1] << nBits;
			}
			return newMag;
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x0005254C File Offset: 0x0005074C
		private static int ShiftLeftOneInPlace(int[] x, int carry)
		{
			int pos = x.Length;
			while (--pos >= 0)
			{
				uint val = (uint)x[pos];
				x[pos] = (int)(val << 1 | (uint)carry);
				carry = (int)(val >> 31);
			}
			return carry;
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0005257C File Offset: 0x0005077C
		public global::Org.BouncyCastle.Math.BigInteger ShiftLeft(int n)
		{
			if (this.sign == 0 || this.magnitude.Length == 0)
			{
				return global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			if (n == 0)
			{
				return this;
			}
			if (n < 0)
			{
				return this.ShiftRight(-n);
			}
			global::Org.BouncyCastle.Math.BigInteger result = new global::Org.BouncyCastle.Math.BigInteger(this.sign, global::Org.BouncyCastle.Math.BigInteger.ShiftLeft(this.magnitude, n), true);
			if (this.nBits != -1)
			{
				result.nBits = ((this.sign > 0) ? this.nBits : (this.nBits + n));
			}
			if (this.nBitLength != -1)
			{
				result.nBitLength = this.nBitLength + n;
			}
			return result;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0005260C File Offset: 0x0005080C
		private static void ShiftRightInPlace(int start, int[] mag, int n)
		{
			int nInts = (int)(((uint)n >> 5) + (uint)start);
			int nBits = n & 31;
			int magEnd = mag.Length - 1;
			if (nInts != start)
			{
				int delta = nInts - start;
				for (int i = magEnd; i >= nInts; i--)
				{
					mag[i] = mag[i - delta];
				}
				for (int j = nInts - 1; j >= start; j--)
				{
					mag[j] = 0;
				}
			}
			if (nBits != 0)
			{
				int nBits2 = 32 - nBits;
				int k = mag[magEnd];
				for (int l = magEnd; l > nInts; l--)
				{
					int next = mag[l - 1];
					mag[l] = (int)((uint)k >> nBits | (uint)((uint)next << nBits2));
					k = next;
				}
				mag[nInts] = (int)((uint)mag[nInts] >> nBits);
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x000526AC File Offset: 0x000508AC
		private static void ShiftRightOneInPlace(int start, int[] mag)
		{
			int i = mag.Length;
			int j = mag[i - 1];
			while (--i > start)
			{
				int next = mag[i - 1];
				mag[i] = (int)((uint)j >> 1 | (uint)((uint)next << 31));
				j = next;
			}
			mag[start] = (int)((uint)mag[start] >> 1);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x000526E8 File Offset: 0x000508E8
		public global::Org.BouncyCastle.Math.BigInteger ShiftRight(int n)
		{
			if (n == 0)
			{
				return this;
			}
			if (n < 0)
			{
				return this.ShiftLeft(-n);
			}
			if (n < this.BitLength)
			{
				int resultLength = this.BitLength - n + 31 >> 5;
				int[] res = new int[resultLength];
				int numInts = n >> 5;
				int numBits = n & 31;
				if (numBits == 0)
				{
					global::System.Array.Copy(this.magnitude, 0, res, 0, res.Length);
				}
				else
				{
					int numBits2 = 32 - numBits;
					int magPos = this.magnitude.Length - 1 - numInts;
					for (int i = resultLength - 1; i >= 0; i--)
					{
						res[i] = (int)((uint)this.magnitude[magPos--] >> (numBits & 31));
						if (magPos >= 0)
						{
							res[i] |= this.magnitude[magPos] << numBits2;
						}
					}
				}
				return new global::Org.BouncyCastle.Math.BigInteger(this.sign, res, false);
			}
			if (this.sign >= 0)
			{
				return global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			return global::Org.BouncyCastle.Math.BigInteger.One.Negate();
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x000527C8 File Offset: 0x000509C8
		public int SignValue
		{
			get
			{
				return this.sign;
			}
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x000527D0 File Offset: 0x000509D0
		private static int[] Subtract(int xStart, int[] x, int yStart, int[] y)
		{
			int iT = x.Length;
			int iV = y.Length;
			int borrow = 0;
			do
			{
				long i = ((long)x[--iT] & (long)((ulong)-1)) - ((long)y[--iV] & (long)((ulong)-1)) + (long)borrow;
				x[iT] = (int)i;
				borrow = (int)(i >> 63);
			}
			while (iV > yStart);
			if (borrow != 0)
			{
				int num2;
				do
				{
					int num = --iT;
					num2 = x[num] - 1;
					x[num] = num2;
				}
				while (num2 == -1);
			}
			return x;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00052830 File Offset: 0x00050A30
		public global::Org.BouncyCastle.Math.BigInteger Subtract(global::Org.BouncyCastle.Math.BigInteger n)
		{
			if (n.sign == 0)
			{
				return this;
			}
			if (this.sign == 0)
			{
				return n.Negate();
			}
			if (this.sign != n.sign)
			{
				return this.Add(n.Negate());
			}
			int compare = global::Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(0, this.magnitude, 0, n.magnitude);
			if (compare == 0)
			{
				return global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			global::Org.BouncyCastle.Math.BigInteger bigun;
			global::Org.BouncyCastle.Math.BigInteger lilun;
			if (compare < 0)
			{
				bigun = n;
				lilun = this;
			}
			else
			{
				bigun = this;
				lilun = n;
			}
			return new global::Org.BouncyCastle.Math.BigInteger(this.sign * compare, global::Org.BouncyCastle.Math.BigInteger.doSubBigLil(bigun.magnitude, lilun.magnitude), true);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000528BC File Offset: 0x00050ABC
		private static int[] doSubBigLil(int[] bigMag, int[] lilMag)
		{
			int[] res = (int[])bigMag.Clone();
			return global::Org.BouncyCastle.Math.BigInteger.Subtract(0, res, 0, lilMag);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000528DE File Offset: 0x00050ADE
		public byte[] ToByteArray()
		{
			return this.ToByteArray(false);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000528E7 File Offset: 0x00050AE7
		public byte[] ToByteArrayUnsigned()
		{
			return this.ToByteArray(true);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x000528F0 File Offset: 0x00050AF0
		private byte[] ToByteArray(bool unsigned)
		{
			if (this.sign != 0)
			{
				byte[] bytes = new byte[global::Org.BouncyCastle.Math.BigInteger.GetByteLength((unsigned && this.sign > 0) ? this.BitLength : (this.BitLength + 1))];
				int magIndex = this.magnitude.Length;
				int bytesIndex = bytes.Length;
				if (this.sign > 0)
				{
					while (magIndex > 1)
					{
						uint mag = (uint)this.magnitude[--magIndex];
						bytes[--bytesIndex] = (byte)mag;
						bytes[--bytesIndex] = (byte)(mag >> 8);
						bytes[--bytesIndex] = (byte)(mag >> 16);
						bytes[--bytesIndex] = (byte)(mag >> 24);
					}
					uint lastMag;
					for (lastMag = (uint)this.magnitude[0]; lastMag > 255U; lastMag >>= 8)
					{
						bytes[--bytesIndex] = (byte)lastMag;
					}
					bytes[bytesIndex - 1] = (byte)lastMag;
				}
				else
				{
					bool carry = true;
					while (magIndex > 1)
					{
						uint mag2 = (uint)(~(uint)this.magnitude[--magIndex]);
						if (carry)
						{
							carry = ((mag2 += 1U) == 0U);
						}
						bytes[--bytesIndex] = (byte)mag2;
						bytes[--bytesIndex] = (byte)(mag2 >> 8);
						bytes[--bytesIndex] = (byte)(mag2 >> 16);
						bytes[--bytesIndex] = (byte)(mag2 >> 24);
					}
					uint lastMag2 = (uint)this.magnitude[0];
					if (carry)
					{
						lastMag2 -= 1U;
					}
					while (lastMag2 > 255U)
					{
						bytes[--bytesIndex] = (byte)(~(byte)lastMag2);
						lastMag2 >>= 8;
					}
					bytes[--bytesIndex] = (byte)(~(byte)lastMag2);
					if (bytesIndex > 0)
					{
						bytes[bytesIndex - 1] = byte.MaxValue;
					}
				}
				return bytes;
			}
			if (!unsigned)
			{
				return new byte[1];
			}
			return global::Org.BouncyCastle.Math.BigInteger.ZeroEncoding;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00052A68 File Offset: 0x00050C68
		public override string ToString()
		{
			return this.ToString(10);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00052A74 File Offset: 0x00050C74
		public string ToString(int radix)
		{
			if (radix <= 8)
			{
				if (radix == 2 || radix == 8)
				{
					goto IL_23;
				}
			}
			else if (radix == 10 || radix == 16)
			{
				goto IL_23;
			}
			throw new global::System.FormatException("Only bases 2, 8, 10, 16 are allowed");
			IL_23:
			if (this.magnitude == null)
			{
				return "null";
			}
			if (this.sign == 0)
			{
				return "0";
			}
			int firstNonZero = 0;
			while (firstNonZero < this.magnitude.Length && this.magnitude[firstNonZero] == 0)
			{
				firstNonZero++;
			}
			if (firstNonZero == this.magnitude.Length)
			{
				return "0";
			}
			global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
			if (this.sign == -1)
			{
				sb.Append('-');
			}
			if (radix <= 8)
			{
				if (radix != 2)
				{
					if (radix == 8)
					{
						int mask = 1073741823;
						global::Org.BouncyCastle.Math.BigInteger u = this.Abs();
						int bits = u.BitLength;
						global::System.Collections.IList S = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
						while (bits > 30)
						{
							S.Add(global::System.Convert.ToString(u.IntValue & mask, 8));
							u = u.ShiftRight(30);
							bits -= 30;
						}
						sb.Append(global::System.Convert.ToString(u.IntValue, 8));
						for (int i = S.Count - 1; i >= 0; i--)
						{
							global::Org.BouncyCastle.Math.BigInteger.AppendZeroExtendedString(sb, (string)S[i], 10);
						}
					}
				}
				else
				{
					int pos = firstNonZero;
					sb.Append(global::System.Convert.ToString(this.magnitude[pos], 2));
					while (++pos < this.magnitude.Length)
					{
						global::Org.BouncyCastle.Math.BigInteger.AppendZeroExtendedString(sb, global::System.Convert.ToString(this.magnitude[pos], 2), 32);
					}
				}
			}
			else if (radix != 10)
			{
				if (radix == 16)
				{
					int pos2 = firstNonZero;
					sb.Append(global::System.Convert.ToString(this.magnitude[pos2], 16));
					while (++pos2 < this.magnitude.Length)
					{
						global::Org.BouncyCastle.Math.BigInteger.AppendZeroExtendedString(sb, global::System.Convert.ToString(this.magnitude[pos2], 16), 8);
					}
				}
			}
			else
			{
				global::Org.BouncyCastle.Math.BigInteger q = this.Abs();
				if (q.BitLength < 64)
				{
					sb.Append(global::System.Convert.ToString(q.LongValue, radix));
				}
				else
				{
					global::System.Collections.IList moduli = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
					global::Org.BouncyCastle.Math.BigInteger R = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)radix);
					while (R.CompareTo(q) <= 0)
					{
						moduli.Add(R);
						R = R.Square();
					}
					int scale = moduli.Count;
					sb.EnsureCapacity(sb.Length + (1 << scale));
					global::Org.BouncyCastle.Math.BigInteger.ToString(sb, radix, moduli, scale, q);
				}
			}
			return sb.ToString();
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00052CDC File Offset: 0x00050EDC
		private static void ToString(global::System.Text.StringBuilder sb, int radix, global::System.Collections.IList moduli, int scale, global::Org.BouncyCastle.Math.BigInteger pos)
		{
			if (pos.BitLength >= 64)
			{
				global::Org.BouncyCastle.Math.BigInteger[] qr = pos.DivideAndRemainder((global::Org.BouncyCastle.Math.BigInteger)moduli[--scale]);
				global::Org.BouncyCastle.Math.BigInteger.ToString(sb, radix, moduli, scale, qr[0]);
				global::Org.BouncyCastle.Math.BigInteger.ToString(sb, radix, moduli, scale, qr[1]);
				return;
			}
			string s = global::System.Convert.ToString(pos.LongValue, radix);
			if (sb.Length > 1 || (sb.Length == 1 && sb[0] != '-'))
			{
				global::Org.BouncyCastle.Math.BigInteger.AppendZeroExtendedString(sb, s, 1 << scale);
				return;
			}
			if (pos.SignValue != 0)
			{
				sb.Append(s);
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00052D70 File Offset: 0x00050F70
		private static void AppendZeroExtendedString(global::System.Text.StringBuilder sb, string s, int minLength)
		{
			for (int len = s.Length; len < minLength; len++)
			{
				sb.Append('0');
			}
			sb.Append(s);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00052DA0 File Offset: 0x00050FA0
		private static global::Org.BouncyCastle.Math.BigInteger CreateUValueOf(ulong value)
		{
			int msw = (int)(value >> 32);
			int lsw = (int)value;
			if (msw != 0)
			{
				return new global::Org.BouncyCastle.Math.BigInteger(1, new int[]
				{
					msw,
					lsw
				}, false);
			}
			if (lsw != 0)
			{
				global::Org.BouncyCastle.Math.BigInteger i = new global::Org.BouncyCastle.Math.BigInteger(1, new int[]
				{
					lsw
				}, false);
				if ((lsw & -lsw) == lsw)
				{
					i.nBits = 1;
				}
				return i;
			}
			return global::Org.BouncyCastle.Math.BigInteger.Zero;
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00052DF9 File Offset: 0x00050FF9
		private static global::Org.BouncyCastle.Math.BigInteger CreateValueOf(long value)
		{
			if (value >= 0L)
			{
				return global::Org.BouncyCastle.Math.BigInteger.CreateUValueOf((ulong)value);
			}
			if (value == -9223372036854775808L)
			{
				return global::Org.BouncyCastle.Math.BigInteger.CreateValueOf(~value).Not();
			}
			return global::Org.BouncyCastle.Math.BigInteger.CreateValueOf(-value).Negate();
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00052E2C File Offset: 0x0005102C
		public static global::Org.BouncyCastle.Math.BigInteger ValueOf(long value)
		{
			if (value >= 0L && value < (long)global::Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS.Length)
			{
				return global::Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS[(int)(checked((global::System.IntPtr)value))];
			}
			return global::Org.BouncyCastle.Math.BigInteger.CreateValueOf(value);
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00052E4D File Offset: 0x0005104D
		public int GetLowestSetBit()
		{
			if (this.sign == 0)
			{
				return -1;
			}
			return this.GetLowestSetBitMaskFirst(-1);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00052E60 File Offset: 0x00051060
		private int GetLowestSetBitMaskFirst(int firstWordMask)
		{
			int w = this.magnitude.Length;
			int offset = 0;
			uint word = (uint)(this.magnitude[--w] & firstWordMask);
			while (word == 0U)
			{
				word = (uint)this.magnitude[--w];
				offset += 32;
			}
			while ((word & 255U) == 0U)
			{
				word >>= 8;
				offset += 8;
			}
			while ((word & 1U) == 0U)
			{
				word >>= 1;
				offset++;
			}
			return offset;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00052EC4 File Offset: 0x000510C4
		public bool TestBit(int n)
		{
			if (n < 0)
			{
				throw new global::System.ArithmeticException("Bit position must not be negative");
			}
			if (this.sign < 0)
			{
				return !this.Not().TestBit(n);
			}
			int wordNum = n / 32;
			return wordNum < this.magnitude.Length && (this.magnitude[this.magnitude.Length - 1 - wordNum] >> n % 32 & 1) > 0;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00052F2C File Offset: 0x0005112C
		public global::Org.BouncyCastle.Math.BigInteger Or(global::Org.BouncyCastle.Math.BigInteger value)
		{
			if (this.sign == 0)
			{
				return value;
			}
			if (value.sign == 0)
			{
				return this;
			}
			int[] aMag = (this.sign > 0) ? this.magnitude : this.Add(global::Org.BouncyCastle.Math.BigInteger.One).magnitude;
			int[] bMag = (value.sign > 0) ? value.magnitude : value.Add(global::Org.BouncyCastle.Math.BigInteger.One).magnitude;
			bool resultNeg = this.sign < 0 || value.sign < 0;
			int[] resultMag = new int[global::System.Math.Max(aMag.Length, bMag.Length)];
			int aStart = resultMag.Length - aMag.Length;
			int bStart = resultMag.Length - bMag.Length;
			for (int i = 0; i < resultMag.Length; i++)
			{
				int aWord = (i >= aStart) ? aMag[i - aStart] : 0;
				int bWord = (i >= bStart) ? bMag[i - bStart] : 0;
				if (this.sign < 0)
				{
					aWord = ~aWord;
				}
				if (value.sign < 0)
				{
					bWord = ~bWord;
				}
				resultMag[i] = (aWord | bWord);
				if (resultNeg)
				{
					resultMag[i] = ~resultMag[i];
				}
			}
			global::Org.BouncyCastle.Math.BigInteger result = new global::Org.BouncyCastle.Math.BigInteger(1, resultMag, true);
			if (resultNeg)
			{
				result = result.Not();
			}
			return result;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0005304C File Offset: 0x0005124C
		public global::Org.BouncyCastle.Math.BigInteger Xor(global::Org.BouncyCastle.Math.BigInteger value)
		{
			if (this.sign == 0)
			{
				return value;
			}
			if (value.sign == 0)
			{
				return this;
			}
			int[] aMag = (this.sign > 0) ? this.magnitude : this.Add(global::Org.BouncyCastle.Math.BigInteger.One).magnitude;
			int[] bMag = (value.sign > 0) ? value.magnitude : value.Add(global::Org.BouncyCastle.Math.BigInteger.One).magnitude;
			bool resultNeg = (this.sign < 0 && value.sign >= 0) || (this.sign >= 0 && value.sign < 0);
			int[] resultMag = new int[global::System.Math.Max(aMag.Length, bMag.Length)];
			int aStart = resultMag.Length - aMag.Length;
			int bStart = resultMag.Length - bMag.Length;
			for (int i = 0; i < resultMag.Length; i++)
			{
				int aWord = (i >= aStart) ? aMag[i - aStart] : 0;
				int bWord = (i >= bStart) ? bMag[i - bStart] : 0;
				if (this.sign < 0)
				{
					aWord = ~aWord;
				}
				if (value.sign < 0)
				{
					bWord = ~bWord;
				}
				resultMag[i] = (aWord ^ bWord);
				if (resultNeg)
				{
					resultMag[i] = ~resultMag[i];
				}
			}
			global::Org.BouncyCastle.Math.BigInteger result = new global::Org.BouncyCastle.Math.BigInteger(1, resultMag, true);
			if (resultNeg)
			{
				result = result.Not();
			}
			return result;
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00053180 File Offset: 0x00051380
		public global::Org.BouncyCastle.Math.BigInteger SetBit(int n)
		{
			if (n < 0)
			{
				throw new global::System.ArithmeticException("Bit address less than zero");
			}
			if (this.TestBit(n))
			{
				return this;
			}
			if (this.sign > 0 && n < this.BitLength - 1)
			{
				return this.FlipExistingBit(n);
			}
			return this.Or(global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n));
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x000531D4 File Offset: 0x000513D4
		public global::Org.BouncyCastle.Math.BigInteger ClearBit(int n)
		{
			if (n < 0)
			{
				throw new global::System.ArithmeticException("Bit address less than zero");
			}
			if (!this.TestBit(n))
			{
				return this;
			}
			if (this.sign > 0 && n < this.BitLength - 1)
			{
				return this.FlipExistingBit(n);
			}
			return this.AndNot(global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n));
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00053228 File Offset: 0x00051428
		public global::Org.BouncyCastle.Math.BigInteger FlipBit(int n)
		{
			if (n < 0)
			{
				throw new global::System.ArithmeticException("Bit address less than zero");
			}
			if (this.sign > 0 && n < this.BitLength - 1)
			{
				return this.FlipExistingBit(n);
			}
			return this.Xor(global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n));
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00053268 File Offset: 0x00051468
		private global::Org.BouncyCastle.Math.BigInteger FlipExistingBit(int n)
		{
			int[] mag = (int[])this.magnitude.Clone();
			mag[mag.Length - 1 - (n >> 5)] ^= 1 << n;
			return new global::Org.BouncyCastle.Math.BigInteger(this.sign, mag, false);
		}

		// Token: 0x04000901 RID: 2305
		internal static readonly int[][] primeLists = new int[][]
		{
			new int[]
			{
				3,
				5,
				7,
				11,
				13,
				17,
				19,
				23
			},
			new int[]
			{
				29,
				31,
				37,
				41,
				43
			},
			new int[]
			{
				47,
				53,
				59,
				61,
				67
			},
			new int[]
			{
				71,
				73,
				79,
				83
			},
			new int[]
			{
				89,
				97,
				101,
				103
			},
			new int[]
			{
				107,
				109,
				113,
				127
			},
			new int[]
			{
				131,
				137,
				139,
				149
			},
			new int[]
			{
				151,
				157,
				163,
				167
			},
			new int[]
			{
				173,
				179,
				181,
				191
			},
			new int[]
			{
				193,
				197,
				199,
				211
			},
			new int[]
			{
				223,
				227,
				229
			},
			new int[]
			{
				233,
				239,
				241
			},
			new int[]
			{
				251,
				257,
				263
			},
			new int[]
			{
				269,
				271,
				277
			},
			new int[]
			{
				281,
				283,
				293
			},
			new int[]
			{
				307,
				311,
				313
			},
			new int[]
			{
				317,
				331,
				337
			},
			new int[]
			{
				347,
				349,
				353
			},
			new int[]
			{
				359,
				367,
				373
			},
			new int[]
			{
				379,
				383,
				389
			},
			new int[]
			{
				397,
				401,
				409
			},
			new int[]
			{
				419,
				421,
				431
			},
			new int[]
			{
				433,
				439,
				443
			},
			new int[]
			{
				449,
				457,
				461
			},
			new int[]
			{
				463,
				467,
				479
			},
			new int[]
			{
				487,
				491,
				499
			},
			new int[]
			{
				503,
				509,
				521
			},
			new int[]
			{
				523,
				541,
				547
			},
			new int[]
			{
				557,
				563,
				569
			},
			new int[]
			{
				571,
				577,
				587
			},
			new int[]
			{
				593,
				599,
				601
			},
			new int[]
			{
				607,
				613,
				617
			},
			new int[]
			{
				619,
				631,
				641
			},
			new int[]
			{
				643,
				647,
				653
			},
			new int[]
			{
				659,
				661,
				673
			},
			new int[]
			{
				677,
				683,
				691
			},
			new int[]
			{
				701,
				709,
				719
			},
			new int[]
			{
				727,
				733,
				739
			},
			new int[]
			{
				743,
				751,
				757
			},
			new int[]
			{
				761,
				769,
				773
			},
			new int[]
			{
				787,
				797,
				809
			},
			new int[]
			{
				811,
				821,
				823
			},
			new int[]
			{
				827,
				829,
				839
			},
			new int[]
			{
				853,
				857,
				859
			},
			new int[]
			{
				863,
				877,
				881
			},
			new int[]
			{
				883,
				887,
				907
			},
			new int[]
			{
				911,
				919,
				929
			},
			new int[]
			{
				937,
				941,
				947
			},
			new int[]
			{
				953,
				967,
				971
			},
			new int[]
			{
				977,
				983,
				991
			},
			new int[]
			{
				997,
				1009,
				1013
			},
			new int[]
			{
				1019,
				1021,
				1031
			},
			new int[]
			{
				1033,
				1039,
				1049
			},
			new int[]
			{
				1051,
				1061,
				1063
			},
			new int[]
			{
				1069,
				1087,
				1091
			},
			new int[]
			{
				1093,
				1097,
				1103
			},
			new int[]
			{
				1109,
				1117,
				1123
			},
			new int[]
			{
				1129,
				1151,
				1153
			},
			new int[]
			{
				1163,
				1171,
				1181
			},
			new int[]
			{
				1187,
				1193,
				1201
			},
			new int[]
			{
				1213,
				1217,
				1223
			},
			new int[]
			{
				1229,
				1231,
				1237
			},
			new int[]
			{
				1249,
				1259,
				1277
			},
			new int[]
			{
				1279,
				1283,
				1289
			}
		};

		// Token: 0x04000902 RID: 2306
		internal static readonly int[] primeProducts;

		// Token: 0x04000903 RID: 2307
		private const long IMASK = 4294967295L;

		// Token: 0x04000904 RID: 2308
		private const ulong UIMASK = 4294967295UL;

		// Token: 0x04000905 RID: 2309
		private static readonly int[] ZeroMagnitude = new int[0];

		// Token: 0x04000906 RID: 2310
		private static readonly byte[] ZeroEncoding = new byte[0];

		// Token: 0x04000907 RID: 2311
		private static readonly global::Org.BouncyCastle.Math.BigInteger[] SMALL_CONSTANTS = new global::Org.BouncyCastle.Math.BigInteger[17];

		// Token: 0x04000908 RID: 2312
		public static readonly global::Org.BouncyCastle.Math.BigInteger Zero;

		// Token: 0x04000909 RID: 2313
		public static readonly global::Org.BouncyCastle.Math.BigInteger One;

		// Token: 0x0400090A RID: 2314
		public static readonly global::Org.BouncyCastle.Math.BigInteger Two;

		// Token: 0x0400090B RID: 2315
		public static readonly global::Org.BouncyCastle.Math.BigInteger Three;

		// Token: 0x0400090C RID: 2316
		public static readonly global::Org.BouncyCastle.Math.BigInteger Four;

		// Token: 0x0400090D RID: 2317
		public static readonly global::Org.BouncyCastle.Math.BigInteger Ten;

		// Token: 0x0400090E RID: 2318
		private static readonly byte[] BitLengthTable = new byte[]
		{
			0,
			1,
			2,
			2,
			3,
			3,
			3,
			3,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			5,
			5,
			5,
			5,
			5,
			5,
			5,
			5,
			5,
			5,
			5,
			5,
			5,
			5,
			5,
			5,
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
			6,
			6,
			6,
			6,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			7,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8
		};

		// Token: 0x0400090F RID: 2319
		private const int chunk2 = 1;

		// Token: 0x04000910 RID: 2320
		private const int chunk8 = 1;

		// Token: 0x04000911 RID: 2321
		private const int chunk10 = 19;

		// Token: 0x04000912 RID: 2322
		private const int chunk16 = 16;

		// Token: 0x04000913 RID: 2323
		private static readonly global::Org.BouncyCastle.Math.BigInteger radix2;

		// Token: 0x04000914 RID: 2324
		private static readonly global::Org.BouncyCastle.Math.BigInteger radix2E;

		// Token: 0x04000915 RID: 2325
		private static readonly global::Org.BouncyCastle.Math.BigInteger radix8;

		// Token: 0x04000916 RID: 2326
		private static readonly global::Org.BouncyCastle.Math.BigInteger radix8E;

		// Token: 0x04000917 RID: 2327
		private static readonly global::Org.BouncyCastle.Math.BigInteger radix10;

		// Token: 0x04000918 RID: 2328
		private static readonly global::Org.BouncyCastle.Math.BigInteger radix10E;

		// Token: 0x04000919 RID: 2329
		private static readonly global::Org.BouncyCastle.Math.BigInteger radix16;

		// Token: 0x0400091A RID: 2330
		private static readonly global::Org.BouncyCastle.Math.BigInteger radix16E;

		// Token: 0x0400091B RID: 2331
		private static readonly global::Org.BouncyCastle.Security.SecureRandom RandomSource = new global::Org.BouncyCastle.Security.SecureRandom();

		// Token: 0x0400091C RID: 2332
		private static readonly int[] ExpWindowThresholds = new int[]
		{
			7,
			25,
			81,
			241,
			673,
			1793,
			4609,
			int.MaxValue
		};

		// Token: 0x0400091D RID: 2333
		private const int BitsPerByte = 8;

		// Token: 0x0400091E RID: 2334
		private const int BitsPerInt = 32;

		// Token: 0x0400091F RID: 2335
		private const int BytesPerInt = 4;

		// Token: 0x04000920 RID: 2336
		private int[] magnitude;

		// Token: 0x04000921 RID: 2337
		private int sign;

		// Token: 0x04000922 RID: 2338
		private int nBits = -1;

		// Token: 0x04000923 RID: 2339
		private int nBitLength = -1;

		// Token: 0x04000924 RID: 2340
		private int mQuote;
	}
}
