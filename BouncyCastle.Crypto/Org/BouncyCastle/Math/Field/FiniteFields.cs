using System;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x020001FC RID: 508
	public abstract class FiniteFields
	{
		// Token: 0x06001419 RID: 5145 RVA: 0x0005F484 File Offset: 0x0005D684
		public static global::Org.BouncyCastle.Math.Field.IPolynomialExtensionField GetBinaryExtensionField(int[] exponents)
		{
			if (exponents[0] != 0)
			{
				throw new global::System.ArgumentException("Irreducible polynomials in GF(2) must have constant term", "exponents");
			}
			for (int i = 1; i < exponents.Length; i++)
			{
				if (exponents[i] <= exponents[i - 1])
				{
					throw new global::System.ArgumentException("Polynomial exponents must be monotonically increasing", "exponents");
				}
			}
			return new global::Org.BouncyCastle.Math.Field.GenericPolynomialExtensionField(global::Org.BouncyCastle.Math.Field.FiniteFields.GF_2, new global::Org.BouncyCastle.Math.Field.GF2Polynomial(exponents));
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0005F4E0 File Offset: 0x0005D6E0
		public static global::Org.BouncyCastle.Math.Field.IFiniteField GetPrimeField(global::Org.BouncyCastle.Math.BigInteger characteristic)
		{
			int bitLength = characteristic.BitLength;
			if (characteristic.SignValue <= 0 || bitLength < 2)
			{
				throw new global::System.ArgumentException("Must be >= 2", "characteristic");
			}
			if (bitLength < 3)
			{
				int intValue = characteristic.IntValue;
				if (intValue == 2)
				{
					return global::Org.BouncyCastle.Math.Field.FiniteFields.GF_2;
				}
				if (intValue == 3)
				{
					return global::Org.BouncyCastle.Math.Field.FiniteFields.GF_3;
				}
			}
			return new global::Org.BouncyCastle.Math.Field.PrimeField(characteristic);
		}

		// Token: 0x04000935 RID: 2357
		internal static readonly global::Org.BouncyCastle.Math.Field.IFiniteField GF_2 = new global::Org.BouncyCastle.Math.Field.PrimeField(global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L));

		// Token: 0x04000936 RID: 2358
		internal static readonly global::Org.BouncyCastle.Math.Field.IFiniteField GF_3 = new global::Org.BouncyCastle.Math.Field.PrimeField(global::Org.BouncyCastle.Math.BigInteger.ValueOf(3L));
	}
}
