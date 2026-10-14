using System;
using System.Windows;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x020000B6 RID: 182
	public class EditModeEndingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060009EF RID: 2543 RVA: 0x0002D636 File Offset: 0x0002B836
		public EditModeEndingEventArgs(bool acceptChanges, bool force)
		{
			this._force = force;
			this._acceptChanges = acceptChanges;
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0002D64C File Offset: 0x0002B84C
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x0002D654 File Offset: 0x0002B854
		public bool AcceptChanges
		{
			get
			{
				return this._acceptChanges;
			}
			set
			{
				this._acceptChanges = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0002D65D File Offset: 0x0002B85D
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x0002D665 File Offset: 0x0002B865
		public bool Cancel
		{
			get
			{
				return this._cancel;
			}
			set
			{
				if (value && this._force)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_1"));
				}
				this._cancel = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0002D689 File Offset: 0x0002B889
		public bool Force
		{
			get
			{
				return this._force;
			}
		}

		// Token: 0x0400037A RID: 890
		private bool _cancel;

		// Token: 0x0400037B RID: 891
		private bool _acceptChanges;

		// Token: 0x0400037C RID: 892
		private bool _force;
	}
}
