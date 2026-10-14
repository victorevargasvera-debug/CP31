using System;
using System.Windows.Automation;
using System.Windows.Automation.Provider;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000022 RID: 34
	internal class LabelPatternProvider : global::System.Windows.Automation.Provider.IInvokeProvider
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00004BA0 File Offset: 0x00002DA0
		internal LabelPatternProvider(global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer labelPeer)
		{
			this._labelPeer = labelPeer;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004BB0 File Offset: 0x00002DB0
		void global::System.Windows.Automation.Provider.IInvokeProvider.Invoke()
		{
			if (!this._labelPeer.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			global::Infragistics.Windows.DataPresenter.Field field = this._labelPeer.Field;
			if (field == null)
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			global::Infragistics.Windows.DataPresenter.LabelPresenter label = this._labelPeer.Label;
			if (label != null)
			{
				field.PerformLabelClickAction(label.IsInGroupByArea);
			}
		}

		// Token: 0x04000045 RID: 69
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer _labelPeer;
	}
}
