using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000406 RID: 1030
	public class RsaKeyGenerationParameters : global::Org.BouncyCastle.Crypto.KeyGenerationParameters
	{
		// Token: 0x06002870 RID: 10352 RVA: 0x000ACB00 File Offset: 0x000AAD00
		public RsaKeyGenerationParameters(global::Org.BouncyCastle.Math.BigInteger publicExponent, global::Org.BouncyCastle.Security.SecureRandom random, int strength, int certainty) : base(random, strength)
		{
			this.publicExponent = publicExponent;
			this.certainty = certainty;
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x000ACB19 File Offset: 0x000AAD19
		public global::Org.BouncyCastle.Math.BigInteger PublicExponent
		{
			get
			{
				return this.publicExponent;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06002872 RID: 10354 RVA: 0x000ACB21 File Offset: 0x000AAD21
		public int Certainty
		{
			get
			{
				return this.certainty;
			}
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x000ACB2C File Offset: 0x000AAD2C
		public override bool Equals(object obj)
		{
			global::Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters;
			return other != null && this.certainty == other.certainty && this.publicExponent.Equals(other.publicExponent);
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x000ACB68 File Offset: 0x000AAD68
		public override int GetHashCode()
		{
			return this.certainty.GetHashCode() ^ this.publicExponent.GetHashCode();
		}

		// Token: 0x0400106A RID: 4202
		private readonly global::Org.BouncyCastle.Math.BigInteger publicExponent;

		// Token: 0x0400106B RID: 4203
		private readonly int certainty;
	}
}
