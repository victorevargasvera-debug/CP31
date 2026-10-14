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
	// Token: 0x02000063 RID: 99
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class DependencyResolutionExceptionResources
	{
		// Token: 0x06000259 RID: 601 RVA: 0x000087D5 File Offset: 0x000069D5
		internal DependencyResolutionExceptionResources()
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600025A RID: 602 RVA: 0x000087DD File Offset: 0x000069DD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.DependencyResolutionExceptionResources.resourceMan == null)
				{
					global::Autofac.Core.DependencyResolutionExceptionResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.DependencyResolutionExceptionResources", typeof(global::Autofac.Core.DependencyResolutionExceptionResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.DependencyResolutionExceptionResources.resourceMan;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000880E File Offset: 0x00006A0E
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00008815 File Offset: 0x00006A15
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.DependencyResolutionExceptionResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.DependencyResolutionExceptionResources.resourceCulture = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000881D File Offset: 0x00006A1D
		internal static string MessageNestingFormat
		{
			get
			{
				return global::Autofac.Core.DependencyResolutionExceptionResources.ResourceManager.GetString("MessageNestingFormat", global::Autofac.Core.DependencyResolutionExceptionResources.resourceCulture);
			}
		}

		// Token: 0x04000085 RID: 133
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000086 RID: 134
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
