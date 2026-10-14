using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001C4 RID: 452
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TcPr : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrInner
	{
		// Token: 0x06001131 RID: 4401 RVA: 0x00039494 File Offset: 0x00037694
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr ct_TcPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tcPrChange")
				{
					ct_TcPr.tcPrChange = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cellIns")
				{
					ct_TcPr.cellIns = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cellDel")
				{
					ct_TcPr.cellDel = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cellMerge")
				{
					ct_TcPr.cellMerge = global::NPOI.OpenXmlFormats.Wordprocessing.CT_CellMergeTrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cnfStyle")
				{
					ct_TcPr.cnfStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tcW")
				{
					ct_TcPr.tcW = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gridSpan")
				{
					ct_TcPr.gridSpan = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hMerge")
				{
					ct_TcPr.hMerge = global::NPOI.OpenXmlFormats.Wordprocessing.CT_HMerge.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vMerge")
				{
					ct_TcPr.vMerge = global::NPOI.OpenXmlFormats.Wordprocessing.CT_VMerge.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tcBorders")
				{
					ct_TcPr.tcBorders = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcBorders.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shd")
				{
					ct_TcPr.shd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noWrap")
				{
					ct_TcPr.noWrap = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tcMar")
				{
					ct_TcPr.tcMar = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcMar.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "textDirection")
				{
					ct_TcPr.textDirection = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tcFitText")
				{
					ct_TcPr.tcFitText = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vAlign")
				{
					ct_TcPr.vAlign = global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hideMark")
				{
					ct_TcPr.hideMark = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TcPr;
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0003975C File Offset: 0x0003795C
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth AddNewTcW()
		{
			base.tcW = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth();
			return base.tcW;
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00039770 File Offset: 0x00037970
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.tcPrChange != null)
			{
				this.tcPrChange.Write(sw, "tcPrChange");
			}
			if (base.cellIns != null)
			{
				base.cellIns.Write(sw, "cellIns");
			}
			if (base.cellDel != null)
			{
				base.cellDel.Write(sw, "cellDel");
			}
			if (base.cellMerge != null)
			{
				base.cellMerge.Write(sw, "cellMerge");
			}
			if (base.cnfStyle != null)
			{
				base.cnfStyle.Write(sw, "cnfStyle");
			}
			if (base.tcW != null)
			{
				base.tcW.Write(sw, "tcW");
			}
			if (base.gridSpan != null)
			{
				base.gridSpan.Write(sw, "gridSpan");
			}
			if (base.hMerge != null)
			{
				base.hMerge.Write(sw, "hMerge");
			}
			if (base.vMerge != null)
			{
				base.vMerge.Write(sw, "vMerge");
			}
			if (base.tcBorders != null)
			{
				base.tcBorders.Write(sw, "tcBorders");
			}
			if (base.shd != null)
			{
				base.shd.Write(sw, "shd");
			}
			if (base.noWrap != null)
			{
				base.noWrap.Write(sw, "noWrap");
			}
			if (base.tcMar != null)
			{
				base.tcMar.Write(sw, "tcMar");
			}
			if (base.textDirection != null)
			{
				base.textDirection.Write(sw, "textDirection");
			}
			if (base.tcFitText != null)
			{
				base.tcFitText.Write(sw, "tcFitText");
			}
			if (base.vAlign != null)
			{
				base.vAlign.Write(sw, "vAlign");
			}
			if (base.hideMark != null)
			{
				base.hideMark.Write(sw, "hideMark");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x0003995B File Offset: 0x00037B5B
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x00039963 File Offset: 0x00037B63
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrChange tcPrChange
		{
			get
			{
				return this.tcPrChangeField;
			}
			set
			{
				this.tcPrChangeField = value;
			}
		}

		// Token: 0x04000D73 RID: 3443
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrChange tcPrChangeField;
	}
}
