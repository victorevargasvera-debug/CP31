using System;
using System.ComponentModel;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002AD RID: 685
	public class DbConfigurationLoadedEventArgs : global::System.EventArgs
	{
		// Token: 0x060021A8 RID: 8616 RVA: 0x0005D82B File Offset: 0x0005BA2B
		internal DbConfigurationLoadedEventArgs(global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration configuration)
		{
			this._internalConfiguration = configuration;
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x0005D83A File Offset: 0x0005BA3A
		public global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver DependencyResolver
		{
			get
			{
				return this._internalConfiguration.ResolverSnapshot;
			}
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x0005D847 File Offset: 0x0005BA47
		public void AddDependencyResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver, bool overrideConfigFile)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, "resolver");
			this._internalConfiguration.CheckNotLocked("AddDependencyResolver");
			this._internalConfiguration.AddDependencyResolver(resolver, overrideConfigFile);
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0005D872 File Offset: 0x0005BA72
		public void AddDefaultResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, "resolver");
			this._internalConfiguration.CheckNotLocked("AddDefaultResolver");
			this._internalConfiguration.AddDefaultResolver(resolver);
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0005D89C File Offset: 0x0005BA9C
		public void ReplaceService<TService>(global::System.Func<TService, object, TService> serviceInterceptor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TService, object, TService>>(serviceInterceptor, "serviceInterceptor");
			this.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.WrappingDependencyResolver<TService>(this.DependencyResolver, serviceInterceptor), true);
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x0005D8BD File Offset: 0x0005BABD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x0005D8C5 File Offset: 0x0005BAC5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x0005D8CE File Offset: 0x0005BACE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x0005D8D6 File Offset: 0x0005BAD6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000BB9 RID: 3001
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration _internalConfiguration;
	}
}
