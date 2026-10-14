using System;
using System.Collections;
using System.Reflection;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;
using NPOI.SS.Formula.PTG;

namespace NPOI.SS.Formula
{
	// Token: 0x020000D7 RID: 215
	internal class OperationEvaluatorFactory
	{
		// Token: 0x0600073C RID: 1852 RVA: 0x0000253E File Offset: 0x0000073E
		private OperationEvaluatorFactory()
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00012FF0 File Offset: 0x000111F0
		private static global::System.Collections.Hashtable InitialiseInstancesMap()
		{
			return new global::System.Collections.Hashtable(32)
			{
				{
					global::NPOI.SS.Formula.PTG.EqualPtg.instance,
					global::NPOI.SS.Formula.Eval.RelationalOperationEval.EqualEval
				},
				{
					global::NPOI.SS.Formula.PTG.GreaterEqualPtg.instance,
					global::NPOI.SS.Formula.Eval.RelationalOperationEval.GreaterEqualEval
				},
				{
					global::NPOI.SS.Formula.PTG.GreaterThanPtg.instance,
					global::NPOI.SS.Formula.Eval.RelationalOperationEval.GreaterThanEval
				},
				{
					global::NPOI.SS.Formula.PTG.LessEqualPtg.instance,
					global::NPOI.SS.Formula.Eval.RelationalOperationEval.LessEqualEval
				},
				{
					global::NPOI.SS.Formula.PTG.LessThanPtg.instance,
					global::NPOI.SS.Formula.Eval.RelationalOperationEval.LessThanEval
				},
				{
					global::NPOI.SS.Formula.PTG.NotEqualPtg.instance,
					global::NPOI.SS.Formula.Eval.RelationalOperationEval.NotEqualEval
				},
				{
					global::NPOI.SS.Formula.PTG.ConcatPtg.instance,
					global::NPOI.SS.Formula.Eval.ConcatEval.instance
				},
				{
					global::NPOI.SS.Formula.PTG.AddPtg.instance,
					global::NPOI.SS.Formula.Eval.TwoOperandNumericOperation.AddEval
				},
				{
					global::NPOI.SS.Formula.PTG.DividePtg.instance,
					global::NPOI.SS.Formula.Eval.TwoOperandNumericOperation.DivideEval
				},
				{
					global::NPOI.SS.Formula.PTG.MultiplyPtg.instance,
					global::NPOI.SS.Formula.Eval.TwoOperandNumericOperation.MultiplyEval
				},
				{
					global::NPOI.SS.Formula.PTG.PercentPtg.instance,
					global::NPOI.SS.Formula.Eval.PercentEval.instance
				},
				{
					global::NPOI.SS.Formula.PTG.PowerPtg.instance,
					global::NPOI.SS.Formula.Eval.TwoOperandNumericOperation.PowerEval
				},
				{
					global::NPOI.SS.Formula.PTG.SubtractPtg.instance,
					global::NPOI.SS.Formula.Eval.TwoOperandNumericOperation.SubtractEval
				},
				{
					global::NPOI.SS.Formula.PTG.UnaryMinusPtg.instance,
					global::NPOI.SS.Formula.Eval.UnaryMinusEval.instance
				},
				{
					global::NPOI.SS.Formula.PTG.UnaryPlusPtg.instance,
					global::NPOI.SS.Formula.Eval.UnaryPlusEval.instance
				},
				{
					global::NPOI.SS.Formula.PTG.RangePtg.instance,
					global::NPOI.SS.Formula.Eval.RangeEval.instance
				},
				{
					global::NPOI.SS.Formula.PTG.IntersectionPtg.instance,
					global::NPOI.SS.Formula.Eval.IntersectionEval.instance
				}
			};
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00013114 File Offset: 0x00011314
		private static void Add(global::System.Collections.Hashtable m, global::NPOI.SS.Formula.PTG.OperationPtg ptgKey, global::NPOI.SS.Formula.Functions.Function instance)
		{
			global::System.Reflection.ConstructorInfo[] constructors = ptgKey.GetType().GetConstructors();
			if (constructors.Length > 1 || (constructors.Length != 0 && !constructors[0].IsPrivate))
			{
				throw new global::System.Exception("Failed to verify instance (" + ptgKey.GetType().Name + ") is a singleton.");
			}
			m[ptgKey] = instance;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0001316C File Offset: 0x0001136C
		public static global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.PTG.OperationPtg ptg, global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (ptg == null)
			{
				throw new global::System.ArgumentException("ptg must not be null");
			}
			global::NPOI.SS.Formula.Functions.Function function = global::NPOI.SS.Formula.OperationEvaluatorFactory._instancesByPtgClass[ptg] as global::NPOI.SS.Formula.Functions.Function;
			if (function != null)
			{
				return function.Evaluate(args, ec.RowIndex, (int)((short)ec.ColumnIndex));
			}
			if (!(ptg is global::NPOI.SS.Formula.PTG.AbstractFunctionPtg))
			{
				throw new global::System.Exception("Unexpected operation ptg class (" + ptg.GetType().Name + ")");
			}
			int functionIndex = (int)((global::NPOI.SS.Formula.PTG.AbstractFunctionPtg)ptg).FunctionIndex;
			if (functionIndex == 148)
			{
				return global::NPOI.SS.Formula.Functions.Indirect.instance.Evaluate(args, ec);
			}
			if (functionIndex != 255)
			{
				return global::NPOI.SS.Formula.Eval.FunctionEval.GetBasicFunction(functionIndex).Evaluate(args, ec.RowIndex, ec.ColumnIndex);
			}
			return global::NPOI.SS.Formula.UserDefinedFunction.instance.Evaluate(args, ec);
		}

		// Token: 0x040003DA RID: 986
		private static global::System.Type[] OPERATION_CONSTRUCTOR_CLASS_ARRAY = new global::System.Type[]
		{
			typeof(global::NPOI.SS.Formula.PTG.Ptg)
		};

		// Token: 0x040003DB RID: 987
		private static global::System.Collections.Hashtable _instancesByPtgClass = global::NPOI.SS.Formula.OperationEvaluatorFactory.InitialiseInstancesMap();
	}
}
