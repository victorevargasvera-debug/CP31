using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000513 RID: 1299
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SheetData
	{
		// Token: 0x06003811 RID: 14353 RVA: 0x0008BAF4 File Offset: 0x00089CF4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetData ct_SheetData = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetData();
			ct_SheetData.row = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "row")
				{
					ct_SheetData.row.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SheetData;
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x0008BB84 File Offset: 0x00089D84
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.row != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row ct_Row in this.row)
				{
					ct_Row.Write(sw, "row");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x0008BC10 File Offset: 0x00089E10
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row AddNewRow()
		{
			if (this.rowField == null)
			{
				this.rowField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row ct_Row = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row();
			this.rowField.Add(ct_Row);
			return ct_Row;
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x0008BC44 File Offset: 0x00089E44
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row InsertNewRow(int index)
		{
			if (this.rowField == null)
			{
				this.rowField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row ct_Row = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row();
			this.rowField.Insert(index, ct_Row);
			return ct_Row;
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x0008BC78 File Offset: 0x00089E78
		public void RemoveRows(global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row> toRemove)
		{
			if (this.rowField == null)
			{
				return;
			}
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row item in toRemove)
			{
				this.rowField.Remove(item);
			}
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x0008BCD0 File Offset: 0x00089ED0
		public void RemoveRow(int rowNum)
		{
			if (this.rowField != null)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row item = null;
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row ct_Row in this.rowField)
				{
					if ((ulong)ct_Row.r == (ulong)((long)rowNum))
					{
						item = ct_Row;
						break;
					}
				}
				this.rowField.Remove(item);
			}
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x0008BD44 File Offset: 0x00089F44
		public int SizeOfRowArray()
		{
			if (this.rowField != null)
			{
				return this.rowField.Count;
			}
			return 0;
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x0008BD5B File Offset: 0x00089F5B
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row GetRowArray(int index)
		{
			if (this.rowField != null)
			{
				return this.rowField[index];
			}
			return null;
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06003819 RID: 14361 RVA: 0x0008BD73 File Offset: 0x00089F73
		// (set) Token: 0x0600381A RID: 14362 RVA: 0x0008BD7B File Offset: 0x00089F7B
		[global::System.Xml.Serialization.XmlElement("row")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row> row
		{
			get
			{
				return this.rowField;
			}
			set
			{
				this.rowField = value;
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x0600381B RID: 14363 RVA: 0x0008BD84 File Offset: 0x00089F84
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rowSpecified
		{
			get
			{
				return this.rowField != null;
			}
		}

		// Token: 0x04002447 RID: 9287
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row> rowField;
	}
}
