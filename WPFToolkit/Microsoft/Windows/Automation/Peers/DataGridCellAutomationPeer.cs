using System;
using System.Windows;
using System.Windows.Automation.Peers;
using Microsoft.Windows.Controls;
using MS.Internal;

namespace Microsoft.Windows.Automation.Peers
{
	// Token: 0x0200003C RID: 60
	public sealed class DataGridCellAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x00012FAA File Offset: 0x000111AA
		public DataGridCellAutomationPeer(global::Microsoft.Windows.Controls.DataGridCell owner) : base(owner)
		{
			if (owner == null)
			{
				throw new global::System.ArgumentNullException("owner");
			}
			this.UpdateEventSource();
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00012FC7 File Offset: 0x000111C7
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00012FCB File Offset: 0x000111CB
		protected override string GetClassNameCore()
		{
			return base.Owner.GetType().Name;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00012FE0 File Offset: 0x000111E0
		protected override bool IsOffscreenCore()
		{
			if (!base.Owner.IsVisible)
			{
				return true;
			}
			global::System.Windows.Rect rect = global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer.CalculateVisibleBoundingRect(base.Owner);
			return global::MS.Internal.DoubleUtil.AreClose(rect, global::System.Windows.Rect.Empty) || global::MS.Internal.DoubleUtil.AreClose(rect.Height, 0.0) || global::MS.Internal.DoubleUtil.AreClose(rect.Width, 0.0);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00013044 File Offset: 0x00011244
		private void UpdateEventSource()
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = (global::Microsoft.Windows.Controls.DataGridCell)base.Owner;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridCell.DataGridOwner;
			if (dataGridOwner != null)
			{
				global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer dataGridAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(dataGridOwner) as global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer;
				if (dataGridAutomationPeer != null)
				{
					global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer orCreateItemPeer = dataGridAutomationPeer.GetOrCreateItemPeer(dataGridCell.DataContext);
					if (orCreateItemPeer != null)
					{
						global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer orCreateCellItemPeer = orCreateItemPeer.GetOrCreateCellItemPeer(dataGridCell.Column);
						base.EventsSource = orCreateCellItemPeer;
					}
				}
			}
		}
	}
}
