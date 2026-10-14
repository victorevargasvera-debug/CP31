using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200029C RID: 668
	internal class SecT409FieldElement : global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement
	{
		// Token: 0x06001D54 RID: 7508 RVA: 0x00088925 File Offset: 0x00086B25
		public SecT409FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.BitLength > 409)
			{
				throw new global::System.ArgumentException("value invalid for SecT409FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.FromBigInteger(x);
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00088962 File Offset: 0x00086B62
		public SecT409FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00088975 File Offset: 0x00086B75
		protected internal SecT409FieldElement(ulong[] x)
		{
			this.x = x;
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x00088984 File Offset: 0x00086B84
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat448.IsOne64(this.x);
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00088991 File Offset: 0x00086B91
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat448.IsZero64(this.x);
			}
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x0008899E File Offset: 0x00086B9E
		public override bool TestBitZero()
		{
			return (this.x[0] & 1UL) > 0UL;
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x000889AF File Offset: 0x00086BAF
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat448.ToBigInteger64(this.x);
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x000889BC File Offset: 0x00086BBC
		public override string FieldName
		{
			get
			{
				return "SecT409Field";
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x000889C3 File Offset: 0x00086BC3
		public override int FieldSize
		{
			get
			{
				return 409;
			}
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x000889CC File Offset: 0x00086BCC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(z);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x000889FC File Offset: 0x00086BFC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(z);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00088A21 File Offset: 0x00086C21
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Add(b);
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x00088A2C File Offset: 0x00086C2C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(z);
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00088A5C File Offset: 0x00086C5C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.MultiplyPlusProduct(b, x, y);
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00088A68 File Offset: 0x00086C68
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] bx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement)b).x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(13);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.MultiplyAddToExt(ax, bx, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(z);
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x00088ACC File Offset: 0x00086CCC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Multiply(b.Invert());
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00088ADA File Offset: 0x00086CDA
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			return this;
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x00088AE0 File Offset: 0x00086CE0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(z);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00088B05 File Offset: 0x00086D05
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.SquarePlusProduct(x, y);
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00088B10 File Offset: 0x00086D10
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(13);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareAddToExt(ax, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(z);
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00088B64 File Offset: 0x00086D64
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
		{
			if (pow < 1)
			{
				return this;
			}
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(this.x, pow, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(z);
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00088B90 File Offset: 0x00086D90
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement HalfTrace()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.HalfTrace(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(z);
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x00088BB5 File Offset: 0x00086DB5
		public override bool HasFastTrace
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00088BB8 File Offset: 0x00086DB8
		public override int Trace()
		{
			return (int)global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Trace(this.x);
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00088BC8 File Offset: 0x00086DC8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Invert(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(z);
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00088BF0 File Offset: 0x00086DF0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Sqrt(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(z);
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x00088C15 File Offset: 0x00086E15
		public virtual int Representation
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00088C18 File Offset: 0x00086E18
		public virtual int M
		{
			get
			{
				return 409;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x00088C1F File Offset: 0x00086E1F
		public virtual int K1
		{
			get
			{
				return 87;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x00088C23 File Offset: 0x00086E23
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00088C26 File Offset: 0x00086E26
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00088C29 File Offset: 0x00086E29
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement);
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00088C37 File Offset: 0x00086E37
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement);
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00088C45 File Offset: 0x00086E45
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat448.Eq64(this.x, other.x));
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00088C63 File Offset: 0x00086E63
		public override int GetHashCode()
		{
			return 4090087 ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 7);
		}

		// Token: 0x04000AD9 RID: 2777
		protected internal readonly ulong[] x;
	}
}
