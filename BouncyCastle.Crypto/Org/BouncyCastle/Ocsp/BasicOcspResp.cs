using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001DA RID: 474
	public class BasicOcspResp : global::Org.BouncyCastle.X509.X509ExtensionBase
	{
		// Token: 0x06001189 RID: 4489 RVA: 0x0004DAB5 File Offset: 0x0004BCB5
		public BasicOcspResp(global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse resp)
		{
			this.resp = resp;
			this.data = resp.TbsResponseData;
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0004DAD0 File Offset: 0x0004BCD0
		public byte[] GetTbsResponseData()
		{
			byte[] derEncoded;
			try
			{
				derEncoded = this.data.GetDerEncoded();
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Ocsp.OcspException("problem encoding tbsResponseData", e);
			}
			return derEncoded;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x0004DB0C File Offset: 0x0004BD0C
		public int Version
		{
			get
			{
				return this.data.Version.IntValueExact + 1;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x0004DB20 File Offset: 0x0004BD20
		public global::Org.BouncyCastle.Ocsp.RespID ResponderId
		{
			get
			{
				return new global::Org.BouncyCastle.Ocsp.RespID(this.data.ResponderID);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x0004DB32 File Offset: 0x0004BD32
		public global::System.DateTime ProducedAt
		{
			get
			{
				return this.data.ProducedAt.ToDateTime();
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x0004DB44 File Offset: 0x0004BD44
		public global::Org.BouncyCastle.Ocsp.SingleResp[] Responses
		{
			get
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence s = this.data.Responses;
				global::Org.BouncyCastle.Ocsp.SingleResp[] rs = new global::Org.BouncyCastle.Ocsp.SingleResp[s.Count];
				for (int i = 0; i != rs.Length; i++)
				{
					rs[i] = new global::Org.BouncyCastle.Ocsp.SingleResp(global::Org.BouncyCastle.Asn1.Ocsp.SingleResponse.GetInstance(s[i]));
				}
				return rs;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x0004DB8C File Offset: 0x0004BD8C
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions ResponseExtensions
		{
			get
			{
				return this.data.ResponseExtensions;
			}
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0004DB99 File Offset: 0x0004BD99
		protected override global::Org.BouncyCastle.Asn1.X509.X509Extensions GetX509Extensions()
		{
			return this.ResponseExtensions;
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x0004DBA1 File Offset: 0x0004BDA1
		public string SignatureAlgName
		{
			get
			{
				return global::Org.BouncyCastle.Ocsp.OcspUtilities.GetAlgorithmName(this.resp.SignatureAlgorithm.Algorithm);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x0004DBB8 File Offset: 0x0004BDB8
		public string SignatureAlgOid
		{
			get
			{
				return this.resp.SignatureAlgorithm.Algorithm.Id;
			}
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0004DBCF File Offset: 0x0004BDCF
		[global::System.Obsolete("RespData class is no longer required as all functionality is available on this class")]
		public global::Org.BouncyCastle.Ocsp.RespData GetResponseData()
		{
			return new global::Org.BouncyCastle.Ocsp.RespData(this.data);
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0004DBDC File Offset: 0x0004BDDC
		public byte[] GetSignature()
		{
			return this.resp.GetSignatureOctets();
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0004DBEC File Offset: 0x0004BDEC
		private global::System.Collections.IList GetCertList()
		{
			global::System.Collections.IList certs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::Org.BouncyCastle.Asn1.Asn1Sequence s = this.resp.Certs;
			if (s != null)
			{
				foreach (object obj in s)
				{
					global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
					try
					{
						certs.Add(new global::Org.BouncyCastle.X509.X509CertificateParser().ReadCertificate(ae.GetEncoded()));
					}
					catch (global::System.IO.IOException ex)
					{
						throw new global::Org.BouncyCastle.Ocsp.OcspException("can't re-encode certificate!", ex);
					}
					catch (global::Org.BouncyCastle.Security.Certificates.CertificateException ex2)
					{
						throw new global::Org.BouncyCastle.Ocsp.OcspException("can't re-encode certificate!", ex2);
					}
				}
			}
			return certs;
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0004DCA4 File Offset: 0x0004BEA4
		public global::Org.BouncyCastle.X509.X509Certificate[] GetCerts()
		{
			global::System.Collections.IList certs = this.GetCertList();
			global::Org.BouncyCastle.X509.X509Certificate[] result = new global::Org.BouncyCastle.X509.X509Certificate[certs.Count];
			for (int i = 0; i < certs.Count; i++)
			{
				result[i] = (global::Org.BouncyCastle.X509.X509Certificate)certs[i];
			}
			return result;
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0004DCE8 File Offset: 0x0004BEE8
		public global::Org.BouncyCastle.X509.Store.IX509Store GetCertificates(string type)
		{
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

		// Token: 0x06001198 RID: 4504 RVA: 0x0004DD34 File Offset: 0x0004BF34
		public bool Verify(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			bool result;
			try
			{
				global::Org.BouncyCastle.Crypto.ISigner signer = global::Org.BouncyCastle.Security.SignerUtilities.GetSigner(this.SignatureAlgName);
				signer.Init(false, publicKey);
				byte[] bs = this.data.GetDerEncoded();
				signer.BlockUpdate(bs, 0, bs.Length);
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

		// Token: 0x06001199 RID: 4505 RVA: 0x0004DDAC File Offset: 0x0004BFAC
		public byte[] GetEncoded()
		{
			return this.resp.GetEncoded();
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0004DDBC File Offset: 0x0004BFBC
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Ocsp.BasicOcspResp other = obj as global::Org.BouncyCastle.Ocsp.BasicOcspResp;
			return other != null && this.resp.Equals(other.resp);
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0004DDEC File Offset: 0x0004BFEC
		public override int GetHashCode()
		{
			return this.resp.GetHashCode();
		}

		// Token: 0x040008E0 RID: 2272
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse resp;

		// Token: 0x040008E1 RID: 2273
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.ResponseData data;
	}
}
