using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Windows.Automation.Peers;
using MS.Internal;

namespace Microsoft.Windows.Controls.Primitives
{
	// Token: 0x02000083 RID: 131
	[global::System.Windows.TemplatePart(Name = "PART_TopHeaderGripper", Type = typeof(global::System.Windows.Controls.Primitives.Thumb))]
	[global::System.Windows.TemplatePart(Name = "PART_BottomHeaderGripper", Type = typeof(global::System.Windows.Controls.Primitives.Thumb))]
	public class DataGridRowHeader : global::System.Windows.Controls.Primitives.ButtonBase
	{
		// Token: 0x0600090E RID: 2318 RVA: 0x00028570 File Offset: 0x00026770
		static DataGridRowHeader()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader)));
			global::System.Windows.Controls.ContentControl.ContentProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.OnCoerceContent)));
			global::System.Windows.Controls.ContentControl.ContentTemplateProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.OnCoerceContentTemplate)));
			global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.OnCoerceContentTemplateSelector)));
			global::System.Windows.FrameworkElement.StyleProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.OnCoerceStyle)));
			global::System.Windows.FrameworkElement.WidthProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.OnCoerceWidth)));
			global::System.Windows.Controls.Primitives.ButtonBase.ClickModeProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.ClickMode.Press));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00028774 File Offset: 0x00026974
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Microsoft.Windows.Automation.Peers.DataGridRowHeaderAutomationPeer(this);
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0002877C File Offset: 0x0002697C
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x0002878E File Offset: 0x0002698E
		public global::System.Windows.Media.Brush SeparatorBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.SeparatorBrushProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.SeparatorBrushProperty, value);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0002879C File Offset: 0x0002699C
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x000287AE File Offset: 0x000269AE
		public global::System.Windows.Visibility SeparatorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.SeparatorVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.SeparatorVisibilityProperty, value);
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000287C4 File Offset: 0x000269C4
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.DataGridOwner;
			if (dataGridOwner == null)
			{
				return result;
			}
			if (global::MS.Internal.DoubleUtil.IsNaN(dataGridOwner.RowHeaderWidth) && result.Width > dataGridOwner.RowHeaderActualWidth)
			{
				dataGridOwner.RowHeaderActualWidth = result.Width;
			}
			return new global::System.Windows.Size(dataGridOwner.RowHeaderActualWidth, result.Height);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00028820 File Offset: 0x00026A20
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			global::Microsoft.Windows.Controls.DataGridRow parentRow = this.ParentRow;
			if (parentRow != null)
			{
				parentRow.RowHeader = this;
				this.SyncProperties();
			}
			this.HookupGripperEvents();
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00028850 File Offset: 0x00026A50
		internal void SyncProperties()
		{
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.FrameworkElement.StyleProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentTemplateProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.FrameworkElement.WidthProperty);
			base.CoerceValue(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.IsRowSelectedProperty);
			this.OnCanUserResizeRowsChanged();
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000288A5 File Offset: 0x00026AA5
		private static void OnNotifyPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader)d).NotifyPropertyChanged(d, e);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x000288B4 File Offset: 0x00026AB4
		internal void NotifyPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.Property == global::Microsoft.Windows.Controls.DataGridRow.HeaderProperty || e.Property == global::System.Windows.Controls.ContentControl.ContentProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowHeaderStyleProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.HeaderStyleProperty || e.Property == global::System.Windows.FrameworkElement.StyleProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.FrameworkElement.StyleProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowHeaderTemplateProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateProperty || e.Property == global::System.Windows.Controls.ContentControl.ContentTemplateProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentTemplateProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowHeaderTemplateSelectorProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateSelectorProperty || e.Property == global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowHeaderWidthProperty || e.Property == global::System.Windows.FrameworkElement.WidthProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.FrameworkElement.WidthProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGridRow.IsSelectedProperty)
			{
				base.CoerceValue(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.IsRowSelectedProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGrid.CanUserResizeRowsProperty)
			{
				this.OnCanUserResizeRowsChanged();
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowHeaderActualWidthProperty)
			{
				base.InvalidateMeasure();
				base.InvalidateArrange();
				global::System.Windows.UIElement uielement = base.Parent as global::System.Windows.UIElement;
				if (uielement != null)
				{
					uielement.InvalidateMeasure();
					uielement.InvalidateArrange();
				}
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00028A18 File Offset: 0x00026C18
		private static object OnCoerceContent(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader dataGridRowHeader = d as global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRowHeader, baseValue, global::System.Windows.Controls.ContentControl.ContentProperty, dataGridRowHeader.ParentRow, global::Microsoft.Windows.Controls.DataGridRow.HeaderProperty);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00028A44 File Offset: 0x00026C44
		private static object OnCoerceContentTemplate(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader dataGridRowHeader = d as global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader;
			global::Microsoft.Windows.Controls.DataGridRow parentRow = dataGridRowHeader.ParentRow;
			global::Microsoft.Windows.Controls.DataGrid grandParentObject = (parentRow != null) ? parentRow.DataGridOwner : null;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRowHeader, baseValue, global::System.Windows.Controls.ContentControl.ContentTemplateProperty, parentRow, global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateProperty, grandParentObject, global::Microsoft.Windows.Controls.DataGrid.RowHeaderTemplateProperty);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00028A84 File Offset: 0x00026C84
		private static object OnCoerceContentTemplateSelector(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader dataGridRowHeader = d as global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader;
			global::Microsoft.Windows.Controls.DataGridRow parentRow = dataGridRowHeader.ParentRow;
			global::Microsoft.Windows.Controls.DataGrid grandParentObject = (parentRow != null) ? parentRow.DataGridOwner : null;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRowHeader, baseValue, global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty, parentRow, global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateSelectorProperty, grandParentObject, global::Microsoft.Windows.Controls.DataGrid.RowHeaderTemplateSelectorProperty);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00028AC4 File Offset: 0x00026CC4
		private static object OnCoerceStyle(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader dataGridRowHeader = d as global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRowHeader, baseValue, global::System.Windows.FrameworkElement.StyleProperty, dataGridRowHeader.ParentRow, global::Microsoft.Windows.Controls.DataGridRow.HeaderStyleProperty, dataGridRowHeader.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.RowHeaderStyleProperty);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00028AFC File Offset: 0x00026CFC
		private static object OnCoerceWidth(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader dataGridRowHeader = d as global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRowHeader, baseValue, global::System.Windows.FrameworkElement.WidthProperty, dataGridRowHeader.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.RowHeaderWidthProperty);
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00028B27 File Offset: 0x00026D27
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Appearance")]
		public bool IsRowSelected
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.IsRowSelectedProperty);
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00028B3C File Offset: 0x00026D3C
		private static object OnCoerceIsRowSelected(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader dataGridRowHeader = (global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader)d;
			global::Microsoft.Windows.Controls.DataGridRow parentRow = dataGridRowHeader.ParentRow;
			if (parentRow != null)
			{
				return parentRow.IsSelected;
			}
			return baseValue;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00028B68 File Offset: 0x00026D68
		protected override void OnClick()
		{
			base.OnClick();
			if (global::System.Windows.Input.Mouse.Captured == this)
			{
				base.ReleaseMouseCapture();
			}
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.DataGridOwner;
			global::Microsoft.Windows.Controls.DataGridRow parentRow = this.ParentRow;
			if (dataGridOwner != null && parentRow != null)
			{
				dataGridOwner.HandleSelectionForRowHeaderAndDetailsInput(parentRow, true);
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00028BA8 File Offset: 0x00026DA8
		private void HookupGripperEvents()
		{
			this.UnhookGripperEvents();
			this._topGripper = (base.GetTemplateChild("PART_TopHeaderGripper") as global::System.Windows.Controls.Primitives.Thumb);
			this._bottomGripper = (base.GetTemplateChild("PART_BottomHeaderGripper") as global::System.Windows.Controls.Primitives.Thumb);
			if (this._topGripper != null)
			{
				this._topGripper.DragStarted += this.OnRowHeaderGripperDragStarted;
				this._topGripper.DragDelta += this.OnRowHeaderResize;
				this._topGripper.DragCompleted += this.OnRowHeaderGripperDragCompleted;
				this._topGripper.MouseDoubleClick += this.OnGripperDoubleClicked;
				this.SetTopGripperVisibility();
			}
			if (this._bottomGripper != null)
			{
				this._bottomGripper.DragStarted += this.OnRowHeaderGripperDragStarted;
				this._bottomGripper.DragDelta += this.OnRowHeaderResize;
				this._bottomGripper.DragCompleted += this.OnRowHeaderGripperDragCompleted;
				this._bottomGripper.MouseDoubleClick += this.OnGripperDoubleClicked;
				this.SetBottomGripperVisibility();
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00028CBC File Offset: 0x00026EBC
		private void UnhookGripperEvents()
		{
			if (this._topGripper != null)
			{
				this._topGripper.DragStarted -= this.OnRowHeaderGripperDragStarted;
				this._topGripper.DragDelta -= this.OnRowHeaderResize;
				this._topGripper.DragCompleted -= this.OnRowHeaderGripperDragCompleted;
				this._topGripper.MouseDoubleClick -= this.OnGripperDoubleClicked;
				this._topGripper = null;
			}
			if (this._bottomGripper != null)
			{
				this._bottomGripper.DragStarted -= this.OnRowHeaderGripperDragStarted;
				this._bottomGripper.DragDelta -= this.OnRowHeaderResize;
				this._bottomGripper.DragCompleted -= this.OnRowHeaderGripperDragCompleted;
				this._bottomGripper.MouseDoubleClick -= this.OnGripperDoubleClicked;
				this._bottomGripper = null;
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00028DA0 File Offset: 0x00026FA0
		private void SetTopGripperVisibility()
		{
			if (this._topGripper != null)
			{
				global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.DataGridOwner;
				global::Microsoft.Windows.Controls.DataGridRow parentRow = this.ParentRow;
				if (dataGridOwner != null && parentRow != null && dataGridOwner.CanUserResizeRows && dataGridOwner.Items.Count > 1 && !object.ReferenceEquals(parentRow.Item, dataGridOwner.Items[0]))
				{
					this._topGripper.Visibility = global::System.Windows.Visibility.Visible;
					return;
				}
				this._topGripper.Visibility = global::System.Windows.Visibility.Collapsed;
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00028E14 File Offset: 0x00027014
		private void SetBottomGripperVisibility()
		{
			if (this._bottomGripper != null)
			{
				global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.DataGridOwner;
				if (dataGridOwner != null && dataGridOwner.CanUserResizeRows)
				{
					this._bottomGripper.Visibility = global::System.Windows.Visibility.Visible;
					return;
				}
				this._bottomGripper.Visibility = global::System.Windows.Visibility.Collapsed;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00028E54 File Offset: 0x00027054
		private global::Microsoft.Windows.Controls.DataGridRow PreviousRow
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGridRow parentRow = this.ParentRow;
				if (parentRow != null)
				{
					global::Microsoft.Windows.Controls.DataGrid dataGridOwner = parentRow.DataGridOwner;
					if (dataGridOwner != null)
					{
						int num = dataGridOwner.ItemContainerGenerator.IndexFromContainer(parentRow);
						if (num > 0)
						{
							return (global::Microsoft.Windows.Controls.DataGridRow)dataGridOwner.ItemContainerGenerator.ContainerFromIndex(num - 1);
						}
					}
				}
				return null;
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00028E9B File Offset: 0x0002709B
		private global::Microsoft.Windows.Controls.DataGridRow RowToResize(object gripper)
		{
			if (gripper != this._bottomGripper)
			{
				return this.PreviousRow;
			}
			return this.ParentRow;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00028EB4 File Offset: 0x000270B4
		private void OnRowHeaderGripperDragStarted(object sender, global::System.Windows.Controls.Primitives.DragStartedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = this.RowToResize(sender);
			if (dataGridRow != null)
			{
				dataGridRow.OnRowResizeStarted();
				e.Handled = true;
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00028EDC File Offset: 0x000270DC
		private void OnRowHeaderResize(object sender, global::System.Windows.Controls.Primitives.DragDeltaEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = this.RowToResize(sender);
			if (dataGridRow != null)
			{
				dataGridRow.OnRowResize(e.VerticalChange);
				e.Handled = true;
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00028F08 File Offset: 0x00027108
		private void OnRowHeaderGripperDragCompleted(object sender, global::System.Windows.Controls.Primitives.DragCompletedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = this.RowToResize(sender);
			if (dataGridRow != null)
			{
				dataGridRow.OnRowResizeCompleted(e.Canceled);
				e.Handled = true;
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00028F34 File Offset: 0x00027134
		private void OnGripperDoubleClicked(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = this.RowToResize(sender);
			if (dataGridRow != null)
			{
				dataGridRow.OnRowResizeReset();
				e.Handled = true;
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00028F59 File Offset: 0x00027159
		private void OnCanUserResizeRowsChanged()
		{
			this.SetTopGripperVisibility();
			this.SetBottomGripperVisibility();
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00028F67 File Offset: 0x00027167
		internal global::Microsoft.Windows.Controls.DataGridRow ParentRow
		{
			get
			{
				return global::Microsoft.Windows.Controls.DataGridHelper.FindParent<global::Microsoft.Windows.Controls.DataGridRow>(this);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00028F70 File Offset: 0x00027170
		private global::Microsoft.Windows.Controls.DataGrid DataGridOwner
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGridRow parentRow = this.ParentRow;
				if (parentRow != null)
				{
					return parentRow.DataGridOwner;
				}
				return null;
			}
		}

		// Token: 0x040002C5 RID: 709
		private const string TopHeaderGripperTemplateName = "PART_TopHeaderGripper";

		// Token: 0x040002C6 RID: 710
		private const string BottomHeaderGripperTemplateName = "PART_BottomHeaderGripper";

		// Token: 0x040002C7 RID: 711
		public static readonly global::System.Windows.DependencyProperty SeparatorBrushProperty = global::System.Windows.DependencyProperty.Register("SeparatorBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040002C8 RID: 712
		public static readonly global::System.Windows.DependencyProperty SeparatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("SeparatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));

		// Token: 0x040002C9 RID: 713
		private static readonly global::System.Windows.DependencyPropertyKey IsRowSelectedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsRowSelected", typeof(bool), typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader), new global::System.Windows.FrameworkPropertyMetadata(false, null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.OnCoerceIsRowSelected)));

		// Token: 0x040002CA RID: 714
		public static readonly global::System.Windows.DependencyProperty IsRowSelectedProperty = global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader.IsRowSelectedPropertyKey.DependencyProperty;

		// Token: 0x040002CB RID: 715
		private global::System.Windows.Controls.Primitives.Thumb _topGripper;

		// Token: 0x040002CC RID: 716
		private global::System.Windows.Controls.Primitives.Thumb _bottomGripper;
	}
}
