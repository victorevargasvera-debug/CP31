using System;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.UserModel.Charts;

namespace NPOI.XSSF.UserModel.Charts
{
	// Token: 0x020000C1 RID: 193
	public class XSSFValueAxis : global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis, global::NPOI.SS.UserModel.Charts.IValueAxis, global::NPOI.SS.UserModel.Charts.IChartAxis
	{
		// Token: 0x06000BF9 RID: 3065 RVA: 0x0002BFC6 File Offset: 0x0002A1C6
		public XSSFValueAxis(global::NPOI.XSSF.UserModel.XSSFChart chart, long id, global::NPOI.SS.UserModel.Charts.AxisPosition pos) : base(chart)
		{
			this.CreateAxis(id, pos);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0002BFD7 File Offset: 0x0002A1D7
		public XSSFValueAxis(global::NPOI.XSSF.UserModel.XSSFChart chart, global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx ctValAx) : base(chart)
		{
			this.ctValAx = ctValAx;
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x0002BFE7 File Offset: 0x0002A1E7
		public override long Id
		{
			get
			{
				return (long)((ulong)this.ctValAx.axId.val);
			}
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0002BFFA File Offset: 0x0002A1FA
		public void SetCrossBetween(global::NPOI.SS.UserModel.Charts.AxisCrossBetween crossBetween)
		{
			this.ctValAx.crossBetween.val = global::NPOI.XSSF.UserModel.Charts.XSSFValueAxis.fromCrossBetween(crossBetween);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0002C012 File Offset: 0x0002A212
		public global::NPOI.SS.UserModel.Charts.AxisCrossBetween GetCrossBetween()
		{
			return global::NPOI.XSSF.UserModel.Charts.XSSFValueAxis.ToCrossBetween(this.ctValAx.crossBetween.val);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0002C029 File Offset: 0x0002A229
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean GetDelete()
		{
			return this.ctValAx.delete;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0002C036 File Offset: 0x0002A236
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark GetMajorCTTickMark()
		{
			return this.ctValAx.majorTickMark;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0002C043 File Offset: 0x0002A243
		public void SetMajorCTTickMark(global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark tm)
		{
			this.ctValAx.majorTickMark = tm;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0002C051 File Offset: 0x0002A251
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark GetMinorCTTickMark()
		{
			return this.ctValAx.minorTickMark;
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0002C05E File Offset: 0x0002A25E
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos GetCTAxPos()
		{
			return this.ctValAx.axPos;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0002C06B File Offset: 0x0002A26B
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt GetCTNumFmt()
		{
			if (this.ctValAx.IsSetNumFmt())
			{
				return this.ctValAx.numFmt;
			}
			return this.ctValAx.AddNewNumFmt();
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0002C091 File Offset: 0x0002A291
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling GetCTScaling()
		{
			return this.ctValAx.scaling;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0002C09E File Offset: 0x0002A29E
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses GetCTCrosses()
		{
			return this.ctValAx.crosses;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0002C0AB File Offset: 0x0002A2AB
		public override void CrossAxis(global::NPOI.SS.UserModel.Charts.IChartAxis axis)
		{
			this.ctValAx.crossAx.val = (uint)axis.Id;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0002C0C4 File Offset: 0x0002A2C4
		private void CreateAxis(long id, global::NPOI.SS.UserModel.Charts.AxisPosition pos)
		{
			this.ctValAx = this.chart.GetCTChart().plotArea.AddNewValAx();
			this.ctValAx.AddNewAxId().val = (uint)id;
			this.ctValAx.AddNewAxPos();
			this.ctValAx.AddNewScaling();
			this.ctValAx.AddNewCrossBetween();
			this.ctValAx.AddNewCrosses();
			this.ctValAx.AddNewCrossAx();
			this.ctValAx.AddNewTickLblPos().val = global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickLblPos.nextTo;
			this.ctValAx.AddNewDelete();
			this.ctValAx.AddNewMajorTickMark();
			this.ctValAx.AddNewMinorTickMark();
			base.Position = pos;
			base.Orientation = global::NPOI.SS.UserModel.Charts.AxisOrientation.MinToMax;
			this.SetCrossBetween(global::NPOI.SS.UserModel.Charts.AxisCrossBetween.MidpointCategory);
			base.Crosses = global::NPOI.SS.UserModel.Charts.AxisCrosses.AutoZero;
			base.IsVisible = true;
			base.MajorTickMark = global::NPOI.SS.UserModel.Charts.AxisTickMark.Cross;
			base.MinorTickMark = global::NPOI.SS.UserModel.Charts.AxisTickMark.None;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0002C1A0 File Offset: 0x0002A3A0
		private static global::NPOI.OpenXmlFormats.Dml.Chart.ST_CrossBetween fromCrossBetween(global::NPOI.SS.UserModel.Charts.AxisCrossBetween crossBetween)
		{
			if (crossBetween == global::NPOI.SS.UserModel.Charts.AxisCrossBetween.Between)
			{
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_CrossBetween.between;
			}
			if (crossBetween != global::NPOI.SS.UserModel.Charts.AxisCrossBetween.MidpointCategory)
			{
				throw new global::System.ArgumentException();
			}
			return global::NPOI.OpenXmlFormats.Dml.Chart.ST_CrossBetween.midCat;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0002C1A0 File Offset: 0x0002A3A0
		private static global::NPOI.SS.UserModel.Charts.AxisCrossBetween ToCrossBetween(global::NPOI.OpenXmlFormats.Dml.Chart.ST_CrossBetween ctCrossBetween)
		{
			if (ctCrossBetween == global::NPOI.OpenXmlFormats.Dml.Chart.ST_CrossBetween.between)
			{
				return global::NPOI.SS.UserModel.Charts.AxisCrossBetween.Between;
			}
			if (ctCrossBetween != global::NPOI.OpenXmlFormats.Dml.Chart.ST_CrossBetween.midCat)
			{
				throw new global::System.ArgumentException();
			}
			return global::NPOI.SS.UserModel.Charts.AxisCrossBetween.MidpointCategory;
		}

		// Token: 0x040003CD RID: 973
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx ctValAx;
	}
}
