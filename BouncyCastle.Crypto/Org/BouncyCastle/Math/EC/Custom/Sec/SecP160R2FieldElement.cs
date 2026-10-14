using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200024F RID: 591
	internal class SecP160R2FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x06001805 RID: 6149 RVA: 0x00073518 File Offset: 0x00071718
		public SecP160R2FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for SecP160R2FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.FromBigInteger(x);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00073556 File Offset: 0x00071756
		public SecP160R2FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00073569 File Offset: 0x00071769
		protected internal SecP160R2FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x00073578 File Offset: 0x00071778
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat160.IsZero(this.x);
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x00073585 File Offset: 0x00071785
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat160.IsOne(this.x);
			}
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00073592 File Offset: 0x00071792
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat160.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x000735A3 File Offset: 0x000717A3
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat160.ToBigInteger(this.x);
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x000735B0 File Offset: 0x000717B0
		public override string FieldName
		{
			get
			{
				return "SecP160R2Field";
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x000735B7 File Offset: 0x000717B7
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement.Q.BitLength;
			}
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000735C4 File Offset: 0x000717C4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(z);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x000735F4 File Offset: 0x000717F4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(z);
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0007361C File Offset: 0x0007181C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(z);
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x0007364C File Offset: 0x0007184C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(z);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0007367C File Offset: 0x0007187C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(z);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x000736B4 File Offset: 0x000718B4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(z);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x000736DC File Offset: 0x000718DC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(z);
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00073704 File Offset: 0x00071904
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(z);
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x0007372C File Offset: 0x0007192C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] x = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat160.IsZero(x) || global::Org.BouncyCastle.Math.Raw.Nat160.IsOne(x))
			{
				return this;
			}
			uint[] x2 = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Square(x, x2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x2, x, x2);
			uint[] x3 = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Square(x2, x3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x3, x, x3);
			uint[] x4 = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Square(x3, x4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x4, x, x4);
			uint[] x5 = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x4, 3, x5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x5, x3, x5);
			uint[] x6 = x4;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x5, 7, x6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x6, x5, x6);
			uint[] x7 = x5;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x6, 3, x7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x7, x3, x7);
			uint[] x8 = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x7, 14, x8);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x8, x6, x8);
			uint[] x9 = x6;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x8, 31, x9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x9, x8, x9);
			uint[] x10 = x8;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x9, 62, x10);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x10, x9, x10);
			uint[] x11 = x9;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(x10, 3, x11);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(x11, x3, x11);
			uint[] t = x11;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(t, 18, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(t, x7, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(t, 2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(t, 3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(t, x2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(t, 6, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(t, x3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.SquareN(t, 2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Multiply(t, x, t);
			uint[] t2 = x2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Square(t, t2);
			if (!global::Org.BouncyCastle.Math.Raw.Nat160.Eq(x, t2))
			{
				return null;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(t);
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x000738CD File Offset: 0x00071ACD
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement);
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x000738DB File Offset: 0x00071ADB
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement);
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x000738E9 File Offset: 0x00071AE9
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat160.Eq(this.x, other.x));
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00073907 File Offset: 0x00071B07
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 5);
		}

		// Token: 0x04000A25 RID: 2597
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFAC73"));

		// Token: 0x04000A26 RID: 2598
		protected internal readonly uint[] x;
	}
}
