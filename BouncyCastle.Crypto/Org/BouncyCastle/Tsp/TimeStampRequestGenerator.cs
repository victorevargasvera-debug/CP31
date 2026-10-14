using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Tsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tsp
{
	// Token: 0x0200007B RID: 123
	public class TimeStampRequestGenerator
	{
		// Token: 0x060004EF RID: 1263 RVA: 0x000167EA File Offset: 0x000149EA
		public void SetReqPolicy(string reqPolicy)
		{
			this.reqPolicy = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(reqPolicy);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000167F8 File Offset: 0x000149F8
		public void SetCertReq(bool certReq)
		{
			this.certReq = global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(certReq);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00016806 File Offset: 0x00014A06
		[global::System.Obsolete("Use method taking DerObjectIdentifier")]
		public void AddExtension(string oid, bool critical, global::Org.BouncyCastle.Asn1.Asn1Encodable value)
		{
			this.AddExtension(oid, critical, value.GetEncoded());
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00016818 File Offset: 0x00014A18
		[global::System.Obsolete("Use method taking DerObjectIdentifier")]
		public void AddExtension(string oid, bool critical, byte[] value)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derOid = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid);
			this.extensions[derOid] = new global::Org.BouncyCastle.Asn1.X509.X509Extension(critical, new global::Org.BouncyCastle.Asn1.DerOctetString(value));
			this.extOrdering.Add(derOid);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00016851 File Offset: 0x00014A51
		public virtual void AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, bool critical, global::Org.BouncyCastle.Asn1.Asn1Encodable extValue)
		{
			this.AddExtension(oid, critical, extValue.GetEncoded());
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00016861 File Offset: 0x00014A61
		public virtual void AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, bool critical, byte[] extValue)
		{
			this.extensions.Add(oid, new global::Org.BouncyCastle.Asn1.X509.X509Extension(critical, new global::Org.BouncyCastle.Asn1.DerOctetString(extValue)));
			this.extOrdering.Add(oid);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00016888 File Offset: 0x00014A88
		public global::Org.BouncyCastle.Tsp.TimeStampRequest Generate(string digestAlgorithm, byte[] digest)
		{
			return this.Generate(digestAlgorithm, digest, null);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00016894 File Offset: 0x00014A94
		public global::Org.BouncyCastle.Tsp.TimeStampRequest Generate(string digestAlgorithmOid, byte[] digest, global::Org.BouncyCastle.Math.BigInteger nonce)
		{
			if (digestAlgorithmOid == null)
			{
				throw new global::System.ArgumentException("No digest algorithm specified");
			}
			global::Org.BouncyCastle.Asn1.Tsp.MessageImprint messageImprint = new global::Org.BouncyCastle.Asn1.Tsp.MessageImprint(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(digestAlgorithmOid), global::Org.BouncyCastle.Asn1.DerNull.Instance), digest);
			global::Org.BouncyCastle.Asn1.X509.X509Extensions ext = null;
			if (this.extOrdering.Count != 0)
			{
				ext = new global::Org.BouncyCastle.Asn1.X509.X509Extensions(this.extOrdering, this.extensions);
			}
			global::Org.BouncyCastle.Asn1.DerInteger derNonce = (nonce == null) ? null : new global::Org.BouncyCastle.Asn1.DerInteger(nonce);
			return new global::Org.BouncyCastle.Tsp.TimeStampRequest(new global::Org.BouncyCastle.Asn1.Tsp.TimeStampReq(messageImprint, this.reqPolicy, derNonce, this.certReq, ext));
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001690B File Offset: 0x00014B0B
		public virtual global::Org.BouncyCastle.Tsp.TimeStampRequest Generate(global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestAlgorithm, byte[] digest)
		{
			return this.Generate(digestAlgorithm.Id, digest);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001691A File Offset: 0x00014B1A
		public virtual global::Org.BouncyCastle.Tsp.TimeStampRequest Generate(global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestAlgorithm, byte[] digest, global::Org.BouncyCastle.Math.BigInteger nonce)
		{
			return this.Generate(digestAlgorithm.Id, digest, nonce);
		}

		// Token: 0x040002AB RID: 683
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier reqPolicy;

		// Token: 0x040002AC RID: 684
		private global::Org.BouncyCastle.Asn1.DerBoolean certReq;

		// Token: 0x040002AD RID: 685
		private global::System.Collections.IDictionary extensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040002AE RID: 686
		private global::System.Collections.IList extOrdering = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
	}
}
