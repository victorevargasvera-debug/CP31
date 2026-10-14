using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004A0 RID: 1184
	internal class DefaultAssemblyResolver : global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactAssemblyResolver
	{
		// Token: 0x06003A46 RID: 14918 RVA: 0x000BFC1E File Offset: 0x000BDE1E
		internal override bool TryResolveAssemblyReference(global::System.Reflection.AssemblyName referenceName, out global::System.Reflection.Assembly assembly)
		{
			assembly = this.ResolveAssembly(referenceName);
			return assembly != null;
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x000BFC31 File Offset: 0x000BDE31
		internal override global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> GetWildcardAssemblies()
		{
			return global::System.Data.Entity.Core.Metadata.Edm.DefaultAssemblyResolver.GetAllDiscoverableAssemblies();
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x000BFC38 File Offset: 0x000BDE38
		internal virtual global::System.Reflection.Assembly ResolveAssembly(global::System.Reflection.AssemblyName referenceName)
		{
			global::System.Reflection.Assembly assembly = null;
			foreach (global::System.Reflection.Assembly assembly2 in global::System.Data.Entity.Core.Metadata.Edm.DefaultAssemblyResolver.GetAlreadyLoadedNonSystemAssemblies())
			{
				if (global::System.Reflection.AssemblyName.ReferenceMatchesDefinition(referenceName, new global::System.Reflection.AssemblyName(assembly2.FullName)))
				{
					return assembly2;
				}
			}
			if (assembly == null)
			{
				assembly = global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.SafeLoadReferencedAssembly(referenceName);
				if (assembly != null)
				{
					return assembly;
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.DefaultAssemblyResolver.TryFindWildcardAssemblyMatch(referenceName, out assembly);
			return assembly;
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x000BFCC0 File Offset: 0x000BDEC0
		private static bool TryFindWildcardAssemblyMatch(global::System.Reflection.AssemblyName referenceName, out global::System.Reflection.Assembly assembly)
		{
			foreach (global::System.Reflection.Assembly assembly2 in global::System.Data.Entity.Core.Metadata.Edm.DefaultAssemblyResolver.GetAllDiscoverableAssemblies())
			{
				if (global::System.Reflection.AssemblyName.ReferenceMatchesDefinition(referenceName, new global::System.Reflection.AssemblyName(assembly2.FullName)))
				{
					assembly = assembly2;
					return true;
				}
			}
			assembly = null;
			return false;
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x000BFD28 File Offset: 0x000BDF28
		private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> GetAlreadyLoadedNonSystemAssemblies()
		{
			return from a in global::System.AppDomain.CurrentDomain.GetAssemblies()
			where a != null && !global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.ShouldFilterAssembly(a)
			select a;
		}

		// Token: 0x06003A4B RID: 14923 RVA: 0x000BFD58 File Offset: 0x000BDF58
		private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> GetAllDiscoverableAssemblies()
		{
			global::System.Reflection.Assembly entryAssembly = global::System.Reflection.Assembly.GetEntryAssembly();
			global::System.Collections.Generic.HashSet<global::System.Reflection.Assembly> hashSet = new global::System.Collections.Generic.HashSet<global::System.Reflection.Assembly>(global::System.Data.Entity.Core.Metadata.Edm.DefaultAssemblyResolver.AssemblyComparer.Instance);
			foreach (global::System.Reflection.Assembly item in global::System.Data.Entity.Core.Metadata.Edm.DefaultAssemblyResolver.GetAlreadyLoadedNonSystemAssemblies())
			{
				hashSet.Add(item);
			}
			global::System.Data.Entity.Core.Metadata.Edm.AspProxy aspProxy = new global::System.Data.Entity.Core.Metadata.Edm.AspProxy();
			if (aspProxy.IsAspNetEnvironment())
			{
				if (aspProxy.HasBuildManagerType())
				{
					global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> buildManagerReferencedAssemblies = aspProxy.GetBuildManagerReferencedAssemblies();
					if (buildManagerReferencedAssemblies != null)
					{
						foreach (global::System.Reflection.Assembly assembly in buildManagerReferencedAssemblies)
						{
							if (!global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.ShouldFilterAssembly(assembly))
							{
								hashSet.Add(assembly);
							}
						}
					}
				}
				return from a in hashSet
				where a != null
				select a;
			}
			if (entryAssembly == null)
			{
				return hashSet;
			}
			hashSet.Add(entryAssembly);
			foreach (global::System.Reflection.Assembly item2 in global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.GetNonSystemReferencedAssemblies(entryAssembly))
			{
				hashSet.Add(item2);
			}
			return hashSet;
		}

		// Token: 0x02000AC9 RID: 2761
		internal sealed class AssemblyComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Reflection.Assembly>
		{
			// Token: 0x06006330 RID: 25392 RVA: 0x001571D7 File Offset: 0x001553D7
			private AssemblyComparer()
			{
			}

			// Token: 0x170010D6 RID: 4310
			// (get) Token: 0x06006331 RID: 25393 RVA: 0x001571DF File Offset: 0x001553DF
			public static global::System.Data.Entity.Core.Metadata.Edm.DefaultAssemblyResolver.AssemblyComparer Instance
			{
				get
				{
					return global::System.Data.Entity.Core.Metadata.Edm.DefaultAssemblyResolver.AssemblyComparer._instance;
				}
			}

			// Token: 0x06006332 RID: 25394 RVA: 0x001571E8 File Offset: 0x001553E8
			public bool Equals(global::System.Reflection.Assembly x, global::System.Reflection.Assembly y)
			{
				global::System.Reflection.AssemblyName assemblyName = new global::System.Reflection.AssemblyName(x.FullName);
				global::System.Reflection.AssemblyName assemblyName2 = new global::System.Reflection.AssemblyName(y.FullName);
				return x == y || (global::System.Reflection.AssemblyName.ReferenceMatchesDefinition(assemblyName, assemblyName2) && global::System.Reflection.AssemblyName.ReferenceMatchesDefinition(assemblyName2, assemblyName));
			}

			// Token: 0x06006333 RID: 25395 RVA: 0x00157225 File Offset: 0x00155425
			public int GetHashCode(global::System.Reflection.Assembly assembly)
			{
				return assembly.FullName.GetHashCode();
			}

			// Token: 0x04002BAD RID: 11181
			private static readonly global::System.Data.Entity.Core.Metadata.Edm.DefaultAssemblyResolver.AssemblyComparer _instance = new global::System.Data.Entity.Core.Metadata.Edm.DefaultAssemblyResolver.AssemblyComparer();
		}
	}
}
