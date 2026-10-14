using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000605 RID: 1541
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ExternalRow
	{
		// Token: 0x06004384 RID: 17284 RVA: 0x000A0914 File Offset: 0x0009EB14
		public CT_ExternalRow()
		{
			this.cellField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalCell>();
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x000A0927 File Offset: 0x0009EB27
		// (set) Token: 0x06004386 RID: 17286 RVA: 0x000A0934 File Offset: 0x0009EB34
		[global::System.Xml.Serialization.XmlElement("cell")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalCell[] cell
		{
			get
			{
				return this.cellField.ToArray();
			}
			set
			{
				this.cellField.Clear();
				this.cellField.AddRange(value);
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x06004387 RID: 17287 RVA: 0x000A094D File Offset: 0x0009EB4D
		// (set) Token: 0x06004388 RID: 17288 RVA: 0x000A0955 File Offset: 0x0009EB55
		[global::System.Xml.Serialization.XmlAttribute]
		public uint r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x000A0960 File Offset: 0x0009EB60
		internal static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalRow Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalRow ct_ExternalRow = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalRow();
			ct_ExternalRow.r = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["r"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cell")
				{
					ct_ExternalRow.cellField.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalCell.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ExternalRow;
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x000A09F8 File Offset: 0x0009EBF8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", this.rField, false);
			sw.Write(">");
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalCell ct_ExternalCell in this.cellField)
			{
				ct_ExternalCell.Write(sw, "cell");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002A8C RID: 10892
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalCell> cellField;

		// Token: 0x04002A8D RID: 10893
		private uint rField;
	}
}
