using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x0200040B RID: 1035
	public class SM2KeyExchangePublicParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x06002895 RID: 10389 RVA: 0x000AD0E8 File Offset: 0x000AB2E8
		public SM2KeyExchangePublicParameters(global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters staticPublicKey, global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey)
		{
			if (staticPublicKey == null)
			{
				throw new global::System.ArgumentNullException("staticPublicKey");
			}
			if (ephemeralPublicKey == null)
			{
				throw new global::System.ArgumentNullException("ephemeralPublicKey");
			}
			if (!staticPublicKey.Parameters.Equals(ephemeralPublicKey.Parameters))
			{
				throw new global::System.ArgumentException("Static and ephemeral public keys have different domain parameters");
			}
			this.mStaticPublicKey = staticPublicKey;
			this.mEphemeralPublicKey = ephemeralPublicKey;
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x000AD143 File Offset: 0x000AB343
		public virtual global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters StaticPublicKey
		{
			get
			{
				return this.mStaticPublicKey;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x000AD14B File Offset: 0x000AB34B
		public virtual global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters EphemeralPublicKey
		{
			get
			{
				return this.mEphemeralPublicKey;
			}
		}

		// Token: 0x04001083 RID: 4227
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters mStaticPublicKey;

		// Token: 0x04001084 RID: 4228
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters mEphemeralPublicKey;
	}
}
