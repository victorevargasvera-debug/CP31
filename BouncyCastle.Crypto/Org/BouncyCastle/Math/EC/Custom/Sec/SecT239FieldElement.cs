using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000292 RID: 658
	internal class SecT239FieldElement : global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement
	{
		// Token: 0x06001C91 RID: 7313 RVA: 0x0008563B File Offset: 0x0008383B
		public SecT239FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.BitLength > 239)
			{
				throw new global::System.ArgumentException("value invalid for SecT239FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.FromBigInteger(x);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00085678 File Offset: 0x00083878
		public SecT239FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0008568B File Offset: 0x0008388B
		protected internal SecT239FieldElement(ulong[] x)
		{
			this.x = x;
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x0008569A File Offset: 0x0008389A
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsOne64(this.x);
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x000856A7 File Offset: 0x000838A7
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsZero64(this.x);
			}
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x000856B4 File Offset: 0x000838B4
		public override bool TestBitZero()
		{
			return (this.x[0] & 1UL) > 0UL;
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x000856C5 File Offset: 0x000838C5
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat256.ToBigInteger64(this.x);
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x000856D2 File Offset: 0x000838D2
		public override string FieldName
		{
			get
			{
				return "SecT239Field";
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x000856D9 File Offset: 0x000838D9
		public override int FieldSize
		{
			get
			{
				return 239;
			}
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x000856E0 File Offset: 0x000838E0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(z);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00085710 File Offset: 0x00083910
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(z);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00085735 File Offset: 0x00083935
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Add(b);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00085740 File Offset: 0x00083940
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(z);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00085770 File Offset: 0x00083970
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.MultiplyPlusProduct(b, x, y);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0008577C File Offset: 0x0008397C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] bx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement)b).x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.MultiplyAddToExt(ax, bx, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(z);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x000857DE File Offset: 0x000839DE
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Multiply(b.Invert());
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000857EC File Offset: 0x000839EC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			return this;
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x000857F0 File Offset: 0x000839F0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(z);
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00085815 File Offset: 0x00083A15
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.SquarePlusProduct(x, y);
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00085820 File Offset: 0x00083A20
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareAddToExt(ax, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(z);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00085874 File Offset: 0x00083A74
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
		{
			if (pow < 1)
			{
				return this;
			}
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(this.x, pow, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(z);
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x000858A0 File Offset: 0x00083AA0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement HalfTrace()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.HalfTrace(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(z);
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x000858C5 File Offset: 0x00083AC5
		public override bool HasFastTrace
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x000858C8 File Offset: 0x00083AC8
		public override int Trace()
		{
			return (int)global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Trace(this.x);
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x000858D8 File Offset: 0x00083AD8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Invert(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(z);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00085900 File Offset: 0x00083B00
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Sqrt(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(z);
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x00085925 File Offset: 0x00083B25
		public virtual int Representation
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00085928 File Offset: 0x00083B28
		public virtual int M
		{
			get
			{
				return 239;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x0008592F File Offset: 0x00083B2F
		public virtual int K1
		{
			get
			{
				return 158;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00085936 File Offset: 0x00083B36
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x00085939 File Offset: 0x00083B39
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x0008593C File Offset: 0x00083B3C
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement);
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0008594A File Offset: 0x00083B4A
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00085958 File Offset: 0x00083B58
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat256.Eq64(this.x, other.x));
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00085976 File Offset: 0x00083B76
		public override int GetHashCode()
		{
			return 23900158 ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 4);
		}

		// Token: 0x04000AC6 RID: 2758
		protected internal readonly ulong[] x;
	}
}
