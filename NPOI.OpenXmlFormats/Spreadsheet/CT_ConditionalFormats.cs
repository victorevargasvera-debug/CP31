using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004D0 RID: 1232
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_ConditionalFormats
	{
		// Token: 0x06003378 RID: 13176 RVA: 0x00081158 File Offset: 0x0007F358
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormats Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormats ct_ConditionalFormats = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormats();
			if (node.Attributes["count"] != null)
			{
				ct_ConditionalFormats.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_ConditionalFormats.conditionalFormat = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormat>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "conditionalFormat")
				{
					ct_ConditionalFormats.conditionalFormat.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormat.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ConditionalFormats;
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00081214 File Offset: 0x0007F414
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.conditionalFormat != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormat ct_ConditionalFormat in this.conditionalFormat)
				{
					ct_ConditionalFormat.Write(sw, "conditionalFormat");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x000812B4 File Offset: 0x0007F4B4
		public CT_ConditionalFormats()
		{
			this.conditionalFormatField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormat>();
			this.countField = 0U;
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x0600337B RID: 13179 RVA: 0x000812CE File Offset: 0x0007F4CE
		// (set) Token: 0x0600337C RID: 13180 RVA: 0x000812D6 File Offset: 0x0007F4D6
		[global::System.Xml.Serialization.XmlElement("conditionalFormat", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormat> conditionalFormat
		{
			get
			{
				return this.conditionalFormatField;
			}
			set
			{
				this.conditionalFormatField = value;
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x0600337D RID: 13181 RVA: 0x000812DF File Offset: 0x0007F4DF
		// (set) Token: 0x0600337E RID: 13182 RVA: 0x000812E7 File Offset: 0x0007F4E7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
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

		// Token: 0x0400224F RID: 8783
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormat> conditionalFormatField;

		// Token: 0x04002250 RID: 8784
		private uint countField;
	}
}
