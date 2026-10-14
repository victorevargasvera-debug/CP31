using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.SS.Formula;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Formula.UDF;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000379 RID: 889
	public class HSSFFormulaEvaluator : global::NPOI.SS.Formula.BaseFormulaEvaluator
	{
		// Token: 0x06001C2E RID: 7214 RVA: 0x00055864 File Offset: 0x00053A64
		static HSSFFormulaEvaluator()
		{
			global::NPOI.HSSF.UserModel.HSSFFormulaEvaluator.VALUE_EVALS_MAP[typeof(global::NPOI.SS.Formula.PTG.BoolPtg)] = typeof(global::NPOI.SS.Formula.Eval.BoolEval);
			global::NPOI.HSSF.UserModel.HSSFFormulaEvaluator.VALUE_EVALS_MAP[typeof(global::NPOI.SS.Formula.PTG.IntPtg)] = typeof(global::NPOI.SS.Formula.Eval.NumberEval);
			global::NPOI.HSSF.UserModel.HSSFFormulaEvaluator.VALUE_EVALS_MAP[typeof(global::NPOI.SS.Formula.PTG.NumberPtg)] = typeof(global::NPOI.SS.Formula.Eval.NumberEval);
			global::NPOI.HSSF.UserModel.HSSFFormulaEvaluator.VALUE_EVALS_MAP[typeof(global::NPOI.SS.Formula.PTG.StringPtg)] = typeof(global::NPOI.SS.Formula.Eval.StringEval);
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0005597A File Offset: 0x00053B7A
		public HSSFFormulaEvaluator(global::NPOI.SS.UserModel.IWorkbook workbook) : this(workbook, null)
		{
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00055984 File Offset: 0x00053B84
		public HSSFFormulaEvaluator(global::NPOI.SS.UserModel.IWorkbook workbook, global::NPOI.SS.Formula.IStabilityClassifier stabilityClassifier) : this(workbook, stabilityClassifier, null)
		{
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0005598F File Offset: 0x00053B8F
		public HSSFFormulaEvaluator(global::NPOI.SS.UserModel.IWorkbook workbook, global::NPOI.SS.Formula.IStabilityClassifier stabilityClassifier, global::NPOI.SS.Formula.UDF.UDFFinder udfFinder) : base(new global::NPOI.SS.Formula.WorkbookEvaluator(global::NPOI.HSSF.UserModel.HSSFEvaluationWorkbook.Create(workbook), stabilityClassifier, udfFinder))
		{
			this._book = workbook;
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000559AB File Offset: 0x00053BAB
		public static global::NPOI.HSSF.UserModel.HSSFFormulaEvaluator Create(global::NPOI.SS.UserModel.IWorkbook workbook, global::NPOI.SS.Formula.IStabilityClassifier stabilityClassifier, global::NPOI.SS.Formula.UDF.UDFFinder udfFinder)
		{
			return new global::NPOI.HSSF.UserModel.HSSFFormulaEvaluator(workbook, stabilityClassifier, udfFinder);
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x000549EA File Offset: 0x00052BEA
		protected override global::NPOI.SS.UserModel.IRichTextString CreateRichTextString(string str)
		{
			return new global::NPOI.HSSF.UserModel.HSSFRichTextString(str);
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x000559B8 File Offset: 0x00053BB8
		public static void SetupEnvironment(string[] workbookNames, global::NPOI.HSSF.UserModel.HSSFFormulaEvaluator[] evaluators)
		{
			global::NPOI.SS.Formula.BaseFormulaEvaluator.SetupEnvironment(workbookNames, evaluators);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0000DB92 File Offset: 0x0000BD92
		public override void SetupReferencedWorkbooks(global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.UserModel.IFormulaEvaluator> evaluators)
		{
			global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment.SetupFormulaEvaluator(evaluators);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x000559CE File Offset: 0x00053BCE
		public override void NotifyUpdateCell(global::NPOI.SS.UserModel.ICell cell)
		{
			this._bookEvaluator.NotifyUpdateCell(new global::NPOI.HSSF.UserModel.HSSFEvaluationCell(cell));
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x000559E1 File Offset: 0x00053BE1
		public override void NotifyDeleteCell(global::NPOI.SS.UserModel.ICell cell)
		{
			this._bookEvaluator.NotifyDeleteCell(new global::NPOI.HSSF.UserModel.HSSFEvaluationCell(cell));
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x000559CE File Offset: 0x00053BCE
		public override void NotifySetFormula(global::NPOI.SS.UserModel.ICell cell)
		{
			this._bookEvaluator.NotifyUpdateCell(new global::NPOI.HSSF.UserModel.HSSFEvaluationCell(cell));
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x000559F4 File Offset: 0x00053BF4
		protected override global::NPOI.SS.UserModel.CellValue EvaluateFormulaCellValue(global::NPOI.SS.UserModel.ICell cell)
		{
			global::NPOI.SS.Formula.Eval.ValueEval valueEval = this._bookEvaluator.Evaluate(new global::NPOI.HSSF.UserModel.HSSFEvaluationCell((global::NPOI.HSSF.UserModel.HSSFCell)cell));
			if (valueEval is global::NPOI.SS.Formula.Eval.BoolEval)
			{
				return global::NPOI.SS.UserModel.CellValue.ValueOf(((global::NPOI.SS.Formula.Eval.BoolEval)valueEval).BooleanValue);
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.NumberEval)
			{
				return new global::NPOI.SS.UserModel.CellValue(((global::NPOI.SS.Formula.Eval.NumberEval)valueEval).NumberValue);
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.StringEval)
			{
				return new global::NPOI.SS.UserModel.CellValue(((global::NPOI.SS.Formula.Eval.StringEval)valueEval).StringValue);
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				return global::NPOI.SS.UserModel.CellValue.GetError(((global::NPOI.SS.Formula.Eval.ErrorEval)valueEval).ErrorCode);
			}
			throw new global::System.InvalidOperationException("Unexpected eval class (" + valueEval.GetType().Name + ")");
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00055A9C File Offset: 0x00053C9C
		public override global::NPOI.SS.UserModel.ICell EvaluateInCell(global::NPOI.SS.UserModel.ICell cell)
		{
			if (cell == null)
			{
				return null;
			}
			if (cell.CellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				global::NPOI.SS.UserModel.CellValue cv = this.EvaluateFormulaCellValue(cell);
				base.SetCellValue(cell, cv);
				global::NPOI.SS.Formula.BaseFormulaEvaluator.SetCellType(cell, cv);
			}
			return cell;
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00055ACF File Offset: 0x00053CCF
		public static void EvaluateAllFormulaCells(global::NPOI.HSSF.UserModel.HSSFWorkbook wb)
		{
			global::NPOI.SS.Formula.BaseFormulaEvaluator.EvaluateAllFormulaCells(wb, new global::NPOI.HSSF.UserModel.HSSFFormulaEvaluator(wb));
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00055ADD File Offset: 0x00053CDD
		public new static void EvaluateAllFormulaCells(global::NPOI.SS.UserModel.IWorkbook wb)
		{
			global::NPOI.SS.Formula.BaseFormulaEvaluator.EvaluateAllFormulaCells(wb);
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00055AE5 File Offset: 0x00053CE5
		public override void EvaluateAll()
		{
			global::NPOI.SS.Formula.BaseFormulaEvaluator.EvaluateAllFormulaCells(this._book, this);
		}

		// Token: 0x04000B56 RID: 2902
		private static readonly global::System.Type[] VALUE_CONTRUCTOR_CLASS_ARRAY = new global::System.Type[]
		{
			typeof(global::NPOI.SS.Formula.PTG.Ptg)
		};

		// Token: 0x04000B57 RID: 2903
		private static readonly global::System.Type[] AREA3D_CONSTRUCTOR_CLASS_ARRAY = new global::System.Type[]
		{
			typeof(global::NPOI.SS.Formula.PTG.Ptg),
			typeof(global::NPOI.SS.Formula.Eval.ValueEval[])
		};

		// Token: 0x04000B58 RID: 2904
		private static readonly global::System.Type[] REFERENCE_CONSTRUCTOR_CLASS_ARRAY = new global::System.Type[]
		{
			typeof(global::NPOI.SS.Formula.PTG.Ptg),
			typeof(global::NPOI.SS.Formula.Eval.ValueEval)
		};

		// Token: 0x04000B59 RID: 2905
		private static readonly global::System.Type[] REF3D_CONSTRUCTOR_CLASS_ARRAY = new global::System.Type[]
		{
			typeof(global::NPOI.SS.Formula.PTG.Ptg),
			typeof(global::NPOI.SS.Formula.Eval.ValueEval)
		};

		// Token: 0x04000B5A RID: 2906
		private static readonly global::System.Collections.Hashtable VALUE_EVALS_MAP = new global::System.Collections.Hashtable();

		// Token: 0x04000B5B RID: 2907
		protected global::NPOI.SS.UserModel.IRow row;

		// Token: 0x04000B5C RID: 2908
		protected global::NPOI.SS.UserModel.ISheet sheet;

		// Token: 0x04000B5D RID: 2909
		protected global::NPOI.SS.UserModel.IWorkbook _book;
	}
}
