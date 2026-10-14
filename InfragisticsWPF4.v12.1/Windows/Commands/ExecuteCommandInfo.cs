using System;
using System.Windows.Input;

namespace Infragistics.Windows.Commands
{
	// Token: 0x0200010E RID: 270
	public class ExecuteCommandInfo
	{
		// Token: 0x06000A2C RID: 2604 RVA: 0x00021875 File Offset: 0x0001FA75
		public ExecuteCommandInfo(global::System.Windows.Input.ICommand command) : this(command, null, null)
		{
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00021880 File Offset: 0x0001FA80
		public ExecuteCommandInfo(global::System.Windows.Input.ICommand command, object commandParameter, object originalSource) : this(command, commandParameter, originalSource, false)
		{
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0002188C File Offset: 0x0001FA8C
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

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x000218BF File Offset: 0x0001FABF
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				return this._command;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x000218C7 File Offset: 0x0001FAC7
		public global::System.Windows.Input.RoutedCommand RoutedCommand
		{
			get
			{
				return this._command as global::System.Windows.Input.RoutedCommand;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x000218D4 File Offset: 0x0001FAD4
		public object Parameter
		{
			get
			{
				return this._parameter;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x000218DC File Offset: 0x0001FADC
		public object OriginalSource
		{
			get
			{
				return this._originalSource;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x000218E4 File Offset: 0x0001FAE4
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x000218EC File Offset: 0x0001FAEC
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

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x000218F5 File Offset: 0x0001FAF5
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x000218FD File Offset: 0x0001FAFD
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

		// Token: 0x040003FF RID: 1023
		private global::System.Windows.Input.ICommand _command;

		// Token: 0x04000400 RID: 1024
		private object _parameter;

		// Token: 0x04000401 RID: 1025
		private object _originalSource;

		// Token: 0x04000402 RID: 1026
		private bool _continueRouting;

		// Token: 0x04000403 RID: 1027
		private bool _forceHandled;
	}
}
