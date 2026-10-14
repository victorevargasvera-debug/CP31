using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Core
{
	// Token: 0x02000079 RID: 121
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ServiceResources
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x00008C85 File Offset: 0x00006E85
		internal ServiceResources()
		{
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00008C8D File Offset: 0x00006E8D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.ServiceResources.resourceMan == null)
				{
					global::Autofac.Core.ServiceResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.ServiceResources", typeof(global::Autofac.Core.ServiceResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.ServiceResources.resourceMan;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00008CBE File Offset: 0x00006EBE
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x00008CC5 File Offset: 0x00006EC5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.ServiceResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.ServiceResources.resourceCulture = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00008CCD File Offset: 0x00006ECD
		internal static string MustOverrideEquals
		{
			get
			{
				return global::Autofac.Core.ServiceResources.ResourceManager.GetString("MustOverrideEquals", global::Autofac.Core.ServiceResources.resourceCulture);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00008CE3 File Offset: 0x00006EE3
		internal static string MustOverrideGetHashCode
		{
			get
			{
				return global::Autofac.Core.ServiceResources.ResourceManager.GetString("MustOverrideGetHashCode", global::Autofac.Core.ServiceResources.resourceCulture);
			}
		}

		// Token: 0x04000099 RID: 153
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x0400009A RID: 154
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
