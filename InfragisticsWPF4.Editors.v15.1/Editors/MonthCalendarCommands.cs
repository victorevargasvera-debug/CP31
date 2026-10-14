using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000043 RID: 67
	public class MonthCalendarCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamMonthCalendar>
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x000128D0 File Offset: 0x00010AD0
		private static global::Infragistics.Windows.Commands.CommandWrapper[] GetCommandWrappers()
		{
			return new global::Infragistics.Windows.Commands.CommandWrapper[]
			{
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollNextGroup, 0L, 0L, null, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollPreviousGroup, 0L, 0L, null, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollNextGroups, 0L, 0L, null, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollPreviousGroups, 0L, 0L, null, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.ActivateDate, 0L, 0L, null, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.ActivateSelectedDate, 0L, 0L, null, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.Today, 0L, 0L, null, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.PreviousItem, 4096L, 0L, global::Infragistics.Windows.Editors.MonthCalendarCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.Alt),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.NextItem, 4096L, 0L, global::Infragistics.Windows.Editors.MonthCalendarCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.Alt),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.PreviousItem, 0L, 4096L, global::Infragistics.Windows.Editors.MonthCalendarCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.Alt),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.NextItem, 0L, 4096L, global::Infragistics.Windows.Editors.MonthCalendarCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.Alt),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.PreviousItemRow, 0L, 0L, global::Infragistics.Windows.Editors.MonthCalendarCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Up, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.Alt),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.NextItemRow, 0L, 0L, global::Infragistics.Windows.Editors.MonthCalendarCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Down, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.Alt),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.FirstItemOfGroup, 0L, 0L, global::Infragistics.Windows.Editors.MonthCalendarCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.LastItemOfGroup, 0L, 0L, global::Infragistics.Windows.Editors.MonthCalendarCommands.CreateGestureCombinations(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.PreviousGroup, 0L, 0L, global::Infragistics.Windows.Editors.MonthCalendarCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Prior, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.NextGroup, 0L, 0L, global::Infragistics.Windows.Editors.MonthCalendarCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Next, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.FirstItemOfFirstGroup, 0L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)
				}, global::System.Windows.Input.ModifierKeys.Alt),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.LastItemOfLastGroup, 0L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)
				}, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.ZoomOutCalendarMode, 0L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Add, global::System.Windows.Input.ModifierKeys.Control)
				}, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.ZoomInCalendarMode, 0L, 8L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Return, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Space, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Subtract, global::System.Windows.Input.ModifierKeys.Control)
				}, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollToDate, 0L, 0L, null, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MonthCalendarCommands.ToggleActiveDateSelection, 0L, 0L, global::Infragistics.Windows.Editors.MonthCalendarCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Space, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift)
			};
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00012B80 File Offset: 0x00010D80
		static MonthCalendarCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamMonthCalendar>.Initialize(global::Infragistics.Windows.Editors.MonthCalendarCommands.GetCommandWrappers());
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00012E08 File Offset: 0x00011008
		public static void LoadCommands()
		{
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00012E0A File Offset: 0x0001100A
		internal static global::Infragistics.Windows.Editors.MonthCalendarCommands Instance
		{
			get
			{
				if (global::Infragistics.Windows.Editors.MonthCalendarCommands.g_instance == null)
				{
					global::Infragistics.Windows.Editors.MonthCalendarCommands.g_instance = new global::Infragistics.Windows.Editors.MonthCalendarCommands();
				}
				return global::Infragistics.Windows.Editors.MonthCalendarCommands.g_instance;
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00012E24 File Offset: 0x00011024
		private static global::System.Windows.Input.InputGestureCollection CreateGestureCombinations(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifiers)
		{
			global::System.Windows.Input.InputGestureCollection inputGestureCollection = new global::System.Windows.Input.InputGestureCollection();
			global::Infragistics.Windows.Editors.MonthCalendarCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.Editors.MonthCalendarCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.Editors.MonthCalendarCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.Editors.MonthCalendarCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.Editors.MonthCalendarCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.Editors.MonthCalendarCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.Editors.MonthCalendarCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt);
			global::Infragistics.Windows.Editors.MonthCalendarCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.None);
			return inputGestureCollection;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00012E80 File Offset: 0x00011080
		private static void AddGesture(global::System.Windows.Input.InputGestureCollection gestures, global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys gestureModifiers, global::System.Windows.Input.ModifierKeys modifierToCheck)
		{
			if ((gestureModifiers & modifierToCheck) == modifierToCheck)
			{
				gestures.Add(new global::System.Windows.Input.KeyGesture(key, modifierToCheck));
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00012E98 File Offset: 0x00011098
		protected override object GetKeyboardParameter(global::Infragistics.Windows.Commands.ICommandHost commandHost, global::System.Windows.Input.RoutedCommand command, global::System.Windows.Input.KeyEventArgs keyArgs)
		{
			global::System.Windows.Input.Key key = keyArgs.Key;
			if (key == global::System.Windows.Input.Key.System)
			{
				key = keyArgs.SystemKey;
			}
			switch (key)
			{
			case global::System.Windows.Input.Key.Left:
			case global::System.Windows.Input.Key.Up:
			case global::System.Windows.Input.Key.Right:
			case global::System.Windows.Input.Key.Down:
				return global::Infragistics.Windows.Editors.MonthCalendarCommands.NavigationKeyParameter;
			default:
				return null;
			}
		}

		// Token: 0x04000197 RID: 407
		private const global::System.Windows.Input.ModifierKeys AllCtrlShiftModifiers = global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift;

		// Token: 0x04000198 RID: 408
		public static readonly global::System.Windows.Input.RoutedCommand ScrollNextGroup = new global::Infragistics.Windows.Commands.IGRoutedCommand("ScrollNextGroup", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 2L, 0L);

		// Token: 0x04000199 RID: 409
		public static readonly global::System.Windows.Input.RoutedCommand ScrollPreviousGroup = new global::Infragistics.Windows.Commands.IGRoutedCommand("ScrollPreviousGroup", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 1L, 0L);

		// Token: 0x0400019A RID: 410
		public static readonly global::System.Windows.Input.RoutedCommand ScrollNextGroups = new global::Infragistics.Windows.Commands.IGRoutedCommand("ScrollNextGroups", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 2L, 0L);

		// Token: 0x0400019B RID: 411
		public static readonly global::System.Windows.Input.RoutedCommand ScrollPreviousGroups = new global::Infragistics.Windows.Commands.IGRoutedCommand("ScrollPreviousGroups", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 1L, 0L);

		// Token: 0x0400019C RID: 412
		public static readonly global::System.Windows.Input.RoutedCommand ScrollToDate = new global::Infragistics.Windows.Commands.IGRoutedCommand("ScrollToDate", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 0L);

		// Token: 0x0400019D RID: 413
		public static readonly global::System.Windows.Input.RoutedCommand ActivateDate = new global::Infragistics.Windows.Commands.IGRoutedCommand("ActivateDate", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 0L);

		// Token: 0x0400019E RID: 414
		public static readonly global::System.Windows.Input.RoutedCommand ActivateSelectedDate = new global::Infragistics.Windows.Commands.IGRoutedCommand("ActivateSelectedDate", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 0L);

		// Token: 0x0400019F RID: 415
		public static readonly global::System.Windows.Input.RoutedCommand Today = new global::Infragistics.Windows.Commands.IGRoutedCommand("Today", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 4L);

		// Token: 0x040001A0 RID: 416
		public static readonly global::System.Windows.Input.RoutedCommand PreviousItem = new global::Infragistics.Windows.Commands.IGRoutedCommand("PreviousItem", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 8L);

		// Token: 0x040001A1 RID: 417
		public static readonly global::System.Windows.Input.RoutedCommand NextItem = new global::Infragistics.Windows.Commands.IGRoutedCommand("NextItem", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 8L);

		// Token: 0x040001A2 RID: 418
		public static readonly global::System.Windows.Input.RoutedCommand PreviousItemRow = new global::Infragistics.Windows.Commands.IGRoutedCommand("PreviousItemRow", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 8L);

		// Token: 0x040001A3 RID: 419
		public static readonly global::System.Windows.Input.RoutedCommand NextItemRow = new global::Infragistics.Windows.Commands.IGRoutedCommand("NextItemRow", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 8L);

		// Token: 0x040001A4 RID: 420
		public static readonly global::System.Windows.Input.RoutedCommand PreviousGroup = new global::Infragistics.Windows.Commands.IGRoutedCommand("PreviousGroup", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 8L);

		// Token: 0x040001A5 RID: 421
		public static readonly global::System.Windows.Input.RoutedCommand NextGroup = new global::Infragistics.Windows.Commands.IGRoutedCommand("NextGroup", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 8L);

		// Token: 0x040001A6 RID: 422
		public static readonly global::System.Windows.Input.RoutedCommand FirstItemOfGroup = new global::Infragistics.Windows.Commands.IGRoutedCommand("FirstItemOfGroup", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 8L);

		// Token: 0x040001A7 RID: 423
		public static readonly global::System.Windows.Input.RoutedCommand LastItemOfGroup = new global::Infragistics.Windows.Commands.IGRoutedCommand("LastItemOfGroup", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 8L);

		// Token: 0x040001A8 RID: 424
		public static readonly global::System.Windows.Input.RoutedCommand FirstItemOfFirstGroup = new global::Infragistics.Windows.Commands.IGRoutedCommand("FirstItemOfFirstGroup", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 8L);

		// Token: 0x040001A9 RID: 425
		public static readonly global::System.Windows.Input.RoutedCommand LastItemOfLastGroup = new global::Infragistics.Windows.Commands.IGRoutedCommand("LastItemOfLastGroup", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 8L);

		// Token: 0x040001AA RID: 426
		public static readonly global::System.Windows.Input.RoutedCommand ZoomOutCalendarMode = new global::Infragistics.Windows.Commands.IGRoutedCommand("ZoomOutCalendarMode", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 16L);

		// Token: 0x040001AB RID: 427
		public static readonly global::System.Windows.Input.RoutedCommand ZoomInCalendarMode = new global::Infragistics.Windows.Commands.IGRoutedCommand("ZoomInCalendarMode", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 32L);

		// Token: 0x040001AC RID: 428
		public static readonly global::System.Windows.Input.RoutedCommand ToggleActiveDateSelection = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleSelection", typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands), 0L, 2056L);

		// Token: 0x040001AD RID: 429
		private static global::Infragistics.Windows.Editors.MonthCalendarCommands g_instance;

		// Token: 0x040001AE RID: 430
		internal static readonly object NavigationKeyParameter = new object();
	}
}
