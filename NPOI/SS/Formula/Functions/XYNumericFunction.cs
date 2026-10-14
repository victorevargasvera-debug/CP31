using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000201 RID: 513
	public abstract class XYNumericFunction : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000CCB RID: 3275 RVA: 0x0002305C File Offset: 0x0002125C
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			double num;
			try
			{
				global::NPOI.SS.Formula.Functions.ValueVector valueVector = global::NPOI.SS.Formula.Functions.XYNumericFunction.CreateValueVector(arg0);
				global::NPOI.SS.Formula.Functions.ValueVector valueVector2 = global::NPOI.SS.Formula.Functions.XYNumericFunction.CreateValueVector(arg1);
				int size = valueVector.Size;
				if (size == 0 || valueVector2.Size != size)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.NA;
				}
				num = this.EvaluateInternal(valueVector, valueVector2, size);
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

		// Token: 0x06000CCC RID: 3276
		public abstract global::NPOI.SS.Formula.Functions.Accumulator CreateAccumulator();

		// Token: 0x06000CCD RID: 3277 RVA: 0x000230D8 File Offset: 0x000212D8
		private double EvaluateInternal(global::NPOI.SS.Formula.Functions.ValueVector x, global::NPOI.SS.Formula.Functions.ValueVector y, int size)
		{
			global::NPOI.SS.Formula.Functions.Accumulator accumulator = this.CreateAccumulator();
			global::NPOI.SS.Formula.Eval.ErrorEval errorEval = null;
			global::NPOI.SS.Formula.Eval.ErrorEval errorEval2 = null;
			bool flag = false;
			double num = 0.0;
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
					num += accumulator.Accumulate(numberEval.NumberValue, numberEval2.NumberValue);
				}
			}
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
			return num;
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x000231B8 File Offset: 0x000213B8
		private static double[] TrimToSize(double[] arr, int len)
		{
			double[] array = arr;
			if (arr.Length > len)
			{
				array = new double[len];
				global::System.Array.Copy(arr, 0, array, 0, len);
			}
			return array;
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x000231DF File Offset: 0x000213DF
		private static bool IsNumberEval(global::NPOI.SS.Formula.Eval.Eval eval)
		{
			throw new global::System.InvalidOperationException("not found in poi");
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x000231DF File Offset: 0x000213DF
		private static double GetDoubleValue(global::NPOI.SS.Formula.Eval.Eval eval)
		{
			throw new global::System.InvalidOperationException("not found in poi");
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x000231EC File Offset: 0x000213EC
		private static global::NPOI.SS.Formula.Functions.ValueVector CreateValueVector(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			if (arg is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException((global::NPOI.SS.Formula.Eval.ErrorEval)arg);
			}
			if (arg is global::NPOI.SS.Formula.TwoDEval)
			{
				return new global::NPOI.SS.Formula.Functions.XYNumericFunction.AreaValueArray((global::NPOI.SS.Formula.TwoDEval)arg);
			}
			if (arg is global::NPOI.SS.Formula.Eval.RefEval)
			{
				return new global::NPOI.SS.Formula.Functions.XYNumericFunction.RefValueArray((global::NPOI.SS.Formula.Eval.RefEval)arg);
			}
			return new global::NPOI.SS.Formula.Functions.XYNumericFunction.SingleCellValueArray(arg);
		}

		// Token: 0x040005D4 RID: 1492
		protected static int X = 0;

		// Token: 0x040005D5 RID: 1493
		protected static int Y = 1;

		// Token: 0x0200058A RID: 1418
		private abstract class ValueArray : global::NPOI.SS.Formula.Functions.ValueVector
		{
			// Token: 0x06003438 RID: 13368 RVA: 0x000A2A7F File Offset: 0x000A0C7F
			protected ValueArray(int size)
			{
				this._size = size;
			}

			// Token: 0x06003439 RID: 13369 RVA: 0x000A2A90 File Offset: 0x000A0C90
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

			// Token: 0x0600343A RID: 13370
			protected abstract global::NPOI.SS.Formula.Eval.ValueEval GetItemInternal(int index);

			// Token: 0x17000DB2 RID: 3506
			// (get) Token: 0x0600343B RID: 13371 RVA: 0x000A2AF7 File Offset: 0x000A0CF7
			public int Size
			{
				get
				{
					return this._size;
				}
			}

			// Token: 0x040018EE RID: 6382
			private int _size;
		}

		// Token: 0x0200058B RID: 1419
		private class SingleCellValueArray : global::NPOI.SS.Formula.Functions.XYNumericFunction.ValueArray
		{
			// Token: 0x0600343C RID: 13372 RVA: 0x000A2AFF File Offset: 0x000A0CFF
			public SingleCellValueArray(global::NPOI.SS.Formula.Eval.ValueEval value) : base(1)
			{
				this._value = value;
			}

			// Token: 0x0600343D RID: 13373 RVA: 0x000A2B0F File Offset: 0x000A0D0F
			protected override global::NPOI.SS.Formula.Eval.ValueEval GetItemInternal(int index)
			{
				return this._value;
			}

			// Token: 0x040018EF RID: 6383
			private global::NPOI.SS.Formula.Eval.ValueEval _value;
		}

		// Token: 0x0200058C RID: 1420
		private class RefValueArray : global::NPOI.SS.Formula.Functions.XYNumericFunction.ValueArray
		{
			// Token: 0x0600343E RID: 13374 RVA: 0x000A2B17 File Offset: 0x000A0D17
			public RefValueArray(global::NPOI.SS.Formula.Eval.RefEval ref1) : base(ref1.NumberOfSheets)
			{
				this._ref = ref1;
				this._width = ref1.NumberOfSheets;
			}

			// Token: 0x0600343F RID: 13375 RVA: 0x000A2B38 File Offset: 0x000A0D38
			protected override global::NPOI.SS.Formula.Eval.ValueEval GetItemInternal(int index)
			{
				int sheetIndex = index % this._width + this._ref.FirstSheetIndex;
				return this._ref.GetInnerValueEval(sheetIndex);
			}

			// Token: 0x040018F0 RID: 6384
			private global::NPOI.SS.Formula.Eval.RefEval _ref;

			// Token: 0x040018F1 RID: 6385
			private int _width;
		}

		// Token: 0x0200058D RID: 1421
		private class AreaValueArray : global::NPOI.SS.Formula.Functions.XYNumericFunction.ValueArray
		{
			// Token: 0x06003440 RID: 13376 RVA: 0x000A2B66 File Offset: 0x000A0D66
			public AreaValueArray(global::NPOI.SS.Formula.TwoDEval ae) : base(ae.Width * ae.Height)
			{
				this._ae = ae;
				this._width = ae.Width;
			}

			// Token: 0x06003441 RID: 13377 RVA: 0x000A2B90 File Offset: 0x000A0D90
			protected override global::NPOI.SS.Formula.Eval.ValueEval GetItemInternal(int index)
			{
				int rowIndex = index / this._width;
				int columnIndex = index % this._width;
				return this._ae.GetValue(rowIndex, columnIndex);
			}

			// Token: 0x040018F2 RID: 6386
			private global::NPOI.SS.Formula.TwoDEval _ae;

			// Token: 0x040018F3 RID: 6387
			private int _width;
		}

		// Token: 0x0200058E RID: 1422
		protected class DoubleArrayPair
		{
			// Token: 0x06003442 RID: 13378 RVA: 0x000A2BBC File Offset: 0x000A0DBC
			public DoubleArrayPair(double[] xArray, double[] yArray)
			{
				this._xArray = xArray;
				this._yArray = yArray;
			}

			// Token: 0x06003443 RID: 13379 RVA: 0x000A2BD2 File Offset: 0x000A0DD2
			public double[] GetXArray()
			{
				return this._xArray;
			}

			// Token: 0x06003444 RID: 13380 RVA: 0x000A2BDA File Offset: 0x000A0DDA
			public double[] GetYArray()
			{
				return this._yArray;
			}

			// Token: 0x040018F4 RID: 6388
			private double[] _xArray;

			// Token: 0x040018F5 RID: 6389
			private double[] _yArray;
		}
	}
}
