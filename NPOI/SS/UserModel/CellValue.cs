using System;
using System.Globalization;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200004F RID: 79
	public class CellValue
	{
		// Token: 0x06000306 RID: 774 RVA: 0x0000B072 File Offset: 0x00009272
		private CellValue(global::NPOI.SS.UserModel.CellType cellType, double numberValue, bool boolValue, string textValue, int errorCode)
		{
			this._cellType = cellType;
			this._numberValue = numberValue;
			this._boolValue = boolValue;
			this._textValue = textValue;
			this._errorCode = errorCode;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000B09F File Offset: 0x0000929F
		public CellValue(double numberValue) : this(global::NPOI.SS.UserModel.CellType.Numeric, numberValue, false, null, 0)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000B0AC File Offset: 0x000092AC
		public static global::NPOI.SS.UserModel.CellValue ValueOf(bool boolValue)
		{
			if (!boolValue)
			{
				return global::NPOI.SS.UserModel.CellValue.FALSE;
			}
			return global::NPOI.SS.UserModel.CellValue.TRUE;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000B0BC File Offset: 0x000092BC
		public CellValue(string stringValue) : this(global::NPOI.SS.UserModel.CellType.String, 0.0, false, stringValue, 0)
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000B0D1 File Offset: 0x000092D1
		public static global::NPOI.SS.UserModel.CellValue GetError(int errorCode)
		{
			return new global::NPOI.SS.UserModel.CellValue(global::NPOI.SS.UserModel.CellType.Error, 0.0, false, null, errorCode);
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000B0E5 File Offset: 0x000092E5
		public bool BooleanValue
		{
			get
			{
				return this._boolValue;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000B0ED File Offset: 0x000092ED
		public double NumberValue
		{
			get
			{
				return this._numberValue;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000B0F5 File Offset: 0x000092F5
		public string StringValue
		{
			get
			{
				return this._textValue;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0000B0FD File Offset: 0x000092FD
		public global::NPOI.SS.UserModel.CellType CellType
		{
			get
			{
				return this._cellType;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0000B105 File Offset: 0x00009305
		public sbyte ErrorValue
		{
			get
			{
				return (sbyte)this._errorCode;
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000B110 File Offset: 0x00009310
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.FormatAsString());
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000B160 File Offset: 0x00009360
		public string FormatAsString()
		{
			switch (this._cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				return this._numberValue.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			case global::NPOI.SS.UserModel.CellType.String:
				return "\"" + this._textValue + "\"";
			case global::NPOI.SS.UserModel.CellType.Boolean:
				if (!this._boolValue)
				{
					return "FALSE";
				}
				return "TRUE";
			case global::NPOI.SS.UserModel.CellType.Error:
				return global::NPOI.SS.Formula.Eval.ErrorEval.GetText(this._errorCode);
			}
			return "<error unexpected cell type " + this._cellType.ToString() + ">";
		}

		// Token: 0x04000168 RID: 360
		public static readonly global::NPOI.SS.UserModel.CellValue TRUE = new global::NPOI.SS.UserModel.CellValue(global::NPOI.SS.UserModel.CellType.Boolean, 0.0, true, null, 0);

		// Token: 0x04000169 RID: 361
		public static readonly global::NPOI.SS.UserModel.CellValue FALSE = new global::NPOI.SS.UserModel.CellValue(global::NPOI.SS.UserModel.CellType.Boolean, 0.0, false, null, 0);

		// Token: 0x0400016A RID: 362
		private global::NPOI.SS.UserModel.CellType _cellType;

		// Token: 0x0400016B RID: 363
		private double _numberValue;

		// Token: 0x0400016C RID: 364
		private bool _boolValue;

		// Token: 0x0400016D RID: 365
		private string _textValue;

		// Token: 0x0400016E RID: 366
		private int _errorCode;
	}
}
