using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200010F RID: 271
	[global::System.Windows.TemplatePart(Name = "PagerItems", Type = typeof(global::System.Windows.Controls.Primitives.Selector))]
	public class PagerControl : global::Infragistics.Controls.Grids.Primitives.PagerControlBase, global::Infragistics.ICommandTarget
	{
		// Token: 0x0600092D RID: 2349 RVA: 0x000249AC File Offset: 0x00022BAC
		static PagerControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.PagerControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.PagerControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.PagerControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00024A44 File Offset: 0x00022C44
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00024A56 File Offset: 0x00022C56
		public int MaximumAvailablePagerValues
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Grids.Primitives.PagerControl.MaximumAvailablePagerValuesProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.PagerControl.MaximumAvailablePagerValuesProperty, value);
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00024A6C File Offset: 0x00022C6C
		private static void MaximumAvailablePagerValuesChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.PagerControl pagerControl = (global::Infragistics.Controls.Grids.Primitives.PagerControl)obj;
			pagerControl.EnsureContent();
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00024A88 File Offset: 0x00022C88
		protected internal void AddItemsToList(int startPage, int endPage)
		{
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			for (int i = startPage; i <= endPage; i++)
			{
				list.Add(i);
			}
			this._selectorControl.ItemsSource = list;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00024ABC File Offset: 0x00022CBC
		protected internal override void InvalidateItems()
		{
			int totalPages = base.TotalPages;
			this._selectorControl.ItemsSource = null;
			if (this.MaximumAvailablePagerValues < 0)
			{
				this.AddItemsToList(1, base.TotalPages);
			}
			else if (totalPages < this.MaximumAvailablePagerValues)
			{
				this.AddItemsToList(1, totalPages);
			}
			else
			{
				int num = this.MaximumAvailablePagerValues / 2;
				int num2 = base.CurrentPageIndex - num;
				if (num2 <= 1)
				{
					this.AddItemsToList(1, this.MaximumAvailablePagerValues);
				}
				else if (num2 + this.MaximumAvailablePagerValues >= base.TotalPages)
				{
					this.AddItemsToList(base.TotalPages - this.MaximumAvailablePagerValues + 1, base.TotalPages);
				}
				else
				{
					int num3 = num2 + this.MaximumAvailablePagerValues - 1;
					if (num3 > base.TotalPages)
					{
						num3 = base.TotalPages;
					}
					this.AddItemsToList(num2, num3);
				}
			}
			this._originalPageCount = totalPages;
			this._originalPageIndex = base.CurrentPageIndex;
			if (this._selectorControl.SelectedItem == null || (int)this._selectorControl.SelectedItem != base.CurrentPageIndex)
			{
				this._selectorControl.SelectedItem = base.CurrentPageIndex;
			}
			this.CheckButtonState();
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00024BD4 File Offset: 0x00022DD4
		protected internal override void EnsureContent()
		{
			if (this._selectorControl != null)
			{
				int totalPages = base.TotalPages;
				if (this._originalPageCount != totalPages || this._originalPageIndex != base.CurrentPageIndex)
				{
					this.InvalidateItems();
				}
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00024C0D File Offset: 0x00022E0D
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.Primitives.PagingControlCommandBase;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00024C18 File Offset: 0x00022E18
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			global::System.Windows.Controls.SelectionChangedEventArgs selectionChangedEventArgs = source.OriginEventArgs as global::System.Windows.Controls.SelectionChangedEventArgs;
			if (selectionChangedEventArgs != null && selectionChangedEventArgs.RemovedItems.Count > 0 && selectionChangedEventArgs.AddedItems.Count > 0)
			{
				return new object[]
				{
					this,
					(int)selectionChangedEventArgs.AddedItems[0]
				};
			}
			return this;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00024C77 File Offset: 0x00022E77
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._selectorControl = (base.GetTemplateChild("PagerItems") as global::System.Windows.Controls.Primitives.Selector);
			if (this._selectorControl != null)
			{
				this.EnsureContent();
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00024CA3 File Offset: 0x00022EA3
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00024CAC File Offset: 0x00022EAC
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x0400024A RID: 586
		private global::System.Windows.Controls.Primitives.Selector _selectorControl;

		// Token: 0x0400024B RID: 587
		private int _originalPageCount = -1;

		// Token: 0x0400024C RID: 588
		private int _originalPageIndex = -1;

		// Token: 0x0400024D RID: 589
		public static readonly global::System.Windows.DependencyProperty MaximumAvailablePagerValuesProperty = global::System.Windows.DependencyProperty.Register("MaximumAvailablePagerValues", typeof(int), typeof(global::Infragistics.Controls.Grids.Primitives.PagerControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.PagerControl.MaximumAvailablePagerValuesChanged)));
	}
}
