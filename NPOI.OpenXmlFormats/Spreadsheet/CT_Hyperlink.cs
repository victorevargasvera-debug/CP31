using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200050F RID: 1295
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Hyperlink
	{
		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x060037C1 RID: 14273 RVA: 0x0008B06A File Offset: 0x0008926A
		// (set) Token: 0x060037C2 RID: 14274 RVA: 0x0008B072 File Offset: 0x00089272
		[global::System.Xml.Serialization.XmlAttribute("ref")]
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x060037C3 RID: 14275 RVA: 0x0008B07B File Offset: 0x0008927B
		// (set) Token: 0x060037C4 RID: 14276 RVA: 0x0008B083 File Offset: 0x00089283
		[global::System.Xml.Serialization.XmlAttribute(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
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

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x060037C5 RID: 14277 RVA: 0x0008B08C File Offset: 0x0008928C
		// (set) Token: 0x060037C6 RID: 14278 RVA: 0x0008B094 File Offset: 0x00089294
		[global::System.Xml.Serialization.XmlAttribute]
		public string location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x060037C7 RID: 14279 RVA: 0x0008B09D File Offset: 0x0008929D
		// (set) Token: 0x060037C8 RID: 14280 RVA: 0x0008B0A5 File Offset: 0x000892A5
		[global::System.Xml.Serialization.XmlAttribute]
		public string tooltip
		{
			get
			{
				return this.tooltipField;
			}
			set
			{
				this.tooltipField = value;
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x060037C9 RID: 14281 RVA: 0x0008B0AE File Offset: 0x000892AE
		// (set) Token: 0x060037CA RID: 14282 RVA: 0x0008B0B6 File Offset: 0x000892B6
		[global::System.Xml.Serialization.XmlAttribute]
		public string display
		{
			get
			{
				return this.displayField;
			}
			set
			{
				this.displayField = value;
			}
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x0008B0C0 File Offset: 0x000892C0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink
			{
				@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"]),
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"]),
				location = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["location"]),
				tooltip = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["tooltip"]),
				display = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["display"])
			};
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x0008B164 File Offset: 0x00089364
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "location", this.location);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tooltip", this.tooltip);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "display", this.display);
			sw.Write("/>");
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x0008B1E4 File Offset: 0x000893E4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink Copy()
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink
			{
				@ref = this.@ref,
				id = this.id,
				location = this.location,
				tooltip = this.tooltip,
				display = this.display
			};
		}

		// Token: 0x0400242E RID: 9262
		private string refField;

		// Token: 0x0400242F RID: 9263
		private string idField;

		// Token: 0x04002430 RID: 9264
		private string locationField;

		// Token: 0x04002431 RID: 9265
		private string tooltipField;

		// Token: 0x04002432 RID: 9266
		private string displayField;
	}
}
