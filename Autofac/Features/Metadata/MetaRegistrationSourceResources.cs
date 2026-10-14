using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Features.Metadata
{
	// Token: 0x0200003D RID: 61
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class MetaRegistrationSourceResources
	{
		// Token: 0x060001AF RID: 431 RVA: 0x00006EA5 File Offset: 0x000050A5
		internal MetaRegistrationSourceResources()
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00006EAD File Offset: 0x000050AD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Features.Metadata.MetaRegistrationSourceResources.resourceMan == null)
				{
					global::Autofac.Features.Metadata.MetaRegistrationSourceResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Features.Metadata.MetaRegistrationSourceResources", typeof(global::Autofac.Features.Metadata.MetaRegistrationSourceResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Features.Metadata.MetaRegistrationSourceResources.resourceMan;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00006EDE File Offset: 0x000050DE
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00006EE5 File Offset: 0x000050E5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Features.Metadata.MetaRegistrationSourceResources.resourceCulture;
			}
			set
			{
				global::Autofac.Features.Metadata.MetaRegistrationSourceResources.resourceCulture = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00006EED File Offset: 0x000050ED
		internal static string MetaRegistrationSourceDescription
		{
			get
			{
				return global::Autofac.Features.Metadata.MetaRegistrationSourceResources.ResourceManager.GetString("MetaRegistrationSourceDescription", global::Autofac.Features.Metadata.MetaRegistrationSourceResources.resourceCulture);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00006F03 File Offset: 0x00005103
		internal static string StronglyTypedMetaRegistrationSourceDescription
		{
			get
			{
				return global::Autofac.Features.Metadata.MetaRegistrationSourceResources.ResourceManager.GetString("StronglyTypedMetaRegistrationSourceDescription", global::Autofac.Features.Metadata.MetaRegistrationSourceResources.resourceCulture);
			}
		}

		// Token: 0x0400004B RID: 75
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x0400004C RID: 76
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
