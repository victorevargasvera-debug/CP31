using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000185 RID: 389
	internal abstract class LayoutItem : global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem
	{
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x000729E1 File Offset: 0x00070BE1
		public virtual double PreferredWidth
		{
			get
			{
				return this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth);
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x000729EA File Offset: 0x00070BEA
		public virtual double PreferredHeight
		{
			get
			{
				return this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredHeight);
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x000729F3 File Offset: 0x00070BF3
		public virtual global::Infragistics.Windows.DataPresenter.ItemSizeType SizeTypeHeight
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x000729F6 File Offset: 0x00070BF6
		public virtual global::Infragistics.Windows.DataPresenter.ItemSizeType SizeTypeWidth
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit;
			}
		}

		// Token: 0x0600188B RID: 6283
		public abstract double GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size);

		// Token: 0x0600188C RID: 6284
		protected abstract global::System.Windows.Visibility GetVisibility();

		// Token: 0x0600188D RID: 6285 RVA: 0x000729F9 File Offset: 0x00070BF9
		internal static bool IsWidth(global::Infragistics.Windows.DataPresenter.LayoutItemSize size)
		{
			return size < global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinHeight;
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x000729FF File Offset: 0x00070BFF
		public virtual void SetPreferredWidth(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00072A01 File Offset: 0x00070C01
		public virtual void SetPreferredHeight(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x00072A03 File Offset: 0x00070C03
		global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MaximumSize
		{
			get
			{
				return new global::System.Windows.Size(this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxWidth), this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxHeight));
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x00072A18 File Offset: 0x00070C18
		global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MinimumSize
		{
			get
			{
				return new global::System.Windows.Size(this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinWidth), this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinHeight));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x00072A2D File Offset: 0x00070C2D
		global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.PreferredSize
		{
			get
			{
				return new global::System.Windows.Size(this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth), this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredHeight));
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x00072A42 File Offset: 0x00070C42
		global::System.Windows.Visibility global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.Visibility
		{
			get
			{
				return this.GetVisibility();
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x00072A4A File Offset: 0x00070C4A
		bool global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem.IsHeightAutoSized
		{
			get
			{
				return this.SizeTypeHeight != global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x00072A58 File Offset: 0x00070C58
		bool global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem.IsWidthAutoSized
		{
			get
			{
				return this.SizeTypeWidth != global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit;
			}
		}
	}
}
