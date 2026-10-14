using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000470 RID: 1136
	public class ElGamalParametersGenerator
	{
		// Token: 0x06002BD1 RID: 11217 RVA: 0x000BBE9C File Offset: 0x000BA09C
		public void Init(int size, int certainty, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.size = size;
			this.certainty = certainty;
			this.random = random;
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x000BBEB4 File Offset: 0x000BA0B4
		public global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters GenerateParameters()
		{
			global::Org.BouncyCastle.Math.BigInteger[] array = global::Org.BouncyCastle.Crypto.Generators.DHParametersHelper.GenerateSafePrimes(this.size, this.certainty, this.random);
			global::Org.BouncyCastle.Math.BigInteger p = array[0];
			global::Org.BouncyCastle.Math.BigInteger q = array[1];
			global::Org.BouncyCastle.Math.BigInteger g = global::Org.BouncyCastle.Crypto.Generators.DHParametersHelper.SelectGenerator(p, q, this.random);
			return new global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters(p, g);
		}

		// Token: 0x0400122F RID: 4655
		private int size;

		// Token: 0x04001230 RID: 4656
		private int certainty;

		// Token: 0x04001231 RID: 4657
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
