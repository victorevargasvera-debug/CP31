using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Cms;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x02000510 RID: 1296
	public class PkiArchiveControl : global::Org.BouncyCastle.Crmf.IControl
	{
		// Token: 0x06003299 RID: 12953 RVA: 0x000F24F0 File Offset: 0x000F06F0
		public PkiArchiveControl(global::Org.BouncyCastle.Asn1.Crmf.PkiArchiveOptions pkiArchiveOptions)
		{
			this.pkiArchiveOptions = pkiArchiveOptions;
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600329A RID: 12954 RVA: 0x000F24FF File Offset: 0x000F06FF
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier Type
		{
			get
			{
				return global::Org.BouncyCastle.Crmf.PkiArchiveControl.type;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600329B RID: 12955 RVA: 0x000F2506 File Offset: 0x000F0706
		public global::Org.BouncyCastle.Asn1.Asn1Encodable Value
		{
			get
			{
				return this.pkiArchiveOptions;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600329C RID: 12956 RVA: 0x000F250E File Offset: 0x000F070E
		public int ArchiveType
		{
			get
			{
				return this.pkiArchiveOptions.Type;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600329D RID: 12957 RVA: 0x000F251B File Offset: 0x000F071B
		public bool EnvelopedData
		{
			get
			{
				return !global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey.GetInstance(this.pkiArchiveOptions.Value).IsEncryptedValue;
			}
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x000F2538 File Offset: 0x000F0738
		public global::Org.BouncyCastle.Cms.CmsEnvelopedData GetEnvelopedData()
		{
			global::Org.BouncyCastle.Cms.CmsEnvelopedData result;
			try
			{
				global::Org.BouncyCastle.Asn1.Cms.EnvelopedData data = global::Org.BouncyCastle.Asn1.Cms.EnvelopedData.GetInstance(global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey.GetInstance(this.pkiArchiveOptions.Value).Value);
				result = new global::Org.BouncyCastle.Cms.CmsEnvelopedData(new global::Org.BouncyCastle.Asn1.Cms.ContentInfo(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.EnvelopedData, data));
			}
			catch (global::Org.BouncyCastle.Cms.CmsException e)
			{
				throw new global::Org.BouncyCastle.Crmf.CrmfException("CMS parsing error: " + e.Message, e);
			}
			catch (global::System.Exception e2)
			{
				throw new global::Org.BouncyCastle.Crmf.CrmfException("CRMF parsing error: " + e2.Message, e2);
			}
			return result;
		}

		// Token: 0x04001678 RID: 5752
		public static readonly int encryptedPrivKey = 0;

		// Token: 0x04001679 RID: 5753
		public static readonly int keyGenParameters = 1;

		// Token: 0x0400167A RID: 5754
		public static readonly int archiveRemGenPrivKey = 2;

		// Token: 0x0400167B RID: 5755
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier type = global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_regCtrl_pkiArchiveOptions;

		// Token: 0x0400167C RID: 5756
		private readonly global::Org.BouncyCastle.Asn1.Crmf.PkiArchiveOptions pkiArchiveOptions;
	}
}
