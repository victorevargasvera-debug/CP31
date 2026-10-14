using System;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000009 RID: 9
	public class MaskedInputCommand : global::Infragistics.CommandBase
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000027B3 File Offset: 0x000009B3
		internal MaskedInputCommand(global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId commandId)
		{
			this._commandId = commandId;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000027C2 File Offset: 0x000009C2
		public global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId CommandId
		{
			get
			{
				return this._commandId;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000027CC File Offset: 0x000009CC
		public override bool CanExecute(object parameter)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = global::Infragistics.Controls.Editors.Primitives.MaskedInputCommand.GetMaskedInput(parameter);
			if (maskedInput != null)
			{
				global::Infragistics.Controls.CommandSource commandSource = base.CommandSource;
				return (maskedInput.IsUndoEnabled || (this._commandId != global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Undo && this._commandId != global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Redo)) && maskedInput.CanExecuteCommand(this._commandId, (commandSource != null) ? commandSource.SourceElement : null);
			}
			return base.CanExecute(parameter);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002828 File Offset: 0x00000A28
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = global::Infragistics.Controls.Editors.Primitives.MaskedInputCommand.GetMaskedInput(parameter);
			if (maskedInput != null)
			{
				global::Infragistics.Controls.CommandSource commandSource = base.CommandSource;
				maskedInput.ExecuteCommand(this._commandId, (commandSource != null) ? commandSource.ParameterResolved : null, (commandSource != null) ? commandSource.SourceElement : null);
				if (commandSource != null)
				{
					commandSource.Handled = true;
				}
				return;
			}
			base.Execute(parameter);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002880 File Offset: 0x00000A80
		private static global::Infragistics.Controls.Editors.XamMaskedInput GetMaskedInput(object parameter)
		{
			return parameter as global::Infragistics.Controls.Editors.XamMaskedInput;
		}

		// Token: 0x04000041 RID: 65
		private global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId _commandId;
	}
}
