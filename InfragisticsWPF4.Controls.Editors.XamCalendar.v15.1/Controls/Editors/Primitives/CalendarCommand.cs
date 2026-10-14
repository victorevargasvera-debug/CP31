using System;
using System.Windows;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000033 RID: 51
	public class CalendarCommand : global::Infragistics.CommandBase
	{
		// Token: 0x06000259 RID: 601 RVA: 0x0000CB55 File Offset: 0x0000AD55
		internal CalendarCommand(global::Infragistics.Controls.Editors.CalendarCommandType commandTyoe)
		{
			this._commandType = commandTyoe;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000CB64 File Offset: 0x0000AD64
		public override bool CanExecute(object parameter)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.Primitives.CalendarCommand.GetCalendar(parameter);
			if (calendar != null)
			{
				global::Infragistics.Controls.CommandSource commandSource = base.CommandSource;
				return calendar.CanExecuteCommand(this._commandType, commandSource.SourceElement);
			}
			return base.CanExecute(parameter);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000CB9C File Offset: 0x0000AD9C
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.Primitives.CalendarCommand.GetCalendar(parameter);
			if (calendar != null)
			{
				global::Infragistics.Controls.CommandSource commandSource = base.CommandSource;
				calendar.ExecuteCommand(this._commandType, commandSource.ParameterResolved, commandSource.SourceElement);
				base.CommandSource.Handled = true;
				return;
			}
			base.Execute(parameter);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		private static global::Infragistics.Controls.Editors.CalendarBase GetCalendar(object parameter)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = parameter as global::Infragistics.Controls.Editors.CalendarBase;
			if (calendarBase == null)
			{
				global::System.Windows.DependencyObject dependencyObject = parameter as global::System.Windows.DependencyObject;
				if (dependencyObject != null)
				{
					calendarBase = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(dependencyObject);
				}
			}
			return calendarBase;
		}

		// Token: 0x0400016F RID: 367
		private global::Infragistics.Controls.Editors.CalendarCommandType _commandType;
	}
}
