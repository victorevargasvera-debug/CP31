using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000173 RID: 371
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_WriteProtection
	{
		// Token: 0x06000D8D RID: 3469 RVA: 0x0002E064 File Offset: 0x0002C264
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_WriteProtection Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_WriteProtection ct_WriteProtection = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_WriteProtection();
			if (node.Attributes["w:recommended"] != null)
			{
				ct_WriteProtection.recommended = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:recommended"].Value, true);
			}
			if (node.Attributes["w:cryptProviderType"] != null)
			{
				ct_WriteProtection.cryptProviderType = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_CryptProv)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_CryptProv), node.Attributes["w:cryptProviderType"].Value);
			}
			if (node.Attributes["w:cryptAlgorithmClass"] != null)
			{
				ct_WriteProtection.cryptAlgorithmClass = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgClass)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgClass), node.Attributes["w:cryptAlgorithmClass"].Value);
			}
			if (node.Attributes["w:cryptAlgorithmType"] != null)
			{
				ct_WriteProtection.cryptAlgorithmType = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgType), node.Attributes["w:cryptAlgorithmType"].Value);
			}
			ct_WriteProtection.cryptAlgorithmSid = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:cryptAlgorithmSid"]);
			ct_WriteProtection.cryptSpinCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:cryptSpinCount"]);
			ct_WriteProtection.cryptProvider = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:cryptProvider"]);
			ct_WriteProtection.algIdExt = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:algIdExt"]);
			ct_WriteProtection.algIdExtSource = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:algIdExtSource"]);
			ct_WriteProtection.cryptProviderTypeExt = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:cryptProviderTypeExt"]);
			ct_WriteProtection.cryptProviderTypeExtSource = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:cryptProviderTypeExtSource"]);
			ct_WriteProtection.hash = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:hash"]);
			ct_WriteProtection.salt = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:salt"]);
			return ct_WriteProtection;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0002E278 File Offset: 0x0002C478
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:recommended", this.recommended.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:cryptProviderType", this.cryptProviderType.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:cryptAlgorithmClass", this.cryptAlgorithmClass.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:cryptAlgorithmType", this.cryptAlgorithmType.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:cryptAlgorithmSid", this.cryptAlgorithmSid);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:cryptSpinCount", this.cryptSpinCount);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:cryptProvider", this.cryptProvider);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:algIdExt", this.algIdExt);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:algIdExtSource", this.algIdExtSource);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:cryptProviderTypeExt", this.cryptProviderTypeExt);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:cryptProviderTypeExtSource", this.cryptProviderTypeExtSource);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:hash", this.hash);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:salt", this.salt);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x0002E3C7 File Offset: 0x0002C5C7
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x0002E3CF File Offset: 0x0002C5CF
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff recommended
		{
			get
			{
				return this.recommendedField;
			}
			set
			{
				this.recommendedField = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x0002E3D8 File Offset: 0x0002C5D8
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x0002E3E0 File Offset: 0x0002C5E0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool recommendedSpecified
		{
			get
			{
				return this.recommendedFieldSpecified;
			}
			set
			{
				this.recommendedFieldSpecified = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0002E3E9 File Offset: 0x0002C5E9
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x0002E3F1 File Offset: 0x0002C5F1
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_CryptProv cryptProviderType
		{
			get
			{
				return this.cryptProviderTypeField;
			}
			set
			{
				this.cryptProviderTypeField = value;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0002E3FA File Offset: 0x0002C5FA
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x0002E402 File Offset: 0x0002C602
		[global::System.Xml.Serialization.XmlIgnore]
		public bool cryptProviderTypeSpecified
		{
			get
			{
				return this.cryptProviderTypeFieldSpecified;
			}
			set
			{
				this.cryptProviderTypeFieldSpecified = value;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0002E40B File Offset: 0x0002C60B
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x0002E413 File Offset: 0x0002C613
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgClass cryptAlgorithmClass
		{
			get
			{
				return this.cryptAlgorithmClassField;
			}
			set
			{
				this.cryptAlgorithmClassField = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0002E41C File Offset: 0x0002C61C
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x0002E424 File Offset: 0x0002C624
		[global::System.Xml.Serialization.XmlIgnore]
		public bool cryptAlgorithmClassSpecified
		{
			get
			{
				return this.cryptAlgorithmClassFieldSpecified;
			}
			set
			{
				this.cryptAlgorithmClassFieldSpecified = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0002E42D File Offset: 0x0002C62D
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x0002E435 File Offset: 0x0002C635
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgType cryptAlgorithmType
		{
			get
			{
				return this.cryptAlgorithmTypeField;
			}
			set
			{
				this.cryptAlgorithmTypeField = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0002E43E File Offset: 0x0002C63E
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x0002E446 File Offset: 0x0002C646
		[global::System.Xml.Serialization.XmlIgnore]
		public bool cryptAlgorithmTypeSpecified
		{
			get
			{
				return this.cryptAlgorithmTypeFieldSpecified;
			}
			set
			{
				this.cryptAlgorithmTypeFieldSpecified = value;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0002E44F File Offset: 0x0002C64F
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x0002E457 File Offset: 0x0002C657
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string cryptAlgorithmSid
		{
			get
			{
				return this.cryptAlgorithmSidField;
			}
			set
			{
				this.cryptAlgorithmSidField = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0002E460 File Offset: 0x0002C660
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x0002E468 File Offset: 0x0002C668
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string cryptSpinCount
		{
			get
			{
				return this.cryptSpinCountField;
			}
			set
			{
				this.cryptSpinCountField = value;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0002E471 File Offset: 0x0002C671
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x0002E479 File Offset: 0x0002C679
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string cryptProvider
		{
			get
			{
				return this.cryptProviderField;
			}
			set
			{
				this.cryptProviderField = value;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0002E482 File Offset: 0x0002C682
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x0002E48A File Offset: 0x0002C68A
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] algIdExt
		{
			get
			{
				return this.algIdExtField;
			}
			set
			{
				this.algIdExtField = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0002E493 File Offset: 0x0002C693
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x0002E49B File Offset: 0x0002C69B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string algIdExtSource
		{
			get
			{
				return this.algIdExtSourceField;
			}
			set
			{
				this.algIdExtSourceField = value;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x0002E4A4 File Offset: 0x0002C6A4
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x0002E4AC File Offset: 0x0002C6AC
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] cryptProviderTypeExt
		{
			get
			{
				return this.cryptProviderTypeExtField;
			}
			set
			{
				this.cryptProviderTypeExtField = value;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x0002E4B5 File Offset: 0x0002C6B5
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x0002E4BD File Offset: 0x0002C6BD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string cryptProviderTypeExtSource
		{
			get
			{
				return this.cryptProviderTypeExtSourceField;
			}
			set
			{
				this.cryptProviderTypeExtSourceField = value;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x0002E4C6 File Offset: 0x0002C6C6
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x0002E4CE File Offset: 0x0002C6CE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "base64Binary")]
		public byte[] hash
		{
			get
			{
				return this.hashField;
			}
			set
			{
				this.hashField = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x0002E4D7 File Offset: 0x0002C6D7
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x0002E4DF File Offset: 0x0002C6DF
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "base64Binary")]
		public byte[] salt
		{
			get
			{
				return this.saltField;
			}
			set
			{
				this.saltField = value;
			}
		}

		// Token: 0x04000B7C RID: 2940
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff recommendedField;

		// Token: 0x04000B7D RID: 2941
		private bool recommendedFieldSpecified;

		// Token: 0x04000B7E RID: 2942
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_CryptProv cryptProviderTypeField;

		// Token: 0x04000B7F RID: 2943
		private bool cryptProviderTypeFieldSpecified;

		// Token: 0x04000B80 RID: 2944
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgClass cryptAlgorithmClassField;

		// Token: 0x04000B81 RID: 2945
		private bool cryptAlgorithmClassFieldSpecified;

		// Token: 0x04000B82 RID: 2946
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgType cryptAlgorithmTypeField;

		// Token: 0x04000B83 RID: 2947
		private bool cryptAlgorithmTypeFieldSpecified;

		// Token: 0x04000B84 RID: 2948
		private string cryptAlgorithmSidField;

		// Token: 0x04000B85 RID: 2949
		private string cryptSpinCountField;

		// Token: 0x04000B86 RID: 2950
		private string cryptProviderField;

		// Token: 0x04000B87 RID: 2951
		private byte[] algIdExtField;

		// Token: 0x04000B88 RID: 2952
		private string algIdExtSourceField;

		// Token: 0x04000B89 RID: 2953
		private byte[] cryptProviderTypeExtField;

		// Token: 0x04000B8A RID: 2954
		private string cryptProviderTypeExtSourceField;

		// Token: 0x04000B8B RID: 2955
		private byte[] hashField;

		// Token: 0x04000B8C RID: 2956
		private byte[] saltField;
	}
}
