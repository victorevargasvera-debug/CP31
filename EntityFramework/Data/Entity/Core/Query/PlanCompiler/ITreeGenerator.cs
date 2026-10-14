using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000348 RID: 840
	internal class ITreeGenerator : global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<global::System.Data.Entity.Core.Query.InternalTrees.Node>
	{
		// Token: 0x060027E7 RID: 10215 RVA: 0x00075708 File Offset: 0x00073908
		private static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind, global::System.Data.Entity.Core.Query.InternalTrees.OpType> InitializeExpressionKindToOpTypeMap()
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind, global::System.Data.Entity.Core.Query.InternalTrees.OpType> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind, global::System.Data.Entity.Core.Query.InternalTrees.OpType>(12);
			dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Plus] = global::System.Data.Entity.Core.Query.InternalTrees.OpType.Plus;
			dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Minus] = global::System.Data.Entity.Core.Query.InternalTrees.OpType.Minus;
			dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Multiply] = global::System.Data.Entity.Core.Query.InternalTrees.OpType.Multiply;
			dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Divide] = global::System.Data.Entity.Core.Query.InternalTrees.OpType.Divide;
			dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Modulo] = global::System.Data.Entity.Core.Query.InternalTrees.OpType.Modulo;
			dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.UnaryMinus] = global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnaryMinus;
			dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals] = global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ;
			dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NotEquals] = global::System.Data.Entity.Core.Query.InternalTrees.OpType.NE;
			dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThan] = global::System.Data.Entity.Core.Query.InternalTrees.OpType.LT;
			dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThan] = global::System.Data.Entity.Core.Query.InternalTrees.OpType.GT;
			dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThanOrEquals] = global::System.Data.Entity.Core.Query.InternalTrees.OpType.LE;
			dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThanOrEquals] = global::System.Data.Entity.Core.Query.InternalTrees.OpType.GE;
			return dictionary;
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x00075791 File Offset: 0x00073991
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Var> VarMap
		{
			get
			{
				return this._varMap;
			}
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00075799 File Offset: 0x00073999
		public static global::System.Data.Entity.Core.Query.InternalTrees.Command Generate(global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree ctree)
		{
			return global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.Generate(ctree, null);
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x000757A2 File Offset: 0x000739A2
		internal static global::System.Data.Entity.Core.Query.InternalTrees.Command Generate(global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree ctree, global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap discriminatorMap)
		{
			return new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator(ctree, discriminatorMap)._iqtCommand;
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x000757B0 File Offset: 0x000739B0
		private ITreeGenerator(global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree ctree, global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap discriminatorMap)
		{
			this._useDatabaseNullSemantics = ctree.UseDatabaseNullSemantics;
			this._iqtCommand = new global::System.Data.Entity.Core.Query.InternalTrees.Command(ctree.MetadataWorkspace);
			if (discriminatorMap != null)
			{
				this._discriminatorMap = discriminatorMap;
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(ctree.Query.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project, "top level QMV expression must be project to match discriminator pattern");
				this._discriminatedViewTopProject = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)ctree.Query;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> keyValuePair in ctree.Parameters)
			{
				if (!global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ValidateParameterType(keyValuePair.Value))
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ParameterTypeNotSupported(keyValuePair.Key, keyValuePair.Value.ToString()));
				}
				this._iqtCommand.CreateParameterVar(keyValuePair.Key, keyValuePair.Value);
			}
			this._iqtCommand.Root = this.VisitExpr(ctree.Query);
			if (!this._iqtCommand.Root.Op.IsRelOp)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = this.ConvertToScalarOpTree(this._iqtCommand.Root, ctree.Query);
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this._iqtCommand.CreateNode(this._iqtCommand.CreateSingleRowTableOp());
				global::System.Data.Entity.Core.Query.InternalTrees.Var var;
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = this._iqtCommand.CreateVarDefListNode(definingExpr, out var);
				global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op = this._iqtCommand.CreateProjectOp(var);
				global::System.Data.Entity.Core.Query.InternalTrees.Node root = this._iqtCommand.CreateNode(op, arg, node);
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(this._iqtCommand.Root.Op.Type))
				{
					global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp unnestOp = this._iqtCommand.CreateUnnestOp(var);
					root = this._iqtCommand.CreateNode(unnestOp, node.Child0);
					var = unnestOp.Table.Columns[0];
				}
				this._iqtCommand.Root = root;
				this._varMap[this._iqtCommand.Root] = var;
			}
			this._iqtCommand.Root = this.CapWithPhysicalProject(this._iqtCommand.Root);
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x000759FC File Offset: 0x00073BFC
		private static bool ValidateParameterType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage paramType)
		{
			return paramType != null && paramType.EdmType != null && (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(paramType) || paramType.EdmType is global::System.Data.Entity.Core.Metadata.Edm.EnumType);
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x00075A23 File Offset: 0x00073C23
		private static global::System.Data.Entity.Core.Metadata.Edm.RowType ExtractElementRowType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			return global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RowType>(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(typeUsage).TypeUsage);
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x00075A38 File Offset: 0x00073C38
		private bool IsPredicate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(expr.ResultType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean))
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = expr.ExpressionKind;
				if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NotEquals)
				{
					if (expressionKind > global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Any)
					{
						switch (expressionKind)
						{
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThan:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThanOrEquals:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsEmpty:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsNull:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOf:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOfOnly:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThan:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThanOrEquals:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Like:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Not:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NotEquals:
							break;
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Except:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Filter:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GroupBy:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Intersect:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Limit:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Minus:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Modulo:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Multiply:
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance:
							return false;
						case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Function:
						{
							if (!((global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression)expr).Function.HasUserDefinedBody)
							{
								return false;
							}
							bool result;
							if (this._functionsIsPredicateFlag.TryGetValue(expr, out result))
							{
								return result;
							}
							global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "IsPredicate must be called on a visited function expression");
							return false;
						}
						default:
							return false;
						}
					}
				}
				else if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Or)
				{
					switch (expressionKind)
					{
					case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference:
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression dbVariableReferenceExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)expr;
						return this.ResolveScope(dbVariableReferenceExpression).IsPredicate(dbVariableReferenceExpression.VariableName);
					}
					case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Lambda:
					{
						bool result2;
						if (this._functionsIsPredicateFlag.TryGetValue(expr, out result2))
						{
							return result2;
						}
						global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "IsPredicate must be called on a visited lambda expression");
						return false;
					}
					case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.In:
						break;
					default:
						return false;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x00075B68 File Offset: 0x00073D68
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitExpr(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			if (e == null)
			{
				return null;
			}
			return e.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Node>(this);
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00075B78 File Offset: 0x00073D78
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitExprAsScalar(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
		{
			if (expr == null)
			{
				return null;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.VisitExpr(expr);
			return this.ConvertToScalarOpTree(node, expr);
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00075B9C File Offset: 0x00073D9C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ConvertToScalarOpTree(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
		{
			if (node.Op.IsRelOp)
			{
				node = this.ConvertRelOpToScalarOpTree(node, expr.ResultType);
			}
			else if (this.IsPredicate(expr))
			{
				node = this.ConvertPredicateToScalarOpTree(node, expr);
			}
			return node;
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x00075BD0 File Offset: 0x00073DD0
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ConvertRelOpToScalarOpTree(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(resultType), "RelOp with non-Collection result type");
			global::System.Data.Entity.Core.Query.InternalTrees.CollectOp op = this._iqtCommand.CreateCollectOp(resultType);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.CapWithPhysicalProject(node);
			node = this._iqtCommand.CreateNode(op, arg);
			return node;
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x00075C14 File Offset: 0x00073E14
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ConvertPredicateToScalarOpTree(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op = this._iqtCommand.CreateCaseOp(this._iqtCommand.BooleanType);
			bool flag = this.IsNullable(expr);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(flag ? 5 : 3);
			list.Add(node);
			list.Add(this._iqtCommand.CreateNode(this._iqtCommand.CreateInternalConstantOp(this._iqtCommand.BooleanType, true)));
			if (flag)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.VisitExpr(expr);
				list.Add(this._iqtCommand.CreateNode(this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not), arg));
			}
			list.Add(this._iqtCommand.CreateNode(this._iqtCommand.CreateInternalConstantOp(this._iqtCommand.BooleanType, false)));
			if (flag)
			{
				list.Add(this._iqtCommand.CreateNode(this._iqtCommand.CreateNullOp(this._iqtCommand.BooleanType)));
			}
			node = this._iqtCommand.CreateNode(op, list);
			return node;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00075D10 File Offset: 0x00073F10
		private bool IsNullable(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = expression.ExpressionKind;
			if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsNull)
			{
				switch (expressionKind)
				{
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.All:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Any:
					break;
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.And:
					goto IL_47;
				default:
					if (expressionKind - global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsEmpty > 1)
					{
						return true;
					}
					break;
				}
				return false;
			}
			if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Not)
			{
				return this.IsNullable(((global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression)expression).Argument);
			}
			if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Or)
			{
				return true;
			}
			IL_47:
			global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression dbBinaryExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression)expression;
			return this.IsNullable(dbBinaryExpression.Left) || this.IsNullable(dbBinaryExpression.Right);
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00075D8C File Offset: 0x00073F8C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitExprAsPredicate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
		{
			if (expr == null)
			{
				return null;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.VisitExpr(expr);
			if (!this.IsPredicate(expr))
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op = this._iqtCommand.CreateComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, false);
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this._iqtCommand.CreateNode(this._iqtCommand.CreateInternalConstantOp(this._iqtCommand.BooleanType, true));
				node = this._iqtCommand.CreateNode(op, node, arg);
			}
			else
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!node.Op.IsRelOp, "unexpected relOp as predicate?");
			}
			return node;
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00075E10 File Offset: 0x00074010
		private static global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> VisitExpr(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> exprs, global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate exprDelegate)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			for (int i = 0; i < exprs.Count; i++)
			{
				list.Add(exprDelegate(exprs[i]));
			}
			return list;
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00075E48 File Offset: 0x00074048
		private global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> VisitExprAsScalar(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> exprs)
		{
			return global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExpr(exprs, new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate(this.VisitExprAsScalar));
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00075E5C File Offset: 0x0007405C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitUnary(global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression e, global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate exprDelegate)
		{
			return this._iqtCommand.CreateNode(op, exprDelegate(e.Argument));
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00075E76 File Offset: 0x00074076
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression e, global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate exprDelegate)
		{
			return this._iqtCommand.CreateNode(op, exprDelegate(e.Left), exprDelegate(e.Right));
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x00075E9C File Offset: 0x0007409C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node EnsureRelOp(global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = inputNode.Op;
			if (op.IsRelOp)
			{
				return inputNode;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp scalarOp = op as global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(scalarOp != null, "An expression in a CQT produced a non-ScalarOp and non-RelOp output Op");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(scalarOp.Type), "An expression used as a RelOp argument was neither a RelOp or a collection");
			if (op is global::System.Data.Entity.Core.Query.InternalTrees.CollectOp)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(inputNode.HasChild0, "CollectOp without argument");
				if (inputNode.Child0.Op is global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp)
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(inputNode.Child0.HasChild0, "PhysicalProjectOp without argument");
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(inputNode.Child0.Child0.Op.IsRelOp, "PhysicalProjectOp applied to non-RelOp input");
					return inputNode.Child0.Child0;
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Var v;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this._iqtCommand.CreateVarDefNode(inputNode, out v);
			global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp unnestOp = this._iqtCommand.CreateUnnestOp(v);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(unnestOp.Table.Columns.Count == 1, "Un-nest of collection ScalarOp produced unexpected number of columns (1 expected)");
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this._iqtCommand.CreateNode(unnestOp, arg);
			this._varMap[node] = unnestOp.Table.Columns[0];
			global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = this._iqtCommand.CreateNode(this._iqtCommand.CreateVarRefOp(unnestOp.Table.Columns[0]));
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = this._iqtCommand.CreateVarDefListNode(definingExpr, out var);
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op2 = this._iqtCommand.CreateProjectOp(var);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this._iqtCommand.CreateNode(op2, node, arg2);
			this._varMap[node2] = var;
			return node2;
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x00076020 File Offset: 0x00074220
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CapWithProject(global::System.Data.Entity.Core.Query.InternalTrees.Node input)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(input.Op.IsRelOp, "unexpected non-RelOp?");
			if (input.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project)
			{
				return input;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = this._varMap[input];
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op = this._iqtCommand.CreateProjectOp(var);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this._iqtCommand.CreateNode(op, input, this._iqtCommand.CreateNode(this._iqtCommand.CreateVarDefListOp()));
			this._varMap[node] = var;
			return node;
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x000760A0 File Offset: 0x000742A0
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CapWithPhysicalProject(global::System.Data.Entity.Core.Query.InternalTrees.Node input)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(input.Op.IsRelOp, "unexpected non-RelOp?");
			global::System.Data.Entity.Core.Query.InternalTrees.Var outputVar = this._varMap[input];
			global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op = this._iqtCommand.CreatePhysicalProjectOp(outputVar);
			return this._iqtCommand.CreateNode(op, input);
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000760E9 File Offset: 0x000742E9
		private global::System.Data.Entity.Core.Query.InternalTrees.Node EnterExpressionBinding(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding)
		{
			return this.VisitBoundExpressionPushBindingScope(binding.Expression, binding.VariableName);
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000760FD File Offset: 0x000742FD
		private global::System.Data.Entity.Core.Query.InternalTrees.Node EnterGroupExpressionBinding(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding binding)
		{
			return this.VisitBoundExpressionPushBindingScope(binding.Expression, binding.VariableName);
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x00076114 File Offset: 0x00074314
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitBoundExpressionPushBindingScope(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression boundExpression, string bindingName)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var boundVar;
			global::System.Data.Entity.Core.Query.InternalTrees.Node result = this.VisitBoundExpression(boundExpression, out boundVar);
			this.PushBindingScope(boundVar, bindingName);
			return result;
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x00076134 File Offset: 0x00074334
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitBoundExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression boundExpression, out global::System.Data.Entity.Core.Query.InternalTrees.Var boundVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.VisitExpr(boundExpression);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node != null, "DbExpressionBinding.Expression produced null conversion");
			node = this.EnsureRelOp(node);
			boundVar = this._varMap[node];
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(boundVar != null, "No Var found for Input Op");
			return node;
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x0007617D File Offset: 0x0007437D
		private void PushBindingScope(global::System.Data.Entity.Core.Query.InternalTrees.Var boundVar, string bindingName)
		{
			this._varScopes.Push(new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ExpressionBindingScope(this._iqtCommand, bindingName, boundVar));
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x00076197 File Offset: 0x00074397
		private global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ExpressionBindingScope ExitExpressionBinding()
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ExpressionBindingScope expressionBindingScope = this._varScopes.Pop() as global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ExpressionBindingScope;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(expressionBindingScope != null, "ExitExpressionBinding called without ExpressionBindingScope on top of scope stack");
			return expressionBindingScope;
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x000761B7 File Offset: 0x000743B7
		private void ExitGroupExpressionBinding()
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this._varScopes.Pop() is global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ExpressionBindingScope, "ExitGroupExpressionBinding called without ExpressionBindingScope on top of scope stack");
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x000761D8 File Offset: 0x000743D8
		private void EnterLambdaFunction(global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda, global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Query.InternalTrees.Node, bool>> argumentValues, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction expandingEdmFunction)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> variables = lambda.Variables;
			global::System.Collections.Generic.Dictionary<string, global::System.Tuple<global::System.Data.Entity.Core.Query.InternalTrees.Node, bool>> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Tuple<global::System.Data.Entity.Core.Query.InternalTrees.Node, bool>>();
			int num = 0;
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Query.InternalTrees.Node, bool> value in argumentValues)
			{
				dictionary.Add(variables[num].VariableName, value);
				num++;
			}
			if (expandingEdmFunction != null)
			{
				if (this._functionExpansions.Contains(expandingEdmFunction))
				{
					throw new global::System.Data.Entity.Core.EntityCommandCompilationException(global::System.Data.Entity.Resources.Strings.Cqt_UDF_FunctionDefinitionWithCircularReference(expandingEdmFunction.FullName), null);
				}
				this._functionExpansions.Push(expandingEdmFunction);
			}
			this._varScopes.Push(new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.LambdaScope(this, this._iqtCommand, dictionary));
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00076290 File Offset: 0x00074490
		private global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.LambdaScope ExitLambdaFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction expandingEdmFunction)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.LambdaScope lambdaScope = this._varScopes.Pop() as global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.LambdaScope;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(lambdaScope != null, "ExitLambdaFunction called without LambdaScope on top of scope stack");
			if (expandingEdmFunction != null)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this._functionExpansions.Pop() == expandingEdmFunction, "Function expansion stack corruption: unexpected function at the top of the stack");
			}
			return lambdaScope;
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x000762CC File Offset: 0x000744CC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ProjectNewRecord(global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode, global::System.Data.Entity.Core.Metadata.Edm.RowType recType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> colVars)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in colVars)
			{
				list.Add(this._iqtCommand.CreateNode(this._iqtCommand.CreateVarRefOp(v)));
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = this._iqtCommand.CreateNode(this._iqtCommand.CreateNewRecordOp(recType), list);
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this._iqtCommand.CreateVarDefListNode(definingExpr, out var);
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op = this._iqtCommand.CreateProjectOp(var);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this._iqtCommand.CreateNode(op, inputNode, arg);
			this._varMap[node] = var;
			return node;
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x00076390 File Offset: 0x00074590
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(e, "e");
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Cqt_General_UnsupportedExpression(e.GetType().FullName));
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x000763B4 File Offset: 0x000745B4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp op = this._iqtCommand.CreateConstantOp(e.ResultType, e.GetValue());
			return this._iqtCommand.CreateNode(op);
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000763F4 File Offset: 0x000745F4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.NullOp op = this._iqtCommand.CreateNullOp(e.ResultType);
			return this._iqtCommand.CreateNode(op);
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x0007642B File Offset: 0x0007462B
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(e, "e");
			return this.ResolveScope(e)[e.VariableName];
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x0007644C File Offset: 0x0007464C
		private global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.CqtVariableScope ResolveScope(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression e)
		{
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.CqtVariableScope cqtVariableScope in this._varScopes)
			{
				if (cqtVariableScope.Contains(e.VariableName))
				{
					return cqtVariableScope;
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "CQT VarRef could not be resolved in the variable scope stack");
			return null;
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x000764B8 File Offset: 0x000746B8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateVarRefOp(this._iqtCommand.GetParameter(e.ParameterName));
			return this._iqtCommand.CreateNode(op);
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000764FC File Offset: 0x000746FC
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (e.Function.IsModelDefinedFunction)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbLambda generatedFunctionDefinition;
				try
				{
					generatedFunctionDefinition = this._iqtCommand.MetadataWorkspace.GetGeneratedFunctionDefinition(e.Function);
				}
				catch (global::System.Exception ex)
				{
					if (ex.IsCatchableExceptionType())
					{
						throw new global::System.Data.Entity.Core.EntityCommandCompilationException(global::System.Data.Entity.Resources.Strings.Cqt_UDF_FunctionDefinitionGenerationFailed(e.Function.FullName), ex);
					}
					throw;
				}
				result = this.VisitLambdaExpression(generatedFunctionDefinition, e.Arguments, e, e.Function);
			}
			else
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(e.Arguments.Count);
				for (int i = 0; i < e.Arguments.Count; i++)
				{
					list.Add(this.BuildSoftCast(this.VisitExprAsScalar(e.Arguments[i]), e.Function.Parameters[i].TypeUsage));
				}
				result = this._iqtCommand.CreateNode(this._iqtCommand.CreateFunctionOp(e.Function), list);
			}
			return result;
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00076608 File Offset: 0x00074808
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression>(e, "e");
			return this.VisitLambdaExpression(e.Lambda, e.Arguments, e, null);
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x0007662C File Offset: 0x0007482C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitLambdaExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression applicationExpr, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction expandingEdmFunction)
		{
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Query.InternalTrees.Node, bool>> list = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Query.InternalTrees.Node, bool>>(arguments.Count);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in arguments)
			{
				list.Add(global::System.Tuple.Create<global::System.Data.Entity.Core.Query.InternalTrees.Node, bool>(this.VisitExpr(dbExpression), this.IsPredicate(dbExpression)));
			}
			this.EnterLambdaFunction(lambda, list, expandingEdmFunction);
			global::System.Data.Entity.Core.Query.InternalTrees.Node result = this.VisitExpr(lambda.Body);
			this._functionsIsPredicateFlag[applicationExpr] = this.IsPredicate(lambda.Body);
			this.ExitLambdaFunction(expandingEdmFunction);
			return result;
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x000766CC File Offset: 0x000748CC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildSoftCast(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage targetType)
		{
			if (node.Op.IsRelOp)
			{
				targetType = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(targetType).TypeUsage;
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = this._varMap[node];
				if (global::System.Data.Entity.Core.Query.InternalTrees.Command.EqualTypes(targetType, var.Type))
				{
					return node;
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this._iqtCommand.CreateNode(this._iqtCommand.CreateVarRefOp(var));
				global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = this._iqtCommand.CreateNode(this._iqtCommand.CreateSoftCastOp(targetType), arg);
				global::System.Data.Entity.Core.Query.InternalTrees.Var var2;
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = this._iqtCommand.CreateVarDefListNode(definingExpr, out var2);
				global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op = this._iqtCommand.CreateProjectOp(var2);
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this._iqtCommand.CreateNode(op, node, arg2);
				this._varMap[node2] = var2;
				return node2;
			}
			else
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node.Op.IsScalarOp, "I want a scalar op");
				if (global::System.Data.Entity.Core.Query.InternalTrees.Command.EqualTypes(node.Op.Type, targetType))
				{
					return node;
				}
				global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp op2 = this._iqtCommand.CreateSoftCastOp(targetType);
				return this._iqtCommand.CreateNode(op2, node);
			}
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x000767CB File Offset: 0x000749CB
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildSoftCast(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Metadata.Edm.EdmType targetType)
		{
			return this.BuildSoftCast(node, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(targetType));
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x000767DC File Offset: 0x000749DC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildEntityRef(global::System.Data.Entity.Core.Query.InternalTrees.Node arg, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage entityType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = global::System.Data.Entity.Core.Common.TypeHelpers.CreateReferenceTypeUsage((global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.EdmType);
			return this._iqtCommand.CreateNode(this._iqtCommand.CreateGetEntityRefOp(type), arg);
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x00076814 File Offset: 0x00074A14
		private static bool TryRewriteKeyPropertyAccess(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression propertyExpression, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression rewritten)
		{
			if (propertyExpression.Instance.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(propertyExpression.Instance.ResultType.EdmType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)propertyExpression.Instance.ResultType.EdmType;
				global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)propertyExpression.Instance;
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsNavigationProperty(dbPropertyExpression.Property) && entityType.KeyMembers.Contains(propertyExpression.Property))
				{
					global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)dbPropertyExpression.Property;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument = dbPropertyExpression.Instance.GetEntityRef().Navigate(navigationProperty.FromEndMember, navigationProperty.ToEndMember);
					rewritten = argument.GetRefKey();
					rewritten = rewritten.Property(propertyExpression.Property.Name);
					return true;
				}
			}
			rewritten = null;
			return false;
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x000768DC File Offset: 0x00074ADC
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(e, "e");
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty != e.Property.BuiltInTypeKind && e.Property.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationEndMember && global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.NavigationProperty != e.Property.BuiltInTypeKind)
			{
				throw new global::System.NotSupportedException();
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(e.Instance != null, "Static properties are not supported");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e2;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node;
			if (global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.TryRewriteKeyPropertyAccess(e, out e2))
			{
				node = this.VisitExpr(e2);
			}
			else
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.VisitExpr(e.Instance);
				if (e.Instance.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStructuralType(e.Instance.ResultType.EdmType))
				{
					global::System.Collections.IList allStructuralMembers = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetAllStructuralMembers(e.Instance.ResultType.EdmType);
					int num = -1;
					for (int i = 0; i < allStructuralMembers.Count; i++)
					{
						if (string.Equals(e.Property.Name, ((global::System.Data.Entity.Core.Metadata.Edm.EdmMember)allStructuralMembers[i]).Name, global::System.StringComparison.Ordinal))
						{
							num = i;
							break;
						}
					}
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(num > -1, "The specified property was not found");
					node = node2.Children[num];
					node = this.BuildSoftCast(node, e.ResultType);
				}
				else
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreatePropertyOp(e.Property);
					node2 = this.BuildSoftCast(node2, e.Property.DeclaringType);
					node = this._iqtCommand.CreateNode(op, node2);
				}
			}
			return node;
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x00076A48 File Offset: 0x00074C48
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateComparisonOp(global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator._opMap[e.ExpressionKind], false);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.VisitExprAsScalar(e.Left);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.VisitExprAsScalar(e.Right);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(e.Left.ResultType, e.Right.ResultType);
			if (!global::System.Data.Entity.Core.Query.InternalTrees.Command.EqualTypes(e.Left.ResultType, e.Right.ResultType))
			{
				node = this.BuildSoftCast(node, commonTypeUsage);
				node2 = this.BuildSoftCast(node2, commonTypeUsage);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(commonTypeUsage) && (e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals || e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NotEquals))
			{
				node = this.BuildEntityRef(node, commonTypeUsage);
				node2 = this.BuildEntityRef(node2, commonTypeUsage);
			}
			return this._iqtCommand.CreateNode(op, node, node2);
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00076B20 File Offset: 0x00074D20
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression>(e, "e");
			return this._iqtCommand.CreateNode(this._iqtCommand.CreateLikeOp(), this.VisitExpr(e.Argument), this.VisitExpr(e.Pattern), this.VisitExpr(e.Escape));
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x00076B74 File Offset: 0x00074D74
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CreateLimitNode(global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode, global::System.Data.Entity.Core.Query.InternalTrees.Node limitNode, bool withTies)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstrainedSort == inputNode.Op.OpType && global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null == inputNode.Child2.Op.OpType)
			{
				inputNode.Child2 = limitNode;
				if (withTies)
				{
					((global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp)inputNode.Op).WithTies = true;
				}
				result = inputNode;
			}
			else if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort == inputNode.Op.OpType)
			{
				result = this._iqtCommand.CreateNode(this._iqtCommand.CreateConstrainedSortOp(((global::System.Data.Entity.Core.Query.InternalTrees.SortOp)inputNode.Op).Keys, withTies), inputNode.Child0, this._iqtCommand.CreateNode(this._iqtCommand.CreateNullOp(this._iqtCommand.IntegerType)), limitNode);
			}
			else
			{
				result = this._iqtCommand.CreateNode(this._iqtCommand.CreateConstrainedSortOp(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>(), withTies), inputNode, this._iqtCommand.CreateNode(this._iqtCommand.CreateNullOp(this._iqtCommand.IntegerType)), limitNode);
			}
			return result;
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x00076C6C File Offset: 0x00074E6C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression>(expression, "expression");
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.EnsureRelOp(this.VisitExpr(expression.Argument));
			global::System.Data.Entity.Core.Query.InternalTrees.Var value = this._varMap[node];
			global::System.Data.Entity.Core.Query.InternalTrees.Node limitNode = this.VisitExprAsScalar(expression.Limit);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2;
			if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project == node.Op.OpType && (node.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort || node.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstrainedSort))
			{
				node.Child0 = this.CreateLimitNode(node.Child0, limitNode, expression.WithTies);
				node2 = node;
			}
			else
			{
				node2 = this.CreateLimitNode(node, limitNode, expression.WithTies);
			}
			if (node2 != node)
			{
				this._varMap[node2] = value;
			}
			return node2;
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00076D28 File Offset: 0x00074F28
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression>(e, "e");
			bool flag = false;
			if (e.Argument.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsNull)
			{
				flag = true;
			}
			else if (e.Argument.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Not && ((global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression)e.Argument).Argument.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsNull)
			{
				flag = true;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull);
			if (flag)
			{
				return this._iqtCommand.CreateNode(op, this._iqtCommand.CreateNode(this._iqtCommand.CreateInternalConstantOp(this._iqtCommand.BooleanType, true)));
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.VisitExprAsScalar(e.Argument);
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(e.Argument.ResultType))
			{
				node = this.BuildEntityRef(node, e.Argument.ResultType);
			}
			return this._iqtCommand.CreateNode(op, node);
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00076E04 File Offset: 0x00075004
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateArithmeticOp(global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator._opMap[e.ExpressionKind], e.ResultType);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr in e.Arguments)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.VisitExprAsScalar(expr);
				list.Add(this.BuildSoftCast(node, e.ResultType));
			}
			return this._iqtCommand.CreateNode(op, list);
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00076EA8 File Offset: 0x000750A8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And);
			return this.VisitBinary(e, op, new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate(this.VisitExprAsPredicate));
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00076EE4 File Offset: 0x000750E4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Or);
			return this.VisitBinary(e, op, new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate(this.VisitExprAsPredicate));
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x00076F20 File Offset: 0x00075120
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.In);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(1 + e.List.Count)
			{
				this.VisitExpr(e.Item)
			};
			list.AddRange(e.List.Select(new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Query.InternalTrees.Node>(this.VisitExpr)));
			return this._iqtCommand.CreateNode(op, list);
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00076F98 File Offset: 0x00075198
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not);
			return this.VisitUnary(e, op, new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate(this.VisitExprAsPredicate));
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00076FD4 File Offset: 0x000751D4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.EnsureRelOp(this.VisitExpr(e.Argument));
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = this._varMap[node];
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateDistinctOp(var);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this._iqtCommand.CreateNode(op, node);
			this._varMap[node2] = var;
			return node2;
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x00077038 File Offset: 0x00075238
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateElementOp(e.ResultType);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.EnsureRelOp(this.VisitExpr(e.Argument));
			node = this.BuildSoftCast(node, global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionTypeUsage(e.ResultType));
			global::System.Data.Entity.Core.Query.InternalTrees.Var value = this._varMap[node];
			node = this._iqtCommand.CreateNode(this._iqtCommand.CreateSingleRowOp(), node);
			this._varMap[node] = value;
			node = this.CapWithProject(node);
			return this._iqtCommand.CreateNode(op, node);
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x000770D0 File Offset: 0x000752D0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateExistsOp();
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.EnsureRelOp(this.VisitExpr(e.Argument));
			return this._iqtCommand.CreateNode(this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not), this._iqtCommand.CreateNode(op, arg));
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00077130 File Offset: 0x00075330
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitSetOpExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression expression)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Except == expression.ExpressionKind || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Intersect == expression.ExpressionKind || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.UnionAll == expression.ExpressionKind, "Non-SetOp DbExpression used as argument to VisitSetOpExpression");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(expression.ResultType), "SetOp DbExpression does not have collection result type?");
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.EnsureRelOp(this.VisitExpr(expression.Left));
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.EnsureRelOp(this.VisitExpr(expression.Right));
			node = this.BuildSoftCast(node, expression.ResultType);
			node2 = this.BuildSoftCast(node2, expression.ResultType);
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = this._iqtCommand.CreateSetOpVar(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(expression.ResultType).TypeUsage);
			global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
			varMap.Add(var, this._varMap[node]);
			global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap2 = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
			varMap2.Add(var, this._varMap[node2]);
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = null;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = expression.ExpressionKind;
			if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Except)
			{
				if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Intersect)
				{
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.UnionAll)
					{
						op = this._iqtCommand.CreateUnionAllOp(varMap, varMap2);
					}
				}
				else
				{
					op = this._iqtCommand.CreateIntersectOp(varMap, varMap2);
				}
			}
			else
			{
				op = this._iqtCommand.CreateExceptOp(varMap, varMap2);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node3 = this._iqtCommand.CreateNode(op, node, node2);
			this._varMap[node3] = var;
			return node3;
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00077283 File Offset: 0x00075483
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression>(e, "e");
			return this.VisitSetOpExpression(e);
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00077298 File Offset: 0x00075498
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression>(e, "e");
			return this.VisitSetOpExpression(e);
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x000772AD File Offset: 0x000754AD
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression>(e, "e");
			return this.VisitSetOpExpression(e);
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x000772C4 File Offset: 0x000754C4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op;
			if (this._fakeTreats.Contains(e))
			{
				op = this._iqtCommand.CreateFakeTreatOp(e.ResultType);
			}
			else
			{
				op = this._iqtCommand.CreateTreatOp(e.ResultType);
			}
			return this.VisitUnary(e, op, new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate(this.VisitExprAsScalar));
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x00077328 File Offset: 0x00075528
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op;
			if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOfOnly == e.ExpressionKind)
			{
				op = this._iqtCommand.CreateIsOfOnlyOp(e.OfType);
			}
			else
			{
				op = this._iqtCommand.CreateIsOfOp(e.OfType);
			}
			return this.VisitUnary(e, op, new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate(this.VisitExprAsScalar));
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00077388 File Offset: 0x00075588
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateCastOp(e.ResultType);
			return this.VisitUnary(e, op, new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate(this.VisitExprAsScalar));
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x000773C8 File Offset: 0x000755C8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression>(e, "e");
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			for (int i = 0; i < e.When.Count; i++)
			{
				list.Add(this.VisitExprAsPredicate(e.When[i]));
				list.Add(this.BuildSoftCast(this.VisitExprAsScalar(e.Then[i]), e.ResultType));
			}
			list.Add(this.BuildSoftCast(this.VisitExprAsScalar(e.Else), e.ResultType));
			return this._iqtCommand.CreateNode(this._iqtCommand.CreateCaseOp(e.ResultType), list);
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00077474 File Offset: 0x00075674
		private global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression CreateIsOfFilterExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter typeFilter)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding resultBinding = input.Bind();
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate = global::System.Data.Entity.Core.Common.Utils.Helpers.BuildBalancedTreeInPlace<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(typeFilter.ToEnumerable().Select(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool> tf)
			{
				if (!tf.Value)
				{
					return resultBinding.Variable.IsOf(tf.Key);
				}
				return resultBinding.Variable.IsOfOnly(tf.Key);
			}).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression>()), (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right) => left.And(right));
			global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression dbFilterExpression = resultBinding.Filter(predicate);
			this._processedIsOfFilters.Add(dbFilterExpression);
			return dbFilterExpression;
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x000774F4 File Offset: 0x000756F4
		private static bool IsIsOfFilter(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter)
		{
			if (filter.Predicate.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOf && filter.Predicate.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOfOnly)
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument = ((global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression)filter.Predicate).Argument;
			return argument.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference && ((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)argument).VariableName == filter.Input.VariableName;
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x0007755C File Offset: 0x0007575C
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ApplyIsOfFilter(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression current, global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter typeFilter)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = current.ExpressionKind;
			if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Filter)
			{
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Distinct)
				{
					return this.ApplyIsOfFilter(((global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression)current).Argument, typeFilter).Distinct();
				}
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Filter)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression dbFilterExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression)current;
					if (global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsIsOfFilter(dbFilterExpression))
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression other = (global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression)dbFilterExpression.Predicate;
						typeFilter = typeFilter.Merge(other);
						return this.ApplyIsOfFilter(dbFilterExpression.Input.Expression, typeFilter);
					}
					return this.ApplyIsOfFilter(dbFilterExpression.Input.Expression, typeFilter).BindAs(dbFilterExpression.Input.VariableName).Filter(dbFilterExpression.Predicate);
				}
			}
			else
			{
				if (expressionKind - global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OfType <= 1)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression dbOfTypeExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression)current;
					typeFilter = typeFilter.Merge(dbOfTypeExpression);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = this.ApplyIsOfFilter(dbOfTypeExpression.Argument, typeFilter).Bind();
					global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression dbTreatExpression = dbExpressionBinding.Variable.TreatAs(dbOfTypeExpression.OfType);
					this._fakeTreats.Add(dbTreatExpression);
					return dbExpressionBinding.Project(dbTreatExpression);
				}
				if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
				{
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Sort)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression dbSortExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression)current;
						return this.ApplyIsOfFilter(dbSortExpression.Input.Expression, typeFilter).BindAs(dbSortExpression.Input.VariableName).Sort(dbSortExpression.SortOrder);
					}
				}
				else
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)current;
					if (dbProjectExpression.Projection.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference && ((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)dbProjectExpression.Projection).VariableName == dbProjectExpression.Input.VariableName)
					{
						return this.ApplyIsOfFilter(dbProjectExpression.Input.Expression, typeFilter);
					}
					return this.CreateIsOfFilterExpression(current, typeFilter);
				}
			}
			return this.CreateIsOfFilterExpression(current, typeFilter);
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x00077728 File Offset: 0x00075928
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression>(e, "e");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(e.Argument.ResultType), "Non-Collection Type Argument in DbOfTypeExpression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e2 = this.ApplyIsOfFilter(e.Argument, new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter(e));
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.EnsureRelOp(this.VisitExpr(e2));
			global::System.Data.Entity.Core.Query.InternalTrees.Var inputVar = this._varMap[node];
			global::System.Data.Entity.Core.Query.InternalTrees.Var value;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this._iqtCommand.BuildFakeTreatProject(node, inputVar, e.OfType, out value);
			this._varMap[node2] = value;
			return node2;
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x000777B0 File Offset: 0x000759B0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = null;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = null;
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(e.ResultType))
			{
				op = this._iqtCommand.CreateNewMultisetOp(e.ResultType);
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(e.ResultType))
			{
				op = this._iqtCommand.CreateNewRecordOp(e.ResultType);
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(e.ResultType))
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>();
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				if (e.HasRelatedEntityReferences)
				{
					foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef dbRelatedEntityRef in e.RelatedEntityReferences)
					{
						global::System.Data.Entity.Core.Query.InternalTrees.RelProperty item = new global::System.Data.Entity.Core.Query.InternalTrees.RelProperty((global::System.Data.Entity.Core.Metadata.Edm.RelationshipType)dbRelatedEntityRef.TargetEnd.DeclaringType, dbRelatedEntityRef.SourceEnd, dbRelatedEntityRef.TargetEnd);
						list2.Add(item);
						global::System.Data.Entity.Core.Query.InternalTrees.Node item2 = this.VisitExprAsScalar(dbRelatedEntityRef.TargetEntityReference);
						list.Add(item2);
					}
				}
				op = this._iqtCommand.CreateNewEntityOp(e.ResultType, list2);
			}
			else
			{
				op = this._iqtCommand.CreateNewInstanceOp(e.ResultType);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructuralType(e.ResultType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>(e.ResultType);
				int num = 0;
				using (global::System.Collections.IEnumerator enumerator2 = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(edmType).GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						global::System.Data.Entity.Core.Metadata.Edm.EdmMember member = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
						global::System.Data.Entity.Core.Query.InternalTrees.Node item3 = this.BuildSoftCast(this.VisitExprAsScalar(e.Arguments[num]), global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(member));
						list3.Add(item3);
						num++;
					}
					goto IL_1FF;
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(e.ResultType).TypeUsage;
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr in e.Arguments)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node item4 = this.BuildSoftCast(this.VisitExprAsScalar(expr), typeUsage);
				list3.Add(item4);
			}
			IL_1FF:
			if (list != null)
			{
				list3.AddRange(list);
			}
			return this._iqtCommand.CreateNode(op, list3);
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x000779FC File Offset: 0x00075BFC
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateRefOp(e.EntitySet, e.ResultType);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.BuildSoftCast(this.VisitExprAsScalar(e.Argument), global::System.Data.Entity.Core.Common.TypeHelpers.CreateKeyRowType(e.EntitySet.ElementType));
			return this._iqtCommand.CreateNode(op, arg);
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00077A60 File Offset: 0x00075C60
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty = new global::System.Data.Entity.Core.Query.InternalTrees.RelProperty(e.Relationship, e.NavigateFrom, e.NavigateTo);
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateNavigateOp(e.ResultType, relProperty);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.VisitExprAsScalar(e.NavigationSource);
			return this._iqtCommand.CreateNode(op, arg);
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x00077AC0 File Offset: 0x00075CC0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateDerefOp(e.ResultType);
			return this.VisitUnary(e, op, new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate(this.VisitExprAsScalar));
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00077B00 File Offset: 0x00075D00
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateGetRefKeyOp(e.ResultType);
			return this.VisitUnary(e, op, new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate(this.VisitExprAsScalar));
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00077B40 File Offset: 0x00075D40
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateGetEntityRefOp(e.ResultType);
			return this.VisitUnary(e, op, new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.VisitExprDelegate(this.VisitExprAsScalar));
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x00077B80 File Offset: 0x00075D80
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.TableMD tableMetadata = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateTableDefinition(e.Target);
			global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp = this._iqtCommand.CreateScanTableOp(tableMetadata);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this._iqtCommand.CreateNode(scanTableOp);
			global::System.Data.Entity.Core.Query.InternalTrees.Var value = scanTableOp.Table.Columns[0];
			this._varMap[node] = value;
			return node;
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00077BE0 File Offset: 0x00075DE0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>(e, "e");
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsIsOfFilter(e) || this._processedIsOfFilters.Contains(e))
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.EnterExpressionBinding(e.Input);
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.VisitExprAsPredicate(e.Predicate);
				this.ExitExpressionBinding();
				global::System.Data.Entity.Core.Query.InternalTrees.Op op = this._iqtCommand.CreateFilterOp();
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this._iqtCommand.CreateNode(op, node, arg);
				this._varMap[node2] = this._varMap[node];
				return node2;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression template = (global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression)e.Predicate;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e2 = this.ApplyIsOfFilter(e.Input.Expression, new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter(template));
			return this.VisitExpr(e2);
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x00077C94 File Offset: 0x00075E94
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression>(e, "e");
			if (e == this._discriminatedViewTopProject)
			{
				return this.GenerateDiscriminatedProject(e);
			}
			return this.GenerateStandardProject(e);
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x00077CBC File Offset: 0x00075EBC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node GenerateDiscriminatedProject(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression e)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this._discriminatedViewTopProject != null, "if a project matches the pattern, there must be a corresponding discriminator map");
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.EnterExpressionBinding(e.Input);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValuePair in this._discriminatorMap.RelPropertyMap)
			{
				list.Add(keyValuePair.Key);
				list2.Add(this.VisitExprAsScalar(keyValuePair.Value));
			}
			global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp op = this._iqtCommand.CreateDiscriminatedNewEntityOp(e.Projection.ResultType, new global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap(this._discriminatorMap), this._discriminatorMap.EntitySet, list);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(this._discriminatorMap.PropertyMap.Count + 1);
			list3.Add(this.CreateNewInstanceArgument(this._discriminatorMap.Discriminator.Property, this._discriminatorMap.Discriminator));
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValuePair2 in this._discriminatorMap.PropertyMap)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value = keyValuePair2.Value;
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty key = keyValuePair2.Key;
				global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.CreateNewInstanceArgument(key, value);
				list3.Add(item);
			}
			list3.AddRange(list2);
			global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = this._iqtCommand.CreateNode(op, list3);
			this.ExitExpressionBinding();
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = this._iqtCommand.CreateVarDefListNode(definingExpr, out var);
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op2 = this._iqtCommand.CreateProjectOp(var);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this._iqtCommand.CreateNode(op2, arg, arg2);
			this._varMap[node] = var;
			return node;
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00077E94 File Offset: 0x00076094
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CreateNewInstanceArgument(global::System.Data.Entity.Core.Metadata.Edm.EdmMember property, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value)
		{
			return this.BuildSoftCast(this.VisitExprAsScalar(value), global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(property));
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00077EAC File Offset: 0x000760AC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node GenerateStandardProject(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression e)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.EnterExpressionBinding(e.Input);
			global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = this.VisitExprAsScalar(e.Projection);
			this.ExitExpressionBinding();
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = this._iqtCommand.CreateVarDefListNode(definingExpr, out var);
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op = this._iqtCommand.CreateProjectOp(var);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this._iqtCommand.CreateNode(op, arg, arg2);
			this._varMap[node] = var;
			return node;
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00077F18 File Offset: 0x00076118
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression>(e, "e");
			return this.VisitJoin(e, e.Inputs, null);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00077F34 File Offset: 0x00076134
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression>(e, "e");
			return this.VisitJoin(e, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>
			{
				e.Left,
				e.Right
			}, e.JoinCondition);
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x00077F7C File Offset: 0x0007617C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitJoin(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> inputs, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCond)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossJoin == e.ExpressionKind || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin == e.ExpressionKind || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin == e.ExpressionKind || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin == e.ExpressionKind, "Unrecognized JoinType specified in DbJoinExpression");
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			for (int i = 0; i < inputs.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var item2;
				global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.VisitBoundExpression(inputs[i].Expression, out item2);
				list.Add(item);
				list2.Add(item2);
			}
			for (int j = 0; j < list.Count; j++)
			{
				this.PushBindingScope(list2[j], inputs[j].VariableName);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.VisitExprAsPredicate(joinCond);
			for (int k = 0; k < list.Count; k++)
			{
				this.ExitExpressionBinding();
			}
			global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp joinBaseOp = null;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = e.ExpressionKind;
			if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin)
			{
				if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossJoin)
				{
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin)
					{
						joinBaseOp = this._iqtCommand.CreateFullOuterJoinOp();
					}
				}
				else
				{
					joinBaseOp = this._iqtCommand.CreateCrossJoinOp();
				}
			}
			else if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin)
			{
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin)
				{
					joinBaseOp = this._iqtCommand.CreateLeftOuterJoinOp();
				}
			}
			else
			{
				joinBaseOp = this._iqtCommand.CreateInnerJoinOp();
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(joinBaseOp != null, "Unrecognized JoinOp specified in DbJoinExpression, no JoinOp was produced");
			if (e.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossJoin)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node != null, "Non CrossJoinOps must specify a join condition");
				list.Add(node);
			}
			return this.ProjectNewRecord(this._iqtCommand.CreateNode(joinBaseOp, list), global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ExtractElementRowType(e.ResultType), list2);
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x00078108 File Offset: 0x00076308
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.EnterExpressionBinding(e.Input);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.EnterExpressionBinding(e.Apply);
			this.ExitExpressionBinding();
			this.ExitExpressionBinding();
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossApply == e.ExpressionKind || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OuterApply == e.ExpressionKind, "Unrecognized DbExpressionKind specified in DbApplyExpression");
			global::System.Data.Entity.Core.Query.InternalTrees.ApplyBaseOp op;
			if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossApply == e.ExpressionKind)
			{
				op = this._iqtCommand.CreateCrossApplyOp();
			}
			else
			{
				op = this._iqtCommand.CreateOuterApplyOp();
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode = this._iqtCommand.CreateNode(op, node, node2);
			return this.ProjectNewRecord(inputNode, global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ExtractElementRowType(e.ResultType), new global::System.Data.Entity.Core.Query.InternalTrees.Var[]
			{
				this._varMap[node],
				this._varMap[node2]
			});
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x000781D4 File Offset: 0x000763D4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression>(e, "e");
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this._iqtCommand.CreateVarVec();
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2 = this._iqtCommand.CreateVarVec();
			global::System.Data.Entity.Core.Query.InternalTrees.Node node;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list;
			global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ExpressionBindingScope expressionBindingScope;
			this.ExtractKeys(e, varVec, varVec2, out node, out list, out expressionBindingScope);
			int num = -1;
			for (int i = 0; i < e.Aggregates.Count; i++)
			{
				if (e.Aggregates[i].GetType() == typeof(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate))
				{
					num = i;
					break;
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node copyOfInput = null;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> copyOfkeyVarDefNodes = null;
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputVarSet = this._iqtCommand.CreateVarVec();
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec3 = this._iqtCommand.CreateVarVec();
			if (num >= 0)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ExpressionBindingScope expressionBindingScope2;
				this.ExtractKeys(e, varVec3, outputVarSet, out copyOfInput, out copyOfkeyVarDefNodes, out expressionBindingScope2);
			}
			expressionBindingScope = new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ExpressionBindingScope(this._iqtCommand, e.Input.GroupVariableName, expressionBindingScope.ScopeVar);
			this._varScopes.Push(expressionBindingScope);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = null;
			for (int j = 0; j < e.Aggregates.Count; j++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate dbAggregate = e.Aggregates[j];
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> argNodes = this.VisitExprAsScalar(dbAggregate.Arguments);
				global::System.Data.Entity.Core.Query.InternalTrees.Var v;
				if (j != num)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate dbFunctionAggregate = dbAggregate as global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate;
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(dbFunctionAggregate != null, "Unrecognized DbAggregate used in DbGroupByExpression");
					list2.Add(this.ProcessFunctionAggregate(dbFunctionAggregate, argNodes, out v));
				}
				else
				{
					arg = this.ProcessGroupAggregate(list, copyOfInput, copyOfkeyVarDefNodes, varVec3, e.Input.Expression.ResultType, out v);
				}
				varVec2.Set(v);
			}
			this.ExitGroupExpressionBinding();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			list3.Add(node);
			list3.Add(this._iqtCommand.CreateNode(this._iqtCommand.CreateVarDefListOp(), list));
			list3.Add(this._iqtCommand.CreateNode(this._iqtCommand.CreateVarDefListOp(), list2));
			global::System.Data.Entity.Core.Query.InternalTrees.GroupByBaseOp op;
			if (num >= 0)
			{
				list3.Add(this._iqtCommand.CreateNode(this._iqtCommand.CreateVarDefListOp(), arg));
				op = this._iqtCommand.CreateGroupByIntoOp(varVec, this._iqtCommand.CreateVarVec(this._varMap[node]), varVec2);
			}
			else
			{
				op = this._iqtCommand.CreateGroupByOp(varVec, varVec2);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode = this._iqtCommand.CreateNode(op, list3);
			return this.ProjectNewRecord(inputNode, global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ExtractElementRowType(e.ResultType), varVec2);
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x00078434 File Offset: 0x00076634
		private void ExtractKeys(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression e, global::System.Data.Entity.Core.Query.InternalTrees.VarVec keyVarSet, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputVarSet, out global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> keyVarDefNodes, out global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.ExpressionBindingScope scope)
		{
			inputNode = this.EnterGroupExpressionBinding(e.Input);
			keyVarDefNodes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			for (int i = 0; i < e.Keys.Count; i++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr = e.Keys[i];
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.VisitExprAsScalar(expr);
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node.Op is global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp, "GroupBy Key is not a ScalarOp");
				global::System.Data.Entity.Core.Query.InternalTrees.Var v;
				keyVarDefNodes.Add(this._iqtCommand.CreateVarDefNode(node, out v));
				outputVarSet.Set(v);
				keyVarSet.Set(v);
			}
			scope = this.ExitExpressionBinding();
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x000784C8 File Offset: 0x000766C8
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ProcessFunctionAggregate(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate funcAgg, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> argNodes, out global::System.Data.Entity.Core.Query.InternalTrees.Var aggVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = this._iqtCommand.CreateNode(this._iqtCommand.CreateAggregateOp(funcAgg.Function, funcAgg.Distinct), argNodes);
			return this._iqtCommand.CreateVarDefNode(definingExpr, out aggVar);
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x00078508 File Offset: 0x00076708
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ProcessGroupAggregate(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> keyVarDefNodes, global::System.Data.Entity.Core.Query.InternalTrees.Node copyOfInput, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> copyOfkeyVarDefNodes, global::System.Data.Entity.Core.Query.InternalTrees.VarVec copyKeyVarSet, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage inputResultType, out global::System.Data.Entity.Core.Query.InternalTrees.Var groupAggVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = this._varMap[copyOfInput];
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = copyOfInput;
			if (keyVarDefNodes.Count > 0)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this._iqtCommand.CreateVarVec();
				varVec.Set(var);
				varVec.Or(copyKeyVarSet);
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this._iqtCommand.CreateNode(this._iqtCommand.CreateProjectOp(varVec), node, this._iqtCommand.CreateNode(this._iqtCommand.CreateVarDefListOp(), copyOfkeyVarDefNodes));
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				for (int i = 0; i < keyVarDefNodes.Count; i++)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = keyVarDefNodes[i];
					global::System.Data.Entity.Core.Query.InternalTrees.Node node3 = copyOfkeyVarDefNodes[i];
					global::System.Data.Entity.Core.Query.InternalTrees.Var var2 = ((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node2.Op).Var;
					global::System.Data.Entity.Core.Query.InternalTrees.Var var3 = ((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node3.Op).Var;
					this.FlattenProperties(this._iqtCommand.CreateNode(this._iqtCommand.CreateVarRefOp(var2)), list);
					this.FlattenProperties(this._iqtCommand.CreateNode(this._iqtCommand.CreateVarRefOp(var3)), list2);
				}
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list.Count == list2.Count, "The flattened keys lists should have the same number of elements");
				global::System.Data.Entity.Core.Query.InternalTrees.Node node4 = null;
				for (int j = 0; j < list.Count; j++)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Node node5 = list[j];
					global::System.Data.Entity.Core.Query.InternalTrees.Node node6 = list2[j];
					global::System.Data.Entity.Core.Query.InternalTrees.Node node7;
					if (this._useDatabaseNullSemantics)
					{
						node7 = this._iqtCommand.CreateNode(this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Or), this._iqtCommand.CreateNode(this._iqtCommand.CreateComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, false), node5, node6), this._iqtCommand.CreateNode(this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And), this._iqtCommand.CreateNode(this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull), global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(this._iqtCommand, node5)), this._iqtCommand.CreateNode(this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull), global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(this._iqtCommand, node6))));
					}
					else
					{
						node7 = this._iqtCommand.CreateNode(this._iqtCommand.CreateComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, false), node5, node6);
					}
					if (node4 == null)
					{
						node4 = node7;
					}
					else
					{
						node4 = this._iqtCommand.CreateNode(this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And), node4, node7);
					}
				}
				node = this._iqtCommand.CreateNode(this._iqtCommand.CreateFilterOp(), arg, node4);
			}
			this._varMap[node] = var;
			node = this.ConvertRelOpToScalarOpTree(node, inputResultType);
			return this._iqtCommand.CreateVarDefNode(node, out groupAggVar);
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00078794 File Offset: 0x00076994
		private void FlattenProperties(global::System.Data.Entity.Core.Query.InternalTrees.Node input, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> flattenedProperties)
		{
			if (input.Op.Type.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
			{
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties = global::System.Data.Entity.Core.Common.TypeHelpers.GetProperties(input.Op.Type);
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(properties.Count != 0, "No nested properties for RowType");
				for (int i = 0; i < properties.Count; i++)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Node arg = (i == 0) ? input : global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(this._iqtCommand, input);
					this.FlattenProperties(this._iqtCommand.CreateNode(this._iqtCommand.CreatePropertyOp(properties[i]), arg), flattenedProperties);
				}
				return;
			}
			flattenedProperties.Add(input);
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00078830 File Offset: 0x00076A30
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitSortArguments(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys, out global::System.Data.Entity.Core.Query.InternalTrees.Var inputVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.EnterExpressionBinding(input);
			inputVar = this._varMap[node];
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this._iqtCommand.CreateVarVec();
			varVec.Set(inputVar);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(sortKeys.Count == 0, "Non-empty SortKey list before adding converted SortClauses");
			for (int i = 0; i < sortOrder.Count; i++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause dbSortClause = sortOrder[i];
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.VisitExprAsScalar(dbSortClause.Expression);
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node2.Op is global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp, "DbSortClause Expression converted to non-ScalarOp");
				global::System.Data.Entity.Core.Query.InternalTrees.Var v;
				list.Add(this._iqtCommand.CreateVarDefNode(node2, out v));
				varVec.Set(v);
				global::System.Data.Entity.Core.Query.InternalTrees.SortKey item;
				if (string.IsNullOrEmpty(dbSortClause.Collation))
				{
					item = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateSortKey(v, dbSortClause.Ascending);
				}
				else
				{
					item = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateSortKey(v, dbSortClause.Ascending, dbSortClause.Collation);
				}
				sortKeys.Add(item);
			}
			this.ExitExpressionBinding();
			return this._iqtCommand.CreateNode(this._iqtCommand.CreateProjectOp(varVec), node, this._iqtCommand.CreateNode(this._iqtCommand.CreateVarDefListOp(), list));
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00078964 File Offset: 0x00076B64
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression>(expression, "expression");
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>();
			global::System.Data.Entity.Core.Query.InternalTrees.Var value;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.VisitSortArguments(expression.Input, expression.SortOrder, sortKeys, out value);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = this.VisitExprAsScalar(expression.Count);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this._iqtCommand.CreateNode(this._iqtCommand.CreateConstrainedSortOp(sortKeys), arg, arg2, this._iqtCommand.CreateNode(this._iqtCommand.CreateNullOp(this._iqtCommand.IntegerType)));
			this._varMap[node] = value;
			return node;
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x000789F4 File Offset: 0x00076BF4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(e, "e");
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>();
			global::System.Data.Entity.Core.Query.InternalTrees.Var value;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.VisitSortArguments(e.Input, e.SortOrder, sortKeys, out value);
			global::System.Data.Entity.Core.Query.InternalTrees.SortOp op = this._iqtCommand.CreateSortOp(sortKeys);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this._iqtCommand.CreateNode(op, arg);
			this._varMap[node] = value;
			return node;
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00078A58 File Offset: 0x00076C58
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression>(e, "e");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Any == e.ExpressionKind || e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.All, "Invalid DbExpressionKind in DbQuantifierExpression");
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.EnterExpressionBinding(e.Input);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.VisitExprAsPredicate(e.Predicate);
			if (e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.All)
			{
				node2 = this._iqtCommand.CreateNode(this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not), node2);
				global::System.Data.Entity.Core.Query.InternalTrees.Node node3 = this.VisitExprAsScalar(e.Predicate);
				node3 = this._iqtCommand.CreateNode(this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull), node3);
				node2 = this._iqtCommand.CreateNode(this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Or), node2, node3);
			}
			this.ExitExpressionBinding();
			global::System.Data.Entity.Core.Query.InternalTrees.Var value = this._varMap[node];
			node = this._iqtCommand.CreateNode(this._iqtCommand.CreateFilterOp(), node, node2);
			this._varMap[node] = value;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node4 = this._iqtCommand.CreateNode(this._iqtCommand.CreateExistsOp(), node);
			if (e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.All)
			{
				node4 = this._iqtCommand.CreateNode(this._iqtCommand.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not), node4);
			}
			return node4;
		}

		// Token: 0x04000DF6 RID: 3574
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind, global::System.Data.Entity.Core.Query.InternalTrees.OpType> _opMap = global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.InitializeExpressionKindToOpTypeMap();

		// Token: 0x04000DF7 RID: 3575
		private readonly bool _useDatabaseNullSemantics;

		// Token: 0x04000DF8 RID: 3576
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command _iqtCommand;

		// Token: 0x04000DF9 RID: 3577
		private readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.CqtVariableScope> _varScopes = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.CqtVariableScope>();

		// Token: 0x04000DFA RID: 3578
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Var> _varMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Var>();

		// Token: 0x04000DFB RID: 3579
		private readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> _functionExpansions = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>();

		// Token: 0x04000DFC RID: 3580
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> _functionsIsPredicateFlag = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool>();

		// Token: 0x04000DFD RID: 3581
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression> _processedIsOfFilters = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>();

		// Token: 0x04000DFE RID: 3582
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression> _fakeTreats = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression>();

		// Token: 0x04000DFF RID: 3583
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap _discriminatorMap;

		// Token: 0x04000E00 RID: 3584
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression _discriminatedViewTopProject;

		// Token: 0x020009DF RID: 2527
		private abstract class CqtVariableScope
		{
			// Token: 0x06005FD2 RID: 24530
			internal abstract bool Contains(string varName);

			// Token: 0x1700108B RID: 4235
			internal abstract global::System.Data.Entity.Core.Query.InternalTrees.Node this[string varName]
			{
				get;
			}

			// Token: 0x06005FD4 RID: 24532
			internal abstract bool IsPredicate(string varName);
		}

		// Token: 0x020009E0 RID: 2528
		private class ExpressionBindingScope : global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.CqtVariableScope
		{
			// Token: 0x06005FD6 RID: 24534 RVA: 0x00148BA6 File Offset: 0x00146DA6
			internal ExpressionBindingScope(global::System.Data.Entity.Core.Query.InternalTrees.Command iqtTree, string name, global::System.Data.Entity.Core.Query.InternalTrees.Var iqtVar)
			{
				this._tree = iqtTree;
				this._varName = name;
				this._var = iqtVar;
			}

			// Token: 0x06005FD7 RID: 24535 RVA: 0x00148BC3 File Offset: 0x00146DC3
			internal override bool Contains(string name)
			{
				return this._varName == name;
			}

			// Token: 0x1700108C RID: 4236
			internal override global::System.Data.Entity.Core.Query.InternalTrees.Node this[string name]
			{
				get
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(name == this._varName, "huh?");
					return this._tree.CreateNode(this._tree.CreateVarRefOp(this._var));
				}
			}

			// Token: 0x06005FD9 RID: 24537 RVA: 0x00148C05 File Offset: 0x00146E05
			internal override bool IsPredicate(string varName)
			{
				return false;
			}

			// Token: 0x1700108D RID: 4237
			// (get) Token: 0x06005FDA RID: 24538 RVA: 0x00148C08 File Offset: 0x00146E08
			internal global::System.Data.Entity.Core.Query.InternalTrees.Var ScopeVar
			{
				get
				{
					return this._var;
				}
			}

			// Token: 0x04002874 RID: 10356
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command _tree;

			// Token: 0x04002875 RID: 10357
			private readonly string _varName;

			// Token: 0x04002876 RID: 10358
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.Var _var;
		}

		// Token: 0x020009E1 RID: 2529
		private sealed class LambdaScope : global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.CqtVariableScope
		{
			// Token: 0x06005FDB RID: 24539 RVA: 0x00148C10 File Offset: 0x00146E10
			internal LambdaScope(global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator treeGen, global::System.Data.Entity.Core.Query.InternalTrees.Command command, global::System.Collections.Generic.Dictionary<string, global::System.Tuple<global::System.Data.Entity.Core.Query.InternalTrees.Node, bool>> args)
			{
				this._treeGen = treeGen;
				this._command = command;
				this._arguments = args;
				this._referencedArgs = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, bool>(this._arguments.Count);
			}

			// Token: 0x06005FDC RID: 24540 RVA: 0x00148C43 File Offset: 0x00146E43
			internal override bool Contains(string name)
			{
				return this._arguments.ContainsKey(name);
			}

			// Token: 0x1700108E RID: 4238
			internal override global::System.Data.Entity.Core.Query.InternalTrees.Node this[string name]
			{
				get
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this._arguments.ContainsKey(name), "LambdaScope indexer called for invalid Var");
					global::System.Data.Entity.Core.Query.InternalTrees.Node node = this._arguments[name].Item1;
					if (this._referencedArgs.ContainsKey(node))
					{
						global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap = null;
						global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(this._command, node, out varMap);
						if (varMap.Count > 0)
						{
							this.MapCopiedNodeVars(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(1)
							{
								node
							}, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(1)
							{
								node2
							}, varMap);
						}
						node = node2;
					}
					else
					{
						this._referencedArgs[node] = true;
					}
					return node;
				}
			}

			// Token: 0x06005FDE RID: 24542 RVA: 0x00148CEB File Offset: 0x00146EEB
			internal override bool IsPredicate(string name)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this._arguments.ContainsKey(name), "LambdaScope indexer called for invalid Var");
				return this._arguments[name].Item2;
			}

			// Token: 0x06005FDF RID: 24543 RVA: 0x00148D14 File Offset: 0x00146F14
			private void MapCopiedNodeVars(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> sources, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> copies, global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> varMappings)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(sources.Count == copies.Count, "Source/Copy Node count mismatch");
				for (int i = 0; i < sources.Count; i++)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Node node = sources[i];
					global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = copies[i];
					if (node.Children.Count > 0)
					{
						this.MapCopiedNodeVars(node.Children, node2.Children, varMappings);
					}
					global::System.Data.Entity.Core.Query.InternalTrees.Var key = null;
					if (this._treeGen.VarMap.TryGetValue(node, out key))
					{
						global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(varMappings.ContainsKey(key), "No mapping found for Var in Var to Var map from OpCopier");
						this._treeGen.VarMap[node2] = varMappings[key];
					}
				}
			}

			// Token: 0x04002877 RID: 10359
			private readonly global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator _treeGen;

			// Token: 0x04002878 RID: 10360
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command _command;

			// Token: 0x04002879 RID: 10361
			private readonly global::System.Collections.Generic.Dictionary<string, global::System.Tuple<global::System.Data.Entity.Core.Query.InternalTrees.Node, bool>> _arguments;

			// Token: 0x0400287A RID: 10362
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, bool> _referencedArgs;
		}

		// Token: 0x020009E2 RID: 2530
		// (Invoke) Token: 0x06005FE1 RID: 24545
		private delegate global::System.Data.Entity.Core.Query.InternalTrees.Node VisitExprDelegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e);

		// Token: 0x020009E3 RID: 2531
		private class IsOfFilter
		{
			// Token: 0x06005FE4 RID: 24548 RVA: 0x00148DBB File Offset: 0x00146FBB
			internal IsOfFilter(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression template)
			{
				this.requiredType = template.OfType;
				this.isExact = (template.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOfOnly);
			}

			// Token: 0x06005FE5 RID: 24549 RVA: 0x00148DDF File Offset: 0x00146FDF
			internal IsOfFilter(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression template)
			{
				this.requiredType = template.OfType;
				this.isExact = (template.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OfTypeOnly);
			}

			// Token: 0x06005FE6 RID: 24550 RVA: 0x00148E03 File Offset: 0x00147003
			private IsOfFilter(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage required, bool exact)
			{
				this.requiredType = required;
				this.isExact = exact;
			}

			// Token: 0x06005FE7 RID: 24551 RVA: 0x00148E1C File Offset: 0x0014701C
			private global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter Merge(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage otherRequiredType, bool otherIsExact)
			{
				bool flag = this.requiredType.EdmEquals(otherRequiredType);
				global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter isOfFilter;
				if (flag && this.isExact == otherIsExact)
				{
					isOfFilter = this;
				}
				else if (this.isExact && otherIsExact)
				{
					isOfFilter = new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter(otherRequiredType, otherIsExact);
					isOfFilter.next = this;
				}
				else if (!this.isExact && !otherIsExact)
				{
					if (otherRequiredType.IsSubtypeOf(this.requiredType))
					{
						isOfFilter = new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter(otherRequiredType, false);
						isOfFilter.next = this.next;
					}
					else if (this.requiredType.IsSubtypeOf(otherRequiredType))
					{
						isOfFilter = this;
					}
					else
					{
						isOfFilter = new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter(otherRequiredType, otherIsExact);
						isOfFilter.next = this;
					}
				}
				else if (flag)
				{
					isOfFilter = new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter(otherRequiredType, true);
					isOfFilter.next = this.next;
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = this.isExact ? this.requiredType : otherRequiredType;
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage2 = this.isExact ? otherRequiredType : this.requiredType;
					if (typeUsage.IsSubtypeOf(typeUsage2))
					{
						if (typeUsage == this.requiredType && this.isExact)
						{
							isOfFilter = this;
						}
						else
						{
							isOfFilter = new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter(typeUsage, true);
							isOfFilter.next = this.next;
						}
					}
					else
					{
						isOfFilter = new global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter(otherRequiredType, otherIsExact);
						isOfFilter.next = this;
					}
				}
				return isOfFilter;
			}

			// Token: 0x06005FE8 RID: 24552 RVA: 0x00148F43 File Offset: 0x00147143
			internal global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter Merge(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression other)
			{
				return this.Merge(other.OfType, other.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOfOnly);
			}

			// Token: 0x06005FE9 RID: 24553 RVA: 0x00148F5B File Offset: 0x0014715B
			internal global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter Merge(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression other)
			{
				return this.Merge(other.OfType, other.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OfTypeOnly);
			}

			// Token: 0x06005FEA RID: 24554 RVA: 0x00148F73 File Offset: 0x00147173
			internal global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool>> ToEnumerable()
			{
				for (global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter currentFilter = this; currentFilter != null; currentFilter = currentFilter.next)
				{
					yield return new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool>(currentFilter.requiredType, currentFilter.isExact);
				}
				yield break;
			}

			// Token: 0x0400287B RID: 10363
			private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage requiredType;

			// Token: 0x0400287C RID: 10364
			private readonly bool isExact;

			// Token: 0x0400287D RID: 10365
			private global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.IsOfFilter next;
		}
	}
}
