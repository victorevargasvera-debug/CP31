using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Features.OpenGenerics
{
	// Token: 0x02000031 RID: 49
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class OpenGenericDecoratorActivatorDataResources
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00005E02 File Offset: 0x00004002
		internal OpenGenericDecoratorActivatorDataResources()
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00005E0A File Offset: 0x0000400A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorDataResources.resourceMan == null)
				{
					global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorDataResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorDataResources", typeof(global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorDataResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorDataResources.resourceMan;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00005E3B File Offset: 0x0000403B
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00005E42 File Offset: 0x00004042
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorDataResources.resourceCulture;
			}
			set
			{
				global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorDataResources.resourceCulture = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00005E4A File Offset: 0x0000404A
		internal static string DecoratedServiceIsNotOpenGeneric
		{
			get
			{
				return global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorDataResources.ResourceManager.GetString("DecoratedServiceIsNotOpenGeneric", global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorDataResources.resourceCulture);
			}
		}

		// Token: 0x04000039 RID: 57
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x0400003A RID: 58
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
