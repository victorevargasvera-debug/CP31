using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Agreement.Srp
{
	// Token: 0x020004F7 RID: 1271
	public class Srp6Client
	{
		// Token: 0x060031E7 RID: 12775 RVA: 0x000EFF1B File Offset: 0x000EE11B
		public virtual void Init(global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.N = N;
			this.g = g;
			this.digest = digest;
			this.random = random;
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x000EFF3A File Offset: 0x000EE13A
		public virtual void Init(global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters group, global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.Init(group.N, group.G, digest, random);
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x000EFF50 File Offset: 0x000EE150
		public virtual global::Org.BouncyCastle.Math.BigInteger GenerateClientCredentials(byte[] salt, byte[] identity, byte[] password)
		{
			this.x = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.CalculateX(this.digest, this.N, salt, identity, password);
			this.privA = this.SelectPrivateValue();
			this.pubA = this.g.ModPow(this.privA, this.N);
			return this.pubA;
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x000EFFA8 File Offset: 0x000EE1A8
		public virtual global::Org.BouncyCastle.Math.BigInteger CalculateSecret(global::Org.BouncyCastle.Math.BigInteger serverB)
		{
			this.B = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.ValidatePublicValue(this.N, serverB);
			this.u = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.CalculateU(this.digest, this.N, this.pubA, this.B);
			this.S = this.CalculateS();
			return this.S;
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x000EFFFC File Offset: 0x000EE1FC
		protected virtual global::Org.BouncyCastle.Math.BigInteger SelectPrivateValue()
		{
			return global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.GeneratePrivateValue(this.digest, this.N, this.g, this.random);
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x000F001C File Offset: 0x000EE21C
		private global::Org.BouncyCastle.Math.BigInteger CalculateS()
		{
			global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.CalculateK(this.digest, this.N, this.g);
			global::Org.BouncyCastle.Math.BigInteger exp = this.u.Multiply(this.x).Add(this.privA);
			global::Org.BouncyCastle.Math.BigInteger tmp = this.g.ModPow(this.x, this.N).Multiply(i).Mod(this.N);
			return this.B.Subtract(tmp).Mod(this.N).ModPow(exp, this.N);
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x000F00AC File Offset: 0x000EE2AC
		public virtual global::Org.BouncyCastle.Math.BigInteger CalculateClientEvidenceMessage()
		{
			if (this.pubA == null || this.B == null || this.S == null)
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("Impossible to compute M1: some data are missing from the previous operations (A,B,S)");
			}
			this.M1 = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.CalculateM1(this.digest, this.N, this.pubA, this.B, this.S);
			return this.M1;
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x000F010C File Offset: 0x000EE30C
		public virtual bool VerifyServerEvidenceMessage(global::Org.BouncyCastle.Math.BigInteger serverM2)
		{
			if (this.pubA == null || this.M1 == null || this.S == null)
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("Impossible to compute and verify M2: some data are missing from the previous operations (A,M1,S)");
			}
			if (global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.CalculateM2(this.digest, this.N, this.pubA, this.M1, this.S).Equals(serverM2))
			{
				this.M2 = serverM2;
				return true;
			}
			return false;
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x000F0174 File Offset: 0x000EE374
		public virtual global::Org.BouncyCastle.Math.BigInteger CalculateSessionKey()
		{
			if (this.S == null || this.M1 == null || this.M2 == null)
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("Impossible to compute Key: some data are missing from the previous operations (S,M1,M2)");
			}
			this.Key = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.CalculateKey(this.digest, this.N, this.S);
			return this.Key;
		}

		// Token: 0x040015F4 RID: 5620
		protected global::Org.BouncyCastle.Math.BigInteger N;

		// Token: 0x040015F5 RID: 5621
		protected global::Org.BouncyCastle.Math.BigInteger g;

		// Token: 0x040015F6 RID: 5622
		protected global::Org.BouncyCastle.Math.BigInteger privA;

		// Token: 0x040015F7 RID: 5623
		protected global::Org.BouncyCastle.Math.BigInteger pubA;

		// Token: 0x040015F8 RID: 5624
		protected global::Org.BouncyCastle.Math.BigInteger B;

		// Token: 0x040015F9 RID: 5625
		protected global::Org.BouncyCastle.Math.BigInteger x;

		// Token: 0x040015FA RID: 5626
		protected global::Org.BouncyCastle.Math.BigInteger u;

		// Token: 0x040015FB RID: 5627
		protected global::Org.BouncyCastle.Math.BigInteger S;

		// Token: 0x040015FC RID: 5628
		protected global::Org.BouncyCastle.Math.BigInteger M1;

		// Token: 0x040015FD RID: 5629
		protected global::Org.BouncyCastle.Math.BigInteger M2;

		// Token: 0x040015FE RID: 5630
		protected global::Org.BouncyCastle.Math.BigInteger Key;

		// Token: 0x040015FF RID: 5631
		protected global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04001600 RID: 5632
		protected global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
