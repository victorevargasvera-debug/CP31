using System;
using System.Windows;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x0200003D RID: 61
	internal struct AutoScrollInfo
	{
		// Token: 0x06000291 RID: 657 RVA: 0x0000D211 File Offset: 0x0000B411
		public AutoScrollInfo(global::System.Windows.FrameworkElement scrollArea, bool canScrollDown, bool canScrollLeft, bool canScrollRight, bool canScrollUp)
		{
			this._scrollArea = scrollArea;
			this._canScrollDown = canScrollDown;
			this._canScrollLeft = canScrollLeft;
			this._canScrollRight = canScrollRight;
			this._canScrollUp = canScrollUp;
			this._scrollOrientation = global::Infragistics.Controls.Primitives.ScrollOrientation.Both;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000D23F File Offset: 0x0000B43F
		public bool CanScrollDown
		{
			get
			{
				return this._canScrollDown;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000D247 File Offset: 0x0000B447
		public bool CanScrollLeft
		{
			get
			{
				return this._canScrollLeft;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000D24F File Offset: 0x0000B44F
		public bool CanScrollRight
		{
			get
			{
				return this._canScrollRight;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000D257 File Offset: 0x0000B457
		public bool CanScrollUp
		{
			get
			{
				return this._canScrollUp;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000D25F File Offset: 0x0000B45F
		public global::System.Windows.FrameworkElement ScrollArea
		{
			get
			{
				return this._scrollArea;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000D267 File Offset: 0x0000B467
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0000D26F File Offset: 0x0000B46F
		public global::Infragistics.Controls.Primitives.ScrollOrientation ScrollOrientation
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

		// Token: 0x0400018C RID: 396
		private global::System.Windows.FrameworkElement _scrollArea;

		// Token: 0x0400018D RID: 397
		private bool _canScrollDown;

		// Token: 0x0400018E RID: 398
		private bool _canScrollLeft;

		// Token: 0x0400018F RID: 399
		private bool _canScrollRight;

		// Token: 0x04000190 RID: 400
		private bool _canScrollUp;

		// Token: 0x04000191 RID: 401
		private global::Infragistics.Controls.Primitives.ScrollOrientation _scrollOrientation;
	}
}
