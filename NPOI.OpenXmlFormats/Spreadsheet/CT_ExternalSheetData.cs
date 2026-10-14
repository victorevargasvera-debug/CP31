using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000604 RID: 1540
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ExternalSheetData
	{
		// Token: 0x0600437B RID: 17275 RVA: 0x000A0755 File Offset: 0x0009E955
		public CT_ExternalSheetData()
		{
			this.rowField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalRow>();
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x0600437C RID: 17276 RVA: 0x000A0768 File Offset: 0x0009E968
		// (set) Token: 0x0600437D RID: 17277 RVA: 0x000A0775 File Offset: 0x0009E975
		[global::System.Xml.Serialization.XmlElement("row")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalRow[] row
		{
			get
			{
				return this.rowField.ToArray();
			}
			set
			{
				this.rowField.Clear();
				this.rowField.AddRange(value);
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x0600437E RID: 17278 RVA: 0x000A078E File Offset: 0x0009E98E
		// (set) Token: 0x0600437F RID: 17279 RVA: 0x000A0796 File Offset: 0x0009E996
		[global::System.Xml.Serialization.XmlAttribute]
		public uint sheetId
		{
			get
			{
				return this.sheetIdField;
			}
			set
			{
				this.sheetIdField = value;
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x06004380 RID: 17280 RVA: 0x000A079F File Offset: 0x0009E99F
		// (set) Token: 0x06004381 RID: 17281 RVA: 0x000A07A7 File Offset: 0x0009E9A7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool refreshError
		{
			get
			{
				return this.refreshErrorField;
			}
			set
			{
				this.refreshErrorField = value;
			}
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x000A07B0 File Offset: 0x0009E9B0
		internal static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetData ct_ExternalSheetData = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetData();
			ct_ExternalSheetData.refreshErrorField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["refreshError"]);
			ct_ExternalSheetData.sheetIdField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["sheetId"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "row")
				{
					ct_ExternalSheetData.rowField.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalRow.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ExternalSheetData;
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x000A0864 File Offset: 0x0009EA64
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sheetId", this.sheetIdField, true);
			if (this.refreshError)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "refreshError", this.refreshErrorField);
			}
			sw.Write(">");
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalRow ct_ExternalRow in this.rowField)
			{
				ct_ExternalRow.Write(sw, "row");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002A89 RID: 10889
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalRow> rowField;

		// Token: 0x04002A8A RID: 10890
		private uint sheetIdField;

		// Token: 0x04002A8B RID: 10891
		private bool refreshErrorField;
	}
}
