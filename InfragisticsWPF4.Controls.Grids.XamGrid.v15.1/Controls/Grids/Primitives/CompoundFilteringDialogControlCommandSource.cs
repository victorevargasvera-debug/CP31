using System;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000070 RID: 112
	public class CompoundFilteringDialogControlCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00013249 File Offset: 0x00011449
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00013251 File Offset: 0x00011451
		public global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControlCommand CommandType { get; set; }

		// Token: 0x06000422 RID: 1058 RVA: 0x0001325C File Offset: 0x0001145C
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControlCommand.Accept:
				result = new global::Infragistics.Controls.Grids.Primitives.AcceptCompoundFilterDialogChangesCommand();
				break;
			case global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControlCommand.Close:
				result = new global::Infragistics.Controls.Grids.Primitives.CloseCompoundFilterDialogCommand();
				break;
			case global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControlCommand.AddToCurrent:
				result = new global::Infragistics.Controls.Grids.Primitives.AddToCurrentCompoundFilterDialogCommand();
				break;
			case global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControlCommand.DeleteCondition:
				result = new global::Infragistics.Controls.Grids.Primitives.RemoveConditionsCompoundFilterDialogCommand();
				break;
			case global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControlCommand.CreateAndGroup:
				result = new global::Infragistics.Controls.Grids.Primitives.CreateAndGroupCompoundFilterDialogCommand();
				break;
			case global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControlCommand.CreateOrGroup:
				result = new global::Infragistics.Controls.Grids.Primitives.CreateOrGroupCompoundFilterDialogCommand();
				break;
			case global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControlCommand.Ungroup:
				result = new global::Infragistics.Controls.Grids.Primitives.UngroupCompoundFilterDialogCommand();
				break;
			case global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControlCommand.ToggleGroup:
				result = new global::Infragistics.Controls.Grids.Primitives.ToggleGroupCompoundFilterDialogCommand();
				break;
			}
			return result;
		}
	}
}
