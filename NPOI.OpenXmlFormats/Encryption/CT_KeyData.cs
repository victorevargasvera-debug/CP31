using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Encryption
{
	// Token: 0x02000682 RID: 1666
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3761.0")]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.microsoft.com/office/2006/encryption")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.microsoft.com/office/2006/encryption", IsNullable = true)]
	[global::System.Serializable]
	public class CT_KeyData
	{
		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x06004715 RID: 18197 RVA: 0x000ABD4C File Offset: 0x000A9F4C
		// (set) Token: 0x06004716 RID: 18198 RVA: 0x000ABD54 File Offset: 0x000A9F54
		[global::System.Xml.Serialization.XmlAttribute]
		public uint saltSize
		{
			get
			{
				return this.saltSizeField;
			}
			set
			{
				this.saltSizeField = value;
			}
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x06004717 RID: 18199 RVA: 0x000ABD5D File Offset: 0x000A9F5D
		// (set) Token: 0x06004718 RID: 18200 RVA: 0x000ABD65 File Offset: 0x000A9F65
		[global::System.Xml.Serialization.XmlAttribute]
		public uint blockSize
		{
			get
			{
				return this.blockSizeField;
			}
			set
			{
				this.blockSizeField = value;
			}
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x06004719 RID: 18201 RVA: 0x000ABD6E File Offset: 0x000A9F6E
		// (set) Token: 0x0600471A RID: 18202 RVA: 0x000ABD76 File Offset: 0x000A9F76
		[global::System.Xml.Serialization.XmlAttribute]
		public uint keyBits
		{
			get
			{
				return this.keyBitsField;
			}
			set
			{
				this.keyBitsField = value;
			}
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x0600471B RID: 18203 RVA: 0x000ABD7F File Offset: 0x000A9F7F
		// (set) Token: 0x0600471C RID: 18204 RVA: 0x000ABD87 File Offset: 0x000A9F87
		[global::System.Xml.Serialization.XmlAttribute]
		public uint hashSize
		{
			get
			{
				return this.hashSizeField;
			}
			set
			{
				this.hashSizeField = value;
			}
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x0600471D RID: 18205 RVA: 0x000ABD90 File Offset: 0x000A9F90
		// (set) Token: 0x0600471E RID: 18206 RVA: 0x000ABD98 File Offset: 0x000A9F98
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Encryption.ST_CipherAlgorithm cipherAlgorithm
		{
			get
			{
				return this.cipherAlgorithmField;
			}
			set
			{
				this.cipherAlgorithmField = value;
			}
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x0600471F RID: 18207 RVA: 0x000ABDA1 File Offset: 0x000A9FA1
		// (set) Token: 0x06004720 RID: 18208 RVA: 0x000ABDA9 File Offset: 0x000A9FA9
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining cipherChaining
		{
			get
			{
				return this.cipherChainingField;
			}
			set
			{
				this.cipherChainingField = value;
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06004721 RID: 18209 RVA: 0x000ABDB2 File Offset: 0x000A9FB2
		// (set) Token: 0x06004722 RID: 18210 RVA: 0x000ABDBA File Offset: 0x000A9FBA
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Encryption.ST_HashAlgorithm hashAlgorithm
		{
			get
			{
				return this.hashAlgorithmField;
			}
			set
			{
				this.hashAlgorithmField = value;
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x06004723 RID: 18211 RVA: 0x000ABDC3 File Offset: 0x000A9FC3
		// (set) Token: 0x06004724 RID: 18212 RVA: 0x000ABDCB File Offset: 0x000A9FCB
		[global::System.Xml.Serialization.XmlAttribute(DataType = "base64Binary")]
		public byte[] saltValue
		{
			get
			{
				return this.saltValueField;
			}
			set
			{
				this.saltValueField = value;
			}
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x000ABDD4 File Offset: 0x000A9FD4
		internal static global::NPOI.OpenXmlFormats.Encryption.CT_KeyData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager nameSpaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Encryption.CT_KeyData ct_KeyData = new global::NPOI.OpenXmlFormats.Encryption.CT_KeyData();
			ct_KeyData.saltSize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["saltSize"]);
			ct_KeyData.blockSize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["blockSize"]);
			ct_KeyData.keyBits = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["keyBits"]);
			ct_KeyData.hashSize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["hashSize"]);
			ct_KeyData.cipherAlgorithm = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadEnum<global::NPOI.OpenXmlFormats.Encryption.ST_CipherAlgorithm>(node.Attributes["cipherAlgorithm"]);
			ct_KeyData.cipherChaining = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadEnum<global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining>(node.Attributes["cipherChaining"]);
			ct_KeyData.hashAlgorithm = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadEnum<global::NPOI.OpenXmlFormats.Encryption.ST_HashAlgorithm>(node.Attributes["hashAlgorithm"]);
			if (node.Attributes["saltValue"] != null)
			{
				ct_KeyData.saltValue = global::System.Convert.FromBase64String(node.Attributes["saltValue"].Value);
			}
			return ct_KeyData;
		}

		// Token: 0x04002C7B RID: 11387
		private uint saltSizeField;

		// Token: 0x04002C7C RID: 11388
		private uint blockSizeField;

		// Token: 0x04002C7D RID: 11389
		private uint keyBitsField;

		// Token: 0x04002C7E RID: 11390
		private uint hashSizeField;

		// Token: 0x04002C7F RID: 11391
		private global::NPOI.OpenXmlFormats.Encryption.ST_CipherAlgorithm cipherAlgorithmField;

		// Token: 0x04002C80 RID: 11392
		private global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining cipherChainingField;

		// Token: 0x04002C81 RID: 11393
		private global::NPOI.OpenXmlFormats.Encryption.ST_HashAlgorithm hashAlgorithmField;

		// Token: 0x04002C82 RID: 11394
		private byte[] saltValueField;
	}
}
