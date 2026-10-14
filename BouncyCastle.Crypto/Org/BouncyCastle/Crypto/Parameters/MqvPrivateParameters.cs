using System;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003F9 RID: 1017
	public class MqvPrivateParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x0600283C RID: 10300 RVA: 0x000AC6C0 File Offset: 0x000AA8C0
		public MqvPrivateParameters(global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters staticPrivateKey, global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters ephemeralPrivateKey) : this(staticPrivateKey, ephemeralPrivateKey, null)
		{
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x000AC6CC File Offset: 0x000AA8CC
		public MqvPrivateParameters(global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters staticPrivateKey, global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters ephemeralPrivateKey, global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey)
		{
			if (staticPrivateKey == null)
			{
				throw new global::System.ArgumentNullException("staticPrivateKey");
			}
			if (ephemeralPrivateKey == null)
			{
				throw new global::System.ArgumentNullException("ephemeralPrivateKey");
			}
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters = staticPrivateKey.Parameters;
			if (!parameters.Equals(ephemeralPrivateKey.Parameters))
			{
				throw new global::System.ArgumentException("Static and ephemeral private keys have different domain parameters");
			}
			if (ephemeralPublicKey == null)
			{
				ephemeralPublicKey = new global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(new global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier().Multiply(parameters.G, ephemeralPrivateKey.D), parameters);
			}
			else if (!parameters.Equals(ephemeralPublicKey.Parameters))
			{
				throw new global::System.ArgumentException("Ephemeral public key has different domain parameters");
			}
			this.staticPrivateKey = staticPrivateKey;
			this.ephemeralPrivateKey = ephemeralPrivateKey;
			this.ephemeralPublicKey = ephemeralPublicKey;
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x0600283E RID: 10302 RVA: 0x000AC76C File Offset: 0x000AA96C
		public virtual global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters StaticPrivateKey
		{
			get
			{
				return this.staticPrivateKey;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x000AC774 File Offset: 0x000AA974
		public virtual global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters EphemeralPrivateKey
		{
			get
			{
				return this.ephemeralPrivateKey;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06002840 RID: 10304 RVA: 0x000AC77C File Offset: 0x000AA97C
		public virtual global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters EphemeralPublicKey
		{
			get
			{
				return this.ephemeralPublicKey;
			}
		}

		// Token: 0x04001050 RID: 4176
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters staticPrivateKey;

		// Token: 0x04001051 RID: 4177
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters ephemeralPrivateKey;

		// Token: 0x04001052 RID: 4178
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey;
	}
}
