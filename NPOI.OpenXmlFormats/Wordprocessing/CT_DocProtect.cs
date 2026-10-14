using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200018E RID: 398
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocProtect
	{
		// Token: 0x06000E56 RID: 3670 RVA: 0x0002FD84 File Offset: 0x0002DF84
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocProtect Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocProtect ct_DocProtect = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocProtect();
			if (node.Attributes["w:edit"] != null)
			{
				ct_DocProtect.edit = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect), node.Attributes["w:edit"].Value);
			}
			if (node.Attributes["w:formatting"] != null)
			{
				ct_DocProtect.formatting = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:formatting"].Value, true);
			}
			if (node.Attributes["w:enforcement"] != null)
			{
				ct_DocProtect.enforcement = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff), node.Attributes["w:enforcement"].Value, true);
			}
			if (node.Attributes["w:cryptProviderType"] != null)
			{
				ct_DocProtect.cryptProviderType = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_CryptProv)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_CryptProv), node.Attributes["w:cryptProviderType"].Value);
			}
			if (node.Attributes["w:cryptAlgorithmClass"] != null)
			{
				ct_DocProtect.cryptAlgorithmClass = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgClass)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgClass), node.Attributes["w:cryptAlgorithmClass"].Value);
			}
			if (node.Attributes["w:cryptAlgorithmType"] != null)
			{
				ct_DocProtect.cryptAlgorithmType = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgType), node.Attributes["w:cryptAlgorithmType"].Value);
			}
			ct_DocProtect.cryptAlgorithmSid = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:cryptAlgorithmSid"]);
			ct_DocProtect.cryptSpinCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:cryptSpinCount"]);
			ct_DocProtect.cryptProvider = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:cryptProvider"]);
			ct_DocProtect.algIdExt = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:algIdExt"]);
			ct_DocProtect.algIdExtSource = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:algIdExtSource"]);
			ct_DocProtect.cryptProviderTypeExt = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:cryptProviderTypeExt"]);
			ct_DocProtect.cryptProviderTypeExtSource = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:cryptProviderTypeExtSource"]);
			ct_DocProtect.hash = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:hash"]);
			ct_DocProtect.salt = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:salt"]);
			return ct_DocProtect;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00030018 File Offset: 0x0002E218
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:edit", this.edit.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:formatting", this.formatting.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:enforcement", this.enforcement.ToString());
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
			sw.Write("/>");
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00030195 File Offset: 0x0002E395
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x0003019D File Offset: 0x0002E39D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect edit
		{
			get
			{
				return this.editField;
			}
			set
			{
				this.editField = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x000301A6 File Offset: 0x0002E3A6
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x000301B1 File Offset: 0x0002E3B1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool editSpecified
		{
			get
			{
				return this.editField > global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect.none;
			}
			set
			{
				this.editFieldSpecified = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x000301BA File Offset: 0x0002E3BA
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x000301C2 File Offset: 0x0002E3C2
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff formatting
		{
			get
			{
				return this.formattingField;
			}
			set
			{
				this.formattingField = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x000301CB File Offset: 0x0002E3CB
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x000301D3 File Offset: 0x0002E3D3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool formattingSpecified
		{
			get
			{
				return this.formattingFieldSpecified;
			}
			set
			{
				this.formattingFieldSpecified = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x000301DC File Offset: 0x0002E3DC
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x000301E4 File Offset: 0x0002E3E4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff enforcement
		{
			get
			{
				return this.enforcementField;
			}
			set
			{
				this.enforcementField = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x000301A6 File Offset: 0x0002E3A6
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x000301ED File Offset: 0x0002E3ED
		[global::System.Xml.Serialization.XmlIgnore]
		public bool enforcementSpecified
		{
			get
			{
				return this.editField > global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect.none;
			}
			set
			{
				this.enforcementFieldSpecified = value;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x000301F6 File Offset: 0x0002E3F6
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x000301FE File Offset: 0x0002E3FE
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

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00030207 File Offset: 0x0002E407
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x0003020F File Offset: 0x0002E40F
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

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00030218 File Offset: 0x0002E418
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00030220 File Offset: 0x0002E420
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

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00030229 File Offset: 0x0002E429
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x00030231 File Offset: 0x0002E431
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

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x0003023A File Offset: 0x0002E43A
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x00030242 File Offset: 0x0002E442
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

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0003024B File Offset: 0x0002E44B
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x00030253 File Offset: 0x0002E453
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

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0003025C File Offset: 0x0002E45C
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00030264 File Offset: 0x0002E464
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

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0003026D File Offset: 0x0002E46D
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00030275 File Offset: 0x0002E475
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

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0003027E File Offset: 0x0002E47E
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00030286 File Offset: 0x0002E486
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

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0003028F File Offset: 0x0002E48F
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x00030297 File Offset: 0x0002E497
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

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x000302A0 File Offset: 0x0002E4A0
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x000302A8 File Offset: 0x0002E4A8
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

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x000302B1 File Offset: 0x0002E4B1
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x000302B9 File Offset: 0x0002E4B9
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

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x000302C2 File Offset: 0x0002E4C2
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x000302CA File Offset: 0x0002E4CA
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

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x000302D3 File Offset: 0x0002E4D3
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x000302DB File Offset: 0x0002E4DB
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "base64Binary")]
		public string hash
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

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x000302E4 File Offset: 0x0002E4E4
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x000302EC File Offset: 0x0002E4EC
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "base64Binary")]
		public string salt
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

		// Token: 0x04000C04 RID: 3076
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect editField;

		// Token: 0x04000C05 RID: 3077
		private bool editFieldSpecified;

		// Token: 0x04000C06 RID: 3078
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff formattingField;

		// Token: 0x04000C07 RID: 3079
		private bool formattingFieldSpecified;

		// Token: 0x04000C08 RID: 3080
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff enforcementField;

		// Token: 0x04000C09 RID: 3081
		private bool enforcementFieldSpecified;

		// Token: 0x04000C0A RID: 3082
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_CryptProv cryptProviderTypeField;

		// Token: 0x04000C0B RID: 3083
		private bool cryptProviderTypeFieldSpecified;

		// Token: 0x04000C0C RID: 3084
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgClass cryptAlgorithmClassField;

		// Token: 0x04000C0D RID: 3085
		private bool cryptAlgorithmClassFieldSpecified;

		// Token: 0x04000C0E RID: 3086
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_AlgType cryptAlgorithmTypeField;

		// Token: 0x04000C0F RID: 3087
		private bool cryptAlgorithmTypeFieldSpecified;

		// Token: 0x04000C10 RID: 3088
		private string cryptAlgorithmSidField;

		// Token: 0x04000C11 RID: 3089
		private string cryptSpinCountField;

		// Token: 0x04000C12 RID: 3090
		private string cryptProviderField;

		// Token: 0x04000C13 RID: 3091
		private byte[] algIdExtField;

		// Token: 0x04000C14 RID: 3092
		private string algIdExtSourceField;

		// Token: 0x04000C15 RID: 3093
		private byte[] cryptProviderTypeExtField;

		// Token: 0x04000C16 RID: 3094
		private string cryptProviderTypeExtSourceField;

		// Token: 0x04000C17 RID: 3095
		private string hashField;

		// Token: 0x04000C18 RID: 3096
		private string saltField;
	}
}
