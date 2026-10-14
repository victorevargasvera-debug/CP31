using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac
{
	// Token: 0x02000006 RID: 6
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ContainerBuilderResources
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000026B7 File Offset: 0x000008B7
		internal ContainerBuilderResources()
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000026BF File Offset: 0x000008BF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.ContainerBuilderResources.resourceMan == null)
				{
					global::Autofac.ContainerBuilderResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.ContainerBuilderResources", typeof(global::Autofac.ContainerBuilderResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.ContainerBuilderResources.resourceMan;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000026F0 File Offset: 0x000008F0
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000026F7 File Offset: 0x000008F7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.ContainerBuilderResources.resourceCulture;
			}
			set
			{
				global::Autofac.ContainerBuilderResources.resourceCulture = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000026FF File Offset: 0x000008FF
		internal static string BuildCanOnlyBeCalledOnce
		{
			get
			{
				return global::Autofac.ContainerBuilderResources.ResourceManager.GetString("BuildCanOnlyBeCalledOnce", global::Autofac.ContainerBuilderResources.resourceCulture);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002715 File Offset: 0x00000915
		internal static string ErrorAutoActivating
		{
			get
			{
				return global::Autofac.ContainerBuilderResources.ResourceManager.GetString("ErrorAutoActivating", global::Autofac.ContainerBuilderResources.resourceCulture);
			}
		}

		// Token: 0x0400000B RID: 11
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x0400000C RID: 12
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
