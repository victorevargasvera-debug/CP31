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
	// Token: 0x02000089 RID: 137
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ResolveOperationResources
	{
		// Token: 0x06000312 RID: 786 RVA: 0x000098A2 File Offset: 0x00007AA2
		internal ResolveOperationResources()
		{
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000313 RID: 787 RVA: 0x000098AA File Offset: 0x00007AAA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Resolving.ResolveOperationResources.resourceMan == null)
				{
					global::Autofac.Core.Resolving.ResolveOperationResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Resolving.ResolveOperationResources", typeof(global::Autofac.Core.Resolving.ResolveOperationResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Resolving.ResolveOperationResources.resourceMan;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000314 RID: 788 RVA: 0x000098DB File Offset: 0x00007ADB
		// (set) Token: 0x06000315 RID: 789 RVA: 0x000098E2 File Offset: 0x00007AE2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Resolving.ResolveOperationResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Resolving.ResolveOperationResources.resourceCulture = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000316 RID: 790 RVA: 0x000098EA File Offset: 0x00007AEA
		internal static string ExceptionDuringResolve
		{
			get
			{
				return global::Autofac.Core.Resolving.ResolveOperationResources.ResourceManager.GetString("ExceptionDuringResolve", global::Autofac.Core.Resolving.ResolveOperationResources.resourceCulture);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00009900 File Offset: 0x00007B00
		internal static string MaxDepthExceeded
		{
			get
			{
				return global::Autofac.Core.Resolving.ResolveOperationResources.ResourceManager.GetString("MaxDepthExceeded", global::Autofac.Core.Resolving.ResolveOperationResources.resourceCulture);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00009916 File Offset: 0x00007B16
		internal static string TemporaryContextDisposed
		{
			get
			{
				return global::Autofac.Core.Resolving.ResolveOperationResources.ResourceManager.GetString("TemporaryContextDisposed", global::Autofac.Core.Resolving.ResolveOperationResources.resourceCulture);
			}
		}

		// Token: 0x040000BA RID: 186
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x040000BB RID: 187
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
