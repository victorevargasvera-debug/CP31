using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000002 RID: 2
	internal abstract class CommandsHelper<TCommandId> where TCommandId : struct
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D8 File Offset: 0x000002D8
		protected CommandsHelper(global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandWrapper[] commands, global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandDefinition[] minimumRequiredStates = null)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(commands, "commands");
			this._commands = commands;
			if (minimumRequiredStates != null)
			{
				global::System.Collections.Generic.Dictionary<TCommandId, global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandDefinition> dictionary = minimumRequiredStates.ToDictionary((global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandDefinition ii) => ii._command);
				foreach (global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandWrapper commandWrapper in commands)
				{
					global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandDefinition minimumRequiredState;
					if (dictionary.TryGetValue(commandWrapper._command, out minimumRequiredState))
					{
						commandWrapper._minimumRequiredState = minimumRequiredState;
					}
				}
				this._minimumRequiredStates = dictionary;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000215C File Offset: 0x0000035C
		public bool? DoesMinimumStateMatch(TCommandId commandId, long controlState)
		{
			global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandDefinition commandDefinition;
			if (this._minimumRequiredStates != null && this._minimumRequiredStates.TryGetValue(commandId, out commandDefinition))
			{
				return new bool?(global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandWrapper.StateMatchHelper(controlState, commandDefinition._disallowedState, commandDefinition._requiredState));
			}
			return null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021A4 File Offset: 0x000003A4
		public bool? DoesMinimumStateMatch(TCommandId commandId, global::System.Func<long, long> getCurrentStates)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(getCurrentStates);
			global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandDefinition commandDefinition;
			if (this._minimumRequiredStates != null && this._minimumRequiredStates.TryGetValue(commandId, out commandDefinition))
			{
				long controlState = getCurrentStates(commandDefinition._disallowedState | commandDefinition._requiredState);
				return new bool?(global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandWrapper.StateMatchHelper(controlState, commandDefinition._disallowedState, commandDefinition._requiredState));
			}
			return null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002238 File Offset: 0x00000438
		public global::System.Collections.Generic.IEnumerable<TCommandId> GetMatchingCommands(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifierKeys, long controlState)
		{
			return from ww in this._commands
			where ww.DoesKeyMatch(key, modifierKeys) && ww.DoesStateMatch(controlState)
			select ww._command;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000022B8 File Offset: 0x000004B8
		public global::System.Collections.Generic.IEnumerable<TCommandId> GetMatchingCommands(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifierKeys, global::System.Func<long, long> getCurrentStates)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(getCurrentStates);
			global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandWrapper> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandWrapper>();
			long num = 0L;
			foreach (global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandWrapper commandWrapper in this._commands)
			{
				if (commandWrapper.DoesKeyMatch(key, modifierKeys))
				{
					list.Add(commandWrapper);
					num |= commandWrapper.StatesConsidered;
				}
			}
			long controlState = getCurrentStates(num);
			return from ww in list
			where ww.DoesStateMatch(controlState)
			select ww._command;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002358 File Offset: 0x00000558
		internal global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandDefinition GetDefinition(TCommandId commandId)
		{
			global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandDefinition result;
			this._minimumRequiredStates.TryGetValue(commandId, out result);
			return result;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002398 File Offset: 0x00000598
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandWrapper> GetCommandWrappers(TCommandId commandId)
		{
			return from ii in this._commands
			where global::System.Collections.Generic.EqualityComparer<TCommandId>.Default.Equals(ii._command, commandId)
			select ii;
		}

		// Token: 0x04000001 RID: 1
		private global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandWrapper[] _commands;

		// Token: 0x04000002 RID: 2
		private global::System.Collections.Generic.Dictionary<TCommandId, global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandDefinition> _minimumRequiredStates;

		// Token: 0x02000003 RID: 3
		internal class CommandDefinition
		{
			// Token: 0x0600000B RID: 11 RVA: 0x000023C9 File Offset: 0x000005C9
			internal CommandDefinition(TCommandId command, long disallowedState, long requiredState)
			{
				this._command = command;
				this._disallowedState = disallowedState;
				this._requiredState = requiredState;
			}

			// Token: 0x04000006 RID: 6
			internal readonly TCommandId _command;

			// Token: 0x04000007 RID: 7
			internal readonly long _disallowedState;

			// Token: 0x04000008 RID: 8
			internal readonly long _requiredState;
		}

		// Token: 0x02000004 RID: 4
		internal struct KeyGesture
		{
			// Token: 0x0600000C RID: 12 RVA: 0x000023E6 File Offset: 0x000005E6
			internal KeyGesture(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifierKeys)
			{
				this._key = key;
				this._modifierKeys = modifierKeys;
			}

			// Token: 0x04000009 RID: 9
			internal readonly global::System.Windows.Input.Key _key;

			// Token: 0x0400000A RID: 10
			internal readonly global::System.Windows.Input.ModifierKeys _modifierKeys;
		}

		// Token: 0x02000005 RID: 5
		internal class CommandWrapper
		{
			// Token: 0x0600000D RID: 13 RVA: 0x000023F8 File Offset: 0x000005F8
			internal CommandWrapper(TCommandId command, long disallowedState, long requiredState, global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.KeyGesture keyGesture, global::System.Windows.Input.ModifierKeys disallowedModifierKeys = global::System.Windows.Input.ModifierKeys.None) : this(command, disallowedState, requiredState, new global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.KeyGesture[]
			{
				keyGesture
			}, disallowedModifierKeys)
			{
			}

			// Token: 0x0600000E RID: 14 RVA: 0x00002426 File Offset: 0x00000626
			internal CommandWrapper(TCommandId command, long disallowedState, long requiredState, global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.KeyGesture[] keyGestures, global::System.Windows.Input.ModifierKeys disallowedModifierKeys = global::System.Windows.Input.ModifierKeys.None)
			{
				this._command = command;
				this._disallowedState = disallowedState;
				this._requiredState = requiredState;
				this._keyGestures = keyGestures;
				this._disallowedModifierKeys = disallowedModifierKeys;
			}

			// Token: 0x0600000F RID: 15 RVA: 0x00002454 File Offset: 0x00000654
			internal bool DoesKeyMatch(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifierKeys)
			{
				if (this._keyGestures != null)
				{
					for (int i = 0; i < this._keyGestures.Length; i++)
					{
						global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.KeyGesture keyGesture = this._keyGestures[i];
						if (keyGesture._key == key && keyGesture._modifierKeys == (keyGesture._modifierKeys & modifierKeys) && (this._disallowedModifierKeys & modifierKeys) == global::System.Windows.Input.ModifierKeys.None)
						{
							return true;
						}
					}
				}
				return false;
			}

			// Token: 0x06000010 RID: 16 RVA: 0x000024B7 File Offset: 0x000006B7
			internal static bool StateMatchHelper(long controlState, long disallowedState, long requiredState)
			{
				return 0L == (disallowedState & controlState) && requiredState == (requiredState & controlState);
			}

			// Token: 0x06000011 RID: 17 RVA: 0x000024C8 File Offset: 0x000006C8
			internal bool DoesStateMatch(long controlState)
			{
				return global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandWrapper.StateMatchHelper(controlState, this._disallowedState, this._requiredState) && (this._minimumRequiredState == null || global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandWrapper.StateMatchHelper(controlState, this._minimumRequiredState._disallowedState, this._minimumRequiredState._requiredState));
			}

			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000012 RID: 18 RVA: 0x00002508 File Offset: 0x00000708
			public long StatesConsidered
			{
				get
				{
					long num = this._disallowedState | this._requiredState;
					if (this._minimumRequiredState != null)
					{
						num |= (this._minimumRequiredState._disallowedState | this._minimumRequiredState._requiredState);
					}
					return num;
				}
			}

			// Token: 0x0400000B RID: 11
			internal readonly TCommandId _command;

			// Token: 0x0400000C RID: 12
			internal global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.CommandDefinition _minimumRequiredState;

			// Token: 0x0400000D RID: 13
			internal readonly long _disallowedState;

			// Token: 0x0400000E RID: 14
			internal readonly long _requiredState;

			// Token: 0x0400000F RID: 15
			internal readonly global::Infragistics.Controls.Primitives.CommandsHelper<TCommandId>.KeyGesture[] _keyGestures;

			// Token: 0x04000010 RID: 16
			internal readonly global::System.Windows.Input.ModifierKeys _disallowedModifierKeys;
		}
	}
}
