using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.EntityClient.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005D9 RID: 1497
	internal class UpdateTranslator
	{
		// Token: 0x06004857 RID: 18519 RVA: 0x000FFEB4 File Offset: 0x000FE0B4
		public UpdateTranslator(global::System.Data.Entity.Core.EntityClient.Internal.EntityAdapter adapter) : this()
		{
			this._stateManager = adapter.Context.ObjectStateManager;
			this._interceptionContext = adapter.Context.InterceptionContext;
			this._adapter = adapter;
			this._providerServices = adapter.Connection.StoreProviderFactory.GetProviderServices();
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x000FFF08 File Offset: 0x000FE108
		protected UpdateTranslator()
		{
			this._changes = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode>();
			this._functionChanges = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry>>();
			this._stateEntries = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry>();
			this._knownEntityKeys = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.EntityKey>();
			this._requiredEntities = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>();
			this._optionalEntities = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.EntityKey>();
			this._includedValueEntities = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.EntityKey>();
			this._interceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext();
			this._recordConverter = new global::System.Data.Entity.Core.Mapping.Update.Internal.RecordConverter(this);
			this._constraintValidator = new global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator();
			this._extractorMetadata = new global::System.Collections.Generic.Dictionary<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.StructuralType>, global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata>();
			global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager keyManager = new global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager();
			this.KeyManager = keyManager;
			this.KeyComparer = global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey.CreateComparer(keyManager);
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06004859 RID: 18521 RVA: 0x000FFFAE File Offset: 0x000FE1AE
		internal global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace MetadataWorkspace
		{
			get
			{
				return this.Connection.GetMetadataWorkspace();
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x000FFFBB File Offset: 0x000FE1BB
		// (set) Token: 0x0600485B RID: 18523 RVA: 0x000FFFC3 File Offset: 0x000FE1C3
		internal virtual global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager KeyManager { get; private set; }

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x0600485C RID: 18524 RVA: 0x000FFFCC File Offset: 0x000FE1CC
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.ViewLoader ViewLoader
		{
			get
			{
				return this.MetadataWorkspace.GetUpdateViewLoader();
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x0600485D RID: 18525 RVA: 0x000FFFD9 File Offset: 0x000FE1D9
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.RecordConverter RecordConverter
		{
			get
			{
				return this._recordConverter;
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x000FFFE1 File Offset: 0x000FE1E1
		internal virtual global::System.Data.Entity.Core.EntityClient.EntityConnection Connection
		{
			get
			{
				return this._adapter.Connection;
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x0600485F RID: 18527 RVA: 0x000FFFEE File Offset: 0x000FE1EE
		internal virtual int? CommandTimeout
		{
			get
			{
				return this._adapter.CommandTimeout;
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x000FFFFB File Offset: 0x000FE1FB
		public virtual global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext InterceptionContext
		{
			get
			{
				return this._interceptionContext;
			}
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x00100004 File Offset: 0x000FE204
		internal void RegisterReferentialConstraints(global::System.Data.Entity.Core.IEntityStateEntry stateEntry)
		{
			if (stateEntry.IsRelationship)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)stateEntry.EntitySet;
				if (0 >= associationSet.ElementType.ReferentialConstraints.Count)
				{
					return;
				}
				global::System.Data.Common.DbDataRecord dbDataRecord = (stateEntry.State == global::System.Data.Entity.EntityState.Added) ? stateEntry.CurrentValues : stateEntry.OriginalValues;
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>.Enumerator enumerator = associationSet.ElementType.ReferentialConstraints.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = enumerator.Current;
						global::System.Data.Entity.Core.EntityKey entityKey = (global::System.Data.Entity.Core.EntityKey)dbDataRecord[referentialConstraint.FromRole.Name];
						global::System.Data.Entity.Core.EntityKey entityKey2 = (global::System.Data.Entity.Core.EntityKey)dbDataRecord[referentialConstraint.ToRole.Name];
						using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator2 = referentialConstraint.FromProperties.GetEnumerator())
						{
							using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator3 = referentialConstraint.ToProperties.GetEnumerator())
							{
								while (enumerator2.MoveNext() && enumerator3.MoveNext())
								{
									int keyMemberCount;
									int keyMemberOffset = global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.GetKeyMemberOffset(referentialConstraint.FromRole, enumerator2.Current, out keyMemberCount);
									int keyMemberCount2;
									int keyMemberOffset2 = global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.GetKeyMemberOffset(referentialConstraint.ToRole, enumerator3.Current, out keyMemberCount2);
									int keyIdentifierForMemberOffset = this.KeyManager.GetKeyIdentifierForMemberOffset(entityKey, keyMemberOffset, keyMemberCount);
									int keyIdentifierForMemberOffset2 = this.KeyManager.GetKeyIdentifierForMemberOffset(entityKey2, keyMemberOffset2, keyMemberCount2);
									this.KeyManager.AddReferentialConstraint(stateEntry, keyIdentifierForMemberOffset2, keyIdentifierForMemberOffset);
								}
							}
						}
					}
					return;
				}
			}
			if (!stateEntry.IsKeyEntry)
			{
				if (stateEntry.State == global::System.Data.Entity.EntityState.Added || stateEntry.State == global::System.Data.Entity.EntityState.Modified)
				{
					this.RegisterEntityReferentialConstraints(stateEntry, true);
				}
				if (stateEntry.State == global::System.Data.Entity.EntityState.Deleted || stateEntry.State == global::System.Data.Entity.EntityState.Modified)
				{
					this.RegisterEntityReferentialConstraints(stateEntry, false);
				}
			}
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x001001D4 File Offset: 0x000FE3D4
		private void RegisterEntityReferentialConstraints(global::System.Data.Entity.Core.IEntityStateEntry stateEntry, bool currentValues)
		{
			global::System.Data.Entity.Core.IExtendedDataRecord extendedDataRecord;
			if (!currentValues)
			{
				extendedDataRecord = (global::System.Data.Entity.Core.IExtendedDataRecord)stateEntry.OriginalValues;
			}
			else
			{
				global::System.Data.Entity.Core.IExtendedDataRecord currentValues2 = stateEntry.CurrentValues;
				extendedDataRecord = currentValues2;
			}
			global::System.Data.Entity.Core.IExtendedDataRecord extendedDataRecord2 = extendedDataRecord;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)stateEntry.EntitySet;
			global::System.Data.Entity.Core.EntityKey entityKey = stateEntry.EntityKey;
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> tuple in entitySet.ForeignKeyDependents)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet item = tuple.Item1;
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint item2 = tuple.Item2;
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)item2.ToRole).IsAssignableFrom(extendedDataRecord2.DataRecordInfo.RecordType.EdmType))
				{
					global::System.Data.Entity.Core.EntityKey entityKey2 = null;
					if (!currentValues || !this._stateManager.TryGetReferenceKey(entityKey, (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)item2.FromRole, out entityKey2))
					{
						global::System.Data.Entity.Core.Metadata.Edm.EntityType entityTypeForEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)item2.FromRole);
						bool flag = false;
						object[] array = new object[entityTypeForEnd.KeyMembers.Count];
						int i = 0;
						int num = array.Length;
						while (i < num)
						{
							global::System.Data.Entity.Core.Metadata.Edm.EdmProperty value = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)entityTypeForEnd.KeyMembers[i];
							int index = item2.FromProperties.IndexOf(value);
							int ordinal = extendedDataRecord2.GetOrdinal(item2.ToProperties[index].Name);
							if (extendedDataRecord2.IsDBNull(ordinal))
							{
								flag = true;
								break;
							}
							array[i] = extendedDataRecord2.GetValue(ordinal);
							i++;
						}
						if (!flag)
						{
							global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet2 = item.AssociationSetEnds[item2.FromRole.Name].EntitySet;
							if (1 == array.Length)
							{
								entityKey2 = new global::System.Data.Entity.Core.EntityKey(entitySet2, array[0]);
							}
							else
							{
								entityKey2 = new global::System.Data.Entity.Core.EntityKey(entitySet2, array);
							}
						}
					}
					if (null != entityKey2)
					{
						global::System.Data.Entity.Core.IEntityStateEntry entityStateEntry;
						global::System.Data.Entity.Core.EntityKey entityKey3;
						if (!this._stateManager.TryGetEntityStateEntry(entityKey2, out entityStateEntry) && currentValues && this.KeyManager.TryGetTempKey(entityKey2, out entityKey3))
						{
							if (null == entityKey3)
							{
								throw global::System.Data.Entity.Core.EntityUtil.Update(global::System.Data.Entity.Resources.Strings.Update_AmbiguousForeignKey(item2.ToRole.DeclaringType.FullName), null, new global::System.Data.Entity.Core.IEntityStateEntry[]
								{
									stateEntry
								});
							}
							entityKey2 = entityKey3;
						}
						this.AddValidAncillaryKey(entityKey2, this._optionalEntities);
						int j = 0;
						int count = item2.FromProperties.Count;
						while (j < count)
						{
							global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property = item2.FromProperties[j];
							global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = item2.ToProperties[j];
							int keyMemberCount;
							int keyMemberOffset = global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.GetKeyMemberOffset(item2.FromRole, property, out keyMemberCount);
							int keyIdentifierForMemberOffset = this.KeyManager.GetKeyIdentifierForMemberOffset(entityKey2, keyMemberOffset, keyMemberCount);
							int dependentIdentifier;
							if (entitySet.ElementType.KeyMembers.Contains(edmProperty))
							{
								int keyMemberCount2;
								int keyMemberOffset2 = global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.GetKeyMemberOffset(item2.ToRole, edmProperty, out keyMemberCount2);
								dependentIdentifier = this.KeyManager.GetKeyIdentifierForMemberOffset(entityKey, keyMemberOffset2, keyMemberCount2);
							}
							else
							{
								dependentIdentifier = this.KeyManager.GetKeyIdentifierForMember(entityKey, edmProperty.Name, currentValues);
							}
							if (currentValues && entityStateEntry != null && entityStateEntry.State == global::System.Data.Entity.EntityState.Deleted && (stateEntry.State == global::System.Data.Entity.EntityState.Added || stateEntry.State == global::System.Data.Entity.EntityState.Modified))
							{
								throw global::System.Data.Entity.Core.EntityUtil.Update(global::System.Data.Entity.Resources.Strings.Update_InsertingOrUpdatingReferenceToDeletedEntity(item.ElementType.FullName), null, new global::System.Data.Entity.Core.IEntityStateEntry[]
								{
									stateEntry,
									entityStateEntry
								});
							}
							this.KeyManager.AddReferentialConstraint(stateEntry, dependentIdentifier, keyIdentifierForMemberOffset);
							j++;
						}
					}
				}
			}
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x00100528 File Offset: 0x000FE728
		private static int GetKeyMemberOffset(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember role, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, out int keyMemberCount)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)role.TypeUsage.EdmType).ElementType;
			keyMemberCount = entityType.KeyMembers.Count;
			return entityType.KeyMembers.IndexOf(property);
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x00100569 File Offset: 0x000FE769
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.IEntityStateEntry> GetRelationships(global::System.Data.Entity.Core.EntityKey entityKey)
		{
			return this._stateManager.FindRelationshipsByKey(entityKey);
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x00100578 File Offset: 0x000FE778
		internal virtual int Update()
		{
			global::System.Collections.Generic.Dictionary<int, object> identifierValues = new global::System.Collections.Generic.Dictionary<int, object>();
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>> generatedValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>>();
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> enumerable = this.ProduceCommands();
			global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand source = null;
			try
			{
				foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand in enumerable)
				{
					long rowsAffected = (source = updateCommand).Execute(identifierValues, generatedValues);
					this.ValidateRowsAffected(rowsAffected, source);
				}
			}
			catch (global::System.Exception ex)
			{
				if (ex.RequiresContext())
				{
					throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_GeneralExecutionException, ex, this.DetermineStateEntriesFromSource(source).Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
				}
				throw;
			}
			this.BackPropagateServerGen(generatedValues);
			return this.AcceptChanges();
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x0010062C File Offset: 0x000FE82C
		internal virtual async global::System.Threading.Tasks.Task<int> UpdateAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Collections.Generic.Dictionary<int, object> identifierValues = new global::System.Collections.Generic.Dictionary<int, object>();
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>> generatedValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>>();
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> enumerable = this.ProduceCommands();
			global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand source = null;
			try
			{
				foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand in enumerable)
				{
					source = updateCommand;
					long rowsAffected = await updateCommand.ExecuteAsync(identifierValues, generatedValues, cancellationToken).WithCurrentCulture<long>();
					this.ValidateRowsAffected(rowsAffected, source);
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> enumerator = null;
			}
			catch (global::System.Exception ex)
			{
				if (ex.RequiresContext())
				{
					throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_GeneralExecutionException, ex, this.DetermineStateEntriesFromSource(source).Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
				}
				throw;
			}
			this.BackPropagateServerGen(generatedValues);
			return this.AcceptChanges();
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x0010067C File Offset: 0x000FE87C
		protected virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> ProduceCommands()
		{
			this.PullModifiedEntriesFromStateManager();
			this.PullUnchangedEntriesFromStateManager();
			this._constraintValidator.ValidateConstraints();
			this.KeyManager.ValidateReferentialIntegrityGraphAcyclic();
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> first = this.ProduceDynamicCommands();
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> second = this.ProduceFunctionCommands();
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> result;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> remainder;
			if (!new global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer(first.Concat(second), this).TryTopologicalSort(out result, out remainder))
			{
				throw this.DependencyOrderingError(remainder);
			}
			return result;
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x001006D8 File Offset: 0x000FE8D8
		private void ValidateRowsAffected(long rowsAffected, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand source)
		{
			if (rowsAffected == 0L)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.IEntityStateEntry> source2 = this.DetermineStateEntriesFromSource(source);
				throw new global::System.Data.Entity.Core.OptimisticConcurrencyException(global::System.Data.Entity.Resources.Strings.Update_ConcurrencyError(rowsAffected), null, source2.Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
			}
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x0010070D File Offset: 0x000FE90D
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.IEntityStateEntry> DetermineStateEntriesFromSource(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand source)
		{
			if (source == null)
			{
				return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.IEntityStateEntry>();
			}
			return source.GetStateEntries(this);
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x00100720 File Offset: 0x000FE920
		private void BackPropagateServerGen(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>> generatedValues)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object> keyValuePair in generatedValues)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult key;
				if (-1 == keyValuePair.Key.Identifier || !this.KeyManager.TryGetIdentifierOwner(keyValuePair.Key.Identifier, out key))
				{
					key = keyValuePair.Key;
				}
				object value = keyValuePair.Value;
				if (key.Identifier == -1)
				{
					key.SetServerGenValue(value);
				}
				else
				{
					foreach (int identifier in this.KeyManager.GetDependents(key.Identifier))
					{
						if (this.KeyManager.TryGetIdentifierOwner(identifier, out key))
						{
							key.SetServerGenValue(value);
						}
					}
				}
			}
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x00100818 File Offset: 0x000FEA18
		private int AcceptChanges()
		{
			int num = 0;
			foreach (global::System.Data.Entity.Core.IEntityStateEntry entityStateEntry in this._stateEntries)
			{
				if (global::System.Data.Entity.EntityState.Unchanged != entityStateEntry.State)
				{
					if (this._adapter.AcceptChangesDuringUpdate)
					{
						entityStateEntry.AcceptChanges();
					}
					num++;
				}
			}
			return num;
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x00100888 File Offset: 0x000FEA88
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> GetDynamicModifiedExtents()
		{
			return this._changes.Keys;
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x00100895 File Offset: 0x000FEA95
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> GetFunctionModifiedExtents()
		{
			return this._functionChanges.Keys;
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x001008A2 File Offset: 0x000FEAA2
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> ProduceDynamicCommands()
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler updateCompiler = new global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler(this);
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in this.GetDynamicModifiedExtents())
			{
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> affectedTables = this.ViewLoader.GetAffectedTables(entitySetBase, this.MetadataWorkspace);
				if (affectedTables.Count == 0)
				{
					throw global::System.Data.Entity.Core.EntityUtil.Update(global::System.Data.Entity.Resources.Strings.Update_MappingNotFound(entitySetBase.Name), null, new global::System.Data.Entity.Core.IEntityStateEntry[0]);
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet element in affectedTables)
				{
					set.Add(element);
				}
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet in set)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree cqtView = this.Connection.GetMetadataWorkspace().GetCqtView(entitySet);
				global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode changeNode = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Propagate(this, entitySet, cqtView);
				global::System.Data.Entity.Core.Mapping.Update.Internal.TableChangeProcessor tableChangeProcessor = new global::System.Data.Entity.Core.Mapping.Update.Internal.TableChangeProcessor(entitySet);
				foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand in tableChangeProcessor.CompileCommands(changeNode, updateCompiler))
				{
					yield return updateCommand;
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>.Enumerator enumerator4 = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>.Enumerator);
			}
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>.Enumerator enumerator3 = default(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x001008B4 File Offset: 0x000FEAB4
		internal global::System.Data.Entity.Core.Common.DbCommandDefinition GenerateCommandDefinition(global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping functionMapping)
		{
			if (this._modificationFunctionCommandDefinitions == null)
			{
				this._modificationFunctionCommandDefinitions = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping, global::System.Data.Entity.Core.Common.DbCommandDefinition>();
			}
			global::System.Data.Entity.Core.Common.DbCommandDefinition dbCommandDefinition;
			if (!this._modificationFunctionCommandDefinitions.TryGetValue(functionMapping, out dbCommandDefinition))
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType = null;
				if (functionMapping.ResultBindings != null && functionMapping.ResultBindings.Count > 0)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(functionMapping.ResultBindings.Count);
					foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding modificationFunctionResultBinding in functionMapping.ResultBindings)
					{
						list.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(modificationFunctionResultBinding.ColumnName, modificationFunctionResultBinding.Property.TypeUsage));
					}
					resultType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(new global::System.Data.Entity.Core.Metadata.Edm.RowType(list)));
				}
				global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> parameters = from paramInfo in functionMapping.Function.Parameters
				select new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(paramInfo.Name, paramInfo.TypeUsage);
				global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree commandTree = new global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree(this.MetadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace, functionMapping.Function, resultType, parameters);
				dbCommandDefinition = this._providerServices.CreateCommandDefinition(commandTree, this._interceptionContext);
				this._modificationFunctionCommandDefinitions.Add(functionMapping, dbCommandDefinition);
			}
			return dbCommandDefinition;
		}

		// Token: 0x06004870 RID: 18544 RVA: 0x001009EC File Offset: 0x000FEBEC
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> ProduceFunctionCommands()
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent in this.GetFunctionModifiedExtents())
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator translator = this.ViewLoader.GetFunctionMappingTranslator(extent, this.MetadataWorkspace);
				if (translator != null)
				{
					foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry stateEntry in this.GetExtentFunctionModifications(extent))
					{
						global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand functionUpdateCommand = translator.Translate(this, stateEntry);
						if (functionUpdateCommand != null)
						{
							yield return functionUpdateCommand;
						}
					}
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry>.Enumerator enumerator2 = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry>.Enumerator);
				}
				translator = null;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x001009FC File Offset: 0x000FEBFC
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata GetExtractorMetadata(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase, global::System.Data.Entity.Core.Metadata.Edm.StructuralType type)
		{
			global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.StructuralType> key = global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.StructuralType>(entitySetBase, type);
			global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata extractorMetadata;
			if (!this._extractorMetadata.TryGetValue(key, out extractorMetadata))
			{
				extractorMetadata = new global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata(entitySetBase, type, this);
				this._extractorMetadata.Add(key, extractorMetadata);
			}
			return extractorMetadata;
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x00100A38 File Offset: 0x000FEC38
		private global::System.Data.Entity.Core.UpdateException DependencyOrderingError(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> remainder)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.IEntityStateEntry> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.IEntityStateEntry>();
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand in remainder)
			{
				hashSet.UnionWith(updateCommand.GetStateEntries(this));
			}
			throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_ConstraintCycle, null, hashSet.Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x00100AA4 File Offset: 0x000FECA4
		internal global::System.Data.Common.DbCommand CreateCommand(global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree commandTree)
		{
			global::System.Data.Common.DbCommand result;
			try
			{
				result = new global::System.Data.Entity.Internal.InterceptableDbCommand(this._providerServices.CreateCommand(commandTree, this._interceptionContext), this._interceptionContext, null);
			}
			catch (global::System.Exception ex)
			{
				if (ex.RequiresContext())
				{
					throw new global::System.Data.Entity.Core.EntityCommandCompilationException(global::System.Data.Entity.Resources.Strings.EntityClient_CommandDefinitionPreparationFailed, ex);
				}
				throw;
			}
			return result;
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x00100AFC File Offset: 0x000FECFC
		internal void SetParameterValue(global::System.Data.Common.DbParameter parameter, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage, object value)
		{
			this._providerServices.SetParameterValue(parameter, typeUsage, value);
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x00100B0C File Offset: 0x000FED0C
		private void PullModifiedEntriesFromStateManager()
		{
			foreach (global::System.Data.Entity.Core.IEntityStateEntry entityStateEntry in this._stateManager.GetEntityStateEntries(global::System.Data.Entity.EntityState.Added))
			{
				if (!entityStateEntry.IsRelationship && !entityStateEntry.IsKeyEntry)
				{
					this.KeyManager.RegisterKeyValueForAddedEntity(entityStateEntry);
				}
			}
			foreach (global::System.Data.Entity.Core.IEntityStateEntry stateEntry in this._stateManager.GetEntityStateEntries(global::System.Data.Entity.EntityState.Added | global::System.Data.Entity.EntityState.Deleted | global::System.Data.Entity.EntityState.Modified))
			{
				this.RegisterReferentialConstraints(stateEntry);
			}
			foreach (global::System.Data.Entity.Core.IEntityStateEntry stateEntry2 in this._stateManager.GetEntityStateEntries(global::System.Data.Entity.EntityState.Added | global::System.Data.Entity.EntityState.Deleted | global::System.Data.Entity.EntityState.Modified))
			{
				this.LoadStateEntry(stateEntry2);
			}
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x00100BFC File Offset: 0x000FEDFC
		private void PullUnchangedEntriesFromStateManager()
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> keyValuePair in this._requiredEntities)
			{
				global::System.Data.Entity.Core.EntityKey key = keyValuePair.Key;
				if (!this._knownEntityKeys.Contains(key))
				{
					global::System.Data.Entity.Core.IEntityStateEntry entityStateEntry;
					if (!this._stateManager.TryGetEntityStateEntry(key, out entityStateEntry) || entityStateEntry.IsKeyEntry)
					{
						throw global::System.Data.Entity.Core.EntityUtil.Update(global::System.Data.Entity.Resources.Strings.Update_MissingEntity(keyValuePair.Value.Name, global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(key.EntityContainerName, key.EntitySetName)), null, new global::System.Data.Entity.Core.IEntityStateEntry[0]);
					}
					this.LoadStateEntry(entityStateEntry);
				}
			}
			foreach (global::System.Data.Entity.Core.EntityKey entityKey in this._optionalEntities)
			{
				global::System.Data.Entity.Core.IEntityStateEntry entityStateEntry2;
				if (!this._knownEntityKeys.Contains(entityKey) && this._stateManager.TryGetEntityStateEntry(entityKey, out entityStateEntry2) && !entityStateEntry2.IsKeyEntry)
				{
					this.LoadStateEntry(entityStateEntry2);
				}
			}
			foreach (global::System.Data.Entity.Core.EntityKey entityKey2 in this._includedValueEntities)
			{
				global::System.Data.Entity.Core.IEntityStateEntry stateEntry;
				if (!this._knownEntityKeys.Contains(entityKey2) && this._stateManager.TryGetEntityStateEntry(entityKey2, out stateEntry))
				{
					this._recordConverter.ConvertCurrentValuesToPropagatorResult(stateEntry, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.NoneModified);
				}
			}
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x00100D88 File Offset: 0x000FEF88
		private void ValidateAndRegisterStateEntry(global::System.Data.Entity.Core.IEntityStateEntry stateEntry)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet = stateEntry.EntitySet;
			if (entitySet == null)
			{
				throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.InvalidStateEntry, 1, null);
			}
			global::System.Data.Entity.Core.EntityKey entityKey = stateEntry.EntityKey;
			global::System.Data.Entity.Core.IExtendedDataRecord extendedDataRecord = null;
			if (((global::System.Data.Entity.EntityState.Unchanged | global::System.Data.Entity.EntityState.Added | global::System.Data.Entity.EntityState.Modified) & stateEntry.State) != (global::System.Data.Entity.EntityState)0)
			{
				extendedDataRecord = stateEntry.CurrentValues;
				this.ValidateRecord(entitySet, extendedDataRecord);
			}
			if (((global::System.Data.Entity.EntityState.Unchanged | global::System.Data.Entity.EntityState.Deleted | global::System.Data.Entity.EntityState.Modified) & stateEntry.State) != (global::System.Data.Entity.EntityState)0)
			{
				extendedDataRecord = (global::System.Data.Entity.Core.IExtendedDataRecord)stateEntry.OriginalValues;
				this.ValidateRecord(entitySet, extendedDataRecord);
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = entitySet as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
			if (associationSet != null)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.AssociationSetMetadata associationSetMetadata = this.ViewLoader.GetAssociationSetMetadata(associationSet, this.MetadataWorkspace);
				if (associationSetMetadata.HasEnds)
				{
					foreach (global::System.Data.Entity.Core.Common.FieldMetadata fieldMetadata in extendedDataRecord.DataRecordInfo.FieldMetadata)
					{
						global::System.Data.Entity.Core.EntityKey key = (global::System.Data.Entity.Core.EntityKey)extendedDataRecord.GetValue(fieldMetadata.Ordinal);
						global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember element = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)fieldMetadata.FieldType;
						if (associationSetMetadata.RequiredEnds.Contains(element))
						{
							if (!this._requiredEntities.ContainsKey(key))
							{
								this._requiredEntities.Add(key, associationSet);
							}
						}
						else if (associationSetMetadata.OptionalEnds.Contains(element))
						{
							this.AddValidAncillaryKey(key, this._optionalEntities);
						}
						else if (associationSetMetadata.IncludedValueEnds.Contains(element))
						{
							this.AddValidAncillaryKey(key, this._includedValueEntities);
						}
					}
				}
				this._constraintValidator.RegisterAssociation(associationSet, extendedDataRecord, stateEntry);
			}
			else
			{
				this._constraintValidator.RegisterEntity(stateEntry);
			}
			this._stateEntries.Add(stateEntry);
			if (entityKey != null)
			{
				this._knownEntityKeys.Add(entityKey);
			}
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x00100F2C File Offset: 0x000FF12C
		private void AddValidAncillaryKey(global::System.Data.Entity.Core.EntityKey key, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.EntityKey> keySet)
		{
			global::System.Data.Entity.Core.IEntityStateEntry entityStateEntry;
			if (this._stateManager.TryGetEntityStateEntry(key, out entityStateEntry) && !entityStateEntry.IsKeyEntry && entityStateEntry.State == global::System.Data.Entity.EntityState.Unchanged)
			{
				keySet.Add(key);
			}
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x00100F64 File Offset: 0x000FF164
		private void ValidateRecord(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.IExtendedDataRecord record)
		{
			global::System.Data.Entity.Core.Common.DataRecordInfo dataRecordInfo;
			if (record == null || (dataRecordInfo = record.DataRecordInfo) == null || dataRecordInfo.RecordType == null)
			{
				throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.InvalidStateEntry, 2, null);
			}
			global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.VerifyExtent(this.MetadataWorkspace, extent);
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x00100FA0 File Offset: 0x000FF1A0
		private static void VerifyExtent(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer = extent.EntityContainer;
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer2 = null;
			if (entityContainer != null)
			{
				workspace.TryGetEntityContainer(entityContainer.Name, entityContainer.DataSpace, out entityContainer2);
			}
			if (entityContainer == null || entityContainer2 == null || entityContainer != entityContainer2)
			{
				throw global::System.Data.Entity.Core.EntityUtil.Update(global::System.Data.Entity.Resources.Strings.Update_WorkspaceMismatch, null, new global::System.Data.Entity.Core.IEntityStateEntry[0]);
			}
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x00100FEC File Offset: 0x000FF1EC
		private void LoadStateEntry(global::System.Data.Entity.Core.IEntityStateEntry stateEntry)
		{
			this.ValidateAndRegisterStateEntry(stateEntry);
			global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry extractedStateEntry = new global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry(this, stateEntry);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet = stateEntry.EntitySet;
			if (this.ViewLoader.GetFunctionMappingTranslator(entitySet, this.MetadataWorkspace) == null)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode extentModifications = this.GetExtentModifications(entitySet);
				if (extractedStateEntry.Original != null)
				{
					extentModifications.Deleted.Add(extractedStateEntry.Original);
				}
				if (extractedStateEntry.Current != null)
				{
					extentModifications.Inserted.Add(extractedStateEntry.Current);
					return;
				}
			}
			else
			{
				this.GetExtentFunctionModifications(entitySet).Add(extractedStateEntry);
			}
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x0010106C File Offset: 0x000FF26C
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode GetExtentModifications(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode changeNode;
			if (!this._changes.TryGetValue(extent, out changeNode))
			{
				changeNode = new global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(extent.ElementType));
				this._changes.Add(extent, changeNode);
			}
			return changeNode;
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x001010A8 File Offset: 0x000FF2A8
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry> GetExtentFunctionModifications(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry> list;
			if (!this._functionChanges.TryGetValue(extent, out list))
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry>();
				this._functionChanges.Add(extent, list);
			}
			return list;
		}

		// Token: 0x040019A6 RID: 6566
		private readonly global::System.Data.Entity.Core.EntityClient.Internal.EntityAdapter _adapter;

		// Token: 0x040019A7 RID: 6567
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode> _changes;

		// Token: 0x040019A8 RID: 6568
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry>> _functionChanges;

		// Token: 0x040019A9 RID: 6569
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry> _stateEntries;

		// Token: 0x040019AA RID: 6570
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.EntityKey> _knownEntityKeys;

		// Token: 0x040019AB RID: 6571
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> _requiredEntities;

		// Token: 0x040019AC RID: 6572
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.EntityKey> _optionalEntities;

		// Token: 0x040019AD RID: 6573
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.EntityKey> _includedValueEntities;

		// Token: 0x040019AE RID: 6574
		private readonly global::System.Data.Entity.Core.IEntityStateManager _stateManager;

		// Token: 0x040019AF RID: 6575
		private readonly global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext _interceptionContext;

		// Token: 0x040019B0 RID: 6576
		private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.RecordConverter _recordConverter;

		// Token: 0x040019B1 RID: 6577
		private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator _constraintValidator;

		// Token: 0x040019B2 RID: 6578
		private readonly global::System.Data.Entity.Core.Common.DbProviderServices _providerServices;

		// Token: 0x040019B3 RID: 6579
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping, global::System.Data.Entity.Core.Common.DbCommandDefinition> _modificationFunctionCommandDefinitions;

		// Token: 0x040019B4 RID: 6580
		private readonly global::System.Collections.Generic.Dictionary<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.StructuralType>, global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata> _extractorMetadata;

		// Token: 0x040019B6 RID: 6582
		internal readonly global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey> KeyComparer;

		// Token: 0x02000C12 RID: 3090
		private class RelationshipConstraintValidator
		{
			// Token: 0x0600697A RID: 27002 RVA: 0x001679F8 File Offset: 0x00165BF8
			internal RelationshipConstraintValidator()
			{
				this.m_existingRelationships = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship>.Default);
				this.m_impliedRelationships = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship, global::System.Data.Entity.Core.IEntityStateEntry>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship>.Default);
				this.m_referencingRelationshipSets = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>.Default);
			}

			// Token: 0x0600697B RID: 27003 RVA: 0x00167A30 File Offset: 0x00165C30
			internal void RegisterEntity(global::System.Data.Entity.Core.IEntityStateEntry stateEntry)
			{
				if (global::System.Data.Entity.EntityState.Added == stateEntry.State || global::System.Data.Entity.EntityState.Deleted == stateEntry.State)
				{
					global::System.Data.Entity.Core.EntityKey entityKey = stateEntry.EntityKey;
					global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)stateEntry.EntitySet;
					global::System.Data.Entity.Core.Metadata.Edm.EntityType otherType = (global::System.Data.Entity.EntityState.Added == stateEntry.State) ? global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.GetEntityType(stateEntry.CurrentValues) : global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.GetEntityType(stateEntry.OriginalValues);
					foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in this.GetReferencingAssociationSets(entitySet))
					{
						global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> associationSetEnds = associationSet.AssociationSetEnds;
						foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSetEnds)
						{
							foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd2 in associationSetEnds)
							{
								if (associationSetEnd2.CorrespondingAssociationEndMember != associationSetEnd.CorrespondingAssociationEndMember && associationSetEnd2.EntitySet.EdmEquals(entitySet) && global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetLowerBoundOfMultiplicity(associationSetEnd.CorrespondingAssociationEndMember.RelationshipMultiplicity) != 0 && global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd(associationSetEnd2.CorrespondingAssociationEndMember).IsAssignableFrom(otherType))
								{
									global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship key = new global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship(entityKey, associationSetEnd.CorrespondingAssociationEndMember, associationSetEnd2.CorrespondingAssociationEndMember, associationSet, stateEntry);
									this.m_impliedRelationships.Add(key, stateEntry);
								}
							}
						}
					}
				}
			}

			// Token: 0x0600697C RID: 27004 RVA: 0x00167BB8 File Offset: 0x00165DB8
			private static global::System.Data.Entity.Core.Metadata.Edm.EntityType GetEntityType(global::System.Data.Common.DbDataRecord dbDataRecord)
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.EntityType)(dbDataRecord as global::System.Data.Entity.Core.IExtendedDataRecord).DataRecordInfo.RecordType.EdmType;
			}

			// Token: 0x0600697D RID: 27005 RVA: 0x00167BD4 File Offset: 0x00165DD4
			internal void RegisterAssociation(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.IExtendedDataRecord record, global::System.Data.Entity.Core.IEntityStateEntry stateEntry)
			{
				global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.EntityKey> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.EntityKey>(global::System.StringComparer.Ordinal);
				foreach (global::System.Data.Entity.Core.Common.FieldMetadata fieldMetadata in record.DataRecordInfo.FieldMetadata)
				{
					string name = fieldMetadata.FieldType.Name;
					global::System.Data.Entity.Core.EntityKey value = (global::System.Data.Entity.Core.EntityKey)record.GetValue(fieldMetadata.Ordinal);
					dictionary.Add(name, value);
				}
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> associationSetEnds = associationSet.AssociationSetEnds;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSetEnds)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd2 in associationSetEnds)
					{
						if (associationSetEnd2.CorrespondingAssociationEndMember != associationSetEnd.CorrespondingAssociationEndMember)
						{
							global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship relationship = new global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship(dictionary[associationSetEnd2.CorrespondingAssociationEndMember.Name], associationSetEnd.CorrespondingAssociationEndMember, associationSetEnd2.CorrespondingAssociationEndMember, associationSet, stateEntry);
							this.AddExistingRelationship(relationship);
						}
					}
				}
			}

			// Token: 0x0600697E RID: 27006 RVA: 0x00167D10 File Offset: 0x00165F10
			internal void ValidateConstraints()
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship, global::System.Data.Entity.Core.IEntityStateEntry> keyValuePair in this.m_impliedRelationships)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship key = keyValuePair.Key;
					global::System.Data.Entity.Core.IEntityStateEntry value = keyValuePair.Value;
					int num = this.GetDirectionalRelationshipCountDelta(key);
					if (global::System.Data.Entity.EntityState.Deleted == value.State)
					{
						num = -num;
					}
					int lowerBoundOfMultiplicity = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetLowerBoundOfMultiplicity(key.FromEnd.RelationshipMultiplicity);
					int? upperBoundOfMultiplicity = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetUpperBoundOfMultiplicity(key.FromEnd.RelationshipMultiplicity);
					int num2 = (upperBoundOfMultiplicity != null) ? upperBoundOfMultiplicity.Value : num;
					if (num < lowerBoundOfMultiplicity || num > num2)
					{
						throw global::System.Data.Entity.Core.EntityUtil.UpdateRelationshipCardinalityConstraintViolation(key.AssociationSet.Name, lowerBoundOfMultiplicity, upperBoundOfMultiplicity, global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(key.ToEntityKey.EntityContainerName, key.ToEntityKey.EntitySetName), num, key.FromEnd.Name, value);
					}
				}
				foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship directionalRelationship in this.m_existingRelationships.Keys)
				{
					int num3;
					int num4;
					directionalRelationship.GetCountsInEquivalenceSet(out num3, out num4);
					int num5 = global::System.Math.Abs(num3 - num4);
					int lowerBoundOfMultiplicity2 = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetLowerBoundOfMultiplicity(directionalRelationship.FromEnd.RelationshipMultiplicity);
					int? upperBoundOfMultiplicity2 = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetUpperBoundOfMultiplicity(directionalRelationship.FromEnd.RelationshipMultiplicity);
					if (upperBoundOfMultiplicity2 != null)
					{
						global::System.Data.Entity.EntityState? entityState = null;
						int? num6 = null;
						if (num3 > upperBoundOfMultiplicity2.Value)
						{
							entityState = new global::System.Data.Entity.EntityState?(global::System.Data.Entity.EntityState.Added);
							num6 = new int?(num3);
						}
						else if (num4 > upperBoundOfMultiplicity2.Value)
						{
							entityState = new global::System.Data.Entity.EntityState?(global::System.Data.Entity.EntityState.Deleted);
							num6 = new int?(num4);
						}
						if (entityState != null)
						{
							throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_RelationshipCardinalityViolation(upperBoundOfMultiplicity2.Value, entityState.Value, directionalRelationship.AssociationSet.ElementType.FullName, directionalRelationship.FromEnd.Name, directionalRelationship.ToEnd.Name, num6.Value), null, (from reln in directionalRelationship.GetEquivalenceSet()
							select reln.StateEntry).Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
						}
					}
					if (1 == num5 && 1 == lowerBoundOfMultiplicity2)
					{
						int num7 = 1;
						int? num8 = upperBoundOfMultiplicity2;
						if (num7 == num8.GetValueOrDefault() & num8 != null)
						{
							bool flag = num3 > num4;
							global::System.Data.Entity.Core.IEntityStateEntry entityStateEntry;
							if (!this.m_impliedRelationships.TryGetValue(directionalRelationship, out entityStateEntry) || (flag && global::System.Data.Entity.EntityState.Added != entityStateEntry.State) || (!flag && global::System.Data.Entity.EntityState.Deleted != entityStateEntry.State))
							{
								throw global::System.Data.Entity.Core.EntityUtil.Update(global::System.Data.Entity.Resources.Strings.Update_MissingRequiredEntity(directionalRelationship.AssociationSet.Name, directionalRelationship.StateEntry.State, directionalRelationship.ToEnd.Name), null, new global::System.Data.Entity.Core.IEntityStateEntry[]
								{
									directionalRelationship.StateEntry
								});
							}
						}
					}
				}
			}

			// Token: 0x0600697F RID: 27007 RVA: 0x0016803C File Offset: 0x0016623C
			private int GetDirectionalRelationshipCountDelta(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship expectedRelationship)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship directionalRelationship;
				if (this.m_existingRelationships.TryGetValue(expectedRelationship, out directionalRelationship))
				{
					int num;
					int num2;
					directionalRelationship.GetCountsInEquivalenceSet(out num, out num2);
					return num - num2;
				}
				return 0;
			}

			// Token: 0x06006980 RID: 27008 RVA: 0x00168068 File Offset: 0x00166268
			private void AddExistingRelationship(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship relationship)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship directionalRelationship;
				if (this.m_existingRelationships.TryGetValue(relationship, out directionalRelationship))
				{
					directionalRelationship.AddToEquivalenceSet(relationship);
					return;
				}
				this.m_existingRelationships.Add(relationship, relationship);
			}

			// Token: 0x06006981 RID: 27009 RVA: 0x0016809C File Offset: 0x0016629C
			private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> GetReferencingAssociationSets(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> list;
				if (!this.m_referencingRelationshipSets.TryGetValue(entitySet, out list))
				{
					list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>();
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in entitySet.EntityContainer.BaseEntitySets)
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = entitySetBase as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
						if (associationSet != null && !associationSet.ElementType.IsForeignKey)
						{
							using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>.Enumerator enumerator2 = associationSet.AssociationSetEnds.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									if (enumerator2.Current.EntitySet.Equals(entitySet))
									{
										list.Add(associationSet);
										break;
									}
								}
							}
						}
					}
					this.m_referencingRelationshipSets.Add(entitySet, list);
				}
				return list;
			}

			// Token: 0x04002FC2 RID: 12226
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship> m_existingRelationships;

			// Token: 0x04002FC3 RID: 12227
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship, global::System.Data.Entity.Core.IEntityStateEntry> m_impliedRelationships;

			// Token: 0x04002FC4 RID: 12228
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>> m_referencingRelationshipSets;

			// Token: 0x02000D94 RID: 3476
			private class DirectionalRelationship : global::System.IEquatable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship>
			{
				// Token: 0x06006FB5 RID: 28597 RVA: 0x0017D604 File Offset: 0x0017B804
				internal DirectionalRelationship(global::System.Data.Entity.Core.EntityKey toEntityKey, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember fromEnd, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember toEnd, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.IEntityStateEntry stateEntry)
				{
					this.ToEntityKey = toEntityKey;
					this.FromEnd = fromEnd;
					this.ToEnd = toEnd;
					this.AssociationSet = associationSet;
					this.StateEntry = stateEntry;
					this._equivalenceSetLinkedListNext = this;
					this._hashCode = (toEntityKey.GetHashCode() ^ fromEnd.GetHashCode() ^ toEnd.GetHashCode() ^ associationSet.GetHashCode());
				}

				// Token: 0x06006FB6 RID: 28598 RVA: 0x0017D668 File Offset: 0x0017B868
				internal void AddToEquivalenceSet(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship other)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship equivalenceSetLinkedListNext = this._equivalenceSetLinkedListNext;
					this._equivalenceSetLinkedListNext = other;
					other._equivalenceSetLinkedListNext = equivalenceSetLinkedListNext;
				}

				// Token: 0x06006FB7 RID: 28599 RVA: 0x0017D68A File Offset: 0x0017B88A
				internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship> GetEquivalenceSet()
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship current = this;
					do
					{
						yield return current;
						current = current._equivalenceSetLinkedListNext;
					}
					while (current != this);
					yield break;
				}

				// Token: 0x06006FB8 RID: 28600 RVA: 0x0017D69C File Offset: 0x0017B89C
				internal void GetCountsInEquivalenceSet(out int addedCount, out int deletedCount)
				{
					addedCount = 0;
					deletedCount = 0;
					global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship directionalRelationship = this;
					do
					{
						if (directionalRelationship.StateEntry.State == global::System.Data.Entity.EntityState.Added)
						{
							addedCount++;
						}
						else if (directionalRelationship.StateEntry.State == global::System.Data.Entity.EntityState.Deleted)
						{
							deletedCount++;
						}
						directionalRelationship = directionalRelationship._equivalenceSetLinkedListNext;
					}
					while (directionalRelationship != this);
				}

				// Token: 0x06006FB9 RID: 28601 RVA: 0x0017D6E6 File Offset: 0x0017B8E6
				public override int GetHashCode()
				{
					return this._hashCode;
				}

				// Token: 0x06006FBA RID: 28602 RVA: 0x0017D6F0 File Offset: 0x0017B8F0
				public bool Equals(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship other)
				{
					return this == other || (other != null && !(this.ToEntityKey != other.ToEntityKey) && this.AssociationSet == other.AssociationSet && this.ToEnd == other.ToEnd && this.FromEnd == other.FromEnd);
				}

				// Token: 0x06006FBB RID: 28603 RVA: 0x0017D74E File Offset: 0x0017B94E
				public override bool Equals(object obj)
				{
					return this.Equals(obj as global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship);
				}

				// Token: 0x06006FBC RID: 28604 RVA: 0x0017D75C File Offset: 0x0017B95C
				public override string ToString()
				{
					return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}-->{2}: {3}", new object[]
					{
						this.AssociationSet.Name,
						this.FromEnd.Name,
						this.ToEnd.Name,
						global::System.Data.Entity.Core.Common.Utils.StringUtil.BuildDelimitedList<global::System.Data.Entity.Core.EntityKeyMember>(this.ToEntityKey.EntityKeyValues, null, null)
					});
				}

				// Token: 0x040033A4 RID: 13220
				internal readonly global::System.Data.Entity.Core.EntityKey ToEntityKey;

				// Token: 0x040033A5 RID: 13221
				internal readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember FromEnd;

				// Token: 0x040033A6 RID: 13222
				internal readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember ToEnd;

				// Token: 0x040033A7 RID: 13223
				internal readonly global::System.Data.Entity.Core.IEntityStateEntry StateEntry;

				// Token: 0x040033A8 RID: 13224
				internal readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationSet AssociationSet;

				// Token: 0x040033A9 RID: 13225
				private global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.RelationshipConstraintValidator.DirectionalRelationship _equivalenceSetLinkedListNext;

				// Token: 0x040033AA RID: 13226
				private readonly int _hashCode;
			}
		}
	}
}
