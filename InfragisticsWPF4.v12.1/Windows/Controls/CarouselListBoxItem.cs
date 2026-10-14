using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200022B RID: 555
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CarouselListBoxItem : global::Infragistics.Windows.Controls.CarouselPanelItem
	{
		// Token: 0x06001728 RID: 5928 RVA: 0x0005AD88 File Offset: 0x00058F88
		static CarouselListBoxItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.CarouselListBoxItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.CarouselListBoxItem)));
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x0005ADAD File Offset: 0x00058FAD
		public CarouselListBoxItem()
		{
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0005ADB5 File Offset: 0x00058FB5
		protected internal CarouselListBoxItem(global::Infragistics.Windows.Controls.XamCarouselPanel carouselPanel) : base(carouselPanel)
		{
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0005ADC0 File Offset: 0x00058FC0
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!e.Handled)
			{
				global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this) as global::Infragistics.Windows.Controls.XamCarouselListBox;
				if (xamCarouselListBox != null)
				{
					base.Focus();
					xamCarouselListBox.SelectedIndex = xamCarouselListBox.Items.IndexOf(base.Content);
					if (xamCarouselListBox.SelectedIndex == -1)
					{
						xamCarouselListBox.SelectedIndex = xamCarouselListBox.Items.IndexOf(this);
					}
					e.Handled = true;
				}
			}
		}
	}
}
