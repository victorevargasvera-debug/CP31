using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000A1 RID: 161
	internal static class VisualStateUtilities
	{
		// Token: 0x0600062A RID: 1578 RVA: 0x00018008 File Offset: 0x00016208
		public static bool GetHasVisualStateGroups(global::System.Windows.Controls.Control control)
		{
			if (control == null)
			{
				return false;
			}
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(control);
			for (int i = 0; i < childrenCount; i++)
			{
				global::System.Windows.FrameworkElement frameworkElement = global::System.Windows.Media.VisualTreeHelper.GetChild(control, i) as global::System.Windows.FrameworkElement;
				if (frameworkElement != null && frameworkElement.TemplatedParent == control)
				{
					return global::System.Windows.DependencyPropertyHelper.GetValueSource(frameworkElement, global::System.Windows.VisualStateManager.VisualStateGroupsProperty).BaseValueSource != global::System.Windows.BaseValueSource.Default;
				}
			}
			return false;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00018064 File Offset: 0x00016264
		public static void GoToState(global::System.Windows.Controls.Control control, bool useTransitions, params string[] states)
		{
			if (states != null)
			{
				int num = states.Length;
				for (int i = 0; i < num; i++)
				{
					if (global::System.Windows.VisualStateManager.GoToState(control, states[i], useTransitions))
					{
						return;
					}
				}
			}
		}

		// Token: 0x04000276 RID: 630
		public const string GroupActive = "ActiveStates";

		// Token: 0x04000277 RID: 631
		public const string GroupCalendar = "CalendarStates";

		// Token: 0x04000278 RID: 632
		public const string GroupChange = "ChangeStates";

		// Token: 0x04000279 RID: 633
		public const string GroupCheck = "CheckStates";

		// Token: 0x0400027A RID: 634
		public const string GroupCommon = "CommonStates";

		// Token: 0x0400027B RID: 635
		public const string GroupContextual = "ContextualStates";

		// Token: 0x0400027C RID: 636
		public const string GroupCurrent = "CurrentStates";

		// Token: 0x0400027D RID: 637
		public const string GroupDay = "DayStates";

		// Token: 0x0400027E RID: 638
		public const string GroupDrag = "DragStates";

		// Token: 0x0400027F RID: 639
		public const string GroupEdit = "EditStates";

		// Token: 0x04000280 RID: 640
		public const string GroupEmbedded = "EmbeddedStates";

		// Token: 0x04000281 RID: 641
		public const string GroupError = "ErrorStates";

		// Token: 0x04000282 RID: 642
		public const string GroupExpansion = "ExpansionStates";

		// Token: 0x04000283 RID: 643
		public const string GroupFilter = "FilterStates";

		// Token: 0x04000284 RID: 644
		public const string GroupFirstLastItem = "FirstLastItemStates";

		// Token: 0x04000285 RID: 645
		public const string GroupFixed = "FixedStates";

		// Token: 0x04000286 RID: 646
		public const string GroupFocus = "FocusStates";

		// Token: 0x04000287 RID: 647
		public const string GroupHasItems = "HasItemsStates";

		// Token: 0x04000288 RID: 648
		public const string GroupHighlight = "HighlightStates";

		// Token: 0x04000289 RID: 649
		public const string GroupInteraction = "InteractionStates";

		// Token: 0x0400028A RID: 650
		public const string GroupLeadingOrTrailing = "LeadingOrTrailingStates";

		// Token: 0x0400028B RID: 651
		public const string GroupLocation = "LocationStates";

		// Token: 0x0400028C RID: 652
		public const string GroupMajor = "MajorStates";

		// Token: 0x0400028D RID: 653
		public const string GroupMinimized = "MinimizedStates";

		// Token: 0x0400028E RID: 654
		public const string GroupOpen = "OpenStates";

		// Token: 0x0400028F RID: 655
		public const string GroupPaneLocation = "PaneLocationStates";

		// Token: 0x04000290 RID: 656
		public const string GroupRecord = "RecordStates";

		// Token: 0x04000291 RID: 657
		public const string GroupSelection = "SelectionStates";

		// Token: 0x04000292 RID: 658
		public const string GroupSort = "SortStates";

		// Token: 0x04000293 RID: 659
		public const string GroupSplitterLocation = "SplitterLocationStates";

		// Token: 0x04000294 RID: 660
		public const string GroupValidationEx = "ValidationStatesEx";

		// Token: 0x04000295 RID: 661
		public const string GroupWorkDay = "WorkDayStates";

		// Token: 0x04000296 RID: 662
		public const string GroupOrientation = "OrientationStates";

		// Token: 0x04000297 RID: 663
		public const string GroupWorkingHour = "WorkingHourStates";

		// Token: 0x04000298 RID: 664
		public const string GroupDirection = "DirectionStates";

		// Token: 0x04000299 RID: 665
		public const string StateActive = "Active";

		// Token: 0x0400029A RID: 666
		public const string StateActiveDocument = "ActiveDocument";

		// Token: 0x0400029B RID: 667
		public const string StateAddRecord = "AddRecord";

		// Token: 0x0400029C RID: 668
		public const string StateAppMenu = "AppMenu";

		// Token: 0x0400029D RID: 669
		public const string StateAppMenuFooterToolbar = "AppMenuFooterToolbar";

		// Token: 0x0400029E RID: 670
		public const string StateAppMenuRecentItems = "AppMenuRecentItems";

		// Token: 0x0400029F RID: 671
		public const string StateAppMenuSubMenu = "AppMenuSubMenu";

		// Token: 0x040002A0 RID: 672
		public const string StateBottom = "Bottom";

		// Token: 0x040002A1 RID: 673
		public const string StateBottomMouseOverTab = "Bottom_MouseOverTab";

		// Token: 0x040002A2 RID: 674
		public const string StateCellArea = "CellArea";

		// Token: 0x040002A3 RID: 675
		public const string StateCentury = "Century";

		// Token: 0x040002A4 RID: 676
		public const string StateChecked = "Checked";

		// Token: 0x040002A5 RID: 677
		public const string StateClosed = "Closed";

		// Token: 0x040002A6 RID: 678
		public const string StateCollapsed = "Collapsed";

		// Token: 0x040002A7 RID: 679
		public const string StateContextual = "Contextual";

		// Token: 0x040002A8 RID: 680
		public const string StateCurrent = "Current";

		// Token: 0x040002A9 RID: 681
		public const string StateChanged = "Changed";

		// Token: 0x040002AA RID: 682
		public const string StateDay = "Day";

		// Token: 0x040002AB RID: 683
		public const string StateDataRecord = "DataRecord";

		// Token: 0x040002AC RID: 684
		public const string StateDataRecordAlternateRow = "DataRecord_AlternateRow";

		// Token: 0x040002AD RID: 685
		public const string StateDecade = "Decade";

		// Token: 0x040002AE RID: 686
		public const string StateDisabled = "Disabled";

		// Token: 0x040002AF RID: 687
		public const string StateDisplay = "Display";

		// Token: 0x040002B0 RID: 688
		public const string StateDockedBottom = "DockedBottom";

		// Token: 0x040002B1 RID: 689
		public const string StateDockedLeft = "DockedLeft";

		// Token: 0x040002B2 RID: 690
		public const string StateDockedRight = "DockedRight";

		// Token: 0x040002B3 RID: 691
		public const string StateDockedTop = "DockedTop";

		// Token: 0x040002B4 RID: 692
		public const string StateDocument = "Document";

		// Token: 0x040002B5 RID: 693
		public const string StateDragging = "Dragging";

		// Token: 0x040002B6 RID: 694
		public const string StateDraggingDeferred = "DraggingDeferred";

		// Token: 0x040002B7 RID: 695
		public const string StateDragSource = "DragSource";

		// Token: 0x040002B8 RID: 696
		public const string StateDropdownArea = "DropdownArea";

		// Token: 0x040002B9 RID: 697
		public const string StateEditable = "Editable";

		// Token: 0x040002BA RID: 698
		public const string StateEditing = "Editing";

		// Token: 0x040002BB RID: 699
		public const string StateEmbedded = "Embedded";

		// Token: 0x040002BC RID: 700
		public const string StateError = "Error";

		// Token: 0x040002BD RID: 701
		public const string StateExpanded = "Expanded";

		// Token: 0x040002BE RID: 702
		public const string StateFieldChooser = "FieldChooser";

		// Token: 0x040002BF RID: 703
		public const string StateFieldSelected = "FieldSelected";

		// Token: 0x040002C0 RID: 704
		public const string StateFilterRecord = "FilterRecord";

		// Token: 0x040002C1 RID: 705
		public const string StateFilteredIn = "FilteredIn";

		// Token: 0x040002C2 RID: 706
		public const string StateFilteredOut = "FilteredOut";

		// Token: 0x040002C3 RID: 707
		public const string StateFixed = "Fixed";

		// Token: 0x040002C4 RID: 708
		public const string StateFloating = "Floating";

		// Token: 0x040002C5 RID: 709
		public const string StateFocused = "Focused";

		// Token: 0x040002C6 RID: 710
		public const string StateFocusedDropDown = "FocusedDropDown";

		// Token: 0x040002C7 RID: 711
		public const string StateGroupByArea = "GroupByArea";

		// Token: 0x040002C8 RID: 712
		public const string StateHasItems = "HasItems";

		// Token: 0x040002C9 RID: 713
		public const string StateHeaderArea = "HeaderArea";

		// Token: 0x040002CA RID: 714
		public const string StateHighlight = "Highlight";

		// Token: 0x040002CB RID: 715
		public const string StateInactive = "Inactive";

		// Token: 0x040002CC RID: 716
		public const string StateIndeterminate = "Indeterminate";

		// Token: 0x040002CD RID: 717
		public const string StateInvalidEx = "InvalidEx";

		// Token: 0x040002CE RID: 718
		public const string StateInvalidFocusedEx = "InvalidFocusedEx";

		// Token: 0x040002CF RID: 719
		public const string StateInvalidUnfocusedEx = "InvalidUnfocusedEx";

		// Token: 0x040002D0 RID: 720
		public const string StateIsHighlighted = "IsHighlighted";

		// Token: 0x040002D1 RID: 721
		public const string StateIsNotHighlighted = "IsNotHighlighted";

		// Token: 0x040002D2 RID: 722
		public const string StateIsLeadingOrTrailing = "IsLeadingOrTrailing";

		// Token: 0x040002D3 RID: 723
		public const string StateIsNotLeadingOrTrailing = "IsNotLeadingOrTrailing";

		// Token: 0x040002D4 RID: 724
		public const string StateLeft = "Left";

		// Token: 0x040002D5 RID: 725
		public const string StateLeftMouseOverTab = "Left_MouseOverTab";

		// Token: 0x040002D6 RID: 726
		public const string StateMaximized = "Maximized";

		// Token: 0x040002D7 RID: 727
		public const string StateMenu = "Menu";

		// Token: 0x040002D8 RID: 728
		public const string StateMinimized = "Minimized";

		// Token: 0x040002D9 RID: 729
		public const string StateMinimizedExpanded = "MinimizedExpanded";

		// Token: 0x040002DA RID: 730
		public const string StateMonth = "Month";

		// Token: 0x040002DB RID: 731
		public const string StateMouseOver = "MouseOver";

		// Token: 0x040002DC RID: 732
		public const string StateNavigationArea = "NavigationArea";

		// Token: 0x040002DD RID: 733
		public const string StateNoError = "NoError";

		// Token: 0x040002DE RID: 734
		public const string StateNoItems = "NoItems";

		// Token: 0x040002DF RID: 735
		public const string StateNonContextual = "NonContextual";

		// Token: 0x040002E0 RID: 736
		public const string StateNonWorkDay = "NonWorkDay";

		// Token: 0x040002E1 RID: 737
		public const string StateNormal = "Normal";

		// Token: 0x040002E2 RID: 738
		public const string StateNotDragging = "NotDragging";

		// Token: 0x040002E3 RID: 739
		public const string StateNotEmbedded = "NotEmbedded";

		// Token: 0x040002E4 RID: 740
		public const string StateNotMinimized = "NotMinimized";

		// Token: 0x040002E5 RID: 741
		public const string StateOpen = "Open";

		// Token: 0x040002E6 RID: 742
		public const string StateOverflowArea = "OverflowArea";

		// Token: 0x040002E7 RID: 743
		public const string StatePressed = "Pressed";

		// Token: 0x040002E8 RID: 744
		public const string StatePreviewArea = "PreviewArea";

		// Token: 0x040002E9 RID: 745
		public const string StateQAT = "QAT";

		// Token: 0x040002EA RID: 746
		public const string StateReadOnly = "ReadOnly";

		// Token: 0x040002EB RID: 747
		public const string StateRegularDay = "RegularDay";

		// Token: 0x040002EC RID: 748
		public const string StateRibbon = "Ribbon";

		// Token: 0x040002ED RID: 749
		public const string StateRight = "Right";

		// Token: 0x040002EE RID: 750
		public const string StateRightMouseOverTab = "Right_MouseOverTab";

		// Token: 0x040002EF RID: 751
		public const string StateSelected = "Selected";

		// Token: 0x040002F0 RID: 752
		public const string StateSelectedInactive = "SelectedInactive";

		// Token: 0x040002F1 RID: 753
		public const string StateSelectedUnfocused = "SelectedUnfocused";

		// Token: 0x040002F2 RID: 754
		public const string StateSortAscending = "SortAscending";

		// Token: 0x040002F3 RID: 755
		public const string StateSortDescending = "SortDescending";

		// Token: 0x040002F4 RID: 756
		public const string StateSwapTarget = "SwapTarget";

		// Token: 0x040002F5 RID: 757
		public const string StateTabItemAreaToolbar = "TabItemAreaToolbar";

		// Token: 0x040002F6 RID: 758
		public const string StateToday = "Today";

		// Token: 0x040002F7 RID: 759
		public const string StateTop = "Top";

		// Token: 0x040002F8 RID: 760
		public const string StateTopMouseOverTab = "Top_MouseOverTab";

		// Token: 0x040002F9 RID: 761
		public const string StateUnchanged = "Unchanged";

		// Token: 0x040002FA RID: 762
		public const string StateUnchecked = "Unchecked";

		// Token: 0x040002FB RID: 763
		public const string StateUneditable = "Uneditable";

		// Token: 0x040002FC RID: 764
		public const string StateUnfixed = "Unfixed";

		// Token: 0x040002FD RID: 765
		public const string StateUnfocused = "Unfocused";

		// Token: 0x040002FE RID: 766
		public const string StateUnpinned = "Unpinned";

		// Token: 0x040002FF RID: 767
		public const string StateUnselected = "Unselected";

		// Token: 0x04000300 RID: 768
		public const string StateUnsorted = "Unsorted";

		// Token: 0x04000301 RID: 769
		public const string StateValidEx = "ValidEx";

		// Token: 0x04000302 RID: 770
		public const string StateWorkDay = "WorkDay";

		// Token: 0x04000303 RID: 771
		public const string StateYear = "Year";

		// Token: 0x04000304 RID: 772
		public const string StateUp = "Up";

		// Token: 0x04000305 RID: 773
		public const string StateDown = "Down";

		// Token: 0x04000306 RID: 774
		public const string StateHorizontal = "Horizontal";

		// Token: 0x04000307 RID: 775
		public const string StateVertical = "Vertical";

		// Token: 0x04000308 RID: 776
		public const string StateWorkingHour = "WorkingHour";

		// Token: 0x04000309 RID: 777
		public const string StateNonWorkingHour = "NonWorkingHour";

		// Token: 0x0400030A RID: 778
		public const string StateIsFirstItem = "IsFirstItem";

		// Token: 0x0400030B RID: 779
		public const string StateIsFirstAndLastItem = "IsFirstAndLastItem";

		// Token: 0x0400030C RID: 780
		public const string StateIsLastItem = "IsLastItem";

		// Token: 0x0400030D RID: 781
		public const string StateIsNotFirstOrLastItem = "IsNotFirstOrLastItem";

		// Token: 0x0400030E RID: 782
		public const string StateIsFirstInDay = "IsFirstInDay";

		// Token: 0x0400030F RID: 783
		public const string StateIsFirstAndLastInDay = "IsFirstAndLastInDay";

		// Token: 0x04000310 RID: 784
		public const string StateIsLastInDay = "IsLastInDay";

		// Token: 0x04000311 RID: 785
		public const string StateIsNotFirstOrLastInDay = "IsNotFirstOrLastInDay";

		// Token: 0x04000312 RID: 786
		public const string StateIsFirstInMajor = "IsFirstInMajor";

		// Token: 0x04000313 RID: 787
		public const string StateIsFirstAndLastInMajor = "IsFirstAndLastInMajor";

		// Token: 0x04000314 RID: 788
		public const string StateIsLastInMajor = "IsLastInMajor";

		// Token: 0x04000315 RID: 789
		public const string StateIsNotFirstOrLastInMajor = "IsNotFirstOrLastInMajor";
	}
}
