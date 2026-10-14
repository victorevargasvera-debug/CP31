using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Types;

namespace System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation
{
	// Token: 0x02000208 RID: 520
	internal abstract class ConstraintConfiguration
	{
		// Token: 0x06001B8E RID: 7054
		internal abstract global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration Clone();

		// Token: 0x06001B8F RID: 7055
		internal abstract void Configure(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember dependentEnd, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration);

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0004B109 File Offset: 0x00049309
		public virtual bool IsFullySpecified
		{
			get
			{
				return true;
			}
		}
	}
}
