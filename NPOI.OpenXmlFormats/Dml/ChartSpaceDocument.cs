using System;
using System.IO;
using System.Xml;
using NPOI.OpenXmlFormats.Dml.Chart;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000235 RID: 565
	public class ChartSpaceDocument
	{
		// Token: 0x0600170C RID: 5900 RVA: 0x00042E3F File Offset: 0x0004103F
		public ChartSpaceDocument()
		{
			this.chartSpace = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartSpace();
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00042E52 File Offset: 0x00041052
		public ChartSpaceDocument(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartSpace chartspace)
		{
			this.chartSpace = chartspace;
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00042E61 File Offset: 0x00041061
		public static global::NPOI.OpenXmlFormats.Dml.ChartSpaceDocument Parse(global::System.Xml.XmlDocument xmldoc, global::System.Xml.XmlNamespaceManager namespaceMgr)
		{
			return new global::NPOI.OpenXmlFormats.Dml.ChartSpaceDocument(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartSpace.Parse(xmldoc.DocumentElement, namespaceMgr));
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00042E74 File Offset: 0x00041074
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartSpace GetChartSpace()
		{
			return this.chartSpace;
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00042E7C File Offset: 0x0004107C
		public void SetChartSpace(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartSpace chartspace)
		{
			this.chartSpace = chartspace;
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00042E85 File Offset: 0x00041085
		public void Save(global::System.IO.Stream stream)
		{
			this.chartSpace.Write(stream);
		}

		// Token: 0x04001216 RID: 4630
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartSpace chartSpace;
	}
}
