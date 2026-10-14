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
	// Token: 0x0200001C RID: 28
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class EnforceResources
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00004790 File Offset: 0x00002990
		internal EnforceResources()
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00004798 File Offset: 0x00002998
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Util.EnforceResources.resourceMan == null)
				{
					global::Autofac.Util.EnforceResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Util.EnforceResources", typeof(global::Autofac.Util.EnforceResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Util.EnforceResources.resourceMan;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000047C9 File Offset: 0x000029C9
		// (set) Token: 0x060000FB RID: 251 RVA: 0x000047D0 File Offset: 0x000029D0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Util.EnforceResources.resourceCulture;
			}
			set
			{
				global::Autofac.Util.EnforceResources.resourceCulture = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000047D8 File Offset: 0x000029D8
		internal static string CannotBeEmpty
		{
			get
			{
				return global::Autofac.Util.EnforceResources.ResourceManager.GetString("CannotBeEmpty", global::Autofac.Util.EnforceResources.resourceCulture);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000047EE File Offset: 0x000029EE
		internal static string CannotBeNull
		{
			get
			{
				return global::Autofac.Util.EnforceResources.ResourceManager.GetString("CannotBeNull", global::Autofac.Util.EnforceResources.resourceCulture);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00004804 File Offset: 0x00002A04
		internal static string DelegateReturnsVoid
		{
			get
			{
				return global::Autofac.Util.EnforceResources.ResourceManager.GetString("DelegateReturnsVoid", global::Autofac.Util.EnforceResources.resourceCulture);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000481A File Offset: 0x00002A1A
		internal static string ElementCannotBeNull
		{
			get
			{
				return global::Autofac.Util.EnforceResources.ResourceManager.GetString("ElementCannotBeNull", global::Autofac.Util.EnforceResources.resourceCulture);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00004830 File Offset: 0x00002A30
		internal static string NotDelegate
		{
			get
			{
				return global::Autofac.Util.EnforceResources.ResourceManager.GetString("NotDelegate", global::Autofac.Util.EnforceResources.resourceCulture);
			}
		}

		// Token: 0x0400001E RID: 30
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x0400001F RID: 31
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
