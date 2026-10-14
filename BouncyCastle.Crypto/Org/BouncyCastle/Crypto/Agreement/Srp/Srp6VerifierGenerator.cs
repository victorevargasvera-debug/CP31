using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Agreement.Srp
{
	// Token: 0x020004FB RID: 1275
	public class Srp6VerifierGenerator
	{
		// Token: 0x0600320B RID: 12811 RVA: 0x000F0778 File Offset: 0x000EE978
		public virtual void Init(global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.N = N;
			this.g = g;
			this.digest = digest;
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x000F078F File Offset: 0x000EE98F
		public virtual void Init(global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters group, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.Init(group.N, group.G, digest);
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x000F07A4 File Offset: 0x000EE9A4
		public virtual global::Org.BouncyCastle.Math.BigInteger GenerateVerifier(byte[] salt, byte[] identity, byte[] password)
		{
			global::Org.BouncyCastle.Math.BigInteger x = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.CalculateX(this.digest, this.N, salt, identity, password);
			return this.g.ModPow(x, this.N);
		}

		// Token: 0x04001623 RID: 5667
		protected global::Org.BouncyCastle.Math.BigInteger N;

		// Token: 0x04001624 RID: 5668
		protected global::Org.BouncyCastle.Math.BigInteger g;

		// Token: 0x04001625 RID: 5669
		protected global::Org.BouncyCastle.Crypto.IDigest digest;
	}
}
