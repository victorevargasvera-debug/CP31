using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003F9 RID: 1017
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PrintSettings
	{
		// Token: 0x060028C2 RID: 10434 RVA: 0x00066A74 File Offset: 0x00064C74
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_PrintSettings Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PrintSettings ct_PrintSettings = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PrintSettings();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "headerFooter")
				{
					ct_PrintSettings.headerFooter = global::NPOI.OpenXmlFormats.Dml.Chart.CT_HeaderFooter.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageMargins")
				{
					ct_PrintSettings.pageMargins = global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageMargins.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pageSetup")
				{
					ct_PrintSettings.pageSetup = global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageSetup.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "legacyDrawingHF")
				{
					ct_PrintSettings.legacyDrawingHF = global::NPOI.OpenXmlFormats.Dml.Chart.CT_RelId.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PrintSettings;
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x00066B5C File Offset: 0x00064D5C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.headerFooter != null)
			{
				this.headerFooter.Write(sw, "headerFooter");
			}
			if (this.pageMargins != null)
			{
				this.pageMargins.Write(sw, "pageMargins");
			}
			if (this.pageSetup != null)
			{
				this.pageSetup.Write(sw, "pageSetup");
			}
			if (this.legacyDrawingHF != null)
			{
				this.legacyDrawingHF.Write(sw, "legacyDrawingHF");
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x00066BFA File Offset: 0x00064DFA
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_HeaderFooter AddNewHeaderFooter()
		{
			this.headerFooterField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_HeaderFooter();
			return this.headerFooterField;
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00066C0D File Offset: 0x00064E0D
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageSetup AddNewPageSetup()
		{
			this.pageSetupField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageSetup();
			return this.pageSetupField;
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x00066C20 File Offset: 0x00064E20
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageMargins AddNewPageMargins()
		{
			this.pageMarginsField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageMargins();
			return this.pageMarginsField;
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x00066C33 File Offset: 0x00064E33
		// (set) Token: 0x060028C8 RID: 10440 RVA: 0x00066C3B File Offset: 0x00064E3B
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_HeaderFooter headerFooter
		{
			get
			{
				return this.headerFooterField;
			}
			set
			{
				this.headerFooterField = value;
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x00066C44 File Offset: 0x00064E44
		// (set) Token: 0x060028CA RID: 10442 RVA: 0x00066C4C File Offset: 0x00064E4C
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageMargins pageMargins
		{
			get
			{
				return this.pageMarginsField;
			}
			set
			{
				this.pageMarginsField = value;
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x00066C55 File Offset: 0x00064E55
		// (set) Token: 0x060028CC RID: 10444 RVA: 0x00066C5D File Offset: 0x00064E5D
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageSetup pageSetup
		{
			get
			{
				return this.pageSetupField;
			}
			set
			{
				this.pageSetupField = value;
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x00066C66 File Offset: 0x00064E66
		// (set) Token: 0x060028CE RID: 10446 RVA: 0x00066C6E File Offset: 0x00064E6E
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_RelId legacyDrawingHF
		{
			get
			{
				return this.legacyDrawingHFField;
			}
			set
			{
				this.legacyDrawingHFField = value;
			}
		}

		// Token: 0x04001D94 RID: 7572
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_HeaderFooter headerFooterField;

		// Token: 0x04001D95 RID: 7573
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageMargins pageMarginsField;

		// Token: 0x04001D96 RID: 7574
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_PageSetup pageSetupField;

		// Token: 0x04001D97 RID: 7575
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_RelId legacyDrawingHFField;
	}
}
