using System;
using System.ComponentModel;
using System.Printing;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x020001DA RID: 474
	public class ReportSettings
	{
		// Token: 0x0600118A RID: 4490 RVA: 0x0003F70C File Offset: 0x0003D90C
		public ReportSettings()
		{
			this._fileName = "";
			this._margin = default(global::System.Windows.Thickness);
			this._pageRange = global::Infragistics.Windows.Reporting.ReportSettings.DefaultPageRange;
			this._userPageRangeEnabled = true;
			this._horizontalPaginationMode = global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Mosaic;
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x0003F744 File Offset: 0x0003D944
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x0003F74C File Offset: 0x0003D94C
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

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x0003F755 File Offset: 0x0003D955
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x0003F75D File Offset: 0x0003D95D
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

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x0003F766 File Offset: 0x0003D966
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x0003F76E File Offset: 0x0003D96E
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

		// Token: 0x06001191 RID: 4497 RVA: 0x0003F788 File Offset: 0x0003D988
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMargin()
		{
			return this._margin != default(global::System.Windows.Thickness);
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0003F7A9 File Offset: 0x0003D9A9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMargin()
		{
			this._margin = default(global::System.Windows.Thickness);
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x0003F7B7 File Offset: 0x0003D9B7
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0003F7BF File Offset: 0x0003D9BF
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

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x0003F7D6 File Offset: 0x0003D9D6
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x0003F7DE File Offset: 0x0003D9DE
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

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x0003F7E7 File Offset: 0x0003D9E7
		// (set) Token: 0x06001198 RID: 4504 RVA: 0x0003F7F0 File Offset: 0x0003D9F0
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

		// Token: 0x06001199 RID: 4505 RVA: 0x0003F862 File Offset: 0x0003DA62
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePageRange()
		{
			return this._pageRange != global::Infragistics.Windows.Reporting.ReportSettings.DefaultPageRange;
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0003F874 File Offset: 0x0003DA74
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPageRange()
		{
			this._pageRange = global::Infragistics.Windows.Reporting.ReportSettings.DefaultPageRange;
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x0003F881 File Offset: 0x0003DA81
		// (set) Token: 0x0600119C RID: 4508 RVA: 0x0003F889 File Offset: 0x0003DA89
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

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x0003F892 File Offset: 0x0003DA92
		// (set) Token: 0x0600119E RID: 4510 RVA: 0x0003F89A File Offset: 0x0003DA9A
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

		// Token: 0x0600119F RID: 4511 RVA: 0x0003F8B1 File Offset: 0x0003DAB1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePageSize()
		{
			return this._pageSize.IsEmpty;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0003F8BE File Offset: 0x0003DABE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPageSize()
		{
			this._pageSize = default(global::System.Windows.Size);
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x0003F8CC File Offset: 0x0003DACC
		// (set) Token: 0x060011A2 RID: 4514 RVA: 0x0003F8D4 File Offset: 0x0003DAD4
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

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0003F8DD File Offset: 0x0003DADD
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0003F8E5 File Offset: 0x0003DAE5
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

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x0003F8FC File Offset: 0x0003DAFC
		internal int PageMetricsVersion
		{
			get
			{
				return this._pageMetricsVersion;
			}
		}

		// Token: 0x04000920 RID: 2336
		private global::System.Printing.PrintQueue _printQueue;

		// Token: 0x04000921 RID: 2337
		private global::Infragistics.Windows.Reporting.RepeatType _repeatType;

		// Token: 0x04000922 RID: 2338
		private global::System.Windows.Controls.PageRange _pageRange;

		// Token: 0x04000923 RID: 2339
		private global::System.Windows.Size _pageSize;

		// Token: 0x04000924 RID: 2340
		private global::Infragistics.Windows.Reporting.PageOrientation _pageOrientation;

		// Token: 0x04000925 RID: 2341
		private global::System.Windows.Thickness _margin;

		// Token: 0x04000926 RID: 2342
		private string _fileName;

		// Token: 0x04000927 RID: 2343
		private bool _userPageRangeEnabled;

		// Token: 0x04000928 RID: 2344
		private global::Infragistics.Windows.Reporting.PagePrintOrder _pagePrintOrder;

		// Token: 0x04000929 RID: 2345
		private global::Infragistics.Windows.Reporting.HorizontalPaginationMode _horizontalPaginationMode;

		// Token: 0x0400092A RID: 2346
		private static global::System.Windows.Controls.PageRange DefaultPageRange = new global::System.Windows.Controls.PageRange(1, 0);

		// Token: 0x0400092B RID: 2347
		private int _pageMetricsVersion;
	}
}
