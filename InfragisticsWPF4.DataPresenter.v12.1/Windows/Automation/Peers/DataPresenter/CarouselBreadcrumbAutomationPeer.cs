using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000010 RID: 16
	public class CarouselBreadcrumbAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IInvokeProvider
	{
		// Token: 0x06000063 RID: 99 RVA: 0x000036E1 File Offset: 0x000018E1
		public CarouselBreadcrumbAutomationPeer(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb owner) : base(owner)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000036EA File Offset: 0x000018EA
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Hyperlink;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000036ED File Offset: 0x000018ED
		protected override string GetClassNameCore()
		{
			return "CarouselBreadcrumb";
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000036F4 File Offset: 0x000018F4
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Invoke)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003702 File Offset: 0x00001902
		void global::System.Windows.Automation.Provider.IInvokeProvider.Invoke()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			((global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb)base.Owner).OnCarouselBreadcrumbClick();
		}
	}
}
