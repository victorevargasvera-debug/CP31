using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Interop;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x02000106 RID: 262
	public class ToolWindowAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.ITransformProvider
	{
		// Token: 0x06000937 RID: 2359 RVA: 0x0001FBBD File Offset: 0x0001DDBD
		public ToolWindowAutomationPeer(global::Infragistics.Windows.Controls.ToolWindow owner) : base(owner)
		{
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0001FBC6 File Offset: 0x0001DDC6
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0001FBCA File Offset: 0x0001DDCA
		protected override string GetClassNameCore()
		{
			return "ToolWindow";
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0001FBD1 File Offset: 0x0001DDD1
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

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanMove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0001FBF4 File Offset: 0x0001DDF4
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

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0001FC29 File Offset: 0x0001DE29
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanRotate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0001FC2C File Offset: 0x0001DE2C
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

		// Token: 0x0600093F RID: 2367 RVA: 0x0001FCA0 File Offset: 0x0001DEA0
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

		// Token: 0x06000940 RID: 2368 RVA: 0x0001FD13 File Offset: 0x0001DF13
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
