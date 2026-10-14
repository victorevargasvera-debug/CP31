using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000272 RID: 626
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RegularTextRun
	{
		// Token: 0x06001990 RID: 6544 RVA: 0x00045C9C File Offset: 0x00043E9C
		public static global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun ct_RegularTextRun = new global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rPr")
				{
					ct_RegularTextRun.rPr = global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "t")
				{
					ct_RegularTextRun.t = xmlNode.InnerText;
				}
			}
			return ct_RegularTextRun;
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00045D3C File Offset: 0x00043F3C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			if (this.t != null)
			{
				sw.Write("<a:t>");
				sw.Write(global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.t));
				sw.Write("</a:t>");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00045DBE File Offset: 0x00043FBE
		public global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties AddNewRPr()
		{
			this.rPrField = new global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties();
			return this.rPrField;
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x00045DD1 File Offset: 0x00043FD1
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x00045DD9 File Offset: 0x00043FD9
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

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x00045DE2 File Offset: 0x00043FE2
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x00045DEA File Offset: 0x00043FEA
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public string t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00045DF3 File Offset: 0x00043FF3
		public bool IsSetRPr()
		{
			return this.rPrField != null;
		}

		// Token: 0x0400134D RID: 4941
		private global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rPrField;

		// Token: 0x0400134E RID: 4942
		private string tField;
	}
}
