using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001B3 RID: 435
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblPrEx : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExBase
	{
		// Token: 0x0600107B RID: 4219 RVA: 0x00035908 File Offset: 0x00033B08
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrEx Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrEx ct_TblPrEx = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrEx();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tblPrExChange")
				{
					ct_TblPrEx.tblPrExChange = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblW")
				{
					ct_TblPrEx.tblW = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "jc")
				{
					ct_TblPrEx.jc = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblCellSpacing")
				{
					ct_TblPrEx.tblCellSpacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblInd")
				{
					ct_TblPrEx.tblInd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblBorders")
				{
					ct_TblPrEx.tblBorders = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblBorders.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shd")
				{
					ct_TblPrEx.shd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblLayout")
				{
					ct_TblPrEx.tblLayout = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblLayoutType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblCellMar")
				{
					ct_TblPrEx.tblCellMar = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblLook")
				{
					ct_TblPrEx.tblLook = global::NPOI.OpenXmlFormats.Wordprocessing.CT_ShortHexNumber.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TblPrEx;
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00035AD4 File Offset: 0x00033CD4
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.tblPrExChange != null)
			{
				this.tblPrExChange.Write(sw, "tblPrExChange");
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
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x00035C10 File Offset: 0x00033E10
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x00035C18 File Offset: 0x00033E18
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExChange tblPrExChange
		{
			get
			{
				return this.tblPrExChangeField;
			}
			set
			{
				this.tblPrExChangeField = value;
			}
		}

		// Token: 0x04000D22 RID: 3362
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrExChange tblPrExChangeField;
	}
}
