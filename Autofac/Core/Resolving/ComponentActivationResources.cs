using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac.Core.Resolving
{
	// Token: 0x0200007E RID: 126
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class ComponentActivationResources
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x00008FC4 File Offset: 0x000071C4
		internal ComponentActivationResources()
		{
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00008FCC File Offset: 0x000071CC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Resolving.ComponentActivationResources.resourceMan == null)
				{
					global::Autofac.Core.Resolving.ComponentActivationResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Resolving.ComponentActivationResources", typeof(global::Autofac.Core.Resolving.ComponentActivationResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Resolving.ComponentActivationResources.resourceMan;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00008FFD File Offset: 0x000071FD
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00009004 File Offset: 0x00007204
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Resolving.ComponentActivationResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Resolving.ComponentActivationResources.resourceCulture = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000900C File Offset: 0x0000720C
		public static string ActivationAlreadyExecuted
		{
			get
			{
				return global::Autofac.Core.Resolving.ComponentActivationResources.ResourceManager.GetString("ActivationAlreadyExecuted", global::Autofac.Core.Resolving.ComponentActivationResources.resourceCulture);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00009022 File Offset: 0x00007222
		public static string ErrorDuringActivation
		{
			get
			{
				return global::Autofac.Core.Resolving.ComponentActivationResources.ResourceManager.GetString("ErrorDuringActivation", global::Autofac.Core.Resolving.ComponentActivationResources.resourceCulture);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00009038 File Offset: 0x00007238
		public static string UnableToLocateLifetimeScope
		{
			get
			{
				return global::Autofac.Core.Resolving.ComponentActivationResources.ResourceManager.GetString("UnableToLocateLifetimeScope", global::Autofac.Core.Resolving.ComponentActivationResources.resourceCulture);
			}
		}

		// Token: 0x040000A0 RID: 160
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x040000A1 RID: 161
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
