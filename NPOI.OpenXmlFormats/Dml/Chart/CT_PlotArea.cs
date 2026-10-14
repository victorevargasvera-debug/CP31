using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200045C RID: 1116
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PlotArea
	{
		// Token: 0x06002C5C RID: 11356 RVA: 0x0006F8C0 File Offset: 0x0006DAC0
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea ct_PlotArea = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea();
			ct_PlotArea.surfaceChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceChart>();
			ct_PlotArea.lineChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart>();
			ct_PlotArea.bubbleChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleChart>();
			ct_PlotArea.bar3DChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Bar3DChart>();
			ct_PlotArea.area3DChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Area3DChart>();
			ct_PlotArea.doughnutChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DoughnutChart>();
			ct_PlotArea.pie3DChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Pie3DChart>();
			ct_PlotArea.line3DChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Line3DChart>();
			ct_PlotArea.surface3DChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface3DChart>();
			ct_PlotArea.barChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart>();
			ct_PlotArea.radarChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarChart>();
			ct_PlotArea.areaChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaChart>();
			ct_PlotArea.scatterChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart>();
			ct_PlotArea.ofPieChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieChart>();
			ct_PlotArea.pieChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieChart>();
			ct_PlotArea.stockChart = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_StockChart>();
			ct_PlotArea.valAx = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx>();
			ct_PlotArea.serAx = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerAx>();
			ct_PlotArea.dateAx = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx>();
			ct_PlotArea.catAx = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx>();
			ct_PlotArea.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "layout")
				{
					ct_PlotArea.layout = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dTable")
				{
					ct_PlotArea.dTable = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DTable.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_PlotArea.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "surfaceChart")
				{
					ct_PlotArea.surfaceChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "lineChart")
				{
					ct_PlotArea.lineChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "bubbleChart")
				{
					ct_PlotArea.bubbleChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "bar3DChart")
				{
					ct_PlotArea.bar3DChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Bar3DChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "area3DChart")
				{
					ct_PlotArea.area3DChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Area3DChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "doughnutChart")
				{
					ct_PlotArea.doughnutChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_DoughnutChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "pie3DChart")
				{
					ct_PlotArea.pie3DChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Pie3DChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "line3DChart")
				{
					ct_PlotArea.line3DChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Line3DChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "surface3DChart")
				{
					ct_PlotArea.surface3DChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface3DChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "barChart")
				{
					ct_PlotArea.barChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "radarChart")
				{
					ct_PlotArea.radarChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "areaChart")
				{
					ct_PlotArea.areaChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "scatterChart")
				{
					ct_PlotArea.scatterChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "ofPieChart")
				{
					ct_PlotArea.ofPieChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "pieChart")
				{
					ct_PlotArea.pieChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "stockChart")
				{
					ct_PlotArea.stockChart.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_StockChart.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "valAx")
				{
					ct_PlotArea.valAx.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "serAx")
				{
					ct_PlotArea.serAx.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerAx.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "dateAx")
				{
					ct_PlotArea.dateAx.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "catAx")
				{
					ct_PlotArea.catAx.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_PlotArea.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PlotArea;
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x0006FDD4 File Offset: 0x0006DFD4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}>", nodeName));
			if (this.layout != null)
			{
				this.layout.Write(sw, "layout");
			}
			if (this.dTable != null)
			{
				this.dTable.Write(sw, "dTable");
			}
			if (this.surfaceChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceChart ct_SurfaceChart in this.surfaceChart)
				{
					ct_SurfaceChart.Write(sw, "surfaceChart");
				}
			}
			if (this.bubbleChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleChart ct_BubbleChart in this.bubbleChart)
				{
					ct_BubbleChart.Write(sw, "bubbleChart");
				}
			}
			if (this.bar3DChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Bar3DChart ct_Bar3DChart in this.bar3DChart)
				{
					ct_Bar3DChart.Write(sw, "bar3DChart");
				}
			}
			if (this.area3DChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Area3DChart ct_Area3DChart in this.area3DChart)
				{
					ct_Area3DChart.Write(sw, "area3DChart");
				}
			}
			if (this.doughnutChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_DoughnutChart ct_DoughnutChart in this.doughnutChart)
				{
					ct_DoughnutChart.Write(sw, "doughnutChart");
				}
			}
			if (this.pie3DChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Pie3DChart ct_Pie3DChart in this.pie3DChart)
				{
					ct_Pie3DChart.Write(sw, "pie3DChart");
				}
			}
			if (this.line3DChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Line3DChart ct_Line3DChart in this.line3DChart)
				{
					ct_Line3DChart.Write(sw, "line3DChart");
				}
			}
			if (this.surface3DChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface3DChart ct_Surface3DChart in this.surface3DChart)
				{
					ct_Surface3DChart.Write(sw, "surface3DChart");
				}
			}
			if (this.barChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart ct_BarChart in this.barChart)
				{
					ct_BarChart.Write(sw, "barChart");
				}
			}
			if (this.lineChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart ct_LineChart in this.lineChart)
				{
					ct_LineChart.Write(sw, "lineChart");
				}
			}
			if (this.radarChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarChart ct_RadarChart in this.radarChart)
				{
					ct_RadarChart.Write(sw, "radarChart");
				}
			}
			if (this.areaChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaChart ct_AreaChart in this.areaChart)
				{
					ct_AreaChart.Write(sw, "areaChart");
				}
			}
			if (this.scatterChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart ct_ScatterChart in this.scatterChart)
				{
					ct_ScatterChart.Write(sw, "scatterChart");
				}
			}
			if (this.ofPieChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieChart ct_OfPieChart in this.ofPieChart)
				{
					ct_OfPieChart.Write(sw, "ofPieChart");
				}
			}
			if (this.pieChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieChart ct_PieChart in this.pieChart)
				{
					ct_PieChart.Write(sw, "pieChart");
				}
			}
			if (this.stockChart != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_StockChart ct_StockChart in this.stockChart)
				{
					ct_StockChart.Write(sw, "stockChart");
				}
			}
			if (this.serAx != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerAx ct_SerAx in this.serAx)
				{
					ct_SerAx.Write(sw, "serAx");
				}
			}
			if (this.dateAx != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx ct_DateAx in this.dateAx)
				{
					ct_DateAx.Write(sw, "dateAx");
				}
			}
			if (this.catAx != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx ct_CatAx in this.catAx)
				{
					ct_CatAx.Write(sw, "catAx");
				}
			}
			if (this.valAx != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx ct_ValAx in this.valAx)
				{
					ct_ValAx.Write(sw, "valAx");
				}
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.extLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension ct_Extension in this.extLst)
				{
					ct_Extension.Write(sw, "extLst");
				}
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000705B0 File Offset: 0x0006E7B0
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx AddNewValAx()
		{
			if (this.valAxField == null)
			{
				this.valAxField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx>();
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx ct_ValAx = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx();
			this.valAxField.Add(ct_ValAx);
			return ct_ValAx;
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000705E4 File Offset: 0x0006E7E4
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerAx AddNewSerAx()
		{
			if (this.serAxField == null)
			{
				this.serAxField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerAx>();
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerAx ct_SerAx = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerAx();
			this.serAxField.Add(ct_SerAx);
			return ct_SerAx;
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x00070617 File Offset: 0x0006E817
		public bool IsSetLayout()
		{
			return this.layoutField != null;
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x00070622 File Offset: 0x0006E822
		// (set) Token: 0x06002C62 RID: 11362 RVA: 0x0007062A File Offset: 0x0006E82A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout layout
		{
			get
			{
				return this.layoutField;
			}
			set
			{
				this.layoutField = value;
			}
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x00070633 File Offset: 0x0006E833
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout AddNewLayout()
		{
			this.layoutField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout();
			return this.layoutField;
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x00070648 File Offset: 0x0006E848
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Pie3DChart AddNewPie3DChart()
		{
			if (this.pie3DChartField == null)
			{
				this.pie3DChartField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Pie3DChart>();
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Pie3DChart ct_Pie3DChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Pie3DChart();
			this.pie3DChartField.Add(ct_Pie3DChart);
			return ct_Pie3DChart;
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x0007067C File Offset: 0x0006E87C
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart AddNewScatterChart()
		{
			if (this.scatterChartField == null)
			{
				this.scatterChartField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart>();
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart ct_ScatterChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart();
			this.scatterChartField.Add(ct_ScatterChart);
			return ct_ScatterChart;
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000706B0 File Offset: 0x0006E8B0
		public int GetAllSeriesCount()
		{
			int num;
			if (this.surfaceChartField != null)
			{
				num = (from x in this.surfaceChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num = 0;
			}
			int num2;
			if (this.lineChartField != null)
			{
				num2 = (from x in this.lineChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num2 = 0;
			}
			int num3 = num + num2;
			int num4;
			if (this.bubbleChartField != null)
			{
				num4 = (from x in this.bubbleChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num4 = 0;
			}
			int num5 = num3 + num4;
			int num6;
			if (this.bar3DChartField != null)
			{
				num6 = (from x in this.bar3DChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num6 = 0;
			}
			int num7 = num5 + num6;
			int num8;
			if (this.area3DChartField != null)
			{
				num8 = (from x in this.area3DChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num8 = 0;
			}
			int num9 = num7 + num8;
			int num10;
			if (this.doughnutChartField != null)
			{
				num10 = (from x in this.doughnutChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num10 = 0;
			}
			int num11 = num9 + num10;
			int num12;
			if (this.pie3DChartField != null)
			{
				num12 = (from x in this.pie3DChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num12 = 0;
			}
			int num13 = num11 + num12;
			int num14;
			if (this.line3DChartField != null)
			{
				num14 = (from x in this.line3DChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num14 = 0;
			}
			int num15 = num13 + num14;
			int num16;
			if (this.surface3DChartField != null)
			{
				num16 = (from x in this.surface3DChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num16 = 0;
			}
			int num17 = num15 + num16;
			int num18;
			if (this.barChartField != null)
			{
				num18 = (from x in this.barChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num18 = 0;
			}
			int num19 = num17 + num18;
			int num20;
			if (this.radarChartField != null)
			{
				num20 = (from x in this.radarChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num20 = 0;
			}
			int num21 = num19 + num20;
			int num22;
			if (this.areaChartField != null)
			{
				num22 = (from x in this.areaChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num22 = 0;
			}
			int num23 = num21 + num22;
			int num24;
			if (this.scatterChartField != null)
			{
				num24 = (from x in this.scatterChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num24 = 0;
			}
			int num25 = num23 + num24;
			int num26;
			if (this.ofPieChartField != null)
			{
				num26 = (from x in this.ofPieChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num26 = 0;
			}
			int num27 = num25 + num26;
			int num28;
			if (this.pieChartField != null)
			{
				num28 = (from x in this.pieChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num28 = 0;
			}
			int num29 = num27 + num28;
			int num30;
			if (this.stockChartField != null)
			{
				num30 = (from x in this.stockChartField
				select x.GetSeriesCount()).Sum();
			}
			else
			{
				num30 = 0;
			}
			return num29 + num30;
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x00070A6C File Offset: 0x0006EC6C
		// (set) Token: 0x06002C68 RID: 11368 RVA: 0x00070A74 File Offset: 0x0006EC74
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceChart> surfaceChart
		{
			get
			{
				return this.surfaceChartField;
			}
			set
			{
				this.surfaceChartField = value;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x00070A7D File Offset: 0x0006EC7D
		// (set) Token: 0x06002C6A RID: 11370 RVA: 0x00070A85 File Offset: 0x0006EC85
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart> lineChart
		{
			get
			{
				return this.lineChartField;
			}
			set
			{
				this.lineChartField = value;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x00070A8E File Offset: 0x0006EC8E
		// (set) Token: 0x06002C6C RID: 11372 RVA: 0x00070A96 File Offset: 0x0006EC96
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleChart> bubbleChart
		{
			get
			{
				return this.bubbleChartField;
			}
			set
			{
				this.bubbleChartField = value;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06002C6D RID: 11373 RVA: 0x00070A9F File Offset: 0x0006EC9F
		// (set) Token: 0x06002C6E RID: 11374 RVA: 0x00070AA7 File Offset: 0x0006ECA7
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Bar3DChart> bar3DChart
		{
			get
			{
				return this.bar3DChartField;
			}
			set
			{
				this.bar3DChartField = value;
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06002C6F RID: 11375 RVA: 0x00070AB0 File Offset: 0x0006ECB0
		// (set) Token: 0x06002C70 RID: 11376 RVA: 0x00070AB8 File Offset: 0x0006ECB8
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Area3DChart> area3DChart
		{
			get
			{
				return this.area3DChartField;
			}
			set
			{
				this.area3DChartField = value;
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06002C71 RID: 11377 RVA: 0x00070AC1 File Offset: 0x0006ECC1
		// (set) Token: 0x06002C72 RID: 11378 RVA: 0x00070AC9 File Offset: 0x0006ECC9
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DoughnutChart> doughnutChart
		{
			get
			{
				return this.doughnutChartField;
			}
			set
			{
				this.doughnutChartField = value;
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x00070AD2 File Offset: 0x0006ECD2
		// (set) Token: 0x06002C74 RID: 11380 RVA: 0x00070ADA File Offset: 0x0006ECDA
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Pie3DChart> pie3DChart
		{
			get
			{
				return this.pie3DChartField;
			}
			set
			{
				this.pie3DChartField = value;
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06002C75 RID: 11381 RVA: 0x00070AE3 File Offset: 0x0006ECE3
		// (set) Token: 0x06002C76 RID: 11382 RVA: 0x00070AEB File Offset: 0x0006ECEB
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Line3DChart> line3DChart
		{
			get
			{
				return this.line3DChartField;
			}
			set
			{
				this.line3DChartField = value;
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06002C77 RID: 11383 RVA: 0x00070AF4 File Offset: 0x0006ECF4
		// (set) Token: 0x06002C78 RID: 11384 RVA: 0x00070AFC File Offset: 0x0006ECFC
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface3DChart> surface3DChart
		{
			get
			{
				return this.surface3DChartField;
			}
			set
			{
				this.surface3DChartField = value;
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x00070B05 File Offset: 0x0006ED05
		// (set) Token: 0x06002C7A RID: 11386 RVA: 0x00070B0D File Offset: 0x0006ED0D
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart> barChart
		{
			get
			{
				return this.barChartField;
			}
			set
			{
				this.barChartField = value;
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06002C7B RID: 11387 RVA: 0x00070B16 File Offset: 0x0006ED16
		// (set) Token: 0x06002C7C RID: 11388 RVA: 0x00070B1E File Offset: 0x0006ED1E
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarChart> radarChart
		{
			get
			{
				return this.radarChartField;
			}
			set
			{
				this.radarChartField = value;
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06002C7D RID: 11389 RVA: 0x00070B27 File Offset: 0x0006ED27
		// (set) Token: 0x06002C7E RID: 11390 RVA: 0x00070B2F File Offset: 0x0006ED2F
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaChart> areaChart
		{
			get
			{
				return this.areaChartField;
			}
			set
			{
				this.areaChartField = value;
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06002C7F RID: 11391 RVA: 0x00070B38 File Offset: 0x0006ED38
		// (set) Token: 0x06002C80 RID: 11392 RVA: 0x00070B40 File Offset: 0x0006ED40
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart> scatterChart
		{
			get
			{
				return this.scatterChartField;
			}
			set
			{
				this.scatterChartField = value;
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06002C81 RID: 11393 RVA: 0x00070B49 File Offset: 0x0006ED49
		// (set) Token: 0x06002C82 RID: 11394 RVA: 0x00070B51 File Offset: 0x0006ED51
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieChart> ofPieChart
		{
			get
			{
				return this.ofPieChartField;
			}
			set
			{
				this.ofPieChartField = value;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06002C83 RID: 11395 RVA: 0x00070B5A File Offset: 0x0006ED5A
		// (set) Token: 0x06002C84 RID: 11396 RVA: 0x00070B62 File Offset: 0x0006ED62
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieChart> pieChart
		{
			get
			{
				return this.pieChartField;
			}
			set
			{
				this.pieChartField = value;
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06002C85 RID: 11397 RVA: 0x00070B6B File Offset: 0x0006ED6B
		// (set) Token: 0x06002C86 RID: 11398 RVA: 0x00070B73 File Offset: 0x0006ED73
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_StockChart> stockChart
		{
			get
			{
				return this.stockChartField;
			}
			set
			{
				this.stockChartField = value;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06002C87 RID: 11399 RVA: 0x00070B7C File Offset: 0x0006ED7C
		// (set) Token: 0x06002C88 RID: 11400 RVA: 0x00070B84 File Offset: 0x0006ED84
		[global::System.Xml.Serialization.XmlElement(Order = 21)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx> valAx
		{
			get
			{
				return this.valAxField;
			}
			set
			{
				this.valAxField = value;
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x00070B8D File Offset: 0x0006ED8D
		// (set) Token: 0x06002C8A RID: 11402 RVA: 0x00070B95 File Offset: 0x0006ED95
		[global::System.Xml.Serialization.XmlElement(Order = 22)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerAx> serAx
		{
			get
			{
				return this.serAxField;
			}
			set
			{
				this.serAxField = value;
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06002C8B RID: 11403 RVA: 0x00070B9E File Offset: 0x0006ED9E
		// (set) Token: 0x06002C8C RID: 11404 RVA: 0x00070BA6 File Offset: 0x0006EDA6
		[global::System.Xml.Serialization.XmlElement(Order = 23)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx> dateAx
		{
			get
			{
				return this.dateAxField;
			}
			set
			{
				this.dateAxField = value;
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06002C8D RID: 11405 RVA: 0x00070BAF File Offset: 0x0006EDAF
		// (set) Token: 0x06002C8E RID: 11406 RVA: 0x00070BB7 File Offset: 0x0006EDB7
		[global::System.Xml.Serialization.XmlElement(Order = 24)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx> catAx
		{
			get
			{
				return this.catAxField;
			}
			set
			{
				this.catAxField = value;
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x00070BC0 File Offset: 0x0006EDC0
		// (set) Token: 0x06002C90 RID: 11408 RVA: 0x00070BC8 File Offset: 0x0006EDC8
		[global::System.Xml.Serialization.XmlElement(Order = 25)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_DTable dTable
		{
			get
			{
				return this.dTableField;
			}
			set
			{
				this.dTableField = value;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x00070BD1 File Offset: 0x0006EDD1
		// (set) Token: 0x06002C92 RID: 11410 RVA: 0x00070BD9 File Offset: 0x0006EDD9
		[global::System.Xml.Serialization.XmlElement(Order = 26)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPr
		{
			get
			{
				return this.spPrField;
			}
			set
			{
				this.spPrField = value;
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x00070BE2 File Offset: 0x0006EDE2
		// (set) Token: 0x06002C94 RID: 11412 RVA: 0x00070BEA File Offset: 0x0006EDEA
		[global::System.Xml.Serialization.XmlElement(Order = 27)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x00070BF4 File Offset: 0x0006EDF4
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart AddNewBarChart()
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart ct_BarChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart();
			if (this.barChartField == null)
			{
				this.barChartField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart>();
			}
			this.barChartField.Add(ct_BarChart);
			return ct_BarChart;
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x00070C28 File Offset: 0x0006EE28
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart AddNewLineChart()
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart ct_LineChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart();
			if (this.lineChartField == null)
			{
				this.lineChartField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart>();
			}
			this.lineChartField.Add(ct_LineChart);
			return ct_LineChart;
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00070C5C File Offset: 0x0006EE5C
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx AddNewCatAx()
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx ct_CatAx = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx();
			if (this.catAxField == null)
			{
				this.catAxField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx>();
			}
			this.catAxField.Add(ct_CatAx);
			return ct_CatAx;
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x00070C90 File Offset: 0x0006EE90
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx AddNewDateAx()
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx ct_DateAx = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx();
			if (this.dateAxField == null)
			{
				this.dateAxField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx>();
			}
			this.dateAxField.Add(ct_DateAx);
			return ct_DateAx;
		}

		// Token: 0x04001F3A RID: 7994
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout layoutField;

		// Token: 0x04001F3B RID: 7995
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DTable dTableField;

		// Token: 0x04001F3C RID: 7996
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001F3D RID: 7997
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;

		// Token: 0x04001F3E RID: 7998
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx> valAxField;

		// Token: 0x04001F3F RID: 7999
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerAx> serAxField;

		// Token: 0x04001F40 RID: 8000
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx> catAxField;

		// Token: 0x04001F41 RID: 8001
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx> dateAxField;

		// Token: 0x04001F42 RID: 8002
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceChart> surfaceChartField;

		// Token: 0x04001F43 RID: 8003
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart> lineChartField;

		// Token: 0x04001F44 RID: 8004
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleChart> bubbleChartField;

		// Token: 0x04001F45 RID: 8005
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Bar3DChart> bar3DChartField;

		// Token: 0x04001F46 RID: 8006
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Area3DChart> area3DChartField;

		// Token: 0x04001F47 RID: 8007
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DoughnutChart> doughnutChartField;

		// Token: 0x04001F48 RID: 8008
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Pie3DChart> pie3DChartField;

		// Token: 0x04001F49 RID: 8009
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Line3DChart> line3DChartField;

		// Token: 0x04001F4A RID: 8010
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface3DChart> surface3DChartField;

		// Token: 0x04001F4B RID: 8011
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart> barChartField;

		// Token: 0x04001F4C RID: 8012
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarChart> radarChartField;

		// Token: 0x04001F4D RID: 8013
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaChart> areaChartField;

		// Token: 0x04001F4E RID: 8014
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart> scatterChartField;

		// Token: 0x04001F4F RID: 8015
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieChart> ofPieChartField;

		// Token: 0x04001F50 RID: 8016
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieChart> pieChartField;

		// Token: 0x04001F51 RID: 8017
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_StockChart> stockChartField;
	}
}
