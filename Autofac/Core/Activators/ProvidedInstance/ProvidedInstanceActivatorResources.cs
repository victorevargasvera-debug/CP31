using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Core.Activators.ProvidedInstance
{
	// Token: 0x020000B5 RID: 181
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ProvidedInstanceActivatorResources
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x0000C7DF File Offset: 0x0000A9DF
		internal ProvidedInstanceActivatorResources()
		{
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0000C7E7 File Offset: 0x0000A9E7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivatorResources.resourceMan == null)
				{
					global::Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivatorResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivatorResources", typeof(global::Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivatorResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivatorResources.resourceMan;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0000C818 File Offset: 0x0000AA18
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x0000C81F File Offset: 0x0000AA1F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivatorResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivatorResources.resourceCulture = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0000C827 File Offset: 0x0000AA27
		public static string InstanceAlreadyActivated
		{
			get
			{
				return global::Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivatorResources.ResourceManager.GetString("InstanceAlreadyActivated", global::Autofac.Core.Activators.ProvidedInstance.ProvidedInstanceActivatorResources.resourceCulture);
			}
		}

		// Token: 0x0400011D RID: 285
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x0400011E RID: 286
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
