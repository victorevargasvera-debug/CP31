using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Infragistics.Controls.Editors.Properties
{
	// Token: 0x0200005F RID: 95
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x0001966C File Offset: 0x0001786C
		internal Resources()
		{
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00019674 File Offset: 0x00017874
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(global::Infragistics.Controls.Editors.Properties.Resources.resourceMan, null))
				{
					global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager("Infragistics.Controls.Editors.Properties.Resources", typeof(global::Infragistics.Controls.Editors.Properties.Resources).Assembly);
					global::Infragistics.Controls.Editors.Properties.Resources.resourceMan = resourceManager;
				}
				return global::Infragistics.Controls.Editors.Properties.Resources.resourceMan;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000196B3 File Offset: 0x000178B3
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x000196BA File Offset: 0x000178BA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Infragistics.Controls.Editors.Properties.Resources.resourceCulture;
			}
			set
			{
				global::Infragistics.Controls.Editors.Properties.Resources.resourceCulture = value;
			}
		}

		// Token: 0x040001BC RID: 444
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x040001BD RID: 445
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
