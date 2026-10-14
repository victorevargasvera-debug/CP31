using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000E6 RID: 230
	public class SimpleTextBlockAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IValueProvider
	{
		// Token: 0x0600082E RID: 2094 RVA: 0x0001BEEF File Offset: 0x0001A0EF
		public SimpleTextBlockAutomationPeer(global::Infragistics.Windows.Controls.SimpleTextBlock owner) : base(owner)
		{
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		bool global::System.Windows.Automation.Provider.IValueProvider.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0001BEFB File Offset: 0x0001A0FB
		void global::System.Windows.Automation.Provider.IValueProvider.SetValue(string value)
		{
			throw new global::System.Windows.Automation.ElementNotEnabledException();
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0001BF04 File Offset: 0x0001A104
		string global::System.Windows.Automation.Provider.IValueProvider.Value
		{
			get
			{
				global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)base.Owner;
				return simpleTextBlock.Text;
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0001BF23 File Offset: 0x0001A123
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Text;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0001BF27 File Offset: 0x0001A127
		protected override string GetClassNameCore()
		{
			return typeof(global::Infragistics.Windows.Controls.SimpleTextBlock).Name;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0001BF38 File Offset: 0x0001A138
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0001BF47 File Offset: 0x0001A147
		protected override bool IsContentElementCore()
		{
			return ((global::Infragistics.Windows.Controls.SimpleTextBlock)base.Owner).TemplatedParent == null;
		}
	}
}
