using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006E9 RID: 1769
	public class DbExpressionRebinder : global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor
	{
		// Token: 0x06005219 RID: 21017 RVA: 0x00124BAD File Offset: 0x00122DAD
		internal DbExpressionRebinder()
		{
		}

		// Token: 0x0600521A RID: 21018 RVA: 0x00124BB5 File Offset: 0x00122DB5
		protected DbExpressionRebinder(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace targetWorkspace)
		{
			this._metadata = targetWorkspace;
			this._perspective = new global::System.Data.Entity.Core.Metadata.Edm.ModelPerspective(targetWorkspace);
		}

		// Token: 0x0600521B RID: 21019 RVA: 0x00124BD0 File Offset: 0x00122DD0
		protected override global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase VisitEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer;
			if (!this._metadata.TryGetEntityContainer(entitySet.EntityContainer.Name, entitySet.EntityContainer.DataSpace, out entityContainer))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Copier_EntityContainerNotFound(entitySet.EntityContainer.Name));
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase = null;
			if (entityContainer.BaseEntitySets.TryGetValue(entitySet.Name, false, out entitySetBase) && entitySetBase != null && entitySet.BuiltInTypeKind == entitySetBase.BuiltInTypeKind)
			{
				return entitySetBase;
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Copier_EntitySetNotFound(entitySet.EntityContainer.Name, entitySet.Name));
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x00124C60 File Offset: 0x00122E60
		protected override global::System.Data.Entity.Core.Metadata.Edm.EdmFunction VisitFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionMetadata)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(functionMetadata.Parameters.Count);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter in functionMetadata.Parameters)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage item = this.VisitTypeUsage(functionParameter.TypeUsage);
				list.Add(item);
			}
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functionsMetadata;
			if (global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace == functionMetadata.DataSpace)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = null;
				if (this._metadata.TryGetFunction(functionMetadata.Name, functionMetadata.NamespaceName, list.ToArray(), false, functionMetadata.DataSpace, out edmFunction) && edmFunction != null)
				{
					return edmFunction;
				}
			}
			else if (this._perspective.TryGetFunctionByName(functionMetadata.NamespaceName, functionMetadata.Name, false, out functionsMetadata))
			{
				bool flag;
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction2 = global::System.Data.Entity.Core.Common.EntitySql.FunctionOverloadResolver.ResolveFunctionOverloads(functionsMetadata, list, false, out flag);
				if (!flag && edmFunction2 != null)
				{
					return edmFunction2;
				}
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Copier_FunctionNotFound(global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(functionMetadata.NamespaceName, functionMetadata.Name)));
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x00124D5C File Offset: 0x00122F5C
		protected override global::System.Data.Entity.Core.Metadata.Edm.EdmType VisitType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = type;
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType == type.BuiltInTypeKind)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RefType refType = (global::System.Data.Entity.Core.Metadata.Edm.RefType)type;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)this.VisitType(refType.ElementType);
				if (refType.ElementType != entityType)
				{
					edmType = new global::System.Data.Entity.Core.Metadata.Edm.RefType(entityType);
				}
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType == type.BuiltInTypeKind)
			{
				global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType = (global::System.Data.Entity.Core.Metadata.Edm.CollectionType)type;
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = this.VisitTypeUsage(collectionType.TypeUsage);
				if (collectionType.TypeUsage != typeUsage)
				{
					edmType = new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(typeUsage);
				}
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType == type.BuiltInTypeKind)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)type;
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> list = null;
				for (int i = 0; i < rowType.Properties.Count; i++)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = rowType.Properties[i];
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage2 = this.VisitTypeUsage(edmProperty.TypeUsage);
					if (edmProperty.TypeUsage != typeUsage2)
					{
						if (list == null)
						{
							list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>(from prop in rowType.Properties
							select new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(prop.Name, prop.TypeUsage));
						}
						list[i] = new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(edmProperty.Name, typeUsage2);
					}
				}
				if (list != null)
				{
					edmType = new global::System.Data.Entity.Core.Metadata.Edm.RowType(from propInfo in list
					select new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(propInfo.Key, propInfo.Value), rowType.InitializerMetadata);
				}
			}
			else if (!this._metadata.TryGetType(type.Name, type.NamespaceName, type.DataSpace, out edmType) || edmType == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Copier_TypeNotFound(global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(type.NamespaceName, type.Name)));
			}
			return edmType;
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x00124F08 File Offset: 0x00123108
		protected override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage VisitTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = this.VisitType(type.EdmType);
			if (edmType == type.EdmType)
			{
				return type;
			}
			global::System.Data.Entity.Core.Metadata.Edm.Facet[] array = new global::System.Data.Entity.Core.Metadata.Edm.Facet[type.Facets.Count];
			int num = 0;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.Facet facet in type.Facets)
			{
				array[num] = facet;
				num++;
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType, array);
		}

		// Token: 0x0600521F RID: 21023 RVA: 0x00124F90 File Offset: 0x00123190
		private static bool TryGetMember<TMember>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance, string memberName, out TMember member) where TMember : global::System.Data.Entity.Core.Metadata.Edm.EdmMember
		{
			member = default(TMember);
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = instance.ResultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.StructuralType;
			if (structuralType != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = null;
				if (structuralType.Members.TryGetValue(memberName, false, out edmMember))
				{
					member = (edmMember as TMember);
				}
			}
			return member != null;
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x00124FEC File Offset: 0x001231EC
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.VisitExpression(expression.Instance);
			if (expression.Instance != dbExpression)
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRelationshipEndMember(expression.Property))
				{
					global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEnd;
					if (!global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionRebinder.TryGetMember<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>(dbExpression, expression.Property.Name, out relationshipEnd))
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = dbExpression.ResultType.EdmType;
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Copier_EndNotFound(expression.Property.Name, global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(edmType.NamespaceName, edmType.Name)));
					}
					result = dbExpression.Property(relationshipEnd);
				}
				else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsNavigationProperty(expression.Property))
				{
					global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty;
					if (!global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionRebinder.TryGetMember<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(dbExpression, expression.Property.Name, out navigationProperty))
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 = dbExpression.ResultType.EdmType;
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Copier_NavPropertyNotFound(expression.Property.Name, global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(edmType2.NamespaceName, edmType2.Name)));
					}
					result = dbExpression.Property(navigationProperty);
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty propertyMetadata;
					if (!global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionRebinder.TryGetMember<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(dbExpression, expression.Property.Name, out propertyMetadata))
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType3 = dbExpression.ResultType.EdmType;
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Copier_PropertyNotFound(expression.Property.Name, global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(edmType3.NamespaceName, edmType3.Name)));
					}
					result = dbExpression.Property(propertyMetadata);
				}
			}
			return result;
		}

		// Token: 0x04001DE1 RID: 7649
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _metadata;

		// Token: 0x04001DE2 RID: 7650
		private readonly global::System.Data.Entity.Core.Metadata.Edm.Perspective _perspective;
	}
}
