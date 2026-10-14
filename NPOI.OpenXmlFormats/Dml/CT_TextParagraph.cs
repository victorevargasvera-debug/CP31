using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000263 RID: 611
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextParagraph
	{
		// Token: 0x060018C7 RID: 6343 RVA: 0x00044694 File Offset: 0x00042894
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph ct_TextParagraph = new global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph();
			ct_TextParagraph.r = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun>();
			ct_TextParagraph.br = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak>();
			ct_TextParagraph.fld = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextField>();
			ct_TextParagraph.items = new global::System.Collections.Generic.List<object>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pPr")
				{
					ct_TextParagraph.pPr = global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties.Parse(xmlNode, namespaceManager);
					ct_TextParagraph.items.Add(ct_TextParagraph.pPr);
				}
				else if (xmlNode.LocalName == "endParaRPr")
				{
					ct_TextParagraph.endParaRPr = global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties.Parse(xmlNode, namespaceManager);
					ct_TextParagraph.items.Add(ct_TextParagraph.endParaRPr);
				}
				else if (xmlNode.LocalName == "r")
				{
					global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun item = global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun.Parse(xmlNode, namespaceManager);
					ct_TextParagraph.r.Add(item);
					ct_TextParagraph.items.Add(item);
				}
				else if (xmlNode.LocalName == "br")
				{
					global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak item2 = global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak.Parse(xmlNode, namespaceManager);
					ct_TextParagraph.br.Add(item2);
					ct_TextParagraph.items.Add(item2);
				}
				else if (xmlNode.LocalName == "fld")
				{
					global::NPOI.OpenXmlFormats.Dml.CT_TextField item3 = global::NPOI.OpenXmlFormats.Dml.CT_TextField.Parse(xmlNode, namespaceManager);
					ct_TextParagraph.fld.Add(item3);
					ct_TextParagraph.items.Add(item3);
				}
			}
			return ct_TextParagraph;
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00044840 File Offset: 0x00042A40
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.pPr != null)
			{
				this.pPr.Write(sw, "pPr");
			}
			foreach (object obj in this.items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun)
				{
					(obj as global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun).Write(sw, "r");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak)
				{
					(obj as global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak).Write(sw, "br");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Dml.CT_TextField)
				{
					(obj as global::NPOI.OpenXmlFormats.Dml.CT_TextField).Write(sw, "fld");
				}
			}
			if (this.endParaRPr != null)
			{
				this.endParaRPr.Write(sw, "endParaRPr");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0004493C File Offset: 0x00042B3C
		// (set) Token: 0x060018CA RID: 6346 RVA: 0x00044944 File Offset: 0x00042B44
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<object> items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x00044950 File Offset: 0x00042B50
		public global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun AddNewR()
		{
			if (this.rField == null)
			{
				this.rField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun>();
			}
			global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun ct_RegularTextRun = new global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun();
			this.rField.Add(ct_RegularTextRun);
			this.itemsField.Add(ct_RegularTextRun);
			return ct_RegularTextRun;
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0004498F File Offset: 0x00042B8F
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties AddNewPPr()
		{
			this.pPrField = new global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties();
			return this.pPrField;
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x000449A2 File Offset: 0x00042BA2
		public global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties AddNewEndParaRPr()
		{
			this.endParaRPrField = new global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties();
			return this.endParaRPrField;
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x000449B5 File Offset: 0x00042BB5
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x000449BD File Offset: 0x00042BBD
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties pPr
		{
			get
			{
				return this.pPrField;
			}
			set
			{
				this.pPrField = value;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x000449C6 File Offset: 0x00042BC6
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x000449CE File Offset: 0x00042BCE
		[global::System.Xml.Serialization.XmlElement("r")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun> r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x000449D7 File Offset: 0x00042BD7
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x000449DF File Offset: 0x00042BDF
		[global::System.Xml.Serialization.XmlElement("br")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak> br
		{
			get
			{
				return this.brField;
			}
			set
			{
				this.brField = value;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x000449E8 File Offset: 0x00042BE8
		// (set) Token: 0x060018D5 RID: 6357 RVA: 0x000449F0 File Offset: 0x00042BF0
		[global::System.Xml.Serialization.XmlElement("fld")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextField> fld
		{
			get
			{
				return this.fldField;
			}
			set
			{
				this.fldField = value;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x000449F9 File Offset: 0x00042BF9
		// (set) Token: 0x060018D7 RID: 6359 RVA: 0x00044A01 File Offset: 0x00042C01
		public global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties endParaRPr
		{
			get
			{
				return this.endParaRPrField;
			}
			set
			{
				this.endParaRPrField = value;
			}
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00044A0A File Offset: 0x00042C0A
		public int SizeOfRArray()
		{
			return this.rField.Count;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00044A17 File Offset: 0x00042C17
		public bool IsSetPPr()
		{
			return this.pPrField != null;
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00044A24 File Offset: 0x00042C24
		public global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak AddNewBr()
		{
			global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak ct_TextLineBreak = new global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak();
			this.brField.Add(ct_TextLineBreak);
			this.itemsField.Add(ct_TextLineBreak);
			return ct_TextLineBreak;
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00044A50 File Offset: 0x00042C50
		public global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun GetRArray(int v)
		{
			return this.rField[v];
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00044A5E File Offset: 0x00042C5E
		public int SizeOfFldArray()
		{
			return this.fldField.Count;
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00044A6B File Offset: 0x00042C6B
		public global::NPOI.OpenXmlFormats.Dml.CT_TextField GetFldArray(int v)
		{
			return this.fldField[v];
		}

		// Token: 0x040012D9 RID: 4825
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties pPrField;

		// Token: 0x040012DA RID: 4826
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun> rField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun>();

		// Token: 0x040012DB RID: 4827
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak> brField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak>();

		// Token: 0x040012DC RID: 4828
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextField> fldField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TextField>();

		// Token: 0x040012DD RID: 4829
		private global::System.Collections.Generic.List<object> itemsField = new global::System.Collections.Generic.List<object>();

		// Token: 0x040012DE RID: 4830
		private global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties endParaRPrField;
	}
}
