using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200002A RID: 42
	public class ComboEditorCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamComboEditor>
	{
		// Token: 0x060002DB RID: 731 RVA: 0x0000B0AC File Offset: 0x000092AC
		private static global::Infragistics.Windows.Commands.CommandWrapper[] GetCommandWrappers()
		{
			return new global::Infragistics.Windows.Commands.CommandWrapper[]
			{
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.Editors.ComboEditorCommands.ToggleDropDown, 0L, 0L, new global::System.Windows.Input.InputGesture[0], global::System.Windows.Input.ModifierKeys.None)
			};
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000B0D9 File Offset: 0x000092D9
		static ComboEditorCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamComboEditor>.Initialize(global::Infragistics.Windows.Editors.ComboEditorCommands.GetCommandWrappers());
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000B10C File Offset: 0x0000930C
		public static void LoadCommands()
		{
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000B10E File Offset: 0x0000930E
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

		// Token: 0x040000DD RID: 221
		public static readonly global::System.Windows.Input.RoutedCommand NotACommand = global::System.Windows.Input.ApplicationCommands.NotACommand;

		// Token: 0x040000DE RID: 222
		public static readonly global::System.Windows.Input.RoutedCommand ToggleDropDown = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleDropDown", typeof(global::Infragistics.Windows.Editors.ComboEditorCommands), 0L, 0L);

		// Token: 0x040000DF RID: 223
		private static global::Infragistics.Windows.Editors.ComboEditorCommands g_instance;
	}
}
