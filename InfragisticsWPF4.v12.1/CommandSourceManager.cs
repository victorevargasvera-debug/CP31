using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using Infragistics.Controls;

namespace Infragistics
{
	// Token: 0x020000AF RID: 175
	public static class CommandSourceManager
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00017D40 File Offset: 0x00015F40
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::System.WeakReference>> Commands
		{
			get
			{
				if (global::Infragistics.CommandSourceManager._commands == null)
				{
					global::Infragistics.CommandSourceManager._commands = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::System.WeakReference>>();
				}
				return global::Infragistics.CommandSourceManager._commands;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00017D58 File Offset: 0x00015F58
		private static global::System.Collections.Generic.List<global::System.WeakReference> CommandTargets
		{
			get
			{
				if (global::Infragistics.CommandSourceManager._commandTargets == null)
				{
					global::Infragistics.CommandSourceManager._commandTargets = new global::System.Collections.Generic.List<global::System.WeakReference>();
				}
				return global::Infragistics.CommandSourceManager._commandTargets;
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00017D70 File Offset: 0x00015F70
		public static void RegisterCommandTarget(global::Infragistics.ICommandTarget target)
		{
			global::Infragistics.CommandSourceManager.CommandTargets.Add(new global::System.WeakReference(target));
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00017D84 File Offset: 0x00015F84
		public static void UnregisterCommandTarget(global::Infragistics.ICommandTarget target)
		{
			global::System.Collections.Generic.List<global::System.WeakReference> commandTargets = global::Infragistics.CommandSourceManager.CommandTargets;
			for (int i = commandTargets.Count - 1; i >= 0; i--)
			{
				global::System.WeakReference weakReference = commandTargets[i];
				if (weakReference.Target == target)
				{
					commandTargets.RemoveAt(i);
				}
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00017DC4 File Offset: 0x00015FC4
		public static global::System.Collections.ObjectModel.Collection<global::Infragistics.ICommandTarget> GetTargets(global::System.Windows.Input.ICommand command)
		{
			global::System.Collections.ObjectModel.Collection<global::Infragistics.ICommandTarget> collection = new global::System.Collections.ObjectModel.Collection<global::Infragistics.ICommandTarget>();
			foreach (global::System.WeakReference weakReference in global::Infragistics.CommandSourceManager.CommandTargets)
			{
				if (weakReference.IsAlive)
				{
					global::Infragistics.ICommandTarget commandTarget = (global::Infragistics.ICommandTarget)weakReference.Target;
					if (commandTarget.SupportsCommand(command))
					{
						collection.Add(commandTarget);
					}
				}
			}
			return collection;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00017E3C File Offset: 0x0001603C
		public static void NotifyCanExecuteChanged(global::System.Type commandType)
		{
			global::System.Collections.Generic.List<global::System.WeakReference> list;
			if (global::Infragistics.CommandSourceManager.Commands.TryGetValue(commandType, out list))
			{
				foreach (global::System.WeakReference weakReference in list)
				{
					if (weakReference.IsAlive)
					{
						global::Infragistics.Controls.CommandSource commandSource = weakReference.Target as global::Infragistics.Controls.CommandSource;
						if (commandSource != null && commandSource.Command.GetType() == commandType)
						{
							commandSource.InvokeCommand(false);
						}
					}
				}
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00017EC4 File Offset: 0x000160C4
		internal static void RegisterCommandSource(global::Infragistics.Controls.CommandSource source, global::System.Windows.FrameworkElement elem)
		{
			global::System.Windows.Input.ICommand command = source.Command;
			if (command != null && !string.IsNullOrEmpty(source.EventName))
			{
				source.SourceElement = elem;
				global::System.Reflection.EventInfo @event = elem.GetType().GetEvent(source.EventName);
				if (!(@event != null))
				{
					throw new global::Infragistics.InvalidEventNameException(source.EventName, elem.GetType());
				}
				global::System.Action<object, global::System.EventArgs> action = new global::System.Action<object, global::System.EventArgs>(source.EventFired);
				source.EventHandler = global::System.Delegate.CreateDelegate(@event.EventHandlerType, source, action.Method);
				@event.AddEventHandler(elem, source.EventHandler);
				global::System.Type type = command.GetType();
				global::System.Collections.Generic.List<global::System.WeakReference> list;
				if (!global::Infragistics.CommandSourceManager.Commands.TryGetValue(type, out list))
				{
					list = new global::System.Collections.Generic.List<global::System.WeakReference>();
					global::Infragistics.CommandSourceManager.Commands.Add(type, list);
				}
				bool flag = false;
				foreach (global::System.WeakReference weakReference in list)
				{
					if (weakReference.IsAlive && weakReference.Target == source)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(new global::System.WeakReference(source));
				}
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00017FEC File Offset: 0x000161EC
		internal static void UnregisterCommandSource(global::Infragistics.Controls.CommandSource source)
		{
			global::System.Reflection.EventInfo @event = source.SourceElement.GetType().GetEvent(source.EventName);
			if (@event != null)
			{
				@event.RemoveEventHandler(source.SourceElement, source.EventHandler);
			}
			global::System.Type type = source.Command.GetType();
			global::System.Collections.Generic.List<global::System.WeakReference> list;
			if (global::Infragistics.CommandSourceManager.Commands.TryGetValue(type, out list))
			{
				int num = -1;
				foreach (global::System.WeakReference weakReference in list)
				{
					num++;
					if (weakReference.IsAlive && weakReference.Target == source)
					{
						break;
					}
				}
				if (num < list.Count)
				{
					list.RemoveAt(num);
				}
			}
			source.EventHandler = null;
			source.SourceElement = null;
		}

		// Token: 0x04000313 RID: 787
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.List<global::System.WeakReference> _commandTargets = new global::System.Collections.Generic.List<global::System.WeakReference>();

		// Token: 0x04000314 RID: 788
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::System.WeakReference>> _commands = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::System.WeakReference>>();
	}
}
