using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000027 RID: 39
	public class ComboEditorCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamComboEditor>
	{
		// Token: 0x060002BB RID: 699 RVA: 0x0000A7FC File Offset: 0x000089FC
		private static global::Infragistics.Windows.Commands.CommandWrapper[] GetCommandWrappers()
		{
			return new global::Infragistics.Windows.Commands.CommandWrapper[]
			{
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.ComboEditorCommands.ToggleDropDown, 0L, 0L, new global::System.Windows.Input.InputGesture[0], global::System.Windows.Input.ModifierKeys.None)
			};
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000A829 File Offset: 0x00008A29
		static ComboEditorCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamComboEditor>.Initialize(global::Infragistics.Windows.Editors.ComboEditorCommands.GetCommandWrappers());
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000A85C File Offset: 0x00008A5C
		public static void LoadCommands()
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000A85E File Offset: 0x00008A5E
		internal static global::Infragistics.Windows.Editors.ComboEditorCommands Instance
		{
			get
			{
				if (global::Infragistics.Windows.Editors.ComboEditorCommands.g_instance == null)
				{
					global::Infragistics.Windows.Editors.ComboEditorCommands.g_instance = new global::Infragistics.Windows.Editors.ComboEditorCommands();
				}
				return global::Infragistics.Windows.Editors.ComboEditorCommands.g_instance;
			}
		}

		// Token: 0x040000C5 RID: 197
		public static readonly global::System.Windows.Input.RoutedCommand NotACommand = global::System.Windows.Input.ApplicationCommands.NotACommand;

		// Token: 0x040000C6 RID: 198
		public static readonly global::System.Windows.Input.RoutedCommand ToggleDropDown = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleDropDown", typeof(global::Infragistics.Windows.Editors.ComboEditorCommands), 0L, 0L);

		// Token: 0x040000C7 RID: 199
		private static global::Infragistics.Windows.Editors.ComboEditorCommands g_instance;
	}
}
