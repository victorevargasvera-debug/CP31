using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000256 RID: 598
	public class ModelContainerConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x06001EC7 RID: 7879 RVA: 0x00054A96 File Offset: 0x00052C96
		internal ModelContainerConvention(string containerName)
		{
			this._containerName = containerName;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00054AA5 File Offset: 0x00052CA5
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			item.Name = this._containerName;
		}

		// Token: 0x04000B35 RID: 2869
		private readonly string _containerName;
	}
}
