using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers.DataPresenter;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000319 RID: 793
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupByAreaFieldListBox : global::System.Windows.Controls.ListBox
	{
		// Token: 0x06002696 RID: 9878 RVA: 0x000AC2BD File Offset: 0x000AA4BD
		static GroupByAreaFieldListBox()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldListBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldListBox)));
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x000AC2E2 File Offset: 0x000AA4E2
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return false;
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x000AC2E5 File Offset: 0x000AA4E5
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaFieldListBoxAutomationPeer(this);
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x000AC2F0 File Offset: 0x000AA4F0
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);
			if (item is global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel && element is global::System.Windows.FrameworkElement && ((global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel)item).Field != null)
			{
				((global::System.Windows.FrameworkElement)element).SetValue(global::System.Windows.Automation.AutomationProperties.NameProperty, ((global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel)item).Field.Name);
			}
		}
	}
}
