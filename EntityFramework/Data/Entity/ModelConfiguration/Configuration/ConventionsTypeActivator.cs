using System;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001C6 RID: 454
	internal class ConventionsTypeActivator
	{
		// Token: 0x0600180D RID: 6157 RVA: 0x000407FF File Offset: 0x0003E9FF
		public virtual global::System.Data.Entity.ModelConfiguration.Conventions.IConvention Activate(global::System.Type conventionType)
		{
			return (global::System.Data.Entity.ModelConfiguration.Conventions.IConvention)global::System.Activator.CreateInstance(conventionType, true);
		}
	}
}
