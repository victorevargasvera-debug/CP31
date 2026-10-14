using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200025B RID: 603
	internal class SecP224K1FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x060018CD RID: 6349 RVA: 0x000763FD File Offset: 0x000745FD
		public SecP224K1FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for SecP224K1FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.FromBigInteger(x);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0007643B File Offset: 0x0007463B
		public SecP224K1FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0007644E File Offset: 0x0007464E
		protected internal SecP224K1FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0007645D File Offset: 0x0007465D
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat224.IsZero(this.x);
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x0007646A File Offset: 0x0007466A
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat224.IsOne(this.x);
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00076477 File Offset: 0x00074677
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat224.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00076488 File Offset: 0x00074688
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat224.ToBigInteger(this.x);
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x00076495 File Offset: 0x00074695
		public override string FieldName
		{
			get
			{
				return "SecP224K1Field";
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x0007649C File Offset: 0x0007469C
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.Q.BitLength;
			}
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x000764A8 File Offset: 0x000746A8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(z);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x000764D8 File Offset: 0x000746D8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(z);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00076500 File Offset: 0x00074700
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(z);
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00076530 File Offset: 0x00074730
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(z);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00076560 File Offset: 0x00074760
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(z);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00076598 File Offset: 0x00074798
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(z);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000765C0 File Offset: 0x000747C0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(z);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x000765E8 File Offset: 0x000747E8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(z);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00076610 File Offset: 0x00074810
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] x = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat224.IsZero(x) || global::Org.BouncyCastle.Math.Raw.Nat224.IsOne(x))
			{
				return this;
			}
			uint[] x2 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(x, x2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x2, x, x2);
			uint[] x3 = x2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(x2, x3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x3, x, x3);
			uint[] x4 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(x3, x4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x4, x, x4);
			uint[] x5 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x4, 4, x5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x5, x4, x5);
			uint[] x6 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x5, 3, x6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x6, x3, x6);
			uint[] x7 = x6;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x6, 8, x7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x7, x5, x7);
			uint[] x8 = x5;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x7, 4, x8);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x8, x4, x8);
			uint[] x9 = x4;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x8, 19, x9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x9, x7, x9);
			uint[] x10 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x9, 42, x10);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x10, x9, x10);
			uint[] x11 = x9;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x10, 23, x11);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x11, x8, x11);
			uint[] x12 = x8;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(x11, 84, x12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(x12, x10, x12);
			uint[] t = x12;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(t, 20, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(t, x7, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(t, 3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(t, 2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.SquareN(t, 4, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(t, x3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(t, t);
			uint[] t2 = x10;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(t, t2);
			if (global::Org.BouncyCastle.Math.Raw.Nat224.Eq(x, t2))
			{
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(t);
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(t, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.PRECOMP_POW2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(t, t2);
			if (global::Org.BouncyCastle.Math.Raw.Nat224.Eq(x, t2))
			{
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(t);
			}
			return null;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x000767E9 File Offset: 0x000749E9
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000767F7 File Offset: 0x000749F7
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00076805 File Offset: 0x00074A05
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat224.Eq(this.x, other.x));
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00076823 File Offset: 0x00074A23
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 7);
		}

		// Token: 0x04000A4B RID: 2635
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFE56D"));

		// Token: 0x04000A4C RID: 2636
		private static readonly uint[] PRECOMP_POW2 = new uint[]
		{
			868209154U,
			3707425075U,
			579297866U,
			3280018344U,
			2824165628U,
			514782679U,
			2396984652U
		};

		// Token: 0x04000A4D RID: 2637
		protected internal readonly uint[] x;
	}
}
