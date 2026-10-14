using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000762 RID: 1890
	public class SignedDataParser
	{
		// Token: 0x0600438B RID: 17291 RVA: 0x0012E548 File Offset: 0x0012C748
		public static global::Org.BouncyCastle.Asn1.Cms.SignedDataParser GetInstance(object o)
		{
			if (o is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.SignedDataParser(((global::Org.BouncyCastle.Asn1.Asn1Sequence)o).Parser);
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1SequenceParser)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.SignedDataParser((global::Org.BouncyCastle.Asn1.Asn1SequenceParser)o);
			}
			throw new global::System.IO.IOException("unknown object encountered: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o));
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x0012E597 File Offset: 0x0012C797
		public SignedDataParser(global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq)
		{
			this._seq = seq;
			this._version = (global::Org.BouncyCastle.Asn1.DerInteger)seq.ReadObject();
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x0600438D RID: 17293 RVA: 0x0012E5B7 File Offset: 0x0012C7B7
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x0012E5BF File Offset: 0x0012C7BF
		public global::Org.BouncyCastle.Asn1.Asn1SetParser GetDigestAlgorithms()
		{
			return (global::Org.BouncyCastle.Asn1.Asn1SetParser)this._seq.ReadObject();
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x0012E5D1 File Offset: 0x0012C7D1
		public global::Org.BouncyCastle.Asn1.Cms.ContentInfoParser GetEncapContentInfo()
		{
			return new global::Org.BouncyCastle.Asn1.Cms.ContentInfoParser((global::Org.BouncyCastle.Asn1.Asn1SequenceParser)this._seq.ReadObject());
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x0012E5E8 File Offset: 0x0012C7E8
		public global::Org.BouncyCastle.Asn1.Asn1SetParser GetCertificates()
		{
			this._certsCalled = true;
			this._nextObject = this._seq.ReadObject();
			if (this._nextObject is global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser && ((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)this._nextObject).TagNo == 0)
			{
				global::Org.BouncyCastle.Asn1.Asn1SetParser result = (global::Org.BouncyCastle.Asn1.Asn1SetParser)((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)this._nextObject).GetObjectParser(17, false);
				this._nextObject = null;
				return result;
			}
			return null;
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x0012E650 File Offset: 0x0012C850
		public global::Org.BouncyCastle.Asn1.Asn1SetParser GetCrls()
		{
			if (!this._certsCalled)
			{
				throw new global::System.IO.IOException("GetCerts() has not been called.");
			}
			this._crlsCalled = true;
			if (this._nextObject == null)
			{
				this._nextObject = this._seq.ReadObject();
			}
			if (this._nextObject is global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser && ((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)this._nextObject).TagNo == 1)
			{
				global::Org.BouncyCastle.Asn1.Asn1SetParser result = (global::Org.BouncyCastle.Asn1.Asn1SetParser)((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)this._nextObject).GetObjectParser(17, false);
				this._nextObject = null;
				return result;
			}
			return null;
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x0012E6D4 File Offset: 0x0012C8D4
		public global::Org.BouncyCastle.Asn1.Asn1SetParser GetSignerInfos()
		{
			if (!this._certsCalled || !this._crlsCalled)
			{
				throw new global::System.IO.IOException("GetCerts() and/or GetCrls() has not been called.");
			}
			if (this._nextObject == null)
			{
				this._nextObject = this._seq.ReadObject();
			}
			return (global::Org.BouncyCastle.Asn1.Asn1SetParser)this._nextObject;
		}

		// Token: 0x0400207A RID: 8314
		private global::Org.BouncyCastle.Asn1.Asn1SequenceParser _seq;

		// Token: 0x0400207B RID: 8315
		private global::Org.BouncyCastle.Asn1.DerInteger _version;

		// Token: 0x0400207C RID: 8316
		private object _nextObject;

		// Token: 0x0400207D RID: 8317
		private bool _certsCalled;

		// Token: 0x0400207E RID: 8318
		private bool _crlsCalled;
	}
}
