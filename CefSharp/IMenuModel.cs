using System;

namespace CefSharp
{
	// Token: 0x02000074 RID: 116
	public interface IMenuModel
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600029D RID: 669
		int Count { get; }

		// Token: 0x0600029E RID: 670
		bool Clear();

		// Token: 0x0600029F RID: 671
		string GetLabelAt(int index);

		// Token: 0x060002A0 RID: 672
		global::CefSharp.CefMenuCommand GetCommandIdAt(int index);

		// Token: 0x060002A1 RID: 673
		bool Remove(global::CefSharp.CefMenuCommand commandId);

		// Token: 0x060002A2 RID: 674
		bool AddItem(global::CefSharp.CefMenuCommand commandId, string label);

		// Token: 0x060002A3 RID: 675
		bool AddSeparator();

		// Token: 0x060002A4 RID: 676
		bool AddCheckItem(global::CefSharp.CefMenuCommand commandId, string label);

		// Token: 0x060002A5 RID: 677
		bool AddRadioItem(global::CefSharp.CefMenuCommand commandId, string label, int groupId);

		// Token: 0x060002A6 RID: 678
		global::CefSharp.IMenuModel AddSubMenu(global::CefSharp.CefMenuCommand commandId, string label);

		// Token: 0x060002A7 RID: 679
		bool InsertSeparatorAt(int index);

		// Token: 0x060002A8 RID: 680
		bool InsertItemAt(int index, global::CefSharp.CefMenuCommand commandId, string label);

		// Token: 0x060002A9 RID: 681
		bool InsertCheckItemAt(int index, global::CefSharp.CefMenuCommand commandId, string label);

		// Token: 0x060002AA RID: 682
		bool InsertRadioItemAt(int index, global::CefSharp.CefMenuCommand commandId, string label, int groupId);

		// Token: 0x060002AB RID: 683
		global::CefSharp.IMenuModel InsertSubMenuAt(int index, global::CefSharp.CefMenuCommand commandId, string label);

		// Token: 0x060002AC RID: 684
		bool RemoveAt(int index);

		// Token: 0x060002AD RID: 685
		int GetIndexOf(global::CefSharp.CefMenuCommand commandId);

		// Token: 0x060002AE RID: 686
		bool SetCommandIdAt(int index, global::CefSharp.CefMenuCommand commandId);

		// Token: 0x060002AF RID: 687
		string GetLabel(global::CefSharp.CefMenuCommand commandId);

		// Token: 0x060002B0 RID: 688
		bool SetLabel(global::CefSharp.CefMenuCommand commandId, string label);

		// Token: 0x060002B1 RID: 689
		bool SetLabelAt(int index, string label);

		// Token: 0x060002B2 RID: 690
		global::CefSharp.MenuItemType GetType(global::CefSharp.CefMenuCommand commandId);

		// Token: 0x060002B3 RID: 691
		global::CefSharp.MenuItemType GetTypeAt(int index);

		// Token: 0x060002B4 RID: 692
		int GetGroupId(global::CefSharp.CefMenuCommand commandId);

		// Token: 0x060002B5 RID: 693
		int GetGroupIdAt(int index);

		// Token: 0x060002B6 RID: 694
		bool SetGroupId(global::CefSharp.CefMenuCommand commandId, int groupId);

		// Token: 0x060002B7 RID: 695
		bool SetGroupIdAt(int index, int groupId);

		// Token: 0x060002B8 RID: 696
		global::CefSharp.IMenuModel GetSubMenu(global::CefSharp.CefMenuCommand commandId);

		// Token: 0x060002B9 RID: 697
		global::CefSharp.IMenuModel GetSubMenuAt(int index);

		// Token: 0x060002BA RID: 698
		bool IsVisible(global::CefSharp.CefMenuCommand commandId);

		// Token: 0x060002BB RID: 699
		bool IsVisibleAt(int index);

		// Token: 0x060002BC RID: 700
		bool SetVisible(global::CefSharp.CefMenuCommand commandId, bool visible);

		// Token: 0x060002BD RID: 701
		bool SetVisibleAt(int index, bool visible);

		// Token: 0x060002BE RID: 702
		bool IsEnabled(global::CefSharp.CefMenuCommand commandId);

		// Token: 0x060002BF RID: 703
		bool IsEnabledAt(int index);

		// Token: 0x060002C0 RID: 704
		bool SetEnabled(global::CefSharp.CefMenuCommand commandId, bool enabled);

		// Token: 0x060002C1 RID: 705
		bool SetEnabledAt(int index, bool enabled);

		// Token: 0x060002C2 RID: 706
		bool IsChecked(global::CefSharp.CefMenuCommand commandId);

		// Token: 0x060002C3 RID: 707
		bool IsCheckedAt(int index);

		// Token: 0x060002C4 RID: 708
		bool SetChecked(global::CefSharp.CefMenuCommand commandId, bool isChecked);

		// Token: 0x060002C5 RID: 709
		bool SetCheckedAt(int index, bool isChecked);

		// Token: 0x060002C6 RID: 710
		bool HasAccelerator(global::CefSharp.CefMenuCommand commandId);

		// Token: 0x060002C7 RID: 711
		bool HasAcceleratorAt(int index);

		// Token: 0x060002C8 RID: 712
		bool SetAccelerator(global::CefSharp.CefMenuCommand commandId, int keyCode, bool shiftPressed, bool ctrlPressed, bool altPressed);

		// Token: 0x060002C9 RID: 713
		bool SetAcceleratorAt(int index, int keyCode, bool shiftPressed, bool ctrlPressed, bool altPressed);

		// Token: 0x060002CA RID: 714
		bool RemoveAccelerator(global::CefSharp.CefMenuCommand commandId);

		// Token: 0x060002CB RID: 715
		bool RemoveAcceleratorAt(int index);

		// Token: 0x060002CC RID: 716
		bool GetAccelerator(global::CefSharp.CefMenuCommand commandId, out int keyCode, out bool shiftPressed, out bool ctrlPressed, out bool altPressed);

		// Token: 0x060002CD RID: 717
		bool GetAcceleratorAt(int index, out int keyCode, out bool shiftPressed, out bool ctrlPressed, out bool altPressed);
	}
}
