using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200028C RID: 652
	internal class SecT233FieldElement : global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement
	{
		// Token: 0x06001C23 RID: 7203 RVA: 0x00083AC0 File Offset: 0x00081CC0
		public SecT233FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.BitLength > 233)
			{
				throw new global::System.ArgumentException("value invalid for SecT233FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.FromBigInteger(x);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00083AFD File Offset: 0x00081CFD
		public SecT233FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00083B10 File Offset: 0x00081D10
		protected internal SecT233FieldElement(ulong[] x)
		{
			this.x = x;
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00083B1F File Offset: 0x00081D1F
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsOne64(this.x);
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x00083B2C File Offset: 0x00081D2C
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsZero64(this.x);
			}
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00083B39 File Offset: 0x00081D39
		public override bool TestBitZero()
		{
			return (this.x[0] & 1UL) > 0UL;
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00083B4A File Offset: 0x00081D4A
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat256.ToBigInteger64(this.x);
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00083B57 File Offset: 0x00081D57
		public override string FieldName
		{
			get
			{
				return "SecT233Field";
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x00083B5E File Offset: 0x00081D5E
		public override int FieldSize
		{
			get
			{
				return 233;
			}
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x00083B68 File Offset: 0x00081D68
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(z);
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x00083B98 File Offset: 0x00081D98
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(z);
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00083BBD File Offset: 0x00081DBD
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Add(b);
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00083BC8 File Offset: 0x00081DC8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(z);
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00083BF8 File Offset: 0x00081DF8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.MultiplyPlusProduct(b, x, y);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00083C04 File Offset: 0x00081E04
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] bx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement)b).x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.MultiplyAddToExt(ax, bx, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(z);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00083C66 File Offset: 0x00081E66
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Multiply(b.Invert());
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00083C74 File Offset: 0x00081E74
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			return this;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00083C78 File Offset: 0x00081E78
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(z);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00083C9D File Offset: 0x00081E9D
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.SquarePlusProduct(x, y);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00083CA8 File Offset: 0x00081EA8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareAddToExt(ax, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(z);
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00083CFC File Offset: 0x00081EFC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
		{
			if (pow < 1)
			{
				return this;
			}
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(this.x, pow, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(z);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00083D28 File Offset: 0x00081F28
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement HalfTrace()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.HalfTrace(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(z);
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x00083D4D File Offset: 0x00081F4D
		public override bool HasFastTrace
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00083D50 File Offset: 0x00081F50
		public override int Trace()
		{
			return (int)global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Trace(this.x);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00083D60 File Offset: 0x00081F60
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Invert(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(z);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00083D88 File Offset: 0x00081F88
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Sqrt(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(z);
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00083DAD File Offset: 0x00081FAD
		public virtual int Representation
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00083DB0 File Offset: 0x00081FB0
		public virtual int M
		{
			get
			{
				return 233;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x00083DB7 File Offset: 0x00081FB7
		public virtual int K1
		{
			get
			{
				return 74;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00083DBB File Offset: 0x00081FBB
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x00083DBE File Offset: 0x00081FBE
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00083DC1 File Offset: 0x00081FC1
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement);
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00083DCF File Offset: 0x00081FCF
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement);
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00083DDD File Offset: 0x00081FDD
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat256.Eq64(this.x, other.x));
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00083DFB File Offset: 0x00081FFB
		public override int GetHashCode()
		{
			return 2330074 ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 4);
		}

		// Token: 0x04000ABB RID: 2747
		protected internal readonly ulong[] x;
	}
}
