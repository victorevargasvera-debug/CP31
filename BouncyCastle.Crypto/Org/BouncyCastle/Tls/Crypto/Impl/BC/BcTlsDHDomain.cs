using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200016E RID: 366
	public class BcTlsDHDomain : global::Org.BouncyCastle.Tls.Crypto.TlsDHDomain
	{
		// Token: 0x06000E60 RID: 3680 RVA: 0x000356F0 File Offset: 0x000338F0
		private static byte[] EncodeValue(global::Org.BouncyCastle.Crypto.Parameters.DHParameters dh, bool padded, global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (!padded)
			{
				return global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(x);
			}
			return global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDHDomain.GetValueLength(dh), x);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00035708 File Offset: 0x00033908
		private static int GetValueLength(global::Org.BouncyCastle.Crypto.Parameters.DHParameters dh)
		{
			return (dh.P.BitLength + 7) / 8;
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0003571C File Offset: 0x0003391C
		public static global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSecret CalculateDHAgreement(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters privateKey, global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters publicKey, bool padded)
		{
			global::Org.BouncyCastle.Crypto.Agreement.DHBasicAgreement dhbasicAgreement = new global::Org.BouncyCastle.Crypto.Agreement.DHBasicAgreement();
			dhbasicAgreement.Init(privateKey);
			global::Org.BouncyCastle.Math.BigInteger agreementValue = dhbasicAgreement.CalculateAgreement(publicKey);
			byte[] secret = global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDHDomain.EncodeValue(privateKey.Parameters, padded, agreementValue);
			return crypto.AdoptLocalSecret(secret);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00035754 File Offset: 0x00033954
		public static global::Org.BouncyCastle.Crypto.Parameters.DHParameters GetParameters(global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig)
		{
			global::Org.BouncyCastle.Tls.Crypto.DHGroup dhGroup = global::Org.BouncyCastle.Tls.TlsDHUtilities.GetDHGroup(dhConfig);
			if (dhGroup == null)
			{
				throw new global::System.ArgumentException("No DH configuration provided");
			}
			return new global::Org.BouncyCastle.Crypto.Parameters.DHParameters(dhGroup.P, dhGroup.G, dhGroup.Q, dhGroup.L);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00035793 File Offset: 0x00033993
		public BcTlsDHDomain(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig)
		{
			this.crypto = crypto;
			this.dhConfig = dhConfig;
			this.dhParameters = global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDHDomain.GetParameters(dhConfig);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000357B5 File Offset: 0x000339B5
		public virtual global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSecret CalculateDHAgreement(global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters privateKey, global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters publicKey)
		{
			return global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDHDomain.CalculateDHAgreement(this.crypto, privateKey, publicKey, this.dhConfig.IsPadded);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x000357CF File Offset: 0x000339CF
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsAgreement CreateDH()
		{
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDH(this);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x000357D7 File Offset: 0x000339D7
		public virtual global::Org.BouncyCastle.Math.BigInteger DecodeParameter(byte[] encoding)
		{
			if (this.dhConfig.IsPadded && global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDHDomain.GetValueLength(this.dhParameters) != encoding.Length)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, encoding);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00035808 File Offset: 0x00033A08
		public virtual global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters DecodePublicKey(byte[] encoding)
		{
			global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters result;
			try
			{
				result = new global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(this.DecodeParameter(encoding), this.dhParameters);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40, e);
			}
			return result;
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00035848 File Offset: 0x00033A48
		public virtual byte[] EncodeParameter(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDHDomain.EncodeValue(this.dhParameters, this.dhConfig.IsPadded, x);
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00035861 File Offset: 0x00033A61
		public virtual byte[] EncodePublicKey(global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters publicKey)
		{
			return global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDHDomain.EncodeValue(this.dhParameters, true, publicKey.Y);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00035875 File Offset: 0x00033A75
		public virtual global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			global::Org.BouncyCastle.Crypto.Generators.DHBasicKeyPairGenerator dhbasicKeyPairGenerator = new global::Org.BouncyCastle.Crypto.Generators.DHBasicKeyPairGenerator();
			dhbasicKeyPairGenerator.Init(new global::Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters(this.crypto.SecureRandom, this.dhParameters));
			return dhbasicKeyPairGenerator.GenerateKeyPair();
		}

		// Token: 0x04000820 RID: 2080
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto;

		// Token: 0x04000821 RID: 2081
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig;

		// Token: 0x04000822 RID: 2082
		protected readonly global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters;
	}
}
