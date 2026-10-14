using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020002CA RID: 714
	public class TabControlCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.XamTabControl>
	{
		// Token: 0x06001D0C RID: 7436 RVA: 0x0006F92C File Offset: 0x0006DB2C
		internal static global::Infragistics.Windows.Commands.CommandWrapper[] GetCommandWrappers()
		{
			return new global::Infragistics.Windows.Commands.CommandWrapper[]
			{
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Controls.TabControlCommands.CloseAll),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Controls.TabControlCommands.CloseSelected),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Controls.TabControlCommands.Expand),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Controls.TabControlCommands.Minimize),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Controls.TabControlCommands.SelectFirstTab),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Controls.TabControlCommands.SelectLastTab),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Controls.TabControlCommands.SelectNextTab),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Controls.TabControlCommands.SelectPreviousTab),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Controls.TabControlCommands.ToggleMinimized, 0L, 1L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.M, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)
				}), global::System.Windows.Input.ModifierKeys.None)
			};
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x0006F9D4 File Offset: 0x0006DBD4
		static TabControlCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.XamTabControl>.Initialize(global::Infragistics.Windows.Controls.TabControlCommands.GetCommandWrappers());
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x0006FAF5 File Offset: 0x0006DCF5
		public static void LoadCommands()
		{
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x0006FAF7 File Offset: 0x0006DCF7
		internal static global::Infragistics.Windows.Controls.TabControlCommands Instance
		{
			get
			{
				if (global::Infragistics.Windows.Controls.TabControlCommands.g_instance == null)
				{
					global::Infragistics.Windows.Controls.TabControlCommands.g_instance = new global::Infragistics.Windows.Controls.TabControlCommands();
				}
				return global::Infragistics.Windows.Controls.TabControlCommands.g_instance;
			}
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x0006FB10 File Offset: 0x0006DD10
		private static global::System.Windows.Input.InputGestureCollection CreateGestureCombinations(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifiers)
		{
			global::System.Windows.Input.InputGestureCollection inputGestureCollection = new global::System.Windows.Input.InputGestureCollection();
			global::Infragistics.Windows.Controls.TabControlCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.Controls.TabControlCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.Controls.TabControlCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.Controls.TabControlCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.Controls.TabControlCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.Controls.TabControlCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.Controls.TabControlCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt);
			global::Infragistics.Windows.Controls.TabControlCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.None);
			return inputGestureCollection;
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x0006FB6C File Offset: 0x0006DD6C
		private static void AddGesture(global::System.Windows.Input.InputGestureCollection gestures, global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys gestureModifiers, global::System.Windows.Input.ModifierKeys modifierToCheck)
		{
			if ((gestureModifiers & modifierToCheck) == modifierToCheck)
			{
				gestures.Add(new global::System.Windows.Input.KeyGesture(key, modifierToCheck));
			}
		}

		// Token: 0x04000E1D RID: 3613
		private const global::System.Windows.Input.ModifierKeys AllCtrlShiftModifiers = global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift;

		// Token: 0x04000E1E RID: 3614
		public static readonly global::System.Windows.Input.RoutedCommand CloseAll = new global::Infragistics.Windows.Commands.IGRoutedCommand("CloseAll", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 0L, 0L);

		// Token: 0x04000E1F RID: 3615
		public static readonly global::System.Windows.Input.RoutedCommand CloseSelected = new global::Infragistics.Windows.Commands.IGRoutedCommand("CloseSelected", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 0L, 68L);

		// Token: 0x04000E20 RID: 3616
		public static readonly global::System.Windows.Input.RoutedCommand Expand = new global::Infragistics.Windows.Commands.IGRoutedCommand("Expand", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 0L, 32L);

		// Token: 0x04000E21 RID: 3617
		public static readonly global::System.Windows.Input.RoutedCommand Minimize = new global::Infragistics.Windows.Commands.IGRoutedCommand("Minimize", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 32L, 1L);

		// Token: 0x04000E22 RID: 3618
		public static readonly global::System.Windows.Input.RoutedCommand SelectFirstTab = new global::Infragistics.Windows.Commands.IGRoutedCommand("SelectFirstTab", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 8L, 4L);

		// Token: 0x04000E23 RID: 3619
		public static readonly global::System.Windows.Input.RoutedCommand SelectLastTab = new global::Infragistics.Windows.Commands.IGRoutedCommand("SelectLastTab", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 16L, 4L);

		// Token: 0x04000E24 RID: 3620
		public static readonly global::System.Windows.Input.RoutedCommand SelectNextTab = new global::Infragistics.Windows.Commands.IGRoutedCommand("SelectNextTab", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 16L, 4L);

		// Token: 0x04000E25 RID: 3621
		public static readonly global::System.Windows.Input.RoutedCommand SelectPreviousTab = new global::Infragistics.Windows.Commands.IGRoutedCommand("SelectPreviousTab", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 8L, 4L);

		// Token: 0x04000E26 RID: 3622
		public static readonly global::System.Windows.Input.RoutedCommand ToggleMinimized = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleMinimized", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 0L, 1L);

		// Token: 0x04000E27 RID: 3623
		private static global::Infragistics.Windows.Controls.TabControlCommands g_instance;
	}
}
