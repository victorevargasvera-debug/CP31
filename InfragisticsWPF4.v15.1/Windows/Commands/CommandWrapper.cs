using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Infragistics.Windows.Commands
{
	// Token: 0x02000128 RID: 296
	public class CommandWrapper
	{
		// Token: 0x06000B05 RID: 2821 RVA: 0x00024E4B File Offset: 0x0002304B
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command) : this(command, 0L, 0L)
		{
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00024E58 File Offset: 0x00023058
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command, long stateDisallowed, long stateRequired) : this(command, stateDisallowed, stateRequired, null)
		{
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00024E64 File Offset: 0x00023064
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command, long stateDisallowed, long stateRequired, global::System.Windows.Input.InputGestureCollection inputGestures) : this(command, stateDisallowed, stateRequired, inputGestures, global::System.Windows.Input.ModifierKeys.None)
		{
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00024E72 File Offset: 0x00023072
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command, long stateDisallowed, long stateRequired, global::System.Windows.Input.InputGesture inputGesture) : this(command, stateDisallowed, stateRequired, inputGesture, global::System.Windows.Input.ModifierKeys.None)
		{
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00024E80 File Offset: 0x00023080
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command, long stateDisallowed, long stateRequired, global::System.Windows.Input.InputGesture inputGesture, global::System.Windows.Input.ModifierKeys modifierKeysDisallowed) : this(command, stateDisallowed, stateRequired, (inputGesture == null) ? null : new global::System.Windows.Input.InputGesture[]
		{
			inputGesture
		}, modifierKeysDisallowed)
		{
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00024EAC File Offset: 0x000230AC
		public CommandWrapper(global::System.Windows.Input.RoutedCommand command, long stateDisallowed, long stateRequired, global::System.Windows.Input.InputGesture[] inputGestures, global::System.Windows.Input.ModifierKeys modifierKeysDisallowed) : this(command, stateDisallowed, stateRequired, (inputGestures == null) ? null : new global::System.Windows.Input.InputGestureCollection(inputGestures), modifierKeysDisallowed)
		{
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00024EC8 File Offset: 0x000230C8
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

		// Token: 0x06000B0C RID: 2828 RVA: 0x00024F37 File Offset: 0x00023137
		public CommandWrapper(global::Infragistics.Windows.Commands.IGRoutedCommand command, global::System.Windows.Input.InputGestureCollection inputGestures) : this(command, command.MinimumStateDisallowed, command.MinimumStateRequired, inputGestures)
		{
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00024F4D File Offset: 0x0002314D
		public CommandWrapper(global::Infragistics.Windows.Commands.IGRoutedUICommand command, global::System.Windows.Input.InputGestureCollection inputGestures) : this(command, command.MinimumStateDisallowed, command.MinimumStateRequired, inputGestures)
		{
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00024F63 File Offset: 0x00023163
		public global::System.Windows.Input.RoutedCommand Command
		{
			get
			{
				return this._command;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00024F6B File Offset: 0x0002316B
		public bool HasInputGestures
		{
			get
			{
				return this._inputGestures != null && this._inputGestures.Count > 0;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00024F85 File Offset: 0x00023185
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

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00024FA0 File Offset: 0x000231A0
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00024FA8 File Offset: 0x000231A8
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

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00024FB1 File Offset: 0x000231B1
		public global::System.Windows.Input.ModifierKeys ModifierKeysDisallowed
		{
			get
			{
				return this._modifierKeysDisallowed;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00024FB9 File Offset: 0x000231B9
		public long StateDisallowed
		{
			get
			{
				return this._stateDisallowed;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00024FC1 File Offset: 0x000231C1
		public long StateRequired
		{
			get
			{
				return this._stateRequired;
			}
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00024FC9 File Offset: 0x000231C9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool IsAllowed(long state)
		{
			return this._isEnabled && (state & this.StateRequired) == this.StateRequired && 0L == (state & this.StateDisallowed);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00024FF6 File Offset: 0x000231F6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool IsMinimumStatePresent(long state)
		{
			return this._isEnabled && global::Infragistics.Windows.Commands.CommandUtilities.IsMinimumStatePresent(state, this.Command);
		}

		// Token: 0x040004AA RID: 1194
		private global::System.Windows.Input.RoutedCommand _command;

		// Token: 0x040004AB RID: 1195
		private long _stateDisallowed;

		// Token: 0x040004AC RID: 1196
		private long _stateRequired;

		// Token: 0x040004AD RID: 1197
		private bool _isEnabled = true;

		// Token: 0x040004AE RID: 1198
		private global::System.Windows.Input.InputGestureCollection _inputGestures;

		// Token: 0x040004AF RID: 1199
		private global::System.Windows.Input.ModifierKeys _modifierKeysDisallowed;
	}
}
