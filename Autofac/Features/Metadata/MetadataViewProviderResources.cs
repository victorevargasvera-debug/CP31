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
	// Token: 0x0200003B RID: 59
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class MetadataViewProviderResources
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00006D00 File Offset: 0x00004F00
		internal MetadataViewProviderResources()
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00006D08 File Offset: 0x00004F08
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Features.Metadata.MetadataViewProviderResources.resourceMan == null)
				{
					global::Autofac.Features.Metadata.MetadataViewProviderResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Features.Metadata.MetadataViewProviderResources", typeof(global::Autofac.Features.Metadata.MetadataViewProviderResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Features.Metadata.MetadataViewProviderResources.resourceMan;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00006D39 File Offset: 0x00004F39
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00006D40 File Offset: 0x00004F40
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Features.Metadata.MetadataViewProviderResources.resourceCulture;
			}
			set
			{
				global::Autofac.Features.Metadata.MetadataViewProviderResources.resourceCulture = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00006D48 File Offset: 0x00004F48
		internal static string InvalidViewImplementation
		{
			get
			{
				return global::Autofac.Features.Metadata.MetadataViewProviderResources.ResourceManager.GetString("InvalidViewImplementation", global::Autofac.Features.Metadata.MetadataViewProviderResources.resourceCulture);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00006D5E File Offset: 0x00004F5E
		internal static string MissingMetadata
		{
			get
			{
				return global::Autofac.Features.Metadata.MetadataViewProviderResources.ResourceManager.GetString("MissingMetadata", global::Autofac.Features.Metadata.MetadataViewProviderResources.resourceCulture);
			}
		}

		// Token: 0x04000048 RID: 72
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000049 RID: 73
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
