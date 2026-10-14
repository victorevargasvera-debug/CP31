using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005B8 RID: 1464
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_WebPublishItem
	{
		// Token: 0x0600406E RID: 16494 RVA: 0x0009C4B3 File Offset: 0x0009A6B3
		public CT_WebPublishItem()
		{
			this.autoRepublishField = false;
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x0009C4C4 File Offset: 0x0009A6C4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItem Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItem ct_WebPublishItem = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItem();
			if (node.Attributes["id"] != null)
			{
				ct_WebPublishItem.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["id"]);
			}
			ct_WebPublishItem.divId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["divId"]);
			if (node.Attributes["sourceType"] != null)
			{
				ct_WebPublishItem.sourceType = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_WebSourceType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_WebSourceType), node.Attributes["sourceType"].Value);
			}
			ct_WebPublishItem.sourceRef = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["sourceRef"]);
			ct_WebPublishItem.sourceObject = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["sourceObject"]);
			ct_WebPublishItem.destinationFile = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["destinationFile"]);
			ct_WebPublishItem.title = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["title"]);
			if (node.Attributes["autoRepublish"] != null)
			{
				ct_WebPublishItem.autoRepublish = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoRepublish"]);
			}
			return ct_WebPublishItem;
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x0009C600 File Offset: 0x0009A800
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "divId", this.divId);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sourceType", this.sourceType.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sourceRef", this.sourceRef);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sourceObject", this.sourceObject);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "destinationFile", this.destinationFile);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "title", this.title);
			if (this.autoRepublish)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoRepublish", this.autoRepublish);
			}
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06004071 RID: 16497 RVA: 0x0009C6D9 File Offset: 0x0009A8D9
		// (set) Token: 0x06004072 RID: 16498 RVA: 0x0009C6E1 File Offset: 0x0009A8E1
		public uint id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06004073 RID: 16499 RVA: 0x0009C6EA File Offset: 0x0009A8EA
		// (set) Token: 0x06004074 RID: 16500 RVA: 0x0009C6F2 File Offset: 0x0009A8F2
		public string divId
		{
			get
			{
				return this.divIdField;
			}
			set
			{
				this.divIdField = value;
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06004075 RID: 16501 RVA: 0x0009C6FB File Offset: 0x0009A8FB
		// (set) Token: 0x06004076 RID: 16502 RVA: 0x0009C703 File Offset: 0x0009A903
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_WebSourceType sourceType
		{
			get
			{
				return this.sourceTypeField;
			}
			set
			{
				this.sourceTypeField = value;
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06004077 RID: 16503 RVA: 0x0009C70C File Offset: 0x0009A90C
		// (set) Token: 0x06004078 RID: 16504 RVA: 0x0009C714 File Offset: 0x0009A914
		public string sourceRef
		{
			get
			{
				return this.sourceRefField;
			}
			set
			{
				this.sourceRefField = value;
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06004079 RID: 16505 RVA: 0x0009C71D File Offset: 0x0009A91D
		// (set) Token: 0x0600407A RID: 16506 RVA: 0x0009C725 File Offset: 0x0009A925
		public string sourceObject
		{
			get
			{
				return this.sourceObjectField;
			}
			set
			{
				this.sourceObjectField = value;
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x0600407B RID: 16507 RVA: 0x0009C72E File Offset: 0x0009A92E
		// (set) Token: 0x0600407C RID: 16508 RVA: 0x0009C736 File Offset: 0x0009A936
		public string destinationFile
		{
			get
			{
				return this.destinationFileField;
			}
			set
			{
				this.destinationFileField = value;
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x0600407D RID: 16509 RVA: 0x0009C73F File Offset: 0x0009A93F
		// (set) Token: 0x0600407E RID: 16510 RVA: 0x0009C747 File Offset: 0x0009A947
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x0600407F RID: 16511 RVA: 0x0009C750 File Offset: 0x0009A950
		// (set) Token: 0x06004080 RID: 16512 RVA: 0x0009C758 File Offset: 0x0009A958
		[global::System.ComponentModel.DefaultValue(false)]
		public bool autoRepublish
		{
			get
			{
				return this.autoRepublishField;
			}
			set
			{
				this.autoRepublishField = value;
			}
		}

		// Token: 0x040028D9 RID: 10457
		private uint idField;

		// Token: 0x040028DA RID: 10458
		private string divIdField;

		// Token: 0x040028DB RID: 10459
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_WebSourceType sourceTypeField;

		// Token: 0x040028DC RID: 10460
		private string sourceRefField;

		// Token: 0x040028DD RID: 10461
		private string sourceObjectField;

		// Token: 0x040028DE RID: 10462
		private string destinationFileField;

		// Token: 0x040028DF RID: 10463
		private string titleField;

		// Token: 0x040028E0 RID: 10464
		private bool autoRepublishField;
	}
}
