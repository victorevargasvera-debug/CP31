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
	// Token: 0x02000039 RID: 57
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class OpenGenericServiceBinderResources
	{
		// Token: 0x06000197 RID: 407 RVA: 0x0000690C File Offset: 0x00004B0C
		internal OpenGenericServiceBinderResources()
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00006914 File Offset: 0x00004B14
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.resourceMan == null)
				{
					global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources", typeof(global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.resourceMan;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00006945 File Offset: 0x00004B45
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0000694C File Offset: 0x00004B4C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.resourceCulture;
			}
			set
			{
				global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.resourceCulture = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00006954 File Offset: 0x00004B54
		internal static string ImplementorDoesntImplementService
		{
			get
			{
				return global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.ResourceManager.GetString("ImplementorDoesntImplementService", global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.resourceCulture);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000696A File Offset: 0x00004B6A
		internal static string ImplementorMustBeOpenGenericTypeDefinition
		{
			get
			{
				return global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.ResourceManager.GetString("ImplementorMustBeOpenGenericTypeDefinition", global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.resourceCulture);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00006980 File Offset: 0x00004B80
		internal static string InterfaceIsNotImplemented
		{
			get
			{
				return global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.ResourceManager.GetString("InterfaceIsNotImplemented", global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.resourceCulture);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00006996 File Offset: 0x00004B96
		internal static string ServiceTypeMustBeOpenGenericTypeDefinition
		{
			get
			{
				return global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.ResourceManager.GetString("ServiceTypeMustBeOpenGenericTypeDefinition", global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.resourceCulture);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000069AC File Offset: 0x00004BAC
		internal static string TypesAreNotConvertible
		{
			get
			{
				return global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.ResourceManager.GetString("TypesAreNotConvertible", global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.resourceCulture);
			}
		}

		// Token: 0x04000045 RID: 69
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000046 RID: 70
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
