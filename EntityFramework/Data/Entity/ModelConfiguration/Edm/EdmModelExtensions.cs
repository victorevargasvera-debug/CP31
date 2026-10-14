using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Edm.Services;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000164 RID: 356
	internal static class EdmModelExtensions
	{
		// Token: 0x0600163A RID: 5690 RVA: 0x000397E8 File Offset: 0x000379E8
		public static global::System.Data.Entity.Core.Metadata.Edm.EntityType AddTable(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, string name)
		{
			string text = database.EntityTypes.UniquifyName(name);
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = new global::System.Data.Entity.Core.Metadata.Edm.EntityType(text, "CodeFirstDatabaseSchema", global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
			database.AddItem(entityType);
			database.AddEntitySet(entityType.Name, entityType, text);
			return entityType;
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00039828 File Offset: 0x00037A28
		public static global::System.Data.Entity.Core.Metadata.Edm.EntityType AddTable(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, string name, global::System.Data.Entity.Core.Metadata.Edm.EntityType pkSource)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = database.AddTable(name);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty tableColumn in pkSource.KeyProperties)
			{
				entityType.AddKeyMember(tableColumn.Clone());
			}
			return entityType;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x0003988C File Offset: 0x00037A8C
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmFunction AddFunction(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, string name, global::System.Data.Entity.Core.Metadata.Edm.EdmFunctionPayload functionPayload)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = new global::System.Data.Entity.Core.Metadata.Edm.EdmFunction(database.Functions.UniquifyName(name), "CodeFirstDatabaseSchema", global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace, functionPayload);
			database.AddItem(edmFunction);
			return edmFunction;
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x000398BC File Offset: 0x00037ABC
		public static global::System.Data.Entity.Core.Metadata.Edm.EntityType FindTableByName(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, global::System.Data.Entity.Utilities.DatabaseName tableName)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntityType> list = (database.EntityTypes as global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>) ?? database.EntityTypes.ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = list[i];
				global::System.Data.Entity.Utilities.DatabaseName tableName2 = entityType.GetTableName();
				if ((tableName2 != null) ? tableName2.Equals(tableName) : (string.Equals(entityType.Name, tableName.Name, global::System.StringComparison.Ordinal) && tableName.Schema == null))
				{
					return entityType;
				}
			}
			return null;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00039938 File Offset: 0x00037B38
		public static bool HasCascadeDeletePath(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.EntityType sourceEntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType targetEntityType)
		{
			return (from a in model.AssociationTypes
			from ae in a.Members.Cast<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>()
			where ae.GetEntityType() == sourceEntityType && ae.DeleteBehavior == global::System.Data.Entity.Core.Metadata.Edm.OperationAction.Cascade
			select a.GetOtherEnd(ae).GetEntityType()).Any((global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => et == targetEntityType || model.HasCascadeDeletePath(et, targetEntityType));
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x000399F4 File Offset: 0x00037BF4
		public static global::System.Collections.Generic.IEnumerable<global::System.Type> GetClrTypes(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			return (from e in model.EntityTypes
			select e.GetClrType()).Union(from ct in model.ComplexTypes
			select ct.GetClrType());
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00039A5C File Offset: 0x00037C5C
		public static global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty GetNavigationProperty(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntityType> list = (model.EntityTypes as global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>) ?? model.EntityTypes.ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = list[i].GetNavigationProperty(propertyInfo);
				if (navigationProperty != null)
				{
					return navigationProperty;
				}
			}
			return null;
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00039AAC File Offset: 0x00037CAC
		public static void ValidateAndSerializeCsdl(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Xml.XmlWriter writer)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs> list = model.SerializeAndGetCsdlErrors(writer);
			if (list.Count > 0)
			{
				throw new global::System.Data.Entity.ModelConfiguration.ModelValidationException(list);
			}
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00039AD4 File Offset: 0x00037CD4
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs> SerializeAndGetCsdlErrors(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Xml.XmlWriter writer)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs> validationErrors = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs>();
			global::System.Data.Entity.Core.Metadata.Edm.CsdlSerializer csdlSerializer = new global::System.Data.Entity.Core.Metadata.Edm.CsdlSerializer();
			csdlSerializer.OnError += delegate(object s, global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs e)
			{
				validationErrors.Add(e);
			};
			csdlSerializer.Serialize(model, writer, null);
			return validationErrors;
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00039B18 File Offset: 0x00037D18
		public static global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping GenerateDatabaseMapping(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			return new global::System.Data.Entity.ModelConfiguration.Edm.Services.DatabaseMappingGenerator(providerInfo, providerManifest).Generate(model);
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00039B27 File Offset: 0x00037D27
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmType GetStructuralOrEnumType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, string name)
		{
			return model.GetStructuralType(name) ?? model.GetEnumType(name);
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00039B3B File Offset: 0x00037D3B
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmType GetStructuralType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, string name)
		{
			return model.GetEntityType(name) ?? model.GetComplexType(name);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00039B50 File Offset: 0x00037D50
		public static global::System.Data.Entity.Core.Metadata.Edm.EntityType GetEntityType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, string name)
		{
			return model.EntityTypes.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EntityType e) => e.Name == name);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00039B84 File Offset: 0x00037D84
		public static global::System.Data.Entity.Core.Metadata.Edm.EntityType GetEntityType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Type clrType)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntityType> list = (model.EntityTypes as global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>) ?? model.EntityTypes.ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = list[i];
				if (entityType.GetClrType() == clrType)
				{
					return entityType;
				}
			}
			return null;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00039BD8 File Offset: 0x00037DD8
		public static global::System.Data.Entity.Core.Metadata.Edm.ComplexType GetComplexType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, string name)
		{
			return model.ComplexTypes.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.ComplexType e) => e.Name == name);
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00039C0C File Offset: 0x00037E0C
		public static global::System.Data.Entity.Core.Metadata.Edm.ComplexType GetComplexType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Type clrType)
		{
			return model.ComplexTypes.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.ComplexType e) => e.GetClrType() == clrType);
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00039C40 File Offset: 0x00037E40
		public static global::System.Data.Entity.Core.Metadata.Edm.EnumType GetEnumType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, string name)
		{
			return model.EnumTypes.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EnumType e) => e.Name == name);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00039C74 File Offset: 0x00037E74
		public static global::System.Data.Entity.Core.Metadata.Edm.EntityType AddEntityType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, string name, string modelNamespace = null)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = new global::System.Data.Entity.Core.Metadata.Edm.EntityType(name, modelNamespace ?? "CodeFirstNamespace", global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			model.AddItem(entityType);
			return entityType;
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00039C9C File Offset: 0x00037E9C
		public static global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetEntitySet(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return model.GetEntitySets().SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EntitySet e) => e.ElementType == entityType.GetRootType());
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00039CD0 File Offset: 0x00037ED0
		public static global::System.Data.Entity.Core.Metadata.Edm.AssociationSet GetAssociationSet(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			return model.Containers.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().AssociationSets.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet a) => a.ElementType == associationType);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00039D0B File Offset: 0x00037F0B
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> GetEntitySets(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			return model.Containers.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().EntitySets;
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00039D20 File Offset: 0x00037F20
		public static global::System.Data.Entity.Core.Metadata.Edm.EntitySet AddEntitySet(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, string name, global::System.Data.Entity.Core.Metadata.Edm.EntityType elementType, string table = null)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = new global::System.Data.Entity.Core.Metadata.Edm.EntitySet(name, null, table, null, elementType);
			model.Containers.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().AddEntitySetBase(entitySet);
			return entitySet;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00039D4C File Offset: 0x00037F4C
		public static global::System.Data.Entity.Core.Metadata.Edm.ComplexType AddComplexType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, string name, string modelNamespace = null)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType(name, modelNamespace ?? "CodeFirstNamespace", global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			model.AddItem(complexType);
			return complexType;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00039D74 File Offset: 0x00037F74
		public static global::System.Data.Entity.Core.Metadata.Edm.EnumType AddEnumType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, string name, string modelNamespace = null)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType = new global::System.Data.Entity.Core.Metadata.Edm.EnumType(name, modelNamespace ?? "CodeFirstNamespace", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32), false, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			model.AddItem(enumType);
			return enumType;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00039DA4 File Offset: 0x00037FA4
		public static global::System.Data.Entity.Core.Metadata.Edm.AssociationType GetAssociationType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, string name)
		{
			return model.AssociationTypes.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.AssociationType a) => a.Name == name);
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00039DD8 File Offset: 0x00037FD8
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> GetAssociationTypesBetween(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.EntityType first, global::System.Data.Entity.Core.Metadata.Edm.EntityType second)
		{
			return from a in model.AssociationTypes
			where (a.SourceEnd.GetEntityType() == first && a.TargetEnd.GetEntityType() == second) || (a.SourceEnd.GetEntityType() == second && a.TargetEnd.GetEntityType() == first)
			select a;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00039E10 File Offset: 0x00038010
		public static global::System.Data.Entity.Core.Metadata.Edm.AssociationType AddAssociationType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, string name, global::System.Data.Entity.Core.Metadata.Edm.EntityType sourceEntityType, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity sourceAssociationEndKind, global::System.Data.Entity.Core.Metadata.Edm.EntityType targetEntityType, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity targetAssociationEndKind, string modelNamespace = null)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = new global::System.Data.Entity.Core.Metadata.Edm.AssociationType(name, modelNamespace ?? "CodeFirstNamespace", false, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				SourceEnd = new global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember(name + "_Source", sourceEntityType.GetReferenceType(), sourceAssociationEndKind),
				TargetEnd = new global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember(name + "_Target", targetEntityType.GetReferenceType(), targetAssociationEndKind)
			};
			model.AddAssociationType(associationType);
			return associationType;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00039E75 File Offset: 0x00038075
		public static void AddAssociationType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			model.AddItem(associationType);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00039E7E File Offset: 0x0003807E
		public static void AddAssociationSet(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet)
		{
			model.Containers.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().AddEntitySetBase(associationSet);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00039E94 File Offset: 0x00038094
		public static void RemoveEntityType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			model.RemoveItem(entityType);
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer = model.Containers.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>();
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = entityContainer.EntitySets.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EntitySet a) => a.ElementType == entityType);
			if (entitySet != null)
			{
				entityContainer.RemoveEntitySetBase(entitySet);
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00039EE8 File Offset: 0x000380E8
		public static void ReplaceEntitySet(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntitySet newSet)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer = model.Containers.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>();
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = entityContainer.EntitySets.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EntitySet a) => a.ElementType == entityType);
			if (entitySet != null)
			{
				entityContainer.RemoveEntitySetBase(entitySet);
				if (newSet != null)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in model.Containers.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().AssociationSets)
					{
						if (associationSet.SourceSet == entitySet)
						{
							associationSet.SourceSet = newSet;
						}
						if (associationSet.TargetSet == entitySet)
						{
							associationSet.TargetSet = newSet;
						}
					}
				}
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00039FA4 File Offset: 0x000381A4
		public static void RemoveAssociationType(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			model.RemoveItem(associationType);
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer = model.Containers.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>();
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = entityContainer.AssociationSets.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet a) => a.ElementType == associationType);
			if (associationSet != null)
			{
				entityContainer.RemoveEntitySetBase(associationSet);
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00039FF8 File Offset: 0x000381F8
		public static global::System.Data.Entity.Core.Metadata.Edm.AssociationSet AddAssociationSet(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, string name, global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = new global::System.Data.Entity.Core.Metadata.Edm.AssociationSet(name, associationType)
			{
				SourceSet = model.GetEntitySet(associationType.SourceEnd.GetEntityType()),
				TargetSet = model.GetEntitySet(associationType.TargetEnd.GetEntityType())
			};
			model.Containers.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().AddEntitySetBase(associationSet);
			return associationSet;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0003A050 File Offset: 0x00038250
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> GetDerivedTypes(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return from et in model.EntityTypes
			where et.BaseType == entityType
			select et;
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0003A084 File Offset: 0x00038284
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> GetSelfAndAllDerivedTypes(this global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			global::System.Data.Entity.ModelConfiguration.Edm.EdmModelExtensions.AddSelfAndAllDerivedTypes(model, entityType, list);
			return list;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0003A0A0 File Offset: 0x000382A0
		private static void AddSelfAndAllDerivedTypes(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> entityTypes)
		{
			entityTypes.Add(entityType);
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> entityTypes2 = model.EntityTypes;
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityType, bool> <>9__0;
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityType, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => et.BaseType == entityType));
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 in entityTypes2.Where(predicate))
			{
				global::System.Data.Entity.ModelConfiguration.Edm.EdmModelExtensions.AddSelfAndAllDerivedTypes(model, entityType2, entityTypes);
			}
		}

		// Token: 0x04000A02 RID: 2562
		public const string DefaultSchema = "dbo";

		// Token: 0x04000A03 RID: 2563
		public const string DefaultModelNamespace = "CodeFirstNamespace";

		// Token: 0x04000A04 RID: 2564
		public const string DefaultStoreNamespace = "CodeFirstDatabaseSchema";
	}
}
