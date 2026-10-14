using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005D1 RID: 1489
	internal class SourceInterpreter
	{
		// Token: 0x060047EB RID: 18411 RVA: 0x000FDEE0 File Offset: 0x000FC0E0
		private SourceInterpreter(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Entity.Core.Metadata.Edm.EntitySet sourceTable)
		{
			this.m_stateEntries = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry>();
			this.m_translator = translator;
			this.m_sourceTable = sourceTable;
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x000FDF01 File Offset: 0x000FC101
		internal static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.IEntityStateEntry> GetAllStateEntries(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult source, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Entity.Core.Metadata.Edm.EntitySet sourceTable)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.SourceInterpreter sourceInterpreter = new global::System.Data.Entity.Core.Mapping.Update.Internal.SourceInterpreter(translator, sourceTable);
			sourceInterpreter.RetrieveResultMarkup(source);
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.IEntityStateEntry>(sourceInterpreter.m_stateEntries);
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x000FDF1C File Offset: 0x000FC11C
		private void RetrieveResultMarkup(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult source)
		{
			if (source.Identifier != -1)
			{
				do
				{
					if (source.StateEntry != null)
					{
						this.m_stateEntries.Add(source.StateEntry);
						if (source.Identifier != -1)
						{
							global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult;
							if (this.m_translator.KeyManager.TryGetIdentifierOwner(source.Identifier, out propagatorResult) && propagatorResult.StateEntry != null && this.ExtentInScope(propagatorResult.StateEntry.EntitySet))
							{
								this.m_stateEntries.Add(propagatorResult.StateEntry);
							}
							foreach (global::System.Data.Entity.Core.IEntityStateEntry item in this.m_translator.KeyManager.GetDependentStateEntries(source.Identifier))
							{
								this.m_stateEntries.Add(item);
							}
						}
					}
					source = source.Next;
				}
				while (source != null);
				return;
			}
			if (!source.IsSimple && !source.IsNull)
			{
				foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult source2 in source.GetMemberValues())
				{
					this.RetrieveResultMarkup(source2);
				}
			}
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x000FE040 File Offset: 0x000FC240
		private bool ExtentInScope(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
		{
			return extent != null && this.m_translator.ViewLoader.GetAffectedTables(extent, this.m_translator.MetadataWorkspace).Contains(this.m_sourceTable);
		}

		// Token: 0x04001990 RID: 6544
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry> m_stateEntries;

		// Token: 0x04001991 RID: 6545
		private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator m_translator;

		// Token: 0x04001992 RID: 6546
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet m_sourceTable;
	}
}
