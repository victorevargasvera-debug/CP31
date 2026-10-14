using System;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Eval.Forked
{
	// Token: 0x0200022A RID: 554
	internal class ForkedEvaluationCell : global::NPOI.SS.Formula.IEvaluationCell
	{
		// Token: 0x06000D82 RID: 3458 RVA: 0x00025AE4 File Offset: 0x00023CE4
		public ForkedEvaluationCell(global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet sheet, global::NPOI.SS.Formula.IEvaluationCell masterCell)
		{
			this._sheet = sheet;
			this._masterCell = masterCell;
			this.SetValue(global::NPOI.SS.Formula.Eval.BlankEval.instance);
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x00025B05 File Offset: 0x00023D05
		public object IdentityKey
		{
			get
			{
				return this._masterCell.IdentityKey;
			}
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00025B14 File Offset: 0x00023D14
		public void SetValue(global::NPOI.SS.Formula.Eval.ValueEval value)
		{
			global::System.Type type = value.GetType();
			if (type == typeof(global::NPOI.SS.Formula.Eval.NumberEval))
			{
				this._cellType = global::NPOI.SS.UserModel.CellType.Numeric;
				this._numberValue = ((global::NPOI.SS.Formula.Eval.NumberEval)value).NumberValue;
				return;
			}
			if (type == typeof(global::NPOI.SS.Formula.Eval.StringEval))
			{
				this._cellType = global::NPOI.SS.UserModel.CellType.String;
				this._stringValue = ((global::NPOI.SS.Formula.Eval.StringEval)value).StringValue;
				return;
			}
			if (type == typeof(global::NPOI.SS.Formula.Eval.BoolEval))
			{
				this._cellType = global::NPOI.SS.UserModel.CellType.Boolean;
				this._boolValue = ((global::NPOI.SS.Formula.Eval.BoolEval)value).BooleanValue;
				return;
			}
			if (type == typeof(global::NPOI.SS.Formula.Eval.ErrorEval))
			{
				this._cellType = global::NPOI.SS.UserModel.CellType.Error;
				this._errorValue = ((global::NPOI.SS.Formula.Eval.ErrorEval)value).ErrorCode;
				return;
			}
			if (type == typeof(global::NPOI.SS.Formula.Eval.BlankEval))
			{
				this._cellType = global::NPOI.SS.UserModel.CellType.Blank;
				return;
			}
			throw new global::System.ArgumentException("Unexpected value class (" + type.Name + ")");
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00025C08 File Offset: 0x00023E08
		public void CopyValue(global::NPOI.SS.UserModel.ICell destCell)
		{
			switch (this._cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				destCell.SetCellValue(this._numberValue);
				return;
			case global::NPOI.SS.UserModel.CellType.String:
				destCell.SetCellValue(this._stringValue);
				return;
			case global::NPOI.SS.UserModel.CellType.Blank:
				destCell.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
				return;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				destCell.SetCellValue(this._boolValue);
				return;
			case global::NPOI.SS.UserModel.CellType.Error:
				destCell.SetCellErrorValue((byte)this._errorValue);
				return;
			}
			throw new global::System.InvalidOperationException("Unexpected data type (" + this._cellType.ToString() + ")");
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00025C9E File Offset: 0x00023E9E
		private void CheckCellType(global::NPOI.SS.UserModel.CellType expectedCellType)
		{
			if (this._cellType != expectedCellType)
			{
				throw new global::System.Exception("Wrong data type (" + this._cellType.ToString() + ")");
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00025CCF File Offset: 0x00023ECF
		public global::NPOI.SS.UserModel.CellType CellType
		{
			get
			{
				return this._cellType;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00025CD7 File Offset: 0x00023ED7
		public bool BooleanCellValue
		{
			get
			{
				this.CheckCellType(global::NPOI.SS.UserModel.CellType.Boolean);
				return this._boolValue;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x00025CE6 File Offset: 0x00023EE6
		public int ErrorCellValue
		{
			get
			{
				this.CheckCellType(global::NPOI.SS.UserModel.CellType.Error);
				return this._errorValue;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00025CF5 File Offset: 0x00023EF5
		public double NumericCellValue
		{
			get
			{
				this.CheckCellType(global::NPOI.SS.UserModel.CellType.Numeric);
				return this._numberValue;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00025D04 File Offset: 0x00023F04
		public string StringCellValue
		{
			get
			{
				this.CheckCellType(global::NPOI.SS.UserModel.CellType.String);
				return this._stringValue;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00025D13 File Offset: 0x00023F13
		public global::NPOI.SS.Formula.IEvaluationSheet Sheet
		{
			get
			{
				return this._sheet;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00025D1B File Offset: 0x00023F1B
		public int RowIndex
		{
			get
			{
				return this._masterCell.RowIndex;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00025D28 File Offset: 0x00023F28
		public int ColumnIndex
		{
			get
			{
				return this._masterCell.ColumnIndex;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00025D35 File Offset: 0x00023F35
		public global::NPOI.SS.UserModel.CellType CachedFormulaResultType
		{
			get
			{
				return this._masterCell.CachedFormulaResultType;
			}
		}

		// Token: 0x04000611 RID: 1553
		private global::NPOI.SS.Formula.IEvaluationSheet _sheet;

		// Token: 0x04000612 RID: 1554
		private global::NPOI.SS.Formula.IEvaluationCell _masterCell;

		// Token: 0x04000613 RID: 1555
		private bool _boolValue;

		// Token: 0x04000614 RID: 1556
		private global::NPOI.SS.UserModel.CellType _cellType;

		// Token: 0x04000615 RID: 1557
		private int _errorValue;

		// Token: 0x04000616 RID: 1558
		private double _numberValue;

		// Token: 0x04000617 RID: 1559
		private string _stringValue;
	}
}
