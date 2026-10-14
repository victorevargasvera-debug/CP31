using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001B6 RID: 438
	public abstract class MultiOperandNumericFunction : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000BDE RID: 3038 RVA: 0x00020896 File Offset: 0x0001EA96
		protected MultiOperandNumericFunction(bool isReferenceBoolCounted, bool isBlankCounted)
		{
			this._isReferenceBoolCounted = isReferenceBoolCounted;
			this._isBlankCounted = isBlankCounted;
		}

		// Token: 0x06000BDF RID: 3039
		protected internal abstract double Evaluate(double[] values);

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000208AC File Offset: 0x0001EAAC
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			double num;
			try
			{
				double[] numberArray = this.GetNumberArray(args);
				num = this.Evaluate(numberArray);
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

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00020904 File Offset: 0x0001EB04
		protected virtual int MaxNumOperands
		{
			get
			{
				return 30;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00008875 File Offset: 0x00006A75
		public virtual bool IsSubtotalCounted
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00020908 File Offset: 0x0001EB08
		private void CollectValues(global::NPOI.SS.Formula.Eval.ValueEval operand, global::NPOI.SS.Formula.Functions.MultiOperandNumericFunction.DoubleList temp)
		{
			if (operand is global::NPOI.SS.Formula.ThreeDEval)
			{
				global::NPOI.SS.Formula.ThreeDEval threeDEval = (global::NPOI.SS.Formula.ThreeDEval)operand;
				for (int i = threeDEval.FirstSheetIndex; i <= threeDEval.LastSheetIndex; i++)
				{
					int width = threeDEval.Width;
					int height = threeDEval.Height;
					for (int j = 0; j < height; j++)
					{
						for (int k = 0; k < width; k++)
						{
							global::NPOI.SS.Formula.Eval.ValueEval value = threeDEval.GetValue(i, j, k);
							if (this.IsSubtotalCounted || !threeDEval.IsSubTotal(j, k))
							{
								this.CollectValue(value, true, temp);
							}
						}
					}
				}
				return;
			}
			if (operand is global::NPOI.SS.Formula.TwoDEval)
			{
				global::NPOI.SS.Formula.TwoDEval twoDEval = (global::NPOI.SS.Formula.TwoDEval)operand;
				int width2 = twoDEval.Width;
				int height2 = twoDEval.Height;
				for (int l = 0; l < height2; l++)
				{
					for (int m = 0; m < width2; m++)
					{
						global::NPOI.SS.Formula.Eval.ValueEval value2 = twoDEval.GetValue(l, m);
						if (this.IsSubtotalCounted || !twoDEval.IsSubTotal(l, m))
						{
							this.CollectValue(value2, true, temp);
						}
					}
				}
				return;
			}
			if (operand is global::NPOI.SS.Formula.Eval.RefEval)
			{
				global::NPOI.SS.Formula.Eval.RefEval refEval = (global::NPOI.SS.Formula.Eval.RefEval)operand;
				for (int n = refEval.FirstSheetIndex; n <= refEval.LastSheetIndex; n++)
				{
					this.CollectValue(refEval.GetInnerValueEval(n), true, temp);
				}
				return;
			}
			this.CollectValue(operand, false, temp);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00020A4C File Offset: 0x0001EC4C
		private void CollectValue(global::NPOI.SS.Formula.Eval.ValueEval ve, bool isViaReference, global::NPOI.SS.Formula.Functions.MultiOperandNumericFunction.DoubleList temp)
		{
			if (ve == null)
			{
				throw new global::System.ArgumentException("ve must not be null");
			}
			if (ve is global::NPOI.SS.Formula.Eval.BoolEval)
			{
				if (!isViaReference || this._isReferenceBoolCounted)
				{
					global::NPOI.SS.Formula.Eval.BoolEval boolEval = (global::NPOI.SS.Formula.Eval.BoolEval)ve;
					temp.Add(boolEval.NumberValue);
				}
				return;
			}
			if (ve is global::NPOI.SS.Formula.Eval.NumberEval)
			{
				global::NPOI.SS.Formula.Eval.NumberEval numberEval = (global::NPOI.SS.Formula.Eval.NumberEval)ve;
				temp.Add(numberEval.NumberValue);
				return;
			}
			if (ve is global::NPOI.SS.Formula.Eval.StringEval)
			{
				if (isViaReference)
				{
					return;
				}
				double num = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(((global::NPOI.SS.Formula.Eval.StringEval)ve).StringValue);
				if (double.IsNaN(num))
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
				}
				temp.Add(num);
				return;
			}
			else
			{
				if (ve is global::NPOI.SS.Formula.Eval.ErrorEval)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException((global::NPOI.SS.Formula.Eval.ErrorEval)ve);
				}
				if (ve == global::NPOI.SS.Formula.Eval.BlankEval.instance)
				{
					if (this._isBlankCounted)
					{
						temp.Add(0.0);
					}
					return;
				}
				string str = "Invalid ValueEval type passed for conversion: (";
				global::System.Type type = ve.GetType();
				throw new global::System.InvalidOperationException(str + ((type != null) ? type.ToString() : null) + ")");
			}
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00020B3C File Offset: 0x0001ED3C
		protected double[] GetNumberArray(global::NPOI.SS.Formula.Eval.ValueEval[] operands)
		{
			if (operands.Length > this.MaxNumOperands)
			{
				throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
			}
			global::NPOI.SS.Formula.Functions.MultiOperandNumericFunction.DoubleList doubleList = new global::NPOI.SS.Formula.Functions.MultiOperandNumericFunction.DoubleList();
			int i = 0;
			int num = operands.Length;
			while (i < num)
			{
				this.CollectValues(operands[i], doubleList);
				i++;
			}
			return doubleList.ToArray();
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00020B80 File Offset: 0x0001ED80
		protected static bool AreSubArraysConsistent(double[][] values)
		{
			if (values == null || values.Length < 1)
			{
				return true;
			}
			if (values[0] == null)
			{
				return false;
			}
			int num = values.Length;
			int num2 = values[0].Length;
			for (int i = 1; i < num; i++)
			{
				double[] array = values[i];
				if (array == null)
				{
					return false;
				}
				if (num2 != array.Length)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000582 RID: 1410
		private static double[] EMPTY_DOUBLE_ARRAY = new double[0];

		// Token: 0x04000583 RID: 1411
		private bool _isReferenceBoolCounted;

		// Token: 0x04000584 RID: 1412
		private bool _isBlankCounted;

		// Token: 0x04000585 RID: 1413
		private const int DEFAULT_MAX_NUM_OPERANDS = 30;

		// Token: 0x02000583 RID: 1411
		private class DoubleList
		{
			// Token: 0x0600341E RID: 13342 RVA: 0x000A2751 File Offset: 0x000A0951
			public DoubleList()
			{
				this._array = new double[8];
				this._Count = 0;
			}

			// Token: 0x0600341F RID: 13343 RVA: 0x000A276C File Offset: 0x000A096C
			public double[] ToArray()
			{
				if (this._Count < 1)
				{
					return global::NPOI.SS.Formula.Functions.MultiOperandNumericFunction.EMPTY_DOUBLE_ARRAY;
				}
				double[] array = new double[this._Count];
				global::System.Array.Copy(this._array, 0, array, 0, this._Count);
				return array;
			}

			// Token: 0x06003420 RID: 13344 RVA: 0x000A27AC File Offset: 0x000A09AC
			public void Add(double[] values)
			{
				int num = values.Length;
				this.EnsureCapacity(this._Count + num);
				global::System.Array.Copy(values, 0, this._array, this._Count, num);
				this._Count += num;
			}

			// Token: 0x06003421 RID: 13345 RVA: 0x000A27F0 File Offset: 0x000A09F0
			private void EnsureCapacity(int reqSize)
			{
				if (reqSize > this._array.Length)
				{
					double[] array = new double[reqSize * 3 / 2];
					global::System.Array.Copy(this._array, 0, array, 0, this._Count);
					this._array = array;
				}
			}

			// Token: 0x06003422 RID: 13346 RVA: 0x000A282E File Offset: 0x000A0A2E
			public void Add(double value)
			{
				this.EnsureCapacity(this._Count + 1);
				this._array[this._Count] = value;
				this._Count++;
			}

			// Token: 0x040018E2 RID: 6370
			private double[] _array;

			// Token: 0x040018E3 RID: 6371
			private int _Count;
		}
	}
}
