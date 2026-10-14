using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000272 RID: 626
	internal class SecT113FieldElement : global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement
	{
		// Token: 0x06001A54 RID: 6740 RVA: 0x0007C6AC File Offset: 0x0007A8AC
		public SecT113FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.BitLength > 113)
			{
				throw new global::System.ArgumentException("value invalid for SecT113FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.FromBigInteger(x);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x0007C6E6 File Offset: 0x0007A8E6
		public SecT113FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0007C6F9 File Offset: 0x0007A8F9
		protected internal SecT113FieldElement(ulong[] x)
		{
			this.x = x;
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x0007C708 File Offset: 0x0007A908
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat128.IsOne64(this.x);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x0007C715 File Offset: 0x0007A915
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat128.IsZero64(this.x);
			}
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0007C722 File Offset: 0x0007A922
		public override bool TestBitZero()
		{
			return (this.x[0] & 1UL) > 0UL;
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0007C733 File Offset: 0x0007A933
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat128.ToBigInteger64(this.x);
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x0007C740 File Offset: 0x0007A940
		public override string FieldName
		{
			get
			{
				return "SecT113Field";
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0007C747 File Offset: 0x0007A947
		public override int FieldSize
		{
			get
			{
				return 113;
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0007C74C File Offset: 0x0007A94C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(z);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0007C77C File Offset: 0x0007A97C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(z);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0007C7A1 File Offset: 0x0007A9A1
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Add(b);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0007C7AC File Offset: 0x0007A9AC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(z);
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0007C7DC File Offset: 0x0007A9DC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.MultiplyPlusProduct(b, x, y);
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0007C7E8 File Offset: 0x0007A9E8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] bx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement)b).x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat128.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.MultiplyAddToExt(ax, bx, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(z);
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x0007C84A File Offset: 0x0007AA4A
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Multiply(b.Invert());
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x0007C858 File Offset: 0x0007AA58
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			return this;
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0007C85C File Offset: 0x0007AA5C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(z);
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0007C881 File Offset: 0x0007AA81
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.SquarePlusProduct(x, y);
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x0007C88C File Offset: 0x0007AA8C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat128.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.SquareAddToExt(ax, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(z);
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x0007C8E0 File Offset: 0x0007AAE0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
		{
			if (pow < 1)
			{
				return this;
			}
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.SquareN(this.x, pow, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(z);
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0007C90C File Offset: 0x0007AB0C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement HalfTrace()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.HalfTrace(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(z);
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0007C931 File Offset: 0x0007AB31
		public override bool HasFastTrace
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0007C934 File Offset: 0x0007AB34
		public override int Trace()
		{
			return (int)global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Trace(this.x);
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0007C944 File Offset: 0x0007AB44
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Invert(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(z);
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0007C96C File Offset: 0x0007AB6C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Sqrt(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(z);
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x0007C991 File Offset: 0x0007AB91
		public virtual int Representation
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x0007C994 File Offset: 0x0007AB94
		public virtual int M
		{
			get
			{
				return 113;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x0007C998 File Offset: 0x0007AB98
		public virtual int K1
		{
			get
			{
				return 9;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x0007C99C File Offset: 0x0007AB9C
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x0007C99F File Offset: 0x0007AB9F
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0007C9A2 File Offset: 0x0007ABA2
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement);
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0007C9B0 File Offset: 0x0007ABB0
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0007C9BE File Offset: 0x0007ABBE
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat128.Eq64(this.x, other.x));
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0007C9DC File Offset: 0x0007ABDC
		public override int GetHashCode()
		{
			return 113009 ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 2);
		}

		// Token: 0x04000A89 RID: 2697
		protected internal readonly ulong[] x;
	}
}
