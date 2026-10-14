using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000016 RID: 22
	public class FixedFieldSplitterAutomationPeer : global::System.Windows.Automation.Peers.ThumbAutomationPeer, global::System.Windows.Automation.Provider.ITransformProvider
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00003EA2 File Offset: 0x000020A2
		public FixedFieldSplitterAutomationPeer(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter element) : base(element)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003EAB File Offset: 0x000020AB
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Thumb;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003EB0 File Offset: 0x000020B0
		protected override string GetAutomationIdCore()
		{
			string text = base.GetAutomationIdCore();
			if (string.IsNullOrEmpty(text))
			{
				global::Infragistics.Windows.DataPresenter.FixedFieldSplitter fixedFieldSplitter = base.Owner as global::Infragistics.Windows.DataPresenter.FixedFieldSplitter;
				text = fixedFieldSplitter.SplitterType.ToString();
			}
			return text;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003EEA File Offset: 0x000020EA
		protected override string GetClassNameCore()
		{
			return "FixedFieldSplitter";
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003EF1 File Offset: 0x000020F1
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Transform)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00003F01 File Offset: 0x00002101
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanMove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00003F04 File Offset: 0x00002104
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanResize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003F07 File Offset: 0x00002107
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanRotate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003F0C File Offset: 0x0000210C
		void global::System.Windows.Automation.Provider.ITransformProvider.Move(double x, double y)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (!((global::System.Windows.Automation.Provider.ITransformProvider)this).CanMove)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.Resources.GetString("LE_CannotPerformAutomationOperation"));
			}
			if (double.IsInfinity(x) || double.IsNaN(x))
			{
				throw new global::System.ArgumentOutOfRangeException("x");
			}
			if (double.IsInfinity(y) || double.IsNaN(y))
			{
				throw new global::System.ArgumentOutOfRangeException("y");
			}
			((global::Infragistics.Windows.DataPresenter.FixedFieldSplitter)base.Owner).PerformMove(x, y);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003F87 File Offset: 0x00002187
		void global::System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			throw new global::System.InvalidOperationException();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003F9C File Offset: 0x0000219C
		void global::System.Windows.Automation.Provider.ITransformProvider.Rotate(double degrees)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			throw new global::System.InvalidOperationException();
		}
	}
}
