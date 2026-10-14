using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace DevComponents.WpfDock
{
	// Token: 0x0200003D RID: 61
	public class SplitPanelChildrenCollection : global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.UIElement>
	{
		// Token: 0x060002CC RID: 716 RVA: 0x00049498 File Offset: 0x00047698
		public SplitPanelChildrenCollection(global::DevComponents.WpfDock.SplitPanel parent)
		{
			this.a = parent;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000494B4 File Offset: 0x000476B4
		protected override void ClearItems()
		{
			short num = (short)1968308225;
			if (num != 0)
			{
			}
			num = (short)2121587531;
			short num2 = num;
			num = (short)597023563;
			switch (num2 == num)
			{
			}
			num = (short)1274413056;
			short num3 = num;
			num = (short)574160896;
			if (num != 0)
			{
			}
			this.a.g();
			base.ClearItems();
		}

		// Token: 0x040001A8 RID: 424
		private global::DevComponents.WpfDock.SplitPanel a;
	}
}
