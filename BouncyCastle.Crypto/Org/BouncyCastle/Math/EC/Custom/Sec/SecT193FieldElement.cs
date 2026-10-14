using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000286 RID: 646
	internal class SecT193FieldElement : global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement
	{
		// Token: 0x06001BB6 RID: 7094 RVA: 0x00081F2D File Offset: 0x0008012D
		public SecT193FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.BitLength > 193)
			{
				throw new global::System.ArgumentException("value invalid for SecT193FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.FromBigInteger(x);
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00081F6A File Offset: 0x0008016A
		public SecT193FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00081F7D File Offset: 0x0008017D
		protected internal SecT193FieldElement(ulong[] x)
		{
			this.x = x;
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00081F8C File Offset: 0x0008018C
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsOne64(this.x);
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x00081F99 File Offset: 0x00080199
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsZero64(this.x);
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00081FA6 File Offset: 0x000801A6
		public override bool TestBitZero()
		{
			return (this.x[0] & 1UL) > 0UL;
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00081FB7 File Offset: 0x000801B7
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat256.ToBigInteger64(this.x);
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00081FC4 File Offset: 0x000801C4
		public override string FieldName
		{
			get
			{
				return "SecT193Field";
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x00081FCB File Offset: 0x000801CB
		public override int FieldSize
		{
			get
			{
				return 193;
			}
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00081FD4 File Offset: 0x000801D4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(z);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00082004 File Offset: 0x00080204
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(z);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00082029 File Offset: 0x00080229
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Add(b);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00082034 File Offset: 0x00080234
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(z);
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00082064 File Offset: 0x00080264
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.MultiplyPlusProduct(b, x, y);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00082070 File Offset: 0x00080270
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] bx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement)b).x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.MultiplyAddToExt(ax, bx, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(z);
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x000820D2 File Offset: 0x000802D2
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Multiply(b.Invert());
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000820E0 File Offset: 0x000802E0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			return this;
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000820E4 File Offset: 0x000802E4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(z);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00082109 File Offset: 0x00080309
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.SquarePlusProduct(x, y);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00082114 File Offset: 0x00080314
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			ulong[] ax = this.x;
			ulong[] array = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement)x).x;
			ulong[] yx = ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement)y).x;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareAddToExt(ax, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.MultiplyAddToExt(array, yx, tt);
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce(tt, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(z);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00082168 File Offset: 0x00080368
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
		{
			if (pow < 1)
			{
				return this;
			}
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(this.x, pow, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(z);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00082194 File Offset: 0x00080394
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement HalfTrace()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.HalfTrace(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(z);
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x000821B9 File Offset: 0x000803B9
		public override bool HasFastTrace
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x000821BC File Offset: 0x000803BC
		public override int Trace()
		{
			return (int)global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Trace(this.x);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x000821CC File Offset: 0x000803CC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Invert(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(z);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x000821F4 File Offset: 0x000803F4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Sqrt(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(z);
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00082219 File Offset: 0x00080419
		public virtual int Representation
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x0008221C File Offset: 0x0008041C
		public virtual int M
		{
			get
			{
				return 193;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x00082223 File Offset: 0x00080423
		public virtual int K1
		{
			get
			{
				return 15;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x00082227 File Offset: 0x00080427
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x0008222A File Offset: 0x0008042A
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0008222D File Offset: 0x0008042D
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0008223B File Offset: 0x0008043B
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement);
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00082249 File Offset: 0x00080449
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat256.Eq64(this.x, other.x));
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00082267 File Offset: 0x00080467
		public override int GetHashCode()
		{
			return 1930015 ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 4);
		}

		// Token: 0x04000AB0 RID: 2736
		protected internal readonly ulong[] x;
	}
}
