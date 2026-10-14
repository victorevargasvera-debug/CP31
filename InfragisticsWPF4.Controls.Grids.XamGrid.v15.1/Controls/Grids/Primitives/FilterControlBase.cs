using System;
using System.ComponentModel;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000B7 RID: 183
	public abstract class FilterControlBase : global::System.Windows.Controls.ContentControl, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000629 RID: 1577
		// (set) Token: 0x0600062A RID: 1578
		public abstract global::Infragistics.Controls.Grids.Primitives.FilterRowCell Cell { get; set; }

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600062B RID: 1579 RVA: 0x0001C334 File Offset: 0x0001A534
		// (remove) Token: 0x0600062C RID: 1580 RVA: 0x0001C36C File Offset: 0x0001A56C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600062D RID: 1581 RVA: 0x0001C3A1 File Offset: 0x0001A5A1
		protected internal void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0001C3BD File Offset: 0x0001A5BD
		protected internal virtual void EnsureContent()
		{
		}
	}
}
