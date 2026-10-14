using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200055A RID: 1370
	public class SignerInfoGeneratorBuilder
	{
		// Token: 0x06003472 RID: 13426 RVA: 0x000FA7F4 File Offset: 0x000F89F4
		public global::Org.BouncyCastle.Cms.SignerInfoGeneratorBuilder SetDirectSignature(bool hasNoSignedAttributes)
		{
			this.directSignature = hasNoSignedAttributes;
			return this;
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x000FA7FE File Offset: 0x000F89FE
		public global::Org.BouncyCastle.Cms.SignerInfoGeneratorBuilder WithSignedAttributeGenerator(global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedGen)
		{
			this.signedGen = signedGen;
			return this;
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x000FA808 File Offset: 0x000F8A08
		public global::Org.BouncyCastle.Cms.SignerInfoGeneratorBuilder WithUnsignedAttributeGenerator(global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedGen)
		{
			this.unsignedGen = unsignedGen;
			return this;
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x000FA814 File Offset: 0x000F8A14
		public global::Org.BouncyCastle.Cms.SignerInfoGenerator Build(global::Org.BouncyCastle.Crypto.ISignatureFactory contentSigner, global::Org.BouncyCastle.X509.X509Certificate certificate)
		{
			global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier sigId = new global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier(new global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber(certificate.IssuerDN, new global::Org.BouncyCastle.Asn1.DerInteger(certificate.SerialNumber)));
			global::Org.BouncyCastle.Cms.SignerInfoGenerator signerInfoGenerator = this.CreateGenerator(contentSigner, sigId);
			signerInfoGenerator.setAssociatedCertificate(certificate);
			return signerInfoGenerator;
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x000FA84C File Offset: 0x000F8A4C
		public global::Org.BouncyCastle.Cms.SignerInfoGenerator Build(global::Org.BouncyCastle.Crypto.ISignatureFactory signerFactory, byte[] subjectKeyIdentifier)
		{
			global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier sigId = new global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier(new global::Org.BouncyCastle.Asn1.DerOctetString(subjectKeyIdentifier));
			return this.CreateGenerator(signerFactory, sigId);
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x000FA870 File Offset: 0x000F8A70
		private global::Org.BouncyCastle.Cms.SignerInfoGenerator CreateGenerator(global::Org.BouncyCastle.Crypto.ISignatureFactory contentSigner, global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier sigId)
		{
			if (this.directSignature)
			{
				return new global::Org.BouncyCastle.Cms.SignerInfoGenerator(sigId, contentSigner, true);
			}
			if (this.signedGen != null || this.unsignedGen != null)
			{
				if (this.signedGen == null)
				{
					this.signedGen = new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator();
				}
				return new global::Org.BouncyCastle.Cms.SignerInfoGenerator(sigId, contentSigner, this.signedGen, this.unsignedGen);
			}
			return new global::Org.BouncyCastle.Cms.SignerInfoGenerator(sigId, contentSigner);
		}

		// Token: 0x04001773 RID: 6003
		private bool directSignature;

		// Token: 0x04001774 RID: 6004
		private global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedGen;

		// Token: 0x04001775 RID: 6005
		private global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedGen;
	}
}
