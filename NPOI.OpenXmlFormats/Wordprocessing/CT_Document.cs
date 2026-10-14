using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000071 RID: 113
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("document", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Document : global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocumentBase
	{
		// Token: 0x06000345 RID: 837 RVA: 0x00009C4C File Offset: 0x00007E4C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Document Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Document ct_Document = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Document();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "body")
				{
					ct_Document.body = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Body.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "background")
				{
					ct_Document.background = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Background.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Document;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00009CEC File Offset: 0x00007EEC
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<w:document xmlns:wpc=\"http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas\" ");
			sw.Write("xmlns:cx=\"http://schemas.microsoft.com/office/drawing/2014/chartex\" xmlns:cx1=\"http://schemas.microsoft.com/office/drawing/2015/9/8/chartex\" xmlns:cx2=\"http://schemas.microsoft.com/office/drawing/2015/10/21/chartex\" xmlns:cx3=\"http://schemas.microsoft.com/office/drawing/2016/5/9/chartex\" ");
			sw.Write("xmlns:cx4=\"http://schemas.microsoft.com/office/drawing/2016/5/10/chartex\" xmlns:cx5=\"http://schemas.microsoft.com/office/drawing/2016/5/11/chartex\" xmlns:cx6=\"http://schemas.microsoft.com/office/drawing/2016/5/12/chartex\" ");
			sw.Write("xmlns:cx7=\"http://schemas.microsoft.com/office/drawing/2016/5/13/chartex\" xmlns:cx8=\"http://schemas.microsoft.com/office/drawing/2016/5/14/chartex\" ");
			sw.Write("xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" ");
			sw.Write("xmlns:aink=\"http://schemas.microsoft.com/office/drawing/2016/ink\" xmlns:am3d=\"http://schemas.microsoft.com/office/drawing/2017/model3d\" ");
			sw.Write("xmlns:o=\"urn:schemas-microsoft-com:office:office\" ");
			sw.Write("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" xmlns:m=\"http://schemas.openxmlformats.org/officeDocument/2006/math\" ");
			sw.Write("xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:wp14=\"http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing\" xmlns:wp=\"http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing\" ");
			sw.Write("xmlns:w10=\"urn:schemas-microsoft-com:office:word\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" ");
			sw.Write("xmlns:w14=\"http://schemas.microsoft.com/office/word/2010/wordml\" xmlns:w15=\"http://schemas.microsoft.com/office/word/2012/wordml\" xmlns:w16cex=\"http://schemas.microsoft.com/office/word/2018/wordml/cex\" ");
			sw.Write("xmlns:w16cid=\"http://schemas.microsoft.com/office/word/2016/wordml/cid\" xmlns:w16=\"http://schemas.microsoft.com/office/word/2018/wordml\" xmlns:w16sdtdh=\"http://schemas.microsoft.com/office/word/2020/wordml/sdtdatahash\" ");
			sw.Write("xmlns:w16se=\"http://schemas.microsoft.com/office/word/2015/wordml/symex\" xmlns:wpg=\"http://schemas.microsoft.com/office/word/2010/wordprocessingGroup\" xmlns:wpi=\"http://schemas.microsoft.com/office/word/2010/wordprocessingInk\" ");
			sw.Write("xmlns:wne=\"http://schemas.microsoft.com/office/word/2006/wordml\" xmlns:wps=\"http://schemas.microsoft.com/office/word/2010/wordprocessingShape\" ");
			sw.Write("mc:Ignorable=\"w14 w15 w16se w16cid w16 w16cex w16sdtdh wp14\">");
			if (this.body != null)
			{
				this.body.Write(sw, "body");
			}
			if (base.background != null)
			{
				base.background.Write(sw, "background");
			}
			sw.Write("</w:document>");
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00009DE6 File Offset: 0x00007FE6
		public CT_Document()
		{
			this.bodyField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Body();
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00009DF9 File Offset: 0x00007FF9
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00009E01 File Offset: 0x00008001
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Body body
		{
			get
			{
				return this.bodyField;
			}
			set
			{
				this.bodyField = value;
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00009E0A File Offset: 0x0000800A
		public void AddNewBody()
		{
			this.bodyField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Body();
		}

		// Token: 0x040002DE RID: 734
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Body bodyField;
	}
}
