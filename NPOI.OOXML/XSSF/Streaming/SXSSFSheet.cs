using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;
using NPOI.XSSF.UserModel;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000CE RID: 206
	public class SXSSFSheet : global::NPOI.SS.UserModel.ISheet
	{
		// Token: 0x06000CD4 RID: 3284 RVA: 0x0002E7B4 File Offset: 0x0002C9B4
		public SXSSFSheet(global::NPOI.XSSF.Streaming.SXSSFWorkbook workbook, global::NPOI.XSSF.UserModel.XSSFSheet xSheet)
		{
			this._workbook = workbook;
			this._sh = xSheet;
			this._writer = workbook.CreateSheetDataWriter();
			this.SetRandomAccessWindowSize(this._workbook.RandomAccessWindowSize);
			this._autoSizeColumnTracker = new global::System.Lazy<global::NPOI.XSSF.Streaming.AutoSizeColumnTracker>(() => new global::NPOI.XSSF.Streaming.AutoSizeColumnTracker(this));
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0002E831 File Offset: 0x0002CA31
		public void SetRandomAccessWindowSize(int value)
		{
			if (value == 0 || value < -1)
			{
				throw new global::System.ArgumentException("RandomAccessWindowSize must be either -1 or a positive integer");
			}
			this._randomAccessWindowSize = value;
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0002E84C File Offset: 0x0002CA4C
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x0002E859 File Offset: 0x0002CA59
		public bool Autobreaks
		{
			get
			{
				return this._sh.Autobreaks;
			}
			set
			{
				this._sh.Autobreaks = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0002E867 File Offset: 0x0002CA67
		public int[] ColumnBreaks
		{
			get
			{
				return this._sh.ColumnBreaks;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x0002E874 File Offset: 0x0002CA74
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x0002E881 File Offset: 0x0002CA81
		public int DefaultColumnWidth
		{
			get
			{
				return this._sh.DefaultColumnWidth;
			}
			set
			{
				this._sh.DefaultColumnWidth = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0002E88F File Offset: 0x0002CA8F
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x0002E89C File Offset: 0x0002CA9C
		public short DefaultRowHeight
		{
			get
			{
				return this._sh.DefaultRowHeight;
			}
			set
			{
				this._sh.DefaultRowHeight = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0002E8AA File Offset: 0x0002CAAA
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x0002E8B7 File Offset: 0x0002CAB7
		public float DefaultRowHeightInPoints
		{
			get
			{
				return this._sh.DefaultRowHeightInPoints;
			}
			set
			{
				this._sh.DefaultRowHeightInPoints = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0002E8C5 File Offset: 0x0002CAC5
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x0002E8D2 File Offset: 0x0002CAD2
		public bool DisplayFormulas
		{
			get
			{
				return this._sh.DisplayFormulas;
			}
			set
			{
				this._sh.DisplayFormulas = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0002E8E0 File Offset: 0x0002CAE0
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x0002E8ED File Offset: 0x0002CAED
		public bool DisplayGridlines
		{
			get
			{
				return this._sh.DisplayGridlines;
			}
			set
			{
				this._sh.DisplayGridlines = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0002E8FB File Offset: 0x0002CAFB
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x0002E908 File Offset: 0x0002CB08
		public bool DisplayGuts
		{
			get
			{
				return this._sh.DisplayGuts;
			}
			set
			{
				this._sh.DisplayGuts = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0002E916 File Offset: 0x0002CB16
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x0002E923 File Offset: 0x0002CB23
		public bool DisplayRowColHeadings
		{
			get
			{
				return this._sh.DisplayRowColHeadings;
			}
			set
			{
				this._sh.DisplayRowColHeadings = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0002E931 File Offset: 0x0002CB31
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x0002E93E File Offset: 0x0002CB3E
		public bool DisplayZeros
		{
			get
			{
				return this._sh.DisplayZeros;
			}
			set
			{
				this._sh.DisplayZeros = value;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0002E94C File Offset: 0x0002CB4C
		public global::NPOI.SS.UserModel.IDrawing DrawingPatriarch
		{
			get
			{
				return this._sh.DrawingPatriarch;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0002E959 File Offset: 0x0002CB59
		public int FirstRowNum
		{
			get
			{
				if (this._writer.NumberOfFlushedRows > 0)
				{
					return this._writer.LowestIndexOfFlushedRows;
				}
				if (this._rows.Count != 0)
				{
					return this._FirstRowNum;
				}
				return 0;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x0002E98A File Offset: 0x0002CB8A
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x0002E997 File Offset: 0x0002CB97
		public bool FitToPage
		{
			get
			{
				return this._sh.FitToPage;
			}
			set
			{
				this._sh.FitToPage = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0002E9A5 File Offset: 0x0002CBA5
		public global::NPOI.SS.UserModel.IFooter Footer
		{
			get
			{
				return this._sh.Footer;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0002E9B2 File Offset: 0x0002CBB2
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x0002E9BF File Offset: 0x0002CBBF
		public bool ForceFormulaRecalculation
		{
			get
			{
				return this._sh.ForceFormulaRecalculation;
			}
			set
			{
				this._sh.ForceFormulaRecalculation = value;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0002E9CD File Offset: 0x0002CBCD
		public global::NPOI.SS.UserModel.IHeader Header
		{
			get
			{
				return this._sh.Header;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x0002E9DA File Offset: 0x0002CBDA
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x0002E9E7 File Offset: 0x0002CBE7
		public bool HorizontallyCenter
		{
			get
			{
				return this._sh.HorizontallyCenter;
			}
			set
			{
				this._sh.HorizontallyCenter = value;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x000065E4 File Offset: 0x000047E4
		public bool IsActive
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0002E9F5 File Offset: 0x0002CBF5
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x0002EA02 File Offset: 0x0002CC02
		public bool IsPrintGridlines
		{
			get
			{
				return this._sh.IsPrintGridlines;
			}
			set
			{
				this._sh.IsPrintGridlines = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0002EA10 File Offset: 0x0002CC10
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x0002EA1D File Offset: 0x0002CC1D
		public bool IsPrintRowAndColumnHeadings
		{
			get
			{
				return this._sh.IsPrintRowAndColumnHeadings;
			}
			set
			{
				this._sh.IsPrintRowAndColumnHeadings = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0002EA2B File Offset: 0x0002CC2B
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x0002EA38 File Offset: 0x0002CC38
		public bool IsRightToLeft
		{
			get
			{
				return this._sh.IsRightToLeft;
			}
			set
			{
				this._sh.IsRightToLeft = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0002EA46 File Offset: 0x0002CC46
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x0002EA53 File Offset: 0x0002CC53
		public bool IsSelected
		{
			get
			{
				return this._sh.IsSelected;
			}
			set
			{
				this._sh.IsSelected = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0002EA61 File Offset: 0x0002CC61
		public int LastRowNum
		{
			get
			{
				if (this._rows.Count != 0)
				{
					return this._LastRowNum;
				}
				if (this._writer.NumberOfFlushedRows <= 0)
				{
					return 0;
				}
				return this.LastFlushedRowNumber;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0002EA8D File Offset: 0x0002CC8D
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x000065E4 File Offset: 0x000047E4
		public short LeftCol
		{
			get
			{
				return this._sh.LeftCol;
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x0002EA9A File Offset: 0x0002CC9A
		public int NumMergedRegions
		{
			get
			{
				return this._sh.NumMergedRegions;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0002EAA7 File Offset: 0x0002CCA7
		public global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> MergedRegions
		{
			get
			{
				return this._sh.MergedRegions;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0002EAB4 File Offset: 0x0002CCB4
		public global::NPOI.SS.Util.PaneInformation PaneInformation
		{
			get
			{
				return this._sh.PaneInformation;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x0002EAC1 File Offset: 0x0002CCC1
		public int PhysicalNumberOfRows
		{
			get
			{
				return this._rows.Count + this._writer.NumberOfFlushedRows;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0002EADA File Offset: 0x0002CCDA
		public global::NPOI.SS.UserModel.IPrintSetup PrintSetup
		{
			get
			{
				return this._sh.PrintSetup;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x0002EAE7 File Offset: 0x0002CCE7
		public bool Protect
		{
			get
			{
				return this._sh.Protect;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0002EAF4 File Offset: 0x0002CCF4
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x0002EB01 File Offset: 0x0002CD01
		public global::NPOI.SS.Util.CellRangeAddress RepeatingColumns
		{
			get
			{
				return this._sh.RepeatingColumns;
			}
			set
			{
				this._sh.RepeatingColumns = value;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0002EB0F File Offset: 0x0002CD0F
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x0002EB1C File Offset: 0x0002CD1C
		public global::NPOI.SS.Util.CellRangeAddress RepeatingRows
		{
			get
			{
				return this._sh.RepeatingRows;
			}
			set
			{
				this._sh.RepeatingRows = value;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0002EB2A File Offset: 0x0002CD2A
		public int[] RowBreaks
		{
			get
			{
				return this._sh.RowBreaks;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x0002EB37 File Offset: 0x0002CD37
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x0002EB44 File Offset: 0x0002CD44
		public bool RowSumsBelow
		{
			get
			{
				return this._sh.RowSumsBelow;
			}
			set
			{
				this._sh.RowSumsBelow = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0002EB52 File Offset: 0x0002CD52
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x0002EB5F File Offset: 0x0002CD5F
		public bool RowSumsRight
		{
			get
			{
				return this._sh.RowSumsRight;
			}
			set
			{
				this._sh.RowSumsRight = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0002EB6D File Offset: 0x0002CD6D
		public bool ScenarioProtect
		{
			get
			{
				return this._sh.ScenarioProtect;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0002EB7A File Offset: 0x0002CD7A
		public global::NPOI.SS.UserModel.ISheetConditionalFormatting SheetConditionalFormatting
		{
			get
			{
				return this._sh.SheetConditionalFormatting;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0002EB87 File Offset: 0x0002CD87
		public string SheetName
		{
			get
			{
				return this._sh.SheetName;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x000065E4 File Offset: 0x000047E4
		public short TabColorIndex
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0002EB94 File Offset: 0x0002CD94
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x0002EBA1 File Offset: 0x0002CDA1
		public short TopRow
		{
			get
			{
				return this._sh.TopRow;
			}
			set
			{
				this._sh.TopRow = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0002EBAF File Offset: 0x0002CDAF
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x0002EBBC File Offset: 0x0002CDBC
		public bool VerticallyCenter
		{
			get
			{
				return this._sh.VerticallyCenter;
			}
			set
			{
				this._sh.VerticallyCenter = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0002EBCA File Offset: 0x0002CDCA
		public global::NPOI.SS.UserModel.IWorkbook Workbook
		{
			get
			{
				return this._workbook;
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0002EBD2 File Offset: 0x0002CDD2
		public int AddMergedRegion(global::NPOI.SS.Util.CellRangeAddress region)
		{
			return this._sh.AddMergedRegion(region);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		public int AddMergedRegionUnsafe(global::NPOI.SS.Util.CellRangeAddress region)
		{
			return this._sh.AddMergedRegionUnsafe(region);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0002EBEE File Offset: 0x0002CDEE
		public void ValidateMergedRegions()
		{
			this._sh.ValidateMergedRegions();
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0002EBFB File Offset: 0x0002CDFB
		public void AddValidationData(global::NPOI.SS.UserModel.IDataValidation dataValidation)
		{
			this._sh.AddValidationData(dataValidation);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0002EC09 File Offset: 0x0002CE09
		public void AutoSizeColumn(int column)
		{
			this.AutoSizeColumn(column, false);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0002EC14 File Offset: 0x0002CE14
		public void AutoSizeColumn(int column, bool useMergedCells)
		{
			int bestFitColumnWidth;
			try
			{
				bestFitColumnWidth = this._autoSizeColumnTracker.Value.GetBestFitColumnWidth(column, useMergedCells);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.InvalidOperationException("Could not auto-size column. Make sure the column was tracked prior to auto-sizing the column.", innerException);
			}
			int val = (int)(256.0 * global::NPOI.SS.Util.SheetUtil.GetColumnWidth(this, column, useMergedCells));
			int num = global::System.Math.Max(bestFitColumnWidth, val);
			if (num > 0)
			{
				int val2 = 65280;
				int width = global::System.Math.Min(num, val2);
				this.SetColumnWidth(column, width);
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.SS.UserModel.IRow CopyRow(int sourceIndex, int targetIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.SS.UserModel.ISheet CopySheet(string Name)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.SS.UserModel.ISheet CopySheet(string Name, string newName, bool copyStyle)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.SS.UserModel.ISheet CopySheet(string Name, bool copyStyle)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0002EC90 File Offset: 0x0002CE90
		public global::NPOI.SS.UserModel.IHyperlink GetHyperlink(int row, int column)
		{
			return this._sh.GetHyperlink(row, column);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0002EC9F File Offset: 0x0002CE9F
		public global::NPOI.SS.UserModel.IHyperlink GetHyperlink(global::NPOI.SS.Util.CellAddress addr)
		{
			return this._sh.GetHyperlink(addr);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0002ECAD File Offset: 0x0002CEAD
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IHyperlink> GetHyperlinkList()
		{
			return this._sh.GetHyperlinkList();
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0002ECBA File Offset: 0x0002CEBA
		public global::NPOI.SS.UserModel.IDrawing CreateDrawingPatriarch()
		{
			return this._sh.CreateDrawingPatriarch();
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0002ECC7 File Offset: 0x0002CEC7
		public void CreateFreezePane(int colSplit, int rowSplit)
		{
			this._sh.CreateFreezePane(colSplit, rowSplit);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0002ECD6 File Offset: 0x0002CED6
		public void CreateFreezePane(int colSplit, int rowSplit, int leftmostColumn, int topRow)
		{
			this._sh.CreateFreezePane(colSplit, rowSplit, leftmostColumn, topRow);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0002ECE8 File Offset: 0x0002CEE8
		public global::NPOI.SS.UserModel.IRow CreateRow(int rownum)
		{
			int lastRowIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL2007.LastRowIndex;
			if (rownum < 0 || rownum > lastRowIndex)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Invalid row number (",
					rownum.ToString(),
					") outside allowable range (0..",
					lastRowIndex.ToString(),
					")"
				}));
			}
			if (rownum <= this._writer.NumberLastFlushedRow)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Attempting to write a row[",
					rownum.ToString(),
					"] in the range [0,",
					this._writer.NumberLastFlushedRow.ToString(),
					"] that is already written to disk."
				}));
			}
			if (this._sh.PhysicalNumberOfRows > 0 && rownum <= this._sh.LastRowNum)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Attempting to write a row[",
					rownum.ToString(),
					"] in the range [0,",
					this._sh.LastRowNum.ToString(),
					"] that is already written to disk."
				}));
			}
			global::NPOI.XSSF.Streaming.SXSSFRow sxssfrow = new global::NPOI.XSSF.Streaming.SXSSFRow(this);
			this._rows[rownum] = sxssfrow;
			this.UpdateIndexWhenAdd(rownum);
			this.allFlushed = false;
			if (this._randomAccessWindowSize >= 0 && this._rows.Count > this._randomAccessWindowSize)
			{
				try
				{
					this.FlushRows(this._randomAccessWindowSize, false);
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::NPOI.Util.RuntimeException(e);
				}
			}
			return sxssfrow;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0002EE64 File Offset: 0x0002D064
		private void UpdateIndexWhenAdd(int rownum)
		{
			if (this._FirstRowNum == -1 || rownum < this._FirstRowNum)
			{
				this._FirstRowNum = rownum;
			}
			if (rownum > this._LastRowNum)
			{
				this._LastRowNum = rownum;
			}
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0002EE8F File Offset: 0x0002D08F
		public void CreateSplitPane(int xSplitPos, int ySplitPos, int leftmostColumn, int topRow, global::NPOI.SS.UserModel.PanePosition activePane)
		{
			this._sh.CreateSplitPane(xSplitPos, ySplitPos, leftmostColumn, topRow, activePane);
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0002EEA3 File Offset: 0x0002D0A3
		[global::System.Obsolete("deprecated as of 2015-11-23 (circa POI 3.14beta1). Use {@link #getCellComment(CellAddress)} instead.")]
		public global::NPOI.SS.UserModel.IComment GetCellComment(int row, int column)
		{
			return this.GetCellComment(new global::NPOI.SS.Util.CellAddress(row, column));
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0002EEB2 File Offset: 0x0002D0B2
		public global::NPOI.SS.UserModel.IComment GetCellComment(global::NPOI.SS.Util.CellAddress ref1)
		{
			return this._sh.GetCellComment(ref1);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0002EEC0 File Offset: 0x0002D0C0
		public global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.SS.UserModel.IComment> GetCellComments()
		{
			return this._sh.GetCellComments();
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0002EECD File Offset: 0x0002D0CD
		public int GetColumnOutlineLevel(int columnIndex)
		{
			return this._sh.GetColumnOutlineLevel(columnIndex);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0002EEDB File Offset: 0x0002D0DB
		public global::NPOI.SS.UserModel.ICellStyle GetColumnStyle(int column)
		{
			return this._sh.GetColumnStyle(column);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0002EEE9 File Offset: 0x0002D0E9
		public int GetColumnWidth(int columnIndex)
		{
			return this._sh.GetColumnWidth(columnIndex);
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0002EEF7 File Offset: 0x0002D0F7
		public float GetColumnWidthInPixels(int columnIndex)
		{
			return this._sh.GetColumnWidthInPixels(columnIndex);
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0002EF05 File Offset: 0x0002D105
		public global::NPOI.SS.UserModel.IDataValidationHelper GetDataValidationHelper()
		{
			return this._sh.GetDataValidationHelper();
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0002EF12 File Offset: 0x0002D112
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IDataValidation> GetDataValidations()
		{
			return this._sh.GetDataValidations();
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0002EF1F File Offset: 0x0002D11F
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return new global::System.Collections.Generic.SortedDictionary<int, global::NPOI.XSSF.Streaming.SXSSFRow>(this._rows).Values.GetEnumerator();
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0002EF3B File Offset: 0x0002D13B
		public double GetMargin(global::NPOI.SS.UserModel.MarginType margin)
		{
			return this._sh.GetMargin(margin);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0002EF49 File Offset: 0x0002D149
		public global::NPOI.SS.Util.CellRangeAddress GetMergedRegion(int index)
		{
			return this._sh.GetMergedRegion(index);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0002EF57 File Offset: 0x0002D157
		public global::NPOI.SS.UserModel.IRow GetRow(int rownum)
		{
			if (this._rows.ContainsKey(rownum))
			{
				return this._rows[rownum];
			}
			return null;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0002EF75 File Offset: 0x0002D175
		public global::System.Collections.IEnumerator GetRowEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0002EF7D File Offset: 0x0002D17D
		public void GroupColumn(int fromColumn, int toColumn)
		{
			this._sh.GroupColumn(fromColumn, toColumn);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0002EF8C File Offset: 0x0002D18C
		public void GroupRow(int fromRow, int toRow)
		{
			foreach (global::NPOI.XSSF.Streaming.SXSSFRow sxssfrow in from kvp in this._rows
			where kvp.Key >= fromRow && kvp.Key <= toRow + 1
			select kvp into r
			select r.Value)
			{
				int num = sxssfrow.OutlineLevel + 1;
				sxssfrow.OutlineLevel = num;
				if (num > this.outlineLevelRow)
				{
					this.outlineLevelRow = num;
				}
			}
			this.SetWorksheetOutlineLevelRow();
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x0002F040 File Offset: 0x0002D240
		public void SetRowOutlineLevel(int rownum, int level)
		{
			this._rows[rownum].OutlineLevel = level;
			if (level > 0 && level > this.outlineLevelRow)
			{
				this.outlineLevelRow = level;
				this.SetWorksheetOutlineLevelRow();
			}
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0002F070 File Offset: 0x0002D270
		private void SetWorksheetOutlineLevelRow()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet ctworksheet = this._sh.GetCTWorksheet();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr ct_SheetFormatPr = ctworksheet.IsSetSheetFormatPr() ? ctworksheet.sheetFormatPr : ctworksheet.AddNewSheetFormatPr();
			if (this.outlineLevelRow > 0)
			{
				ct_SheetFormatPr.outlineLevelRow = (byte)this.outlineLevelRow;
			}
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x0002F0B6 File Offset: 0x0002D2B6
		public bool IsColumnBroken(int column)
		{
			return this._sh.IsColumnBroken(column);
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0002F0C4 File Offset: 0x0002D2C4
		public bool IsColumnHidden(int columnIndex)
		{
			return this._sh.IsColumnHidden(columnIndex);
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x000065E4 File Offset: 0x000047E4
		public bool IsMergedRegion(global::NPOI.SS.Util.CellRangeAddress mergedRegion)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x0002F0D2 File Offset: 0x0002D2D2
		public bool IsRowBroken(int row)
		{
			return this._sh.IsRowBroken(row);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0002F0E0 File Offset: 0x0002D2E0
		public void ProtectSheet(string password)
		{
			this._sh.ProtectSheet(password);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0002F0EE File Offset: 0x0002D2EE
		public global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> RemoveArrayFormula(global::NPOI.SS.UserModel.ICell cell)
		{
			return this._sh.RemoveArrayFormula(cell);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x0002F0FC File Offset: 0x0002D2FC
		public void RemoveColumnBreak(int column)
		{
			this._sh.RemoveColumnBreak(column);
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x0002F10A File Offset: 0x0002D30A
		public void RemoveMergedRegion(int index)
		{
			this._sh.RemoveMergedRegion(index);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x0002F118 File Offset: 0x0002D318
		public void RemoveMergedRegions(global::System.Collections.Generic.IList<int> indices)
		{
			this._sh.RemoveMergedRegions(indices);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x0002F128 File Offset: 0x0002D328
		public void RemoveRow(global::NPOI.SS.UserModel.IRow row)
		{
			if (row == null)
			{
				throw new global::System.ArgumentException("Invalid row (null)");
			}
			if (row.Sheet != this)
			{
				throw new global::System.ArgumentException("Specified row does not belong to this sheet");
			}
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			foreach (global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.Streaming.SXSSFRow> keyValuePair in this._rows)
			{
				if (keyValuePair.Value == row)
				{
					list.Add(keyValuePair.Key);
				}
			}
			bool flag = false;
			bool flag2 = false;
			foreach (int num in list)
			{
				if (num == this._FirstRowNum)
				{
					flag = true;
				}
				if (num >= this._LastRowNum - 1)
				{
					flag2 = true;
				}
				this._rows.Remove(num);
			}
			if (flag)
			{
				this.InvalidateFirstRowNum();
			}
			if (flag2)
			{
				this.InvalidateLastRowNum();
			}
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0002F224 File Offset: 0x0002D424
		private void InvalidateFirstRowNum()
		{
			if (this._rows.Count == 0)
			{
				this._FirstRowNum = -1;
				return;
			}
			this._FirstRowNum = this._rows.Keys.Min();
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0002F251 File Offset: 0x0002D451
		private void InvalidateLastRowNum()
		{
			if (this._rows.Count == 0)
			{
				this._LastRowNum = -1;
				return;
			}
			this._LastRowNum = this._rows.Keys.Max();
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0002F27E File Offset: 0x0002D47E
		public void RemoveRowBreak(int row)
		{
			this._sh.RemoveRowBreak(row);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000065E4 File Offset: 0x000047E4
		public void SetActive(bool value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x000065E4 File Offset: 0x000047E4
		public void SetActiveCell(int row, int column)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000065E4 File Offset: 0x000047E4
		public void SetActiveCellRange(global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress8Bit> cellranges, int activeRange, int activeRow, int activeColumn)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x000065E4 File Offset: 0x000047E4
		public void SetActiveCellRange(int firstRow, int lastRow, int firstColumn, int lastColumn)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0002F28C File Offset: 0x0002D48C
		public global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> SetArrayFormula(string formula, global::NPOI.SS.Util.CellRangeAddress range)
		{
			return this._sh.SetArrayFormula(formula, range);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0002F29B File Offset: 0x0002D49B
		public global::NPOI.SS.UserModel.IAutoFilter SetAutoFilter(global::NPOI.SS.Util.CellRangeAddress range)
		{
			return this._sh.SetAutoFilter(range);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x0002F2A9 File Offset: 0x0002D4A9
		public void SetColumnBreak(int column)
		{
			this._sh.SetColumnBreak(column);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0002F2B7 File Offset: 0x0002D4B7
		public void SetColumnGroupCollapsed(int columnNumber, bool collapsed)
		{
			this._sh.SetColumnGroupCollapsed(columnNumber, collapsed);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0002F2C6 File Offset: 0x0002D4C6
		public void SetColumnHidden(int columnIndex, bool hidden)
		{
			this._sh.SetColumnHidden(columnIndex, hidden);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0002F2D5 File Offset: 0x0002D4D5
		public void SetColumnWidth(int columnIndex, int width)
		{
			this._sh.SetColumnWidth(columnIndex, width);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0002F2E4 File Offset: 0x0002D4E4
		public void SetDefaultColumnStyle(int column, global::NPOI.SS.UserModel.ICellStyle style)
		{
			this._sh.SetDefaultColumnStyle(column, style);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0002F2F3 File Offset: 0x0002D4F3
		public void TrackColumnForAutoSizing(int column)
		{
			this._autoSizeColumnTracker.Value.TrackColumn(column);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0002F307 File Offset: 0x0002D507
		public void TrackColumnsForAutoSizing(global::System.Collections.Generic.ICollection<int> columns)
		{
			this._autoSizeColumnTracker.Value.TrackColumns(columns);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0002F31A File Offset: 0x0002D51A
		public void TrackAllColumnsForAutoSizing()
		{
			this._autoSizeColumnTracker.Value.TrackAllColumns();
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0002F32C File Offset: 0x0002D52C
		public bool UntrackColumnForAutoSizing(int column)
		{
			return this._autoSizeColumnTracker.Value.UntrackColumn(column);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0002F33F File Offset: 0x0002D53F
		public bool UntrackColumnsForAutoSizing(global::System.Collections.Generic.ICollection<int> columns)
		{
			return this._autoSizeColumnTracker.Value.UntrackColumns(columns);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0002F352 File Offset: 0x0002D552
		public void UntrackAllColumnsForAutoSizing()
		{
			this._autoSizeColumnTracker.Value.UntrackAllColumns();
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0002F364 File Offset: 0x0002D564
		public bool IsColumnTrackedForAutoSizing(int column)
		{
			return this._autoSizeColumnTracker.Value.IsColumnTracked(column);
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0002F377 File Offset: 0x0002D577
		public global::System.Collections.Generic.ISet<int> TrackedColumnsForAutoSizing
		{
			get
			{
				return this._autoSizeColumnTracker.Value.TrackedColumns;
			}
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0002F389 File Offset: 0x0002D589
		public void SetMargin(global::NPOI.SS.UserModel.MarginType margin, double size)
		{
			this._sh.SetMargin(margin, size);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0002F398 File Offset: 0x0002D598
		public void SetRowBreak(int row)
		{
			this._sh.SetRowBreak(row);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0002F3A6 File Offset: 0x0002D5A6
		public void SetRowGroupCollapsed(int row, bool collapse)
		{
			if (collapse)
			{
				this.collapseRow(row);
				return;
			}
			throw new global::NPOI.Util.RuntimeException("Unable to expand row: Not Implemented");
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0002F3C0 File Offset: 0x0002D5C0
		private void collapseRow(int rowIndex)
		{
			global::NPOI.XSSF.Streaming.SXSSFRow sxssfrow = (global::NPOI.XSSF.Streaming.SXSSFRow)this.GetRow(rowIndex);
			if (sxssfrow == null)
			{
				throw new global::System.InvalidOperationException("Invalid row number(" + rowIndex.ToString() + "). Row does not exist.");
			}
			int rowIndex2 = this.FindStartOfRowOutlineGroup(rowIndex);
			int rownum = this.WriteHidden(sxssfrow, rowIndex2, true);
			global::NPOI.XSSF.Streaming.SXSSFRow sxssfrow2 = (global::NPOI.XSSF.Streaming.SXSSFRow)this.GetRow(rownum);
			if (sxssfrow2 != null)
			{
				sxssfrow2.Collapsed = new bool?(true);
				return;
			}
			((global::NPOI.XSSF.Streaming.SXSSFRow)this.CreateRow(rownum)).Collapsed = new bool?(true);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0002F440 File Offset: 0x0002D640
		private int FindStartOfRowOutlineGroup(int rowIndex)
		{
			int outlineLevel = ((global::NPOI.XSSF.Streaming.SXSSFRow)this.GetRow(rowIndex)).OutlineLevel;
			if (outlineLevel == 0)
			{
				throw new global::System.InvalidOperationException("Outline level is zero for the row (" + rowIndex.ToString() + ").");
			}
			int num = rowIndex;
			while (this.GetRow(num) != null)
			{
				if (this.GetRow(num).OutlineLevel < outlineLevel)
				{
					return num + 1;
				}
				num--;
			}
			return num + 1;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0002F4A8 File Offset: 0x0002D6A8
		private int WriteHidden(global::NPOI.XSSF.Streaming.SXSSFRow xRow, int rowIndex, bool hidden)
		{
			int outlineLevel = xRow.OutlineLevel;
			global::NPOI.XSSF.Streaming.SXSSFRow sxssfrow = (global::NPOI.XSSF.Streaming.SXSSFRow)this.GetRow(rowIndex);
			while (sxssfrow != null && sxssfrow.OutlineLevel >= outlineLevel)
			{
				sxssfrow.Hidden = new bool?(hidden);
				rowIndex++;
				sxssfrow = (global::NPOI.XSSF.Streaming.SXSSFRow)this.GetRow(rowIndex);
			}
			return rowIndex;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0002F4F6 File Offset: 0x0002D6F6
		[global::System.Obsolete("deprecated 2015-11-23 (circa POI 3.14beta1). Use {@link #setZoom(int)} instead.")]
		public void SetZoom(int numerator, int denominator)
		{
			this._sh.SetZoom(numerator, denominator);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0002F505 File Offset: 0x0002D705
		public void SetZoom(int scale)
		{
			this._sh.SetZoom(scale);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x000065E4 File Offset: 0x000047E4
		public void ShiftRows(int startRow, int endRow, int n)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000065E4 File Offset: 0x000047E4
		public void ShiftRows(int startRow, int endRow, int n, bool copyRowHeight, bool resetOriginalRowHeight)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0002F513 File Offset: 0x0002D713
		public void ShowInPane(int toprow, int leftcol)
		{
			this._sh.ShowInPane(toprow, leftcol);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0002F522 File Offset: 0x0002D722
		public void UngroupColumn(int fromColumn, int toColumn)
		{
			this._sh.UngroupColumn(fromColumn, toColumn);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0002F531 File Offset: 0x0002D731
		public void UngroupRow(int fromRow, int toRow)
		{
			this._sh.UngroupRow(fromRow, toRow);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0002F540 File Offset: 0x0002D740
		public bool IsDate1904()
		{
			return this._workbook.IsDate1904();
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0002F550 File Offset: 0x0002D750
		public int GetRowNum(global::NPOI.XSSF.Streaming.SXSSFRow row)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.Streaming.SXSSFRow> keyValuePair in this._rows)
			{
				if (keyValuePair.Value == row)
				{
					return keyValuePair.Key;
				}
			}
			return -1;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0002F5B0 File Offset: 0x0002D7B0
		public void ChangeRowNum(global::NPOI.XSSF.Streaming.SXSSFRow row, int newRowNum)
		{
			this.RemoveRow(row);
			this._rows.Add(newRowNum, row);
			this.UpdateIndexWhenAdd(newRowNum);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0002F5CD File Offset: 0x0002D7CD
		public bool Dispose()
		{
			if (!this.allFlushed)
			{
				this.FlushRows();
			}
			return this._writer.Dispose();
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0002F5E8 File Offset: 0x0002D7E8
		private void FlushRows(int remaining, bool flushOnDisk)
		{
			global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.Streaming.SXSSFRow>? keyValuePair = null;
			int num = 0;
			while (this._rows.Count > remaining)
			{
				num++;
				keyValuePair = this.flushOneRow();
			}
			this.InvalidateFirstRowNum();
			this.InvalidateLastRowNum();
			if (remaining == 0)
			{
				this.allFlushed = true;
			}
			if (keyValuePair != null && flushOnDisk)
			{
				this._writer.FlushRows(num, keyValuePair.Value.Key, (int)keyValuePair.Value.Value.LastCellNum);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0002F66A File Offset: 0x0002D86A
		public bool AllRowsFlushed
		{
			get
			{
				return this.allFlushed;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0002F672 File Offset: 0x0002D872
		public int LastFlushedRowNumber
		{
			get
			{
				return this.lastFlushedRowNumber;
			}
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0002F67A File Offset: 0x0002D87A
		public void FlushRows()
		{
			this.FlushRows(0, true);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0002F684 File Offset: 0x0002D884
		private global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.Streaming.SXSSFRow>? flushOneRow()
		{
			if (this._rows.Count == 0)
			{
				return null;
			}
			int num = this._rows.Keys.Min();
			global::NPOI.XSSF.Streaming.SXSSFRow sxssfrow = this._rows[num];
			this._writer.WriteRow(num, sxssfrow);
			this._rows.Remove(num);
			this.lastFlushedRowNumber = num;
			return new global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.Streaming.SXSSFRow>?(new global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.Streaming.SXSSFRow>(num, sxssfrow));
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0002F6F3 File Offset: 0x0002D8F3
		public global::System.IO.Stream GetWorksheetXMLInputStream()
		{
			this.FlushRows(0, true);
			this._writer.Close();
			return this._writer.GetWorksheetXmlInputStream();
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x0002F713 File Offset: 0x0002D913
		public global::NPOI.XSSF.Streaming.SheetDataWriter SheetDataWriter
		{
			get
			{
				return this._writer;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x0002F71B File Offset: 0x0002D91B
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x0002F728 File Offset: 0x0002D928
		public global::NPOI.SS.Util.CellAddress ActiveCell
		{
			get
			{
				return this._sh.ActiveCell;
			}
			set
			{
				this._sh.ActiveCell = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x0002F736 File Offset: 0x0002D936
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x0002F743 File Offset: 0x0002D943
		public global::NPOI.XSSF.UserModel.XSSFColor TabColor
		{
			get
			{
				return this._sh.TabColor;
			}
			set
			{
				this._sh.TabColor = value;
			}
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000065E4 File Offset: 0x000047E4
		public void CopyTo(global::NPOI.SS.UserModel.IWorkbook dest, string name, bool copyStyle, bool keepFormulas)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040003F5 RID: 1013
		internal global::NPOI.XSSF.UserModel.XSSFSheet _sh;

		// Token: 0x040003F6 RID: 1014
		private global::NPOI.XSSF.Streaming.SXSSFWorkbook _workbook;

		// Token: 0x040003F7 RID: 1015
		private global::System.Collections.Generic.IDictionary<int, global::NPOI.XSSF.Streaming.SXSSFRow> _rows = new global::System.Collections.Generic.Dictionary<int, global::NPOI.XSSF.Streaming.SXSSFRow>();

		// Token: 0x040003F8 RID: 1016
		private global::NPOI.XSSF.Streaming.SheetDataWriter _writer;

		// Token: 0x040003F9 RID: 1017
		private int _randomAccessWindowSize = 100;

		// Token: 0x040003FA RID: 1018
		private global::System.Lazy<global::NPOI.XSSF.Streaming.AutoSizeColumnTracker> _autoSizeColumnTracker;

		// Token: 0x040003FB RID: 1019
		private int outlineLevelRow;

		// Token: 0x040003FC RID: 1020
		private int lastFlushedRowNumber = -1;

		// Token: 0x040003FD RID: 1021
		private bool allFlushed;

		// Token: 0x040003FE RID: 1022
		private int _FirstRowNum = -1;

		// Token: 0x040003FF RID: 1023
		private int _LastRowNum = -1;
	}
}
