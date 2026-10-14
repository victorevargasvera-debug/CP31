using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200060B RID: 1547
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ExternalSheetDataSet
	{
		// Token: 0x060043B4 RID: 17332 RVA: 0x000A122C File Offset: 0x0009F42C
		public CT_ExternalSheetDataSet()
		{
			this.sheetDataField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetData>();
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x060043B5 RID: 17333 RVA: 0x000A123F File Offset: 0x0009F43F
		// (set) Token: 0x060043B6 RID: 17334 RVA: 0x000A124C File Offset: 0x0009F44C
		[global::System.Xml.Serialization.XmlElement("sheetData")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetData[] sheetData
		{
			get
			{
				return this.sheetDataField.ToArray();
			}
			set
			{
				this.sheetDataField.Clear();
				this.sheetDataField.AddRange(value);
			}
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x000A1268 File Offset: 0x0009F468
		internal static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetDataSet Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetDataSet ct_ExternalSheetDataSet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetDataSet();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode node2 = (global::System.Xml.XmlNode)obj;
				ct_ExternalSheetDataSet.sheetDataField.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetData.Parse(node2, namespaceManager));
			}
			return ct_ExternalSheetDataSet;
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x000A12D4 File Offset: 0x0009F4D4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetData ct_ExternalSheetData in this.sheetDataField)
			{
				ct_ExternalSheetData.Write(sw, "sheetData");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002A9B RID: 10907
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetData> sheetDataField;
	}
}
