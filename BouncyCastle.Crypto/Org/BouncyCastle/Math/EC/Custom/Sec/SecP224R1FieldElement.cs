using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200025F RID: 607
	internal class SecP224R1FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x06001911 RID: 6417 RVA: 0x000775B9 File Offset: 0x000757B9
		public SecP224R1FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for SecP224R1FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.FromBigInteger(x);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x000775F7 File Offset: 0x000757F7
		public SecP224R1FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0007760A File Offset: 0x0007580A
		protected internal SecP224R1FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x00077619 File Offset: 0x00075819
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat224.IsZero(this.x);
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x00077626 File Offset: 0x00075826
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat224.IsOne(this.x);
			}
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00077633 File Offset: 0x00075833
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat224.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00077644 File Offset: 0x00075844
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat224.ToBigInteger(this.x);
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x00077651 File Offset: 0x00075851
		public override string FieldName
		{
			get
			{
				return "SecP224R1Field";
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x00077658 File Offset: 0x00075858
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.Q.BitLength;
			}
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00077664 File Offset: 0x00075864
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(z);
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00077694 File Offset: 0x00075894
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(z);
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x000776BC File Offset: 0x000758BC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(z);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000776EC File Offset: 0x000758EC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(z);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0007771C File Offset: 0x0007591C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(z);
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00077754 File Offset: 0x00075954
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(z);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0007777C File Offset: 0x0007597C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(z);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000777A4 File Offset: 0x000759A4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(z);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000777CC File Offset: 0x000759CC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] c = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat224.IsZero(c) || global::Org.BouncyCastle.Math.Raw.Nat224.IsOne(c))
			{
				return this;
			}
			uint[] nc = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Negate(c, nc);
			uint[] r = global::Org.BouncyCastle.Math.Raw.Mod.Random(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P);
			uint[] t = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			if (!global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.IsSquare(c))
			{
				return null;
			}
			while (!global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.TrySqrt(nc, r, t))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddOne(r, r);
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(t, r);
			if (!global::Org.BouncyCastle.Math.Raw.Nat224.Eq(c, r))
			{
				return null;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(t);
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00077843 File Offset: 0x00075A43
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement);
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00077851 File Offset: 0x00075A51
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x0007785F File Offset: 0x00075A5F
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat224.Eq(this.x, other.x));
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x0007787D File Offset: 0x00075A7D
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 7);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00077898 File Offset: 0x00075A98
		private static bool IsSquare(uint[] x)
		{
			uint[] t = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			uint[] t2 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.Raw.Nat224.Copy(x, t);
			for (int i = 0; i < 7; i++)
			{
				global::Org.BouncyCastle.Math.Raw.Nat224.Copy(t, t2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.SquareN(t, 1 << i, t);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(t, t2, t);
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.SquareN(t, 95, t);
			return global::Org.BouncyCastle.Math.Raw.Nat224.IsOne(t);
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x000778F0 File Offset: 0x00075AF0
		private static void RM(uint[] nc, uint[] d0, uint[] e0, uint[] d1, uint[] e1, uint[] f1, uint[] t)
		{
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(e1, e0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(t, nc, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(d1, d0, f1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Add(f1, t, f1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(d1, e0, t);
			global::Org.BouncyCastle.Math.Raw.Nat224.Copy(f1, d1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(e1, d0, e1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Add(e1, t, e1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(e1, f1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(f1, nc, f1);
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00077960 File Offset: 0x00075B60
		private static void RP(uint[] nc, uint[] d1, uint[] e1, uint[] f1, uint[] t)
		{
			global::Org.BouncyCastle.Math.Raw.Nat224.Copy(nc, f1);
			uint[] d2 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			uint[] e2 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			for (int i = 0; i < 7; i++)
			{
				global::Org.BouncyCastle.Math.Raw.Nat224.Copy(d1, d2);
				global::Org.BouncyCastle.Math.Raw.Nat224.Copy(e1, e2);
				int j = 1 << i;
				while (--j >= 0)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.RS(d1, e1, f1, t);
				}
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.RM(nc, d2, e2, d1, e1, f1, t);
			}
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x000779C2 File Offset: 0x00075BC2
		private static void RS(uint[] d, uint[] e, uint[] f, uint[] t)
		{
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(e, d, e);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Twice(e, e);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Square(d, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Add(f, t, d);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(f, t, f);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(7, f, 2, 0U), f);
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x000779FC File Offset: 0x00075BFC
		private static bool TrySqrt(uint[] nc, uint[] r, uint[] t)
		{
			uint[] d = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.Raw.Nat224.Copy(r, d);
			uint[] e = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			e[0] = 1U;
			uint[] f = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.RP(nc, d, e, f, t);
			uint[] d2 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			uint[] e2 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			for (int i = 1; i < 96; i++)
			{
				global::Org.BouncyCastle.Math.Raw.Nat224.Copy(d, d2);
				global::Org.BouncyCastle.Math.Raw.Nat224.Copy(e, e2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.RS(d, e, f, t);
				if (global::Org.BouncyCastle.Math.Raw.Nat224.IsZero(d))
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Inv(e2, t);
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Multiply(t, d2, t);
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000A58 RID: 2648
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF000000000000000000000001"));

		// Token: 0x04000A59 RID: 2649
		protected internal readonly uint[] x;
	}
}
