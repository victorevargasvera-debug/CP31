using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using Infragistics.Collections;
using Infragistics.Controls;

namespace Infragistics
{
	// Token: 0x020000C9 RID: 201
	public static class CommandSourceManager
	{
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x0001B490 File Offset: 0x00019690
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.ICollection<global::Infragistics.Controls.CommandSource>> Commands
		{
			get
			{
				if (global::Infragistics.CommandSourceManager._commands == null)
				{
					global::Infragistics.CommandSourceManager._commands = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.ICollection<global::Infragistics.Controls.CommandSource>>();
				}
				return global::Infragistics.CommandSourceManager._commands;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0001B4A8 File Offset: 0x000196A8
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

		// Token: 0x06000789 RID: 1929 RVA: 0x0001B4C0 File Offset: 0x000196C0
		public static void RegisterCommandTarget(global::Infragistics.ICommandTarget target)
		{
			global::Infragistics.CommandSourceManager.CommandTargets.Add(new global::System.WeakReference(target));
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0001B4D4 File Offset: 0x000196D4
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

		// Token: 0x0600078B RID: 1931 RVA: 0x0001B514 File Offset: 0x00019714
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

		// Token: 0x0600078C RID: 1932 RVA: 0x0001B58C File Offset: 0x0001978C
		public static void NotifyCanExecuteChanged(global::System.Type commandType)
		{
			global::System.Collections.Generic.ICollection<global::Infragistics.Controls.CommandSource> collection;
			if (global::Infragistics.CommandSourceManager.Commands.TryGetValue(commandType, out collection))
			{
				foreach (global::Infragistics.Controls.CommandSource commandSource in collection)
				{
					commandSource.InvokeCommand(false);
				}
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0001B5E4 File Offset: 0x000197E4
		internal static void RegisterCommandSource(global::Infragistics.Controls.CommandSource source, global::System.Windows.FrameworkElement elem)
		{
			global::System.Windows.Input.ICommand command = source.Command;
			if (command != null && !string.IsNullOrEmpty(source.EventName))
			{
				source.SourceElement = elem;
				source.SourceElements.Add(elem);
				global::System.Reflection.EventInfo @event = elem.GetType().GetEvent(source.EventName);
				if (!(@event != null))
				{
					throw new global::Infragistics.InvalidEventNameException(source.EventName, elem.GetType());
				}
				global::System.Action<object, global::System.EventArgs> action = new global::System.Action<object, global::System.EventArgs>(source.EventFired);
				source.EventHandler = global::System.Delegate.CreateDelegate(@event.EventHandlerType, source, action.Method);
				@event.AddEventHandler(elem, source.EventHandler);
				global::System.Type type = command.GetType();
				global::System.Collections.Generic.ICollection<global::Infragistics.Controls.CommandSource> collection;
				if (!global::Infragistics.CommandSourceManager.Commands.TryGetValue(type, out collection))
				{
					collection = (global::Infragistics.CommandSourceManager.Commands[type] = new global::Infragistics.Collections.WeakSet<global::Infragistics.Controls.CommandSource>());
				}
				collection.Add(source);
				if (collection.Count % 50 == 0)
				{
					((global::Infragistics.Collections.WeakSet<global::Infragistics.Controls.CommandSource>)collection).Compact();
				}
			}
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0001B6CC File Offset: 0x000198CC
		internal static void UnregisterCommandSource(global::Infragistics.Controls.CommandSource source)
		{
			foreach (global::System.Windows.FrameworkElement frameworkElement in source.SourceElements)
			{
				global::System.Reflection.EventInfo @event = frameworkElement.GetType().GetEvent(source.EventName);
				if (@event != null)
				{
					@event.RemoveEventHandler(frameworkElement, source.EventHandler);
				}
			}
			global::System.Windows.Input.ICommand command = source.Command;
			if (command != null)
			{
				global::System.Type type = command.GetType();
				global::System.Collections.Generic.ICollection<global::Infragistics.Controls.CommandSource> collection;
				if (global::Infragistics.CommandSourceManager.Commands.TryGetValue(type, out collection))
				{
					collection.Remove(source);
				}
			}
			source.EventHandler = null;
			source.SourceElement = null;
			source.SourceElements.Clear();
		}

		// Token: 0x040003B7 RID: 951
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.List<global::System.WeakReference> _commandTargets = new global::System.Collections.Generic.List<global::System.WeakReference>();

		// Token: 0x040003B8 RID: 952
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.ICollection<global::Infragistics.Controls.CommandSource>> _commands;
	}
}
