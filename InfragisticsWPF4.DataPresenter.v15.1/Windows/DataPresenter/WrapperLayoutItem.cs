using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200018B RID: 395
	internal class WrapperLayoutItem : global::Infragistics.Windows.DataPresenter.LayoutItem, global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem
	{
		// Token: 0x060018FB RID: 6395 RVA: 0x00073DE4 File Offset: 0x00071FE4
		internal WrapperLayoutItem(global::Infragistics.Windows.DataPresenter.LayoutItem layoutItem)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(layoutItem);
			this._layoutItem = layoutItem;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00073DFC File Offset: 0x00071FFC
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

		// Token: 0x060018FD RID: 6397 RVA: 0x00073E53 File Offset: 0x00072053
		protected override global::System.Windows.Visibility GetVisibility()
		{
			return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this._layoutItem).Visibility;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00073E60 File Offset: 0x00072060
		public override void SetPreferredHeight(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this._preferredHeight = new double?(value);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00073E6E File Offset: 0x0007206E
		public override void SetPreferredWidth(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this._preferredWidth = new double?(value);
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x00073E7C File Offset: 0x0007207C
		public global::Infragistics.Windows.DataPresenter.LayoutItem BaseItem
		{
			get
			{
				return this._layoutItem;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x00073E84 File Offset: 0x00072084
		global::Infragistics.Controls.Layouts.Primitives.ILayoutItem global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem.InnerLayoutItem
		{
			get
			{
				return this._layoutItem;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x00073E8C File Offset: 0x0007208C
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x00073E94 File Offset: 0x00072094
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

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x00073EB5 File Offset: 0x000720B5
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x00073EBD File Offset: 0x000720BD
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

		// Token: 0x04000A3C RID: 2620
		private global::Infragistics.Windows.DataPresenter.LayoutItem _layoutItem;

		// Token: 0x04000A3D RID: 2621
		private double? _preferredWidth;

		// Token: 0x04000A3E RID: 2622
		private double? _preferredHeight;
	}
}
