using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Features.LazyDependencies
{
	// Token: 0x02000046 RID: 70
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class LazyRegistrationSourceResources
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x00007585 File Offset: 0x00005785
		internal LazyRegistrationSourceResources()
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000758D File Offset: 0x0000578D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Features.LazyDependencies.LazyRegistrationSourceResources.resourceMan == null)
				{
					global::Autofac.Features.LazyDependencies.LazyRegistrationSourceResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Features.LazyDependencies.LazyRegistrationSourceResources", typeof(global::Autofac.Features.LazyDependencies.LazyRegistrationSourceResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Features.LazyDependencies.LazyRegistrationSourceResources.resourceMan;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000075BE File Offset: 0x000057BE
		// (set) Token: 0x060001DB RID: 475 RVA: 0x000075C5 File Offset: 0x000057C5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Features.LazyDependencies.LazyRegistrationSourceResources.resourceCulture;
			}
			set
			{
				global::Autofac.Features.LazyDependencies.LazyRegistrationSourceResources.resourceCulture = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001DC RID: 476 RVA: 0x000075CD File Offset: 0x000057CD
		internal static string LazyRegistrationSourceDescription
		{
			get
			{
				return global::Autofac.Features.LazyDependencies.LazyRegistrationSourceResources.ResourceManager.GetString("LazyRegistrationSourceDescription", global::Autofac.Features.LazyDependencies.LazyRegistrationSourceResources.resourceCulture);
			}
		}

		// Token: 0x04000059 RID: 89
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x0400005A RID: 90
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
