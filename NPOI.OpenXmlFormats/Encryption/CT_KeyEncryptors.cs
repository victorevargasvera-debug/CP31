using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Encryption
{
	// Token: 0x02000689 RID: 1673
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3761.0")]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.microsoft.com/office/2006/encryption")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.microsoft.com/office/2006/encryption", IsNullable = true)]
	[global::System.Serializable]
	public class CT_KeyEncryptors
	{
		// Token: 0x06004737 RID: 18231 RVA: 0x000AC0A5 File Offset: 0x000AA2A5
		public CT_KeyEncryptors()
		{
			this.keyEncryptorField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor>();
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06004738 RID: 18232 RVA: 0x000AC0B8 File Offset: 0x000AA2B8
		// (set) Token: 0x06004739 RID: 18233 RVA: 0x000AC0C0 File Offset: 0x000AA2C0
		[global::System.Xml.Serialization.XmlElement("keyEncryptor", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor> keyEncryptor
		{
			get
			{
				return this.keyEncryptorField;
			}
			set
			{
				this.keyEncryptorField = value;
			}
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x000AC0CC File Offset: 0x000AA2CC
		public global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor AddNewKeyEncryptor()
		{
			global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor ct_KeyEncryptor = new global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor();
			this.keyEncryptorField.Add(ct_KeyEncryptor);
			return ct_KeyEncryptor;
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x000AC0EC File Offset: 0x000AA2EC
		internal static global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptors Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager nameSpaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptors ct_KeyEncryptors = new global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptors();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode node2 = (global::System.Xml.XmlNode)obj;
				ct_KeyEncryptors.keyEncryptorField.Add(global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor.Parse(node2, nameSpaceManager));
			}
			return ct_KeyEncryptors;
		}

		// Token: 0x04002CA1 RID: 11425
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptor> keyEncryptorField;
	}
}
