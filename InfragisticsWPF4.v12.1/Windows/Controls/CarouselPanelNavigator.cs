using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000239 RID: 569
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CarouselPanelNavigator : global::System.Windows.Controls.Control
	{
		// Token: 0x0600177F RID: 6015 RVA: 0x0005BA9C File Offset: 0x00059C9C
		static CarouselPanelNavigator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.CarouselPanelNavigator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.CarouselPanelNavigator)));
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0005BAF5 File Offset: 0x00059CF5
		public CarouselPanelNavigator()
		{
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0005BAFD File Offset: 0x00059CFD
		public CarouselPanelNavigator(global::Infragistics.Windows.Controls.XamCarouselPanel carouselPanel)
		{
			this.CarouselPanel = carouselPanel;
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x0005BB0C File Offset: 0x00059D0C
		// (set) Token: 0x06001783 RID: 6019 RVA: 0x0005BB1E File Offset: 0x00059D1E
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

		// Token: 0x04000B5E RID: 2910
		private static readonly global::System.Windows.DependencyProperty CarouselPanelProperty = global::System.Windows.DependencyProperty.Register("CarouselPanel", typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), typeof(global::Infragistics.Windows.Controls.CarouselPanelNavigator), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
