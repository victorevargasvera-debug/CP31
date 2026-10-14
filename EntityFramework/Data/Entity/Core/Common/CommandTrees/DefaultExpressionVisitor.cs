using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006E8 RID: 1768
	public class DefaultExpressionVisitor : global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>
	{
		// Token: 0x060051CC RID: 20940 RVA: 0x0012372E File Offset: 0x0012192E
		protected DefaultExpressionVisitor()
		{
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x00123741 File Offset: 0x00121941
		protected virtual void OnExpressionReplaced(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression oldExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression newExpression)
		{
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x00123743 File Offset: 0x00121943
		protected virtual void OnVariableRebound(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression fromVarRef, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression toVarRef)
		{
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x00123745 File Offset: 0x00121945
		protected virtual void OnEnterScope(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> scopeVariables)
		{
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x00123747 File Offset: 0x00121947
		protected virtual void OnExitScope()
		{
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x0012374C File Offset: 0x0012194C
		protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result = null;
			if (expression != null)
			{
				result = expression.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this);
			}
			return result;
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x00123767 File Offset: 0x00121967
		protected virtual global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> VisitExpressionList(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor.VisitList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(list, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this.VisitExpression));
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x0012377C File Offset: 0x0012197C
		protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding VisitExpressionBinding(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = binding;
			if (binding != null)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.VisitExpression(binding.Expression);
				if (binding.Expression != dbExpression)
				{
					dbExpressionBinding = dbExpression.BindAs(binding.VariableName);
					this.RebindVariable(binding.Variable, dbExpressionBinding.Variable);
				}
			}
			return dbExpressionBinding;
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x001237C4 File Offset: 0x001219C4
		protected virtual global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> VisitExpressionBindingList(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> list)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor.VisitList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(list, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(this.VisitExpressionBinding));
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x001237DC File Offset: 0x001219DC
		protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding VisitGroupExpressionBinding(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding binding)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding dbGroupExpressionBinding = binding;
			if (binding != null)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.VisitExpression(binding.Expression);
				if (binding.Expression != dbExpression)
				{
					dbGroupExpressionBinding = dbExpression.GroupBindAs(binding.VariableName, binding.GroupVariableName);
					this.RebindVariable(binding.Variable, dbGroupExpressionBinding.Variable);
					this.RebindVariable(binding.GroupVariable, dbGroupExpressionBinding.GroupVariable);
				}
			}
			return dbGroupExpressionBinding;
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x0012383C File Offset: 0x00121A3C
		protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause VisitSortClause(global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause clause)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause result = clause;
			if (clause != null)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.VisitExpression(clause.Expression);
				if (clause.Expression != dbExpression)
				{
					if (!string.IsNullOrEmpty(clause.Collation))
					{
						result = (clause.Ascending ? dbExpression.ToSortClause(clause.Collation) : dbExpression.ToSortClauseDescending(clause.Collation));
					}
					else
					{
						result = (clause.Ascending ? dbExpression.ToSortClause() : dbExpression.ToSortClauseDescending());
					}
				}
			}
			return result;
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x001238AE File Offset: 0x00121AAE
		protected virtual global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> VisitSortOrder(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor.VisitList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>(sortOrder, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause, global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>(this.VisitSortClause));
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x001238C4 File Offset: 0x00121AC4
		protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate VisitAggregate(global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate aggregate)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate dbFunctionAggregate = aggregate as global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate;
			if (dbFunctionAggregate != null)
			{
				return this.VisitFunctionAggregate(dbFunctionAggregate);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate aggregate2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate)aggregate;
			return this.VisitGroupAggregate(aggregate2);
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x001238F4 File Offset: 0x00121AF4
		protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate VisitFunctionAggregate(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate aggregate)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate result = aggregate;
			if (aggregate != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = this.VisitFunction(aggregate.Function);
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = this.VisitExpressionList(aggregate.Arguments);
				if (aggregate.Function != edmFunction || aggregate.Arguments != list)
				{
					if (aggregate.Distinct)
					{
						result = edmFunction.AggregateDistinct(list);
					}
					else
					{
						result = edmFunction.Aggregate(list);
					}
				}
			}
			return result;
		}

		// Token: 0x060051DA RID: 20954 RVA: 0x00123950 File Offset: 0x00121B50
		protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate VisitGroupAggregate(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate aggregate)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate result = aggregate;
			if (aggregate != null)
			{
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = this.VisitExpressionList(aggregate.Arguments);
				if (aggregate.Arguments != list)
				{
					result = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.GroupAggregate(list[0]);
				}
			}
			return result;
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x00123988 File Offset: 0x00121B88
		protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbLambda VisitLambda(global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambda>(lambda, "lambda");
			global::System.Data.Entity.Core.Common.CommandTrees.DbLambda result = lambda;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> list = global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor.VisitList<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(lambda.Variables, delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression varRef)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = this.VisitTypeUsage(varRef.ResultType);
				if (varRef.ResultType != typeUsage)
				{
					return typeUsage.Variable(varRef.VariableName);
				}
				return varRef;
			});
			this.EnterScope(list.ToArray<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>());
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.VisitExpression(lambda.Body);
			this.ExitScope();
			if (lambda.Variables != list || lambda.Body != dbExpression)
			{
				result = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(dbExpression, list);
			}
			return result;
		}

		// Token: 0x060051DC RID: 20956 RVA: 0x001239F5 File Offset: 0x00121BF5
		protected virtual global::System.Data.Entity.Core.Metadata.Edm.EdmType VisitType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			return type;
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x001239F8 File Offset: 0x00121BF8
		protected virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage VisitTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return type;
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x001239FB File Offset: 0x00121BFB
		protected virtual global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase VisitEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet)
		{
			return entitySet;
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x001239FE File Offset: 0x00121BFE
		protected virtual global::System.Data.Entity.Core.Metadata.Edm.EdmFunction VisitFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionMetadata)
		{
			return functionMetadata;
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x00123A01 File Offset: 0x00121C01
		private void NotifyIfChanged(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression originalExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression newExpression)
		{
			if (originalExpression != newExpression)
			{
				this.OnExpressionReplaced(originalExpression, newExpression);
			}
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x00123A10 File Offset: 0x00121C10
		private static global::System.Collections.Generic.IList<TElement> VisitList<TElement>(global::System.Collections.Generic.IList<TElement> list, global::System.Func<TElement, TElement> map)
		{
			global::System.Collections.Generic.IList<TElement> result = list;
			if (list != null)
			{
				global::System.Collections.Generic.List<TElement> list2 = null;
				for (int i = 0; i < list.Count; i++)
				{
					TElement telement = map(list[i]);
					if (list2 == null && list[i] != telement)
					{
						list2 = new global::System.Collections.Generic.List<TElement>(list);
						result = list2;
					}
					if (list2 != null)
					{
						list2[i] = telement;
					}
				}
			}
			return result;
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x00123A70 File Offset: 0x00121C70
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitUnary(global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression expression, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> callback)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Argument);
			if (expression.Argument != dbExpression2)
			{
				dbExpression = callback(dbExpression2);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x00123AA8 File Offset: 0x00121CA8
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitTypeUnary(global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression expression, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> callback)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Argument);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = this.VisitTypeUsage(type);
			if (expression.Argument != dbExpression2 || type != typeUsage)
			{
				dbExpression = callback(dbExpression2, typeUsage);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x00123AEC File Offset: 0x00121CEC
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression expression, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> callback)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Left);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = this.VisitExpression(expression.Right);
			if (expression.Left != dbExpression2 || expression.Right != dbExpression3)
			{
				dbExpression = callback(dbExpression2, dbExpression3);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x00123B3C File Offset: 0x00121D3C
		private global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef VisitRelatedEntityRef(global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef entityRef)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEndMember;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEndMember2;
			this.VisitRelationshipEnds(entityRef.SourceEnd, entityRef.TargetEnd, out relationshipEndMember, out relationshipEndMember2);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.VisitExpression(entityRef.TargetEntityReference);
			if (entityRef.SourceEnd != relationshipEndMember || entityRef.TargetEnd != relationshipEndMember2 || entityRef.TargetEntityReference != dbExpression)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateRelatedEntityRef(relationshipEndMember, relationshipEndMember2, dbExpression);
			}
			return entityRef;
		}

		// Token: 0x060051E6 RID: 20966 RVA: 0x00123B94 File Offset: 0x00121D94
		private void VisitRelationshipEnds(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember source, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember target, out global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember newSource, out global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember newTarget)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipType)this.VisitType(target.DeclaringType);
			newSource = relationshipType.RelationshipEndMembers[source.Name];
			newTarget = relationshipType.RelationshipEndMembers[target.Name];
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x00123BDC File Offset: 0x00121DDC
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitTerminal(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> reconstructor)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = this.VisitTypeUsage(expression.ResultType);
			if (expression.ResultType != typeUsage)
			{
				dbExpression = reconstructor(typeUsage);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x060051E8 RID: 20968 RVA: 0x00123C14 File Offset: 0x00121E14
		private void RebindVariable(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression from, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression to)
		{
			if (!from.VariableName.Equals(to.VariableName, global::System.StringComparison.Ordinal) || from.ResultType.EdmType != to.ResultType.EdmType || !from.ResultType.EdmEquals(to.ResultType))
			{
				this.varMappings[from] = to;
				this.OnVariableRebound(from, to);
			}
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x00123C78 File Offset: 0x00121E78
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding VisitExpressionBindingEnterScope(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = this.VisitExpressionBinding(binding);
			this.OnEnterScope(new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[]
			{
				dbExpressionBinding.Variable
			});
			return dbExpressionBinding;
		}

		// Token: 0x060051EA RID: 20970 RVA: 0x00123CA3 File Offset: 0x00121EA3
		private void EnterScope(params global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] scopeVars)
		{
			this.OnEnterScope(scopeVars);
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x00123CAC File Offset: 0x00121EAC
		private void ExitScope()
		{
			this.OnExitScope();
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x00123CB4 File Offset: 0x00121EB4
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(expression, "expression");
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Cqt_General_UnsupportedExpression(expression.GetType().FullName));
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x00123CD8 File Offset: 0x00121ED8
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>(expression, "expression");
			return this.VisitTerminal(expression, (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage newType) => newType.Constant(expression.GetValue()));
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x00123D1B File Offset: 0x00121F1B
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression>(expression, "expression");
			return this.VisitTerminal(expression, new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Null));
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00123D3C File Offset: 0x00121F3C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression dbVariableReferenceExpression;
			if (this.varMappings.TryGetValue(expression, out dbVariableReferenceExpression))
			{
				dbExpression = dbVariableReferenceExpression;
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x00123D74 File Offset: 0x00121F74
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(expression, "expression");
			return this.VisitTerminal(expression, (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage newType) => newType.Parameter(expression.ParameterName));
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x00123DB8 File Offset: 0x00121FB8
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = this.VisitExpressionList(expression.Arguments);
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = this.VisitFunction(expression.Function);
			if (expression.Arguments != list || expression.Function != edmFunction)
			{
				dbExpression = edmFunction.Invoke(list);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x060051F2 RID: 20978 RVA: 0x00123E10 File Offset: 0x00122010
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = this.VisitExpressionList(expression.Arguments);
			global::System.Data.Entity.Core.Common.CommandTrees.DbLambda dbLambda = this.VisitLambda(expression.Lambda);
			if (expression.Arguments != list || expression.Lambda != dbLambda)
			{
				dbExpression = dbLambda.Invoke(list);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x00123E68 File Offset: 0x00122068
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Instance);
			if (expression.Instance != dbExpression2)
			{
				dbExpression = dbExpression2.Property(expression.Property.Name);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x00123EB4 File Offset: 0x001220B4
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = expression.ExpressionKind;
			if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThanOrEquals)
			{
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals)
				{
					return this.VisitBinary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Equal));
				}
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThan)
				{
					return this.VisitBinary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.GreaterThan));
				}
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThanOrEquals)
				{
					return this.VisitBinary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.GreaterThanOrEqual));
				}
			}
			else
			{
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThan)
				{
					return this.VisitBinary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.LessThan));
				}
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThanOrEquals)
				{
					return this.VisitBinary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.LessThanOrEqual));
				}
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NotEquals)
				{
					return this.VisitBinary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NotEqual));
				}
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x00123F7C File Offset: 0x0012217C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Argument);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = this.VisitExpression(expression.Pattern);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression4 = this.VisitExpression(expression.Escape);
			if (expression.Argument != dbExpression2 || expression.Pattern != dbExpression3 || expression.Escape != dbExpression4)
			{
				dbExpression = dbExpression2.Like(dbExpression3, dbExpression4);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x00123FEC File Offset: 0x001221EC
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Argument);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = this.VisitExpression(expression.Limit);
			if (expression.Argument != dbExpression2 || expression.Limit != dbExpression3)
			{
				dbExpression = dbExpression2.Limit(dbExpression3);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x00124044 File Offset: 0x00122244
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression>(expression, "expression");
			return this.VisitUnary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.IsNull));
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x00124068 File Offset: 0x00122268
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = this.VisitExpressionList(expression.Arguments);
			if (expression.Arguments != list)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = expression.ExpressionKind;
				if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Multiply)
				{
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Divide)
					{
						dbExpression = list[0].Divide(list[1]);
						goto IL_E1;
					}
					switch (expressionKind)
					{
					case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Minus:
						dbExpression = list[0].Minus(list[1]);
						goto IL_E1;
					case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Modulo:
						dbExpression = list[0].Modulo(list[1]);
						goto IL_E1;
					case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Multiply:
						dbExpression = list[0].Multiply(list[1]);
						goto IL_E1;
					}
				}
				else
				{
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Plus)
					{
						dbExpression = list[0].Plus(list[1]);
						goto IL_E1;
					}
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.UnaryMinus)
					{
						dbExpression = list[0].UnaryMinus();
						goto IL_E1;
					}
				}
				throw new global::System.NotSupportedException();
			}
			IL_E1:
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x060051F9 RID: 20985 RVA: 0x0012415F File Offset: 0x0012235F
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(expression, "expression");
			return this.VisitBinary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.And));
		}

		// Token: 0x060051FA RID: 20986 RVA: 0x00124180 File Offset: 0x00122380
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression>(expression, "expression");
			return this.VisitBinary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Or));
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x001241A4 File Offset: 0x001223A4
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Item);
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = this.VisitExpressionList(expression.List);
			if (expression.Item != dbExpression2 || expression.List != list)
			{
				dbExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateInExpression(dbExpression2, list);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x001241FC File Offset: 0x001223FC
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression>(expression, "expression");
			return this.VisitUnary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Not));
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x0012421D File Offset: 0x0012241D
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression>(expression, "expression");
			return this.VisitUnary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Distinct));
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x0012423E File Offset: 0x0012243E
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression>(expression, "expression");
			return this.VisitUnary(expression, expression.IsSinglePropertyUnwrapped ? new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateElementExpressionUnwrapSingleProperty) : new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Element));
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x00124275 File Offset: 0x00122475
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression>(expression, "expression");
			return this.VisitUnary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.IsEmpty));
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x00124296 File Offset: 0x00122496
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression>(expression, "expression");
			return this.VisitBinary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.UnionAll));
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x001242B7 File Offset: 0x001224B7
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression>(expression, "expression");
			return this.VisitBinary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Intersect));
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x001242D8 File Offset: 0x001224D8
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression>(expression, "expression");
			return this.VisitBinary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Except));
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x001242F9 File Offset: 0x001224F9
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression>(expression, "expression");
			return this.VisitTypeUnary(expression, expression.ResultType, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.TreatAs));
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x00124320 File Offset: 0x00122520
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression>(expression, "expression");
			if (expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOfOnly)
			{
				return this.VisitTypeUnary(expression, expression.OfType, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.IsOfOnly));
			}
			return this.VisitTypeUnary(expression, expression.OfType, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.IsOf));
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x00124376 File Offset: 0x00122576
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression>(expression, "expression");
			return this.VisitTypeUnary(expression, expression.ResultType, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CastTo));
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x001243A0 File Offset: 0x001225A0
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = this.VisitExpressionList(expression.When);
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list2 = this.VisitExpressionList(expression.Then);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Else);
			if (expression.When != list || expression.Then != list2 || expression.Else != dbExpression2)
			{
				dbExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(list, list2, dbExpression2);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x00124410 File Offset: 0x00122610
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression>(expression, "expression");
			if (expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OfTypeOnly)
			{
				return this.VisitTypeUnary(expression, expression.OfType, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.OfTypeOnly));
			}
			return this.VisitTypeUnary(expression, expression.OfType, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.OfType));
		}

		// Token: 0x06005208 RID: 21000 RVA: 0x00124468 File Offset: 0x00122668
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = this.VisitTypeUsage(expression.ResultType);
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = this.VisitExpressionList(expression.Arguments);
			bool flag = expression.ResultType == typeUsage && expression.Arguments == list;
			if (expression.HasRelatedEntityReferences)
			{
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> list2 = global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor.VisitList<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef>(expression.RelatedEntityReferences, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef, global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef>(this.VisitRelatedEntityRef));
				if (!flag || expression.RelatedEntityReferences != list2)
				{
					dbExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateNewEntityWithRelationshipsExpression((global::System.Data.Entity.Core.Metadata.Edm.EntityType)typeUsage.EdmType, list, list2);
				}
			}
			else if (!flag)
			{
				dbExpression = typeUsage.New(list.ToArray<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>());
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x06005209 RID: 21001 RVA: 0x00124510 File Offset: 0x00122710
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(expression.ResultType).ElementType;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Argument);
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)this.VisitType(entityType);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)this.VisitEntitySet(expression.EntitySet);
			if (expression.Argument != dbExpression2 || entityType != entityType2 || expression.EntitySet != entitySet)
			{
				dbExpression = entitySet.RefFromKey(dbExpression2, entityType2);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x0600520A RID: 21002 RVA: 0x00124598 File Offset: 0x00122798
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEndMember;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEndMember2;
			this.VisitRelationshipEnds(expression.NavigateFrom, expression.NavigateTo, out relationshipEndMember, out relationshipEndMember2);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.NavigationSource);
			if (expression.NavigateFrom != relationshipEndMember || expression.NavigateTo != relationshipEndMember2 || expression.NavigationSource != dbExpression2)
			{
				dbExpression = dbExpression2.Navigate(relationshipEndMember, relationshipEndMember2);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x00124603 File Offset: 0x00122803
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression>(expression, "expression");
			return this.VisitUnary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Deref));
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x00124624 File Offset: 0x00122824
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression>(expression, "expression");
			return this.VisitUnary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.GetRefKey));
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x00124645 File Offset: 0x00122845
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression>(expression, "expression");
			return this.VisitUnary(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.GetEntityRef));
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x00124668 File Offset: 0x00122868
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase = this.VisitEntitySet(expression.Target);
			if (expression.Target != entitySetBase)
			{
				dbExpression = entitySetBase.Scan();
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x001246AC File Offset: 0x001228AC
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = this.VisitExpressionBindingEnterScope(expression.Input);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Predicate);
			this.ExitScope();
			if (expression.Input != dbExpressionBinding || expression.Predicate != dbExpression2)
			{
				dbExpression = dbExpressionBinding.Filter(dbExpression2);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x0012470C File Offset: 0x0012290C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = this.VisitExpressionBindingEnterScope(expression.Input);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Projection);
			this.ExitScope();
			if (expression.Input != dbExpressionBinding || expression.Projection != dbExpression2)
			{
				dbExpression = dbExpressionBinding.Project(dbExpression2);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x0012476C File Offset: 0x0012296C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> list = this.VisitExpressionBindingList(expression.Inputs);
			if (expression.Inputs != list)
			{
				dbExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CrossJoin(list);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x001247B0 File Offset: 0x001229B0
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = this.VisitExpressionBinding(expression.Left);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2 = this.VisitExpressionBinding(expression.Right);
			this.EnterScope(new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[]
			{
				dbExpressionBinding.Variable,
				dbExpressionBinding2.Variable
			});
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.JoinCondition);
			this.ExitScope();
			if (expression.Left != dbExpressionBinding || expression.Right != dbExpressionBinding2 || expression.JoinCondition != dbExpression2)
			{
				if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin == expression.ExpressionKind)
				{
					dbExpression = dbExpressionBinding.InnerJoin(dbExpressionBinding2, dbExpression2);
				}
				else if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin == expression.ExpressionKind)
				{
					dbExpression = dbExpressionBinding.LeftOuterJoin(dbExpressionBinding2, dbExpression2);
				}
				else
				{
					dbExpression = dbExpressionBinding.FullOuterJoin(dbExpressionBinding2, dbExpression2);
				}
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x06005213 RID: 21011 RVA: 0x00124870 File Offset: 0x00122A70
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = this.VisitExpressionBindingEnterScope(expression.Input);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2 = this.VisitExpressionBinding(expression.Apply);
			this.ExitScope();
			if (expression.Input != dbExpressionBinding || expression.Apply != dbExpressionBinding2)
			{
				if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossApply == expression.ExpressionKind)
				{
					dbExpression = dbExpressionBinding.CrossApply(dbExpressionBinding2);
				}
				else
				{
					dbExpression = dbExpressionBinding.OuterApply(dbExpressionBinding2);
				}
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x06005214 RID: 21012 RVA: 0x001248E4 File Offset: 0x00122AE4
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding dbGroupExpressionBinding = this.VisitGroupExpressionBinding(expression.Input);
			this.EnterScope(new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[]
			{
				dbGroupExpressionBinding.Variable
			});
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = this.VisitExpressionList(expression.Keys);
			this.ExitScope();
			this.EnterScope(new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[]
			{
				dbGroupExpressionBinding.GroupVariable
			});
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> list2 = global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor.VisitList<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>(expression.Aggregates, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>(this.VisitAggregate));
			this.ExitScope();
			if (expression.Input != dbGroupExpressionBinding || expression.Keys != list || expression.Aggregates != list2)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RowType edmType = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RowType>(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(expression.ResultType).TypeUsage);
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> keys = (from p in edmType.Properties.Take(list.Count)
				select p.Name).Zip(list).ToList<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>();
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>> aggregates = (from p in edmType.Properties.Skip(list.Count)
				select p.Name).Zip(list2).ToList<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>>();
				dbExpression = dbGroupExpressionBinding.GroupBy(keys, aggregates);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x00124A34 File Offset: 0x00122C34
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = this.VisitExpressionBindingEnterScope(expression.Input);
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> list = this.VisitSortOrder(expression.SortOrder);
			this.ExitScope();
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Count);
			if (expression.Input != dbExpressionBinding || expression.SortOrder != list || expression.Count != dbExpression2)
			{
				dbExpression = dbExpressionBinding.Skip(list, dbExpression2);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x06005216 RID: 21014 RVA: 0x00124AAC File Offset: 0x00122CAC
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = this.VisitExpressionBindingEnterScope(expression.Input);
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> list = this.VisitSortOrder(expression.SortOrder);
			this.ExitScope();
			if (expression.Input != dbExpressionBinding || expression.SortOrder != list)
			{
				dbExpression = dbExpressionBinding.Sort(list);
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x06005217 RID: 21015 RVA: 0x00124B0C File Offset: 0x00122D0C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = this.VisitExpressionBindingEnterScope(expression.Input);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Predicate);
			this.ExitScope();
			if (expression.Input != dbExpressionBinding || expression.Predicate != dbExpression2)
			{
				if (expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.All)
				{
					dbExpression = dbExpressionBinding.All(dbExpression2);
				}
				else
				{
					dbExpression = dbExpressionBinding.Any(dbExpression2);
				}
			}
			this.NotifyIfChanged(expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x04001DE0 RID: 7648
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> varMappings = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>();
	}
}
