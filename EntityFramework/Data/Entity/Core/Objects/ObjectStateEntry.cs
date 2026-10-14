using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Resources;
using System.Diagnostics;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200041F RID: 1055
	public abstract class ObjectStateEntry : global::System.Data.Entity.Core.IEntityStateEntry, global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker
	{
		// Token: 0x060032C4 RID: 12996 RVA: 0x000A1A59 File Offset: 0x0009FC59
		internal ObjectStateEntry()
		{
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x000A1A61 File Offset: 0x0009FC61
		internal ObjectStateEntry(global::System.Data.Entity.Core.Objects.ObjectStateManager cache, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.EntityState state)
		{
			this._cache = cache;
			this._entitySet = entitySet;
			this._state = state;
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x000A1A7E File Offset: 0x0009FC7E
		public global::System.Data.Entity.Core.Objects.ObjectStateManager ObjectStateManager
		{
			get
			{
				this.ValidateState();
				return this._cache;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060032C7 RID: 12999 RVA: 0x000A1A8C File Offset: 0x0009FC8C
		public global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase EntitySet
		{
			get
			{
				this.ValidateState();
				return this._entitySet;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x000A1A9A File Offset: 0x0009FC9A
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x000A1AA2 File Offset: 0x0009FCA2
		public global::System.Data.Entity.EntityState State
		{
			get
			{
				return this._state;
			}
			internal set
			{
				this._state = value;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060032CA RID: 13002
		public abstract object Entity { get; }

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060032CB RID: 13003
		// (set) Token: 0x060032CC RID: 13004
		public abstract global::System.Data.Entity.Core.EntityKey EntityKey { get; internal set; }

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060032CD RID: 13005
		public abstract bool IsRelationship { get; }

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060032CE RID: 13006
		internal abstract global::System.Collections.BitArray ModifiedProperties { get; }

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x060032CF RID: 13007 RVA: 0x000A1AAB File Offset: 0x0009FCAB
		global::System.Collections.BitArray global::System.Data.Entity.Core.IEntityStateEntry.ModifiedProperties
		{
			get
			{
				return this.ModifiedProperties;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060032D0 RID: 13008
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		public abstract global::System.Data.Common.DbDataRecord OriginalValues { get; }

		// Token: 0x060032D1 RID: 13009
		public abstract global::System.Data.Entity.Core.Objects.OriginalValueRecord GetUpdatableOriginalValues();

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060032D2 RID: 13010
		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		public abstract global::System.Data.Entity.Core.Objects.CurrentValueRecord CurrentValues { get; }

		// Token: 0x060032D3 RID: 13011
		public abstract void AcceptChanges();

		// Token: 0x060032D4 RID: 13012
		public abstract void Delete();

		// Token: 0x060032D5 RID: 13013
		public abstract global::System.Collections.Generic.IEnumerable<string> GetModifiedProperties();

		// Token: 0x060032D6 RID: 13014
		public abstract void SetModified();

		// Token: 0x060032D7 RID: 13015
		public abstract void SetModifiedProperty(string propertyName);

		// Token: 0x060032D8 RID: 13016
		public abstract void RejectPropertyChanges(string propertyName);

		// Token: 0x060032D9 RID: 13017
		public abstract bool IsPropertyChanged(string propertyName);

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x060032DA RID: 13018
		public abstract global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager RelationshipManager { get; }

		// Token: 0x060032DB RID: 13019
		public abstract void ChangeState(global::System.Data.Entity.EntityState state);

		// Token: 0x060032DC RID: 13020
		public abstract void ApplyCurrentValues(object currentEntity);

		// Token: 0x060032DD RID: 13021
		public abstract void ApplyOriginalValues(object originalEntity);

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060032DE RID: 13022 RVA: 0x000A1AB3 File Offset: 0x0009FCB3
		global::System.Data.Entity.Core.IEntityStateManager global::System.Data.Entity.Core.IEntityStateEntry.StateManager
		{
			get
			{
				return this.ObjectStateManager;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060032DF RID: 13023 RVA: 0x000A1ABB File Offset: 0x0009FCBB
		bool global::System.Data.Entity.Core.IEntityStateEntry.IsKeyEntry
		{
			get
			{
				return this.IsKeyEntry;
			}
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x000A1AC3 File Offset: 0x0009FCC3
		void global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker.EntityMemberChanging(string entityMemberName)
		{
			this.EntityMemberChanging(entityMemberName);
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x000A1ACC File Offset: 0x0009FCCC
		void global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker.EntityMemberChanged(string entityMemberName)
		{
			this.EntityMemberChanged(entityMemberName);
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x000A1AD5 File Offset: 0x0009FCD5
		void global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker.EntityComplexMemberChanging(string entityMemberName, object complexObject, string complexObjectMemberName)
		{
			this.EntityComplexMemberChanging(entityMemberName, complexObject, complexObjectMemberName);
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x000A1AE0 File Offset: 0x0009FCE0
		void global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker.EntityComplexMemberChanged(string entityMemberName, object complexObject, string complexObjectMemberName)
		{
			this.EntityComplexMemberChanged(entityMemberName, complexObject, complexObjectMemberName);
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060032E4 RID: 13028 RVA: 0x000A1AEB File Offset: 0x0009FCEB
		global::System.Data.Entity.EntityState global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker.EntityState
		{
			get
			{
				return this.State;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060032E5 RID: 13029
		internal abstract bool IsKeyEntry { get; }

		// Token: 0x060032E6 RID: 13030
		internal abstract int GetFieldCount(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata);

		// Token: 0x060032E7 RID: 13031
		internal abstract global::System.Type GetFieldType(int ordinal, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata);

		// Token: 0x060032E8 RID: 13032
		internal abstract string GetCLayerName(int ordinal, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata);

		// Token: 0x060032E9 RID: 13033
		internal abstract int GetOrdinalforCLayerName(string name, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata);

		// Token: 0x060032EA RID: 13034
		internal abstract void RevertDelete();

		// Token: 0x060032EB RID: 13035
		internal abstract void SetModifiedAll();

		// Token: 0x060032EC RID: 13036
		internal abstract void EntityMemberChanging(string entityMemberName);

		// Token: 0x060032ED RID: 13037
		internal abstract void EntityMemberChanged(string entityMemberName);

		// Token: 0x060032EE RID: 13038
		internal abstract void EntityComplexMemberChanging(string entityMemberName, object complexObject, string complexObjectMemberName);

		// Token: 0x060032EF RID: 13039
		internal abstract void EntityComplexMemberChanged(string entityMemberName, object complexObject, string complexObjectMemberName);

		// Token: 0x060032F0 RID: 13040
		internal abstract global::System.Data.Entity.Core.Common.DataRecordInfo GetDataRecordInfo(global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, object userObject);

		// Token: 0x060032F1 RID: 13041 RVA: 0x000A1AF3 File Offset: 0x0009FCF3
		internal virtual void Reset()
		{
			this._cache = null;
			this._entitySet = null;
			this._state = global::System.Data.Entity.EntityState.Detached;
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x000A1B0A File Offset: 0x0009FD0A
		internal void ValidateState()
		{
			if (this._state == global::System.Data.Entity.EntityState.Detached)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateEntry_InvalidState);
			}
		}

		// Token: 0x04001091 RID: 4241
		internal global::System.Data.Entity.Core.Objects.ObjectStateManager _cache;

		// Token: 0x04001092 RID: 4242
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase _entitySet;

		// Token: 0x04001093 RID: 4243
		internal global::System.Data.Entity.EntityState _state;
	}
}
