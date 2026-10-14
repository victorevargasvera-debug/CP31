using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200019B RID: 411
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public sealed class TreeReportViewPanel : global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase
	{
		// Token: 0x06001A0A RID: 6666 RVA: 0x0007775C File Offset: 0x0007595C
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this._lineRenderer != null)
			{
				this._lineRenderer.InvalidateVisual();
				if (!this._isLayutUpdatedWired)
				{
					this._isLayutUpdatedWired = true;
					base.LayoutUpdated += this.OnLayoutUpdated;
				}
			}
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x000777B4 File Offset: 0x000759B4
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			if (this._lineRenderer == null)
			{
				if (this._viewSettings == null)
				{
					global::Infragistics.Windows.DataPresenter.TreeReportView treeReportView = base.DataPresenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.TreeReportView;
					if (treeReportView != null)
					{
						this._viewSettings = treeReportView.ViewSettingsResolved;
					}
				}
				if (this._viewSettings != null && this._viewSettings.TreeLineVisibility == global::System.Windows.Visibility.Visible)
				{
					global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
					if (adornerLayer != null)
					{
						this._lineRenderer = new global::Infragistics.Windows.DataPresenter.TreeLineRenderer(this, base.DataPresenter, global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area.All, () => this._viewSettings, () => this.ConnectorLinePen, () => -base.HorizontalOffset);
						adornerLayer.Add(this._lineRenderer);
						base.SetResourceReference(global::Infragistics.Windows.DataPresenter.TreeReportViewPanel.ConnectorLinePenProperty, global::Infragistics.Windows.DataPresenter.DataPresenterBrushKeys.TreeLinePen);
						base.CoerceValue(global::Infragistics.Windows.DataPresenter.TreeReportViewPanel.ConnectorLinePenProperty);
					}
				}
			}
			else
			{
				this._lineRenderer.InvalidateVisual();
			}
			return result;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x000778B0 File Offset: 0x00075AB0
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			this._isLayutUpdatedWired = false;
			base.LayoutUpdated -= this.OnLayoutUpdated;
			if (this._lineRenderer != null && !this._lineRenderer.IsArrangeValid)
			{
				this._lineRenderer.Arrange(new global::System.Windows.Rect(base.RenderSize));
			}
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00077904 File Offset: 0x00075B04
		private static object CoerceConnectorLinePen(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.TreeReportViewPanel treeReportViewPanel = target as global::Infragistics.Windows.DataPresenter.TreeReportViewPanel;
			if (treeReportViewPanel._lineRenderer != null && treeReportViewPanel._viewSettings != null)
			{
				global::System.Windows.Media.Pen treeLinePen = treeReportViewPanel._viewSettings.TreeLinePen;
				if (treeLinePen != null)
				{
					return treeLinePen;
				}
			}
			return value;
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x0007793A File Offset: 0x00075B3A
		// (set) Token: 0x06001A0F RID: 6671 RVA: 0x0007794C File Offset: 0x00075B4C
		internal global::System.Windows.Media.Pen ConnectorLinePen
		{
			get
			{
				return (global::System.Windows.Media.Pen)base.GetValue(global::Infragistics.Windows.DataPresenter.TreeReportViewPanel.ConnectorLinePenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TreeReportViewPanel.ConnectorLinePenProperty, value);
			}
		}

		// Token: 0x04000AA5 RID: 2725
		private global::Infragistics.Windows.DataPresenter.TreeLineRenderer _lineRenderer;

		// Token: 0x04000AA6 RID: 2726
		private global::Infragistics.Windows.DataPresenter.TreeViewSettings _viewSettings;

		// Token: 0x04000AA7 RID: 2727
		private bool _isLayutUpdatedWired;

		// Token: 0x04000AA8 RID: 2728
		internal static readonly global::System.Windows.DependencyProperty ConnectorLinePenProperty = global::System.Windows.DependencyProperty.Register("ConnectorLinePen", typeof(global::System.Windows.Media.Pen), typeof(global::Infragistics.Windows.DataPresenter.TreeReportViewPanel), new global::System.Windows.FrameworkPropertyMetadata(null, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.TreeReportViewPanel.CoerceConnectorLinePen)));
	}
}
