using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001C1 RID: 449
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public abstract class AdornerEx : global::System.Windows.Documents.Adorner
	{
		// Token: 0x060010B7 RID: 4279 RVA: 0x0003C27E File Offset: 0x0003A47E
		protected AdornerEx(global::System.Windows.FrameworkElement adornedElement) : base(adornedElement)
		{
			this.WireLoadedUnloaded(false);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0003C28E File Offset: 0x0003A48E
		private void OnAdornedElementLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			((global::System.Windows.FrameworkElement)base.AdornedElement).Loaded -= this.OnAdornedElementLoaded;
			this.VerifyAdornerLayer(true);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0003C2B3 File Offset: 0x0003A4B3
		private void OnAdornerLayerUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.VerifyAdornerLayer(false);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0003C2BC File Offset: 0x0003A4BC
		private void VerifyAdornerLayer(bool calledFromLoaded)
		{
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::System.Windows.Documents.AdornerLayer;
			if (adornerLayer != null)
			{
				if (adornerLayer == global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(base.AdornedElement))
				{
					if (calledFromLoaded)
					{
						((global::System.Windows.FrameworkElement)base.AdornedElement).Unloaded += this.OnAdornerLayerUnloaded;
					}
					return;
				}
				((global::System.Windows.FrameworkElement)base.AdornedElement).Unloaded -= this.OnAdornerLayerUnloaded;
				adornerLayer.Remove(this);
			}
			this.WireLoadedUnloaded(true);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0003C330 File Offset: 0x0003A530
		private void WireLoadedUnloaded(bool addToLayer)
		{
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(base.AdornedElement);
			if (adornerLayer != null)
			{
				if (!addToLayer && !((global::System.Windows.FrameworkElement)base.AdornedElement).IsLoaded)
				{
					((global::System.Windows.FrameworkElement)base.AdornedElement).Loaded += this.OnAdornedElementLoaded;
				}
				else
				{
					((global::System.Windows.FrameworkElement)base.AdornedElement).Unloaded += this.OnAdornerLayerUnloaded;
				}
				if (addToLayer && adornerLayer != global::System.Windows.Media.VisualTreeHelper.GetParent(this))
				{
					adornerLayer.Add(this);
				}
			}
		}
	}
}
