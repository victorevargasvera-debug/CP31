using System;
using System.Windows;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200002F RID: 47
	public class CrumbBarSelectionChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0004C1C0 File Offset: 0x0004A3C0
		public object SelectedItem
		{
			get
			{
				short num = (short)1009361274;
				short num2 = num;
				num = (short)38969722;
				switch (num2 == num)
				{
				}
				num = (short)137363457;
				if (num != 0)
				{
				}
				num = (short)2115698688;
				short num3 = num;
				num = (short)647168000;
				if (num != 0)
				{
				}
				return this._SelectedItem;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0004C270 File Offset: 0x0004A470
		public object DeselectedItem
		{
			get
			{
				short num = (short)259538100;
				short num2 = num;
				num = (short)1005468852;
				switch (num2 == num)
				{
				}
				num = (short)892076032;
				if (num != 0)
				{
				}
				num = (short)625147904;
				short num3 = num;
				num = (short)2006253569;
				if (num != 0)
				{
				}
				return this._DeselectedItem;
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0004C31C File Offset: 0x0004A51C
		public CrumbBarSelectionChangedEventArgs(global::System.Windows.RoutedEvent routedEvent, object source, object selectedItem, object deselectedItem) : base(routedEvent, source)
		{
			this._SelectedItem = selectedItem;
			this._DeselectedItem = deselectedItem;
		}

		// Token: 0x0400013C RID: 316
		private object _SelectedItem;

		// Token: 0x0400013D RID: 317
		private object _DeselectedItem;
	}
}
