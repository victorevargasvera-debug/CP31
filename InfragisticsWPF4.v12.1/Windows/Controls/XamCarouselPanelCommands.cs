using System;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000229 RID: 553
	public class XamCarouselPanelCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.XamCarouselPanel>
	{
		// Token: 0x06001707 RID: 5895 RVA: 0x0005A664 File Offset: 0x00058864
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

		// Token: 0x06001708 RID: 5896 RVA: 0x0005A6C8 File Offset: 0x000588C8
		static XamCarouselPanelCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.XamCarouselPanel>.Initialize(global::Infragistics.Windows.Controls.XamCarouselPanelCommands.GetCommandWrappers());
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0005A753 File Offset: 0x00058953
		public static void LoadCommands()
		{
		}

		// Token: 0x04000B32 RID: 2866
		public static readonly global::System.Windows.Input.RoutedCommand NavigateToNextItem = new global::Infragistics.Windows.Commands.IGRoutedCommand("NavigateToNextItem", typeof(global::Infragistics.Windows.Controls.XamCarouselPanelCommands), 0L, 1L);

		// Token: 0x04000B33 RID: 2867
		public static readonly global::System.Windows.Input.RoutedCommand NavigateToPreviousItem = new global::Infragistics.Windows.Commands.IGRoutedCommand("NavigateToPreviousItem", typeof(global::Infragistics.Windows.Controls.XamCarouselPanelCommands), 0L, 2L);

		// Token: 0x04000B34 RID: 2868
		public static readonly global::System.Windows.Input.RoutedCommand NavigateToNextPage = new global::Infragistics.Windows.Commands.IGRoutedCommand("NavigateToNextPage", typeof(global::Infragistics.Windows.Controls.XamCarouselPanelCommands), 0L, 4L);

		// Token: 0x04000B35 RID: 2869
		public static readonly global::System.Windows.Input.RoutedCommand NavigateToPreviousPage = new global::Infragistics.Windows.Commands.IGRoutedCommand("NavigateToPreviousPage", typeof(global::Infragistics.Windows.Controls.XamCarouselPanelCommands), 0L, 8L);
	}
}
