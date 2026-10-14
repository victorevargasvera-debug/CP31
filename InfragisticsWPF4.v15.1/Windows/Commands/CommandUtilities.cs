using System;
using System.Windows.Input;

namespace Infragistics.Windows.Commands
{
	// Token: 0x0200012D RID: 301
	internal static class CommandUtilities
	{
		// Token: 0x06000B36 RID: 2870 RVA: 0x000254D0 File Offset: 0x000236D0
		internal static bool IsMinimumStatePresent(global::Infragistics.Windows.Commands.ICommandHost host, global::System.Windows.Input.RoutedCommand command)
		{
			bool flag;
			return global::Infragistics.Windows.Commands.CommandUtilities.IsMinimumStatePresent(host, command, out flag);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x000254E8 File Offset: 0x000236E8
		internal static bool IsMinimumStatePresent(global::Infragistics.Windows.Commands.ICommandHost host, global::System.Windows.Input.RoutedCommand command, out bool forceHandled)
		{
			return global::Infragistics.Windows.Commands.CommandUtilities.IsMinimumStatePresent(host, null, command, out forceHandled);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00025508 File Offset: 0x00023708
		internal static bool IsMinimumStatePresent(long state, global::System.Windows.Input.RoutedCommand command)
		{
			bool flag;
			return global::Infragistics.Windows.Commands.CommandUtilities.IsMinimumStatePresent(state, command, out flag);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0002551E File Offset: 0x0002371E
		internal static bool IsMinimumStatePresent(long state, global::System.Windows.Input.RoutedCommand command, out bool forceHandled)
		{
			return global::Infragistics.Windows.Commands.CommandUtilities.IsMinimumStatePresent(null, new long?(state), command, out forceHandled);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00025530 File Offset: 0x00023730
		private static bool IsMinimumStatePresent(global::Infragistics.Windows.Commands.ICommandHost host, long? hostState, global::System.Windows.Input.RoutedCommand command, out bool forceHandled)
		{
			global::Infragistics.Windows.Commands.ICommandEx commandEx = command as global::Infragistics.Windows.Commands.ICommandEx;
			if (commandEx == null)
			{
				forceHandled = false;
				return true;
			}
			long minimumStateRequired = commandEx.MinimumStateRequired;
			long minimumStateDisallowed = commandEx.MinimumStateDisallowed;
			forceHandled = commandEx.ForceHandled;
			long num = (hostState != null) ? hostState.Value : ((host != null) ? host.GetCurrentState(minimumStateRequired | minimumStateDisallowed) : 0L);
			return (num & minimumStateRequired) == minimumStateRequired && 0L == (num & minimumStateDisallowed);
		}
	}
}
