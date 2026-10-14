using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200001C RID: 28
	public class ContentPaneCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DockManager.ContentPane>
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00007E18 File Offset: 0x00006018
		internal static global::Infragistics.Windows.Commands.CommandWrapper[] GetCommandWrappers()
		{
			return new global::Infragistics.Windows.Commands.CommandWrapper[]
			{
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.TogglePinnedState),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.ToggleDockedState),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.Close, 8L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Escape, global::System.Windows.Input.ModifierKeys.Shift)
				}), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Windows),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.CloseAllButThis),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNextGroup),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToPreviousGroup),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNewHorizontalGroup),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNewVerticalGroup),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.ChangeToFloatingOnly),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.ChangeToDockable),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.ChangeToDocument),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.ActivatePane),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.Flyout),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.ContentPaneCommands.FlyIn)
			};
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00007F08 File Offset: 0x00006108
		static ContentPaneCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DockManager.ContentPane>.Initialize(global::Infragistics.Windows.DockManager.ContentPaneCommands.GetCommandWrappers());
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00008036 File Offset: 0x00006236
		public static void LoadCommands()
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00008038 File Offset: 0x00006238
		internal static global::Infragistics.Windows.DockManager.ContentPaneCommands Instance
		{
			get
			{
				if (global::Infragistics.Windows.DockManager.ContentPaneCommands.g_instance == null)
				{
					global::Infragistics.Windows.DockManager.ContentPaneCommands.g_instance = new global::Infragistics.Windows.DockManager.ContentPaneCommands();
				}
				return global::Infragistics.Windows.DockManager.ContentPaneCommands.g_instance;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00008050 File Offset: 0x00006250
		private static global::System.Windows.Input.InputGestureCollection CreateGestureCombinations(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifiers)
		{
			global::System.Windows.Input.InputGestureCollection inputGestureCollection = new global::System.Windows.Input.InputGestureCollection();
			global::Infragistics.Windows.DockManager.ContentPaneCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DockManager.ContentPaneCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DockManager.ContentPaneCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DockManager.ContentPaneCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.DockManager.ContentPaneCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DockManager.ContentPaneCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.DockManager.ContentPaneCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt);
			global::Infragistics.Windows.DockManager.ContentPaneCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.None);
			return inputGestureCollection;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000080AC File Offset: 0x000062AC
		private static void AddGesture(global::System.Windows.Input.InputGestureCollection gestures, global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys gestureModifiers, global::System.Windows.Input.ModifierKeys modifierToCheck)
		{
			if ((gestureModifiers & modifierToCheck) == modifierToCheck)
			{
				gestures.Add(new global::System.Windows.Input.KeyGesture(key, modifierToCheck));
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000080C2 File Offset: 0x000062C2
		internal static global::Infragistics.Windows.Commands.IGRoutedCommand CreateCommand(string name, long minimumStateDisallowed, long minimumStateRequired)
		{
			return new global::Infragistics.Windows.Commands.IGRoutedCommand(name, typeof(global::Infragistics.Windows.DockManager.ContentPaneCommands), minimumStateDisallowed, minimumStateRequired, true);
		}

		// Token: 0x0400007C RID: 124
		private const global::System.Windows.Input.ModifierKeys AllCtrlShiftModifiers = global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift;

		// Token: 0x0400007D RID: 125
		public static readonly global::System.Windows.Input.RoutedCommand TogglePinnedState = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("TogglePinnedState", 56L, 0L);

		// Token: 0x0400007E RID: 126
		public static readonly global::System.Windows.Input.RoutedCommand ToggleDockedState = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("ToggleDockedState", 200L, 0L);

		// Token: 0x0400007F RID: 127
		public static readonly global::System.Windows.Input.RoutedCommand Close = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("Close", 0L, 4L);

		// Token: 0x04000080 RID: 128
		public static readonly global::System.Windows.Input.RoutedCommand CloseAllButThis = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("CloseAllButThis", 0L, 0L);

		// Token: 0x04000081 RID: 129
		public static readonly global::System.Windows.Input.RoutedCommand MoveToNextGroup = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("MoveToNextGroup", 0L, 0L);

		// Token: 0x04000082 RID: 130
		public static readonly global::System.Windows.Input.RoutedCommand MoveToPreviousGroup = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("MoveToPreviousGroup", 0L, 0L);

		// Token: 0x04000083 RID: 131
		public static readonly global::System.Windows.Input.RoutedCommand MoveToNewHorizontalGroup = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("MoveToNewHorizontalGroup", 0L, 0L);

		// Token: 0x04000084 RID: 132
		public static readonly global::System.Windows.Input.RoutedCommand MoveToNewVerticalGroup = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("MoveToNewVerticalGroup", 0L, 0L);

		// Token: 0x04000085 RID: 133
		public static readonly global::System.Windows.Input.RoutedCommand ChangeToFloatingOnly = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("ChangeToFloatingOnly", 0L, 0L);

		// Token: 0x04000086 RID: 134
		public static readonly global::System.Windows.Input.RoutedCommand ChangeToDockable = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("ChangeToDockable", 0L, 0L);

		// Token: 0x04000087 RID: 135
		public static readonly global::System.Windows.Input.RoutedCommand ChangeToDocument = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("ChangeToDocument", 0L, 0L);

		// Token: 0x04000088 RID: 136
		public static readonly global::System.Windows.Input.RoutedCommand ActivatePane = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("ActivatePane", 0L, 0L);

		// Token: 0x04000089 RID: 137
		public static readonly global::System.Windows.Input.RoutedCommand Flyout = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("Flyout", 0L, 128L);

		// Token: 0x0400008A RID: 138
		public static readonly global::System.Windows.Input.RoutedCommand FlyIn = global::Infragistics.Windows.DockManager.ContentPaneCommands.CreateCommand("FlyIn", 0L, 128L);

		// Token: 0x0400008B RID: 139
		private static global::Infragistics.Windows.DockManager.ContentPaneCommands g_instance;
	}
}
