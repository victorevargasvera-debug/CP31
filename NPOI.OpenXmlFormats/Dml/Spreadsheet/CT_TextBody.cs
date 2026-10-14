using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000360 RID: 864
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	public class CT_TextBody
	{
		// Token: 0x06002234 RID: 8756 RVA: 0x00059410 File Offset: 0x00057610
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TextBody Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TextBody ct_TextBody = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TextBody();
			ct_TextBody.p = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "bodyPr")
				{
					ct_TextBody.bodyPr = global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lstStyle")
				{
					ct_TextBody.lstStyle = global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "p")
				{
					ct_TextBody.p.Add(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_TextBody;
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x000594E0 File Offset: 0x000576E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			sw.Write(">");
			if (this.bodyPr != null)
			{
				this.bodyPr.Write(sw, "bodyPr");
			}
			if (this.lstStyle != null)
			{
				this.lstStyle.Write(sw, "lstStyle");
			}
			foreach (global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph ct_TextParagraph in this.p)
			{
				ct_TextParagraph.Write(sw, "p");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x00059598 File Offset: 0x00057798
		public void SetPArray(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph[] array)
		{
			if (array == null)
			{
				this.pField.Clear();
				return;
			}
			this.pField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph>(array);
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x000595B8 File Offset: 0x000577B8
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph AddNewP()
		{
			if (this.pField == null)
			{
				this.pField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph>();
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph ct_TextParagraph = new global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph();
			this.pField.Add(ct_TextParagraph);
			return ct_TextParagraph;
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x000595EB File Offset: 0x000577EB
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties AddNewBodyPr()
		{
			this.bodyPrField = new global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties();
			return this.bodyPrField;
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x000595FE File Offset: 0x000577FE
		public global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle AddNewLstStyle()
		{
			this.lstStyleField = new global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle();
			return this.lstStyleField;
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x00059611 File Offset: 0x00057811
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x00059619 File Offset: 0x00057819
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr
		{
			get
			{
				return this.bodyPrField;
			}
			set
			{
				this.bodyPrField = value;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x00059622 File Offset: 0x00057822
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x0005962A File Offset: 0x0005782A
		public global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle lstStyle
		{
			get
			{
				return this.lstStyleField;
			}
			set
			{
				this.lstStyleField = value;
			}
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00059634 File Offset: 0x00057834
		public override string ToString()
		{
			if (this.p == null || this.p.Count == 0)
			{
				return string.Empty;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph ct_TextParagraph in this.p)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun ct_RegularTextRun in ct_TextParagraph.r)
				{
					stringBuilder.Append(ct_RegularTextRun.t);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x000596F0 File Offset: 0x000578F0
		// (set) Token: 0x06002240 RID: 8768 RVA: 0x000596F8 File Offset: 0x000578F8
		[global::System.Xml.Serialization.XmlElement("p")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph> p
		{
			get
			{
				return this.pField;
			}
			set
			{
				this.pField = value;
			}
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00059701 File Offset: 0x00057901
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph GetPArray(int pos)
		{
			if (this.p == null)
			{
				return null;
			}
			return this.p[pos];
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00059719 File Offset: 0x00057919
		public int SizeOfPArray()
		{
			return this.p.Count;
		}

		// Token: 0x04001A09 RID: 6665
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPrField;

		// Token: 0x04001A0A RID: 6666
		private global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle lstStyleField;

		// Token: 0x04001A0B RID: 6667
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph> pField;
	}
}
