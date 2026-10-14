using System;
using System.ComponentModel;

namespace Infragistics.Controls
{
	// Token: 0x0200001F RID: 31
	public class ZoomChangeEventArgs : global::System.ComponentModel.CancelEventArgs
	{
		// Token: 0x060001A2 RID: 418 RVA: 0x00009114 File Offset: 0x00007314
		public ZoomChangeEventArgs(global::Infragistics.Controls.Range newRange)
		{
			this.NewRange = newRange;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00009123 File Offset: 0x00007323
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000912B File Offset: 0x0000732B
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

		// Token: 0x0400007D RID: 125
		private global::Infragistics.Controls.Range _newRange;
	}
}
