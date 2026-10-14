using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A4 RID: 164
	public class MaskedEditorCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamMaskedEditor>
	{
		// Token: 0x060008E5 RID: 2277 RVA: 0x000295A4 File Offset: 0x000277A4
		private static global::Infragistics.Windows.Commands.CommandWrapper[] GetCommandWrappers()
		{
			return new global::Infragistics.Windows.Commands.CommandWrapper[]
			{
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.NextCharacter, 0L, 1L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Shift)
				}, global::System.Windows.Input.ModifierKeys.Control),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.NextSection, 16L, 1L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)
				}, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.AfterLastCharacter, 0L, 16L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)
				}, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SetPivot, 0L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control)
				}, global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.PreviousCharacter, 2L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Shift)
				}, global::System.Windows.Input.ModifierKeys.Control),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.PreviousSection, 8L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)
				}, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.FirstCharacter, 2L, 8L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)
				}, global::System.Windows.Input.ModifierKeys.None),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.MaskedEditorCommands.SetPivot, 0L, 0L, new global::System.Windows.Input.InputGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.None),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control)
				}, global::System.Windows.Input.ModifierKeys.Shift),
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

		// Token: 0x060008E6 RID: 2278 RVA: 0x00029C84 File Offset: 0x00027E84
		static MaskedEditorCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamMaskedEditor>.Initialize(global::Infragistics.Windows.Editors.MaskedEditorCommands.GetCommandWrappers());
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00029EA0 File Offset: 0x000280A0
		public static void LoadCommands()
		{
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00029EA2 File Offset: 0x000280A2
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

		// Token: 0x04000356 RID: 854
		public static readonly global::System.Windows.Input.RoutedCommand NotACommand = global::System.Windows.Input.ApplicationCommands.NotACommand;

		// Token: 0x04000357 RID: 855
		public static readonly global::System.Windows.Input.RoutedCommand NextCharacter = new global::Infragistics.Windows.Commands.IGRoutedCommand("NextCharacter", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 1L);

		// Token: 0x04000358 RID: 856
		public static readonly global::System.Windows.Input.RoutedCommand NextSection = new global::Infragistics.Windows.Commands.IGRoutedCommand("NextSection", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097168L, 1L);

		// Token: 0x04000359 RID: 857
		public static readonly global::System.Windows.Input.RoutedCommand AfterLastCharacter = new global::Infragistics.Windows.Commands.IGRoutedCommand("AfterLastCharacter", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 0L);

		// Token: 0x0400035A RID: 858
		public static readonly global::System.Windows.Input.RoutedCommand SetPivot = new global::Infragistics.Windows.Commands.IGRoutedCommand("SetPivot", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 0L);

		// Token: 0x0400035B RID: 859
		public static readonly global::System.Windows.Input.RoutedCommand PreviousCharacter = new global::Infragistics.Windows.Commands.IGRoutedCommand("PreviousCharacter", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097154L, 0L);

		// Token: 0x0400035C RID: 860
		public static readonly global::System.Windows.Input.RoutedCommand PreviousSection = new global::Infragistics.Windows.Commands.IGRoutedCommand("PreviousSection", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097160L, 0L);

		// Token: 0x0400035D RID: 861
		public static readonly global::System.Windows.Input.RoutedCommand FirstCharacter = new global::Infragistics.Windows.Commands.IGRoutedCommand("FirstCharacter", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097154L, 0L);

		// Token: 0x0400035E RID: 862
		public static readonly global::System.Windows.Input.RoutedCommand SelectSection = new global::Infragistics.Windows.Commands.IGRoutedCommand("SelectSection", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 0L);

		// Token: 0x0400035F RID: 863
		public static readonly global::System.Windows.Input.RoutedCommand SelectAll = global::System.Windows.Input.ApplicationCommands.SelectAll;

		// Token: 0x04000360 RID: 864
		public static readonly global::System.Windows.Input.RoutedCommand Delete = global::System.Windows.Input.ApplicationCommands.Delete;

		// Token: 0x04000361 RID: 865
		public static readonly global::System.Windows.Input.RoutedCommand Backspace = new global::Infragistics.Windows.Commands.IGRoutedCommand("Backspace", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 0L);

		// Token: 0x04000362 RID: 866
		public static readonly global::System.Windows.Input.RoutedCommand Copy = global::System.Windows.Input.ApplicationCommands.Copy;

		// Token: 0x04000363 RID: 867
		public static readonly global::System.Windows.Input.RoutedCommand Cut = global::System.Windows.Input.ApplicationCommands.Cut;

		// Token: 0x04000364 RID: 868
		public static readonly global::System.Windows.Input.RoutedCommand Paste = global::System.Windows.Input.ApplicationCommands.Paste;

		// Token: 0x04000365 RID: 869
		public static readonly global::System.Windows.Input.RoutedCommand Undo = global::System.Windows.Input.ApplicationCommands.Undo;

		// Token: 0x04000366 RID: 870
		public static readonly global::System.Windows.Input.RoutedCommand Redo = global::System.Windows.Input.ApplicationCommands.Redo;

		// Token: 0x04000367 RID: 871
		public static readonly global::System.Windows.Input.RoutedCommand ToggleInsertionMode = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleInsertionMode", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 0L);

		// Token: 0x04000368 RID: 872
		public static readonly global::System.Windows.Input.RoutedCommand SpinUp = new global::Infragistics.Windows.Commands.IGRoutedCommand("SpinUp", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 131072L);

		// Token: 0x04000369 RID: 873
		public static readonly global::System.Windows.Input.RoutedCommand SpinDown = new global::Infragistics.Windows.Commands.IGRoutedCommand("SpinDown", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 2097152L, 65536L);

		// Token: 0x0400036A RID: 874
		public static readonly global::System.Windows.Input.RoutedCommand ToggleDropDown = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleDropDown", typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands), 0L, 1048576L);

		// Token: 0x0400036B RID: 875
		private static global::Infragistics.Windows.Editors.MaskedEditorCommands g_instance;
	}
}
