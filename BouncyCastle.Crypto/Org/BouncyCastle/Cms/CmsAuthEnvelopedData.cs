using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000521 RID: 1313
	internal class CmsAuthEnvelopedData
	{
		// Token: 0x060032EA RID: 13034 RVA: 0x000F3408 File Offset: 0x000F1608
		public CmsAuthEnvelopedData(byte[] authEnvData) : this(global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(authEnvData))
		{
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x000F3416 File Offset: 0x000F1616
		public CmsAuthEnvelopedData(global::System.IO.Stream authEnvData) : this(global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(authEnvData))
		{
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x000F3424 File Offset: 0x000F1624
		public CmsAuthEnvelopedData(global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo)
		{
			this.contentInfo = contentInfo;
			global::Org.BouncyCastle.Asn1.Cms.AuthEnvelopedData authEnvData = global::Org.BouncyCastle.Asn1.Cms.AuthEnvelopedData.GetInstance(contentInfo.Content);
			this.originator = authEnvData.OriginatorInfo;
			global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos = authEnvData.RecipientInfos;
			global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo authEncInfo = authEnvData.AuthEncryptedContentInfo;
			this.authEncAlg = authEncInfo.ContentEncryptionAlgorithm;
			global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable = new global::Org.BouncyCastle.Cms.CmsAuthEnvelopedData.AuthEnvelopedSecureReadable(this);
			this.recipientInfoStore = global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.BuildRecipientInformationStore(recipientInfos, secureReadable);
			this.authAttrs = authEnvData.AuthAttrs;
			this.mac = authEnvData.Mac.GetOctets();
			this.unauthAttrs = authEnvData.UnauthAttrs;
		}

		// Token: 0x040016A7 RID: 5799
		internal global::Org.BouncyCastle.Cms.RecipientInformationStore recipientInfoStore;

		// Token: 0x040016A8 RID: 5800
		internal global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo;

		// Token: 0x040016A9 RID: 5801
		private global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo originator;

		// Token: 0x040016AA RID: 5802
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier authEncAlg;

		// Token: 0x040016AB RID: 5803
		private global::Org.BouncyCastle.Asn1.Asn1Set authAttrs;

		// Token: 0x040016AC RID: 5804
		private byte[] mac;

		// Token: 0x040016AD RID: 5805
		private global::Org.BouncyCastle.Asn1.Asn1Set unauthAttrs;

		// Token: 0x02000839 RID: 2105
		private class AuthEnvelopedSecureReadable : global::Org.BouncyCastle.Cms.CmsSecureReadable
		{
			// Token: 0x0600470A RID: 18186 RVA: 0x00139FEC File Offset: 0x001381EC
			internal AuthEnvelopedSecureReadable(global::Org.BouncyCastle.Cms.CmsAuthEnvelopedData parent)
			{
				this.parent = parent;
			}

			// Token: 0x17000AB1 RID: 2737
			// (get) Token: 0x0600470B RID: 18187 RVA: 0x00139FFB File Offset: 0x001381FB
			public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Algorithm
			{
				get
				{
					return this.parent.authEncAlg;
				}
			}

			// Token: 0x17000AB2 RID: 2738
			// (get) Token: 0x0600470C RID: 18188 RVA: 0x0013A008 File Offset: 0x00138208
			public object CryptoObject
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0600470D RID: 18189 RVA: 0x0013A00B File Offset: 0x0013820B
			public global::Org.BouncyCastle.Cms.CmsReadable GetReadable(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("AuthEnveloped data decryption not yet implemented");
			}

			// Token: 0x04002580 RID: 9600
			private readonly global::Org.BouncyCastle.Cms.CmsAuthEnvelopedData parent;
		}
	}
}
