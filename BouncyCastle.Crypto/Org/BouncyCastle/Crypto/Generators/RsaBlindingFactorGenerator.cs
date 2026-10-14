using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000481 RID: 1153
	public class RsaBlindingFactorGenerator
	{
		// Token: 0x06002C38 RID: 11320 RVA: 0x000BEEE8 File Offset: 0x000BD0E8
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters param)
		{
			if (param is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom rParam = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)param;
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)rParam.Parameters;
				this.random = rParam.Random;
			}
			else
			{
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)param;
				this.random = new global::Org.BouncyCastle.Security.SecureRandom();
			}
			if (this.key.IsPrivate)
			{
				throw new global::System.ArgumentException("generator requires RSA public key");
			}
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x000BEF54 File Offset: 0x000BD154
		public global::Org.BouncyCastle.Math.BigInteger GenerateBlindingFactor()
		{
			if (this.key == null)
			{
				throw new global::System.InvalidOperationException("generator not initialised");
			}
			global::Org.BouncyCastle.Math.BigInteger i = this.key.Modulus;
			int length = i.BitLength - 1;
			global::Org.BouncyCastle.Math.BigInteger factor;
			global::Org.BouncyCastle.Math.BigInteger gcd;
			do
			{
				factor = new global::Org.BouncyCastle.Math.BigInteger(length, this.random);
				gcd = factor.Gcd(i);
			}
			while (factor.SignValue == 0 || factor.Equals(global::Org.BouncyCastle.Math.BigInteger.One) || !gcd.Equals(global::Org.BouncyCastle.Math.BigInteger.One));
			return factor;
		}

		// Token: 0x04001270 RID: 4720
		private global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key;

		// Token: 0x04001271 RID: 4721
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
