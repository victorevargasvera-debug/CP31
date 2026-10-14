using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004E5 RID: 1253
	public class CT_Dxf
	{
		// Token: 0x0600346A RID: 13418 RVA: 0x000837A8 File Offset: 0x000819A8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf ct_Dxf = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "font")
				{
					ct_Dxf.font = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_Dxf.numFmt = global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fill")
				{
					ct_Dxf.fill = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "alignment")
				{
					ct_Dxf.alignment = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "border")
				{
					ct_Dxf.border = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "protection")
				{
					ct_Dxf.protection = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellProtection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Dxf.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Dxf;
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x00083908 File Offset: 0x00081B08
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.font != null)
			{
				this.font.Write(sw, "font");
			}
			if (this.numFmt != null)
			{
				this.numFmt.Write(sw, "numFmt");
			}
			if (this.fill != null)
			{
				this.fill.Write(sw, "fill");
			}
			if (this.alignment != null)
			{
				this.alignment.Write(sw, "alignment");
			}
			if (this.border != null)
			{
				this.border.Write(sw, "border");
			}
			if (this.protection != null)
			{
				this.protection.Write(sw, "protection");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x000839F1 File Offset: 0x00081BF1
		public bool IsSetBorder()
		{
			return this.borderField != null;
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x000839FC File Offset: 0x00081BFC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font AddNewFont()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font result = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font();
			this.fontField = result;
			return result;
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x00083A18 File Offset: 0x00081C18
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill AddNewFill()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill result = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill();
			this.fillField = result;
			return result;
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x00083A34 File Offset: 0x00081C34
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border AddNewBorder()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border result = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border();
			this.borderField = result;
			return result;
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x00083A4F File Offset: 0x00081C4F
		public bool IsSetFont()
		{
			return this.fontField != null;
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x00083A5A File Offset: 0x00081C5A
		public bool IsSetFill()
		{
			return this.fillField != null;
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x00083A65 File Offset: 0x00081C65
		// (set) Token: 0x06003474 RID: 13428 RVA: 0x00083A6D File Offset: 0x00081C6D
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font font
		{
			get
			{
				return this.fontField;
			}
			set
			{
				this.fontField = value;
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x00083A76 File Offset: 0x00081C76
		// (set) Token: 0x06003476 RID: 13430 RVA: 0x00083A7E File Offset: 0x00081C7E
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt numFmt
		{
			get
			{
				return this.numFmtField;
			}
			set
			{
				this.numFmtField = value;
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x00083A87 File Offset: 0x00081C87
		// (set) Token: 0x06003478 RID: 13432 RVA: 0x00083A8F File Offset: 0x00081C8F
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill fill
		{
			get
			{
				return this.fillField;
			}
			set
			{
				this.fillField = value;
			}
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x06003479 RID: 13433 RVA: 0x00083A98 File Offset: 0x00081C98
		// (set) Token: 0x0600347A RID: 13434 RVA: 0x00083AA0 File Offset: 0x00081CA0
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment alignment
		{
			get
			{
				return this.alignmentField;
			}
			set
			{
				this.alignmentField = value;
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x0600347B RID: 13435 RVA: 0x00083AA9 File Offset: 0x00081CA9
		// (set) Token: 0x0600347C RID: 13436 RVA: 0x00083AB1 File Offset: 0x00081CB1
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border border
		{
			get
			{
				return this.borderField;
			}
			set
			{
				this.borderField = value;
			}
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x0600347D RID: 13437 RVA: 0x00083ABA File Offset: 0x00081CBA
		// (set) Token: 0x0600347E RID: 13438 RVA: 0x00083AC2 File Offset: 0x00081CC2
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellProtection protection
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

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x0600347F RID: 13439 RVA: 0x00083ACB File Offset: 0x00081CCB
		// (set) Token: 0x06003480 RID: 13440 RVA: 0x00083AD3 File Offset: 0x00081CD3
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x040022F9 RID: 8953
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font fontField;

		// Token: 0x040022FA RID: 8954
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt numFmtField;

		// Token: 0x040022FB RID: 8955
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill fillField;

		// Token: 0x040022FC RID: 8956
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment alignmentField;

		// Token: 0x040022FD RID: 8957
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border borderField;

		// Token: 0x040022FE RID: 8958
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellProtection protectionField;

		// Token: 0x040022FF RID: 8959
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
