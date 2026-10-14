using System;
using System.Collections.Generic;
using System.Drawing;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.UserModel;
using NPOI.SS.UserModel.Charts;

namespace NPOI.XSSF.UserModel.Charts
{
	// Token: 0x020000B7 RID: 183
	public class XSSFBarChartData<Tx, Ty> : global::NPOI.SS.UserModel.Charts.IBarChartData<Tx, Ty>, global::NPOI.SS.UserModel.Charts.IChartData
	{
		// Token: 0x06000B70 RID: 2928 RVA: 0x0002ADA3 File Offset: 0x00028FA3
		public XSSFBarChartData()
		{
			this.series = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.IBarChartSeries<Tx, Ty>>();
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0002ADB8 File Offset: 0x00028FB8
		public global::NPOI.SS.UserModel.Charts.IBarChartSeries<Tx, Ty> AddSeries(global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> categoryAxisData, global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> values)
		{
			if (!values.IsNumeric)
			{
				throw new global::System.ArgumentException("Value data source must be numeric.");
			}
			int count = this.series.Count;
			global::NPOI.XSSF.UserModel.Charts.XSSFBarChartData<Tx, Ty>.Series series = new global::NPOI.XSSF.UserModel.Charts.XSSFBarChartData<Tx, Ty>.Series(count, count, categoryAxisData, values);
			this.series.Add(series);
			return series;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0002ADF9 File Offset: 0x00028FF9
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.IBarChartSeries<Tx, Ty>> GetSeries()
		{
			return this.series;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0002AE04 File Offset: 0x00029004
		public void FillChart(global::NPOI.SS.UserModel.IChart chart, params global::NPOI.SS.UserModel.Charts.IChartAxis[] axis)
		{
			if (!(chart is global::NPOI.XSSF.UserModel.XSSFChart))
			{
				throw new global::System.ArgumentException("Chart must be instance of XSSFChart");
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea plotArea = ((global::NPOI.XSSF.UserModel.XSSFChart)chart).GetCTChart().plotArea;
			int allSeriesCount = plotArea.GetAllSeriesCount();
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart ct_BarChart = plotArea.AddNewBarChart();
			ct_BarChart.AddNewVaryColors().val = 0;
			for (int i = 0; i < this.series.Count; i++)
			{
				global::NPOI.XSSF.UserModel.Charts.XSSFBarChartData<Tx, Ty>.Series series = (global::NPOI.XSSF.UserModel.Charts.XSSFBarChartData<Tx, Ty>.Series)this.series[i];
				series.SetId(allSeriesCount + i);
				series.SetOrder(allSeriesCount + i);
				series.AddToChart(ct_BarChart);
			}
			foreach (global::NPOI.SS.UserModel.Charts.IChartAxis chartAxis in axis)
			{
				ct_BarChart.AddNewAxId().val = (uint)chartAxis.Id;
			}
		}

		// Token: 0x040003C0 RID: 960
		private global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.IBarChartSeries<Tx, Ty>> series;

		// Token: 0x02000142 RID: 322
		public class Series : global::NPOI.XSSF.UserModel.Charts.AbstractXSSFChartSeries, global::NPOI.SS.UserModel.Charts.IBarChartSeries<Tx, Ty>, global::NPOI.SS.UserModel.Charts.IChartSeries
		{
			// Token: 0x06001031 RID: 4145 RVA: 0x00038DD2 File Offset: 0x00036FD2
			internal Series(int id, int order, global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> categories, global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> values)
			{
				this.id = id;
				this.order = order;
				this.categories = categories;
				this.values = values;
			}

			// Token: 0x06001032 RID: 4146 RVA: 0x00038DF7 File Offset: 0x00036FF7
			public void SetId(int id)
			{
				this.id = id;
			}

			// Token: 0x06001033 RID: 4147 RVA: 0x00038E00 File Offset: 0x00037000
			public void SetOrder(int order)
			{
				this.order = order;
			}

			// Token: 0x06001034 RID: 4148 RVA: 0x00038E09 File Offset: 0x00037009
			public void SetFillColor(global::System.Drawing.Color color)
			{
				this.fillColor = new byte[3];
				this.fillColor[0] = color.R;
				this.fillColor[1] = color.G;
				this.fillColor[2] = color.B;
			}

			// Token: 0x06001035 RID: 4149 RVA: 0x00038E44 File Offset: 0x00037044
			public global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> GetCategoryAxisData()
			{
				return this.categories;
			}

			// Token: 0x06001036 RID: 4150 RVA: 0x00038E4C File Offset: 0x0003704C
			public global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> GetValues()
			{
				return this.values;
			}

			// Token: 0x06001037 RID: 4151 RVA: 0x00038E54 File Offset: 0x00037054
			internal void AddToChart(global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart ctBarChart)
			{
				global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer ct_BarSer = ctBarChart.AddNewSer();
				ctBarChart.AddNewGrouping().val = global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarGrouping.clustered;
				ct_BarSer.AddNewIdx().val = (uint)this.id;
				ct_BarSer.AddNewOrder().val = (uint)this.order;
				ct_BarSer.invertIfNegative = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean
				{
					val = 0
				};
				ctBarChart.AddNewBarDir().val = global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarDir.col;
				global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.BuildAxDataSource<Tx>(ct_BarSer.AddNewCat(), this.categories);
				global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.BuildNumDataSource<Ty>(ct_BarSer.AddNewVal(), this.values);
				if (base.IsTitleSet)
				{
					ct_BarSer.tx = base.GetCTSerTx();
				}
				if (this.fillColor != null)
				{
					ct_BarSer.spPr = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties();
					ct_BarSer.spPr.AddNewSolidFill().AddNewSrgbClr().val = this.fillColor;
				}
			}

			// Token: 0x04000516 RID: 1302
			private int id;

			// Token: 0x04000517 RID: 1303
			private int order;

			// Token: 0x04000518 RID: 1304
			private byte[] fillColor;

			// Token: 0x04000519 RID: 1305
			private global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> categories;

			// Token: 0x0400051A RID: 1306
			private global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> values;
		}
	}
}
