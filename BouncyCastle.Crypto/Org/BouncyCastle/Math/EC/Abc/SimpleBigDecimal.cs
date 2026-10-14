using System;
using System.Text;

namespace Org.BouncyCastle.Math.EC.Abc
{
	// Token: 0x020002AF RID: 687
	internal class SimpleBigDecimal
	{
		// Token: 0x06001EAE RID: 7854 RVA: 0x0008E040 File Offset: 0x0008C240
		public static global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal GetInstance(global::Org.BouncyCastle.Math.BigInteger val, int scale)
		{
			return new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(val.ShiftLeft(scale), scale);
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x0008E04F File Offset: 0x0008C24F
		public SimpleBigDecimal(global::Org.BouncyCastle.Math.BigInteger bigInt, int scale)
		{
			if (scale < 0)
			{
				throw new global::System.ArgumentException("scale may not be negative");
			}
			this.bigInt = bigInt;
			this.scale = scale;
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x0008E074 File Offset: 0x0008C274
		private SimpleBigDecimal(global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal limBigDec)
		{
			this.bigInt = limBigDec.bigInt;
			this.scale = limBigDec.scale;
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x0008E094 File Offset: 0x0008C294
		private void CheckScale(global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal b)
		{
			if (this.scale != b.scale)
			{
				throw new global::System.ArgumentException("Only SimpleBigDecimal of same scale allowed in arithmetic operations");
			}
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x0008E0AF File Offset: 0x0008C2AF
		public global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal AdjustScale(int newScale)
		{
			if (newScale < 0)
			{
				throw new global::System.ArgumentException("scale may not be negative");
			}
			if (newScale == this.scale)
			{
				return this;
			}
			return new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(this.bigInt.ShiftLeft(newScale - this.scale), newScale);
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x0008E0E4 File Offset: 0x0008C2E4
		public global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Add(global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal b)
		{
			this.CheckScale(b);
			return new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(this.bigInt.Add(b.bigInt), this.scale);
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0008E109 File Offset: 0x0008C309
		public global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Add(global::Org.BouncyCastle.Math.BigInteger b)
		{
			return new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(this.bigInt.Add(b.ShiftLeft(this.scale)), this.scale);
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x0008E12D File Offset: 0x0008C32D
		public global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Negate()
		{
			return new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(this.bigInt.Negate(), this.scale);
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x0008E145 File Offset: 0x0008C345
		public global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Subtract(global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal b)
		{
			return this.Add(b.Negate());
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x0008E153 File Offset: 0x0008C353
		public global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Subtract(global::Org.BouncyCastle.Math.BigInteger b)
		{
			return new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(this.bigInt.Subtract(b.ShiftLeft(this.scale)), this.scale);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x0008E177 File Offset: 0x0008C377
		public global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Multiply(global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal b)
		{
			this.CheckScale(b);
			return new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(this.bigInt.Multiply(b.bigInt), this.scale + this.scale);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x0008E1A3 File Offset: 0x0008C3A3
		public global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Multiply(global::Org.BouncyCastle.Math.BigInteger b)
		{
			return new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(this.bigInt.Multiply(b), this.scale);
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x0008E1BC File Offset: 0x0008C3BC
		public global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Divide(global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal b)
		{
			this.CheckScale(b);
			return new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(this.bigInt.ShiftLeft(this.scale).Divide(b.bigInt), this.scale);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x0008E1EC File Offset: 0x0008C3EC
		public global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Divide(global::Org.BouncyCastle.Math.BigInteger b)
		{
			return new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(this.bigInt.Divide(b), this.scale);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x0008E205 File Offset: 0x0008C405
		public global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal ShiftLeft(int n)
		{
			return new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(this.bigInt.ShiftLeft(n), this.scale);
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x0008E21E File Offset: 0x0008C41E
		public int CompareTo(global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal val)
		{
			this.CheckScale(val);
			return this.bigInt.CompareTo(val.bigInt);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x0008E238 File Offset: 0x0008C438
		public int CompareTo(global::Org.BouncyCastle.Math.BigInteger val)
		{
			return this.bigInt.CompareTo(val.ShiftLeft(this.scale));
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x0008E251 File Offset: 0x0008C451
		public global::Org.BouncyCastle.Math.BigInteger Floor()
		{
			return this.bigInt.ShiftRight(this.scale);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x0008E264 File Offset: 0x0008C464
		public global::Org.BouncyCastle.Math.BigInteger Round()
		{
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal oneHalf = new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(global::Org.BouncyCastle.Math.BigInteger.One, 1);
			return this.Add(oneHalf.AdjustScale(this.scale)).Floor();
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x0008E294 File Offset: 0x0008C494
		public int IntValue
		{
			get
			{
				return this.Floor().IntValue;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x0008E2A1 File Offset: 0x0008C4A1
		public long LongValue
		{
			get
			{
				return this.Floor().LongValue;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x0008E2AE File Offset: 0x0008C4AE
		public int Scale
		{
			get
			{
				return this.scale;
			}
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0008E2B8 File Offset: 0x0008C4B8
		public override string ToString()
		{
			if (this.scale == 0)
			{
				return this.bigInt.ToString();
			}
			global::Org.BouncyCastle.Math.BigInteger floorBigInt = this.Floor();
			global::Org.BouncyCastle.Math.BigInteger fract = this.bigInt.Subtract(floorBigInt.ShiftLeft(this.scale));
			if (this.bigInt.SignValue < 0)
			{
				fract = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(this.scale).Subtract(fract);
			}
			if (floorBigInt.SignValue == -1 && !fract.Equals(global::Org.BouncyCastle.Math.BigInteger.Zero))
			{
				floorBigInt = floorBigInt.Add(global::Org.BouncyCastle.Math.BigInteger.One);
			}
			string leftOfPoint = floorBigInt.ToString();
			char[] fractCharArr = new char[this.scale];
			string fractStr = fract.ToString(2);
			int fractLen = fractStr.Length;
			int zeroes = this.scale - fractLen;
			for (int i = 0; i < zeroes; i++)
			{
				fractCharArr[i] = '0';
			}
			for (int j = 0; j < fractLen; j++)
			{
				fractCharArr[zeroes + j] = fractStr[j];
			}
			string rightOfPoint = new string(fractCharArr);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(leftOfPoint);
			stringBuilder.Append(".");
			stringBuilder.Append(rightOfPoint);
			return stringBuilder.ToString();
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x0008E3D0 File Offset: 0x0008C5D0
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal other = obj as global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal;
			return other != null && this.bigInt.Equals(other.bigInt) && this.scale == other.scale;
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x0008E412 File Offset: 0x0008C612
		public override int GetHashCode()
		{
			return this.bigInt.GetHashCode() ^ this.scale;
		}

		// Token: 0x04000B08 RID: 2824
		private readonly global::Org.BouncyCastle.Math.BigInteger bigInt;

		// Token: 0x04000B09 RID: 2825
		private readonly int scale;
	}
}
