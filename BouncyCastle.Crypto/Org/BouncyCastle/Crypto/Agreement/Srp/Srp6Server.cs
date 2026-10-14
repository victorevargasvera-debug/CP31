using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Agreement.Srp
{
	// Token: 0x020004F8 RID: 1272
	public class Srp6Server
	{
		// Token: 0x060031F1 RID: 12785 RVA: 0x000F01CF File Offset: 0x000EE3CF
		public virtual void Init(global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger v, global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.N = N;
			this.g = g;
			this.v = v;
			this.random = random;
			this.digest = digest;
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x000F01F6 File Offset: 0x000EE3F6
		public virtual void Init(global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters group, global::Org.BouncyCastle.Math.BigInteger v, global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.Init(group.N, group.G, v, digest, random);
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x000F0210 File Offset: 0x000EE410
		public virtual global::Org.BouncyCastle.Math.BigInteger GenerateServerCredentials()
		{
			global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.CalculateK(this.digest, this.N, this.g);
			this.privB = this.SelectPrivateValue();
			this.pubB = i.Multiply(this.v).Mod(this.N).Add(this.g.ModPow(this.privB, this.N)).Mod(this.N);
			return this.pubB;
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x000F028C File Offset: 0x000EE48C
		public virtual global::Org.BouncyCastle.Math.BigInteger CalculateSecret(global::Org.BouncyCastle.Math.BigInteger clientA)
		{
			this.A = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.ValidatePublicValue(this.N, clientA);
			this.u = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.CalculateU(this.digest, this.N, this.A, this.pubB);
			this.S = this.CalculateS();
			return this.S;
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x000F02E0 File Offset: 0x000EE4E0
		protected virtual global::Org.BouncyCastle.Math.BigInteger SelectPrivateValue()
		{
			return global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.GeneratePrivateValue(this.digest, this.N, this.g, this.random);
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x000F02FF File Offset: 0x000EE4FF
		private global::Org.BouncyCastle.Math.BigInteger CalculateS()
		{
			return this.v.ModPow(this.u, this.N).Multiply(this.A).Mod(this.N).ModPow(this.privB, this.N);
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x000F0340 File Offset: 0x000EE540
		public virtual bool VerifyClientEvidenceMessage(global::Org.BouncyCastle.Math.BigInteger clientM1)
		{
			if (this.A == null || this.pubB == null || this.S == null)
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("Impossible to compute and verify M1: some data are missing from the previous operations (A,B,S)");
			}
			if (global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.CalculateM1(this.digest, this.N, this.A, this.pubB, this.S).Equals(clientM1))
			{
				this.M1 = clientM1;
				return true;
			}
			return false;
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x000F03A8 File Offset: 0x000EE5A8
		public virtual global::Org.BouncyCastle.Math.BigInteger CalculateServerEvidenceMessage()
		{
			if (this.A == null || this.M1 == null || this.S == null)
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("Impossible to compute M2: some data are missing from the previous operations (A,M1,S)");
			}
			this.M2 = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.CalculateM2(this.digest, this.N, this.A, this.M1, this.S);
			return this.M2;
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x000F0408 File Offset: 0x000EE608
		public virtual global::Org.BouncyCastle.Math.BigInteger CalculateSessionKey()
		{
			if (this.S == null || this.M1 == null || this.M2 == null)
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("Impossible to compute Key: some data are missing from the previous operations (S,M1,M2)");
			}
			this.Key = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.CalculateKey(this.digest, this.N, this.S);
			return this.Key;
		}

		// Token: 0x04001601 RID: 5633
		protected global::Org.BouncyCastle.Math.BigInteger N;

		// Token: 0x04001602 RID: 5634
		protected global::Org.BouncyCastle.Math.BigInteger g;

		// Token: 0x04001603 RID: 5635
		protected global::Org.BouncyCastle.Math.BigInteger v;

		// Token: 0x04001604 RID: 5636
		protected global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x04001605 RID: 5637
		protected global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04001606 RID: 5638
		protected global::Org.BouncyCastle.Math.BigInteger A;

		// Token: 0x04001607 RID: 5639
		protected global::Org.BouncyCastle.Math.BigInteger privB;

		// Token: 0x04001608 RID: 5640
		protected global::Org.BouncyCastle.Math.BigInteger pubB;

		// Token: 0x04001609 RID: 5641
		protected global::Org.BouncyCastle.Math.BigInteger u;

		// Token: 0x0400160A RID: 5642
		protected global::Org.BouncyCastle.Math.BigInteger S;

		// Token: 0x0400160B RID: 5643
		protected global::Org.BouncyCastle.Math.BigInteger M1;

		// Token: 0x0400160C RID: 5644
		protected global::Org.BouncyCastle.Math.BigInteger M2;

		// Token: 0x0400160D RID: 5645
		protected global::Org.BouncyCastle.Math.BigInteger Key;
	}
}
