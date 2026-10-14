using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x02000352 RID: 850
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PosH
	{
		// Token: 0x060021C1 RID: 8641 RVA: 0x000588C8 File Offset: 0x00056AC8
		public static global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PosH Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PosH ct_PosH = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PosH();
			if (node.Attributes["relativeFrom"] != null)
			{
				ct_PosH.relativeFrom = (global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_RelFromH)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_RelFromH), node.Attributes["relativeFrom"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "posOffset")
				{
					int value;
					ct_PosH.posOffset = (int.TryParse(xmlNode.InnerText, out value) ? new int?(value) : null);
				}
				else if (xmlNode.LocalName == "align")
				{
					ct_PosH.align = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_AlignH?((global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_AlignH)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_AlignH), xmlNode.InnerText));
				}
			}
			return ct_PosH;
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x000589E0 File Offset: 0x00056BE0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<wp:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "relativeFrom", this.relativeFrom.ToString());
			sw.Write(">");
			if (this.posOffset != null)
			{
				sw.Write(string.Format("<wp:posOffset>{0}</wp:posOffset>", this.posOffset.Value));
			}
			if (this.align != null)
			{
				sw.Write(string.Format("<wp:align>{0}</wp:align>", this.align.Value));
			}
			sw.Write(string.Format("</wp:{0}>", nodeName));
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x00058A9F File Offset: 0x00056C9F
		// (set) Token: 0x060021C4 RID: 8644 RVA: 0x00058AA7 File Offset: 0x00056CA7
		public int? posOffset
		{
			get
			{
				return this.posOffsetField;
			}
			set
			{
				this.posOffsetField = value;
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x00058AB0 File Offset: 0x00056CB0
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x00058AB8 File Offset: 0x00056CB8
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_AlignH? align
		{
			get
			{
				return this.alignField;
			}
			set
			{
				this.alignField = value;
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x00058AC1 File Offset: 0x00056CC1
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x00058AC9 File Offset: 0x00056CC9
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_RelFromH relativeFrom
		{
			get
			{
				return this.relativeFromField;
			}
			set
			{
				this.relativeFromField = value;
			}
		}

		// Token: 0x040019B9 RID: 6585
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_RelFromH relativeFromField;

		// Token: 0x040019BA RID: 6586
		private int? posOffsetField;

		// Token: 0x040019BB RID: 6587
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.ST_AlignH? alignField;
	}
}
