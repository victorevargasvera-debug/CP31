using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Interop;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000E8 RID: 232
	public class ToolWindowAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.ITransformProvider
	{
		// Token: 0x06000838 RID: 2104 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
		public ToolWindowAutomationPeer(global::Infragistics.Windows.Controls.ToolWindow owner) : base(owner)
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0001BFFD File Offset: 0x0001A1FD
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0001C001 File Offset: 0x0001A201
		protected override string GetClassNameCore()
		{
			return "ToolWindow";
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0001C008 File Offset: 0x0001A208
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface != global::System.Windows.Automation.Peers.PatternInterface.Transform)
			{
				return base.GetPattern(patternInterface);
			}
			if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				return base.GetPattern(patternInterface);
			}
			return this;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x0001C027 File Offset: 0x0001A227
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanMove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0001C02C File Offset: 0x0001A22C
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanResize
		{
			get
			{
				switch (((global::Infragistics.Windows.Controls.ToolWindow)base.Owner).ResizeMode)
				{
				case global::System.Windows.ResizeMode.CanResize:
				case global::System.Windows.ResizeMode.CanResizeWithGrip:
					return true;
				default:
					return false;
				}
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x0001C061 File Offset: 0x0001A261
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanRotate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0001C064 File Offset: 0x0001A264
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
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Owner as global::Infragistics.Windows.Controls.ToolWindow;
			if (double.IsInfinity(x))
			{
				throw new global::System.ArgumentOutOfRangeException("x");
			}
			if (double.IsInfinity(y))
			{
				throw new global::System.ArgumentOutOfRangeException("y");
			}
			toolWindow.Left = x;
			toolWindow.Top = y;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
		void global::System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (!((global::System.Windows.Automation.Provider.ITransformProvider)this).CanResize)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_CannotPerformAutomationOperation"));
			}
			if (double.IsInfinity(width))
			{
				throw new global::System.ArgumentOutOfRangeException("width");
			}
			if (double.IsInfinity(height))
			{
				throw new global::System.ArgumentOutOfRangeException("height");
			}
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Owner as global::Infragistics.Windows.Controls.ToolWindow;
			toolWindow.Width = width;
			toolWindow.Height = height;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0001C14B File Offset: 0x0001A34B
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
