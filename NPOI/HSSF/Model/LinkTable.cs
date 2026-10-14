using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NPOI.HSSF.Record;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Model
{
	// Token: 0x02000332 RID: 818
	public class LinkTable
	{
		// Token: 0x0600173B RID: 5947 RVA: 0x00045408 File Offset: 0x00043608
		private static global::NPOI.HSSF.Record.ExternSheetRecord ReadExtSheetRecord(global::NPOI.HSSF.Model.RecordStream rs)
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ExternSheetRecord> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ExternSheetRecord>(2);
			while (rs.PeekNextClass() == typeof(global::NPOI.HSSF.Record.ExternSheetRecord))
			{
				list.Add((global::NPOI.HSSF.Record.ExternSheetRecord)rs.GetNext());
			}
			int count = list.Count;
			if (count < 1)
			{
				throw new global::System.Exception("Expected an EXTERNSHEET record but got (" + rs.PeekNextClass().Name + ")");
			}
			if (count == 1)
			{
				return list[0];
			}
			new global::NPOI.HSSF.Record.ExternSheetRecord[count];
			return global::NPOI.HSSF.Record.ExternSheetRecord.Combine(list.ToArray());
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00045490 File Offset: 0x00043690
		public LinkTable(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> inputList, int startIndex, global::NPOI.HSSF.Model.WorkbookRecordList workbookRecordList, global::System.Collections.Generic.Dictionary<string, global::NPOI.HSSF.Record.NameCommentRecord> commentRecords)
		{
			this._workbookRecordList = workbookRecordList;
			global::NPOI.HSSF.Model.RecordStream recordStream = new global::NPOI.HSSF.Model.RecordStream(inputList, startIndex);
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			while (recordStream.PeekNextClass() == typeof(global::NPOI.HSSF.Record.SupBookRecord))
			{
				arrayList.Add(new global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock(recordStream));
			}
			this._externalBookBlocks = (global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock[])arrayList.ToArray(typeof(global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock));
			arrayList.Clear();
			if (this._externalBookBlocks.Length != 0)
			{
				if (recordStream.PeekNextClass() != typeof(global::NPOI.HSSF.Record.ExternSheetRecord))
				{
					this._externSheetRecord = null;
				}
				else
				{
					this._externSheetRecord = global::NPOI.HSSF.Model.LinkTable.ReadExtSheetRecord(recordStream);
				}
			}
			else
			{
				this._externSheetRecord = null;
			}
			this._definedNames = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.NameRecord>();
			for (;;)
			{
				global::System.Type left = recordStream.PeekNextClass();
				if (left == typeof(global::NPOI.HSSF.Record.NameRecord))
				{
					global::NPOI.HSSF.Record.NameRecord item = (global::NPOI.HSSF.Record.NameRecord)recordStream.GetNext();
					this._definedNames.Add(item);
				}
				else
				{
					if (!(left == typeof(global::NPOI.HSSF.Record.NameCommentRecord)))
					{
						break;
					}
					global::NPOI.HSSF.Record.NameCommentRecord nameCommentRecord = (global::NPOI.HSSF.Record.NameCommentRecord)recordStream.GetNext();
					commentRecords[nameCommentRecord.NameText] = nameCommentRecord;
				}
			}
			this._recordCount = recordStream.GetCountRead();
			for (int i = startIndex; i < startIndex + this._recordCount; i++)
			{
				this._workbookRecordList.Records.Add(inputList[i]);
			}
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x000455E8 File Offset: 0x000437E8
		public LinkTable(int numberOfSheets, global::NPOI.HSSF.Model.WorkbookRecordList workbookRecordList)
		{
			this._workbookRecordList = workbookRecordList;
			this._definedNames = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.NameRecord>();
			this._externalBookBlocks = new global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock[]
			{
				new global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock(numberOfSheets)
			};
			this._externSheetRecord = new global::NPOI.HSSF.Record.ExternSheetRecord();
			this._recordCount = 2;
			global::NPOI.HSSF.Record.SupBookRecord externalBookRecord = this._externalBookBlocks[0].GetExternalBookRecord();
			int num = this.FindFirstRecordLocBySid(140);
			if (num < 0)
			{
				throw new global::System.Exception("CountryRecord not found");
			}
			this._workbookRecordList.Add(num + 1, this._externSheetRecord);
			this._workbookRecordList.Add(num + 1, externalBookRecord);
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x00045680 File Offset: 0x00043880
		public int RecordCount
		{
			get
			{
				return this._recordCount;
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00045688 File Offset: 0x00043888
		public global::NPOI.HSSF.Record.NameRecord GetSpecificBuiltinRecord(byte builtInCode, int sheetNumber)
		{
			foreach (global::NPOI.HSSF.Record.NameRecord nameRecord in this._definedNames)
			{
				if (nameRecord.BuiltInName == builtInCode && nameRecord.SheetNumber == sheetNumber)
				{
					return nameRecord;
				}
			}
			return null;
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x000456CC File Offset: 0x000438CC
		public void RemoveBuiltinRecord(byte name, int sheetIndex)
		{
			global::NPOI.HSSF.Record.NameRecord specificBuiltinRecord = this.GetSpecificBuiltinRecord(name, sheetIndex);
			if (specificBuiltinRecord != null)
			{
				this._definedNames.Remove(specificBuiltinRecord);
			}
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x000456F2 File Offset: 0x000438F2
		public int GetFirstInternalSheetIndexForExtIndex(int extRefIndex)
		{
			if (extRefIndex >= this._externSheetRecord.NumOfRefs || extRefIndex < 0)
			{
				return -1;
			}
			return this._externSheetRecord.GetFirstSheetIndexFromRefIndex(extRefIndex);
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00045714 File Offset: 0x00043914
		public int GetLastInternalSheetIndexForExtIndex(int extRefIndex)
		{
			if (extRefIndex >= this._externSheetRecord.NumOfRefs || extRefIndex < 0)
			{
				return -1;
			}
			return this._externSheetRecord.GetLastSheetIndexFromRefIndex(extRefIndex);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00045736 File Offset: 0x00043936
		public void RemoveSheet(int sheetIdx)
		{
			this._externSheetRecord.RemoveSheet(sheetIdx);
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00045744 File Offset: 0x00043944
		public int NumNames
		{
			get
			{
				return this._definedNames.Count;
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00045754 File Offset: 0x00043954
		private int ExtendExternalBookBlocks(global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock newBlock)
		{
			global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock[] array = new global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock[this._externalBookBlocks.Length + 1];
			global::System.Array.Copy(this._externalBookBlocks, 0, array, 0, this._externalBookBlocks.Length);
			array[array.Length - 1] = newBlock;
			this._externalBookBlocks = array;
			return this._externalBookBlocks.Length - 1;
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x000457A0 File Offset: 0x000439A0
		private int FindRefIndexFromExtBookIndex(int extBookIndex)
		{
			return this._externSheetRecord.FindRefIndexFromExtBookIndex(extBookIndex);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x000457B0 File Offset: 0x000439B0
		public global::NPOI.SS.Formula.PTG.NameXPtg GetNameXPtg(string name, int sheetRefIndex)
		{
			for (int i = 0; i < this._externalBookBlocks.Length; i++)
			{
				int indexOfName = this._externalBookBlocks[i].GetIndexOfName(name);
				if (indexOfName >= 0)
				{
					int num = this.FindRefIndexFromExtBookIndex(i);
					if (num >= 0 && (sheetRefIndex == -1 || num == sheetRefIndex))
					{
						return new global::NPOI.SS.Formula.PTG.NameXPtg(num, indexOfName);
					}
				}
			}
			return null;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00045800 File Offset: 0x00043A00
		public global::NPOI.HSSF.Record.NameRecord GetNameRecord(int index)
		{
			return this._definedNames[index];
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00045810 File Offset: 0x00043A10
		public void AddName(global::NPOI.HSSF.Record.NameRecord name)
		{
			this._definedNames.Add(name);
			int num = this.FindFirstRecordLocBySid(23);
			if (num == -1)
			{
				num = this.FindFirstRecordLocBySid(430);
			}
			if (num == -1)
			{
				num = this.FindFirstRecordLocBySid(140);
			}
			int count = this._definedNames.Count;
			this._workbookRecordList.Add(num + count, name);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00045870 File Offset: 0x00043A70
		public global::NPOI.SS.Formula.PTG.NameXPtg AddNameXPtg(string name)
		{
			int externalBookIndex = -1;
			global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock externalBookBlock = null;
			for (int i = 0; i < this._externalBookBlocks.Length; i++)
			{
				if (this._externalBookBlocks[i].GetExternalBookRecord().IsAddInFunctions)
				{
					externalBookBlock = this._externalBookBlocks[i];
					externalBookIndex = i;
					break;
				}
			}
			if (externalBookBlock == null)
			{
				externalBookBlock = new global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock();
				externalBookIndex = this.ExtendExternalBookBlocks(externalBookBlock);
				int pos = this.FindFirstRecordLocBySid(23);
				this._workbookRecordList.Add(pos, externalBookBlock.GetExternalBookRecord());
				this._externSheetRecord.AddRef(this._externalBookBlocks.Length - 1, -2, -2);
			}
			global::NPOI.HSSF.Record.ExternalNameRecord externalNameRecord = new global::NPOI.HSSF.Record.ExternalNameRecord();
			externalNameRecord.Text = name;
			externalNameRecord.SetParsedExpression(new global::NPOI.SS.Formula.PTG.Ptg[]
			{
				global::NPOI.SS.Formula.PTG.ErrPtg.REF_INVALID
			});
			int nameIndex = externalBookBlock.AddExternalName(externalNameRecord);
			int num = 0;
			foreach (object obj in this._workbookRecordList)
			{
				global::NPOI.HSSF.Record.Record record = (global::NPOI.HSSF.Record.Record)obj;
				if (record is global::NPOI.HSSF.Record.SupBookRecord && ((global::NPOI.HSSF.Record.SupBookRecord)record).IsAddInFunctions)
				{
					break;
				}
				num++;
			}
			int numberOfNames = externalBookBlock.NumberOfNames;
			this._workbookRecordList.Add(num + numberOfNames, externalNameRecord);
			int num2 = -2;
			return new global::NPOI.SS.Formula.PTG.NameXPtg(this._externSheetRecord.GetRefIxForSheet(externalBookIndex, num2, num2), nameIndex);
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x000459A6 File Offset: 0x00043BA6
		public void RemoveName(int namenum)
		{
			this._definedNames.RemoveAt(namenum);
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x000459B4 File Offset: 0x00043BB4
		private static int GetSheetIndex(string[] sheetNames, string sheetName)
		{
			for (int i = 0; i < sheetNames.Length; i++)
			{
				if (sheetNames[i].Equals(sheetName))
				{
					return i;
				}
			}
			throw new global::System.InvalidOperationException("External workbook does not contain sheet '" + sheetName + "'");
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x000459F4 File Offset: 0x00043BF4
		private int GetExternalWorkbookIndex(string workbookName)
		{
			for (int i = 0; i < this._externalBookBlocks.Length; i++)
			{
				global::NPOI.HSSF.Record.SupBookRecord externalBookRecord = this._externalBookBlocks[i].GetExternalBookRecord();
				if (externalBookRecord.IsExternalReferences && workbookName.Equals(externalBookRecord.URL))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00045A3C File Offset: 0x00043C3C
		public int LinkExternalWorkbook(string name, global::NPOI.SS.UserModel.IWorkbook externalWorkbook)
		{
			int num = this.GetExternalWorkbookIndex(name);
			if (num != -1)
			{
				return num;
			}
			string[] array = new string[externalWorkbook.NumberOfSheets];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = externalWorkbook.GetSheetName(i);
			}
			global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock externalBookBlock = new global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock("\0" + name, array);
			num = this.ExtendExternalBookBlocks(externalBookBlock);
			int num2 = this.FindFirstRecordLocBySid(23);
			if (num2 == -1)
			{
				num2 = this._workbookRecordList.Count;
			}
			this._workbookRecordList.Add(num2, externalBookBlock.GetExternalBookRecord());
			for (int j = 0; j < array.Length; j++)
			{
				this._externSheetRecord.AddRef(num, j, j);
			}
			return num;
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00045AEC File Offset: 0x00043CEC
		public int GetExternalSheetIndex(string workbookName, string firstSheetName, string lastSheetName)
		{
			int externalWorkbookIndex = this.GetExternalWorkbookIndex(workbookName);
			if (externalWorkbookIndex == -1)
			{
				throw new global::NPOI.Util.RuntimeException("No external workbook with name '" + workbookName + "'");
			}
			global::NPOI.HSSF.Record.SupBookRecord externalBookRecord = this._externalBookBlocks[externalWorkbookIndex].GetExternalBookRecord();
			int sheetIndex = global::NPOI.HSSF.Model.LinkTable.GetSheetIndex(externalBookRecord.SheetNames, firstSheetName);
			int sheetIndex2 = global::NPOI.HSSF.Model.LinkTable.GetSheetIndex(externalBookRecord.SheetNames, lastSheetName);
			int num = this._externSheetRecord.GetRefIxForSheet(externalWorkbookIndex, sheetIndex, sheetIndex2);
			if (num < 0)
			{
				num = this._externSheetRecord.AddRef(externalWorkbookIndex, sheetIndex, sheetIndex2);
			}
			return num;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00045B64 File Offset: 0x00043D64
		public string[] GetExternalBookAndSheetName(int extRefIndex)
		{
			int extbookIndexFromRefIndex = this._externSheetRecord.GetExtbookIndexFromRefIndex(extRefIndex);
			global::NPOI.HSSF.Record.SupBookRecord externalBookRecord = this._externalBookBlocks[extbookIndexFromRefIndex].GetExternalBookRecord();
			if (!externalBookRecord.IsExternalReferences)
			{
				return null;
			}
			int firstSheetIndexFromRefIndex = this._externSheetRecord.GetFirstSheetIndexFromRefIndex(extRefIndex);
			int lastSheetIndexFromRefIndex = this._externSheetRecord.GetLastSheetIndexFromRefIndex(extRefIndex);
			string text = null;
			string text2 = null;
			if (firstSheetIndexFromRefIndex >= 0)
			{
				text = externalBookRecord.SheetNames[firstSheetIndexFromRefIndex];
			}
			if (lastSheetIndexFromRefIndex >= 0)
			{
				text2 = externalBookRecord.SheetNames[lastSheetIndexFromRefIndex];
			}
			if (firstSheetIndexFromRefIndex == lastSheetIndexFromRefIndex)
			{
				return new string[]
				{
					externalBookRecord.URL,
					text
				};
			}
			return new string[]
			{
				externalBookRecord.URL,
				text,
				text2
			};
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00045C04 File Offset: 0x00043E04
		public int CheckExternSheet(int sheetIndex)
		{
			return this.CheckExternSheet(sheetIndex, sheetIndex);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00045C10 File Offset: 0x00043E10
		public int CheckExternSheet(int firstSheetIndex, int lastSheetIndex)
		{
			int num = -1;
			for (int i = 0; i < this._externalBookBlocks.Length; i++)
			{
				if (this._externalBookBlocks[i].GetExternalBookRecord().IsInternalReferences)
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				throw new global::System.InvalidOperationException("Could not find 'internal references' EXTERNALBOOK");
			}
			int refIxForSheet = this._externSheetRecord.GetRefIxForSheet(num, firstSheetIndex, lastSheetIndex);
			if (refIxForSheet >= 0)
			{
				return refIxForSheet;
			}
			return this._externSheetRecord.AddRef(num, firstSheetIndex, lastSheetIndex);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00045C7C File Offset: 0x00043E7C
		private int FindFirstRecordLocBySid(short sid)
		{
			int num = 0;
			global::System.Collections.Generic.IEnumerator<global::NPOI.HSSF.Record.Record> enumerator = this._workbookRecordList.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Sid == sid)
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00045CB8 File Offset: 0x00043EB8
		public string ResolveNameXText(int refIndex, int definedNameIndex, global::NPOI.HSSF.Model.InternalWorkbook workbook)
		{
			int extbookIndexFromRefIndex = this._externSheetRecord.GetExtbookIndexFromRefIndex(refIndex);
			int firstSheetIndexFromRefIndex = this._externSheetRecord.GetFirstSheetIndexFromRefIndex(refIndex);
			if (firstSheetIndexFromRefIndex == -1)
			{
				throw new global::NPOI.Util.RuntimeException("Referenced sheet could not be found");
			}
			if (this._externalBookBlocks[extbookIndexFromRefIndex]._externalNameRecords.Length > definedNameIndex)
			{
				return this._externalBookBlocks[extbookIndexFromRefIndex].GetNameText(definedNameIndex);
			}
			if (firstSheetIndexFromRefIndex == -2)
			{
				global::NPOI.HSSF.Record.NameRecord nameRecord = this.GetNameRecord(definedNameIndex);
				int sheetNumber = nameRecord.SheetNumber;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				if (sheetNumber > 0)
				{
					string sheetName = workbook.GetSheetName(sheetNumber - 1);
					global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, sheetName);
					stringBuilder.Append("!");
				}
				stringBuilder.Append(nameRecord.NameText);
				return stringBuilder.ToString();
			}
			throw new global::System.IndexOutOfRangeException("Ext Book Index relative but beyond the supported length, was " + extbookIndexFromRefIndex.ToString() + " but maximum is " + this._externalBookBlocks.Length.ToString());
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00045D94 File Offset: 0x00043F94
		public int ResolveNameXIx(int refIndex, int definedNameIndex)
		{
			int extbookIndexFromRefIndex = this._externSheetRecord.GetExtbookIndexFromRefIndex(refIndex);
			return this._externalBookBlocks[extbookIndexFromRefIndex].GetNameIx(definedNameIndex);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00045DBC File Offset: 0x00043FBC
		public bool ChangeExternalReference(string oldUrl, string newUrl)
		{
			global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock[] externalBookBlocks = this._externalBookBlocks;
			for (int i = 0; i < externalBookBlocks.Length; i++)
			{
				global::NPOI.HSSF.Record.SupBookRecord externalBookRecord = externalBookBlocks[i].GetExternalBookRecord();
				if (externalBookRecord.IsExternalReferences && externalBookRecord.URL.Equals(oldUrl))
				{
					externalBookRecord.URL = newUrl;
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000997 RID: 2455
		private global::NPOI.HSSF.Model.LinkTable.ExternalBookBlock[] _externalBookBlocks;

		// Token: 0x04000998 RID: 2456
		private global::NPOI.HSSF.Record.ExternSheetRecord _externSheetRecord;

		// Token: 0x04000999 RID: 2457
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.NameRecord> _definedNames;

		// Token: 0x0400099A RID: 2458
		private int _recordCount;

		// Token: 0x0400099B RID: 2459
		private global::NPOI.HSSF.Model.WorkbookRecordList _workbookRecordList;

		// Token: 0x020005C3 RID: 1475
		private class CRNBlock
		{
			// Token: 0x060034E7 RID: 13543 RVA: 0x000A4838 File Offset: 0x000A2A38
			public CRNBlock(global::NPOI.HSSF.Model.RecordStream rs)
			{
				this._countRecord = (global::NPOI.HSSF.Record.CRNCountRecord)rs.GetNext();
				global::NPOI.HSSF.Record.CRNRecord[] array = new global::NPOI.HSSF.Record.CRNRecord[this._countRecord.NumberOfCRNs];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (global::NPOI.HSSF.Record.CRNRecord)rs.GetNext();
				}
				this._crns = array;
			}

			// Token: 0x060034E8 RID: 13544 RVA: 0x000A4890 File Offset: 0x000A2A90
			public global::NPOI.HSSF.Record.CRNRecord[] GetCrns()
			{
				return (global::NPOI.HSSF.Record.CRNRecord[])this._crns.Clone();
			}

			// Token: 0x04001977 RID: 6519
			private global::NPOI.HSSF.Record.CRNCountRecord _countRecord;

			// Token: 0x04001978 RID: 6520
			private global::NPOI.HSSF.Record.CRNRecord[] _crns;
		}

		// Token: 0x020005C4 RID: 1476
		private class ExternalBookBlock
		{
			// Token: 0x060034E9 RID: 13545 RVA: 0x000A48A2 File Offset: 0x000A2AA2
			public ExternalBookBlock()
			{
				this._externalBookRecord = global::NPOI.HSSF.Record.SupBookRecord.CreateAddInFunctions();
				this._externalNameRecords = new global::NPOI.HSSF.Record.ExternalNameRecord[0];
				this._crnBlocks = new global::NPOI.HSSF.Model.LinkTable.CRNBlock[0];
			}

			// Token: 0x060034EA RID: 13546 RVA: 0x000A48D0 File Offset: 0x000A2AD0
			public ExternalBookBlock(global::NPOI.HSSF.Model.RecordStream rs)
			{
				this._externalBookRecord = (global::NPOI.HSSF.Record.SupBookRecord)rs.GetNext();
				global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
				while (rs.PeekNextClass() == typeof(global::NPOI.HSSF.Record.ExternalNameRecord))
				{
					arrayList.Add(rs.GetNext());
				}
				this._externalNameRecords = (global::NPOI.HSSF.Record.ExternalNameRecord[])arrayList.ToArray(typeof(global::NPOI.HSSF.Record.ExternalNameRecord));
				arrayList.Clear();
				while (rs.PeekNextClass() == typeof(global::NPOI.HSSF.Record.CRNCountRecord))
				{
					arrayList.Add(new global::NPOI.HSSF.Model.LinkTable.CRNBlock(rs));
				}
				this._crnBlocks = (global::NPOI.HSSF.Model.LinkTable.CRNBlock[])arrayList.ToArray(typeof(global::NPOI.HSSF.Model.LinkTable.CRNBlock));
			}

			// Token: 0x060034EB RID: 13547 RVA: 0x000A4982 File Offset: 0x000A2B82
			public ExternalBookBlock(string url, string[] sheetNames)
			{
				this._externalBookRecord = global::NPOI.HSSF.Record.SupBookRecord.CreateExternalReferences(url, sheetNames);
				this._crnBlocks = new global::NPOI.HSSF.Model.LinkTable.CRNBlock[0];
			}

			// Token: 0x060034EC RID: 13548 RVA: 0x000A49A3 File Offset: 0x000A2BA3
			public ExternalBookBlock(int numberOfSheets)
			{
				this._externalBookRecord = global::NPOI.HSSF.Record.SupBookRecord.CreateInternalReferences((short)numberOfSheets);
				this._externalNameRecords = new global::NPOI.HSSF.Record.ExternalNameRecord[0];
				this._crnBlocks = new global::NPOI.HSSF.Model.LinkTable.CRNBlock[0];
			}

			// Token: 0x17000DC0 RID: 3520
			// (get) Token: 0x060034ED RID: 13549 RVA: 0x000A49D0 File Offset: 0x000A2BD0
			public int NumberOfNames
			{
				get
				{
					return this._externalNameRecords.Length;
				}
			}

			// Token: 0x060034EE RID: 13550 RVA: 0x000A49DC File Offset: 0x000A2BDC
			public int AddExternalName(global::NPOI.HSSF.Record.ExternalNameRecord rec)
			{
				global::NPOI.HSSF.Record.ExternalNameRecord[] array = new global::NPOI.HSSF.Record.ExternalNameRecord[this._externalNameRecords.Length + 1];
				global::System.Array.Copy(this._externalNameRecords, 0, array, 0, this._externalNameRecords.Length);
				array[array.Length - 1] = rec;
				this._externalNameRecords = array;
				return this._externalNameRecords.Length - 1;
			}

			// Token: 0x060034EF RID: 13551 RVA: 0x000A4A28 File Offset: 0x000A2C28
			public global::NPOI.HSSF.Record.SupBookRecord GetExternalBookRecord()
			{
				return this._externalBookRecord;
			}

			// Token: 0x060034F0 RID: 13552 RVA: 0x000A4A30 File Offset: 0x000A2C30
			public string GetNameText(int definedNameIndex)
			{
				return this._externalNameRecords[definedNameIndex].Text;
			}

			// Token: 0x060034F1 RID: 13553 RVA: 0x000A4A40 File Offset: 0x000A2C40
			public int GetIndexOfName(string name)
			{
				for (int i = 0; i < this._externalNameRecords.Length; i++)
				{
					if (this._externalNameRecords[i].Text.Equals(name, global::System.StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x060034F2 RID: 13554 RVA: 0x000A4A79 File Offset: 0x000A2C79
			public int GetNameIx(int definedNameIndex)
			{
				return (int)this._externalNameRecords[definedNameIndex].Ix;
			}

			// Token: 0x04001979 RID: 6521
			private global::NPOI.HSSF.Record.SupBookRecord _externalBookRecord;

			// Token: 0x0400197A RID: 6522
			internal global::NPOI.HSSF.Record.ExternalNameRecord[] _externalNameRecords;

			// Token: 0x0400197B RID: 6523
			private global::NPOI.HSSF.Model.LinkTable.CRNBlock[] _crnBlocks;
		}
	}
}
