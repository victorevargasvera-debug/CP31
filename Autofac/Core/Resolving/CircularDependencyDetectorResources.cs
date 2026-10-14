using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Core.Resolving
{
	// Token: 0x0200007D RID: 125
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class CircularDependencyDetectorResources
	{
		// Token: 0x060002CB RID: 715 RVA: 0x00008F50 File Offset: 0x00007150
		internal CircularDependencyDetectorResources()
		{
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00008F58 File Offset: 0x00007158
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Resolving.CircularDependencyDetectorResources.resourceMan == null)
				{
					global::Autofac.Core.Resolving.CircularDependencyDetectorResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Resolving.CircularDependencyDetectorResources", typeof(global::Autofac.Core.Resolving.CircularDependencyDetectorResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Resolving.CircularDependencyDetectorResources.resourceMan;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00008F89 File Offset: 0x00007189
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00008F90 File Offset: 0x00007190
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Resolving.CircularDependencyDetectorResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Resolving.CircularDependencyDetectorResources.resourceCulture = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00008F98 File Offset: 0x00007198
		internal static string CircularDependency
		{
			get
			{
				return global::Autofac.Core.Resolving.CircularDependencyDetectorResources.ResourceManager.GetString("CircularDependency", global::Autofac.Core.Resolving.CircularDependencyDetectorResources.resourceCulture);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00008FAE File Offset: 0x000071AE
		internal static string MaxDepthExceeded
		{
			get
			{
				return global::Autofac.Core.Resolving.CircularDependencyDetectorResources.ResourceManager.GetString("MaxDepthExceeded", global::Autofac.Core.Resolving.CircularDependencyDetectorResources.resourceCulture);
			}
		}

		// Token: 0x0400009E RID: 158
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x0400009F RID: 159
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
