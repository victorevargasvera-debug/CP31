using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Encryption
{
	// Token: 0x0200068C RID: 1676
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3761.0")]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.microsoft.com/office/2006/keyEncryptor/password")]
	[global::System.Xml.Serialization.XmlRoot("encryptedKey", Namespace = "http://schemas.microsoft.com/office/2006/keyEncryptor/password", IsNullable = false)]
	[global::System.Serializable]
	public class CT_PasswordKeyEncryptor
	{
		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06004751 RID: 18257 RVA: 0x000AC343 File Offset: 0x000AA543
		// (set) Token: 0x06004752 RID: 18258 RVA: 0x000AC34B File Offset: 0x000AA54B
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

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x06004753 RID: 18259 RVA: 0x000AC354 File Offset: 0x000AA554
		// (set) Token: 0x06004754 RID: 18260 RVA: 0x000AC35C File Offset: 0x000AA55C
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

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x06004755 RID: 18261 RVA: 0x000AC365 File Offset: 0x000AA565
		// (set) Token: 0x06004756 RID: 18262 RVA: 0x000AC36D File Offset: 0x000AA56D
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

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06004757 RID: 18263 RVA: 0x000AC376 File Offset: 0x000AA576
		// (set) Token: 0x06004758 RID: 18264 RVA: 0x000AC37E File Offset: 0x000AA57E
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

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06004759 RID: 18265 RVA: 0x000AC387 File Offset: 0x000AA587
		// (set) Token: 0x0600475A RID: 18266 RVA: 0x000AC38F File Offset: 0x000AA58F
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

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x0600475B RID: 18267 RVA: 0x000AC398 File Offset: 0x000AA598
		// (set) Token: 0x0600475C RID: 18268 RVA: 0x000AC3A0 File Offset: 0x000AA5A0
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

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x0600475D RID: 18269 RVA: 0x000AC3A9 File Offset: 0x000AA5A9
		// (set) Token: 0x0600475E RID: 18270 RVA: 0x000AC3B1 File Offset: 0x000AA5B1
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

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x0600475F RID: 18271 RVA: 0x000AC3BA File Offset: 0x000AA5BA
		// (set) Token: 0x06004760 RID: 18272 RVA: 0x000AC3C2 File Offset: 0x000AA5C2
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

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x000AC3CB File Offset: 0x000AA5CB
		// (set) Token: 0x06004762 RID: 18274 RVA: 0x000AC3D3 File Offset: 0x000AA5D3
		[global::System.Xml.Serialization.XmlAttribute]
		public uint spinCount
		{
			get
			{
				return this.spinCountField;
			}
			set
			{
				this.spinCountField = value;
			}
		}

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x000AC3DC File Offset: 0x000AA5DC
		// (set) Token: 0x06004764 RID: 18276 RVA: 0x000AC3E4 File Offset: 0x000AA5E4
		[global::System.Xml.Serialization.XmlAttribute(DataType = "base64Binary")]
		public byte[] encryptedVerifierHashInput
		{
			get
			{
				return this.encryptedVerifierHashInputField;
			}
			set
			{
				this.encryptedVerifierHashInputField = value;
			}
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x06004765 RID: 18277 RVA: 0x000AC3ED File Offset: 0x000AA5ED
		// (set) Token: 0x06004766 RID: 18278 RVA: 0x000AC3F5 File Offset: 0x000AA5F5
		[global::System.Xml.Serialization.XmlAttribute(DataType = "base64Binary")]
		public byte[] encryptedVerifierHashValue
		{
			get
			{
				return this.encryptedVerifierHashValueField;
			}
			set
			{
				this.encryptedVerifierHashValueField = value;
			}
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06004767 RID: 18279 RVA: 0x000AC3FE File Offset: 0x000AA5FE
		// (set) Token: 0x06004768 RID: 18280 RVA: 0x000AC406 File Offset: 0x000AA606
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

		// Token: 0x06004769 RID: 18281 RVA: 0x000AC410 File Offset: 0x000AA610
		public static global::NPOI.OpenXmlFormats.Encryption.CT_PasswordKeyEncryptor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager nameSpaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Encryption.CT_PasswordKeyEncryptor ct_PasswordKeyEncryptor = new global::NPOI.OpenXmlFormats.Encryption.CT_PasswordKeyEncryptor();
			ct_PasswordKeyEncryptor.spinCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["spinCount"]);
			ct_PasswordKeyEncryptor.saltSize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["saltSize"]);
			ct_PasswordKeyEncryptor.blockSize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["blockSize"]);
			ct_PasswordKeyEncryptor.keyBits = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["keyBits"]);
			ct_PasswordKeyEncryptor.hashSize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["hashSize"]);
			ct_PasswordKeyEncryptor.cipherAlgorithm = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadEnum<global::NPOI.OpenXmlFormats.Encryption.ST_CipherAlgorithm>(node.Attributes["cipherAlgorithm"]);
			ct_PasswordKeyEncryptor.cipherChaining = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadEnum<global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining>(node.Attributes["cipherChaining"]);
			ct_PasswordKeyEncryptor.hashAlgorithm = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadEnum<global::NPOI.OpenXmlFormats.Encryption.ST_HashAlgorithm>(node.Attributes["hashAlgorithm"]);
			if (node.Attributes["saltValue"] != null)
			{
				ct_PasswordKeyEncryptor.saltValue = global::System.Convert.FromBase64String(node.Attributes["saltValue"].Value);
			}
			if (node.Attributes["encryptedVerifierHashInput"] != null)
			{
				ct_PasswordKeyEncryptor.encryptedVerifierHashInput = global::System.Convert.FromBase64String(node.Attributes["encryptedVerifierHashInput"].Value);
			}
			if (node.Attributes["encryptedVerifierHashValue"] != null)
			{
				ct_PasswordKeyEncryptor.encryptedVerifierHashValue = global::System.Convert.FromBase64String(node.Attributes["encryptedVerifierHashValue"].Value);
			}
			if (node.Attributes["encryptedKeyValue"] != null)
			{
				ct_PasswordKeyEncryptor.encryptedKeyValue = global::System.Convert.FromBase64String(node.Attributes["encryptedKeyValue"].Value);
			}
			return ct_PasswordKeyEncryptor;
		}

		// Token: 0x04002CAA RID: 11434
		private uint saltSizeField;

		// Token: 0x04002CAB RID: 11435
		private uint blockSizeField;

		// Token: 0x04002CAC RID: 11436
		private uint keyBitsField;

		// Token: 0x04002CAD RID: 11437
		private uint hashSizeField;

		// Token: 0x04002CAE RID: 11438
		private global::NPOI.OpenXmlFormats.Encryption.ST_CipherAlgorithm cipherAlgorithmField;

		// Token: 0x04002CAF RID: 11439
		private global::NPOI.OpenXmlFormats.Encryption.ST_CipherChaining cipherChainingField;

		// Token: 0x04002CB0 RID: 11440
		private global::NPOI.OpenXmlFormats.Encryption.ST_HashAlgorithm hashAlgorithmField;

		// Token: 0x04002CB1 RID: 11441
		private byte[] saltValueField;

		// Token: 0x04002CB2 RID: 11442
		private uint spinCountField;

		// Token: 0x04002CB3 RID: 11443
		private byte[] encryptedVerifierHashInputField;

		// Token: 0x04002CB4 RID: 11444
		private byte[] encryptedVerifierHashValueField;

		// Token: 0x04002CB5 RID: 11445
		private byte[] encryptedKeyValueField;
	}
}
