using System;
using System.Data;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200002E RID: 46
	public class SummaryResultPresenterAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IValueProvider
	{
		// Token: 0x060001AE RID: 430 RVA: 0x00007118 File Offset: 0x00005318
		public SummaryResultPresenterAutomationPeer(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter owner) : base(owner)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00007121 File Offset: 0x00005321
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00007128 File Offset: 0x00005328
		protected override string GetClassNameCore()
		{
			string text = base.GetClassNameCore();
			if (string.IsNullOrEmpty(text))
			{
				global::Infragistics.Windows.DataPresenter.SummaryResultPresenter summaryResultPresenter = base.Owner as global::Infragistics.Windows.DataPresenter.SummaryResultPresenter;
				global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult = (summaryResultPresenter != null) ? summaryResultPresenter.SummaryResult : null;
				if (summaryResult != null)
				{
					global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = summaryResult.SummaryDefinition;
					if (summaryResult.SourceField != null && summaryDefinition.Calculator != null)
					{
						text = string.Format("FieldName={0}, Calculator={1}", summaryResult.SourceField.Name, summaryDefinition.Calculator.Name);
					}
					else
					{
						text = string.Format("Key={0}", summaryDefinition.Key);
					}
				}
			}
			return text;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000071AC File Offset: 0x000053AC
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text))
			{
				text = ((global::System.Windows.Automation.Provider.IValueProvider)this).Value;
			}
			return text;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000071D0 File Offset: 0x000053D0
		bool global::System.Windows.Automation.Provider.IValueProvider.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000071D3 File Offset: 0x000053D3
		void global::System.Windows.Automation.Provider.IValueProvider.SetValue(string value)
		{
			throw new global::System.Data.ReadOnlyException();
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000071DC File Offset: 0x000053DC
		string global::System.Windows.Automation.Provider.IValueProvider.Value
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.SummaryResultPresenter summaryResultPresenter = base.Owner as global::Infragistics.Windows.DataPresenter.SummaryResultPresenter;
				if (summaryResultPresenter == null)
				{
					return null;
				}
				return summaryResultPresenter.SummaryResult.DisplayText;
			}
		}
	}
}
