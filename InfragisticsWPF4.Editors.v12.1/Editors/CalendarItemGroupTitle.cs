using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers.Editors;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000037 RID: 55
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CalendarItemGroupTitle : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x0001075C File Offset: 0x0000E95C
		static CalendarItemGroupTitle()
		{
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupTitle), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupTitle), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupTitle)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupTitle), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentCenterBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroupTitle), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentCenterBox));
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000107E6 File Offset: 0x0000E9E6
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.CalendarItemGroupTitleAutomationPeer(this);
		}
	}
}
