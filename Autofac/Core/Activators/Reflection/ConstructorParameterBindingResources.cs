using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000A7 RID: 167
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ConstructorParameterBindingResources
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x0000BC41 File Offset: 0x00009E41
		internal ConstructorParameterBindingResources()
		{
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000BC49 File Offset: 0x00009E49
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.resourceMan == null)
				{
					global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources", typeof(global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.resourceMan;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0000BC7A File Offset: 0x00009E7A
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x0000BC81 File Offset: 0x00009E81
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.resourceCulture = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0000BC89 File Offset: 0x00009E89
		public static string BoundConstructor
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.ResourceManager.GetString("BoundConstructor", global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.resourceCulture);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0000BC9F File Offset: 0x00009E9F
		public static string CannotInstantitate
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.ResourceManager.GetString("CannotInstantitate", global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.resourceCulture);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000BCB5 File Offset: 0x00009EB5
		public static string ExceptionDuringInstantiation
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.ResourceManager.GetString("ExceptionDuringInstantiation", global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.resourceCulture);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000BCCB File Offset: 0x00009ECB
		public static string NonBindableConstructor
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.ResourceManager.GetString("NonBindableConstructor", global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.resourceCulture);
			}
		}

		// Token: 0x04000105 RID: 261
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000106 RID: 262
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
