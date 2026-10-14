using System;
using System.Windows;
using System.Windows.Controls;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200002C RID: 44
	internal class CrumbBarItemsControl : global::System.Windows.Controls.ItemsControl
	{
		// Token: 0x06000333 RID: 819 RVA: 0x000485D8 File Offset: 0x000467D8
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			short num = (short)1974729438;
			short num2 = num;
			num = (short)1830222558;
			switch (num2 == num)
			{
			}
			num = (short)431751168;
			short num3 = num;
			num = (short)1712193536;
			if (num != 0)
			{
			}
			num = (short)1911029761;
			if (num != 0)
			{
			}
			return item is global::DevComponents.WpfRibbon.CrumbBarItem;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0004868C File Offset: 0x0004688C
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0004873C File Offset: 0x0004693C
		internal global::DevComponents.WpfRibbon.CrumbBarItemView ParentViewItem
		{
			get
			{
				short num = (short)757989377;
				if (num != 0)
				{
				}
				num = (short)1247866064;
				short num2 = num;
				num = (short)156691664;
				switch (num2 == num)
				{
				default:
				{
					num = (short)339804160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)14548992;
				if (num != 0)
				{
				}
				return this._ParentViewItem;
			}
			set
			{
				short num = (short)1135404443;
				short num2 = num;
				num = (short)1013573019;
				switch (num2 == num)
				{
				}
				num = (short)157155328;
				short num3 = num;
				num = (short)1313931265;
				if (num != 0)
				{
				}
				num = (short)1528299520;
				if (num != 0)
				{
				}
				this._ParentViewItem = value;
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000487F0 File Offset: 0x000469F0
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			short num = (short)2124416106;
			short num2 = num;
			num = (short)1302856810;
			switch (num2 == num)
			{
			}
			num = (short)1584988160;
			short num3 = num;
			num = (short)1063845888;
			if (num != 0)
			{
			}
			num = (short)749338625;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfRibbon.CrumbBarItem();
		}

		// Token: 0x0400012B RID: 299
		private global::DevComponents.WpfRibbon.CrumbBarItemView _ParentViewItem;
	}
}
