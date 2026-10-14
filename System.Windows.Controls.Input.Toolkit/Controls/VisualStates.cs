using System;
using System.Linq;
using System.Windows.Media;

namespace System.Windows.Controls
{
	// Token: 0x0200001D RID: 29
	internal static class VisualStates
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00007044 File Offset: 0x00005244
		public static void GoToState(global::System.Windows.Controls.Control control, bool useTransitions, params string[] stateNames)
		{
			foreach (string stateName in stateNames)
			{
				if (global::System.Windows.VisualStateManager.GoToState(control, stateName, useTransitions))
				{
					return;
				}
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00007070 File Offset: 0x00005270
		public static global::System.Windows.FrameworkElement GetImplementationRoot(global::System.Windows.DependencyObject dependencyObject)
		{
			if (1 != global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(dependencyObject))
			{
				return null;
			}
			return global::System.Windows.Media.VisualTreeHelper.GetChild(dependencyObject, 0) as global::System.Windows.FrameworkElement;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000070A8 File Offset: 0x000052A8
		public static global::System.Windows.VisualStateGroup TryGetVisualStateGroup(global::System.Windows.DependencyObject dependencyObject, string groupName)
		{
			global::System.Windows.FrameworkElement implementationRoot = global::System.Windows.Controls.VisualStates.GetImplementationRoot(dependencyObject);
			if (implementationRoot == null)
			{
				return null;
			}
			return (from @group in global::System.Windows.VisualStateManager.GetVisualStateGroups(implementationRoot).OfType<global::System.Windows.VisualStateGroup>()
			where string.CompareOrdinal(groupName, @group.Name) == 0
			select @group).FirstOrDefault<global::System.Windows.VisualStateGroup>();
		}

		// Token: 0x04000086 RID: 134
		public const string GroupCommon = "CommonStates";

		// Token: 0x04000087 RID: 135
		public const string StateNormal = "Normal";

		// Token: 0x04000088 RID: 136
		public const string StateReadOnly = "ReadOnly";

		// Token: 0x04000089 RID: 137
		public const string StateMouseOver = "MouseOver";

		// Token: 0x0400008A RID: 138
		public const string StatePressed = "Pressed";

		// Token: 0x0400008B RID: 139
		public const string StateDisabled = "Disabled";

		// Token: 0x0400008C RID: 140
		public const string GroupFocus = "FocusStates";

		// Token: 0x0400008D RID: 141
		public const string StateUnfocused = "Unfocused";

		// Token: 0x0400008E RID: 142
		public const string StateFocused = "Focused";

		// Token: 0x0400008F RID: 143
		public const string GroupSelection = "SelectionStates";

		// Token: 0x04000090 RID: 144
		public const string StateSelected = "Selected";

		// Token: 0x04000091 RID: 145
		public const string StateUnselected = "Unselected";

		// Token: 0x04000092 RID: 146
		public const string StateSelectedInactive = "SelectedInactive";

		// Token: 0x04000093 RID: 147
		public const string GroupExpansion = "ExpansionStates";

		// Token: 0x04000094 RID: 148
		public const string StateExpanded = "Expanded";

		// Token: 0x04000095 RID: 149
		public const string StateCollapsed = "Collapsed";

		// Token: 0x04000096 RID: 150
		public const string GroupPopup = "PopupStates";

		// Token: 0x04000097 RID: 151
		public const string StatePopupOpened = "PopupOpened";

		// Token: 0x04000098 RID: 152
		public const string StatePopupClosed = "PopupClosed";

		// Token: 0x04000099 RID: 153
		public const string GroupValidation = "ValidationStates";

		// Token: 0x0400009A RID: 154
		public const string StateValid = "Valid";

		// Token: 0x0400009B RID: 155
		public const string StateInvalidFocused = "InvalidFocused";

		// Token: 0x0400009C RID: 156
		public const string StateInvalidUnfocused = "InvalidUnfocused";

		// Token: 0x0400009D RID: 157
		public const string GroupExpandDirection = "ExpandDirectionStates";

		// Token: 0x0400009E RID: 158
		public const string StateExpandDown = "ExpandDown";

		// Token: 0x0400009F RID: 159
		public const string StateExpandUp = "ExpandUp";

		// Token: 0x040000A0 RID: 160
		public const string StateExpandLeft = "ExpandLeft";

		// Token: 0x040000A1 RID: 161
		public const string StateExpandRight = "ExpandRight";

		// Token: 0x040000A2 RID: 162
		public const string GroupHasItems = "HasItemsStates";

		// Token: 0x040000A3 RID: 163
		public const string StateHasItems = "HasItems";

		// Token: 0x040000A4 RID: 164
		public const string StateNoItems = "NoItems";

		// Token: 0x040000A5 RID: 165
		public const string GroupIncrease = "IncreaseStates";

		// Token: 0x040000A6 RID: 166
		public const string StateIncreaseEnabled = "IncreaseEnabled";

		// Token: 0x040000A7 RID: 167
		public const string StateIncreaseDisabled = "IncreaseDisabled";

		// Token: 0x040000A8 RID: 168
		public const string GroupDecrease = "DecreaseStates";

		// Token: 0x040000A9 RID: 169
		public const string StateDecreaseEnabled = "DecreaseEnabled";

		// Token: 0x040000AA RID: 170
		public const string StateDecreaseDisabled = "DecreaseDisabled";

		// Token: 0x040000AB RID: 171
		public const string GroupInteractionMode = "InteractionModeStates";

		// Token: 0x040000AC RID: 172
		public const string StateEdit = "Edit";

		// Token: 0x040000AD RID: 173
		public const string StateDisplay = "Display";

		// Token: 0x040000AE RID: 174
		public const string GroupLocked = "LockedStates";

		// Token: 0x040000AF RID: 175
		public const string StateLocked = "Locked";

		// Token: 0x040000B0 RID: 176
		public const string StateUnlocked = "Unlocked";

		// Token: 0x040000B1 RID: 177
		public const string StateActive = "Active";

		// Token: 0x040000B2 RID: 178
		public const string StateInactive = "Inactive";

		// Token: 0x040000B3 RID: 179
		public const string GroupActive = "ActiveStates";

		// Token: 0x040000B4 RID: 180
		public const string StateUnwatermarked = "Unwatermarked";

		// Token: 0x040000B5 RID: 181
		public const string StateWatermarked = "Watermarked";

		// Token: 0x040000B6 RID: 182
		public const string GroupWatermark = "WatermarkStates";

		// Token: 0x040000B7 RID: 183
		public const string StateCalendarButtonUnfocused = "CalendarButtonUnfocused";

		// Token: 0x040000B8 RID: 184
		public const string StateCalendarButtonFocused = "CalendarButtonFocused";

		// Token: 0x040000B9 RID: 185
		public const string GroupCalendarButtonFocus = "CalendarButtonFocusStates";

		// Token: 0x040000BA RID: 186
		public const string StateBusy = "Busy";

		// Token: 0x040000BB RID: 187
		public const string StateIdle = "Idle";

		// Token: 0x040000BC RID: 188
		public const string GroupBusyStatus = "BusyStatusStates";

		// Token: 0x040000BD RID: 189
		public const string StateVisible = "Visible";

		// Token: 0x040000BE RID: 190
		public const string StateHidden = "Hidden";

		// Token: 0x040000BF RID: 191
		public const string GroupVisibility = "VisibilityStates";
	}
}
