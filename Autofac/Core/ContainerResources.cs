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
	// Token: 0x02000061 RID: 97
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ContainerResources
	{
		// Token: 0x06000251 RID: 593 RVA: 0x00008718 File Offset: 0x00006918
		internal ContainerResources()
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00008720 File Offset: 0x00006920
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.ContainerResources.resourceMan == null)
				{
					global::Autofac.Core.ContainerResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.ContainerResources", typeof(global::Autofac.Core.ContainerResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.ContainerResources.resourceMan;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00008751 File Offset: 0x00006951
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00008758 File Offset: 0x00006958
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.ContainerResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.ContainerResources.resourceCulture = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00008760 File Offset: 0x00006960
		internal static string SelfRegistrationCannotBeActivated
		{
			get
			{
				return global::Autofac.Core.ContainerResources.ResourceManager.GetString("SelfRegistrationCannotBeActivated", global::Autofac.Core.ContainerResources.resourceCulture);
			}
		}

		// Token: 0x04000083 RID: 131
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000084 RID: 132
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
