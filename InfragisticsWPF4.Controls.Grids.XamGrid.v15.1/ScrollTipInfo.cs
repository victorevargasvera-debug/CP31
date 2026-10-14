using System;
using System.Windows;
using Infragistics.Controls.Grids;

namespace Infragistics
{
	// Token: 0x02000064 RID: 100
	public class ScrollTipInfo : global::System.Windows.FrameworkElement
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00010063 File Offset: 0x0000E263
		// (set) Token: 0x06000374 RID: 884 RVA: 0x0001006B File Offset: 0x0000E26B
		public global::Infragistics.Controls.Grids.RowBase Row { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00010074 File Offset: 0x0000E274
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00010081 File Offset: 0x0000E281
		public object FirstColumnValue
		{
			get
			{
				return base.GetValue(global::Infragistics.ScrollTipInfo.FirstColumnValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.ScrollTipInfo.FirstColumnValueProperty, value);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0001008F File Offset: 0x0000E28F
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00010097 File Offset: 0x0000E297
		public global::Infragistics.Controls.Grids.Column Column { get; set; }

		// Token: 0x040000D8 RID: 216
		public static readonly global::System.Windows.DependencyProperty FirstColumnValueProperty = global::System.Windows.DependencyProperty.Register("FirstColumnValue", typeof(object), typeof(global::Infragistics.ScrollTipInfo), null);
	}
}
