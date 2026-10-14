using System;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000125 RID: 293
	internal class ModelCompatibilityChecker
	{
		// Token: 0x06001482 RID: 5250 RVA: 0x00034774 File Offset: 0x00032974
		public virtual bool CompatibleWithModel(global::System.Data.Entity.Internal.InternalContext internalContext, global::System.Data.Entity.Internal.ModelHashCalculator modelHashCalculator, bool throwIfNoMetadata, global::System.Data.Entity.Internal.DatabaseExistenceState existenceState = global::System.Data.Entity.Internal.DatabaseExistenceState.Unknown)
		{
			if (internalContext.CodeFirstModel == null)
			{
				if (throwIfNoMetadata)
				{
					throw global::System.Data.Entity.Resources.Error.Database_NonCodeFirstCompatibilityCheck();
				}
				return true;
			}
			else
			{
				global::System.Data.Entity.Migrations.Infrastructure.VersionedModel versionedModel = internalContext.QueryForModel(existenceState);
				if (versionedModel != null)
				{
					return internalContext.ModelMatches(versionedModel);
				}
				string text = internalContext.QueryForModelHash();
				if (text != null)
				{
					return string.Equals(text, modelHashCalculator.Calculate(internalContext.CodeFirstModel), global::System.StringComparison.Ordinal);
				}
				if (throwIfNoMetadata)
				{
					throw global::System.Data.Entity.Resources.Error.Database_NoDatabaseMetadata();
				}
				return true;
			}
		}
	}
}
