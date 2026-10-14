using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200010D RID: 269
	public class FieldChooserCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DataPresenter.FieldChooser>
	{
		// Token: 0x06000E4C RID: 3660 RVA: 0x0003D120 File Offset: 0x0003B320
		private static global::Infragistics.Windows.Commands.CommandWrapper[] GetCommandWrappers()
		{
			return new global::Infragistics.Windows.Commands.CommandWrapper[]
			{
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.FieldChooserCommands.ToggleVisibility, 0L, 1L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Space)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.FieldChooserCommands.Stop, 0L, 4L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Escape)
				}))
			};
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0003D185 File Offset: 0x0003B385
		static FieldChooserCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DataPresenter.FieldChooser>.Initialize(global::Infragistics.Windows.DataPresenter.FieldChooserCommands.GetCommandWrappers());
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0003D1B8 File Offset: 0x0003B3B8
		public static void LoadCommands()
		{
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0003D1BA File Offset: 0x0003B3BA
		internal static global::Infragistics.Windows.DataPresenter.FieldChooserCommands Instance
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.FieldChooserCommands.g_instance == null)
				{
					global::Infragistics.Windows.DataPresenter.FieldChooserCommands.g_instance = new global::Infragistics.Windows.DataPresenter.FieldChooserCommands();
				}
				return global::Infragistics.Windows.DataPresenter.FieldChooserCommands.g_instance;
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0003D1D4 File Offset: 0x0003B3D4
		private static global::System.Windows.Input.InputGestureCollection CreateGestureCombinations(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifiers)
		{
			global::System.Windows.Input.InputGestureCollection inputGestureCollection = new global::System.Windows.Input.InputGestureCollection();
			global::Infragistics.Windows.DataPresenter.FieldChooserCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DataPresenter.FieldChooserCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DataPresenter.FieldChooserCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DataPresenter.FieldChooserCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.DataPresenter.FieldChooserCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DataPresenter.FieldChooserCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.DataPresenter.FieldChooserCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt);
			global::Infragistics.Windows.DataPresenter.FieldChooserCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.None);
			return inputGestureCollection;
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0003D230 File Offset: 0x0003B430
		private static void AddGesture(global::System.Windows.Input.InputGestureCollection gestures, global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys gestureModifiers, global::System.Windows.Input.ModifierKeys modifierToCheck)
		{
			if ((gestureModifiers & modifierToCheck) == modifierToCheck)
			{
				gestures.Add(new global::System.Windows.Input.KeyGesture(key, modifierToCheck));
			}
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0003D248 File Offset: 0x0003B448
		public override bool ProcessKeyboardInput(global::System.Windows.Input.KeyEventArgs e, global::Infragistics.Windows.Commands.ICommandHost commandHost)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = commandHost as global::Infragistics.Windows.DataPresenter.FieldChooser;
			return (fieldChooser == null || !(global::System.Windows.Input.Keyboard.FocusedElement is global::System.Windows.DependencyObject) || global::System.Windows.Input.FocusManager.GetFocusScope((global::System.Windows.DependencyObject)global::System.Windows.Input.Keyboard.FocusedElement) == global::System.Windows.Input.FocusManager.GetFocusScope(fieldChooser)) && base.ProcessKeyboardInput(e, commandHost);
		}

		// Token: 0x0400058A RID: 1418
		private const global::System.Windows.Input.ModifierKeys AllCtrlShiftModifiers = global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift;

		// Token: 0x0400058B RID: 1419
		public static readonly global::System.Windows.Input.RoutedCommand ToggleVisibility = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleVisibility", typeof(global::Infragistics.Windows.DataPresenter.FieldChooserCommands), 0L, 1L);

		// Token: 0x0400058C RID: 1420
		public static readonly global::System.Windows.Input.RoutedCommand Stop = global::System.Windows.Input.ApplicationCommands.Stop;

		// Token: 0x0400058D RID: 1421
		private static global::Infragistics.Windows.DataPresenter.FieldChooserCommands g_instance;
	}
}
