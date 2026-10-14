using System;
using System.ComponentModel;

namespace DevAge.ComponentModel
{
	// Token: 0x0200029F RID: 671
	internal class EmptyTypeDescriptorContext : global::System.ComponentModel.ITypeDescriptorContext, global::System.IServiceProvider
	{
		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x00077C70 File Offset: 0x00075E70
		public static global::DevAge.ComponentModel.EmptyTypeDescriptorContext Empty
		{
			get
			{
				return global::DevAge.ComponentModel.EmptyTypeDescriptorContext.t_Empty;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x00077C78 File Offset: 0x00075E78
		public global::System.ComponentModel.IContainer Container
		{
			get
			{
				return this.container;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x00077C80 File Offset: 0x00075E80
		public object Instance
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00077C84 File Offset: 0x00075E84
		public void OnComponentChanged()
		{
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00077C88 File Offset: 0x00075E88
		public bool OnComponentChanging()
		{
			return true;
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00077C8C File Offset: 0x00075E8C
		public global::System.ComponentModel.PropertyDescriptor PropertyDescriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00077C90 File Offset: 0x00075E90
		public object GetService(global::System.Type serviceType)
		{
			return null;
		}

		// Token: 0x04000C3B RID: 3131
		[global::System.ThreadStatic]
		private static global::DevAge.ComponentModel.EmptyTypeDescriptorContext t_Empty;

		// Token: 0x04000C3C RID: 3132
		private readonly global::DevAge.ComponentModel.EmptyContainer container = new global::DevAge.ComponentModel.EmptyContainer();
	}
}
