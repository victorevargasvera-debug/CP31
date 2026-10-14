using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000E3 RID: 227
	public class PopupResizerBarAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.ITransformProvider
	{
		// Token: 0x06000808 RID: 2056 RVA: 0x0001BA20 File Offset: 0x00019C20
		public PopupResizerBarAutomationPeer(global::Infragistics.Windows.Controls.PopupResizerBar owner) : base(owner)
		{
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0001BA29 File Offset: 0x00019C29
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0001BA2D File Offset: 0x00019C2D
		protected override string GetClassNameCore()
		{
			return "PopupResizerBar";
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0001BA34 File Offset: 0x00019C34
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Transform)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0001BA44 File Offset: 0x00019C44
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanMove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x0001BA47 File Offset: 0x00019C47
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanResize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x0001BA4A File Offset: 0x00019C4A
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanRotate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0001BA50 File Offset: 0x00019C50
		void global::System.Windows.Automation.Provider.ITransformProvider.Move(double x, double y)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (!((global::System.Windows.Automation.Provider.ITransformProvider)this).CanMove)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_CannotPerformAutomationOperation"));
			}
			global::Infragistics.Windows.Controls.PopupResizerBar popupResizerBar = (global::Infragistics.Windows.Controls.PopupResizerBar)base.Owner;
			popupResizerBar.PerformMove(x, y);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0001BA97 File Offset: 0x00019C97
		void global::System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			throw new global::System.InvalidOperationException(global::SR.GetString("LE_CannotPerformAutomationOperation"));
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0001BAB6 File Offset: 0x00019CB6
		void global::System.Windows.Automation.Provider.ITransformProvider.Rotate(double degrees)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			throw new global::System.InvalidOperationException(global::SR.GetString("LE_CannotPerformAutomationOperation"));
		}
	}
}
