using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000601 RID: 1537
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ExternalBook
	{
		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x000A03E1 File Offset: 0x0009E5E1
		// (set) Token: 0x06004360 RID: 17248 RVA: 0x000A03E9 File Offset: 0x0009E5E9
		[global::System.Xml.Serialization.XmlArrayItem("sheetName", IsNullable = false)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetNames sheetNames
		{
			get
			{
				return this.sheetNamesField;
			}
			set
			{
				this.sheetNamesField = value;
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x06004361 RID: 17249 RVA: 0x000A03F2 File Offset: 0x0009E5F2
		// (set) Token: 0x06004362 RID: 17250 RVA: 0x000A03FA File Offset: 0x0009E5FA
		[global::System.Xml.Serialization.XmlArrayItem("definedName", IsNullable = false)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedNames definedNames
		{
			get
			{
				return this.definedNamesField;
			}
			set
			{
				this.definedNamesField = value;
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x000A0403 File Offset: 0x0009E603
		// (set) Token: 0x06004364 RID: 17252 RVA: 0x000A040B File Offset: 0x0009E60B
		[global::System.Xml.Serialization.XmlArrayItem("sheetData", IsNullable = false)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetDataSet sheetDataSet
		{
			get
			{
				return this.sheetDataSetField;
			}
			set
			{
				this.sheetDataSetField = value;
			}
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x06004365 RID: 17253 RVA: 0x000A0414 File Offset: 0x0009E614
		// (set) Token: 0x06004366 RID: 17254 RVA: 0x000A041C File Offset: 0x0009E61C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x000A0428 File Offset: 0x0009E628
		internal static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalBook Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalBook ct_ExternalBook = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalBook();
			ct_ExternalBook.idField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", namespaceManager.LookupNamespace("r")]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sheetNames")
				{
					ct_ExternalBook.sheetNamesField = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetNames.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "definedNames")
				{
					ct_ExternalBook.definedNamesField = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedNames.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sheetDataSet")
				{
					ct_ExternalBook.sheetDataSetField = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetDataSet.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ExternalBook;
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x000A0510 File Offset: 0x0009E710
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.idField);
			sw.Write(">");
			if (this.sheetNamesField != null)
			{
				this.sheetNamesField.Write(sw, "sheetNames");
			}
			if (this.definedNamesField != null)
			{
				this.definedNamesField.Write(sw, "definedNames");
			}
			if (this.sheetDataSetField != null)
			{
				this.sheetDataSetField.Write(sw, "sheetDataSet");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002A80 RID: 10880
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetNames sheetNamesField;

		// Token: 0x04002A81 RID: 10881
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedNames definedNamesField;

		// Token: 0x04002A82 RID: 10882
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetDataSet sheetDataSetField;

		// Token: 0x04002A83 RID: 10883
		private string idField;
	}
}
