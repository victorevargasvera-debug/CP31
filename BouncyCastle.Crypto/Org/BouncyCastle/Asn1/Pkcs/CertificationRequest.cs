using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006AB RID: 1707
	public class CertificationRequest : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E93 RID: 16019 RVA: 0x0011D7D8 File Offset: 0x0011B9D8
		public static global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequest GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequest)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequest)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequest((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			return null;
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x0011D7F9 File Offset: 0x0011B9F9
		protected CertificationRequest()
		{
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x0011D801 File Offset: 0x0011BA01
		public CertificationRequest(global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo requestInfo, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithm, global::Org.BouncyCastle.Asn1.DerBitString signature)
		{
			this.reqInfo = requestInfo;
			this.sigAlgId = algorithm;
			this.sigBits = signature;
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x0011D820 File Offset: 0x0011BA20
		[global::System.Obsolete("Use 'GetInstance' instead")]
		public CertificationRequest(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 3)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.reqInfo = global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo.GetInstance(seq[0]);
			this.sigAlgId = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[1]);
			this.sigBits = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[2]);
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x0011D882 File Offset: 0x0011BA82
		public global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo GetCertificationRequestInfo()
		{
			return this.reqInfo;
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06003E98 RID: 16024 RVA: 0x0011D88A File Offset: 0x0011BA8A
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm
		{
			get
			{
				return this.sigAlgId;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06003E99 RID: 16025 RVA: 0x0011D892 File Offset: 0x0011BA92
		public global::Org.BouncyCastle.Asn1.DerBitString Signature
		{
			get
			{
				return this.sigBits;
			}
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x0011D89A File Offset: 0x0011BA9A
		public byte[] GetSignatureOctets()
		{
			return this.sigBits.GetOctets();
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x0011D8A7 File Offset: 0x0011BAA7
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.reqInfo,
				this.sigAlgId,
				this.sigBits
			});
		}

		// Token: 0x04001C67 RID: 7271
		protected global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo reqInfo;

		// Token: 0x04001C68 RID: 7272
		protected global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId;

		// Token: 0x04001C69 RID: 7273
		protected global::Org.BouncyCastle.Asn1.DerBitString sigBits;
	}
}
