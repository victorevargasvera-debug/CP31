using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003FA RID: 1018
	public class MqvPublicParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x06002841 RID: 10305 RVA: 0x000AC784 File Offset: 0x000AA984
		public MqvPublicParameters(global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters staticPublicKey, global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey)
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
			this.staticPublicKey = staticPublicKey;
			this.ephemeralPublicKey = ephemeralPublicKey;
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06002842 RID: 10306 RVA: 0x000AC7DF File Offset: 0x000AA9DF
		public virtual global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters StaticPublicKey
		{
			get
			{
				return this.staticPublicKey;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x000AC7E7 File Offset: 0x000AA9E7
		public virtual global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters EphemeralPublicKey
		{
			get
			{
				return this.ephemeralPublicKey;
			}
		}

		// Token: 0x04001053 RID: 4179
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters staticPublicKey;

		// Token: 0x04001054 RID: 4180
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey;
	}
}
