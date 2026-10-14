using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Core.Lifetime
{
	// Token: 0x0200009D RID: 157
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class LifetimeScopeResources
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x0000B402 File Offset: 0x00009602
		internal LifetimeScopeResources()
		{
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000B40A File Offset: 0x0000960A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Lifetime.LifetimeScopeResources.resourceMan == null)
				{
					global::Autofac.Core.Lifetime.LifetimeScopeResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Lifetime.LifetimeScopeResources", typeof(global::Autofac.Core.Lifetime.LifetimeScopeResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Lifetime.LifetimeScopeResources.resourceMan;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0000B43B File Offset: 0x0000963B
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x0000B442 File Offset: 0x00009642
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Lifetime.LifetimeScopeResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Lifetime.LifetimeScopeResources.resourceCulture = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0000B44A File Offset: 0x0000964A
		internal static string DuplicateTagDetected
		{
			get
			{
				return global::Autofac.Core.Lifetime.LifetimeScopeResources.ResourceManager.GetString("DuplicateTagDetected", global::Autofac.Core.Lifetime.LifetimeScopeResources.resourceCulture);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0000B460 File Offset: 0x00009660
		internal static string ScopeIsDisposed
		{
			get
			{
				return global::Autofac.Core.Lifetime.LifetimeScopeResources.ResourceManager.GetString("ScopeIsDisposed", global::Autofac.Core.Lifetime.LifetimeScopeResources.resourceCulture);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0000B476 File Offset: 0x00009676
		internal static string SelfConstructingDependencyDetected
		{
			get
			{
				return global::Autofac.Core.Lifetime.LifetimeScopeResources.ResourceManager.GetString("SelfConstructingDependencyDetected", global::Autofac.Core.Lifetime.LifetimeScopeResources.resourceCulture);
			}
		}

		// Token: 0x040000F8 RID: 248
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x040000F9 RID: 249
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
