using System;
using Org.BouncyCastle.Math.Field;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000207 RID: 519
	public abstract class AbstractFpCurve : global::Org.BouncyCastle.Math.EC.ECCurve
	{
		// Token: 0x0600147A RID: 5242 RVA: 0x00060A3B File Offset: 0x0005EC3B
		protected AbstractFpCurve(global::Org.BouncyCastle.Math.BigInteger q) : base(global::Org.BouncyCastle.Math.Field.FiniteFields.GetPrimeField(q))
		{
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x00060A49 File Offset: 0x0005EC49
		public override bool IsValidFieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return x != null && x.SignValue >= 0 && x.CompareTo(this.Field.Characteristic) < 0;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00060A70 File Offset: 0x0005EC70
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			global::Org.BouncyCastle.Math.BigInteger p = this.Field.Characteristic;
			global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement = this.FromBigInteger(global::Org.BouncyCastle.Math.EC.AbstractFpCurve.ImplRandomFieldElement(r, p));
			global::Org.BouncyCastle.Math.EC.ECFieldElement fe2 = this.FromBigInteger(global::Org.BouncyCastle.Math.EC.AbstractFpCurve.ImplRandomFieldElement(r, p));
			return ecfieldElement.Multiply(fe2);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00060AAC File Offset: 0x0005ECAC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			global::Org.BouncyCastle.Math.BigInteger p = this.Field.Characteristic;
			global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement = this.FromBigInteger(global::Org.BouncyCastle.Math.EC.AbstractFpCurve.ImplRandomFieldElementMult(r, p));
			global::Org.BouncyCastle.Math.EC.ECFieldElement fe2 = this.FromBigInteger(global::Org.BouncyCastle.Math.EC.AbstractFpCurve.ImplRandomFieldElementMult(r, p));
			return ecfieldElement.Multiply(fe2);
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00060AE8 File Offset: 0x0005ECE8
		protected override global::Org.BouncyCastle.Math.EC.ECPoint DecompressPoint(int yTilde, global::Org.BouncyCastle.Math.BigInteger X1)
		{
			global::Org.BouncyCastle.Math.EC.ECFieldElement x = this.FromBigInteger(X1);
			global::Org.BouncyCastle.Math.EC.ECFieldElement y = x.Square().Add(this.A).Multiply(x).Add(this.B).Sqrt();
			if (y == null)
			{
				throw new global::System.ArgumentException("Invalid point compression");
			}
			if (y.TestBitZero() != (yTilde == 1))
			{
				y = y.Negate();
			}
			return this.CreateRawPoint(x, y, true);
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00060B50 File Offset: 0x0005ED50
		private static global::Org.BouncyCastle.Math.BigInteger ImplRandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r, global::Org.BouncyCastle.Math.BigInteger p)
		{
			global::Org.BouncyCastle.Math.BigInteger x;
			do
			{
				x = global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomBigInteger(p.BitLength, r);
			}
			while (x.CompareTo(p) >= 0);
			return x;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00060B78 File Offset: 0x0005ED78
		private static global::Org.BouncyCastle.Math.BigInteger ImplRandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r, global::Org.BouncyCastle.Math.BigInteger p)
		{
			global::Org.BouncyCastle.Math.BigInteger x;
			do
			{
				x = global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomBigInteger(p.BitLength, r);
			}
			while (x.SignValue <= 0 || x.CompareTo(p) >= 0);
			return x;
		}
	}
}
