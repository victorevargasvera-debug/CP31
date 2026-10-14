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
	// Token: 0x0200008C RID: 140
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ComponentNotRegisteredExceptionResources
	{
		// Token: 0x06000320 RID: 800 RVA: 0x00009B12 File Offset: 0x00007D12
		internal ComponentNotRegisteredExceptionResources()
		{
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00009B1A File Offset: 0x00007D1A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Registration.ComponentNotRegisteredExceptionResources.resourceMan == null)
				{
					global::Autofac.Core.Registration.ComponentNotRegisteredExceptionResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Registration.ComponentNotRegisteredExceptionResources", typeof(global::Autofac.Core.Registration.ComponentNotRegisteredExceptionResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Registration.ComponentNotRegisteredExceptionResources.resourceMan;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00009B4B File Offset: 0x00007D4B
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00009B52 File Offset: 0x00007D52
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Registration.ComponentNotRegisteredExceptionResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Registration.ComponentNotRegisteredExceptionResources.resourceCulture = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00009B5A File Offset: 0x00007D5A
		internal static string Message
		{
			get
			{
				return global::Autofac.Core.Registration.ComponentNotRegisteredExceptionResources.ResourceManager.GetString("Message", global::Autofac.Core.Registration.ComponentNotRegisteredExceptionResources.resourceCulture);
			}
		}

		// Token: 0x040000C1 RID: 193
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x040000C2 RID: 194
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
