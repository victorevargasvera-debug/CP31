using System;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.UserModel.Charts;

namespace NPOI.XSSF.UserModel.Charts
{
	// Token: 0x020000B8 RID: 184
	public class XSSFCategoryAxis : global::NPOI.XSSF.UserModel.Charts.XSSFChartAxis
	{
		// Token: 0x06000B74 RID: 2932 RVA: 0x0002AEB9 File Offset: 0x000290B9
		public XSSFCategoryAxis(global::NPOI.XSSF.UserModel.XSSFChart chart, long id, global::NPOI.SS.UserModel.Charts.AxisPosition pos) : base(chart)
		{
			this.createAxis(id, pos);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0002AECA File Offset: 0x000290CA
		public XSSFCategoryAxis(global::NPOI.XSSF.UserModel.XSSFChart chart, global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx ctCatAx) : base(chart)
		{
			this.ctCatAx = ctCatAx;
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0002AEDA File Offset: 0x000290DA
		public override long Id
		{
			get
			{
				return (long)((ulong)this.ctCatAx.axId.val);
			}
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0002AEED File Offset: 0x000290ED
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos GetCTAxPos()
		{
			return this.ctCatAx.axPos;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0002AEFA File Offset: 0x000290FA
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt GetCTNumFmt()
		{
			if (this.ctCatAx.IsSetNumFmt())
			{
				return this.ctCatAx.numFmt;
			}
			return this.ctCatAx.AddNewNumFmt();
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0002AF20 File Offset: 0x00029120
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling GetCTScaling()
		{
			return this.ctCatAx.scaling;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0002AF2D File Offset: 0x0002912D
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses GetCTCrosses()
		{
			return this.ctCatAx.crosses;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0002AF3A File Offset: 0x0002913A
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean GetDelete()
		{
			return this.ctCatAx.delete;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0002AF47 File Offset: 0x00029147
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark GetMajorCTTickMark()
		{
			return this.ctCatAx.majorTickMark;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0002AF54 File Offset: 0x00029154
		public void SetMajorCTTickMark(global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark tm)
		{
			this.ctCatAx.majorTickMark = tm;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0002AF62 File Offset: 0x00029162
		protected override global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark GetMinorCTTickMark()
		{
			return this.ctCatAx.minorTickMark;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0002AF6F File Offset: 0x0002916F
		public override void CrossAxis(global::NPOI.SS.UserModel.Charts.IChartAxis axis)
		{
			this.ctCatAx.crossAx.val = (uint)axis.Id;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0002AF88 File Offset: 0x00029188
		public void SetAuto(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean au)
		{
			this.ctCatAx.auto = au;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0002AF98 File Offset: 0x00029198
		private void createAxis(long id, global::NPOI.SS.UserModel.Charts.AxisPosition pos)
		{
			this.ctCatAx = this.chart.GetCTChart().plotArea.AddNewCatAx();
			this.ctCatAx.AddNewAxId().val = (uint)id;
			this.ctCatAx.AddNewAxPos();
			this.ctCatAx.AddNewScaling();
			this.ctCatAx.AddNewCrosses();
			this.ctCatAx.AddNewCrossAx();
			this.ctCatAx.AddNewTickLblPos().val = global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickLblPos.nextTo;
			this.ctCatAx.AddNewDelete();
			this.ctCatAx.AddNewMajorTickMark();
			this.ctCatAx.AddNewMinorTickMark();
			base.Position = pos;
			base.Orientation = global::NPOI.SS.UserModel.Charts.AxisOrientation.MinToMax;
			base.Crosses = global::NPOI.SS.UserModel.Charts.AxisCrosses.AutoZero;
			base.IsVisible = true;
			base.MajorTickMark = global::NPOI.SS.UserModel.Charts.AxisTickMark.Cross;
			base.MinorTickMark = global::NPOI.SS.UserModel.Charts.AxisTickMark.None;
		}

		// Token: 0x040003C1 RID: 961
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx ctCatAx;
	}
}
