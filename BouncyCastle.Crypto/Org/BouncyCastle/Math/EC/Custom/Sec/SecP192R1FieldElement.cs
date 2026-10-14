using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000257 RID: 599
	internal class SecP192R1FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x0600188B RID: 6283 RVA: 0x00075575 File Offset: 0x00073775
		public SecP192R1FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for SecP192R1FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.FromBigInteger(x);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x000755B3 File Offset: 0x000737B3
		public SecP192R1FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x000755C6 File Offset: 0x000737C6
		protected internal SecP192R1FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x000755D5 File Offset: 0x000737D5
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat192.IsZero(this.x);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x000755E2 File Offset: 0x000737E2
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat192.IsOne(this.x);
			}
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x000755EF File Offset: 0x000737EF
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat192.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00075600 File Offset: 0x00073800
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat192.ToBigInteger(this.x);
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x0007560D File Offset: 0x0007380D
		public override string FieldName
		{
			get
			{
				return "SecP192R1Field";
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x00075614 File Offset: 0x00073814
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement.Q.BitLength;
			}
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00075620 File Offset: 0x00073820
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(z);
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00075650 File Offset: 0x00073850
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(z);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00075678 File Offset: 0x00073878
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(z);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x000756A8 File Offset: 0x000738A8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(z);
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x000756D8 File Offset: 0x000738D8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(z);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00075710 File Offset: 0x00073910
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(z);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00075738 File Offset: 0x00073938
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(z);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00075760 File Offset: 0x00073960
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(z);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00075788 File Offset: 0x00073988
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] x = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat192.IsZero(x) || global::Org.BouncyCastle.Math.Raw.Nat192.IsOne(x))
			{
				return this;
			}
			uint[] t = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			uint[] t2 = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Square(x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.SquareN(t, 2, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Multiply(t2, t, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.SquareN(t2, 4, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Multiply(t, t2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.SquareN(t, 8, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Multiply(t2, t, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.SquareN(t2, 16, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Multiply(t, t2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.SquareN(t, 32, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Multiply(t2, t, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.SquareN(t2, 64, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Multiply(t, t2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.SquareN(t, 62, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Square(t, t2);
			if (!global::Org.BouncyCastle.Math.Raw.Nat192.Eq(x, t2))
			{
				return null;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(t);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0007584D File Offset: 0x00073A4D
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0007585B File Offset: 0x00073A5B
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00075869 File Offset: 0x00073A69
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat192.Eq(this.x, other.x));
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00075887 File Offset: 0x00073A87
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 6);
		}

		// Token: 0x04000A3E RID: 2622
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFF"));

		// Token: 0x04000A3F RID: 2623
		protected internal readonly uint[] x;
	}
}
