using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001DB RID: 475
	public class BasicOcspRespGenerator
	{
		// Token: 0x0600119C RID: 4508 RVA: 0x0004DDF9 File Offset: 0x0004BFF9
		public BasicOcspRespGenerator(global::Org.BouncyCastle.Ocsp.RespID responderID)
		{
			this.responderID = responderID;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0004DE13 File Offset: 0x0004C013
		public BasicOcspRespGenerator(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			this.responderID = new global::Org.BouncyCastle.Ocsp.RespID(publicKey);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0004DE32 File Offset: 0x0004C032
		public void AddResponse(global::Org.BouncyCastle.Ocsp.CertificateID certID, global::Org.BouncyCastle.Ocsp.CertificateStatus certStatus)
		{
			this.list.Add(new global::Org.BouncyCastle.Ocsp.BasicOcspRespGenerator.ResponseObject(certID, certStatus, global::System.DateTime.UtcNow, null));
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0004DE4D File Offset: 0x0004C04D
		public void AddResponse(global::Org.BouncyCastle.Ocsp.CertificateID certID, global::Org.BouncyCastle.Ocsp.CertificateStatus certStatus, global::Org.BouncyCastle.Asn1.X509.X509Extensions singleExtensions)
		{
			this.list.Add(new global::Org.BouncyCastle.Ocsp.BasicOcspRespGenerator.ResponseObject(certID, certStatus, global::System.DateTime.UtcNow, singleExtensions));
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0004DE68 File Offset: 0x0004C068
		public void AddResponse(global::Org.BouncyCastle.Ocsp.CertificateID certID, global::Org.BouncyCastle.Ocsp.CertificateStatus certStatus, global::System.DateTime nextUpdate, global::Org.BouncyCastle.Asn1.X509.X509Extensions singleExtensions)
		{
			this.list.Add(new global::Org.BouncyCastle.Ocsp.BasicOcspRespGenerator.ResponseObject(certID, certStatus, global::System.DateTime.UtcNow, nextUpdate, singleExtensions));
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0004DE85 File Offset: 0x0004C085
		public void AddResponse(global::Org.BouncyCastle.Ocsp.CertificateID certID, global::Org.BouncyCastle.Ocsp.CertificateStatus certStatus, global::System.DateTime thisUpdate, global::System.DateTime nextUpdate, global::Org.BouncyCastle.Asn1.X509.X509Extensions singleExtensions)
		{
			this.list.Add(new global::Org.BouncyCastle.Ocsp.BasicOcspRespGenerator.ResponseObject(certID, certStatus, thisUpdate, nextUpdate, singleExtensions));
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0004DE9F File Offset: 0x0004C09F
		public void SetResponseExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions responseExtensions)
		{
			this.responseExtensions = responseExtensions;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0004DEA8 File Offset: 0x0004C0A8
		private global::Org.BouncyCastle.Ocsp.BasicOcspResp GenerateResponse(global::Org.BouncyCastle.Crypto.ISignatureFactory signatureCalculator, global::Org.BouncyCastle.X509.X509Certificate[] chain, global::System.DateTime producedAt)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier signingAlgorithm = ((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)signatureCalculator.AlgorithmDetails).Algorithm;
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector responses = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in this.list)
			{
				global::Org.BouncyCastle.Ocsp.BasicOcspRespGenerator.ResponseObject respObj = (global::Org.BouncyCastle.Ocsp.BasicOcspRespGenerator.ResponseObject)obj;
				try
				{
					responses.Add(respObj.ToResponse());
				}
				catch (global::System.Exception e)
				{
					throw new global::Org.BouncyCastle.Ocsp.OcspException("exception creating Request", e);
				}
			}
			global::Org.BouncyCastle.Asn1.Ocsp.ResponseData tbsResp = new global::Org.BouncyCastle.Asn1.Ocsp.ResponseData(this.responderID.ToAsn1Object(), new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(producedAt), new global::Org.BouncyCastle.Asn1.DerSequence(responses), this.responseExtensions);
			global::Org.BouncyCastle.Asn1.DerBitString bitSig = null;
			try
			{
				global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator = signatureCalculator.CreateCalculator();
				byte[] encoded = tbsResp.GetDerEncoded();
				streamCalculator.Stream.Write(encoded, 0, encoded.Length);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(streamCalculator.Stream);
				bitSig = new global::Org.BouncyCastle.Asn1.DerBitString(((global::Org.BouncyCastle.Crypto.IBlockResult)streamCalculator.GetResult()).Collect());
			}
			catch (global::System.Exception e2)
			{
				string str = "exception processing TBSRequest: ";
				global::System.Exception ex = e2;
				throw new global::Org.BouncyCastle.Ocsp.OcspException(str + ((ex != null) ? ex.ToString() : null), e2);
			}
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId = global::Org.BouncyCastle.Ocsp.OcspUtilities.GetSigAlgID(signingAlgorithm);
			global::Org.BouncyCastle.Asn1.DerSequence chainSeq = null;
			if (chain != null && chain.Length != 0)
			{
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
				try
				{
					for (int i = 0; i != chain.Length; i++)
					{
						v.Add(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(chain[i].GetEncoded())));
					}
				}
				catch (global::System.IO.IOException e3)
				{
					throw new global::Org.BouncyCastle.Ocsp.OcspException("error processing certs", e3);
				}
				catch (global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException e4)
				{
					throw new global::Org.BouncyCastle.Ocsp.OcspException("error encoding certs", e4);
				}
				chainSeq = new global::Org.BouncyCastle.Asn1.DerSequence(v);
			}
			return new global::Org.BouncyCastle.Ocsp.BasicOcspResp(new global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse(tbsResp, sigAlgId, bitSig, chainSeq));
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0004E070 File Offset: 0x0004C270
		public global::Org.BouncyCastle.Ocsp.BasicOcspResp Generate(string signingAlgorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate[] chain, global::System.DateTime thisUpdate)
		{
			return this.Generate(signingAlgorithm, privateKey, chain, thisUpdate, null);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0004E07E File Offset: 0x0004C27E
		public global::Org.BouncyCastle.Ocsp.BasicOcspResp Generate(string signingAlgorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate[] chain, global::System.DateTime producedAt, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (signingAlgorithm == null)
			{
				throw new global::System.ArgumentException("no signing algorithm specified");
			}
			return this.GenerateResponse(new global::Org.BouncyCastle.Crypto.Operators.Asn1SignatureFactory(signingAlgorithm, privateKey, random), chain, producedAt);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0004E0A0 File Offset: 0x0004C2A0
		public global::Org.BouncyCastle.Ocsp.BasicOcspResp Generate(global::Org.BouncyCastle.Crypto.ISignatureFactory signatureCalculatorFactory, global::Org.BouncyCastle.X509.X509Certificate[] chain, global::System.DateTime producedAt)
		{
			if (signatureCalculatorFactory == null)
			{
				throw new global::System.ArgumentException("no signature calculator specified");
			}
			return this.GenerateResponse(signatureCalculatorFactory, chain, producedAt);
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x0004E0B9 File Offset: 0x0004C2B9
		public global::System.Collections.IEnumerable SignatureAlgNames
		{
			get
			{
				return global::Org.BouncyCastle.Ocsp.OcspUtilities.AlgNames;
			}
		}

		// Token: 0x040008E2 RID: 2274
		private readonly global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x040008E3 RID: 2275
		private global::Org.BouncyCastle.Asn1.X509.X509Extensions responseExtensions;

		// Token: 0x040008E4 RID: 2276
		private global::Org.BouncyCastle.Ocsp.RespID responderID;

		// Token: 0x020007B9 RID: 1977
		private class ResponseObject
		{
			// Token: 0x06004547 RID: 17735 RVA: 0x00132E53 File Offset: 0x00131053
			public ResponseObject(global::Org.BouncyCastle.Ocsp.CertificateID certId, global::Org.BouncyCastle.Ocsp.CertificateStatus certStatus, global::System.DateTime thisUpdate, global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions) : this(certId, certStatus, new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(thisUpdate), null, extensions)
			{
			}

			// Token: 0x06004548 RID: 17736 RVA: 0x00132E66 File Offset: 0x00131066
			public ResponseObject(global::Org.BouncyCastle.Ocsp.CertificateID certId, global::Org.BouncyCastle.Ocsp.CertificateStatus certStatus, global::System.DateTime thisUpdate, global::System.DateTime nextUpdate, global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions) : this(certId, certStatus, new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(thisUpdate), new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(nextUpdate), extensions)
			{
			}

			// Token: 0x06004549 RID: 17737 RVA: 0x00132E80 File Offset: 0x00131080
			private ResponseObject(global::Org.BouncyCastle.Ocsp.CertificateID certId, global::Org.BouncyCastle.Ocsp.CertificateStatus certStatus, global::Org.BouncyCastle.Asn1.DerGeneralizedTime thisUpdate, global::Org.BouncyCastle.Asn1.DerGeneralizedTime nextUpdate, global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
			{
				this.certId = certId;
				if (certStatus == null)
				{
					this.certStatus = new global::Org.BouncyCastle.Asn1.Ocsp.CertStatus();
				}
				else if (certStatus is global::Org.BouncyCastle.Ocsp.UnknownStatus)
				{
					this.certStatus = new global::Org.BouncyCastle.Asn1.Ocsp.CertStatus(2, global::Org.BouncyCastle.Asn1.DerNull.Instance);
				}
				else
				{
					global::Org.BouncyCastle.Ocsp.RevokedStatus rs = (global::Org.BouncyCastle.Ocsp.RevokedStatus)certStatus;
					global::Org.BouncyCastle.Asn1.X509.CrlReason revocationReason = rs.HasRevocationReason ? new global::Org.BouncyCastle.Asn1.X509.CrlReason(rs.RevocationReason) : null;
					this.certStatus = new global::Org.BouncyCastle.Asn1.Ocsp.CertStatus(new global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo(new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(rs.RevocationTime), revocationReason));
				}
				this.thisUpdate = thisUpdate;
				this.nextUpdate = nextUpdate;
				this.extensions = extensions;
			}

			// Token: 0x0600454A RID: 17738 RVA: 0x00132F16 File Offset: 0x00131116
			public global::Org.BouncyCastle.Asn1.Ocsp.SingleResponse ToResponse()
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.SingleResponse(this.certId.ToAsn1Object(), this.certStatus, this.thisUpdate, this.nextUpdate, this.extensions);
			}

			// Token: 0x040023D9 RID: 9177
			internal global::Org.BouncyCastle.Ocsp.CertificateID certId;

			// Token: 0x040023DA RID: 9178
			internal global::Org.BouncyCastle.Asn1.Ocsp.CertStatus certStatus;

			// Token: 0x040023DB RID: 9179
			internal global::Org.BouncyCastle.Asn1.DerGeneralizedTime thisUpdate;

			// Token: 0x040023DC RID: 9180
			internal global::Org.BouncyCastle.Asn1.DerGeneralizedTime nextUpdate;

			// Token: 0x040023DD RID: 9181
			internal global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions;
		}
	}
}
