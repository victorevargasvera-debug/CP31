using System;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.MappingViews
{
	// Token: 0x02000271 RID: 625
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class DbMappingViewCacheTypeAttribute : global::System.Attribute
	{
		// Token: 0x06001F83 RID: 8067 RVA: 0x00058F14 File Offset: 0x00057114
		public DbMappingViewCacheTypeAttribute(global::System.Type contextType, global::System.Type cacheType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(contextType, "contextType");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(cacheType, "cacheType");
			if (!contextType.IsSubclassOf(typeof(global::System.Data.Entity.Core.Objects.ObjectContext)) && !contextType.IsSubclassOf(typeof(global::System.Data.Entity.DbContext)))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbMappingViewCacheTypeAttribute_InvalidContextType(contextType), "contextType");
			}
			if (!cacheType.IsSubclassOf(typeof(global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCache)))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Generated_View_Type_Super_Class(cacheType), "cacheType");
			}
			this._contextType = contextType;
			this._cacheType = cacheType;
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x00058FA8 File Offset: 0x000571A8
		public DbMappingViewCacheTypeAttribute(global::System.Type contextType, string cacheTypeName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(contextType, "contextType");
			global::System.Data.Entity.Utilities.Check.NotEmpty(cacheTypeName, "cacheTypeName");
			if (!contextType.IsSubclassOf(typeof(global::System.Data.Entity.Core.Objects.ObjectContext)) && !contextType.IsSubclassOf(typeof(global::System.Data.Entity.DbContext)))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbMappingViewCacheTypeAttribute_InvalidContextType(contextType), "contextType");
			}
			this._contextType = contextType;
			try
			{
				this._cacheType = global::System.Type.GetType(cacheTypeName, true);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbMappingViewCacheTypeAttribute_CacheTypeNotFound(cacheTypeName), "cacheTypeName", innerException);
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x00059044 File Offset: 0x00057244
		internal global::System.Type ContextType
		{
			get
			{
				return this._contextType;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x0005904C File Offset: 0x0005724C
		internal global::System.Type CacheType
		{
			get
			{
				return this._cacheType;
			}
		}

		// Token: 0x04000B68 RID: 2920
		private readonly global::System.Type _contextType;

		// Token: 0x04000B69 RID: 2921
		private readonly global::System.Type _cacheType;
	}
}
