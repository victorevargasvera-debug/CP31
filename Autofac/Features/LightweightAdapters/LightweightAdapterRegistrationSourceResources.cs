using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Features.LightweightAdapters
{
	// Token: 0x02000044 RID: 68
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class LightweightAdapterRegistrationSourceResources
	{
		// Token: 0x060001CC RID: 460 RVA: 0x000073DE File Offset: 0x000055DE
		internal LightweightAdapterRegistrationSourceResources()
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000073E6 File Offset: 0x000055E6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources.resourceMan == null)
				{
					global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources", typeof(global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources.resourceMan;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00007417 File Offset: 0x00005617
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0000741E File Offset: 0x0000561E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources.resourceCulture;
			}
			set
			{
				global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources.resourceCulture = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00007426 File Offset: 0x00005626
		internal static string AdapterFromToDescription
		{
			get
			{
				return global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources.ResourceManager.GetString("AdapterFromToDescription", global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources.resourceCulture);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000743C File Offset: 0x0000563C
		internal static string FromAndToMustDiffer
		{
			get
			{
				return global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources.ResourceManager.GetString("FromAndToMustDiffer", global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources.resourceCulture);
			}
		}

		// Token: 0x04000056 RID: 86
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000057 RID: 87
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
