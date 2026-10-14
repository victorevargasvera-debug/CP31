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
		// Token: 0x060000A4 RID: 164 RVA: 0x00003E7A File Offset: 0x0000207A
		public FixedFieldSplitterAutomationPeer(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter element) : base(element)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003E83 File Offset: 0x00002083
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Thumb;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003E88 File Offset: 0x00002088
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

		// Token: 0x060000A7 RID: 167 RVA: 0x00003EC2 File Offset: 0x000020C2
		protected override string GetClassNameCore()
		{
			return "FixedFieldSplitter";
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003EC9 File Offset: 0x000020C9
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Transform)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00003ED9 File Offset: 0x000020D9
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanMove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00003EDC File Offset: 0x000020DC
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanResize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00003EDF File Offset: 0x000020DF
		bool global::System.Windows.Automation.Provider.ITransformProvider.CanRotate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003EE4 File Offset: 0x000020E4
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

		// Token: 0x060000AD RID: 173 RVA: 0x00003F5F File Offset: 0x0000215F
		void global::System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			throw new global::System.InvalidOperationException();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003F74 File Offset: 0x00002174
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
