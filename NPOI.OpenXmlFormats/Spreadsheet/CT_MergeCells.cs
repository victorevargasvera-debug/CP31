using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000516 RID: 1302
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_MergeCells
	{
		// Token: 0x060038C0 RID: 14528 RVA: 0x0008D33C File Offset: 0x0008B53C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells ct_MergeCells = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCells();
			ct_MergeCells.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_MergeCells.mergeCell = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "mergeCell")
				{
					ct_MergeCells.mergeCell.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_MergeCells;
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x0008D3E4 File Offset: 0x0008B5E4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.mergeCell != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell ct_MergeCell in this.mergeCell)
				{
					if (ct_MergeCell != null)
					{
						ct_MergeCell.Write(sw, "mergeCell");
					}
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x0008D488 File Offset: 0x0008B688
		public CT_MergeCells()
		{
			this.mergeCellField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell>();
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x0008D49B File Offset: 0x0008B69B
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell GetMergeCellArray(int index)
		{
			return this.mergeCellField[index];
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x0008D4A9 File Offset: 0x0008B6A9
		public void SetMergeCellArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell[] array)
		{
			this.mergeCell = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell>(array);
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x0008D4B7 File Offset: 0x0008B6B7
		public int sizeOfMergeCellArray()
		{
			return this.mergeCell.Count;
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x0008D4C4 File Offset: 0x0008B6C4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell AddNewMergeCell()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell ct_MergeCell = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell();
			this.mergeCell.Add(ct_MergeCell);
			return ct_MergeCell;
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x060038C7 RID: 14535 RVA: 0x0008D4E4 File Offset: 0x0008B6E4
		// (set) Token: 0x060038C8 RID: 14536 RVA: 0x0008D4EC File Offset: 0x0008B6EC
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell> mergeCell
		{
			get
			{
				return this.mergeCellField;
			}
			set
			{
				this.mergeCellField = value;
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x060038C9 RID: 14537 RVA: 0x0008D4F5 File Offset: 0x0008B6F5
		// (set) Token: 0x060038CA RID: 14538 RVA: 0x0008D4FD File Offset: 0x0008B6FD
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x0008D506 File Offset: 0x0008B706
		// (set) Token: 0x060038CC RID: 14540 RVA: 0x0008D50E File Offset: 0x0008B70E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x0400247A RID: 9338
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MergeCell> mergeCellField;

		// Token: 0x0400247B RID: 9339
		private uint countField;

		// Token: 0x0400247C RID: 9340
		private bool countFieldSpecified;
	}
}
