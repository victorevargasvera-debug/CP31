using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x02000101 RID: 257
	public class PopupResizerBarAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.ITransformProvider
	{
		// Token: 0x06000907 RID: 2311 RVA: 0x0001F5E8 File Offset: 0x0001D7E8
		public PopupResizerBarAutomationPeer(global::Infragistics.Windows.Controls.PopupResizerBar owner) : base(owner)
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0001F5F1 File Offset: 0x0001D7F1
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0001F5F5 File Offset: 0x0001D7F5
		protected override string GetClassNameCore()
		{
			return "PopupResizerBar";
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0001F5FC File Offset: 0x0001D7FC
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Transform)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x0001F60C File Offset: 0x0001D80C
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanMove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0001F60F File Offset: 0x0001D80F
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanResize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0001F612 File Offset: 0x0001D812
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanRotate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0001F618 File Offset: 0x0001D818
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

		// Token: 0x0600090F RID: 2319 RVA: 0x0001F65F File Offset: 0x0001D85F
		void global::System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			throw new global::System.InvalidOperationException(global::SR.GetString("LE_CannotPerformAutomationOperation"));
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0001F67E File Offset: 0x0001D87E
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
