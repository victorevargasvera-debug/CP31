using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200017B RID: 379
	public class Countif : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000AFE RID: 2814 RVA: 0x0001D990 File Offset: 0x0001BB90
		private double CountMatchingCellsInArea(global::NPOI.SS.Formula.Eval.ValueEval rangeArg, global::NPOI.SS.Formula.Functions.IMatchPredicate criteriaPredicate)
		{
			if (rangeArg is global::NPOI.SS.Formula.Eval.RefEval)
			{
				return (double)global::NPOI.SS.Formula.Functions.CountUtils.CountMatchingCellsInRef((global::NPOI.SS.Formula.Eval.RefEval)rangeArg, criteriaPredicate);
			}
			if (rangeArg is global::NPOI.SS.Formula.ThreeDEval)
			{
				return (double)global::NPOI.SS.Formula.Functions.CountUtils.CountMatchingCellsInArea((global::NPOI.SS.Formula.ThreeDEval)rangeArg, criteriaPredicate);
			}
			throw new global::System.ArgumentException("Bad range arg type (" + rangeArg.GetType().Name + ")");
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0001D9E8 File Offset: 0x0001BBE8
		private static global::NPOI.SS.Formula.Eval.ValueEval EvaluateCriteriaArg(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcRowIndex, int srcColumnIndex)
		{
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				result = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcRowIndex, (int)((short)srcColumnIndex));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0001DA1C File Offset: 0x0001BC1C
		private static global::NPOI.SS.Formula.Functions.IMatchPredicate CreateGeneralMatchPredicate(global::NPOI.SS.Formula.Eval.StringEval stringEval)
		{
			string text = stringEval.StringValue;
			global::NPOI.SS.Formula.Functions.Countif.CmpOp @operator = global::NPOI.SS.Formula.Functions.Countif.CmpOp.GetOperator(text);
			text = text.Substring(@operator.Length);
			bool? flag = global::NPOI.SS.Formula.Functions.Countif.ParseBoolean(text);
			if (flag != null)
			{
				return new global::NPOI.SS.Formula.Functions.Countif.BooleanMatcher(flag.Value, @operator);
			}
			double num = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(text);
			if (!double.IsNaN(num))
			{
				return new global::NPOI.SS.Formula.Functions.Countif.NumberMatcher(num, @operator);
			}
			global::NPOI.SS.Formula.Eval.ErrorEval errorEval = global::NPOI.SS.Formula.Functions.Countif.ParseError(text);
			if (errorEval != null)
			{
				return new global::NPOI.SS.Formula.Functions.Countif.ErrorMatcher(errorEval.ErrorCode, @operator);
			}
			return new global::NPOI.SS.Formula.Functions.Countif.StringMatcher(text, @operator);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0001DA9C File Offset: 0x0001BC9C
		public static global::NPOI.SS.Formula.Functions.IMatchPredicate CreateCriteriaPredicate(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcRowIndex, int srcColumnIndex)
		{
			global::NPOI.SS.Formula.Eval.ValueEval valueEval = global::NPOI.SS.Formula.Functions.Countif.EvaluateCriteriaArg(arg, srcRowIndex, srcColumnIndex);
			if (valueEval is global::NPOI.SS.Formula.Eval.NumberEval)
			{
				return new global::NPOI.SS.Formula.Functions.Countif.NumberMatcher(((global::NPOI.SS.Formula.Eval.NumberEval)valueEval).NumberValue, global::NPOI.SS.Formula.Functions.Countif.CmpOp.OP_NONE);
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.BoolEval)
			{
				return new global::NPOI.SS.Formula.Functions.Countif.BooleanMatcher(((global::NPOI.SS.Formula.Eval.BoolEval)valueEval).BooleanValue, global::NPOI.SS.Formula.Functions.Countif.CmpOp.OP_NONE);
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.StringEval)
			{
				return global::NPOI.SS.Formula.Functions.Countif.CreateGeneralMatchPredicate((global::NPOI.SS.Formula.Eval.StringEval)valueEval);
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				return new global::NPOI.SS.Formula.Functions.Countif.ErrorMatcher(((global::NPOI.SS.Formula.Eval.ErrorEval)valueEval).ErrorCode, global::NPOI.SS.Formula.Functions.Countif.CmpOp.OP_NONE);
			}
			if (valueEval == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return null;
			}
			throw new global::System.Exception("Unexpected type for criteria (" + valueEval.GetType().Name + ")");
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0001DB4C File Offset: 0x0001BD4C
		private static global::NPOI.SS.Formula.Eval.ErrorEval ParseError(string value)
		{
			if (value.Length < 4 || value[0] != '#')
			{
				return null;
			}
			if (value.Equals("#NULL!"))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NULL_INTERSECTION;
			}
			if (value.Equals("#DIV/0!"))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.DIV_ZERO;
			}
			if (value.Equals("#VALUE!"))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (value.Equals("#REF!"))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
			}
			if (value.Equals("#NAME?"))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NAME_INVALID;
			}
			if (value.Equals("#NUM!"))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			if (value.Equals("#N/A"))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NA;
			}
			return null;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0001DBF8 File Offset: 0x0001BDF8
		public static bool? ParseBoolean(string strRep)
		{
			if (strRep.Length < 1)
			{
				return null;
			}
			char c = strRep[0];
			if (c <= 'T')
			{
				if (c == 'F')
				{
					goto IL_4B;
				}
				if (c != 'T')
				{
					goto IL_60;
				}
			}
			else
			{
				if (c == 'f')
				{
					goto IL_4B;
				}
				if (c != 't')
				{
					goto IL_60;
				}
			}
			if ("TRUE".Equals(strRep, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return new bool?(true);
			}
			goto IL_60;
			IL_4B:
			if ("FALSE".Equals(strRep, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return new bool?(false);
			}
			IL_60:
			return null;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0001DC70 File Offset: 0x0001BE70
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			global::NPOI.SS.Formula.Functions.IMatchPredicate matchPredicate = global::NPOI.SS.Formula.Functions.Countif.CreateCriteriaPredicate(arg1, srcRowIndex, srcColumnIndex);
			if (matchPredicate == null)
			{
				return global::NPOI.SS.Formula.Eval.NumberEval.ZERO;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(this.CountMatchingCellsInArea(arg0, matchPredicate));
		}

		// Token: 0x02000577 RID: 1399
		public class CmpOp
		{
			// Token: 0x060033EB RID: 13291 RVA: 0x000A1C72 File Offset: 0x0009FE72
			private static global::NPOI.SS.Formula.Functions.Countif.CmpOp op(string rep, int code)
			{
				return new global::NPOI.SS.Formula.Functions.Countif.CmpOp(rep, code);
			}

			// Token: 0x060033EC RID: 13292 RVA: 0x000A1C7B File Offset: 0x0009FE7B
			private CmpOp(string representation, int code)
			{
				this._representation = representation;
				this._code = code;
			}

			// Token: 0x17000D9F RID: 3487
			// (get) Token: 0x060033ED RID: 13293 RVA: 0x000A1C91 File Offset: 0x0009FE91
			public int Length
			{
				get
				{
					return this._representation.Length;
				}
			}

			// Token: 0x17000DA0 RID: 3488
			// (get) Token: 0x060033EE RID: 13294 RVA: 0x000A1C9E File Offset: 0x0009FE9E
			public int Code
			{
				get
				{
					return this._code;
				}
			}

			// Token: 0x060033EF RID: 13295 RVA: 0x000A1CA8 File Offset: 0x0009FEA8
			public static global::NPOI.SS.Formula.Functions.Countif.CmpOp GetOperator(string value)
			{
				int length = value.Length;
				if (length < 1)
				{
					return global::NPOI.SS.Formula.Functions.Countif.CmpOp.OP_NONE;
				}
				switch (value[0])
				{
				case '<':
					if (length > 1)
					{
						char c = value[1];
						if (c == '=')
						{
							return global::NPOI.SS.Formula.Functions.Countif.CmpOp.OP_LE;
						}
						if (c == '>')
						{
							return global::NPOI.SS.Formula.Functions.Countif.CmpOp.OP_NE;
						}
					}
					return global::NPOI.SS.Formula.Functions.Countif.CmpOp.OP_LT;
				case '=':
					return global::NPOI.SS.Formula.Functions.Countif.CmpOp.OP_EQ;
				case '>':
					if (length > 1 && value[1] == '=')
					{
						return global::NPOI.SS.Formula.Functions.Countif.CmpOp.OP_GE;
					}
					return global::NPOI.SS.Formula.Functions.Countif.CmpOp.OP_GT;
				default:
					return global::NPOI.SS.Formula.Functions.Countif.CmpOp.OP_NONE;
				}
			}

			// Token: 0x060033F0 RID: 13296 RVA: 0x000A1D38 File Offset: 0x0009FF38
			public bool Evaluate(bool cmpResult)
			{
				int code = this._code;
				if (code <= 1)
				{
					return cmpResult;
				}
				if (code != 2)
				{
					throw new global::System.Exception("Cannot call bool Evaluate on non-equality operator '" + this._representation + "'");
				}
				return !cmpResult;
			}

			// Token: 0x060033F1 RID: 13297 RVA: 0x000A1D78 File Offset: 0x0009FF78
			public bool Evaluate(int cmpResult)
			{
				switch (this._code)
				{
				case 0:
				case 1:
					return cmpResult == 0;
				case 2:
					return cmpResult != 0;
				case 3:
					return cmpResult <= 0;
				case 4:
					return cmpResult < 0;
				case 5:
					return cmpResult > 0;
				case 6:
					return cmpResult >= 0;
				default:
					throw new global::System.Exception("Cannot call bool Evaluate on non-equality operator '" + this._representation + "'");
				}
			}

			// Token: 0x060033F2 RID: 13298 RVA: 0x000A1DF0 File Offset: 0x0009FFF0
			public override string ToString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
				stringBuilder.Append(base.GetType().Name);
				stringBuilder.Append(" [").Append(this._representation).Append("]");
				return stringBuilder.ToString();
			}

			// Token: 0x17000DA1 RID: 3489
			// (get) Token: 0x060033F3 RID: 13299 RVA: 0x000A1E3C File Offset: 0x000A003C
			public string Representation
			{
				get
				{
					return this._representation;
				}
			}

			// Token: 0x040018BB RID: 6331
			public const int NONE = 0;

			// Token: 0x040018BC RID: 6332
			public const int EQ = 1;

			// Token: 0x040018BD RID: 6333
			public const int NE = 2;

			// Token: 0x040018BE RID: 6334
			public const int LE = 3;

			// Token: 0x040018BF RID: 6335
			public const int LT = 4;

			// Token: 0x040018C0 RID: 6336
			public const int GT = 5;

			// Token: 0x040018C1 RID: 6337
			public const int GE = 6;

			// Token: 0x040018C2 RID: 6338
			public static readonly global::NPOI.SS.Formula.Functions.Countif.CmpOp OP_NONE = global::NPOI.SS.Formula.Functions.Countif.CmpOp.op("", 0);

			// Token: 0x040018C3 RID: 6339
			public static readonly global::NPOI.SS.Formula.Functions.Countif.CmpOp OP_EQ = global::NPOI.SS.Formula.Functions.Countif.CmpOp.op("=", 1);

			// Token: 0x040018C4 RID: 6340
			public static readonly global::NPOI.SS.Formula.Functions.Countif.CmpOp OP_NE = global::NPOI.SS.Formula.Functions.Countif.CmpOp.op("<>", 2);

			// Token: 0x040018C5 RID: 6341
			public static readonly global::NPOI.SS.Formula.Functions.Countif.CmpOp OP_LE = global::NPOI.SS.Formula.Functions.Countif.CmpOp.op("<=", 3);

			// Token: 0x040018C6 RID: 6342
			public static readonly global::NPOI.SS.Formula.Functions.Countif.CmpOp OP_LT = global::NPOI.SS.Formula.Functions.Countif.CmpOp.op("<", 4);

			// Token: 0x040018C7 RID: 6343
			public static readonly global::NPOI.SS.Formula.Functions.Countif.CmpOp OP_GT = global::NPOI.SS.Formula.Functions.Countif.CmpOp.op(">", 5);

			// Token: 0x040018C8 RID: 6344
			public static readonly global::NPOI.SS.Formula.Functions.Countif.CmpOp OP_GE = global::NPOI.SS.Formula.Functions.Countif.CmpOp.op(">=", 6);

			// Token: 0x040018C9 RID: 6345
			private string _representation;

			// Token: 0x040018CA RID: 6346
			private int _code;
		}

		// Token: 0x02000578 RID: 1400
		public abstract class MatcherBase : global::NPOI.SS.Formula.Functions.IMatchPredicate
		{
			// Token: 0x060033F5 RID: 13301 RVA: 0x000A1EC1 File Offset: 0x000A00C1
			public MatcherBase(global::NPOI.SS.Formula.Functions.Countif.CmpOp operator1)
			{
				this._operator = operator1;
			}

			// Token: 0x17000DA2 RID: 3490
			// (get) Token: 0x060033F6 RID: 13302 RVA: 0x000A1ED0 File Offset: 0x000A00D0
			protected int Code
			{
				get
				{
					return this._operator.Code;
				}
			}

			// Token: 0x060033F7 RID: 13303 RVA: 0x000A1EDD File Offset: 0x000A00DD
			protected bool Evaluate(int cmpResult)
			{
				return this._operator.Evaluate(cmpResult);
			}

			// Token: 0x060033F8 RID: 13304 RVA: 0x000A1EEB File Offset: 0x000A00EB
			protected bool Evaluate(bool cmpResult)
			{
				return this._operator.Evaluate(cmpResult);
			}

			// Token: 0x060033F9 RID: 13305 RVA: 0x000A1EFC File Offset: 0x000A00FC
			public override string ToString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
				stringBuilder.Append(base.GetType().Name).Append(" [");
				stringBuilder.Append(this._operator.Representation);
				stringBuilder.Append(this.ValueText);
				stringBuilder.Append("]");
				return stringBuilder.ToString();
			}

			// Token: 0x17000DA3 RID: 3491
			// (get) Token: 0x060033FA RID: 13306
			protected abstract string ValueText { get; }

			// Token: 0x060033FB RID: 13307
			public abstract bool Matches(global::NPOI.SS.Formula.Eval.ValueEval x);

			// Token: 0x040018CB RID: 6347
			private global::NPOI.SS.Formula.Functions.Countif.CmpOp _operator;
		}

		// Token: 0x02000579 RID: 1401
		public class ErrorMatcher : global::NPOI.SS.Formula.Functions.Countif.MatcherBase
		{
			// Token: 0x060033FC RID: 13308 RVA: 0x000A1F5C File Offset: 0x000A015C
			public ErrorMatcher(int errorCode, global::NPOI.SS.Formula.Functions.Countif.CmpOp operator1) : base(operator1)
			{
				this._value = errorCode;
			}

			// Token: 0x17000DA4 RID: 3492
			// (get) Token: 0x060033FD RID: 13309 RVA: 0x000A1F6C File Offset: 0x000A016C
			protected override string ValueText
			{
				get
				{
					return global::NPOI.SS.UserModel.FormulaError.ForInt(this._value).String;
				}
			}

			// Token: 0x060033FE RID: 13310 RVA: 0x000A1F80 File Offset: 0x000A0180
			public override bool Matches(global::NPOI.SS.Formula.Eval.ValueEval x)
			{
				if (x is global::NPOI.SS.Formula.Eval.ErrorEval)
				{
					int errorCode = ((global::NPOI.SS.Formula.Eval.ErrorEval)x).ErrorCode;
					return base.Evaluate(errorCode - this._value);
				}
				return false;
			}

			// Token: 0x17000DA5 RID: 3493
			// (get) Token: 0x060033FF RID: 13311 RVA: 0x000A1FB1 File Offset: 0x000A01B1
			public int Value
			{
				get
				{
					return this._value;
				}
			}

			// Token: 0x040018CC RID: 6348
			private int _value;
		}

		// Token: 0x0200057A RID: 1402
		private class NumberMatcher : global::NPOI.SS.Formula.Functions.Countif.MatcherBase
		{
			// Token: 0x06003400 RID: 13312 RVA: 0x000A1FB9 File Offset: 0x000A01B9
			public NumberMatcher(double value, global::NPOI.SS.Formula.Functions.Countif.CmpOp optr) : base(optr)
			{
				this._value = value;
			}

			// Token: 0x06003401 RID: 13313 RVA: 0x000A1FCC File Offset: 0x000A01CC
			public override bool Matches(global::NPOI.SS.Formula.Eval.ValueEval x)
			{
				if (x is global::NPOI.SS.Formula.Eval.StringEval)
				{
					int code = base.Code;
					if (code > 1)
					{
						return code == 2;
					}
					double num = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(((global::NPOI.SS.Formula.Eval.StringEval)x).StringValue);
					return !double.IsNaN(num) && this._value == num;
				}
				else
				{
					if (x is global::NPOI.SS.Formula.Eval.NumberEval)
					{
						return base.Evaluate(((global::NPOI.SS.Formula.Eval.NumberEval)x).NumberValue.CompareTo(this._value));
					}
					return x is global::NPOI.SS.Formula.Eval.BlankEval && base.Code == 2;
				}
			}

			// Token: 0x17000DA6 RID: 3494
			// (get) Token: 0x06003402 RID: 13314 RVA: 0x000A2059 File Offset: 0x000A0259
			protected override string ValueText
			{
				get
				{
					return this._value.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				}
			}

			// Token: 0x040018CD RID: 6349
			private double _value;
		}

		// Token: 0x0200057B RID: 1403
		private class BooleanMatcher : global::NPOI.SS.Formula.Functions.Countif.MatcherBase
		{
			// Token: 0x06003403 RID: 13315 RVA: 0x000A206B File Offset: 0x000A026B
			public BooleanMatcher(bool value, global::NPOI.SS.Formula.Functions.Countif.CmpOp optr) : base(optr)
			{
				this._value = global::NPOI.SS.Formula.Functions.Countif.BooleanMatcher.BoolToInt(value);
			}

			// Token: 0x06003404 RID: 13316 RVA: 0x000A2080 File Offset: 0x000A0280
			private static int BoolToInt(bool value)
			{
				if (!value)
				{
					return 0;
				}
				return 1;
			}

			// Token: 0x06003405 RID: 13317 RVA: 0x000A2088 File Offset: 0x000A0288
			public override bool Matches(global::NPOI.SS.Formula.Eval.ValueEval x)
			{
				if (x is global::NPOI.SS.Formula.Eval.StringEval)
				{
					return false;
				}
				if (x is global::NPOI.SS.Formula.Eval.BoolEval)
				{
					int num = global::NPOI.SS.Formula.Functions.Countif.BooleanMatcher.BoolToInt(((global::NPOI.SS.Formula.Eval.BoolEval)x).BooleanValue);
					return base.Evaluate(num - this._value);
				}
				if (x is global::NPOI.SS.Formula.Eval.BlankEval)
				{
					return base.Code == 2;
				}
				return x is global::NPOI.SS.Formula.Eval.NumberEval && base.Code == 2;
			}

			// Token: 0x17000DA7 RID: 3495
			// (get) Token: 0x06003406 RID: 13318 RVA: 0x000A20F4 File Offset: 0x000A02F4
			protected override string ValueText
			{
				get
				{
					if (this._value != 1)
					{
						return "FALSE";
					}
					return "TRUE";
				}
			}

			// Token: 0x040018CE RID: 6350
			private int _value;
		}

		// Token: 0x0200057C RID: 1404
		internal class StringMatcher : global::NPOI.SS.Formula.Functions.Countif.MatcherBase
		{
			// Token: 0x06003407 RID: 13319 RVA: 0x000A210C File Offset: 0x000A030C
			public StringMatcher(string value, global::NPOI.SS.Formula.Functions.Countif.CmpOp optr) : base(optr)
			{
				this._value = value;
				this._operator = optr;
				int code = optr.Code;
				if (code <= 2)
				{
					this._pattern = global::NPOI.SS.Formula.Functions.Countif.StringMatcher.GetWildCardPattern(value);
					return;
				}
				this._pattern = null;
			}

			// Token: 0x06003408 RID: 13320 RVA: 0x000A2150 File Offset: 0x000A0350
			public override bool Matches(global::NPOI.SS.Formula.Eval.ValueEval x)
			{
				if (x is global::NPOI.SS.Formula.Eval.BlankEval)
				{
					int code = this._operator.Code;
					if (code > 1)
					{
						return code == 2 && this._value.Length != 0;
					}
					return this._value.Length == 0;
				}
				else
				{
					if (!(x is global::NPOI.SS.Formula.Eval.StringEval))
					{
						return this._operator.Code == 2;
					}
					string stringValue = ((global::NPOI.SS.Formula.Eval.StringEval)x).StringValue;
					if (stringValue.Length < 1 && this._value.Length < 1)
					{
						switch (this._operator.Code)
						{
						case 0:
							return true;
						case 1:
							return false;
						case 2:
							return true;
						default:
							return false;
						}
					}
					else
					{
						if (this._pattern != null)
						{
							return base.Evaluate(this._pattern.IsMatch(stringValue));
						}
						return base.Evaluate(string.Compare(stringValue, this._value, global::System.StringComparison.CurrentCultureIgnoreCase));
					}
				}
			}

			// Token: 0x06003409 RID: 13321 RVA: 0x000A2230 File Offset: 0x000A0430
			internal static global::System.Text.RegularExpressions.Regex GetWildCardPattern(string value)
			{
				int length = value.Length;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(length);
				stringBuilder.Append("^");
				bool flag = false;
				int i = 0;
				while (i < length)
				{
					char c = value[i];
					if (c <= '.')
					{
						switch (c)
						{
						case '$':
						case '(':
						case ')':
							goto IL_F2;
						case '%':
						case '&':
						case '\'':
							goto IL_107;
						case '*':
							flag = true;
							stringBuilder.Append(".*");
							break;
						default:
							if (c != '.')
							{
								goto IL_107;
							}
							goto IL_F2;
						}
					}
					else if (c != '?')
					{
						switch (c)
						{
						case '[':
						case ']':
						case '^':
							goto IL_F2;
						case '\\':
							goto IL_107;
						default:
							if (c != '~')
							{
								goto IL_107;
							}
							if (i + 1 < length)
							{
								c = value[i + 1];
								if (c == '*' || c == '?')
								{
									flag = true;
									stringBuilder.Append('[').Append(c).Append(']');
									i++;
									break;
								}
							}
							stringBuilder.Append('~');
							break;
						}
					}
					else
					{
						flag = true;
						stringBuilder.Append('.');
					}
					IL_110:
					i++;
					continue;
					IL_F2:
					stringBuilder.Append("\\").Append(c);
					goto IL_110;
					IL_107:
					stringBuilder.Append(c);
					goto IL_110;
				}
				stringBuilder.Append("$");
				if (flag)
				{
					return new global::System.Text.RegularExpressions.Regex(stringBuilder.ToString(), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
				}
				return null;
			}

			// Token: 0x17000DA8 RID: 3496
			// (get) Token: 0x0600340A RID: 13322 RVA: 0x000A2375 File Offset: 0x000A0575
			protected override string ValueText
			{
				get
				{
					if (this._pattern == null)
					{
						return this._value;
					}
					return this._pattern.ToString();
				}
			}

			// Token: 0x040018CF RID: 6351
			private string _value;

			// Token: 0x040018D0 RID: 6352
			private global::NPOI.SS.Formula.Functions.Countif.CmpOp _operator;

			// Token: 0x040018D1 RID: 6353
			private global::System.Text.RegularExpressions.Regex _pattern;
		}
	}
}
