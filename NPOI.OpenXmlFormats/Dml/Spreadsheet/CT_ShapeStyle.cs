using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000361 RID: 865
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_ShapeStyle
	{
		// Token: 0x06002244 RID: 8772 RVA: 0x00059728 File Offset: 0x00057928
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle ct_ShapeStyle = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeStyle();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "lnRef")
				{
					ct_ShapeStyle.lnRef = global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fillRef")
				{
					ct_ShapeStyle.fillRef = global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "effectRef")
				{
					ct_ShapeStyle.effectRef = global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fontRef")
				{
					ct_ShapeStyle.fontRef = global::NPOI.OpenXmlFormats.Dml.CT_FontReference.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ShapeStyle;
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00059810 File Offset: 0x00057A10
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			sw.Write(">");
			if (this.lnRef != null)
			{
				this.lnRef.Write(sw, "lnRef");
			}
			if (this.fillRef != null)
			{
				this.fillRef.Write(sw, "fillRef");
			}
			if (this.effectRef != null)
			{
				this.effectRef.Write(sw, "effectRef");
			}
			if (this.fontRef != null)
			{
				this.fontRef.Write(sw, "fontRef");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x000598AE File Offset: 0x00057AAE
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference AddNewFillRef()
		{
			this.fillRefField = new global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference();
			return this.fillRefField;
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x000598C1 File Offset: 0x00057AC1
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference AddNewLnRef()
		{
			this.lnRefField = new global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference();
			return this.lnRefField;
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x000598D4 File Offset: 0x00057AD4
		public global::NPOI.OpenXmlFormats.Dml.CT_FontReference AddNewFontRef()
		{
			this.fontRefField = new global::NPOI.OpenXmlFormats.Dml.CT_FontReference();
			return this.fontRefField;
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x000598E7 File Offset: 0x00057AE7
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference AddNewEffectRef()
		{
			this.effectRefField = new global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference();
			return this.effectRefField;
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x000598FA File Offset: 0x00057AFA
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x00059902 File Offset: 0x00057B02
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference lnRef
		{
			get
			{
				return this.lnRefField;
			}
			set
			{
				this.lnRefField = value;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x0005990B File Offset: 0x00057B0B
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x00059913 File Offset: 0x00057B13
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference fillRef
		{
			get
			{
				return this.fillRefField;
			}
			set
			{
				this.fillRefField = value;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x0005991C File Offset: 0x00057B1C
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x00059924 File Offset: 0x00057B24
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference effectRef
		{
			get
			{
				return this.effectRefField;
			}
			set
			{
				this.effectRefField = value;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x0005992D File Offset: 0x00057B2D
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x00059935 File Offset: 0x00057B35
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FontReference fontRef
		{
			get
			{
				return this.fontRefField;
			}
			set
			{
				this.fontRefField = value;
			}
		}

		// Token: 0x04001A0C RID: 6668
		private global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference lnRefField;

		// Token: 0x04001A0D RID: 6669
		private global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference fillRefField;

		// Token: 0x04001A0E RID: 6670
		private global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrixReference effectRefField;

		// Token: 0x04001A0F RID: 6671
		private global::NPOI.OpenXmlFormats.Dml.CT_FontReference fontRefField;
	}
}
