using System;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000257 RID: 599
	public class ModelNamespaceConvention : global::System.Data.Entity.ModelConfiguration.Conventions.Convention
	{
		// Token: 0x06001EC9 RID: 7881 RVA: 0x00054ABF File Offset: 0x00052CBF
		internal ModelNamespaceConvention(string modelNamespace)
		{
			this._modelNamespace = modelNamespace;
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00054ACE File Offset: 0x00052CCE
		internal override void ApplyModelConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			base.ApplyModelConfiguration(modelConfiguration);
			modelConfiguration.ModelNamespace = this._modelNamespace;
		}

		// Token: 0x04000B36 RID: 2870
		private readonly string _modelNamespace;
	}
}
