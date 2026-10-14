using System;
using System.Collections.Generic;
using System.Drawing;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.UserModel;
using NPOI.SS.UserModel.Charts;

namespace NPOI.XSSF.UserModel.Charts
{
	// Token: 0x020000BE RID: 190
	public class XSSFLineChartData<Tx, Ty> : global::NPOI.SS.UserModel.Charts.ILineChartData<Tx, Ty>, global::NPOI.SS.UserModel.Charts.IChartData
	{
		// Token: 0x06000BD6 RID: 3030 RVA: 0x0002B9AD File Offset: 0x00029BAD
		public XSSFLineChartData()
		{
			this.series = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.ILineChartSeries<Tx, Ty>>();
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0002B9C0 File Offset: 0x00029BC0
		public global::NPOI.SS.UserModel.Charts.ILineChartSeries<Tx, Ty> AddSeries(global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> categoryAxisData, global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> values)
		{
			if (!values.IsNumeric)
			{
				throw new global::System.ArgumentException("Value data source must be numeric.");
			}
			int count = this.series.Count;
			global::NPOI.XSSF.UserModel.Charts.XSSFLineChartData<Tx, Ty>.Series series = new global::NPOI.XSSF.UserModel.Charts.XSSFLineChartData<Tx, Ty>.Series(count, count, categoryAxisData, values);
			this.series.Add(series);
			return series;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0002BA01 File Offset: 0x00029C01
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.ILineChartSeries<Tx, Ty>> GetSeries()
		{
			return this.series;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0002BA0C File Offset: 0x00029C0C
		public void FillChart(global::NPOI.SS.UserModel.IChart chart, params global::NPOI.SS.UserModel.Charts.IChartAxis[] axis)
		{
			if (!(chart is global::NPOI.XSSF.UserModel.XSSFChart))
			{
				throw new global::System.ArgumentException("Chart must be instance of XSSFChart");
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea plotArea = ((global::NPOI.XSSF.UserModel.XSSFChart)chart).GetCTChart().plotArea;
			int allSeriesCount = plotArea.GetAllSeriesCount();
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart ct_LineChart = plotArea.AddNewLineChart();
			ct_LineChart.AddNewVaryColors().val = 0;
			for (int i = 0; i < this.series.Count; i++)
			{
				global::NPOI.XSSF.UserModel.Charts.XSSFLineChartData<Tx, Ty>.Series series = (global::NPOI.XSSF.UserModel.Charts.XSSFLineChartData<Tx, Ty>.Series)this.series[i];
				series.SetId(allSeriesCount + i);
				series.SetOrder(allSeriesCount + i);
				series.AddToChart(ct_LineChart);
			}
			foreach (global::NPOI.SS.UserModel.Charts.IChartAxis chartAxis in axis)
			{
				ct_LineChart.AddNewAxId().val = (uint)chartAxis.Id;
			}
		}

		// Token: 0x040003C8 RID: 968
		private global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.ILineChartSeries<Tx, Ty>> series;

		// Token: 0x02000143 RID: 323
		public class Series : global::NPOI.XSSF.UserModel.Charts.AbstractXSSFChartSeries, global::NPOI.SS.UserModel.Charts.ILineChartSeries<Tx, Ty>, global::NPOI.SS.UserModel.Charts.IChartSeries
		{
			// Token: 0x06001038 RID: 4152 RVA: 0x00038F1A File Offset: 0x0003711A
			internal Series(int id, int order, global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> categories, global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> values)
			{
				this.id = id;
				this.order = order;
				this.categories = categories;
				this.values = values;
			}

			// Token: 0x06001039 RID: 4153 RVA: 0x00038F3F File Offset: 0x0003713F
			public void SetId(int id)
			{
				this.id = id;
			}

			// Token: 0x0600103A RID: 4154 RVA: 0x00038F48 File Offset: 0x00037148
			public void SetOrder(int order)
			{
				this.order = order;
			}

			// Token: 0x0600103B RID: 4155 RVA: 0x00038F51 File Offset: 0x00037151
			public void SetFillColor(global::System.Drawing.Color color)
			{
				this.fillColor = new byte[3];
				this.fillColor[0] = color.R;
				this.fillColor[1] = color.G;
				this.fillColor[2] = color.B;
			}

			// Token: 0x0600103C RID: 4156 RVA: 0x00038F8C File Offset: 0x0003718C
			public global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> GetCategoryAxisData()
			{
				return this.categories;
			}

			// Token: 0x0600103D RID: 4157 RVA: 0x00038F94 File Offset: 0x00037194
			public global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> GetValues()
			{
				return this.values;
			}

			// Token: 0x0600103E RID: 4158 RVA: 0x00038F9C File Offset: 0x0003719C
			internal void AddToChart(global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart ctLineChart)
			{
				global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer ct_LineSer = ctLineChart.AddNewSer();
				ctLineChart.AddNewGrouping().val = global::NPOI.OpenXmlFormats.Dml.Chart.ST_Grouping.standard;
				ct_LineSer.AddNewIdx().val = (uint)this.id;
				ct_LineSer.AddNewOrder().val = (uint)this.order;
				ct_LineSer.AddNewMarker().AddNewSymbol().val = global::NPOI.OpenXmlFormats.Dml.Chart.ST_MarkerStyle.none;
				global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.BuildAxDataSource<Tx>(ct_LineSer.AddNewCat(), this.categories);
				global::NPOI.XSSF.UserModel.Charts.XSSFChartUtil.BuildNumDataSource<Ty>(ct_LineSer.AddNewVal(), this.values);
				if (base.IsTitleSet)
				{
					ct_LineSer.tx = base.GetCTSerTx();
				}
				if (this.fillColor != null)
				{
					ct_LineSer.spPr = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties();
					ct_LineSer.spPr.AddNewLn().AddNewSolidFill().AddNewSrgbClr().val = this.fillColor;
				}
			}

			// Token: 0x0400051B RID: 1307
			private int id;

			// Token: 0x0400051C RID: 1308
			private int order;

			// Token: 0x0400051D RID: 1309
			private byte[] fillColor;

			// Token: 0x0400051E RID: 1310
			private global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> categories;

			// Token: 0x0400051F RID: 1311
			private global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> values;
		}
	}
}
