using System;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005C5 RID: 1477
	internal struct ExtractedStateEntry
	{
		// Token: 0x06004789 RID: 18313 RVA: 0x000FC14D File Offset: 0x000FA34D
		internal ExtractedStateEntry(global::System.Data.Entity.EntityState state, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult original, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult current, global::System.Data.Entity.Core.IEntityStateEntry source)
		{
			this.State = state;
			this.Original = original;
			this.Current = current;
			this.Source = source;
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x000FC16C File Offset: 0x000FA36C
		internal ExtractedStateEntry(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Entity.Core.IEntityStateEntry stateEntry)
		{
			this.State = stateEntry.State;
			this.Source = stateEntry;
			global::System.Data.Entity.EntityState state = stateEntry.State;
			if (state <= global::System.Data.Entity.EntityState.Added)
			{
				if (state == global::System.Data.Entity.EntityState.Unchanged)
				{
					this.Original = translator.RecordConverter.ConvertOriginalValuesToPropagatorResult(stateEntry, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.NoneModified);
					this.Current = translator.RecordConverter.ConvertCurrentValuesToPropagatorResult(stateEntry, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.NoneModified);
					return;
				}
				if (state == global::System.Data.Entity.EntityState.Added)
				{
					this.Original = null;
					this.Current = translator.RecordConverter.ConvertCurrentValuesToPropagatorResult(stateEntry, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.AllModified);
					return;
				}
			}
			else
			{
				if (state == global::System.Data.Entity.EntityState.Deleted)
				{
					this.Original = translator.RecordConverter.ConvertOriginalValuesToPropagatorResult(stateEntry, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.AllModified);
					this.Current = null;
					return;
				}
				if (state == global::System.Data.Entity.EntityState.Modified)
				{
					this.Original = translator.RecordConverter.ConvertOriginalValuesToPropagatorResult(stateEntry, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.SomeModified);
					this.Current = translator.RecordConverter.ConvertCurrentValuesToPropagatorResult(stateEntry, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.SomeModified);
					return;
				}
			}
			this.Original = null;
			this.Current = null;
		}

		// Token: 0x04001963 RID: 6499
		internal readonly global::System.Data.Entity.EntityState State;

		// Token: 0x04001964 RID: 6500
		internal readonly global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Original;

		// Token: 0x04001965 RID: 6501
		internal readonly global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Current;

		// Token: 0x04001966 RID: 6502
		internal readonly global::System.Data.Entity.Core.IEntityStateEntry Source;
	}
}
