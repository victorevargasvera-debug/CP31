using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000088 RID: 136
	internal static class VisualStateUtilities
	{
		// Token: 0x0600054D RID: 1357 RVA: 0x00014990 File Offset: 0x00012B90
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

		// Token: 0x0600054E RID: 1358 RVA: 0x000149EC File Offset: 0x00012BEC
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

		// Token: 0x040001F4 RID: 500
		public const string GroupActive = "ActiveStates";

		// Token: 0x040001F5 RID: 501
		public const string GroupCalendar = "CalendarStates";

		// Token: 0x040001F6 RID: 502
		public const string GroupChange = "ChangeStates";

		// Token: 0x040001F7 RID: 503
		public const string GroupCheck = "CheckStates";

		// Token: 0x040001F8 RID: 504
		public const string GroupCommon = "CommonStates";

		// Token: 0x040001F9 RID: 505
		public const string GroupContextual = "ContextualStates";

		// Token: 0x040001FA RID: 506
		public const string GroupCurrent = "CurrentStates";

		// Token: 0x040001FB RID: 507
		public const string GroupDay = "DayStates";

		// Token: 0x040001FC RID: 508
		public const string GroupDrag = "DragStates";

		// Token: 0x040001FD RID: 509
		public const string GroupEdit = "EditStates";

		// Token: 0x040001FE RID: 510
		public const string GroupEmbedded = "EmbeddedStates";

		// Token: 0x040001FF RID: 511
		public const string GroupError = "ErrorStates";

		// Token: 0x04000200 RID: 512
		public const string GroupExpansion = "ExpansionStates";

		// Token: 0x04000201 RID: 513
		public const string GroupFilter = "FilterStates";

		// Token: 0x04000202 RID: 514
		public const string GroupFirstLastItem = "FirstLastItemStates";

		// Token: 0x04000203 RID: 515
		public const string GroupFixed = "FixedStates";

		// Token: 0x04000204 RID: 516
		public const string GroupFocus = "FocusStates";

		// Token: 0x04000205 RID: 517
		public const string GroupHasItems = "HasItemsStates";

		// Token: 0x04000206 RID: 518
		public const string GroupHighlight = "HighlightStates";

		// Token: 0x04000207 RID: 519
		public const string GroupInteraction = "InteractionStates";

		// Token: 0x04000208 RID: 520
		public const string GroupLeadingOrTrailing = "LeadingOrTrailingStates";

		// Token: 0x04000209 RID: 521
		public const string GroupLocation = "LocationStates";

		// Token: 0x0400020A RID: 522
		public const string GroupMajor = "MajorStates";

		// Token: 0x0400020B RID: 523
		public const string GroupMinimized = "MinimizedStates";

		// Token: 0x0400020C RID: 524
		public const string GroupOpen = "OpenStates";

		// Token: 0x0400020D RID: 525
		public const string GroupPaneLocation = "PaneLocationStates";

		// Token: 0x0400020E RID: 526
		public const string GroupRecord = "RecordStates";

		// Token: 0x0400020F RID: 527
		public const string GroupSelection = "SelectionStates";

		// Token: 0x04000210 RID: 528
		public const string GroupSort = "SortStates";

		// Token: 0x04000211 RID: 529
		public const string GroupSplitterLocation = "SplitterLocationStates";

		// Token: 0x04000212 RID: 530
		public const string GroupValidationEx = "ValidationStatesEx";

		// Token: 0x04000213 RID: 531
		public const string GroupWorkDay = "WorkDayStates";

		// Token: 0x04000214 RID: 532
		public const string GroupOrientation = "OrientationStates";

		// Token: 0x04000215 RID: 533
		public const string GroupWorkingHour = "WorkingHourStates";

		// Token: 0x04000216 RID: 534
		public const string GroupDirection = "DirectionStates";

		// Token: 0x04000217 RID: 535
		public const string StateActive = "Active";

		// Token: 0x04000218 RID: 536
		public const string StateActiveDocument = "ActiveDocument";

		// Token: 0x04000219 RID: 537
		public const string StateAddRecord = "AddRecord";

		// Token: 0x0400021A RID: 538
		public const string StateAppMenu = "AppMenu";

		// Token: 0x0400021B RID: 539
		public const string StateAppMenuFooterToolbar = "AppMenuFooterToolbar";

		// Token: 0x0400021C RID: 540
		public const string StateAppMenuRecentItems = "AppMenuRecentItems";

		// Token: 0x0400021D RID: 541
		public const string StateAppMenuSubMenu = "AppMenuSubMenu";

		// Token: 0x0400021E RID: 542
		public const string StateBottom = "Bottom";

		// Token: 0x0400021F RID: 543
		public const string StateBottomMouseOverTab = "Bottom_MouseOverTab";

		// Token: 0x04000220 RID: 544
		public const string StateCellArea = "CellArea";

		// Token: 0x04000221 RID: 545
		public const string StateCentury = "Century";

		// Token: 0x04000222 RID: 546
		public const string StateChecked = "Checked";

		// Token: 0x04000223 RID: 547
		public const string StateClosed = "Closed";

		// Token: 0x04000224 RID: 548
		public const string StateCollapsed = "Collapsed";

		// Token: 0x04000225 RID: 549
		public const string StateContextual = "Contextual";

		// Token: 0x04000226 RID: 550
		public const string StateCurrent = "Current";

		// Token: 0x04000227 RID: 551
		public const string StateChanged = "Changed";

		// Token: 0x04000228 RID: 552
		public const string StateDay = "Day";

		// Token: 0x04000229 RID: 553
		public const string StateDataRecord = "DataRecord";

		// Token: 0x0400022A RID: 554
		public const string StateDataRecordAlternateRow = "DataRecord_AlternateRow";

		// Token: 0x0400022B RID: 555
		public const string StateDecade = "Decade";

		// Token: 0x0400022C RID: 556
		public const string StateDisabled = "Disabled";

		// Token: 0x0400022D RID: 557
		public const string StateDisplay = "Display";

		// Token: 0x0400022E RID: 558
		public const string StateDockedBottom = "DockedBottom";

		// Token: 0x0400022F RID: 559
		public const string StateDockedLeft = "DockedLeft";

		// Token: 0x04000230 RID: 560
		public const string StateDockedRight = "DockedRight";

		// Token: 0x04000231 RID: 561
		public const string StateDockedTop = "DockedTop";

		// Token: 0x04000232 RID: 562
		public const string StateDocument = "Document";

		// Token: 0x04000233 RID: 563
		public const string StateDragging = "Dragging";

		// Token: 0x04000234 RID: 564
		public const string StateDraggingDeferred = "DraggingDeferred";

		// Token: 0x04000235 RID: 565
		public const string StateDragSource = "DragSource";

		// Token: 0x04000236 RID: 566
		public const string StateDropdownArea = "DropdownArea";

		// Token: 0x04000237 RID: 567
		public const string StateEditable = "Editable";

		// Token: 0x04000238 RID: 568
		public const string StateEditing = "Editing";

		// Token: 0x04000239 RID: 569
		public const string StateEmbedded = "Embedded";

		// Token: 0x0400023A RID: 570
		public const string StateError = "Error";

		// Token: 0x0400023B RID: 571
		public const string StateExpanded = "Expanded";

		// Token: 0x0400023C RID: 572
		public const string StateFieldChooser = "FieldChooser";

		// Token: 0x0400023D RID: 573
		public const string StateFieldSelected = "FieldSelected";

		// Token: 0x0400023E RID: 574
		public const string StateFilterRecord = "FilterRecord";

		// Token: 0x0400023F RID: 575
		public const string StateFilteredIn = "FilteredIn";

		// Token: 0x04000240 RID: 576
		public const string StateFilteredOut = "FilteredOut";

		// Token: 0x04000241 RID: 577
		public const string StateFixed = "Fixed";

		// Token: 0x04000242 RID: 578
		public const string StateFloating = "Floating";

		// Token: 0x04000243 RID: 579
		public const string StateFocused = "Focused";

		// Token: 0x04000244 RID: 580
		public const string StateFocusedDropDown = "FocusedDropDown";

		// Token: 0x04000245 RID: 581
		public const string StateGroupByArea = "GroupByArea";

		// Token: 0x04000246 RID: 582
		public const string StateHasItems = "HasItems";

		// Token: 0x04000247 RID: 583
		public const string StateHeaderArea = "HeaderArea";

		// Token: 0x04000248 RID: 584
		public const string StateHighlight = "Highlight";

		// Token: 0x04000249 RID: 585
		public const string StateInactive = "Inactive";

		// Token: 0x0400024A RID: 586
		public const string StateIndeterminate = "Indeterminate";

		// Token: 0x0400024B RID: 587
		public const string StateInvalidEx = "InvalidEx";

		// Token: 0x0400024C RID: 588
		public const string StateInvalidFocusedEx = "InvalidFocusedEx";

		// Token: 0x0400024D RID: 589
		public const string StateInvalidUnfocusedEx = "InvalidUnfocusedEx";

		// Token: 0x0400024E RID: 590
		public const string StateIsHighlighted = "IsHighlighted";

		// Token: 0x0400024F RID: 591
		public const string StateIsNotHighlighted = "IsNotHighlighted";

		// Token: 0x04000250 RID: 592
		public const string StateIsLeadingOrTrailing = "IsLeadingOrTrailing";

		// Token: 0x04000251 RID: 593
		public const string StateIsNotLeadingOrTrailing = "IsNotLeadingOrTrailing";

		// Token: 0x04000252 RID: 594
		public const string StateLeft = "Left";

		// Token: 0x04000253 RID: 595
		public const string StateLeftMouseOverTab = "Left_MouseOverTab";

		// Token: 0x04000254 RID: 596
		public const string StateMaximized = "Maximized";

		// Token: 0x04000255 RID: 597
		public const string StateMenu = "Menu";

		// Token: 0x04000256 RID: 598
		public const string StateMinimized = "Minimized";

		// Token: 0x04000257 RID: 599
		public const string StateMinimizedExpanded = "MinimizedExpanded";

		// Token: 0x04000258 RID: 600
		public const string StateMonth = "Month";

		// Token: 0x04000259 RID: 601
		public const string StateMouseOver = "MouseOver";

		// Token: 0x0400025A RID: 602
		public const string StateNavigationArea = "NavigationArea";

		// Token: 0x0400025B RID: 603
		public const string StateNoError = "NoError";

		// Token: 0x0400025C RID: 604
		public const string StateNoItems = "NoItems";

		// Token: 0x0400025D RID: 605
		public const string StateNonContextual = "NonContextual";

		// Token: 0x0400025E RID: 606
		public const string StateNonWorkDay = "NonWorkDay";

		// Token: 0x0400025F RID: 607
		public const string StateNormal = "Normal";

		// Token: 0x04000260 RID: 608
		public const string StateNotDragging = "NotDragging";

		// Token: 0x04000261 RID: 609
		public const string StateNotEmbedded = "NotEmbedded";

		// Token: 0x04000262 RID: 610
		public const string StateNotMinimized = "NotMinimized";

		// Token: 0x04000263 RID: 611
		public const string StateOpen = "Open";

		// Token: 0x04000264 RID: 612
		public const string StateOverflowArea = "OverflowArea";

		// Token: 0x04000265 RID: 613
		public const string StatePressed = "Pressed";

		// Token: 0x04000266 RID: 614
		public const string StatePreviewArea = "PreviewArea";

		// Token: 0x04000267 RID: 615
		public const string StateQAT = "QAT";

		// Token: 0x04000268 RID: 616
		public const string StateReadOnly = "ReadOnly";

		// Token: 0x04000269 RID: 617
		public const string StateRegularDay = "RegularDay";

		// Token: 0x0400026A RID: 618
		public const string StateRibbon = "Ribbon";

		// Token: 0x0400026B RID: 619
		public const string StateRight = "Right";

		// Token: 0x0400026C RID: 620
		public const string StateRightMouseOverTab = "Right_MouseOverTab";

		// Token: 0x0400026D RID: 621
		public const string StateSelected = "Selected";

		// Token: 0x0400026E RID: 622
		public const string StateSelectedInactive = "SelectedInactive";

		// Token: 0x0400026F RID: 623
		public const string StateSelectedUnfocused = "SelectedUnfocused";

		// Token: 0x04000270 RID: 624
		public const string StateSortAscending = "SortAscending";

		// Token: 0x04000271 RID: 625
		public const string StateSortDescending = "SortDescending";

		// Token: 0x04000272 RID: 626
		public const string StateSwapTarget = "SwapTarget";

		// Token: 0x04000273 RID: 627
		public const string StateToday = "Today";

		// Token: 0x04000274 RID: 628
		public const string StateTop = "Top";

		// Token: 0x04000275 RID: 629
		public const string StateTopMouseOverTab = "Top_MouseOverTab";

		// Token: 0x04000276 RID: 630
		public const string StateUnchanged = "Unchanged";

		// Token: 0x04000277 RID: 631
		public const string StateUnchecked = "Unchecked";

		// Token: 0x04000278 RID: 632
		public const string StateUneditable = "Uneditable";

		// Token: 0x04000279 RID: 633
		public const string StateUnfixed = "Unfixed";

		// Token: 0x0400027A RID: 634
		public const string StateUnfocused = "Unfocused";

		// Token: 0x0400027B RID: 635
		public const string StateUnpinned = "Unpinned";

		// Token: 0x0400027C RID: 636
		public const string StateUnselected = "Unselected";

		// Token: 0x0400027D RID: 637
		public const string StateUnsorted = "Unsorted";

		// Token: 0x0400027E RID: 638
		public const string StateValidEx = "ValidEx";

		// Token: 0x0400027F RID: 639
		public const string StateWorkDay = "WorkDay";

		// Token: 0x04000280 RID: 640
		public const string StateYear = "Year";

		// Token: 0x04000281 RID: 641
		public const string StateUp = "Up";

		// Token: 0x04000282 RID: 642
		public const string StateDown = "Down";

		// Token: 0x04000283 RID: 643
		public const string StateHorizontal = "Horizontal";

		// Token: 0x04000284 RID: 644
		public const string StateVertical = "Vertical";

		// Token: 0x04000285 RID: 645
		public const string StateWorkingHour = "WorkingHour";

		// Token: 0x04000286 RID: 646
		public const string StateNonWorkingHour = "NonWorkingHour";

		// Token: 0x04000287 RID: 647
		public const string StateIsFirstItem = "IsFirstItem";

		// Token: 0x04000288 RID: 648
		public const string StateIsFirstAndLastItem = "IsFirstAndLastItem";

		// Token: 0x04000289 RID: 649
		public const string StateIsLastItem = "IsLastItem";

		// Token: 0x0400028A RID: 650
		public const string StateIsNotFirstOrLastItem = "IsNotFirstOrLastItem";

		// Token: 0x0400028B RID: 651
		public const string StateIsFirstInDay = "IsFirstInDay";

		// Token: 0x0400028C RID: 652
		public const string StateIsFirstAndLastInDay = "IsFirstAndLastInDay";

		// Token: 0x0400028D RID: 653
		public const string StateIsLastInDay = "IsLastInDay";

		// Token: 0x0400028E RID: 654
		public const string StateIsNotFirstOrLastInDay = "IsNotFirstOrLastInDay";

		// Token: 0x0400028F RID: 655
		public const string StateIsFirstInMajor = "IsFirstInMajor";

		// Token: 0x04000290 RID: 656
		public const string StateIsFirstAndLastInMajor = "IsFirstAndLastInMajor";

		// Token: 0x04000291 RID: 657
		public const string StateIsLastInMajor = "IsLastInMajor";

		// Token: 0x04000292 RID: 658
		public const string StateIsNotFirstOrLastInMajor = "IsNotFirstOrLastInMajor";
	}
}
