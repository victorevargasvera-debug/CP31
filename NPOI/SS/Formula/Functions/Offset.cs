using System;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001D9 RID: 473
	public class Offset : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000C43 RID: 3139 RVA: 0x0002151C File Offset: 0x0001F71C
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			if (args.Length < 3 || args.Length > 5)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				global::NPOI.SS.Formula.Functions.Offset.BaseRef baseRef = global::NPOI.SS.Formula.Functions.Offset.EvaluateBaseRef(args[0]);
				int offset = global::NPOI.SS.Formula.Functions.Offset.EvaluateIntArg(args[1], srcCellRow, srcCellCol);
				int offset2 = global::NPOI.SS.Formula.Functions.Offset.EvaluateIntArg(args[2], srcCellRow, srcCellCol);
				int num = baseRef.Height;
				int num2 = baseRef.Width;
				int num3 = args.Length;
				if (num3 != 4)
				{
					if (num3 == 5)
					{
						if (!(args[4] is global::NPOI.SS.Formula.Eval.MissingArgEval))
						{
							num2 = global::NPOI.SS.Formula.Functions.Offset.EvaluateIntArg(args[4], srcCellRow, srcCellCol);
						}
						if (!(args[3] is global::NPOI.SS.Formula.Eval.MissingArgEval))
						{
							num = global::NPOI.SS.Formula.Functions.Offset.EvaluateIntArg(args[3], srcCellRow, srcCellCol);
						}
					}
				}
				else if (!(args[3] is global::NPOI.SS.Formula.Eval.MissingArgEval))
				{
					num = global::NPOI.SS.Formula.Functions.Offset.EvaluateIntArg(args[3], srcCellRow, srcCellCol);
				}
				if (num == 0 || num2 == 0)
				{
					result = global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
				}
				else
				{
					global::NPOI.SS.Formula.Functions.Offset.LinearOffsetRange orRow = new global::NPOI.SS.Formula.Functions.Offset.LinearOffsetRange(offset, num);
					global::NPOI.SS.Formula.Functions.Offset.LinearOffsetRange orCol = new global::NPOI.SS.Formula.Functions.Offset.LinearOffsetRange(offset2, num2);
					result = global::NPOI.SS.Formula.Functions.Offset.CreateOffset(baseRef, orRow, orCol);
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00021608 File Offset: 0x0001F808
		private static global::NPOI.SS.Formula.Eval.AreaEval CreateOffset(global::NPOI.SS.Formula.Functions.Offset.BaseRef baseRef, global::NPOI.SS.Formula.Functions.Offset.LinearOffsetRange orRow, global::NPOI.SS.Formula.Functions.Offset.LinearOffsetRange orCol)
		{
			global::NPOI.SS.Formula.Functions.Offset.LinearOffsetRange linearOffsetRange = orRow.NormaliseAndTranslate(baseRef.FirstRowIndex);
			global::NPOI.SS.Formula.Functions.Offset.LinearOffsetRange linearOffsetRange2 = orCol.NormaliseAndTranslate(baseRef.FirstColumnIndex);
			if (linearOffsetRange.IsOutOfBounds(0, 65535))
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID);
			}
			if (linearOffsetRange2.IsOutOfBounds(0, 255))
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID);
			}
			return baseRef.Offset((int)orRow.FirstIndex, (int)orRow.LastIndex, (int)orCol.FirstIndex, (int)orCol.LastIndex);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00021680 File Offset: 0x0001F880
		private static global::NPOI.SS.Formula.Functions.Offset.BaseRef EvaluateBaseRef(global::NPOI.SS.Formula.Eval.ValueEval eval)
		{
			if (eval is global::NPOI.SS.Formula.Eval.RefEval)
			{
				return new global::NPOI.SS.Formula.Functions.Offset.BaseRef((global::NPOI.SS.Formula.Eval.RefEval)eval);
			}
			if (eval is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				return new global::NPOI.SS.Formula.Functions.Offset.BaseRef((global::NPOI.SS.Formula.Eval.AreaEval)eval);
			}
			if (eval is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				throw new global::NPOI.SS.Formula.Functions.Offset.EvalEx((global::NPOI.SS.Formula.Eval.ErrorEval)eval);
			}
			throw new global::NPOI.SS.Formula.Functions.Offset.EvalEx(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x000216D3 File Offset: 0x0001F8D3
		public static int EvaluateIntArg(global::NPOI.SS.Formula.Eval.ValueEval eval, int srcCellRow, int srcCellCol)
		{
			return global::NPOI.SS.Formula.Functions.Offset.ConvertDoubleToInt(global::NPOI.SS.Formula.Functions.Offset.EvaluateDoubleArg(eval, srcCellRow, srcCellCol));
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x000216E2 File Offset: 0x0001F8E2
		public static int ConvertDoubleToInt(double d)
		{
			return (int)global::System.Math.Floor(d);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000216EC File Offset: 0x0001F8EC
		private static double EvaluateDoubleArg(global::NPOI.SS.Formula.Eval.ValueEval eval, int srcCellRow, int srcCellCol)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(eval, srcCellRow, srcCellCol);
			if (singleValue is global::NPOI.SS.Formula.Eval.NumericValueEval)
			{
				return ((global::NPOI.SS.Formula.Eval.NumericValueEval)singleValue).NumberValue;
			}
			if (singleValue is global::NPOI.SS.Formula.Eval.StringEval)
			{
				double num = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(((global::NPOI.SS.Formula.Eval.StringEval)singleValue).StringValue);
				if (double.IsNaN(num))
				{
					throw new global::NPOI.SS.Formula.Functions.Offset.EvalEx(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
				}
				return num;
			}
			else
			{
				if (!(singleValue is global::NPOI.SS.Formula.Eval.BoolEval))
				{
					throw new global::System.Exception("Unexpected eval type (" + singleValue.GetType().Name + ")");
				}
				if (((global::NPOI.SS.Formula.Eval.BoolEval)singleValue).BooleanValue)
				{
					return 1.0;
				}
				return 0.0;
			}
		}

		// Token: 0x040005B4 RID: 1460
		private const int LAST_VALID_ROW_INDEX = 65535;

		// Token: 0x040005B5 RID: 1461
		private const int LAST_VALID_COLUMN_INDEX = 255;

		// Token: 0x02000584 RID: 1412
		[global::System.Serializable]
		private class EvalEx : global::System.Exception
		{
			// Token: 0x06003423 RID: 13347 RVA: 0x000A285A File Offset: 0x000A0A5A
			public EvalEx(global::NPOI.SS.Formula.Eval.ErrorEval error)
			{
				this._error = error;
			}

			// Token: 0x06003424 RID: 13348 RVA: 0x000A2869 File Offset: 0x000A0A69
			public global::NPOI.SS.Formula.Eval.ErrorEval GetError()
			{
				return this._error;
			}

			// Token: 0x040018E4 RID: 6372
			private global::NPOI.SS.Formula.Eval.ErrorEval _error;
		}

		// Token: 0x02000585 RID: 1413
		public class LinearOffsetRange
		{
			// Token: 0x06003425 RID: 13349 RVA: 0x000A2871 File Offset: 0x000A0A71
			public LinearOffsetRange(int offset, int length)
			{
				if (length == 0)
				{
					throw new global::System.ArgumentException("Length may not be zero");
				}
				this._offset = offset;
				this._Length = length;
			}

			// Token: 0x17000DAC RID: 3500
			// (get) Token: 0x06003426 RID: 13350 RVA: 0x000A2895 File Offset: 0x000A0A95
			public short FirstIndex
			{
				get
				{
					return (short)this._offset;
				}
			}

			// Token: 0x17000DAD RID: 3501
			// (get) Token: 0x06003427 RID: 13351 RVA: 0x000A289E File Offset: 0x000A0A9E
			public short LastIndex
			{
				get
				{
					return (short)(this._offset + this._Length - 1);
				}
			}

			// Token: 0x06003428 RID: 13352 RVA: 0x000A28B0 File Offset: 0x000A0AB0
			public global::NPOI.SS.Formula.Functions.Offset.LinearOffsetRange NormaliseAndTranslate(int translationAmount)
			{
				if (this._Length <= 0)
				{
					return new global::NPOI.SS.Formula.Functions.Offset.LinearOffsetRange(translationAmount + this._offset + this._Length + 1, -this._Length);
				}
				if (translationAmount == 0)
				{
					return this;
				}
				return new global::NPOI.SS.Formula.Functions.Offset.LinearOffsetRange(translationAmount + this._offset, this._Length);
			}

			// Token: 0x06003429 RID: 13353 RVA: 0x000A28FC File Offset: 0x000A0AFC
			public bool IsOutOfBounds(int lowValidIx, int highValidIx)
			{
				return this._offset < lowValidIx || (int)this.LastIndex > highValidIx;
			}

			// Token: 0x0600342A RID: 13354 RVA: 0x000A2918 File Offset: 0x000A0B18
			public override string ToString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
				stringBuilder.Append(base.GetType().Name).Append(" [");
				stringBuilder.Append(this._offset).Append("...").Append(this.LastIndex);
				stringBuilder.Append("]");
				return stringBuilder.ToString();
			}

			// Token: 0x040018E5 RID: 6373
			private int _offset;

			// Token: 0x040018E6 RID: 6374
			private int _Length;
		}

		// Token: 0x02000586 RID: 1414
		private class BaseRef
		{
			// Token: 0x0600342B RID: 13355 RVA: 0x000A297B File Offset: 0x000A0B7B
			public BaseRef(global::NPOI.SS.Formula.Eval.RefEval re)
			{
				this._refEval = re;
				this._areaEval = null;
				this._firstRowIndex = re.Row;
				this._firstColumnIndex = re.Column;
				this._height = 1;
				this._width = 1;
			}

			// Token: 0x0600342C RID: 13356 RVA: 0x000A29B8 File Offset: 0x000A0BB8
			public BaseRef(global::NPOI.SS.Formula.Eval.AreaEval ae)
			{
				this._refEval = null;
				this._areaEval = ae;
				this._firstRowIndex = ae.FirstRow;
				this._firstColumnIndex = ae.FirstColumn;
				this._height = ae.LastRow - ae.FirstRow + 1;
				this._width = ae.LastColumn - ae.FirstColumn + 1;
			}

			// Token: 0x17000DAE RID: 3502
			// (get) Token: 0x0600342D RID: 13357 RVA: 0x000A2A1B File Offset: 0x000A0C1B
			public int Width
			{
				get
				{
					return this._width;
				}
			}

			// Token: 0x17000DAF RID: 3503
			// (get) Token: 0x0600342E RID: 13358 RVA: 0x000A2A23 File Offset: 0x000A0C23
			public int Height
			{
				get
				{
					return this._height;
				}
			}

			// Token: 0x17000DB0 RID: 3504
			// (get) Token: 0x0600342F RID: 13359 RVA: 0x000A2A2B File Offset: 0x000A0C2B
			public int FirstRowIndex
			{
				get
				{
					return this._firstRowIndex;
				}
			}

			// Token: 0x17000DB1 RID: 3505
			// (get) Token: 0x06003430 RID: 13360 RVA: 0x000A2A33 File Offset: 0x000A0C33
			public int FirstColumnIndex
			{
				get
				{
					return this._firstColumnIndex;
				}
			}

			// Token: 0x06003431 RID: 13361 RVA: 0x000A2A3B File Offset: 0x000A0C3B
			public global::NPOI.SS.Formula.Eval.AreaEval Offset(int relFirstRowIx, int relLastRowIx, int relFirstColIx, int relLastColIx)
			{
				if (this._refEval == null)
				{
					return this._areaEval.Offset(relFirstRowIx, relLastRowIx, relFirstColIx, relLastColIx);
				}
				return this._refEval.Offset(relFirstRowIx, relLastRowIx, relFirstColIx, relLastColIx);
			}

			// Token: 0x040018E7 RID: 6375
			private const int INVALID_SHEET_INDEX = -1;

			// Token: 0x040018E8 RID: 6376
			private int _firstRowIndex;

			// Token: 0x040018E9 RID: 6377
			private int _firstColumnIndex;

			// Token: 0x040018EA RID: 6378
			private int _width;

			// Token: 0x040018EB RID: 6379
			private int _height;

			// Token: 0x040018EC RID: 6380
			private global::NPOI.SS.Formula.Eval.RefEval _refEval;

			// Token: 0x040018ED RID: 6381
			private global::NPOI.SS.Formula.Eval.AreaEval _areaEval;
		}
	}
}
