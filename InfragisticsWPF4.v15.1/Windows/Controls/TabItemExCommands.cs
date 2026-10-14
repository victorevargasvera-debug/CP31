using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000210 RID: 528
	public class TabItemExCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.TabItemEx>
	{
		// Token: 0x060013DF RID: 5087 RVA: 0x000460D4 File Offset: 0x000442D4
		internal static global::Infragistics.Windows.Commands.CommandWrapper[] GetCommandWrappers()
		{
			return new global::Infragistics.Windows.Commands.CommandWrapper[]
			{
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Controls.TabItemExCommands.Close, 0L, 3L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.W, global::System.Windows.Input.ModifierKeys.Control)
				}), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift | global::System.Windows.Input.ModifierKeys.Windows),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Controls.TabItemExCommands.CloseAllButThis)
			};
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00046124 File Offset: 0x00044324
		static TabItemExCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.TabItemEx>.Initialize(global::Infragistics.Windows.Controls.TabItemExCommands.GetCommandWrappers());
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00046175 File Offset: 0x00044375
		public static void LoadCommands()
		{
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x00046177 File Offset: 0x00044377
		internal static global::Infragistics.Windows.Controls.TabItemExCommands Instance
		{
			get
			{
				if (global::Infragistics.Windows.Controls.TabItemExCommands.g_instance == null)
				{
					global::Infragistics.Windows.Controls.TabItemExCommands.g_instance = new global::Infragistics.Windows.Controls.TabItemExCommands();
				}
				return global::Infragistics.Windows.Controls.TabItemExCommands.g_instance;
			}
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00046190 File Offset: 0x00044390
		private static global::System.Windows.Input.InputGestureCollection CreateGestureCombinations(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifiers)
		{
			global::System.Windows.Input.InputGestureCollection inputGestureCollection = new global::System.Windows.Input.InputGestureCollection();
			global::Infragistics.Windows.Controls.TabItemExCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.Controls.TabItemExCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.Controls.TabItemExCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.Controls.TabItemExCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.Controls.TabItemExCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.Controls.TabItemExCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.Controls.TabItemExCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt);
			global::Infragistics.Windows.Controls.TabItemExCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.None);
			return inputGestureCollection;
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x000461EC File Offset: 0x000443EC
		private static void AddGesture(global::System.Windows.Input.InputGestureCollection gestures, global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys gestureModifiers, global::System.Windows.Input.ModifierKeys modifierToCheck)
		{
			if ((gestureModifiers & modifierToCheck) == modifierToCheck)
			{
				gestures.Add(new global::System.Windows.Input.KeyGesture(key, modifierToCheck));
			}
		}

		// Token: 0x04000A85 RID: 2693
		private const global::System.Windows.Input.ModifierKeys AllCtrlShiftModifiers = global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift;

		// Token: 0x04000A86 RID: 2694
		public static readonly global::System.Windows.Input.RoutedCommand Close = new global::Infragistics.Windows.Commands.IGRoutedCommand("Close", typeof(global::Infragistics.Windows.Controls.TabItemExCommands), 0L, 2L);

		// Token: 0x04000A87 RID: 2695
		public static readonly global::System.Windows.Input.RoutedCommand CloseAllButThis = new global::Infragistics.Windows.Commands.IGRoutedCommand("CloseAllButThis", typeof(global::Infragistics.Windows.Controls.TabItemExCommands), 0L, 0L);

		// Token: 0x04000A88 RID: 2696
		private static global::Infragistics.Windows.Controls.TabItemExCommands g_instance;
	}
}
