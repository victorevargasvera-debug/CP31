using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Resources;
using System.IO;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004D1 RID: 1233
	internal abstract class MetadataArtifactLoader
	{
		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06003D25 RID: 15653
		public abstract string Path { get; }

		// Token: 0x06003D26 RID: 15654 RVA: 0x000C9719 File Offset: 0x000C7919
		public static global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader Create(string path, global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.ExtensionCheck extensionCheck, string validExtension, global::System.Collections.Generic.ICollection<string> uriRegistry)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.Create(path, extensionCheck, validExtension, uriRegistry, new global::System.Data.Entity.Core.Metadata.Edm.DefaultAssemblyResolver());
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x000C972C File Offset: 0x000C792C
		internal static global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader Create(string path, global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.ExtensionCheck extensionCheck, string validExtension, global::System.Collections.Generic.ICollection<string> uriRegistry, global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactAssemblyResolver resolver)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.PathStartsWithResPrefix(path))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.CreateResourceLoader(path, extensionCheck, validExtension, uriRegistry, resolver);
			}
			string text = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.NormalizeFilePaths(path);
			if (global::System.IO.Directory.Exists(text))
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeFile(text, uriRegistry);
			}
			if (global::System.IO.File.Exists(text))
			{
				if (extensionCheck != global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.ExtensionCheck.Specific)
				{
					if (extensionCheck == global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.ExtensionCheck.All)
					{
						if (!global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.IsValidArtifact(text))
						{
							throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.InvalidMetadataPath);
						}
					}
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.CheckArtifactExtension(text, validExtension);
				}
				return new global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile(text, uriRegistry);
			}
			throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.InvalidMetadataPath);
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x000C97A4 File Offset: 0x000C79A4
		public static global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader Create(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> allCollections)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderComposite(allCollections);
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x000C97AC File Offset: 0x000C79AC
		public static global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader CreateCompositeFromFilePaths(global::System.Collections.Generic.IEnumerable<string> filePaths, string validExtension)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.CreateCompositeFromFilePaths(filePaths, validExtension, new global::System.Data.Entity.Core.Metadata.Edm.DefaultAssemblyResolver());
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x000C97BC File Offset: 0x000C79BC
		internal static global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader CreateCompositeFromFilePaths(global::System.Collections.Generic.IEnumerable<string> filePaths, string validExtension, global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactAssemblyResolver resolver)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.ExtensionCheck extensionCheck;
			if (string.IsNullOrEmpty(validExtension))
			{
				extensionCheck = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.ExtensionCheck.All;
			}
			else
			{
				extensionCheck = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.ExtensionCheck.Specific;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>();
			global::System.Collections.Generic.HashSet<string> uriRegistry = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.OrdinalIgnoreCase);
			foreach (string text in filePaths)
			{
				if (string.IsNullOrEmpty(text))
				{
					throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.NotValidInputPath, new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_CollectionParameterElementIsNullOrEmpty("filePaths")));
				}
				string text2 = text.Trim();
				if (text2.Length > 0)
				{
					list.Add(global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.Create(text2, extensionCheck, validExtension, uriRegistry, resolver));
				}
			}
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.Create(list);
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x000C9868 File Offset: 0x000C7A68
		public static global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader CreateCompositeFromXmlReaders(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>();
			foreach (global::System.Xml.XmlReader xmlReader in xmlReaders)
			{
				if (xmlReader == null)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_CollectionParameterElementIsNull("xmlReaders"));
				}
				list.Add(new global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderXmlReaderWrapper(xmlReader));
			}
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.Create(list);
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x000C98D4 File Offset: 0x000C7AD4
		internal static void CheckArtifactExtension(string path, string validExtension)
		{
			string extension = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.GetExtension(path);
			if (!extension.Equals(validExtension, global::System.StringComparison.OrdinalIgnoreCase))
			{
				throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.InvalidFileExtension(path, extension, validExtension));
			}
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x000C9900 File Offset: 0x000C7B00
		public virtual global::System.Collections.Generic.List<string> GetOriginalPaths()
		{
			return new global::System.Collections.Generic.List<string>(new string[]
			{
				this.Path
			});
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x000C9918 File Offset: 0x000C7B18
		public virtual global::System.Collections.Generic.List<string> GetOriginalPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			if (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.IsArtifactOfDataSpace(this.Path, spaceToGet))
			{
				list.Add(this.Path);
			}
			return list;
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06003D2F RID: 15663 RVA: 0x000C9946 File Offset: 0x000C7B46
		public virtual bool IsComposite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06003D30 RID: 15664
		public abstract global::System.Collections.Generic.List<string> GetPaths();

		// Token: 0x06003D31 RID: 15665
		public abstract global::System.Collections.Generic.List<string> GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet);

		// Token: 0x06003D32 RID: 15666 RVA: 0x000C9949 File Offset: 0x000C7B49
		public global::System.Collections.Generic.List<global::System.Xml.XmlReader> GetReaders()
		{
			return this.GetReaders(null);
		}

		// Token: 0x06003D33 RID: 15667
		public abstract global::System.Collections.Generic.List<global::System.Xml.XmlReader> GetReaders(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader, global::System.Xml.XmlReader> sourceDictionary);

		// Token: 0x06003D34 RID: 15668
		public abstract global::System.Collections.Generic.List<global::System.Xml.XmlReader> CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet);

		// Token: 0x06003D35 RID: 15669 RVA: 0x000C9952 File Offset: 0x000C7B52
		internal static bool PathStartsWithResPrefix(string path)
		{
			return path.StartsWith(global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.resPathPrefix, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x000C9960 File Offset: 0x000C7B60
		protected static bool IsCSpaceArtifact(string resource)
		{
			string extension = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.GetExtension(resource);
			return !string.IsNullOrEmpty(extension) && string.Compare(extension, ".csdl", global::System.StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x000C9990 File Offset: 0x000C7B90
		protected static bool IsSSpaceArtifact(string resource)
		{
			string extension = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.GetExtension(resource);
			return !string.IsNullOrEmpty(extension) && string.Compare(extension, ".ssdl", global::System.StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x000C99C0 File Offset: 0x000C7BC0
		protected static bool IsCSSpaceArtifact(string resource)
		{
			string extension = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.GetExtension(resource);
			return !string.IsNullOrEmpty(extension) && string.Compare(extension, ".msl", global::System.StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x000C99F0 File Offset: 0x000C7BF0
		private static string GetExtension(string resource)
		{
			if (string.IsNullOrEmpty(resource))
			{
				return string.Empty;
			}
			int num = resource.LastIndexOf('.');
			if (num < 0)
			{
				return string.Empty;
			}
			return resource.Substring(num);
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x000C9A28 File Offset: 0x000C7C28
		internal static bool IsValidArtifact(string resource)
		{
			string extension = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.GetExtension(resource);
			return !string.IsNullOrEmpty(extension) && (string.Compare(extension, ".csdl", global::System.StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(extension, ".ssdl", global::System.StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(extension, ".msl", global::System.StringComparison.OrdinalIgnoreCase) == 0);
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x000C9A73 File Offset: 0x000C7C73
		protected static bool IsArtifactOfDataSpace(string resource, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace)
		{
			if (dataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.IsCSpaceArtifact(resource);
			}
			if (dataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.IsSSpaceArtifact(resource);
			}
			return dataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace && global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.IsCSSpaceArtifact(resource);
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x000C9A98 File Offset: 0x000C7C98
		internal static string NormalizeFilePaths(string path)
		{
			bool flag = true;
			if (!string.IsNullOrEmpty(path))
			{
				path = path.Trim();
				if (path.StartsWith("~", global::System.StringComparison.Ordinal))
				{
					path = new global::System.Data.Entity.Core.Metadata.Edm.AspProxy().MapWebPath(path);
					flag = false;
				}
				if (path.Length == 2 && path[1] == global::System.IO.Path.VolumeSeparatorChar)
				{
					path += global::System.IO.Path.DirectorySeparatorChar.ToString();
				}
				else
				{
					string text = global::System.Data.Entity.Core.Common.DbProviderServices.ExpandDataDirectory(path);
					if (!path.Equals(text, global::System.StringComparison.Ordinal))
					{
						path = text;
						flag = false;
					}
				}
			}
			try
			{
				if (flag)
				{
					path = global::System.IO.Path.GetFullPath(path);
				}
			}
			catch (global::System.ArgumentException innerException)
			{
				throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.NotValidInputPath, innerException);
			}
			catch (global::System.NotSupportedException innerException2)
			{
				throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.NotValidInputPath, innerException2);
			}
			catch (global::System.IO.PathTooLongException)
			{
				throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.NotValidInputPath);
			}
			return path;
		}

		// Token: 0x040014EC RID: 5356
		protected static readonly string resPathPrefix = "res://";

		// Token: 0x040014ED RID: 5357
		protected static readonly string resPathSeparator = "/";

		// Token: 0x040014EE RID: 5358
		protected static readonly string altPathSeparator = "\\";

		// Token: 0x040014EF RID: 5359
		protected static readonly string wildcard = "*";

		// Token: 0x02000AF4 RID: 2804
		public enum ExtensionCheck
		{
			// Token: 0x04002C5A RID: 11354
			None,
			// Token: 0x04002C5B RID: 11355
			Specific,
			// Token: 0x04002C5C RID: 11356
			All
		}
	}
}
