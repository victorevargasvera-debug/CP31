using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001DF RID: 479
	public class OcspReq : global::Org.BouncyCastle.X509.X509ExtensionBase
	{
		// Token: 0x060011B8 RID: 4536 RVA: 0x0004E2CF File Offset: 0x0004C4CF
		public OcspReq(global::Org.BouncyCastle.Asn1.Ocsp.OcspRequest req)
		{
			this.req = req;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0004E2DE File Offset: 0x0004C4DE
		public OcspReq(byte[] req) : this(new global::Org.BouncyCastle.Asn1.Asn1InputStream(req))
		{
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0004E2EC File Offset: 0x0004C4EC
		public OcspReq(global::System.IO.Stream inStr) : this(new global::Org.BouncyCastle.Asn1.Asn1InputStream(inStr))
		{
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0004E2FC File Offset: 0x0004C4FC
		private OcspReq(global::Org.BouncyCastle.Asn1.Asn1InputStream aIn)
		{
			try
			{
				this.req = global::Org.BouncyCastle.Asn1.Ocsp.OcspRequest.GetInstance(aIn.ReadObject());
			}
			catch (global::System.ArgumentException e)
			{
				throw new global::System.IO.IOException("malformed request: " + e.Message);
			}
			catch (global::System.InvalidCastException e2)
			{
				throw new global::System.IO.IOException("malformed request: " + e2.Message);
			}
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0004E36C File Offset: 0x0004C56C
		public byte[] GetTbsRequest()
		{
			byte[] encoded;
			try
			{
				encoded = this.req.TbsRequest.GetEncoded();
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Ocsp.OcspException("problem encoding tbsRequest", e);
			}
			return encoded;
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x0004E3AC File Offset: 0x0004C5AC
		public int Version
		{
			get
			{
				return this.req.TbsRequest.Version.IntValueExact + 1;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x0004E3C5 File Offset: 0x0004C5C5
		public global::Org.BouncyCastle.Asn1.X509.GeneralName RequestorName
		{
			get
			{
				return global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(this.req.TbsRequest.RequestorName);
			}
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0004E3DC File Offset: 0x0004C5DC
		public global::Org.BouncyCastle.Ocsp.Req[] GetRequestList()
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence seq = this.req.TbsRequest.RequestList;
			global::Org.BouncyCastle.Ocsp.Req[] requests = new global::Org.BouncyCastle.Ocsp.Req[seq.Count];
			for (int i = 0; i != requests.Length; i++)
			{
				requests[i] = new global::Org.BouncyCastle.Ocsp.Req(global::Org.BouncyCastle.Asn1.Ocsp.Request.GetInstance(seq[i]));
			}
			return requests;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0004E429 File Offset: 0x0004C629
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions RequestExtensions
		{
			get
			{
				return global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(this.req.TbsRequest.RequestExtensions);
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0004E440 File Offset: 0x0004C640
		protected override global::Org.BouncyCastle.Asn1.X509.X509Extensions GetX509Extensions()
		{
			return this.RequestExtensions;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x0004E448 File Offset: 0x0004C648
		public string SignatureAlgOid
		{
			get
			{
				if (!this.IsSigned)
				{
					return null;
				}
				return this.req.OptionalSignature.SignatureAlgorithm.Algorithm.Id;
			}
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0004E46E File Offset: 0x0004C66E
		public byte[] GetSignature()
		{
			if (!this.IsSigned)
			{
				return null;
			}
			return this.req.OptionalSignature.GetSignatureOctets();
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0004E48C File Offset: 0x0004C68C
		private global::System.Collections.IList GetCertList()
		{
			global::System.Collections.IList certs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::Org.BouncyCastle.Asn1.Asn1Sequence s = this.req.OptionalSignature.Certs;
			if (s != null)
			{
				foreach (object obj in s)
				{
					global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
					try
					{
						certs.Add(new global::Org.BouncyCastle.X509.X509CertificateParser().ReadCertificate(ae.GetEncoded()));
					}
					catch (global::System.Exception e)
					{
						throw new global::Org.BouncyCastle.Ocsp.OcspException("can't re-encode certificate!", e);
					}
				}
			}
			return certs;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0004E52C File Offset: 0x0004C72C
		public global::Org.BouncyCastle.X509.X509Certificate[] GetCerts()
		{
			if (!this.IsSigned)
			{
				return null;
			}
			global::System.Collections.IList certs = this.GetCertList();
			global::Org.BouncyCastle.X509.X509Certificate[] result = new global::Org.BouncyCastle.X509.X509Certificate[certs.Count];
			for (int i = 0; i < certs.Count; i++)
			{
				result[i] = (global::Org.BouncyCastle.X509.X509Certificate)certs[i];
			}
			return result;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0004E578 File Offset: 0x0004C778
		public global::Org.BouncyCastle.X509.Store.IX509Store GetCertificates(string type)
		{
			if (!this.IsSigned)
			{
				return null;
			}
			global::Org.BouncyCastle.X509.Store.IX509Store result;
			try
			{
				result = global::Org.BouncyCastle.X509.Store.X509StoreFactory.Create("Certificate/" + type, new global::Org.BouncyCastle.X509.Store.X509CollectionStoreParameters(this.GetCertList()));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Ocsp.OcspException("can't setup the CertStore", e);
			}
			return result;
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x0004E5CC File Offset: 0x0004C7CC
		public bool IsSigned
		{
			get
			{
				return this.req.OptionalSignature != null;
			}
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0004E5DC File Offset: 0x0004C7DC
		public bool Verify(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			if (!this.IsSigned)
			{
				throw new global::Org.BouncyCastle.Ocsp.OcspException("attempt to Verify signature on unsigned object");
			}
			bool result;
			try
			{
				global::Org.BouncyCastle.Crypto.ISigner signer = global::Org.BouncyCastle.Security.SignerUtilities.GetSigner(this.SignatureAlgOid);
				signer.Init(false, publicKey);
				byte[] encoded = this.req.TbsRequest.GetEncoded();
				signer.BlockUpdate(encoded, 0, encoded.Length);
				result = signer.VerifySignature(this.GetSignature());
			}
			catch (global::System.Exception e)
			{
				string str = "exception processing sig: ";
				global::System.Exception ex = e;
				throw new global::Org.BouncyCastle.Ocsp.OcspException(str + ((ex != null) ? ex.ToString() : null), e);
			}
			return result;
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0004E66C File Offset: 0x0004C86C
		public byte[] GetEncoded()
		{
			return this.req.GetEncoded();
		}

		// Token: 0x040008E8 RID: 2280
		private global::Org.BouncyCastle.Asn1.Ocsp.OcspRequest req;
	}
}
