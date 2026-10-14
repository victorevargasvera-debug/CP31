using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac
{
	// Token: 0x0200000D RID: 13
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ModuleResources
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00002ABD File Offset: 0x00000CBD
		internal ModuleResources()
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002AC5 File Offset: 0x00000CC5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.ModuleResources.resourceMan == null)
				{
					global::Autofac.ModuleResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.ModuleResources", typeof(global::Autofac.ModuleResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.ModuleResources.resourceMan;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002AF6 File Offset: 0x00000CF6
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002AFD File Offset: 0x00000CFD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.ModuleResources.resourceCulture;
			}
			set
			{
				global::Autofac.ModuleResources.resourceCulture = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002B05 File Offset: 0x00000D05
		public static string ThisAssemblyUnavailable
		{
			get
			{
				return global::Autofac.ModuleResources.ResourceManager.GetString("ThisAssemblyUnavailable", global::Autofac.ModuleResources.resourceCulture);
			}
		}

		// Token: 0x0400000D RID: 13
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x0400000E RID: 14
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
