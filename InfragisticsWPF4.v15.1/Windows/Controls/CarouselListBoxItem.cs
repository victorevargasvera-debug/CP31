using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000260 RID: 608
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CarouselListBoxItem : global::Infragistics.Windows.Controls.CarouselPanelItem
	{
		// Token: 0x06001928 RID: 6440 RVA: 0x000617D0 File Offset: 0x0005F9D0
		static CarouselListBoxItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.CarouselListBoxItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.CarouselListBoxItem)));
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x000617F5 File Offset: 0x0005F9F5
		public CarouselListBoxItem()
		{
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00061804 File Offset: 0x0005FA04
		protected internal CarouselListBoxItem(global::Infragistics.Windows.Controls.XamCarouselPanel carouselPanel) : base(carouselPanel)
		{
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00061814 File Offset: 0x0005FA14
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!e.Handled)
			{
				global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this) as global::Infragistics.Windows.Controls.XamCarouselListBox;
				if (xamCarouselListBox != null)
				{
					base.Focus();
					xamCarouselListBox.SelectedIndex = this.IndexOfItem;
					if (xamCarouselListBox.SelectedIndex == -1)
					{
						xamCarouselListBox.SelectedIndex = xamCarouselListBox.Items.IndexOf(base.Content);
					}
					if (xamCarouselListBox.SelectedIndex == -1)
					{
						xamCarouselListBox.SelectedIndex = xamCarouselListBox.Items.IndexOf(this);
					}
					e.Handled = true;
				}
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0006188D File Offset: 0x0005FA8D
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x00061895 File Offset: 0x0005FA95
		internal int IndexOfItem
		{
			get
			{
				return this._indexOfitem;
			}
			set
			{
				this._indexOfitem = value;
			}
		}

		// Token: 0x04000CAF RID: 3247
		private int _indexOfitem = -1;
	}
}
