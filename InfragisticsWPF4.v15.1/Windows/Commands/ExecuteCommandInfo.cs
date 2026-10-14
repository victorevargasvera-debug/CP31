using System;
using System.Windows.Input;

namespace Infragistics.Windows.Commands
{
	// Token: 0x0200012C RID: 300
	public class ExecuteCommandInfo
	{
		// Token: 0x06000B2B RID: 2859 RVA: 0x0002543D File Offset: 0x0002363D
		public ExecuteCommandInfo(global::System.Windows.Input.ICommand command) : this(command, null, null)
		{
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00025448 File Offset: 0x00023648
		public ExecuteCommandInfo(global::System.Windows.Input.ICommand command, object commandParameter, object originalSource) : this(command, commandParameter, originalSource, false)
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00025454 File Offset: 0x00023654
		public ExecuteCommandInfo(global::System.Windows.Input.ICommand command, object commandParameter, object originalSource, bool continueRouting)
		{
			if (command == null)
			{
				throw new global::System.ArgumentNullException("command");
			}
			this._command = command;
			this._parameter = commandParameter;
			this._originalSource = originalSource;
			this._continueRouting = continueRouting;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x00025487 File Offset: 0x00023687
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				return this._command;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0002548F File Offset: 0x0002368F
		public global::System.Windows.Input.RoutedCommand RoutedCommand
		{
			get
			{
				return this._command as global::System.Windows.Input.RoutedCommand;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0002549C File Offset: 0x0002369C
		public object Parameter
		{
			get
			{
				return this._parameter;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x000254A4 File Offset: 0x000236A4
		public object OriginalSource
		{
			get
			{
				return this._originalSource;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x000254AC File Offset: 0x000236AC
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x000254B4 File Offset: 0x000236B4
		public bool ContinueRouting
		{
			get
			{
				return this._continueRouting;
			}
			set
			{
				this._continueRouting = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x000254BD File Offset: 0x000236BD
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x000254C5 File Offset: 0x000236C5
		public bool ForceHandled
		{
			get
			{
				return this._forceHandled;
			}
			set
			{
				this._forceHandled = value;
			}
		}

		// Token: 0x040004B2 RID: 1202
		private global::System.Windows.Input.ICommand _command;

		// Token: 0x040004B3 RID: 1203
		private object _parameter;

		// Token: 0x040004B4 RID: 1204
		private object _originalSource;

		// Token: 0x040004B5 RID: 1205
		private bool _continueRouting;

		// Token: 0x040004B6 RID: 1206
		private bool _forceHandled;
	}
}
