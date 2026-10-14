using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter.Internal
{
	// Token: 0x02000357 RID: 855
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RecordListItemContainer : global::System.Windows.FrameworkElement, global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer
	{
		// Token: 0x06002986 RID: 10630 RVA: 0x000B6A49 File Offset: 0x000B4C49
		internal RecordListItemContainer()
		{
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x000B6A51 File Offset: 0x000B4C51
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this._child != null)
			{
				this._child.Arrange(new global::System.Windows.Rect(finalSize));
			}
			return finalSize;
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002988 RID: 10632 RVA: 0x000B6A6D File Offset: 0x000B4C6D
		public global::System.Windows.UIElement Child
		{
			get
			{
				return this._child;
			}
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x000B6A75 File Offset: 0x000B4C75
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index == 0 && this._child != null)
			{
				return this._child;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x000B6A90 File Offset: 0x000B4C90
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return new global::Infragistics.Collections.SingleItemEnumerator(this._child);
			}
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x000B6AA0 File Offset: 0x000B4CA0
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this._child != null)
			{
				this._child.Measure(availableSize);
				return this._child.DesiredSize;
			}
			return default(global::System.Windows.Size);
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x0600298C RID: 10636 RVA: 0x000B6AD6 File Offset: 0x000B4CD6
		protected override int VisualChildrenCount
		{
			get
			{
				if (this._child == null)
				{
					return 0;
				}
				return 1;
			}
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x000B6AE4 File Offset: 0x000B4CE4
		internal void SetChild(global::System.Windows.FrameworkElement child, global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			if (this._child != child)
			{
				if (this._child != null)
				{
					if (this._child.Parent == this)
					{
						base.RemoveLogicalChild(this._child);
					}
					if (dp != null && this.RecordPresenter == dp.PendingActiveRecordPresenter)
					{
						dp.InternalAddLogicalChild(this._child);
					}
					base.RemoveVisualChild(this._child);
				}
				this._child = child;
				if (this._child != null)
				{
					base.AddVisualChild(this._child);
					if (dp != null && this._child.Parent == dp)
					{
						dp.InternalRemoveLogicalChild(this._child);
					}
					base.AddLogicalChild(this._child);
					this._child.ClearValue(global::System.Windows.FrameworkElement.DataContextProperty);
					global::System.Windows.Data.Binding binding = global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.HorizontalAlignmentProperty, global::System.Windows.Data.BindingMode.TwoWay, this._child);
					global::System.Windows.Data.Binding binding2 = global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.VerticalAlignmentProperty, global::System.Windows.Data.BindingMode.TwoWay, this._child);
					global::System.Windows.Data.BindingOperations.SetBinding(this, global::System.Windows.FrameworkElement.HorizontalAlignmentProperty, binding);
					global::System.Windows.Data.BindingOperations.SetBinding(this, global::System.Windows.FrameworkElement.VerticalAlignmentProperty, binding2);
					global::System.Windows.Data.BindingOperations.SetBinding(this, global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.UIElement.VisibilityProperty, global::System.Windows.Data.BindingMode.TwoWay, this._child));
					return;
				}
				global::System.Windows.Data.BindingOperations.ClearAllBindings(this);
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x000B6C04 File Offset: 0x000B4E04
		public global::Infragistics.Windows.DataPresenter.RecordPresenter RecordPresenter
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(this.Child);
			}
		}

		// Token: 0x04001402 RID: 5122
		private global::System.Windows.FrameworkElement _child;
	}
}
