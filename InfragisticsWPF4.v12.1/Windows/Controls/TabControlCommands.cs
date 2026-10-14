using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200028D RID: 653
	public class TabControlCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.XamTabControl>
	{
		// Token: 0x06001AD2 RID: 6866 RVA: 0x00068374 File Offset: 0x00066574
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

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0006841C File Offset: 0x0006661C
		static TabControlCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.XamTabControl>.Initialize(global::Infragistics.Windows.Controls.TabControlCommands.GetCommandWrappers());
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0006853D File Offset: 0x0006673D
		public static void LoadCommands()
		{
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x0006853F File Offset: 0x0006673F
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

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00068558 File Offset: 0x00066758
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

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000685B4 File Offset: 0x000667B4
		private static void AddGesture(global::System.Windows.Input.InputGestureCollection gestures, global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys gestureModifiers, global::System.Windows.Input.ModifierKeys modifierToCheck)
		{
			if ((gestureModifiers & modifierToCheck) == modifierToCheck)
			{
				gestures.Add(new global::System.Windows.Input.KeyGesture(key, modifierToCheck));
			}
		}

		// Token: 0x04000CA7 RID: 3239
		private const global::System.Windows.Input.ModifierKeys AllCtrlShiftModifiers = global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift;

		// Token: 0x04000CA8 RID: 3240
		public static readonly global::System.Windows.Input.RoutedCommand CloseAll = new global::Infragistics.Windows.Commands.IGRoutedCommand("CloseAll", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 0L, 0L);

		// Token: 0x04000CA9 RID: 3241
		public static readonly global::System.Windows.Input.RoutedCommand CloseSelected = new global::Infragistics.Windows.Commands.IGRoutedCommand("CloseSelected", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 0L, 68L);

		// Token: 0x04000CAA RID: 3242
		public static readonly global::System.Windows.Input.RoutedCommand Expand = new global::Infragistics.Windows.Commands.IGRoutedCommand("Expand", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 0L, 32L);

		// Token: 0x04000CAB RID: 3243
		public static readonly global::System.Windows.Input.RoutedCommand Minimize = new global::Infragistics.Windows.Commands.IGRoutedCommand("Minimize", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 32L, 1L);

		// Token: 0x04000CAC RID: 3244
		public static readonly global::System.Windows.Input.RoutedCommand SelectFirstTab = new global::Infragistics.Windows.Commands.IGRoutedCommand("SelectFirstTab", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 8L, 4L);

		// Token: 0x04000CAD RID: 3245
		public static readonly global::System.Windows.Input.RoutedCommand SelectLastTab = new global::Infragistics.Windows.Commands.IGRoutedCommand("SelectLastTab", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 16L, 4L);

		// Token: 0x04000CAE RID: 3246
		public static readonly global::System.Windows.Input.RoutedCommand SelectNextTab = new global::Infragistics.Windows.Commands.IGRoutedCommand("SelectNextTab", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 16L, 4L);

		// Token: 0x04000CAF RID: 3247
		public static readonly global::System.Windows.Input.RoutedCommand SelectPreviousTab = new global::Infragistics.Windows.Commands.IGRoutedCommand("SelectPreviousTab", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 8L, 4L);

		// Token: 0x04000CB0 RID: 3248
		public static readonly global::System.Windows.Input.RoutedCommand ToggleMinimized = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleMinimized", typeof(global::Infragistics.Windows.Controls.TabControlCommands), 0L, 1L);

		// Token: 0x04000CB1 RID: 3249
		private static global::Infragistics.Windows.Controls.TabControlCommands g_instance;
	}
}
