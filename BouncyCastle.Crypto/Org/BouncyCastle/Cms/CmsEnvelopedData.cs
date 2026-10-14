using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000528 RID: 1320
	public class CmsEnvelopedData
	{
		// Token: 0x06003301 RID: 13057 RVA: 0x000F3895 File Offset: 0x000F1A95
		public CmsEnvelopedData(byte[] envelopedData) : this(global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(envelopedData))
		{
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x000F38A3 File Offset: 0x000F1AA3
		public CmsEnvelopedData(global::System.IO.Stream envelopedData) : this(global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(envelopedData))
		{
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x000F38B4 File Offset: 0x000F1AB4
		public CmsEnvelopedData(global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo)
		{
			this.contentInfo = contentInfo;
			global::Org.BouncyCastle.Asn1.Cms.EnvelopedData envData = global::Org.BouncyCastle.Asn1.Cms.EnvelopedData.GetInstance(contentInfo.Content);
			global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos = envData.RecipientInfos;
			global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo encInfo = envData.EncryptedContentInfo;
			this.encAlg = encInfo.ContentEncryptionAlgorithm;
			global::Org.BouncyCastle.Cms.CmsReadable readable = new global::Org.BouncyCastle.Cms.CmsProcessableByteArray(encInfo.EncryptedContent.GetOctets());
			global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable = new global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.CmsEnvelopedSecureReadable(this.encAlg, readable);
			this.recipientInfoStore = global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.BuildRecipientInformationStore(recipientInfos, secureReadable);
			this.unprotectedAttributes = envData.UnprotectedAttrs;
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x000F392D File Offset: 0x000F1B2D
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier EncryptionAlgorithmID
		{
			get
			{
				return this.encAlg;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x000F3935 File Offset: 0x000F1B35
		public string EncryptionAlgOid
		{
			get
			{
				return this.encAlg.Algorithm.Id;
			}
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x000F3947 File Offset: 0x000F1B47
		public global::Org.BouncyCastle.Cms.RecipientInformationStore GetRecipientInfos()
		{
			return this.recipientInfoStore;
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x000F394F File Offset: 0x000F1B4F
		public global::Org.BouncyCastle.Asn1.Cms.ContentInfo ContentInfo
		{
			get
			{
				return this.contentInfo;
			}
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x000F3957 File Offset: 0x000F1B57
		public global::Org.BouncyCastle.Asn1.Cms.AttributeTable GetUnprotectedAttributes()
		{
			if (this.unprotectedAttributes == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(this.unprotectedAttributes);
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x000F396E File Offset: 0x000F1B6E
		public byte[] GetEncoded()
		{
			return this.contentInfo.GetEncoded();
		}

		// Token: 0x040016BA RID: 5818
		internal global::Org.BouncyCastle.Cms.RecipientInformationStore recipientInfoStore;

		// Token: 0x040016BB RID: 5819
		internal global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo;

		// Token: 0x040016BC RID: 5820
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier encAlg;

		// Token: 0x040016BD RID: 5821
		private global::Org.BouncyCastle.Asn1.Asn1Set unprotectedAttributes;
	}
}
