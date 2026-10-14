using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Builder
{
	// Token: 0x020000C3 RID: 195
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class RegistrationBuilderResources
	{
		// Token: 0x0600046E RID: 1134 RVA: 0x0000CE3C File Offset: 0x0000B03C
		internal RegistrationBuilderResources()
		{
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0000CE44 File Offset: 0x0000B044
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Builder.RegistrationBuilderResources.resourceMan == null)
				{
					global::Autofac.Builder.RegistrationBuilderResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Builder.RegistrationBuilderResources", typeof(global::Autofac.Builder.RegistrationBuilderResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Builder.RegistrationBuilderResources.resourceMan;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000CE75 File Offset: 0x0000B075
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0000CE7C File Offset: 0x0000B07C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Builder.RegistrationBuilderResources.resourceCulture;
			}
			set
			{
				global::Autofac.Builder.RegistrationBuilderResources.resourceCulture = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0000CE84 File Offset: 0x0000B084
		internal static string ComponentDoesNotSupportService
		{
			get
			{
				return global::Autofac.Builder.RegistrationBuilderResources.ResourceManager.GetString("ComponentDoesNotSupportService", global::Autofac.Builder.RegistrationBuilderResources.resourceCulture);
			}
		}

		// Token: 0x04000134 RID: 308
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000135 RID: 309
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
