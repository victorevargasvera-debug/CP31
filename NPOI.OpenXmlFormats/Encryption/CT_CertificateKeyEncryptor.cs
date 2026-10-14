using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Encryption
{
	// Token: 0x0200068B RID: 1675
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3761.0")]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.microsoft.com/office/2006/keyEncryptor/certificate")]
	[global::System.Xml.Serialization.XmlRoot("encryptedKey", Namespace = "http://schemas.microsoft.com/office/2006/keyEncryptor/certificate", IsNullable = false)]
	[global::System.Serializable]
	public class CT_CertificateKeyEncryptor
	{
		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06004749 RID: 18249 RVA: 0x000AC261 File Offset: 0x000AA461
		// (set) Token: 0x0600474A RID: 18250 RVA: 0x000AC269 File Offset: 0x000AA469
		[global::System.Xml.Serialization.XmlAttribute(DataType = "base64Binary")]
		public byte[] encryptedKeyValue
		{
			get
			{
				return this.encryptedKeyValueField;
			}
			set
			{
				this.encryptedKeyValueField = value;
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x0600474B RID: 18251 RVA: 0x000AC272 File Offset: 0x000AA472
		// (set) Token: 0x0600474C RID: 18252 RVA: 0x000AC27A File Offset: 0x000AA47A
		[global::System.Xml.Serialization.XmlAttribute(DataType = "base64Binary")]
		public byte[] X509Certificate
		{
			get
			{
				return this.x509CertificateField;
			}
			set
			{
				this.x509CertificateField = value;
			}
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x0600474D RID: 18253 RVA: 0x000AC283 File Offset: 0x000AA483
		// (set) Token: 0x0600474E RID: 18254 RVA: 0x000AC28B File Offset: 0x000AA48B
		[global::System.Xml.Serialization.XmlAttribute(DataType = "base64Binary")]
		public byte[] certVerifier
		{
			get
			{
				return this.certVerifierField;
			}
			set
			{
				this.certVerifierField = value;
			}
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x000AC294 File Offset: 0x000AA494
		public static global::NPOI.OpenXmlFormats.Encryption.CT_CertificateKeyEncryptor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager nameSpaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Encryption.CT_CertificateKeyEncryptor ct_CertificateKeyEncryptor = new global::NPOI.OpenXmlFormats.Encryption.CT_CertificateKeyEncryptor();
			if (node.Attributes["certVerifier"] != null)
			{
				ct_CertificateKeyEncryptor.certVerifier = global::System.Convert.FromBase64String(node.Attributes["certVerifier"].Value);
			}
			if (node.Attributes["encryptedKeyValue"] != null)
			{
				ct_CertificateKeyEncryptor.encryptedKeyValue = global::System.Convert.FromBase64String(node.Attributes["encryptedKeyValue"].Value);
			}
			if (node.Attributes["x509Certificate"] != null)
			{
				ct_CertificateKeyEncryptor.X509Certificate = global::System.Convert.FromBase64String(node.Attributes["x509Certificate"].Value);
			}
			return ct_CertificateKeyEncryptor;
		}

		// Token: 0x04002CA7 RID: 11431
		private byte[] encryptedKeyValueField;

		// Token: 0x04002CA8 RID: 11432
		private byte[] x509CertificateField;

		// Token: 0x04002CA9 RID: 11433
		private byte[] certVerifierField;
	}
}
