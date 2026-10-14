using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000245 RID: 581
	internal class SecP128R1FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x0600176B RID: 5995 RVA: 0x00070FE3 File Offset: 0x0006F1E3
		public SecP128R1FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for SecP128R1FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.FromBigInteger(x);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00071021 File Offset: 0x0006F221
		public SecP128R1FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00071034 File Offset: 0x0006F234
		protected internal SecP128R1FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x00071043 File Offset: 0x0006F243
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat128.IsZero(this.x);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600176F RID: 5999 RVA: 0x00071050 File Offset: 0x0006F250
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat128.IsOne(this.x);
			}
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0007105D File Offset: 0x0006F25D
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat128.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0007106E File Offset: 0x0006F26E
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat128.ToBigInteger(this.x);
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x0007107B File Offset: 0x0006F27B
		public override string FieldName
		{
			get
			{
				return "SecP128R1Field";
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x00071082 File Offset: 0x0006F282
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement.Q.BitLength;
			}
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00071090 File Offset: 0x0006F290
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(z);
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x000710C0 File Offset: 0x0006F2C0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(z);
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x000710E8 File Offset: 0x0006F2E8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(z);
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00071118 File Offset: 0x0006F318
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(z);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00071148 File Offset: 0x0006F348
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(z);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00071180 File Offset: 0x0006F380
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(z);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x000711A8 File Offset: 0x0006F3A8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(z);
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x000711D0 File Offset: 0x0006F3D0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(z);
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x000711F8 File Offset: 0x0006F3F8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] x = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat128.IsZero(x) || global::Org.BouncyCastle.Math.Raw.Nat128.IsOne(x))
			{
				return this;
			}
			uint[] x2 = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Square(x, x2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(x2, x, x2);
			uint[] x3 = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.SquareN(x2, 2, x3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(x3, x2, x3);
			uint[] x4 = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.SquareN(x3, 4, x4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(x4, x3, x4);
			uint[] x5 = x3;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.SquareN(x4, 2, x5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(x5, x2, x5);
			uint[] x6 = x2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.SquareN(x5, 10, x6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(x6, x5, x6);
			uint[] x7 = x4;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.SquareN(x6, 10, x7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(x7, x5, x7);
			uint[] x8 = x5;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Square(x7, x8);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(x8, x, x8);
			uint[] t = x8;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.SquareN(t, 95, t);
			uint[] t2 = x7;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Square(t, t2);
			if (!global::Org.BouncyCastle.Math.Raw.Nat128.Eq(x, t2))
			{
				return null;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(t);
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x000712ED File Offset: 0x0006F4ED
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement);
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x000712FB File Offset: 0x0006F4FB
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement);
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00071309 File Offset: 0x0006F509
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat128.Eq(this.x, other.x));
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00071327 File Offset: 0x0006F527
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 4);
		}

		// Token: 0x04000A06 RID: 2566
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFDFFFFFFFFFFFFFFFFFFFFFFFF"));

		// Token: 0x04000A07 RID: 2567
		protected internal readonly uint[] x;
	}
}
