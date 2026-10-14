using System;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x0200040A RID: 1034
	public class SM2KeyExchangePrivateParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x0600288F RID: 10383 RVA: 0x000AD01C File Offset: 0x000AB21C
		public SM2KeyExchangePrivateParameters(bool initiator, global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters staticPrivateKey, global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters ephemeralPrivateKey)
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
			global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier i = new global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier();
			this.mInitiator = initiator;
			this.mStaticPrivateKey = staticPrivateKey;
			this.mStaticPublicPoint = i.Multiply(parameters.G, staticPrivateKey.D).Normalize();
			this.mEphemeralPrivateKey = ephemeralPrivateKey;
			this.mEphemeralPublicPoint = i.Multiply(parameters.G, ephemeralPrivateKey.D).Normalize();
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x000AD0C0 File Offset: 0x000AB2C0
		public virtual bool IsInitiator
		{
			get
			{
				return this.mInitiator;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06002891 RID: 10385 RVA: 0x000AD0C8 File Offset: 0x000AB2C8
		public virtual global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters StaticPrivateKey
		{
			get
			{
				return this.mStaticPrivateKey;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x000AD0D0 File Offset: 0x000AB2D0
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint StaticPublicPoint
		{
			get
			{
				return this.mStaticPublicPoint;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x000AD0D8 File Offset: 0x000AB2D8
		public virtual global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters EphemeralPrivateKey
		{
			get
			{
				return this.mEphemeralPrivateKey;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x000AD0E0 File Offset: 0x000AB2E0
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint EphemeralPublicPoint
		{
			get
			{
				return this.mEphemeralPublicPoint;
			}
		}

		// Token: 0x0400107E RID: 4222
		private readonly bool mInitiator;

		// Token: 0x0400107F RID: 4223
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mStaticPrivateKey;

		// Token: 0x04001080 RID: 4224
		private readonly global::Org.BouncyCastle.Math.EC.ECPoint mStaticPublicPoint;

		// Token: 0x04001081 RID: 4225
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mEphemeralPrivateKey;

		// Token: 0x04001082 RID: 4226
		private readonly global::Org.BouncyCastle.Math.EC.ECPoint mEphemeralPublicPoint;
	}
}
