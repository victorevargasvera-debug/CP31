using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200074A RID: 1866
	public class EncryptedData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060042C0 RID: 17088 RVA: 0x0012C50B File Offset: 0x0012A70B
		public static global::Org.BouncyCastle.Asn1.Cms.EncryptedData GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cms.EncryptedData)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.EncryptedData)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.EncryptedData((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid EncryptedData: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x0012C545 File Offset: 0x0012A745
		public EncryptedData(global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo encInfo) : this(encInfo, null)
		{
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x0012C54F File Offset: 0x0012A74F
		public EncryptedData(global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo encInfo, global::Org.BouncyCastle.Asn1.Asn1Set unprotectedAttrs)
		{
			if (encInfo == null)
			{
				throw new global::System.ArgumentNullException("encInfo");
			}
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger((unprotectedAttrs == null) ? 0 : 2);
			this.encryptedContentInfo = encInfo;
			this.unprotectedAttrs = unprotectedAttrs;
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x0012C588 File Offset: 0x0012A788
		private EncryptedData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count < 2 || seq.Count > 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			this.encryptedContentInfo = global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo.GetInstance(seq[1]);
			if (seq.Count > 2)
			{
				this.unprotectedAttrs = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[2], false);
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x0012C623 File Offset: 0x0012A823
		public virtual global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x060042C5 RID: 17093 RVA: 0x0012C62B File Offset: 0x0012A82B
		public virtual global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo EncryptedContentInfo
		{
			get
			{
				return this.encryptedContentInfo;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x060042C6 RID: 17094 RVA: 0x0012C633 File Offset: 0x0012A833
		public virtual global::Org.BouncyCastle.Asn1.Asn1Set UnprotectedAttrs
		{
			get
			{
				return this.unprotectedAttrs;
			}
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x0012C63C File Offset: 0x0012A83C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.encryptedContentInfo
			});
			if (this.unprotectedAttrs != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.BerTaggedObject(false, 1, this.unprotectedAttrs));
			}
			return new global::Org.BouncyCastle.Asn1.BerSequence(v);
		}

		// Token: 0x04002030 RID: 8240
		private readonly global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04002031 RID: 8241
		private readonly global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo encryptedContentInfo;

		// Token: 0x04002032 RID: 8242
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set unprotectedAttrs;
	}
}
