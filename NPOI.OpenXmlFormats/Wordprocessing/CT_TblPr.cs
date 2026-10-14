using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001B8 RID: 440
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblPr : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrBase
	{
		// Token: 0x060010B1 RID: 4273 RVA: 0x00036250 File Offset: 0x00034450
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr ct_TblPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tblPrChange")
				{
					ct_TblPr.tblPrChange = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblStyle")
				{
					ct_TblPr.tblStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblpPr")
				{
					ct_TblPr.tblpPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblOverlap")
				{
					ct_TblPr.tblOverlap = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblOverlap.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bidiVisual")
				{
					ct_TblPr.bidiVisual = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblStyleRowBandSize")
				{
					ct_TblPr.tblStyleRowBandSize = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblStyleColBandSize")
				{
					ct_TblPr.tblStyleColBandSize = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblW")
				{
					ct_TblPr.tblW = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "jc")
				{
					ct_TblPr.jc = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblCellSpacing")
				{
					ct_TblPr.tblCellSpacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblInd")
				{
					ct_TblPr.tblInd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblBorders")
				{
					ct_TblPr.tblBorders = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shd")
				{
					ct_TblPr.shd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblLayout")
				{
					ct_TblPr.tblLayout = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblLayoutType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblCellMar")
				{
					ct_TblPr.tblCellMar = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblLook")
				{
					ct_TblPr.tblLook = global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblCaption")
				{
					ct_TblPr.tblCaption = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblDescription")
				{
					ct_TblPr.tblDescription = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TblPr;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0003653C File Offset: 0x0003473C
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.tblPrChange != null)
			{
				this.tblPrChange.Write(sw, "tblPrChange");
			}
			if (base.tblStyle != null)
			{
				base.tblStyle.Write(sw, "tblStyle");
			}
			if (base.tblpPr != null)
			{
				base.tblpPr.Write(sw, "tblpPr");
			}
			if (base.tblOverlap != null)
			{
				base.tblOverlap.Write(sw, "tblOverlap");
			}
			if (base.bidiVisual != null)
			{
				base.bidiVisual.Write(sw, "bidiVisual");
			}
			if (base.tblStyleRowBandSize != null)
			{
				base.tblStyleRowBandSize.Write(sw, "tblStyleRowBandSize");
			}
			if (base.tblStyleColBandSize != null)
			{
				base.tblStyleColBandSize.Write(sw, "tblStyleColBandSize");
			}
			if (base.tblW != null)
			{
				base.tblW.Write(sw, "tblW");
			}
			if (base.jc != null)
			{
				base.jc.Write(sw, "jc");
			}
			if (base.tblCellSpacing != null)
			{
				base.tblCellSpacing.Write(sw, "tblCellSpacing");
			}
			if (base.tblInd != null)
			{
				base.tblInd.Write(sw, "tblInd");
			}
			if (base.tblBorders != null)
			{
				base.tblBorders.Write(sw, "tblBorders");
			}
			if (base.shd != null)
			{
				base.shd.Write(sw, "shd");
			}
			if (base.tblLayout != null)
			{
				base.tblLayout.Write(sw, "tblLayout");
			}
			if (base.tblCellMar != null)
			{
				base.tblCellMar.Write(sw, "tblCellMar");
			}
			if (base.tblLook != null)
			{
				base.tblLook.Write(sw, "tblLook");
			}
			if (base.tblCaption != null)
			{
				base.tblCaption.Write(sw, "tblCaption");
			}
			if (base.tblDescription != null)
			{
				base.tblDescription.Write(sw, "tblDescription");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00036740 File Offset: 0x00034940
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x00036748 File Offset: 0x00034948
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrChange tblPrChange
		{
			get
			{
				return this.tblPrChangeField;
			}
			set
			{
				this.tblPrChangeField = value;
			}
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00036751 File Offset: 0x00034951
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblLayoutType AddNewTblLayout()
		{
			base.tblLayout = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblLayoutType();
			return base.tblLayout;
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00036764 File Offset: 0x00034964
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPPr AddNewTblPPr()
		{
			base.tblpPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPPr();
			return base.tblpPr;
		}

		// Token: 0x04000D32 RID: 3378
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrChange tblPrChangeField;
	}
}
