using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000B3 RID: 179
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ReflectionActivatorResources
	{
		// Token: 0x06000418 RID: 1048 RVA: 0x0000C68C File Offset: 0x0000A88C
		internal ReflectionActivatorResources()
		{
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0000C694 File Offset: 0x0000A894
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Activators.Reflection.ReflectionActivatorResources.resourceMan == null)
				{
					global::Autofac.Core.Activators.Reflection.ReflectionActivatorResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Activators.Reflection.ReflectionActivatorResources", typeof(global::Autofac.Core.Activators.Reflection.ReflectionActivatorResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Activators.Reflection.ReflectionActivatorResources.resourceMan;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0000C6C5 File Offset: 0x0000A8C5
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x0000C6CC File Offset: 0x0000A8CC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.ReflectionActivatorResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Activators.Reflection.ReflectionActivatorResources.resourceCulture = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		internal static string NoConstructorsAvailable
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.ReflectionActivatorResources.ResourceManager.GetString("NoConstructorsAvailable", global::Autofac.Core.Activators.Reflection.ReflectionActivatorResources.resourceCulture);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0000C6EA File Offset: 0x0000A8EA
		internal static string NoConstructorsBindable
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.ReflectionActivatorResources.ResourceManager.GetString("NoConstructorsBindable", global::Autofac.Core.Activators.Reflection.ReflectionActivatorResources.resourceCulture);
			}
		}

		// Token: 0x04000118 RID: 280
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000119 RID: 281
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
