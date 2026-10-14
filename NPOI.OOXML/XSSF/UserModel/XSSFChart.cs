using System;
using System.Collections.Generic;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Chart;
using NPOI.SS.UserModel;
using NPOI.SS.UserModel.Charts;
using NPOI.XSSF.UserModel.Charts;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200006B RID: 107
	public class XSSFChart : global::NPOI.POIXMLDocumentPart, global::NPOI.SS.UserModel.IChart, global::NPOI.SS.UserModel.Charts.ManuallyPositionable, global::NPOI.SS.UserModel.Charts.IChartAxisFactory
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x00013E16 File Offset: 0x00012016
		public XSSFChart()
		{
			this.CreateChart();
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00013E30 File Offset: 0x00012030
		protected XSSFChart(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			global::System.Xml.XmlDocument xmldoc = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(part.GetInputStream());
			this.chartSpaceDocument = global::NPOI.OpenXmlFormats.Dml.ChartSpaceDocument.Parse(xmldoc, global::NPOI.POIXMLDocumentPart.NamespaceManager);
			this.chart = this.chartSpaceDocument.GetChartSpace().chart;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00013E82 File Offset: 0x00012082
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		protected XSSFChart(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00013E8C File Offset: 0x0001208C
		private void CreateChart()
		{
			this.chartSpaceDocument = new global::NPOI.OpenXmlFormats.Dml.ChartSpaceDocument();
			this.chart = this.chartSpaceDocument.GetChartSpace().AddNewChart();
			this.chart.AddNewPlotArea().AddNewLayout();
			this.chart.AddNewPlotVisOnly().val = 1;
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PrintSettings ct_PrintSettings = this.chartSpaceDocument.GetChartSpace().AddNewPrintSettings();
			ct_PrintSettings.AddNewHeaderFooter();
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageMargins ct_PageMargins = ct_PrintSettings.AddNewPageMargins();
			ct_PageMargins.b = 0.75;
			ct_PageMargins.l = 0.7;
			ct_PageMargins.r = 0.7;
			ct_PageMargins.t = 0.75;
			ct_PageMargins.header = 0.3;
			ct_PageMargins.footer = 0.3;
			ct_PrintSettings.AddNewPageSetup();
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00013F58 File Offset: 0x00012158
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartSpace GetCTChartSpace()
		{
			return this.chartSpaceDocument.GetChartSpace();
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00013F65 File Offset: 0x00012165
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Chart GetCTChart()
		{
			return this.chart;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00013F70 File Offset: 0x00012170
		protected internal override void Commit()
		{
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = base.GetPackagePart();
			this.chartSpaceDocument.Save(packagePart.GetOutputStream());
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00013F95 File Offset: 0x00012195
		public global::NPOI.XSSF.UserModel.XSSFGraphicFrame GetGraphicFrame()
		{
			return this.frame;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00013F9D File Offset: 0x0001219D
		internal void SetGraphicFrame(global::NPOI.XSSF.UserModel.XSSFGraphicFrame frame)
		{
			this.frame = frame;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00013FA6 File Offset: 0x000121A6
		public global::NPOI.SS.UserModel.Charts.IChartDataFactory ChartDataFactory
		{
			get
			{
				return global::NPOI.XSSF.UserModel.Charts.XSSFChartDataFactory.GetInstance();
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00006FB7 File Offset: 0x000051B7
		public global::NPOI.SS.UserModel.Charts.IChartAxisFactory ChartAxisFactory
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00013FAD File Offset: 0x000121AD
		public void Plot(global::NPOI.SS.UserModel.Charts.IChartData data, params global::NPOI.SS.UserModel.Charts.IChartAxis[] axis)
		{
			data.FillChart(this, axis);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00013FB8 File Offset: 0x000121B8
		public global::NPOI.SS.UserModel.Charts.IValueAxis CreateValueAxis(global::NPOI.SS.UserModel.Charts.AxisPosition pos)
		{
			long id = (long)(this.axis.Count + 1);
			global::NPOI.XSSF.UserModel.Charts.XSSFValueAxis xssfvalueAxis = new global::NPOI.XSSF.UserModel.Charts.XSSFValueAxis(this, id, pos);
			if (this.axis.Count == 1)
			{
				global::NPOI.SS.UserModel.Charts.IChartAxis chartAxis = this.axis[0];
				chartAxis.CrossAxis(xssfvalueAxis);
				xssfvalueAxis.CrossAxis(chartAxis);
			}
			this.axis.Add(xssfvalueAxis);
			return xssfvalueAxis;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00014014 File Offset: 0x00012214
		public global::NPOI.SS.UserModel.Charts.IChartAxis CreateCategoryAxis(global::NPOI.SS.UserModel.Charts.AxisPosition pos)
		{
			long id = (long)(this.axis.Count + 1);
			global::NPOI.XSSF.UserModel.Charts.XSSFCategoryAxis xssfcategoryAxis = new global::NPOI.XSSF.UserModel.Charts.XSSFCategoryAxis(this, id, pos);
			if (this.axis.Count == 1)
			{
				global::NPOI.SS.UserModel.Charts.IChartAxis chartAxis = this.axis[0];
				chartAxis.CrossAxis(xssfcategoryAxis);
				xssfcategoryAxis.CrossAxis(chartAxis);
			}
			this.axis.Add(xssfcategoryAxis);
			return xssfcategoryAxis;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00014070 File Offset: 0x00012270
		public global::NPOI.SS.UserModel.Charts.IChartAxis CreateDateAxis(global::NPOI.SS.UserModel.Charts.AxisPosition pos)
		{
			long id = (long)(this.axis.Count + 1);
			global::NPOI.XSSF.UserModel.Charts.XSSFDateAxis xssfdateAxis = new global::NPOI.XSSF.UserModel.Charts.XSSFDateAxis(this, id, pos);
			if (this.axis.Count == 1)
			{
				global::NPOI.SS.UserModel.Charts.IChartAxis chartAxis = this.axis[0];
				chartAxis.CrossAxis(xssfdateAxis);
				xssfdateAxis.CrossAxis(chartAxis);
			}
			this.axis.Add(xssfdateAxis);
			return xssfdateAxis;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000140CB File Offset: 0x000122CB
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.IChartAxis> GetAxis()
		{
			if (this.axis.Count == 0 && this.HasAxis())
			{
				this.ParseAxis();
			}
			return this.axis;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000140EE File Offset: 0x000122EE
		public global::NPOI.SS.UserModel.Charts.IManualLayout GetManualLayout()
		{
			return new global::NPOI.XSSF.UserModel.Charts.XSSFManualLayout(this);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000140F6 File Offset: 0x000122F6
		public bool IsPlotOnlyVisibleCells()
		{
			return this.chart.plotVisOnly.val == 1;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001410E File Offset: 0x0001230E
		public void SetPlotOnlyVisibleCells(bool plotVisOnly)
		{
			this.chart.plotVisOnly.val = (plotVisOnly ? 1 : 0);
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00014128 File Offset: 0x00012328
		public global::NPOI.XSSF.UserModel.XSSFRichTextString Title
		{
			get
			{
				if (!this.chart.IsSetTitle())
				{
					return null;
				}
				global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title title = this.chart.title;
				if (title.tx == null)
				{
					return null;
				}
				if (title.tx.rich == null)
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFRichTextString(title.tx.rich.ToString());
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00014180 File Offset: 0x00012380
		public void SetTitle(string newTitle)
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title ct_Title;
			if (this.chart.IsSetTitle())
			{
				ct_Title = this.chart.title;
			}
			else
			{
				ct_Title = this.chart.AddNewTitle();
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx ct_Tx;
			if (ct_Title.IsSetTx())
			{
				ct_Tx = ct_Title.tx;
			}
			else
			{
				ct_Tx = ct_Title.AddNewTx();
			}
			if (ct_Tx.IsSetStrRef())
			{
				ct_Tx.UnsetStrRef();
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody ct_TextBody;
			if (ct_Tx.IsSetRich())
			{
				ct_TextBody = ct_Tx.rich;
			}
			else
			{
				ct_TextBody = ct_Tx.AddNewRich();
				ct_TextBody.AddNewBodyPr();
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph ct_TextParagraph;
			if (ct_TextBody.SizeOfPArray() > 0)
			{
				ct_TextParagraph = ct_TextBody.GetPArray(0);
			}
			else
			{
				ct_TextParagraph = ct_TextBody.AddNewP();
			}
			if (ct_TextParagraph.SizeOfRArray() > 0)
			{
				ct_TextParagraph.GetRArray(0).t = newTitle;
				return;
			}
			if (ct_TextParagraph.SizeOfFldArray() > 0)
			{
				ct_TextParagraph.GetFldArray(0).t = newTitle;
				return;
			}
			ct_TextParagraph.AddNewR().t = newTitle;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001424D File Offset: 0x0001244D
		public global::NPOI.SS.UserModel.Charts.IChartLegend GetOrCreateLegend()
		{
			return new global::NPOI.XSSF.UserModel.Charts.XSSFChartLegend(this);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00014255 File Offset: 0x00012455
		public void DeleteLegend()
		{
			if (this.chart.IsSetLegend())
			{
				this.chart.unsetLegend();
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001426F File Offset: 0x0001246F
		public void SetCTDispBlanksAs(global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispBlanksAs disp)
		{
			this.chart.dispBlanksAs = disp;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00014280 File Offset: 0x00012480
		private bool HasAxis()
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea plotArea = this.chart.plotArea;
			return ((plotArea.valAx == null) ? 0 : plotArea.valAx.Count) + ((plotArea.catAx == null) ? 0 : plotArea.catAx.Count) + ((plotArea.dateAx == null) ? 0 : plotArea.dateAx.Count) + ((plotArea.serAx == null) ? 0 : plotArea.serAx.Count) > 0;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000142F7 File Offset: 0x000124F7
		private void ParseAxis()
		{
			this.ParseCategoryAxis();
			this.ParseValueAxis();
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00014308 File Offset: 0x00012508
		private void ParseCategoryAxis()
		{
			if (this.chart.plotArea.catAx == null)
			{
				return;
			}
			foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx ctCatAx in this.chart.plotArea.catAx)
			{
				this.axis.Add(new global::NPOI.XSSF.UserModel.Charts.XSSFCategoryAxis(this, ctCatAx));
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00014384 File Offset: 0x00012584
		private void ParseValueAxis()
		{
			if (this.chart.plotArea.valAx == null)
			{
				return;
			}
			foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx ctValAx in this.chart.plotArea.valAx)
			{
				this.axis.Add(new global::NPOI.XSSF.UserModel.Charts.XSSFValueAxis(this, ctValAx));
			}
		}

		// Token: 0x040002A4 RID: 676
		private global::NPOI.XSSF.UserModel.XSSFGraphicFrame frame;

		// Token: 0x040002A5 RID: 677
		private global::NPOI.OpenXmlFormats.Dml.ChartSpaceDocument chartSpaceDocument;

		// Token: 0x040002A6 RID: 678
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Chart chart;

		// Token: 0x040002A7 RID: 679
		private global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.IChartAxis> axis = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.IChartAxis>();
	}
}
