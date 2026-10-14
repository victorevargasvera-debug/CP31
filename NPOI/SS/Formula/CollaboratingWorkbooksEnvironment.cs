using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula
{
	// Token: 0x020000B7 RID: 183
	public class CollaboratingWorkbooksEnvironment
	{
		// Token: 0x06000635 RID: 1589 RVA: 0x0000E5C4 File Offset: 0x0000C7C4
		private CollaboratingWorkbooksEnvironment()
		{
			this._evaluatorsByName = new global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.WorkbookEvaluator>();
			this._evaluators = new global::NPOI.SS.Formula.WorkbookEvaluator[0];
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
		public static void Setup(string[] workbookNames, global::NPOI.SS.Formula.WorkbookEvaluator[] evaluators)
		{
			int num = workbookNames.Length;
			if (evaluators.Length != num)
			{
				throw new global::System.ArgumentException("Number of workbook names is " + num.ToString() + " but number of evaluators is " + evaluators.Length.ToString());
			}
			if (num < 1)
			{
				throw new global::System.ArgumentException("Must provide at least one collaborating worbook");
			}
			global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment env = new global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment(workbookNames, evaluators, num);
			global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment.HookNewEnvironment(evaluators, env);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0000E644 File Offset: 0x0000C844
		public static void Setup(global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.WorkbookEvaluator> evaluatorsByName)
		{
			if (evaluatorsByName.Count < 1)
			{
				throw new global::System.ArgumentException("Must provide at least one collaborating worbook");
			}
			global::System.Collections.Generic.List<global::NPOI.SS.Formula.WorkbookEvaluator> list = new global::System.Collections.Generic.List<global::NPOI.SS.Formula.WorkbookEvaluator>(evaluatorsByName.Count);
			list.AddRange(evaluatorsByName.Values);
			global::NPOI.SS.Formula.WorkbookEvaluator[] evaluators = list.ToArray();
			new global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment(evaluatorsByName, evaluators);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0000E68C File Offset: 0x0000C88C
		public static void SetupFormulaEvaluator(global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.UserModel.IFormulaEvaluator> evaluators)
		{
			global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.WorkbookEvaluator> dictionary = new global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.WorkbookEvaluator>(evaluators.Count);
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::NPOI.SS.UserModel.IFormulaEvaluator> keyValuePair in evaluators)
			{
				string key = keyValuePair.Key;
				global::NPOI.SS.UserModel.IFormulaEvaluator value = keyValuePair.Value;
				if (!(value is global::NPOI.SS.Formula.IWorkbookEvaluatorProvider))
				{
					string str = "Formula Evaluator ";
					global::NPOI.SS.UserModel.IFormulaEvaluator formulaEvaluator = value;
					throw new global::System.ArgumentException(str + ((formulaEvaluator != null) ? formulaEvaluator.ToString() : null) + " provides no WorkbookEvaluator access");
				}
				dictionary.Add(key, ((global::NPOI.SS.Formula.IWorkbookEvaluatorProvider)value).GetWorkbookEvaluator());
			}
			global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment.Setup(dictionary);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0000E738 File Offset: 0x0000C938
		private CollaboratingWorkbooksEnvironment(string[] workbookNames, global::NPOI.SS.Formula.WorkbookEvaluator[] evaluators, int nItems) : this(global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment.ToUniqueMap(workbookNames, evaluators, nItems), evaluators)
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0000E74C File Offset: 0x0000C94C
		private static global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.WorkbookEvaluator> ToUniqueMap(string[] workbookNames, global::NPOI.SS.Formula.WorkbookEvaluator[] evaluators, int nItems)
		{
			global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.WorkbookEvaluator> dictionary = new global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.WorkbookEvaluator>(nItems * 3 / 2);
			for (int i = 0; i < nItems; i++)
			{
				string text = workbookNames[i];
				global::NPOI.SS.Formula.WorkbookEvaluator value = evaluators[i];
				if (dictionary.ContainsKey(text))
				{
					throw new global::System.ArgumentException("Duplicate workbook name '" + text + "'");
				}
				dictionary.Add(text, value);
			}
			return dictionary;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0000E7A0 File Offset: 0x0000C9A0
		private CollaboratingWorkbooksEnvironment(global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.WorkbookEvaluator> evaluatorsByName, global::NPOI.SS.Formula.WorkbookEvaluator[] evaluators)
		{
			global::System.Collections.Generic.Dictionary<global::NPOI.SS.Formula.WorkbookEvaluator, string> dictionary = new global::System.Collections.Generic.Dictionary<global::NPOI.SS.Formula.WorkbookEvaluator, string>(evaluators.Length);
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::NPOI.SS.Formula.WorkbookEvaluator> keyValuePair in evaluatorsByName)
			{
				if (dictionary.ContainsKey(keyValuePair.Value))
				{
					throw new global::System.ArgumentException(string.Concat(new string[]
					{
						"Attempted to register same workbook under names '",
						dictionary[keyValuePair.Value],
						"' and '",
						keyValuePair.Key,
						"'"
					}));
				}
				dictionary.Add(keyValuePair.Value, keyValuePair.Key);
			}
			this.UnhookOldEnvironments(evaluators);
			global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment.HookNewEnvironment(evaluators, this);
			this._unhooked = false;
			this._evaluators = (global::NPOI.SS.Formula.WorkbookEvaluator[])evaluators.Clone();
			this._evaluatorsByName = evaluatorsByName;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0000E88C File Offset: 0x0000CA8C
		private static void HookNewEnvironment(global::NPOI.SS.Formula.WorkbookEvaluator[] evaluators, global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment env)
		{
			int num = evaluators.Length;
			global::NPOI.SS.Formula.IEvaluationListener evaluationListener = evaluators[0].GetEvaluationListener();
			for (int i = 0; i < num; i++)
			{
				if (evaluationListener != evaluators[i].GetEvaluationListener())
				{
					throw new global::System.Exception("Workbook evaluators must all have the same evaluation listener");
				}
			}
			global::NPOI.SS.Formula.EvaluationCache cache = new global::NPOI.SS.Formula.EvaluationCache(evaluationListener);
			for (int j = 0; j < num; j++)
			{
				evaluators[j].AttachToEnvironment(env, cache, j);
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0000E8EC File Offset: 0x0000CAEC
		private void UnhookOldEnvironments(global::NPOI.SS.Formula.WorkbookEvaluator[] evaluators)
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			for (int i = 0; i < evaluators.Length; i++)
			{
				arrayList.Add(evaluators[i].GetEnvironment());
			}
			global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment[] array = new global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment[arrayList.Count];
			array = (global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment[])arrayList.ToArray(typeof(global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment));
			for (int j = 0; j < array.Length; j++)
			{
				array[j].Unhook();
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0000E954 File Offset: 0x0000CB54
		private void Unhook()
		{
			if (this._evaluators.Length < 1)
			{
				return;
			}
			for (int i = 0; i < this._evaluators.Length; i++)
			{
				this._evaluators[i].DetachFromEnvironment();
			}
			this._unhooked = true;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0000E994 File Offset: 0x0000CB94
		public global::NPOI.SS.Formula.WorkbookEvaluator GetWorkbookEvaluator(string workbookName)
		{
			if (this._unhooked)
			{
				throw new global::System.InvalidOperationException("This environment Has been unhooked");
			}
			if (this._evaluatorsByName.ContainsKey(workbookName))
			{
				return this._evaluatorsByName[workbookName];
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(256);
			stringBuilder.Append("Could not resolve external workbook name '").Append(workbookName).Append("'.");
			if (this._evaluators.Length < 1)
			{
				stringBuilder.Append(" Workbook environment has not been set up.");
			}
			else
			{
				stringBuilder.Append(" The following workbook names are valid: (");
				global::System.Collections.IEnumerator enumerator = this._evaluatorsByName.Keys.GetEnumerator();
				int num = 0;
				while (enumerator.MoveNext())
				{
					if (num++ > 0)
					{
						stringBuilder.Append(", ");
					}
					stringBuilder.Append("'").Append(enumerator.Current).Append("'");
				}
				stringBuilder.Append(")");
			}
			throw new global::NPOI.SS.Formula.WorkbookNotFoundException(stringBuilder.ToString());
		}

		// Token: 0x04000399 RID: 921
		public static readonly global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment EMPTY = new global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment();

		// Token: 0x0400039A RID: 922
		private global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.WorkbookEvaluator> _evaluatorsByName;

		// Token: 0x0400039B RID: 923
		private global::NPOI.SS.Formula.WorkbookEvaluator[] _evaluators;

		// Token: 0x0400039C RID: 924
		private bool _unhooked;
	}
}
