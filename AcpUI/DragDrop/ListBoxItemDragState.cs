using System;
using System.Windows;
using System.Windows.Controls;
using AcpUI.Common;

namespace AcpUI.DragDrop
{
	// Token: 0x0200006D RID: 109
	public static class ListBoxItemDragState
	{
		// Token: 0x060005A9 RID: 1449 RVA: 0x00072700 File Offset: 0x00070900
		internal static bool GetIsBeingDragged(global::System.Windows.DependencyObject A_0)
		{
			short num = (short)1687936107;
			short num2 = num;
			num = (short)601807979;
			switch (num2 == num)
			{
			}
			num = (short)85917696;
			short num3 = num;
			num = (short)315817985;
			if (num != 0)
			{
			}
			num = (short)948502528;
			if (num != 0)
			{
			}
			return (bool)A_0.GetValue(global::AcpUI.DragDrop.ListBoxItemDragState.IsBeingDraggedProperty);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000727B8 File Offset: 0x000709B8
		internal static void SetIsBeingDragged(global::System.Windows.DependencyObject A_0, bool A_1)
		{
			short num = (short)114364479;
			short num2 = num;
			num = (short)1665994815;
			switch (num2 == num)
			{
			}
			num = (short)717291520;
			short num3 = num;
			num = (short)2033647616;
			if (num != 0)
			{
			}
			num = (short)669253633;
			if (num != 0)
			{
			}
			A_0.SetValue(global::AcpUI.DragDrop.ListBoxItemDragState.IsBeingDraggedProperty, A_1);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00072870 File Offset: 0x00070A70
		internal static bool GetIsUnderDragCursor(global::System.Windows.DependencyObject A_0)
		{
			short num = (short)91752469;
			short num2 = num;
			num = (short)1422329877;
			switch (num2 == num)
			{
			}
			num = (short)881655808;
			short num3 = num;
			num = (short)1471807489;
			if (num != 0)
			{
			}
			num = (short)1861353472;
			if (num != 0)
			{
			}
			return (bool)A_0.GetValue(global::AcpUI.DragDrop.ListBoxItemDragState.IsUnderDragCursorProperty);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0007292C File Offset: 0x00070B2C
		internal static void SetIsUnderDragCursor(global::System.Windows.Controls.ListBoxItem A_0, bool A_1)
		{
			short num = (short)1392844967;
			short num2 = num;
			num = (short)375922855;
			switch (num2 == num)
			{
			}
			num = (short)968818688;
			short num3 = num;
			num = (short)49872897;
			if (num != 0)
			{
			}
			num = (short)2066153472;
			if (num != 0)
			{
			}
			A_0.SetValue(global::AcpUI.DragDrop.ListBoxItemDragState.IsUnderDragCursorProperty, A_1);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000729E4 File Offset: 0x00070BE4
		// Note: this type is marked as 'beforefieldinit'.
		static ListBoxItemDragState()
		{
			int a_ = 13;
			short num = (short)1234698241;
			if (num != 0)
			{
			}
			num = (short)1157094860;
			short num2 = num;
			num = (short)1077796300;
			switch (num2 == num)
			{
			default:
			{
				num = (short)952958976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1573257216;
			if (num != 0)
			{
			}
			global::AcpUI.DragDrop.ListBoxItemDragState.IsBeingDraggedProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("횤첨슪쎬좮솲풴킶\udeb8\udeba\ud9bc", a_), typeof(bool), typeof(global::AcpUI.DragDrop.ListBoxItemDragState), new global::System.Windows.UIPropertyMetadata(false));
			global::AcpUI.DragDrop.ListBoxItemDragState.IsUnderDragCursorProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("횤잨쾪좬\uddae솲풴킶視캺쾼첾껀뇂", a_), typeof(bool), typeof(global::AcpUI.DragDrop.ListBoxItemDragState), new global::System.Windows.UIPropertyMetadata(false));
		}

		// Token: 0x040002FE RID: 766
		public static readonly global::System.Windows.DependencyProperty IsBeingDraggedProperty;

		// Token: 0x040002FF RID: 767
		public static readonly global::System.Windows.DependencyProperty IsUnderDragCursorProperty;
	}
}
