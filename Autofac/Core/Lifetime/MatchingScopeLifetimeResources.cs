using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Core.Lifetime
{
	// Token: 0x0200009F RID: 159
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class MatchingScopeLifetimeResources
	{
		// Token: 0x060003CA RID: 970 RVA: 0x0000B51F File Offset: 0x0000971F
		internal MatchingScopeLifetimeResources()
		{
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0000B527 File Offset: 0x00009727
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Lifetime.MatchingScopeLifetimeResources.resourceMan == null)
				{
					global::Autofac.Core.Lifetime.MatchingScopeLifetimeResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Lifetime.MatchingScopeLifetimeResources", typeof(global::Autofac.Core.Lifetime.MatchingScopeLifetimeResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Lifetime.MatchingScopeLifetimeResources.resourceMan;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0000B558 File Offset: 0x00009758
		// (set) Token: 0x060003CD RID: 973 RVA: 0x0000B55F File Offset: 0x0000975F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Lifetime.MatchingScopeLifetimeResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Lifetime.MatchingScopeLifetimeResources.resourceCulture = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0000B567 File Offset: 0x00009767
		internal static string MatchingScopeNotFound
		{
			get
			{
				return global::Autofac.Core.Lifetime.MatchingScopeLifetimeResources.ResourceManager.GetString("MatchingScopeNotFound", global::Autofac.Core.Lifetime.MatchingScopeLifetimeResources.resourceCulture);
			}
		}

		// Token: 0x040000FB RID: 251
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x040000FC RID: 252
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
