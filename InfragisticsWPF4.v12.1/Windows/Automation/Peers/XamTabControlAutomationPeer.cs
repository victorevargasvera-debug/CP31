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
	// Token: 0x020000EB RID: 235
	public class XamTabControlAutomationPeer : global::System.Windows.Automation.Peers.TabControlAutomationPeer, global::System.Windows.Automation.Provider.IExpandCollapseProvider
	{
		// Token: 0x06000856 RID: 2134 RVA: 0x0001C4D9 File Offset: 0x0001A6D9
		public XamTabControlAutomationPeer(global::Infragistics.Windows.Controls.XamTabControl tabControl) : base(tabControl)
		{
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0001C4E2 File Offset: 0x0001A6E2
		protected override global::System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item)
		{
			return new global::Infragistics.Windows.Automation.Peers.TabItemExAutomationPeer(item, this);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0001C540 File Offset: 0x0001A740
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = base.GetChildrenCore();
			global::Infragistics.Windows.Controls.XamTabControl tc = (global::Infragistics.Windows.Controls.XamTabControl)base.Owner;
			tc.UpdateLayout();
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

		// Token: 0x06000859 RID: 2137 RVA: 0x0001C5CB File Offset: 0x0001A7CB
		protected override string GetClassNameCore()
		{
			return "XamTabControl";
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0001C5D2 File Offset: 0x0001A7D2
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0001C5E4 File Offset: 0x0001A7E4
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

		// Token: 0x0600085C RID: 2140 RVA: 0x0001C63D File Offset: 0x0001A83D
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

		// Token: 0x0600085D RID: 2141 RVA: 0x0001C665 File Offset: 0x0001A865
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse()
		{
			this.VerifyEnabled();
			((global::Infragistics.Windows.Controls.XamTabControl)base.Owner).IsMinimized = true;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0001C67E File Offset: 0x0001A87E
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Expand()
		{
			this.VerifyEnabled();
			((global::Infragistics.Windows.Controls.XamTabControl)base.Owner).IsMinimized = false;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0001C698 File Offset: 0x0001A898
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

		// Token: 0x04000394 RID: 916
		private global::System.Windows.Automation.ExpandCollapseState? _lastReturnedExpandState;
	}
}
