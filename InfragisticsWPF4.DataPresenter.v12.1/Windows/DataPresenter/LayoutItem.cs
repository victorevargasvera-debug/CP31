using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000169 RID: 361
	internal abstract class LayoutItem : global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem
	{
		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x00060A39 File Offset: 0x0005EC39
		public virtual double PreferredWidth
		{
			get
			{
				return this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth);
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x00060A42 File Offset: 0x0005EC42
		public virtual double PreferredHeight
		{
			get
			{
				return this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredHeight);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x00060A4B File Offset: 0x0005EC4B
		public virtual global::Infragistics.Windows.DataPresenter.ItemSizeType SizeTypeHeight
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x00060A4E File Offset: 0x0005EC4E
		public virtual global::Infragistics.Windows.DataPresenter.ItemSizeType SizeTypeWidth
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit;
			}
		}

		// Token: 0x06001513 RID: 5395
		public abstract double GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size);

		// Token: 0x06001514 RID: 5396
		protected abstract global::System.Windows.Visibility GetVisibility();

		// Token: 0x06001515 RID: 5397 RVA: 0x00060A51 File Offset: 0x0005EC51
		internal static bool IsWidth(global::Infragistics.Windows.DataPresenter.LayoutItemSize size)
		{
			return size < global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinHeight;
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00060A57 File Offset: 0x0005EC57
		public virtual void SetPreferredWidth(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00060A59 File Offset: 0x0005EC59
		public virtual void SetPreferredHeight(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x00060A5B File Offset: 0x0005EC5B
		global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MaximumSize
		{
			get
			{
				return new global::System.Windows.Size(this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxWidth), this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxHeight));
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x00060A70 File Offset: 0x0005EC70
		global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MinimumSize
		{
			get
			{
				return new global::System.Windows.Size(this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinWidth), this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinHeight));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x00060A85 File Offset: 0x0005EC85
		global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.PreferredSize
		{
			get
			{
				return new global::System.Windows.Size(this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth), this.GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredHeight));
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x00060A9A File Offset: 0x0005EC9A
		global::System.Windows.Visibility global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.Visibility
		{
			get
			{
				return this.GetVisibility();
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x00060AA2 File Offset: 0x0005ECA2
		bool global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem.IsHeightAutoSized
		{
			get
			{
				return this.SizeTypeHeight != global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x00060AB0 File Offset: 0x0005ECB0
		bool global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem.IsWidthAutoSized
		{
			get
			{
				return this.SizeTypeWidth != global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit;
			}
		}
	}
}
