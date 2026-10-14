using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.UserModel;
using NPOI.SS.UserModel.Charts;

namespace NPOI.XSSF.UserModel.Charts
{
	// Token: 0x020000C0 RID: 192
	public class XSSFScatterChartData<Tx, Ty> : global::NPOI.SS.UserModel.Charts.IScatterChartData<Tx, Ty>, global::NPOI.SS.UserModel.Charts.IChartData
	{
		// Token: 0x06000BF4 RID: 3060 RVA: 0x0002BEA6 File Offset: 0x0002A0A6
		public XSSFScatterChartData()
		{
			this.series = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.IScatterChartSeries<Tx, Ty>>();
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0002BEBC File Offset: 0x0002A0BC
		public global::NPOI.SS.UserModel.Charts.IScatterChartSeries<Tx, Ty> AddSeries(global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> xs, global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> ys)
		{
			if (!ys.IsNumeric)
			{
				throw new global::System.ArgumentException("Y axis data source must be numeric.");
			}
			int count = this.series.Count;
			global::NPOI.XSSF.UserModel.Charts.XSSFScatterChartData<Tx, Ty>.Series series = new global::NPOI.XSSF.UserModel.Charts.XSSFScatterChartData<Tx, Ty>.Series(count, count, xs, ys);
			this.series.Add(series);
			return series;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0002BF00 File Offset: 0x0002A100
		public void FillChart(global::NPOI.SS.UserModel.IChart chart, global::NPOI.SS.UserModel.Charts.IChartAxis[] axis)
		{
			if (!(chart is global::NPOI.XSSF.UserModel.XSSFChart))
			{
				throw new global::System.ArgumentException("Chart must be instance of XSSFChart");
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea plotArea = ((global::NPOI.XSSF.UserModel.XSSFChart)chart).GetCTChart().plotArea;
			int allSeriesCount = plotArea.GetAllSeriesCount();
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart ct_ScatterChart = plotArea.AddNewScatterChart();
			this.AddStyle(ct_ScatterChart);
			for (int i = 0; i < this.series.Count; i++)
			{
				global::NPOI.XSSF.UserModel.Charts.XSSFScatterChartData<Tx, Ty>.Series series = (global::NPOI.XSSF.UserModel.Charts.XSSFScatterChartData<Tx, Ty>.Series)this.series[i];
				series.SetId(allSeriesCount + i);
				series.SetOrder(allSeriesCount + i);
				series.AddToChart(ct_ScatterChart);
			}
			foreach (global::NPOI.SS.UserModel.Charts.IChartAxis chartAxis in axis)
			{
				ct_ScatterChart.AddNewAxId().val = (uint)chartAxis.Id;
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.IScatterChartSeries<Tx, Ty>> GetSeries()
		{
			return this.series;
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0002BFB8 File Offset: 0x0002A1B8
		private void AddStyle(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart ctScatterChart)
		{
			ctScatterChart.AddNewScatterStyle().val = global::NPOI.OpenXmlFormats.Dml.Chart.ST_ScatterStyle.lineMarker;
		}

		// Token: 0x040003CC RID: 972
		private global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.IScatterChartSeries<Tx, Ty>> series;

		// Token: 0x02000144 RID: 324
		internal class Series : global::NPOI.XSSF.UserModel.Charts.AbstractXSSFChartSeries, global::NPOI.SS.UserModel.Charts.IScatterChartSeries<Tx, Ty>, global::NPOI.SS.UserModel.Charts.IChartSeries
		{
			// Token: 0x0600103F RID: 4159 RVA: 0x00039058 File Offset: 0x00037258
			internal Series(int id, int order, global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> xs, global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> ys)
			{
				this.id = id;
				this.order = order;
				this.xs = xs;
				this.ys = ys;
			}

			// Token: 0x06001040 RID: 4160 RVA: 0x0003907D File Offset: 0x0003727D
			public void SetId(int id)
			{
				this.id = id;
			}

			// Token: 0x06001041 RID: 4161 RVA: 0x00039086 File Offset: 0x00037286
			public void SetOrder(int order)
			{
				this.order = order;
			}

			// Token: 0x06001042 RID: 4162 RVA: 0x0003908F File Offset: 0x0003728F
			public global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> GetXValues()
			{
				return this.xs;
			}

			// Token: 0x06001043 RID: 4163 RVA: 0x00039097 File Offset: 0x00037297
			public global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> GetYValues()
			{
				return this.ys;
			}

			// Token: 0x06001044 RID: 4164 RVA: 0x0003909F File Offset: 0x0003729F
			public void SetUseCache(bool useCache)
			{
				this.useCache = useCache;
			}

			// Token: 0x06001045 RID: 4165 RVA: 0x000390A8 File Offset: 0x000372A8
			internal void AddToChart(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart ctScatterChart)
			{
				global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer ct_ScatterSer = ctScatterChart.AddNewSer();
				ct_ScatterSer.AddNewIdx().val = (uint)this.id;
				ct_ScatterSer.AddNewOrder().val = (uint)this.order;
				global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.BuildAxDataSource<Tx>(ct_ScatterSer.AddNewXVal(), this.xs);
				global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.BuildNumDataSource<Ty>(ct_ScatterSer.AddNewYVal(), this.ys);
				if (base.IsTitleSet)
				{
					ct_ScatterSer.tx = base.GetCTSerTx();
				}
			}

			// Token: 0x04000520 RID: 1312
			private int id;

			// Token: 0x04000521 RID: 1313
			private int order;

			// Token: 0x04000522 RID: 1314
			private bool useCache;

			// Token: 0x04000523 RID: 1315
			private global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> xs;

			// Token: 0x04000524 RID: 1316
			private global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> ys;
		}
	}
}
