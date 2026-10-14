using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Infragistics.Windows.Commands
{
	// Token: 0x0200010A RID: 266
	public class CommandWrapper
	{
		// Token: 0x06000A06 RID: 2566 RVA: 0x00021283 File Offset: 0x0001F483
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command) : this(command, 0L, 0L)
		{
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00021290 File Offset: 0x0001F490
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command, long stateDisallowed, long stateRequired) : this(command, stateDisallowed, stateRequired, null)
		{
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0002129C File Offset: 0x0001F49C
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command, long stateDisallowed, long stateRequired, global::System.Windows.Input.InputGestureCollection inputGestures) : this(command, stateDisallowed, stateRequired, inputGestures, global::System.Windows.Input.ModifierKeys.None)
		{
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x000212AA File Offset: 0x0001F4AA
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command, long stateDisallowed, long stateRequired, global::System.Windows.Input.InputGesture inputGesture) : this(command, stateDisallowed, stateRequired, inputGesture, global::System.Windows.Input.ModifierKeys.None)
		{
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x000212B8 File Offset: 0x0001F4B8
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command, long stateDisallowed, long stateRequired, global::System.Windows.Input.InputGesture inputGesture, global::System.Windows.Input.ModifierKeys modifierKeysDisallowed) : this(command, stateDisallowed, stateRequired, (inputGesture == null) ? null : new global::System.Windows.Input.InputGesture[]
		{
			inputGesture
		}, modifierKeysDisallowed)
		{
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x000212E4 File Offset: 0x0001F4E4
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command, long stateDisallowed, long stateRequired, global::System.Windows.Input.InputGesture[] inputGestures, global::System.Windows.Input.ModifierKeys modifierKeysDisallowed) : this(command, stateDisallowed, stateRequired, (inputGestures == null) ? null : new global::System.Windows.Input.InputGestureCollection(inputGestures), modifierKeysDisallowed)
		{
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00021300 File Offset: 0x0001F500
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command, long stateDisallowed, long stateRequired, global::System.Windows.Input.InputGestureCollection inputGestures, global::System.Windows.Input.ModifierKeys modifierKeysDisallowed)
		{
			this._command = command;
			this._stateDisallowed = stateDisallowed;
			this._stateRequired = stateRequired;
			this._inputGestures = inputGestures;
			this._modifierKeysDisallowed = modifierKeysDisallowed;
			global::Infragistics.Windows.Commands.ICommandEx commandEx = command as global::Infragistics.Windows.Commands.ICommandEx;
			if (commandEx != null)
			{
				this._stateDisallowed |= commandEx.MinimumStateDisallowed;
				this._stateRequired |= commandEx.MinimumStateRequired;
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0002136F File Offset: 0x0001F56F
		public CommandWrapper(global::Infragistics.Windows.Commands.IGRoutedCommand command, global::System.Windows.Input.InputGestureCollection inputGestures) : this(command, command.MinimumStateDisallowed, command.MinimumStateRequired, inputGestures)
		{
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00021385 File Offset: 0x0001F585
		public CommandWrapper(global::Infragistics.Windows.Commands.IGRoutedUICommand command, global::System.Windows.Input.InputGestureCollection inputGestures) : this(command, command.MinimumStateDisallowed, command.MinimumStateRequired, inputGestures)
		{
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0002139B File Offset: 0x0001F59B
		public global::System.Windows.Input.RoutedCommand Command
		{
			get
			{
				return this._command;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x000213A3 File Offset: 0x0001F5A3
		public bool HasInputGestures
		{
			get
			{
				return this._inputGestures != null && this._inputGestures.Count > 0;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x000213BD File Offset: 0x0001F5BD
		public global::System.Windows.Input.InputGestureCollection InputGestures
		{
			get
			{
				if (this._inputGestures == null)
				{
					this._inputGestures = new global::System.Windows.Input.InputGestureCollection();
				}
				return this._inputGestures;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x000213D8 File Offset: 0x0001F5D8
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x000213E0 File Offset: 0x0001F5E0
		public bool IsEnabled
		{
			get
			{
				return this._isEnabled;
			}
			set
			{
				this._isEnabled = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x000213E9 File Offset: 0x0001F5E9
		public global::System.Windows.Input.ModifierKeys ModifierKeysDisallowed
		{
			get
			{
				return this._modifierKeysDisallowed;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x000213F1 File Offset: 0x0001F5F1
		public long StateDisallowed
		{
			get
			{
				return this._stateDisallowed;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x000213F9 File Offset: 0x0001F5F9
		public long StateRequired
		{
			get
			{
				return this._stateRequired;
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00021401 File Offset: 0x0001F601
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool IsAllowed(long state)
		{
			return this._isEnabled && (state & this.StateRequired) == this.StateRequired && 0L == (state & this.StateDisallowed);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0002142E File Offset: 0x0001F62E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool IsMinimumStatePresent(long state)
		{
			return this._isEnabled && global::Infragistics.Windows.Commands.CommandUtilities.IsMinimumStatePresent(state, this.Command);
		}

		// Token: 0x040003F7 RID: 1015
		private global::System.Windows.Input.RoutedCommand _command;

		// Token: 0x040003F8 RID: 1016
		private long _stateDisallowed;

		// Token: 0x040003F9 RID: 1017
		private long _stateRequired;

		// Token: 0x040003FA RID: 1018
		private bool _isEnabled = true;

		// Token: 0x040003FB RID: 1019
		private global::System.Windows.Input.InputGestureCollection _inputGestures;

		// Token: 0x040003FC RID: 1020
		private global::System.Windows.Input.ModifierKeys _modifierKeysDisallowed;
	}
}
