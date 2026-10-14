using System;
using System.Windows;

namespace Infragistics.Windows.Selection
{
	// Token: 0x020002B4 RID: 692
	public struct AutoScrollInfo
	{
		// Token: 0x06001B20 RID: 6944 RVA: 0x00066B5D File Offset: 0x00064D5D
		public AutoScrollInfo(global::System.Windows.FrameworkElement scrollArea, bool canScrollDown, bool canScrollLeft, bool canScrollRight, bool canScrollUp)
		{
			this._scrollArea = scrollArea;
			this._canScrollDown = canScrollDown;
			this._canScrollLeft = canScrollLeft;
			this._canScrollRight = canScrollRight;
			this._canScrollUp = canScrollUp;
			this._scrollOrientation = global::Infragistics.Windows.Selection.ScrollOrientation.Both;
			this._adjustScrollInfoCallback = null;
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x00066B92 File Offset: 0x00064D92
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x00066B9A File Offset: 0x00064D9A
		public global::Infragistics.Windows.Selection.AdjustScrollInfoCallback AdjustScrollInfoCallback
		{
			get
			{
				return this._adjustScrollInfoCallback;
			}
			set
			{
				this._adjustScrollInfoCallback = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x00066BA3 File Offset: 0x00064DA3
		public bool CanScrollDown
		{
			get
			{
				return this._canScrollDown;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x00066BAB File Offset: 0x00064DAB
		public bool CanScrollLeft
		{
			get
			{
				return this._canScrollLeft;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x00066BB3 File Offset: 0x00064DB3
		public bool CanScrollRight
		{
			get
			{
				return this._canScrollRight;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x00066BBB File Offset: 0x00064DBB
		public bool CanScrollUp
		{
			get
			{
				return this._canScrollUp;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x00066BC3 File Offset: 0x00064DC3
		public global::System.Windows.FrameworkElement ScrollArea
		{
			get
			{
				return this._scrollArea;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x00066BCB File Offset: 0x00064DCB
		// (set) Token: 0x06001B29 RID: 6953 RVA: 0x00066BD3 File Offset: 0x00064DD3
		public global::Infragistics.Windows.Selection.ScrollOrientation ScrollOrientation
		{
			get
			{
				return this._scrollOrientation;
			}
			set
			{
				this._scrollOrientation = value;
			}
		}

		// Token: 0x04000D72 RID: 3442
		private global::System.Windows.FrameworkElement _scrollArea;

		// Token: 0x04000D73 RID: 3443
		private bool _canScrollDown;

		// Token: 0x04000D74 RID: 3444
		private bool _canScrollLeft;

		// Token: 0x04000D75 RID: 3445
		private bool _canScrollRight;

		// Token: 0x04000D76 RID: 3446
		private bool _canScrollUp;

		// Token: 0x04000D77 RID: 3447
		private global::Infragistics.Windows.Selection.ScrollOrientation _scrollOrientation;

		// Token: 0x04000D78 RID: 3448
		private global::Infragistics.Windows.Selection.AdjustScrollInfoCallback _adjustScrollInfoCallback;
	}
}
