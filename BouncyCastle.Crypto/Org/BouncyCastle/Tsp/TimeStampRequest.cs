using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Tsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Tsp
{
	// Token: 0x0200007A RID: 122
	public class TimeStampRequest : global::Org.BouncyCastle.X509.X509ExtensionBase
	{
		// Token: 0x060004DE RID: 1246 RVA: 0x00016553 File Offset: 0x00014753
		public TimeStampRequest(global::Org.BouncyCastle.Asn1.Tsp.TimeStampReq req)
		{
			this.req = req;
			this.extensions = req.Extensions;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0001656E File Offset: 0x0001476E
		public TimeStampRequest(byte[] req) : this(new global::Org.BouncyCastle.Asn1.Asn1InputStream(req))
		{
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001657C File Offset: 0x0001477C
		public TimeStampRequest(global::System.IO.Stream input) : this(new global::Org.BouncyCastle.Asn1.Asn1InputStream(input))
		{
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001658C File Offset: 0x0001478C
		private TimeStampRequest(global::Org.BouncyCastle.Asn1.Asn1InputStream str)
		{
			try
			{
				this.req = global::Org.BouncyCastle.Asn1.Tsp.TimeStampReq.GetInstance(str.ReadObject());
			}
			catch (global::System.InvalidCastException e)
			{
				string str2 = "malformed request: ";
				global::System.InvalidCastException ex = e;
				throw new global::System.IO.IOException(str2 + ((ex != null) ? ex.ToString() : null));
			}
			catch (global::System.ArgumentException e2)
			{
				string str3 = "malformed request: ";
				global::System.ArgumentException ex2 = e2;
				throw new global::System.IO.IOException(str3 + ((ex2 != null) ? ex2.ToString() : null));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0001660C File Offset: 0x0001480C
		public int Version
		{
			get
			{
				return this.req.Version.IntValueExact;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0001661E File Offset: 0x0001481E
		public string MessageImprintAlgOid
		{
			get
			{
				return this.req.MessageImprint.HashAlgorithm.Algorithm.Id;
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0001663A File Offset: 0x0001483A
		public byte[] GetMessageImprintDigest()
		{
			return this.req.MessageImprint.GetHashedMessage();
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0001664C File Offset: 0x0001484C
		public string ReqPolicy
		{
			get
			{
				if (this.req.ReqPolicy != null)
				{
					return this.req.ReqPolicy.Id;
				}
				return null;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0001666D File Offset: 0x0001486D
		public global::Org.BouncyCastle.Math.BigInteger Nonce
		{
			get
			{
				if (this.req.Nonce != null)
				{
					return this.req.Nonce.Value;
				}
				return null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0001668E File Offset: 0x0001488E
		public bool CertReq
		{
			get
			{
				return this.req.CertReq != null && this.req.CertReq.IsTrue;
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000166B0 File Offset: 0x000148B0
		public void Validate(global::System.Collections.IList algorithms, global::System.Collections.IList policies, global::System.Collections.IList extensions)
		{
			if (!algorithms.Contains(this.MessageImprintAlgOid))
			{
				throw new global::Org.BouncyCastle.Tsp.TspValidationException("request contains unknown algorithm", 128);
			}
			if (policies != null && this.ReqPolicy != null && !policies.Contains(this.ReqPolicy))
			{
				throw new global::Org.BouncyCastle.Tsp.TspValidationException("request contains unknown policy", 256);
			}
			if (this.Extensions != null && extensions != null)
			{
				foreach (object obj in this.Extensions.ExtensionOids)
				{
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
					if (!extensions.Contains(oid.Id))
					{
						throw new global::Org.BouncyCastle.Tsp.TspValidationException("request contains unknown extension", 8388608);
					}
				}
			}
			if (global::Org.BouncyCastle.Tsp.TspUtil.GetDigestLength(this.MessageImprintAlgOid) != this.GetMessageImprintDigest().Length)
			{
				throw new global::Org.BouncyCastle.Tsp.TspValidationException("imprint digest the wrong length", 4);
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00016798 File Offset: 0x00014998
		public byte[] GetEncoded()
		{
			return this.req.GetEncoded();
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x000167A5 File Offset: 0x000149A5
		internal global::Org.BouncyCastle.Asn1.X509.X509Extensions Extensions
		{
			get
			{
				return this.req.Extensions;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x000167B2 File Offset: 0x000149B2
		public virtual bool HasExtensions
		{
			get
			{
				return this.extensions != null;
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000167BD File Offset: 0x000149BD
		public virtual global::Org.BouncyCastle.Asn1.X509.X509Extension GetExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			if (this.extensions != null)
			{
				return this.extensions.GetExtension(oid);
			}
			return null;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000167D5 File Offset: 0x000149D5
		public virtual global::System.Collections.IList GetExtensionOids()
		{
			return global::Org.BouncyCastle.Tsp.TspUtil.GetExtensionOids(this.extensions);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000167E2 File Offset: 0x000149E2
		protected override global::Org.BouncyCastle.Asn1.X509.X509Extensions GetX509Extensions()
		{
			return this.Extensions;
		}

		// Token: 0x040002A9 RID: 681
		private global::Org.BouncyCastle.Asn1.Tsp.TimeStampReq req;

		// Token: 0x040002AA RID: 682
		private global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions;
	}
}
