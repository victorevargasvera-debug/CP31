using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DevAge.Properties
{
	// Token: 0x02000300 RID: 768
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x060024BB RID: 9403 RVA: 0x00080348 File Offset: 0x0007E548
		internal Resources()
		{
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x00080350 File Offset: 0x0007E550
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(global::DevAge.Properties.Resources.resourceMan, null))
				{
					global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager("DevAge.Properties.Resources", typeof(global::DevAge.Properties.Resources).Assembly);
					global::DevAge.Properties.Resources.resourceMan = resourceManager;
				}
				return global::DevAge.Properties.Resources.resourceMan;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x00080398 File Offset: 0x0007E598
		// (set) Token: 0x060024BE RID: 9406 RVA: 0x000803A0 File Offset: 0x0007E5A0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::DevAge.Properties.Resources.resourceCulture;
			}
			set
			{
				global::DevAge.Properties.Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x000803A8 File Offset: 0x0007E5A8
		internal static byte[] CURSOR_Left
		{
			get
			{
				object @object = global::DevAge.Properties.Resources.ResourceManager.GetObject("CURSOR_Left", global::DevAge.Properties.Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x000803D4 File Offset: 0x0007E5D4
		internal static byte[] CURSOR_Right
		{
			get
			{
				object @object = global::DevAge.Properties.Resources.ResourceManager.GetObject("CURSOR_Right", global::DevAge.Properties.Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x00080400 File Offset: 0x0007E600
		internal static global::System.Drawing.Icon ICO_DropDown
		{
			get
			{
				object @object = global::DevAge.Properties.Resources.ResourceManager.GetObject("ICO_DropDown", global::DevAge.Properties.Resources.resourceCulture);
				return (global::System.Drawing.Icon)@object;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x0008042C File Offset: 0x0007E62C
		internal static global::System.Drawing.Icon ICO_SortDown
		{
			get
			{
				object @object = global::DevAge.Properties.Resources.ResourceManager.GetObject("ICO_SortDown", global::DevAge.Properties.Resources.resourceCulture);
				return (global::System.Drawing.Icon)@object;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x00080458 File Offset: 0x0007E658
		internal static global::System.Drawing.Icon ICO_SortUp
		{
			get
			{
				object @object = global::DevAge.Properties.Resources.ResourceManager.GetObject("ICO_SortUp", global::DevAge.Properties.Resources.resourceCulture);
				return (global::System.Drawing.Icon)@object;
			}
		}

		// Token: 0x04000CDD RID: 3293
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000CDE RID: 3294
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
