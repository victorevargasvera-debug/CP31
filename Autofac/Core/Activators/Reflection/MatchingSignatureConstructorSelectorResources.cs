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
	// Token: 0x020000AD RID: 173
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class MatchingSignatureConstructorSelectorResources
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x0000BF95 File Offset: 0x0000A195
		internal MatchingSignatureConstructorSelectorResources()
		{
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000BF9D File Offset: 0x0000A19D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.resourceMan == null)
				{
					global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources", typeof(global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.resourceMan;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0000BFCE File Offset: 0x0000A1CE
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0000BFD5 File Offset: 0x0000A1D5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.resourceCulture = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0000BFDD File Offset: 0x0000A1DD
		internal static string AtLeastOneBindingRequired
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.ResourceManager.GetString("AtLeastOneBindingRequired", global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.resourceCulture);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0000BFF3 File Offset: 0x0000A1F3
		internal static string RequiredConstructorNotAvailable
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.ResourceManager.GetString("RequiredConstructorNotAvailable", global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.resourceCulture);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000C009 File Offset: 0x0000A209
		internal static string TooManyConstructorsMatch
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.ResourceManager.GetString("TooManyConstructorsMatch", global::Autofac.Core.Activators.Reflection.MatchingSignatureConstructorSelectorResources.resourceCulture);
			}
		}

		// Token: 0x0400010A RID: 266
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x0400010B RID: 267
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
