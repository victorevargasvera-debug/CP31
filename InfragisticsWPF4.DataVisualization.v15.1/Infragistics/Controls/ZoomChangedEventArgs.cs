using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x0200001E RID: 30
	public class ZoomChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600019F RID: 415 RVA: 0x000090F4 File Offset: 0x000072F4
		public ZoomChangedEventArgs(global::Infragistics.Controls.Range newRange)
		{
			this.NewRange = newRange;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00009103 File Offset: 0x00007303
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0000910B File Offset: 0x0000730B
		public global::Infragistics.Controls.Range NewRange
		{
			get
			{
				return this._newRange;
			}
			private set
			{
				this._newRange = value;
			}
		}

		// Token: 0x0400007C RID: 124
		private global::Infragistics.Controls.Range _newRange;
	}
}
