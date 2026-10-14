using System;
using System.Configuration;

namespace System.Data.Entity.Internal.ConfigFile
{
	// Token: 0x0200014C RID: 332
	internal class DefaultConnectionFactoryElement : global::System.Configuration.ConfigurationElement
	{
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x0003748D File Offset: 0x0003568D
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x0003749F File Offset: 0x0003569F
		[global::System.Configuration.ConfigurationProperty("type", IsRequired = true)]
		public string FactoryTypeName
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

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x000374AD File Offset: 0x000356AD
		[global::System.Configuration.ConfigurationProperty("parameters")]
		public global::System.Data.Entity.Internal.ConfigFile.ParameterCollection Parameters
		{
			get
			{
				return (global::System.Data.Entity.Internal.ConfigFile.ParameterCollection)base["parameters"];
			}
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x000374BF File Offset: 0x000356BF
		public global::System.Type GetFactoryType()
		{
			return global::System.Type.GetType(this.FactoryTypeName, true);
		}

		// Token: 0x040009DC RID: 2524
		private const string TypeKey = "type";

		// Token: 0x040009DD RID: 2525
		private const string ParametersKey = "parameters";
	}
}
