using System;

namespace Gibraltar.Data
{
	// Token: 0x020000EE RID: 238
	internal class LogicTree<D> : global::Gibraltar.Data.LogicTree
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x00017D04 File Offset: 0x00015F04
		public void Clear()
		{
			this.m_RootNode = null;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00017D10 File Offset: 0x00015F10
		public global::Gibraltar.Data.LogicNode<D, F> CreateReferencePredicateNode<F>(global::Gibraltar.Data.LogicNode.GetDataValueDelegate<D, F> getDataValue, global::Gibraltar.Data.MatchOperationType operationType, F fieldValue) where F : class, global::System.IComparable<F>
		{
			return this.CreateStandardReferencePredicateNode<F>(getDataValue, operationType, fieldValue, fieldValue);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00017D1C File Offset: 0x00015F1C
		public global::Gibraltar.Data.LogicNode<D, F> CreateStandardReferencePredicateNode<F>(global::Gibraltar.Data.LogicNode.GetDataValueDelegate<D, F> getDataValue, global::Gibraltar.Data.MatchOperationType operationType, F fieldA, F fieldB) where F : class, global::System.IComparable<F>
		{
			if ((operationType & global::Gibraltar.Data.MatchOperationType.SpecialOperationsMask) != global::Gibraltar.Data.MatchOperationType.None)
			{
				throw new global::Gibraltar.GibraltarException(string.Format("Non-standard operation {0:X4} ({0:F}) not supported by CreateStandardReferencePredicateNode.", operationType));
			}
			return new global::Gibraltar.Data.LogicNode<D, F>(getDataValue, new global::Gibraltar.Data.LogicNode.ComparisonDelegate<F>(global::Gibraltar.Data.LogicTree.CompareReference<F>), operationType, fieldA, fieldB);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00017D54 File Offset: 0x00015F54
		public global::Gibraltar.Data.LogicNode<D, F> CreateValuePredicateNode<F>(global::Gibraltar.Data.LogicNode.GetDataValueDelegate<D, F> getDataValue, global::Gibraltar.Data.MatchOperationType operationType, F fieldValue) where F : struct, global::System.IComparable<F>
		{
			return this.CreateStandardValuePredicateNode<F>(getDataValue, operationType, fieldValue, fieldValue);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00017D60 File Offset: 0x00015F60
		public global::Gibraltar.Data.LogicNode<D, F> CreateStandardValuePredicateNode<F>(global::Gibraltar.Data.LogicNode.GetDataValueDelegate<D, F> getDataValue, global::Gibraltar.Data.MatchOperationType operationType, F fieldA, F fieldB) where F : struct, global::System.IComparable<F>
		{
			if ((operationType & global::Gibraltar.Data.MatchOperationType.SpecialOperationsMask) != global::Gibraltar.Data.MatchOperationType.None)
			{
				throw new global::Gibraltar.GibraltarException(string.Format("Non-standard operation {0:X4} ({0:F}) not supported by CreateStandardValuePredicateNode.", operationType));
			}
			return new global::Gibraltar.Data.LogicNode<D, F>(getDataValue, new global::Gibraltar.Data.LogicNode.ComparisonDelegate<F>(global::Gibraltar.Data.LogicTree.CompareValue<F>), operationType, fieldA, fieldB);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00017D98 File Offset: 0x00015F98
		public global::Gibraltar.Data.LogicNode<D, string> CreateSpecialStringPredicateNode(global::Gibraltar.Data.LogicNode.GetDataValueDelegate<D, string> getDataValue, global::Gibraltar.Data.MatchOperationType operationType, string fieldA, string fieldB)
		{
			if ((operationType & global::Gibraltar.Data.MatchOperationType.SpecialOperationsMask) == global::Gibraltar.Data.MatchOperationType.None)
			{
				return this.CreateStandardReferencePredicateNode<string>(getDataValue, operationType, fieldA, fieldB);
			}
			global::Gibraltar.Data.LogicNode.ComparisonDelegate<string> comparer;
			if (operationType <= global::Gibraltar.Data.MatchOperationType.EndsWith)
			{
				if (operationType == global::Gibraltar.Data.MatchOperationType.StartsWith || operationType == global::Gibraltar.Data.MatchOperationType.NotStartsWith)
				{
					comparer = new global::Gibraltar.Data.LogicNode.ComparisonDelegate<string>(global::Gibraltar.Data.LogicTree.ComparePrefix);
					goto IL_B8;
				}
				if (operationType != global::Gibraltar.Data.MatchOperationType.EndsWith)
				{
					goto IL_A2;
				}
			}
			else if (operationType != global::Gibraltar.Data.MatchOperationType.NotEndsWith)
			{
				if (operationType != global::Gibraltar.Data.MatchOperationType.Contains && operationType != global::Gibraltar.Data.MatchOperationType.NotContains)
				{
					goto IL_A2;
				}
				comparer = new global::Gibraltar.Data.LogicNode.ComparisonDelegate<string>(global::Gibraltar.Data.LogicTree.CompareContains);
				goto IL_B8;
			}
			comparer = new global::Gibraltar.Data.LogicNode.ComparisonDelegate<string>(global::Gibraltar.Data.LogicTree.CompareSuffix);
			goto IL_B8;
			IL_A2:
			throw new global::Gibraltar.GibraltarException(string.Format("Unrecognized operation {0:X4} ({0:F}) not supported by CreateSpecialStringPredicateNode.", operationType));
			IL_B8:
			return new global::Gibraltar.Data.LogicNode<D, string>(getDataValue, comparer, operationType, fieldA, fieldB);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00017E6C File Offset: 0x0001606C
		public bool EvaluateMatch(D dataset)
		{
			return global::Gibraltar.Data.LogicTree<D>.EvaluateMatch(this.m_RootNode, dataset);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00017E7C File Offset: 0x0001607C
		public static bool EvaluateMatch(global::Gibraltar.Data.ILogicNode<D> rootNode, D dataset)
		{
			bool flag = false;
			global::Gibraltar.Data.ILogicNode<D> logicNode = rootNode;
			while (logicNode != null)
			{
				flag = logicNode.EvaluateNode(dataset);
				if (flag)
				{
					logicNode = logicNode.NextOnTrue;
				}
				else
				{
					logicNode = logicNode.NextOnFalse;
				}
			}
			return flag;
		}

		// Token: 0x04000262 RID: 610
		private global::Gibraltar.Data.ILogicNode<D> m_RootNode;
	}
}
