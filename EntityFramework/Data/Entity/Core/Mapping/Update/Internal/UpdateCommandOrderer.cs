using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005D6 RID: 1494
	internal class UpdateCommandOrderer : global::System.Data.Entity.Core.Mapping.Update.Internal.Graph<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>
	{
		// Token: 0x06004815 RID: 18453 RVA: 0x000FEA40 File Offset: 0x000FCC40
		internal UpdateCommandOrderer(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> commands, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator) : base(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>.Default)
		{
			this._translator = translator;
			this._keyComparer = new global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValueComparer(this._translator.KeyComparer);
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> hashSet2 = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>();
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand in commands)
			{
				if (updateCommand.Table != null)
				{
					hashSet.Add(updateCommand.Table);
					hashSet2.Add(updateCommand.Table.EntityContainer);
				}
				base.AddVertex(updateCommand);
				if (updateCommand.Kind == global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandKind.Function)
				{
					this._hasFunctionCommands = true;
				}
			}
			global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.InitializeForeignKeyMaps(hashSet2, hashSet, out this._sourceMap, out this._targetMap);
			this.AddServerGenDependencies();
			this.AddForeignKeyDependencies();
			if (this._hasFunctionCommands)
			{
				this.AddModelDependencies();
			}
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x000FEB20 File Offset: 0x000FCD20
		private static void InitializeForeignKeyMaps(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> containers, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> tables, out global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> sourceMap, out global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> targetMap)
		{
			sourceMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>.Default);
			targetMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>.Default);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer in containers)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in entityContainer.BaseEntitySets)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = entitySetBase as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
					if (associationSet != null)
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = null;
						global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd2 = null;
						global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> associationSetEnds = associationSet.AssociationSetEnds;
						if (2 == associationSetEnds.Count)
						{
							global::System.Data.Entity.Core.Metadata.Edm.AssociationType elementType = associationSet.ElementType;
							bool flag = false;
							global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint value = null;
							foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in elementType.ReferentialConstraints)
							{
								if (!flag)
								{
									flag = true;
								}
								associationSetEnd = associationSet.AssociationSetEnds[referentialConstraint.ToRole.Name];
								associationSetEnd2 = associationSet.AssociationSetEnds[referentialConstraint.FromRole.Name];
								value = referentialConstraint;
							}
							if (associationSetEnd2 != null && associationSetEnd != null && tables.Contains(associationSetEnd2.EntitySet) && tables.Contains(associationSetEnd.EntitySet))
							{
								sourceMap.Add(associationSetEnd.EntitySet, value);
								targetMap.Add(associationSetEnd2.EntitySet, value);
							}
						}
					}
				}
			}
		}

		// Token: 0x06004817 RID: 18455 RVA: 0x000FECD4 File Offset: 0x000FCED4
		private void AddServerGenDependencies()
		{
			global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> dictionary = new global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>();
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand in base.Vertices)
			{
				foreach (int key in updateCommand.OutputIdentifiers)
				{
					try
					{
						dictionary.Add(key, updateCommand);
					}
					catch (global::System.ArgumentException innerException)
					{
						throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_AmbiguousServerGenIdentifier, innerException, updateCommand.GetStateEntries(this._translator).Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
					}
				}
			}
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand2 in base.Vertices)
			{
				foreach (int key2 in updateCommand2.InputIdentifiers)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand from;
					if (dictionary.TryGetValue(key2, out from))
					{
						base.AddEdge(from, updateCommand2);
					}
				}
			}
		}

		// Token: 0x06004818 RID: 18456 RVA: 0x000FEE18 File Offset: 0x000FD018
		private void AddForeignKeyDependencies()
		{
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> predecessors = this.DetermineForeignKeyPredecessors();
			this.AddForeignKeyEdges(predecessors);
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x000FEE34 File Offset: 0x000FD034
		private void AddForeignKeyEdges(global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> predecessors)
		{
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand dynamicUpdateCommand in base.Vertices.OfType<global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand>())
			{
				if (dynamicUpdateCommand.Operator == global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update || global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Insert == dynamicUpdateCommand.Operator)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint metadata in this._sourceMap.EnumerateValues(dynamicUpdateCommand.Table))
					{
						global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue foreignKeyValue;
						global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue x;
						if (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue.TryCreateSourceKey(metadata, dynamicUpdateCommand.CurrentValues, true, out foreignKeyValue) && (dynamicUpdateCommand.Operator != global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update || !global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue.TryCreateSourceKey(metadata, dynamicUpdateCommand.OriginalValues, true, out x) || !this._keyComparer.Equals(x, foreignKeyValue)))
						{
							foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand in predecessors.EnumerateValues(foreignKeyValue))
							{
								if (updateCommand != dynamicUpdateCommand)
								{
									base.AddEdge(updateCommand, dynamicUpdateCommand);
								}
							}
						}
					}
				}
				if (dynamicUpdateCommand.Operator == global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update || global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Delete == dynamicUpdateCommand.Operator)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint metadata2 in this._targetMap.EnumerateValues(dynamicUpdateCommand.Table))
					{
						global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue foreignKeyValue2;
						global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue x2;
						if (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue.TryCreateTargetKey(metadata2, dynamicUpdateCommand.OriginalValues, false, out foreignKeyValue2) && (dynamicUpdateCommand.Operator != global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update || !global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue.TryCreateTargetKey(metadata2, dynamicUpdateCommand.CurrentValues, false, out x2) || !this._keyComparer.Equals(x2, foreignKeyValue2)))
						{
							foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand2 in predecessors.EnumerateValues(foreignKeyValue2))
							{
								if (updateCommand2 != dynamicUpdateCommand)
								{
									base.AddEdge(updateCommand2, dynamicUpdateCommand);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600481A RID: 18458 RVA: 0x000FF084 File Offset: 0x000FD284
		private global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> DetermineForeignKeyPredecessors()
		{
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>(this._keyComparer);
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand dynamicUpdateCommand in base.Vertices.OfType<global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand>())
			{
				if (dynamicUpdateCommand.Operator == global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update || global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Insert == dynamicUpdateCommand.Operator)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint metadata in this._targetMap.EnumerateValues(dynamicUpdateCommand.Table))
					{
						global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue foreignKeyValue;
						global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue x;
						if (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue.TryCreateTargetKey(metadata, dynamicUpdateCommand.CurrentValues, true, out foreignKeyValue) && (dynamicUpdateCommand.Operator != global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update || !global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue.TryCreateTargetKey(metadata, dynamicUpdateCommand.OriginalValues, true, out x) || !this._keyComparer.Equals(x, foreignKeyValue)))
						{
							keyToListMap.Add(foreignKeyValue, dynamicUpdateCommand);
						}
					}
				}
				if (dynamicUpdateCommand.Operator == global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update || global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Delete == dynamicUpdateCommand.Operator)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint metadata2 in this._sourceMap.EnumerateValues(dynamicUpdateCommand.Table))
					{
						global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue foreignKeyValue2;
						global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue x2;
						if (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue.TryCreateSourceKey(metadata2, dynamicUpdateCommand.OriginalValues, false, out foreignKeyValue2) && (dynamicUpdateCommand.Operator != global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update || !global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue.TryCreateSourceKey(metadata2, dynamicUpdateCommand.CurrentValues, false, out x2) || !this._keyComparer.Equals(x2, foreignKeyValue2)))
						{
							keyToListMap.Add(foreignKeyValue2, dynamicUpdateCommand);
						}
					}
				}
			}
			return keyToListMap;
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x000FF238 File Offset: 0x000FD438
		private void AddModelDependencies()
		{
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.EntityKey>.Default);
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> keyToListMap2 = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.EntityKey>.Default);
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> keyToListMap3 = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.EntityKey>.Default);
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> keyToListMap4 = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.EntityKey>.Default);
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand in base.Vertices)
			{
				updateCommand.GetRequiredAndProducedEntities(this._translator, keyToListMap, keyToListMap2, keyToListMap3, keyToListMap4);
			}
			this.AddModelDependencies(keyToListMap, keyToListMap3);
			this.AddModelDependencies(keyToListMap4, keyToListMap2);
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x000FF2D0 File Offset: 0x000FD4D0
		private void AddModelDependencies(global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> producedMap, global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> requiredMap)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.EntityKey, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>> keyValuePair in requiredMap.KeyValuePairs)
			{
				global::System.Data.Entity.Core.EntityKey key = keyValuePair.Key;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> value = keyValuePair.Value;
				foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand in producedMap.EnumerateValues(key))
				{
					foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand2 in value)
					{
						if (updateCommand != updateCommand2 && (updateCommand.Kind == global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandKind.Function || updateCommand2.Kind == global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandKind.Function))
						{
							base.AddEdge(updateCommand, updateCommand2);
						}
					}
				}
			}
		}

		// Token: 0x0400199F RID: 6559
		private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValueComparer _keyComparer;

		// Token: 0x040019A0 RID: 6560
		private readonly global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> _sourceMap;

		// Token: 0x040019A1 RID: 6561
		private readonly global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> _targetMap;

		// Token: 0x040019A2 RID: 6562
		private readonly bool _hasFunctionCommands;

		// Token: 0x040019A3 RID: 6563
		private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator _translator;

		// Token: 0x02000C0F RID: 3087
		private struct ForeignKeyValue
		{
			// Token: 0x06006971 RID: 26993 RVA: 0x001678C8 File Offset: 0x00165AC8
			private ForeignKeyValue(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint metadata, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult record, bool isTarget, bool isInsert)
			{
				this.Metadata = metadata;
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = isTarget ? metadata.FromProperties : metadata.ToProperties;
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[list.Count];
				bool flag = false;
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = record.GetMemberValue(list[i]);
					if (array[i].IsNull)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					this.Key = null;
				}
				else
				{
					this.Key = new global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey(array);
				}
				this.IsInsert = isInsert;
			}

			// Token: 0x06006972 RID: 26994 RVA: 0x00167948 File Offset: 0x00165B48
			internal static bool TryCreateTargetKey(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint metadata, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult record, bool isInsert, out global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue key)
			{
				key = new global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue(metadata, record, true, isInsert);
				return key.Key != null;
			}

			// Token: 0x06006973 RID: 26995 RVA: 0x00167964 File Offset: 0x00165B64
			internal static bool TryCreateSourceKey(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint metadata, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult record, bool isInsert, out global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue key)
			{
				key = new global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue(metadata, record, false, isInsert);
				return key.Key != null;
			}

			// Token: 0x04002FBC RID: 12220
			internal readonly global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint Metadata;

			// Token: 0x04002FBD RID: 12221
			internal readonly global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey Key;

			// Token: 0x04002FBE RID: 12222
			internal readonly bool IsInsert;
		}

		// Token: 0x02000C10 RID: 3088
		private class ForeignKeyValueComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue>
		{
			// Token: 0x06006974 RID: 26996 RVA: 0x00167980 File Offset: 0x00165B80
			internal ForeignKeyValueComparer(global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey> baseComparer)
			{
				this._baseComparer = baseComparer;
			}

			// Token: 0x06006975 RID: 26997 RVA: 0x0016798F File Offset: 0x00165B8F
			public bool Equals(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue x, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue y)
			{
				return x.IsInsert == y.IsInsert && x.Metadata == y.Metadata && this._baseComparer.Equals(x.Key, y.Key);
			}

			// Token: 0x06006976 RID: 26998 RVA: 0x001679C6 File Offset: 0x00165BC6
			public int GetHashCode(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandOrderer.ForeignKeyValue obj)
			{
				return this._baseComparer.GetHashCode(obj.Key);
			}

			// Token: 0x04002FBF RID: 12223
			private readonly global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey> _baseComparer;
		}
	}
}
