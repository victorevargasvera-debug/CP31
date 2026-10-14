using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006EC RID: 1772
	internal abstract class ExpressionDumper : global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor
	{
		// Token: 0x0600522A RID: 21034 RVA: 0x0012523E File Offset: 0x0012343E
		internal void Begin(string name)
		{
			this.Begin(name, null);
		}

		// Token: 0x0600522B RID: 21035
		internal abstract void Begin(string name, global::System.Collections.Generic.Dictionary<string, object> attrs);

		// Token: 0x0600522C RID: 21036
		internal abstract void End(string name);

		// Token: 0x0600522D RID: 21037 RVA: 0x00125248 File Offset: 0x00123448
		internal void Dump(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression target)
		{
			target.Accept(this);
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x00125251 File Offset: 0x00123451
		internal void Dump(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e, string name)
		{
			this.Begin(name);
			this.Dump(e);
			this.End(name);
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00125268 File Offset: 0x00123468
		internal void Dump(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding, string name)
		{
			this.Begin(name);
			this.Dump(binding);
			this.End(name);
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x00125280 File Offset: 0x00123480
		internal void Dump(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding)
		{
			this.Begin("DbExpressionBinding", "VariableName", binding.VariableName);
			this.Begin("Expression");
			this.Dump(binding.Expression);
			this.End("Expression");
			this.End("DbExpressionBinding");
		}

		// Token: 0x06005231 RID: 21041 RVA: 0x001252D0 File Offset: 0x001234D0
		internal void Dump(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding binding, string name)
		{
			this.Begin(name);
			this.Dump(binding);
			this.End(name);
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x001252E8 File Offset: 0x001234E8
		internal void Dump(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding binding)
		{
			this.Begin("DbGroupExpressionBinding", "VariableName", binding.VariableName, "GroupVariableName", binding.GroupVariableName);
			this.Begin("Expression");
			this.Dump(binding.Expression);
			this.End("Expression");
			this.End("DbGroupExpressionBinding");
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x00125344 File Offset: 0x00123544
		internal void Dump(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> exprs, string pluralName, string singularName)
		{
			this.Begin(pluralName);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression target in exprs)
			{
				this.Begin(singularName);
				this.Dump(target);
				this.End(singularName);
			}
			this.End(pluralName);
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x001253A8 File Offset: 0x001235A8
		internal void Dump(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> paramList)
		{
			this.Begin("Parameters");
			foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter in paramList)
			{
				this.Begin("Parameter", "Name", functionParameter.Name);
				this.Dump(functionParameter.TypeUsage, "ParameterType");
				this.End("Parameter");
			}
			this.End("Parameters");
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x00125434 File Offset: 0x00123634
		internal void Dump(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name)
		{
			this.Begin(name);
			this.Dump(type);
			this.End(name);
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x0012544C File Offset: 0x0012364C
		internal void Dump(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.Facet facet in type.Facets)
			{
				dictionary.Add(facet.Name, facet.Value);
			}
			this.Begin("TypeUsage", dictionary);
			this.Dump(type.EdmType);
			this.End("TypeUsage");
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x001254D4 File Offset: 0x001236D4
		internal void Dump(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, string name)
		{
			this.Begin(name);
			this.Dump(type);
			this.End(name);
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x001254EC File Offset: 0x001236EC
		internal void Dump(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			this.Begin("EdmType", "BuiltInTypeKind", global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind), type.BuiltInTypeKind), "Namespace", type.NamespaceName, "Name", type.Name);
			this.End("EdmType");
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x00125544 File Offset: 0x00123744
		internal void Dump(global::System.Data.Entity.Core.Metadata.Edm.RelationshipType type, string name)
		{
			this.Begin(name);
			this.Dump(type);
			this.End(name);
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x0012555B File Offset: 0x0012375B
		internal void Dump(global::System.Data.Entity.Core.Metadata.Edm.RelationshipType type)
		{
			this.Begin("RelationshipType", "Namespace", type.NamespaceName, "Name", type.Name);
			this.End("RelationshipType");
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x0012558C File Offset: 0x0012378C
		internal void Dump(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			this.Begin("Function", "Name", function.Name, "Namespace", function.NamespaceName);
			this.Dump(function.Parameters);
			if (function.ReturnParameters.Count == 1)
			{
				this.Dump(function.ReturnParameters[0].TypeUsage, "ReturnType");
			}
			else
			{
				this.Begin("ReturnTypes");
				foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter in function.ReturnParameters)
				{
					this.Dump(functionParameter.TypeUsage, functionParameter.Name);
				}
				this.End("ReturnTypes");
			}
			this.End("Function");
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x00125664 File Offset: 0x00123864
		internal void Dump(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty prop)
		{
			this.Begin("Property", "Name", prop.Name, "Nullable", prop.Nullable);
			this.Dump(prop.DeclaringType, "DeclaringType");
			this.Dump(prop.TypeUsage, "PropertyType");
			this.End("Property");
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x001256C4 File Offset: 0x001238C4
		internal void Dump(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember end, string name)
		{
			this.Begin(name);
			this.Begin("RelationshipEndMember", "Name", end.Name, "RelationshipMultiplicity", global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity), end.RelationshipMultiplicity));
			this.Dump(end.DeclaringType, "DeclaringRelation");
			this.Dump(end.TypeUsage, "EndType");
			this.End("RelationshipEndMember");
			this.End(name);
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x00125744 File Offset: 0x00123944
		internal void Dump(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navProp, string name)
		{
			this.Begin(name);
			this.Begin("NavigationProperty", "Name", navProp.Name, "RelationshipTypeName", navProp.RelationshipType.FullName, "ToEndMemberName", navProp.ToEndMember.Name);
			this.Dump(navProp.DeclaringType, "DeclaringType");
			this.Dump(navProp.TypeUsage, "PropertyType");
			this.End("NavigationProperty");
			this.End(name);
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x001257C4 File Offset: 0x001239C4
		internal void Dump(global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda)
		{
			this.Begin("DbLambda");
			this.Dump(lambda.Variables.Cast<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(), "Variables", "Variable");
			this.Dump(lambda.Body, "Body");
			this.End("DbLambda");
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x00125813 File Offset: 0x00123A13
		private void Begin(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
		{
			this.Begin(expr, new global::System.Collections.Generic.Dictionary<string, object>());
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x00125824 File Offset: 0x00123A24
		private void Begin(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr, global::System.Collections.Generic.Dictionary<string, object> attrs)
		{
			attrs.Add("DbExpressionKind", global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind), expr.ExpressionKind));
			this.Begin(expr.GetType().Name, attrs);
			this.Dump(expr.ResultType, "ResultType");
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x0012587C File Offset: 0x00123A7C
		private void Begin(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr, string attributeName, object attributeValue)
		{
			this.Begin(expr, new global::System.Collections.Generic.Dictionary<string, object>
			{
				{
					attributeName,
					attributeValue
				}
			});
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x001258A0 File Offset: 0x00123AA0
		private void Begin(string expr, string attributeName, object attributeValue)
		{
			this.Begin(expr, new global::System.Collections.Generic.Dictionary<string, object>
			{
				{
					attributeName,
					attributeValue
				}
			});
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x001258C4 File Offset: 0x00123AC4
		private void Begin(string expr, string attributeName1, object attributeValue1, string attributeName2, object attributeValue2)
		{
			this.Begin(expr, new global::System.Collections.Generic.Dictionary<string, object>
			{
				{
					attributeName1,
					attributeValue1
				},
				{
					attributeName2,
					attributeValue2
				}
			});
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x001258F4 File Offset: 0x00123AF4
		private void Begin(string expr, string attributeName1, object attributeValue1, string attributeName2, object attributeValue2, string attributeName3, object attributeValue3)
		{
			this.Begin(expr, new global::System.Collections.Generic.Dictionary<string, object>
			{
				{
					attributeName1,
					attributeValue1
				},
				{
					attributeName2,
					attributeValue2
				},
				{
					attributeName3,
					attributeValue3
				}
			});
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x0012592B File Offset: 0x00123B2B
		private void End(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
		{
			this.End(expr.GetType().Name);
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x0012593E File Offset: 0x00123B3E
		private void BeginUnary(global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression e)
		{
			this.Begin(e);
			this.Begin("Argument");
			this.Dump(e.Argument);
			this.End("Argument");
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x0012596C File Offset: 0x00123B6C
		private void BeginBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression e)
		{
			this.Begin(e);
			this.Begin("Left");
			this.Dump(e.Left);
			this.End("Left");
			this.Begin("Right");
			this.Dump(e.Right);
			this.End("Right");
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x001259C4 File Offset: 0x00123BC4
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(e, "e");
			this.Begin(e);
			this.End(e);
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x001259E0 File Offset: 0x00123BE0
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>(e, "e");
			this.Begin(e, new global::System.Collections.Generic.Dictionary<string, object>
			{
				{
					"Value",
					e.Value
				}
			});
			this.End(e);
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x00125A1F File Offset: 0x00123C1F
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression>(e, "e");
			this.Begin(e);
			this.End(e);
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x00125A3C File Offset: 0x00123C3C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(e, "e");
			this.Begin(e, new global::System.Collections.Generic.Dictionary<string, object>
			{
				{
					"VariableName",
					e.VariableName
				}
			});
			this.End(e);
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x00125A7C File Offset: 0x00123C7C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(e, "e");
			this.Begin(e, new global::System.Collections.Generic.Dictionary<string, object>
			{
				{
					"ParameterName",
					e.ParameterName
				}
			});
			this.End(e);
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x00125ABB File Offset: 0x00123CBB
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Function);
			this.Dump(e.Arguments, "Arguments", "Argument");
			this.End(e);
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x00125AF9 File Offset: 0x00123CF9
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression>(expression, "expression");
			this.Begin(expression);
			this.Dump(expression.Lambda);
			this.Dump(expression.Arguments, "Arguments", "Argument");
			this.End(expression);
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x00125B38 File Offset: 0x00123D38
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(e, "e");
			this.Begin(e);
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEndMember = e.Property as global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember;
			if (relationshipEndMember != null)
			{
				this.Dump(relationshipEndMember, "Property");
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsNavigationProperty(e.Property))
			{
				this.Dump((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)e.Property, "Property");
			}
			else
			{
				this.Dump((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)e.Property);
			}
			if (e.Instance != null)
			{
				this.Dump(e.Instance, "Instance");
			}
			this.End(e);
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x00125BCB File Offset: 0x00123DCB
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(e, "e");
			this.BeginBinary(e);
			this.End(e);
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x00125BE8 File Offset: 0x00123DE8
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Argument, "Argument");
			this.Dump(e.Pattern, "Pattern");
			this.Dump(e.Escape, "Escape");
			this.End(e);
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x00125C44 File Offset: 0x00123E44
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression>(e, "e");
			this.Begin(e, "WithTies", e.WithTies);
			this.Dump(e.Argument, "Argument");
			this.Dump(e.Limit, "Limit");
			this.End(e);
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x00125C9D File Offset: 0x00123E9D
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression>(e, "e");
			this.BeginUnary(e);
			this.End(e);
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x00125CB9 File Offset: 0x00123EB9
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Arguments, "Arguments", "Argument");
			this.End(e);
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x00125CEB File Offset: 0x00123EEB
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(e, "e");
			this.BeginBinary(e);
			this.End(e);
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x00125D07 File Offset: 0x00123F07
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression>(e, "e");
			this.BeginBinary(e);
			this.End(e);
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x00125D23 File Offset: 0x00123F23
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Item);
			this.Dump(e.List, "List", "Item");
			this.End(e);
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x00125D61 File Offset: 0x00123F61
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression>(e, "e");
			this.BeginUnary(e);
			this.End(e);
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x00125D7D File Offset: 0x00123F7D
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression>(e, "e");
			this.BeginUnary(e);
			this.End(e);
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x00125D99 File Offset: 0x00123F99
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression>(e, "e");
			this.BeginUnary(e);
			this.End(e);
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x00125DB5 File Offset: 0x00123FB5
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression>(e, "e");
			this.BeginUnary(e);
			this.End(e);
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x00125DD1 File Offset: 0x00123FD1
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression>(e, "e");
			this.BeginBinary(e);
			this.End(e);
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x00125DED File Offset: 0x00123FED
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression>(e, "e");
			this.BeginBinary(e);
			this.End(e);
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x00125E09 File Offset: 0x00124009
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression>(e, "e");
			this.BeginBinary(e);
			this.End(e);
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x00125E25 File Offset: 0x00124025
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression>(e, "e");
			this.BeginUnary(e);
			this.End(e);
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x00125E41 File Offset: 0x00124041
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression>(e, "e");
			this.BeginUnary(e);
			this.Dump(e.OfType, "OfType");
			this.End(e);
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x00125E6E File Offset: 0x0012406E
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression>(e, "e");
			this.BeginUnary(e);
			this.End(e);
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x00125E8C File Offset: 0x0012408C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.When, "Whens", "When");
			this.Dump(e.Then, "Thens", "Then");
			this.Dump(e.Else, "Else");
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x00125EE9 File Offset: 0x001240E9
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression>(e, "e");
			this.BeginUnary(e);
			this.Dump(e.OfType, "OfType");
			this.End(e);
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x00125F18 File Offset: 0x00124118
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Arguments, "Arguments", "Argument");
			if (e.HasRelatedEntityReferences)
			{
				this.Begin("RelatedEntityReferences");
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef dbRelatedEntityRef in e.RelatedEntityReferences)
				{
					this.Begin("DbRelatedEntityRef");
					this.Dump(dbRelatedEntityRef.SourceEnd, "SourceEnd");
					this.Dump(dbRelatedEntityRef.TargetEnd, "TargetEnd");
					this.Dump(dbRelatedEntityRef.TargetEntityReference, "TargetEntityReference");
					this.End("DbRelatedEntityRef");
				}
				this.End("RelatedEntityReferences");
			}
			this.End(e);
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x00125FF8 File Offset: 0x001241F8
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.NavigateFrom, "NavigateFrom");
			this.Dump(e.NavigateTo, "NavigateTo");
			this.Dump(e.Relationship, "Relationship");
			this.Dump(e.NavigationSource, "NavigationSource");
			this.End(e);
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x00126063 File Offset: 0x00124263
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression>(e, "e");
			this.BeginUnary(e);
			this.End(e);
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x0012607F File Offset: 0x0012427F
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression>(e, "e");
			this.BeginUnary(e);
			this.End(e);
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x0012609B File Offset: 0x0012429B
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression>(e, "e");
			this.BeginUnary(e);
			this.End(e);
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x001260B7 File Offset: 0x001242B7
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression>(e, "e");
			this.BeginUnary(e);
			this.End(e);
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x001260D4 File Offset: 0x001242D4
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(e, "e");
			this.Begin(e);
			this.Begin("Target", "Name", e.Target.Name, "Container", e.Target.EntityContainer.Name);
			this.Dump(e.Target.ElementType, "TargetElementType");
			this.End("Target");
			this.End(e);
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x0012614C File Offset: 0x0012434C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Input, "Input");
			this.Dump(e.Predicate, "Predicate");
			this.End(e);
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x0012618A File Offset: 0x0012438A
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Input, "Input");
			this.Dump(e.Projection, "Projection");
			this.End(e);
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x001261C8 File Offset: 0x001243C8
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression>(e, "e");
			this.Begin(e);
			this.Begin("Inputs");
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding in e.Inputs)
			{
				this.Dump(binding, "Input");
			}
			this.End("Inputs");
			this.End(e);
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x0012624C File Offset: 0x0012444C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Left, "Left");
			this.Dump(e.Right, "Right");
			this.Dump(e.JoinCondition, "JoinCondition");
			this.End(e);
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x001262A6 File Offset: 0x001244A6
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Input, "Input");
			this.Dump(e.Apply, "Apply");
			this.End(e);
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x001262E4 File Offset: 0x001244E4
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Input, "Input");
			this.Dump(e.Keys, "Keys", "Key");
			this.Begin("Aggregates");
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate dbAggregate in e.Aggregates)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate dbFunctionAggregate = dbAggregate as global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate;
				if (dbFunctionAggregate != null)
				{
					this.Begin("DbFunctionAggregate");
					this.Dump(dbFunctionAggregate.Function);
					this.Dump(dbFunctionAggregate.Arguments, "Arguments", "Argument");
					this.End("DbFunctionAggregate");
				}
				else
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate dbGroupAggregate = dbAggregate as global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate;
					this.Begin("DbGroupAggregate");
					this.Dump(dbGroupAggregate.Arguments, "Arguments", "Argument");
					this.End("DbGroupAggregate");
				}
			}
			this.End("Aggregates");
			this.End(e);
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x001263FC File Offset: 0x001245FC
		protected virtual void Dump(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder)
		{
			this.Begin("SortOrder");
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause dbSortClause in sortOrder)
			{
				string text = dbSortClause.Collation;
				if (text == null)
				{
					text = "";
				}
				this.Begin("DbSortClause", "Ascending", dbSortClause.Ascending, "Collation", text);
				this.Dump(dbSortClause.Expression, "Expression");
				this.End("DbSortClause");
			}
			this.End("SortOrder");
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x001264A0 File Offset: 0x001246A0
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Input, "Input");
			this.Dump(e.SortOrder);
			this.Dump(e.Count, "Count");
			this.End(e);
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x001264F5 File Offset: 0x001246F5
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Input, "Input");
			this.Dump(e.SortOrder);
			this.End(e);
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x0012652E File Offset: 0x0012472E
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression>(e, "e");
			this.Begin(e);
			this.Dump(e.Input, "Input");
			this.Dump(e.Predicate, "Predicate");
			this.End(e);
		}
	}
}
