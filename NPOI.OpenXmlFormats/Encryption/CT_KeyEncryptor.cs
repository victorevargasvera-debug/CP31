using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Encryption
{
	// Token: 0x02000686 RID: 1670
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3761.0")]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.microsoft.com/office/2006/encryption")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.microsoft.com/office/2006/encryption", IsNullable = true)]
	[global::System.Serializable]
	public class CT_KeyEncryptor
	{
		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06004727 RID: 18215 RVA: 0x000ABEDC File Offset: 0x000AA0DC
		// (set) Token: 0x06004728 RID: 18216 RVA: 0x000ABEE4 File Offset: 0x000AA0E4
		[global::System.Xml.Serialization.XmlElement("encryptedKey", typeof(global::NPOI.OpenXmlFormats.Encryption.CT_CertificateKeyEncryptor), Namespace = "http://schemas.microsoft.com/office/2006/keyEncryptor/certificate", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("encryptedKey", typeof(global::NPOI.OpenXmlFormats.Encryption.CT_PasswordKeyEncryptor), Namespace = "http://schemas.microsoft.com/office/2006/keyEncryptor/password", Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x06004729 RID: 18217 RVA: 0x000ABEED File Offset: 0x000AA0ED
		// (set) Token: 0x0600472A RID: 18218 RVA: 0x000ABEF5 File Offset: 0x000AA0F5
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptorUri uri
		{
			get
			{
				return this.uriField;
			}
			set
			{
				this.uriField = value;
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x0600472B RID: 18219 RVA: 0x000ABEFE File Offset: 0x000AA0FE
		// (set) Token: 0x0600472C RID: 18220 RVA: 0x000ABF06 File Offset: 0x000AA106
		[global::System.Xml.Serialization.XmlIgnore]
		public bool uriSpecified
		{
			get
			{
				return this.uriFieldSpecified;
			}
			set
			{
				this.uriFieldSpecified = value;
			}
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x000ABF10 File Offset: 0x000AA110
		public global::NPOI.OpenXmlFormats.Encryption.CT_PasswordKeyEncryptor AddNewEncryptedPasswordKey()
		{
			global::NPOI.OpenXmlFormats.Encryption.CT_PasswordKeyEncryptor result = new global::NPOI.OpenXmlFormats.Encryption.CT_PasswordKeyEncryptor();
			this.itemField = result;
			return result;
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x000ABF2C File Offset: 0x000AA12C
		public global::NPOI.OpenXmlFormats.Encryption.CT_CertificateKeyEncryptor AddNewEncryptedCertificateKey()
		{
			global::NPOI.OpenXmlFormats.Encryption.CT_CertificateKeyEncryptor result = new global::NPOI.OpenXmlFormats.Encryption.CT_CertificateKeyEncryptor();
			this.itemField = result;
			return result;
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x000ABF48 File Offset: 0x000AA148
		public static global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager nameSpaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor ct_KeyEncryptor = new global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor();
			if (node.Attributes["uri"] != null)
			{
				ct_KeyEncryptor.uriFieldSpecified = true;
				ct_KeyEncryptor.uriField = global::NPOI.OpenXml4Net.Util.XmlHelper.GetEnumValueFromString<global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptorUri>(node.Attributes["uri"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode node2 = (global::System.Xml.XmlNode)obj;
				if (ct_KeyEncryptor.uriField == global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptorUri.httpschemasmicrosoftcomoffice2006keyEncryptorcertificate)
				{
					ct_KeyEncryptor.itemField = global::NPOI.OpenXmlFormats.Encryption.CT_CertificateKeyEncryptor.Parse(node2, nameSpaceManager);
				}
				else
				{
					ct_KeyEncryptor.itemField = global::NPOI.OpenXmlFormats.Encryption.CT_PasswordKeyEncryptor.Parse(node2, nameSpaceManager);
				}
			}
			return ct_KeyEncryptor;
		}

		// Token: 0x04002C99 RID: 11417
		private object itemField;

		// Token: 0x04002C9A RID: 11418
		private global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptorUri uriField;

		// Token: 0x04002C9B RID: 11419
		private bool uriFieldSpecified;
	}
}
