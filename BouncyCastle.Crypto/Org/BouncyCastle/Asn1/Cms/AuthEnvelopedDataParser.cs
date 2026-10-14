using System;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000741 RID: 1857
	public class AuthEnvelopedDataParser
	{
		// Token: 0x06004293 RID: 17043 RVA: 0x0012BD70 File Offset: 0x00129F70
		public AuthEnvelopedDataParser(global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq)
		{
			this.seq = seq;
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)seq.ReadObject();
			if (!this.version.HasValue(0))
			{
				throw new global::Org.BouncyCastle.Asn1.Asn1ParsingException("AuthEnvelopedData version number must be 0");
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x0012BDA9 File Offset: 0x00129FA9
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x0012BDB4 File Offset: 0x00129FB4
		public global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo GetOriginatorInfo()
		{
			this.originatorInfoCalled = true;
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			if (this.nextObject is global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser && ((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)this.nextObject).TagNo == 0)
			{
				global::Org.BouncyCastle.Asn1.IAsn1Convertible asn1Convertible = (global::Org.BouncyCastle.Asn1.Asn1SequenceParser)((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)this.nextObject).GetObjectParser(16, false);
				this.nextObject = null;
				return global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo.GetInstance(asn1Convertible.ToAsn1Object());
			}
			return null;
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x0012BE2B File Offset: 0x0012A02B
		public global::Org.BouncyCastle.Asn1.Asn1SetParser GetRecipientInfos()
		{
			if (!this.originatorInfoCalled)
			{
				this.GetOriginatorInfo();
			}
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			global::Org.BouncyCastle.Asn1.Asn1SetParser result = (global::Org.BouncyCastle.Asn1.Asn1SetParser)this.nextObject;
			this.nextObject = null;
			return result;
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x0012BE68 File Offset: 0x0012A068
		public global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfoParser GetAuthEncryptedContentInfo()
		{
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			if (this.nextObject != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1SequenceParser asn1SequenceParser = (global::Org.BouncyCastle.Asn1.Asn1SequenceParser)this.nextObject;
				this.nextObject = null;
				global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfoParser encryptedContentInfoParser = new global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfoParser(asn1SequenceParser);
				this.isData = global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data.Equals(encryptedContentInfoParser.ContentType);
				return encryptedContentInfoParser;
			}
			return null;
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x0012BEC8 File Offset: 0x0012A0C8
		public global::Org.BouncyCastle.Asn1.Asn1SetParser GetAuthAttrs()
		{
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			if (this.nextObject is global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)
			{
				global::Org.BouncyCastle.Asn1.IAsn1Convertible asn1Convertible = this.nextObject;
				this.nextObject = null;
				return (global::Org.BouncyCastle.Asn1.Asn1SetParser)((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)asn1Convertible).GetObjectParser(17, false);
			}
			if (!this.isData)
			{
				throw new global::Org.BouncyCastle.Asn1.Asn1ParsingException("authAttrs must be present with non-data content");
			}
			return null;
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x0012BF2F File Offset: 0x0012A12F
		public global::Org.BouncyCastle.Asn1.Asn1OctetString GetMac()
		{
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			global::Org.BouncyCastle.Asn1.IAsn1Convertible asn1Convertible = this.nextObject;
			this.nextObject = null;
			return global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(asn1Convertible.ToAsn1Object());
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x0012BF64 File Offset: 0x0012A164
		public global::Org.BouncyCastle.Asn1.Asn1SetParser GetUnauthAttrs()
		{
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			if (this.nextObject != null)
			{
				global::Org.BouncyCastle.Asn1.IAsn1Convertible asn1Convertible = this.nextObject;
				this.nextObject = null;
				return (global::Org.BouncyCastle.Asn1.Asn1SetParser)((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)asn1Convertible).GetObjectParser(17, false);
			}
			return null;
		}

		// Token: 0x04002009 RID: 8201
		private global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq;

		// Token: 0x0400200A RID: 8202
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x0400200B RID: 8203
		private global::Org.BouncyCastle.Asn1.IAsn1Convertible nextObject;

		// Token: 0x0400200C RID: 8204
		private bool originatorInfoCalled;

		// Token: 0x0400200D RID: 8205
		private bool isData;
	}
}
