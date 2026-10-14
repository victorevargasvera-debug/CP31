using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000296 RID: 662
	internal class SecT283FieldElement : global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement
	{
		// Token: 0x06001CE6 RID: 7398 RVA: 0x00086B50 File Offset: 0x00084D50
		public SecT283FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.BitLength > 283)
			{
				throw new global::System.ArgumentException("value invalid for SecT283FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.FromBigInteger(x);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00086B8D File Offset: 0x00084D8D
		public SecT283FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00086BA0 File Offset: 0x00084DA0
		protected internal SecT283FieldElement(ulong[] x)
		{
			this.x = x;
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x00086BAF File Offset: 0x00084DAF
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat320.IsOne64(this.x);
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x00086BBC File Offset: 0x00084DBC
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat320.IsZero64(this.x);
			}
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00086BC9 File Offset: 0x00084DC9
		public override bool TestBitZero()
		{
			return (this.x[0] & 1UL) > 0UL;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00086BDA File Offset: 0x00084DDA
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat320.ToBigInteger64(this.x);
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x00086BE7 File Offset: 0x00084DE7
		public override string FieldName
		{
			get
			{
				return "SecT283Field";
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x00086BEE File Offset: 0x00084DEE
		public override int FieldSize
		{
			get
			{
				return 283;
			}
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00086BF8 File Offset: 0x00084DF8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(z);
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00086C28 File Offset: 0x00084E28
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(z);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00086C4D File Offset: 0x00084E4D
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Add(b);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00086C58 File Offset: 0x00084E58
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(z);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00086C88 File Offset: 0x00084E88
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.MultiplyPlusProduct(b, x, y);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00086C94 File Offset: 0x00084E94
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] bx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement)b).x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.MultiplyAddToExt(ax, bx, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(z);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00086CF8 File Offset: 0x00084EF8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Multiply(b.Invert());
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00086D06 File Offset: 0x00084F06
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			return this;
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00086D0C File Offset: 0x00084F0C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(z);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00086D31 File Offset: 0x00084F31
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.SquarePlusProduct(x, y);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00086D3C File Offset: 0x00084F3C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareAddToExt(ax, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(z);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00086D90 File Offset: 0x00084F90
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
		{
			if (pow < 1)
			{
				return this;
			}
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(this.x, pow, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(z);
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00086DBC File Offset: 0x00084FBC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement HalfTrace()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.HalfTrace(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(z);
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x00086DE1 File Offset: 0x00084FE1
		public override bool HasFastTrace
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00086DE4 File Offset: 0x00084FE4
		public override int Trace()
		{
			return (int)global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Trace(this.x);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00086DF4 File Offset: 0x00084FF4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Invert(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(z);
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00086E1C File Offset: 0x0008501C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Sqrt(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(z);
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00086E41 File Offset: 0x00085041
		public virtual int Representation
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x00086E44 File Offset: 0x00085044
		public virtual int M
		{
			get
			{
				return 283;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x00086E4B File Offset: 0x0008504B
		public virtual int K1
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x00086E4E File Offset: 0x0008504E
		public virtual int K2
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x00086E51 File Offset: 0x00085051
		public virtual int K3
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00086E55 File Offset: 0x00085055
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00086E63 File Offset: 0x00085063
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement);
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00086E71 File Offset: 0x00085071
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat320.Eq64(this.x, other.x));
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00086E8F File Offset: 0x0008508F
		public override int GetHashCode()
		{
			return 2831275 ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 5);
		}

		// Token: 0x04000ACE RID: 2766
		protected internal readonly ulong[] x;
	}
}
