using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Encryption
{
	// Token: 0x02000681 RID: 1665
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3761.0")]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.microsoft.com/office/2006/encryption")]
	[global::System.Xml.Serialization.XmlRoot("encryption", Namespace = "http://schemas.microsoft.com/office/2006/encryption", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Encryption
	{
		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x0600470B RID: 18187 RVA: 0x000ABC58 File Offset: 0x000A9E58
		// (set) Token: 0x0600470C RID: 18188 RVA: 0x000ABC60 File Offset: 0x000A9E60
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Encryption.CT_KeyData keyData
		{
			get
			{
				return this.keyDataField;
			}
			set
			{
				this.keyDataField = value;
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x0600470D RID: 18189 RVA: 0x000ABC69 File Offset: 0x000A9E69
		// (set) Token: 0x0600470E RID: 18190 RVA: 0x000ABC71 File Offset: 0x000A9E71
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Encryption.CT_DataIntegrity dataIntegrity
		{
			get
			{
				return this.dataIntegrityField;
			}
			set
			{
				this.dataIntegrityField = value;
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x0600470F RID: 18191 RVA: 0x000ABC7A File Offset: 0x000A9E7A
		// (set) Token: 0x06004710 RID: 18192 RVA: 0x000ABC82 File Offset: 0x000A9E82
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptors keyEncryptors
		{
			get
			{
				return this.keyEncryptorsField;
			}
			set
			{
				this.keyEncryptorsField = value;
			}
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x000024E5 File Offset: 0x000006E5
		public global::NPOI.OpenXmlFormats.Encryption.CT_KeyData AddNewKeyData()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x000024E5 File Offset: 0x000006E5
		public global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptors AddNewKeyEncryptors()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x000024E5 File Offset: 0x000006E5
		public global::NPOI.OpenXmlFormats.Encryption.CT_DataIntegrity AddNewDataIntegrity()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x000ABC8C File Offset: 0x000A9E8C
		internal static global::NPOI.OpenXmlFormats.Encryption.CT_Encryption Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager nameSpaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Encryption.CT_Encryption ct_Encryption = new global::NPOI.OpenXmlFormats.Encryption.CT_Encryption();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "keyData")
				{
					ct_Encryption.keyData = global::NPOI.OpenXmlFormats.Encryption.CT_KeyData.Parse(xmlNode, nameSpaceManager);
				}
				else if (xmlNode.LocalName == "dataIntegrity")
				{
					ct_Encryption.dataIntegrity = global::NPOI.OpenXmlFormats.Encryption.CT_DataIntegrity.Parse(xmlNode, nameSpaceManager);
				}
				else if (xmlNode.LocalName == "keyEncryptors")
				{
					ct_Encryption.keyEncryptorsField = global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptors.Parse(xmlNode, nameSpaceManager);
				}
			}
			return ct_Encryption;
		}

		// Token: 0x04002C78 RID: 11384
		private global::NPOI.OpenXmlFormats.Encryption.CT_KeyData keyDataField;

		// Token: 0x04002C79 RID: 11385
		private global::NPOI.OpenXmlFormats.Encryption.CT_DataIntegrity dataIntegrityField;

		// Token: 0x04002C7A RID: 11386
		private global::NPOI.OpenXmlFormats.Encryption.CT_KeyEncryptors keyEncryptorsField;
	}
}
