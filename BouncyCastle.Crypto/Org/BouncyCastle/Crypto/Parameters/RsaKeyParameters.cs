using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000407 RID: 1031
	public class RsaKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x06002875 RID: 10357 RVA: 0x000ACB8F File Offset: 0x000AAD8F
		private static global::Org.BouncyCastle.Math.BigInteger Validate(global::Org.BouncyCastle.Math.BigInteger modulus)
		{
			if ((modulus.IntValue & 1) == 0)
			{
				throw new global::System.ArgumentException("RSA modulus is even", "modulus");
			}
			if (!modulus.Gcd(global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters.SmallPrimesProduct).Equals(global::Org.BouncyCastle.Math.BigInteger.One))
			{
				throw new global::System.ArgumentException("RSA modulus has a small prime factor");
			}
			return modulus;
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x000ACBD0 File Offset: 0x000AADD0
		public RsaKeyParameters(bool isPrivate, global::Org.BouncyCastle.Math.BigInteger modulus, global::Org.BouncyCastle.Math.BigInteger exponent) : base(isPrivate)
		{
			if (modulus == null)
			{
				throw new global::System.ArgumentNullException("modulus");
			}
			if (exponent == null)
			{
				throw new global::System.ArgumentNullException("exponent");
			}
			if (modulus.SignValue <= 0)
			{
				throw new global::System.ArgumentException("Not a valid RSA modulus", "modulus");
			}
			if (exponent.SignValue <= 0)
			{
				throw new global::System.ArgumentException("Not a valid RSA exponent", "exponent");
			}
			if (!isPrivate && (exponent.IntValue & 1) == 0)
			{
				throw new global::System.ArgumentException("RSA publicExponent is even", "exponent");
			}
			this.modulus = global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters.Validate(modulus);
			this.exponent = exponent;
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06002877 RID: 10359 RVA: 0x000ACC62 File Offset: 0x000AAE62
		public global::Org.BouncyCastle.Math.BigInteger Modulus
		{
			get
			{
				return this.modulus;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x000ACC6A File Offset: 0x000AAE6A
		public global::Org.BouncyCastle.Math.BigInteger Exponent
		{
			get
			{
				return this.exponent;
			}
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x000ACC74 File Offset: 0x000AAE74
		public override bool Equals(object obj)
		{
			global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters kp = obj as global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters;
			return kp != null && (kp.IsPrivate == base.IsPrivate && kp.Modulus.Equals(this.modulus)) && kp.Exponent.Equals(this.exponent);
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x000ACCC4 File Offset: 0x000AAEC4
		public override int GetHashCode()
		{
			return this.modulus.GetHashCode() ^ this.exponent.GetHashCode() ^ base.IsPrivate.GetHashCode();
		}

		// Token: 0x0400106C RID: 4204
		private static readonly global::Org.BouncyCastle.Math.BigInteger SmallPrimesProduct = new global::Org.BouncyCastle.Math.BigInteger("8138e8a0fcf3a4e84a771d40fd305d7f4aa59306d7251de54d98af8fe95729a1f73d893fa424cd2edc8636a6c3285e022b0e3866a565ae8108eed8591cd4fe8d2ce86165a978d719ebf647f362d33fca29cd179fb42401cbaf3df0c614056f9c8f3cfd51e474afb6bc6974f78db8aba8e9e517fded658591ab7502bd41849462f", 16);

		// Token: 0x0400106D RID: 4205
		private readonly global::Org.BouncyCastle.Math.BigInteger modulus;

		// Token: 0x0400106E RID: 4206
		private readonly global::Org.BouncyCastle.Math.BigInteger exponent;
	}
}
