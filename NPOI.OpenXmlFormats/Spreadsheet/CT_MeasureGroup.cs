using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004B6 RID: 1206
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_MeasureGroup
	{
		// Token: 0x06003157 RID: 12631 RVA: 0x0007BBD8 File Offset: 0x00079DD8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroup Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroup
			{
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]),
				caption = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["caption"])
			};
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x0007BC28 File Offset: 0x00079E28
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "caption", this.caption);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06003159 RID: 12633 RVA: 0x0007BC84 File Offset: 0x00079E84
		// (set) Token: 0x0600315A RID: 12634 RVA: 0x0007BC8C File Offset: 0x00079E8C
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x0600315B RID: 12635 RVA: 0x0007BC95 File Offset: 0x00079E95
		// (set) Token: 0x0600315C RID: 12636 RVA: 0x0007BC9D File Offset: 0x00079E9D
		[global::System.Xml.Serialization.XmlAttribute]
		public string caption
		{
			get
			{
				return this.captionField;
			}
			set
			{
				this.captionField = value;
			}
		}

		// Token: 0x04002149 RID: 8521
		private string nameField;

		// Token: 0x0400214A RID: 8522
		private string captionField;
	}
}
