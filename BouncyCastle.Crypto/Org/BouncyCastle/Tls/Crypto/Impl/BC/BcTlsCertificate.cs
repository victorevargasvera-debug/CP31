using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200016B RID: 363
	public class BcTlsCertificate : global::Org.BouncyCastle.Tls.Crypto.TlsCertificate
	{
		// Token: 0x06000E00 RID: 3584 RVA: 0x000346FD File Offset: 0x000328FD
		public static global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCertificate Convert(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Tls.Crypto.TlsCertificate certificate)
		{
			if (certificate is global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCertificate)
			{
				return (global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCertificate)certificate;
			}
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCertificate(crypto, certificate.GetEncoded());
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0003471C File Offset: 0x0003291C
		public static global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure ParseCertificate(byte[] encoding)
		{
			global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure instance;
			try
			{
				instance = global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(encoding);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(42, e);
			}
			return instance;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00034750 File Offset: 0x00032950
		public BcTlsCertificate(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, byte[] encoding) : this(crypto, global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCertificate.ParseCertificate(encoding))
		{
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0003475F File Offset: 0x0003295F
		public BcTlsCertificate(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure certificate)
		{
			this.m_crypto = crypto;
			this.m_certificate = certificate;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00034775 File Offset: 0x00032975
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsEncryptor CreateEncryptor(int tlsCertificateRole)
		{
			this.ValidateKeyUsage(32);
			if (tlsCertificateRole == 3)
			{
				this.m_pubKeyRsa = this.GetPubKeyRsa();
				return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsRsaEncryptor(this.m_crypto, this.m_pubKeyRsa);
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x000347A8 File Offset: 0x000329A8
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsVerifier CreateVerifier(short signatureAlgorithm)
		{
			if (signatureAlgorithm - 4 <= 7)
			{
				return this.CreateVerifier(global::Org.BouncyCastle.Tls.SignatureScheme.From(8, signatureAlgorithm));
			}
			this.ValidateKeyUsage(128);
			switch (signatureAlgorithm)
			{
			case 1:
				this.ValidateRsa_Pkcs1();
				return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsRsaVerifier(this.m_crypto, this.GetPubKeyRsa());
			case 2:
				return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDsaVerifier(this.m_crypto, this.GetPubKeyDss());
			case 3:
				return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsECDsaVerifier(this.m_crypto, this.GetPubKeyEC());
			default:
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46);
			}
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00034830 File Offset: 0x00032A30
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsVerifier CreateVerifier(int signatureScheme)
		{
			this.ValidateKeyUsage(128);
			if (signatureScheme <= 1281)
			{
				if (signatureScheme <= 515)
				{
					if (signatureScheme == 513)
					{
						goto IL_EE;
					}
					if (signatureScheme != 515)
					{
						goto IL_13E;
					}
				}
				else
				{
					if (signatureScheme == 1025)
					{
						goto IL_EE;
					}
					if (signatureScheme != 1027)
					{
						if (signatureScheme != 1281)
						{
							goto IL_13E;
						}
						goto IL_EE;
					}
				}
			}
			else if (signatureScheme <= 1537)
			{
				if (signatureScheme != 1283)
				{
					if (signatureScheme != 1537)
					{
						goto IL_13E;
					}
					goto IL_EE;
				}
			}
			else if (signatureScheme != 1539)
			{
				switch (signatureScheme)
				{
				case 2052:
				case 2053:
				case 2054:
					this.ValidateRsa_Pss_Rsae();
					return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsRsaPssVerifier(this.m_crypto, this.GetPubKeyRsa(), signatureScheme);
				case 2055:
					return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsEd25519Verifier(this.m_crypto, this.GetPubKeyEd25519());
				case 2056:
					return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsEd448Verifier(this.m_crypto, this.GetPubKeyEd448());
				case 2057:
				case 2058:
				case 2059:
					this.ValidateRsa_Pss_Pss(global::Org.BouncyCastle.Tls.SignatureScheme.GetSignatureAlgorithm(signatureScheme));
					return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsRsaPssVerifier(this.m_crypto, this.GetPubKeyRsa(), signatureScheme);
				default:
					if (signatureScheme - 2074 > 2)
					{
						goto IL_13E;
					}
					break;
				}
			}
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsECDsa13Verifier(this.m_crypto, this.GetPubKeyEC(), signatureScheme);
			IL_EE:
			this.ValidateRsa_Pkcs1();
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsRsaVerifier(this.m_crypto, this.GetPubKeyRsa());
			IL_13E:
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00034982 File Offset: 0x00032B82
		public virtual byte[] GetEncoded()
		{
			return this.m_certificate.GetEncoded("DER");
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00034994 File Offset: 0x00032B94
		public virtual byte[] GetExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier extensionOid)
		{
			global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions = this.m_certificate.TbsCertificate.Extensions;
			if (extensions != null)
			{
				global::Org.BouncyCastle.Asn1.X509.X509Extension extension = extensions.GetExtension(extensionOid);
				if (extension != null)
				{
					return global::Org.BouncyCastle.Utilities.Arrays.Clone(extension.Value.GetOctets());
				}
			}
			return null;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x000349D2 File Offset: 0x00032BD2
		public virtual global::Org.BouncyCastle.Math.BigInteger SerialNumber
		{
			get
			{
				return this.m_certificate.SerialNumber.Value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000349E4 File Offset: 0x00032BE4
		public virtual string SigAlgOid
		{
			get
			{
				return this.m_certificate.SignatureAlgorithm.Algorithm.Id;
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x000349FB File Offset: 0x00032BFB
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable GetSigAlgParams()
		{
			return this.m_certificate.SignatureAlgorithm.Parameters;
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00034A10 File Offset: 0x00032C10
		public virtual short GetLegacySignatureAlgorithm()
		{
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey = this.GetPublicKey();
			if (publicKey.IsPrivate)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			if (!this.SupportsKeyUsage(128))
			{
				return -1;
			}
			if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)
			{
				return 1;
			}
			if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters)
			{
				return 2;
			}
			if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)
			{
				return 3;
			}
			return -1;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00034A64 File Offset: 0x00032C64
		public virtual global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters GetPubKeyDH()
		{
			global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters result;
			try
			{
				result = (global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)this.GetPublicKey();
			}
			catch (global::System.InvalidCastException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46, e);
			}
			return result;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00034A9C File Offset: 0x00032C9C
		public virtual global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters GetPubKeyDss()
		{
			global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters result;
			try
			{
				result = (global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters)this.GetPublicKey();
			}
			catch (global::System.InvalidCastException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46, e);
			}
			return result;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00034AD4 File Offset: 0x00032CD4
		public virtual global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters GetPubKeyEC()
		{
			global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters result;
			try
			{
				result = (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.GetPublicKey();
			}
			catch (global::System.InvalidCastException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46, e);
			}
			return result;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00034B0C File Offset: 0x00032D0C
		public virtual global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters GetPubKeyEd25519()
		{
			global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters result;
			try
			{
				result = (global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters)this.GetPublicKey();
			}
			catch (global::System.InvalidCastException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46, e);
			}
			return result;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00034B44 File Offset: 0x00032D44
		public virtual global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters GetPubKeyEd448()
		{
			global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters result;
			try
			{
				result = (global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters)this.GetPublicKey();
			}
			catch (global::System.InvalidCastException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46, e);
			}
			return result;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00034B7C File Offset: 0x00032D7C
		public virtual global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters GetPubKeyRsa()
		{
			global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters result;
			try
			{
				result = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)this.GetPublicKey();
			}
			catch (global::System.InvalidCastException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46, e);
			}
			return result;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00034BB4 File Offset: 0x00032DB4
		public virtual bool SupportsSignatureAlgorithm(short signatureAlgorithm)
		{
			return this.SupportsSignatureAlgorithm(signatureAlgorithm, 128);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00034BC2 File Offset: 0x00032DC2
		public virtual bool SupportsSignatureAlgorithmCA(short signatureAlgorithm)
		{
			return this.SupportsSignatureAlgorithm(signatureAlgorithm, 4);
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00034BCC File Offset: 0x00032DCC
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsCertificate CheckUsageInRole(int tlsCertificateRole)
		{
			if (tlsCertificateRole == 1)
			{
				this.ValidateKeyUsage(8);
				this.m_pubKeyDH = this.GetPubKeyDH();
				return this;
			}
			if (tlsCertificateRole != 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46);
			}
			this.ValidateKeyUsage(8);
			this.m_pubKeyEC = this.GetPubKeyEC();
			return this;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00034C0C File Offset: 0x00032E0C
		protected virtual global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter GetPublicKey()
		{
			global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo keyInfo = this.m_certificate.SubjectPublicKeyInfo;
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter result;
			try
			{
				result = global::Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(keyInfo);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(43, e);
			}
			return result;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00034C4C File Offset: 0x00032E4C
		protected virtual bool SupportsKeyUsage(int keyUsageBits)
		{
			global::Org.BouncyCastle.Asn1.X509.X509Extensions exts = this.m_certificate.TbsCertificate.Extensions;
			if (exts != null)
			{
				global::Org.BouncyCastle.Asn1.X509.KeyUsage ku = global::Org.BouncyCastle.Asn1.X509.KeyUsage.FromExtensions(exts);
				if (ku != null && ((int)(ku.GetBytes()[0] & 255) & keyUsageBits) != keyUsageBits)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00034C8D File Offset: 0x00032E8D
		protected virtual bool SupportsRsa_Pkcs1()
		{
			return global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.SupportsPkcs1(this.m_certificate.SubjectPublicKeyInfo.AlgorithmID);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00034CA4 File Offset: 0x00032EA4
		protected virtual bool SupportsRsa_Pss_Pss(short signatureAlgorithm)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier pubKeyAlgID = this.m_certificate.SubjectPublicKeyInfo.AlgorithmID;
			return global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.SupportsPss_Pss(signatureAlgorithm, pubKeyAlgID);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00034CC9 File Offset: 0x00032EC9
		protected virtual bool SupportsRsa_Pss_Rsae()
		{
			return global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.SupportsPss_Rsae(this.m_certificate.SubjectPublicKeyInfo.AlgorithmID);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00034CE0 File Offset: 0x00032EE0
		protected virtual bool SupportsSignatureAlgorithm(short signatureAlgorithm, int keyUsage)
		{
			if (!this.SupportsKeyUsage(keyUsage))
			{
				return false;
			}
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey = this.GetPublicKey();
			switch (signatureAlgorithm)
			{
			case 1:
				return this.SupportsRsa_Pkcs1() && publicKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters;
			case 2:
				return publicKey is global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters;
			case 3:
				break;
			case 4:
			case 5:
			case 6:
				return this.SupportsRsa_Pss_Rsae() && publicKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters;
			case 7:
				return publicKey is global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters;
			case 8:
				return publicKey is global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters;
			case 9:
			case 10:
			case 11:
				return this.SupportsRsa_Pss_Pss(signatureAlgorithm) && publicKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters;
			default:
				if (signatureAlgorithm - 26 > 2)
				{
					return false;
				}
				break;
			}
			return publicKey is global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00034DA2 File Offset: 0x00032FA2
		public virtual void ValidateKeyUsage(int keyUsageBits)
		{
			if (!this.SupportsKeyUsage(keyUsageBits))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46);
			}
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00034DB5 File Offset: 0x00032FB5
		protected virtual void ValidateRsa_Pkcs1()
		{
			if (!this.SupportsRsa_Pkcs1())
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46);
			}
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00034DC7 File Offset: 0x00032FC7
		protected virtual void ValidateRsa_Pss_Pss(short signatureAlgorithm)
		{
			if (!this.SupportsRsa_Pss_Pss(signatureAlgorithm))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46);
			}
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00034DDA File Offset: 0x00032FDA
		protected virtual void ValidateRsa_Pss_Rsae()
		{
			if (!this.SupportsRsa_Pss_Rsae())
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46);
			}
		}

		// Token: 0x04000815 RID: 2069
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;

		// Token: 0x04000816 RID: 2070
		protected readonly global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure m_certificate;

		// Token: 0x04000817 RID: 2071
		protected global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters m_pubKeyDH;

		// Token: 0x04000818 RID: 2072
		protected global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters m_pubKeyEC;

		// Token: 0x04000819 RID: 2073
		protected global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters m_pubKeyEd25519;

		// Token: 0x0400081A RID: 2074
		protected global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters m_pubKeyEd448;

		// Token: 0x0400081B RID: 2075
		protected global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters m_pubKeyRsa;
	}
}
