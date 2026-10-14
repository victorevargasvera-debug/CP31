using System;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.UserModel.Charts;

namespace NPOI.XSSF.UserModel.Charts
{
	// Token: 0x020000BB RID: 187
	public class XSSFChartLegend : global::NPOI.SS.UserModel.Charts.IChartLegend, global::NPOI.SS.UserModel.Charts.ManuallyPositionable
	{
		// Token: 0x06000BB1 RID: 2993 RVA: 0x0002B4C0 File Offset: 0x000296C0
		public XSSFChartLegend(global::NPOI.XSSF.UserModel.XSSFChart chart)
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Chart ctchart = chart.GetCTChart();
			this.legend = (ctchart.IsSetLegend() ? ctchart.legend : ctchart.AddNewLegend());
			this.SetDefaults();
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0002B4FC File Offset: 0x000296FC
		private void SetDefaults()
		{
			if (!this.legend.IsSetOverlay())
			{
				this.legend.AddNewOverlay();
			}
			this.legend.overlay.val = 0;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0002B527 File Offset: 0x00029727
		internal global::NPOI.OpenXmlFormats.Dml.Chart.CT_Legend GetCTLegend()
		{
			return this.legend;
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0002B52F File Offset: 0x0002972F
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0002B551 File Offset: 0x00029751
		public global::NPOI.SS.UserModel.Charts.LegendPosition Position
		{
			get
			{
				if (this.legend.IsSetLegendPos())
				{
					return this.ToLegendPosition(this.legend.legendPos);
				}
				return global::NPOI.SS.UserModel.Charts.LegendPosition.Right;
			}
			set
			{
				if (!this.legend.IsSetLegendPos())
				{
					this.legend.AddNewLegendPos();
				}
				this.legend.legendPos.val = this.FromLegendPosition(value);
				this.legend.legendPosSpecified = true;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0002B58F File Offset: 0x0002978F
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x0002B5A4 File Offset: 0x000297A4
		public bool IsOverlay
		{
			get
			{
				return this.legend.overlay.val != 0;
			}
			set
			{
				this.legend.overlay.val = (value ? 1 : 0);
			}
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0002B5BD File Offset: 0x000297BD
		public global::NPOI.SS.UserModel.Charts.IManualLayout GetManualLayout()
		{
			if (!this.legend.IsSetLayout())
			{
				this.legend.AddNewLayout();
			}
			return new global::NPOI.XSSF.UserModel.Charts.XSSFManualLayout(this.legend.layout);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0002B5E8 File Offset: 0x000297E8
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos FromLegendPosition(global::NPOI.SS.UserModel.Charts.LegendPosition position)
		{
			switch (position)
			{
			case global::NPOI.SS.UserModel.Charts.LegendPosition.Bottom:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.b;
			case global::NPOI.SS.UserModel.Charts.LegendPosition.Left:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.l;
			case global::NPOI.SS.UserModel.Charts.LegendPosition.Right:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.r;
			case global::NPOI.SS.UserModel.Charts.LegendPosition.Top:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.t;
			case global::NPOI.SS.UserModel.Charts.LegendPosition.TopRight:
				return global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.tr;
			default:
				throw new global::System.ArgumentException();
			}
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0002B618 File Offset: 0x00029818
		private global::NPOI.SS.UserModel.Charts.LegendPosition ToLegendPosition(global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendPos ctLegendPos)
		{
			switch (ctLegendPos.val)
			{
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.b:
				return global::NPOI.SS.UserModel.Charts.LegendPosition.Bottom;
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.tr:
				return global::NPOI.SS.UserModel.Charts.LegendPosition.TopRight;
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.l:
				return global::NPOI.SS.UserModel.Charts.LegendPosition.Left;
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.r:
				return global::NPOI.SS.UserModel.Charts.LegendPosition.Right;
			case global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.t:
				return global::NPOI.SS.UserModel.Charts.LegendPosition.Top;
			default:
				throw new global::System.ArgumentException();
			}
		}

		// Token: 0x040003C6 RID: 966
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Legend legend;
	}
}
