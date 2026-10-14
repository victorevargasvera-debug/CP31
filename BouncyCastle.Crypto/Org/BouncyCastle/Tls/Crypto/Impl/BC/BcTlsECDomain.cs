using System;
using System.IO;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.EC;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000174 RID: 372
	public class BcTlsECDomain : global::Org.BouncyCastle.Tls.Crypto.TlsECDomain
	{
		// Token: 0x06000E7E RID: 3710 RVA: 0x00035ACC File Offset: 0x00033CCC
		public static global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSecret CalculateBasicAgreement(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privateKey, global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters publicKey)
		{
			global::Org.BouncyCastle.Crypto.Agreement.ECDHBasicAgreement ecdhbasicAgreement = new global::Org.BouncyCastle.Crypto.Agreement.ECDHBasicAgreement();
			ecdhbasicAgreement.Init(privateKey);
			global::Org.BouncyCastle.Math.BigInteger agreementValue = ecdhbasicAgreement.CalculateAgreement(publicKey);
			byte[] secret = global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(ecdhbasicAgreement.GetFieldSize(), agreementValue);
			return crypto.AdoptLocalSecret(secret);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00035B00 File Offset: 0x00033D00
		public static global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters GetDomainParameters(global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig)
		{
			return global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsECDomain.GetDomainParameters(ecConfig.NamedGroup);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00035B10 File Offset: 0x00033D10
		public static global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters GetDomainParameters(int namedGroup)
		{
			if (!global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificCurve(namedGroup))
			{
				return null;
			}
			string curveName = global::Org.BouncyCastle.Tls.NamedGroup.GetCurveName(namedGroup);
			global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecP = global::Org.BouncyCastle.Crypto.EC.CustomNamedCurves.GetByName(curveName);
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.X9.ECNamedCurveTable.GetByName(curveName);
				if (ecP == null)
				{
					return null;
				}
			}
			return new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(ecP.Curve, ecP.G, ecP.N, ecP.H, ecP.GetSeed());
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00035B67 File Offset: 0x00033D67
		public BcTlsECDomain(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig)
		{
			this.m_crypto = crypto;
			this.m_ecConfig = ecConfig;
			this.m_ecDomainParameters = global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsECDomain.GetDomainParameters(ecConfig);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00035B89 File Offset: 0x00033D89
		public virtual global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSecret CalculateECDHAgreement(global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privateKey, global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters publicKey)
		{
			return global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsECDomain.CalculateBasicAgreement(this.m_crypto, privateKey, publicKey);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00035B98 File Offset: 0x00033D98
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsAgreement CreateECDH()
		{
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsECDH(this);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00035BA0 File Offset: 0x00033DA0
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint DecodePoint(byte[] encoding)
		{
			return this.m_ecDomainParameters.Curve.DecodePoint(encoding);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00035BB4 File Offset: 0x00033DB4
		public virtual global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters DecodePublicKey(byte[] encoding)
		{
			global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters result;
			try
			{
				result = new global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(this.DecodePoint(encoding), this.m_ecDomainParameters);
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47, e);
			}
			return result;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00035C00 File Offset: 0x00033E00
		public virtual byte[] EncodePoint(global::Org.BouncyCastle.Math.EC.ECPoint point)
		{
			return point.GetEncoded(false);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00035C09 File Offset: 0x00033E09
		public virtual byte[] EncodePublicKey(global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters publicKey)
		{
			return this.EncodePoint(publicKey.Q);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00035C17 File Offset: 0x00033E17
		public virtual global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator eckeyPairGenerator = new global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator();
			eckeyPairGenerator.Init(new global::Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters(this.m_ecDomainParameters, this.m_crypto.SecureRandom));
			return eckeyPairGenerator.GenerateKeyPair();
		}

		// Token: 0x04000826 RID: 2086
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;

		// Token: 0x04000827 RID: 2087
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsECConfig m_ecConfig;

		// Token: 0x04000828 RID: 2088
		protected readonly global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters m_ecDomainParameters;
	}
}
