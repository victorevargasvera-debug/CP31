using System;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000559 RID: 1369
	public class SignerInfoGenerator
	{
		// Token: 0x0600346C RID: 13420 RVA: 0x000FA72C File Offset: 0x000F892C
		internal SignerInfoGenerator(global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier sigId, global::Org.BouncyCastle.Crypto.ISignatureFactory signerFactory) : this(sigId, signerFactory, false)
		{
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x000FA738 File Offset: 0x000F8938
		internal SignerInfoGenerator(global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier sigId, global::Org.BouncyCastle.Crypto.ISignatureFactory signerFactory, bool isDirectSignature)
		{
			this.sigId = sigId;
			this.contentSigner = signerFactory;
			this.isDirectSignature = isDirectSignature;
			if (this.isDirectSignature)
			{
				this.signedGen = null;
				this.unsignedGen = null;
				return;
			}
			this.signedGen = new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator();
			this.unsignedGen = null;
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x000FA789 File Offset: 0x000F8989
		internal SignerInfoGenerator(global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier sigId, global::Org.BouncyCastle.Crypto.ISignatureFactory contentSigner, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedGen, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedGen)
		{
			this.sigId = sigId;
			this.contentSigner = contentSigner;
			this.signedGen = signedGen;
			this.unsignedGen = unsignedGen;
			this.isDirectSignature = false;
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x000FA7B5 File Offset: 0x000F89B5
		internal void setAssociatedCertificate(global::Org.BouncyCastle.X509.X509Certificate certificate)
		{
			this.certificate = certificate;
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x000FA7BE File Offset: 0x000F89BE
		public global::Org.BouncyCastle.Cms.SignerInfoGeneratorBuilder NewBuilder()
		{
			global::Org.BouncyCastle.Cms.SignerInfoGeneratorBuilder signerInfoGeneratorBuilder = new global::Org.BouncyCastle.Cms.SignerInfoGeneratorBuilder();
			signerInfoGeneratorBuilder.WithSignedAttributeGenerator(this.signedGen);
			signerInfoGeneratorBuilder.WithUnsignedAttributeGenerator(this.unsignedGen);
			signerInfoGeneratorBuilder.SetDirectSignature(this.isDirectSignature);
			return signerInfoGeneratorBuilder;
		}

		// Token: 0x0400176D RID: 5997
		internal global::Org.BouncyCastle.X509.X509Certificate certificate;

		// Token: 0x0400176E RID: 5998
		internal global::Org.BouncyCastle.Crypto.ISignatureFactory contentSigner;

		// Token: 0x0400176F RID: 5999
		internal global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier sigId;

		// Token: 0x04001770 RID: 6000
		internal global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedGen;

		// Token: 0x04001771 RID: 6001
		internal global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedGen;

		// Token: 0x04001772 RID: 6002
		private bool isDirectSignature;
	}
}
