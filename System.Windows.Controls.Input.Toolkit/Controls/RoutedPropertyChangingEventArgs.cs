using System;
using System.Windows.Controls.Properties;

namespace System.Windows.Controls
{
	// Token: 0x0200001A RID: 26
	public class RoutedPropertyChangingEventArgs<T> : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00006F6D File Offset: 0x0000516D
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00006F75 File Offset: 0x00005175
		public global::System.Windows.DependencyProperty Property { get; private set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00006F7E File Offset: 0x0000517E
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00006F86 File Offset: 0x00005186
		public T OldValue { get; private set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00006F8F File Offset: 0x0000518F
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00006F97 File Offset: 0x00005197
		public T NewValue { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00006FA0 File Offset: 0x000051A0
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00006FA8 File Offset: 0x000051A8
		public bool IsCancelable { get; private set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00006FB1 File Offset: 0x000051B1
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00006FB9 File Offset: 0x000051B9
		public bool Cancel
		{
			get
			{
				return this._cancel;
			}
			set
			{
				if (this.IsCancelable)
				{
					this._cancel = value;
					return;
				}
				if (value)
				{
					throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.RoutedPropertyChangingEventArgs_CancelSet_InvalidOperation);
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00006FD9 File Offset: 0x000051D9
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00006FE1 File Offset: 0x000051E1
		public bool InCoercion { get; set; }

		// Token: 0x060001A7 RID: 423 RVA: 0x00006FEA File Offset: 0x000051EA
		public RoutedPropertyChangingEventArgs(global::System.Windows.DependencyProperty property, T oldValue, T newValue, bool isCancelable)
		{
			this.Property = property;
			this.OldValue = oldValue;
			this.NewValue = newValue;
			this.IsCancelable = isCancelable;
			this.Cancel = false;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00007016 File Offset: 0x00005216
		public RoutedPropertyChangingEventArgs(global::System.Windows.DependencyProperty property, T oldValue, T newValue, bool isCancelable, global::System.Windows.RoutedEvent routedEvent) : base(routedEvent)
		{
			this.Property = property;
			this.OldValue = oldValue;
			this.NewValue = newValue;
			this.IsCancelable = isCancelable;
			this.Cancel = false;
		}

		// Token: 0x04000080 RID: 128
		private bool _cancel;
	}
}
