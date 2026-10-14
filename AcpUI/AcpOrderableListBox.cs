using System;
using System.Windows;
using System.Windows.Controls;
using AcpBusinessLayer;
using AcpUI.Common;
using AcpUI.DragDrop;

namespace AcpUI
{
	// Token: 0x02000020 RID: 32
	public class AcpOrderableListBox : global::AcpUI.AcpListBox
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x000213B8 File Offset: 0x0001F5B8
		public AcpOrderableListBox()
		{
			new global::AcpUI.DragDrop.ListBoxDragDropManager<global::AcpBusinessLayer.ListItem>(this);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000213D4 File Offset: 0x0001F5D4
		public override void OnApplyTemplate()
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_75;
			}
			short num;
			int num3;
			global::System.Windows.Style style;
			for (;;)
			{
				IL_13:
				num = (short)1676017664;
				short num2 = num;
				num = (short)150994945;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
				{
					num = (short)489566025;
					short num4 = num;
					num = (short)755511113;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1847853056;
						if (num != 0)
						{
						}
						global::System.Windows.Style itemContainerStyle = new global::System.Windows.Style(typeof(global::System.Windows.Controls.ListBoxItem), style);
						base.ItemContainerStyle = itemContainerStyle;
						break;
					}
					}
					num = (short)1266941954;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (style != null)
					{
						num = (short)2012086272;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					return;
				}
				goto IL_75;
			}
			return;
			IL_75:
			base.OnApplyTemplate();
			style = (global::System.Windows.Style)base.TryFindResource(global::AcpUI.Common.Utility.c("욤힦슪\udeac\udbae\udcb2춴ﺶ춸\udeba킼뗀뫂꧄ꋆ", a_));
			num = (short)793313281;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}
	}
}
