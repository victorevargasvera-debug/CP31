using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005D5 RID: 1493
	internal abstract class UpdateCommand : global::System.IComparable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>, global::System.IEquatable<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>
	{
		// Token: 0x06004800 RID: 18432 RVA: 0x000FE757 File Offset: 0x000FC957
		protected UpdateCommand(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult originalValues, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult currentValues)
		{
			this.OriginalValues = originalValues;
			this.CurrentValues = currentValues;
			this.Translator = translator;
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06004801 RID: 18433
		internal abstract global::System.Collections.Generic.IEnumerable<int> OutputIdentifiers { get; }

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06004802 RID: 18434
		internal abstract global::System.Collections.Generic.IEnumerable<int> InputIdentifiers { get; }

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x000FE774 File Offset: 0x000FC974
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.EntitySet Table
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06004804 RID: 18436
		internal abstract global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandKind Kind { get; }

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x000FE777 File Offset: 0x000FC977
		// (set) Token: 0x06004806 RID: 18438 RVA: 0x000FE77F File Offset: 0x000FC97F
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult OriginalValues { get; private set; }

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06004807 RID: 18439 RVA: 0x000FE788 File Offset: 0x000FC988
		// (set) Token: 0x06004808 RID: 18440 RVA: 0x000FE790 File Offset: 0x000FC990
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CurrentValues { get; private set; }

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06004809 RID: 18441 RVA: 0x000FE799 File Offset: 0x000FC999
		// (set) Token: 0x0600480A RID: 18442 RVA: 0x000FE7A1 File Offset: 0x000FC9A1
		private protected global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator Translator { protected get; private set; }

		// Token: 0x0600480B RID: 18443
		internal abstract global::System.Collections.Generic.IList<global::System.Data.Entity.Core.IEntityStateEntry> GetStateEntries(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator);

		// Token: 0x0600480C RID: 18444 RVA: 0x000FE7AC File Offset: 0x000FC9AC
		internal void GetRequiredAndProducedEntities(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> addedEntities, global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> deletedEntities, global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> addedRelationships, global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> deletedRelationships)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.IEntityStateEntry> stateEntries = this.GetStateEntries(translator);
			foreach (global::System.Data.Entity.Core.IEntityStateEntry entityStateEntry in stateEntries)
			{
				if (!entityStateEntry.IsRelationship)
				{
					if (entityStateEntry.State == global::System.Data.Entity.EntityState.Added)
					{
						addedEntities.Add(entityStateEntry.EntityKey, this);
					}
					else if (entityStateEntry.State == global::System.Data.Entity.EntityState.Deleted)
					{
						deletedEntities.Add(entityStateEntry.EntityKey, this);
					}
				}
			}
			if (this.OriginalValues != null)
			{
				this.AddReferencedEntities(translator, this.OriginalValues, deletedRelationships);
			}
			if (this.CurrentValues != null)
			{
				this.AddReferencedEntities(translator, this.CurrentValues, addedRelationships);
			}
			foreach (global::System.Data.Entity.Core.IEntityStateEntry entityStateEntry2 in stateEntries)
			{
				if (entityStateEntry2.IsRelationship)
				{
					bool flag = entityStateEntry2.State == global::System.Data.Entity.EntityState.Added;
					if (flag || entityStateEntry2.State == global::System.Data.Entity.EntityState.Deleted)
					{
						global::System.Data.Entity.Core.Objects.CurrentValueRecord currentValueRecord = flag ? entityStateEntry2.CurrentValues : entityStateEntry2.OriginalValues;
						global::System.Data.Entity.Core.EntityKey key = (global::System.Data.Entity.Core.EntityKey)currentValueRecord[0];
						global::System.Data.Entity.Core.EntityKey key2 = (global::System.Data.Entity.Core.EntityKey)currentValueRecord[1];
						global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> keyToListMap = flag ? addedRelationships : deletedRelationships;
						keyToListMap.Add(key, this);
						keyToListMap.Add(key2, this);
					}
				}
			}
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x000FE8F4 File Offset: 0x000FCAF4
		private void AddReferencedEntities(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult result, global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> referencedEntities)
		{
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult in result.GetMemberValues())
			{
				if (propagatorResult.IsSimple && propagatorResult.Identifier != -1 && global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.ForeignKey == (propagatorResult.PropagatorFlags & global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.ForeignKey))
				{
					foreach (int identifier in translator.KeyManager.GetDirectReferences(propagatorResult.Identifier))
					{
						global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult2;
						if (translator.KeyManager.TryGetIdentifierOwner(identifier, out propagatorResult2) && propagatorResult2.StateEntry != null)
						{
							referencedEntities.Add(propagatorResult2.StateEntry.EntityKey, this);
						}
					}
				}
			}
		}

		// Token: 0x0600480E RID: 18446
		internal abstract long Execute(global::System.Collections.Generic.Dictionary<int, object> identifierValues, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>> generatedValues);

		// Token: 0x0600480F RID: 18447
		internal abstract global::System.Threading.Tasks.Task<long> ExecuteAsync(global::System.Collections.Generic.Dictionary<int, object> identifierValues, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>> generatedValues, global::System.Threading.CancellationToken cancellationToken);

		// Token: 0x06004810 RID: 18448
		internal abstract int CompareToType(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand other);

		// Token: 0x06004811 RID: 18449 RVA: 0x000FE9B0 File Offset: 0x000FCBB0
		public int CompareTo(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand other)
		{
			if (this.Equals(other))
			{
				return 0;
			}
			int num = this.Kind - other.Kind;
			if (num != 0)
			{
				return num;
			}
			num = this.CompareToType(other);
			if (num != 0)
			{
				return num;
			}
			if (this._orderingIdentifier == 0)
			{
				this._orderingIdentifier = global::System.Threading.Interlocked.Increment(ref global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand.OrderingIdentifierCounter);
			}
			if (other._orderingIdentifier == 0)
			{
				other._orderingIdentifier = global::System.Threading.Interlocked.Increment(ref global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand.OrderingIdentifierCounter);
			}
			return this._orderingIdentifier - other._orderingIdentifier;
		}

		// Token: 0x06004812 RID: 18450 RVA: 0x000FEA25 File Offset: 0x000FCC25
		public bool Equals(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand other)
		{
			return base.Equals(other);
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x000FEA2E File Offset: 0x000FCC2E
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x000FEA37 File Offset: 0x000FCC37
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0400199A RID: 6554
		private static int OrderingIdentifierCounter;

		// Token: 0x0400199B RID: 6555
		private int _orderingIdentifier;
	}
}
