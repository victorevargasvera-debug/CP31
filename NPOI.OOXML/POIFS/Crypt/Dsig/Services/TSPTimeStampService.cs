using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.X509;

namespace NPOI.POIFS.Crypt.Dsig.Services
{
	// Token: 0x0200010B RID: 267
	public class TSPTimeStampService : global::NPOI.POIFS.Crypt.Dsig.Services.ITimeStampService, global::NPOI.POIFS.Crypt.Dsig.ISignatureConfigurable
	{
		// Token: 0x06000F79 RID: 3961 RVA: 0x0003644C File Offset: 0x0003464C
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier mapDigestAlgoToOID(global::NPOI.POIFS.Crypt.HashAlgorithm digestAlgo)
		{
			string jceId = digestAlgo.jceId;
			if (jceId == "sha1")
			{
				return global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdSha1;
			}
			if (jceId == "sha256")
			{
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256;
			}
			if (jceId == "sha384")
			{
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384;
			}
			if (!(jceId == "sha512"))
			{
				throw new global::System.ArgumentException("unsupported digest algo: " + ((digestAlgo != null) ? digestAlgo.ToString() : null));
			}
			return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000364CA File Offset: 0x000346CA
		public byte[] TimeStamp(byte[] data, global::NPOI.POIFS.Crypt.Dsig.Services.RevocationData revocationData)
		{
			global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(this.signatureConfig.GetTspDigestAlgo()).Digest(data);
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x000364E8 File Offset: 0x000346E8
		public void SetSignatureConfig(global::NPOI.POIFS.Crypt.Dsig.SignatureConfig signatureConfig)
		{
			this.signatureConfig = signatureConfig;
		}

		// Token: 0x040004BF RID: 1215
		private global::NPOI.POIFS.Crypt.Dsig.SignatureConfig signatureConfig;
	}
}
