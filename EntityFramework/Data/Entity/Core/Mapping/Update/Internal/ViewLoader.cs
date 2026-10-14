using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Threading;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005DA RID: 1498
	internal class ViewLoader
	{
		// Token: 0x0600487E RID: 18558 RVA: 0x001010DC File Offset: 0x000FF2DC
		internal ViewLoader(global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingCollection)
		{
			this.m_mappingCollection = mappingCollection;
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x0010113D File Offset: 0x000FF33D
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator GetFunctionMappingTranslator(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			return this.SyncGetValue<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator>(extent, workspace, this.m_functionMappingTranslators, extent);
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x0010114E File Offset: 0x000FF34E
		internal global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> GetAffectedTables(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			return this.SyncGetValue<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>>(extent, workspace, this.m_affectedTables, extent);
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x0010115F File Offset: 0x000FF35F
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata GetAssociationSetMetadata(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			return this.SyncGetValue<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata>(associationSet, workspace, this.m_associationSetMetadata, associationSet);
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x00101170 File Offset: 0x000FF370
		internal bool IsServerGen(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return this.SyncContains<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(entitySetBase, workspace, this.m_serverGenProperties, member);
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x00101181 File Offset: 0x000FF381
		internal bool IsNullConditionMember(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return this.SyncContains<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(entitySetBase, workspace, this.m_isNullConditionProperties, member);
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x00101194 File Offset: 0x000FF394
		private T_Value SyncGetValue<T_Key, T_Value>(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Collections.Generic.Dictionary<T_Key, T_Value> dictionary, T_Key key)
		{
			return this.SyncInitializeEntitySet<T_Key, T_Value>(entitySetBase, workspace, (T_Key k) => dictionary[k], key);
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x001011C4 File Offset: 0x000FF3C4
		private bool SyncContains<T_Element>(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Common.Utils.Set<T_Element> set, T_Element element)
		{
			return this.SyncInitializeEntitySet<T_Element, bool>(entitySetBase, workspace, new global::System.Func<T_Element, bool>(set.Contains), element);
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x001011DC File Offset: 0x000FF3DC
		private TResult SyncInitializeEntitySet<TArg, TResult>(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Func<TArg, TResult> evaluate, TArg arg)
		{
			this.m_readerWriterLock.EnterReadLock();
			try
			{
				if (this.m_affectedTables.ContainsKey(entitySetBase))
				{
					return evaluate(arg);
				}
			}
			finally
			{
				this.m_readerWriterLock.ExitReadLock();
			}
			this.m_readerWriterLock.EnterWriteLock();
			TResult result;
			try
			{
				if (this.m_affectedTables.ContainsKey(entitySetBase))
				{
					result = evaluate(arg);
				}
				else
				{
					this.InitializeEntitySet(entitySetBase, workspace);
					result = evaluate(arg);
				}
			}
			finally
			{
				this.m_readerWriterLock.ExitWriteLock();
			}
			return result;
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x0010127C File Offset: 0x000FF47C
		private void InitializeEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping = (global::System.Data.Entity.Core.Mapping.EntityContainerMapping)this.m_mappingCollection.GetMap(entitySetBase.EntityContainer);
			if (entityContainerMapping.HasViews)
			{
				this.m_mappingCollection.GetGeneratedView(entitySetBase, workspace);
			}
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
			if (entityContainerMapping != null)
			{
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> set2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
				global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping;
				if (entitySetBase.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet)
				{
					entitySetBaseMapping = entityContainerMapping.GetEntitySetMapping(entitySetBase.Name);
					this.m_serverGenProperties.Unite(global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader.GetMembersWithResultBinding((global::System.Data.Entity.Core.Mapping.EntitySetMapping)entitySetBaseMapping));
				}
				else
				{
					if (entitySetBase.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet)
					{
						throw new global::System.NotSupportedException();
					}
					entitySetBaseMapping = entityContainerMapping.GetAssociationSetMapping(entitySetBase.Name);
				}
				foreach (global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment in global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader.GetMappingFragments(entitySetBaseMapping))
				{
					set.Add(mappingFragment.TableSet);
					this.m_serverGenProperties.AddRange(global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader.FindServerGenMembers(mappingFragment));
					set2.AddRange(global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader.FindIsNullConditionColumns(mappingFragment));
				}
				if (0 < set2.Count)
				{
					foreach (global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment2 in global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader.GetMappingFragments(entitySetBaseMapping))
					{
						this.m_isNullConditionProperties.AddRange(global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader.FindPropertiesMappedToColumns(set2, mappingFragment2));
					}
				}
			}
			this.m_affectedTables.Add(entitySetBase, set.MakeReadOnly());
			this.InitializeFunctionMappingTranslators(entitySetBase, entityContainerMapping);
			if (entitySetBase.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)entitySetBase;
				if (!this.m_associationSetMetadata.ContainsKey(associationSet))
				{
					this.m_associationSetMetadata.Add(associationSet, new global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata(this.m_affectedTables[associationSet], associationSet, workspace));
				}
			}
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x00101434 File Offset: 0x000FF634
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> GetMembersWithResultBinding(global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping)
		{
			foreach (global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping typeFunctionMapping in entitySetMapping.ModificationFunctionMappings)
			{
				if (typeFunctionMapping.InsertFunctionMapping != null && typeFunctionMapping.InsertFunctionMapping.ResultBindings != null)
				{
					foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding modificationFunctionResultBinding in typeFunctionMapping.InsertFunctionMapping.ResultBindings)
					{
						yield return modificationFunctionResultBinding.Property;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> enumerator2 = null;
				}
				if (typeFunctionMapping.UpdateFunctionMapping != null && typeFunctionMapping.UpdateFunctionMapping.ResultBindings != null)
				{
					foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding modificationFunctionResultBinding2 in typeFunctionMapping.UpdateFunctionMapping.ResultBindings)
					{
						yield return modificationFunctionResultBinding2.Property;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> enumerator2 = null;
				}
				typeFunctionMapping = null;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x00101444 File Offset: 0x000FF644
		private void InitializeFunctionMappingTranslators(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase, global::System.Data.Entity.Core.Mapping.EntityContainerMapping mapping)
		{
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>.Default);
			if (!this.m_functionMappingTranslators.ContainsKey(entitySetBase))
			{
				foreach (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping in mapping.EntitySetMaps)
				{
					global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping = (global::System.Data.Entity.Core.Mapping.EntitySetMapping)entitySetBaseMapping;
					if (0 < entitySetMapping.ModificationFunctionMappings.Count)
					{
						this.m_functionMappingTranslators.Add(entitySetMapping.Set, global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator.CreateEntitySetTranslator(entitySetMapping));
						using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> enumerator2 = entitySetMapping.ImplicitlyMappedAssociationSetEnds.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = enumerator2.Current;
								global::System.Data.Entity.Core.Metadata.Edm.AssociationSet parentAssociationSet = associationSetEnd.ParentAssociationSet;
								if (!this.m_functionMappingTranslators.ContainsKey(parentAssociationSet))
								{
									this.m_functionMappingTranslators.Add(parentAssociationSet, global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator.CreateAssociationSetTranslator(null));
								}
								global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd oppositeEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetOppositeEnd(associationSetEnd);
								keyToListMap.Add(parentAssociationSet, oppositeEnd.CorrespondingAssociationEndMember);
							}
							continue;
						}
					}
					this.m_functionMappingTranslators.Add(entitySetMapping.Set, null);
				}
				foreach (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping2 in mapping.RelationshipSetMaps)
				{
					global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping = (global::System.Data.Entity.Core.Mapping.AssociationSetMapping)entitySetBaseMapping2;
					if (associationSetMapping.ModificationFunctionMapping != null)
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationSet key = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)associationSetMapping.Set;
						this.m_functionMappingTranslators.Add(key, global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator.CreateAssociationSetTranslator(associationSetMapping));
						keyToListMap.AddRange(key, global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>());
					}
					else if (!this.m_functionMappingTranslators.ContainsKey(associationSetMapping.Set))
					{
						this.m_functionMappingTranslators.Add(associationSetMapping.Set, null);
					}
				}
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet key2 in keyToListMap.Keys)
			{
				this.m_associationSetMetadata.Add(key2, new global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata(keyToListMap.EnumerateValues(key2)));
			}
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x00101650 File Offset: 0x000FF850
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> FindServerGenMembers(global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping in global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader.FlattenPropertyMappings(mappingFragment.AllProperties).OfType<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>())
			{
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetStoreGeneratedPattern(scalarPropertyMapping.Column) != global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.None)
				{
					yield return scalarPropertyMapping.Property;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x00101660 File Offset: 0x000FF860
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> FindIsNullConditionColumns(global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMapping in global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader.FlattenPropertyMappings(mappingFragment.AllProperties).OfType<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>())
			{
				if (conditionPropertyMapping.Column != null && conditionPropertyMapping.IsNull != null)
				{
					yield return conditionPropertyMapping.Column;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x00101670 File Offset: 0x000FF870
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> FindPropertiesMappedToColumns(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> columns, global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping in global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader.FlattenPropertyMappings(mappingFragment.AllProperties).OfType<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>())
			{
				if (columns.Contains(scalarPropertyMapping.Column))
				{
					yield return scalarPropertyMapping.Property;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x00101687 File Offset: 0x000FF887
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment> GetMappingFragments(global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping setMapping)
		{
			foreach (global::System.Data.Entity.Core.Mapping.TypeMapping typeMapping in setMapping.TypeMappings)
			{
				foreach (global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment in typeMapping.MappingFragments)
				{
					yield return mappingFragment;
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.MappingFragment> enumerator2 = null;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.TypeMapping> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x00101697 File Offset: 0x000FF897
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.PropertyMapping> FlattenPropertyMappings(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.PropertyMapping> propertyMappings)
		{
			foreach (global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping in propertyMappings)
			{
				global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping;
				if (complexPropertyMapping != null)
				{
					foreach (global::System.Data.Entity.Core.Mapping.ComplexTypeMapping complexTypeMapping in complexPropertyMapping.TypeMappings)
					{
						foreach (global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping2 in global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader.FlattenPropertyMappings(complexTypeMapping.AllProperties))
						{
							yield return propertyMapping2;
						}
						global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.PropertyMapping> enumerator3 = null;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ComplexTypeMapping> enumerator2 = null;
				}
				else
				{
					yield return propertyMapping;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.PropertyMapping> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x040019B7 RID: 6583
		private readonly global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection m_mappingCollection;

		// Token: 0x040019B8 RID: 6584
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata> m_associationSetMetadata = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata>();

		// Token: 0x040019B9 RID: 6585
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> m_affectedTables = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>>();

		// Token: 0x040019BA RID: 6586
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> m_serverGenProperties = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();

		// Token: 0x040019BB RID: 6587
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> m_isNullConditionProperties = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();

		// Token: 0x040019BC RID: 6588
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator> m_functionMappingTranslators = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>.Default);

		// Token: 0x040019BD RID: 6589
		private readonly global::System.Threading.ReaderWriterLockSlim m_readerWriterLock = new global::System.Threading.ReaderWriterLockSlim();
	}
}
