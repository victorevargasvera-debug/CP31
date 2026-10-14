using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000764 RID: 1892
	public class SignerInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600439A RID: 17306 RVA: 0x0012E808 File Offset: 0x0012CA08
		public static global::Org.BouncyCastle.Asn1.Cms.SignerInfo GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.SignerInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.SignerInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.SignerInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x0012E858 File Offset: 0x0012CA58
		public SignerInfo(global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier sid, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlgorithm, global::Org.BouncyCastle.Asn1.Asn1Set authenticatedAttributes, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digEncryptionAlgorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedDigest, global::Org.BouncyCastle.Asn1.Asn1Set unauthenticatedAttributes)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(sid.IsTagged ? 3 : 1);
			this.sid = sid;
			this.digAlgorithm = digAlgorithm;
			this.authenticatedAttributes = authenticatedAttributes;
			this.digEncryptionAlgorithm = digEncryptionAlgorithm;
			this.encryptedDigest = encryptedDigest;
			this.unauthenticatedAttributes = unauthenticatedAttributes;
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x0012E8B0 File Offset: 0x0012CAB0
		public SignerInfo(global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier sid, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlgorithm, global::Org.BouncyCastle.Asn1.Cms.Attributes authenticatedAttributes, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digEncryptionAlgorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedDigest, global::Org.BouncyCastle.Asn1.Cms.Attributes unauthenticatedAttributes)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(sid.IsTagged ? 3 : 1);
			this.sid = sid;
			this.digAlgorithm = digAlgorithm;
			this.authenticatedAttributes = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(authenticatedAttributes);
			this.digEncryptionAlgorithm = digEncryptionAlgorithm;
			this.encryptedDigest = encryptedDigest;
			this.unauthenticatedAttributes = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(unauthenticatedAttributes);
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x0012E914 File Offset: 0x0012CB14
		[global::System.Obsolete("Use 'GetInstance' instead")]
		public SignerInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)e.Current;
			e.MoveNext();
			this.sid = global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier.GetInstance(e.Current);
			e.MoveNext();
			this.digAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(e.Current);
			e.MoveNext();
			object obj = e.Current;
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.authenticatedAttributes = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj, false);
				e.MoveNext();
				this.digEncryptionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(e.Current);
			}
			else
			{
				this.authenticatedAttributes = null;
				this.digEncryptionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(obj);
			}
			e.MoveNext();
			this.encryptedDigest = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(e.Current);
			if (e.MoveNext())
			{
				this.unauthenticatedAttributes = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)e.Current, false);
				return;
			}
			this.unauthenticatedAttributes = null;
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x0600439E RID: 17310 RVA: 0x0012EA0A File Offset: 0x0012CC0A
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x0600439F RID: 17311 RVA: 0x0012EA12 File Offset: 0x0012CC12
		public global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier SignerID
		{
			get
			{
				return this.sid;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x060043A0 RID: 17312 RVA: 0x0012EA1A File Offset: 0x0012CC1A
		public global::Org.BouncyCastle.Asn1.Asn1Set AuthenticatedAttributes
		{
			get
			{
				return this.authenticatedAttributes;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x060043A1 RID: 17313 RVA: 0x0012EA22 File Offset: 0x0012CC22
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DigestAlgorithm
		{
			get
			{
				return this.digAlgorithm;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x060043A2 RID: 17314 RVA: 0x0012EA2A File Offset: 0x0012CC2A
		public global::Org.BouncyCastle.Asn1.Asn1OctetString EncryptedDigest
		{
			get
			{
				return this.encryptedDigest;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x060043A3 RID: 17315 RVA: 0x0012EA32 File Offset: 0x0012CC32
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DigestEncryptionAlgorithm
		{
			get
			{
				return this.digEncryptionAlgorithm;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x060043A4 RID: 17316 RVA: 0x0012EA3A File Offset: 0x0012CC3A
		public global::Org.BouncyCastle.Asn1.Asn1Set UnauthenticatedAttributes
		{
			get
			{
				return this.unauthenticatedAttributes;
			}
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x0012EA44 File Offset: 0x0012CC44
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.sid,
				this.digAlgorithm
			});
			v.AddOptionalTagged(false, 0, this.authenticatedAttributes);
			v.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.digEncryptionAlgorithm,
				this.encryptedDigest
			});
			v.AddOptionalTagged(false, 1, this.unauthenticatedAttributes);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04002080 RID: 8320
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04002081 RID: 8321
		private global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier sid;

		// Token: 0x04002082 RID: 8322
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlgorithm;

		// Token: 0x04002083 RID: 8323
		private global::Org.BouncyCastle.Asn1.Asn1Set authenticatedAttributes;

		// Token: 0x04002084 RID: 8324
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digEncryptionAlgorithm;

		// Token: 0x04002085 RID: 8325
		private global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedDigest;

		// Token: 0x04002086 RID: 8326
		private global::Org.BouncyCastle.Asn1.Asn1Set unauthenticatedAttributes;
	}
}
