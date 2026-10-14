using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NPOI.SS.Formula.UDF;
using NPOI.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200008E RID: 142
	public interface IWorkbook : global::NPOI.Util.ICloseable
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000554 RID: 1364
		int ActiveSheetIndex { get; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000555 RID: 1365
		// (set) Token: 0x06000556 RID: 1366
		int FirstVisibleTab { get; set; }

		// Token: 0x06000557 RID: 1367
		void SetSheetOrder(string sheetname, int pos);

		// Token: 0x06000558 RID: 1368
		void SetSelectedTab(int index);

		// Token: 0x06000559 RID: 1369
		void SetActiveSheet(int sheetIndex);

		// Token: 0x0600055A RID: 1370
		string GetSheetName(int sheet);

		// Token: 0x0600055B RID: 1371
		void SetSheetName(int sheet, string name);

		// Token: 0x0600055C RID: 1372
		int GetSheetIndex(string name);

		// Token: 0x0600055D RID: 1373
		int GetSheetIndex(global::NPOI.SS.UserModel.ISheet sheet);

		// Token: 0x0600055E RID: 1374
		global::NPOI.SS.UserModel.ISheet CreateSheet();

		// Token: 0x0600055F RID: 1375
		global::NPOI.SS.UserModel.ISheet CreateSheet(string sheetname);

		// Token: 0x06000560 RID: 1376
		global::NPOI.SS.UserModel.ISheet CloneSheet(int sheetNum);

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000561 RID: 1377
		int NumberOfSheets { get; }

		// Token: 0x06000562 RID: 1378
		global::NPOI.SS.UserModel.ISheet GetSheetAt(int index);

		// Token: 0x06000563 RID: 1379
		global::NPOI.SS.UserModel.ISheet GetSheet(string name);

		// Token: 0x06000564 RID: 1380
		void RemoveSheetAt(int index);

		// Token: 0x06000565 RID: 1381
		global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ISheet> GetEnumerator();

		// Token: 0x06000566 RID: 1382
		global::NPOI.SS.UserModel.IFont CreateFont();

		// Token: 0x06000567 RID: 1383
		[global::System.Obsolete("deprecated 3.15 beta 2. Use {@link #findFont(boolean, short, short, String, boolean, boolean, short, byte)} instead.")]
		global::NPOI.SS.UserModel.IFont FindFont(short boldWeight, short color, short fontHeight, string name, bool italic, bool strikeout, global::NPOI.SS.UserModel.FontSuperScript typeOffset, global::NPOI.SS.UserModel.FontUnderlineType underline);

		// Token: 0x06000568 RID: 1384
		global::NPOI.SS.UserModel.IFont FindFont(bool bold, short color, short fontHeight, string name, bool italic, bool strikeout, global::NPOI.SS.UserModel.FontSuperScript typeOffset, global::NPOI.SS.UserModel.FontUnderlineType underline);

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000569 RID: 1385
		short NumberOfFonts { get; }

		// Token: 0x0600056A RID: 1386
		global::NPOI.SS.UserModel.IFont GetFontAt(short idx);

		// Token: 0x0600056B RID: 1387
		global::NPOI.SS.UserModel.ICellStyle CreateCellStyle();

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600056C RID: 1388
		int NumCellStyles { get; }

		// Token: 0x0600056D RID: 1389
		global::NPOI.SS.UserModel.ICellStyle GetCellStyleAt(int idx);

		// Token: 0x0600056E RID: 1390
		void Write(global::System.IO.Stream stream);

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600056F RID: 1391
		int NumberOfNames { get; }

		// Token: 0x06000570 RID: 1392
		global::NPOI.SS.UserModel.IName GetName(string name);

		// Token: 0x06000571 RID: 1393
		global::System.Collections.Generic.IList<global::NPOI.SS.UserModel.IName> GetNames(string name);

		// Token: 0x06000572 RID: 1394
		global::System.Collections.Generic.IList<global::NPOI.SS.UserModel.IName> GetAllNames();

		// Token: 0x06000573 RID: 1395
		global::NPOI.SS.UserModel.IName GetNameAt(int nameIndex);

		// Token: 0x06000574 RID: 1396
		global::NPOI.SS.UserModel.IName CreateName();

		// Token: 0x06000575 RID: 1397
		int GetNameIndex(string name);

		// Token: 0x06000576 RID: 1398
		void RemoveName(int index);

		// Token: 0x06000577 RID: 1399
		void RemoveName(string name);

		// Token: 0x06000578 RID: 1400
		void RemoveName(global::NPOI.SS.UserModel.IName name);

		// Token: 0x06000579 RID: 1401
		int LinkExternalWorkbook(string name, global::NPOI.SS.UserModel.IWorkbook workbook);

		// Token: 0x0600057A RID: 1402
		void SetPrintArea(int sheetIndex, string reference);

		// Token: 0x0600057B RID: 1403
		void SetPrintArea(int sheetIndex, int startColumn, int endColumn, int startRow, int endRow);

		// Token: 0x0600057C RID: 1404
		string GetPrintArea(int sheetIndex);

		// Token: 0x0600057D RID: 1405
		void RemovePrintArea(int sheetIndex);

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600057E RID: 1406
		// (set) Token: 0x0600057F RID: 1407
		global::NPOI.SS.UserModel.MissingCellPolicy MissingCellPolicy { get; set; }

		// Token: 0x06000580 RID: 1408
		global::NPOI.SS.UserModel.IDataFormat CreateDataFormat();

		// Token: 0x06000581 RID: 1409
		int AddPicture(byte[] pictureData, global::NPOI.SS.UserModel.PictureType format);

		// Token: 0x06000582 RID: 1410
		global::System.Collections.IList GetAllPictures();

		// Token: 0x06000583 RID: 1411
		global::NPOI.SS.UserModel.ICreationHelper GetCreationHelper();

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000584 RID: 1412
		// (set) Token: 0x06000585 RID: 1413
		bool IsHidden { get; set; }

		// Token: 0x06000586 RID: 1414
		bool IsSheetHidden(int sheetIx);

		// Token: 0x06000587 RID: 1415
		bool IsSheetVeryHidden(int sheetIx);

		// Token: 0x06000588 RID: 1416
		void SetSheetHidden(int sheetIx, global::NPOI.SS.UserModel.SheetState hidden);

		// Token: 0x06000589 RID: 1417
		void SetSheetHidden(int sheetIx, int hidden);

		// Token: 0x0600058A RID: 1418
		void AddToolPack(global::NPOI.SS.Formula.UDF.UDFFinder toopack);

		// Token: 0x0600058B RID: 1419
		bool IsDate1904();

		// Token: 0x0600058C RID: 1420
		void Close();

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600058D RID: 1421
		global::NPOI.SS.SpreadsheetVersion SpreadsheetVersion { get; }
	}
}
