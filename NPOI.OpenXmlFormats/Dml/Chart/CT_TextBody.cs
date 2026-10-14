using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200046E RID: 1134
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextBody
	{
		// Token: 0x06002D25 RID: 11557 RVA: 0x0007204C File Offset: 0x0007024C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody ct_TextBody = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody();
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

		// Token: 0x06002D26 RID: 11558 RVA: 0x0007211C File Offset: 0x0007031C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}>", nodeName));
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
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x000721C8 File Offset: 0x000703C8
		public void SetPArray(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph[] array)
		{
			this.pField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph>(array);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x000721D8 File Offset: 0x000703D8
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

		// Token: 0x06002D29 RID: 11561 RVA: 0x0007220B File Offset: 0x0007040B
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties AddNewBodyPr()
		{
			this.bodyPrField = new global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties();
			return this.bodyPrField;
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x0007221E File Offset: 0x0007041E
		public global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle AddNewLstStyle()
		{
			this.lstStyleField = new global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle();
			return this.lstStyleField;
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x00072231 File Offset: 0x00070431
		// (set) Token: 0x06002D2C RID: 11564 RVA: 0x00072239 File Offset: 0x00070439
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

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06002D2D RID: 11565 RVA: 0x00072242 File Offset: 0x00070442
		// (set) Token: 0x06002D2E RID: 11566 RVA: 0x0007224A File Offset: 0x0007044A
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

		// Token: 0x06002D2F RID: 11567 RVA: 0x00072254 File Offset: 0x00070454
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

		// Token: 0x06002D30 RID: 11568 RVA: 0x00072310 File Offset: 0x00070510
		public int SizeOfPArray()
		{
			if (this.pField == null)
			{
				this.pField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph>();
			}
			return this.pField.Count;
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00072330 File Offset: 0x00070530
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph GetPArray(int v)
		{
			return this.pField[v];
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x0007233E File Offset: 0x0007053E
		// (set) Token: 0x06002D33 RID: 11571 RVA: 0x00072346 File Offset: 0x00070546
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

		// Token: 0x04001F80 RID: 8064
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPrField;

		// Token: 0x04001F81 RID: 8065
		private global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle lstStyleField;

		// Token: 0x04001F82 RID: 8066
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph> pField;
	}
}
