using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000114 RID: 276
	internal class StateEntryAdapter : global::System.Data.Entity.Internal.IEntityStateEntry
	{
		// Token: 0x06001352 RID: 4946 RVA: 0x000318FA File Offset: 0x0002FAFA
		public StateEntryAdapter(global::System.Data.Entity.Core.Objects.ObjectStateEntry stateEntry)
		{
			this._stateEntry = stateEntry;
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x00031909 File Offset: 0x0002FB09
		public object Entity
		{
			get
			{
				return this._stateEntry.Entity;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x00031916 File Offset: 0x0002FB16
		public global::System.Data.Entity.EntityState State
		{
			get
			{
				return this._stateEntry.State;
			}
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00031923 File Offset: 0x0002FB23
		public void ChangeState(global::System.Data.Entity.EntityState state)
		{
			this._stateEntry.ChangeState(state);
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x00031931 File Offset: 0x0002FB31
		public global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord CurrentValues
		{
			get
			{
				return this._stateEntry.CurrentValues;
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0003193E File Offset: 0x0002FB3E
		public global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord GetUpdatableOriginalValues()
		{
			return this._stateEntry.GetUpdatableOriginalValues();
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x0003194B File Offset: 0x0002FB4B
		public global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase EntitySet
		{
			get
			{
				return this._stateEntry.EntitySet;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x00031958 File Offset: 0x0002FB58
		public global::System.Data.Entity.Core.EntityKey EntityKey
		{
			get
			{
				return this._stateEntry.EntityKey;
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00031965 File Offset: 0x0002FB65
		public global::System.Collections.Generic.IEnumerable<string> GetModifiedProperties()
		{
			return this._stateEntry.GetModifiedProperties();
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00031972 File Offset: 0x0002FB72
		public void SetModifiedProperty(string propertyName)
		{
			this._stateEntry.SetModifiedProperty(propertyName);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00031980 File Offset: 0x0002FB80
		public void RejectPropertyChanges(string propertyName)
		{
			this._stateEntry.RejectPropertyChanges(propertyName);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0003198E File Offset: 0x0002FB8E
		public bool IsPropertyChanged(string propertyName)
		{
			return this._stateEntry.IsPropertyChanged(propertyName);
		}

		// Token: 0x04000950 RID: 2384
		private readonly global::System.Data.Entity.Core.Objects.ObjectStateEntry _stateEntry;
	}
}
