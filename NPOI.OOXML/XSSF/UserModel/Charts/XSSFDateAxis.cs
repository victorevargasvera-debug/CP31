using System;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.UserModel.Charts;

namespace NPOI.XSSF.UserModel.Charts
{
	// Token: 0x020000BD RID: 189
	public class XSSFDateAxis : global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis
	{
		// Token: 0x06000BC4 RID: 3012 RVA: 0x0002B7CF File Offset: 0x000299CF
		public XSSFDateAxis(global::NPOI.XSSF.UserModel.XSSFChart chart, long id, global::NPOI.SS.UserModel.Charts.AxisPosition pos) : base(chart)
		{
			this.createAxis(id, pos);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0002B7E0 File Offset: 0x000299E0
		public XSSFDateAxis(global::NPOI.XSSF.UserModel.XSSFChart chart, global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx ctDateAx) : base(chart)
		{
			this.ctDateAx = ctDateAx;
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0002B7F0 File Offset: 0x000299F0
		public override long Id
		{
			get
			{
				return (long)((ulong)this.ctDateAx.axId.val);
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0002B803 File Offset: 0x00029A03
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties Line
		{
			get
			{
				return this.ctDateAx.spPr;
			}
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0002B810 File Offset: 0x00029A10
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos GetCTAxPos()
		{
			return this.ctDateAx.axPos;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0002B81D File Offset: 0x00029A1D
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt GetCTNumFmt()
		{
			if (this.ctDateAx.IsSetNumFmt())
			{
				return this.ctDateAx.numFmt;
			}
			return this.ctDateAx.AddNewNumFmt();
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0002B843 File Offset: 0x00029A43
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling GetCTScaling()
		{
			return this.ctDateAx.scaling;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0002B850 File Offset: 0x00029A50
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses GetCTCrosses()
		{
			return this.ctDateAx.crosses;
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0002B85D File Offset: 0x00029A5D
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean GetDelete()
		{
			return this.ctDateAx.delete;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0002B86A File Offset: 0x00029A6A
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark GetMajorCTTickMark()
		{
			return this.ctDateAx.majorTickMark;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0002B877 File Offset: 0x00029A77
		public void SetMajorCTTickMark(global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark tm)
		{
			this.ctDateAx.majorTickMark = tm;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0002B885 File Offset: 0x00029A85
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark GetMinorCTTickMark()
		{
			return this.ctDateAx.minorTickMark;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0002B892 File Offset: 0x00029A92
		protected global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines GetMajorGridLines()
		{
			return this.ctDateAx.majorGridlines;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0002B89F File Offset: 0x00029A9F
		public override void CrossAxis(global::NPOI.SS.UserModel.Charts.IChartAxis axis)
		{
			this.ctDateAx.crossAx.val = (uint)axis.Id;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0002B8B8 File Offset: 0x00029AB8
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit GetBaseTimeUnit()
		{
			return this.ctDateAx.baseTimeUnit;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0002B8C5 File Offset: 0x00029AC5
		public void SetBaseTimeUnit(global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit unit)
		{
			this.ctDateAx.baseTimeUnit = unit;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0002B8D3 File Offset: 0x00029AD3
		public void SetAuto(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean au)
		{
			this.ctDateAx.auto = au;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0002B8E4 File Offset: 0x00029AE4
		private void createAxis(long id, global::NPOI.SS.UserModel.Charts.AxisPosition pos)
		{
			this.ctDateAx = this.chart.GetCTChart().plotArea.AddNewDateAx();
			this.ctDateAx.AddNewAxId().val = (uint)id;
			this.ctDateAx.AddNewAxPos();
			this.ctDateAx.AddNewScaling();
			this.ctDateAx.AddNewCrosses();
			this.ctDateAx.AddNewCrossAx();
			this.ctDateAx.AddNewTickLblPos().val = global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickLblPos.nextTo;
			this.ctDateAx.AddNewDelete();
			this.ctDateAx.AddNewMajorTickMark();
			this.ctDateAx.AddNewMinorTickMark();
			base.Position = pos;
			base.Orientation = global::NPOI.SS.UserModel.Charts.AxisOrientation.MinToMax;
			base.Crosses = global::NPOI.SS.UserModel.Charts.AxisCrosses.AutoZero;
			base.IsVisible = true;
			base.MajorTickMark = global::NPOI.SS.UserModel.Charts.AxisTickMark.Cross;
			base.MinorTickMark = global::NPOI.SS.UserModel.Charts.AxisTickMark.None;
		}

		// Token: 0x040003C7 RID: 967
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx ctDateAx;
	}
}
