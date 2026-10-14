using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Windows.Automation.Peers;

namespace Microsoft.Windows.Controls.Primitives
{
	// Token: 0x0200000B RID: 11
	public class DataGridDetailsPresenter : global::System.Windows.Controls.ContentPresenter
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00004794 File Offset: 0x00002994
		static DataGridDetailsPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter)));
			global::System.Windows.Controls.ContentPresenter.ContentTemplateProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter.OnCoerceContentTemplate)));
			global::System.Windows.Controls.ContentPresenter.ContentTemplateSelectorProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter.OnCoerceContentTemplateSelector)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter), global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter.OnAnyMouseLeftButtonDownThunk), true);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000484F File Offset: 0x00002A4F
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Microsoft.Windows.Automation.Peers.DataGridDetailsPresenterAutomationPeer(this);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004858 File Offset: 0x00002A58
		private static object OnCoerceContentTemplate(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter dataGridDetailsPresenter = d as global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter;
			global::Microsoft.Windows.Controls.DataGridRow dataGridRowOwner = dataGridDetailsPresenter.DataGridRowOwner;
			global::Microsoft.Windows.Controls.DataGrid grandParentObject = (dataGridRowOwner != null) ? dataGridRowOwner.DataGridOwner : null;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridDetailsPresenter, baseValue, global::System.Windows.Controls.ContentPresenter.ContentTemplateProperty, dataGridRowOwner, global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateProperty, grandParentObject, global::Microsoft.Windows.Controls.DataGrid.RowDetailsTemplateProperty);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004898 File Offset: 0x00002A98
		private static object OnCoerceContentTemplateSelector(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter dataGridDetailsPresenter = d as global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter;
			global::Microsoft.Windows.Controls.DataGridRow dataGridRowOwner = dataGridDetailsPresenter.DataGridRowOwner;
			global::Microsoft.Windows.Controls.DataGrid grandParentObject = (dataGridRowOwner != null) ? dataGridRowOwner.DataGridOwner : null;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridDetailsPresenter, baseValue, global::System.Windows.Controls.ContentPresenter.ContentTemplateSelectorProperty, dataGridRowOwner, global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateSelectorProperty, grandParentObject, global::Microsoft.Windows.Controls.DataGrid.RowDetailsTemplateSelectorProperty);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000048D8 File Offset: 0x00002AD8
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			base.OnVisualParentChanged(oldParent);
			global::Microsoft.Windows.Controls.DataGridRow dataGridRowOwner = this.DataGridRowOwner;
			if (dataGridRowOwner != null)
			{
				dataGridRowOwner.DetailsPresenter = this;
				this.SyncProperties();
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00004903 File Offset: 0x00002B03
		private bool IsInVisualSubTree(global::System.Windows.DependencyObject visual)
		{
			while (visual != null)
			{
				if (visual == this)
				{
					return true;
				}
				visual = global::System.Windows.Media.VisualTreeHelper.GetParent(visual);
			}
			return false;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004919 File Offset: 0x00002B19
		private static void OnAnyMouseLeftButtonDownThunk(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			((global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter)sender).OnAnyMouseLeftButtonDown(e);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00004928 File Offset: 0x00002B28
		private void OnAnyMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!this.IsInVisualSubTree(e.OriginalSource as global::System.Windows.DependencyObject))
			{
				return;
			}
			global::Microsoft.Windows.Controls.DataGridRow dataGridRowOwner = this.DataGridRowOwner;
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (dataGridRowOwner != null) ? dataGridRowOwner.DataGridOwner : null;
			if (dataGrid != null && dataGridRowOwner != null)
			{
				if (dataGrid.CurrentCell.Item != dataGridRowOwner.Item)
				{
					dataGrid.ScrollIntoView(dataGridRowOwner.Item, dataGrid.ColumnFromDisplayIndex(0));
				}
				dataGrid.HandleSelectionForRowHeaderAndDetailsInput(dataGridRowOwner, global::System.Windows.Input.Mouse.Captured == null);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000499C File Offset: 0x00002B9C
		internal global::System.Windows.FrameworkElement DetailsElement
		{
			get
			{
				int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this);
				if (childrenCount > 0)
				{
					return global::System.Windows.Media.VisualTreeHelper.GetChild(this, 0) as global::System.Windows.FrameworkElement;
				}
				return null;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000049C4 File Offset: 0x00002BC4
		internal void SyncProperties()
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRowOwner = this.DataGridRowOwner;
			base.Content = ((dataGridRowOwner != null) ? dataGridRowOwner.Item : null);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentPresenter.ContentTemplateProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentPresenter.ContentTemplateSelectorProperty);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00004A00 File Offset: 0x00002C00
		private static void OnNotifyPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter)d).NotifyPropertyChanged(d, e);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00004A10 File Offset: 0x00002C10
		internal void NotifyPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowDetailsTemplateProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateProperty || e.Property == global::System.Windows.Controls.ContentPresenter.ContentTemplateProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentPresenter.ContentTemplateProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowDetailsTemplateSelectorProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateSelectorProperty || e.Property == global::System.Windows.Controls.ContentPresenter.ContentTemplateSelectorProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentPresenter.ContentTemplateSelectorProperty);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004A88 File Offset: 0x00002C88
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRowOwner = this.DataGridRowOwner;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridRowOwner.DataGridOwner;
			if (dataGridRowOwner.DetailsPresenterDrawsGridLines && global::Microsoft.Windows.Controls.DataGridHelper.IsGridLineVisible(dataGridOwner, true))
			{
				double horizontalGridLineThickness = dataGridOwner.HorizontalGridLineThickness;
				global::System.Windows.Size result = base.MeasureOverride(global::Microsoft.Windows.Controls.DataGridHelper.SubtractFromSize(availableSize, horizontalGridLineThickness, true));
				result.Height += horizontalGridLineThickness;
				return result;
			}
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004AE4 File Offset: 0x00002CE4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRowOwner = this.DataGridRowOwner;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridRowOwner.DataGridOwner;
			if (dataGridRowOwner.DetailsPresenterDrawsGridLines && global::Microsoft.Windows.Controls.DataGridHelper.IsGridLineVisible(dataGridOwner, true))
			{
				double horizontalGridLineThickness = dataGridOwner.HorizontalGridLineThickness;
				global::System.Windows.Size result = base.ArrangeOverride(global::Microsoft.Windows.Controls.DataGridHelper.SubtractFromSize(finalSize, horizontalGridLineThickness, true));
				result.Height += horizontalGridLineThickness;
				return result;
			}
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004B40 File Offset: 0x00002D40
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			base.OnRender(drawingContext);
			global::Microsoft.Windows.Controls.DataGridRow dataGridRowOwner = this.DataGridRowOwner;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridRowOwner.DataGridOwner;
			if (dataGridRowOwner.DetailsPresenterDrawsGridLines && global::Microsoft.Windows.Controls.DataGridHelper.IsGridLineVisible(dataGridOwner, true))
			{
				double horizontalGridLineThickness = dataGridOwner.HorizontalGridLineThickness;
				global::System.Windows.Rect rectangle = new global::System.Windows.Rect(new global::System.Windows.Size(base.RenderSize.Width, horizontalGridLineThickness));
				rectangle.Y = base.RenderSize.Height - horizontalGridLineThickness;
				drawingContext.DrawRectangle(dataGridOwner.HorizontalGridLinesBrush, null, rectangle);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00004BBC File Offset: 0x00002DBC
		private global::Microsoft.Windows.Controls.DataGrid DataGridOwner
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGridRow dataGridRowOwner = this.DataGridRowOwner;
				if (dataGridRowOwner != null)
				{
					return dataGridRowOwner.DataGridOwner;
				}
				return null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00004BDB File Offset: 0x00002DDB
		internal global::Microsoft.Windows.Controls.DataGridRow DataGridRowOwner
		{
			get
			{
				return global::Microsoft.Windows.Controls.DataGridHelper.FindParent<global::Microsoft.Windows.Controls.DataGridRow>(this);
			}
		}
	}
}
