using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002B7 RID: 695
	internal class InternalConfiguration
	{
		// Token: 0x060021DD RID: 8669 RVA: 0x0005E3B8 File Offset: 0x0005C5B8
		public InternalConfiguration(global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain appConfigChain = null, global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain normalResolverChain = null, global::System.Data.Entity.Infrastructure.DependencyResolution.RootDependencyResolver rootResolver = null, global::System.Data.Entity.Infrastructure.DependencyResolution.AppConfigDependencyResolver appConfigResolver = null, global::System.Func<global::System.Data.Entity.Infrastructure.Interception.DbDispatchers> dispatchers = null)
		{
			this._rootResolver = (rootResolver ?? new global::System.Data.Entity.Infrastructure.DependencyResolution.RootDependencyResolver());
			this._resolvers = new global::System.Data.Entity.Infrastructure.DependencyResolution.CompositeResolver<global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain, global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain>(appConfigChain ?? new global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain(), normalResolverChain ?? new global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain());
			this._resolvers.Second.Add(this._rootResolver);
			this._resolvers.First.Add(appConfigResolver ?? new global::System.Data.Entity.Infrastructure.DependencyResolution.AppConfigDependencyResolver(global::System.Data.Entity.Internal.AppConfig.DefaultInstance, this, null));
			global::System.Func<global::System.Data.Entity.Infrastructure.Interception.DbDispatchers> dispatchers2 = dispatchers;
			if (dispatchers == null && (dispatchers2 = global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration.<>c.<>9__4_0) == null)
			{
				dispatchers2 = (global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration.<>c.<>9__4_0 = (() => global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch));
			}
			this._dispatchers = dispatchers2;
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x0005E45D File Offset: 0x0005C65D
		// (set) Token: 0x060021DF RID: 8671 RVA: 0x0005E469 File Offset: 0x0005C669
		public static global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration Instance
		{
			get
			{
				return global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.GetConfiguration();
			}
			set
			{
				global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.SetConfiguration(value);
			}
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x0005E478 File Offset: 0x0005C678
		public virtual void Lock()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor> list = this.DependencyResolver.GetServices<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor>().ToList<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor>();
			list.Each(new global::System.Action<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor>(this._dispatchers().AddInterceptor));
			global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.OnLoaded(this);
			this._isLocked = true;
			this.DependencyResolver.GetServices<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor>().Except(list).Each(new global::System.Action<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor>(this._dispatchers().AddInterceptor));
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0005E4F2 File Offset: 0x0005C6F2
		public void DispatchLoadedInterceptors(global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs loadedEventArgs)
		{
			this._dispatchers().Configuration.Loaded(loadedEventArgs, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext());
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x0005E50F File Offset: 0x0005C70F
		public virtual void AddAppConfigResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
		{
			this._resolvers.First.Add(resolver);
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0005E522 File Offset: 0x0005C722
		public virtual void AddDependencyResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver, bool overrideConfigFile = false)
		{
			(overrideConfigFile ? this._resolvers.First : this._resolvers.Second).Add(resolver);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x0005E545 File Offset: 0x0005C745
		public virtual void AddDefaultResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
		{
			this._rootResolver.AddDefaultResolver(resolver);
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x0005E553 File Offset: 0x0005C753
		public virtual void SetDefaultProviderServices(global::System.Data.Entity.Core.Common.DbProviderServices provider, string invariantName)
		{
			this._rootResolver.SetDefaultProviderServices(provider, invariantName);
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x0005E562 File Offset: 0x0005C762
		public virtual void RegisterSingleton<TService>(TService instance) where TService : class
		{
			this.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<TService>(instance, null), false);
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x0005E572 File Offset: 0x0005C772
		public virtual void RegisterSingleton<TService>(TService instance, object key) where TService : class
		{
			this.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<TService>(instance, key), false);
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x0005E582 File Offset: 0x0005C782
		public virtual void RegisterSingleton<TService>(TService instance, global::System.Func<object, bool> keyPredicate) where TService : class
		{
			this.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<TService>(instance, keyPredicate), false);
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x0005E592 File Offset: 0x0005C792
		public virtual TService GetService<TService>(object key)
		{
			return this._resolvers.GetService(key);
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x0005E5A0 File Offset: 0x0005C7A0
		public virtual global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver DependencyResolver
		{
			get
			{
				return this._resolvers;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060021EB RID: 8683 RVA: 0x0005E5A8 File Offset: 0x0005C7A8
		public virtual global::System.Data.Entity.Infrastructure.DependencyResolution.RootDependencyResolver RootResolver
		{
			get
			{
				return this._rootResolver;
			}
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x0005E5B0 File Offset: 0x0005C7B0
		public virtual void SwitchInRootResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.RootDependencyResolver value)
		{
			global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain resolverChain = new global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain();
			resolverChain.Add(value);
			this._resolvers.Second.Resolvers.Skip(1).Each(new global::System.Action<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolverChain.Add));
			this._rootResolver = value;
			this._resolvers = new global::System.Data.Entity.Infrastructure.DependencyResolution.CompositeResolver<global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain, global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain>(this._resolvers.First, resolverChain);
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x0005E610 File Offset: 0x0005C810
		public virtual global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver ResolverSnapshot
		{
			get
			{
				global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain resolverChain = new global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain();
				this._resolvers.Second.Resolvers.Each(new global::System.Action<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolverChain.Add));
				this._resolvers.First.Resolvers.Each(new global::System.Action<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolverChain.Add));
				return resolverChain;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x0005E668 File Offset: 0x0005C868
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x0005E670 File Offset: 0x0005C870
		public virtual global::System.Data.Entity.DbConfiguration Owner { get; set; }

		// Token: 0x060021F0 RID: 8688 RVA: 0x0005E679 File Offset: 0x0005C879
		public virtual void CheckNotLocked(string memberName)
		{
			if (this._isLocked)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConfigurationLocked(memberName));
			}
		}

		// Token: 0x04000BC7 RID: 3015
		private global::System.Data.Entity.Infrastructure.DependencyResolution.CompositeResolver<global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain, global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain> _resolvers;

		// Token: 0x04000BC8 RID: 3016
		private global::System.Data.Entity.Infrastructure.DependencyResolution.RootDependencyResolver _rootResolver;

		// Token: 0x04000BC9 RID: 3017
		private readonly global::System.Func<global::System.Data.Entity.Infrastructure.Interception.DbDispatchers> _dispatchers;

		// Token: 0x04000BCA RID: 3018
		private bool _isLocked;
	}
}
