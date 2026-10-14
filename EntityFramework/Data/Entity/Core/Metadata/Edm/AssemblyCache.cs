using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000507 RID: 1287
	internal static class AssemblyCache
	{
		// Token: 0x06003FB8 RID: 16312 RVA: 0x000D3335 File Offset: 0x000D1535
		internal static global::System.Data.Entity.Core.Metadata.Edm.LockedAssemblyCache AcquireLockedAssemblyCache()
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.LockedAssemblyCache(global::System.Data.Entity.Core.Metadata.Edm.AssemblyCache._assemblyCacheLock, global::System.Data.Entity.Core.Metadata.Edm.AssemblyCache._globalAssemblyCache);
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x000D3348 File Offset: 0x000D1548
		internal static void LoadAssembly(global::System.Reflection.Assembly assembly, bool loadReferencedAssemblies, global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet knownAssemblies, out global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> typesInLoading, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors)
		{
			object obj = null;
			global::System.Data.Entity.Core.Metadata.Edm.AssemblyCache.LoadAssembly(assembly, loadReferencedAssemblies, knownAssemblies, null, null, ref obj, out typesInLoading, out errors);
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x000D3368 File Offset: 0x000D1568
		internal static void LoadAssembly(global::System.Reflection.Assembly assembly, bool loadReferencedAssemblies, global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet knownAssemblies, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Action<string> logLoadMessage, ref object loaderCookie, out global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> typesInLoading, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors)
		{
			typesInLoading = null;
			errors = null;
			using (global::System.Data.Entity.Core.Metadata.Edm.LockedAssemblyCache lockedAssemblyCache = global::System.Data.Entity.Core.Metadata.Edm.AssemblyCache.AcquireLockedAssemblyCache())
			{
				global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData objectItemLoadingSessionData = new global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData(knownAssemblies, lockedAssemblyCache, edmItemCollection, logLoadMessage, loaderCookie);
				global::System.Data.Entity.Core.Metadata.Edm.AssemblyCache.LoadAssembly(assembly, loadReferencedAssemblies, objectItemLoadingSessionData);
				loaderCookie = objectItemLoadingSessionData.LoaderCookie;
				objectItemLoadingSessionData.CompleteSession();
				if (objectItemLoadingSessionData.EdmItemErrors.Count == 0)
				{
					new global::System.Data.Entity.Core.Metadata.Edm.EdmValidator
					{
						SkipReadOnlyItems = true
					}.Validate<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(objectItemLoadingSessionData.TypesInLoading.Values, objectItemLoadingSessionData.EdmItemErrors);
					if (objectItemLoadingSessionData.EdmItemErrors.Count == 0)
					{
						if (global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader.IsAttributeLoader(objectItemLoadingSessionData.ObjectItemAssemblyLoaderFactory))
						{
							global::System.Data.Entity.Core.Metadata.Edm.AssemblyCache.UpdateCache(lockedAssemblyCache, objectItemLoadingSessionData.AssembliesLoaded);
						}
						else if (objectItemLoadingSessionData.EdmItemCollection != null && global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader.IsConventionLoader(objectItemLoadingSessionData.ObjectItemAssemblyLoaderFactory))
						{
							global::System.Data.Entity.Core.Metadata.Edm.AssemblyCache.UpdateCache(objectItemLoadingSessionData.EdmItemCollection, objectItemLoadingSessionData.AssembliesLoaded);
						}
					}
				}
				if (objectItemLoadingSessionData.TypesInLoading.Count > 0)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in objectItemLoadingSessionData.TypesInLoading.Values)
					{
						edmType.SetReadOnly();
					}
				}
				typesInLoading = objectItemLoadingSessionData.TypesInLoading;
				errors = objectItemLoadingSessionData.EdmItemErrors;
			}
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x000D34A8 File Offset: 0x000D16A8
		private static void LoadAssembly(global::System.Reflection.Assembly assembly, bool loadReferencedAssemblies, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData loadingData)
		{
			global::System.Data.Entity.Core.Metadata.Edm.KnownAssemblyEntry knownAssemblyEntry;
			bool flag;
			if (loadingData.KnownAssemblies.TryGetKnownAssembly(assembly, loadingData.ObjectItemAssemblyLoaderFactory, loadingData.EdmItemCollection, out knownAssemblyEntry))
			{
				flag = (!knownAssemblyEntry.ReferencedAssembliesAreLoaded && loadReferencedAssemblies);
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader.CreateLoader(assembly, loadingData).Load();
				flag = loadReferencedAssemblies;
			}
			if (flag)
			{
				if ((knownAssemblyEntry == null && loadingData.KnownAssemblies.TryGetKnownAssembly(assembly, loadingData.ObjectItemAssemblyLoaderFactory, loadingData.EdmItemCollection, out knownAssemblyEntry)) || knownAssemblyEntry != null)
				{
					knownAssemblyEntry.ReferencedAssembliesAreLoaded = true;
				}
				foreach (global::System.Reflection.Assembly assembly2 in global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.GetNonSystemReferencedAssemblies(assembly))
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssemblyCache.LoadAssembly(assembly2, loadReferencedAssemblies, loadingData);
				}
			}
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x000D355C File Offset: 0x000D175C
		private static void UpdateCache(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry> assemblies)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry> keyValuePair in assemblies)
			{
				edmItemCollection.ConventionalOcCache.AddAssemblyToOcCacheFromAssemblyCache(keyValuePair.Key, new global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry(keyValuePair.Value));
			}
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x000D35C4 File Offset: 0x000D17C4
		private static void UpdateCache(global::System.Data.Entity.Core.Metadata.Edm.LockedAssemblyCache lockedAssemblyCache, global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry> assemblies)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry> keyValuePair in assemblies)
			{
				lockedAssemblyCache.Add(keyValuePair.Key, new global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry(keyValuePair.Value));
			}
		}

		// Token: 0x0400163D RID: 5693
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry> _globalAssemblyCache = new global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry>();

		// Token: 0x0400163E RID: 5694
		private static readonly object _assemblyCacheLock = new object();
	}
}
