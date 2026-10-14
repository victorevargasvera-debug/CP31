using System;
using System.Data.Entity.Internal;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000252 RID: 594
	[global::System.Obsolete("The IncludeMetadataConvention is no longer used. EdmMetadata is not included in the model. <see cref=\"EdmModelDiffer\" /> is now used to detect changes in the model.")]
	public class IncludeMetadataConvention : global::System.Data.Entity.ModelConfiguration.Conventions.Convention
	{
		// Token: 0x06001EBE RID: 7870 RVA: 0x00054986 File Offset: 0x00052B86
		internal virtual void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration>(modelConfiguration, "modelConfiguration");
			global::System.Data.Entity.Internal.EdmMetadataContext.ConfigureEdmMetadata(modelConfiguration);
		}
	}
}
