using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000562 RID: 1378
	internal static class ViewValidator
	{
		// Token: 0x06004356 RID: 17238 RVA: 0x000E6918 File Offset: 0x000E4B18
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> ValidateQueryView(global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree view, global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping setMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType, bool includeSubtypes)
		{
			global::System.Data.Entity.Core.Mapping.ViewValidator.ViewExpressionValidator viewExpressionValidator = new global::System.Data.Entity.Core.Mapping.ViewValidator.ViewExpressionValidator(setMapping, elementType, includeSubtypes);
			viewExpressionValidator.VisitExpression(view.Query);
			if (viewExpressionValidator.Errors.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>() == 0 && setMapping.Set.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet)
			{
				global::System.Data.Entity.Core.Mapping.ViewValidator.AssociationSetViewValidator associationSetViewValidator = new global::System.Data.Entity.Core.Mapping.ViewValidator.AssociationSetViewValidator(setMapping);
				associationSetViewValidator.VisitExpression(view.Query);
				return associationSetViewValidator.Errors;
			}
			return viewExpressionValidator.Errors;
		}

		// Token: 0x02000B6B RID: 2923
		private sealed class ViewExpressionValidator : global::System.Data.Entity.Core.Common.CommandTrees.BasicExpressionVisitor
		{
			// Token: 0x17001103 RID: 4355
			// (get) Token: 0x0600660C RID: 26124 RVA: 0x0015E03E File Offset: 0x0015C23E
			private global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection EdmItemCollection
			{
				get
				{
					return this._setMapping.EntityContainerMapping.StorageMappingItemCollection.EdmItemCollection;
				}
			}

			// Token: 0x17001104 RID: 4356
			// (get) Token: 0x0600660D RID: 26125 RVA: 0x0015E055 File Offset: 0x0015C255
			private global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection StoreItemCollection
			{
				get
				{
					return this._setMapping.EntityContainerMapping.StorageMappingItemCollection.StoreItemCollection;
				}
			}

			// Token: 0x0600660E RID: 26126 RVA: 0x0015E06C File Offset: 0x0015C26C
			internal ViewExpressionValidator(global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping setMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType, bool includeSubtypes)
			{
				this._setMapping = setMapping;
				this._elementType = elementType;
				this._includeSubtypes = includeSubtypes;
				this._errors = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>();
			}

			// Token: 0x17001105 RID: 4357
			// (get) Token: 0x0600660F RID: 26127 RVA: 0x0015E094 File Offset: 0x0015C294
			internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> Errors
			{
				get
				{
					return this._errors;
				}
			}

			// Token: 0x06006610 RID: 26128 RVA: 0x0015E09C File Offset: 0x0015C29C
			public override void VisitExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(expression, "expression");
				this.ValidateExpressionKind(expression.ExpressionKind);
				base.VisitExpression(expression);
			}

			// Token: 0x06006611 RID: 26129 RVA: 0x0015E0C0 File Offset: 0x0015C2C0
			private void ValidateExpressionKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind)
			{
				switch (expressionKind)
				{
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.And:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Case:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Cast:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.EntityRef:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Filter:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Function:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThan:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThanOrEquals:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsNull:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThan:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThanOrEquals:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Not:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NotEquals:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Or:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Ref:
					return;
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Any:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossApply:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossJoin:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Deref:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Distinct:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Divide:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Element:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Except:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GroupBy:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Intersect:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsEmpty:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOf:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOfOnly:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Like:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Limit:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Minus:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Modulo:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Multiply:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OfType:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OfTypeOnly:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OuterApply:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference:
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Plus:
					break;
				default:
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Scan || expressionKind - global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.UnionAll <= 1)
					{
						return;
					}
					break;
				}
				string text;
				if (!this._includeSubtypes)
				{
					text = this._elementType.ToString();
				}
				else
				{
					string str = "IsTypeOf(";
					global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType = this._elementType;
					text = str + ((elementType != null) ? elementType.ToString() : null) + ")";
				}
				string p = text;
				this._errors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_UnsupportedExpressionKind_QueryView(this._setMapping.Set.Name, p, expressionKind), 2071, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this._setMapping.EntityContainerMapping.SourceLocation, this._setMapping.StartLineNumber, this._setMapping.StartLinePosition));
			}

			// Token: 0x06006612 RID: 26130 RVA: 0x0015E234 File Offset: 0x0015C434
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(expression, "expression");
				base.Visit(expression);
				if (expression.Property.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty)
				{
					this._errors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_UnsupportedPropertyKind_QueryView(this._setMapping.Set.Name, expression.Property.Name, expression.Property.BuiltInTypeKind), 2073, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this._setMapping.EntityContainerMapping.SourceLocation, this._setMapping.StartLineNumber, this._setMapping.StartLinePosition));
				}
			}

			// Token: 0x06006613 RID: 26131 RVA: 0x0015E2D0 File Offset: 0x0015C4D0
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>(expression, "expression");
				base.Visit(expression);
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = expression.ResultType.EdmType;
				if (edmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType && edmType != this._elementType && (!this._includeSubtypes || !this._elementType.IsAssignableFrom(edmType)) && (edmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType || !this.GetComplexTypes().Contains((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)edmType)))
				{
					this._errors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_UnsupportedInitialization_QueryView(this._setMapping.Set.Name, edmType.FullName), 2074, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this._setMapping.EntityContainerMapping.SourceLocation, this._setMapping.StartLineNumber, this._setMapping.StartLinePosition));
				}
			}

			// Token: 0x06006614 RID: 26132 RVA: 0x0015E3A0 File Offset: 0x0015C5A0
			private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> GetComplexTypes()
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties = this.GetEntityTypes().SelectMany((global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType) => entityType.Properties).Distinct<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				return this.GetComplexTypes(properties);
			}

			// Token: 0x06006615 RID: 26133 RVA: 0x0015E3E4 File Offset: 0x0015C5E4
			private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> GetComplexTypes(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType in (from p in properties
				select p.TypeUsage.EdmType).OfType<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>())
				{
					yield return complexType;
					foreach (global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType2 in this.GetComplexTypes(complexType.Properties))
					{
						yield return complexType2;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> enumerator2 = null;
					complexType = null;
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> enumerator = null;
				yield break;
				yield break;
			}

			// Token: 0x06006616 RID: 26134 RVA: 0x0015E3FC File Offset: 0x0015C5FC
			private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> GetEntityTypes()
			{
				if (this._includeSubtypes)
				{
					return global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(this._elementType, this.EdmItemCollection, true).OfType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
				}
				if (this._elementType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
				{
					return global::System.Linq.Enumerable.Repeat<global::System.Data.Entity.Core.Metadata.Edm.EntityType>((global::System.Data.Entity.Core.Metadata.Edm.EntityType)this._elementType, 1);
				}
				return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			}

			// Token: 0x06006617 RID: 26135 RVA: 0x0015E450 File Offset: 0x0015C650
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression>(expression, "expression");
				base.Visit(expression);
				if (!global::System.Data.Entity.Core.Mapping.ViewValidator.ViewExpressionValidator.IsStoreSpaceOrCanonicalFunction(this.StoreItemCollection, expression.Function))
				{
					this._errors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_UnsupportedFunctionCall_QueryView(this._setMapping.Set.Name, expression.Function.Identity), 2112, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this._setMapping.EntityContainerMapping.SourceLocation, this._setMapping.StartLineNumber, this._setMapping.StartLinePosition));
				}
			}

			// Token: 0x06006618 RID: 26136 RVA: 0x0015E4DF File Offset: 0x0015C6DF
			internal static bool IsStoreSpaceOrCanonicalFunction(global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection sSpace, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
			{
				return global::System.Data.Entity.Core.Common.TypeHelpers.IsCanonicalFunction(function) || sSpace.GetCTypeFunctions(function.FullName, false).Contains(function);
			}

			// Token: 0x06006619 RID: 26137 RVA: 0x0015E500 File Offset: 0x0015C700
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(expression, "expression");
				base.Visit(expression);
				global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase target = expression.Target;
				if (target.EntityContainer.DataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
				{
					this._errors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_UnsupportedScanTarget_QueryView(this._setMapping.Set.Name, target.Name), 2072, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this._setMapping.EntityContainerMapping.SourceLocation, this._setMapping.StartLineNumber, this._setMapping.StartLinePosition));
				}
			}

			// Token: 0x04002DCC RID: 11724
			private readonly global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping _setMapping;

			// Token: 0x04002DCD RID: 11725
			private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> _errors;

			// Token: 0x04002DCE RID: 11726
			private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase _elementType;

			// Token: 0x04002DCF RID: 11727
			private readonly bool _includeSubtypes;
		}

		// Token: 0x02000B6C RID: 2924
		private class AssociationSetViewValidator : global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo>
		{
			// Token: 0x0600661A RID: 26138 RVA: 0x0015E58C File Offset: 0x0015C78C
			internal AssociationSetViewValidator(global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping setMapping)
			{
				this._setMapping = setMapping;
			}

			// Token: 0x17001106 RID: 4358
			// (get) Token: 0x0600661B RID: 26139 RVA: 0x0015E5B1 File Offset: 0x0015C7B1
			internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> Errors
			{
				get
				{
					return this._errors;
				}
			}

			// Token: 0x0600661C RID: 26140 RVA: 0x0015E5B9 File Offset: 0x0015C7B9
			internal global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo VisitExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
			{
				return expression.Accept<global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo>(this);
			}

			// Token: 0x0600661D RID: 26141 RVA: 0x0015E5C2 File Offset: 0x0015C7C2
			private global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo VisitExpressionBinding(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding)
			{
				if (binding != null)
				{
					return this.VisitExpression(binding.Expression);
				}
				return null;
			}

			// Token: 0x0600661E RID: 26142 RVA: 0x0015E5D8 File Offset: 0x0015C7D8
			private void VisitExpressionBindingEnterScope(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding)
			{
				global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo value = this.VisitExpressionBinding(binding);
				this.variableScopes.Push(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo>(binding.VariableName, value));
			}

			// Token: 0x0600661F RID: 26143 RVA: 0x0015E604 File Offset: 0x0015C804
			private void VisitExpressionBindingExitScope()
			{
				this.variableScopes.Pop();
			}

			// Token: 0x06006620 RID: 26144 RVA: 0x0015E614 File Offset: 0x0015C814
			private void ValidateEntitySetsMappedForAssociationSetMapping(global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionStructuralTypeEntitySetInfo setInfos)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = this._setMapping.Set as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
				int num = 0;
				if (setInfos.SetInfos.All((global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo> it) => it.Value != null && it.Value is global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionSimpleTypeEntitySetInfo) && setInfos.SetInfos.Count<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo>>() == 2)
				{
					foreach (global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo dbExpressionEntitySetInfo in from it in setInfos.SetInfos
					select it.Value)
					{
						global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionSimpleTypeEntitySetInfo dbExpressionSimpleTypeEntitySetInfo = (global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionSimpleTypeEntitySetInfo)dbExpressionEntitySetInfo;
						global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = associationSet.AssociationSetEnds[num];
						global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = associationSetEnd.EntitySet;
						if (!entitySet.Equals(dbExpressionSimpleTypeEntitySetInfo.EntitySet))
						{
							this._errors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_EntitySetMismatchOnAssociationSetEnd_QueryView(dbExpressionSimpleTypeEntitySetInfo.EntitySet.Name, entitySet.Name, associationSetEnd.Name, this._setMapping.Set.Name), 2074, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this._setMapping.EntityContainerMapping.SourceLocation, this._setMapping.StartLineNumber, this._setMapping.StartLinePosition));
						}
						num++;
					}
				}
			}

			// Token: 0x06006621 RID: 26145 RVA: 0x0015E770 File Offset: 0x0015C970
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006622 RID: 26146 RVA: 0x0015E780 File Offset: 0x0015C980
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(expression, "expression");
				return (from it in this.variableScopes
				where it.Key == expression.VariableName
				select it.Value).FirstOrDefault<global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo>();
			}

			// Token: 0x06006623 RID: 26147 RVA: 0x0015E7EC File Offset: 0x0015C9EC
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(expression, "expression");
				global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionStructuralTypeEntitySetInfo dbExpressionStructuralTypeEntitySetInfo = this.VisitExpression(expression.Instance) as global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionStructuralTypeEntitySetInfo;
				if (dbExpressionStructuralTypeEntitySetInfo != null)
				{
					return dbExpressionStructuralTypeEntitySetInfo.GetEntitySetInfoForMember(expression.Property.Name);
				}
				return null;
			}

			// Token: 0x06006624 RID: 26148 RVA: 0x0015E82D File Offset: 0x0015CA2D
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression>(expression, "expression");
				this.VisitExpressionBindingEnterScope(expression.Input);
				global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo result = this.VisitExpression(expression.Projection);
				this.VisitExpressionBindingExitScope();
				return result;
			}

			// Token: 0x06006625 RID: 26149 RVA: 0x0015E85C File Offset: 0x0015CA5C
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>(expression, "expression");
				global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionMemberCollectionEntitySetInfo dbExpressionMemberCollectionEntitySetInfo = this.VisitExpressionList(expression.Arguments);
				global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = expression.ResultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.StructuralType;
				if (dbExpressionMemberCollectionEntitySetInfo != null && structuralType != null)
				{
					global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionStructuralTypeEntitySetInfo dbExpressionStructuralTypeEntitySetInfo = new global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionStructuralTypeEntitySetInfo();
					int num = 0;
					foreach (global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo value in dbExpressionMemberCollectionEntitySetInfo.entitySetInfos)
					{
						dbExpressionStructuralTypeEntitySetInfo.Add(structuralType.Members[num].Name, value);
						num++;
					}
					if (expression.ResultType.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType)
					{
						this.ValidateEntitySetsMappedForAssociationSetMapping(dbExpressionStructuralTypeEntitySetInfo);
					}
					return dbExpressionStructuralTypeEntitySetInfo;
				}
				return null;
			}

			// Token: 0x06006626 RID: 26150 RVA: 0x0015E91C File Offset: 0x0015CB1C
			private global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionMemberCollectionEntitySetInfo VisitExpressionList(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list)
			{
				return new global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionMemberCollectionEntitySetInfo(from it in list
				select this.VisitExpression(it));
			}

			// Token: 0x06006627 RID: 26151 RVA: 0x0015E935 File Offset: 0x0015CB35
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression>(expression, "expression");
				return new global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionSimpleTypeEntitySetInfo(expression.EntitySet);
			}

			// Token: 0x06006628 RID: 26152 RVA: 0x0015E94E File Offset: 0x0015CB4E
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006629 RID: 26153 RVA: 0x0015E95D File Offset: 0x0015CB5D
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600662A RID: 26154 RVA: 0x0015E96C File Offset: 0x0015CB6C
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600662B RID: 26155 RVA: 0x0015E97B File Offset: 0x0015CB7B
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600662C RID: 26156 RVA: 0x0015E98A File Offset: 0x0015CB8A
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600662D RID: 26157 RVA: 0x0015E999 File Offset: 0x0015CB99
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600662E RID: 26158 RVA: 0x0015E9A8 File Offset: 0x0015CBA8
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600662F RID: 26159 RVA: 0x0015E9B7 File Offset: 0x0015CBB7
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006630 RID: 26160 RVA: 0x0015E9C6 File Offset: 0x0015CBC6
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006631 RID: 26161 RVA: 0x0015E9D5 File Offset: 0x0015CBD5
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006632 RID: 26162 RVA: 0x0015E9E4 File Offset: 0x0015CBE4
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006633 RID: 26163 RVA: 0x0015E9F3 File Offset: 0x0015CBF3
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006634 RID: 26164 RVA: 0x0015EA02 File Offset: 0x0015CC02
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006635 RID: 26165 RVA: 0x0015EA11 File Offset: 0x0015CC11
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006636 RID: 26166 RVA: 0x0015EA20 File Offset: 0x0015CC20
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006637 RID: 26167 RVA: 0x0015EA2F File Offset: 0x0015CC2F
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006638 RID: 26168 RVA: 0x0015EA3E File Offset: 0x0015CC3E
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006639 RID: 26169 RVA: 0x0015EA4D File Offset: 0x0015CC4D
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600663A RID: 26170 RVA: 0x0015EA5C File Offset: 0x0015CC5C
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600663B RID: 26171 RVA: 0x0015EA6B File Offset: 0x0015CC6B
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600663C RID: 26172 RVA: 0x0015EA7A File Offset: 0x0015CC7A
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600663D RID: 26173 RVA: 0x0015EA89 File Offset: 0x0015CC89
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600663E RID: 26174 RVA: 0x0015EA98 File Offset: 0x0015CC98
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600663F RID: 26175 RVA: 0x0015EAA7 File Offset: 0x0015CCA7
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006640 RID: 26176 RVA: 0x0015EAB6 File Offset: 0x0015CCB6
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006641 RID: 26177 RVA: 0x0015EAC5 File Offset: 0x0015CCC5
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006642 RID: 26178 RVA: 0x0015EAD4 File Offset: 0x0015CCD4
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006643 RID: 26179 RVA: 0x0015EAE3 File Offset: 0x0015CCE3
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006644 RID: 26180 RVA: 0x0015EAF2 File Offset: 0x0015CCF2
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006645 RID: 26181 RVA: 0x0015EB01 File Offset: 0x0015CD01
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006646 RID: 26182 RVA: 0x0015EB10 File Offset: 0x0015CD10
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006647 RID: 26183 RVA: 0x0015EB1F File Offset: 0x0015CD1F
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006648 RID: 26184 RVA: 0x0015EB2E File Offset: 0x0015CD2E
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression>(expression, "expression");
				return null;
			}

			// Token: 0x06006649 RID: 26185 RVA: 0x0015EB3D File Offset: 0x0015CD3D
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600664A RID: 26186 RVA: 0x0015EB4C File Offset: 0x0015CD4C
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600664B RID: 26187 RVA: 0x0015EB5B File Offset: 0x0015CD5B
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600664C RID: 26188 RVA: 0x0015EB6A File Offset: 0x0015CD6A
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(expression, "expression");
				return null;
			}

			// Token: 0x0600664D RID: 26189 RVA: 0x0015EB79 File Offset: 0x0015CD79
			public override global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression>(expression, "expression");
				return null;
			}

			// Token: 0x04002DD0 RID: 11728
			private readonly global::System.Collections.Generic.Stack<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo>> variableScopes = new global::System.Collections.Generic.Stack<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo>>();

			// Token: 0x04002DD1 RID: 11729
			private readonly global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping _setMapping;

			// Token: 0x04002DD2 RID: 11730
			private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> _errors = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>();
		}

		// Token: 0x02000B6D RID: 2925
		internal abstract class DbExpressionEntitySetInfo
		{
		}

		// Token: 0x02000B6E RID: 2926
		private class DbExpressionSimpleTypeEntitySetInfo : global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo
		{
			// Token: 0x17001107 RID: 4359
			// (get) Token: 0x06006650 RID: 26192 RVA: 0x0015EB99 File Offset: 0x0015CD99
			internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet
			{
				get
				{
					return this.m_entitySet;
				}
			}

			// Token: 0x06006651 RID: 26193 RVA: 0x0015EBA1 File Offset: 0x0015CDA1
			internal DbExpressionSimpleTypeEntitySetInfo(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
			{
				this.m_entitySet = entitySet;
			}

			// Token: 0x04002DD3 RID: 11731
			private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet m_entitySet;
		}

		// Token: 0x02000B6F RID: 2927
		private class DbExpressionStructuralTypeEntitySetInfo : global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo
		{
			// Token: 0x06006652 RID: 26194 RVA: 0x0015EBB0 File Offset: 0x0015CDB0
			internal DbExpressionStructuralTypeEntitySetInfo()
			{
				this.m_entitySetInfos = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo>();
			}

			// Token: 0x06006653 RID: 26195 RVA: 0x0015EBC3 File Offset: 0x0015CDC3
			internal void Add(string key, global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo value)
			{
				this.m_entitySetInfos.Add(key, value);
			}

			// Token: 0x17001108 RID: 4360
			// (get) Token: 0x06006654 RID: 26196 RVA: 0x0015EBD2 File Offset: 0x0015CDD2
			internal global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo>> SetInfos
			{
				get
				{
					return this.m_entitySetInfos;
				}
			}

			// Token: 0x06006655 RID: 26197 RVA: 0x0015EBDA File Offset: 0x0015CDDA
			internal global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo GetEntitySetInfoForMember(string memberName)
			{
				return this.m_entitySetInfos[memberName];
			}

			// Token: 0x04002DD4 RID: 11732
			private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo> m_entitySetInfos;
		}

		// Token: 0x02000B70 RID: 2928
		private class DbExpressionMemberCollectionEntitySetInfo : global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo
		{
			// Token: 0x06006656 RID: 26198 RVA: 0x0015EBE8 File Offset: 0x0015CDE8
			internal DbExpressionMemberCollectionEntitySetInfo(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo> entitySetInfos)
			{
				this.m_entitySets = entitySetInfos;
			}

			// Token: 0x17001109 RID: 4361
			// (get) Token: 0x06006657 RID: 26199 RVA: 0x0015EBF7 File Offset: 0x0015CDF7
			internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo> entitySetInfos
			{
				get
				{
					return this.m_entitySets;
				}
			}

			// Token: 0x04002DD5 RID: 11733
			private readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewValidator.DbExpressionEntitySetInfo> m_entitySets;
		}
	}
}
