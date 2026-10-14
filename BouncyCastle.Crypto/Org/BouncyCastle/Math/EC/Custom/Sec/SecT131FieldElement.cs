using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000278 RID: 632
	internal class SecT131FieldElement : global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement
	{
		// Token: 0x06001AC1 RID: 6849 RVA: 0x0007E203 File Offset: 0x0007C403
		public SecT131FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.BitLength > 131)
			{
				throw new global::System.ArgumentException("value invalid for SecT131FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.FromBigInteger(x);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x0007E240 File Offset: 0x0007C440
		public SecT131FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0007E253 File Offset: 0x0007C453
		protected internal SecT131FieldElement(ulong[] x)
		{
			this.x = x;
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0007E262 File Offset: 0x0007C462
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat192.IsOne64(this.x);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x0007E26F File Offset: 0x0007C46F
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat192.IsZero64(this.x);
			}
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0007E27C File Offset: 0x0007C47C
		public override bool TestBitZero()
		{
			return (this.x[0] & 1UL) > 0UL;
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0007E28D File Offset: 0x0007C48D
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat192.ToBigInteger64(this.x);
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x0007E29A File Offset: 0x0007C49A
		public override string FieldName
		{
			get
			{
				return "SecT131Field";
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x0007E2A1 File Offset: 0x0007C4A1
		public override int FieldSize
		{
			get
			{
				return 131;
			}
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0007E2A8 File Offset: 0x0007C4A8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(z);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0007E2D8 File Offset: 0x0007C4D8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(z);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0007E2FD File Offset: 0x0007C4FD
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Add(b);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0007E308 File Offset: 0x0007C508
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(z);
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0007E338 File Offset: 0x0007C538
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.MultiplyPlusProduct(b, x, y);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0007E344 File Offset: 0x0007C544
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] bx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement)b).x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.MultiplyAddToExt(ax, bx, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(z);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x0007E3A7 File Offset: 0x0007C5A7
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Multiply(b.Invert());
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0007E3B5 File Offset: 0x0007C5B5
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			return this;
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x0007E3B8 File Offset: 0x0007C5B8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(z);
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0007E3DD File Offset: 0x0007C5DD
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.SquarePlusProduct(x, y);
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0007E3E8 File Offset: 0x0007C5E8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareAddToExt(ax, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(z);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0007E43C File Offset: 0x0007C63C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
		{
			if (pow < 1)
			{
				return this;
			}
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(this.x, pow, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(z);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0007E468 File Offset: 0x0007C668
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement HalfTrace()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.HalfTrace(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(z);
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x0007E48D File Offset: 0x0007C68D
		public override bool HasFastTrace
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x0007E490 File Offset: 0x0007C690
		public override int Trace()
		{
			return (int)global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Trace(this.x);
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0007E4A0 File Offset: 0x0007C6A0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Invert(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(z);
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x0007E4C8 File Offset: 0x0007C6C8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Sqrt(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(z);
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x0007E4ED File Offset: 0x0007C6ED
		public virtual int Representation
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0007E4F0 File Offset: 0x0007C6F0
		public virtual int M
		{
			get
			{
				return 131;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x0007E4F7 File Offset: 0x0007C6F7
		public virtual int K1
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x0007E4FA File Offset: 0x0007C6FA
		public virtual int K2
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x0007E4FD File Offset: 0x0007C6FD
		public virtual int K3
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0007E500 File Offset: 0x0007C700
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement);
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0007E50E File Offset: 0x0007C70E
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0007E51C File Offset: 0x0007C71C
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat192.Eq64(this.x, other.x));
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0007E53A File Offset: 0x0007C73A
		public override int GetHashCode()
		{
			return 131832 ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 3);
		}

		// Token: 0x04000A95 RID: 2709
		protected internal readonly ulong[] x;
	}
}
