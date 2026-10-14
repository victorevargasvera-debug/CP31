using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000267 RID: 615
	internal class SecP256R1FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x0600199C RID: 6556 RVA: 0x0007977F File Offset: 0x0007797F
		public SecP256R1FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for SecP256R1FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.FromBigInteger(x);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x000797BD File Offset: 0x000779BD
		public SecP256R1FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000797D0 File Offset: 0x000779D0
		protected internal SecP256R1FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x000797DF File Offset: 0x000779DF
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsZero(this.x);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x000797EC File Offset: 0x000779EC
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsOne(this.x);
			}
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x000797F9 File Offset: 0x000779F9
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat256.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x0007980A File Offset: 0x00077A0A
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat256.ToBigInteger(this.x);
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x00079817 File Offset: 0x00077A17
		public override string FieldName
		{
			get
			{
				return "SecP256R1Field";
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x0007981E File Offset: 0x00077A1E
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement.Q.BitLength;
			}
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0007982C File Offset: 0x00077A2C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(z);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0007985C File Offset: 0x00077A5C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(z);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00079884 File Offset: 0x00077A84
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(z);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x000798B4 File Offset: 0x00077AB4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(z);
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x000798E4 File Offset: 0x00077AE4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(z);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0007991C File Offset: 0x00077B1C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(z);
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00079944 File Offset: 0x00077B44
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(z);
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0007996C File Offset: 0x00077B6C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(z);
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00079994 File Offset: 0x00077B94
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] x = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat256.IsZero(x) || global::Org.BouncyCastle.Math.Raw.Nat256.IsOne(x))
			{
				return this;
			}
			uint[] t = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			uint[] t2 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Square(x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(t, 2, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(t2, t, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(t2, 4, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(t, t2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(t, 8, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(t2, t, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(t2, 16, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(t, t2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(t, 32, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(t, 96, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SquareN(t, 94, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Multiply(t, t, t2);
			if (!global::Org.BouncyCastle.Math.Raw.Nat256.Eq(x, t2))
			{
				return null;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(t);
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00079A5A File Offset: 0x00077C5A
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00079A68 File Offset: 0x00077C68
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00079A76 File Offset: 0x00077C76
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat256.Eq(this.x, other.x));
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00079A94 File Offset: 0x00077C94
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 8);
		}

		// Token: 0x04000A70 RID: 2672
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFF00000001000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFF"));

		// Token: 0x04000A71 RID: 2673
		protected internal readonly uint[] x;
	}
}
