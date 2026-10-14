using System;
using System.ComponentModel;
using System.Printing;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x02000208 RID: 520
	public class ReportSettings
	{
		// Token: 0x0600135C RID: 4956 RVA: 0x00044F34 File Offset: 0x00043134
		public ReportSettings()
		{
			this._fileName = "";
			this._margin = default(global::System.Windows.Thickness);
			this._pageRange = global::Infragistics.Windows.Reporting.ReportSettings.DefaultPageRange;
			this._userPageRangeEnabled = true;
			this._horizontalPaginationMode = global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Mosaic;
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x00044F6C File Offset: 0x0004316C
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x00044F74 File Offset: 0x00043174
		[global::System.ComponentModel.DefaultValue("")]
		public string FileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				this._fileName = value;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x00044F7D File Offset: 0x0004317D
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x00044F85 File Offset: 0x00043185
		[global::System.ComponentModel.DefaultValue(global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Mosaic)]
		public global::Infragistics.Windows.Reporting.HorizontalPaginationMode HorizontalPaginationMode
		{
			get
			{
				return this._horizontalPaginationMode;
			}
			set
			{
				this._horizontalPaginationMode = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x00044F8E File Offset: 0x0004318E
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x00044F96 File Offset: 0x00043196
		public global::System.Windows.Thickness Margin
		{
			get
			{
				return this._margin;
			}
			set
			{
				this._margin = value;
				this._pageMetricsVersion++;
			}
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00044FB0 File Offset: 0x000431B0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMargin()
		{
			return this._margin != default(global::System.Windows.Thickness);
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00044FD1 File Offset: 0x000431D1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMargin()
		{
			this._margin = default(global::System.Windows.Thickness);
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x00044FDF File Offset: 0x000431DF
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x00044FE7 File Offset: 0x000431E7
		[global::System.ComponentModel.DefaultValue(global::Infragistics.Windows.Reporting.PageOrientation.Portrait)]
		public global::Infragistics.Windows.Reporting.PageOrientation PageOrientation
		{
			get
			{
				return this._pageOrientation;
			}
			set
			{
				this._pageOrientation = value;
				this._pageMetricsVersion++;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x00044FFE File Offset: 0x000431FE
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x00045008 File Offset: 0x00043208
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Printing.PageMediaSize PageMediaSize
		{
			get
			{
				return this._pageMediaSize;
			}
			set
			{
				if (value != null)
				{
					if (value.Width != null)
					{
						global::Infragistics.CoreUtilities.ValidateIsPositive(value.Width.Value, "width");
					}
					if (value.Height != null)
					{
						global::Infragistics.CoreUtilities.ValidateIsPositive(value.Height.Value, "height");
					}
				}
				this._pageMediaSize = value;
				this._pageMetricsVersion++;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x0004507D File Offset: 0x0004327D
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x00045085 File Offset: 0x00043285
		[global::System.ComponentModel.DefaultValue(global::Infragistics.Windows.Reporting.PagePrintOrder.Horizontal)]
		public global::Infragistics.Windows.Reporting.PagePrintOrder PagePrintOrder
		{
			get
			{
				return this._pagePrintOrder;
			}
			set
			{
				this._pagePrintOrder = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x0004508E File Offset: 0x0004328E
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x00045098 File Offset: 0x00043298
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Controls.PageRange PageRange
		{
			get
			{
				return this._pageRange;
			}
			set
			{
				if (value.PageFrom < 1)
				{
					throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_23"));
				}
				if (value.PageTo < 0)
				{
					throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_24"));
				}
				if (value.PageTo > 0 && value.PageTo < value.PageFrom)
				{
					throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_25"));
				}
				this._pageRange = value;
			}
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x0004510A File Offset: 0x0004330A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePageRange()
		{
			return this._pageRange != global::Infragistics.Windows.Reporting.ReportSettings.DefaultPageRange;
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0004511C File Offset: 0x0004331C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPageRange()
		{
			this._pageRange = global::Infragistics.Windows.Reporting.ReportSettings.DefaultPageRange;
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x00045129 File Offset: 0x00043329
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x00045131 File Offset: 0x00043331
		[global::System.ComponentModel.DefaultValue(true)]
		public bool UserPageRangeEnabled
		{
			get
			{
				return this._userPageRangeEnabled;
			}
			set
			{
				this._userPageRangeEnabled = value;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x0004513A File Offset: 0x0004333A
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x00045142 File Offset: 0x00043342
		[global::System.Obsolete("Use PageMediaSize instead which can supply the PageMediaSizeName and optionally a specific width and height.", false)]
		public global::System.Windows.Size PageSize
		{
			get
			{
				return this._pageSize;
			}
			set
			{
				this._pageSize = value;
				this._pageMetricsVersion++;
			}
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00045159 File Offset: 0x00043359
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePageSize()
		{
			return this._pageSize.IsEmpty;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00045166 File Offset: 0x00043366
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPageSize()
		{
			this._pageSize = default(global::System.Windows.Size);
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x00045174 File Offset: 0x00043374
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x0004517C File Offset: 0x0004337C
		[global::System.ComponentModel.DefaultValue(global::Infragistics.Windows.Reporting.RepeatType.FirstOccurrence)]
		public global::Infragistics.Windows.Reporting.RepeatType RepeatType
		{
			get
			{
				return this._repeatType;
			}
			set
			{
				this._repeatType = value;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x00045185 File Offset: 0x00043385
		// (set) Token: 0x06001378 RID: 4984 RVA: 0x0004518D File Offset: 0x0004338D
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Printing.PrintQueue PrintQueue
		{
			get
			{
				return this._printQueue;
			}
			set
			{
				this._printQueue = value;
				this._pageMetricsVersion++;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x000451A4 File Offset: 0x000433A4
		internal int PageMetricsVersion
		{
			get
			{
				return this._pageMetricsVersion;
			}
		}

		// Token: 0x04000A63 RID: 2659
		private global::System.Printing.PrintQueue _printQueue;

		// Token: 0x04000A64 RID: 2660
		private global::Infragistics.Windows.Reporting.RepeatType _repeatType;

		// Token: 0x04000A65 RID: 2661
		private global::System.Windows.Controls.PageRange _pageRange;

		// Token: 0x04000A66 RID: 2662
		private global::System.Windows.Size _pageSize;

		// Token: 0x04000A67 RID: 2663
		private global::Infragistics.Windows.Reporting.PageOrientation _pageOrientation;

		// Token: 0x04000A68 RID: 2664
		private global::System.Printing.PageMediaSize _pageMediaSize;

		// Token: 0x04000A69 RID: 2665
		private global::System.Windows.Thickness _margin;

		// Token: 0x04000A6A RID: 2666
		private string _fileName;

		// Token: 0x04000A6B RID: 2667
		private bool _userPageRangeEnabled;

		// Token: 0x04000A6C RID: 2668
		private global::Infragistics.Windows.Reporting.PagePrintOrder _pagePrintOrder;

		// Token: 0x04000A6D RID: 2669
		private global::Infragistics.Windows.Reporting.HorizontalPaginationMode _horizontalPaginationMode;

		// Token: 0x04000A6E RID: 2670
		private static global::System.Windows.Controls.PageRange DefaultPageRange = new global::System.Windows.Controls.PageRange(1, 0);

		// Token: 0x04000A6F RID: 2671
		private int _pageMetricsVersion;
	}
}
