using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000023 RID: 35
	public class LabelPresenterAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00004BFC File Offset: 0x00002DFC
		public LabelPresenterAutomationPeer(global::Infragistics.Windows.DataPresenter.LabelPresenter owner) : base(owner)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004C05 File Offset: 0x00002E05
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.HeaderItem;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004C09 File Offset: 0x00002E09
		protected override string GetClassNameCore()
		{
			return "LabelPresenter";
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00004C10 File Offset: 0x00002E10
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Invoke)
			{
				global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = (global::Infragistics.Windows.DataPresenter.LabelPresenter)base.Owner;
				global::Infragistics.Windows.DataPresenter.Field field = labelPresenter.Field;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (field != null) ? field.Owner : null;
				if (fieldLayout != null && fieldLayout.LabelLocationResolved == global::Infragistics.Windows.DataPresenter.LabelLocation.InCells)
				{
					return this.PatternProvider;
				}
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004C5A File Offset: 0x00002E5A
		protected override bool IsEnabledCore()
		{
			return ((global::Infragistics.Windows.DataPresenter.LabelPresenter)base.Owner).Field != null && base.IsEnabledCore();
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00004C76 File Offset: 0x00002E76
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelPatternProvider PatternProvider
		{
			get
			{
				if (this._patternProvider == null)
				{
					this._patternProvider = new global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelPatternProvider(this);
				}
				return this._patternProvider;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00004C92 File Offset: 0x00002E92
		global::Infragistics.Windows.DataPresenter.Field global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer.Field
		{
			get
			{
				return ((global::Infragistics.Windows.DataPresenter.LabelPresenter)base.Owner).Field;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00004CA4 File Offset: 0x00002EA4
		global::Infragistics.Windows.DataPresenter.LabelPresenter global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer.Label
		{
			get
			{
				return base.Owner as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004CB1 File Offset: 0x00002EB1
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer.IsEnabled()
		{
			return base.IsEnabled();
		}

		// Token: 0x04000038 RID: 56
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelPatternProvider _patternProvider;
	}
}
