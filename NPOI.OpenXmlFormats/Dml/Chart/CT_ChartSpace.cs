using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003F2 RID: 1010
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot("chartSpace", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = false)]
	[global::System.Serializable]
	public class CT_ChartSpace
	{
		// Token: 0x0600285E RID: 10334 RVA: 0x00065A64 File Offset: 0x00063C64
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartSpace Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartSpace ct_ChartSpace = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartSpace();
			ct_ChartSpace.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "date1904")
				{
					ct_ChartSpace.date1904 = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lang")
				{
					ct_ChartSpace.lang = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextLanguageID.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "roundedCorners")
				{
					ct_ChartSpace.roundedCorners = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "style")
				{
					ct_ChartSpace.style = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Style.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "clrMapOvr")
				{
					ct_ChartSpace.clrMapOvr = global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pivotSource")
				{
					ct_ChartSpace.pivotSource = global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "protection")
				{
					ct_ChartSpace.protection = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Protection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "chart")
				{
					ct_ChartSpace.chart = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Chart.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_ChartSpace.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_ChartSpace.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "externalData")
				{
					ct_ChartSpace.externalData = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ExternalData.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "printSettings")
				{
					ct_ChartSpace.printSettings = global::NPOI.OpenXmlFormats.Dml.Chart.CT_PrintSettings.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "userShapes")
				{
					ct_ChartSpace.userShapes = global::NPOI.OpenXmlFormats.Dml.Chart.CT_RelId.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_ChartSpace.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ChartSpace;
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x00065CD0 File Offset: 0x00063ED0
		internal void Write(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				streamWriter.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
				streamWriter.Write("<c:chartSpace");
				streamWriter.Write(" xmlns:c=\"http://schemas.openxmlformats.org/drawingml/2006/chart\" xmlns:a=\"http://schemas.openxmlformats.org/drawingml/2006/main\"");
				streamWriter.Write(" xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\"");
				streamWriter.Write(">");
				if (this.date1904 != null)
				{
					this.date1904.Write(streamWriter, "date1904");
				}
				if (this.lang != null)
				{
					this.lang.Write(streamWriter, "lang");
				}
				if (this.roundedCorners != null)
				{
					this.roundedCorners.Write(streamWriter, "roundedCorners");
				}
				if (this.style != null)
				{
					this.style.Write(streamWriter, "style");
				}
				if (this.clrMapOvr != null)
				{
					this.clrMapOvr.Write(streamWriter, "clrMapOvr");
				}
				if (this.pivotSource != null)
				{
					this.pivotSource.Write(streamWriter, "pivotSource");
				}
				if (this.protection != null)
				{
					this.protection.Write(streamWriter, "protection");
				}
				if (this.chart != null)
				{
					this.chart.Write(streamWriter, "chart");
				}
				if (this.spPr != null)
				{
					this.spPr.Write(streamWriter, "spPr");
				}
				if (this.txPr != null)
				{
					this.txPr.Write(streamWriter, "txPr");
				}
				if (this.externalData != null)
				{
					this.externalData.Write(streamWriter, "externalData");
				}
				if (this.printSettings != null)
				{
					this.printSettings.Write(streamWriter, "printSettings");
				}
				if (this.userShapes != null)
				{
					this.userShapes.Write(streamWriter, "userShapes");
				}
				if (this.extLst != null)
				{
					foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension ct_Extension in this.extLst)
					{
						ct_Extension.Write(streamWriter, "extLst");
					}
				}
				streamWriter.Write("</c:chartSpace>");
			}
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x00065EEC File Offset: 0x000640EC
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Chart AddNewChart()
		{
			this.chartField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Chart();
			return this.chartField;
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x00065EFF File Offset: 0x000640FF
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PrintSettings AddNewPrintSettings()
		{
			this.printSettingsField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PrintSettings();
			return this.printSettingsField;
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x00065F12 File Offset: 0x00064112
		// (set) Token: 0x06002863 RID: 10339 RVA: 0x00065F1A File Offset: 0x0006411A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean date1904
		{
			get
			{
				return this.date1904Field;
			}
			set
			{
				this.date1904Field = value;
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06002864 RID: 10340 RVA: 0x00065F23 File Offset: 0x00064123
		// (set) Token: 0x06002865 RID: 10341 RVA: 0x00065F2B File Offset: 0x0006412B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextLanguageID lang
		{
			get
			{
				return this.langField;
			}
			set
			{
				this.langField = value;
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06002866 RID: 10342 RVA: 0x00065F34 File Offset: 0x00064134
		// (set) Token: 0x06002867 RID: 10343 RVA: 0x00065F3C File Offset: 0x0006413C
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean roundedCorners
		{
			get
			{
				return this.roundedCornersField;
			}
			set
			{
				this.roundedCornersField = value;
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x00065F45 File Offset: 0x00064145
		// (set) Token: 0x06002869 RID: 10345 RVA: 0x00065F4D File Offset: 0x0006414D
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Style style
		{
			get
			{
				return this.styleField;
			}
			set
			{
				this.styleField = value;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x00065F56 File Offset: 0x00064156
		// (set) Token: 0x0600286B RID: 10347 RVA: 0x00065F5E File Offset: 0x0006415E
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping clrMapOvr
		{
			get
			{
				return this.clrMapOvrField;
			}
			set
			{
				this.clrMapOvrField = value;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x00065F67 File Offset: 0x00064167
		// (set) Token: 0x0600286D RID: 10349 RVA: 0x00065F6F File Offset: 0x0006416F
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotSource pivotSource
		{
			get
			{
				return this.pivotSourceField;
			}
			set
			{
				this.pivotSourceField = value;
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x0600286E RID: 10350 RVA: 0x00065F78 File Offset: 0x00064178
		// (set) Token: 0x0600286F RID: 10351 RVA: 0x00065F80 File Offset: 0x00064180
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Protection protection
		{
			get
			{
				return this.protectionField;
			}
			set
			{
				this.protectionField = value;
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06002870 RID: 10352 RVA: 0x00065F89 File Offset: 0x00064189
		// (set) Token: 0x06002871 RID: 10353 RVA: 0x00065F91 File Offset: 0x00064191
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Chart chart
		{
			get
			{
				return this.chartField;
			}
			set
			{
				this.chartField = value;
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06002872 RID: 10354 RVA: 0x00065F9A File Offset: 0x0006419A
		// (set) Token: 0x06002873 RID: 10355 RVA: 0x00065FA2 File Offset: 0x000641A2
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
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

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x00065FAB File Offset: 0x000641AB
		// (set) Token: 0x06002875 RID: 10357 RVA: 0x00065FB3 File Offset: 0x000641B3
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPr
		{
			get
			{
				return this.txPrField;
			}
			set
			{
				this.txPrField = value;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06002876 RID: 10358 RVA: 0x00065FBC File Offset: 0x000641BC
		// (set) Token: 0x06002877 RID: 10359 RVA: 0x00065FC4 File Offset: 0x000641C4
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ExternalData externalData
		{
			get
			{
				return this.externalDataField;
			}
			set
			{
				this.externalDataField = value;
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x00065FCD File Offset: 0x000641CD
		// (set) Token: 0x06002879 RID: 10361 RVA: 0x00065FD5 File Offset: 0x000641D5
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PrintSettings printSettings
		{
			get
			{
				return this.printSettingsField;
			}
			set
			{
				this.printSettingsField = value;
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x00065FDE File Offset: 0x000641DE
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x00065FE6 File Offset: 0x000641E6
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_RelId userShapes
		{
			get
			{
				return this.userShapesField;
			}
			set
			{
				this.userShapesField = value;
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x00065FEF File Offset: 0x000641EF
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x00065FF7 File Offset: 0x000641F7
		[global::System.Xml.Serialization.XmlArray(Order = 13)]
		[global::System.Xml.Serialization.XmlArrayItem("ext", IsNullable = false)]
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

		// Token: 0x04001D68 RID: 7528
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean date1904Field;

		// Token: 0x04001D69 RID: 7529
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextLanguageID langField;

		// Token: 0x04001D6A RID: 7530
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean roundedCornersField;

		// Token: 0x04001D6B RID: 7531
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Style styleField;

		// Token: 0x04001D6C RID: 7532
		private global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping clrMapOvrField;

		// Token: 0x04001D6D RID: 7533
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotSource pivotSourceField;

		// Token: 0x04001D6E RID: 7534
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Protection protectionField;

		// Token: 0x04001D6F RID: 7535
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Chart chartField;

		// Token: 0x04001D70 RID: 7536
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001D71 RID: 7537
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;

		// Token: 0x04001D72 RID: 7538
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ExternalData externalDataField;

		// Token: 0x04001D73 RID: 7539
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_PrintSettings printSettingsField;

		// Token: 0x04001D74 RID: 7540
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_RelId userShapesField;

		// Token: 0x04001D75 RID: 7541
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
