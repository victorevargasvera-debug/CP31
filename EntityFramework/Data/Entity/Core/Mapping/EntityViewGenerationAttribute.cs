using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000531 RID: 1329
	[global::System.Obsolete("The mechanism to provide pre-generated views has changed. Implement a class that derives from System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCache and has a parameterless constructor, then associate it with a type that derives from DbContext or ObjectContext by using System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCacheTypeAttribute.", true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class EntityViewGenerationAttribute : global::System.Attribute
	{
		// Token: 0x060041B3 RID: 16819 RVA: 0x000DCF2F File Offset: 0x000DB12F
		public EntityViewGenerationAttribute(global::System.Type viewGenerationType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(viewGenerationType, "viewGenerationType");
			this.m_viewGenType = viewGenerationType;
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060041B4 RID: 16820 RVA: 0x000DCF4A File Offset: 0x000DB14A
		public global::System.Type ViewGenerationType
		{
			get
			{
				return this.m_viewGenType;
			}
		}

		// Token: 0x040016C5 RID: 5829
		private readonly global::System.Type m_viewGenType;
	}
}
