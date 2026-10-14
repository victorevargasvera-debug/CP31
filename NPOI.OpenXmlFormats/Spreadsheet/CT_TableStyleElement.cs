using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004EE RID: 1262
	public class CT_TableStyleElement
	{
		// Token: 0x06003535 RID: 13621 RVA: 0x00085289 File Offset: 0x00083489
		public CT_TableStyleElement()
		{
			this.sizeField = 1U;
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x00085298 File Offset: 0x00083498
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleElement Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleElement ct_TableStyleElement = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyleElement();
			if (node.Attributes["type"] != null)
			{
				ct_TableStyleElement.type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_TableStyleType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_TableStyleType), node.Attributes["type"].Value);
			}
			ct_TableStyleElement.size = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["size"]);
			ct_TableStyleElement.dxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["dxfId"]);
			return ct_TableStyleElement;
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x00085328 File Offset: 0x00083528
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "size", this.size, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dxfId", this.dxfId, false);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06003538 RID: 13624 RVA: 0x000853A5 File Offset: 0x000835A5
		// (set) Token: 0x06003539 RID: 13625 RVA: 0x000853AD File Offset: 0x000835AD
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_TableStyleType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x0600353A RID: 13626 RVA: 0x000853B6 File Offset: 0x000835B6
		// (set) Token: 0x0600353B RID: 13627 RVA: 0x000853BE File Offset: 0x000835BE
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x0600353C RID: 13628 RVA: 0x000853C7 File Offset: 0x000835C7
		// (set) Token: 0x0600353D RID: 13629 RVA: 0x000853CF File Offset: 0x000835CF
		[global::System.Xml.Serialization.XmlAttribute]
		public uint dxfId
		{
			get
			{
				return this.dxfIdField;
			}
			set
			{
				this.dxfIdField = value;
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x0600353E RID: 13630 RVA: 0x000853D8 File Offset: 0x000835D8
		// (set) Token: 0x0600353F RID: 13631 RVA: 0x000853E0 File Offset: 0x000835E0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dxfIdSpecified
		{
			get
			{
				return this.dxfIdFieldSpecified;
			}
			set
			{
				this.dxfIdFieldSpecified = value;
			}
		}

		// Token: 0x0400236C RID: 9068
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_TableStyleType typeField;

		// Token: 0x0400236D RID: 9069
		private uint sizeField;

		// Token: 0x0400236E RID: 9070
		private uint dxfIdField;

		// Token: 0x0400236F RID: 9071
		private bool dxfIdFieldSpecified;
	}
}
