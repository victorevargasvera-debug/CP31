using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005CA RID: 1482
	internal class KeyManager
	{
		// Token: 0x060047AE RID: 18350 RVA: 0x000FD250 File Offset: 0x000FB450
		internal int GetCliqueIdentifier(int identifier)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.Partition partition = this._identifiers[identifier].Partition;
			if (partition != null)
			{
				return partition.PartitionId;
			}
			return identifier;
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x000FD27C File Offset: 0x000FB47C
		internal void AddReferentialConstraint(global::System.Data.Entity.Core.IEntityStateEntry dependentStateEntry, int dependentIdentifier, int principalIdentifier)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.IdentifierInfo identifierInfo = this._identifiers[dependentIdentifier];
			if (dependentIdentifier != principalIdentifier)
			{
				this.AssociateNodes(dependentIdentifier, principalIdentifier);
				global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int>.Add(ref identifierInfo.References, principalIdentifier);
				global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int>.Add(ref this._identifiers[principalIdentifier].ReferencedBy, dependentIdentifier);
			}
			global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<global::System.Data.Entity.Core.IEntityStateEntry>.Add(ref identifierInfo.DependentStateEntries, dependentStateEntry);
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x000FD2D1 File Offset: 0x000FB4D1
		internal void RegisterIdentifierOwner(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult owner)
		{
			this._identifiers[owner.Identifier].Owner = owner;
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x000FD2EA File Offset: 0x000FB4EA
		internal bool TryGetIdentifierOwner(int identifier, out global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult owner)
		{
			owner = this._identifiers[identifier].Owner;
			return owner != null;
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x000FD304 File Offset: 0x000FB504
		internal int GetKeyIdentifierForMemberOffset(global::System.Data.Entity.Core.EntityKey entityKey, int memberOffset, int keyMemberCount)
		{
			int num;
			if (!this._keyIdentifiers.TryGetValue(entityKey, out num))
			{
				num = this._identifiers.Count;
				for (int i = 0; i < keyMemberCount; i++)
				{
					this._identifiers.Add(new global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.IdentifierInfo());
				}
				this._keyIdentifiers.Add(entityKey, num);
			}
			num += memberOffset;
			return num;
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x000FD35C File Offset: 0x000FB55C
		internal int GetKeyIdentifierForMember(global::System.Data.Entity.Core.EntityKey entityKey, string member, bool currentValues)
		{
			global::System.Tuple<global::System.Data.Entity.Core.EntityKey, string, bool> key = global::System.Tuple.Create<global::System.Data.Entity.Core.EntityKey, string, bool>(entityKey, member, currentValues);
			int count;
			if (!this._foreignKeyIdentifiers.TryGetValue(key, out count))
			{
				count = this._identifiers.Count;
				this._identifiers.Add(new global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.IdentifierInfo());
				this._foreignKeyIdentifiers.Add(key, count);
			}
			return count;
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x000FD3AC File Offset: 0x000FB5AC
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.IEntityStateEntry> GetDependentStateEntries(int identifier)
		{
			return global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<global::System.Data.Entity.Core.IEntityStateEntry>.Enumerate(this._identifiers[identifier].DependentStateEntries);
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x000FD3C4 File Offset: 0x000FB5C4
		internal object GetPrincipalValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult result)
		{
			int identifier = result.Identifier;
			if (-1 == identifier)
			{
				return result.GetSimpleValue();
			}
			bool flag = true;
			object obj = null;
			foreach (int index in this.GetPrincipals(identifier))
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult owner = this._identifiers[index].Owner;
				if (owner != null)
				{
					if (flag)
					{
						obj = owner.GetSimpleValue();
						flag = false;
					}
					else if (!global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(obj, owner.GetSimpleValue()))
					{
						throw new global::System.Data.ConstraintException(global::System.Data.Entity.Resources.Strings.Update_ReferentialConstraintIntegrityViolation);
					}
				}
			}
			if (flag)
			{
				obj = result.GetSimpleValue();
			}
			return obj;
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x000FD474 File Offset: 0x000FB674
		internal global::System.Collections.Generic.IEnumerable<int> GetPrincipals(int identifier)
		{
			return this.WalkGraph(identifier, (global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.IdentifierInfo info) => info.References, true);
		}

		// Token: 0x060047B7 RID: 18359 RVA: 0x000FD49D File Offset: 0x000FB69D
		internal global::System.Collections.Generic.IEnumerable<int> GetDirectReferences(int identifier)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int> references = this._identifiers[identifier].References;
			foreach (int num in global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int>.Enumerate(references))
			{
				yield return num;
			}
			global::System.Collections.Generic.IEnumerator<int> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x000FD4B4 File Offset: 0x000FB6B4
		internal global::System.Collections.Generic.IEnumerable<int> GetDependents(int identifier)
		{
			return this.WalkGraph(identifier, (global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.IdentifierInfo info) => info.ReferencedBy, false);
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x000FD4DD File Offset: 0x000FB6DD
		private global::System.Collections.Generic.IEnumerable<int> WalkGraph(int identifier, global::System.Func<global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.IdentifierInfo, global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int>> successorFunction, bool leavesOnly)
		{
			global::System.Collections.Generic.Stack<int> stack = new global::System.Collections.Generic.Stack<int>();
			stack.Push(identifier);
			while (stack.Count > 0)
			{
				int num = stack.Pop();
				global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int> linkedList = successorFunction(this._identifiers[num]);
				if (linkedList != null)
				{
					foreach (int item in global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int>.Enumerate(linkedList))
					{
						stack.Push(item);
					}
					if (!leavesOnly)
					{
						yield return num;
					}
				}
				else
				{
					yield return num;
				}
			}
			yield break;
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x000FD502 File Offset: 0x000FB702
		internal bool HasPrincipals(int identifier)
		{
			return this._identifiers[identifier].References != null;
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x000FD518 File Offset: 0x000FB718
		internal void ValidateReferentialIntegrityGraphAcyclic()
		{
			byte[] array = new byte[this._identifiers.Count];
			int i = 0;
			int count = this._identifiers.Count;
			while (i < count)
			{
				if (array[i] == 0)
				{
					this.ValidateReferentialIntegrityGraphAcyclic(i, array, null);
				}
				i++;
			}
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x000FD55C File Offset: 0x000FB75C
		internal void RegisterKeyValueForAddedEntity(global::System.Data.Entity.Core.IEntityStateEntry addedEntry)
		{
			global::System.Data.Entity.Core.EntityKey entityKey = addedEntry.EntityKey;
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers = addedEntry.EntitySet.ElementType.KeyMembers;
			global::System.Data.Entity.Core.Objects.CurrentValueRecord currentValues = addedEntry.CurrentValues;
			object[] array = new object[keyMembers.Count];
			bool flag = false;
			int i = 0;
			int count = keyMembers.Count;
			while (i < count)
			{
				int ordinal = currentValues.GetOrdinal(keyMembers[i].Name);
				if (currentValues.IsDBNull(ordinal))
				{
					flag = true;
					break;
				}
				array[i] = currentValues.GetValue(ordinal);
				i++;
			}
			if (flag)
			{
				return;
			}
			global::System.Data.Entity.Core.EntityKey key = (array.Length == 1) ? new global::System.Data.Entity.Core.EntityKey(addedEntry.EntitySet, array[0]) : new global::System.Data.Entity.Core.EntityKey(addedEntry.EntitySet, array);
			if (this._valueKeyToTempKey.ContainsKey(key))
			{
				this._valueKeyToTempKey[key] = null;
				return;
			}
			this._valueKeyToTempKey.Add(key, entityKey);
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x000FD636 File Offset: 0x000FB836
		internal bool TryGetTempKey(global::System.Data.Entity.Core.EntityKey valueKey, out global::System.Data.Entity.Core.EntityKey tempKey)
		{
			return this._valueKeyToTempKey.TryGetValue(valueKey, out tempKey);
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x000FD648 File Offset: 0x000FB848
		private void ValidateReferentialIntegrityGraphAcyclic(int node, byte[] color, global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int> parent)
		{
			color[node] = 2;
			global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int>.Add(ref parent, node);
			foreach (int num in global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int>.Enumerate(this._identifiers[node].References))
			{
				byte b = color[num];
				if (b != 0)
				{
					if (b == 2)
					{
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry>();
						foreach (int num2 in global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int>.Enumerate(parent))
						{
							global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult owner = this._identifiers[num2].Owner;
							if (owner != null)
							{
								list.Add(owner.StateEntry);
							}
							if (num2 == num)
							{
								break;
							}
						}
						throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_CircularRelationships, null, list.Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
					}
				}
				else
				{
					this.ValidateReferentialIntegrityGraphAcyclic(num, color, parent);
				}
			}
			color[node] = 1;
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x000FD754 File Offset: 0x000FB954
		internal void AssociateNodes(int firstId, int secondId)
		{
			if (firstId == secondId)
			{
				return;
			}
			global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.Partition partition = this._identifiers[firstId].Partition;
			if (partition != null)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.Partition partition2 = this._identifiers[secondId].Partition;
				if (partition2 != null)
				{
					partition.Merge(this, partition2);
					return;
				}
				partition.AddNode(this, secondId);
				return;
			}
			else
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.Partition partition3 = this._identifiers[secondId].Partition;
				if (partition3 != null)
				{
					partition3.AddNode(this, firstId);
					return;
				}
				global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.Partition.CreatePartition(this, firstId, secondId);
				return;
			}
		}

		// Token: 0x04001974 RID: 6516
		private readonly global::System.Collections.Generic.Dictionary<global::System.Tuple<global::System.Data.Entity.Core.EntityKey, string, bool>, int> _foreignKeyIdentifiers = new global::System.Collections.Generic.Dictionary<global::System.Tuple<global::System.Data.Entity.Core.EntityKey, string, bool>, int>();

		// Token: 0x04001975 RID: 6517
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.EntityKey> _valueKeyToTempKey = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.EntityKey>();

		// Token: 0x04001976 RID: 6518
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, int> _keyIdentifiers = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, int>();

		// Token: 0x04001977 RID: 6519
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.IdentifierInfo> _identifiers = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.IdentifierInfo>
		{
			new global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.IdentifierInfo()
		};

		// Token: 0x04001978 RID: 6520
		private const byte White = 0;

		// Token: 0x04001979 RID: 6521
		private const byte Black = 1;

		// Token: 0x0400197A RID: 6522
		private const byte Gray = 2;

		// Token: 0x02000BFF RID: 3071
		private sealed class Partition
		{
			// Token: 0x060068FC RID: 26876 RVA: 0x00165CDB File Offset: 0x00163EDB
			private Partition(int partitionId)
			{
				this._nodeIds = new global::System.Collections.Generic.List<int>(2);
				this.PartitionId = partitionId;
			}

			// Token: 0x060068FD RID: 26877 RVA: 0x00165CF6 File Offset: 0x00163EF6
			internal static void CreatePartition(global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager manager, int firstId, int secondId)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.Partition partition = new global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.Partition(firstId);
				partition.AddNode(manager, firstId);
				partition.AddNode(manager, secondId);
			}

			// Token: 0x060068FE RID: 26878 RVA: 0x00165D0D File Offset: 0x00163F0D
			internal void AddNode(global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager manager, int nodeId)
			{
				this._nodeIds.Add(nodeId);
				manager._identifiers[nodeId].Partition = this;
			}

			// Token: 0x060068FF RID: 26879 RVA: 0x00165D30 File Offset: 0x00163F30
			internal void Merge(global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager manager, global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.Partition other)
			{
				if (other.PartitionId == this.PartitionId)
				{
					return;
				}
				foreach (int nodeId in other._nodeIds)
				{
					this.AddNode(manager, nodeId);
				}
			}

			// Token: 0x04002F81 RID: 12161
			internal readonly int PartitionId;

			// Token: 0x04002F82 RID: 12162
			private readonly global::System.Collections.Generic.List<int> _nodeIds;
		}

		// Token: 0x02000C00 RID: 3072
		private sealed class LinkedList<T>
		{
			// Token: 0x06006900 RID: 26880 RVA: 0x00165D94 File Offset: 0x00163F94
			private LinkedList(T value, global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<T> previous)
			{
				this._value = value;
				this._previous = previous;
			}

			// Token: 0x06006901 RID: 26881 RVA: 0x00165DAA File Offset: 0x00163FAA
			internal static global::System.Collections.Generic.IEnumerable<T> Enumerate(global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<T> current)
			{
				while (current != null)
				{
					yield return current._value;
					current = current._previous;
				}
				yield break;
			}

			// Token: 0x06006902 RID: 26882 RVA: 0x00165DBA File Offset: 0x00163FBA
			internal static void Add(ref global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<T> list, T value)
			{
				list = new global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<T>(value, list);
			}

			// Token: 0x04002F83 RID: 12163
			private readonly T _value;

			// Token: 0x04002F84 RID: 12164
			private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<T> _previous;
		}

		// Token: 0x02000C01 RID: 3073
		private sealed class IdentifierInfo
		{
			// Token: 0x04002F85 RID: 12165
			internal global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.Partition Partition;

			// Token: 0x04002F86 RID: 12166
			internal global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Owner;

			// Token: 0x04002F87 RID: 12167
			internal global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<global::System.Data.Entity.Core.IEntityStateEntry> DependentStateEntries;

			// Token: 0x04002F88 RID: 12168
			internal global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int> References;

			// Token: 0x04002F89 RID: 12169
			internal global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager.LinkedList<int> ReferencedBy;
		}
	}
}
