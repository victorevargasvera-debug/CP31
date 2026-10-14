using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200039D RID: 925
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GridViewPanelAdorner : global::Infragistics.Windows.Internal.AdornerEx, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06002C2C RID: 11308 RVA: 0x000C195C File Offset: 0x000BFB5C
		static GridViewPanelAdorner()
		{
			global::System.Windows.FrameworkElement.FlowDirectionProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner.CoerceFlowDirection)));
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x000C1984 File Offset: 0x000BFB84
		internal GridViewPanelAdorner(global::Infragistics.Windows.DataPresenter.GridViewPanelNested adornedElement) : base(adornedElement)
		{
			this._gridViewPanel = adornedElement;
			this._flowDirectionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._gridViewPanel, global::System.Windows.FrameworkElement.FlowDirectionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnPanelFlowDirectionChanged));
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000C19C4 File Offset: 0x000BFBC4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(finalSize);
			double num = 0.0;
			double num2 = 0.0;
			if (this._gridViewPanel != null && this._gridViewPanel.IsRootPanel)
			{
				if (this._orientationIsVertical)
				{
					num2 = this._lastMeasureConstraint.Width;
				}
				else
				{
					num2 = this._lastMeasureConstraint.Height;
				}
				if (double.IsPositiveInfinity(num2))
				{
					num2 = 0.0;
				}
			}
			foreach (global::System.Windows.UIElement uielement in this.Children)
			{
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = uielement as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
				if (dataRecordPresenter != null && dataRecordPresenter.IsHeaderRecord)
				{
					if (this._orientationIsVertical)
					{
						finalRect.X = this._locationOffset;
						finalRect.Y += num;
						num = dataRecordPresenter.DesiredSize.Height;
						finalRect.Height = num;
						finalRect.Width = global::System.Math.Max(finalSize.Width, dataRecordPresenter.DesiredSize.Width);
						if (!dataRecordPresenter.FieldLayout.IsAutoFitWidth)
						{
							finalRect.Width = global::System.Math.Max(num2 - finalRect.X, finalRect.Width);
						}
						if (global::Infragistics.Windows.Utilities.DoubleIsZero(finalRect.Y))
						{
							finalRect.Y = 0.0;
						}
					}
					else
					{
						finalRect.X += num;
						finalRect.Y = this._locationOffset;
						num = dataRecordPresenter.DesiredSize.Width;
						finalRect.Height = global::System.Math.Max(finalSize.Height, dataRecordPresenter.DesiredSize.Height);
						if (!dataRecordPresenter.FieldLayout.IsAutoFitHeight)
						{
							finalRect.Height = global::System.Math.Max(num2 - finalRect.Y, finalRect.Height);
						}
						if (global::Infragistics.Windows.Utilities.DoubleIsZero(finalRect.X))
						{
							finalRect.X = 0.0;
						}
					}
					dataRecordPresenter.Arrange(finalRect);
				}
			}
			return finalSize;
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000C1BF8 File Offset: 0x000BFDF8
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index < 0 || index >= this.Children.Count)
			{
				return null;
			}
			return this.Children[index];
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000C1C1C File Offset: 0x000BFE1C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			this._lastMeasureConstraint = availableSize;
			global::System.Windows.Size result = default(global::System.Windows.Size);
			foreach (global::System.Windows.UIElement uielement in this.Children)
			{
				uielement.Measure(this._constraint);
				global::System.Windows.Size desiredSize = uielement.DesiredSize;
				result.Width = global::System.Math.Max(result.Width, desiredSize.Width);
				result.Height = global::System.Math.Max(result.Height, desiredSize.Height);
			}
			return result;
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000C1CC0 File Offset: 0x000BFEC0
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			base.OnChildDesiredSizeChanged(child);
			double primaryExtent = global::Infragistics.Windows.DataPresenter.GridUtilities.GetPrimaryExtent(child.DesiredSize, this._orientationIsVertical);
			if (primaryExtent != this._headerExtent)
			{
				this._headerExtent = primaryExtent;
				if (this._gridViewPanel != null)
				{
					this._gridViewPanel.InvalidateMeasure();
				}
				return;
			}
			if (this._gridViewPanel != null && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this._gridViewPanel) == 0)
			{
				this._gridViewPanel.InvalidateMeasure();
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x000C1D2A File Offset: 0x000BFF2A
		protected override int VisualChildrenCount
		{
			get
			{
				return this.Children.Count;
			}
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000C1D38 File Offset: 0x000BFF38
		internal void ClearHeaderRecordPresenters()
		{
			int count = this.Children.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = this.Children[i] as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
				if (dataRecordPresenter != null && dataRecordPresenter.IsHeaderRecord)
				{
					dataRecordPresenter.ClearContainerForItem(null);
					this.RemoveElementAsLogicalChild(dataRecordPresenter);
					base.RemoveVisualChild(dataRecordPresenter);
					this.Children.RemoveAt(i);
				}
			}
			base.InvalidateArrange();
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x000C1DA4 File Offset: 0x000BFFA4
		internal global::System.Windows.Size CreateAndMeasureHeaderRecordPresenter(global::Infragistics.Windows.DataPresenter.Record record, global::System.Windows.Size constraint, bool orientationIsVertical, double locationOffset)
		{
			this._constraint = constraint;
			bool flag = this._orientationIsVertical != orientationIsVertical;
			this._orientationIsVertical = orientationIsVertical;
			this._locationOffset = locationOffset;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
			if (this._fieldLayout != null)
			{
				global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._fieldLayout, this, "GridColumnWidthVersion");
				global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._fieldLayout, this, "GridRowHeightVersion");
			}
			this._fieldLayout = fieldLayout;
			if (this._fieldLayout != null)
			{
				int internalVersion = this._fieldLayout.InternalVersion;
				if (internalVersion != this._fieldLayoutVersion)
				{
					if (this._fieldLayoutVersion != -1 && fieldLayout.DataPresenter != null && !fieldLayout.DataPresenter.IsReportControl)
					{
						base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.DelayedPathInvalidation));
					}
					this._fieldLayoutVersion = internalVersion;
				}
				if (this._fieldLayout.IsHorizontal)
				{
					global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._fieldLayout, this, "GridRowHeightVersion");
				}
				else
				{
					global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._fieldLayout, this, "GridColumnWidthVersion");
				}
			}
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = null;
			foreach (global::System.Windows.UIElement uielement in this.Children)
			{
				dataRecordPresenter = (uielement as global::Infragistics.Windows.DataPresenter.DataRecordPresenter);
				if (dataRecordPresenter != null && dataRecordPresenter.IsHeaderRecord)
				{
					dataRecordPresenter.IsActiveHeaderRecord = false;
					dataRecordPresenter.IsArrangedInView = false;
					dataRecordPresenter.SizeChanged -= this.OnHeaderSizeChanged;
				}
			}
			dataRecordPresenter = null;
			if (!flag)
			{
				foreach (global::System.Windows.UIElement uielement2 in this.Children)
				{
					dataRecordPresenter = (uielement2 as global::Infragistics.Windows.DataPresenter.DataRecordPresenter);
					if (dataRecordPresenter != null && dataRecordPresenter.IsHeaderRecord && dataRecordPresenter.Record != null && dataRecordPresenter.Record.FieldLayout == record.FieldLayout)
					{
						break;
					}
					dataRecordPresenter = null;
				}
			}
			if (dataRecordPresenter == null)
			{
				dataRecordPresenter = new global::Infragistics.Windows.DataPresenter.DataRecordPresenter();
				dataRecordPresenter.PrepareContainerForItem(record, true);
				this.AddChildElement(dataRecordPresenter);
			}
			dataRecordPresenter.SetValue(global::System.Windows.FrameworkElement.DataContextProperty, record);
			dataRecordPresenter.IsActiveHeaderRecord = true;
			dataRecordPresenter.IsArrangedInView = true;
			dataRecordPresenter.InitializeHeaderContent(true);
			dataRecordPresenter.InitializeNestedContent(null);
			dataRecordPresenter.InitializeRecordContentVisibility(false);
			dataRecordPresenter.InitializeExpandableRecordContentVisibility(false);
			dataRecordPresenter.InitializeGroupByRecordContentVisibility(false);
			dataRecordPresenter.SetHeaderRecordCollection(this._gridViewPanel.ViewableRecords);
			dataRecordPresenter.InvalidateMeasure();
			dataRecordPresenter.Measure(constraint);
			if (dataRecordPresenter.DesiredSize.Width == 0.0 || dataRecordPresenter.DesiredSize.Height == 0.0)
			{
				dataRecordPresenter.InvalidateMeasure();
				dataRecordPresenter.Measure(constraint);
			}
			global::System.Windows.Size desiredSize = dataRecordPresenter.DesiredSize;
			this._headerExtent = global::Infragistics.Windows.DataPresenter.GridUtilities.GetPrimaryExtent(desiredSize, this._orientationIsVertical);
			int count = this.Children.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter2 = this.Children[i] as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
				if (dataRecordPresenter2 != null && dataRecordPresenter2.IsHeaderRecord && !dataRecordPresenter2.IsActiveHeaderRecord)
				{
					dataRecordPresenter2.ClearContainerForItem(null);
					dataRecordPresenter2.IsArrangedInView = false;
					dataRecordPresenter2.SetHeaderRecordCollection(null);
					this.RemoveElementAsLogicalChild(dataRecordPresenter2);
					base.RemoveVisualChild(dataRecordPresenter2);
					this.Children.RemoveAt(i);
				}
			}
			base.InvalidateArrange();
			dataRecordPresenter.SizeChanged += this.OnHeaderSizeChanged;
			return desiredSize;
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x000C20EC File Offset: 0x000C02EC
		internal void InitializeOffset(double newOffset)
		{
			this._locationOffset = newOffset;
			base.InvalidateArrange();
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x000C20FC File Offset: 0x000C02FC
		private void AddChildElement(global::System.Windows.UIElement childElement)
		{
			base.AddVisualChild(childElement);
			this.Children.Add(childElement);
			if (this._gridViewPanel != null && global::System.Windows.LogicalTreeHelper.GetParent(childElement) == null)
			{
				this._gridViewPanel.AddLogicalChildInternal(childElement);
			}
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x000C213C File Offset: 0x000C033C
		private static object CoerceFlowDirection(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner gridViewPanelAdorner = (global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner)d;
			return gridViewPanelAdorner._gridViewPanel.GetValue(global::System.Windows.FrameworkElement.FlowDirectionProperty);
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x000C2160 File Offset: 0x000C0360
		private void DelayedPathInvalidation()
		{
			for (global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.Windows.Utilities.GetDescendantFromType(this, typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter), true) as global::System.Windows.FrameworkElement; frameworkElement != null; frameworkElement = (global::System.Windows.Media.VisualTreeHelper.GetParent(frameworkElement) as global::System.Windows.FrameworkElement))
			{
				frameworkElement.InvalidateMeasure();
				if (frameworkElement is global::System.Windows.Documents.AdornerLayer)
				{
					return;
				}
			}
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x000C21A4 File Offset: 0x000C03A4
		private void OnHeaderSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = sender as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
			if (dataRecordPresenter == null)
			{
				return;
			}
			if (this._gridViewPanel != null && this._gridViewPanel == dataRecordPresenter.Parent)
			{
				double newExtent = this._orientationIsVertical ? dataRecordPresenter.ActualHeight : dataRecordPresenter.ActualWidth;
				double nonPrimaryExtent = this._orientationIsVertical ? e.NewSize.Width : e.NewSize.Height;
				this._gridViewPanel.OnHeaderExtentChanged(dataRecordPresenter.FieldLayout, newExtent, nonPrimaryExtent);
			}
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x000C2224 File Offset: 0x000C0424
		private void OnPanelFlowDirectionChanged()
		{
			base.CoerceValue(global::System.Windows.FrameworkElement.FlowDirectionProperty);
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x000C2234 File Offset: 0x000C0434
		private void RemoveElementAsLogicalChild(global::System.Windows.DependencyObject childElement)
		{
			if (this._gridViewPanel == null)
			{
				return;
			}
			global::System.Windows.DependencyObject parent = global::System.Windows.LogicalTreeHelper.GetParent(childElement);
			if (parent == this._gridViewPanel)
			{
				this._gridViewPanel.RemoveLogicalChildInternal(childElement);
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06002C3C RID: 11324 RVA: 0x000C2266 File Offset: 0x000C0466
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> Children
		{
			get
			{
				if (this._children == null)
				{
					this._children = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(3);
				}
				return this._children;
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x000C2282 File Offset: 0x000C0482
		internal global::Infragistics.Windows.DataPresenter.GridViewPanelNested GridViewPanel
		{
			get
			{
				return this._gridViewPanel;
			}
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x000C228A File Offset: 0x000C048A
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				if (this._gridViewPanel != null && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this._gridViewPanel) == 0)
				{
					this._gridViewPanel.InvalidateMeasure();
				}
				return true;
			}
			return false;
		}

		// Token: 0x04001518 RID: 5400
		private global::Infragistics.Windows.DataPresenter.GridViewPanelNested _gridViewPanel;

		// Token: 0x04001519 RID: 5401
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> _children;

		// Token: 0x0400151A RID: 5402
		private bool _orientationIsVertical = true;

		// Token: 0x0400151B RID: 5403
		private double _locationOffset;

		// Token: 0x0400151C RID: 5404
		private double _headerExtent;

		// Token: 0x0400151D RID: 5405
		private int _fieldLayoutVersion = -1;

		// Token: 0x0400151E RID: 5406
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x0400151F RID: 5407
		private global::Infragistics.Windows.Internal.PropertyValueTracker _flowDirectionTracker;

		// Token: 0x04001520 RID: 5408
		private global::System.Windows.Size _constraint;

		// Token: 0x04001521 RID: 5409
		private global::System.Windows.Size _lastMeasureConstraint;
	}
}
