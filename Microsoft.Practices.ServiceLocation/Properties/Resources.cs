using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.Practices.ServiceLocation.Properties
{
	// Token: 0x02000004 RID: 4
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	internal class Resources
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000020F5 File Offset: 0x000010F5
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002100 File Offset: 0x00001100
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(global::Microsoft.Practices.ServiceLocation.Properties.Resources.resourceMan, null))
				{
					global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager("Microsoft.Practices.ServiceLocation.Properties.Resources", typeof(global::Microsoft.Practices.ServiceLocation.Properties.Resources).Assembly);
					global::Microsoft.Practices.ServiceLocation.Properties.Resources.resourceMan = resourceManager;
				}
				return global::Microsoft.Practices.ServiceLocation.Properties.Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000213F File Offset: 0x0000113F
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002146 File Offset: 0x00001146
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Microsoft.Practices.ServiceLocation.Properties.Resources.resourceCulture;
			}
			set
			{
				global::Microsoft.Practices.ServiceLocation.Properties.Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000214E File Offset: 0x0000114E
		internal static string ActivateAllExceptionMessage
		{
			get
			{
				return global::Microsoft.Practices.ServiceLocation.Properties.Resources.ResourceManager.GetString("ActivateAllExceptionMessage", global::Microsoft.Practices.ServiceLocation.Properties.Resources.resourceCulture);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002164 File Offset: 0x00001164
		internal static string ActivationExceptionMessage
		{
			get
			{
				return global::Microsoft.Practices.ServiceLocation.Properties.Resources.ResourceManager.GetString("ActivationExceptionMessage", global::Microsoft.Practices.ServiceLocation.Properties.Resources.resourceCulture);
			}
		}

		// Token: 0x04000001 RID: 1
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000002 RID: 2
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
