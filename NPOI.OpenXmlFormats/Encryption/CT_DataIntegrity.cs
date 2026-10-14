using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Encryption
{
	// Token: 0x02000688 RID: 1672
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3761.0")]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.microsoft.com/office/2006/encryption")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.microsoft.com/office/2006/encryption", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DataIntegrity
	{
		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x06004731 RID: 18225 RVA: 0x000AC004 File Offset: 0x000AA204
		// (set) Token: 0x06004732 RID: 18226 RVA: 0x000AC00C File Offset: 0x000AA20C
		[global::System.Xml.Serialization.XmlAttribute(DataType = "base64Binary")]
		public byte[] encryptedHmacKey
		{
			get
			{
				return this.encryptedHmacKeyField;
			}
			set
			{
				this.encryptedHmacKeyField = value;
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x06004733 RID: 18227 RVA: 0x000AC015 File Offset: 0x000AA215
		// (set) Token: 0x06004734 RID: 18228 RVA: 0x000AC01D File Offset: 0x000AA21D
		[global::System.Xml.Serialization.XmlAttribute(DataType = "base64Binary")]
		public byte[] encryptedHmacValue
		{
			get
			{
				return this.encryptedHmacValueField;
			}
			set
			{
				this.encryptedHmacValueField = value;
			}
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x000AC028 File Offset: 0x000AA228
		internal static global::NPOI.OpenXmlFormats.Encryption.CT_DataIntegrity Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager nameSpaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Encryption.CT_DataIntegrity ct_DataIntegrity = new global::NPOI.OpenXmlFormats.Encryption.CT_DataIntegrity();
			if (node.Attributes["encryptedHmacKey"] != null)
			{
				ct_DataIntegrity.encryptedHmacKey = global::System.Convert.FromBase64String(node.Attributes["encryptedHmacKey"].Value);
			}
			if (node.Attributes["encryptedHmacValue"] != null)
			{
				ct_DataIntegrity.encryptedHmacValue = global::System.Convert.FromBase64String(node.Attributes["encryptedHmacValue"].Value);
			}
			return ct_DataIntegrity;
		}

		// Token: 0x04002C9F RID: 11423
		private byte[] encryptedHmacKeyField;

		// Token: 0x04002CA0 RID: 11424
		private byte[] encryptedHmacValueField;
	}
}
