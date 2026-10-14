using System;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004D1 RID: 1233
	[global::System.Serializable]
	public class FormulaRecordAggregate : global::NPOI.HSSF.Record.Aggregates.RecordAggregate, global::NPOI.HSSF.Record.CellValueRecordInterface, global::System.IComparable, global::System.ICloneable
	{
		// Token: 0x06002EB4 RID: 11956 RVA: 0x0008A8D0 File Offset: 0x00088AD0
		public FormulaRecordAggregate(global::NPOI.HSSF.Record.FormulaRecord formulaRec, global::NPOI.HSSF.Record.StringRecord stringRec, global::NPOI.HSSF.Record.Aggregates.SharedValueManager svm)
		{
			if (svm == null)
			{
				throw new global::System.ArgumentException("sfm must not be null");
			}
			if (formulaRec.HasCachedResultString)
			{
				if (stringRec == null)
				{
					throw new global::NPOI.Util.RecordFormatException("Formula record flag is set but String record was not found");
				}
				this._stringRecord = stringRec;
			}
			else
			{
				this._stringRecord = null;
			}
			this._formulaRecord = formulaRec;
			this._sharedValueManager = svm;
			if (formulaRec.IsSharedFormula)
			{
				global::NPOI.SS.Util.CellReference expReference = formulaRec.Formula.ExpReference;
				if (expReference == null)
				{
					global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate.HandleMissingSharedFormulaRecord(formulaRec);
					return;
				}
				this._sharedFormulaRecord = svm.LinkSharedFormulaRecord(expReference, this);
			}
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x0008A951 File Offset: 0x00088B51
		public void NotifyFormulaChanging()
		{
			if (this._sharedFormulaRecord != null)
			{
				this._sharedValueManager.Unlink(this._sharedFormulaRecord);
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002EB6 RID: 11958 RVA: 0x0008A96C File Offset: 0x00088B6C
		public bool IsPartOfArrayFormula
		{
			get
			{
				if (this._sharedFormulaRecord != null)
				{
					return false;
				}
				global::NPOI.SS.Util.CellReference expReference = this._formulaRecord.Formula.ExpReference;
				return ((expReference == null) ? null : this._sharedValueManager.GetArrayRecord(expReference.Row, (int)expReference.Col)) != null;
			}
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x0008A9B4 File Offset: 0x00088BB4
		public override int Serialize(int offset, byte[] data)
		{
			int num = offset + this._formulaRecord.Serialize(offset, data);
			if (this._stringRecord != null)
			{
				num += this._stringRecord.Serialize(num, data);
			}
			return num - offset;
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x0008A9F0 File Offset: 0x00088BF0
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this._formulaRecord);
			global::NPOI.HSSF.Record.Record recordForFirstCell = this._sharedValueManager.GetRecordForFirstCell(this);
			if (recordForFirstCell != null)
			{
				rv.VisitRecord(recordForFirstCell);
			}
			if (this._formulaRecord.HasCachedResultString && this._stringRecord != null)
			{
				rv.VisitRecord(this._stringRecord);
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06002EB9 RID: 11961 RVA: 0x0008AA41 File Offset: 0x00088C41
		public override int RecordSize
		{
			get
			{
				return this._formulaRecord.RecordSize + ((this._stringRecord == null) ? 0 : this._stringRecord.RecordSize);
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002EBA RID: 11962 RVA: 0x0008AA65 File Offset: 0x00088C65
		public override short Sid
		{
			get
			{
				return -2000;
			}
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x0008AA6C File Offset: 0x00088C6C
		private static void HandleMissingSharedFormulaRecord(global::NPOI.HSSF.Record.FormulaRecord formula)
		{
			if (formula.ParsedExpression[0] is global::NPOI.SS.Formula.PTG.ExpPtg)
			{
				throw new global::NPOI.Util.RecordFormatException("SharedFormulaRecord not found for FormulaRecord with (isSharedFormula=true)");
			}
			formula.IsSharedFormula = false;
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x0008AA8F File Offset: 0x00088C8F
		// (set) Token: 0x06002EBD RID: 11965 RVA: 0x0008AA97 File Offset: 0x00088C97
		public global::NPOI.HSSF.Record.FormulaRecord FormulaRecord
		{
			get
			{
				return this._formulaRecord;
			}
			set
			{
				this._formulaRecord = value;
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x0008AAA0 File Offset: 0x00088CA0
		// (set) Token: 0x06002EBF RID: 11967 RVA: 0x0008AAA8 File Offset: 0x00088CA8
		public global::NPOI.HSSF.Record.StringRecord StringRecord
		{
			get
			{
				return this._stringRecord;
			}
			set
			{
				this._stringRecord = value;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x0008AAB1 File Offset: 0x00088CB1
		// (set) Token: 0x06002EC1 RID: 11969 RVA: 0x0008AABE File Offset: 0x00088CBE
		public short XFIndex
		{
			get
			{
				return this._formulaRecord.XFIndex;
			}
			set
			{
				this._formulaRecord.XFIndex = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x0008AACC File Offset: 0x00088CCC
		// (set) Token: 0x06002EC3 RID: 11971 RVA: 0x0008AAD9 File Offset: 0x00088CD9
		public int Column
		{
			get
			{
				return this._formulaRecord.Column;
			}
			set
			{
				this._formulaRecord.Column = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x0008AAE7 File Offset: 0x00088CE7
		// (set) Token: 0x06002EC5 RID: 11973 RVA: 0x0008AAF4 File Offset: 0x00088CF4
		public int Row
		{
			get
			{
				return this._formulaRecord.Row;
			}
			set
			{
				this._formulaRecord.Row = value;
			}
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x0008AB02 File Offset: 0x00088D02
		public int CompareTo(object o)
		{
			return this._formulaRecord.CompareTo(o);
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x0008AB10 File Offset: 0x00088D10
		public override bool Equals(object obj)
		{
			return this._formulaRecord.Equals(obj);
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x0008AB1E File Offset: 0x00088D1E
		public override int GetHashCode()
		{
			return this._formulaRecord.GetHashCode();
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x0008AB2B File Offset: 0x00088D2B
		public override string ToString()
		{
			return this._formulaRecord.ToString();
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x0008AB38 File Offset: 0x00088D38
		public string StringValue
		{
			get
			{
				if (this._stringRecord == null)
				{
					return null;
				}
				return this._stringRecord.String;
			}
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x0008AB4F File Offset: 0x00088D4F
		public void SetCachedDoubleResult(double value)
		{
			this._stringRecord = null;
			this._formulaRecord.Value = value;
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x0008AB64 File Offset: 0x00088D64
		public void SetCachedStringResult(string value)
		{
			if (this._stringRecord == null)
			{
				this._stringRecord = new global::NPOI.HSSF.Record.StringRecord();
			}
			this._stringRecord.String = value;
			if (value.Length < 1)
			{
				this._formulaRecord.SetCachedResultTypeEmptyString();
				return;
			}
			this._formulaRecord.SetCachedResultTypeString();
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x0008ABB0 File Offset: 0x00088DB0
		public void SetCachedBooleanResult(bool value)
		{
			this._stringRecord = null;
			this._formulaRecord.SetCachedResultBoolean(value);
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x0008ABC5 File Offset: 0x00088DC5
		public void SetCachedErrorResult(int errorCode)
		{
			this._stringRecord = null;
			this._formulaRecord.SetCachedResultErrorCode(errorCode);
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x0008ABDA File Offset: 0x00088DDA
		public void SetCachedErrorResult(global::NPOI.SS.UserModel.FormulaError error)
		{
			this.SetCachedErrorResult((int)error.Code);
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x0000F20C File Offset: 0x0000D40C
		public object Clone()
		{
			return this;
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x0008ABE8 File Offset: 0x00088DE8
		public global::NPOI.SS.Formula.PTG.Ptg[] FormulaTokens
		{
			get
			{
				if (this._sharedFormulaRecord != null)
				{
					return this._sharedFormulaRecord.GetFormulaTokens(this._formulaRecord);
				}
				global::NPOI.SS.Util.CellReference expReference = this._formulaRecord.Formula.ExpReference;
				if (expReference != null)
				{
					return this._sharedValueManager.GetArrayRecord(expReference.Row, (int)expReference.Col).FormulaTokens;
				}
				return this._formulaRecord.ParsedExpression;
			}
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x0008AC4B File Offset: 0x00088E4B
		public void SetParsedExpression(global::NPOI.SS.Formula.PTG.Ptg[] ptgs)
		{
			this.NotifyFormulaChanging();
			this._formulaRecord.ParsedExpression = ptgs;
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x0008AC60 File Offset: 0x00088E60
		public void UnlinkSharedFormula()
		{
			global::NPOI.HSSF.Record.SharedFormulaRecord sharedFormulaRecord = this._sharedFormulaRecord;
			if (sharedFormulaRecord == null)
			{
				throw new global::System.InvalidOperationException("Formula not linked to shared formula");
			}
			global::NPOI.SS.Formula.PTG.Ptg[] formulaTokens = sharedFormulaRecord.GetFormulaTokens(this._formulaRecord);
			this._formulaRecord.SetParsedExpression(formulaTokens);
			this._formulaRecord.SetSharedFormula(false);
			this._sharedFormulaRecord = null;
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x0008ACAC File Offset: 0x00088EAC
		public global::NPOI.SS.Util.CellRangeAddress GetArrayFormulaRange()
		{
			if (this._sharedFormulaRecord != null)
			{
				throw new global::System.InvalidOperationException("not an array formula cell.");
			}
			global::NPOI.SS.Util.CellReference expReference = this._formulaRecord.Formula.ExpReference;
			if (expReference == null)
			{
				throw new global::System.InvalidOperationException("not an array formula cell.");
			}
			global::NPOI.HSSF.Record.ArrayRecord arrayRecord = this._sharedValueManager.GetArrayRecord(expReference.Row, (int)expReference.Col);
			if (arrayRecord == null)
			{
				throw new global::System.InvalidOperationException("ArrayRecord was not found for the locator " + expReference.FormatAsString());
			}
			global::NPOI.SS.Util.CellRangeAddress8Bit range = arrayRecord.Range;
			return new global::NPOI.SS.Util.CellRangeAddress(range.FirstRow, range.LastRow, range.FirstColumn, range.LastColumn);
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x0008AD40 File Offset: 0x00088F40
		public void SetArrayFormula(global::NPOI.SS.Util.CellRangeAddress r, global::NPOI.SS.Formula.PTG.Ptg[] ptgs)
		{
			global::NPOI.HSSF.Record.ArrayRecord ar = new global::NPOI.HSSF.Record.ArrayRecord(global::NPOI.SS.Formula.Formula.Create(ptgs), new global::NPOI.SS.Util.CellRangeAddress8Bit(r.FirstRow, r.LastRow, r.FirstColumn, r.LastColumn));
			this._sharedValueManager.AddArrayRecord(ar);
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x0008AD84 File Offset: 0x00088F84
		public global::NPOI.SS.Util.CellRangeAddress RemoveArrayFormula(int rowIndex, int columnIndex)
		{
			global::NPOI.SS.Util.CellRangeAddress8Bit cellRangeAddress8Bit = this._sharedValueManager.RemoveArrayFormula(rowIndex, columnIndex);
			this._formulaRecord.ParsedExpression = null;
			return new global::NPOI.SS.Util.CellRangeAddress(cellRangeAddress8Bit.FirstRow, cellRangeAddress8Bit.LastRow, cellRangeAddress8Bit.FirstColumn, cellRangeAddress8Bit.LastColumn);
		}

		// Token: 0x04001469 RID: 5225
		public const short sid = -2000;

		// Token: 0x0400146A RID: 5226
		private global::NPOI.HSSF.Record.FormulaRecord _formulaRecord;

		// Token: 0x0400146B RID: 5227
		private global::NPOI.HSSF.Record.Aggregates.SharedValueManager _sharedValueManager;

		// Token: 0x0400146C RID: 5228
		private global::NPOI.HSSF.Record.StringRecord _stringRecord;

		// Token: 0x0400146D RID: 5229
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.SharedFormulaRecord _sharedFormulaRecord;
	}
}
