using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.GM
{
	// Token: 0x020002A9 RID: 681
	internal class SM2P256V1FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x06001E44 RID: 7748 RVA: 0x0008C517 File Offset: 0x0008A717
		public SM2P256V1FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for SM2P256V1FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.FromBigInteger(x);
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0008C555 File Offset: 0x0008A755
		public SM2P256V1FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0008C568 File Offset: 0x0008A768
		protected internal SM2P256V1FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x0008C577 File Offset: 0x0008A777
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsZero(this.x);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x0008C584 File Offset: 0x0008A784
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsOne(this.x);
			}
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x0008C591 File Offset: 0x0008A791
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat256.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x0008C5A2 File Offset: 0x0008A7A2
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat256.ToBigInteger(this.x);
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x0008C5AF File Offset: 0x0008A7AF
		public override string FieldName
		{
			get
			{
				return "SM2P256V1Field";
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x0008C5B6 File Offset: 0x0008A7B6
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement.Q.BitLength;
			}
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x0008C5C4 File Offset: 0x0008A7C4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(z);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x0008C5F4 File Offset: 0x0008A7F4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(z);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x0008C61C File Offset: 0x0008A81C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(z);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x0008C64C File Offset: 0x0008A84C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(z);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x0008C67C File Offset: 0x0008A87C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(z);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x0008C6B4 File Offset: 0x0008A8B4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(z);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0008C6DC File Offset: 0x0008A8DC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(z);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x0008C704 File Offset: 0x0008A904
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(z);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0008C72C File Offset: 0x0008A92C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] x = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat256.IsZero(x) || global::Org.BouncyCastle.Math.Raw.Nat256.IsOne(x))
			{
				return this;
			}
			uint[] x2 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Square(x, x2);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(x2, x, x2);
			uint[] x3 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.SquareN(x2, 2, x3);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(x3, x2, x3);
			uint[] x4 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.SquareN(x3, 2, x4);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(x4, x2, x4);
			uint[] x5 = x2;
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.SquareN(x4, 6, x5);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(x5, x4, x5);
			uint[] x6 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.SquareN(x5, 12, x6);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(x6, x5, x6);
			uint[] x7 = x5;
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.SquareN(x6, 6, x7);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(x7, x4, x7);
			uint[] x8 = x4;
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Square(x7, x8);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(x8, x, x8);
			uint[] t = x6;
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.SquareN(x8, 31, t);
			uint[] x9 = x7;
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(t, x8, x9);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.SquareN(t, 32, t);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(t, x9, t);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.SquareN(t, 62, t);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(t, x9, t);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.SquareN(t, 4, t);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(t, x3, t);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.SquareN(t, 32, t);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.SquareN(t, 62, t);
			uint[] t2 = x3;
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Square(t, t2);
			if (!global::Org.BouncyCastle.Math.Raw.Nat256.Eq(x, t2))
			{
				return null;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(t);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0008C891 File Offset: 0x0008AA91
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0008C89F File Offset: 0x0008AA9F
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0008C8AD File Offset: 0x0008AAAD
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat256.Eq(this.x, other.x));
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0008C8CB File Offset: 0x0008AACB
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 8);
		}

		// Token: 0x04000AF8 RID: 2808
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000FFFFFFFFFFFFFFFF"));

		// Token: 0x04000AF9 RID: 2809
		protected internal readonly uint[] x;
	}
}
