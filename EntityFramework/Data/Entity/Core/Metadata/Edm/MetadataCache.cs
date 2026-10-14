using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.EntityClient.Internal;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004D8 RID: 1240
	internal class MetadataCache
	{
		// Token: 0x06003D8A RID: 15754 RVA: 0x000CAB20 File Offset: 0x000C8D20
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> SplitPaths(string paths)
		{
			global::System.Collections.Generic.HashSet<string> uriRegistry = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.OrdinalIgnoreCase);
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			for (int num = paths.IndexOf("|datadirectory|", global::System.StringComparison.OrdinalIgnoreCase); num != -1; num = paths.IndexOf("|datadirectory|", global::System.StringComparison.OrdinalIgnoreCase))
			{
				int num2 = ((num == 0) ? -1 : paths.LastIndexOf("|", num - 1, global::System.StringComparison.Ordinal)) + 1;
				int num3 = paths.IndexOf("|", num + "|datadirectory|".Length, global::System.StringComparison.Ordinal);
				if (num3 == -1)
				{
					list.Add(paths.Substring(num2));
					paths = paths.Remove(num2);
					break;
				}
				list.Add(paths.Substring(num2, num3 - num2));
				paths = paths.Remove(num2, num3 - num2);
			}
			string[] array = paths.Split(new string[]
			{
				"|"
			}, global::System.StringSplitOptions.RemoveEmptyEntries);
			if (list.Count > 0)
			{
				list.AddRange(array);
				array = list.ToArray();
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> list4 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> list5 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = array[i].Trim();
				if (array[i].Length > 0)
				{
					global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader item = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.Create(array[i], global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.ExtensionCheck.All, null, uriRegistry);
					if (array[i].EndsWith(".csdl", global::System.StringComparison.OrdinalIgnoreCase))
					{
						list2.Add(item);
					}
					else if (array[i].EndsWith(".msl", global::System.StringComparison.OrdinalIgnoreCase))
					{
						list3.Add(item);
					}
					else if (array[i].EndsWith(".ssdl", global::System.StringComparison.OrdinalIgnoreCase))
					{
						list4.Add(item);
					}
					else
					{
						list5.Add(item);
					}
				}
			}
			list5.AddRange(list4);
			list5.AddRange(list3);
			list5.AddRange(list2);
			return list5;
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x000CACDC File Offset: 0x000C8EDC
		public global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace GetMetadataWorkspace(global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions effectiveConnectionOptions)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader artifactLoader = this.GetArtifactLoader(effectiveConnectionOptions);
			string cacheKey = global::System.Data.Entity.Core.Metadata.Edm.MetadataCache.CreateMetadataCacheKey(artifactLoader.GetPaths(), effectiveConnectionOptions["provider"]);
			return this.GetMetadataWorkspace(cacheKey, artifactLoader);
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x000CAD10 File Offset: 0x000C8F10
		public global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader GetArtifactLoader(global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions effectiveConnectionOptions)
		{
			string text = effectiveConnectionOptions["metadata"];
			if (!string.IsNullOrEmpty(text))
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> list = this._artifactLoaderCache.Evaluate(text);
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataCache.ShouldRecalculateMetadataArtifactLoader(list) ? global::System.Data.Entity.Core.Metadata.Edm.MetadataCache.SplitPaths(text) : list);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.Create(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>());
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x000CAD60 File Offset: 0x000C8F60
		public global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace GetMetadataWorkspace(string cacheKey, global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader artifactLoader)
		{
			return this._cachedWorkspaces.GetOrAdd(cacheKey, delegate(string k)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection = global::System.Data.Entity.Core.Metadata.Edm.MetadataCache.LoadEdmItemCollection(artifactLoader);
				global::System.Lazy<global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection> mappingLoader = new global::System.Lazy<global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection>(() => global::System.Data.Entity.Core.Metadata.Edm.MetadataCache.LoadStoreCollection(edmItemCollection, artifactLoader));
				return new global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace(() => edmItemCollection, () => mappingLoader.Value.StoreItemCollection, () => mappingLoader.Value);
			});
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x000CAD92 File Offset: 0x000C8F92
		public void Clear()
		{
			this._cachedWorkspaces.Clear();
			global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Common.Utils.Memoizer<string, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>>>(ref this._artifactLoaderCache, new global::System.Data.Entity.Core.Common.Utils.Memoizer<string, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>>(new global::System.Func<string, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>>(global::System.Data.Entity.Core.Metadata.Edm.MetadataCache.SplitPaths), null), this._artifactLoaderCache);
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x000CADC4 File Offset: 0x000C8FC4
		private static global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection LoadStoreCollection(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader loader)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> xmlReaders = loader.CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
			global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeCollection;
			try
			{
				storeCollection = new global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection(xmlReaders, loader.GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace));
			}
			finally
			{
				global::System.Data.Entity.Core.Metadata.Edm.Helper.DisposeXmlReaders(xmlReaders);
			}
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> xmlReaders2 = loader.CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace);
			global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection result;
			try
			{
				result = new global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection(edmItemCollection, storeCollection, xmlReaders2, loader.GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace));
			}
			finally
			{
				global::System.Data.Entity.Core.Metadata.Edm.Helper.DisposeXmlReaders(xmlReaders2);
			}
			return result;
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x000CAE30 File Offset: 0x000C9030
		private static global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection LoadEdmItemCollection(global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader loader)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> xmlReaders = loader.CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection result;
			try
			{
				result = new global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection(xmlReaders, loader.GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace), false);
			}
			finally
			{
				global::System.Data.Entity.Core.Metadata.Edm.Helper.DisposeXmlReaders(xmlReaders);
			}
			return result;
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x000CAE70 File Offset: 0x000C9070
		private static bool ShouldRecalculateMetadataArtifactLoader(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> loaders)
		{
			return loaders.Any((global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader loader) => loader.GetType() == typeof(global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeFile));
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x000CAE98 File Offset: 0x000C9098
		private static string CreateMetadataCacheKey(global::System.Collections.Generic.IList<string> paths, string providerName)
		{
			int num = 0;
			string result;
			global::System.Data.Entity.Core.Metadata.Edm.MetadataCache.CreateMetadataCacheKeyWithCount(paths, providerName, false, ref num, out result);
			global::System.Data.Entity.Core.Metadata.Edm.MetadataCache.CreateMetadataCacheKeyWithCount(paths, providerName, true, ref num, out result);
			return result;
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x000CAEC0 File Offset: 0x000C90C0
		private static void CreateMetadataCacheKeyWithCount(global::System.Collections.Generic.IList<string> paths, string providerName, bool buildResult, ref int resultCount, out string result)
		{
			global::System.Text.StringBuilder stringBuilder = buildResult ? new global::System.Text.StringBuilder(resultCount) : null;
			resultCount = 0;
			if (!string.IsNullOrEmpty(providerName))
			{
				resultCount += providerName.Length + 1;
				if (buildResult)
				{
					stringBuilder.Append(providerName);
					stringBuilder.Append(";");
				}
			}
			if (paths != null)
			{
				for (int i = 0; i < paths.Count; i++)
				{
					if (paths[i].Length > 0)
					{
						if (i > 0)
						{
							resultCount++;
							if (buildResult)
							{
								stringBuilder.Append("|");
							}
						}
						resultCount += paths[i].Length;
						if (buildResult)
						{
							stringBuilder.Append(paths[i]);
						}
					}
				}
				resultCount++;
				if (buildResult)
				{
					stringBuilder.Append(";");
				}
			}
			result = (buildResult ? stringBuilder.ToString() : null);
		}

		// Token: 0x040014FF RID: 5375
		private const string DataDirectory = "|datadirectory|";

		// Token: 0x04001500 RID: 5376
		private const string MetadataPathSeparator = "|";

		// Token: 0x04001501 RID: 5377
		private const string SemicolonSeparator = ";";

		// Token: 0x04001502 RID: 5378
		public static readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataCache Instance = new global::System.Data.Entity.Core.Metadata.Edm.MetadataCache();

		// Token: 0x04001503 RID: 5379
		private global::System.Data.Entity.Core.Common.Utils.Memoizer<string, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>> _artifactLoaderCache = new global::System.Data.Entity.Core.Common.Utils.Memoizer<string, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>>(new global::System.Func<string, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>>(global::System.Data.Entity.Core.Metadata.Edm.MetadataCache.SplitPaths), null);

		// Token: 0x04001504 RID: 5380
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace> _cachedWorkspaces = new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace>();
	}
}
