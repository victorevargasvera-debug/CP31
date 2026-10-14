using System;
using System.Windows;

namespace Infragistics.Windows.Resizing
{
	// Token: 0x0200026C RID: 620
	public class ResizeConstraints
	{
		// Token: 0x0600188C RID: 6284 RVA: 0x0005E1E7 File Offset: 0x0005C3E7
		public ResizeConstraints(global::System.Windows.FrameworkElement resizerBar, global::System.Windows.FrameworkElement resizeArea, bool resizeInXAxis)
		{
			this._resizerBar = resizerBar;
			this._resizeArea = resizeArea;
			this._resizeInXAxis = resizeInXAxis;
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x0005E213 File Offset: 0x0005C413
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x0005E21B File Offset: 0x0005C41B
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

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x0005E224 File Offset: 0x0005C424
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x0005E22C File Offset: 0x0005C42C
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

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x0005E235 File Offset: 0x0005C435
		// (set) Token: 0x06001892 RID: 6290 RVA: 0x0005E23D File Offset: 0x0005C43D
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

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x0005E246 File Offset: 0x0005C446
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x0005E24E File Offset: 0x0005C44E
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

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x0005E257 File Offset: 0x0005C457
		public global::System.Windows.FrameworkElement ResizerBar
		{
			get
			{
				return this._resizerBar;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0005E25F File Offset: 0x0005C45F
		public global::System.Windows.FrameworkElement ResizeArea
		{
			get
			{
				return this._resizeArea;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x0005E267 File Offset: 0x0005C467
		public bool ResizeInXAxis
		{
			get
			{
				return this._resizeInXAxis;
			}
		}

		// Token: 0x04000BD1 RID: 3025
		private global::System.Windows.FrameworkElement _resizerBar;

		// Token: 0x04000BD2 RID: 3026
		private double _minExtent = 4.0;

		// Token: 0x04000BD3 RID: 3027
		private double _maxExtent;

		// Token: 0x04000BD4 RID: 3028
		private bool _resizeWhileDragging;

		// Token: 0x04000BD5 RID: 3029
		private bool _cancel;

		// Token: 0x04000BD6 RID: 3030
		private global::System.Windows.FrameworkElement _resizeArea;

		// Token: 0x04000BD7 RID: 3031
		private bool _resizeInXAxis;
	}
}
