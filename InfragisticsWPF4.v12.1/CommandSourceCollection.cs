using System;
using System.Windows;
using Infragistics.Collections;
using Infragistics.Controls;

namespace Infragistics
{
	// Token: 0x020000B2 RID: 178
	public class CommandSourceCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.CommandSource>
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0001854F File Offset: 0x0001674F
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x00018558 File Offset: 0x00016758
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

		// Token: 0x060006D0 RID: 1744 RVA: 0x000185C0 File Offset: 0x000167C0
		protected override void AddItem(int index, global::Infragistics.Controls.CommandSource item)
		{
			if (this.Element != null)
			{
				global::Infragistics.CommandSourceManager.RegisterCommandSource(item, this.Element);
			}
			base.AddItem(index, item);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000185DE File Offset: 0x000167DE
		protected override bool RemoveItem(int index)
		{
			global::Infragistics.CommandSourceManager.UnregisterCommandSource(this.Items[index]);
			return base.RemoveItem(index);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000185F8 File Offset: 0x000167F8
		protected override void ResetItems()
		{
			foreach (global::Infragistics.Controls.CommandSource source in this.Items)
			{
				global::Infragistics.CommandSourceManager.UnregisterCommandSource(source);
			}
			base.ResetItems();
		}

		// Token: 0x04000320 RID: 800
		private global::System.Windows.FrameworkElement _element;
	}
}
