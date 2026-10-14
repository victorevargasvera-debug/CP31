using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000103 RID: 259
	internal interface IEntityStateEntry
	{
		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001290 RID: 4752
		object Entity { get; }

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001291 RID: 4753
		global::System.Data.Entity.EntityState State { get; }

		// Token: 0x06001292 RID: 4754
		void ChangeState(global::System.Data.Entity.EntityState state);

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001293 RID: 4755
		global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord CurrentValues { get; }

		// Token: 0x06001294 RID: 4756
		global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord GetUpdatableOriginalValues();

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001295 RID: 4757
		global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase EntitySet { get; }

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001296 RID: 4758
		global::System.Data.Entity.Core.EntityKey EntityKey { get; }

		// Token: 0x06001297 RID: 4759
		global::System.Collections.Generic.IEnumerable<string> GetModifiedProperties();

		// Token: 0x06001298 RID: 4760
		void SetModifiedProperty(string propertyName);

		// Token: 0x06001299 RID: 4761
		bool IsPropertyChanged(string propertyName);

		// Token: 0x0600129A RID: 4762
		void RejectPropertyChanges(string propertyName);
	}
}
