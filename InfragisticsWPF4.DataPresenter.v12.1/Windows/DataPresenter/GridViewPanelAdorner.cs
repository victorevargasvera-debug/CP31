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
	// Token: 0x02000357 RID: 855
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GridViewPanelAdorner : global::Infragistics.Windows.Internal.AdornerEx, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06002844 RID: 10308 RVA: 0x000ACC6C File Offset: 0x000AAE6C
		static GridViewPanelAdorner()
		{
			global::System.Windows.FrameworkElement.FlowDirectionProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner.CoerceFlowDirection)));
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x000ACC94 File Offset: 0x000AAE94
		internal GridViewPanelAdorner(global::Infragistics.Windows.DataPresenter.GridViewPanelNested adornedElement) : base(adornedElement)
		{
			this._gridViewPanel = adornedElement;
			this._flowDirectionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._gridViewPanel, global::System.Windows.FrameworkElement.FlowDirectionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnPanelFlowDirectionChanged));
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x000ACCD4 File Offset: 0x000AAED4
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

		// Token: 0x06002847 RID: 10311 RVA: 0x000ACF08 File Offset: 0x000AB108
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index < 0 || index >= this.Children.Count)
			{
				return null;
			}
			return this.Children[index];
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x000ACF2C File Offset: 0x000AB12C
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

		// Token: 0x06002849 RID: 10313 RVA: 0x000ACFD0 File Offset: 0x000AB1D0
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

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x000AD03A File Offset: 0x000AB23A
		protected override int VisualChildrenCount
		{
			get
			{
				return this.Children.Count;
			}
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x000AD048 File Offset: 0x000AB248
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

		// Token: 0x0600284C RID: 10316 RVA: 0x000AD0B4 File Offset: 0x000AB2B4
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

		// Token: 0x0600284D RID: 10317 RVA: 0x000AD3FC File Offset: 0x000AB5FC
		internal void InitializeOffset(double newOffset)
		{
			this._locationOffset = newOffset;
			base.InvalidateArrange();
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x000AD40C File Offset: 0x000AB60C
		private void AddChildElement(global::System.Windows.UIElement childElement)
		{
			base.AddVisualChild(childElement);
			this.Children.Add(childElement);
			if (this._gridViewPanel != null && global::System.Windows.LogicalTreeHelper.GetParent(childElement) == null)
			{
				this._gridViewPanel.AddLogicalChildInternal(childElement);
			}
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x000AD44C File Offset: 0x000AB64C
		private static object CoerceFlowDirection(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner gridViewPanelAdorner = (global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner)d;
			return gridViewPanelAdorner._gridViewPanel.GetValue(global::System.Windows.FrameworkElement.FlowDirectionProperty);
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x000AD470 File Offset: 0x000AB670
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

		// Token: 0x06002851 RID: 10321 RVA: 0x000AD4B4 File Offset: 0x000AB6B4
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

		// Token: 0x06002852 RID: 10322 RVA: 0x000AD534 File Offset: 0x000AB734
		private void OnPanelFlowDirectionChanged()
		{
			base.CoerceValue(global::System.Windows.FrameworkElement.FlowDirectionProperty);
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x000AD544 File Offset: 0x000AB744
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

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x000AD576 File Offset: 0x000AB776
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

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06002855 RID: 10325 RVA: 0x000AD592 File Offset: 0x000AB792
		internal global::Infragistics.Windows.DataPresenter.GridViewPanelNested GridViewPanel
		{
			get
			{
				return this._gridViewPanel;
			}
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x000AD59A File Offset: 0x000AB79A
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

		// Token: 0x040012EF RID: 4847
		private global::Infragistics.Windows.DataPresenter.GridViewPanelNested _gridViewPanel;

		// Token: 0x040012F0 RID: 4848
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> _children;

		// Token: 0x040012F1 RID: 4849
		private bool _orientationIsVertical = true;

		// Token: 0x040012F2 RID: 4850
		private double _locationOffset;

		// Token: 0x040012F3 RID: 4851
		private double _headerExtent;

		// Token: 0x040012F4 RID: 4852
		private int _fieldLayoutVersion = -1;

		// Token: 0x040012F5 RID: 4853
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040012F6 RID: 4854
		private global::Infragistics.Windows.Internal.PropertyValueTracker _flowDirectionTracker;

		// Token: 0x040012F7 RID: 4855
		private global::System.Windows.Size _constraint;

		// Token: 0x040012F8 RID: 4856
		private global::System.Windows.Size _lastMeasureConstraint;
	}
}
