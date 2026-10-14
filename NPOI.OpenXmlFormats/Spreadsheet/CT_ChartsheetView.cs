using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005BF RID: 1471
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_ChartsheetView
	{
		// Token: 0x060040BD RID: 16573 RVA: 0x0009D15A File Offset: 0x0009B35A
		public CT_ChartsheetView()
		{
			this.tabSelectedField = false;
			this.zoomScaleField = 100U;
			this.zoomToFitField = false;
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x060040BE RID: 16574 RVA: 0x0009D178 File Offset: 0x0009B378
		// (set) Token: 0x060040BF RID: 16575 RVA: 0x0009D180 File Offset: 0x0009B380
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
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

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x060040C0 RID: 16576 RVA: 0x0009D189 File Offset: 0x0009B389
		// (set) Token: 0x060040C1 RID: 16577 RVA: 0x0009D191 File Offset: 0x0009B391
		[global::System.ComponentModel.DefaultValue(false)]
		public bool tabSelected
		{
			get
			{
				return this.tabSelectedField;
			}
			set
			{
				this.tabSelectedField = value;
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x060040C2 RID: 16578 RVA: 0x0009D19A File Offset: 0x0009B39A
		// (set) Token: 0x060040C3 RID: 16579 RVA: 0x0009D1A2 File Offset: 0x0009B3A2
		[global::System.ComponentModel.DefaultValue(typeof(uint), "100")]
		public uint zoomScale
		{
			get
			{
				return this.zoomScaleField;
			}
			set
			{
				this.zoomScaleField = value;
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x060040C4 RID: 16580 RVA: 0x0009D1AB File Offset: 0x0009B3AB
		// (set) Token: 0x060040C5 RID: 16581 RVA: 0x0009D1B3 File Offset: 0x0009B3B3
		public uint workbookViewId
		{
			get
			{
				return this.workbookViewIdField;
			}
			set
			{
				this.workbookViewIdField = value;
			}
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x060040C6 RID: 16582 RVA: 0x0009D1BC File Offset: 0x0009B3BC
		// (set) Token: 0x060040C7 RID: 16583 RVA: 0x0009D1C4 File Offset: 0x0009B3C4
		[global::System.ComponentModel.DefaultValue(false)]
		public bool zoomToFit
		{
			get
			{
				return this.zoomToFitField;
			}
			set
			{
				this.zoomToFitField = value;
			}
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x0009D1D0 File Offset: 0x0009B3D0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetView Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetView ct_ChartsheetView = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartsheetView();
			if (node.Attributes["tabSelected"] != null)
			{
				ct_ChartsheetView.tabSelected = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["tabSelected"]);
			}
			if (node.Attributes["zoomScale"] != null)
			{
				ct_ChartsheetView.zoomScale = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["zoomScale"]);
			}
			if (node.Attributes["workbookViewId"] != null)
			{
				ct_ChartsheetView.workbookViewId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["workbookViewId"]);
			}
			if (node.Attributes["zoomToFit"] != null)
			{
				ct_ChartsheetView.zoomToFit = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["zoomToFit"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_ChartsheetView.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ChartsheetView;
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x0009D304 File Offset: 0x0009B504
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.tabSelected)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tabSelected", this.tabSelected);
			}
			if (this.zoomScale != 100U)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "zoomScale", this.zoomScale, false);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "workbookViewId", this.workbookViewId, false);
			if (this.zoomToFit)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "zoomToFit", this.zoomToFit);
			}
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002900 RID: 10496
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002901 RID: 10497
		private bool tabSelectedField;

		// Token: 0x04002902 RID: 10498
		private uint zoomScaleField;

		// Token: 0x04002903 RID: 10499
		private uint workbookViewIdField;

		// Token: 0x04002904 RID: 10500
		private bool zoomToFitField;
	}
}
