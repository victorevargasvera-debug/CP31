using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Features.OwnedInstances
{
	// Token: 0x0200002F RID: 47
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class OwnedInstanceRegistrationSourceResources
	{
		// Token: 0x06000169 RID: 361 RVA: 0x00005D40 File Offset: 0x00003F40
		internal OwnedInstanceRegistrationSourceResources()
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00005D48 File Offset: 0x00003F48
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Features.OwnedInstances.OwnedInstanceRegistrationSourceResources.resourceMan == null)
				{
					global::Autofac.Features.OwnedInstances.OwnedInstanceRegistrationSourceResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Features.OwnedInstances.OwnedInstanceRegistrationSourceResources", typeof(global::Autofac.Features.OwnedInstances.OwnedInstanceRegistrationSourceResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Features.OwnedInstances.OwnedInstanceRegistrationSourceResources.resourceMan;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00005D79 File Offset: 0x00003F79
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00005D80 File Offset: 0x00003F80
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Features.OwnedInstances.OwnedInstanceRegistrationSourceResources.resourceCulture;
			}
			set
			{
				global::Autofac.Features.OwnedInstances.OwnedInstanceRegistrationSourceResources.resourceCulture = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00005D88 File Offset: 0x00003F88
		internal static string OwnedInstanceRegistrationSourceDescription
		{
			get
			{
				return global::Autofac.Features.OwnedInstances.OwnedInstanceRegistrationSourceResources.ResourceManager.GetString("OwnedInstanceRegistrationSourceDescription", global::Autofac.Features.OwnedInstances.OwnedInstanceRegistrationSourceResources.resourceCulture);
			}
		}

		// Token: 0x04000036 RID: 54
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000037 RID: 55
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
