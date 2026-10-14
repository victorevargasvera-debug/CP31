using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200049C RID: 1180
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_FieldUsage
	{
		// Token: 0x06003010 RID: 12304 RVA: 0x00078820 File Offset: 0x00076A20
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldUsage Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldUsage ct_FieldUsage = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FieldUsage();
			if (node.Attributes["x"] != null)
			{
				ct_FieldUsage.x = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["x"]);
			}
			return ct_FieldUsage;
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x00078866 File Offset: 0x00076A66
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "x", this.x);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x000788A6 File Offset: 0x00076AA6
		// (set) Token: 0x06003013 RID: 12307 RVA: 0x000788AE File Offset: 0x00076AAE
		[global::System.Xml.Serialization.XmlAttribute]
		public int x
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xField = value;
			}
		}

		// Token: 0x040020C3 RID: 8387
		private int xField;
	}
}
