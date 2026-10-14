using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200009D RID: 157
	public class MaskedEditorCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamMaskedEditor>
	{
		// Token: 0x06000878 RID: 2168 RVA: 0x000277B4 File Offset: 0x000259B4
		private static global::Infragistics.Windows.Commands.CommandWrapper[] GetCommandWrappers()
		{
			return new global::Infragistics.Windows.Commands.CommandWrapper[]
			{
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.NextCharacter, 0L, 1L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Shift)
				}, global::System.Windows.Input.ModifierKeys.Control),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.NextSection, 16L, 1L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.AfterLastCharacter, 0L, 16L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SetPivot, 0L, 0L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.PreviousCharacter, 2L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Shift)
				}, global::System.Windows.Input.ModifierKeys.Control),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.PreviousSection, 8L, 0L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.FirstCharacter, 2L, 8L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SetPivot, 0L, 0L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.FirstCharacter, 2L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Shift)
				}, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SetPivot, 0L, 0L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.AfterLastCharacter, 256L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Shift)
				}, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SetPivot, 0L, 0L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.NextSection, 16L, 16385L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Tab, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SetPivot, 16L, 16385L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Tab, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SelectSection, 16L, 16385L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Tab, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SelectAll, 0L, 0L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.A, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.PreviousSection, 8L, 16384L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Tab, global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SetPivot, 8L, 16384L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Tab, global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SelectSection, 8L, 16384L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Tab, global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Delete, 0L, 512L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Delete, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Delete, 512L, 1L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Delete, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Backspace, 512L, 0L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Delete, global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.Control),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.AfterLastCharacter, 512L, 1L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Delete, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Delete, 512L, 1L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Delete, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Backspace, 0L, 512L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Back, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Backspace, 514L, 0L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Back, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Copy, 0L, 512L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.C, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Cut, 0L, 512L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.X, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Paste, 0L, 0L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.V, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.ToggleInsertionMode, 0L, 0L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Insert, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SpinUp, 0L, 131072L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Up, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SpinDown, 0L, 65536L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Down, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.NotACommand, 0L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Up, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Down, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Shift),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Shift),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control)
				}, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Copy, 0L, 512L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Insert, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Paste, 0L, 0L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Insert, global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.Control),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Cut, 0L, 512L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Delete, global::System.Windows.Input.ModifierKeys.Shift), global::System.Windows.Input.ModifierKeys.Control),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.NextSection, 0L, 32768L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Decimal, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SetPivot, 0L, 32768L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Decimal, global::System.Windows.Input.ModifierKeys.None), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Undo, 0L, 262144L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Z, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.Redo, 0L, 524288L, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Y, global::System.Windows.Input.ModifierKeys.Control), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.NotACommand, 0L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Back, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Back, global::System.Windows.Input.ModifierKeys.Shift),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Back, global::System.Windows.Input.ModifierKeys.Control)
				}, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.ToggleDropDown, 0L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Up, global::System.Windows.Input.ModifierKeys.Alt),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Down, global::System.Windows.Input.ModifierKeys.Alt),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.F4, global::System.Windows.Input.ModifierKeys.None)
				}, global::System.Windows.Input.ModifierKeys.Control),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.ToggleDropDown, 0L, 2097152L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Return, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Space, global::System.Windows.Input.ModifierKeys.None)
				}, global::System.Windows.Input.ModifierKeys.Control),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.ToggleDropDown, 0L, 2097152L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Escape, global::System.Windows.Input.ModifierKeys.None)
				}, global::System.Windows.Input.ModifierKeys.Control)
			};
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00027DF8 File Offset: 0x00025FF8
		static MaskedEditorCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamMaskedEditor>.Initialize(global::Infragistics.Windows.Editors.MaskedEditorCommands.GetCommandWrappers());
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00028014 File Offset: 0x00026214
		public static void LoadCommands()
		{
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00028016 File Offset: 0x00026216
		internal static global::Infragistics.Windows.Editors.MaskedEditorCommands Instance
		{
			get
			{
				if (global::Infragistics.Windows.Editors.MaskedEditorCommands.g_instance == null)
				{
					global::Infragistics.Windows.Editors.MaskedEditorCommands.g_instance = new global::Infragistics.Windows.Editors.MaskedEditorCommands();
				}
				return global::Infragistics.Windows.Editors.MaskedEditorCommands.g_instance;
			}
		}

		// Token: 0x04000320 RID: 800
		public static readonly global::System.Windows.Input.RoutedCommand NotACommand = global::System.Windows.Input.ApplicationCommands.NotACommand;

		// Token: 0x04000321 RID: 801
		public static readonly global::System.Windows.Input.RoutedCommand NextCharacter = new global::Infragistics.Windows.Commands.IGRoutedCommand("NextCharacter", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 1L);

		// Token: 0x04000322 RID: 802
		public static readonly global::System.Windows.Input.RoutedCommand NextSection = new global::Infragistics.Windows.Commands.IGRoutedCommand("NextSection", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097168L, 1L);

		// Token: 0x04000323 RID: 803
		public static readonly global::System.Windows.Input.RoutedCommand AfterLastCharacter = new global::Infragistics.Windows.Commands.IGRoutedCommand("AfterLastCharacter", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 0L);

		// Token: 0x04000324 RID: 804
		public static readonly global::System.Windows.Input.RoutedCommand SetPivot = new global::Infragistics.Windows.Commands.IGRoutedCommand("SetPivot", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 0L);

		// Token: 0x04000325 RID: 805
		public static readonly global::System.Windows.Input.RoutedCommand PreviousCharacter = new global::Infragistics.Windows.Commands.IGRoutedCommand("PreviousCharacter", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097154L, 0L);

		// Token: 0x04000326 RID: 806
		public static readonly global::System.Windows.Input.RoutedCommand PreviousSection = new global::Infragistics.Windows.Commands.IGRoutedCommand("PreviousSection", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097160L, 0L);

		// Token: 0x04000327 RID: 807
		public static readonly global::System.Windows.Input.RoutedCommand FirstCharacter = new global::Infragistics.Windows.Commands.IGRoutedCommand("FirstCharacter", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097154L, 0L);

		// Token: 0x04000328 RID: 808
		public static readonly global::System.Windows.Input.RoutedCommand SelectSection = new global::Infragistics.Windows.Commands.IGRoutedCommand("SelectSection", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 0L);

		// Token: 0x04000329 RID: 809
		public static readonly global::System.Windows.Input.RoutedCommand SelectAll = global::System.Windows.Input.ApplicationCommands.SelectAll;

		// Token: 0x0400032A RID: 810
		public static readonly global::System.Windows.Input.RoutedCommand Delete = global::System.Windows.Input.ApplicationCommands.Delete;

		// Token: 0x0400032B RID: 811
		public static readonly global::System.Windows.Input.RoutedCommand Backspace = new global::Infragistics.Windows.Commands.IGRoutedCommand("Backspace", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 0L);

		// Token: 0x0400032C RID: 812
		public static readonly global::System.Windows.Input.RoutedCommand Copy = global::System.Windows.Input.ApplicationCommands.Copy;

		// Token: 0x0400032D RID: 813
		public static readonly global::System.Windows.Input.RoutedCommand Cut = global::System.Windows.Input.ApplicationCommands.Cut;

		// Token: 0x0400032E RID: 814
		public static readonly global::System.Windows.Input.RoutedCommand Paste = global::System.Windows.Input.ApplicationCommands.Paste;

		// Token: 0x0400032F RID: 815
		public static readonly global::System.Windows.Input.RoutedCommand Undo = global::System.Windows.Input.ApplicationCommands.Undo;

		// Token: 0x04000330 RID: 816
		public static readonly global::System.Windows.Input.RoutedCommand Redo = global::System.Windows.Input.ApplicationCommands.Redo;

		// Token: 0x04000331 RID: 817
		public static readonly global::System.Windows.Input.RoutedCommand ToggleInsertionMode = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleInsertionMode", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 0L);

		// Token: 0x04000332 RID: 818
		public static readonly global::System.Windows.Input.RoutedCommand SpinUp = new global::Infragistics.Windows.Commands.IGRoutedCommand("SpinUp", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 131072L);

		// Token: 0x04000333 RID: 819
		public static readonly global::System.Windows.Input.RoutedCommand SpinDown = new global::Infragistics.Windows.Commands.IGRoutedCommand("SpinDown", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 65536L);

		// Token: 0x04000334 RID: 820
		public static readonly global::System.Windows.Input.RoutedCommand ToggleDropDown = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleDropDown", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 0L, 1048576L);

		// Token: 0x04000335 RID: 821
		private static global::Infragistics.Windows.Editors.MaskedEditorCommands g_instance;
	}
}
