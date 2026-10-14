using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.SS.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000089 RID: 137
	public interface ISheet
	{
		// Token: 0x060004B2 RID: 1202
		global::NPOI.SS.UserModel.IRow CreateRow(int rownum);

		// Token: 0x060004B3 RID: 1203
		void RemoveRow(global::NPOI.SS.UserModel.IRow row);

		// Token: 0x060004B4 RID: 1204
		global::NPOI.SS.UserModel.IRow GetRow(int rownum);

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004B5 RID: 1205
		int PhysicalNumberOfRows { get; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004B6 RID: 1206
		int FirstRowNum { get; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004B7 RID: 1207
		int LastRowNum { get; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004B8 RID: 1208
		// (set) Token: 0x060004B9 RID: 1209
		bool ForceFormulaRecalculation { get; set; }

		// Token: 0x060004BA RID: 1210
		void SetColumnHidden(int columnIndex, bool hidden);

		// Token: 0x060004BB RID: 1211
		bool IsColumnHidden(int columnIndex);

		// Token: 0x060004BC RID: 1212
		global::NPOI.SS.UserModel.IRow CopyRow(int sourceIndex, int targetIndex);

		// Token: 0x060004BD RID: 1213
		void SetColumnWidth(int columnIndex, int width);

		// Token: 0x060004BE RID: 1214
		int GetColumnWidth(int columnIndex);

		// Token: 0x060004BF RID: 1215
		float GetColumnWidthInPixels(int columnIndex);

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004C0 RID: 1216
		// (set) Token: 0x060004C1 RID: 1217
		int DefaultColumnWidth { get; set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004C2 RID: 1218
		// (set) Token: 0x060004C3 RID: 1219
		short DefaultRowHeight { get; set; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004C4 RID: 1220
		// (set) Token: 0x060004C5 RID: 1221
		float DefaultRowHeightInPoints { get; set; }

		// Token: 0x060004C6 RID: 1222
		global::NPOI.SS.UserModel.ICellStyle GetColumnStyle(int column);

		// Token: 0x060004C7 RID: 1223
		int AddMergedRegion(global::NPOI.SS.Util.CellRangeAddress region);

		// Token: 0x060004C8 RID: 1224
		int AddMergedRegionUnsafe(global::NPOI.SS.Util.CellRangeAddress region);

		// Token: 0x060004C9 RID: 1225
		void ValidateMergedRegions();

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004CA RID: 1226
		// (set) Token: 0x060004CB RID: 1227
		bool HorizontallyCenter { get; set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004CC RID: 1228
		// (set) Token: 0x060004CD RID: 1229
		bool VerticallyCenter { get; set; }

		// Token: 0x060004CE RID: 1230
		void RemoveMergedRegion(int index);

		// Token: 0x060004CF RID: 1231
		void RemoveMergedRegions(global::System.Collections.Generic.IList<int> indices);

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004D0 RID: 1232
		int NumMergedRegions { get; }

		// Token: 0x060004D1 RID: 1233
		global::NPOI.SS.Util.CellRangeAddress GetMergedRegion(int index);

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004D2 RID: 1234
		global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> MergedRegions { get; }

		// Token: 0x060004D3 RID: 1235
		global::System.Collections.IEnumerator GetRowEnumerator();

		// Token: 0x060004D4 RID: 1236
		global::System.Collections.IEnumerator GetEnumerator();

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004D5 RID: 1237
		// (set) Token: 0x060004D6 RID: 1238
		bool DisplayZeros { get; set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004D7 RID: 1239
		// (set) Token: 0x060004D8 RID: 1240
		bool Autobreaks { get; set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004D9 RID: 1241
		// (set) Token: 0x060004DA RID: 1242
		bool DisplayGuts { get; set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004DB RID: 1243
		// (set) Token: 0x060004DC RID: 1244
		bool FitToPage { get; set; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004DD RID: 1245
		// (set) Token: 0x060004DE RID: 1246
		bool RowSumsBelow { get; set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004DF RID: 1247
		// (set) Token: 0x060004E0 RID: 1248
		bool RowSumsRight { get; set; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004E1 RID: 1249
		// (set) Token: 0x060004E2 RID: 1250
		bool IsPrintGridlines { get; set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004E3 RID: 1251
		// (set) Token: 0x060004E4 RID: 1252
		bool IsPrintRowAndColumnHeadings { get; set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004E5 RID: 1253
		global::NPOI.SS.UserModel.IPrintSetup PrintSetup { get; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004E6 RID: 1254
		global::NPOI.SS.UserModel.IHeader Header { get; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004E7 RID: 1255
		global::NPOI.SS.UserModel.IFooter Footer { get; }

		// Token: 0x060004E8 RID: 1256
		double GetMargin(global::NPOI.SS.UserModel.MarginType margin);

		// Token: 0x060004E9 RID: 1257
		void SetMargin(global::NPOI.SS.UserModel.MarginType margin, double size);

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004EA RID: 1258
		bool Protect { get; }

		// Token: 0x060004EB RID: 1259
		void ProtectSheet(string password);

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004EC RID: 1260
		bool ScenarioProtect { get; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004ED RID: 1261
		// (set) Token: 0x060004EE RID: 1262
		short TabColorIndex { get; set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004EF RID: 1263
		global::NPOI.SS.UserModel.IDrawing DrawingPatriarch { get; }

		// Token: 0x060004F0 RID: 1264
		[global::System.Obsolete("deprecated 2015-11-23 (circa POI 3.14beta1). Use {@link #setZoom(int)} instead.")]
		void SetZoom(int numerator, int denominator);

		// Token: 0x060004F1 RID: 1265
		void SetZoom(int scale);

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004F2 RID: 1266
		// (set) Token: 0x060004F3 RID: 1267
		short TopRow { get; set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004F4 RID: 1268
		// (set) Token: 0x060004F5 RID: 1269
		short LeftCol { get; set; }

		// Token: 0x060004F6 RID: 1270
		void ShowInPane(int toprow, int leftcol);

		// Token: 0x060004F7 RID: 1271
		void ShiftRows(int startRow, int endRow, int n);

		// Token: 0x060004F8 RID: 1272
		void ShiftRows(int startRow, int endRow, int n, bool copyRowHeight, bool resetOriginalRowHeight);

		// Token: 0x060004F9 RID: 1273
		void CreateFreezePane(int colSplit, int rowSplit, int leftmostColumn, int topRow);

		// Token: 0x060004FA RID: 1274
		void CreateFreezePane(int colSplit, int rowSplit);

		// Token: 0x060004FB RID: 1275
		void CreateSplitPane(int xSplitPos, int ySplitPos, int leftmostColumn, int topRow, global::NPOI.SS.UserModel.PanePosition activePane);

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004FC RID: 1276
		global::NPOI.SS.Util.PaneInformation PaneInformation { get; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004FD RID: 1277
		// (set) Token: 0x060004FE RID: 1278
		bool DisplayGridlines { get; set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004FF RID: 1279
		// (set) Token: 0x06000500 RID: 1280
		bool DisplayFormulas { get; set; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000501 RID: 1281
		// (set) Token: 0x06000502 RID: 1282
		bool DisplayRowColHeadings { get; set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000503 RID: 1283
		// (set) Token: 0x06000504 RID: 1284
		bool IsActive { get; set; }

		// Token: 0x06000505 RID: 1285
		bool IsRowBroken(int row);

		// Token: 0x06000506 RID: 1286
		void RemoveRowBreak(int row);

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000507 RID: 1287
		int[] RowBreaks { get; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000508 RID: 1288
		int[] ColumnBreaks { get; }

		// Token: 0x06000509 RID: 1289
		void SetActiveCellRange(int firstRow, int lastRow, int firstColumn, int lastColumn);

		// Token: 0x0600050A RID: 1290
		void SetActiveCellRange(global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress8Bit> cellranges, int activeRange, int activeRow, int activeColumn);

		// Token: 0x0600050B RID: 1291
		void SetColumnBreak(int column);

		// Token: 0x0600050C RID: 1292
		void SetRowBreak(int row);

		// Token: 0x0600050D RID: 1293
		bool IsColumnBroken(int column);

		// Token: 0x0600050E RID: 1294
		void RemoveColumnBreak(int column);

		// Token: 0x0600050F RID: 1295
		void SetColumnGroupCollapsed(int columnNumber, bool collapsed);

		// Token: 0x06000510 RID: 1296
		void GroupColumn(int fromColumn, int toColumn);

		// Token: 0x06000511 RID: 1297
		void UngroupColumn(int fromColumn, int toColumn);

		// Token: 0x06000512 RID: 1298
		void GroupRow(int fromRow, int toRow);

		// Token: 0x06000513 RID: 1299
		void UngroupRow(int fromRow, int toRow);

		// Token: 0x06000514 RID: 1300
		void SetRowGroupCollapsed(int row, bool collapse);

		// Token: 0x06000515 RID: 1301
		void SetDefaultColumnStyle(int column, global::NPOI.SS.UserModel.ICellStyle style);

		// Token: 0x06000516 RID: 1302
		void AutoSizeColumn(int column);

		// Token: 0x06000517 RID: 1303
		void AutoSizeColumn(int column, bool useMergedCells);

		// Token: 0x06000518 RID: 1304
		[global::System.Obsolete("deprecated as of 2015-11-23 (circa POI 3.14beta1). Use {@link #getCellComment(CellAddress)} instead.")]
		global::NPOI.SS.UserModel.IComment GetCellComment(int row, int column);

		// Token: 0x06000519 RID: 1305
		global::NPOI.SS.UserModel.IComment GetCellComment(global::NPOI.SS.Util.CellAddress ref1);

		// Token: 0x0600051A RID: 1306
		global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.SS.UserModel.IComment> GetCellComments();

		// Token: 0x0600051B RID: 1307
		global::NPOI.SS.UserModel.IDrawing CreateDrawingPatriarch();

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600051C RID: 1308
		global::NPOI.SS.UserModel.IWorkbook Workbook { get; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600051D RID: 1309
		string SheetName { get; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600051E RID: 1310
		// (set) Token: 0x0600051F RID: 1311
		bool IsSelected { get; set; }

		// Token: 0x06000520 RID: 1312
		void SetActive(bool value);

		// Token: 0x06000521 RID: 1313
		global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> SetArrayFormula(string formula, global::NPOI.SS.Util.CellRangeAddress range);

		// Token: 0x06000522 RID: 1314
		global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> RemoveArrayFormula(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x06000523 RID: 1315
		bool IsMergedRegion(global::NPOI.SS.Util.CellRangeAddress mergedRegion);

		// Token: 0x06000524 RID: 1316
		global::NPOI.SS.UserModel.IDataValidationHelper GetDataValidationHelper();

		// Token: 0x06000525 RID: 1317
		global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IDataValidation> GetDataValidations();

		// Token: 0x06000526 RID: 1318
		void AddValidationData(global::NPOI.SS.UserModel.IDataValidation dataValidation);

		// Token: 0x06000527 RID: 1319
		global::NPOI.SS.UserModel.IAutoFilter SetAutoFilter(global::NPOI.SS.Util.CellRangeAddress range);

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000528 RID: 1320
		global::NPOI.SS.UserModel.ISheetConditionalFormatting SheetConditionalFormatting { get; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000529 RID: 1321
		// (set) Token: 0x0600052A RID: 1322
		bool IsRightToLeft { get; set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600052B RID: 1323
		// (set) Token: 0x0600052C RID: 1324
		global::NPOI.SS.Util.CellRangeAddress RepeatingRows { get; set; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600052D RID: 1325
		// (set) Token: 0x0600052E RID: 1326
		global::NPOI.SS.Util.CellRangeAddress RepeatingColumns { get; set; }

		// Token: 0x0600052F RID: 1327
		global::NPOI.SS.UserModel.ISheet CopySheet(string Name);

		// Token: 0x06000530 RID: 1328
		global::NPOI.SS.UserModel.ISheet CopySheet(string Name, bool copyStyle);

		// Token: 0x06000531 RID: 1329
		int GetColumnOutlineLevel(int columnIndex);

		// Token: 0x06000532 RID: 1330
		bool IsDate1904();

		// Token: 0x06000533 RID: 1331
		global::NPOI.SS.UserModel.IHyperlink GetHyperlink(int row, int column);

		// Token: 0x06000534 RID: 1332
		global::NPOI.SS.UserModel.IHyperlink GetHyperlink(global::NPOI.SS.Util.CellAddress addr);

		// Token: 0x06000535 RID: 1333
		global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IHyperlink> GetHyperlinkList();

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000536 RID: 1334
		// (set) Token: 0x06000537 RID: 1335
		global::NPOI.SS.Util.CellAddress ActiveCell { get; set; }

		// Token: 0x06000538 RID: 1336
		void CopyTo(global::NPOI.SS.UserModel.IWorkbook dest, string name, bool copyStyle, bool keepFormulas);
	}
}
