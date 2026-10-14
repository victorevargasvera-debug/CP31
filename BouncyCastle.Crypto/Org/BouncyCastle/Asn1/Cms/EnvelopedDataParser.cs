using System;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200074C RID: 1868
	public class EnvelopedDataParser
	{
		// Token: 0x060042D4 RID: 17108 RVA: 0x0012C8D8 File Offset: 0x0012AAD8
		public EnvelopedDataParser(global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq)
		{
			this._seq = seq;
			this._version = (global::Org.BouncyCastle.Asn1.DerInteger)seq.ReadObject();
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060042D5 RID: 17109 RVA: 0x0012C8F8 File Offset: 0x0012AAF8
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x0012C900 File Offset: 0x0012AB00
		public global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo GetOriginatorInfo()
		{
			this._originatorInfoCalled = true;
			if (this._nextObject == null)
			{
				this._nextObject = this._seq.ReadObject();
			}
			if (this._nextObject is global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser && ((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)this._nextObject).TagNo == 0)
			{
				global::Org.BouncyCastle.Asn1.IAsn1Convertible asn1Convertible = (global::Org.BouncyCastle.Asn1.Asn1SequenceParser)((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)this._nextObject).GetObjectParser(16, false);
				this._nextObject = null;
				return global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo.GetInstance(asn1Convertible.ToAsn1Object());
			}
			return null;
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x0012C977 File Offset: 0x0012AB77
		public global::Org.BouncyCastle.Asn1.Asn1SetParser GetRecipientInfos()
		{
			if (!this._originatorInfoCalled)
			{
				this.GetOriginatorInfo();
			}
			if (this._nextObject == null)
			{
				this._nextObject = this._seq.ReadObject();
			}
			global::Org.BouncyCastle.Asn1.Asn1SetParser result = (global::Org.BouncyCastle.Asn1.Asn1SetParser)this._nextObject;
			this._nextObject = null;
			return result;
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x0012C9B3 File Offset: 0x0012ABB3
		public global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfoParser GetEncryptedContentInfo()
		{
			if (this._nextObject == null)
			{
				this._nextObject = this._seq.ReadObject();
			}
			if (this._nextObject != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq = (global::Org.BouncyCastle.Asn1.Asn1SequenceParser)this._nextObject;
				this._nextObject = null;
				return new global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfoParser(seq);
			}
			return null;
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x0012C9F0 File Offset: 0x0012ABF0
		public global::Org.BouncyCastle.Asn1.Asn1SetParser GetUnprotectedAttrs()
		{
			if (this._nextObject == null)
			{
				this._nextObject = this._seq.ReadObject();
			}
			if (this._nextObject != null)
			{
				global::Org.BouncyCastle.Asn1.IAsn1Convertible nextObject = this._nextObject;
				this._nextObject = null;
				return (global::Org.BouncyCastle.Asn1.Asn1SetParser)((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)nextObject).GetObjectParser(17, false);
			}
			return null;
		}

		// Token: 0x04002038 RID: 8248
		private global::Org.BouncyCastle.Asn1.Asn1SequenceParser _seq;

		// Token: 0x04002039 RID: 8249
		private global::Org.BouncyCastle.Asn1.DerInteger _version;

		// Token: 0x0400203A RID: 8250
		private global::Org.BouncyCastle.Asn1.IAsn1Convertible _nextObject;

		// Token: 0x0400203B RID: 8251
		private bool _originatorInfoCalled;
	}
}
