using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers.Editors;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200003A RID: 58
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CalendarItemGroupTitle : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x0001141C File Offset: 0x0000F61C
		static CalendarItemGroupTitle()
		{
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupTitle), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupTitle), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupTitle)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupTitle), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentCenterBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupTitle), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentCenterBox));
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000114A6 File Offset: 0x0000F6A6
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.CalendarItemGroupTitleAutomationPeer(this);
		}
	}
}
