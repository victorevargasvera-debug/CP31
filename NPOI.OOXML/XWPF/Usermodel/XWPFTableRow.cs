using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000051 RID: 81
	public class XWPFTableRow
	{
		// Token: 0x060003B5 RID: 949 RVA: 0x0000EE5D File Offset: 0x0000D05D
		public XWPFTableRow(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row row, global::NPOI.XWPF.UserModel.XWPFTable table)
		{
			this.table = table;
			this.ctRow = row;
			this.GetTableCells();
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000EE7A File Offset: 0x0000D07A
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row GetCTRow()
		{
			return this.ctRow;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000EE84 File Offset: 0x0000D084
		public global::NPOI.XWPF.UserModel.XWPFTableCell CreateCell()
		{
			global::NPOI.XWPF.UserModel.XWPFTableCell xwpftableCell = new global::NPOI.XWPF.UserModel.XWPFTableCell(this.ctRow.AddNewTc(), this, this.table.Body);
			this.tableCells.Add(xwpftableCell);
			return xwpftableCell;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000EEBC File Offset: 0x0000D0BC
		public void MergeCells(int startIndex, int endIndex)
		{
			if (startIndex >= endIndex)
			{
				throw new global::System.ArgumentOutOfRangeException("Start index must be smaller than end index");
			}
			if (startIndex < 0 || endIndex >= this.tableCells.Count)
			{
				throw new global::System.ArgumentOutOfRangeException("Invalid start index and end index");
			}
			global::NPOI.XWPF.UserModel.XWPFTableCell cell = this.GetCell(startIndex);
			for (int i = endIndex; i > startIndex; i--)
			{
				this.RemoveCell(i);
			}
			if (!cell.GetCTTc().IsSetTcPr())
			{
				cell.GetCTTc().AddNewTcPr();
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr tcPr = cell.GetCTTc().tcPr;
			if (tcPr.gridSpan == null)
			{
				tcPr.AddNewGridspan();
			}
			tcPr.gridSpan.val = (endIndex - startIndex + 1).ToString();
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000EF5C File Offset: 0x0000D15C
		public global::NPOI.XWPF.UserModel.XWPFTableCell GetCell(int pos)
		{
			if (pos >= 0 && pos < this.ctRow.SizeOfTcArray())
			{
				return this.GetTableCells()[pos];
			}
			return null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000EF7E File Offset: 0x0000D17E
		public void RemoveCell(int pos)
		{
			if (pos >= 0 && pos < this.ctRow.SizeOfTcArray())
			{
				this.tableCells.RemoveAt(pos);
				this.ctRow.RemoveTc(pos);
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000EFAC File Offset: 0x0000D1AC
		public global::NPOI.XWPF.UserModel.XWPFTableCell AddNewTableCell()
		{
			global::NPOI.XWPF.UserModel.XWPFTableCell xwpftableCell = new global::NPOI.XWPF.UserModel.XWPFTableCell(this.ctRow.AddNewTc(), this, this.table.Body);
			this.tableCells.Add(xwpftableCell);
			return xwpftableCell;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000EFE4 File Offset: 0x0000D1E4
		public global::NPOI.XWPF.UserModel.XWPFTableRow CloneRow()
		{
			global::NPOI.XWPF.UserModel.XWPFTableRow xwpftableRow = new global::NPOI.XWPF.UserModel.XWPFTableRow(this.ctRow.Copy(), this.table);
			this.table.AddRow(xwpftableRow);
			return xwpftableRow;
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000F018 File Offset: 0x0000D218
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0000F044 File Offset: 0x0000D244
		public int Height
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr trPr = this.GetTrPr();
				if (trPr.SizeOfTrHeightArray() != 0)
				{
					return (int)trPr.GetTrHeightArray(0).val;
				}
				return 0;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr trPr = this.GetTrPr();
				((trPr.SizeOfTrHeightArray() == 0) ? trPr.AddNewTrHeight() : trPr.GetTrHeightArray(0)).val = (ulong)((long)value);
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000F076 File Offset: 0x0000D276
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr GetTrPr()
		{
			if (!this.ctRow.IsSetTrPr())
			{
				return this.ctRow.AddNewTrPr();
			}
			return this.ctRow.trPr;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000F09C File Offset: 0x0000D29C
		public global::NPOI.XWPF.UserModel.XWPFTable GetTable()
		{
			return this.table;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		public global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.ICell> GetTableICells()
		{
			global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.ICell> list = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.ICell>();
			foreach (object obj in this.ctRow.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc)
				{
					list.Add(new global::NPOI.XWPF.UserModel.XWPFTableCell((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc)obj, this, this.table.Body));
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell)
				{
					list.Add(new global::NPOI.XWPF.UserModel.XWPFSDTCell((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell)obj, this, this.table.Body));
				}
			}
			return list;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000F14C File Offset: 0x0000D34C
		public global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTableCell> GetTableCells()
		{
			if (this.tableCells == null)
			{
				global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTableCell> list = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTableCell>();
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc cell in this.ctRow.GetTcList())
				{
					list.Add(new global::NPOI.XWPF.UserModel.XWPFTableCell(cell, this, this.table.Body));
				}
				this.tableCells = list;
			}
			return this.tableCells;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000F1CC File Offset: 0x0000D3CC
		public global::NPOI.XWPF.UserModel.XWPFTableCell GetTableCell(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc cell)
		{
			for (int i = 0; i < this.tableCells.Count; i++)
			{
				if (this.tableCells[i].GetCTTc() == cell)
				{
					return this.tableCells[i];
				}
			}
			return null;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0000F214 File Offset: 0x0000D414
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x0000F246 File Offset: 0x0000D446
		public bool IsCantSplitRow
		{
			get
			{
				bool result = false;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr trPr = this.GetTrPr();
				if (trPr.SizeOfCantSplitArray() > 0)
				{
					result = trPr.GetCantSplitList()[0].val;
				}
				return result;
			}
			set
			{
				this.GetTrPr().AddNewCantSplit().val = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0000F25C File Offset: 0x0000D45C
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x0000F28E File Offset: 0x0000D48E
		public bool IsRepeatHeader
		{
			get
			{
				bool result = false;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr trPr = this.GetTrPr();
				if (trPr.SizeOfTblHeaderArray() > 0)
				{
					result = trPr.GetTblHeaderList()[0].val;
				}
				return result;
			}
			set
			{
				this.GetTrPr().AddNewTblHeader().val = value;
			}
		}

		// Token: 0x04000237 RID: 567
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row ctRow;

		// Token: 0x04000238 RID: 568
		private global::NPOI.XWPF.UserModel.XWPFTable table;

		// Token: 0x04000239 RID: 569
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTableCell> tableCells;
	}
}
