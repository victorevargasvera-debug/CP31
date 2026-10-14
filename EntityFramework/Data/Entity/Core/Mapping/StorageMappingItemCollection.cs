using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.Update.Internal;
using System.Data.Entity.Core.Mapping.ViewGeneration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.SchemaObjectModel;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Xml;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200055C RID: 1372
	public class StorageMappingItemCollection : global::System.Data.Entity.Core.Mapping.MappingItemCollection
	{
		// Token: 0x0600430A RID: 17162 RVA: 0x000E56E3 File Offset: 0x000E38E3
		internal StorageMappingItemCollection() : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace)
		{
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x000E5704 File Offset: 0x000E3904
		public StorageMappingItemCollection(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmCollection, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeCollection, params string[] filePaths) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection>(edmCollection, "edmCollection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeCollection, "storeCollection");
			global::System.Data.Entity.Utilities.Check.NotNull<string[]>(filePaths, "filePaths");
			this._edmCollection = edmCollection;
			this._storeItemCollection = storeCollection;
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = null;
			try
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader metadataArtifactLoader = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.CreateCompositeFromFilePaths(filePaths, ".msl");
				list = metadataArtifactLoader.CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace);
				this.Init(edmCollection, storeCollection, list, metadataArtifactLoader.GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace), true);
			}
			finally
			{
				if (list != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.Helper.DisposeXmlReaders(list);
				}
			}
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x000E57A8 File Offset: 0x000E39A8
		public StorageMappingItemCollection(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmCollection, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeCollection, global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader>>(xmlReaders, "xmlReaders");
			global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader metadataArtifactLoader = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.CreateCompositeFromXmlReaders(xmlReaders);
			this.Init(edmCollection, storeCollection, metadataArtifactLoader.GetReaders(), metadataArtifactLoader.GetPaths(), true);
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x000E57FB File Offset: 0x000E39FB
		private StorageMappingItemCollection(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection, global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IList<string> filePaths, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace)
		{
			errors = this.Init(edmItemCollection, storeItemCollection, xmlReaders, filePaths, false);
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x000E5829 File Offset: 0x000E3A29
		internal StorageMappingItemCollection(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmCollection, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeCollection, global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IList<string> filePaths) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace)
		{
			this.Init(edmCollection, storeCollection, xmlReaders, filePaths, true);
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x000E5858 File Offset: 0x000E3A58
		private global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> Init(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmCollection, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeCollection, global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IList<string> filePaths, bool throwOnError)
		{
			this._edmCollection = edmCollection;
			this._storeItemCollection = storeCollection;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> userDefinedQueryViewsDict;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> userDefinedQueryViewsOfTypeDict;
			this.m_viewDictionary = new global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.ViewDictionary(this, ref userDefinedQueryViewsDict, ref userDefinedQueryViewsOfTypeDict);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>();
			if (this._edmCollection.EdmVersion != 0.0 && this._storeItemCollection.StoreSchemaVersion != 0.0 && this._edmCollection.EdmVersion != this._storeItemCollection.StoreSchemaVersion)
			{
				list.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_DifferentEdmStoreVersion, 2102, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error));
			}
			else
			{
				double expectedVersion = (this._edmCollection.EdmVersion != 0.0) ? this._edmCollection.EdmVersion : this._storeItemCollection.StoreSchemaVersion;
				list.AddRange(this.LoadItems(xmlReaders, filePaths, userDefinedQueryViewsDict, userDefinedQueryViewsOfTypeDict, expectedVersion));
			}
			if (list.Count > 0 && throwOnError && !global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CheckIfAllErrorsAreWarnings(list))
			{
				throw new global::System.Data.Entity.Core.MappingException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::System.Data.Entity.Resources.EntityRes.GetString("InvalidSchemaEncountered"), new object[]
				{
					global::System.Data.Entity.Core.Metadata.Edm.Helper.CombineErrorMessage(list)
				}));
			}
			return list;
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06004310 RID: 17168 RVA: 0x000E5966 File Offset: 0x000E3B66
		// (set) Token: 0x06004311 RID: 17169 RVA: 0x000E596E File Offset: 0x000E3B6E
		public global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCacheFactory MappingViewCacheFactory
		{
			get
			{
				return this._mappingViewCacheFactory;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCacheFactory>(value, "value");
				global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCacheFactory>(ref this._mappingViewCacheFactory, value, null);
				if (!this._mappingViewCacheFactory.Equals(value))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.MappingViewCacheFactory_MustNotChange, "value");
				}
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06004312 RID: 17170 RVA: 0x000E59A8 File Offset: 0x000E3BA8
		internal global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace Workspace
		{
			get
			{
				if (this._workspace == null)
				{
					this._workspace = new global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace(() => this._edmCollection, () => this._storeItemCollection, () => this);
				}
				return this._workspace;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06004313 RID: 17171 RVA: 0x000E59E7 File Offset: 0x000E3BE7
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection EdmItemCollection
		{
			get
			{
				return this._edmCollection;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06004314 RID: 17172 RVA: 0x000E59EF File Offset: 0x000E3BEF
		public double MappingVersion
		{
			get
			{
				return this.m_mappingVersion;
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06004315 RID: 17173 RVA: 0x000E59F7 File Offset: 0x000E3BF7
		internal global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection StoreItemCollection
		{
			get
			{
				return this._storeItemCollection;
			}
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x000E59FF File Offset: 0x000E3BFF
		internal override global::System.Data.Entity.Core.Mapping.MappingBase GetMap(string identity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace, bool ignoreCase)
		{
			if (typeSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Mapping_Storage_InvalidSpace(typeSpace));
			}
			return base.GetItem<global::System.Data.Entity.Core.Mapping.MappingBase>(identity, ignoreCase);
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x000E5A1E File Offset: 0x000E3C1E
		internal override bool TryGetMap(string identity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace, bool ignoreCase, out global::System.Data.Entity.Core.Mapping.MappingBase map)
		{
			if (typeSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Mapping_Storage_InvalidSpace(typeSpace));
			}
			return base.TryGetItem<global::System.Data.Entity.Core.Mapping.MappingBase>(identity, ignoreCase, out map);
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x000E5A3F File Offset: 0x000E3C3F
		internal override global::System.Data.Entity.Core.Mapping.MappingBase GetMap(string identity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace)
		{
			return this.GetMap(identity, typeSpace, false);
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x000E5A4A File Offset: 0x000E3C4A
		internal override bool TryGetMap(string identity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace, out global::System.Data.Entity.Core.Mapping.MappingBase map)
		{
			return this.TryGetMap(identity, typeSpace, false, out map);
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x000E5A58 File Offset: 0x000E3C58
		internal override global::System.Data.Entity.Core.Mapping.MappingBase GetMap(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item)
		{
			global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace = item.DataSpace;
			if (dataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Mapping_Storage_InvalidSpace(dataSpace));
			}
			return this.GetMap(item.Identity, dataSpace);
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x000E5A90 File Offset: 0x000E3C90
		internal override bool TryGetMap(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item, out global::System.Data.Entity.Core.Mapping.MappingBase map)
		{
			if (item == null)
			{
				map = null;
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace = item.DataSpace;
			if (dataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				map = null;
				return false;
			}
			return this.TryGetMap(item.Identity, dataSpace, out map);
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x000E5AC4 File Offset: 0x000E3CC4
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> GetInterestingMembers(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.InterestingMembersKind interestingMembersKind)
		{
			global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.InterestingMembersKind> key = new global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.InterestingMembersKind>(entitySet, entityType, interestingMembersKind);
			return this._cachedInterestingMembers.GetOrAdd(key, this.FindInterestingMembers(entitySet, entityType, interestingMembersKind));
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x000E5AF0 File Offset: 0x000E3CF0
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> FindInterestingMembers(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.InterestingMembersKind interestingMembersKind)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
			foreach (global::System.Data.Entity.Core.Mapping.TypeMapping typeMapping in global::System.Data.Entity.Core.Metadata.Edm.MappingMetadataHelper.GetMappingsForEntitySetAndSuperTypes(this, entitySet.EntityContainer, entitySet, entityType))
			{
				global::System.Data.Entity.Core.Mapping.AssociationTypeMapping associationTypeMapping = typeMapping as global::System.Data.Entity.Core.Mapping.AssociationTypeMapping;
				if (associationTypeMapping != null)
				{
					global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.FindInterestingAssociationMappingMembers(associationTypeMapping, list);
				}
				else
				{
					global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.FindInterestingEntityMappingMembers((global::System.Data.Entity.Core.Mapping.EntityTypeMapping)typeMapping, interestingMembersKind, list);
				}
			}
			if (interestingMembersKind != global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.InterestingMembersKind.RequiredOriginalValueMembers)
			{
				global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.FindForeignKeyProperties(entitySet, entityType, list);
			}
			foreach (global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping functionMappings2 in from functionMappings in global::System.Data.Entity.Core.Metadata.Edm.MappingMetadataHelper.GetModificationFunctionMappingsForEntitySetAndType(this, entitySet.EntityContainer, entitySet, entityType)
			where functionMappings.UpdateFunctionMapping != null
			select functionMappings)
			{
				global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.FindInterestingFunctionMappingMembers(functionMappings2, interestingMembersKind, ref list);
			}
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(list.Distinct<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>().ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>());
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x000E5BEC File Offset: 0x000E3DEC
		private static void FindInterestingAssociationMappingMembers(global::System.Data.Entity.Core.Mapping.AssociationTypeMapping associationTypeMapping, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> interestingMembers)
		{
			interestingMembers.AddRange(from epm in associationTypeMapping.MappingFragments.SelectMany((global::System.Data.Entity.Core.Mapping.MappingFragment m) => m.AllProperties).OfType<global::System.Data.Entity.Core.Mapping.EndPropertyMapping>()
			select epm.AssociationEnd);
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x000E5C54 File Offset: 0x000E3E54
		private static void FindInterestingEntityMappingMembers(global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.InterestingMembersKind interestingMembersKind, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> interestingMembers)
		{
			foreach (global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping in entityTypeMapping.MappingFragments.SelectMany((global::System.Data.Entity.Core.Mapping.MappingFragment mf) => mf.AllProperties))
			{
				global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping;
				global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping;
				global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping;
				if (scalarPropertyMapping != null && scalarPropertyMapping.Property != null)
				{
					if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsPartOfEntityTypeKey(scalarPropertyMapping.Property))
					{
						if (interestingMembersKind == global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.InterestingMembersKind.RequiredOriginalValueMembers)
						{
							interestingMembers.Add(scalarPropertyMapping.Property);
						}
					}
					else if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetConcurrencyMode(scalarPropertyMapping.Property) == global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.Fixed)
					{
						interestingMembers.Add(scalarPropertyMapping.Property);
					}
				}
				else if (complexPropertyMapping != null)
				{
					if (interestingMembersKind == global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.InterestingMembersKind.PartialUpdate || global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetConcurrencyMode(complexPropertyMapping.Property) == global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.Fixed || global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.HasFixedConcurrencyModeInAnyChildProperty(complexPropertyMapping))
					{
						interestingMembers.Add(complexPropertyMapping.Property);
					}
				}
				else if (conditionPropertyMapping != null && conditionPropertyMapping.Property != null)
				{
					interestingMembers.Add(conditionPropertyMapping.Property);
				}
			}
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x000E5D60 File Offset: 0x000E3F60
		private static bool HasFixedConcurrencyModeInAnyChildProperty(global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexMapping)
		{
			foreach (global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping in complexMapping.TypeMappings.SelectMany((global::System.Data.Entity.Core.Mapping.ComplexTypeMapping m) => m.AllProperties))
			{
				global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping;
				global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping;
				if (scalarPropertyMapping != null && global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetConcurrencyMode(scalarPropertyMapping.Property) == global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.Fixed)
				{
					return true;
				}
				if (complexPropertyMapping != null && (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetConcurrencyMode(complexPropertyMapping.Property) == global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.Fixed || global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.HasFixedConcurrencyModeInAnyChildProperty(complexPropertyMapping)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x000E5E0C File Offset: 0x000E400C
		private static void FindForeignKeyProperties(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> interestingMembers)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = entitySetBase as global::System.Data.Entity.Core.Metadata.Edm.EntitySet;
			if (entitySet != null && entitySet.HasForeignKeyRelationships)
			{
				interestingMembers.AddRange(from p in global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndParentTypesOf(entityType, true).SelectMany((global::System.Data.Entity.Core.Metadata.Edm.EdmType e) => ((global::System.Data.Entity.Core.Metadata.Edm.EntityType)e).Properties)
				where entitySet.ForeignKeyDependents.SelectMany((global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> fk) => fk.Item2.ToProperties).Contains(p)
				select p);
			}
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x000E5E84 File Offset: 0x000E4084
		private static void FindInterestingFunctionMappingMembers(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping functionMappings, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.InterestingMembersKind interestingMembersKind, ref global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> interestingMembers)
		{
			if (interestingMembersKind == global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.InterestingMembersKind.PartialUpdate)
			{
				interestingMembers.AddRange(from p in functionMappings.UpdateFunctionMapping.ParameterBindings
				select p.MemberPath.Members.Last<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>());
				return;
			}
			foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding in from p in functionMappings.UpdateFunctionMapping.ParameterBindings
			where !p.IsCurrent
			select p)
			{
				interestingMembers.Add(modificationFunctionParameterBinding.MemberPath.Members.Last<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>());
			}
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x000E5F48 File Offset: 0x000E4148
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView GetGeneratedView(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			return this.m_viewDictionary.GetGeneratedView(extent, workspace, this);
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x000E5F58 File Offset: 0x000E4158
		private void AddInternal(global::System.Data.Entity.Core.Mapping.MappingBase storageMap)
		{
			storageMap.DataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace;
			try
			{
				base.AddInternal(storageMap);
			}
			catch (global::System.ArgumentException innerException)
			{
				throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_Duplicate_Type(storageMap.EdmItem.Identity), innerException);
			}
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x000E5FA0 File Offset: 0x000E41A0
		internal bool ContainsStorageEntityContainer(string storageEntityContainerName)
		{
			return this.GetItems<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().Any((global::System.Data.Entity.Core.Mapping.EntityContainerMapping map) => map.StorageEntityContainer.Name.Equals(storageEntityContainerName, global::System.StringComparison.Ordinal));
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x000E5FD4 File Offset: 0x000E41D4
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> LoadItems(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IList<string> mappingSchemaUris, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> userDefinedQueryViewsDict, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> userDefinedQueryViewsOfTypeDict, double expectedVersion)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>();
			int num = -1;
			foreach (global::System.Xml.XmlReader xmlReader in xmlReaders)
			{
				num++;
				string fileName = null;
				if (mappingSchemaUris == null)
				{
					global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.TryGetBaseUri(xmlReader, out fileName);
				}
				else
				{
					fileName = mappingSchemaUris[num];
				}
				global::System.Data.Entity.Core.Mapping.MappingItemLoader mappingItemLoader = new global::System.Data.Entity.Core.Mapping.MappingItemLoader(xmlReader, this, fileName, this.m_memberMappings);
				list.AddRange(mappingItemLoader.ParsingErrors);
				this.CheckIsSameVersion(expectedVersion, mappingItemLoader.MappingVersion, list);
				global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping = mappingItemLoader.ContainerMapping;
				if (mappingItemLoader.HasQueryViews && containerMapping != null)
				{
					global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.CompileUserDefinedQueryViews(containerMapping, userDefinedQueryViewsDict, userDefinedQueryViewsOfTypeDict, list);
				}
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CheckIfAllErrorsAreWarnings(list) && !base.Contains(containerMapping))
				{
					containerMapping.SetReadOnly();
					this.AddInternal(containerMapping);
				}
			}
			global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.CheckForDuplicateItems(this.EdmItemCollection, this.StoreItemCollection, list);
			return list;
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x000E60C4 File Offset: 0x000E42C4
		private static void CompileUserDefinedQueryViews(global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> userDefinedQueryViewsDict, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> userDefinedQueryViewsOfTypeDict, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config = new global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator();
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping in entityContainerMapping.AllSetMaps)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView value;
				if (entitySetBaseMapping.QueryView != null && !userDefinedQueryViewsDict.TryGetValue(entitySetBaseMapping.Set, out value))
				{
					if (global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView.TryParseUserSpecifiedView(entitySetBaseMapping, entitySetBaseMapping.Set.ElementType, entitySetBaseMapping.QueryView, true, entityContainerMapping.StorageMappingItemCollection, config, errors, out value))
					{
						userDefinedQueryViewsDict.Add(entitySetBaseMapping.Set, value);
					}
					foreach (global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>> pair in entitySetBaseMapping.GetTypeSpecificQVKeys())
					{
						if (global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView.TryParseUserSpecifiedView(entitySetBaseMapping, pair.Second.First, entitySetBaseMapping.GetTypeSpecificQueryView(pair), pair.Second.Second, entityContainerMapping.StorageMappingItemCollection, config, errors, out value))
						{
							userDefinedQueryViewsOfTypeDict.Add(pair, value);
						}
					}
				}
			}
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x000E61DC File Offset: 0x000E43DC
		private void CheckIsSameVersion(double expectedVersion, double currentLoaderVersion, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors)
		{
			if (this.m_mappingVersion == 0.0)
			{
				this.m_mappingVersion = currentLoaderVersion;
			}
			if (expectedVersion != 0.0 && currentLoaderVersion != 0.0 && currentLoaderVersion != expectedVersion)
			{
				errors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_DifferentMappingEdmStoreVersion, 2101, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error));
			}
			if (currentLoaderVersion != this.m_mappingVersion && currentLoaderVersion != 0.0)
			{
				errors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.CannotLoadDifferentVersionOfSchemaInTheSameItemCollection, 2100, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error));
			}
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x000E625E File Offset: 0x000E445E
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader GetUpdateViewLoader()
		{
			if (this._viewLoader == null)
			{
				this._viewLoader = new global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader(this);
			}
			return this._viewLoader;
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x000E627A File Offset: 0x000E447A
		internal bool TryGetGeneratedViewOfType(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entity, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase type, bool includeSubtypes, out global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView generatedView)
		{
			return this.m_viewDictionary.TryGetGeneratedViewOfType(entity, type, includeSubtypes, out generatedView);
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x000E628C File Offset: 0x000E448C
		private static void CheckForDuplicateItems(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errorCollection)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.GlobalItem globalItem in edmItemCollection)
			{
				if (storeItemCollection.Contains(globalItem.Identity))
				{
					errorCollection.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_ItemWithSameNameExistsBothInCSpaceAndSSpace(globalItem.Identity), 2070, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error));
				}
			}
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x000E6300 File Offset: 0x000E4500
		public string ComputeMappingHashValue(string conceptualModelContainerName, string storeModelContainerName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(conceptualModelContainerName, "conceptualModelContainerName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(storeModelContainerName, "storeModelContainerName");
			global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping = this.GetItems<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().SingleOrDefault((global::System.Data.Entity.Core.Mapping.EntityContainerMapping m) => m.EdmEntityContainer.Name == conceptualModelContainerName && m.StorageEntityContainer.Name == storeModelContainerName);
			if (entityContainerMapping == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.HashCalcContainersNotFound(conceptualModelContainerName, storeModelContainerName));
			}
			return global::System.Data.Entity.Core.Mapping.MetadataMappingHasherVisitor.GetMappingClosureHash(this.MappingVersion, entityContainerMapping, true);
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x000E6382 File Offset: 0x000E4582
		public string ComputeMappingHashValue()
		{
			if (this.GetItems<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().Count != 1)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.HashCalcMultipleContainers);
			}
			return global::System.Data.Entity.Core.Mapping.MetadataMappingHasherVisitor.GetMappingClosureHash(this.MappingVersion, this.GetItems<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>(), true);
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x000E63B4 File Offset: 0x000E45B4
		public global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Infrastructure.MappingViews.DbMappingView> GenerateViews(string conceptualModelContainerName, string storeModelContainerName, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(conceptualModelContainerName, "conceptualModelContainerName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(storeModelContainerName, "storeModelContainerName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>>(errors, "errors");
			global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping = this.GetItems<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().SingleOrDefault((global::System.Data.Entity.Core.Mapping.EntityContainerMapping m) => m.EdmEntityContainer.Name == conceptualModelContainerName && m.StorageEntityContainer.Name == storeModelContainerName);
			if (entityContainerMapping == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ViewGenContainersNotFound(conceptualModelContainerName, storeModelContainerName));
			}
			return global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.GenerateViews(entityContainerMapping, errors);
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x000E643A File Offset: 0x000E463A
		public global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Infrastructure.MappingViews.DbMappingView> GenerateViews(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>>(errors, "errors");
			if (this.GetItems<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().Count != 1)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ViewGenMultipleContainers);
			}
			return global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.GenerateViews(this.GetItems<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>(), errors);
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x000E6474 File Offset: 0x000E4674
		internal static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Infrastructure.MappingViews.DbMappingView> GenerateViews(global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Infrastructure.MappingViews.DbMappingView> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Infrastructure.MappingViews.DbMappingView>();
			if (!containerMapping.HasViews)
			{
				return dictionary;
			}
			if (!containerMapping.HasMappingFragments())
			{
				errors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_AllQueryViewAtCompileTime(containerMapping.Identity), 2088, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Warning));
				return dictionary;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenResults viewGenResults = global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenGatekeeper.GenerateViewsFromMapping(containerMapping, new global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator
			{
				GenerateEsql = true
			});
			if (viewGenResults.HasErrors)
			{
				viewGenResults.Errors.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError e)
				{
					errors.Add(e);
				});
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView>> keyValuePair in viewGenResults.Views.KeyValuePairs)
			{
				dictionary.Add(keyValuePair.Key, new global::System.Data.Entity.Infrastructure.MappingViews.DbMappingView(keyValuePair.Value[0].eSQL));
			}
			return dictionary;
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x000E6560 File Offset: 0x000E4760
		public static global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection Create(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection, global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IList<string> filePaths, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection>(edmItemCollection, "edmItemCollection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(storeItemCollection, "storeItemCollection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader>>(xmlReaders, "xmlReaders");
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentContainsNull<global::System.Xml.XmlReader>(ref xmlReaders, "xmlReaders");
			global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection result = new global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection(edmItemCollection, storeItemCollection, xmlReaders, filePaths, ref errors);
			if (errors == null || errors.Count <= 0)
			{
				return result;
			}
			return null;
		}

		// Token: 0x040017F1 RID: 6129
		private global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection _edmCollection;

		// Token: 0x040017F2 RID: 6130
		private global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection _storeItemCollection;

		// Token: 0x040017F3 RID: 6131
		private global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.ViewDictionary m_viewDictionary;

		// Token: 0x040017F4 RID: 6132
		private double m_mappingVersion;

		// Token: 0x040017F5 RID: 6133
		private global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _workspace;

		// Token: 0x040017F6 RID: 6134
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> m_memberMappings = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>();

		// Token: 0x040017F7 RID: 6135
		private global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader _viewLoader;

		// Token: 0x040017F8 RID: 6136
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.InterestingMembersKind>, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>> _cachedInterestingMembers = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.InterestingMembersKind>, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>>();

		// Token: 0x040017F9 RID: 6137
		private global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCacheFactory _mappingViewCacheFactory;

		// Token: 0x02000B60 RID: 2912
		// (Invoke) Token: 0x060065E5 RID: 26085
		internal delegate bool TryGetUserDefinedQueryView(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, out global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView generatedView);

		// Token: 0x02000B61 RID: 2913
		// (Invoke) Token: 0x060065E9 RID: 26089
		internal delegate bool TryGetUserDefinedQueryViewOfType(global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>> extent, out global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView generatedView);

		// Token: 0x02000B62 RID: 2914
		internal class ViewDictionary
		{
			// Token: 0x060065EC RID: 26092 RVA: 0x0015D8F8 File Offset: 0x0015BAF8
			internal ViewDictionary(global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection storageMappingItemCollection, out global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> userDefinedQueryViewsDict, out global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> userDefinedQueryViewsOfTypeDict)
			{
				this._storageMappingItemCollection = storageMappingItemCollection;
				this._generatedViewsMemoizer = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView>>(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView>>(this.SerializedGetGeneratedViews), null);
				this._generatedViewOfTypeMemoizer = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView>(new global::System.Func<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView>(this.SerializedGeneratedViewOfType), global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>.PairComparer.Instance);
				userDefinedQueryViewsDict = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>.Default);
				userDefinedQueryViewsOfTypeDict = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView>(global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>.PairComparer.Instance);
				this._tryGetUserDefinedQueryView = new global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.TryGetUserDefinedQueryView(userDefinedQueryViewsDict.TryGetValue);
				this._tryGetUserDefinedQueryViewOfType = new global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.TryGetUserDefinedQueryViewOfType(userDefinedQueryViewsOfTypeDict.TryGetValue);
			}

			// Token: 0x060065ED RID: 26093 RVA: 0x0015D990 File Offset: 0x0015BB90
			private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> SerializedGetGeneratedViews(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container)
			{
				global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMap = global::System.Data.Entity.Core.Metadata.Edm.MappingMetadataHelper.GetEntityContainerMap(this._storageMappingItemCollection, container);
				global::System.Data.Entity.Core.Metadata.Edm.EntityContainer arg = (container.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace) ? entityContainerMap.StorageEntityContainer : entityContainerMap.EdmEntityContainer;
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> dictionary;
				if (this._generatedViewsMemoizer.TryGetValue(arg, out dictionary))
				{
					return dictionary;
				}
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView>();
				if (!entityContainerMap.HasViews)
				{
					return dictionary;
				}
				if (this._generatedViewsMode && this._storageMappingItemCollection.MappingViewCacheFactory != null)
				{
					this.SerializedCollectViewsFromCache(entityContainerMap, dictionary);
				}
				if (dictionary.Count == 0)
				{
					this._generatedViewsMode = false;
					global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.ViewDictionary.SerializedGenerateViews(entityContainerMap, dictionary);
				}
				return dictionary;
			}

			// Token: 0x060065EE RID: 26094 RVA: 0x0015DA18 File Offset: 0x0015BC18
			private static void SerializedGenerateViews(global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMap, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> resultDictionary)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenResults viewGenResults = global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenGatekeeper.GenerateViewsFromMapping(entityContainerMap, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.ViewDictionary._config);
				global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> views = viewGenResults.Views;
				if (viewGenResults.HasErrors)
				{
					throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Core.Metadata.Edm.Helper.CombineErrorMessage(viewGenResults.Errors));
				}
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView>> keyValuePair in views.KeyValuePairs)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView value;
					if (!resultDictionary.TryGetValue(keyValuePair.Key, out value))
					{
						value = keyValuePair.Value[0];
						resultDictionary.Add(keyValuePair.Key, value);
					}
				}
			}

			// Token: 0x060065EF RID: 26095 RVA: 0x0015DABC File Offset: 0x0015BCBC
			private bool TryGenerateQueryViewOfType(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entity, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase type, bool includeSubtypes, out global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView generatedView)
			{
				if (type.Abstract)
				{
					generatedView = null;
					return false;
				}
				bool flag;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenResults viewGenResults = global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenGatekeeper.GenerateTypeSpecificQueryView(global::System.Data.Entity.Core.Metadata.Edm.MappingMetadataHelper.GetEntityContainerMap(this._storageMappingItemCollection, entityContainer), global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.ViewDictionary._config, entity, type, includeSubtypes, out flag);
				if (!flag)
				{
					generatedView = null;
					return false;
				}
				global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> views = viewGenResults.Views;
				if (viewGenResults.HasErrors)
				{
					throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Core.Metadata.Edm.Helper.CombineErrorMessage(viewGenResults.Errors));
				}
				generatedView = views.AllValues.First<global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView>();
				return true;
			}

			// Token: 0x060065F0 RID: 26096 RVA: 0x0015DB2C File Offset: 0x0015BD2C
			internal bool TryGetGeneratedViewOfType(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entity, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase type, bool includeSubtypes, out global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView generatedView)
			{
				global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>> arg = new global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>(entity, new global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>(type, includeSubtypes));
				generatedView = this._generatedViewOfTypeMemoizer.Evaluate(arg);
				return generatedView != null;
			}

			// Token: 0x060065F1 RID: 26097 RVA: 0x0015DB5C File Offset: 0x0015BD5C
			private global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView SerializedGeneratedViewOfType(global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>> arg)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView result;
				if (this._tryGetUserDefinedQueryViewOfType(arg, out result))
				{
					return result;
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase first = arg.First;
				global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase first2 = arg.Second.First;
				bool second = arg.Second.Second;
				if (!this.TryGenerateQueryViewOfType(first.EntityContainer, first, first2, second, out result))
				{
					result = null;
				}
				return result;
			}

			// Token: 0x060065F2 RID: 26098 RVA: 0x0015DBB0 File Offset: 0x0015BDB0
			internal global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView GetGeneratedView(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection storageMappingItemCollection)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView result;
				if (this._tryGetUserDefinedQueryView(extent, out result))
				{
					return result;
				}
				if (extent.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSet aSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)extent;
					if (aSet.ElementType.IsForeignKey)
					{
						if (global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.ViewDictionary._config.IsViewTracing)
						{
							global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
							global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
							global::System.Data.Entity.Core.Common.Utils.Helpers.FormatTraceLine("================= Generating FK Query View for: {0} =================", new object[]
							{
								aSet.Name
							});
							global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
							global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
						}
						global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint rc = aSet.ElementType.ReferentialConstraints.Single<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>();
						global::System.Data.Entity.Core.Metadata.Edm.EntitySet dependentSet = aSet.AssociationSetEnds[rc.ToRole.Name].EntitySet;
						global::System.Data.Entity.Core.Metadata.Edm.EntitySet principalSet = aSet.AssociationSetEnds[rc.FromRole.Name].EntitySet;
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = dependentSet.Scan();
						global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentType = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)rc.ToRole);
						global::System.Data.Entity.Core.Metadata.Edm.EntityType principalType = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)rc.FromRole);
						if (dependentSet.ElementType.IsBaseTypeOf(dependentType))
						{
							dbExpression = dbExpression.OfType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(dependentType));
						}
						if (rc.FromRole.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne)
						{
							dbExpression = dbExpression.Where(delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
							{
								global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = null;
								foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty propertyMetadata in rc.ToProperties)
								{
									global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = e.Property(propertyMetadata).IsNull().Not();
									dbExpression2 = ((dbExpression2 == null) ? dbExpression3 : dbExpression2.And(dbExpression3));
								}
								return dbExpression2;
							});
						}
						dbExpression = dbExpression.Select(delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
						{
							global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
							using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>.Enumerator enumerator = aSet.ElementType.AssociationEndMembers.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									if (enumerator.Current.Name == rc.ToRole.Name)
									{
										global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>();
										foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in dependentSet.ElementType.KeyMembers)
										{
											list2.Add(e.Property((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)edmMember));
										}
										list.Add(dependentSet.RefFromKey(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(list2), dependentType));
									}
									else
									{
										global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list3 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>();
										foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember2 in principalSet.ElementType.KeyMembers)
										{
											int index = rc.FromProperties.IndexOf((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)edmMember2);
											list3.Add(e.Property(rc.ToProperties[index]));
										}
										list.Add(principalSet.RefFromKey(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(list3), principalType));
									}
								}
							}
							return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(aSet.ElementType).New(list);
						});
						return global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView.CreateGeneratedViewForFKAssociationSet(aSet, aSet.ElementType, new global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree(workspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace, dbExpression), storageMappingItemCollection, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.ViewDictionary._config);
					}
				}
				if (!this._generatedViewsMemoizer.Evaluate(extent.EntityContainer).TryGetValue(extent, out result))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Mapping_Views_For_Extent_Not_Generated((extent.EntityContainer.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace) ? "Table" : "EntitySet", extent.Name));
				}
				return result;
			}

			// Token: 0x060065F3 RID: 26099 RVA: 0x0015DDD8 File Offset: 0x0015BFD8
			private void SerializedCollectViewsFromCache(global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> extentMappingViews)
			{
				global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCache dbMappingViewCache = this._storageMappingItemCollection.MappingViewCacheFactory.Create(containerMapping);
				if (dbMappingViewCache == null)
				{
					return;
				}
				if (global::System.Data.Entity.Core.Mapping.MetadataMappingHasherVisitor.GetMappingClosureHash(containerMapping.StorageMappingItemCollection.MappingVersion, containerMapping, true) != dbMappingViewCache.MappingHashValue)
				{
					throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.ViewGen_HashOnMappingClosure_Not_Matching(dbMappingViewCache.GetType().Name));
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in containerMapping.StorageEntityContainer.BaseEntitySets.Union(containerMapping.EdmEntityContainer.BaseEntitySets))
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView value;
					if (!extentMappingViews.TryGetValue(entitySetBase, out value))
					{
						global::System.Data.Entity.Infrastructure.MappingViews.DbMappingView view = dbMappingViewCache.GetView(entitySetBase);
						if (view != null)
						{
							value = global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView.CreateGeneratedView(entitySetBase, null, null, view.EntitySql, this._storageMappingItemCollection, new global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator());
							extentMappingViews.Add(entitySetBase, value);
						}
					}
				}
			}

			// Token: 0x04002DAF RID: 11695
			private readonly global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.TryGetUserDefinedQueryView _tryGetUserDefinedQueryView;

			// Token: 0x04002DB0 RID: 11696
			private readonly global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection.TryGetUserDefinedQueryViewOfType _tryGetUserDefinedQueryViewOfType;

			// Token: 0x04002DB1 RID: 11697
			private readonly global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection _storageMappingItemCollection;

			// Token: 0x04002DB2 RID: 11698
			private static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator _config = new global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator();

			// Token: 0x04002DB3 RID: 11699
			private bool _generatedViewsMode = true;

			// Token: 0x04002DB4 RID: 11700
			private readonly global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView>> _generatedViewsMemoizer;

			// Token: 0x04002DB5 RID: 11701
			private readonly global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> _generatedViewOfTypeMemoizer;
		}

		// Token: 0x02000B63 RID: 2915
		internal enum InterestingMembersKind
		{
			// Token: 0x04002DB7 RID: 11703
			RequiredOriginalValueMembers,
			// Token: 0x04002DB8 RID: 11704
			FullUpdate,
			// Token: 0x04002DB9 RID: 11705
			PartialUpdate
		}
	}
}
