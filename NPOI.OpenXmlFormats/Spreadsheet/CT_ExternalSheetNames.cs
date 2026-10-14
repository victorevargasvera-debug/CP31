using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000609 RID: 1545
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ExternalSheetNames
	{
		// Token: 0x060043AA RID: 17322 RVA: 0x000A0FEC File Offset: 0x0009F1EC
		public CT_ExternalSheetNames()
		{
			this.sheetNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetName>();
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x060043AB RID: 17323 RVA: 0x000A0FFF File Offset: 0x0009F1FF
		// (set) Token: 0x060043AC RID: 17324 RVA: 0x000A100C File Offset: 0x0009F20C
		[global::System.Xml.Serialization.XmlElement("sheetName")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetName[] sheetName
		{
			get
			{
				return this.sheetNameField.ToArray();
			}
			set
			{
				this.sheetNameField.Clear();
				this.sheetNameField.AddRange(value);
			}
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x000A1028 File Offset: 0x0009F228
		internal static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetNames Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetNames ct_ExternalSheetNames = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetNames();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode node2 = (global::System.Xml.XmlNode)obj;
				ct_ExternalSheetNames.sheetNameField.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetName.Parse(node2, namespaceManager));
			}
			return ct_ExternalSheetNames;
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x000A1094 File Offset: 0x0009F294
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}>", nodeName));
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetName ct_ExternalSheetName in this.sheetNameField)
			{
				ct_ExternalSheetName.Write(sw, "sheetName");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002A99 RID: 10905
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetName> sheetNameField;
	}
}
