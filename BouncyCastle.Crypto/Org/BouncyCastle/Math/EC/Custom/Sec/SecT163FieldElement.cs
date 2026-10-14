using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200027E RID: 638
	internal class SecT163FieldElement : global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement
	{
		// Token: 0x06001B2E RID: 6958 RVA: 0x0007FD66 File Offset: 0x0007DF66
		public SecT163FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.BitLength > 163)
			{
				throw new global::System.ArgumentException("value invalid for SecT163FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.FromBigInteger(x);
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0007FDA3 File Offset: 0x0007DFA3
		public SecT163FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0007FDB6 File Offset: 0x0007DFB6
		protected internal SecT163FieldElement(ulong[] x)
		{
			this.x = x;
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x0007FDC5 File Offset: 0x0007DFC5
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat192.IsOne64(this.x);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0007FDD2 File Offset: 0x0007DFD2
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat192.IsZero64(this.x);
			}
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0007FDDF File Offset: 0x0007DFDF
		public override bool TestBitZero()
		{
			return (this.x[0] & 1UL) > 0UL;
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0007FDF0 File Offset: 0x0007DFF0
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat192.ToBigInteger64(this.x);
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x0007FDFD File Offset: 0x0007DFFD
		public override string FieldName
		{
			get
			{
				return "SecT163Field";
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0007FE04 File Offset: 0x0007E004
		public override int FieldSize
		{
			get
			{
				return 163;
			}
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0007FE0C File Offset: 0x0007E00C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(z);
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0007FE3C File Offset: 0x0007E03C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(z);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0007FE61 File Offset: 0x0007E061
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Add(b);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0007FE6C File Offset: 0x0007E06C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(z);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x0007FE9C File Offset: 0x0007E09C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.MultiplyPlusProduct(b, x, y);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0007FEA8 File Offset: 0x0007E0A8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] bx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement)b).x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.MultiplyAddToExt(ax, bx, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(z);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0007FF0A File Offset: 0x0007E10A
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Multiply(b.Invert());
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0007FF18 File Offset: 0x0007E118
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			return this;
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0007FF1C File Offset: 0x0007E11C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(z);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0007FF41 File Offset: 0x0007E141
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.SquarePlusProduct(x, y);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0007FF4C File Offset: 0x0007E14C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareAddToExt(ax, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(z);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0007FFA0 File Offset: 0x0007E1A0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
		{
			if (pow < 1)
			{
				return this;
			}
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(this.x, pow, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(z);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0007FFCC File Offset: 0x0007E1CC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement HalfTrace()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.HalfTrace(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(z);
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x0007FFF1 File Offset: 0x0007E1F1
		public override bool HasFastTrace
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0007FFF4 File Offset: 0x0007E1F4
		public override int Trace()
		{
			return (int)global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Trace(this.x);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00080004 File Offset: 0x0007E204
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Invert(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(z);
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0008002C File Offset: 0x0007E22C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Sqrt(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(z);
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x00080051 File Offset: 0x0007E251
		public virtual int Representation
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00080054 File Offset: 0x0007E254
		public virtual int M
		{
			get
			{
				return 163;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x0008005B File Offset: 0x0007E25B
		public virtual int K1
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x0008005E File Offset: 0x0007E25E
		public virtual int K2
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x00080061 File Offset: 0x0007E261
		public virtual int K3
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00080064 File Offset: 0x0007E264
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00080072 File Offset: 0x0007E272
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement);
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00080080 File Offset: 0x0007E280
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat192.Eq64(this.x, other.x));
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0008009E File Offset: 0x0007E29E
		public override int GetHashCode()
		{
			return 163763 ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 3);
		}

		// Token: 0x04000AA1 RID: 2721
		protected internal readonly ulong[] x;
	}
}
