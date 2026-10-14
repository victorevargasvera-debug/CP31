using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Mapping.Update.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Edm.Services
{
	// Token: 0x02000177 RID: 375
	internal class ModificationFunctionMappingGenerator : global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator
	{
		// Token: 0x060016CF RID: 5839 RVA: 0x0003B6A4 File Offset: 0x000398A4
		public ModificationFunctionMappingGenerator(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest) : base(providerManifest)
		{
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x0003B6B0 File Offset: 0x000398B0
		public void Generate(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			if (entityType.Abstract)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = databaseMapping.Model.GetEntitySet(entityType);
			global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping = databaseMapping.GetEntitySetMapping(entitySet);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> columnMappings = global::System.Data.Entity.ModelConfiguration.Edm.Services.ModificationFunctionMappingGenerator.GetColumnMappings(entityType, entitySetMapping).ToList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>();
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> iaFkProperties = global::System.Data.Entity.ModelConfiguration.Edm.Services.ModificationFunctionMappingGenerator.GetIndependentFkColumns(entityType, databaseMapping).ToList<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>();
			global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping insertFunctionMapping = this.GenerateFunctionMapping(global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Insert, entitySetMapping.EntitySet, entityType, databaseMapping, entityType.Properties, iaFkProperties, columnMappings, from p in entityType.Properties
			where p.HasStoreGeneratedPattern()
			select p, null);
			global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping updateFunctionMapping = this.GenerateFunctionMapping(global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update, entitySetMapping.EntitySet, entityType, databaseMapping, entityType.Properties, iaFkProperties, columnMappings, entityType.Properties.Where(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p)
			{
				global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern? storeGeneratedPattern = p.GetStoreGeneratedPattern();
				global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern storeGeneratedPattern2 = global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Computed;
				return storeGeneratedPattern.GetValueOrDefault() == storeGeneratedPattern2 & storeGeneratedPattern != null;
			}), null);
			global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping deleteFunctionMapping = this.GenerateFunctionMapping(global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Delete, entitySetMapping.EntitySet, entityType, databaseMapping, entityType.Properties, iaFkProperties, columnMappings, null, null);
			global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping modificationFunctionMapping = new global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping(entityType, deleteFunctionMapping, insertFunctionMapping, updateFunctionMapping);
			entitySetMapping.AddModificationFunctionMapping(modificationFunctionMapping);
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x0003B7B0 File Offset: 0x000399B0
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> GetColumnMappings(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.EntityType[]
			{
				entityType
			}.Concat(global::System.Data.Entity.ModelConfiguration.Edm.Services.ModificationFunctionMappingGenerator.GetParents(entityType)).SelectMany((global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => (from stm in entitySetMapping.TypeMappings
			where stm.Types.Contains(et)
			select stm).SelectMany((global::System.Data.Entity.Core.Mapping.TypeMapping stm) => stm.MappingFragments).SelectMany((global::System.Data.Entity.Core.Mapping.MappingFragment mf) => mf.ColumnMappings));
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x0003B7F0 File Offset: 0x000399F0
		public void Generate(global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> iaFkProperties = global::System.Data.Entity.ModelConfiguration.Edm.Services.ModificationFunctionMappingGenerator.GetIndependentFkColumns(associationSetMapping).ToList<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>();
			global::System.Data.Entity.Core.Metadata.Edm.EdmType entityType = associationSetMapping.AssociationSet.ElementType.SourceEnd.GetEntityType();
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = associationSetMapping.AssociationSet.ElementType.TargetEnd.GetEntityType();
			string functionNamePrefix = entityType.Name + entityType2.Name;
			global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping insertFunctionMapping = this.GenerateFunctionMapping(global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Insert, associationSetMapping.AssociationSet, associationSetMapping.AssociationSet.ElementType, databaseMapping, global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(), iaFkProperties, new global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder[0], null, functionNamePrefix);
			global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping deleteFunctionMapping = this.GenerateFunctionMapping(global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Delete, associationSetMapping.AssociationSet, associationSetMapping.AssociationSet.ElementType, databaseMapping, global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(), iaFkProperties, new global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder[0], null, functionNamePrefix);
			associationSetMapping.ModificationFunctionMapping = new global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping(associationSetMapping.AssociationSet, deleteFunctionMapping, insertFunctionMapping);
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x0003B8AA File Offset: 0x00039AAA
		private static global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> GetIndependentFkColumns(global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping in associationSetMapping.SourceEndMapping.PropertyMappings)
			{
				yield return global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(new global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath(new global::System.Data.Entity.Core.Metadata.Edm.EdmMember[]
				{
					scalarPropertyMapping.Property,
					associationSetMapping.SourceEndMapping.AssociationEnd
				}, associationSetMapping.AssociationSet), scalarPropertyMapping.Column);
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping> enumerator = null;
			foreach (global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping2 in associationSetMapping.TargetEndMapping.PropertyMappings)
			{
				yield return global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(new global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath(new global::System.Data.Entity.Core.Metadata.Edm.EdmMember[]
				{
					scalarPropertyMapping2.Property,
					associationSetMapping.TargetEndMapping.AssociationEnd
				}, associationSetMapping.AssociationSet), scalarPropertyMapping2.Column);
			}
			enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x0003B8BA File Offset: 0x00039ABA
		private static global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> GetIndependentFkColumns(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			foreach (global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping in databaseMapping.GetAssociationSetMappings())
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationType elementType = associationSetMapping.AssociationSet.ElementType;
				if (!elementType.IsManyToMany())
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember dependentEnd;
					if (!elementType.TryGuessPrincipalAndDependentEnds(out associationEndMember, out dependentEnd))
					{
						dependentEnd = elementType.TargetEnd;
					}
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = dependentEnd.GetEntityType();
					if (entityType2 == entityType || global::System.Data.Entity.ModelConfiguration.Edm.Services.ModificationFunctionMappingGenerator.GetParents(entityType).Contains(entityType2))
					{
						global::System.Data.Entity.Core.Mapping.EndPropertyMapping endPropertyMapping = (associationSetMapping.TargetEndMapping.AssociationEnd != dependentEnd) ? associationSetMapping.TargetEndMapping : associationSetMapping.SourceEndMapping;
						foreach (global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping in endPropertyMapping.PropertyMappings)
						{
							yield return global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(new global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath(new global::System.Data.Entity.Core.Metadata.Edm.EdmMember[]
							{
								scalarPropertyMapping.Property,
								dependentEnd
							}, associationSetMapping.AssociationSet), scalarPropertyMapping.Column);
						}
						global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping> enumerator2 = null;
					}
					dependentEnd = null;
					associationSetMapping = null;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.AssociationSetMapping> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x0003B8D1 File Offset: 0x00039AD1
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> GetParents(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			while (entityType.BaseType != null)
			{
				yield return (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType;
				entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType;
			}
			yield break;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0003B8E4 File Offset: 0x00039AE4
		private global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping GenerateFunctionMapping(global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator modificationOperator, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> parameterProperties, global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> iaFkProperties, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> columnMappings, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> resultProperties = null, string functionNamePrefix = null)
		{
			bool useOriginalValues = modificationOperator == global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Delete;
			global::System.Data.Entity.ModelConfiguration.Edm.Services.FunctionParameterMappingGenerator functionParameterMappingGenerator = new global::System.Data.Entity.ModelConfiguration.Edm.Services.FunctionParameterMappingGenerator(this._providerManifest);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> list = functionParameterMappingGenerator.Generate((modificationOperator == global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Insert && global::System.Data.Entity.ModelConfiguration.Edm.Services.ModificationFunctionMappingGenerator.IsTableSplitDependent(entityTypeBase, databaseMapping)) ? global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update : modificationOperator, parameterProperties, columnMappings, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(), useOriginalValues).Concat(functionParameterMappingGenerator.Generate(iaFkProperties, useOriginalValues)).ToList<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> list2 = (from b in list
			select b.Parameter).ToList<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>();
			global::System.Data.Entity.ModelConfiguration.Edm.Services.ModificationFunctionMappingGenerator.UniquifyParameterNames(list2);
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunctionPayload functionPayload = new global::System.Data.Entity.Core.Metadata.Edm.EdmFunctionPayload
			{
				ReturnParameters = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[0],
				Parameters = list2.ToArray(),
				IsComposable = new bool?(false)
			};
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function = databaseMapping.Database.AddFunction((functionNamePrefix ?? entityTypeBase.Name) + "_" + modificationOperator.ToString(), functionPayload);
			return new global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping(entitySetBase, entityTypeBase, function, list, null, (resultProperties != null) ? (from p in resultProperties
			select new global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding(columnMappings.First((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder cm) => cm.PropertyPath.SequenceEqual(new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				p
			})).ColumnProperty.Name, p)) : null);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0003BA04 File Offset: 0x00039C04
		private static bool IsTableSplitDependent(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = databaseMapping.Model.AssociationTypes.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.AssociationType at) => at.IsForeignKey && at.IsRequiredToRequired() && !at.IsSelfReferencing() && (at.SourceEnd.GetEntityType().IsAssignableFrom(entityTypeBase) || at.TargetEnd.GetEntityType().IsAssignableFrom(entityTypeBase)) && databaseMapping.Database.AssociationTypes.All((global::System.Data.Entity.Core.Metadata.Edm.AssociationType fk) => fk.Name != at.Name));
			return associationType != null && associationType.TargetEnd.GetEntityType() == entityTypeBase;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0003BA60 File Offset: 0x00039C60
		private static void UniquifyParameterNames(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> parameters)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter in parameters)
			{
				functionParameter.Name = parameters.Except(new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[]
				{
					functionParameter
				}).UniquifyName(functionParameter.Name);
			}
		}
	}
}
