using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.DockManager;

namespace Infragistics.Windows.Automation.Peers.DockManager
{
	// Token: 0x0200000F RID: 15
	public abstract class PaneSplitterAutomationPeer : global::System.Windows.Automation.Peers.ThumbAutomationPeer, global::System.Windows.Automation.Provider.ITransformProvider
	{
		// Token: 0x06000093 RID: 147 RVA: 0x0000496C File Offset: 0x00002B6C
		protected PaneSplitterAutomationPeer(global::Infragistics.Windows.DockManager.PaneSplitter owner) : base(owner)
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004975 File Offset: 0x00002B75
		protected override string GetClassNameCore()
		{
			return "PaneSplitter";
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000497C File Offset: 0x00002B7C
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Transform)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000498C File Offset: 0x00002B8C
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanMove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000498F File Offset: 0x00002B8F
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanResize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00004992 File Offset: 0x00002B92
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanRotate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004998 File Offset: 0x00002B98
		void global::System.Windows.Automation.Provider.ITransformProvider.Move(double x, double y)
		{
			if (!((global::System.Windows.Automation.Provider.ITransformProvider)this).CanMove)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_CannotPerformAutomationOperation"));
			}
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (double.IsInfinity(x) || double.IsNaN(x))
			{
				throw new global::System.ArgumentOutOfRangeException("x");
			}
			if (double.IsInfinity(y) || double.IsNaN(y))
			{
				throw new global::System.ArgumentOutOfRangeException("y");
			}
			global::Infragistics.Windows.DockManager.PaneSplitter paneSplitter = (global::Infragistics.Windows.DockManager.PaneSplitter)base.Owner;
			paneSplitter.PerformMove(x, y);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004A15 File Offset: 0x00002C15
		void global::System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_CannotPerformAutomationOperation"));
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004A26 File Offset: 0x00002C26
		void global::System.Windows.Automation.Provider.ITransformProvider.Rotate(double degrees)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_CannotPerformAutomationOperation"));
		}
	}
}
