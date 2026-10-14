using System;
using System.Windows;
using Infragistics.Collections;
using Infragistics.Controls;

namespace Infragistics
{
	// Token: 0x020000CD RID: 205
	public class CommandSourceCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.CommandSource>
	{
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x0001BCF7 File Offset: 0x00019EF7
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x0001BD00 File Offset: 0x00019F00
		public global::System.Windows.FrameworkElement Element
		{
			get
			{
				return this._element;
			}
			set
			{
				if (this._element != value)
				{
					global::System.Windows.FrameworkElement element = this._element;
					this._element = value;
					if (element == null)
					{
						foreach (global::Infragistics.Controls.CommandSource source in this)
						{
							global::Infragistics.CommandSourceManager.RegisterCommandSource(source, this.Element);
						}
					}
				}
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0001BD68 File Offset: 0x00019F68
		protected override void AddItem(int index, global::Infragistics.Controls.CommandSource item)
		{
			if (this.Element != null)
			{
				global::Infragistics.CommandSourceManager.RegisterCommandSource(item, this.Element);
			}
			base.AddItem(index, item);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0001BD86 File Offset: 0x00019F86
		protected override bool RemoveItem(int index)
		{
			global::Infragistics.CommandSourceManager.UnregisterCommandSource(this.Items[index]);
			return base.RemoveItem(index);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0001BDA0 File Offset: 0x00019FA0
		protected override void ResetItems()
		{
			foreach (global::Infragistics.Controls.CommandSource source in this.Items)
			{
				global::Infragistics.CommandSourceManager.UnregisterCommandSource(source);
			}
			base.ResetItems();
		}

		// Token: 0x040003C9 RID: 969
		private global::System.Windows.FrameworkElement _element;
	}
}
