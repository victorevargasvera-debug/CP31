using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Resources;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004D4 RID: 1236
	internal class MetadataArtifactLoaderCompositeResource : global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader
	{
		// Token: 0x06003D58 RID: 15704 RVA: 0x000CA238 File Offset: 0x000C8438
		internal MetadataArtifactLoaderCompositeResource(string originalPath, string assemblyName, string resourceName, global::System.Collections.Generic.ICollection<string> uriRegistry, global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactAssemblyResolver resolver)
		{
			this._originalPath = originalPath;
			this._children = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource>(global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.LoadResources(assemblyName, resourceName, uriRegistry, resolver));
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06003D59 RID: 15705 RVA: 0x000CA25D File Offset: 0x000C845D
		public override string Path
		{
			get
			{
				return this._originalPath;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06003D5A RID: 15706 RVA: 0x000CA265 File Offset: 0x000C8465
		public override bool IsComposite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x000CA268 File Offset: 0x000C8468
		public override global::System.Collections.Generic.List<string> GetOriginalPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			return this.GetOriginalPaths();
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x000CA270 File Offset: 0x000C8470
		public override global::System.Collections.Generic.List<string> GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource metadataArtifactLoaderResource in this._children)
			{
				list.AddRange(metadataArtifactLoaderResource.GetPaths(spaceToGet));
			}
			return list;
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x000CA2CC File Offset: 0x000C84CC
		public override global::System.Collections.Generic.List<string> GetPaths()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource metadataArtifactLoaderResource in this._children)
			{
				list.AddRange(metadataArtifactLoaderResource.GetPaths());
			}
			return list;
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x000CA328 File Offset: 0x000C8528
		public override global::System.Collections.Generic.List<global::System.Xml.XmlReader> GetReaders(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader, global::System.Xml.XmlReader> sourceDictionary)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = new global::System.Collections.Generic.List<global::System.Xml.XmlReader>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource metadataArtifactLoaderResource in this._children)
			{
				list.AddRange(metadataArtifactLoaderResource.GetReaders(sourceDictionary));
			}
			return list;
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x000CA384 File Offset: 0x000C8584
		public override global::System.Collections.Generic.List<global::System.Xml.XmlReader> CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = new global::System.Collections.Generic.List<global::System.Xml.XmlReader>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource metadataArtifactLoaderResource in this._children)
			{
				list.AddRange(metadataArtifactLoaderResource.CreateReaders(spaceToGet));
			}
			return list;
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x000CA3E0 File Offset: 0x000C85E0
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource> LoadResources(string assemblyName, string resourceName, global::System.Collections.Generic.ICollection<string> uriRegistry, global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactAssemblyResolver resolver)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource>();
			if (assemblyName == global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.wildcard)
			{
				using (global::System.Collections.Generic.IEnumerator<global::System.Reflection.Assembly> enumerator = resolver.GetWildcardAssemblies().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Reflection.Assembly assembly = enumerator.Current;
						if (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.AssemblyContainsResource(assembly, ref resourceName))
						{
							global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.LoadResourcesFromAssembly(assembly, resourceName, uriRegistry, list);
						}
					}
					goto IL_5E;
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.LoadResourcesFromAssembly(global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.ResolveAssemblyName(assemblyName, resolver), resourceName, uriRegistry, list);
			IL_5E:
			if (resourceName != null && list.Count == 0)
			{
				throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.UnableToLoadResource);
			}
			return list;
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x000CA474 File Offset: 0x000C8674
		private static bool AssemblyContainsResource(global::System.Reflection.Assembly assembly, ref string resourceName)
		{
			if (resourceName == null)
			{
				return true;
			}
			foreach (string text in global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.GetManifestResourceNamesForAssembly(assembly))
			{
				if (string.Equals(resourceName, text, global::System.StringComparison.OrdinalIgnoreCase))
				{
					resourceName = text;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x000CA4B1 File Offset: 0x000C86B1
		private static void LoadResourcesFromAssembly(global::System.Reflection.Assembly assembly, string resourceName, global::System.Collections.Generic.ICollection<string> uriRegistry, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource> loaders)
		{
			if (resourceName == null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.LoadAllResourcesFromAssembly(assembly, uriRegistry, loaders);
				return;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.AssemblyContainsResource(assembly, ref resourceName))
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.CreateAndAddSingleResourceLoader(assembly, resourceName, uriRegistry, loaders);
				return;
			}
			throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.UnableToLoadResource);
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x000CA4E0 File Offset: 0x000C86E0
		private static void LoadAllResourcesFromAssembly(global::System.Reflection.Assembly assembly, global::System.Collections.Generic.ICollection<string> uriRegistry, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource> loaders)
		{
			foreach (string resourceName in global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.GetManifestResourceNamesForAssembly(assembly))
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.CreateAndAddSingleResourceLoader(assembly, resourceName, uriRegistry, loaders);
			}
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x000CA510 File Offset: 0x000C8710
		private static void CreateAndAddSingleResourceLoader(global::System.Reflection.Assembly assembly, string resourceName, global::System.Collections.Generic.ICollection<string> uriRegistry, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource> loaders)
		{
			string item = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.CreateResPath(assembly, resourceName);
			if (!uriRegistry.Contains(item))
			{
				loaders.Add(new global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource(assembly, resourceName, uriRegistry));
			}
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x000CA53C File Offset: 0x000C873C
		internal static string CreateResPath(global::System.Reflection.Assembly assembly, string resourceName)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}{1}{2}{3}", new object[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.resPathPrefix,
				assembly.FullName,
				global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.resPathSeparator,
				resourceName
			});
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x000CA570 File Offset: 0x000C8770
		internal static string[] GetManifestResourceNamesForAssembly(global::System.Reflection.Assembly assembly)
		{
			if (assembly.IsDynamic)
			{
				return new string[0];
			}
			return assembly.GetManifestResourceNames();
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x000CA588 File Offset: 0x000C8788
		private static global::System.Reflection.Assembly ResolveAssemblyName(string assemblyName, global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactAssemblyResolver resolver)
		{
			global::System.Reflection.AssemblyName referenceName = new global::System.Reflection.AssemblyName(assemblyName);
			global::System.Reflection.Assembly result;
			if (!resolver.TryResolveAssemblyReference(referenceName, out result))
			{
				throw new global::System.IO.FileNotFoundException(global::System.Data.Entity.Resources.Strings.UnableToResolveAssembly(assemblyName));
			}
			return result;
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x000CA5B4 File Offset: 0x000C87B4
		internal static global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader CreateResourceLoader(string path, global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.ExtensionCheck extensionCheck, string validExtension, global::System.Collections.Generic.ICollection<string> uriRegistry, global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactAssemblyResolver resolver)
		{
			string text = null;
			string text2 = null;
			global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.ParseResourcePath(path, out text, out text2);
			bool flag = text != null && (text2 == null || text.Trim() == global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.wildcard);
			global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.ValidateExtension(extensionCheck, validExtension, text2);
			if (flag)
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource(path, text, text2, uriRegistry, resolver);
			}
			return new global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource(global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.ResolveAssemblyName(text, resolver), text2, uriRegistry);
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x000CA610 File Offset: 0x000C8810
		private static void ValidateExtension(global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.ExtensionCheck extensionCheck, string validExtension, string resourceName)
		{
			if (resourceName == null)
			{
				return;
			}
			if (extensionCheck == global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.ExtensionCheck.Specific)
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.CheckArtifactExtension(resourceName, validExtension);
				return;
			}
			if (extensionCheck != global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.ExtensionCheck.All)
			{
				return;
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.IsValidArtifact(resourceName))
			{
				throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.InvalidMetadataPath);
			}
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x000CA63C File Offset: 0x000C883C
		private static void ParseResourcePath(string path, out string assemblyName, out string resourceName)
		{
			int length = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.resPathPrefix.Length;
			string[] array = path.Substring(length).Split(new string[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.resPathSeparator,
				global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.altPathSeparator
			}, global::System.StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == 0 || array.Length > 2)
			{
				throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.InvalidMetadataPath);
			}
			if (array.Length >= 1)
			{
				assemblyName = array[0];
			}
			else
			{
				assemblyName = null;
			}
			if (array.Length == 2)
			{
				resourceName = array[1];
				return;
			}
			resourceName = null;
		}

		// Token: 0x040014F6 RID: 5366
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource> _children;

		// Token: 0x040014F7 RID: 5367
		private readonly string _originalPath;
	}
}
