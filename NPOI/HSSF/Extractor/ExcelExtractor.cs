using System;
using System.Text;
using NPOI.HSSF.UserModel;
using NPOI.POIFS.FileSystem;
using NPOI.SS.Extractor;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.Extractor
{
	// Token: 0x020004F6 RID: 1270
	public class ExcelExtractor : global::NPOI.POIOLE2TextExtractor, global::NPOI.SS.Extractor.IExcelExtractor
	{
		// Token: 0x06002FB9 RID: 12217 RVA: 0x0009060A File Offset: 0x0008E80A
		public ExcelExtractor(global::NPOI.HSSF.UserModel.HSSFWorkbook wb) : base(wb)
		{
			this.wb = wb;
			this._formatter = new global::NPOI.HSSF.UserModel.HSSFDataFormatter();
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x00090633 File Offset: 0x0008E833
		public ExcelExtractor(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs) : this(new global::NPOI.HSSF.UserModel.HSSFWorkbook(fs))
		{
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x00090641 File Offset: 0x0008E841
		// (set) Token: 0x06002FBC RID: 12220 RVA: 0x00090649 File Offset: 0x0008E849
		public bool IncludeHeaderFooter
		{
			get
			{
				return this.includeHeaderFooter;
			}
			set
			{
				this.includeHeaderFooter = value;
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x00090652 File Offset: 0x0008E852
		// (set) Token: 0x06002FBE RID: 12222 RVA: 0x0009065A File Offset: 0x0008E85A
		public bool IncludeSheetNames
		{
			get
			{
				return this.includeSheetNames;
			}
			set
			{
				this.includeSheetNames = value;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x00090663 File Offset: 0x0008E863
		// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x0009066B File Offset: 0x0008E86B
		public bool FormulasNotResults
		{
			get
			{
				return this.formulasNotResults;
			}
			set
			{
				this.formulasNotResults = value;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x00090674 File Offset: 0x0008E874
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x0009067C File Offset: 0x0008E87C
		public bool IncludeCellComments
		{
			get
			{
				return this.includeCellComments;
			}
			set
			{
				this.includeCellComments = value;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x00090685 File Offset: 0x0008E885
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x0009068D File Offset: 0x0008E88D
		public bool IncludeBlankCells
		{
			get
			{
				return this.includeBlankCells;
			}
			set
			{
				this.includeBlankCells = value;
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x00090698 File Offset: 0x0008E898
		public override string Text
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				this.wb.MissingCellPolicy = global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_BLANK_AS_NULL;
				for (int i = 0; i < this.wb.NumberOfSheets; i++)
				{
					global::NPOI.HSSF.UserModel.HSSFSheet hssfsheet = (global::NPOI.HSSF.UserModel.HSSFSheet)this.wb.GetSheetAt(i);
					if (hssfsheet != null)
					{
						if (this.includeSheetNames)
						{
							string sheetName = this.wb.GetSheetName(i);
							if (sheetName != null)
							{
								stringBuilder.Append(sheetName);
								stringBuilder.Append("\n");
							}
						}
						if (hssfsheet.Header != null && this.includeHeaderFooter)
						{
							stringBuilder.Append(global::NPOI.HSSF.Extractor.ExcelExtractor.ExtractHeaderFooter(hssfsheet.Header));
						}
						int firstRowNum = hssfsheet.FirstRowNum;
						int lastRowNum = hssfsheet.LastRowNum;
						for (int j = firstRowNum; j <= lastRowNum; j++)
						{
							global::NPOI.SS.UserModel.IRow row = hssfsheet.GetRow(j);
							if (row != null)
							{
								int num = (int)row.FirstCellNum;
								int lastCellNum = (int)row.LastCellNum;
								if (this.includeBlankCells)
								{
									num = 0;
								}
								for (int k = num; k < lastCellNum; k++)
								{
									global::NPOI.SS.UserModel.ICell cell = row.GetCell(k);
									bool flag = true;
									if (cell != null)
									{
										switch (cell.CellType)
										{
										case global::NPOI.SS.UserModel.CellType.Numeric:
											stringBuilder.Append(this._formatter.FormatCellValue(cell));
											break;
										case global::NPOI.SS.UserModel.CellType.String:
											stringBuilder.Append(cell.RichStringCellValue.String);
											break;
										case global::NPOI.SS.UserModel.CellType.Formula:
											if (this.formulasNotResults)
											{
												stringBuilder.Append(cell.CellFormula);
											}
											else
											{
												switch (cell.CachedFormulaResultType)
												{
												case global::NPOI.SS.UserModel.CellType.Numeric:
												{
													global::NPOI.HSSF.UserModel.HSSFCellStyle hssfcellStyle = (global::NPOI.HSSF.UserModel.HSSFCellStyle)cell.CellStyle;
													if (hssfcellStyle == null)
													{
														stringBuilder.Append(cell.NumericCellValue);
													}
													else
													{
														stringBuilder.Append(this._formatter.FormatRawCellContents(cell.NumericCellValue, (int)hssfcellStyle.DataFormat, hssfcellStyle.GetDataFormatString()));
													}
													break;
												}
												case global::NPOI.SS.UserModel.CellType.String:
												{
													global::NPOI.SS.UserModel.IRichTextString richStringCellValue = cell.RichStringCellValue;
													if (richStringCellValue != null && richStringCellValue.Length > 0)
													{
														stringBuilder.Append(richStringCellValue.ToString());
													}
													break;
												}
												case global::NPOI.SS.UserModel.CellType.Boolean:
													stringBuilder.Append(cell.BooleanCellValue);
													break;
												case global::NPOI.SS.UserModel.CellType.Error:
													stringBuilder.Append(global::NPOI.SS.Formula.Eval.ErrorEval.GetText((int)cell.ErrorCellValue));
													break;
												}
											}
											break;
										case global::NPOI.SS.UserModel.CellType.Blank:
											goto IL_25D;
										case global::NPOI.SS.UserModel.CellType.Boolean:
											stringBuilder.Append(cell.BooleanCellValue);
											break;
										case global::NPOI.SS.UserModel.CellType.Error:
											stringBuilder.Append(global::NPOI.SS.Formula.Eval.ErrorEval.GetText((int)cell.ErrorCellValue));
											break;
										default:
											goto IL_25D;
										}
										global::NPOI.SS.UserModel.IComment cellComment = cell.CellComment;
										if (this.includeCellComments && cellComment != null)
										{
											string str = cellComment.String.String.Replace('\n', ' ');
											stringBuilder.Append(" Comment by " + cellComment.Author + ": " + str);
											goto IL_2D3;
										}
										goto IL_2D3;
										IL_25D:
										throw new global::System.Exception("Unexpected cell type (" + cell.CellType.ToString() + ")");
									}
									flag = this.includeBlankCells;
									IL_2D3:
									if (flag && k < lastCellNum - 1)
									{
										stringBuilder.Append("\t");
									}
								}
								stringBuilder.Append("\n");
							}
						}
						if (hssfsheet.Footer != null && this.includeHeaderFooter)
						{
							stringBuilder.Append(global::NPOI.HSSF.Extractor.ExcelExtractor.ExtractHeaderFooter(hssfsheet.Footer));
						}
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x000909F8 File Offset: 0x0008EBF8
		public static string ExtractHeaderFooter(global::NPOI.SS.UserModel.IHeaderFooter hf)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (hf.Left != null)
			{
				stringBuilder.Append(hf.Left);
			}
			if (hf.Center != null)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append("\t");
				}
				stringBuilder.Append(hf.Center);
			}
			if (hf.Right != null)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append("\t");
				}
				stringBuilder.Append(hf.Right);
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append("\n");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04001559 RID: 5465
		private global::NPOI.HSSF.UserModel.HSSFWorkbook wb;

		// Token: 0x0400155A RID: 5466
		private global::NPOI.HSSF.UserModel.HSSFDataFormatter _formatter;

		// Token: 0x0400155B RID: 5467
		private bool includeSheetNames = true;

		// Token: 0x0400155C RID: 5468
		private bool formulasNotResults;

		// Token: 0x0400155D RID: 5469
		private bool includeCellComments;

		// Token: 0x0400155E RID: 5470
		private bool includeBlankCells;

		// Token: 0x0400155F RID: 5471
		private bool includeHeaderFooter = true;
	}
}
