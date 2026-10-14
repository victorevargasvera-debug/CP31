using System;
using System.Windows;

namespace Infragistics.Windows.Selection
{
	// Token: 0x02000277 RID: 631
	public struct AutoScrollInfo
	{
		// Token: 0x060018F5 RID: 6389 RVA: 0x0005FA4F File Offset: 0x0005DC4F
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

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0005FA84 File Offset: 0x0005DC84
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x0005FA8C File Offset: 0x0005DC8C
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

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0005FA95 File Offset: 0x0005DC95
		public bool CanScrollDown
		{
			get
			{
				return this._canScrollDown;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x0005FA9D File Offset: 0x0005DC9D
		public bool CanScrollLeft
		{
			get
			{
				return this._canScrollLeft;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0005FAA5 File Offset: 0x0005DCA5
		public bool CanScrollRight
		{
			get
			{
				return this._canScrollRight;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x0005FAAD File Offset: 0x0005DCAD
		public bool CanScrollUp
		{
			get
			{
				return this._canScrollUp;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0005FAB5 File Offset: 0x0005DCB5
		public global::System.Windows.FrameworkElement ScrollArea
		{
			get
			{
				return this._scrollArea;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x0005FABD File Offset: 0x0005DCBD
		// (set) Token: 0x060018FE RID: 6398 RVA: 0x0005FAC5 File Offset: 0x0005DCC5
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

		// Token: 0x04000C00 RID: 3072
		private global::System.Windows.FrameworkElement _scrollArea;

		// Token: 0x04000C01 RID: 3073
		private bool _canScrollDown;

		// Token: 0x04000C02 RID: 3074
		private bool _canScrollLeft;

		// Token: 0x04000C03 RID: 3075
		private bool _canScrollRight;

		// Token: 0x04000C04 RID: 3076
		private bool _canScrollUp;

		// Token: 0x04000C05 RID: 3077
		private global::Infragistics.Windows.Selection.ScrollOrientation _scrollOrientation;

		// Token: 0x04000C06 RID: 3078
		private global::Infragistics.Windows.Selection.AdjustScrollInfoCallback _adjustScrollInfoCallback;
	}
}
