using System;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005D0 RID: 1488
	internal class RecordConverter
	{
		// Token: 0x060047E7 RID: 18407 RVA: 0x000FDE4A File Offset: 0x000FC04A
		internal RecordConverter(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator updateTranslator)
		{
			this.m_updateTranslator = updateTranslator;
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x000FDE59 File Offset: 0x000FC059
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ConvertOriginalValuesToPropagatorResult(global::System.Data.Entity.Core.IEntityStateEntry stateEntry, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior modifiedPropertiesBehavior)
		{
			return this.ConvertStateEntryToPropagatorResult(stateEntry, false, modifiedPropertiesBehavior);
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x000FDE64 File Offset: 0x000FC064
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ConvertCurrentValuesToPropagatorResult(global::System.Data.Entity.Core.IEntityStateEntry stateEntry, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior modifiedPropertiesBehavior)
		{
			return this.ConvertStateEntryToPropagatorResult(stateEntry, true, modifiedPropertiesBehavior);
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x000FDE70 File Offset: 0x000FC070
		private global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ConvertStateEntryToPropagatorResult(global::System.Data.Entity.Core.IEntityStateEntry stateEntry, bool useCurrentValues, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior modifiedPropertiesBehavior)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult result;
			try
			{
				global::System.Data.Entity.Core.IExtendedDataRecord extendedDataRecord;
				if (!useCurrentValues)
				{
					extendedDataRecord = (global::System.Data.Entity.Core.IExtendedDataRecord)stateEntry.OriginalValues;
				}
				else
				{
					global::System.Data.Entity.Core.IExtendedDataRecord currentValues = stateEntry.CurrentValues;
					extendedDataRecord = currentValues;
				}
				global::System.Data.Entity.Core.IExtendedDataRecord record = extendedDataRecord;
				bool isModified = false;
				result = global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata.ExtractResultFromRecord(stateEntry, isModified, record, useCurrentValues, this.m_updateTranslator, modifiedPropertiesBehavior);
			}
			catch (global::System.Exception ex)
			{
				if (ex.RequiresContext())
				{
					throw global::System.Data.Entity.Core.EntityUtil.Update(global::System.Data.Entity.Resources.Strings.Update_ErrorLoadingRecord, ex, new global::System.Data.Entity.Core.IEntityStateEntry[]
					{
						stateEntry
					});
				}
				throw;
			}
			return result;
		}

		// Token: 0x0400198F RID: 6543
		private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator m_updateTranslator;
	}
}
