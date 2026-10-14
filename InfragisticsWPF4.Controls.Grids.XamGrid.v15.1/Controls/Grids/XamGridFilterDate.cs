using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000EF RID: 239
	public class XamGridFilterDate : global::Infragistics.Controls.Grids.TrackIsCheckWithChildren<global::Infragistics.Controls.Grids.XamGridFilterDate>
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x000203AF File Offset: 0x0001E5AF
		public XamGridFilterDate()
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000203B7 File Offset: 0x0001E5B7
		public XamGridFilterDate(global::System.DateTime date)
		{
			this.Date = date;
			this.DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Date;
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x000203CD File Offset: 0x0001E5CD
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x000203D5 File Offset: 0x0001E5D5
		public global::System.DateTime Date { get; set; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x000203DE File Offset: 0x0001E5DE
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x000203E6 File Offset: 0x0001E5E6
		public global::Infragistics.Controls.Grids.DateFilterObjectType DateFilterObjectType { get; set; }

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x000203F0 File Offset: 0x0001E5F0
		public string ContentString
		{
			get
			{
				switch (this.DateFilterObjectType)
				{
				case global::Infragistics.Controls.Grids.DateFilterObjectType.None:
					return global::Infragistics.SRGrid.GetString("Blank");
				case global::Infragistics.Controls.Grids.DateFilterObjectType.Year:
					return this.Date.Year.ToString();
				case global::Infragistics.Controls.Grids.DateFilterObjectType.Month:
					return this.ContentStringMonth;
				case global::Infragistics.Controls.Grids.DateFilterObjectType.Date:
					return this.Date.Day.ToString();
				case global::Infragistics.Controls.Grids.DateFilterObjectType.Hour:
					return this.Date.Hour.ToString();
				case global::Infragistics.Controls.Grids.DateFilterObjectType.Minute:
					return ":" + this.Date.Minute.ToString("0#");
				case global::Infragistics.Controls.Grids.DateFilterObjectType.Second:
					return ":" + this.Date.Second.ToString("0#");
				}
				return "";
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000204E0 File Offset: 0x0001E6E0
		public string ContentStringMonth
		{
			get
			{
				if (this.DateFilterObjectType == global::Infragistics.Controls.Grids.DateFilterObjectType.None)
				{
					return "";
				}
				return global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(this.Date.Month);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00020518 File Offset: 0x0001E718
		public bool NullDate
		{
			get
			{
				return this.DateFilterObjectType == global::Infragistics.Controls.Grids.DateFilterObjectType.None;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00020523 File Offset: 0x0001E723
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x0002052B File Offset: 0x0001E72B
		public bool IsExpanded
		{
			get
			{
				return this._isExpanded;
			}
			set
			{
				if (this._isExpanded != value)
				{
					this._isExpanded = value;
					this.OnPropertyChanged("IsExpanded");
				}
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00020548 File Offset: 0x0001E748
		protected internal override void InvalidateIsChecked()
		{
			base.InvalidateIsChecked();
			if (base.Parent != null)
			{
				base.Parent.InvalidateIsChecked();
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00020564 File Offset: 0x0001E764
		protected internal global::Infragistics.Controls.Grids.XamGridFilterDate GetMonthByDate(global::System.DateTime date)
		{
			int month = date.Month;
			foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate in base.Children)
			{
				if (month == xamGridFilterDate.Date.Month)
				{
					return xamGridFilterDate;
				}
			}
			return null;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000205D4 File Offset: 0x0001E7D4
		protected internal global::Infragistics.Controls.Grids.XamGridFilterDate GetDayByDate(global::System.DateTime date)
		{
			foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate in base.Children)
			{
				if (date.Day == xamGridFilterDate.Date.Day)
				{
					return xamGridFilterDate;
				}
			}
			return null;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00020640 File Offset: 0x0001E840
		public global::Infragistics.Controls.Grids.XamGridFilterDate GetHourByDate(global::System.DateTime date)
		{
			foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate in base.Children)
			{
				if (date.Hour == xamGridFilterDate.Date.Hour)
				{
					return xamGridFilterDate;
				}
			}
			return null;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x000206AC File Offset: 0x0001E8AC
		public global::Infragistics.Controls.Grids.XamGridFilterDate GetMinuteByDate(global::System.DateTime date)
		{
			foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate in base.Children)
			{
				if (date.Minute == xamGridFilterDate.Date.Minute)
				{
					return xamGridFilterDate;
				}
			}
			return null;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00020718 File Offset: 0x0001E918
		public global::Infragistics.Controls.Grids.XamGridFilterDate GetSecondByDate(global::System.DateTime date)
		{
			foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate in base.Children)
			{
				if (date.Second == xamGridFilterDate.Date.Second)
				{
					return xamGridFilterDate;
				}
			}
			return null;
		}

		// Token: 0x040001F2 RID: 498
		private bool _isExpanded;
	}
}
