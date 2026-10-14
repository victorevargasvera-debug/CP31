using System;
using System.Collections.Generic;
using System.Text;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200004F RID: 79
	public class XWPFTable : global::NPOI.XWPF.UserModel.IBodyElement, global::NPOI.XWPF.UserModel.ISDTContents
	{
		// Token: 0x0600035A RID: 858 RVA: 0x0000D558 File Offset: 0x0000B758
		static XWPFTable()
		{
			global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap.Add(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.NIL, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.nil);
			global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap.Add(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.NONE, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.none);
			global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap.Add(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.SINGLE, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.single);
			global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap.Add(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.THICK, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.thick);
			global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap.Add(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.DOUBLE, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.@double);
			global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap.Add(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.DOTTED, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.dotted);
			global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap.Add(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.DASHED, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.dashed);
			global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap.Add(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.DOT_DASH, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.dotDash);
			global::NPOI.XWPF.UserModel.XWPFTable.stBorderTypeMap = new global::System.Collections.Generic.Dictionary<global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border, global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType>();
			global::NPOI.XWPF.UserModel.XWPFTable.stBorderTypeMap.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.nil, global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.NIL);
			global::NPOI.XWPF.UserModel.XWPFTable.stBorderTypeMap.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.none, global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.NONE);
			global::NPOI.XWPF.UserModel.XWPFTable.stBorderTypeMap.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.single, global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.SINGLE);
			global::NPOI.XWPF.UserModel.XWPFTable.stBorderTypeMap.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.thick, global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.THICK);
			global::NPOI.XWPF.UserModel.XWPFTable.stBorderTypeMap.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.@double, global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.DOUBLE);
			global::NPOI.XWPF.UserModel.XWPFTable.stBorderTypeMap.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.dotted, global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.DOTTED);
			global::NPOI.XWPF.UserModel.XWPFTable.stBorderTypeMap.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.dashed, global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.DASHED);
			global::NPOI.XWPF.UserModel.XWPFTable.stBorderTypeMap.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.dotDash, global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.DOT_DASH);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000D63C File Offset: 0x0000B83C
		public XWPFTable(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl table, global::NPOI.XWPF.UserModel.IBody part, int row, int col) : this(table, part)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGrid ct_TblGrid = table.AddNewTblGrid();
			for (int i = 0; i < col; i++)
			{
				ct_TblGrid.AddNewGridCol().w = 300UL;
			}
			for (int j = 0; j < row; j++)
			{
				global::NPOI.XWPF.UserModel.XWPFTableRow xwpftableRow = (this.GetRow(j) == null) ? this.CreateRow() : this.GetRow(j);
				for (int k = 0; k < col; k++)
				{
					if (xwpftableRow.GetCell(k) == null)
					{
						xwpftableRow.CreateCell();
					}
				}
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000D6C0 File Offset: 0x0000B8C0
		public void SetColumnWidth(int columnIndex, ulong width)
		{
			if (this.ctTbl.tblGrid == null)
			{
				return;
			}
			if (columnIndex > this.ctTbl.tblGrid.gridCol.Count)
			{
				throw new global::System.ArgumentOutOfRangeException(string.Format("Column index {0} doesn't exist.", columnIndex));
			}
			this.ctTbl.tblGrid.gridCol[columnIndex].w = width;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000D728 File Offset: 0x0000B928
		public XWPFTable(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl table, global::NPOI.XWPF.UserModel.IBody part)
		{
			this.part = part;
			this.ctTbl = table;
			this.tableRows = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTableRow>();
			if (table.SizeOfTrArray() == 0)
			{
				this.CreateEmptyTable(table);
			}
			foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row ct_Row in table.GetTrList())
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				ct_Row.Table = table;
				global::NPOI.XWPF.UserModel.XWPFTableRow item = new global::NPOI.XWPF.UserModel.XWPFTableRow(ct_Row, this);
				this.tableRows.Add(item);
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc ct_Tc in ct_Row.GetTcList())
				{
					foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_P prgrph in ct_Tc.GetPList())
					{
						global::NPOI.XWPF.UserModel.XWPFParagraph xwpfparagraph = new global::NPOI.XWPF.UserModel.XWPFParagraph(prgrph, part);
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append('\t');
						}
						stringBuilder.Append(xwpfparagraph.Text);
					}
				}
				if (stringBuilder.Length > 0)
				{
					this.text.Append(stringBuilder);
					this.text.Append('\n');
				}
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000D88C File Offset: 0x0000BA8C
		private void CreateEmptyTable(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl table)
		{
			table.AddNewTr().AddNewTc().AddNewP();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr ct_TblPr = table.AddNewTblPr();
			if (!ct_TblPr.IsSetTblW())
			{
				ct_TblPr.AddNewTblW().w = "0";
			}
			ct_TblPr.tblW.type = global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblWidth.auto;
			ct_TblPr.AddNewTblLayout().type = global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblLayoutType.autofit;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders ct_TblBorders = ct_TblPr.AddNewTblBorders();
			ct_TblBorders.AddNewBottom().val = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.single;
			ct_TblBorders.AddNewInsideH().val = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.single;
			ct_TblBorders.AddNewInsideV().val = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.single;
			ct_TblBorders.AddNewLeft().val = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.single;
			ct_TblBorders.AddNewRight().val = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.single;
			ct_TblBorders.AddNewTop().val = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border.single;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000D92E File Offset: 0x0000BB2E
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl GetCTTbl()
		{
			return this.ctTbl;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0000D936 File Offset: 0x0000BB36
		public string Text
		{
			get
			{
				return this.text.ToString();
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000065E4 File Offset: 0x000047E4
		public void AddNewRowBetween(int start, int end)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000D944 File Offset: 0x0000BB44
		public void AddNewCol()
		{
			if (this.ctTbl.SizeOfTrArray() == 0)
			{
				this.CreateRow();
			}
			for (int i = 0; i < this.ctTbl.SizeOfTrArray(); i++)
			{
				new global::NPOI.XWPF.UserModel.XWPFTableRow(this.ctTbl.GetTrArray(i), this).CreateCell();
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000D994 File Offset: 0x0000BB94
		public global::NPOI.XWPF.UserModel.XWPFTableRow CreateRow()
		{
			int sizeCol = (this.ctTbl.SizeOfTrArray() > 0) ? this.ctTbl.GetTrArray(0).SizeOfTcArray() : 0;
			global::NPOI.XWPF.UserModel.XWPFTableRow xwpftableRow = new global::NPOI.XWPF.UserModel.XWPFTableRow(this.ctTbl.AddNewTr(), this);
			this.AddColumn(xwpftableRow, sizeCol);
			this.tableRows.Add(xwpftableRow);
			return xwpftableRow;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000D9EB File Offset: 0x0000BBEB
		public global::NPOI.XWPF.UserModel.XWPFTableRow GetRow(int pos)
		{
			if (pos >= 0 && pos < this.ctTbl.SizeOfTrArray())
			{
				return this.Rows[pos];
			}
			return null;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0000DA10 File Offset: 0x0000BC10
		// (set) Token: 0x06000366 RID: 870 RVA: 0x0000DA40 File Offset: 0x0000BC40
		public int Width
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (!trPr.IsSetTblW())
				{
					return -1;
				}
				return int.Parse(trPr.tblW.w);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth ct_TblWidth = trPr.IsSetTblW() ? trPr.tblW : trPr.AddNewTblW();
				ct_TblWidth.w = value.ToString();
				ct_TblWidth.type = global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblWidth.pct;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0000DA7D File Offset: 0x0000BC7D
		public int NumberOfRows
		{
			get
			{
				return this.ctTbl.SizeOfTrArray();
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000DA8A File Offset: 0x0000BC8A
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr GetTrPr()
		{
			if (this.ctTbl.tblPr == null)
			{
				return this.ctTbl.AddNewTblPr();
			}
			return this.ctTbl.tblPr;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000DAB0 File Offset: 0x0000BCB0
		private void AddColumn(global::NPOI.XWPF.UserModel.XWPFTableRow tabRow, int sizeCol)
		{
			if (sizeCol > 0)
			{
				for (int i = 0; i < sizeCol; i++)
				{
					tabRow.CreateCell();
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000DAD4 File Offset: 0x0000BCD4
		// (set) Token: 0x0600036B RID: 875 RVA: 0x0000DB04 File Offset: 0x0000BD04
		public string StyleID
		{
			get
			{
				string result = null;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr tblPr = this.ctTbl.tblPr;
				if (tblPr != null)
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_String tblStyle = tblPr.tblStyle;
					if (tblStyle != null)
					{
						result = tblStyle.val;
					}
				}
				return result;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_String ct_String = trPr.tblStyle;
				if (ct_String == null)
				{
					ct_String = trPr.AddNewTblStyle();
				}
				ct_String.val = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000DB30 File Offset: 0x0000BD30
		public global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType InsideHBorderType
		{
			get
			{
				global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType result = global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.NONE;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.IsSetTblBorders())
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders tblBorders = trPr.tblBorders;
					if (tblBorders.IsSetInsideH())
					{
						global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border insideH = tblBorders.insideH;
						result = global::NPOI.XWPF.UserModel.XWPFTable.stBorderTypeMap[insideH.val];
					}
				}
				return result;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000DB78 File Offset: 0x0000BD78
		public int InsideHBorderSize
		{
			get
			{
				int result = -1;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.IsSetTblBorders())
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders tblBorders = trPr.tblBorders;
					if (tblBorders.IsSetInsideH())
					{
						result = (int)tblBorders.insideH.sz.Value;
					}
				}
				return result;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		public int InsideHBorderSpace
		{
			get
			{
				int result = -1;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.IsSetTblBorders())
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders tblBorders = trPr.tblBorders;
					if (tblBorders.IsSetInsideH())
					{
						result = (int)tblBorders.insideH.space.Value;
					}
				}
				return result;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000DC00 File Offset: 0x0000BE00
		public string InsideHBorderColor
		{
			get
			{
				string result = null;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.IsSetTblBorders())
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders tblBorders = trPr.tblBorders;
					if (tblBorders.IsSetInsideH())
					{
						result = tblBorders.insideH.color;
					}
				}
				return result;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000DC3C File Offset: 0x0000BE3C
		public global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType InsideVBorderType
		{
			get
			{
				global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType result = global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType.NONE;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.IsSetTblBorders())
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders tblBorders = trPr.tblBorders;
					if (tblBorders.IsSetInsideV())
					{
						global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border insideV = tblBorders.insideV;
						result = global::NPOI.XWPF.UserModel.XWPFTable.stBorderTypeMap[insideV.val];
					}
				}
				return result;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0000DC84 File Offset: 0x0000BE84
		public int InsideVBorderSize
		{
			get
			{
				int result = -1;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.IsSetTblBorders())
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders tblBorders = trPr.tblBorders;
					if (tblBorders.IsSetInsideV())
					{
						result = (int)tblBorders.insideV.sz.Value;
					}
				}
				return result;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		public int InsideVBorderSpace
		{
			get
			{
				int result = -1;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.IsSetTblBorders())
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders tblBorders = trPr.tblBorders;
					if (tblBorders.IsSetInsideV())
					{
						result = (int)tblBorders.insideV.space.Value;
					}
				}
				return result;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0000DD0C File Offset: 0x0000BF0C
		public string InsideVBorderColor
		{
			get
			{
				string result = null;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.IsSetTblBorders())
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders tblBorders = trPr.tblBorders;
					if (tblBorders.IsSetInsideV())
					{
						result = tblBorders.insideV.color;
					}
				}
				return result;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0000DD48 File Offset: 0x0000BF48
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0000DD7C File Offset: 0x0000BF7C
		public int RowBandSize
		{
			get
			{
				int result = 0;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.IsSetTblStyleRowBandSize())
				{
					int.TryParse(trPr.tblStyleRowBandSize.val, out result);
				}
				return result;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				(trPr.IsSetTblStyleRowBandSize() ? trPr.tblStyleRowBandSize : trPr.AddNewTblStyleRowBandSize()).val = value.ToString();
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0000DDB4 File Offset: 0x0000BFB4
		// (set) Token: 0x06000377 RID: 887 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		public int ColBandSize
		{
			get
			{
				int result = 0;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.IsSetTblStyleColBandSize())
				{
					int.TryParse(trPr.tblStyleColBandSize.val, out result);
				}
				return result;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				(trPr.IsSetTblStyleColBandSize() ? trPr.tblStyleColBandSize : trPr.AddNewTblStyleColBandSize()).val = value.ToString();
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000DE20 File Offset: 0x0000C020
		public void SetTopBorder(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType type, int size, int space, string rgbColor)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders ct_TblBorders = trPr.IsSetTblBorders() ? trPr.tblBorders : trPr.AddNewTblBorders();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = (ct_TblBorders.top != null) ? ct_TblBorders.top : ct_TblBorders.AddNewTop();
			ct_Border.val = global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap[type];
			ct_Border.sz = new ulong?((ulong)((long)size));
			ct_Border.space = new ulong?((ulong)((long)space));
			ct_Border.color = rgbColor;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000DE94 File Offset: 0x0000C094
		public void SetBottomBorder(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType type, int size, int space, string rgbColor)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders ct_TblBorders = trPr.IsSetTblBorders() ? trPr.tblBorders : trPr.AddNewTblBorders();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = (ct_TblBorders.bottom != null) ? ct_TblBorders.bottom : ct_TblBorders.AddNewBottom();
			ct_Border.val = global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap[type];
			ct_Border.sz = new ulong?((ulong)((long)size));
			ct_Border.space = new ulong?((ulong)((long)space));
			ct_Border.color = rgbColor;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000DF08 File Offset: 0x0000C108
		public void SetLeftBorder(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType type, int size, int space, string rgbColor)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders ct_TblBorders = trPr.IsSetTblBorders() ? trPr.tblBorders : trPr.AddNewTblBorders();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = (ct_TblBorders.left != null) ? ct_TblBorders.left : ct_TblBorders.AddNewLeft();
			ct_Border.val = global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap[type];
			ct_Border.sz = new ulong?((ulong)((long)size));
			ct_Border.space = new ulong?((ulong)((long)space));
			ct_Border.color = rgbColor;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000DF7C File Offset: 0x0000C17C
		public void SetRightBorder(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType type, int size, int space, string rgbColor)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders ct_TblBorders = trPr.IsSetTblBorders() ? trPr.tblBorders : trPr.AddNewTblBorders();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = (ct_TblBorders.right != null) ? ct_TblBorders.right : ct_TblBorders.AddNewRight();
			ct_Border.val = global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap[type];
			ct_Border.sz = new ulong?((ulong)((long)size));
			ct_Border.space = new ulong?((ulong)((long)space));
			ct_Border.color = rgbColor;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000DFF0 File Offset: 0x0000C1F0
		public void SetInsideHBorder(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType type, int size, int space, string rgbColor)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders ct_TblBorders = trPr.IsSetTblBorders() ? trPr.tblBorders : trPr.AddNewTblBorders();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = ct_TblBorders.IsSetInsideH() ? ct_TblBorders.insideH : ct_TblBorders.AddNewInsideH();
			ct_Border.val = global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap[type];
			ct_Border.sz = new ulong?((ulong)((long)size));
			ct_Border.space = new ulong?((ulong)((long)space));
			ct_Border.color = rgbColor;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000E064 File Offset: 0x0000C264
		public void SetInsideVBorder(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType type, int size, int space, string rgbColor)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders ct_TblBorders = trPr.IsSetTblBorders() ? trPr.tblBorders : trPr.AddNewTblBorders();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border = ct_TblBorders.IsSetInsideV() ? ct_TblBorders.insideV : ct_TblBorders.AddNewInsideV();
			ct_Border.val = global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap[type];
			ct_Border.sz = new ulong?((ulong)((long)size));
			ct_Border.space = new ulong?((ulong)((long)space));
			ct_Border.color = rgbColor;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000E0D8 File Offset: 0x0000C2D8
		public int CellMarginTop
		{
			get
			{
				int result = 0;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar tblCellMar = this.GetTrPr().tblCellMar;
				if (tblCellMar != null)
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth top = tblCellMar.top;
					if (top != null)
					{
						int.TryParse(top.w, out result);
					}
				}
				return result;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000E110 File Offset: 0x0000C310
		public int CellMarginLeft
		{
			get
			{
				int result = 0;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar tblCellMar = this.GetTrPr().tblCellMar;
				if (tblCellMar != null)
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth left = tblCellMar.left;
					if (left != null)
					{
						int.TryParse(left.w, out result);
					}
				}
				return result;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000E148 File Offset: 0x0000C348
		public int CellMarginBottom
		{
			get
			{
				int result = 0;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar tblCellMar = this.GetTrPr().tblCellMar;
				if (tblCellMar != null)
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth bottom = tblCellMar.bottom;
					if (bottom != null)
					{
						int.TryParse(bottom.w, out result);
					}
				}
				return result;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000E180 File Offset: 0x0000C380
		public int CellMarginRight
		{
			get
			{
				int result = 0;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar tblCellMar = this.GetTrPr().tblCellMar;
				if (tblCellMar != null)
				{
					global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth right = tblCellMar.right;
					if (right != null)
					{
						int.TryParse(right.w, out result);
					}
				}
				return result;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000E1B8 File Offset: 0x0000C3B8
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0000E1E8 File Offset: 0x0000C3E8
		public string TableCaption
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.tblCaption != null)
				{
					return trPr.tblCaption.val;
				}
				return string.Empty;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.tblCaption == null)
				{
					trPr.tblCaption = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String
					{
						val = value
					};
					return;
				}
				trPr.tblCaption.val = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000E228 File Offset: 0x0000C428
		// (set) Token: 0x06000385 RID: 901 RVA: 0x0000E258 File Offset: 0x0000C458
		public string TableDescription
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.tblDescription != null)
				{
					return trPr.tblDescription.val;
				}
				return string.Empty;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
				if (trPr.tblDescription == null)
				{
					trPr.tblDescription = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String
					{
						val = value
					};
					return;
				}
				trPr.tblDescription.val = value;
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000E298 File Offset: 0x0000C498
		public void SetCellMargins(int top, int left, int bottom, int right)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr trPr = this.GetTrPr();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar ct_TblCellMar = trPr.IsSetTblCellMar() ? trPr.tblCellMar : trPr.AddNewTblCellMar();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth ct_TblWidth = ct_TblCellMar.IsSetLeft() ? ct_TblCellMar.left : ct_TblCellMar.AddNewLeft();
			ct_TblWidth.type = global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblWidth.dxa;
			ct_TblWidth.w = left.ToString();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth ct_TblWidth2 = ct_TblCellMar.IsSetTop() ? ct_TblCellMar.top : ct_TblCellMar.AddNewTop();
			ct_TblWidth2.type = global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblWidth.dxa;
			ct_TblWidth2.w = top.ToString();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth ct_TblWidth3 = ct_TblCellMar.IsSetBottom() ? ct_TblCellMar.bottom : ct_TblCellMar.AddNewBottom();
			ct_TblWidth3.type = global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblWidth.dxa;
			ct_TblWidth3.w = bottom.ToString();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth ct_TblWidth4 = ct_TblCellMar.IsSetRight() ? ct_TblCellMar.right : ct_TblCellMar.AddNewRight();
			ct_TblWidth4.type = global::NPOI.OpenXmlFormats.Wordprocessing.ST_TblWidth.dxa;
			ct_TblWidth4.w = right.ToString();
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000E367 File Offset: 0x0000C567
		public void AddRow(global::NPOI.XWPF.UserModel.XWPFTableRow row)
		{
			this.ctTbl.AddNewTr();
			this.ctTbl.SetTrArray(this.NumberOfRows - 1, row.GetCTRow());
			this.tableRows.Add(row);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000E39C File Offset: 0x0000C59C
		public bool AddRow(global::NPOI.XWPF.UserModel.XWPFTableRow row, int pos)
		{
			if (pos >= 0 && pos <= this.tableRows.Count)
			{
				this.ctTbl.InsertNewTr(pos);
				this.ctTbl.SetTrArray(pos, row.GetCTRow());
				this.tableRows.Insert(pos, row);
				return true;
			}
			return false;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000E3EC File Offset: 0x0000C5EC
		public global::NPOI.XWPF.UserModel.XWPFTableRow InsertNewTableRow(int pos)
		{
			if (pos >= 0 && pos <= this.tableRows.Count)
			{
				global::NPOI.XWPF.UserModel.XWPFTableRow xwpftableRow = new global::NPOI.XWPF.UserModel.XWPFTableRow(this.ctTbl.InsertNewTr(pos), this);
				this.tableRows.Insert(pos, xwpftableRow);
				return xwpftableRow;
			}
			return null;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000E42E File Offset: 0x0000C62E
		public bool RemoveRow(int pos)
		{
			if (pos >= 0 && pos < this.tableRows.Count)
			{
				if (this.ctTbl.SizeOfTrArray() > 0)
				{
					this.ctTbl.RemoveTr(pos);
				}
				this.tableRows.RemoveAt(pos);
				return true;
			}
			return false;
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0000E46B File Offset: 0x0000C66B
		public global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTableRow> Rows
		{
			get
			{
				return this.tableRows;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00007BAC File Offset: 0x00005DAC
		public global::NPOI.XWPF.UserModel.BodyElementType ElementType
		{
			get
			{
				return global::NPOI.XWPF.UserModel.BodyElementType.TABLE;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600038D RID: 909 RVA: 0x0000E473 File Offset: 0x0000C673
		public global::NPOI.XWPF.UserModel.IBody Body
		{
			get
			{
				return this.part;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000E47B File Offset: 0x0000C67B
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				if (this.part != null)
				{
					return this.part.Part;
				}
				return null;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000E492 File Offset: 0x0000C692
		public global::NPOI.XWPF.UserModel.BodyType PartType
		{
			get
			{
				return this.part.PartType;
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000E4A0 File Offset: 0x0000C6A0
		public global::NPOI.XWPF.UserModel.XWPFTableRow GetRow(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row row)
		{
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if (this.Rows[i].GetCTRow() == row)
				{
					return this.GetRow(i);
				}
			}
			return null;
		}

		// Token: 0x04000229 RID: 553
		protected global::System.Text.StringBuilder text = new global::System.Text.StringBuilder();

		// Token: 0x0400022A RID: 554
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl ctTbl;

		// Token: 0x0400022B RID: 555
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTableRow> tableRows;

		// Token: 0x0400022C RID: 556
		internal static global::System.Collections.Generic.Dictionary<global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border> xwpfBorderTypeMap = new global::System.Collections.Generic.Dictionary<global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType, global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border>();

		// Token: 0x0400022D RID: 557
		internal static global::System.Collections.Generic.Dictionary<global::NPOI.OpenXmlFormats.Wordprocessing.ST_Border, global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType> stBorderTypeMap;

		// Token: 0x0400022E RID: 558
		protected global::NPOI.XWPF.UserModel.IBody part;

		// Token: 0x02000120 RID: 288
		public enum XWPFBorderType
		{
			// Token: 0x040004F5 RID: 1269
			NIL,
			// Token: 0x040004F6 RID: 1270
			NONE,
			// Token: 0x040004F7 RID: 1271
			SINGLE,
			// Token: 0x040004F8 RID: 1272
			THICK,
			// Token: 0x040004F9 RID: 1273
			DOUBLE,
			// Token: 0x040004FA RID: 1274
			DOTTED,
			// Token: 0x040004FB RID: 1275
			DASHED,
			// Token: 0x040004FC RID: 1276
			DOT_DASH
		}
	}
}
