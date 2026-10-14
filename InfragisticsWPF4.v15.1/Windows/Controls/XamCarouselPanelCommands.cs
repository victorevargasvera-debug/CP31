using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200025E RID: 606
	public class XamCarouselPanelCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.XamCarouselPanel>
	{
		// Token: 0x06001907 RID: 6407 RVA: 0x000610AC File Offset: 0x0005F2AC
		private static global::Infragistics.Windows.Commands.CommandWrapper[] GetCommandWrappers()
		{
			return new global::Infragistics.Windows.Commands.CommandWrapper[]
			{
				new global::Infragistics.Windows.Commands.CommandWrapper((global::Infragistics.Windows.Commands.IGRoutedCommand)global::Infragistics.Windows.Controls.XamCarouselPanelCommands.NavigateToNextItem, null),
				new global::Infragistics.Windows.Commands.CommandWrapper((global::Infragistics.Windows.Commands.IGRoutedCommand)global::Infragistics.Windows.Controls.XamCarouselPanelCommands.NavigateToNextPage, null),
				new global::Infragistics.Windows.Commands.CommandWrapper((global::Infragistics.Windows.Commands.IGRoutedCommand)global::Infragistics.Windows.Controls.XamCarouselPanelCommands.NavigateToPreviousItem, null),
				new global::Infragistics.Windows.Commands.CommandWrapper((global::Infragistics.Windows.Commands.IGRoutedCommand)global::Infragistics.Windows.Controls.XamCarouselPanelCommands.NavigateToPreviousPage, null)
			};
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00061110 File Offset: 0x0005F310
		static XamCarouselPanelCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.XamCarouselPanel>.Initialize(global::Infragistics.Windows.Controls.XamCarouselPanelCommands.GetCommandWrappers());
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x0006119B File Offset: 0x0005F39B
		public static void LoadCommands()
		{
		}

		// Token: 0x04000C94 RID: 3220
		public static readonly global::System.Windows.Input.RoutedCommand NavigateToNextItem = new global::Infragistics.Windows.Commands.IGRoutedCommand("NavigateToNextItem", typeof(global::Infragistics.Windows.Controls.XamCarouselPanelCommands), 0L, 1L);

		// Token: 0x04000C95 RID: 3221
		public static readonly global::System.Windows.Input.RoutedCommand NavigateToPreviousItem = new global::Infragistics.Windows.Commands.IGRoutedCommand("NavigateToPreviousItem", typeof(global::Infragistics.Windows.Controls.XamCarouselPanelCommands), 0L, 2L);

		// Token: 0x04000C96 RID: 3222
		public static readonly global::System.Windows.Input.RoutedCommand NavigateToNextPage = new global::Infragistics.Windows.Commands.IGRoutedCommand("NavigateToNextPage", typeof(global::Infragistics.Windows.Controls.XamCarouselPanelCommands), 0L, 4L);

		// Token: 0x04000C97 RID: 3223
		public static readonly global::System.Windows.Input.RoutedCommand NavigateToPreviousPage = new global::Infragistics.Windows.Commands.IGRoutedCommand("NavigateToPreviousPage", typeof(global::Infragistics.Windows.Controls.XamCarouselPanelCommands), 0L, 8L);
	}
}
