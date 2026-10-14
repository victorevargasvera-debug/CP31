using System;
using System.Windows.Input;

namespace Infragistics.Windows.Commands
{
	// Token: 0x0200010F RID: 271
	internal static class CommandUtilities
	{
		// Token: 0x06000A37 RID: 2615 RVA: 0x00021908 File Offset: 0x0001FB08
		internal static bool IsMinimumStatePresent(global::Infragistics.Windows.Commands.ICommandHost host, global::System.Windows.Input.RoutedCommand command)
		{
			bool flag;
			return global::Infragistics.Windows.Commands.CommandUtilities.IsMinimumStatePresent(host, command, out flag);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00021920 File Offset: 0x0001FB20
		internal static bool IsMinimumStatePresent(global::Infragistics.Windows.Commands.ICommandHost host, global::System.Windows.Input.RoutedCommand command, out bool forceHandled)
		{
			return global::Infragistics.Windows.Commands.CommandUtilities.IsMinimumStatePresent(host, null, command, out forceHandled);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00021940 File Offset: 0x0001FB40
		internal static bool IsMinimumStatePresent(long state, global::System.Windows.Input.RoutedCommand command)
		{
			bool flag;
			return global::Infragistics.Windows.Commands.CommandUtilities.IsMinimumStatePresent(state, command, out flag);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00021956 File Offset: 0x0001FB56
		internal static bool IsMinimumStatePresent(long state, global::System.Windows.Input.RoutedCommand command, out bool forceHandled)
		{
			return global::Infragistics.Windows.Commands.CommandUtilities.IsMinimumStatePresent(null, new long?(state), command, out forceHandled);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00021968 File Offset: 0x0001FB68
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
