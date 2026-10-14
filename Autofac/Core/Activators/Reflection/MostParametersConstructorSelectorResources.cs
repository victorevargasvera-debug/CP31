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
	// Token: 0x020000AF RID: 175
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal class MostParametersConstructorSelectorResources
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x0000C131 File Offset: 0x0000A331
		internal MostParametersConstructorSelectorResources()
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0000C139 File Offset: 0x0000A339
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.Core.Activators.Reflection.MostParametersConstructorSelectorResources.resourceMan == null)
				{
					global::Autofac.Core.Activators.Reflection.MostParametersConstructorSelectorResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.Core.Activators.Reflection.MostParametersConstructorSelectorResources", typeof(global::Autofac.Core.Activators.Reflection.MostParametersConstructorSelectorResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.Core.Activators.Reflection.MostParametersConstructorSelectorResources.resourceMan;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0000C16A File Offset: 0x0000A36A
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x0000C171 File Offset: 0x0000A371
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.MostParametersConstructorSelectorResources.resourceCulture;
			}
			set
			{
				global::Autofac.Core.Activators.Reflection.MostParametersConstructorSelectorResources.resourceCulture = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0000C179 File Offset: 0x0000A379
		internal static string UnableToChooseFromMultipleConstructors
		{
			get
			{
				return global::Autofac.Core.Activators.Reflection.MostParametersConstructorSelectorResources.ResourceManager.GetString("UnableToChooseFromMultipleConstructors", global::Autofac.Core.Activators.Reflection.MostParametersConstructorSelectorResources.resourceCulture);
			}
		}

		// Token: 0x0400010C RID: 268
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x0400010D RID: 269
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
