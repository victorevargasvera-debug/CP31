using System;
using System.Windows;

namespace Infragistics.Windows.Resizing
{
	// Token: 0x020002A7 RID: 679
	public class ResizeConstraints
	{
		// Token: 0x06001AA8 RID: 6824 RVA: 0x00064EB3 File Offset: 0x000630B3
		public ResizeConstraints(global::System.Windows.FrameworkElement resizerBar, global::System.Windows.FrameworkElement resizeArea, bool resizeInXAxis)
		{
			this._resizerBar = resizerBar;
			this._resizeArea = resizeArea;
			this._resizeInXAxis = resizeInXAxis;
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x00064EDF File Offset: 0x000630DF
		// (set) Token: 0x06001AAA RID: 6826 RVA: 0x00064EE7 File Offset: 0x000630E7
		public bool Cancel
		{
			get
			{
				return this._cancel;
			}
			set
			{
				this._cancel = value;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x00064EF0 File Offset: 0x000630F0
		// (set) Token: 0x06001AAC RID: 6828 RVA: 0x00064EF8 File Offset: 0x000630F8
		public double MinExtent
		{
			get
			{
				return this._minExtent;
			}
			set
			{
				this._minExtent = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x00064F01 File Offset: 0x00063101
		// (set) Token: 0x06001AAE RID: 6830 RVA: 0x00064F09 File Offset: 0x00063109
		public double MaxExtent
		{
			get
			{
				return this._maxExtent;
			}
			set
			{
				this._maxExtent = value;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x00064F12 File Offset: 0x00063112
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x00064F1A File Offset: 0x0006311A
		public bool ResizeWhileDragging
		{
			get
			{
				return this._resizeWhileDragging;
			}
			set
			{
				this._resizeWhileDragging = value;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x00064F23 File Offset: 0x00063123
		public global::System.Windows.FrameworkElement ResizerBar
		{
			get
			{
				return this._resizerBar;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x00064F2B File Offset: 0x0006312B
		public global::System.Windows.FrameworkElement ResizeArea
		{
			get
			{
				return this._resizeArea;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x00064F33 File Offset: 0x00063133
		public bool ResizeInXAxis
		{
			get
			{
				return this._resizeInXAxis;
			}
		}

		// Token: 0x04000D3C RID: 3388
		private global::System.Windows.FrameworkElement _resizerBar;

		// Token: 0x04000D3D RID: 3389
		private double _minExtent = 4.0;

		// Token: 0x04000D3E RID: 3390
		private double _maxExtent;

		// Token: 0x04000D3F RID: 3391
		private bool _resizeWhileDragging;

		// Token: 0x04000D40 RID: 3392
		private bool _cancel;

		// Token: 0x04000D41 RID: 3393
		private global::System.Windows.FrameworkElement _resizeArea;

		// Token: 0x04000D42 RID: 3394
		private bool _resizeInXAxis;
	}
}
