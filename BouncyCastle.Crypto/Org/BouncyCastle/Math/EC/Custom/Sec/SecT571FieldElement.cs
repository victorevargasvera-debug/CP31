using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020002A2 RID: 674
	internal class SecT571FieldElement : global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement
	{
		// Token: 0x06001DC8 RID: 7624 RVA: 0x0008A7A4 File Offset: 0x000889A4
		public SecT571FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.BitLength > 571)
			{
				throw new global::System.ArgumentException("value invalid for SecT571FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.FromBigInteger(x);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x0008A7E1 File Offset: 0x000889E1
		public SecT571FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x0008A7F4 File Offset: 0x000889F4
		protected internal SecT571FieldElement(ulong[] x)
		{
			this.x = x;
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x0008A803 File Offset: 0x00088A03
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat576.IsOne64(this.x);
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x0008A810 File Offset: 0x00088A10
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat576.IsZero64(this.x);
			}
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x0008A81D File Offset: 0x00088A1D
		public override bool TestBitZero()
		{
			return (this.x[0] & 1UL) > 0UL;
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x0008A82E File Offset: 0x00088A2E
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat576.ToBigInteger64(this.x);
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x0008A83B File Offset: 0x00088A3B
		public override string FieldName
		{
			get
			{
				return "SecT571Field";
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x0008A842 File Offset: 0x00088A42
		public override int FieldSize
		{
			get
			{
				return 571;
			}
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x0008A84C File Offset: 0x00088A4C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(z);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x0008A87C File Offset: 0x00088A7C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(z);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x0008A8A1 File Offset: 0x00088AA1
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Add(b);
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x0008A8AC File Offset: 0x00088AAC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(z);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x0008A8DC File Offset: 0x00088ADC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.MultiplyPlusProduct(b, x, y);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x0008A8E8 File Offset: 0x00088AE8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] bx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)b).x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyAddToExt(ax, bx, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(z);
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x0008A94A File Offset: 0x00088B4A
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Multiply(b.Invert());
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0008A958 File Offset: 0x00088B58
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			return this;
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x0008A95C File Offset: 0x00088B5C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(z);
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x0008A981 File Offset: 0x00088B81
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.SquarePlusProduct(x, y);
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x0008A98C File Offset: 0x00088B8C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareAddToExt(ax, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(z);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0008A9E0 File Offset: 0x00088BE0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
		{
			if (pow < 1)
			{
				return this;
			}
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareN(this.x, pow, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(z);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x0008AA0C File Offset: 0x00088C0C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement HalfTrace()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.HalfTrace(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(z);
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x0008AA31 File Offset: 0x00088C31
		public override bool HasFastTrace
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0008AA34 File Offset: 0x00088C34
		public override int Trace()
		{
			return (int)global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Trace(this.x);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0008AA44 File Offset: 0x00088C44
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Invert(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(z);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0008AA6C File Offset: 0x00088C6C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Sqrt(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(z);
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x0008AA91 File Offset: 0x00088C91
		public virtual int Representation
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x0008AA94 File Offset: 0x00088C94
		public virtual int M
		{
			get
			{
				return 571;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x0008AA9B File Offset: 0x00088C9B
		public virtual int K1
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x0008AA9E File Offset: 0x00088C9E
		public virtual int K2
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x0008AAA1 File Offset: 0x00088CA1
		public virtual int K3
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x0008AAA5 File Offset: 0x00088CA5
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement);
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x0008AAB3 File Offset: 0x00088CB3
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement);
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x0008AAC1 File Offset: 0x00088CC1
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat576.Eq64(this.x, other.x));
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x0008AADF File Offset: 0x00088CDF
		public override int GetHashCode()
		{
			return 5711052 ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 9);
		}

		// Token: 0x04000AE4 RID: 2788
		protected internal readonly ulong[] x;
	}
}
