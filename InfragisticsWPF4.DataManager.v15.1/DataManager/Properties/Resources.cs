using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Infragistics.DataManager.Properties
{
	// Token: 0x02000047 RID: 71
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class Resources
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		internal Resources()
		{
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000E1F8 File Offset: 0x0000C3F8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(global::Infragistics.DataManager.Properties.Resources.resourceMan, null))
				{
					global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager("Infragistics.DataManager.Properties.Resources", typeof(global::Infragistics.DataManager.Properties.Resources).Assembly);
					global::Infragistics.DataManager.Properties.Resources.resourceMan = resourceManager;
				}
				return global::Infragistics.DataManager.Properties.Resources.resourceMan;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000E237 File Offset: 0x0000C437
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x0000E23E File Offset: 0x0000C43E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Infragistics.DataManager.Properties.Resources.resourceCulture;
			}
			set
			{
				global::Infragistics.DataManager.Properties.Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000113 RID: 275
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000114 RID: 276
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
