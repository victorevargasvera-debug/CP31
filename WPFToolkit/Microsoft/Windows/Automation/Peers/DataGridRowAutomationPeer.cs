using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;
using Microsoft.Windows.Controls;
using Microsoft.Windows.Controls.Primitives;
using MS.Internal;

namespace Microsoft.Windows.Automation.Peers
{
	// Token: 0x02000040 RID: 64
	public sealed class DataGridRowAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x000130B6 File Offset: 0x000112B6
		public DataGridRowAutomationPeer(global::Microsoft.Windows.Controls.DataGridRow owner) : base(owner)
		{
			if (owner == null)
			{
				throw new global::System.ArgumentNullException("owner");
			}
			this.UpdateEventSource();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x000130D3 File Offset: 0x000112D3
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.DataItem;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x000130D7 File Offset: 0x000112D7
		protected override string GetClassNameCore()
		{
			return base.Owner.GetType().Name;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000130EC File Offset: 0x000112EC
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(3);
			global::System.Windows.Automation.Peers.AutomationPeer rowHeaderAutomationPeer = this.RowHeaderAutomationPeer;
			if (rowHeaderAutomationPeer != null)
			{
				list.Add(rowHeaderAutomationPeer);
			}
			global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer dataGridItemAutomationPeer = base.EventsSource as global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer;
			if (dataGridItemAutomationPeer != null)
			{
				list.AddRange(dataGridItemAutomationPeer.GetCellItemPeers());
			}
			global::System.Windows.Automation.Peers.AutomationPeer detailsPresenterAutomationPeer = this.DetailsPresenterAutomationPeer;
			if (detailsPresenterAutomationPeer != null)
			{
				list.Add(detailsPresenterAutomationPeer);
			}
			return list;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00013140 File Offset: 0x00011340
		protected override bool IsOffscreenCore()
		{
			if (!base.Owner.IsVisible)
			{
				return true;
			}
			global::System.Windows.Rect rect = global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer.CalculateVisibleBoundingRect(base.Owner);
			return global::MS.Internal.DoubleUtil.AreClose(rect, global::System.Windows.Rect.Empty) || global::MS.Internal.DoubleUtil.AreClose(rect.Height, 0.0) || global::MS.Internal.DoubleUtil.AreClose(rect.Width, 0.0);
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x000131A4 File Offset: 0x000113A4
		internal global::System.Windows.Automation.Peers.AutomationPeer RowHeaderAutomationPeer
		{
			get
			{
				global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader rowHeader = this.OwningDataGridRow.RowHeader;
				if (rowHeader != null)
				{
					return global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(rowHeader);
				}
				return null;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000131C8 File Offset: 0x000113C8
		private global::System.Windows.Automation.Peers.AutomationPeer DetailsPresenterAutomationPeer
		{
			get
			{
				global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter detailsPresenter = this.OwningDataGridRow.DetailsPresenter;
				if (detailsPresenter != null)
				{
					return global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(detailsPresenter);
				}
				return null;
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000131EC File Offset: 0x000113EC
		internal void UpdateEventSource()
		{
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.OwningDataGridRow.DataGridOwner;
			if (dataGridOwner != null)
			{
				global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer dataGridAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(dataGridOwner) as global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer;
				if (dataGridAutomationPeer != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer orCreateItemPeer = dataGridAutomationPeer.GetOrCreateItemPeer(this.OwningDataGridRow.Item);
					if (orCreateItemPeer != null)
					{
						base.EventsSource = orCreateItemPeer;
					}
				}
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00013233 File Offset: 0x00011433
		private global::Microsoft.Windows.Controls.DataGridRow OwningDataGridRow
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGridRow)base.Owner;
			}
		}
	}
}
