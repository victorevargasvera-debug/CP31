using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000267 RID: 615
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextField
	{
		// Token: 0x0600195B RID: 6491 RVA: 0x000456E4 File Offset: 0x000438E4
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextField Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextField ct_TextField = new global::NPOI.OpenXmlFormats.Dml.CT_TextField();
			ct_TextField.t = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["t"]);
			ct_TextField.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"]);
			ct_TextField.type = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["type"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rPr")
				{
					ct_TextField.rPr = global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pPr")
				{
					ct_TextField.pPr = global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TextField;
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x000457D4 File Offset: 0x000439D4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "t", this.t);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type);
			sw.Write(">");
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			if (this.pPr != null)
			{
				this.pPr.Write(sw, "pPr");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x00045873 File Offset: 0x00043A73
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x0004587B File Offset: 0x00043A7B
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

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x00045884 File Offset: 0x00043A84
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x0004588C File Offset: 0x00043A8C
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00045895 File Offset: 0x00043A95
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x0004589D File Offset: 0x00043A9D
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x000458A6 File Offset: 0x00043AA6
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x000458AE File Offset: 0x00043AAE
		[global::System.Xml.Serialization.XmlAttribute(DataType = "token")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x000458B7 File Offset: 0x00043AB7
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x000458BF File Offset: 0x00043ABF
		[global::System.Xml.Serialization.XmlAttribute]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x04001314 RID: 4884
		private global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rPrField;

		// Token: 0x04001315 RID: 4885
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties pPrField;

		// Token: 0x04001316 RID: 4886
		private string tField;

		// Token: 0x04001317 RID: 4887
		private string idField;

		// Token: 0x04001318 RID: 4888
		private string typeField;
	}
}
