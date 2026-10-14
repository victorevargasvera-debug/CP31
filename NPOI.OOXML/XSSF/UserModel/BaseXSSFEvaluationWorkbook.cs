using System;
using System.Collections.Generic;
using System.Globalization;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Formula.UDF;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.Model;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200005C RID: 92
	public abstract class BaseXSSFEvaluationWorkbook : global::NPOI.SS.Formula.IFormulaRenderingWorkbook, global::NPOI.SS.Formula.IEvaluationWorkbook, global::NPOI.SS.Formula.IFormulaParsingWorkbook
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x0001066C File Offset: 0x0000E86C
		public virtual void ClearAllCachedResultValues()
		{
			this._tableCache = null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00010675 File Offset: 0x0000E875
		protected BaseXSSFEvaluationWorkbook(global::NPOI.XSSF.UserModel.XSSFWorkbook book)
		{
			this._uBook = book;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00010684 File Offset: 0x0000E884
		private int ConvertFromExternalSheetIndex(int externSheetIndex)
		{
			return externSheetIndex;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00010684 File Offset: 0x0000E884
		public int ConvertFromExternSheetIndex(int externSheetIndex)
		{
			return externSheetIndex;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00010684 File Offset: 0x0000E884
		private int ConvertToExternalSheetIndex(int sheetIndex)
		{
			return sheetIndex;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00010688 File Offset: 0x0000E888
		public int GetExternalSheetIndex(string sheetName)
		{
			int sheetIndex = this._uBook.GetSheetIndex(sheetName);
			return this.ConvertToExternalSheetIndex(sheetIndex);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000106AC File Offset: 0x0000E8AC
		private int ResolveBookIndex(string bookName)
		{
			if (bookName.StartsWith("[") && bookName.EndsWith("]"))
			{
				bookName = bookName.Substring(1, bookName.Length - 2);
			}
			try
			{
				return int.Parse(bookName);
			}
			catch (global::System.FormatException)
			{
			}
			global::System.Collections.Generic.List<global::NPOI.XSSF.Model.ExternalLinksTable> externalLinksTable = this._uBook.ExternalLinksTable;
			int num = this.FindExternalLinkIndex(bookName, externalLinksTable);
			if (num != -1)
			{
				return num;
			}
			if (!bookName.StartsWith("'file:///") || !bookName.EndsWith("'"))
			{
				throw new global::System.Exception("Book not linked for filename " + bookName);
			}
			string text = bookName.Substring(bookName.LastIndexOf('/') + 1);
			text = text.Substring(0, text.Length - 1);
			num = this.FindExternalLinkIndex(text, externalLinksTable);
			if (num != -1)
			{
				return num;
			}
			global::NPOI.XSSF.Model.ExternalLinksTable item = new global::NPOI.XSSF.UserModel.BaseXSSFEvaluationWorkbook.FakeExternalLinksTable(text);
			externalLinksTable.Add(item);
			return externalLinksTable.Count;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00010794 File Offset: 0x0000E994
		private int FindExternalLinkIndex(string bookName, global::System.Collections.Generic.List<global::NPOI.XSSF.Model.ExternalLinksTable> tables)
		{
			int num = 0;
			using (global::System.Collections.Generic.List<global::NPOI.XSSF.Model.ExternalLinksTable>.Enumerator enumerator = tables.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.LinkedFileName.Equals(bookName))
					{
						return num + 1;
					}
					num++;
				}
			}
			return -1;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000107F8 File Offset: 0x0000E9F8
		public global::NPOI.SS.Formula.IEvaluationName GetName(string name, int sheetIndex)
		{
			for (int i = 0; i < this._uBook.NumberOfNames; i++)
			{
				global::NPOI.XSSF.UserModel.XSSFName xssfname = this._uBook.GetNameAt(i) as global::NPOI.XSSF.UserModel.XSSFName;
				string nameName = xssfname.NameName;
				int sheetIndex2 = xssfname.SheetIndex;
				if (name.Equals(nameName, global::System.StringComparison.CurrentCultureIgnoreCase) && (sheetIndex2 == -1 || sheetIndex2 == sheetIndex))
				{
					return new global::NPOI.XSSF.UserModel.BaseXSSFEvaluationWorkbook.Name(xssfname, i, this);
				}
			}
			if (sheetIndex != -1)
			{
				return this.GetName(name, -1);
			}
			return null;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00010864 File Offset: 0x0000EA64
		public string GetSheetName(int sheetIndex)
		{
			return this._uBook.GetSheetName(sheetIndex);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00010872 File Offset: 0x0000EA72
		public global::NPOI.SS.Formula.ExternalName GetExternalName(int externSheetIndex, int externNameIndex)
		{
			throw new global::System.InvalidOperationException("HSSF-style external references are not supported for XSSF");
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00010880 File Offset: 0x0000EA80
		public global::NPOI.SS.Formula.ExternalName GetExternalName(string nameName, string sheetName, int externalWorkbookNumber)
		{
			if (externalWorkbookNumber > 0)
			{
				int index = externalWorkbookNumber - 1;
				global::NPOI.XSSF.Model.ExternalLinksTable externalLinksTable = this._uBook.ExternalLinksTable[index];
				foreach (global::NPOI.SS.UserModel.IName name in externalLinksTable.DefinedNames)
				{
					if (name.NameName.Equals(nameName))
					{
						int ix = name.SheetIndex + 1;
						return new global::NPOI.SS.Formula.ExternalName(nameName, -1, ix);
					}
				}
				throw new global::System.ArgumentException("Name '" + nameName + "' not found in reference to " + externalLinksTable.LinkedFileName);
			}
			int nameIndex = this._uBook.GetNameIndex(nameName);
			return new global::NPOI.SS.Formula.ExternalName(nameName, nameIndex, 0);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00010944 File Offset: 0x0000EB44
		public global::NPOI.SS.Formula.PTG.Ptg GetNameXPtg(string name, global::NPOI.SS.Formula.SheetIdentifier sheet)
		{
			if (((global::NPOI.SS.Formula.UDF.IndexedUDFFinder)this.GetUDFFinder()).FindFunction(name) != null)
			{
				return new global::NPOI.SS.Formula.PTG.NameXPxg(null, name);
			}
			if (sheet == null)
			{
				if (this._uBook.GetNames(name).Count > 0)
				{
					return new global::NPOI.SS.Formula.PTG.NameXPxg(null, name);
				}
				return null;
			}
			else
			{
				if (sheet._sheetIdentifier == null)
				{
					return new global::NPOI.SS.Formula.PTG.NameXPxg(this.ResolveBookIndex(sheet._bookName), null, name);
				}
				string name2 = sheet._sheetIdentifier.Name;
				if (sheet._bookName != null)
				{
					return new global::NPOI.SS.Formula.PTG.NameXPxg(this.ResolveBookIndex(sheet._bookName), name2, name);
				}
				return new global::NPOI.SS.Formula.PTG.NameXPxg(name2, name);
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000109D8 File Offset: 0x0000EBD8
		public global::NPOI.SS.Formula.PTG.Ptg Get3DReferencePtg(global::NPOI.SS.Util.CellReference cell, global::NPOI.SS.Formula.SheetIdentifier sheet)
		{
			if (sheet._bookName != null)
			{
				return new global::NPOI.SS.Formula.PTG.Ref3DPxg(this.ResolveBookIndex(sheet._bookName), sheet, cell);
			}
			return new global::NPOI.SS.Formula.PTG.Ref3DPxg(sheet, cell);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000109FD File Offset: 0x0000EBFD
		public global::NPOI.SS.Formula.PTG.Ptg Get3DReferencePtg(global::NPOI.SS.Util.AreaReference area, global::NPOI.SS.Formula.SheetIdentifier sheet)
		{
			if (sheet._bookName != null)
			{
				return new global::NPOI.SS.Formula.PTG.Area3DPxg(this.ResolveBookIndex(sheet._bookName), sheet, area);
			}
			return new global::NPOI.SS.Formula.PTG.Area3DPxg(sheet, area);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00010A24 File Offset: 0x0000EC24
		public string ResolveNameXText(global::NPOI.SS.Formula.PTG.NameXPtg n)
		{
			int nameIndex = n.NameIndex;
			string text = ((global::NPOI.SS.Formula.UDF.IndexedUDFFinder)this.GetUDFFinder()).GetFunctionName(nameIndex);
			if (text != null)
			{
				return text;
			}
			global::NPOI.XSSF.UserModel.XSSFName xssfname = this._uBook.GetNameAt(nameIndex) as global::NPOI.XSSF.UserModel.XSSFName;
			if (xssfname != null)
			{
				text = xssfname.NameName;
			}
			return text;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00010872 File Offset: 0x0000EA72
		public global::NPOI.SS.Formula.ExternalSheet GetExternalSheet(int externSheetIndex)
		{
			throw new global::System.InvalidOperationException("HSSF-style external references are not supported for XSSF");
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00010A70 File Offset: 0x0000EC70
		public global::NPOI.SS.Formula.ExternalSheet GetExternalSheet(string firstSheetName, string lastSheetName, int externalWorkbookNumber)
		{
			string workbookName;
			if (externalWorkbookNumber > 0)
			{
				int index = externalWorkbookNumber - 1;
				workbookName = this._uBook.ExternalLinksTable[index].LinkedFileName;
			}
			else
			{
				workbookName = null;
			}
			if (lastSheetName == null || firstSheetName.Equals(lastSheetName))
			{
				return new global::NPOI.SS.Formula.ExternalSheet(workbookName, firstSheetName);
			}
			return new global::NPOI.SS.Formula.ExternalSheetRange(workbookName, firstSheetName, lastSheetName);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00010ABC File Offset: 0x0000ECBC
		public int GetExternalSheetIndex(string workbookName, string sheetName)
		{
			throw new global::System.Exception("not implemented yet");
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00010AC8 File Offset: 0x0000ECC8
		public int GetSheetIndex(string sheetName)
		{
			return this._uBook.GetSheetIndex(sheetName);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		public string GetSheetFirstNameByExternSheet(int externSheetIndex)
		{
			int sheetIx = this.ConvertFromExternalSheetIndex(externSheetIndex);
			return this._uBook.GetSheetName(sheetIx);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00010AF9 File Offset: 0x0000ECF9
		public string GetSheetLastNameByExternSheet(int externSheetIndex)
		{
			return this.GetSheetFirstNameByExternSheet(externSheetIndex);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00010B02 File Offset: 0x0000ED02
		public string GetNameText(global::NPOI.SS.Formula.PTG.NamePtg namePtg)
		{
			return this._uBook.GetNameAt(namePtg.Index).NameName;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00010B1C File Offset: 0x0000ED1C
		public global::NPOI.SS.Formula.IEvaluationName GetName(global::NPOI.SS.Formula.PTG.NamePtg namePtg)
		{
			int index = namePtg.Index;
			return new global::NPOI.XSSF.UserModel.BaseXSSFEvaluationWorkbook.Name(this._uBook.GetNameAt(index) as global::NPOI.XSSF.UserModel.XSSFName, index, this);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00010B48 File Offset: 0x0000ED48
		public global::NPOI.SS.UserModel.IName CreateName()
		{
			return this._uBook.CreateName();
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00010B58 File Offset: 0x0000ED58
		private global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.XSSFTable> GetTableCache()
		{
			if (this._tableCache != null)
			{
				return this._tableCache;
			}
			this._tableCache = new global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.XSSFTable>();
			foreach (global::NPOI.SS.UserModel.ISheet sheet in this._uBook)
			{
				foreach (global::NPOI.XSSF.UserModel.XSSFTable xssftable in ((global::NPOI.XSSF.UserModel.XSSFSheet)sheet).GetTables())
				{
					string key = xssftable.Name.ToLower(global::System.Globalization.CultureInfo.CurrentCulture);
					this._tableCache.Add(key, xssftable);
				}
			}
			return this._tableCache;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00010C1C File Offset: 0x0000EE1C
		public global::NPOI.SS.UserModel.ITable GetTable(string name)
		{
			if (name == null)
			{
				return null;
			}
			string key = name.ToLower(global::System.Globalization.CultureInfo.CurrentCulture);
			return this.GetTableCache()[key];
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00010C46 File Offset: 0x0000EE46
		public global::NPOI.SS.Formula.UDF.UDFFinder GetUDFFinder()
		{
			return this._uBook.GetUDFFinder();
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00010C53 File Offset: 0x0000EE53
		public global::NPOI.SS.SpreadsheetVersion GetSpreadsheetVersion()
		{
			return global::NPOI.SS.SpreadsheetVersion.EXCEL2007;
		}

		// Token: 0x06000431 RID: 1073
		public abstract int GetSheetIndex(global::NPOI.SS.Formula.IEvaluationSheet sheet);

		// Token: 0x06000432 RID: 1074
		public abstract global::NPOI.SS.Formula.IEvaluationSheet GetSheet(int sheetIndex);

		// Token: 0x06000433 RID: 1075
		public abstract global::NPOI.SS.Formula.PTG.Ptg[] GetFormulaTokens(global::NPOI.SS.Formula.IEvaluationCell cell);

		// Token: 0x04000257 RID: 599
		protected global::NPOI.XSSF.UserModel.XSSFWorkbook _uBook;

		// Token: 0x04000258 RID: 600
		private global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.XSSFTable> _tableCache;

		// Token: 0x02000124 RID: 292
		private class FakeExternalLinksTable : global::NPOI.XSSF.Model.ExternalLinksTable
		{
			// Token: 0x06000FE2 RID: 4066 RVA: 0x00038336 File Offset: 0x00036536
			internal FakeExternalLinksTable(string fileName)
			{
				this.fileName = fileName;
			}

			// Token: 0x170003BD RID: 957
			// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00038345 File Offset: 0x00036545
			public override string LinkedFileName
			{
				get
				{
					return this.fileName;
				}
			}

			// Token: 0x04000502 RID: 1282
			private string fileName;
		}

		// Token: 0x02000125 RID: 293
		private class Name : global::NPOI.SS.Formula.IEvaluationName
		{
			// Token: 0x06000FE4 RID: 4068 RVA: 0x0003834D File Offset: 0x0003654D
			public Name(global::NPOI.XSSF.UserModel.XSSFName name, int index, global::NPOI.SS.Formula.IFormulaParsingWorkbook fpBook)
			{
				this._nameRecord = name;
				this._index = index;
				this._fpBook = fpBook;
			}

			// Token: 0x170003BE RID: 958
			// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x0003836A File Offset: 0x0003656A
			public global::NPOI.SS.Formula.PTG.Ptg[] NameDefinition
			{
				get
				{
					return global::NPOI.SS.Formula.FormulaParser.Parse(this._nameRecord.RefersToFormula, this._fpBook, global::NPOI.SS.Formula.FormulaType.NamedRange, this._nameRecord.SheetIndex);
				}
			}

			// Token: 0x170003BF RID: 959
			// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0003838E File Offset: 0x0003658E
			public string NameText
			{
				get
				{
					return this._nameRecord.NameName;
				}
			}

			// Token: 0x170003C0 RID: 960
			// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x0003839C File Offset: 0x0003659C
			public bool HasFormula
			{
				get
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_DefinedName ctname = this._nameRecord.GetCTName();
					string value = ctname.Value;
					return !ctname.function && value != null && value.Length > 0;
				}
			}

			// Token: 0x170003C1 RID: 961
			// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x000383D0 File Offset: 0x000365D0
			public bool IsFunctionName
			{
				get
				{
					return this._nameRecord.IsFunctionName;
				}
			}

			// Token: 0x170003C2 RID: 962
			// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x000383DD File Offset: 0x000365DD
			public bool IsRange
			{
				get
				{
					return this.HasFormula;
				}
			}

			// Token: 0x06000FEA RID: 4074 RVA: 0x000383E5 File Offset: 0x000365E5
			public global::NPOI.SS.Formula.PTG.NamePtg CreatePtg()
			{
				return new global::NPOI.SS.Formula.PTG.NamePtg(this._index);
			}

			// Token: 0x04000503 RID: 1283
			private global::NPOI.XSSF.UserModel.XSSFName _nameRecord;

			// Token: 0x04000504 RID: 1284
			private int _index;

			// Token: 0x04000505 RID: 1285
			private global::NPOI.SS.Formula.IFormulaParsingWorkbook _fpBook;
		}
	}
}
