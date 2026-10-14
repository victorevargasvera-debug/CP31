using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Data.Entity.Resources;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200033B RID: 827
	internal class CTreeGenerator : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>
	{
		// Token: 0x06002746 RID: 10054 RVA: 0x000715F4 File Offset: 0x0006F7F4
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree Generate(global::System.Data.Entity.Core.Query.InternalTrees.Command itree, global::System.Data.Entity.Core.Query.InternalTrees.Node toConvert)
		{
			return new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator(itree, toConvert)._queryTree;
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00071604 File Offset: 0x0006F804
		private CTreeGenerator(global::System.Data.Entity.Core.Query.InternalTrees.Command itree, global::System.Data.Entity.Core.Query.InternalTrees.Node toConvert)
		{
			this._iqtCommand = itree;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query = base.VisitNode(toConvert);
			this._queryTree = global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree.FromValidExpression(itree.MetadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace, query, true, false);
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x00071757 File Offset: 0x0006F957
		private void AssertRelOp(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this._relOpState.ContainsKey(expr), "not a relOp expression?");
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x00071770 File Offset: 0x0006F970
		private global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo PublishRelOp(string name, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr, global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList publishedVars)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo(name, expr, publishedVars);
			this._relOpState.Add(expr, relOpInfo);
			return relOpInfo;
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x00071794 File Offset: 0x0006F994
		private global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo ConsumeRelOp(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
		{
			this.AssertRelOp(expr);
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo result = this._relOpState[expr];
			this._relOpState.Remove(expr);
			return result;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x000717B8 File Offset: 0x0006F9B8
		private global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo VisitAsRelOp(global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(inputNode.Op is global::System.Data.Entity.Core.Query.InternalTrees.RelOp, "Non-RelOp used as DbExpressionBinding Input");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr = base.VisitNode(inputNode);
			return this.ConsumeRelOp(expr);
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x000717EC File Offset: 0x0006F9EC
		private void PushExpressionBindingScope(global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo inputState)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(inputState != null && inputState.PublisherName != null && inputState.PublishedVars != null, "Invalid RelOpInfo produced by DbExpressionBinding Input");
			this._bindingScopes.Push(inputState);
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x0007181C File Offset: 0x0006FA1C
		private global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo EnterExpressionBindingScope(global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode, bool pushScope)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo = this.VisitAsRelOp(inputNode);
			if (pushScope)
			{
				this.PushExpressionBindingScope(relOpInfo);
			}
			return relOpInfo;
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x0007183C File Offset: 0x0006FA3C
		private global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo EnterExpressionBindingScope(global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode)
		{
			return this.EnterExpressionBindingScope(inputNode, true);
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00071846 File Offset: 0x0006FA46
		private void ExitExpressionBindingScope(global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo scope, bool wasPushed)
		{
			if (wasPushed)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this._bindingScopes.Count > 0, "ExitExpressionBindingScope called on empty ExpressionBindingScope stack");
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert((global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo)this._bindingScopes.Pop() == scope, "ExitExpressionBindingScope called on incorrect expression");
			}
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x00071880 File Offset: 0x0006FA80
		private void ExitExpressionBindingScope(global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo scope)
		{
			this.ExitExpressionBindingScope(scope, true);
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x0007188C File Offset: 0x0006FA8C
		private global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.GroupByScope EnterGroupByScope(global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo = this.VisitAsRelOp(inputNode);
			string publisherName = relOpInfo.PublisherName;
			string groupVarName = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}Group", new object[]
			{
				publisherName
			});
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.GroupByScope groupByScope = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.GroupByScope(relOpInfo.CreateBinding().Expression.GroupBindAs(publisherName, groupVarName), relOpInfo.PublishedVars);
			this._bindingScopes.Push(groupByScope);
			return groupByScope;
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x000718ED File Offset: 0x0006FAED
		private void ExitGroupByScope(global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.GroupByScope scope)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this._bindingScopes.Count > 0, "ExitGroupByScope called on empty ExpressionBindingScope stack");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert((global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.GroupByScope)this._bindingScopes.Pop() == scope, "ExitGroupByScope called on incorrect expression");
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x00071924 File Offset: 0x0006FB24
		private void EnterVarDefScope(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> varDefNodes)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in varDefNodes)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp;
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(varDefOp != null, "VarDefListOp contained non-VarDefOp child node");
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(varDefOp.Var is global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar, "VarDefOp defined non-Computed Var");
				dictionary.Add(varDefOp.Var, base.VisitNode(node.Child0));
			}
			this._varScopes.Push(new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarDefScope(dictionary));
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x000719CC File Offset: 0x0006FBCC
		private void EnterVarDefListScope(global::System.Data.Entity.Core.Query.InternalTrees.Node varDefListNode)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(varDefListNode.Op is global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp, "EnterVarDefListScope called with non-VarDefListOp");
			this.EnterVarDefScope(varDefListNode.Children);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x000719F2 File Offset: 0x0006FBF2
		private void ExitVarDefScope()
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this._varScopes.Count > 0, "ExitVarDefScope called on empty VarDefScope stack");
			this._varScopes.Pop();
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00071A18 File Offset: 0x0006FC18
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ResolveVar(global::System.Data.Entity.Core.Query.InternalTrees.Var referencedVar)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = null;
			global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar parameterVar = referencedVar as global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar;
			if (parameterVar != null)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression dbParameterReferenceExpression;
				if (!this._addedParams.TryGetValue(parameterVar, out dbParameterReferenceExpression))
				{
					dbParameterReferenceExpression = parameterVar.Type.Parameter(parameterVar.ParameterName);
					this._addedParams[parameterVar] = dbParameterReferenceExpression;
				}
				dbExpression = dbParameterReferenceExpression;
			}
			else
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar computedVar = referencedVar as global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar;
				if (computedVar != null && this._varScopes.Count > 0 && !this._varScopes.Peek().TryResolveVar(computedVar, out dbExpression))
				{
					dbExpression = null;
				}
				if (dbExpression == null)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = null;
					using (global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.IqtVarScope>.Enumerator enumerator = this._bindingScopes.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.TryResolveVar(referencedVar, out dbExpression2))
							{
								dbExpression = dbExpression2;
								break;
							}
						}
					}
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(dbExpression != null, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Unresolvable Var used in Command: VarType={0}, Id={1}", new object[]
			{
				global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Query.InternalTrees.VarType), referencedVar.VarType),
				referencedVar.Id
			}));
			return dbExpression;
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x00071B34 File Offset: 0x0006FD34
		private static void AssertBinary(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(2 == n.Children.Count, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Non-Binary {0} encountered", new object[]
			{
				n.Op.GetType().Name
			}));
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00071B71 File Offset: 0x0006FD71
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitChild(global::System.Data.Entity.Core.Query.InternalTrees.Node n, int index)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.Children.Count > index, "VisitChild called with invalid index");
			return base.VisitNode(n.Children[index]);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00071BA0 File Offset: 0x0006FDA0
		private new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> VisitChildren(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
			{
				list.Add(base.VisitNode(n2));
			}
			return list;
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x00071C00 File Offset: 0x0006FE00
		protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitConstantOp(global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return op.Type.Constant(op.Value);
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x00071C13 File Offset: 0x0006FE13
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstantOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitConstantOp(op, n);
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x00071C1D File Offset: 0x0006FE1D
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitConstantOp(op, n);
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x00071C27 File Offset: 0x0006FE27
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.NullOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return op.Type.Null();
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00071C34 File Offset: 0x0006FE34
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.NullSentinelOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitConstantOp(op, n);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x00071C3E File Offset: 0x0006FE3E
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True.Equal(op.IsTrue ? global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True : global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False);
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x00071C5E File Offset: 0x0006FE5E
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return op.Function.Invoke(this.VisitChildren(n));
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00071C72 File Offset: 0x0006FE72
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x00071C79 File Offset: 0x0006FE79
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00071C80 File Offset: 0x0006FE80
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.ArithmeticOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
			if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnaryMinus == op.OpType)
			{
				dbExpression = this.VisitChild(n, 0).UnaryMinus();
			}
			else
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left = this.VisitChild(n, 0);
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right = this.VisitChild(n, 1);
				switch (op.OpType)
				{
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Plus:
					dbExpression = left.Plus(right);
					break;
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Minus:
					dbExpression = left.Minus(right);
					break;
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Multiply:
					dbExpression = left.Multiply(right);
					break;
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Divide:
					dbExpression = left.Divide(right);
					break;
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Modulo:
					dbExpression = left.Modulo(right);
					break;
				default:
					dbExpression = null;
					break;
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(dbExpression != null, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "ArithmeticOp OpType not recognized: {0}", new object[]
			{
				global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Query.InternalTrees.OpType), op.OpType)
			}));
			return dbExpression;
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00071D54 File Offset: 0x0006FF54
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			int num = n.Children.Count;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(num > 1, "Invalid CaseOp: At least 2 child Nodes (1 When/Then pair) must be present");
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression elseExpression;
			if (n.Children.Count % 2 == 0)
			{
				elseExpression = op.Type.Null();
			}
			else
			{
				num--;
				elseExpression = this.VisitChild(n, n.Children.Count - 1);
			}
			for (int i = 0; i < num; i += 2)
			{
				list.Add(this.VisitChild(n, i));
				list2.Add(this.VisitChild(n, i + 1));
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(list, list2, elseExpression);
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00071DF8 File Offset: 0x0006FFF8
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.AssertBinary(n);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left = this.VisitChild(n, 0);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right = this.VisitChild(n, 1);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
			switch (op.OpType)
			{
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.GT:
				dbExpression = left.GreaterThan(right);
				break;
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.GE:
				dbExpression = left.GreaterThanOrEqual(right);
				break;
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.LE:
				dbExpression = left.LessThanOrEqual(right);
				break;
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.LT:
				dbExpression = left.LessThan(right);
				break;
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ:
				dbExpression = left.Equal(right);
				break;
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.NE:
				dbExpression = left.NotEqual(right);
				break;
			default:
				dbExpression = null;
				break;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(dbExpression != null, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "ComparisonOp OpType not recognized: {0}", new object[]
			{
				global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Query.InternalTrees.OpType), op.OpType)
			}));
			return dbExpression;
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00071EC4 File Offset: 0x000700C4
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.VisitChild(n, 0);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2;
			switch (op.OpType)
			{
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.And:
				dbExpression2 = dbExpression.And(this.VisitChild(n, 1));
				break;
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Or:
				dbExpression2 = dbExpression.Or(this.VisitChild(n, 1));
				break;
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.In:
			{
				int count = n.Children.Count;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(count - 1);
				for (int i = 1; i < count; i++)
				{
					list.Add(this.VisitChild(n, i));
				}
				dbExpression2 = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateInExpression(dbExpression, list);
				break;
			}
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not:
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression dbNotExpression = dbExpression as global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression;
				if (dbNotExpression != null)
				{
					dbExpression2 = dbNotExpression.Argument;
				}
				else
				{
					dbExpression2 = dbExpression.Not();
				}
				break;
			}
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull:
				dbExpression2 = dbExpression.IsNull();
				break;
			default:
				dbExpression2 = null;
				break;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(dbExpression2 != null, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "ConditionalOp OpType not recognized: {0}", new object[]
			{
				global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Query.InternalTrees.OpType), op.OpType)
			}));
			return dbExpression2;
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00071FD1 File Offset: 0x000701D1
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.LikeOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitChild(n, 0).Like(this.VisitChild(n, 1), this.VisitChild(n, 2));
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x00071FF0 File Offset: 0x000701F0
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.AggregateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "AggregateOp encountered outside of GroupByOp");
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Iqt_CTGen_UnexpectedAggregate);
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00072007 File Offset: 0x00070207
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.NavigateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x0007200E File Offset: 0x0007020E
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00072015 File Offset: 0x00070215
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewInstanceOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x0007201C File Offset: 0x0007021C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00072023 File Offset: 0x00070223
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewMultisetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x0007202A File Offset: 0x0007022A
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x00072031 File Offset: 0x00070231
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00072038 File Offset: 0x00070238
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.ResolveVar(op.Var);
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00072046 File Offset: 0x00070246
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.TreatOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x0007204D File Offset: 0x0007024D
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.CastOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitChild(n, 0).CastTo(op.Type);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00072062 File Offset: 0x00070262
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitChild(n, 0);
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x0007206C File Offset: 0x0007026C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (op.IsOfOnly)
			{
				return this.VisitChild(n, 0).IsOfOnly(op.IsOfType);
			}
			return this.VisitChild(n, 0).IsOf(op.IsOfType);
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x000720A0 File Offset: 0x000702A0
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.ExistsOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = base.VisitNode(n.Child0);
			this.ConsumeRelOp(dbExpression);
			return dbExpression.IsEmpty().Not();
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x000720D0 File Offset: 0x000702D0
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.ElementOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = base.VisitNode(n.Child0);
			this.AssertRelOp(dbExpression);
			this.ConsumeRelOp(dbExpression);
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateElementExpressionUnwrapSingleProperty(dbExpression);
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x000720FF File Offset: 0x000702FF
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.GetRefKeyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x00072106 File Offset: 0x00070306
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.GetEntityRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x0007210D File Offset: 0x0007030D
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.CollectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00072114 File Offset: 0x00070314
		private static string GenerateNameForVar(global::System.Data.Entity.Core.Query.InternalTrees.Var projectedVar, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.Utils.AliasGenerator> aliasMap, global::System.Data.Entity.Core.Common.Utils.AliasGenerator defaultAliasGenerator, global::System.Collections.Generic.Dictionary<string, string> alreadyUsedNames)
		{
			string text;
			global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator;
			if (projectedVar.TryGetName(out text))
			{
				if (!aliasMap.TryGetValue(text, out aliasGenerator))
				{
					aliasGenerator = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator(text);
					aliasMap[text] = aliasGenerator;
				}
				else
				{
					text = aliasGenerator.Next();
				}
			}
			else
			{
				aliasGenerator = defaultAliasGenerator;
				text = aliasGenerator.Next();
			}
			while (alreadyUsedNames.ContainsKey(text))
			{
				text = aliasGenerator.Next();
			}
			alreadyUsedNames[text] = text;
			return text;
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x00072174 File Offset: 0x00070374
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CreateProject(global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo sourceInfo, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> outputVars)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList varInfoList = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList();
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>();
			global::System.Data.Entity.Core.Common.Utils.AliasGenerator defaultAliasGenerator = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("C");
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.Utils.AliasGenerator> aliasMap = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.Utils.AliasGenerator>(global::System.StringComparer.InvariantCultureIgnoreCase);
			global::System.Collections.Generic.Dictionary<string, string> alreadyUsedNames = new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.InvariantCultureIgnoreCase);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in outputVars)
			{
				string text = global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.GenerateNameForVar(var, aliasMap, defaultAliasGenerator, alreadyUsedNames);
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value = this.ResolveVar(var);
				list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(text, value));
				global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo varInfo = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo(var);
				varInfo.PrependProperty(text);
				varInfoList.Add(varInfo);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = sourceInfo.CreateBinding().Project(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(list));
			this.PublishRelOp(this._projectAliases.Next(), dbExpression, varInfoList);
			return dbExpression;
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x00072254 File Offset: 0x00070454
		private static global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList GetTableVars(global::System.Data.Entity.Core.Query.InternalTrees.Table targetTable)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList varInfoList = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList();
			if (targetTable.TableMetadata.Flattened)
			{
				for (int i = 0; i < targetTable.Columns.Count; i++)
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo varInfo = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo(targetTable.Columns[i]);
					varInfo.PrependProperty(targetTable.TableMetadata.Columns[i].Name);
					varInfoList.Add(varInfo);
				}
			}
			else
			{
				varInfoList.Add(new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo(targetTable.Columns[0]));
			}
			return varInfoList;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x000722DC File Offset: 0x000704DC
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.Table.TableMetadata.Extent != null, "Invalid TableMetadata used in ScanTableOp - no Extent specified");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!n.HasChild0, "views are not expected here");
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList tableVars = global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.GetTableVars(op.Table);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = op.Table.TableMetadata.Extent.Scan();
			this.PublishRelOp(this._extentAliases.Next(), dbExpression, tableVars);
			return dbExpression;
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00072350 File Offset: 0x00070550
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00072358 File Offset: 0x00070558
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarDef, "an un-nest's child must be a VarDef");
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0.Child0;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = child.Op.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this, child);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(dbExpression.ResultType.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType, "the input to un-nest must yield a collection after plan compilation");
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList tableVars = global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.GetTableVars(op.Table);
			this.PublishRelOp(this._extentAliases.Next(), dbExpression, tableVars);
			return dbExpression;
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000723DC File Offset: 0x000705DC
		private global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo BuildEmptyProjection(global::System.Data.Entity.Core.Query.InternalTrees.Node relOpNode)
		{
			if (relOpNode.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project)
			{
				relOpNode = relOpNode.Child0;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo = this.EnterExpressionBindingScope(relOpNode);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1);
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>();
			list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>("C0", value));
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr = relOpInfo.CreateBinding().Project(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(list));
			this.PublishRelOp(this._projectAliases.Next(), expr, new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList());
			this.ExitExpressionBindingScope(relOpInfo);
			return this.ConsumeRelOp(expr);
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00072464 File Offset: 0x00070664
		private global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo BuildProjection(global::System.Data.Entity.Core.Query.InternalTrees.Node relOpNode, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> projectionVars)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr;
			if (relOpNode.Op is global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)
			{
				expr = this.VisitProject(relOpNode, projectionVars);
			}
			else
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo = this.EnterExpressionBindingScope(relOpNode);
				expr = this.CreateProject(relOpInfo, projectionVars);
				this.ExitExpressionBindingScope(relOpInfo);
			}
			return this.ConsumeRelOp(expr);
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000724AC File Offset: 0x000706AC
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitProject(global::System.Data.Entity.Core.Query.InternalTrees.Node n, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> varList)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo = this.EnterExpressionBindingScope(n.Child0);
			if (n.Children.Count > 1)
			{
				this.EnterVarDefListScope(n.Child1);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result = this.CreateProject(relOpInfo, varList);
			if (n.Children.Count > 1)
			{
				this.ExitVarDefScope();
			}
			this.ExitExpressionBindingScope(relOpInfo);
			return result;
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00072503 File Offset: 0x00070703
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitProject(n, op.Outputs);
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x00072514 File Offset: 0x00070714
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo = this.EnterExpressionBindingScope(n.Child0);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = base.VisitNode(n.Child1);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(dbExpression.ResultType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean), "Invalid FilterOp Predicate (non-ScalarOp or non-Boolean result)");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = relOpInfo.CreateBinding().Filter(dbExpression);
			this.ExitExpressionBindingScope(relOpInfo);
			this.PublishRelOp(this._filterAliases.Next(), dbExpression2, relOpInfo.PublishedVars);
			return dbExpression2;
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x00072580 File Offset: 0x00070780
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> VisitSortKeys(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this._iqtCommand.CreateVarVec();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in sortKeys)
			{
				if (!varVec.IsSet(sortKey.Var))
				{
					varVec.Set(sortKey.Var);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key = this.ResolveVar(sortKey.Var);
					global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause item;
					if (!string.IsNullOrEmpty(sortKey.Collation))
					{
						item = (sortKey.AscendingSort ? key.ToSortClause(sortKey.Collation) : key.ToSortClauseDescending(sortKey.Collation));
					}
					else
					{
						item = (sortKey.AscendingSort ? key.ToSortClause() : key.ToSortClauseDescending());
					}
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x0007265C File Offset: 0x0007085C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.SortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo = this.EnterExpressionBindingScope(n.Child0);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!n.HasChild1, "SortOp can have only one child");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = relOpInfo.CreateBinding().Sort(this.VisitSortKeys(op.Keys));
			this.ExitExpressionBindingScope(relOpInfo);
			this.PublishRelOp(this._sortAliases.Next(), dbExpression, relOpInfo.PublishedVars);
			return dbExpression;
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x000726C2 File Offset: 0x000708C2
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CreateLimitExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression limit, bool withTies)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!withTies, "Limit with Ties is not currently supported");
			return argument.Limit(limit);
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x000726DC File Offset: 0x000708DC
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = null;
			string name = null;
			bool flag = global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null == n.Child1.Op.OpType;
			bool flag2 = global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null == n.Child2.Op.OpType;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!flag || !flag2, "ConstrainedSortOp with no Skip Count and no Limit?");
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo;
			if (op.Keys.Count == 0)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(flag, "ConstrainedSortOp without SortKeys cannot have Skip Count");
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = base.VisitNode(n.Child0);
				relOpInfo = this.ConsumeRelOp(dbExpression2);
				dbExpression = global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.CreateLimitExpression(dbExpression2, base.VisitNode(n.Child2), op.WithTies);
				name = this._limitAliases.Next();
			}
			else
			{
				relOpInfo = this.EnterExpressionBindingScope(n.Child0);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder = this.VisitSortKeys(op.Keys);
				this.ExitExpressionBindingScope(relOpInfo);
				if (!flag && !flag2)
				{
					dbExpression = global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.CreateLimitExpression(relOpInfo.CreateBinding().Skip(sortOrder, this.VisitChild(n, 1)), this.VisitChild(n, 2), op.WithTies);
					name = this._limitAliases.Next();
				}
				else if (!flag && flag2)
				{
					dbExpression = relOpInfo.CreateBinding().Skip(sortOrder, this.VisitChild(n, 1));
					name = this._skipAliases.Next();
				}
				else if (flag && !flag2)
				{
					dbExpression = global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.CreateLimitExpression(relOpInfo.CreateBinding().Sort(sortOrder), this.VisitChild(n, 2), op.WithTies);
					name = this._limitAliases.Next();
				}
			}
			this.PublishRelOp(name, dbExpression, relOpInfo.PublishedVars);
			return dbExpression;
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00072858 File Offset: 0x00070A58
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList varInfoList = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList();
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.GroupByScope groupByScope = this.EnterGroupByScope(n.Child0);
			this.EnterVarDefListScope(n.Child1);
			global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("K");
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>(op.Outputs);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in op.Keys)
			{
				string text = aliasGenerator.Next();
				list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(text, this.ResolveVar(var)));
				global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo varInfo = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo(var);
				varInfo.PrependProperty(text);
				varInfoList.Add(varInfo);
				list2.Remove(var);
			}
			this.ExitVarDefScope();
			groupByScope.SwitchToGroupReference();
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>();
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child2;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(child.Op is global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp, "Invalid Aggregates VarDefListOp Node encountered in GroupByOp");
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in child.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp;
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(varDefOp != null, "Non-VarDefOp Node encountered as child of Aggregates VarDefListOp Node");
				global::System.Data.Entity.Core.Query.InternalTrees.Var var2 = varDefOp.Var;
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(var2 is global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar, "Non-ComputedVar encountered in Aggregate VarDefOp");
				global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = node.Child0;
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments = child2.Children.Select(new global::System.Func<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(base.VisitNode));
				global::System.Data.Entity.Core.Query.InternalTrees.AggregateOp aggregateOp = child2.Op as global::System.Data.Entity.Core.Query.InternalTrees.AggregateOp;
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(aggregateOp != null, "Non-Aggregate Node encountered as child of Aggregate VarDefOp Node");
				global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate value;
				if (aggregateOp.IsDistinctAggregate)
				{
					value = aggregateOp.AggFunc.AggregateDistinct(arguments);
				}
				else
				{
					value = aggregateOp.AggFunc.Aggregate(arguments);
				}
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list2.Contains(var2), "Defined aggregate Var not in Output Aggregate Vars list?");
				dictionary.Add(var2, value);
			}
			this.ExitGroupByScope(groupByScope);
			global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator2 = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("A");
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>> list3 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var3 in list2)
			{
				string text2 = aliasGenerator2.Next();
				list3.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>(text2, dictionary[var3]));
				global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo varInfo2 = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo(var3);
				varInfo2.PrependProperty(text2);
				varInfoList.Add(varInfo2);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = groupByScope.Binding.GroupBy(list, list3);
			this.PublishRelOp(this._groupByAliases.Next(), dbExpression, varInfoList);
			return dbExpression;
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00072B00 File Offset: 0x00070D00
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x00072B08 File Offset: 0x00070D08
		private global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo VisitJoinInput(global::System.Data.Entity.Core.Query.InternalTrees.Node joinInputNode)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo result;
			if (joinInputNode.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Filter && joinInputNode.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanTable)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp = (global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp)joinInputNode.Child0.Op;
				if (scanTableOp.Table.ReferencedColumns.IsEmpty)
				{
					result = this.BuildEmptyProjection(joinInputNode);
				}
				else
				{
					result = this.BuildProjection(joinInputNode, scanTableOp.Table.ReferencedColumns);
				}
			}
			else
			{
				result = this.EnterExpressionBindingScope(joinInputNode, false);
			}
			return result;
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00072B84 File Offset: 0x00070D84
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitBinaryJoin(global::System.Data.Entity.Core.Query.InternalTrees.Node joinNode, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind joinKind)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo = this.VisitJoinInput(joinNode.Child0);
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo2 = this.VisitJoinInput(joinNode.Child1);
			bool wasPushed = false;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition;
			if (joinNode.Children.Count > 2)
			{
				wasPushed = true;
				this.PushExpressionBindingScope(relOpInfo);
				this.PushExpressionBindingScope(relOpInfo2);
				joinCondition = base.VisitNode(joinNode.Child2);
			}
			else
			{
				joinCondition = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateJoinExpressionByKind(joinKind, joinCondition, relOpInfo.CreateBinding(), relOpInfo2.CreateBinding());
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList varInfoList = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList();
			this.ExitExpressionBindingScope(relOpInfo2, wasPushed);
			relOpInfo2.PublishedVars.PrependProperty(relOpInfo2.PublisherName);
			varInfoList.AddRange(relOpInfo2.PublishedVars);
			this.ExitExpressionBindingScope(relOpInfo, wasPushed);
			relOpInfo.PublishedVars.PrependProperty(relOpInfo.PublisherName);
			varInfoList.AddRange(relOpInfo.PublishedVars);
			this.PublishRelOp(this._joinAliases.Next(), dbExpression, varInfoList);
			return dbExpression;
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x00072C64 File Offset: 0x00070E64
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>();
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList varInfoList = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node joinInputNode in n.Children)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo = this.VisitJoinInput(joinInputNode);
				list.Add(relOpInfo.CreateBinding());
				this.ExitExpressionBindingScope(relOpInfo, false);
				relOpInfo.PublishedVars.PrependProperty(relOpInfo.PublisherName);
				varInfoList.AddRange(relOpInfo.PublishedVars);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CrossJoin(list);
			this.PublishRelOp(this._joinAliases.Next(), dbExpression, varInfoList);
			return dbExpression;
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x00072D1C File Offset: 0x00070F1C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitBinaryJoin(n, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin);
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x00072D27 File Offset: 0x00070F27
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitBinaryJoin(n, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin);
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x00072D32 File Offset: 0x00070F32
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.FullOuterJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitBinaryJoin(n, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin);
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x00072D40 File Offset: 0x00070F40
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitApply(global::System.Data.Entity.Core.Query.InternalTrees.Node applyNode, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind applyKind)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo = this.EnterExpressionBindingScope(applyNode.Child0);
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo2 = this.EnterExpressionBindingScope(applyNode.Child1, false);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateApplyExpressionByKind(applyKind, relOpInfo.CreateBinding(), relOpInfo2.CreateBinding());
			this.ExitExpressionBindingScope(relOpInfo2, false);
			this.ExitExpressionBindingScope(relOpInfo);
			relOpInfo.PublishedVars.PrependProperty(relOpInfo.PublisherName);
			relOpInfo2.PublishedVars.PrependProperty(relOpInfo2.PublisherName);
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList varInfoList = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList();
			varInfoList.AddRange(relOpInfo.PublishedVars);
			varInfoList.AddRange(relOpInfo2.PublishedVars);
			this.PublishRelOp(this._applyAliases.Next(), dbExpression, varInfoList);
			return dbExpression;
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x00072DDF File Offset: 0x00070FDF
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitApply(n, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossApply);
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00072DE9 File Offset: 0x00070FE9
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitApply(n, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OuterApply);
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x00072DF4 File Offset: 0x00070FF4
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitSetOpArgument(global::System.Data.Entity.Core.Query.InternalTrees.Node argNode, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputVars, global::System.Data.Entity.Core.Query.InternalTrees.VarMap argVars)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo;
			if (outputVars.IsEmpty)
			{
				relOpInfo = this.BuildEmptyProjection(argNode);
			}
			else
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var key in outputVars)
				{
					list.Add(argVars[key]);
				}
				relOpInfo = this.BuildProjection(argNode, list);
			}
			return relOpInfo.Publisher;
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x00072E6C File Offset: 0x0007106C
		private global::System.Data.Entity.Core.Common.DbProviderManifest ProviderManifest
		{
			get
			{
				global::System.Data.Entity.Core.Common.DbProviderManifest result;
				if ((result = this._providerManifest) == null)
				{
					result = (this._providerManifest = ((global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)this._iqtCommand.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)).ProviderManifest);
				}
				return result;
			}
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00072EA8 File Offset: 0x000710A8
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitSetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n, global::System.Data.Entity.Core.Common.Utils.AliasGenerator alias, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> setOpExpressionBuilder)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.AssertBinary(n);
			bool flag = (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect) && this.ProviderManifest.SupportsIntersectAndUnionAllFlattening();
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = (flag && n.Child0.Op.OpType == op.OpType) ? this.VisitSetOp((global::System.Data.Entity.Core.Query.InternalTrees.SetOp)n.Child0.Op, n.Child0, alias, setOpExpressionBuilder) : this.VisitSetOpArgument(n.Child0, op.Outputs, op.VarMap[0]);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = (flag && n.Child1.Op.OpType == op.OpType) ? this.VisitSetOp((global::System.Data.Entity.Core.Query.InternalTrees.SetOp)n.Child1.Op, n.Child1, alias, setOpExpressionBuilder) : this.VisitSetOpArgument(n.Child1, op.Outputs, op.VarMap[1]);
			global::System.Data.Entity.Core.Metadata.Edm.CollectionType edmType = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(dbExpression.ResultType, dbExpression2.ResultType));
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = null;
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = null;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RowType>(edmType.TypeUsage, out rowType))
			{
				enumerator = rowType.Properties.GetEnumerator();
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList varInfoList = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var target in op.Outputs)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo varInfo = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo(target);
				if (rowType != null)
				{
					if (!enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "Record columns don't match output vars");
					}
					varInfo.PrependProperty(enumerator.Current.Name);
				}
				varInfoList.Add(varInfo);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = setOpExpressionBuilder(dbExpression, dbExpression2);
			this.PublishRelOp(alias.Next(), dbExpression3, varInfoList);
			return dbExpression3;
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00073060 File Offset: 0x00071260
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitSetOp(op, n, this._unionAllAliases, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.UnionAll));
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x0007307C File Offset: 0x0007127C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.IntersectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitSetOp(op, n, this._intersectAliases, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Intersect));
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00073098 File Offset: 0x00071298
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.ExceptOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitSetOp(op, n, this._exceptAliases, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Except));
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x000730B4 File Offset: 0x000712B4
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.DerefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x000730BC File Offset: 0x000712BC
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo = this.BuildProjection(n.Child0, op.Keys);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = relOpInfo.Publisher.Distinct();
			this.PublishRelOp(this._distinctAliases.Next(), dbExpression, relOpInfo.PublishedVars);
			return dbExpression;
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x00073104 File Offset: 0x00071304
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo relOpInfo;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
			if (n.Child0.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this._iqtCommand.GetExtendedNodeInfo(n.Child0);
				if (extendedNodeInfo.Definitions.IsEmpty)
				{
					relOpInfo = this.BuildEmptyProjection(n.Child0);
				}
				else
				{
					relOpInfo = this.BuildProjection(n.Child0, extendedNodeInfo.Definitions);
				}
				dbExpression = relOpInfo.Publisher;
			}
			else
			{
				dbExpression = base.VisitNode(n.Child0);
				this.AssertRelOp(dbExpression);
				relOpInfo = this.ConsumeRelOp(dbExpression);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression item = dbExpression.Element();
			global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewCollection(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>
			{
				item
			});
			this.PublishRelOp(this._elementAliases.Next(), dbNewInstanceExpression, relOpInfo.PublishedVars);
			return dbNewInstanceExpression;
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x000731C4 File Offset: 0x000713C4
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] elements = new global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression[]
			{
				global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1)
			};
			global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewCollection(elements);
			this.PublishRelOp(this._singleRowTableAliases.Next(), dbNewInstanceExpression, new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList());
			return dbNewInstanceExpression;
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x00073206 File Offset: 0x00071406
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "Unexpected VarDefOp");
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Iqt_CTGen_UnexpectedVarDef);
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x0007321D File Offset: 0x0007141D
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "Unexpected VarDefListOp");
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Iqt_CTGen_UnexpectedVarDefList);
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x00073234 File Offset: 0x00071434
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.Children.Count == 1, "more than one input to physicalProjectOp?");
			global::System.Data.Entity.Core.Query.InternalTrees.VarList varList = new global::System.Data.Entity.Core.Query.InternalTrees.VarList();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var item in op.Outputs)
			{
				if (!varList.Contains(item))
				{
					varList.Add(item);
				}
			}
			op.Outputs.Clear();
			op.Outputs.AddRange(varList);
			return this.BuildProjection(n.Child0, op.Outputs).Publisher;
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x000732DC File Offset: 0x000714DC
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x000732E3 File Offset: 0x000714E3
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x04000DB1 RID: 3505
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command _iqtCommand;

		// Token: 0x04000DB2 RID: 3506
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree _queryTree;

		// Token: 0x04000DB3 RID: 3507
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> _addedParams = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>();

		// Token: 0x04000DB4 RID: 3508
		private readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.IqtVarScope> _bindingScopes = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.IqtVarScope>();

		// Token: 0x04000DB5 RID: 3509
		private readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarDefScope> _varScopes = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarDefScope>();

		// Token: 0x04000DB6 RID: 3510
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo> _relOpState = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.RelOpInfo>();

		// Token: 0x04000DB7 RID: 3511
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _applyAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Apply");

		// Token: 0x04000DB8 RID: 3512
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _distinctAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Distinct");

		// Token: 0x04000DB9 RID: 3513
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _exceptAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Except");

		// Token: 0x04000DBA RID: 3514
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _extentAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Extent");

		// Token: 0x04000DBB RID: 3515
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _filterAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Filter");

		// Token: 0x04000DBC RID: 3516
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _groupByAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("GroupBy");

		// Token: 0x04000DBD RID: 3517
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _intersectAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Intersect");

		// Token: 0x04000DBE RID: 3518
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _joinAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Join");

		// Token: 0x04000DBF RID: 3519
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _projectAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Project");

		// Token: 0x04000DC0 RID: 3520
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _sortAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Sort");

		// Token: 0x04000DC1 RID: 3521
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _unionAllAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("UnionAll");

		// Token: 0x04000DC2 RID: 3522
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _elementAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Element");

		// Token: 0x04000DC3 RID: 3523
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _singleRowTableAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("SingleRowTable");

		// Token: 0x04000DC4 RID: 3524
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _limitAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Limit");

		// Token: 0x04000DC5 RID: 3525
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _skipAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Skip");

		// Token: 0x04000DC6 RID: 3526
		private global::System.Data.Entity.Core.Common.DbProviderManifest _providerManifest;

		// Token: 0x020009D6 RID: 2518
		private class VarInfo
		{
			// Token: 0x17001082 RID: 4226
			// (get) Token: 0x06005FB1 RID: 24497 RVA: 0x00148821 File Offset: 0x00146A21
			internal global::System.Data.Entity.Core.Query.InternalTrees.Var Var
			{
				get
				{
					return this._var;
				}
			}

			// Token: 0x17001083 RID: 4227
			// (get) Token: 0x06005FB2 RID: 24498 RVA: 0x00148829 File Offset: 0x00146A29
			internal global::System.Collections.Generic.List<string> PropertyPath
			{
				get
				{
					return this._propertyChain;
				}
			}

			// Token: 0x06005FB3 RID: 24499 RVA: 0x00148831 File Offset: 0x00146A31
			internal VarInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var target)
			{
				this._var = target;
			}

			// Token: 0x06005FB4 RID: 24500 RVA: 0x0014884B File Offset: 0x00146A4B
			internal void PrependProperty(string propName)
			{
				this._propertyChain.Insert(0, propName);
			}

			// Token: 0x04002868 RID: 10344
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.Var _var;

			// Token: 0x04002869 RID: 10345
			private readonly global::System.Collections.Generic.List<string> _propertyChain = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x020009D7 RID: 2519
		private class VarInfoList : global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo>
		{
			// Token: 0x06005FB5 RID: 24501 RVA: 0x0014885A File Offset: 0x00146A5A
			internal VarInfoList()
			{
			}

			// Token: 0x06005FB6 RID: 24502 RVA: 0x00148862 File Offset: 0x00146A62
			internal VarInfoList(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo> elements) : base(elements)
			{
			}

			// Token: 0x06005FB7 RID: 24503 RVA: 0x0014886C File Offset: 0x00146A6C
			internal void PrependProperty(string propName)
			{
				foreach (global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo varInfo in this)
				{
					varInfo.PropertyPath.Insert(0, propName);
				}
			}

			// Token: 0x06005FB8 RID: 24504 RVA: 0x001488C0 File Offset: 0x00146AC0
			internal bool TryGetInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var targetVar, out global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo varInfo)
			{
				varInfo = null;
				foreach (global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo varInfo2 in this)
				{
					if (varInfo2.Var == targetVar)
					{
						varInfo = varInfo2;
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x020009D8 RID: 2520
		private abstract class IqtVarScope
		{
			// Token: 0x06005FB9 RID: 24505
			internal abstract bool TryResolveVar(global::System.Data.Entity.Core.Query.InternalTrees.Var targetVar, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression resultExpr);
		}

		// Token: 0x020009D9 RID: 2521
		private abstract class BindingScope : global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.IqtVarScope
		{
			// Token: 0x06005FBB RID: 24507 RVA: 0x00148928 File Offset: 0x00146B28
			internal BindingScope(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo> boundVars)
			{
				this._definedVars = new global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList(boundVars);
			}

			// Token: 0x17001084 RID: 4228
			// (get) Token: 0x06005FBC RID: 24508 RVA: 0x0014893C File Offset: 0x00146B3C
			internal global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList PublishedVars
			{
				get
				{
					return this._definedVars;
				}
			}

			// Token: 0x06005FBD RID: 24509 RVA: 0x00148944 File Offset: 0x00146B44
			internal override bool TryResolveVar(global::System.Data.Entity.Core.Query.InternalTrees.Var targetVar, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression resultExpr)
			{
				resultExpr = null;
				global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo varInfo = null;
				if (this._definedVars.TryGetInfo(targetVar, out varInfo))
				{
					resultExpr = this.BindingReference;
					foreach (string propertyName in varInfo.PropertyPath)
					{
						resultExpr = resultExpr.Property(propertyName);
					}
					return true;
				}
				return false;
			}

			// Token: 0x17001085 RID: 4229
			// (get) Token: 0x06005FBE RID: 24510
			protected abstract global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression BindingReference { get; }

			// Token: 0x0400286A RID: 10346
			private readonly global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfoList _definedVars;
		}

		// Token: 0x020009DA RID: 2522
		private class RelOpInfo : global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.BindingScope
		{
			// Token: 0x06005FBF RID: 24511 RVA: 0x001489BC File Offset: 0x00146BBC
			internal RelOpInfo(string bindingName, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression publisher, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo> publishedVars) : base(publishedVars)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(publisher.ResultType), "non-collection type used as RelOpInfo publisher");
				this._binding = publisher.BindAs(bindingName);
			}

			// Token: 0x17001086 RID: 4230
			// (get) Token: 0x06005FC0 RID: 24512 RVA: 0x001489E7 File Offset: 0x00146BE7
			internal string PublisherName
			{
				get
				{
					return this._binding.VariableName;
				}
			}

			// Token: 0x17001087 RID: 4231
			// (get) Token: 0x06005FC1 RID: 24513 RVA: 0x001489F4 File Offset: 0x00146BF4
			internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Publisher
			{
				get
				{
					return this._binding.Expression;
				}
			}

			// Token: 0x06005FC2 RID: 24514 RVA: 0x00148A01 File Offset: 0x00146C01
			internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding CreateBinding()
			{
				return this._binding;
			}

			// Token: 0x17001088 RID: 4232
			// (get) Token: 0x06005FC3 RID: 24515 RVA: 0x00148A09 File Offset: 0x00146C09
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression BindingReference
			{
				get
				{
					return this._binding.Variable;
				}
			}

			// Token: 0x0400286B RID: 10347
			private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding _binding;
		}

		// Token: 0x020009DB RID: 2523
		private class GroupByScope : global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.BindingScope
		{
			// Token: 0x06005FC4 RID: 24516 RVA: 0x00148A16 File Offset: 0x00146C16
			internal GroupByScope(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding binding, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.VarInfo> publishedVars) : base(publishedVars)
			{
				this._binding = binding;
			}

			// Token: 0x17001089 RID: 4233
			// (get) Token: 0x06005FC5 RID: 24517 RVA: 0x00148A26 File Offset: 0x00146C26
			internal global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding Binding
			{
				get
				{
					return this._binding;
				}
			}

			// Token: 0x06005FC6 RID: 24518 RVA: 0x00148A2E File Offset: 0x00146C2E
			internal void SwitchToGroupReference()
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!this._referenceGroup, "SwitchToGroupReference called more than once on the same GroupByScope?");
				this._referenceGroup = true;
			}

			// Token: 0x1700108A RID: 4234
			// (get) Token: 0x06005FC7 RID: 24519 RVA: 0x00148A4A File Offset: 0x00146C4A
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression BindingReference
			{
				get
				{
					if (!this._referenceGroup)
					{
						return this._binding.Variable;
					}
					return this._binding.GroupVariable;
				}
			}

			// Token: 0x0400286C RID: 10348
			private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding _binding;

			// Token: 0x0400286D RID: 10349
			private bool _referenceGroup;
		}

		// Token: 0x020009DC RID: 2524
		private class VarDefScope : global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.IqtVarScope
		{
			// Token: 0x06005FC8 RID: 24520 RVA: 0x00148A6B File Offset: 0x00146C6B
			internal VarDefScope(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> definedVars)
			{
				this._definedVars = definedVars;
			}

			// Token: 0x06005FC9 RID: 24521 RVA: 0x00148A7C File Offset: 0x00146C7C
			internal override bool TryResolveVar(global::System.Data.Entity.Core.Query.InternalTrees.Var targetVar, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression resultExpr)
			{
				resultExpr = null;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = null;
				if (this._definedVars.TryGetValue(targetVar, out dbExpression))
				{
					resultExpr = dbExpression;
					return true;
				}
				return false;
			}

			// Token: 0x0400286E RID: 10350
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> _definedVars;
		}
	}
}
