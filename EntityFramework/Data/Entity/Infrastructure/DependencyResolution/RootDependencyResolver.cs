using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Data.Entity.Internal;
using System.Data.Entity.Migrations.History;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Linq;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002BC RID: 700
	internal class RootDependencyResolver : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x06002202 RID: 8706 RVA: 0x0005E953 File Offset: 0x0005CB53
		public RootDependencyResolver() : this(new global::System.Data.Entity.Infrastructure.DependencyResolution.DefaultProviderServicesResolver(), new global::System.Data.Entity.Infrastructure.DependencyResolution.DatabaseInitializerResolver())
		{
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x0005E968 File Offset: 0x0005CB68
		public RootDependencyResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.DefaultProviderServicesResolver defaultProviderServicesResolver, global::System.Data.Entity.Infrastructure.DependencyResolution.DatabaseInitializerResolver databaseInitializerResolver)
		{
			this._databaseInitializerResolver = databaseInitializerResolver;
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.TransactionContextInitializerResolver());
			this._resolvers.Add(this._databaseInitializerResolver);
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.DefaultExecutionStrategyResolver());
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.CachingDependencyResolver(defaultProviderServicesResolver));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.CachingDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.DefaultProviderFactoryResolver()));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.CachingDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.DefaultInvariantNameResolver()));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Data.Entity.Infrastructure.IDbConnectionFactory>(new global::System.Data.Entity.Infrastructure.LocalDbConnectionFactory()));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.Infrastructure.IDbModelCacheKey>>(new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.Infrastructure.IDbModelCacheKey>(new global::System.Data.Entity.Internal.DefaultModelCacheKeyFactory().Create)));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Data.Entity.Infrastructure.IManifestTokenResolver>(new global::System.Data.Entity.Infrastructure.DefaultManifestTokenResolver()));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext>>(global::System.Data.Entity.Migrations.History.HistoryContext.DefaultFactory));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Data.Entity.Infrastructure.Pluralization.IPluralizationService>(new global::System.Data.Entity.Infrastructure.Pluralization.EnglishPluralizationService()));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider>(new global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider()));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Func<global::System.Data.Entity.DbContext, global::System.Action<string>, global::System.Data.Entity.Infrastructure.Interception.DatabaseLogFormatter>>((global::System.Data.Entity.DbContext c, global::System.Action<string> w) => new global::System.Data.Entity.Infrastructure.Interception.DatabaseLogFormatter(c, w)));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler>>(() => new global::System.Data.Entity.Infrastructure.DefaultTransactionHandler(), (object k) => k is global::System.Data.Entity.Infrastructure.ExecutionStrategyKey));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Data.Entity.Infrastructure.IDbProviderFactoryResolver>(new global::System.Data.Entity.Infrastructure.DefaultDbProviderFactoryResolver()));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Func<global::System.Data.Entity.Infrastructure.IMetadataAnnotationSerializer>>(() => new global::System.Data.Entity.Infrastructure.DependencyResolution.ClrTypeAnnotationSerializer(), "ClrType"));
			this._resolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Func<global::System.Data.Entity.Infrastructure.IMetadataAnnotationSerializer>>(() => new global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer(), "Index"));
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x0005EB92 File Offset: 0x0005CD92
		public global::System.Data.Entity.Infrastructure.DependencyResolution.DatabaseInitializerResolver DatabaseInitializerResolver
		{
			get
			{
				return this._databaseInitializerResolver;
			}
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x0005EB9A File Offset: 0x0005CD9A
		public virtual object GetService(global::System.Type type, object key)
		{
			object result;
			if ((result = this._defaultResolvers.GetService(type, key)) == null)
			{
				result = (this._defaultProviderResolvers.GetService(type, key) ?? this._resolvers.GetService(type, key));
			}
			return result;
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x0005EBCB File Offset: 0x0005CDCB
		public virtual void AddDefaultResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
		{
			this._defaultResolvers.Add(resolver);
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x0005EBD9 File Offset: 0x0005CDD9
		public virtual void SetDefaultProviderServices(global::System.Data.Entity.Core.Common.DbProviderServices provider, string invariantName)
		{
			this._defaultProviderResolvers.Add(new global::System.Data.Entity.Infrastructure.DependencyResolution.SingletonDependencyResolver<global::System.Data.Entity.Core.Common.DbProviderServices>(provider, invariantName));
			this._defaultProviderResolvers.Add(provider);
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x0005EBF9 File Offset: 0x0005CDF9
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this._defaultResolvers.GetServices(type, key).Concat(this._resolvers.GetServices(type, key));
		}

		// Token: 0x04000BD2 RID: 3026
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain _defaultProviderResolvers = new global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain();

		// Token: 0x04000BD3 RID: 3027
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain _defaultResolvers = new global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain();

		// Token: 0x04000BD4 RID: 3028
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain _resolvers = new global::System.Data.Entity.Infrastructure.DependencyResolution.ResolverChain();

		// Token: 0x04000BD5 RID: 3029
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.DatabaseInitializerResolver _databaseInitializerResolver;
	}
}
