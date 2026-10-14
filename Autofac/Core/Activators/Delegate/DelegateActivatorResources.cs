using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Core.Activators.Delegate
{
	// Token: 0x020000B7 RID: 183
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class DelegateActivatorResources
	{
		// Token: 0x0600042B RID: 1067 RVA: 0x0000C8BB File Offset: 0x0000AABB
		internal DelegateActivatorResources()
		{
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0000C8C3 File Offset: 0x0000AAC3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Activators.Delegate.DelegateActivatorResources.resourceMan == null)
				{
					global::Autofac.Core.Activators.Delegate.DelegateActivatorResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Activators.Delegate.DelegateActivatorResources", typeof(global::Autofac.Core.Activators.Delegate.DelegateActivatorResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Activators.Delegate.DelegateActivatorResources.resourceMan;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0000C8F4 File Offset: 0x0000AAF4
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x0000C8FB File Offset: 0x0000AAFB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Activators.Delegate.DelegateActivatorResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Activators.Delegate.DelegateActivatorResources.resourceCulture = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0000C903 File Offset: 0x0000AB03
		internal static string NullFromActivationDelegateFor
		{
			get
			{
				return global::Autofac.Core.Activators.Delegate.DelegateActivatorResources.ResourceManager.GetString("NullFromActivationDelegateFor", global::Autofac.Core.Activators.Delegate.DelegateActivatorResources.resourceCulture);
			}
		}

		// Token: 0x04000120 RID: 288
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000121 RID: 289
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
