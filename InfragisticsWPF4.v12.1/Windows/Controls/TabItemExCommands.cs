using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020001E2 RID: 482
	public class TabItemExCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.TabItemEx>
	{
		// Token: 0x0600120B RID: 4619 RVA: 0x0004082C File Offset: 0x0003EA2C
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

		// Token: 0x0600120C RID: 4620 RVA: 0x0004087C File Offset: 0x0003EA7C
		static TabItemExCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.TabItemEx>.Initialize(global::Infragistics.Windows.Controls.TabItemExCommands.GetCommandWrappers());
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x000408CD File Offset: 0x0003EACD
		public static void LoadCommands()
		{
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x000408CF File Offset: 0x0003EACF
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

		// Token: 0x0600120F RID: 4623 RVA: 0x000408E8 File Offset: 0x0003EAE8
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

		// Token: 0x06001210 RID: 4624 RVA: 0x00040944 File Offset: 0x0003EB44
		private static void AddGesture(global::System.Windows.Input.InputGestureCollection gestures, global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys gestureModifiers, global::System.Windows.Input.ModifierKeys modifierToCheck)
		{
			if ((gestureModifiers & modifierToCheck) == modifierToCheck)
			{
				gestures.Add(new global::System.Windows.Input.KeyGesture(key, modifierToCheck));
			}
		}

		// Token: 0x04000941 RID: 2369
		private const global::System.Windows.Input.ModifierKeys AllCtrlShiftModifiers = global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift;

		// Token: 0x04000942 RID: 2370
		public static readonly global::System.Windows.Input.RoutedCommand Close = new global::Infragistics.Windows.Commands.IGRoutedCommand("Close", typeof(global::Infragistics.Windows.Controls.TabItemExCommands), 0L, 2L);

		// Token: 0x04000943 RID: 2371
		public static readonly global::System.Windows.Input.RoutedCommand CloseAllButThis = new global::Infragistics.Windows.Commands.IGRoutedCommand("CloseAllButThis", typeof(global::Infragistics.Windows.Controls.TabItemExCommands), 0L, 0L);

		// Token: 0x04000944 RID: 2372
		private static global::Infragistics.Windows.Controls.TabItemExCommands g_instance;
	}
}
