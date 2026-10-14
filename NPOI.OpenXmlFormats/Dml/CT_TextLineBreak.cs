using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000261 RID: 609
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextLineBreak
	{
		// Token: 0x060018B7 RID: 6327 RVA: 0x00044450 File Offset: 0x00042650
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak ct_TextLineBreak = new global::NPOI.OpenXmlFormats.Dml.CT_TextLineBreak();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rPr")
				{
					ct_TextLineBreak.rPr = global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TextLineBreak;
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000444D0 File Offset: 0x000426D0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}>", nodeName));
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0004450D File Offset: 0x0004270D
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x00044515 File Offset: 0x00042715
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rPr
		{
			get
			{
				return this.rPrField;
			}
			set
			{
				this.rPrField = value;
			}
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0004451E File Offset: 0x0004271E
		public global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties AddNewRPr()
		{
			this.rPr = new global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties();
			return this.rPr;
		}

		// Token: 0x040012D6 RID: 4822
		private global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rPrField;
	}
}
