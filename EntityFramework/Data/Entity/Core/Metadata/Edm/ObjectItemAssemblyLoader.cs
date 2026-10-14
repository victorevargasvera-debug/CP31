using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000512 RID: 1298
	internal abstract class ObjectItemAssemblyLoader
	{
		// Token: 0x06003FF4 RID: 16372 RVA: 0x000D3CA9 File Offset: 0x000D1EA9
		protected ObjectItemAssemblyLoader(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.AssemblyCacheEntry cacheEntry, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData sessionData)
		{
			this._assembly = assembly;
			this._cacheEntry = cacheEntry;
			this._sessionData = sessionData;
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x000D3CC6 File Offset: 0x000D1EC6
		internal virtual void Load()
		{
			this.AddToAssembliesLoaded();
			this.LoadTypesFromAssembly();
			this.AddToKnownAssemblies();
			this.LoadClosureAssemblies();
		}

		// Token: 0x06003FF6 RID: 16374
		protected abstract void AddToAssembliesLoaded();

		// Token: 0x06003FF7 RID: 16375
		protected abstract void LoadTypesFromAssembly();

		// Token: 0x06003FF8 RID: 16376 RVA: 0x000D3CE0 File Offset: 0x000D1EE0
		protected virtual void LoadClosureAssemblies()
		{
			global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader.LoadAssemblies(this.CacheEntry.ClosureAssemblies, this.SessionData);
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x000D3CF8 File Offset: 0x000D1EF8
		internal virtual void OnLevel1SessionProcessing()
		{
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x000D3CFA File Offset: 0x000D1EFA
		internal virtual void OnLevel2SessionProcessing()
		{
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x000D3CFC File Offset: 0x000D1EFC
		internal static global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader CreateLoader(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData sessionData)
		{
			if (sessionData.KnownAssemblies.Contains(assembly, sessionData.ObjectItemAssemblyLoaderFactory, sessionData.EdmItemCollection))
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.ObjectItemNoOpAssemblyLoader(assembly, sessionData);
			}
			global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry immutableAssemblyCacheEntry;
			if (sessionData.LockedAssemblyCache.TryGetValue(assembly, out immutableAssemblyCacheEntry))
			{
				if (sessionData.ObjectItemAssemblyLoaderFactory == null)
				{
					if (immutableAssemblyCacheEntry.TypesInAssembly.Count != 0)
					{
						sessionData.ObjectItemAssemblyLoaderFactory = new global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader>(global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAttributeAssemblyLoader.Create);
					}
				}
				else if (sessionData.ObjectItemAssemblyLoaderFactory != new global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader>(global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAttributeAssemblyLoader.Create))
				{
					sessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_AttributeAssemblyReferenced(assembly.FullName)));
				}
				return new global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCachedAssemblyLoader(assembly, immutableAssemblyCacheEntry, sessionData);
			}
			if (sessionData.EdmItemCollection != null && sessionData.EdmItemCollection.ConventionalOcCache.TryGetConventionalOcCacheFromAssemblyCache(assembly, out immutableAssemblyCacheEntry))
			{
				sessionData.ObjectItemAssemblyLoaderFactory = new global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader>(global::System.Data.Entity.Core.Metadata.Edm.ObjectItemConventionAssemblyLoader.Create);
				return new global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCachedAssemblyLoader(assembly, immutableAssemblyCacheEntry, sessionData);
			}
			if (sessionData.ObjectItemAssemblyLoaderFactory == null)
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAttributeAssemblyLoader.IsSchemaAttributePresent(assembly))
				{
					sessionData.ObjectItemAssemblyLoaderFactory = new global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader>(global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAttributeAssemblyLoader.Create);
				}
				else if (global::System.Data.Entity.Core.Metadata.Edm.ObjectItemConventionAssemblyLoader.SessionContainsConventionParameters(sessionData))
				{
					sessionData.ObjectItemAssemblyLoaderFactory = new global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader>(global::System.Data.Entity.Core.Metadata.Edm.ObjectItemConventionAssemblyLoader.Create);
				}
			}
			if (sessionData.ObjectItemAssemblyLoaderFactory != null)
			{
				return sessionData.ObjectItemAssemblyLoaderFactory(assembly, sessionData);
			}
			return new global::System.Data.Entity.Core.Metadata.Edm.ObjectItemNoOpAssemblyLoader(assembly, sessionData);
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x000D3E34 File Offset: 0x000D2034
		internal static bool IsAttributeLoader(object loaderCookie)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader.IsAttributeLoader(loaderCookie as global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader>);
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x000D3E41 File Offset: 0x000D2041
		internal static bool IsAttributeLoader(global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader> loaderFactory)
		{
			return loaderFactory != null && loaderFactory == new global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader>(global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAttributeAssemblyLoader.Create);
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x000D3E5A File Offset: 0x000D205A
		internal static bool IsConventionLoader(global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader> loaderFactory)
		{
			return loaderFactory != null && loaderFactory == new global::System.Func<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader>(global::System.Data.Entity.Core.Metadata.Edm.ObjectItemConventionAssemblyLoader.Create);
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x000D3E73 File Offset: 0x000D2073
		protected virtual void AddToKnownAssemblies()
		{
			this._sessionData.KnownAssemblies.Add(this._assembly, new global::System.Data.Entity.Core.Metadata.Edm.KnownAssemblyEntry(this.CacheEntry, this.SessionData.EdmItemCollection != null));
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x000D3EA4 File Offset: 0x000D20A4
		protected static void LoadAssemblies(global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> assemblies, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData sessionData)
		{
			foreach (global::System.Reflection.Assembly assembly in assemblies)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader.CreateLoader(assembly, sessionData).Load();
			}
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x000D3EF0 File Offset: 0x000D20F0
		protected static bool TryGetPrimitiveType(global::System.Type type, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.Instance.TryGetPrimitiveType(global::System.Nullable.GetUnderlyingType(type) ?? type, out primitiveType);
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06004002 RID: 16386 RVA: 0x000D3F08 File Offset: 0x000D2108
		protected global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData SessionData
		{
			get
			{
				return this._sessionData;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06004003 RID: 16387 RVA: 0x000D3F10 File Offset: 0x000D2110
		protected global::System.Reflection.Assembly SourceAssembly
		{
			get
			{
				return this._assembly;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x000D3F18 File Offset: 0x000D2118
		protected global::System.Data.Entity.Core.Metadata.Edm.AssemblyCacheEntry CacheEntry
		{
			get
			{
				return this._cacheEntry;
			}
		}

		// Token: 0x04001654 RID: 5716
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData _sessionData;

		// Token: 0x04001655 RID: 5717
		private readonly global::System.Reflection.Assembly _assembly;

		// Token: 0x04001656 RID: 5718
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssemblyCacheEntry _cacheEntry;
	}
}
