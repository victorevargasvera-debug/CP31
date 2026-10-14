using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200051B RID: 1307
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("sheets", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Sheets
	{
		// Token: 0x0600394F RID: 14671 RVA: 0x0008E65F File Offset: 0x0008C85F
		public CT_Sheets()
		{
			this.sheetField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet>();
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x0008E674 File Offset: 0x0008C874
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheets Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheets ct_Sheets = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheets();
			ct_Sheets.sheet = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sheet")
				{
					ct_Sheets.sheet.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Sheets;
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x0008E704 File Offset: 0x0008C904
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.sheet != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet ct_Sheet in this.sheet)
				{
					ct_Sheet.Write(sw, "sheet");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x0008E790 File Offset: 0x0008C990
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet AddNewSheet()
		{
			if (this.sheetField == null)
			{
				this.sheetField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet ct_Sheet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet();
			this.sheetField.Add(ct_Sheet);
			return ct_Sheet;
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x0008E7C3 File Offset: 0x0008C9C3
		public void RemoveSheet(int index)
		{
			if (this.sheetField == null)
			{
				return;
			}
			this.sheetField.RemoveAt(index);
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x0008E7DC File Offset: 0x0008C9DC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet InsertNewSheet(int index)
		{
			if (this.sheetField == null)
			{
				this.sheetField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet ct_Sheet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet();
			this.sheetField.Insert(index, ct_Sheet);
			return ct_Sheet;
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x0008E810 File Offset: 0x0008CA10
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet GetSheetArray(int index)
		{
			if (this.sheetField == null)
			{
				return null;
			}
			return this.sheetField[index];
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06003956 RID: 14678 RVA: 0x0008E828 File Offset: 0x0008CA28
		// (set) Token: 0x06003957 RID: 14679 RVA: 0x0008E830 File Offset: 0x0008CA30
		[global::System.Xml.Serialization.XmlElement("sheet")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet> sheet
		{
			get
			{
				return this.sheetField;
			}
			set
			{
				this.sheetField = value;
			}
		}

		// Token: 0x040024BC RID: 9404
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sheet> sheetField;
	}
}
