using System;
using System.Collections.Generic;
using System.Text;

namespace Gibraltar.Data
{
	// Token: 0x020000F0 RID: 240
	internal class LogicTreeExpression<D>
	{
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x000180D4 File Offset: 0x000162D4
		internal global::Gibraltar.Data.ILogicNode<D> RootNode
		{
			get
			{
				return this.m_RootNode;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x000180DC File Offset: 0x000162DC
		internal global::Gibraltar.Data.ILogicNode<D>[] UnboundTrueList
		{
			get
			{
				return this.m_UnboundTrueList.ToArray();
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x000180EC File Offset: 0x000162EC
		internal global::Gibraltar.Data.ILogicNode<D>[] UnboundFalseList
		{
			get
			{
				return this.m_UnboundFalseList.ToArray();
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000180FC File Offset: 0x000162FC
		internal global::Gibraltar.Data.MatchOperationType Operation
		{
			get
			{
				return this.m_ExpressionOperation;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00018104 File Offset: 0x00016304
		internal global::Gibraltar.Data.LogicTreeExpression<D>[] SubExpressionList
		{
			get
			{
				return this.m_SubExpressionList.ToArray();
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00018114 File Offset: 0x00016314
		public void EvaluateMatch(D dataset)
		{
			global::Gibraltar.Data.LogicTree<D>.EvaluateMatch(this.m_RootNode, dataset);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00018124 File Offset: 0x00016324
		public LogicTreeExpression(global::Gibraltar.Data.ILogicNode<D> singleNode)
		{
			this.m_RootNode = singleNode;
			global::Gibraltar.Data.ILogicNode<D>[] collection = new global::Gibraltar.Data.ILogicNode<D>[]
			{
				this.m_RootNode
			};
			this.m_UnboundTrueList = new global::System.Collections.Generic.List<global::Gibraltar.Data.ILogicNode<D>>(collection);
			this.m_UnboundFalseList = new global::System.Collections.Generic.List<global::Gibraltar.Data.ILogicNode<D>>(collection);
			this.m_SubExpressionList = new global::System.Collections.Generic.List<global::Gibraltar.Data.LogicTreeExpression<D>>(0);
			this.m_ExpressionOperation = global::Gibraltar.Data.MatchOperationType.Equals;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00018180 File Offset: 0x00016380
		public LogicTreeExpression(global::Gibraltar.Data.LogicTreeExpression<D> negationExpression)
		{
			this.m_RootNode = negationExpression.RootNode;
			this.m_ExpressionOperation = global::Gibraltar.Data.MatchOperationType.NotEquals;
			this.m_SubExpressionList = new global::System.Collections.Generic.List<global::Gibraltar.Data.LogicTreeExpression<D>>(new global::Gibraltar.Data.LogicTreeExpression<D>[]
			{
				negationExpression
			});
			global::Gibraltar.Data.ILogicNode<D> logicNode = new global::Gibraltar.Data.LogicNode<D>(false);
			global::Gibraltar.Data.ILogicNode<D> logicNode2 = new global::Gibraltar.Data.LogicNode<D>(true);
			foreach (global::Gibraltar.Data.ILogicNode<D> logicNode3 in negationExpression.UnboundTrueList)
			{
				if (logicNode3.NextOnTrue != null)
				{
					throw new global::Gibraltar.GibraltarException("UnboundTrueList contains a bound member.");
				}
				logicNode3.NextOnTrue = logicNode;
			}
			foreach (global::Gibraltar.Data.ILogicNode<D> logicNode4 in negationExpression.UnboundFalseList)
			{
				if (logicNode4.NextOnFalse != null)
				{
					throw new global::Gibraltar.GibraltarException("UnboundFalseList contains a bound member.");
				}
				logicNode4.NextOnFalse = logicNode2;
			}
			this.m_UnboundTrueList = new global::System.Collections.Generic.List<global::Gibraltar.Data.ILogicNode<D>>(new global::Gibraltar.Data.ILogicNode<D>[]
			{
				logicNode2
			});
			this.m_UnboundFalseList = new global::System.Collections.Generic.List<global::Gibraltar.Data.ILogicNode<D>>(new global::Gibraltar.Data.ILogicNode<D>[]
			{
				logicNode
			});
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00018270 File Offset: 0x00016470
		public LogicTreeExpression(global::Gibraltar.Data.LogicTreeExpression<D> leftExpression, global::Gibraltar.Data.MatchOperationType operation, global::Gibraltar.Data.LogicTreeExpression<D> rightExpression) : this(operation, new global::Gibraltar.Data.LogicTreeExpression<D>[]
		{
			leftExpression,
			rightExpression
		})
		{
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00018288 File Offset: 0x00016488
		public LogicTreeExpression(global::Gibraltar.Data.MatchOperationType operation, global::Gibraltar.Data.LogicTreeExpression<D>[] expressionArray)
		{
			if (expressionArray == null || expressionArray.Length == 0)
			{
				throw new global::Gibraltar.GibraltarException("Illegal argument to LogicTreeExpression constructor: Null or empty expressionArray.");
			}
			this.m_SubExpressionList = new global::System.Collections.Generic.List<global::Gibraltar.Data.LogicTreeExpression<D>>(expressionArray);
			global::Gibraltar.Data.LogicTreeExpression<D> logicTreeExpression = expressionArray[0];
			this.m_RootNode = logicTreeExpression.RootNode;
			this.m_UnboundTrueList = new global::System.Collections.Generic.List<global::Gibraltar.Data.ILogicNode<D>>(logicTreeExpression.UnboundTrueList);
			this.m_UnboundFalseList = new global::System.Collections.Generic.List<global::Gibraltar.Data.ILogicNode<D>>(logicTreeExpression.UnboundFalseList);
			if (operation == global::Gibraltar.Data.MatchOperationType.StandardOperationsMask)
			{
				this.m_ExpressionOperation = operation;
				for (int i = 1; i < expressionArray.Length; i++)
				{
					global::Gibraltar.Data.LogicTreeExpression<D> logicTreeExpression2 = expressionArray[i];
					global::Gibraltar.Data.ILogicNode<D> rootNode = logicTreeExpression2.RootNode;
					foreach (global::Gibraltar.Data.ILogicNode<D> logicNode in this.m_UnboundTrueList)
					{
						if (logicNode.NextOnTrue != null)
						{
							throw new global::Gibraltar.GibraltarException("UnboundTrueList contains a bound member.");
						}
						logicNode.NextOnTrue = rootNode;
					}
					this.m_UnboundTrueList = new global::System.Collections.Generic.List<global::Gibraltar.Data.ILogicNode<D>>(logicTreeExpression2.UnboundTrueList);
					this.m_UnboundFalseList.AddRange(logicTreeExpression2.UnboundFalseList);
				}
				return;
			}
			if (operation == global::Gibraltar.Data.MatchOperationType.Or)
			{
				this.m_ExpressionOperation = operation;
				for (int j = 1; j < expressionArray.Length; j++)
				{
					global::Gibraltar.Data.LogicTreeExpression<D> logicTreeExpression3 = expressionArray[j];
					global::Gibraltar.Data.ILogicNode<D> rootNode2 = logicTreeExpression3.RootNode;
					foreach (global::Gibraltar.Data.ILogicNode<D> logicNode2 in this.m_UnboundFalseList)
					{
						if (logicNode2.NextOnFalse != null)
						{
							throw new global::Gibraltar.GibraltarException("UnboundFalseList contains a bound member.");
						}
						logicNode2.NextOnFalse = rootNode2;
					}
					this.m_UnboundFalseList = new global::System.Collections.Generic.List<global::Gibraltar.Data.ILogicNode<D>>(logicTreeExpression3.UnboundFalseList);
					this.m_UnboundTrueList.AddRange(logicTreeExpression3.UnboundTrueList);
				}
				return;
			}
			throw new global::Gibraltar.GibraltarException(string.Format("Invalid operation {0:X4} ({0:F}) not supported by LogicTreeExpression.", operation));
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00018480 File Offset: 0x00016680
		public override string ToString()
		{
			if (this.m_ExpressionOperation == global::Gibraltar.Data.MatchOperationType.Equals)
			{
				if (this.m_SubExpressionList.Count == 0)
				{
					return this.m_RootNode.ToString();
				}
				return "INVALID LogicTreeExpression SubExpressionList.Count for leaf node";
			}
			else
			{
				if (this.m_ExpressionOperation != global::Gibraltar.Data.MatchOperationType.NotEquals)
				{
					string arg;
					string value;
					string value2;
					if (this.m_ExpressionOperation == global::Gibraltar.Data.MatchOperationType.StandardOperationsMask)
					{
						arg = "AND";
						value = "(";
						value2 = ")";
					}
					else
					{
						if (this.m_ExpressionOperation != global::Gibraltar.Data.MatchOperationType.Or)
						{
							return "INVALID LogicTreeExpression OPERATION";
						}
						arg = "OR";
						value = "[";
						value2 = "]";
					}
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(value);
					global::Gibraltar.Data.LogicTreeExpression<D>[] subExpressionList = this.SubExpressionList;
					if (subExpressionList.Length != 0)
					{
						stringBuilder.Append(subExpressionList[0].ToString());
					}
					for (int i = 1; i < subExpressionList.Length; i++)
					{
						stringBuilder.AppendFormat(" {0} {1}", arg, subExpressionList[1]);
					}
					stringBuilder.Append(value2);
					return stringBuilder.ToString();
				}
				if (this.m_SubExpressionList.Count == 1)
				{
					return "NOT " + this.m_SubExpressionList[0].ToString();
				}
				return "INVALID LogicTreeExpression SubExpressionList.Count for NOT operator";
			}
		}

		// Token: 0x04000264 RID: 612
		private readonly global::Gibraltar.Data.ILogicNode<D> m_RootNode;

		// Token: 0x04000265 RID: 613
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Data.ILogicNode<D>> m_UnboundTrueList;

		// Token: 0x04000266 RID: 614
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Data.ILogicNode<D>> m_UnboundFalseList;

		// Token: 0x04000267 RID: 615
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Data.LogicTreeExpression<D>> m_SubExpressionList;

		// Token: 0x04000268 RID: 616
		private readonly global::Gibraltar.Data.MatchOperationType m_ExpressionOperation;
	}
}
