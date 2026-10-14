using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000129 RID: 297
	public class FieldChooserCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DataPresenter.FieldChooser>
	{
		// Token: 0x060011AD RID: 4525 RVA: 0x0004DC18 File Offset: 0x0004BE18
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

		// Token: 0x060011AE RID: 4526 RVA: 0x0004DC7D File Offset: 0x0004BE7D
		static FieldChooserCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DataPresenter.FieldChooser>.Initialize(global::Infragistics.Windows.DataPresenter.FieldChooserCommands.GetCommandWrappers());
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0004DCB0 File Offset: 0x0004BEB0
		public static void LoadCommands()
		{
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x0004DCB2 File Offset: 0x0004BEB2
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

		// Token: 0x060011B1 RID: 4529 RVA: 0x0004DCCC File Offset: 0x0004BECC
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

		// Token: 0x060011B2 RID: 4530 RVA: 0x0004DD28 File Offset: 0x0004BF28
		private static void AddGesture(global::System.Windows.Input.InputGestureCollection gestures, global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys gestureModifiers, global::System.Windows.Input.ModifierKeys modifierToCheck)
		{
			if ((gestureModifiers & modifierToCheck) == modifierToCheck)
			{
				gestures.Add(new global::System.Windows.Input.KeyGesture(key, modifierToCheck));
			}
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0004DD40 File Offset: 0x0004BF40
		public override bool ProcessKeyboardInput(global::System.Windows.Input.KeyEventArgs e, global::Infragistics.Windows.Commands.ICommandHost commandHost)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = commandHost as global::Infragistics.Windows.DataPresenter.FieldChooser;
			return (fieldChooser == null || !(global::System.Windows.Input.Keyboard.FocusedElement is global::System.Windows.DependencyObject) || global::System.Windows.Input.FocusManager.GetFocusScope((global::System.Windows.DependencyObject)global::System.Windows.Input.Keyboard.FocusedElement) == global::System.Windows.Input.FocusManager.GetFocusScope(fieldChooser)) && base.ProcessKeyboardInput(e, commandHost);
		}

		// Token: 0x04000729 RID: 1833
		private const global::System.Windows.Input.ModifierKeys AllCtrlShiftModifiers = global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift;

		// Token: 0x0400072A RID: 1834
		public static readonly global::System.Windows.Input.RoutedCommand ToggleVisibility = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleVisibility", typeof(global::Infragistics.Windows.DataPresenter.FieldChooserCommands), 0L, 1L);

		// Token: 0x0400072B RID: 1835
		public static readonly global::System.Windows.Input.RoutedCommand Stop = global::System.Windows.Input.ApplicationCommands.Stop;

		// Token: 0x0400072C RID: 1836
		private static global::Infragistics.Windows.DataPresenter.FieldChooserCommands g_instance;
	}
}
