using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200026F RID: 623
	internal class SecP521R1FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x06001A20 RID: 6688 RVA: 0x0007B8C1 File Offset: 0x00079AC1
		public SecP521R1FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for SecP521R1FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.FromBigInteger(x);
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x0007B8FF File Offset: 0x00079AFF
		public SecP521R1FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0007B914 File Offset: 0x00079B14
		protected internal SecP521R1FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x0007B923 File Offset: 0x00079B23
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IsZero(17, this.x);
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x0007B932 File Offset: 0x00079B32
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IsOne(17, this.x);
			}
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0007B941 File Offset: 0x00079B41
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x0007B952 File Offset: 0x00079B52
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.ToBigInteger(17, this.x);
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x0007B961 File Offset: 0x00079B61
		public override string FieldName
		{
			get
			{
				return "SecP521R1Field";
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x0007B968 File Offset: 0x00079B68
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement.Q.BitLength;
			}
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x0007B974 File Offset: 0x00079B74
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(z);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0007B9A8 File Offset: 0x00079BA8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(z);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0007B9D0 File Offset: 0x00079BD0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(z);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0007BA04 File Offset: 0x00079C04
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(z);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0007BA38 File Offset: 0x00079C38
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(z);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0007BA74 File Offset: 0x00079C74
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(z);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0007BA9C File Offset: 0x00079C9C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(z);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0007BAC4 File Offset: 0x00079CC4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(z);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0007BAEC File Offset: 0x00079CEC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] x = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat.IsZero(17, x) || global::Org.BouncyCastle.Math.Raw.Nat.IsOne(17, x))
			{
				return this;
			}
			uint[] t = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			uint[] t2 = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.SquareN(x, 519, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Square(t, t2);
			if (!global::Org.BouncyCastle.Math.Raw.Nat.Eq(17, x, t2))
			{
				return null;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(t);
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x0007BB4C File Offset: 0x00079D4C
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement);
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0007BB5A File Offset: 0x00079D5A
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0007BB68 File Offset: 0x00079D68
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat.Eq(17, this.x, other.x));
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0007BB88 File Offset: 0x00079D88
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 17);
		}

		// Token: 0x04000A85 RID: 2693
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"));

		// Token: 0x04000A86 RID: 2694
		protected internal readonly uint[] x;
	}
}
