using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200050C RID: 1292
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Cols
	{
		// Token: 0x0600379E RID: 14238 RVA: 0x0008AB37 File Offset: 0x00088D37
		public void SetColArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> array)
		{
			this.colField = array;
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x0008AB40 File Offset: 0x00088D40
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col AddNewCol()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col();
			this.colField.Add(ct_Col);
			return ct_Col;
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x0008AB60 File Offset: 0x00088D60
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col InsertNewCol(int index)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col();
			this.colField.Insert(index, ct_Col);
			return ct_Col;
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x0008AB81 File Offset: 0x00088D81
		public void RemoveCol(int index)
		{
			this.colField.RemoveAt(index);
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x0008AB8F File Offset: 0x00088D8F
		public int sizeOfColArray()
		{
			return this.col.Count;
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x0008AB9C File Offset: 0x00088D9C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col GetColArray(int index)
		{
			return this.colField[index];
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x0008ABAA File Offset: 0x00088DAA
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> GetColList()
		{
			return this.colField;
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x060037A5 RID: 14245 RVA: 0x0008ABAA File Offset: 0x00088DAA
		// (set) Token: 0x060037A6 RID: 14246 RVA: 0x0008AB37 File Offset: 0x00088D37
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> col
		{
			get
			{
				return this.colField;
			}
			set
			{
				this.colField = value;
			}
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x0008ABB4 File Offset: 0x00088DB4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols ct_Cols = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols();
			ct_Cols.col = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "col")
				{
					ct_Cols.col.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Cols;
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x0008AC44 File Offset: 0x00088E44
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.col != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col in this.col)
				{
					ct_Col.Write(sw, "col");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x0008ACD0 File Offset: 0x00088ED0
		public void SetColArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col[] colArray)
		{
			this.colField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col>(colArray);
		}

		// Token: 0x04002426 RID: 9254
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> colField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col>();
	}
}
