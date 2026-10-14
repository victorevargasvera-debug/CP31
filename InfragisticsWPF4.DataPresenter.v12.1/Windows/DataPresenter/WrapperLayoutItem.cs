using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200016F RID: 367
	internal class WrapperLayoutItem : global::Infragistics.Windows.DataPresenter.LayoutItem, global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem
	{
		// Token: 0x06001579 RID: 5497 RVA: 0x00061C90 File Offset: 0x0005FE90
		internal WrapperLayoutItem(global::Infragistics.Windows.DataPresenter.LayoutItem layoutItem)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(layoutItem);
			this._layoutItem = layoutItem;
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00061CA8 File Offset: 0x0005FEA8
		public override double GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size)
		{
			if (size != global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth)
			{
				if (size == global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredHeight)
				{
					if (this._preferredHeight != null)
					{
						return this._preferredHeight.Value;
					}
				}
			}
			else if (this._preferredWidth != null)
			{
				return this._preferredWidth.Value;
			}
			return this._layoutItem.GetSize(size);
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00061CFF File Offset: 0x0005FEFF
		protected override global::System.Windows.Visibility GetVisibility()
		{
			return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this._layoutItem).Visibility;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00061D0C File Offset: 0x0005FF0C
		public override void SetPreferredHeight(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this._preferredHeight = new double?(value);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00061D1A File Offset: 0x0005FF1A
		public override void SetPreferredWidth(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this._preferredWidth = new double?(value);
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x00061D28 File Offset: 0x0005FF28
		public global::Infragistics.Windows.DataPresenter.LayoutItem BaseItem
		{
			get
			{
				return this._layoutItem;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x00061D30 File Offset: 0x0005FF30
		global::Infragistics.Controls.Layouts.Primitives.ILayoutItem global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem.InnerLayoutItem
		{
			get
			{
				return this._layoutItem;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x00061D38 File Offset: 0x0005FF38
		// (set) Token: 0x06001581 RID: 5505 RVA: 0x00061D40 File Offset: 0x0005FF40
		double? global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem.ExplicitWidth
		{
			get
			{
				return this._preferredWidth;
			}
			set
			{
				if (!object.Equals(this._preferredWidth, value))
				{
					this._preferredWidth = value;
				}
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x00061D61 File Offset: 0x0005FF61
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x00061D69 File Offset: 0x0005FF69
		double? global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem.ExplicitHeight
		{
			get
			{
				return this._preferredHeight;
			}
			set
			{
				if (!object.Equals(this._preferredHeight, value))
				{
					this._preferredHeight = value;
				}
			}
		}

		// Token: 0x04000886 RID: 2182
		private global::Infragistics.Windows.DataPresenter.LayoutItem _layoutItem;

		// Token: 0x04000887 RID: 2183
		private double? _preferredWidth;

		// Token: 0x04000888 RID: 2184
		private double? _preferredHeight;
	}
}
