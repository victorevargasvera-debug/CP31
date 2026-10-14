using System;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200000A RID: 10
	public class MaskedInputCommand : global::Infragistics.CommandBase
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002E96 File Offset: 0x00001096
		internal MaskedInputCommand(global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId commandId)
		{
			this._commandId = commandId;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002EA5 File Offset: 0x000010A5
		public global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId CommandId
		{
			get
			{
				return this._commandId;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002EB0 File Offset: 0x000010B0
		public override bool CanExecute(object parameter)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = global::Infragistics.Controls.Editors.Primitives.MaskedInputCommand.GetMaskedInput(parameter);
			if (maskedInput != null)
			{
				global::Infragistics.Controls.CommandSource commandSource = base.CommandSource;
				return maskedInput.CanExecuteCommand(this._commandId, (commandSource != null) ? commandSource.SourceElement : null);
			}
			return base.CanExecute(parameter);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002EF0 File Offset: 0x000010F0
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

		// Token: 0x06000021 RID: 33 RVA: 0x00002F48 File Offset: 0x00001148
		private static global::Infragistics.Controls.Editors.XamMaskedInput GetMaskedInput(object parameter)
		{
			return parameter as global::Infragistics.Controls.Editors.XamMaskedInput;
		}

		// Token: 0x0400003F RID: 63
		private global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId _commandId;
	}
}
