using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200021F RID: 543
	public class DbCompiledModel
	{
		// Token: 0x06001C83 RID: 7299 RVA: 0x00050A0F File Offset: 0x0004EC0F
		internal DbCompiledModel()
		{
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00050A17 File Offset: 0x0004EC17
		internal DbCompiledModel(global::System.Data.Entity.Internal.CodeFirstCachedMetadataWorkspace workspace, global::System.Data.Entity.DbModelBuilder cachedModelBuilder)
		{
			this._workspace = workspace;
			this._cachedModelBuilder = cachedModelBuilder;
			this._defaultSchema = cachedModelBuilder.ModelConfiguration.DefaultSchema;
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00050A3E File Offset: 0x0004EC3E
		internal DbCompiledModel(global::System.Data.Entity.Internal.CodeFirstCachedMetadataWorkspace workspace, string defaultSchema)
		{
			this._workspace = workspace;
			this._defaultSchema = defaultSchema;
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x00050A54 File Offset: 0x0004EC54
		internal virtual global::System.Data.Entity.DbModelBuilder CachedModelBuilder
		{
			get
			{
				return this._cachedModelBuilder;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x00050A5C File Offset: 0x0004EC5C
		internal virtual global::System.Data.Entity.Infrastructure.DbProviderInfo ProviderInfo
		{
			get
			{
				return this._workspace.ProviderInfo;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x00050A69 File Offset: 0x0004EC69
		internal string DefaultSchema
		{
			get
			{
				return this._defaultSchema;
			}
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00050A74 File Offset: 0x0004EC74
		public TContext CreateObjectContext<TContext>(global::System.Data.Common.DbConnection existingConnection) where TContext : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(existingConnection, "existingConnection");
			global::System.Data.Entity.Core.EntityClient.EntityConnection arg = new global::System.Data.Entity.Core.EntityClient.EntityConnection(this._workspace.GetMetadataWorkspace(existingConnection), existingConnection);
			TContext tcontext = (TContext)((object)global::System.Data.Entity.Infrastructure.DbCompiledModel.GetConstructorDelegate<TContext>()(arg));
			tcontext.ContextOwnsConnection = true;
			if (string.IsNullOrEmpty(tcontext.DefaultContainerName))
			{
				tcontext.DefaultContainerName = this._workspace.DefaultContainerName;
			}
			foreach (global::System.Reflection.Assembly assembly in this._workspace.Assemblies)
			{
				tcontext.MetadataWorkspace.LoadFromAssembly(assembly);
			}
			return tcontext;
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00050B38 File Offset: 0x0004ED38
		internal static global::System.Func<global::System.Data.Entity.Core.EntityClient.EntityConnection, global::System.Data.Entity.Core.Objects.ObjectContext> GetConstructorDelegate<TContext>() where TContext : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			if (typeof(TContext) == typeof(global::System.Data.Entity.Core.Objects.ObjectContext))
			{
				return global::System.Data.Entity.Infrastructure.DbCompiledModel._objectContextConstructor;
			}
			global::System.Func<global::System.Data.Entity.Core.EntityClient.EntityConnection, global::System.Data.Entity.Core.Objects.ObjectContext> func;
			if (!global::System.Data.Entity.Infrastructure.DbCompiledModel._contextConstructors.TryGetValue(typeof(TContext), out func))
			{
				global::System.Reflection.ConstructorInfo declaredConstructor = typeof(TContext).GetDeclaredConstructor((global::System.Reflection.ConstructorInfo c) => c.IsPublic, new global::System.Type[][]
				{
					new global::System.Type[]
					{
						typeof(global::System.Data.Entity.Core.EntityClient.EntityConnection)
					},
					new global::System.Type[]
					{
						typeof(global::System.Data.Common.DbConnection)
					},
					new global::System.Type[]
					{
						typeof(global::System.Data.IDbConnection)
					},
					new global::System.Type[]
					{
						typeof(global::System.IDisposable)
					},
					new global::System.Type[]
					{
						typeof(global::System.ComponentModel.Component)
					},
					new global::System.Type[]
					{
						typeof(global::System.MarshalByRefObject)
					},
					new global::System.Type[]
					{
						typeof(object)
					}
				});
				if (declaredConstructor == null)
				{
					throw global::System.Data.Entity.Resources.Error.DbModelBuilder_MissingRequiredCtor(typeof(TContext).Name);
				}
				global::System.Linq.Expressions.ParameterExpression parameterExpression;
				func = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Data.Entity.Core.EntityClient.EntityConnection, global::System.Data.Entity.Core.Objects.ObjectContext>>(global::System.Linq.Expressions.Expression.New(declaredConstructor, new global::System.Linq.Expressions.Expression[]
				{
					parameterExpression
				}), new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression
				}).Compile();
				global::System.Data.Entity.Infrastructure.DbCompiledModel._contextConstructors.TryAdd(typeof(TContext), func);
			}
			return func;
		}

		// Token: 0x04000AF5 RID: 2805
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Core.EntityClient.EntityConnection, global::System.Data.Entity.Core.Objects.ObjectContext>> _contextConstructors = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Core.EntityClient.EntityConnection, global::System.Data.Entity.Core.Objects.ObjectContext>>();

		// Token: 0x04000AF6 RID: 2806
		private static readonly global::System.Func<global::System.Data.Entity.Core.EntityClient.EntityConnection, global::System.Data.Entity.Core.Objects.ObjectContext> _objectContextConstructor = (global::System.Data.Entity.Core.EntityClient.EntityConnection c) => new global::System.Data.Entity.Core.Objects.ObjectContext(c);

		// Token: 0x04000AF7 RID: 2807
		private readonly global::System.Data.Entity.Internal.ICachedMetadataWorkspace _workspace;

		// Token: 0x04000AF8 RID: 2808
		private readonly global::System.Data.Entity.DbModelBuilder _cachedModelBuilder;

		// Token: 0x04000AF9 RID: 2809
		private readonly string _defaultSchema;
	}
}
