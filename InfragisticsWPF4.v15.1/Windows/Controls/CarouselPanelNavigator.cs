using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200026E RID: 622
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CarouselPanelNavigator : global::System.Windows.Controls.Control
	{
		// Token: 0x06001981 RID: 6529 RVA: 0x00062514 File Offset: 0x00060714
		static CarouselPanelNavigator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.CarouselPanelNavigator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.CarouselPanelNavigator)));
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x0006256D File Offset: 0x0006076D
		public CarouselPanelNavigator()
		{
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00062575 File Offset: 0x00060775
		public CarouselPanelNavigator(global::Infragistics.Windows.Controls.XamCarouselPanel carouselPanel)
		{
			this.CarouselPanel = carouselPanel;
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x00062584 File Offset: 0x00060784
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x00062596 File Offset: 0x00060796
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.XamCarouselPanel CarouselPanel
		{
			get
			{
				return (global::Infragistics.Windows.Controls.XamCarouselPanel)base.GetValue(global::Infragistics.Windows.Controls.CarouselPanelNavigator.CarouselPanelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselPanelNavigator.CarouselPanelProperty, value);
			}
		}

		// Token: 0x04000CC1 RID: 3265
		private static readonly global::System.Windows.DependencyProperty CarouselPanelProperty = global::System.Windows.DependencyProperty.Register("CarouselPanel", typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), typeof(global::Infragistics.Windows.Controls.CarouselPanelNavigator), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
