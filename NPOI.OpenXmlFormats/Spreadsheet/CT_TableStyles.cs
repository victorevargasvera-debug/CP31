using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004EC RID: 1260
	public class CT_TableStyles
	{
		// Token: 0x06003528 RID: 13608 RVA: 0x00085080 File Offset: 0x00083280
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyles Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyles ct_TableStyles = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyles();
			ct_TableStyles.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_TableStyles.defaultTableStyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["defaultTableStyle"]);
			ct_TableStyles.defaultPivotStyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["defaultPivotStyle"]);
			ct_TableStyles.tableStyle = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyle>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tableStyle")
				{
					ct_TableStyles.tableStyle.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyle.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_TableStyles;
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x00085160 File Offset: 0x00083360
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "defaultTableStyle", this.defaultTableStyle);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "defaultPivotStyle", this.defaultPivotStyle);
			if (this.tableStyle.Count > 0)
			{
				sw.Write(">");
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyle ct_TableStyle in this.tableStyle)
				{
					ct_TableStyle.Write(sw, "tableStyle");
				}
				sw.Write(string.Format("</{0}>", nodeName));
				return;
			}
			sw.Write("/>");
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x0600352B RID: 13611 RVA: 0x00085234 File Offset: 0x00083434
		// (set) Token: 0x0600352C RID: 13612 RVA: 0x0008523C File Offset: 0x0008343C
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyle> tableStyle
		{
			get
			{
				return this.tableStyleField;
			}
			set
			{
				this.tableStyleField = value;
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x0600352D RID: 13613 RVA: 0x00085245 File Offset: 0x00083445
		// (set) Token: 0x0600352E RID: 13614 RVA: 0x0008524D File Offset: 0x0008344D
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x00085256 File Offset: 0x00083456
		// (set) Token: 0x06003530 RID: 13616 RVA: 0x0008525E File Offset: 0x0008345E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06003531 RID: 13617 RVA: 0x00085267 File Offset: 0x00083467
		// (set) Token: 0x06003532 RID: 13618 RVA: 0x0008526F File Offset: 0x0008346F
		public string defaultTableStyle
		{
			get
			{
				return this.defaultTableStyleField;
			}
			set
			{
				this.defaultTableStyleField = value;
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06003533 RID: 13619 RVA: 0x00085278 File Offset: 0x00083478
		// (set) Token: 0x06003534 RID: 13620 RVA: 0x00085280 File Offset: 0x00083480
		public string defaultPivotStyle
		{
			get
			{
				return this.defaultPivotStyleField;
			}
			set
			{
				this.defaultPivotStyleField = value;
			}
		}

		// Token: 0x0400234A RID: 9034
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableStyle> tableStyleField;

		// Token: 0x0400234B RID: 9035
		private uint countField;

		// Token: 0x0400234C RID: 9036
		private bool countFieldSpecified;

		// Token: 0x0400234D RID: 9037
		private string defaultTableStyleField;

		// Token: 0x0400234E RID: 9038
		private string defaultPivotStyleField;
	}
}
