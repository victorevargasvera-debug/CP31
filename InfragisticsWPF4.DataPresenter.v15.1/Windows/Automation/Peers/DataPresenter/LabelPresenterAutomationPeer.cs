using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000023 RID: 35
	public class LabelPresenterAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00004C01 File Offset: 0x00002E01
		public LabelPresenterAutomationPeer(global::Infragistics.Windows.DataPresenter.LabelPresenter owner) : base(owner)
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004C0A File Offset: 0x00002E0A
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.HeaderItem;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004C0E File Offset: 0x00002E0E
		protected override string GetClassNameCore()
		{
			return "LabelPresenter";
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004C18 File Offset: 0x00002E18
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

		// Token: 0x06000104 RID: 260 RVA: 0x00004C62 File Offset: 0x00002E62
		protected override bool IsEnabledCore()
		{
			return ((global::Infragistics.Windows.DataPresenter.LabelPresenter)base.Owner).Field != null && base.IsEnabledCore();
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00004C7E File Offset: 0x00002E7E
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00004C9A File Offset: 0x00002E9A
		global::Infragistics.Windows.DataPresenter.Field global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer.Field
		{
			get
			{
				return ((global::Infragistics.Windows.DataPresenter.LabelPresenter)base.Owner).Field;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00004CAC File Offset: 0x00002EAC
		global::Infragistics.Windows.DataPresenter.LabelPresenter global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer.Label
		{
			get
			{
				return base.Owner as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004CB9 File Offset: 0x00002EB9
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer.IsEnabled()
		{
			return base.IsEnabled();
		}

		// Token: 0x04000046 RID: 70
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelPatternProvider _patternProvider;
	}
}
