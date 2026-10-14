using System;

namespace Gibraltar.Data
{
	// Token: 0x020000EC RID: 236
	internal class LogicNode<D, F> : global::Gibraltar.Data.LogicNode, global::Gibraltar.Data.ILogicNode<D>
	{
		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x000176E4 File Offset: 0x000158E4
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000176EC File Offset: 0x000158EC
		public global::Gibraltar.Data.ILogicNode<D> NextOnTrue
		{
			get
			{
				return this.m_NextOnTrue;
			}
			set
			{
				this.m_NextOnTrue = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x000176F8 File Offset: 0x000158F8
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00017700 File Offset: 0x00015900
		public global::Gibraltar.Data.ILogicNode<D> NextOnFalse
		{
			get
			{
				return this.m_NextOnFalse;
			}
			set
			{
				this.m_NextOnFalse = value;
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0001770C File Offset: 0x0001590C
		public LogicNode(global::Gibraltar.Data.LogicNode.GetDataValueDelegate<D, F> getDataValue, global::Gibraltar.Data.LogicNode.ComparisonDelegate<F> comparer, global::Gibraltar.Data.MatchOperationType operationType, F fieldValue) : this(getDataValue, comparer, operationType, fieldValue, fieldValue)
		{
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0001771C File Offset: 0x0001591C
		public LogicNode(global::Gibraltar.Data.LogicNode.GetDataValueDelegate<D, F> getDataValue, global::Gibraltar.Data.LogicNode.ComparisonDelegate<F> comparer, global::Gibraltar.Data.MatchOperationType operationType, F fieldA, F fieldB)
		{
			this.m_GetDataValue = getDataValue;
			this.m_Compare = comparer;
			this.m_MatchOperation = operationType;
			this.m_FieldA = fieldA;
			this.m_FieldB = fieldB;
			this.m_NextOnTrue = null;
			this.m_NextOnFalse = null;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00017758 File Offset: 0x00015958
		public LogicNode(global::Gibraltar.Data.LogicNode<D, F> original)
		{
			this.m_GetDataValue = original.m_GetDataValue;
			this.m_Compare = original.m_Compare;
			this.m_MatchOperation = original.m_MatchOperation;
			this.m_FieldA = original.m_FieldA;
			this.m_FieldB = original.m_FieldB;
			this.m_NextOnTrue = null;
			this.m_NextOnFalse = null;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000177BC File Offset: 0x000159BC
		public global::Gibraltar.Data.ILogicNode<D> Clone()
		{
			return new global::Gibraltar.Data.LogicNode<D, F>(this);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000177C4 File Offset: 0x000159C4
		public override string ToString()
		{
			F fieldA = this.m_FieldA;
			if (fieldA.Equals(this.m_FieldB))
			{
				return string.Format("{{{0}}} {1:F} {2}", typeof(F), this.m_MatchOperation, this.m_FieldA);
			}
			return string.Format("{{{0}}} {1:F} ({2}, {3})", new object[]
			{
				typeof(F),
				this.m_MatchOperation,
				this.m_FieldA,
				this.m_FieldB
			});
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0001786C File Offset: 0x00015A6C
		public bool EvaluateNode(D dataset)
		{
			F data = this.m_GetDataValue(dataset);
			int num = this.m_Compare(data, this.m_FieldA);
			bool flag;
			if (num < 0)
			{
				flag = ((this.m_MatchOperation & global::Gibraltar.Data.MatchOperationType.LessThanFieldA) > global::Gibraltar.Data.MatchOperationType.None);
			}
			else if (num == 0)
			{
				flag = ((this.m_MatchOperation & global::Gibraltar.Data.MatchOperationType.EqualFieldA) > global::Gibraltar.Data.MatchOperationType.None);
			}
			else
			{
				flag = ((this.m_MatchOperation & global::Gibraltar.Data.MatchOperationType.GreaterThanFieldA) > global::Gibraltar.Data.MatchOperationType.None);
			}
			bool flag2 = (this.m_MatchOperation & global::Gibraltar.Data.MatchOperationType.BothFieldsMatching) == global::Gibraltar.Data.MatchOperationType.None;
			if (flag != flag2)
			{
				if ((this.m_MatchOperation & global::Gibraltar.Data.MatchOperationType.FieldBMask) == global::Gibraltar.Data.MatchOperationType.None)
				{
					flag2 = false;
				}
				else if ((this.m_MatchOperation & global::Gibraltar.Data.MatchOperationType.FieldBMask) == global::Gibraltar.Data.MatchOperationType.FieldBMask)
				{
					flag2 = true;
				}
				else
				{
					F fieldA = this.m_FieldA;
					int num2;
					if (fieldA.Equals(this.m_FieldB))
					{
						num2 = num;
					}
					else
					{
						num2 = this.m_Compare(data, this.m_FieldB);
					}
					if ((this.m_MatchOperation & global::Gibraltar.Data.MatchOperationType.ImplicitIncrementB) != global::Gibraltar.Data.MatchOperationType.None && num2 == 0)
					{
						num2--;
					}
					if (num2 < 0)
					{
						flag2 = ((this.m_MatchOperation & global::Gibraltar.Data.MatchOperationType.LessThanFieldB) > global::Gibraltar.Data.MatchOperationType.None);
					}
					else if (num2 == 0)
					{
						flag2 = ((this.m_MatchOperation & global::Gibraltar.Data.MatchOperationType.EqualFieldB) > global::Gibraltar.Data.MatchOperationType.None);
					}
					else
					{
						flag2 = ((this.m_MatchOperation & global::Gibraltar.Data.MatchOperationType.GreaterThanFieldB) > global::Gibraltar.Data.MatchOperationType.None);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0400025A RID: 602
		private readonly global::Gibraltar.Data.LogicNode.GetDataValueDelegate<D, F> m_GetDataValue;

		// Token: 0x0400025B RID: 603
		private readonly global::Gibraltar.Data.LogicNode.ComparisonDelegate<F> m_Compare;

		// Token: 0x0400025C RID: 604
		private readonly global::Gibraltar.Data.MatchOperationType m_MatchOperation;

		// Token: 0x0400025D RID: 605
		private readonly F m_FieldA;

		// Token: 0x0400025E RID: 606
		private readonly F m_FieldB;

		// Token: 0x0400025F RID: 607
		private global::Gibraltar.Data.ILogicNode<D> m_NextOnTrue;

		// Token: 0x04000260 RID: 608
		private global::Gibraltar.Data.ILogicNode<D> m_NextOnFalse;
	}
}
