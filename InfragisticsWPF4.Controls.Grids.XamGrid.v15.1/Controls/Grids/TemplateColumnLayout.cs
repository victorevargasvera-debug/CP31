using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000267 RID: 615
	public class TemplateColumnLayout : global::Infragistics.Controls.Grids.ColumnLayout
	{
		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0004AA24 File Offset: 0x00048C24
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x0004AA2C File Offset: 0x00048C2C
		public global::System.Windows.DataTemplate Template
		{
			get
			{
				return base.InternalTemplate;
			}
			set
			{
				base.InternalTemplate = value;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0004AA35 File Offset: 0x00048C35
		protected internal override bool RequiresBoundDataKey
		{
			get
			{
				return false;
			}
		}
	}
}
