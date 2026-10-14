using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Commands
{
	// Token: 0x0200012B RID: 299
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public abstract class Commands<T> : global::Infragistics.Windows.Commands.CommandsBase where T : global::Infragistics.Windows.Commands.ICommandHost
	{
		// Token: 0x06000B1D RID: 2845 RVA: 0x00025018 File Offset: 0x00023218
		public static global::Infragistics.Windows.Commands.CommandWrapper[] FindCommandWrappers(global::System.Windows.Input.RoutedCommand commandToFind)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.Commands.CommandWrapper> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Commands.CommandWrapper>(3);
			foreach (global::Infragistics.Windows.Commands.CommandWrapper commandWrapper in global::Infragistics.Windows.Commands.Commands<T>.CommandWrappersInternal)
			{
				if (commandWrapper.Command == commandToFind)
				{
					list.Add(commandWrapper);
				}
			}
			if (list.Count > 0)
			{
				return list.ToArray();
			}
			return null;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00025068 File Offset: 0x00023268
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static void Initialize(global::Infragistics.Windows.Commands.CommandWrapper[] commandWrappers)
		{
			global::Infragistics.Windows.Commands.Commands<T>.CommandWrappersInternal = commandWrappers;
			foreach (global::Infragistics.Windows.Commands.CommandWrapper commandWrapper in commandWrappers)
			{
				global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(T), new global::System.Windows.Input.CommandBinding(commandWrapper.Command, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.Commands.Commands<T>.OnCommand), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.Commands.Commands<T>.OnQueryCommand)));
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x000250C1 File Offset: 0x000232C1
		public static bool IsCommandAllowed(global::Infragistics.Windows.Commands.ICommandHost commandHost, global::System.Windows.Input.RoutedCommand command)
		{
			return global::Infragistics.Windows.Commands.Commands<T>.IsCommandAllowed(commandHost, command, null);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x000250CB File Offset: 0x000232CB
		public static bool IsCommandAllowed(global::Infragistics.Windows.Commands.ICommandHost commandHost, global::System.Windows.Input.RoutedCommand command, object commandParameter)
		{
			return global::Infragistics.Windows.Commands.Commands<T>.IsCommandAllowed(commandHost, command, commandParameter, null);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x000250D8 File Offset: 0x000232D8
		public static bool IsCommandAllowed(global::Infragistics.Windows.Commands.ICommandHost commandHost, global::System.Windows.Input.RoutedCommand command, object commandParameter, object originalSource)
		{
			bool flag;
			return global::Infragistics.Windows.Commands.Commands<T>.IsCommandAllowed(commandHost, command, commandParameter, originalSource, out flag);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x000250F0 File Offset: 0x000232F0
		public static bool IsCommandAllowed(global::Infragistics.Windows.Commands.ICommandHost commandHost, global::System.Windows.Input.RoutedCommand command, object commandParameter, object originalSource, out bool continueRouting)
		{
			bool flag;
			return global::Infragistics.Windows.Commands.Commands<T>.IsCommandAllowed(commandHost, command, commandParameter, originalSource, out continueRouting, out flag);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0002510C File Offset: 0x0002330C
		internal static bool IsCommandAllowed(global::Infragistics.Windows.Commands.ICommandHost commandHost, global::System.Windows.Input.RoutedCommand command, object commandParameter, object originalSource, out bool continueRouting, out bool forceHandled)
		{
			continueRouting = false;
			forceHandled = false;
			if (command == null)
			{
				throw new global::System.ArgumentNullException("command");
			}
			if (commandHost == null)
			{
				throw new global::System.ArgumentNullException("commandHost");
			}
			if (command is global::Infragistics.Windows.Commands.ICommandEx && !global::Infragistics.Windows.Commands.CommandUtilities.IsMinimumStatePresent(commandHost, command, out forceHandled))
			{
				return false;
			}
			global::Infragistics.Windows.Commands.ExecuteCommandInfo executeCommandInfo = new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command, commandParameter, originalSource, continueRouting);
			bool result = commandHost.CanExecute(executeCommandInfo);
			continueRouting = executeCommandInfo.ContinueRouting;
			forceHandled = executeCommandInfo.ForceHandled;
			return result;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00025179 File Offset: 0x00023379
		public static bool IsMinimumStatePresentForCommand(global::Infragistics.Windows.Commands.ICommandHost commandHost, global::System.Windows.Input.RoutedCommand command)
		{
			if (command == null)
			{
				throw new global::System.ArgumentNullException("command");
			}
			if (commandHost == null)
			{
				throw new global::System.ArgumentNullException("commandHost");
			}
			return global::Infragistics.Windows.Commands.CommandUtilities.IsMinimumStatePresent(commandHost, command);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000251A0 File Offset: 0x000233A0
		public override bool ProcessKeyboardInput(global::System.Windows.Input.KeyEventArgs e, global::Infragistics.Windows.Commands.ICommandHost commandHost)
		{
			global::System.Windows.Input.Key key = e.Key;
			switch (key)
			{
			case global::System.Windows.Input.Key.LWin:
			case global::System.Windows.Input.Key.RWin:
				break;
			default:
				switch (key)
				{
				case global::System.Windows.Input.Key.LeftShift:
				case global::System.Windows.Input.Key.RightShift:
				case global::System.Windows.Input.Key.LeftCtrl:
				case global::System.Windows.Input.Key.RightCtrl:
				case global::System.Windows.Input.Key.LeftAlt:
				case global::System.Windows.Input.Key.RightAlt:
					break;
				default:
				{
					global::System.Windows.Input.ModifierKeys modifiers = global::System.Windows.Input.Keyboard.Modifiers;
					bool result = false;
					global::System.Collections.Generic.List<global::Infragistics.Windows.Commands.CommandWrapper> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Commands.CommandWrapper>();
					global::Infragistics.Windows.Commands.CommandWrapper[] commandWrappersInternal = global::Infragistics.Windows.Commands.Commands<T>.CommandWrappersInternal;
					if (commandWrappersInternal != null)
					{
						foreach (global::Infragistics.Windows.Commands.CommandWrapper commandWrapper in commandWrappersInternal)
						{
							if (commandWrapper != null && commandWrapper.HasInputGestures)
							{
								foreach (object obj in commandWrapper.InputGestures)
								{
									global::System.Windows.Input.InputGesture inputGesture = (global::System.Windows.Input.InputGesture)obj;
									if (inputGesture.Matches(commandHost, e))
									{
										if ((commandWrapper.ModifierKeysDisallowed & modifiers) == global::System.Windows.Input.ModifierKeys.None)
										{
											list.Add(commandWrapper);
											break;
										}
										break;
									}
								}
							}
						}
					}
					int num = (list != null) ? list.Count : 0;
					if (num > 0)
					{
						long num2 = 0L;
						for (int j = 0; j < num; j++)
						{
							global::Infragistics.Windows.Commands.CommandWrapper commandWrapper2 = list[j];
							num2 |= commandWrapper2.StateRequired;
							num2 |= commandWrapper2.StateDisallowed;
						}
						long currentState = commandHost.GetCurrentState(num2);
						for (int k = 0; k < num; k++)
						{
							global::Infragistics.Windows.Commands.CommandWrapper commandWrapper3 = list[k];
							if (commandWrapper3.IsAllowed(currentState))
							{
								global::System.Windows.Input.RoutedCommand command = commandWrapper3.Command;
								object keyboardParameter = this.GetKeyboardParameter(commandHost, command, e);
								bool lastCommandExecuted = global::Infragistics.Windows.Commands.Commands<T>._lastCommandExecuted;
								global::Infragistics.Windows.Commands.Commands<T>._lastCommandExecuted = false;
								try
								{
									command.Execute(keyboardParameter, commandHost as global::System.Windows.IInputElement);
									if (global::Infragistics.Windows.Commands.Commands<T>._lastCommandExecuted)
									{
										result = true;
									}
								}
								finally
								{
									global::Infragistics.Windows.Commands.Commands<T>._lastCommandExecuted = lastCommandExecuted;
								}
							}
						}
					}
					return result;
				}
				}
				break;
			}
			return false;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00025368 File Offset: 0x00023568
		private static void OnCommand(object target, global::System.Windows.Input.ExecutedRoutedEventArgs args)
		{
			global::Infragistics.Windows.Commands.ICommandHost commandHost = target as global::Infragistics.Windows.Commands.ICommandHost;
			if (commandHost != null)
			{
				global::Infragistics.Windows.Commands.ExecuteCommandInfo executeCommandInfo = new global::Infragistics.Windows.Commands.ExecuteCommandInfo(args.Command, args.Parameter, args.OriginalSource);
				args.Handled = (commandHost.Execute(executeCommandInfo) || executeCommandInfo.ForceHandled);
			}
			global::Infragistics.Windows.Commands.Commands<T>._lastCommandExecuted = args.Handled;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x000253BC File Offset: 0x000235BC
		private static void OnQueryCommand(object target, global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			global::Infragistics.Windows.Commands.ICommandHost commandHost = target as global::Infragistics.Windows.Commands.ICommandHost;
			global::System.Windows.Input.RoutedCommand routedCommand = args.Command as global::System.Windows.Input.RoutedCommand;
			if (commandHost == null || routedCommand == null)
			{
				args.CanExecute = false;
				return;
			}
			bool continueRouting;
			bool flag;
			if (global::Infragistics.Windows.Commands.Commands<T>.IsCommandAllowed(commandHost, routedCommand, args.Parameter, args.OriginalSource, out continueRouting, out flag))
			{
				args.CanExecute = true;
				args.Handled = true;
				args.ContinueRouting = continueRouting;
				return;
			}
			args.ContinueRouting = continueRouting;
			if (flag)
			{
				args.Handled = true;
			}
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0002542A File Offset: 0x0002362A
		protected virtual object GetKeyboardParameter(global::Infragistics.Windows.Commands.ICommandHost commandHost, global::System.Windows.Input.RoutedCommand command, global::System.Windows.Input.KeyEventArgs keyArgs)
		{
			return null;
		}

		// Token: 0x040004B0 RID: 1200
		private static global::Infragistics.Windows.Commands.CommandWrapper[] CommandWrappersInternal;

		// Token: 0x040004B1 RID: 1201
		[global::System.ThreadStatic]
		private static bool _lastCommandExecuted = false;
	}
}
