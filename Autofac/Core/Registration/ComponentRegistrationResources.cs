using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Core.Registration
{
	// Token: 0x02000090 RID: 144
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ComponentRegistrationResources
	{
		// Token: 0x0600034F RID: 847 RVA: 0x0000A039 File Offset: 0x00008239
		internal ComponentRegistrationResources()
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0000A041 File Offset: 0x00008241
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Registration.ComponentRegistrationResources.resourceMan == null)
				{
					global::Autofac.Core.Registration.ComponentRegistrationResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Registration.ComponentRegistrationResources", typeof(global::Autofac.Core.Registration.ComponentRegistrationResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Registration.ComponentRegistrationResources.resourceMan;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000A072 File Offset: 0x00008272
		// (set) Token: 0x06000352 RID: 850 RVA: 0x0000A079 File Offset: 0x00008279
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Registration.ComponentRegistrationResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Registration.ComponentRegistrationResources.resourceCulture = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000A081 File Offset: 0x00008281
		internal static string ToStringFormat
		{
			get
			{
				return global::Autofac.Core.Registration.ComponentRegistrationResources.ResourceManager.GetString("ToStringFormat", global::Autofac.Core.Registration.ComponentRegistrationResources.resourceCulture);
			}
		}

		// Token: 0x040000D0 RID: 208
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x040000D1 RID: 209
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
