using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x02000104 RID: 260
	public class SimpleTextBlockAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IValueProvider
	{
		// Token: 0x0600092D RID: 2349 RVA: 0x0001FAB7 File Offset: 0x0001DCB7
		public SimpleTextBlockAutomationPeer(global::Infragistics.Windows.Controls.SimpleTextBlock owner) : base(owner)
		{
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0001FAC0 File Offset: 0x0001DCC0
		bool global::System.Windows.Automation.Provider.IValueProvider.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0001FAC3 File Offset: 0x0001DCC3
		void global::System.Windows.Automation.Provider.IValueProvider.SetValue(string value)
		{
			throw new global::System.Windows.Automation.ElementNotEnabledException();
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0001FACC File Offset: 0x0001DCCC
		string global::System.Windows.Automation.Provider.IValueProvider.Value
		{
			get
			{
				global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)base.Owner;
				return simpleTextBlock.Text;
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0001FAEB File Offset: 0x0001DCEB
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Text;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0001FAEF File Offset: 0x0001DCEF
		protected override string GetClassNameCore()
		{
			return typeof(global::Infragistics.Windows.Controls.SimpleTextBlock).Name;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0001FB00 File Offset: 0x0001DD00
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0001FB0F File Offset: 0x0001DD0F
		protected override bool IsContentElementCore()
		{
			return ((global::Infragistics.Windows.Controls.SimpleTextBlock)base.Owner).TemplatedParent == null;
		}
	}
}
