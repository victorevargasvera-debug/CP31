using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using Infragistics.Controls;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000007 RID: 7
	public class XamZoombarAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IScrollProvider
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002A4B File Offset: 0x00000C4B
		public XamZoombarAutomationPeer(global::Infragistics.Controls.XamZoombar zoombar) : base(zoombar)
		{
			this.Zoombar = zoombar;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002A5B File Offset: 0x00000C5B
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002A63 File Offset: 0x00000C63
		public global::Infragistics.Controls.XamZoombar Zoombar { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002A6C File Offset: 0x00000C6C
		public bool HorizontallyScrollable
		{
			get
			{
				return this.Zoombar.Orientation == global::System.Windows.Controls.Orientation.Horizontal;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002A7C File Offset: 0x00000C7C
		public double HorizontalScrollPercent
		{
			get
			{
				if (this.Zoombar.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					return this.Zoombar.Range.Minimum + (this.Zoombar.Range.Maximum - this.Zoombar.Range.Minimum) / 2.0;
				}
				return 0.0;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002ADC File Offset: 0x00000CDC
		public double HorizontalViewSize
		{
			get
			{
				if (this.Zoombar.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					return this.Zoombar.ActualMaximum - this.Zoombar.ActualMinimum;
				}
				return 0.0;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002B0C File Offset: 0x00000D0C
		public bool VerticallyScrollable
		{
			get
			{
				return this.Zoombar.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002B1C File Offset: 0x00000D1C
		public double VerticalScrollPercent
		{
			get
			{
				if (this.Zoombar.Orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					return this.Zoombar.Range.Minimum + (this.Zoombar.Range.Maximum - this.Zoombar.Range.Minimum) / 2.0;
				}
				return 0.0;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002B7D File Offset: 0x00000D7D
		public double VerticalViewSize
		{
			get
			{
				if (this.Zoombar.Orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					return this.Zoombar.ActualMaximum - this.Zoombar.ActualMinimum;
				}
				return 0.0;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002BB0 File Offset: 0x00000DB0
		public void Scroll(global::System.Windows.Automation.ScrollAmount horizontalAmount, global::System.Windows.Automation.ScrollAmount verticalAmount)
		{
			double num = this.Zoombar.Range.Maximum - this.Zoombar.Range.Minimum;
			if (this.Zoombar.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
			{
				switch (horizontalAmount)
				{
				case global::System.Windows.Automation.ScrollAmount.LargeDecrement:
					if (this.Zoombar.Range.Minimum >= this.Zoombar.LargeChange)
					{
						this.Zoombar.Range.Minimum -= this.Zoombar.LargeChange;
						this.Zoombar.Range.Maximum -= this.Zoombar.LargeChange;
						return;
					}
					this.Zoombar.Range.Minimum = 0.0;
					this.Zoombar.Range.Maximum = num;
					return;
				case global::System.Windows.Automation.ScrollAmount.SmallDecrement:
					if (this.Zoombar.Range.Minimum >= this.Zoombar.SmallChange)
					{
						this.Zoombar.Range.Minimum -= this.Zoombar.SmallChange;
						this.Zoombar.Range.Maximum -= this.Zoombar.SmallChange;
						return;
					}
					this.Zoombar.Range.Minimum = 0.0;
					this.Zoombar.Range.Maximum = num;
					return;
				case global::System.Windows.Automation.ScrollAmount.NoAmount:
					break;
				case global::System.Windows.Automation.ScrollAmount.LargeIncrement:
					if (this.Zoombar.Range.Maximum + this.Zoombar.LargeChange <= 1.0)
					{
						this.Zoombar.Range.Minimum += this.Zoombar.LargeChange;
						this.Zoombar.Range.Maximum += this.Zoombar.LargeChange;
						return;
					}
					this.Zoombar.Range.Minimum = 1.0 - num;
					this.Zoombar.Range.Maximum = 1.0;
					return;
				case global::System.Windows.Automation.ScrollAmount.SmallIncrement:
					if (this.Zoombar.Range.Maximum + this.Zoombar.SmallChange <= 1.0)
					{
						this.Zoombar.Range.Minimum += this.Zoombar.SmallChange;
						this.Zoombar.Range.Maximum += this.Zoombar.SmallChange;
						return;
					}
					this.Zoombar.Range.Minimum = 1.0 - num;
					this.Zoombar.Range.Maximum = 1.0;
					return;
				default:
					return;
				}
			}
			else
			{
				switch (verticalAmount)
				{
				case global::System.Windows.Automation.ScrollAmount.LargeDecrement:
					if (this.Zoombar.Range.Minimum >= this.Zoombar.LargeChange)
					{
						this.Zoombar.Range.Minimum -= this.Zoombar.LargeChange;
						this.Zoombar.Range.Maximum -= this.Zoombar.LargeChange;
						return;
					}
					this.Zoombar.Range.Minimum = 0.0;
					this.Zoombar.Range.Maximum = num;
					return;
				case global::System.Windows.Automation.ScrollAmount.SmallDecrement:
					if (this.Zoombar.Range.Minimum >= this.Zoombar.SmallChange)
					{
						this.Zoombar.Range.Minimum -= this.Zoombar.SmallChange;
						this.Zoombar.Range.Maximum -= this.Zoombar.SmallChange;
						return;
					}
					this.Zoombar.Range.Minimum = 0.0;
					this.Zoombar.Range.Maximum = num;
					return;
				case global::System.Windows.Automation.ScrollAmount.NoAmount:
					break;
				case global::System.Windows.Automation.ScrollAmount.LargeIncrement:
					if (this.Zoombar.Range.Maximum + this.Zoombar.LargeChange <= 1.0)
					{
						this.Zoombar.Range.Minimum += this.Zoombar.LargeChange;
						this.Zoombar.Range.Maximum += this.Zoombar.LargeChange;
						return;
					}
					this.Zoombar.Range.Minimum = 1.0 - num;
					this.Zoombar.Range.Maximum = 1.0;
					return;
				case global::System.Windows.Automation.ScrollAmount.SmallIncrement:
					if (this.Zoombar.Range.Maximum + this.Zoombar.SmallChange <= 1.0)
					{
						this.Zoombar.Range.Minimum += this.Zoombar.SmallChange;
						this.Zoombar.Range.Maximum += this.Zoombar.SmallChange;
						return;
					}
					this.Zoombar.Range.Minimum = 1.0 - num;
					this.Zoombar.Range.Maximum = 1.0;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000030E0 File Offset: 0x000012E0
		public void SetScrollPercent(double horizontalPercent, double verticalPercent)
		{
			double num = this.Zoombar.Range.Maximum - this.Zoombar.Range.Minimum;
			double num2;
			double num3;
			if (this.Zoombar.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
			{
				num2 = horizontalPercent / 100.0 - num / 2.0;
				num3 = horizontalPercent / 100.0 + num / 2.0;
				if (num2 < 0.0)
				{
					num2 = 0.0;
					num3 = num;
				}
				if (num3 > 1.0)
				{
					num2 = 1.0 - num;
					num3 = 1.0;
				}
			}
			else
			{
				num2 = verticalPercent / 100.0 - num / 2.0;
				num3 = verticalPercent / 100.0 + num / 2.0;
				if (num2 < 0.0)
				{
					num2 = 0.0;
					num3 = num;
				}
				if (num3 > 1.0)
				{
					num2 = 1.0 - num;
					num3 = 1.0;
				}
			}
			this.Zoombar.Range.Minimum = num2;
			this.Zoombar.Range.Maximum = num3;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000322B File Offset: 0x0000142B
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Scroll)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000323A File Offset: 0x0000143A
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000323E File Offset: 0x0000143E
		protected override string GetClassNameCore()
		{
			return this.Zoombar.GetType().Name;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003250 File Offset: 0x00001450
		protected override string GetNameCore()
		{
			if (string.IsNullOrEmpty(this.Zoombar.Name))
			{
				return this.Zoombar.GetType().Name;
			}
			return this.Zoombar.Name;
		}
	}
}
