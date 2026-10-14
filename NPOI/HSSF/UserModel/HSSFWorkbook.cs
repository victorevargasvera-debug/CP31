using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using NPOI.DDF;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Aggregates;
using NPOI.POIFS.Crypt;
using NPOI.POIFS.FileSystem;
using NPOI.SS;
using NPOI.SS.Formula;
using NPOI.SS.Formula.UDF;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200038F RID: 911
	[global::System.Serializable]
	public class HSSFWorkbook : global::NPOI.POIDocument, global::NPOI.SS.UserModel.IWorkbook, global::NPOI.Util.ICloseable
	{
		// Token: 0x06001E9C RID: 7836 RVA: 0x0005DA27 File Offset: 0x0005BC27
		public global::NPOI.SS.UserModel.ICreationHelper GetCreationHelper()
		{
			return new global::NPOI.HSSF.UserModel.HSSFCreationHelper(this);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0005DA2F File Offset: 0x0005BC2F
		public static global::NPOI.HSSF.UserModel.HSSFWorkbook Create(global::NPOI.HSSF.Model.InternalWorkbook book)
		{
			return new global::NPOI.HSSF.UserModel.HSSFWorkbook(book);
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0005DA37 File Offset: 0x0005BC37
		public HSSFWorkbook() : this(global::NPOI.HSSF.Model.InternalWorkbook.CreateWorkbook())
		{
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0005DA44 File Offset: 0x0005BC44
		public HSSFWorkbook(global::NPOI.HSSF.Model.InternalWorkbook book)
		{
			this.missingCellPolicy = global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_NULL_AND_BLANK;
			this._udfFinder = new global::NPOI.SS.Formula.UDF.IndexedUDFFinder(new global::NPOI.SS.Formula.UDF.UDFFinder[]
			{
				global::NPOI.SS.Formula.UDF.UDFFinder.GetDefault()
			});
			base..ctor(null);
			this.workbook = book;
			this._sheets = new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFSheet>(3);
			this.names = new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFName>(3);
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x0005DA97 File Offset: 0x0005BC97
		public HSSFWorkbook(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs) : this(fs, true)
		{
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x0005DAA1 File Offset: 0x0005BCA1
		public HSSFWorkbook(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs) : this(fs.Root, true)
		{
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x0005DAB0 File Offset: 0x0005BCB0
		public HSSFWorkbook(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs, bool preserveNodes) : this(fs.Root, fs, preserveNodes)
		{
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x0005DAC0 File Offset: 0x0005BCC0
		private static string GetWorkbookDirEntryName(global::NPOI.POIFS.FileSystem.DirectoryNode directory)
		{
			foreach (string text in global::NPOI.HSSF.Model.InternalWorkbook.WORKBOOK_DIR_ENTRY_NAMES)
			{
				try
				{
					directory.GetEntry(text);
					return text;
				}
				catch (global::System.IO.FileNotFoundException)
				{
				}
			}
			try
			{
				directory.GetEntry(global::NPOI.POIFS.Crypt.Decryptor.DEFAULT_POIFS_ENTRY);
				throw new global::NPOI.EncryptedDocumentException("The supplied spreadsheet seems to be an Encrypted .xlsx file. It must be decrypted before use by XSSF, it cannot be used by HSSF");
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			try
			{
				directory.GetEntry(global::NPOI.HSSF.Model.InternalWorkbook.OLD_WORKBOOK_DIR_ENTRY_NAME);
				throw new global::NPOI.HSSF.OldExcelFormatException("The supplied spreadsheet seems to be Excel 5.0/7.0 (BIFF5) format. POI only supports BIFF8 format (from Excel versions 97/2000/XP/2003)");
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			throw new global::System.ArgumentException("The supplied POIFSFileSystem does not contain a BIFF8 'Workbook' entry. Is it really an excel file?");
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x0005DB60 File Offset: 0x0005BD60
		public HSSFWorkbook(global::NPOI.POIFS.FileSystem.DirectoryNode directory, global::NPOI.POIFS.FileSystem.POIFSFileSystem fs, bool preserveNodes) : this(directory, preserveNodes)
		{
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x0005DB6C File Offset: 0x0005BD6C
		public HSSFWorkbook(global::NPOI.POIFS.FileSystem.DirectoryNode directory, bool preserveNodes)
		{
			this.missingCellPolicy = global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_NULL_AND_BLANK;
			this._udfFinder = new global::NPOI.SS.Formula.UDF.IndexedUDFFinder(new global::NPOI.SS.Formula.UDF.UDFFinder[]
			{
				global::NPOI.SS.Formula.UDF.UDFFinder.GetDefault()
			});
			base..ctor(directory);
			string workbookDirEntryName = global::NPOI.HSSF.UserModel.HSSFWorkbook.GetWorkbookDirEntryName(directory);
			this.preserveNodes = preserveNodes;
			if (!preserveNodes)
			{
				this.directory = null;
			}
			this._sheets = new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFSheet>(3);
			this.names = new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFName>(3);
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> list = global::NPOI.HSSF.Record.RecordFactory.CreateRecords(directory.CreatePOIFSDocumentReader(workbookDirEntryName));
			this.workbook = global::NPOI.HSSF.Model.InternalWorkbook.CreateWorkbook(list);
			this.SetPropertiesFromWorkbook(this.workbook);
			int numRecords = this.workbook.NumRecords;
			this.ConvertLabelRecords(list, numRecords);
			global::NPOI.HSSF.Model.RecordStream recordStream = new global::NPOI.HSSF.Model.RecordStream(list, numRecords);
			while (recordStream.HasNext())
			{
				try
				{
					global::NPOI.HSSF.Model.InternalSheet sheet = global::NPOI.HSSF.Model.InternalSheet.CreateSheet(recordStream);
					this._sheets.Add(new global::NPOI.HSSF.UserModel.HSSFSheet(this, sheet));
				}
				catch (global::NPOI.HSSF.Model.UnsupportedBOFType unsupportedBOFType)
				{
					global::System.Console.WriteLine("Unsupported BOF found of type " + unsupportedBOFType.Type.ToString());
				}
			}
			for (int i = 0; i < this.workbook.NumNames; i++)
			{
				global::NPOI.HSSF.Record.NameRecord nameRecord = this.workbook.GetNameRecord(i);
				global::NPOI.HSSF.UserModel.HSSFName item = new global::NPOI.HSSF.UserModel.HSSFName(this, this.workbook.GetNameRecord(i), this.workbook.GetNameCommentRecord(nameRecord));
				this.names.Add(item);
			}
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x0005DCCC File Offset: 0x0005BECC
		public HSSFWorkbook(global::System.IO.Stream s) : this(s, true)
		{
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x0005DCD6 File Offset: 0x0005BED6
		public HSSFWorkbook(global::System.IO.Stream s, bool preserveNodes) : this(new global::NPOI.POIFS.FileSystem.POIFSFileSystem(s), preserveNodes)
		{
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0005DCE5 File Offset: 0x0005BEE5
		private void SetPropertiesFromWorkbook(global::NPOI.HSSF.Model.InternalWorkbook book)
		{
			this.workbook = book;
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0005DCF0 File Offset: 0x0005BEF0
		private void ConvertLabelRecords(global::System.Collections.IList records, int offset)
		{
			for (int i = offset; i < records.Count; i++)
			{
				global::NPOI.HSSF.Record.Record record = (global::NPOI.HSSF.Record.Record)records[i];
				if (record.Sid == 516)
				{
					global::NPOI.HSSF.Record.LabelRecord labelRecord = (global::NPOI.HSSF.Record.LabelRecord)record;
					records.RemoveAt(i);
					global::NPOI.HSSF.Record.LabelSSTRecord labelSSTRecord = new global::NPOI.HSSF.Record.LabelSSTRecord();
					int sstindex = this.workbook.AddSSTString(new global::NPOI.HSSF.Record.UnicodeString(labelRecord.Value));
					labelSSTRecord.Row = labelRecord.Row;
					labelSSTRecord.Column = labelRecord.Column;
					labelSSTRecord.XFIndex = labelRecord.XFIndex;
					labelSSTRecord.SSTIndex = sstindex;
					records.Insert(i, labelSSTRecord);
				}
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x0005DD8B File Offset: 0x0005BF8B
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x0005DD93 File Offset: 0x0005BF93
		public global::NPOI.SS.UserModel.MissingCellPolicy MissingCellPolicy
		{
			get
			{
				return this.missingCellPolicy;
			}
			set
			{
				this.missingCellPolicy = value;
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0005DD9C File Offset: 0x0005BF9C
		public void SetSheetOrder(string sheetname, int pos)
		{
			int sheetIndex = this.GetSheetIndex(sheetname);
			global::NPOI.HSSF.UserModel.HSSFSheet item = (global::NPOI.HSSF.UserModel.HSSFSheet)this.GetSheet(sheetname);
			this._sheets.RemoveAt(sheetIndex);
			this._sheets.Insert(pos, item);
			this.workbook.SetSheetOrder(sheetname, pos);
			global::NPOI.SS.Formula.FormulaShifter shifter = global::NPOI.SS.Formula.FormulaShifter.CreateForSheetShift(sheetIndex, pos);
			foreach (global::NPOI.HSSF.UserModel.HSSFSheet hssfsheet in this._sheets)
			{
				hssfsheet.Sheet.UpdateFormulasAfterCellShift(shifter, -1);
			}
			this.workbook.UpdateNamesAfterCellShift(shifter);
			int activeSheetIndex = this.ActiveSheetIndex;
			if (activeSheetIndex == sheetIndex)
			{
				this.SetActiveSheet(pos);
				return;
			}
			if ((activeSheetIndex >= sheetIndex || activeSheetIndex >= pos) && (activeSheetIndex <= sheetIndex || activeSheetIndex <= pos))
			{
				if (pos > sheetIndex)
				{
					this.SetActiveSheet(activeSheetIndex - 1);
					return;
				}
				this.SetActiveSheet(activeSheetIndex + 1);
			}
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x0005DE80 File Offset: 0x0005C080
		private void ValidateSheetIndex(int index)
		{
			int num = this._sheets.Count - 1;
			if (index < 0 || index > num)
			{
				string str = "(0.." + num.ToString() + ")";
				if (num == -1)
				{
					str = "(no sheets)";
				}
				throw new global::System.ArgumentException("Sheet index (" + index.ToString() + ") is out of range " + str);
			}
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x0005DEE4 File Offset: 0x0005C0E4
		public void InsertChartRecord()
		{
			int index = this.workbook.FindFirstRecordLocBySid(252);
			byte[] data = new byte[]
			{
				15,
				0,
				0,
				240,
				82,
				0,
				0,
				0,
				0,
				0,
				6,
				240,
				24,
				0,
				0,
				0,
				1,
				8,
				0,
				0,
				2,
				0,
				0,
				0,
				2,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				3,
				0,
				0,
				0,
				51,
				0,
				11,
				240,
				18,
				0,
				0,
				0,
				191,
				0,
				8,
				0,
				8,
				0,
				129,
				1,
				9,
				0,
				0,
				8,
				192,
				1,
				64,
				0,
				0,
				8,
				64,
				0,
				30,
				241,
				16,
				0,
				0,
				0,
				13,
				0,
				0,
				8,
				12,
				0,
				0,
				8,
				23,
				0,
				0,
				8,
				247,
				0,
				0,
				16
			};
			global::NPOI.HSSF.Record.UnknownRecord value = new global::NPOI.HSSF.Record.UnknownRecord(235, data);
			this.workbook.Records.Insert(index, value);
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x0005DF34 File Offset: 0x0005C134
		public void SetSelectedTab(int index)
		{
			this.ValidateSheetIndex(index);
			int count = this._sheets.Count;
			for (int i = 0; i < count; i++)
			{
				this.GetSheetAt(i).IsSelected = (i == index);
			}
			this.workbook.WindowOne.NumSelectedTabs = 1;
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x0005DF84 File Offset: 0x0005C184
		public void SetSelectedTabs(int[] indexes)
		{
			global::System.Collections.Generic.IList<int> selectedTabs = new global::System.Collections.Generic.List<int>(indexes);
			this.SetSelectedTabs(selectedTabs);
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x0005DFA0 File Offset: 0x0005C1A0
		public void SetSelectedTabs(global::System.Collections.Generic.IList<int> indexes)
		{
			foreach (int index in indexes)
			{
				this.ValidateSheetIndex(index);
			}
			global::System.Collections.Generic.ISet<int> set = new global::System.Collections.Generic.HashSet<int>(indexes);
			int count = this._sheets.Count;
			for (int i = 0; i < count; i++)
			{
				bool isSelected = set.Contains(i);
				this.GetSheetAt(i).IsSelected = isSelected;
			}
			this.workbook.WindowOne.NumSelectedTabs = (short)indexes.Count;
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x0005E03C File Offset: 0x0005C23C
		public global::System.Collections.Generic.IList<int> GetSelectedTabs()
		{
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			int count = this._sheets.Count;
			for (int i = 0; i < count; i++)
			{
				if ((this.GetSheetAt(i) as global::NPOI.HSSF.UserModel.HSSFSheet).IsSelected)
				{
					list.Add(i);
				}
			}
			return list.AsReadOnly();
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x0005E087 File Offset: 0x0005C287
		public int ActiveSheetIndex
		{
			get
			{
				return this.workbook.WindowOne.ActiveSheetIndex;
			}
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0005E09C File Offset: 0x0005C29C
		public void SetActiveSheet(int index)
		{
			this.ValidateSheetIndex(index);
			int count = this._sheets.Count;
			for (int i = 0; i < count; i++)
			{
				this.GetSheetAt(i).SetActive(i == index);
			}
			this.workbook.WindowOne.ActiveSheetIndex = index;
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x0005E0E9 File Offset: 0x0005C2E9
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x0005E0FB File Offset: 0x0005C2FB
		public int FirstVisibleTab
		{
			get
			{
				return this.workbook.WindowOne.FirstVisibleTab;
			}
			set
			{
				this.workbook.WindowOne.FirstVisibleTab = value;
			}
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x0005E110 File Offset: 0x0005C310
		public void SetSheetName(int sheetIx, string name)
		{
			if (name == null)
			{
				throw new global::System.ArgumentException("sheetName must not be null");
			}
			if (this.workbook.ContainsSheetName(name, sheetIx))
			{
				throw new global::System.ArgumentException("The workbook already contains a sheet named '" + name + "'");
			}
			this.ValidateSheetIndex(sheetIx);
			this.workbook.SetSheetName(sheetIx, name);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x0005E164 File Offset: 0x0005C364
		public string GetSheetName(int sheetIx)
		{
			this.ValidateSheetIndex(sheetIx);
			return this.workbook.GetSheetName(sheetIx);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x0005E179 File Offset: 0x0005C379
		public bool IsSheetHidden(int sheetIx)
		{
			this.ValidateSheetIndex(sheetIx);
			return this.workbook.IsSheetHidden(sheetIx);
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x0005E18E File Offset: 0x0005C38E
		public bool IsSheetVeryHidden(int sheetIx)
		{
			this.ValidateSheetIndex(sheetIx);
			return this.workbook.IsSheetVeryHidden(sheetIx);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x0005E1A3 File Offset: 0x0005C3A3
		public void SetSheetHidden(int sheetIx, global::NPOI.SS.UserModel.SheetState hidden)
		{
			this.ValidateSheetIndex(sheetIx);
			global::NPOI.SS.Util.WorkbookUtil.ValidateSheetState(hidden);
			this.workbook.SetSheetHidden(sheetIx, (int)hidden);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x0005E1BF File Offset: 0x0005C3BF
		public void SetSheetHidden(int sheetIx, int hidden)
		{
			this.ValidateSheetIndex(sheetIx);
			this.workbook.SetSheetHidden(sheetIx, hidden);
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x0005E1D5 File Offset: 0x0005C3D5
		public void SetSheetHidden(int sheetIx, bool hidden)
		{
			this.ValidateSheetIndex(sheetIx);
			this.workbook.SetSheetHidden(sheetIx, hidden);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x0005E1EB File Offset: 0x0005C3EB
		public int GetSheetIndex(string name)
		{
			return this.workbook.GetSheetIndex(name);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x0005E1FC File Offset: 0x0005C3FC
		public int GetSheetIndex(global::NPOI.SS.UserModel.ISheet sheet)
		{
			for (int i = 0; i < this._sheets.Count; i++)
			{
				if (this._sheets[i] == sheet)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x0005E234 File Offset: 0x0005C434
		public global::NPOI.SS.UserModel.ISheet CreateSheet()
		{
			global::NPOI.HSSF.UserModel.HSSFSheet hssfsheet = new global::NPOI.HSSF.UserModel.HSSFSheet(this);
			this._sheets.Add(hssfsheet);
			this.workbook.SetSheetName(this._sheets.Count - 1, "Sheet" + (this._sheets.Count - 1).ToString());
			bool flag = this._sheets.Count == 1;
			hssfsheet.IsSelected = flag;
			hssfsheet.IsActive = flag;
			return hssfsheet;
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0005E2AC File Offset: 0x0005C4AC
		public global::NPOI.SS.UserModel.ISheet CloneSheet(int sheetIndex)
		{
			this.ValidateSheetIndex(sheetIndex);
			global::NPOI.HSSF.UserModel.HSSFSheet hssfsheet = this._sheets[sheetIndex];
			string sheetName = this.workbook.GetSheetName(sheetIndex);
			global::NPOI.SS.UserModel.ISheet sheet = hssfsheet.CloneSheet(this);
			sheet.IsSelected = false;
			sheet.IsActive = false;
			string uniqueSheetName = this.GetUniqueSheetName(sheetName);
			int count = this._sheets.Count;
			this._sheets.Add((global::NPOI.HSSF.UserModel.HSSFSheet)sheet);
			this.workbook.SetSheetName(count, uniqueSheetName);
			int num = this.FindExistingBuiltinNameRecordIdx(sheetIndex, 13);
			if (num != -1)
			{
				global::NPOI.HSSF.Record.NameRecord name = this.workbook.CloneFilter(num, count);
				global::NPOI.HSSF.UserModel.HSSFName item = new global::NPOI.HSSF.UserModel.HSSFName(this, name);
				this.names.Add(item);
			}
			return sheet;
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x0005E358 File Offset: 0x0005C558
		private string GetUniqueSheetName(string srcName)
		{
			int num = 2;
			string text = srcName;
			int num2 = srcName.LastIndexOf('(');
			if (num2 > 0 && srcName.EndsWith(")", global::System.StringComparison.Ordinal))
			{
				string text2 = srcName.Substring(num2 + 1, srcName.Length - num2 - 2);
				try
				{
					num = int.Parse(text2.Trim(), global::System.Globalization.CultureInfo.InvariantCulture);
					num++;
					text = srcName.Substring(0, num2).Trim();
				}
				catch (global::System.FormatException)
				{
				}
			}
			string text4;
			do
			{
				string text3 = num++.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
				if (text.Length + text3.Length + 2 < 31)
				{
					text4 = text + " (" + text3 + ")";
				}
				else
				{
					text4 = text.Substring(0, 31 - text3.Length - 2) + "(" + text3 + ")";
				}
			}
			while (this.workbook.GetSheetIndex(text4) != -1);
			return text4;
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x0005E448 File Offset: 0x0005C648
		public global::NPOI.SS.UserModel.ISheet CreateSheet(string sheetname)
		{
			if (sheetname == null)
			{
				throw new global::System.ArgumentException("sheetName must not be null");
			}
			if (this.workbook.ContainsSheetName(sheetname, this._sheets.Count))
			{
				throw new global::System.ArgumentException("The workbook already contains a sheet named '" + sheetname + "'");
			}
			global::NPOI.SS.Util.WorkbookUtil.ValidateSheetName(sheetname);
			global::NPOI.HSSF.UserModel.HSSFSheet hssfsheet = new global::NPOI.HSSF.UserModel.HSSFSheet(this);
			this.workbook.SetSheetName(this._sheets.Count, sheetname);
			this._sheets.Add(hssfsheet);
			bool flag = this._sheets.Count == 1;
			hssfsheet.IsSelected = flag;
			hssfsheet.IsActive = flag;
			return hssfsheet;
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x0005E4E0 File Offset: 0x0005C6E0
		public int NumberOfSheets
		{
			get
			{
				return this._sheets.Count;
			}
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x0005E4ED File Offset: 0x0005C6ED
		private global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFSheet> GetSheets()
		{
			return this._sheets;
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x0005E4F5 File Offset: 0x0005C6F5
		public global::NPOI.SS.UserModel.ISheet GetSheetAt(int index)
		{
			return this._sheets[index];
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x0005E504 File Offset: 0x0005C704
		public global::NPOI.SS.UserModel.ISheet GetSheet(string name)
		{
			global::NPOI.HSSF.UserModel.HSSFSheet result = null;
			for (int i = 0; i < this._sheets.Count; i++)
			{
				if (this.workbook.GetSheetName(i).Equals(name, global::System.StringComparison.OrdinalIgnoreCase))
				{
					result = this._sheets[i];
					break;
				}
			}
			return result;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x0005E550 File Offset: 0x0005C750
		public void RemoveSheetAt(int index)
		{
			this.ValidateSheetIndex(index);
			bool isSelected = this.GetSheetAt(index).IsSelected;
			this._sheets.RemoveAt(index);
			this.workbook.RemoveSheet(index);
			int count = this._sheets.Count;
			if (count < 1)
			{
				return;
			}
			int num = index;
			if (num >= count)
			{
				num = count - 1;
			}
			if (isSelected)
			{
				bool flag = false;
				for (int i = 0; i < count; i++)
				{
					if (this.GetSheetAt(i).IsSelected)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					this.SetSelectedTab(num);
				}
			}
			int activeSheetIndex = this.ActiveSheetIndex;
			if (activeSheetIndex == index)
			{
				this.SetActiveSheet(num);
				return;
			}
			if (activeSheetIndex > index)
			{
				this.SetActiveSheet(activeSheetIndex - 1);
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x0005E5F9 File Offset: 0x0005C7F9
		// (set) Token: 0x06001ECA RID: 7882 RVA: 0x0005E60E File Offset: 0x0005C80E
		public bool BackupFlag
		{
			get
			{
				return this.workbook.BackupRecord.Backup != 0;
			}
			set
			{
				this.workbook.BackupRecord.Backup = (value ? 1 : 0);
			}
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x0005E628 File Offset: 0x0005C828
		internal int FindExistingBuiltinNameRecordIdx(int sheetIndex, byte builtinCode)
		{
			for (int i = 0; i < this.names.Count; i++)
			{
				global::NPOI.HSSF.Record.NameRecord nameRecord = this.workbook.GetNameRecord(i);
				if (nameRecord == null)
				{
					throw new global::System.InvalidOperationException("Unable to find all defined names to iterate over");
				}
				if (nameRecord.IsBuiltInName && nameRecord.BuiltInName == builtinCode && nameRecord.SheetNumber - 1 == sheetIndex)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0005E688 File Offset: 0x0005C888
		internal global::NPOI.HSSF.UserModel.HSSFName CreateBuiltInName(byte builtinCode, int sheetIndex)
		{
			global::NPOI.HSSF.Record.NameRecord name = this.workbook.CreateBuiltInName(builtinCode, sheetIndex + 1);
			global::NPOI.HSSF.UserModel.HSSFName hssfname = new global::NPOI.HSSF.UserModel.HSSFName(this, name, null);
			this.names.Add(hssfname);
			return hssfname;
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x0005E6BC File Offset: 0x0005C8BC
		internal global::NPOI.HSSF.UserModel.HSSFName GetBuiltInName(byte builtinCode, int sheetIndex)
		{
			int num = this.FindExistingBuiltinNameRecordIdx(sheetIndex, builtinCode);
			if (num < 0)
			{
				return null;
			}
			return this.names[num];
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x0005E6E4 File Offset: 0x0005C8E4
		private bool IsRowColHeaderRecord(global::NPOI.HSSF.Record.NameRecord r)
		{
			return r.OptionFlag == 32 && "\a".Equals(r.NameText);
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x0005E704 File Offset: 0x0005C904
		public global::NPOI.SS.UserModel.IFont CreateFont()
		{
			this.workbook.CreateNewFont();
			short num = this.NumberOfFonts - 1;
			if (num > 3)
			{
				num += 1;
			}
			if (num == 32767)
			{
				throw new global::System.ArgumentException("Maximum number of fonts was exceeded");
			}
			return this.GetFontAt(num);
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x0005E74C File Offset: 0x0005C94C
		[global::System.Obsolete("deprecated 3.15 beta 2. Use {@link #findFont(boolean, short, short, String, boolean, boolean, short, byte)} instead.")]
		public global::NPOI.SS.UserModel.IFont FindFont(short boldWeight, short color, short fontHeight, string name, bool italic, bool strikeout, global::NPOI.SS.UserModel.FontSuperScript typeOffset, global::NPOI.SS.UserModel.FontUnderlineType underline)
		{
			short numberOfFonts = this.NumberOfFonts;
			for (short num = 0; num <= numberOfFonts; num += 1)
			{
				if (num != 4)
				{
					global::NPOI.SS.UserModel.IFont fontAt = this.GetFontAt(num);
					if (fontAt.Boldweight == boldWeight && fontAt.Color == color && fontAt.FontHeight == (double)fontHeight && fontAt.FontName.Equals(name) && fontAt.IsItalic == italic && fontAt.IsStrikeout == strikeout && fontAt.TypeOffset == typeOffset && fontAt.Underline == underline)
					{
						return fontAt;
					}
				}
			}
			return null;
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x0005E7D0 File Offset: 0x0005C9D0
		public global::NPOI.SS.UserModel.IFont FindFont(bool bold, short color, short fontHeight, string name, bool italic, bool strikeout, global::NPOI.SS.UserModel.FontSuperScript typeOffset, global::NPOI.SS.UserModel.FontUnderlineType underline)
		{
			short numberOfFonts = this.NumberOfFonts;
			for (short num = 0; num <= numberOfFonts; num += 1)
			{
				if (num != 4)
				{
					global::NPOI.HSSF.UserModel.HSSFFont hssffont = this.GetFontAt(num) as global::NPOI.HSSF.UserModel.HSSFFont;
					if (hssffont.IsBold == bold && hssffont.Color == color && hssffont.FontHeight == (double)fontHeight && hssffont.FontName.Equals(name) && hssffont.IsItalic == italic && hssffont.IsStrikeout == strikeout && hssffont.TypeOffset == typeOffset && hssffont.Underline == underline)
					{
						return hssffont;
					}
				}
			}
			return null;
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x0005E858 File Offset: 0x0005CA58
		public short NumberOfFonts
		{
			get
			{
				return (short)this.workbook.NumberOfFontRecords;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x0005E866 File Offset: 0x0005CA66
		// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x0005E878 File Offset: 0x0005CA78
		public bool IsHidden
		{
			get
			{
				return this.workbook.WindowOne.Hidden;
			}
			set
			{
				this.workbook.WindowOne.Hidden = value;
			}
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x0005E88C File Offset: 0x0005CA8C
		public global::NPOI.SS.UserModel.IFont GetFontAt(short idx)
		{
			if (this.fonts == null)
			{
				this.fonts = new global::System.Collections.Generic.Dictionary<short, global::NPOI.HSSF.UserModel.HSSFFont>();
			}
			if (this.fonts.ContainsKey(idx))
			{
				return this.fonts[idx];
			}
			global::NPOI.HSSF.Record.FontRecord fontRecordAt = this.workbook.GetFontRecordAt((int)idx);
			global::NPOI.HSSF.UserModel.HSSFFont hssffont = new global::NPOI.HSSF.UserModel.HSSFFont(idx, fontRecordAt);
			this.fonts[idx] = hssffont;
			return hssffont;
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x0005E8EA File Offset: 0x0005CAEA
		public void ResetFontCache()
		{
			this.fonts = new global::System.Collections.Generic.Dictionary<short, global::NPOI.HSSF.UserModel.HSSFFont>();
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x0005E8F8 File Offset: 0x0005CAF8
		public global::NPOI.SS.UserModel.ICellStyle CreateCellStyle()
		{
			if (this.workbook.NumExFormats == 4030)
			{
				throw new global::System.InvalidOperationException("The maximum number of cell styles was exceeded. You can define up to 4000 styles in a .xls workbook");
			}
			global::NPOI.HSSF.Record.ExtendedFormatRecord rec = this.workbook.CreateCellXF();
			return new global::NPOI.HSSF.UserModel.HSSFCellStyle((short)(this.NumCellStyles - 1), rec, this);
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x0005E93E File Offset: 0x0005CB3E
		public int NumCellStyles
		{
			get
			{
				return this.workbook.NumExFormats;
			}
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0005E94C File Offset: 0x0005CB4C
		public global::NPOI.SS.UserModel.ICellStyle GetCellStyleAt(int idx)
		{
			global::NPOI.HSSF.Record.ExtendedFormatRecord exFormatAt = this.workbook.GetExFormatAt(idx);
			return new global::NPOI.HSSF.UserModel.HSSFCellStyle((short)idx, exFormatAt, this);
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x0005E96F File Offset: 0x0005CB6F
		public override void Close()
		{
			base.Close();
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x0005E978 File Offset: 0x0005CB78
		public override void Write()
		{
			base.ValidateInPlaceWritePossible();
			new global::NPOI.POIFS.FileSystem.NPOIFSDocument((global::NPOI.POIFS.FileSystem.DocumentNode)this.directory.GetEntry(global::NPOI.HSSF.UserModel.HSSFWorkbook.GetWorkbookDirEntryName(this.directory))).ReplaceContents(new global::NPOI.Util.ByteArrayInputStream(this.GetBytes()));
			base.WriteProperties();
			this.directory.FileSystem.WriteFileSystem();
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x0005E9D4 File Offset: 0x0005CBD4
		public override void Write(global::System.IO.FileInfo newFile)
		{
			global::NPOI.POIFS.FileSystem.POIFSFileSystem poifsfileSystem = global::NPOI.POIFS.FileSystem.POIFSFileSystem.Create(newFile);
			try
			{
				this.Write(poifsfileSystem);
				poifsfileSystem.WriteFileSystem();
			}
			finally
			{
				poifsfileSystem.Close();
			}
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x0005EA10 File Offset: 0x0005CC10
		public override void Write(global::System.IO.Stream stream)
		{
			global::NPOI.POIFS.FileSystem.NPOIFSFileSystem npoifsfileSystem = new global::NPOI.POIFS.FileSystem.NPOIFSFileSystem();
			try
			{
				this.Write(npoifsfileSystem);
				npoifsfileSystem.WriteFileSystem(stream);
			}
			finally
			{
				npoifsfileSystem.Close();
			}
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x0005EA4C File Offset: 0x0005CC4C
		private void Write(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>(1);
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(this.GetBytes()))
			{
				fs.CreateDocument(memoryStream, "Workbook");
				base.WriteProperties(fs, list);
				if (this.preserveNodes)
				{
					list.AddRange(global::NPOI.HSSF.Model.InternalWorkbook.WORKBOOK_DIR_ENTRY_NAMES);
					global::NPOI.POIFS.FileSystem.EntryUtils.CopyNodes(new global::NPOI.POIFS.FileSystem.FilteringDirectoryNode(this.directory, list), new global::NPOI.POIFS.FileSystem.FilteringDirectoryNode(fs.Root, list));
					fs.Root.StorageClsid = this.directory.StorageClsid;
				}
			}
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x0005EAE4 File Offset: 0x0005CCE4
		public byte[] GetBytes()
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFSheet> sheets = this.GetSheets();
			int count = sheets.Count;
			this.workbook.PreSerialize();
			foreach (global::NPOI.HSSF.UserModel.HSSFSheet hssfsheet in sheets)
			{
				hssfsheet.Sheet.Preserialize();
				hssfsheet.PreSerialize();
			}
			int num = this.workbook.Size;
			global::NPOI.HSSF.UserModel.HSSFWorkbook.SheetRecordCollector[] array = new global::NPOI.HSSF.UserModel.HSSFWorkbook.SheetRecordCollector[count];
			for (int i = 0; i < count; i++)
			{
				this.workbook.SetSheetBof(i, num);
				using (global::NPOI.HSSF.UserModel.HSSFWorkbook.SheetRecordCollector sheetRecordCollector = new global::NPOI.HSSF.UserModel.HSSFWorkbook.SheetRecordCollector())
				{
					sheets[i].Sheet.VisitContainedRecords(sheetRecordCollector, num);
					num += sheetRecordCollector.TotalSize;
					array[i] = sheetRecordCollector;
				}
			}
			byte[] array2 = new byte[num];
			int num2 = this.workbook.Serialize(0, array2);
			for (int j = 0; j < count; j++)
			{
				global::NPOI.HSSF.UserModel.HSSFWorkbook.SheetRecordCollector sheetRecordCollector2 = array[j];
				int num3 = sheetRecordCollector2.Serialize(num2, array2);
				if (num3 != sheetRecordCollector2.TotalSize)
				{
					throw new global::System.InvalidOperationException(string.Concat(new string[]
					{
						"Actual serialized sheet size (",
						num3.ToString(),
						") differs from pre-calculated size (",
						sheetRecordCollector2.TotalSize.ToString(),
						") for sheet (",
						j.ToString(),
						")"
					}));
				}
				num2 += num3;
				sheetRecordCollector2.Dispose();
			}
			return array2;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x0005EC80 File Offset: 0x0005CE80
		public void AddToolPack(global::NPOI.SS.Formula.UDF.UDFFinder toopack)
		{
			((global::NPOI.SS.Formula.UDF.AggregatingUDFFinder)this._udfFinder).Add(toopack);
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0005EC93 File Offset: 0x0005CE93
		internal global::NPOI.SS.Formula.UDF.UDFFinder GetUDFFinder()
		{
			return this._udfFinder;
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x0005EC9B File Offset: 0x0005CE9B
		public global::NPOI.HSSF.Model.InternalWorkbook Workbook
		{
			get
			{
				return this.workbook;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x0005ECA3 File Offset: 0x0005CEA3
		public int NumberOfNames
		{
			get
			{
				return this.names.Count;
			}
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x0005ECB0 File Offset: 0x0005CEB0
		public global::NPOI.SS.UserModel.IName GetName(string name)
		{
			int nameIndex = this.GetNameIndex(name);
			if (nameIndex < 0)
			{
				return null;
			}
			return this.names[nameIndex];
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x0005ECD8 File Offset: 0x0005CED8
		public global::System.Collections.Generic.IList<global::NPOI.SS.UserModel.IName> GetNames(string name)
		{
			global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IName> list = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IName>();
			foreach (global::NPOI.HSSF.UserModel.HSSFName hssfname in this.names)
			{
				if (hssfname.NameName.Equals(name))
				{
					list.Add(hssfname);
				}
			}
			return list;
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x0005ED40 File Offset: 0x0005CF40
		public global::NPOI.SS.UserModel.IName GetNameAt(int nameIndex)
		{
			int count = this.names.Count;
			if (count < 1)
			{
				throw new global::System.InvalidOperationException("There are no defined names in this workbook");
			}
			if (nameIndex < 0 || nameIndex > count)
			{
				throw new global::System.ArgumentOutOfRangeException(string.Concat(new string[]
				{
					"Specified name index ",
					nameIndex.ToString(),
					" is outside the allowable range (0..",
					(count - 1).ToString(),
					")."
				}));
			}
			return this.names[nameIndex];
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x0005EDBD File Offset: 0x0005CFBD
		public global::System.Collections.Generic.IList<global::NPOI.SS.UserModel.IName> GetAllNames()
		{
			global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IName> list = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IName>();
			list.AddRange(this.names);
			return list.AsReadOnly();
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x0005EDD5 File Offset: 0x0005CFD5
		public string GetNameName(int index)
		{
			return this.GetNameAt(index).NameName;
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x0005EDE3 File Offset: 0x0005CFE3
		public global::NPOI.HSSF.Record.NameRecord GetNameRecord(int nameIndex)
		{
			return this.Workbook.GetNameRecord(nameIndex);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x0005EDF4 File Offset: 0x0005CFF4
		public void SetPrintArea(int sheetIndex, string reference)
		{
			global::NPOI.HSSF.Record.NameRecord nameRecord = this.workbook.GetSpecificBuiltinRecord(6, sheetIndex + 1);
			if (nameRecord == null)
			{
				nameRecord = this.workbook.CreateBuiltInName(6, sheetIndex + 1);
			}
			string[] array = reference.Split(new char[]
			{
				','
			});
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(32);
			for (int i = 0; i < array.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(",");
				}
				global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, this.GetSheetName(sheetIndex));
				stringBuilder.Append("!");
				stringBuilder.Append(array[i]);
			}
			nameRecord.NameDefinition = global::NPOI.HSSF.Model.HSSFFormulaParser.Parse(stringBuilder.ToString(), this, global::NPOI.SS.Formula.FormulaType.NamedRange, sheetIndex);
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0005EE94 File Offset: 0x0005D094
		public void SetPrintArea(int sheetIndex, int startColumn, int endColumn, int startRow, int endRow)
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(startRow, startColumn, true, true);
			string text = cellReference.FormatAsString();
			cellReference = new global::NPOI.SS.Util.CellReference(endRow, endColumn, true, true);
			text = text + ":" + cellReference.FormatAsString();
			this.SetPrintArea(sheetIndex, text);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0005EED8 File Offset: 0x0005D0D8
		public string GetPrintArea(int sheetIndex)
		{
			global::NPOI.HSSF.Record.NameRecord specificBuiltinRecord = this.workbook.GetSpecificBuiltinRecord(6, sheetIndex + 1);
			if (specificBuiltinRecord == null)
			{
				return null;
			}
			return global::NPOI.HSSF.Model.HSSFFormulaParser.ToFormulaString(this, specificBuiltinRecord.NameDefinition);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0005EF06 File Offset: 0x0005D106
		public void RemovePrintArea(int sheetIndex)
		{
			this.Workbook.RemoveBuiltinRecord(6, sheetIndex + 1);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0005EF18 File Offset: 0x0005D118
		public global::NPOI.SS.UserModel.IName CreateName()
		{
			global::NPOI.HSSF.Record.NameRecord name = this.workbook.CreateName();
			global::NPOI.HSSF.UserModel.HSSFName hssfname = new global::NPOI.HSSF.UserModel.HSSFName(this, name);
			this.names.Add(hssfname);
			return hssfname;
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x0005EF48 File Offset: 0x0005D148
		public int GetNameIndex(string name)
		{
			int result = -1;
			for (int i = 0; i < this.names.Count; i++)
			{
				if (this.GetNameName(i).Equals(name, global::System.StringComparison.OrdinalIgnoreCase))
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x0005EF84 File Offset: 0x0005D184
		public int GetNameIndex(global::NPOI.HSSF.UserModel.HSSFName name)
		{
			for (int i = 0; i < this.names.Count; i++)
			{
				if (name == this.names[i])
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x0005EFB9 File Offset: 0x0005D1B9
		public void RemoveName(int index)
		{
			this.names.RemoveAt(index);
			this.workbook.RemoveName(index);
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x0005EFD3 File Offset: 0x0005D1D3
		public global::NPOI.SS.UserModel.IDataFormat CreateDataFormat()
		{
			if (this.formatter == null)
			{
				this.formatter = new global::NPOI.HSSF.UserModel.HSSFDataFormat(this.workbook);
			}
			return this.formatter;
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x0005EFF4 File Offset: 0x0005D1F4
		public void RemoveName(string name)
		{
			int nameIndex = this.GetNameIndex(name);
			this.RemoveName(nameIndex);
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x0005F010 File Offset: 0x0005D210
		public void RemoveName(global::NPOI.SS.UserModel.IName name)
		{
			int nameIndex = this.GetNameIndex((global::NPOI.HSSF.UserModel.HSSFName)name);
			this.RemoveName(nameIndex);
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x0005F031 File Offset: 0x0005D231
		public global::NPOI.HSSF.UserModel.HSSFPalette GetCustomPalette()
		{
			return new global::NPOI.HSSF.UserModel.HSSFPalette(this.workbook.CustomPalette);
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x0005F044 File Offset: 0x0005D244
		public void DumpDrawingGroupRecords(bool fat)
		{
			global::NPOI.HSSF.Record.DrawingGroupRecord drawingGroupRecord = (global::NPOI.HSSF.Record.DrawingGroupRecord)this.workbook.FindFirstRecordBySid(235);
			drawingGroupRecord.Decode();
			foreach (object obj in ((global::System.Collections.IEnumerable)drawingGroupRecord.EscherRecords))
			{
				global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
				if (fat)
				{
					global::System.Console.WriteLine(escherRecord.ToString());
				}
				else
				{
					escherRecord.Display(0);
				}
			}
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x0005F0C8 File Offset: 0x0005D2C8
		internal void InitDrawings()
		{
			if (this.workbook.FindDrawingGroup() != null)
			{
				using (global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFSheet>.Enumerator enumerator = this._sheets.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::NPOI.HSSF.UserModel.HSSFSheet hssfsheet = enumerator.Current;
						global::NPOI.SS.UserModel.IDrawing drawingPatriarch = hssfsheet.DrawingPatriarch;
					}
					return;
				}
			}
			this.workbook.CreateDrawingGroup();
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0005F134 File Offset: 0x0005D334
		public int AddPicture(byte[] pictureData, global::NPOI.SS.UserModel.PictureType format)
		{
			this.InitDrawings();
			byte[] uid;
			using (global::System.Security.Cryptography.MD5 md = global::System.Security.Cryptography.MD5.Create())
			{
				uid = md.ComputeHash(pictureData);
			}
			global::NPOI.DDF.EscherBlipRecord escherBlipRecord2;
			int size;
			short tag;
			if (format != global::NPOI.SS.UserModel.PictureType.EMF)
			{
				if (format == global::NPOI.SS.UserModel.PictureType.WMF)
				{
					if (global::NPOI.Util.LittleEndian.GetInt(pictureData) == -1698247209)
					{
						byte[] array = new byte[pictureData.Length - 22];
						global::System.Array.Copy(pictureData, 22, array, 0, pictureData.Length - 22);
						pictureData = array;
					}
					global::NPOI.DDF.EscherBlipRecord escherBlipRecord = escherBlipRecord2 = new global::NPOI.DDF.EscherMetafileBlip();
					escherBlipRecord.UID = uid;
					escherBlipRecord.SetPictureData(pictureData);
					escherBlipRecord.Filter = 254;
					size = escherBlipRecord.CompressedSize + 58;
					tag = 0;
				}
				else
				{
					global::NPOI.DDF.EscherBlipRecord escherBlipRecord3 = escherBlipRecord2 = new global::NPOI.DDF.EscherBitmapBlip();
					escherBlipRecord3.UID = uid;
					escherBlipRecord3.Marker = byte.MaxValue;
					escherBlipRecord3.PictureData = pictureData;
					size = pictureData.Length + 25;
					tag = 255;
				}
			}
			else
			{
				global::NPOI.DDF.EscherBlipRecord escherBlipRecord4 = escherBlipRecord2 = new global::NPOI.DDF.EscherMetafileBlip();
				escherBlipRecord4.UID = uid;
				escherBlipRecord4.SetPictureData(pictureData);
				escherBlipRecord4.Filter = 254;
				size = escherBlipRecord4.CompressedSize + 58;
				tag = 0;
			}
			escherBlipRecord2.RecordId = (short)(-4072 + format);
			switch (format)
			{
			case global::NPOI.SS.UserModel.PictureType.EMF:
				escherBlipRecord2.Options = 15680;
				break;
			case global::NPOI.SS.UserModel.PictureType.WMF:
				escherBlipRecord2.Options = 8544;
				break;
			case global::NPOI.SS.UserModel.PictureType.PICT:
				escherBlipRecord2.Options = 21536;
				break;
			case global::NPOI.SS.UserModel.PictureType.JPEG:
				escherBlipRecord2.Options = 18080;
				break;
			case global::NPOI.SS.UserModel.PictureType.PNG:
				escherBlipRecord2.Options = 28160;
				break;
			case global::NPOI.SS.UserModel.PictureType.DIB:
				escherBlipRecord2.Options = 31360;
				break;
			default:
				throw new global::System.InvalidOperationException("Unexpected picture format: " + format.ToString());
			}
			global::NPOI.DDF.EscherBSERecord escherBSERecord = new global::NPOI.DDF.EscherBSERecord();
			escherBSERecord.RecordId = -4089;
			escherBSERecord.Options = (short)(global::NPOI.SS.UserModel.PictureType.EMF | format << 4);
			escherBSERecord.BlipTypeMacOS = (byte)format;
			escherBSERecord.BlipTypeWin32 = (byte)format;
			escherBSERecord.UID = uid;
			escherBSERecord.Tag = tag;
			escherBSERecord.Size = size;
			escherBSERecord.Ref = 0;
			escherBSERecord.Offset = 0;
			escherBSERecord.BlipRecord = escherBlipRecord2;
			return this.workbook.AddBSERecord(escherBSERecord);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0005F340 File Offset: 0x0005D540
		public global::System.Collections.IList GetAllPictures()
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFPictureData> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFPictureData>();
			foreach (object obj in this.workbook.Records)
			{
				global::NPOI.HSSF.Record.Record record = (global::NPOI.HSSF.Record.Record)obj;
				if (record is global::NPOI.HSSF.Record.AbstractEscherHolderRecord)
				{
					((global::NPOI.HSSF.Record.AbstractEscherHolderRecord)record).Decode();
					global::System.Collections.IList escherRecords = ((global::NPOI.HSSF.Record.AbstractEscherHolderRecord)record).EscherRecords;
					this.SearchForPictures(escherRecords, list);
				}
			}
			return list;
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0005F3C8 File Offset: 0x0005D5C8
		private void SearchForPictures(global::System.Collections.IList escherRecords, global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFPictureData> pictures)
		{
			foreach (object obj in escherRecords)
			{
				if (obj is global::NPOI.DDF.EscherRecord)
				{
					global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
					if (escherRecord is global::NPOI.DDF.EscherBSERecord)
					{
						global::NPOI.DDF.EscherBlipRecord blipRecord = ((global::NPOI.DDF.EscherBSERecord)escherRecord).BlipRecord;
						if (blipRecord != null)
						{
							pictures.Add(new global::NPOI.HSSF.UserModel.HSSFPictureData(blipRecord));
						}
					}
					this.SearchForPictures(escherRecord.ChildRecords, pictures);
				}
			}
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0005F42C File Offset: 0x0005D62C
		protected static global::System.Collections.Generic.Dictionary<string, global::NPOI.Util.ClassID> GetOleMap()
		{
			global::System.Collections.Generic.Dictionary<string, global::NPOI.Util.ClassID> dictionary = new global::System.Collections.Generic.Dictionary<string, global::NPOI.Util.ClassID>();
			dictionary.Add("PowerPoint Document", global::NPOI.Util.ClassID.PPT_SHOW);
			foreach (string key in global::NPOI.HSSF.Model.InternalWorkbook.WORKBOOK_DIR_ENTRY_NAMES)
			{
				dictionary.Add(key, global::NPOI.Util.ClassID.XLS_WORKBOOK);
			}
			return dictionary;
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x0005F474 File Offset: 0x0005D674
		public int AddOlePackage(global::NPOI.POIFS.FileSystem.POIFSFileSystem poiData, string label, string fileName, string command)
		{
			global::NPOI.POIFS.FileSystem.DirectoryNode root = poiData.Root;
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::NPOI.Util.ClassID> keyValuePair in global::NPOI.HSSF.UserModel.HSSFWorkbook.GetOleMap())
			{
				if (root.HasEntry(keyValuePair.Key))
				{
					root.StorageClsid = keyValuePair.Value;
					break;
				}
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			poiData.WriteFileSystem(memoryStream);
			return this.AddOlePackage(memoryStream.ToArray(), label, fileName, command);
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x0005F504 File Offset: 0x0005D704
		public int AddOlePackage(byte[] oleData, string label, string fileName, string command)
		{
			if (this.directory == null)
			{
				this.directory = new global::NPOI.POIFS.FileSystem.POIFSFileSystem().Root;
				this.preserveNodes = true;
			}
			int num = 0;
			global::NPOI.POIFS.FileSystem.DirectoryEntry directoryEntry = null;
			do
			{
				string name = "MBD" + global::NPOI.Util.HexDump.ToHex(++num);
				if (!this.directory.HasEntry(name))
				{
					directoryEntry = this.directory.CreateDirectory(name);
					directoryEntry.StorageClsid = global::NPOI.Util.ClassID.OLE10_PACKAGE;
				}
			}
			while (directoryEntry == null);
			byte[] array = new byte[20];
			array[0] = 1;
			array[3] = 2;
			byte[] buffer = array;
			directoryEntry.CreateDocument("\u0001Ole", new global::System.IO.MemoryStream(buffer));
			global::NPOI.POIFS.FileSystem.Ole10Native ole10Native = new global::NPOI.POIFS.FileSystem.Ole10Native(label, fileName, command, oleData);
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			ole10Native.WriteOut(memoryStream);
			directoryEntry.CreateDocument(global::NPOI.POIFS.FileSystem.Ole10Native.OLE10_NATIVE, new global::System.IO.MemoryStream(memoryStream.ToArray()));
			return num;
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x0005F5C5 File Offset: 0x0005D7C5
		public int LinkExternalWorkbook(string name, global::NPOI.SS.UserModel.IWorkbook workbook)
		{
			return this.workbook.LinkExternalWorkbook(name, workbook);
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x0005F5D4 File Offset: 0x0005D7D4
		public bool IsWriteProtected
		{
			get
			{
				return this.workbook.IsWriteProtected;
			}
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x0005F5E1 File Offset: 0x0005D7E1
		public void WriteProtectWorkbook(string password, string username)
		{
			this.workbook.WriteProtectWorkbook(password, username);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x0005F5F0 File Offset: 0x0005D7F0
		public void UnwriteProtectWorkbook()
		{
			this.workbook.UnwriteProtectWorkbook();
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x0005F600 File Offset: 0x0005D800
		public global::System.Collections.Generic.IList<global::NPOI.HSSF.UserModel.HSSFObjectData> GetAllEmbeddedObjects()
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFObjectData> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFObjectData>();
			foreach (global::NPOI.HSSF.UserModel.HSSFSheet sheet in this._sheets)
			{
				this.GetAllEmbeddedObjects(sheet, list);
			}
			return list;
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x0005F65C File Offset: 0x0005D85C
		private void GetAllEmbeddedObjects(global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFObjectData> objects)
		{
			global::NPOI.HSSF.UserModel.HSSFPatriarch hssfpatriarch = sheet.DrawingPatriarch as global::NPOI.HSSF.UserModel.HSSFPatriarch;
			if (hssfpatriarch == null)
			{
				return;
			}
			this.GetAllEmbeddedObjects(hssfpatriarch, objects);
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x0005F684 File Offset: 0x0005D884
		private void GetAllEmbeddedObjects(global::NPOI.HSSF.UserModel.HSSFShapeContainer parent, global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFObjectData> objects)
		{
			foreach (global::NPOI.HSSF.UserModel.HSSFShape hssfshape in parent.Children)
			{
				if (hssfshape is global::NPOI.HSSF.UserModel.HSSFObjectData)
				{
					objects.Add((global::NPOI.HSSF.UserModel.HSSFObjectData)hssfshape);
				}
				else if (hssfshape is global::NPOI.HSSF.UserModel.HSSFShapeContainer)
				{
					this.GetAllEmbeddedObjects((global::NPOI.HSSF.UserModel.HSSFShapeContainer)hssfshape, objects);
				}
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x0005F6F8 File Offset: 0x0005D8F8
		public byte[] NewUID
		{
			get
			{
				return new byte[16];
			}
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x0005F701 File Offset: 0x0005D901
		public global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ISheet> GetEnumerator()
		{
			return this._sheets.GetEnumerator();
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x0005F728 File Offset: 0x0005D928
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x0005F713 File Offset: 0x0005D913
		public bool ForceFormulaRecalculation
		{
			get
			{
				global::NPOI.HSSF.Record.RecalcIdRecord recalcIdRecord = (global::NPOI.HSSF.Record.RecalcIdRecord)this.Workbook.FindFirstRecordBySid(449);
				return recalcIdRecord != null && recalcIdRecord.EngineId != 0;
			}
			set
			{
				this.Workbook.RecalcId.EngineId = 0;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x0005EC9B File Offset: 0x0005CE9B
		public global::NPOI.HSSF.Model.InternalWorkbook InternalWorkbook
		{
			get
			{
				return this.workbook;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x000551CB File Offset: 0x000533CB
		public global::NPOI.SS.SpreadsheetVersion SpreadsheetVersion
		{
			get
			{
				return global::NPOI.SS.SpreadsheetVersion.EXCEL97;
			}
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x0005F759 File Offset: 0x0005D959
		public bool ChangeExternalReference(string oldUrl, string newUrl)
		{
			return this.workbook.ChangeExternalReference(oldUrl, newUrl);
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000024A0 File Offset: 0x000006A0
		public global::NPOI.POIFS.FileSystem.DirectoryNode RootDirectory
		{
			get
			{
				return this.directory;
			}
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00008C75 File Offset: 0x00006E75
		public int IndexOf(global::NPOI.SS.UserModel.ISheet item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x0005F768 File Offset: 0x0005D968
		public void Insert(int index, global::NPOI.SS.UserModel.ISheet item)
		{
			this._sheets.Insert(index, (global::NPOI.HSSF.UserModel.HSSFSheet)item);
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x0005F77C File Offset: 0x0005D97C
		public void RemoveAt(int index)
		{
			this._sheets.RemoveAt(index);
		}

		// Token: 0x1700068E RID: 1678
		public global::NPOI.SS.UserModel.ISheet this[int index]
		{
			get
			{
				return this.GetSheetAt(index);
			}
			set
			{
				if (this._sheets[index] != null)
				{
					this._sheets[index] = (global::NPOI.HSSF.UserModel.HSSFSheet)value;
					return;
				}
				this._sheets.Insert(index, (global::NPOI.HSSF.UserModel.HSSFSheet)value);
			}
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x0005F7C8 File Offset: 0x0005D9C8
		public void Add(global::NPOI.SS.UserModel.ISheet item)
		{
			this._sheets.Add((global::NPOI.HSSF.UserModel.HSSFSheet)item);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x0005F7DB File Offset: 0x0005D9DB
		public void Clear()
		{
			this._sheets.Clear();
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00008C75 File Offset: 0x00006E75
		public bool Contains(global::NPOI.SS.UserModel.ISheet item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00008C75 File Offset: 0x00006E75
		public void CopyTo(global::NPOI.SS.UserModel.ISheet[] array, int arrayIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x0005F7E8 File Offset: 0x0005D9E8
		public int Count
		{
			get
			{
				return this.NumberOfSheets;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00008C75 File Offset: 0x00006E75
		public bool IsReadOnly
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x0005F7F0 File Offset: 0x0005D9F0
		public bool Remove(global::NPOI.SS.UserModel.ISheet item)
		{
			return this._sheets.Remove((global::NPOI.HSSF.UserModel.HSSFSheet)item);
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x0005F803 File Offset: 0x0005DA03
		public bool IsDate1904()
		{
			return this.Workbook.IsUsing1904DateWindowing;
		}

		// Token: 0x04000BBB RID: 3003
		private const int MAX_STYLES = 4030;

		// Token: 0x04000BBC RID: 3004
		public const int INITIAL_CAPACITY = 3;

		// Token: 0x04000BBD RID: 3005
		private global::NPOI.HSSF.Model.InternalWorkbook workbook;

		// Token: 0x04000BBE RID: 3006
		protected global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFSheet> _sheets;

		// Token: 0x04000BBF RID: 3007
		private global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HSSFName> names;

		// Token: 0x04000BC0 RID: 3008
		private bool preserveNodes;

		// Token: 0x04000BC1 RID: 3009
		private global::NPOI.HSSF.UserModel.HSSFDataFormat formatter;

		// Token: 0x04000BC2 RID: 3010
		private global::System.Collections.Generic.Dictionary<short, global::NPOI.HSSF.UserModel.HSSFFont> fonts;

		// Token: 0x04000BC3 RID: 3011
		[global::System.NonSerialized]
		private global::NPOI.SS.UserModel.MissingCellPolicy missingCellPolicy;

		// Token: 0x04000BC4 RID: 3012
		public const byte ENCODING_COMPRESSED_UNICODE = 0;

		// Token: 0x04000BC5 RID: 3013
		public const byte ENCODING_UTF_16 = 1;

		// Token: 0x04000BC6 RID: 3014
		[global::System.NonSerialized]
		private global::NPOI.SS.Formula.UDF.UDFFinder _udfFinder;

		// Token: 0x02000606 RID: 1542
		private class SheetRecordCollector : global::NPOI.HSSF.Record.Aggregates.RecordVisitor, global::System.IDisposable
		{
			// Token: 0x06003646 RID: 13894 RVA: 0x000A5DDB File Offset: 0x000A3FDB
			public SheetRecordCollector()
			{
				this._totalSize = 0;
				this._list = new global::System.Collections.ArrayList(128);
			}

			// Token: 0x17000E13 RID: 3603
			// (get) Token: 0x06003647 RID: 13895 RVA: 0x000A5DFA File Offset: 0x000A3FFA
			public int TotalSize
			{
				get
				{
					return this._totalSize;
				}
			}

			// Token: 0x06003648 RID: 13896 RVA: 0x000A5E02 File Offset: 0x000A4002
			public void VisitRecord(global::NPOI.HSSF.Record.Record r)
			{
				this._list.Add(r);
				this._totalSize += r.RecordSize;
			}

			// Token: 0x06003649 RID: 13897 RVA: 0x000A5E24 File Offset: 0x000A4024
			public int Serialize(int offset, byte[] data)
			{
				int num = 0;
				int count = this._list.Count;
				foreach (object obj in this._list)
				{
					global::NPOI.HSSF.Record.Record record = (global::NPOI.HSSF.Record.Record)obj;
					num += record.Serialize(offset + num, data);
				}
				return num;
			}

			// Token: 0x0600364A RID: 13898 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void Dispose()
			{
			}

			// Token: 0x04001A4E RID: 6734
			private global::System.Collections.ArrayList _list;

			// Token: 0x04001A4F RID: 6735
			private int _totalSize;
		}
	}
}
