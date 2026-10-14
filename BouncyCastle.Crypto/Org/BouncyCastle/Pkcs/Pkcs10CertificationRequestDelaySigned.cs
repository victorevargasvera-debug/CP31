using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001AC RID: 428
	public class Pkcs10CertificationRequestDelaySigned : global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest
	{
		// Token: 0x0600103C RID: 4156 RVA: 0x00040D7C File Offset: 0x0003EF7C
		protected Pkcs10CertificationRequestDelaySigned()
		{
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00040D84 File Offset: 0x0003EF84
		public Pkcs10CertificationRequestDelaySigned(byte[] encoded) : base(encoded)
		{
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00040D8D File Offset: 0x0003EF8D
		public Pkcs10CertificationRequestDelaySigned(global::Org.BouncyCastle.Asn1.Asn1Sequence seq) : base(seq)
		{
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00040D96 File Offset: 0x0003EF96
		public Pkcs10CertificationRequestDelaySigned(global::System.IO.Stream input) : base(input)
		{
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00040D9F File Offset: 0x0003EF9F
		public Pkcs10CertificationRequestDelaySigned(string signatureAlgorithm, global::Org.BouncyCastle.Asn1.X509.X509Name subject, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, global::Org.BouncyCastle.Asn1.Asn1Set attributes, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter signingKey) : base(signatureAlgorithm, subject, publicKey, attributes, signingKey)
		{
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00040DB0 File Offset: 0x0003EFB0
		public Pkcs10CertificationRequestDelaySigned(string signatureAlgorithm, global::Org.BouncyCastle.Asn1.X509.X509Name subject, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, global::Org.BouncyCastle.Asn1.Asn1Set attributes)
		{
			if (signatureAlgorithm == null)
			{
				throw new global::System.ArgumentNullException("signatureAlgorithm");
			}
			if (subject == null)
			{
				throw new global::System.ArgumentNullException("subject");
			}
			if (publicKey == null)
			{
				throw new global::System.ArgumentNullException("publicKey");
			}
			if (publicKey.IsPrivate)
			{
				throw new global::System.ArgumentException("expected public key", "publicKey");
			}
			string algorithmName = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(signatureAlgorithm);
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigOid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms[algorithmName];
			if (sigOid == null)
			{
				try
				{
					sigOid = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(algorithmName);
				}
				catch (global::System.Exception e)
				{
					throw new global::System.ArgumentException("Unknown signature type requested", e);
				}
			}
			if (global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.noParams.Contains(sigOid))
			{
				this.sigAlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOid);
			}
			else if (global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.exParams.Contains(algorithmName))
			{
				this.sigAlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOid, (global::Org.BouncyCastle.Asn1.Asn1Encodable)global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.exParams[algorithmName]);
			}
			else
			{
				this.sigAlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOid, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			}
			global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo pubInfo = global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(publicKey);
			this.reqInfo = new global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo(subject, pubInfo, attributes);
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00040EB4 File Offset: 0x0003F0B4
		public byte[] GetDataToSign()
		{
			return this.reqInfo.GetDerEncoded();
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00040EC1 File Offset: 0x0003F0C1
		public void SignRequest(byte[] signedData)
		{
			this.sigBits = new global::Org.BouncyCastle.Asn1.DerBitString(signedData);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00040ECF File Offset: 0x0003F0CF
		public void SignRequest(global::Org.BouncyCastle.Asn1.DerBitString signedData)
		{
			this.sigBits = signedData;
		}
	}
}
