using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Util
{
	// Token: 0x02000020 RID: 32
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ReflectionExtensionsResources
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00004C73 File Offset: 0x00002E73
		internal ReflectionExtensionsResources()
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00004C7B File Offset: 0x00002E7B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Util.ReflectionExtensionsResources.resourceMan == null)
				{
					global::Autofac.Util.ReflectionExtensionsResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Util.ReflectionExtensionsResources", typeof(global::Autofac.Util.ReflectionExtensionsResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Util.ReflectionExtensionsResources.resourceMan;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00004CAC File Offset: 0x00002EAC
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00004CB3 File Offset: 0x00002EB3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Util.ReflectionExtensionsResources.resourceCulture;
			}
			set
			{
				global::Autofac.Util.ReflectionExtensionsResources.resourceCulture = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00004CBB File Offset: 0x00002EBB
		internal static string ExpressionNotConstructorCall
		{
			get
			{
				return global::Autofac.Util.ReflectionExtensionsResources.ResourceManager.GetString("ExpressionNotConstructorCall", global::Autofac.Util.ReflectionExtensionsResources.resourceCulture);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00004CD1 File Offset: 0x00002ED1
		internal static string ExpressionNotMethodCall
		{
			get
			{
				return global::Autofac.Util.ReflectionExtensionsResources.ResourceManager.GetString("ExpressionNotMethodCall", global::Autofac.Util.ReflectionExtensionsResources.resourceCulture);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00004CE7 File Offset: 0x00002EE7
		internal static string ExpressionNotPropertyAccessor
		{
			get
			{
				return global::Autofac.Util.ReflectionExtensionsResources.ResourceManager.GetString("ExpressionNotPropertyAccessor", global::Autofac.Util.ReflectionExtensionsResources.resourceCulture);
			}
		}

		// Token: 0x04000024 RID: 36
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000025 RID: 37
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
