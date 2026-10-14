using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001EF RID: 495
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public abstract class AdornerEx : global::System.Windows.Documents.Adorner
	{
		// Token: 0x06001288 RID: 4744 RVA: 0x0004199E File Offset: 0x0003FB9E
		protected AdornerEx(global::System.Windows.FrameworkElement adornedElement) : base(adornedElement)
		{
			this.WireLoadedUnloaded(false);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x000419AE File Offset: 0x0003FBAE
		private void OnAdornedElementLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			((global::System.Windows.FrameworkElement)base.AdornedElement).Loaded -= this.OnAdornedElementLoaded;
			this.VerifyAdornerLayer(true);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x000419D3 File Offset: 0x0003FBD3
		private void OnAdornerLayerUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.VerifyAdornerLayer(false);
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x000419DC File Offset: 0x0003FBDC
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

		// Token: 0x0600128C RID: 4748 RVA: 0x00041A50 File Offset: 0x0003FC50
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
					return;
				}
			}
			else if (addToLayer)
			{
				((global::System.Windows.FrameworkElement)base.AdornedElement).Loaded += this.OnAdornedElementLoaded;
			}
		}
	}
}
