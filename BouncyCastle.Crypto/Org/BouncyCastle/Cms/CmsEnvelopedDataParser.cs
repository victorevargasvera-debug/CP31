using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200052A RID: 1322
	public class CmsEnvelopedDataParser : global::Org.BouncyCastle.Cms.CmsContentInfoParser
	{
		// Token: 0x06003310 RID: 13072 RVA: 0x000F3D98 File Offset: 0x000F1F98
		public CmsEnvelopedDataParser(byte[] envelopedData) : this(new global::System.IO.MemoryStream(envelopedData, false))
		{
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x000F3DA8 File Offset: 0x000F1FA8
		public CmsEnvelopedDataParser(global::System.IO.Stream envelopedData) : base(envelopedData)
		{
			this._attrNotRead = true;
			this.envelopedData = new global::Org.BouncyCastle.Asn1.Cms.EnvelopedDataParser((global::Org.BouncyCastle.Asn1.Asn1SequenceParser)this.contentInfo.GetContent(16));
			global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(this.envelopedData.GetRecipientInfos().ToAsn1Object());
			global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfoParser encInfo = this.envelopedData.GetEncryptedContentInfo();
			this._encAlg = encInfo.ContentEncryptionAlgorithm;
			global::Org.BouncyCastle.Cms.CmsReadable readable = new global::Org.BouncyCastle.Cms.CmsProcessableInputStream(((global::Org.BouncyCastle.Asn1.Asn1OctetStringParser)encInfo.GetEncryptedContent(4)).GetOctetStream());
			global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable = new global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.CmsEnvelopedSecureReadable(this._encAlg, readable);
			this.recipientInfoStore = global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.BuildRecipientInformationStore(recipientInfos, secureReadable);
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06003312 RID: 13074 RVA: 0x000F3E3F File Offset: 0x000F203F
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier EncryptionAlgorithmID
		{
			get
			{
				return this._encAlg;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06003313 RID: 13075 RVA: 0x000F3E47 File Offset: 0x000F2047
		public string EncryptionAlgOid
		{
			get
			{
				return this._encAlg.Algorithm.Id;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06003314 RID: 13076 RVA: 0x000F3E5C File Offset: 0x000F205C
		public global::Org.BouncyCastle.Asn1.Asn1Object EncryptionAlgParams
		{
			get
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = this._encAlg.Parameters;
				if (ae != null)
				{
					return ae.ToAsn1Object();
				}
				return null;
			}
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x000F3E80 File Offset: 0x000F2080
		public global::Org.BouncyCastle.Cms.RecipientInformationStore GetRecipientInfos()
		{
			return this.recipientInfoStore;
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x000F3E88 File Offset: 0x000F2088
		public global::Org.BouncyCastle.Asn1.Cms.AttributeTable GetUnprotectedAttributes()
		{
			if (this._unprotectedAttributes == null && this._attrNotRead)
			{
				global::Org.BouncyCastle.Asn1.Asn1SetParser asn1Set = this.envelopedData.GetUnprotectedAttrs();
				this._attrNotRead = false;
				if (asn1Set != null)
				{
					global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
					global::Org.BouncyCastle.Asn1.IAsn1Convertible o;
					while ((o = asn1Set.ReadObject()) != null)
					{
						global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq = (global::Org.BouncyCastle.Asn1.Asn1SequenceParser)o;
						v.Add(seq.ToAsn1Object());
					}
					this._unprotectedAttributes = new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(new global::Org.BouncyCastle.Asn1.DerSet(v));
				}
			}
			return this._unprotectedAttributes;
		}

		// Token: 0x040016BE RID: 5822
		internal global::Org.BouncyCastle.Cms.RecipientInformationStore recipientInfoStore;

		// Token: 0x040016BF RID: 5823
		internal global::Org.BouncyCastle.Asn1.Cms.EnvelopedDataParser envelopedData;

		// Token: 0x040016C0 RID: 5824
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier _encAlg;

		// Token: 0x040016C1 RID: 5825
		private global::Org.BouncyCastle.Asn1.Cms.AttributeTable _unprotectedAttributes;

		// Token: 0x040016C2 RID: 5826
		private bool _attrNotRead;
	}
}
