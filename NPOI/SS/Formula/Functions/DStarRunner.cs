using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Util;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200013B RID: 315
	public class DStarRunner : global::NPOI.SS.Formula.Functions.Function3Arg, global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000A2A RID: 2602 RVA: 0x0001A88B File Offset: 0x00018A8B
		public DStarRunner(global::NPOI.SS.Formula.Functions.DStarRunner.DStarAlgorithmEnum algorithm)
		{
			this.algoType = algorithm;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0001A89A File Offset: 0x00018A9A
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			if (args.Length == 3)
			{
				return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1], args[2]);
			}
			return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0001A8BC File Offset: 0x00018ABC
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval database, global::NPOI.SS.Formula.Eval.ValueEval filterColumn, global::NPOI.SS.Formula.Eval.ValueEval conditionDatabase)
		{
			if (!(database is global::NPOI.SS.Formula.Eval.AreaEval) || !(conditionDatabase is global::NPOI.SS.Formula.Eval.AreaEval))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.AreaEval areaEval = (global::NPOI.SS.Formula.Eval.AreaEval)database;
			global::NPOI.SS.Formula.Eval.AreaEval cdb = (global::NPOI.SS.Formula.Eval.AreaEval)conditionDatabase;
			try
			{
				filterColumn = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(filterColumn, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			int columnForName;
			try
			{
				columnForName = global::NPOI.SS.Formula.Functions.DStarRunner.GetColumnForName(filterColumn, areaEval);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (columnForName == -1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Functions.IDStarAlgorithm idstarAlgorithm = null;
			global::NPOI.SS.Formula.Functions.DStarRunner.DStarAlgorithmEnum dstarAlgorithmEnum = this.algoType;
			if (dstarAlgorithmEnum != global::NPOI.SS.Formula.Functions.DStarRunner.DStarAlgorithmEnum.DGET)
			{
				if (dstarAlgorithmEnum != global::NPOI.SS.Formula.Functions.DStarRunner.DStarAlgorithmEnum.DMIN)
				{
					throw new global::System.InvalidOperationException("Unexpected algorithm type " + this.algoType.ToString() + " encountered.");
				}
				idstarAlgorithm = new global::NPOI.SS.Formula.Functions.DMin();
			}
			else
			{
				idstarAlgorithm = new global::NPOI.SS.Formula.Functions.DGet();
			}
			int height = areaEval.Height;
			for (int i = 1; i < height; i++)
			{
				bool flag = true;
				try
				{
					flag = global::NPOI.SS.Formula.Functions.DStarRunner.FullFillsConditions(areaEval, i, cdb);
				}
				catch (global::NPOI.SS.Formula.Eval.EvaluationException)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				if (flag)
				{
					global::NPOI.SS.Formula.Eval.ValueEval eval = global::NPOI.SS.Formula.Functions.DStarRunner.ResolveReference(areaEval, i, columnForName);
					if (!idstarAlgorithm.ProcessMatch(eval))
					{
						break;
					}
				}
			}
			return idstarAlgorithm.Result;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0001A9F4 File Offset: 0x00018BF4
		private static int GetColumnForName(global::NPOI.SS.Formula.Eval.ValueEval nameValueEval, global::NPOI.SS.Formula.Eval.AreaEval db)
		{
			string name = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(nameValueEval);
			return global::NPOI.SS.Formula.Functions.DStarRunner.GetColumnForString(db, name);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0001AA10 File Offset: 0x00018C10
		private static int GetColumnForString(global::NPOI.SS.Formula.Eval.AreaEval db, string name)
		{
			int result = -1;
			int width = db.Width;
			for (int i = 0; i < width; i++)
			{
				global::NPOI.SS.Formula.Eval.ValueEval valueEval = global::NPOI.SS.Formula.Functions.DStarRunner.ResolveReference(db, 0, i);
				if (!(valueEval is global::NPOI.SS.Formula.Eval.BlankEval) && !(valueEval is global::NPOI.SS.Formula.Eval.ErrorEval))
				{
					string value = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(valueEval);
					if (name.Equals(value))
					{
						result = i;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0001AA64 File Offset: 0x00018C64
		private static bool FullFillsConditions(global::NPOI.SS.Formula.Eval.AreaEval db, int row, global::NPOI.SS.Formula.Eval.AreaEval cdb)
		{
			int height = cdb.Height;
			for (int i = 1; i < height; i++)
			{
				bool flag = true;
				int width = cdb.Width;
				for (int j = 0; j < width; j++)
				{
					bool flag2 = true;
					global::NPOI.SS.Formula.Eval.ValueEval valueEval = global::NPOI.SS.Formula.Functions.DStarRunner.ResolveReference(cdb, i, j);
					if (!(valueEval is global::NPOI.SS.Formula.Eval.BlankEval))
					{
						global::NPOI.SS.Formula.Eval.ValueEval valueEval2 = global::NPOI.SS.Formula.Functions.DStarRunner.ResolveReference(cdb, 0, j);
						if (!(valueEval2 is global::NPOI.SS.Formula.Eval.StringValueEval))
						{
							throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
						}
						if (global::NPOI.SS.Formula.Functions.DStarRunner.GetColumnForName(valueEval2, db) == -1)
						{
							flag2 = false;
						}
						if (flag2)
						{
							if (!global::NPOI.SS.Formula.Functions.DStarRunner.testNormalCondition(global::NPOI.SS.Formula.Functions.DStarRunner.ResolveReference(db, row, global::NPOI.SS.Formula.Functions.DStarRunner.GetColumnForName(valueEval2, db)), valueEval))
							{
								flag = false;
								break;
							}
						}
						else
						{
							if (string.IsNullOrEmpty(global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(valueEval)))
							{
								throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
							}
							throw new global::System.NotImplementedException("D* function with formula conditions");
						}
					}
				}
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0001AB3C File Offset: 0x00018D3C
		private static bool testNormalCondition(global::NPOI.SS.Formula.Eval.ValueEval value, global::NPOI.SS.Formula.Eval.ValueEval condition)
		{
			if (condition is global::NPOI.SS.Formula.Eval.StringEval)
			{
				string stringValue = ((global::NPOI.SS.Formula.Eval.StringEval)condition).StringValue;
				if (stringValue.StartsWith("<"))
				{
					string text = stringValue.Substring(1);
					if (text.StartsWith("="))
					{
						text = text.Substring(1);
						return global::NPOI.SS.Formula.Functions.DStarRunner.testNumericCondition(value, global::NPOI.SS.Formula.Functions.DStarRunner.Operator.smallerEqualThan, text);
					}
					return global::NPOI.SS.Formula.Functions.DStarRunner.testNumericCondition(value, global::NPOI.SS.Formula.Functions.DStarRunner.Operator.smallerThan, text);
				}
				else if (stringValue.StartsWith(">"))
				{
					string text2 = stringValue.Substring(1);
					if (text2.StartsWith("="))
					{
						text2 = text2.Substring(1);
						return global::NPOI.SS.Formula.Functions.DStarRunner.testNumericCondition(value, global::NPOI.SS.Formula.Functions.DStarRunner.Operator.largerEqualThan, text2);
					}
					return global::NPOI.SS.Formula.Functions.DStarRunner.testNumericCondition(value, global::NPOI.SS.Formula.Functions.DStarRunner.Operator.largerThan, text2);
				}
				else if (stringValue.StartsWith("="))
				{
					string text3 = stringValue.Substring(1);
					if (string.IsNullOrEmpty(text3))
					{
						return value is global::NPOI.SS.Formula.Eval.BlankEval;
					}
					bool flag = false;
					try
					{
						int.Parse(text3);
						flag = true;
					}
					catch (global::System.FormatException)
					{
						try
						{
							double.Parse(text3);
							flag = true;
						}
						catch (global::System.FormatException)
						{
							flag = false;
						}
					}
					if (flag)
					{
						return global::NPOI.SS.Formula.Functions.DStarRunner.testNumericCondition(value, global::NPOI.SS.Formula.Functions.DStarRunner.Operator.equal, text3);
					}
					string value2 = (value is global::NPOI.SS.Formula.Eval.BlankEval) ? "" : global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(value);
					return text3.Equals(value2);
				}
				else
				{
					if (string.IsNullOrEmpty(stringValue))
					{
						return value is global::NPOI.SS.Formula.Eval.StringEval;
					}
					return ((value is global::NPOI.SS.Formula.Eval.BlankEval) ? "" : global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(value)).StartsWith(stringValue);
				}
			}
			else
			{
				if (!(condition is global::NPOI.SS.Formula.Eval.NumericValueEval))
				{
					return condition is global::NPOI.SS.Formula.Eval.ErrorEval && value is global::NPOI.SS.Formula.Eval.ErrorEval && ((global::NPOI.SS.Formula.Eval.ErrorEval)condition).ErrorCode == ((global::NPOI.SS.Formula.Eval.ErrorEval)value).ErrorCode;
				}
				double numberValue = ((global::NPOI.SS.Formula.Eval.NumericValueEval)condition).NumberValue;
				double? numberFromValueEval = global::NPOI.SS.Formula.Functions.DStarRunner.GetNumberFromValueEval(value);
				if (numberFromValueEval == null)
				{
					return false;
				}
				double num = numberValue;
				double? num2 = numberFromValueEval;
				return num == num2.GetValueOrDefault() & num2 != null;
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0001AD08 File Offset: 0x00018F08
		private static bool testNumericCondition(global::NPOI.SS.Formula.Eval.ValueEval valueEval, global::NPOI.SS.Formula.Functions.DStarRunner.Operator op, string condition)
		{
			if (!(valueEval is global::NPOI.SS.Formula.Eval.NumericValueEval))
			{
				return false;
			}
			double numberValue = ((global::NPOI.SS.Formula.Eval.NumericValueEval)valueEval).NumberValue;
			double b = 0.0;
			try
			{
				b = (double)int.Parse(condition);
			}
			catch (global::System.FormatException)
			{
				try
				{
					b = double.Parse(condition);
				}
				catch (global::System.FormatException)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
				}
			}
			int num = global::NPOI.SS.Util.NumberComparer.Compare(numberValue, b);
			switch (op)
			{
			case global::NPOI.SS.Formula.Functions.DStarRunner.Operator.largerThan:
				return num > 0;
			case global::NPOI.SS.Formula.Functions.DStarRunner.Operator.largerEqualThan:
				return num >= 0;
			case global::NPOI.SS.Formula.Functions.DStarRunner.Operator.smallerThan:
				return num < 0;
			case global::NPOI.SS.Formula.Functions.DStarRunner.Operator.smallerEqualThan:
				return num <= 0;
			case global::NPOI.SS.Formula.Functions.DStarRunner.Operator.equal:
				return num == 0;
			default:
				return false;
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		private static double? GetNumberFromValueEval(global::NPOI.SS.Formula.Eval.ValueEval value)
		{
			if (value is global::NPOI.SS.Formula.Eval.NumericValueEval)
			{
				return new double?(((global::NPOI.SS.Formula.Eval.NumericValueEval)value).NumberValue);
			}
			if (value is global::NPOI.SS.Formula.Eval.StringValueEval)
			{
				string stringValue = ((global::NPOI.SS.Formula.Eval.StringValueEval)value).StringValue;
				try
				{
					return new double?(double.Parse(stringValue));
				}
				catch (global::System.FormatException)
				{
					return null;
				}
			}
			return null;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0001AE28 File Offset: 0x00019028
		private static global::NPOI.SS.Formula.Eval.ValueEval ResolveReference(global::NPOI.SS.Formula.Eval.AreaEval db, int dbRow, int dbCol)
		{
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				result = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(db.GetValue(dbRow, dbCol), db.FirstRow + dbRow, db.FirstColumn + dbCol);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x04000515 RID: 1301
		private global::NPOI.SS.Formula.Functions.DStarRunner.DStarAlgorithmEnum algoType;

		// Token: 0x02000569 RID: 1385
		public enum DStarAlgorithmEnum
		{
			// Token: 0x040018A7 RID: 6311
			DGET,
			// Token: 0x040018A8 RID: 6312
			DMIN
		}

		// Token: 0x0200056A RID: 1386
		private enum Operator
		{
			// Token: 0x040018AA RID: 6314
			largerThan,
			// Token: 0x040018AB RID: 6315
			largerEqualThan,
			// Token: 0x040018AC RID: 6316
			smallerThan,
			// Token: 0x040018AD RID: 6317
			smallerEqualThan,
			// Token: 0x040018AE RID: 6318
			equal
		}
	}
}
