using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Util
{
	// Token: 0x0200001E RID: 30
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	public class FallbackDictionaryResources
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00004AA1 File Offset: 0x00002CA1
		internal FallbackDictionaryResources()
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00004AA9 File Offset: 0x00002CA9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Util.FallbackDictionaryResources.resourceMan == null)
				{
					global::Autofac.Util.FallbackDictionaryResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Util.FallbackDictionaryResources", typeof(global::Autofac.Util.FallbackDictionaryResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Util.FallbackDictionaryResources.resourceMan;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00004ADA File Offset: 0x00002CDA
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00004AE1 File Offset: 0x00002CE1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Util.FallbackDictionaryResources.resourceCulture;
			}
			set
			{
				global::Autofac.Util.FallbackDictionaryResources.resourceCulture = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00004AE9 File Offset: 0x00002CE9
		public static string DuplicateItem
		{
			get
			{
				return global::Autofac.Util.FallbackDictionaryResources.ResourceManager.GetString("DuplicateItem", global::Autofac.Util.FallbackDictionaryResources.resourceCulture);
			}
		}

		// Token: 0x04000022 RID: 34
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000023 RID: 35
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
