using System;
using System.Windows;
using System.Windows.Controls;
using AcpUI.Common;

namespace AcpUI.Styles
{
	// Token: 0x02000059 RID: 89
	public class ListViewItemStyleSelector : global::System.Windows.Controls.StyleSelector
	{
		// Token: 0x060004DE RID: 1246 RVA: 0x0005E0F0 File Offset: 0x0005C2F0
		public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			short num2;
			string resourceKey;
			global::System.Windows.Controls.ItemsControl itemsControl;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1687283031;
					short num3 = num2;
					num2 = (short)12576087;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A0;
					default:
						num2 = (short)1490944000;
						if (num2 != 0)
						{
						}
						if (this.a % 2 == 0)
						{
							num2 = (short)42467330;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						resourceKey = global::AcpUI.Common.Utility.c("쮡힣튥ﺧ쎩즫\ud9ad羚욱톳\udbb5캹얻튽ꖿ胁ꣃ독귇", a_);
						num2 = (short)113246214;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_A0;
				case 2:
					resourceKey = global::AcpUI.Common.Utility.c("쮡힣튥ﺧ쎩즫\ud9ad羚욱톳\udbb5캹얻튽ꖿ闁곃꿅볇꿉", a_);
					num2 = (short)1835270145;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_CB;
				case 4:
					if (item == itemsControl.Items[0])
					{
						num2 = (short)1875443717;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CB;
				case 5:
				{
					this.a = 0;
					num2 = (short)1413218304;
					short num4 = num2;
					num2 = (short)140705795;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					goto IL_1C8;
				}
				goto IL_35;
				IL_CB:
				num2 = (short)99287040;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A0:
			num2 = (short)1609433089;
			if (num2 != 0)
			{
			}
			IL_1C8:
			this.a++;
			return (global::System.Windows.Style)itemsControl.FindResource(resourceKey);
			IL_35:
			itemsControl = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(container);
			num2 = (short)1030422532;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x040002B2 RID: 690
		private int a;
	}
}
