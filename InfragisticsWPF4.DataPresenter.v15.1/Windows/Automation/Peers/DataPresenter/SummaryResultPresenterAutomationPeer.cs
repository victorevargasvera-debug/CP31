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
		// Token: 0x060001C2 RID: 450 RVA: 0x0000753C File Offset: 0x0000573C
		public SummaryResultPresenterAutomationPeer(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter owner) : base(owner)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00007545 File Offset: 0x00005745
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000754C File Offset: 0x0000574C
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

		// Token: 0x060001C5 RID: 453 RVA: 0x000075D0 File Offset: 0x000057D0
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text))
			{
				text = ((global::System.Windows.Automation.Provider.IValueProvider)this).Value;
			}
			return text;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000075F4 File Offset: 0x000057F4
		bool global::System.Windows.Automation.Provider.IValueProvider.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000075F7 File Offset: 0x000057F7
		void global::System.Windows.Automation.Provider.IValueProvider.SetValue(string value)
		{
			throw new global::System.Data.ReadOnlyException();
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00007600 File Offset: 0x00005800
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
