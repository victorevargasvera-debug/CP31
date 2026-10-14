using System;
using System.IO;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x02000511 RID: 1297
	public class PkiArchiveControlBuilder
	{
		// Token: 0x060032A0 RID: 12960 RVA: 0x000F25E0 File Offset: 0x000F07E0
		public PkiArchiveControlBuilder(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo privateKeyInfo, global::Org.BouncyCastle.Asn1.X509.GeneralName generalName)
		{
			global::Org.BouncyCastle.Asn1.Crmf.EncKeyWithID encKeyWithID = new global::Org.BouncyCastle.Asn1.Crmf.EncKeyWithID(privateKeyInfo, generalName);
			try
			{
				this.keyContent = new global::Org.BouncyCastle.Cms.CmsProcessableByteArray(global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_ct_encKeyWithID, encKeyWithID.GetEncoded());
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::System.InvalidOperationException("unable to encode key and general name info", e);
			}
			this.envGen = new global::Org.BouncyCastle.Cms.CmsEnvelopedDataGenerator();
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x000F263C File Offset: 0x000F083C
		public global::Org.BouncyCastle.Crmf.PkiArchiveControlBuilder AddRecipientGenerator(global::Org.BouncyCastle.Cms.RecipientInfoGenerator recipientGen)
		{
			this.envGen.AddRecipientInfoGenerator(recipientGen);
			return this;
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000F264B File Offset: 0x000F084B
		public global::Org.BouncyCastle.Crmf.PkiArchiveControl Build(global::Org.BouncyCastle.Crypto.ICipherBuilderWithKey contentEncryptor)
		{
			return new global::Org.BouncyCastle.Crmf.PkiArchiveControl(new global::Org.BouncyCastle.Asn1.Crmf.PkiArchiveOptions(new global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey(global::Org.BouncyCastle.Asn1.Cms.EnvelopedData.GetInstance(this.envGen.Generate(this.keyContent, contentEncryptor).ContentInfo.Content))));
		}

		// Token: 0x0400167D RID: 5757
		private global::Org.BouncyCastle.Cms.CmsEnvelopedDataGenerator envGen;

		// Token: 0x0400167E RID: 5758
		private global::Org.BouncyCastle.Cms.CmsProcessableByteArray keyContent;
	}
}
