using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers.DataPresenter;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002DA RID: 730
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupByAreaFieldListBox : global::System.Windows.Controls.ListBox
	{
		// Token: 0x060022F7 RID: 8951 RVA: 0x00098A31 File Offset: 0x00096C31
		static GroupByAreaFieldListBox()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldListBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldListBox)));
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00098A56 File Offset: 0x00096C56
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return false;
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00098A59 File Offset: 0x00096C59
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaFieldListBoxAutomationPeer(this);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00098A64 File Offset: 0x00096C64
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
