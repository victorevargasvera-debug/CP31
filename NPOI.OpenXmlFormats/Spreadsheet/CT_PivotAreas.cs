using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004D2 RID: 1234
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PivotAreas
	{
		// Token: 0x0600338C RID: 13196 RVA: 0x00081580 File Offset: 0x0007F780
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreas Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreas ct_PivotAreas = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreas();
			if (node.Attributes["count"] != null)
			{
				ct_PivotAreas.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_PivotAreas.pivotArea = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pivotArea")
				{
					ct_PivotAreas.pivotArea.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PivotAreas;
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x0008163C File Offset: 0x0007F83C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.pivotArea != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea ct_PivotArea in this.pivotArea)
				{
					ct_PivotArea.Write(sw, "pivotArea");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x000816DC File Offset: 0x0007F8DC
		public CT_PivotAreas()
		{
			this.pivotAreaField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea>();
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x0600338F RID: 13199 RVA: 0x000816EF File Offset: 0x0007F8EF
		// (set) Token: 0x06003390 RID: 13200 RVA: 0x000816F7 File Offset: 0x0007F8F7
		[global::System.Xml.Serialization.XmlElement("pivotArea", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea> pivotArea
		{
			get
			{
				return this.pivotAreaField;
			}
			set
			{
				this.pivotAreaField = value;
			}
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06003391 RID: 13201 RVA: 0x00081700 File Offset: 0x0007F900
		// (set) Token: 0x06003392 RID: 13202 RVA: 0x00081708 File Offset: 0x0007F908
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

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06003393 RID: 13203 RVA: 0x00081711 File Offset: 0x0007F911
		// (set) Token: 0x06003394 RID: 13204 RVA: 0x00081719 File Offset: 0x0007F919
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

		// Token: 0x04002256 RID: 8790
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea> pivotAreaField;

		// Token: 0x04002257 RID: 8791
		private uint countField;

		// Token: 0x04002258 RID: 8792
		private bool countFieldSpecified;
	}
}
