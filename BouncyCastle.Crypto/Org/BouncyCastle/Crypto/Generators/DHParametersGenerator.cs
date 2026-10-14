using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000468 RID: 1128
	public class DHParametersGenerator
	{
		// Token: 0x06002BA5 RID: 11173 RVA: 0x000BB092 File Offset: 0x000B9292
		public virtual void Init(int size, int certainty, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.size = size;
			this.certainty = certainty;
			this.random = random;
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x000BB0AC File Offset: 0x000B92AC
		public virtual global::Org.BouncyCastle.Crypto.Parameters.DHParameters GenerateParameters()
		{
			global::Org.BouncyCastle.Math.BigInteger[] array = global::Org.BouncyCastle.Crypto.Generators.DHParametersHelper.GenerateSafePrimes(this.size, this.certainty, this.random);
			global::Org.BouncyCastle.Math.BigInteger p = array[0];
			global::Org.BouncyCastle.Math.BigInteger q = array[1];
			global::Org.BouncyCastle.Math.BigInteger g = global::Org.BouncyCastle.Crypto.Generators.DHParametersHelper.SelectGenerator(p, q, this.random);
			return new global::Org.BouncyCastle.Crypto.Parameters.DHParameters(p, g, q, global::Org.BouncyCastle.Math.BigInteger.Two, null);
		}

		// Token: 0x04001218 RID: 4632
		private int size;

		// Token: 0x04001219 RID: 4633
		private int certainty;

		// Token: 0x0400121A RID: 4634
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
