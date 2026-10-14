using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Aggregates;
using NPOI.SS;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Formula.UDF;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000375 RID: 885
	public class HSSFEvaluationWorkbook : global::NPOI.SS.Formula.IFormulaRenderingWorkbook, global::NPOI.SS.Formula.IEvaluationWorkbook, global::NPOI.SS.Formula.IFormulaParsingWorkbook
	{
		// Token: 0x06001BCB RID: 7115 RVA: 0x00054E75 File Offset: 0x00053075
		public static global::NPOI.HSSF.UserModel.HSSFEvaluationWorkbook Create(global::NPOI.SS.UserModel.IWorkbook book)
		{
			if (book == null)
			{
				return null;
			}
			return new global::NPOI.HSSF.UserModel.HSSFEvaluationWorkbook((global::NPOI.HSSF.UserModel.HSSFWorkbook)book);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00054E87 File Offset: 0x00053087
		private HSSFEvaluationWorkbook(global::NPOI.HSSF.UserModel.HSSFWorkbook book)
		{
			this._uBook = book;
			this._iBook = book.Workbook;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00019A7F File Offset: 0x00017C7F
		public void ClearAllCachedResultValues()
		{
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00054EA2 File Offset: 0x000530A2
		public global::NPOI.SS.UserModel.IName CreateName()
		{
			return this._uBook.CreateName();
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00054EB0 File Offset: 0x000530B0
		public int GetExternalSheetIndex(string sheetName)
		{
			int sheetIndex = this._uBook.GetSheetIndex(sheetName);
			return this._iBook.CheckExternSheet(sheetIndex);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00054ED6 File Offset: 0x000530D6
		public int GetExternalSheetIndex(string workbookName, string sheetName)
		{
			return this._iBook.GetExternalSheetIndex(workbookName, sheetName);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00054EE5 File Offset: 0x000530E5
		public global::NPOI.SS.Formula.ExternalName GetExternalName(int externSheetIndex, int externNameIndex)
		{
			return this._iBook.GetExternalName(externSheetIndex, externNameIndex);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00054EF4 File Offset: 0x000530F4
		public global::NPOI.SS.Formula.ExternalName GetExternalName(string nameName, string sheetName, int externalWorkbookNumber)
		{
			throw new global::System.InvalidOperationException("XSSF-style external names are not supported for HSSF");
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00054F00 File Offset: 0x00053100
		public global::NPOI.SS.Formula.PTG.Ptg Get3DReferencePtg(global::NPOI.SS.Util.CellReference cr, global::NPOI.SS.Formula.SheetIdentifier sheet)
		{
			int sheetExtIx = this.GetSheetExtIx(sheet);
			return new global::NPOI.SS.Formula.PTG.Ref3DPtg(cr, sheetExtIx);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00054F1C File Offset: 0x0005311C
		public global::NPOI.SS.Formula.PTG.Ptg Get3DReferencePtg(global::NPOI.SS.Util.AreaReference areaRef, global::NPOI.SS.Formula.SheetIdentifier sheet)
		{
			int sheetExtIx = this.GetSheetExtIx(sheet);
			return new global::NPOI.SS.Formula.PTG.Area3DPtg(areaRef, sheetExtIx);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00054F38 File Offset: 0x00053138
		public global::NPOI.SS.Formula.PTG.Ptg GetNameXPtg(string name, global::NPOI.SS.Formula.SheetIdentifier sheet)
		{
			int sheetExtIx = this.GetSheetExtIx(sheet);
			return this._iBook.GetNameXPtg(name, sheetExtIx, this._uBook.GetUDFFinder());
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00054F68 File Offset: 0x00053168
		public global::NPOI.SS.Formula.IEvaluationName GetName(string name, int sheetIndex)
		{
			for (int i = 0; i < this._iBook.NumNames; i++)
			{
				global::NPOI.HSSF.Record.NameRecord nameRecord = this._iBook.GetNameRecord(i);
				if (nameRecord.SheetNumber == sheetIndex + 1 && name.Equals(nameRecord.NameText, global::System.StringComparison.OrdinalIgnoreCase))
				{
					return new global::NPOI.HSSF.UserModel.HSSFEvaluationWorkbook.Name(nameRecord, i);
				}
			}
			if (sheetIndex != -1)
			{
				return this.GetName(name, -1);
			}
			return null;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00054FC8 File Offset: 0x000531C8
		public int GetSheetIndex(global::NPOI.SS.Formula.IEvaluationSheet evalSheet)
		{
			global::NPOI.HSSF.UserModel.HSSFSheet hssfsheet = ((global::NPOI.HSSF.UserModel.HSSFEvaluationSheet)evalSheet).HSSFSheet;
			return this._uBook.GetSheetIndex(hssfsheet);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00054FED File Offset: 0x000531ED
		public int GetSheetIndex(string sheetName)
		{
			return this._uBook.GetSheetIndex(sheetName);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00054FFB File Offset: 0x000531FB
		public string GetSheetName(int sheetIndex)
		{
			return this._uBook.GetSheetName(sheetIndex);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00055009 File Offset: 0x00053209
		public global::NPOI.SS.Formula.IEvaluationSheet GetSheet(int sheetIndex)
		{
			return new global::NPOI.HSSF.UserModel.HSSFEvaluationSheet((global::NPOI.HSSF.UserModel.HSSFSheet)this._uBook.GetSheetAt(sheetIndex));
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x00055021 File Offset: 0x00053221
		public int ConvertFromExternSheetIndex(int externSheetIndex)
		{
			return this._iBook.GetFirstSheetIndexFromExternSheetIndex(externSheetIndex);
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00055030 File Offset: 0x00053230
		public global::NPOI.SS.Formula.ExternalSheet GetExternalSheet(int externSheetIndex)
		{
			global::NPOI.SS.Formula.ExternalSheet externalSheet = this._iBook.GetExternalSheet(externSheetIndex);
			if (externalSheet == null)
			{
				int num = this.ConvertFromExternSheetIndex(externSheetIndex);
				if (num == -1)
				{
					return null;
				}
				if (num == -2)
				{
					return null;
				}
				string sheetName = this.GetSheetName(num);
				int lastSheetIndexFromExternSheetIndex = this._iBook.GetLastSheetIndexFromExternSheetIndex(externSheetIndex);
				if (lastSheetIndexFromExternSheetIndex == num)
				{
					externalSheet = new global::NPOI.SS.Formula.ExternalSheet(null, sheetName);
				}
				else
				{
					string sheetName2 = this.GetSheetName(lastSheetIndexFromExternSheetIndex);
					externalSheet = new global::NPOI.SS.Formula.ExternalSheetRange(null, sheetName, sheetName2);
				}
			}
			return externalSheet;
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00055099 File Offset: 0x00053299
		public global::NPOI.SS.Formula.ExternalSheet GetExternalSheet(string firstSheetName, string lastSheetName, int externalWorkbookNumber)
		{
			throw new global::System.InvalidOperationException("XSSF-style external references are not supported for HSSF");
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x000550A5 File Offset: 0x000532A5
		public string ResolveNameXText(global::NPOI.SS.Formula.PTG.NameXPtg n)
		{
			return this._iBook.ResolveNameXText(n.SheetRefIndex, n.NameIndex);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x000550BE File Offset: 0x000532BE
		public string GetSheetFirstNameByExternSheet(int externSheetIndex)
		{
			return this._iBook.FindSheetFirstNameFromExternSheet(externSheetIndex);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x000550CC File Offset: 0x000532CC
		public string GetSheetLastNameByExternSheet(int externSheetIndex)
		{
			return this._iBook.FindSheetLastNameFromExternSheet(externSheetIndex);
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x000550DA File Offset: 0x000532DA
		public string GetNameText(global::NPOI.SS.Formula.PTG.NamePtg namePtg)
		{
			return this._iBook.GetNameRecord(namePtg.Index).NameText;
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x000550F4 File Offset: 0x000532F4
		public global::NPOI.SS.Formula.IEvaluationName GetName(global::NPOI.SS.Formula.PTG.NamePtg namePtg)
		{
			int index = namePtg.Index;
			return new global::NPOI.HSSF.UserModel.HSSFEvaluationWorkbook.Name(this._iBook.GetNameRecord(index), index);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0005511A File Offset: 0x0005331A
		public global::NPOI.SS.Formula.PTG.Ptg[] GetFormulaTokens(global::NPOI.SS.Formula.IEvaluationCell evalCell)
		{
			return ((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)((global::NPOI.HSSF.UserModel.HSSFCell)((global::NPOI.HSSF.UserModel.HSSFEvaluationCell)evalCell).HSSFCell).CellValueRecord).FormulaTokens;
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0005513B File Offset: 0x0005333B
		public global::NPOI.SS.Formula.UDF.UDFFinder GetUDFFinder()
		{
			return this._uBook.GetUDFFinder();
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x00055148 File Offset: 0x00053348
		private int GetSheetExtIx(global::NPOI.SS.Formula.SheetIdentifier sheetIden)
		{
			int result;
			if (sheetIden == null)
			{
				result = -1;
			}
			else
			{
				string bookName = sheetIden.BookName;
				string name = sheetIden.SheetId.Name;
				string text = name;
				if (sheetIden is global::NPOI.SS.Formula.SheetRangeIdentifier)
				{
					text = ((global::NPOI.SS.Formula.SheetRangeIdentifier)sheetIden).LastSheetIdentifier.Name;
				}
				if (bookName == null)
				{
					int sheetIndex = this._uBook.GetSheetIndex(name);
					int sheetIndex2 = this._uBook.GetSheetIndex(text);
					result = (int)this._iBook.checkExternSheet(sheetIndex, sheetIndex2);
				}
				else
				{
					result = this._iBook.GetExternalSheetIndex(bookName, name, text);
				}
			}
			return result;
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000551CB File Offset: 0x000533CB
		public global::NPOI.SS.SpreadsheetVersion GetSpreadsheetVersion()
		{
			return global::NPOI.SS.SpreadsheetVersion.EXCEL97;
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x000551D2 File Offset: 0x000533D2
		public global::NPOI.SS.UserModel.ITable GetTable(string name)
		{
			throw new global::System.InvalidOperationException("XSSF-style tables are not supported for HSSF");
		}

		// Token: 0x04000B4D RID: 2893
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.UserModel.HSSFEvaluationWorkbook));

		// Token: 0x04000B4E RID: 2894
		private global::NPOI.HSSF.UserModel.HSSFWorkbook _uBook;

		// Token: 0x04000B4F RID: 2895
		private global::NPOI.HSSF.Model.InternalWorkbook _iBook;

		// Token: 0x02000602 RID: 1538
		private class Name : global::NPOI.SS.Formula.IEvaluationName
		{
			// Token: 0x06003635 RID: 13877 RVA: 0x000A5B86 File Offset: 0x000A3D86
			public Name(global::NPOI.HSSF.Record.NameRecord nameRecord, int index)
			{
				this._nameRecord = nameRecord;
				this._index = index;
			}

			// Token: 0x17000E0D RID: 3597
			// (get) Token: 0x06003636 RID: 13878 RVA: 0x000A5B9C File Offset: 0x000A3D9C
			public global::NPOI.SS.Formula.PTG.Ptg[] NameDefinition
			{
				get
				{
					return this._nameRecord.NameDefinition;
				}
			}

			// Token: 0x17000E0E RID: 3598
			// (get) Token: 0x06003637 RID: 13879 RVA: 0x000A5BA9 File Offset: 0x000A3DA9
			public string NameText
			{
				get
				{
					return this._nameRecord.NameText;
				}
			}

			// Token: 0x17000E0F RID: 3599
			// (get) Token: 0x06003638 RID: 13880 RVA: 0x000A5BB6 File Offset: 0x000A3DB6
			public bool HasFormula
			{
				get
				{
					return this._nameRecord.HasFormula;
				}
			}

			// Token: 0x17000E10 RID: 3600
			// (get) Token: 0x06003639 RID: 13881 RVA: 0x000A5BC3 File Offset: 0x000A3DC3
			public bool IsFunctionName
			{
				get
				{
					return this._nameRecord.IsFunctionName;
				}
			}

			// Token: 0x17000E11 RID: 3601
			// (get) Token: 0x0600363A RID: 13882 RVA: 0x000A5BB6 File Offset: 0x000A3DB6
			public bool IsRange
			{
				get
				{
					return this._nameRecord.HasFormula;
				}
			}

			// Token: 0x0600363B RID: 13883 RVA: 0x000A5BD0 File Offset: 0x000A3DD0
			public global::NPOI.SS.Formula.PTG.NamePtg CreatePtg()
			{
				return new global::NPOI.SS.Formula.PTG.NamePtg(this._index);
			}

			// Token: 0x04001A45 RID: 6725
			private global::NPOI.HSSF.Record.NameRecord _nameRecord;

			// Token: 0x04001A46 RID: 6726
			private int _index;
		}
	}
}
