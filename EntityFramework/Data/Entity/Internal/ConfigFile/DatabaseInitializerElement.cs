using System;
using System.Configuration;

namespace System.Data.Entity.Internal.ConfigFile
{
	// Token: 0x0200014B RID: 331
	internal class DatabaseInitializerElement : global::System.Configuration.ConfigurationElement
	{
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00037453 File Offset: 0x00035653
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x00037465 File Offset: 0x00035665
		[global::System.Configuration.ConfigurationProperty("type", IsRequired = true)]
		public virtual string InitializerTypeName
		{
			get
			{
				return (string)base["type"];
			}
			set
			{
				base["type"] = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x00037473 File Offset: 0x00035673
		[global::System.Configuration.ConfigurationProperty("parameters")]
		public virtual global::System.Data.Entity.Internal.ConfigFile.ParameterCollection Parameters
		{
			get
			{
				return (global::System.Data.Entity.Internal.ConfigFile.ParameterCollection)base["parameters"];
			}
		}

		// Token: 0x040009DA RID: 2522
		private const string TypeKey = "type";

		// Token: 0x040009DB RID: 2523
		private const string ParametersKey = "parameters";
	}
}
