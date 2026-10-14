using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001E0 RID: 480
	public class OcspReqGenerator
	{
		// Token: 0x060011CA RID: 4554 RVA: 0x0004E679 File Offset: 0x0004C879
		public void AddRequest(global::Org.BouncyCastle.Ocsp.CertificateID certId)
		{
			this.list.Add(new global::Org.BouncyCastle.Ocsp.OcspReqGenerator.RequestObject(certId, null));
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0004E68E File Offset: 0x0004C88E
		public void AddRequest(global::Org.BouncyCastle.Ocsp.CertificateID certId, global::Org.BouncyCastle.Asn1.X509.X509Extensions singleRequestExtensions)
		{
			this.list.Add(new global::Org.BouncyCastle.Ocsp.OcspReqGenerator.RequestObject(certId, singleRequestExtensions));
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0004E6A4 File Offset: 0x0004C8A4
		public void SetRequestorName(global::Org.BouncyCastle.Asn1.X509.X509Name requestorName)
		{
			try
			{
				this.requestorName = new global::Org.BouncyCastle.Asn1.X509.GeneralName(4, requestorName);
			}
			catch (global::System.Exception e)
			{
				throw new global::System.ArgumentException("cannot encode principal", e);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0004E6E0 File Offset: 0x0004C8E0
		public void SetRequestorName(global::Org.BouncyCastle.Asn1.X509.GeneralName requestorName)
		{
			this.requestorName = requestorName;
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0004E6E9 File Offset: 0x0004C8E9
		public void SetRequestExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions requestExtensions)
		{
			this.requestExtensions = requestExtensions;
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0004E6F4 File Offset: 0x0004C8F4
		private global::Org.BouncyCastle.Ocsp.OcspReq GenerateRequest(global::Org.BouncyCastle.Asn1.DerObjectIdentifier signingAlgorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate[] chain, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector requests = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in this.list)
			{
				global::Org.BouncyCastle.Ocsp.OcspReqGenerator.RequestObject reqObj = (global::Org.BouncyCastle.Ocsp.OcspReqGenerator.RequestObject)obj;
				try
				{
					requests.Add(reqObj.ToRequest());
				}
				catch (global::System.Exception e)
				{
					throw new global::Org.BouncyCastle.Ocsp.OcspException("exception creating Request", e);
				}
			}
			global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest tbsReq = new global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest(this.requestorName, new global::Org.BouncyCastle.Asn1.DerSequence(requests), this.requestExtensions);
			global::Org.BouncyCastle.Crypto.ISigner sig = null;
			global::Org.BouncyCastle.Asn1.Ocsp.Signature signature = null;
			if (signingAlgorithm != null)
			{
				if (this.requestorName == null)
				{
					throw new global::Org.BouncyCastle.Ocsp.OcspException("requestorName must be specified if request is signed.");
				}
				try
				{
					sig = global::Org.BouncyCastle.Security.SignerUtilities.GetSigner(signingAlgorithm.Id);
					if (random != null)
					{
						sig.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(privateKey, random));
					}
					else
					{
						sig.Init(true, privateKey);
					}
				}
				catch (global::System.Exception e2)
				{
					string str = "exception creating signature: ";
					global::System.Exception ex = e2;
					throw new global::Org.BouncyCastle.Ocsp.OcspException(str + ((ex != null) ? ex.ToString() : null), e2);
				}
				global::Org.BouncyCastle.Asn1.DerBitString bitSig = null;
				try
				{
					byte[] encoded = tbsReq.GetEncoded();
					sig.BlockUpdate(encoded, 0, encoded.Length);
					bitSig = new global::Org.BouncyCastle.Asn1.DerBitString(sig.GenerateSignature());
				}
				catch (global::System.Exception e3)
				{
					string str2 = "exception processing TBSRequest: ";
					global::System.Exception ex2 = e3;
					throw new global::Org.BouncyCastle.Ocsp.OcspException(str2 + ((ex2 != null) ? ex2.ToString() : null), e3);
				}
				global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(signingAlgorithm, global::Org.BouncyCastle.Asn1.DerNull.Instance);
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
					catch (global::System.IO.IOException e4)
					{
						throw new global::Org.BouncyCastle.Ocsp.OcspException("error processing certs", e4);
					}
					catch (global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException e5)
					{
						throw new global::Org.BouncyCastle.Ocsp.OcspException("error encoding certs", e5);
					}
					signature = new global::Org.BouncyCastle.Asn1.Ocsp.Signature(sigAlgId, bitSig, new global::Org.BouncyCastle.Asn1.DerSequence(v));
				}
				else
				{
					signature = new global::Org.BouncyCastle.Asn1.Ocsp.Signature(sigAlgId, bitSig);
				}
			}
			return new global::Org.BouncyCastle.Ocsp.OcspReq(new global::Org.BouncyCastle.Asn1.Ocsp.OcspRequest(tbsReq, signature));
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0004E90C File Offset: 0x0004CB0C
		public global::Org.BouncyCastle.Ocsp.OcspReq Generate()
		{
			return this.GenerateRequest(null, null, null, null);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0004E918 File Offset: 0x0004CB18
		public global::Org.BouncyCastle.Ocsp.OcspReq Generate(string signingAlgorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate[] chain)
		{
			return this.Generate(signingAlgorithm, privateKey, chain, null);
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0004E924 File Offset: 0x0004CB24
		public global::Org.BouncyCastle.Ocsp.OcspReq Generate(string signingAlgorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate[] chain, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (signingAlgorithm == null)
			{
				throw new global::System.ArgumentException("no signing algorithm specified");
			}
			global::Org.BouncyCastle.Ocsp.OcspReq result;
			try
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = global::Org.BouncyCastle.Ocsp.OcspUtilities.GetAlgorithmOid(signingAlgorithm);
				result = this.GenerateRequest(oid, privateKey, chain, random);
			}
			catch (global::System.ArgumentException)
			{
				throw new global::System.ArgumentException("unknown signing algorithm specified: " + signingAlgorithm);
			}
			return result;
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0004E978 File Offset: 0x0004CB78
		public global::System.Collections.IEnumerable SignatureAlgNames
		{
			get
			{
				return global::Org.BouncyCastle.Ocsp.OcspUtilities.AlgNames;
			}
		}

		// Token: 0x040008E9 RID: 2281
		private global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x040008EA RID: 2282
		private global::Org.BouncyCastle.Asn1.X509.GeneralName requestorName;

		// Token: 0x040008EB RID: 2283
		private global::Org.BouncyCastle.Asn1.X509.X509Extensions requestExtensions;

		// Token: 0x020007BA RID: 1978
		private class RequestObject
		{
			// Token: 0x0600454B RID: 17739 RVA: 0x00132F40 File Offset: 0x00131140
			public RequestObject(global::Org.BouncyCastle.Ocsp.CertificateID certId, global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
			{
				this.certId = certId;
				this.extensions = extensions;
			}

			// Token: 0x0600454C RID: 17740 RVA: 0x00132F56 File Offset: 0x00131156
			public global::Org.BouncyCastle.Asn1.Ocsp.Request ToRequest()
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.Request(this.certId.ToAsn1Object(), this.extensions);
			}

			// Token: 0x040023DE RID: 9182
			internal global::Org.BouncyCastle.Ocsp.CertificateID certId;

			// Token: 0x040023DF RID: 9183
			internal global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions;
		}
	}
}
