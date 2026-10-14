using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000148 RID: 328
	public class LinearRegressionFunction : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000A66 RID: 2662 RVA: 0x0001B859 File Offset: 0x00019A59
		public LinearRegressionFunction(global::NPOI.SS.Formula.Functions.LinearRegressionFunction.FUNCTION function)
		{
			this.function = function;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0001B868 File Offset: 0x00019A68
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			double num;
			try
			{
				global::NPOI.SS.Formula.Functions.ValueVector valueVector = this.CreateValueVector(arg0);
				global::NPOI.SS.Formula.Functions.ValueVector valueVector2 = this.CreateValueVector(arg1);
				int size = valueVector2.Size;
				if (size == 0 || valueVector.Size != size)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.NA;
				}
				num = this.EvaluateInternal(valueVector2, valueVector, size);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			if (double.IsNaN(num) || double.IsInfinity(num))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		private double EvaluateInternal(global::NPOI.SS.Formula.Functions.ValueVector x, global::NPOI.SS.Formula.Functions.ValueVector y, int size)
		{
			global::NPOI.SS.Formula.Eval.ErrorEval errorEval = null;
			global::NPOI.SS.Formula.Eval.ErrorEval errorEval2 = null;
			bool flag = false;
			double num = 0.0;
			double num2 = 0.0;
			for (int i = 0; i < size; i++)
			{
				global::NPOI.SS.Formula.Eval.ValueEval item = x.GetItem(i);
				global::NPOI.SS.Formula.Eval.ValueEval item2 = y.GetItem(i);
				if (item is global::NPOI.SS.Formula.Eval.ErrorEval && errorEval == null)
				{
					errorEval = (global::NPOI.SS.Formula.Eval.ErrorEval)item;
				}
				else if (item2 is global::NPOI.SS.Formula.Eval.ErrorEval && errorEval2 == null)
				{
					errorEval2 = (global::NPOI.SS.Formula.Eval.ErrorEval)item2;
				}
				else if (item is global::NPOI.SS.Formula.Eval.NumberEval && item2 is global::NPOI.SS.Formula.Eval.NumberEval)
				{
					flag = true;
					global::NPOI.SS.Formula.Eval.NumberEval numberEval = (global::NPOI.SS.Formula.Eval.NumberEval)item;
					global::NPOI.SS.Formula.Eval.NumberEval numberEval2 = (global::NPOI.SS.Formula.Eval.NumberEval)item2;
					num += numberEval.NumberValue;
					num2 += numberEval2.NumberValue;
				}
			}
			double num3 = num / (double)size;
			double num4 = num2 / (double)size;
			double num5 = 0.0;
			double num6 = 0.0;
			for (int j = 0; j < size; j++)
			{
				global::NPOI.SS.Formula.Eval.ValueEval item3 = x.GetItem(j);
				global::NPOI.SS.Formula.Eval.ValueEval item4 = y.GetItem(j);
				if (item3 is global::NPOI.SS.Formula.Eval.ErrorEval && errorEval == null)
				{
					errorEval = (global::NPOI.SS.Formula.Eval.ErrorEval)item3;
				}
				else if (item4 is global::NPOI.SS.Formula.Eval.ErrorEval && errorEval2 == null)
				{
					errorEval2 = (global::NPOI.SS.Formula.Eval.ErrorEval)item4;
				}
				else if (item3 is global::NPOI.SS.Formula.Eval.NumberEval && item4 is global::NPOI.SS.Formula.Eval.NumberEval)
				{
					global::NPOI.SS.Formula.Eval.NumberEval numberEval3 = (global::NPOI.SS.Formula.Eval.NumberEval)item3;
					global::NPOI.SS.Formula.Eval.NumberEval numberEval4 = (global::NPOI.SS.Formula.Eval.NumberEval)item4;
					num5 += (numberEval3.NumberValue - num3) * (numberEval3.NumberValue - num3);
					num6 += (numberEval3.NumberValue - num3) * (numberEval4.NumberValue - num4);
				}
			}
			double num7 = num6 / num5;
			double result = num4 - num7 * num3;
			if (errorEval != null)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(errorEval);
			}
			if (errorEval2 != null)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(errorEval2);
			}
			if (!flag)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.DIV_ZERO);
			}
			if (this.function == global::NPOI.SS.Formula.Functions.LinearRegressionFunction.FUNCTION.INTERCEPT)
			{
				return result;
			}
			return num7;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0001BAB4 File Offset: 0x00019CB4
		private global::NPOI.SS.Formula.Functions.ValueVector CreateValueVector(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			if (arg is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException((global::NPOI.SS.Formula.Eval.ErrorEval)arg);
			}
			if (arg is global::NPOI.SS.Formula.TwoDEval)
			{
				return new global::NPOI.SS.Formula.Functions.LinearRegressionFunction.AreaValueArray((global::NPOI.SS.Formula.TwoDEval)arg);
			}
			if (arg is global::NPOI.SS.Formula.Eval.RefEval)
			{
				return new global::NPOI.SS.Formula.Functions.LinearRegressionFunction.RefValueArray((global::NPOI.SS.Formula.Eval.RefEval)arg);
			}
			return new global::NPOI.SS.Formula.Functions.LinearRegressionFunction.SingleCellValueArray(arg);
		}

		// Token: 0x04000529 RID: 1321
		public global::NPOI.SS.Formula.Functions.LinearRegressionFunction.FUNCTION function;

		// Token: 0x0200056B RID: 1387
		private abstract class ValueArray : global::NPOI.SS.Formula.Functions.ValueVector
		{
			// Token: 0x060033CE RID: 13262 RVA: 0x000A1A6E File Offset: 0x0009FC6E
			protected ValueArray(int size)
			{
				this._size = size;
			}

			// Token: 0x060033CF RID: 13263 RVA: 0x000A1A80 File Offset: 0x0009FC80
			public global::NPOI.SS.Formula.Eval.ValueEval GetItem(int index)
			{
				if (index < 0 || index > this._size)
				{
					throw new global::System.ArgumentException(string.Concat(new string[]
					{
						"Specified index ",
						index.ToString(),
						" is outside range (0..",
						(this._size - 1).ToString(),
						")"
					}));
				}
				return this.GetItemInternal(index);
			}

			// Token: 0x060033D0 RID: 13264
			protected abstract global::NPOI.SS.Formula.Eval.ValueEval GetItemInternal(int index);

			// Token: 0x17000D9E RID: 3486
			// (get) Token: 0x060033D1 RID: 13265 RVA: 0x000A1AE7 File Offset: 0x0009FCE7
			public int Size
			{
				get
				{
					return this._size;
				}
			}

			// Token: 0x040018AF RID: 6319
			private int _size;
		}

		// Token: 0x0200056C RID: 1388
		private class SingleCellValueArray : global::NPOI.SS.Formula.Functions.LinearRegressionFunction.ValueArray
		{
			// Token: 0x060033D2 RID: 13266 RVA: 0x000A1AEF File Offset: 0x0009FCEF
			public SingleCellValueArray(global::NPOI.SS.Formula.Eval.ValueEval value) : base(1)
			{
				this._value = value;
			}

			// Token: 0x060033D3 RID: 13267 RVA: 0x000A1AFF File Offset: 0x0009FCFF
			protected override global::NPOI.SS.Formula.Eval.ValueEval GetItemInternal(int index)
			{
				return this._value;
			}

			// Token: 0x040018B0 RID: 6320
			private global::NPOI.SS.Formula.Eval.ValueEval _value;
		}

		// Token: 0x0200056D RID: 1389
		private class RefValueArray : global::NPOI.SS.Formula.Functions.LinearRegressionFunction.ValueArray
		{
			// Token: 0x060033D4 RID: 13268 RVA: 0x000A1B07 File Offset: 0x0009FD07
			public RefValueArray(global::NPOI.SS.Formula.Eval.RefEval ref1) : base(ref1.NumberOfSheets)
			{
				this._ref = ref1;
				this._width = ref1.NumberOfSheets;
			}

			// Token: 0x060033D5 RID: 13269 RVA: 0x000A1B28 File Offset: 0x0009FD28
			protected override global::NPOI.SS.Formula.Eval.ValueEval GetItemInternal(int index)
			{
				int sheetIndex = index % this._width + this._ref.FirstSheetIndex;
				return this._ref.GetInnerValueEval(sheetIndex);
			}

			// Token: 0x040018B1 RID: 6321
			private global::NPOI.SS.Formula.Eval.RefEval _ref;

			// Token: 0x040018B2 RID: 6322
			private int _width;
		}

		// Token: 0x0200056E RID: 1390
		private class AreaValueArray : global::NPOI.SS.Formula.Functions.LinearRegressionFunction.ValueArray
		{
			// Token: 0x060033D6 RID: 13270 RVA: 0x000A1B56 File Offset: 0x0009FD56
			public AreaValueArray(global::NPOI.SS.Formula.TwoDEval ae) : base(ae.Width * ae.Height)
			{
				this._ae = ae;
				this._width = ae.Width;
			}

			// Token: 0x060033D7 RID: 13271 RVA: 0x000A1B80 File Offset: 0x0009FD80
			protected override global::NPOI.SS.Formula.Eval.ValueEval GetItemInternal(int index)
			{
				int rowIndex = index / this._width;
				int columnIndex = index % this._width;
				return this._ae.GetValue(rowIndex, columnIndex);
			}

			// Token: 0x040018B3 RID: 6323
			private global::NPOI.SS.Formula.TwoDEval _ae;

			// Token: 0x040018B4 RID: 6324
			private int _width;
		}

		// Token: 0x0200056F RID: 1391
		public enum FUNCTION
		{
			// Token: 0x040018B6 RID: 6326
			INTERCEPT,
			// Token: 0x040018B7 RID: 6327
			SLOPE
		}
	}
}
