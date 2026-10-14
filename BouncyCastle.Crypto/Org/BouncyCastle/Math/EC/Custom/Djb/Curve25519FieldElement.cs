using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
	// Token: 0x020002AD RID: 685
	internal class Curve25519FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x06001E8A RID: 7818 RVA: 0x0008D56E File Offset: 0x0008B76E
		public Curve25519FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for Curve25519FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.FromBigInteger(x);
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0008D5AC File Offset: 0x0008B7AC
		public Curve25519FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x0008D5BF File Offset: 0x0008B7BF
		protected internal Curve25519FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x0008D5CE File Offset: 0x0008B7CE
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsZero(this.x);
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x0008D5DB File Offset: 0x0008B7DB
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsOne(this.x);
			}
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0008D5E8 File Offset: 0x0008B7E8
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat256.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0008D5F9 File Offset: 0x0008B7F9
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat256.ToBigInteger(this.x);
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x0008D606 File Offset: 0x0008B806
		public override string FieldName
		{
			get
			{
				return "Curve25519Field";
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x0008D60D File Offset: 0x0008B80D
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.Q.BitLength;
			}
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x0008D61C File Offset: 0x0008B81C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(z);
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x0008D64C File Offset: 0x0008B84C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(z);
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x0008D674 File Offset: 0x0008B874
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(z);
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x0008D6A4 File Offset: 0x0008B8A4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(z);
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x0008D6D4 File Offset: 0x0008B8D4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(z);
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x0008D70C File Offset: 0x0008B90C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(z);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x0008D734 File Offset: 0x0008B934
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(z);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0008D75C File Offset: 0x0008B95C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(z);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x0008D784 File Offset: 0x0008B984
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] x = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat256.IsZero(x) || global::Org.BouncyCastle.Math.Raw.Nat256.IsOne(x))
			{
				return this;
			}
			uint[] x2 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x, x2);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x2, x, x2);
			uint[] x3 = x2;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x2, x3);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x3, x, x3);
			uint[] x4 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(x3, x4);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x4, x, x4);
			uint[] x5 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x4, 3, x5);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x5, x3, x5);
			uint[] x6 = x3;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x5, 4, x6);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x6, x4, x6);
			uint[] x7 = x5;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x6, 4, x7);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x7, x4, x7);
			uint[] x8 = x4;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x7, 15, x8);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x8, x7, x8);
			uint[] x9 = x7;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x8, 30, x9);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x9, x8, x9);
			uint[] x10 = x8;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x9, 60, x10);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x10, x9, x10);
			uint[] x11 = x9;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x10, 11, x11);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x11, x6, x11);
			uint[] x12 = x6;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SquareN(x11, 120, x12);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(x12, x10, x12);
			uint[] t = x12;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(t, t);
			uint[] t2 = x10;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(t, t2);
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Eq(x, t2))
			{
				return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(t);
			}
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(t, global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.PRECOMP_POW2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(t, t2);
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Eq(x, t2))
			{
				return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(t);
			}
			return null;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x0008D905 File Offset: 0x0008BB05
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0008D913 File Offset: 0x0008BB13
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement);
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0008D921 File Offset: 0x0008BB21
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat256.Eq(this.x, other.x));
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0008D93F File Offset: 0x0008BB3F
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 8);
		}

		// Token: 0x04000B05 RID: 2821
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = global::Org.BouncyCastle.Math.Raw.Nat256.ToBigInteger(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P);

		// Token: 0x04000B06 RID: 2822
		private static readonly uint[] PRECOMP_POW2 = new uint[]
		{
			1242472624U,
			3303938855U,
			2905597048U,
			792926214U,
			1039914919U,
			726466713U,
			1338105611U,
			730014848U
		};

		// Token: 0x04000B07 RID: 2823
		protected internal readonly uint[] x;
	}
}
