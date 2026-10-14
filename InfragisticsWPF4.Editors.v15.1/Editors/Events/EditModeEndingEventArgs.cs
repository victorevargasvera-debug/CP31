using System;
using System.Windows;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x020000BD RID: 189
	public class EditModeEndingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000A61 RID: 2657 RVA: 0x0002F698 File Offset: 0x0002D898
		public EditModeEndingEventArgs(bool acceptChanges, bool force)
		{
			this._force = force;
			this._acceptChanges = acceptChanges;
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0002F6AE File Offset: 0x0002D8AE
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x0002F6B6 File Offset: 0x0002D8B6
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

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0002F6BF File Offset: 0x0002D8BF
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x0002F6C7 File Offset: 0x0002D8C7
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

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0002F6EB File Offset: 0x0002D8EB
		public bool Force
		{
			get
			{
				return this._force;
			}
		}

		// Token: 0x040003B1 RID: 945
		private bool _cancel;

		// Token: 0x040003B2 RID: 946
		private bool _acceptChanges;

		// Token: 0x040003B3 RID: 947
		private bool _force;
	}
}
