using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200030D RID: 781
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextBody
	{
		// Token: 0x06001EF7 RID: 7927 RVA: 0x00053204 File Offset: 0x00051404
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextBody Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextBody ct_TextBody = new global::NPOI.OpenXmlFormats.Dml.CT_TextBody();
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

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000532D4 File Offset: 0x000514D4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
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
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0005338C File Offset: 0x0005158C
		public void SetPArray(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph[] array)
		{
			this.pField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph>(array);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0005339C File Offset: 0x0005159C
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

		// Token: 0x06001EFB RID: 7931 RVA: 0x000533CF File Offset: 0x000515CF
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties AddNewBodyPr()
		{
			this.bodyPrField = new global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties();
			return this.bodyPrField;
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x000533E2 File Offset: 0x000515E2
		public global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle AddNewLstStyle()
		{
			this.lstStyleField = new global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle();
			return this.lstStyleField;
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x000533F5 File Offset: 0x000515F5
		// (set) Token: 0x06001EFE RID: 7934 RVA: 0x000533FD File Offset: 0x000515FD
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

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x00053406 File Offset: 0x00051606
		// (set) Token: 0x06001F00 RID: 7936 RVA: 0x0005340E File Offset: 0x0005160E
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

		// Token: 0x06001F01 RID: 7937 RVA: 0x00053418 File Offset: 0x00051618
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

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x000534D4 File Offset: 0x000516D4
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x000534DC File Offset: 0x000516DC
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

		// Token: 0x0400183C RID: 6204
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPrField;

		// Token: 0x0400183D RID: 6205
		private global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle lstStyleField;

		// Token: 0x0400183E RID: 6206
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph> pField;
	}
}
