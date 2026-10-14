using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000022 RID: 34
	public class DockManagerCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DockManager.XamDockManager>
	{
		// Token: 0x060001BA RID: 442 RVA: 0x00009480 File Offset: 0x00007680
		internal static global::Infragistics.Windows.Commands.CommandWrapper[] GetCommandWrappers()
		{
			return new global::Infragistics.Windows.Commands.CommandWrapper[]
			{
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.DockManagerCommands.ActivateNextDocument, 0L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.F6, global::System.Windows.Input.ModifierKeys.Control)
				}), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift | global::System.Windows.Input.ModifierKeys.Windows),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.DockManagerCommands.ActivatePreviousDocument, 0L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.F6, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)
				}), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Windows),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.DockManagerCommands.ActivateNextPane, 0L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.F6, global::System.Windows.Input.ModifierKeys.Alt)
				}), global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift | global::System.Windows.Input.ModifierKeys.Windows),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.DockManagerCommands.ActivatePreviousPane, 0L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.F6, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift)
				}), global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Windows),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.DockManagerCommands.CloseActiveDocument, 0L, 2L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.F4, global::System.Windows.Input.ModifierKeys.Control)
				}), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift | global::System.Windows.Input.ModifierKeys.Windows),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DockManager.DockManagerCommands.ShowPaneNavigator)
			};
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00009580 File Offset: 0x00007780
		static DockManagerCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DockManager.XamDockManager>.Initialize(global::Infragistics.Windows.DockManager.DockManagerCommands.GetCommandWrappers());
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00009609 File Offset: 0x00007809
		public static void LoadCommands()
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000960B File Offset: 0x0000780B
		internal static global::Infragistics.Windows.DockManager.DockManagerCommands Instance
		{
			get
			{
				if (global::Infragistics.Windows.DockManager.DockManagerCommands.g_instance == null)
				{
					global::Infragistics.Windows.DockManager.DockManagerCommands.g_instance = new global::Infragistics.Windows.DockManager.DockManagerCommands();
				}
				return global::Infragistics.Windows.DockManager.DockManagerCommands.g_instance;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00009624 File Offset: 0x00007824
		private static global::System.Windows.Input.InputGestureCollection CreateGestureCombinations(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifiers)
		{
			global::System.Windows.Input.InputGestureCollection inputGestureCollection = new global::System.Windows.Input.InputGestureCollection();
			global::Infragistics.Windows.DockManager.DockManagerCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DockManager.DockManagerCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DockManager.DockManagerCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DockManager.DockManagerCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.DockManager.DockManagerCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DockManager.DockManagerCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.DockManager.DockManagerCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt);
			global::Infragistics.Windows.DockManager.DockManagerCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.None);
			return inputGestureCollection;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00009680 File Offset: 0x00007880
		private static void AddGesture(global::System.Windows.Input.InputGestureCollection gestures, global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys gestureModifiers, global::System.Windows.Input.ModifierKeys modifierToCheck)
		{
			if ((gestureModifiers & modifierToCheck) == modifierToCheck)
			{
				gestures.Add(new global::System.Windows.Input.KeyGesture(key, modifierToCheck));
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00009696 File Offset: 0x00007896
		internal static global::Infragistics.Windows.Commands.IGRoutedCommand CreateCommand(string name, long minimumStateDisallowed, long minimumStateRequired)
		{
			return new global::Infragistics.Windows.Commands.IGRoutedCommand(name, typeof(global::Infragistics.Windows.DockManager.DockManagerCommands), minimumStateDisallowed, minimumStateRequired, true);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000096AB File Offset: 0x000078AB
		protected override object GetKeyboardParameter(global::Infragistics.Windows.Commands.ICommandHost commandHost, global::System.Windows.Input.RoutedCommand command, global::System.Windows.Input.KeyEventArgs keyArgs)
		{
			return commandHost;
		}

		// Token: 0x04000120 RID: 288
		private const global::System.Windows.Input.ModifierKeys AllCtrlShiftModifiers = global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift;

		// Token: 0x04000121 RID: 289
		public static readonly global::System.Windows.Input.RoutedCommand ActivateNextDocument = global::Infragistics.Windows.DockManager.DockManagerCommands.CreateCommand("ActivateNextDocument", 0L, 0L);

		// Token: 0x04000122 RID: 290
		public static readonly global::System.Windows.Input.RoutedCommand ActivatePreviousDocument = global::Infragistics.Windows.DockManager.DockManagerCommands.CreateCommand("ActivatePreviousDocument", 0L, 0L);

		// Token: 0x04000123 RID: 291
		public static readonly global::System.Windows.Input.RoutedCommand ActivateNextPane = global::Infragistics.Windows.DockManager.DockManagerCommands.CreateCommand("ActivateNextPane", 0L, 0L);

		// Token: 0x04000124 RID: 292
		public static readonly global::System.Windows.Input.RoutedCommand ActivatePreviousPane = global::Infragistics.Windows.DockManager.DockManagerCommands.CreateCommand("ActivatePreviousPane", 0L, 0L);

		// Token: 0x04000125 RID: 293
		public static readonly global::System.Windows.Input.RoutedCommand CloseActiveDocument = global::Infragistics.Windows.DockManager.DockManagerCommands.CreateCommand("CloseActiveDocument", 0L, 0L);

		// Token: 0x04000126 RID: 294
		public static readonly global::System.Windows.Input.RoutedCommand ShowPaneNavigator = global::Infragistics.Windows.DockManager.DockManagerCommands.CreateCommand("ShowPaneNavigator", 0L, 0L);

		// Token: 0x04000127 RID: 295
		private static global::Infragistics.Windows.DockManager.DockManagerCommands g_instance;
	}
}
