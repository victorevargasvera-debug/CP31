using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac
{
	// Token: 0x02000018 RID: 24
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class TypeExtensionsResources
	{
		// Token: 0x060000EA RID: 234 RVA: 0x000044F2 File Offset: 0x000026F2
		internal TypeExtensionsResources()
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000044FA File Offset: 0x000026FA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.TypeExtensionsResources.resourceMan == null)
				{
					global::Autofac.TypeExtensionsResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.TypeExtensionsResources", typeof(global::Autofac.TypeExtensionsResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.TypeExtensionsResources.resourceMan;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000452B File Offset: 0x0000272B
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00004532 File Offset: 0x00002732
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.TypeExtensionsResources.resourceCulture;
			}
			set
			{
				global::Autofac.TypeExtensionsResources.resourceCulture = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000453A File Offset: 0x0000273A
		public static string NotOpenGenericType
		{
			get
			{
				return global::Autofac.TypeExtensionsResources.ResourceManager.GetString("NotOpenGenericType", global::Autofac.TypeExtensionsResources.resourceCulture);
			}
		}

		// Token: 0x0400001A RID: 26
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x0400001B RID: 27
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
