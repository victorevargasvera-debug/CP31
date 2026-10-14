using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000025 RID: 37
	public class AssemblyResolver : global::Microsoft.Practices.Prism.Modularity.IAssemblyResolver, global::System.IDisposable
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00004178 File Offset: 0x00002378
		public void LoadAssemblyFrom(string assemblyFilePath)
		{
			if (!this.handlesAssemblyResolve)
			{
				global::System.AppDomain.CurrentDomain.AssemblyResolve += this.CurrentDomain_AssemblyResolve;
				this.handlesAssemblyResolve = true;
			}
			global::System.Uri fileUri = global::Microsoft.Practices.Prism.Modularity.AssemblyResolver.GetFileUri(assemblyFilePath);
			if (fileUri == null)
			{
				throw new global::System.ArgumentException(global::Microsoft.Practices.Prism.Properties.Resources.InvalidArgumentAssemblyUri, "assemblyFilePath");
			}
			if (!global::System.IO.File.Exists(fileUri.LocalPath))
			{
				throw new global::System.IO.FileNotFoundException();
			}
			global::System.Reflection.AssemblyName assemblyName = global::System.Reflection.AssemblyName.GetAssemblyName(fileUri.LocalPath);
			global::Microsoft.Practices.Prism.Modularity.AssemblyResolver.AssemblyInfo assemblyInfo = this.registeredAssemblies.FirstOrDefault((global::Microsoft.Practices.Prism.Modularity.AssemblyResolver.AssemblyInfo a) => assemblyName == a.AssemblyName);
			if (assemblyInfo != null)
			{
				return;
			}
			assemblyInfo = new global::Microsoft.Practices.Prism.Modularity.AssemblyResolver.AssemblyInfo
			{
				AssemblyName = assemblyName,
				AssemblyUri = fileUri
			};
			this.registeredAssemblies.Add(assemblyInfo);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004238 File Offset: 0x00002438
		private static global::System.Uri GetFileUri(string filePath)
		{
			if (string.IsNullOrEmpty(filePath))
			{
				return null;
			}
			global::System.Uri uri;
			if (!global::System.Uri.TryCreate(filePath, global::System.UriKind.Absolute, out uri))
			{
				return null;
			}
			if (!uri.IsFile)
			{
				return null;
			}
			return uri;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004284 File Offset: 0x00002484
		private global::System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, global::System.ResolveEventArgs args)
		{
			global::System.Reflection.AssemblyName assemblyName = new global::System.Reflection.AssemblyName(args.Name);
			global::Microsoft.Practices.Prism.Modularity.AssemblyResolver.AssemblyInfo assemblyInfo = this.registeredAssemblies.FirstOrDefault((global::Microsoft.Practices.Prism.Modularity.AssemblyResolver.AssemblyInfo a) => global::System.Reflection.AssemblyName.ReferenceMatchesDefinition(assemblyName, a.AssemblyName));
			if (assemblyInfo != null)
			{
				if (assemblyInfo.Assembly == null)
				{
					assemblyInfo.Assembly = global::System.Reflection.Assembly.LoadFrom(assemblyInfo.AssemblyUri.LocalPath);
				}
				return assemblyInfo.Assembly;
			}
			return null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000042EF File Offset: 0x000024EF
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000042FE File Offset: 0x000024FE
		protected virtual void Dispose(bool disposing)
		{
			if (this.handlesAssemblyResolve)
			{
				global::System.AppDomain.CurrentDomain.AssemblyResolve -= this.CurrentDomain_AssemblyResolve;
				this.handlesAssemblyResolve = false;
			}
		}

		// Token: 0x0400003A RID: 58
		private readonly global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Modularity.AssemblyResolver.AssemblyInfo> registeredAssemblies = new global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Modularity.AssemblyResolver.AssemblyInfo>();

		// Token: 0x0400003B RID: 59
		private bool handlesAssemblyResolve;

		// Token: 0x02000026 RID: 38
		private class AssemblyInfo
		{
			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000BD RID: 189 RVA: 0x00004338 File Offset: 0x00002538
			// (set) Token: 0x060000BE RID: 190 RVA: 0x00004340 File Offset: 0x00002540
			public global::System.Reflection.AssemblyName AssemblyName { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000BF RID: 191 RVA: 0x00004349 File Offset: 0x00002549
			// (set) Token: 0x060000C0 RID: 192 RVA: 0x00004351 File Offset: 0x00002551
			public global::System.Uri AssemblyUri { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000435A File Offset: 0x0000255A
			// (set) Token: 0x060000C2 RID: 194 RVA: 0x00004362 File Offset: 0x00002562
			public global::System.Reflection.Assembly Assembly { get; set; }
		}
	}
}
