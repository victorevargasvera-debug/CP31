using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001BF RID: 447
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TcPrInner : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrBase
	{
		// Token: 0x06001100 RID: 4352 RVA: 0x00038938 File Offset: 0x00036B38
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrInner Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrInner ct_TcPrInner = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPrInner();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cellIns")
				{
					ct_TcPrInner.cellIns = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cellDel")
				{
					ct_TcPrInner.cellDel = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cellMerge")
				{
					ct_TcPrInner.cellMerge = global::NPOI.OpenXmlFormats.Wordprocessing.CT_CellMergeTrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cnfStyle")
				{
					ct_TcPrInner.cnfStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tcW")
				{
					ct_TcPrInner.tcW = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gridSpan")
				{
					ct_TcPrInner.gridSpan = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hMerge")
				{
					ct_TcPrInner.hMerge = global::NPOI.OpenXmlFormats.Wordprocessing.CT_HMerge.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vMerge")
				{
					ct_TcPrInner.vMerge = global::NPOI.OpenXmlFormats.Wordprocessing.CT_VMerge.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tcBorders")
				{
					ct_TcPrInner.tcBorders = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcBorders.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shd")
				{
					ct_TcPrInner.shd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noWrap")
				{
					ct_TcPrInner.noWrap = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tcMar")
				{
					ct_TcPrInner.tcMar = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcMar.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "textDirection")
				{
					ct_TcPrInner.textDirection = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tcFitText")
				{
					ct_TcPrInner.tcFitText = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vAlign")
				{
					ct_TcPrInner.vAlign = global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hideMark")
				{
					ct_TcPrInner.hideMark = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TcPrInner;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00038BDC File Offset: 0x00036DDC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.cellIns != null)
			{
				this.cellIns.Write(sw, "cellIns");
			}
			if (this.cellDel != null)
			{
				this.cellDel.Write(sw, "cellDel");
			}
			if (this.cellMerge != null)
			{
				this.cellMerge.Write(sw, "cellMerge");
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

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00038DA6 File Offset: 0x00036FA6
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x00038DAE File Offset: 0x00036FAE
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange cellIns
		{
			get
			{
				return this.cellInsField;
			}
			set
			{
				this.cellInsField = value;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x00038DB7 File Offset: 0x00036FB7
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x00038DBF File Offset: 0x00036FBF
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange cellDel
		{
			get
			{
				return this.cellDelField;
			}
			set
			{
				this.cellDelField = value;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x00038DC8 File Offset: 0x00036FC8
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x00038DD0 File Offset: 0x00036FD0
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_CellMergeTrackChange cellMerge
		{
			get
			{
				return this.cellMergeField;
			}
			set
			{
				this.cellMergeField = value;
			}
		}

		// Token: 0x04000D5D RID: 3421
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange cellInsField;

		// Token: 0x04000D5E RID: 3422
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange cellDelField;

		// Token: 0x04000D5F RID: 3423
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_CellMergeTrackChange cellMergeField;
	}
}
