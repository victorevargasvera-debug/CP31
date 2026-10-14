using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000212 RID: 530
	public sealed class TreeViewPanel : global::Infragistics.Windows.DataPresenter.GridViewPanelFlat
	{
		// Token: 0x06001FDB RID: 8155 RVA: 0x0008A158 File Offset: 0x00088358
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this._lineRenderers != null)
			{
				for (int i = 0; i < this._lineRenderers.Length; i++)
				{
					global::Infragistics.Windows.DataPresenter.TreeLineRenderer treeLineRenderer = this._lineRenderers[i];
					if (treeLineRenderer != null)
					{
						treeLineRenderer.Arrange(new global::System.Windows.Rect(finalSize));
					}
				}
				base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					this.InvalidateLines();
				}), new object[0]);
			}
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0008A1C4 File Offset: 0x000883C4
		internal override global::Infragistics.Windows.DataPresenter.GridViewSettingsBase CreateDefaultViewSettings()
		{
			return new global::Infragistics.Windows.DataPresenter.TreeViewSettings();
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x0008A1CB File Offset: 0x000883CB
		internal override bool DoesRecordHaveHeaderAndChildrenBeforeIt(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.HeaderPlacement headerPlacement, int? visibleIndex)
		{
			return false;
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x0008A1CE File Offset: 0x000883CE
		internal override double GetRecordIndent(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return 0.0;
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x0008A1D9 File Offset: 0x000883D9
		internal override double HeightInfiniteContainersResolved
		{
			get
			{
				return double.PositiveInfinity;
			}
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x0008A200 File Offset: 0x00088400
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size size = base.MeasureOverride(availableSize);
			if (this._lineRenderers == null)
			{
				global::Infragistics.Windows.DataPresenter.TreeViewSettings treeViewSettings = base.ViewSettings as global::Infragistics.Windows.DataPresenter.TreeViewSettings;
				if (treeViewSettings != null)
				{
					if (this._treeLineVisibilityTracker == null)
					{
						this._treeLineVisibilityTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "ViewSettings.TreeLineVisibility", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnLineSettingsChanged), true);
					}
					if (treeViewSettings.TreeLineVisibility == global::System.Windows.Visibility.Visible)
					{
						global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
						if (adornerLayer != null)
						{
							this._lineRenderers = new global::Infragistics.Windows.DataPresenter.TreeLineRenderer[3];
							for (int i = 0; i < 3; i++)
							{
								global::Infragistics.Windows.DataPresenter.TreeLineRenderer treeLineRenderer = new global::Infragistics.Windows.DataPresenter.TreeLineRenderer(this, base.DataPresenter, (global::Infragistics.Windows.DataPresenter.TreeLineRenderer.Area)i, () => base.ViewSettings, () => this.ConnectorLinePen, () => 0.0);
								adornerLayer.Add(treeLineRenderer);
								this._lineRenderers[i] = treeLineRenderer;
							}
							base.SetResourceReference(global::Infragistics.Windows.DataPresenter.TreeViewPanel.ConnectorLinePenProperty, global::Infragistics.Windows.DataPresenter.DataPresenterBrushKeys.TreeLinePen);
							if (this._indentPerLevelTracker == null)
							{
								this._indentPerLevelTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "ViewSettings.IndentPerLevel", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnLineSettingsChanged), true);
							}
							global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (base.DataPresenter != null) ? base.DataPresenter.DefaultFieldLayout : null;
							if (fieldLayout != null)
							{
								if (this._gridColumnWidthVersionTracker == null || this._gridColumnWidthVersionTracker.Tag != fieldLayout)
								{
									this._gridColumnWidthVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(fieldLayout, global::Infragistics.Windows.DataPresenter.FieldLayout.GridColumnWidthVersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnLineSettingsChanged), true);
									this._gridColumnWidthVersionTracker.Tag = fieldLayout;
								}
							}
							else
							{
								this._gridColumnWidthVersionTracker = null;
							}
							base.CoerceValue(global::Infragistics.Windows.DataPresenter.TreeViewPanel.ConnectorLinePenProperty);
						}
					}
					else
					{
						this._indentPerLevelTracker = null;
						this._gridColumnWidthVersionTracker = null;
					}
				}
			}
			if (this._lineRenderers != null)
			{
				for (int j = 0; j < this._lineRenderers.Length; j++)
				{
					global::Infragistics.Windows.DataPresenter.TreeLineRenderer treeLineRenderer2 = this._lineRenderers[j];
					if (treeLineRenderer2 != null)
					{
						treeLineRenderer2.Measure(size);
					}
				}
			}
			else
			{
				this._treeLineVisibilityTracker = null;
				this._indentPerLevelTracker = null;
			}
			return size;
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0008A3F4 File Offset: 0x000885F4
		internal override void OnViewSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnViewSettingsPropertyChanged(sender, e);
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (!(propertyName == "TreeLinePen"))
				{
					return;
				}
				base.CoerceValue(global::Infragistics.Windows.DataPresenter.TreeViewPanel.ConnectorLinePenProperty);
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x0008A42C File Offset: 0x0008862C
		internal override double WidthInfiniteContainersResolved
		{
			get
			{
				return double.PositiveInfinity;
			}
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0008A438 File Offset: 0x00088638
		private static object CoerceConnectorLinePen(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.TreeViewPanel treeViewPanel = target as global::Infragistics.Windows.DataPresenter.TreeViewPanel;
			if (treeViewPanel._lineRenderers != null)
			{
				global::Infragistics.Windows.DataPresenter.TreeViewSettings treeViewSettings = treeViewPanel.ViewSettings as global::Infragistics.Windows.DataPresenter.TreeViewSettings;
				if (treeViewSettings != null)
				{
					global::System.Windows.Media.Pen treeLinePen = treeViewSettings.TreeLinePen;
					if (treeLinePen != null)
					{
						return treeLinePen;
					}
				}
			}
			return value;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x0008A470 File Offset: 0x00088670
		private static void OnConnectorLinePenChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.TreeViewPanel treeViewPanel = target as global::Infragistics.Windows.DataPresenter.TreeViewPanel;
			treeViewPanel.InvalidateLines();
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0008A48A File Offset: 0x0008868A
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x0008A49C File Offset: 0x0008869C
		internal global::System.Windows.Media.Pen ConnectorLinePen
		{
			get
			{
				return (global::System.Windows.Media.Pen)base.GetValue(global::Infragistics.Windows.DataPresenter.TreeViewPanel.ConnectorLinePenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TreeViewPanel.ConnectorLinePenProperty, value);
			}
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x0008A4AC File Offset: 0x000886AC
		internal void InvalidateLines()
		{
			if (this._lineRenderers != null)
			{
				for (int i = 0; i < this._lineRenderers.Length; i++)
				{
					global::Infragistics.Windows.DataPresenter.TreeLineRenderer treeLineRenderer = this._lineRenderers[i];
					if (treeLineRenderer != null)
					{
						treeLineRenderer.InvalidateVisual();
					}
				}
			}
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0008A4E6 File Offset: 0x000886E6
		private void OnLineSettingsChanged()
		{
			this.InvalidateLines();
		}

		// Token: 0x04000D5F RID: 3423
		private global::Infragistics.Windows.DataPresenter.TreeLineRenderer[] _lineRenderers;

		// Token: 0x04000D60 RID: 3424
		private global::Infragistics.Windows.Internal.PropertyValueTracker _treeLineVisibilityTracker;

		// Token: 0x04000D61 RID: 3425
		private global::Infragistics.Windows.Internal.PropertyValueTracker _indentPerLevelTracker;

		// Token: 0x04000D62 RID: 3426
		private global::Infragistics.Windows.Internal.PropertyValueTracker _gridColumnWidthVersionTracker;

		// Token: 0x04000D63 RID: 3427
		internal static readonly global::System.Windows.DependencyProperty ConnectorLinePenProperty = global::System.Windows.DependencyProperty.Register("ConnectorLinePen", typeof(global::System.Windows.Media.Pen), typeof(global::Infragistics.Windows.DataPresenter.TreeViewPanel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.TreeViewPanel.OnConnectorLinePenChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.TreeViewPanel.CoerceConnectorLinePen)));
	}
}
