using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x02000109 RID: 265
	public class XamTabControlAutomationPeer : global::System.Windows.Automation.Peers.TabControlAutomationPeer, global::System.Windows.Automation.Provider.IExpandCollapseProvider
	{
		// Token: 0x06000955 RID: 2389 RVA: 0x000200A1 File Offset: 0x0001E2A1
		public XamTabControlAutomationPeer(global::Infragistics.Windows.Controls.XamTabControl tabControl) : base(tabControl)
		{
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x000200AA File Offset: 0x0001E2AA
		protected override global::System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item)
		{
			return new global::Infragistics.Windows.Automation.Peers.TabItemExAutomationPeer(item, this);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00020108 File Offset: 0x0001E308
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = base.GetChildrenCore();
			global::Infragistics.Windows.Controls.XamTabControl tc = (global::Infragistics.Windows.Controls.XamTabControl)base.Owner;
			tc.ApplyTemplate();
			global::System.Windows.FrameworkElement headerArea = tc.HeaderArea;
			if (headerArea != null)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> children = new global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer(headerArea).GetChildren();
				if (children != null)
				{
					global::System.Predicate<global::System.Windows.Automation.Peers.AutomationPeer> match = delegate(global::System.Windows.Automation.Peers.AutomationPeer peer)
					{
						global::System.Windows.Automation.Peers.UIElementAutomationPeer uielementAutomationPeer = peer as global::System.Windows.Automation.Peers.UIElementAutomationPeer;
						if (uielementAutomationPeer == null)
						{
							return true;
						}
						global::System.Windows.UIElement owner = uielementAutomationPeer.Owner;
						if (global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(owner) == tc)
						{
							return false;
						}
						global::System.Windows.Controls.ScrollViewer scrollViewer = owner as global::System.Windows.Controls.ScrollViewer;
						return scrollViewer == null || scrollViewer.TemplatedParent != tc;
					};
					global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list2 = children.FindAll(match);
					if (list == null)
					{
						list = list2;
					}
					else
					{
						list.AddRange(list2);
					}
				}
			}
			return list;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00020194 File Offset: 0x0001E394
		protected override string GetClassNameCore()
		{
			return "XamTabControl";
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0002019B File Offset: 0x0001E39B
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000201AC File Offset: 0x0001E3AC
		internal void RaiseExpandCollapseStateChanged()
		{
			if (this._lastReturnedExpandState != null && global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.PropertyChanged))
			{
				global::System.Windows.Automation.ExpandCollapseState expandCollapseState = ((global::System.Windows.Automation.Provider.IExpandCollapseProvider)this).ExpandCollapseState;
				if (expandCollapseState != this._lastReturnedExpandState.Value)
				{
					base.RaisePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty, this._lastReturnedExpandState.Value, expandCollapseState);
				}
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00020205 File Offset: 0x0001E405
		private void VerifyEnabled()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (!((global::Infragistics.Windows.Controls.XamTabControl)base.Owner).AllowMinimize)
			{
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0002022D File Offset: 0x0001E42D
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse()
		{
			this.VerifyEnabled();
			((global::Infragistics.Windows.Controls.XamTabControl)base.Owner).IsMinimized = true;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00020246 File Offset: 0x0001E446
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Expand()
		{
			this.VerifyEnabled();
			((global::Infragistics.Windows.Controls.XamTabControl)base.Owner).IsMinimized = false;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00020260 File Offset: 0x0001E460
		global::System.Windows.Automation.ExpandCollapseState global::System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState
		{
			get
			{
				if (((global::Infragistics.Windows.Controls.XamTabControl)base.Owner).AllowMinimize)
				{
					if (((global::Infragistics.Windows.Controls.XamTabControl)base.Owner).IsMinimized)
					{
						this._lastReturnedExpandState = new global::System.Windows.Automation.ExpandCollapseState?(global::System.Windows.Automation.ExpandCollapseState.Collapsed);
					}
					else
					{
						this._lastReturnedExpandState = new global::System.Windows.Automation.ExpandCollapseState?(global::System.Windows.Automation.ExpandCollapseState.Expanded);
					}
				}
				else
				{
					this._lastReturnedExpandState = new global::System.Windows.Automation.ExpandCollapseState?(global::System.Windows.Automation.ExpandCollapseState.LeafNode);
				}
				return this._lastReturnedExpandState.Value;
			}
		}

		// Token: 0x04000447 RID: 1095
		private global::System.Windows.Automation.ExpandCollapseState? _lastReturnedExpandState;
	}
}
