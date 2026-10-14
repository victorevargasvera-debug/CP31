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
	// Token: 0x02000098 RID: 152
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ServiceRegistrationInfoResources
	{
		// Token: 0x06000397 RID: 919 RVA: 0x0000ACD2 File Offset: 0x00008ED2
		internal ServiceRegistrationInfoResources()
		{
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0000ACDA File Offset: 0x00008EDA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Registration.ServiceRegistrationInfoResources.resourceMan == null)
				{
					global::Autofac.Core.Registration.ServiceRegistrationInfoResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Registration.ServiceRegistrationInfoResources", typeof(global::Autofac.Core.Registration.ServiceRegistrationInfoResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Registration.ServiceRegistrationInfoResources.resourceMan;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0000AD0B File Offset: 0x00008F0B
		// (set) Token: 0x0600039A RID: 922 RVA: 0x0000AD12 File Offset: 0x00008F12
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Registration.ServiceRegistrationInfoResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Registration.ServiceRegistrationInfoResources.resourceCulture = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000AD1A File Offset: 0x00008F1A
		internal static string NotDuringInitialization
		{
			get
			{
				return global::Autofac.Core.Registration.ServiceRegistrationInfoResources.ResourceManager.GetString("NotDuringInitialization", global::Autofac.Core.Registration.ServiceRegistrationInfoResources.resourceCulture);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000AD30 File Offset: 0x00008F30
		internal static string NotInitialized
		{
			get
			{
				return global::Autofac.Core.Registration.ServiceRegistrationInfoResources.ResourceManager.GetString("NotInitialized", global::Autofac.Core.Registration.ServiceRegistrationInfoResources.resourceCulture);
			}
		}

		// Token: 0x040000E7 RID: 231
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x040000E8 RID: 232
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
